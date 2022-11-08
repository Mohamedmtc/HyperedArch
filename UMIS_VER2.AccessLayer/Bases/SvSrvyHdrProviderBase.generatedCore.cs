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
	/// This class is the base class for any <see cref="SvSrvyHdrProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvSrvyHdrProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvSrvyHdr, UMIS_VER2.BusinessLyer.SvSrvyHdrKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvSrvyHdrKey key)
		{
			return Delete(transactionManager, key.SvSrvyHdrId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svSrvyHdrId">Dynamic question Template. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _svSrvyHdrId)
		{
			return Delete(null, _svSrvyHdrId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyHdrId">Dynamic question Template. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _svSrvyHdrId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_HDR_ED_ACAD_YEAR key.
		///		FK_SV_SRVY_HDR_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId">For Exam</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyHdr objects.</returns>
		public TList<SvSrvyHdr> GetByEdAcadYearId(System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_HDR_ED_ACAD_YEAR key.
		///		FK_SV_SRVY_HDR_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">For Exam</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyHdr objects.</returns>
		/// <remarks></remarks>
		public TList<SvSrvyHdr> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_HDR_ED_ACAD_YEAR key.
		///		FK_SV_SRVY_HDR_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">For Exam</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyHdr objects.</returns>
		public TList<SvSrvyHdr> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_HDR_ED_ACAD_YEAR key.
		///		fkSvSrvyHdrEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">For Exam</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyHdr objects.</returns>
		public TList<SvSrvyHdr> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_HDR_ED_ACAD_YEAR key.
		///		fkSvSrvyHdrEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">For Exam</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyHdr objects.</returns>
		public TList<SvSrvyHdr> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_HDR_ED_ACAD_YEAR key.
		///		FK_SV_SRVY_HDR_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">For Exam</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyHdr objects.</returns>
		public abstract TList<SvSrvyHdr> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_HDR_ED_CODE_SEMESTER key.
		///		FK_SV_SRVY_HDR_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId">For Exam الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyHdr objects.</returns>
		public TList<SvSrvyHdr> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_HDR_ED_CODE_SEMESTER key.
		///		FK_SV_SRVY_HDR_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">For Exam الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyHdr objects.</returns>
		/// <remarks></remarks>
		public TList<SvSrvyHdr> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_HDR_ED_CODE_SEMESTER key.
		///		FK_SV_SRVY_HDR_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">For Exam الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyHdr objects.</returns>
		public TList<SvSrvyHdr> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_HDR_ED_CODE_SEMESTER key.
		///		fkSvSrvyHdrEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">For Exam الفصل الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyHdr objects.</returns>
		public TList<SvSrvyHdr> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_HDR_ED_CODE_SEMESTER key.
		///		fkSvSrvyHdrEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">For Exam الفصل الدراسي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyHdr objects.</returns>
		public TList<SvSrvyHdr> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_HDR_ED_CODE_SEMESTER key.
		///		FK_SV_SRVY_HDR_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">For Exam الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyHdr objects.</returns>
		public abstract TList<SvSrvyHdr> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_HDR_SE_USER key.
		///		FK_SV_SRVY_HDR_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyHdr objects.</returns>
		public TList<SvSrvyHdr> GetBySeUserId(System.Decimal _seUserId)
		{
			int count = -1;
			return GetBySeUserId(_seUserId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_HDR_SE_USER key.
		///		FK_SV_SRVY_HDR_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyHdr objects.</returns>
		/// <remarks></remarks>
		public TList<SvSrvyHdr> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_HDR_SE_USER key.
		///		FK_SV_SRVY_HDR_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyHdr objects.</returns>
		public TList<SvSrvyHdr> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_HDR_SE_USER key.
		///		fkSvSrvyHdrSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyHdr objects.</returns>
		public TList<SvSrvyHdr> GetBySeUserId(System.Decimal _seUserId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserId(null, _seUserId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_HDR_SE_USER key.
		///		fkSvSrvyHdrSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyHdr objects.</returns>
		public TList<SvSrvyHdr> GetBySeUserId(System.Decimal _seUserId, int start, int pageLength,out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_HDR_SE_USER key.
		///		FK_SV_SRVY_HDR_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyHdr objects.</returns>
		public abstract TList<SvSrvyHdr> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_HDR_SV_CDE_SRVY_TYPE key.
		///		FK_SV_SRVY_HDR_SV_CDE_SRVY_TYPE Description: 
		/// </summary>
		/// <param name="_svCdeSrvyTypeId">1 Exam - 2 Survey</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyHdr objects.</returns>
		public TList<SvSrvyHdr> GetBySvCdeSrvyTypeId(System.Int32 _svCdeSrvyTypeId)
		{
			int count = -1;
			return GetBySvCdeSrvyTypeId(_svCdeSrvyTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_HDR_SV_CDE_SRVY_TYPE key.
		///		FK_SV_SRVY_HDR_SV_CDE_SRVY_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeSrvyTypeId">1 Exam - 2 Survey</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyHdr objects.</returns>
		/// <remarks></remarks>
		public TList<SvSrvyHdr> GetBySvCdeSrvyTypeId(TransactionManager transactionManager, System.Int32 _svCdeSrvyTypeId)
		{
			int count = -1;
			return GetBySvCdeSrvyTypeId(transactionManager, _svCdeSrvyTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_HDR_SV_CDE_SRVY_TYPE key.
		///		FK_SV_SRVY_HDR_SV_CDE_SRVY_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeSrvyTypeId">1 Exam - 2 Survey</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyHdr objects.</returns>
		public TList<SvSrvyHdr> GetBySvCdeSrvyTypeId(TransactionManager transactionManager, System.Int32 _svCdeSrvyTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeSrvyTypeId(transactionManager, _svCdeSrvyTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_HDR_SV_CDE_SRVY_TYPE key.
		///		fkSvSrvyHdrSvCdeSrvyType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCdeSrvyTypeId">1 Exam - 2 Survey</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyHdr objects.</returns>
		public TList<SvSrvyHdr> GetBySvCdeSrvyTypeId(System.Int32 _svCdeSrvyTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySvCdeSrvyTypeId(null, _svCdeSrvyTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_HDR_SV_CDE_SRVY_TYPE key.
		///		fkSvSrvyHdrSvCdeSrvyType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCdeSrvyTypeId">1 Exam - 2 Survey</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyHdr objects.</returns>
		public TList<SvSrvyHdr> GetBySvCdeSrvyTypeId(System.Int32 _svCdeSrvyTypeId, int start, int pageLength,out int count)
		{
			return GetBySvCdeSrvyTypeId(null, _svCdeSrvyTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_HDR_SV_CDE_SRVY_TYPE key.
		///		FK_SV_SRVY_HDR_SV_CDE_SRVY_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeSrvyTypeId">1 Exam - 2 Survey</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyHdr objects.</returns>
		public abstract TList<SvSrvyHdr> GetBySvCdeSrvyTypeId(TransactionManager transactionManager, System.Int32 _svCdeSrvyTypeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SvSrvyHdr Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvSrvyHdrKey key, int start, int pageLength)
		{
			return GetBySvSrvyHdrId(transactionManager, key.SvSrvyHdrId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_SRVY_HDR index.
		/// </summary>
		/// <param name="_svSrvyHdrId">Dynamic question Template</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyHdr GetBySvSrvyHdrId(System.Int32 _svSrvyHdrId)
		{
			int count = -1;
			return GetBySvSrvyHdrId(null,_svSrvyHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_SRVY_HDR index.
		/// </summary>
		/// <param name="_svSrvyHdrId">Dynamic question Template</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyHdr GetBySvSrvyHdrId(System.Int32 _svSrvyHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvSrvyHdrId(null, _svSrvyHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_SRVY_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyHdrId">Dynamic question Template</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyHdr GetBySvSrvyHdrId(TransactionManager transactionManager, System.Int32 _svSrvyHdrId)
		{
			int count = -1;
			return GetBySvSrvyHdrId(transactionManager, _svSrvyHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_SRVY_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyHdrId">Dynamic question Template</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyHdr GetBySvSrvyHdrId(TransactionManager transactionManager, System.Int32 _svSrvyHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvSrvyHdrId(transactionManager, _svSrvyHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_SRVY_HDR index.
		/// </summary>
		/// <param name="_svSrvyHdrId">Dynamic question Template</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyHdr GetBySvSrvyHdrId(System.Int32 _svSrvyHdrId, int start, int pageLength, out int count)
		{
			return GetBySvSrvyHdrId(null, _svSrvyHdrId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_SRVY_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyHdrId">Dynamic question Template</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyHdr"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvSrvyHdr GetBySvSrvyHdrId(TransactionManager transactionManager, System.Int32 _svSrvyHdrId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvSrvyHdr&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvSrvyHdr&gt;"/></returns>
		public static TList<SvSrvyHdr> Fill(IDataReader reader, TList<SvSrvyHdr> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvSrvyHdr c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvSrvyHdr")
					.Append("|").Append((System.Int32)reader["SV_SRVY_HDR_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvSrvyHdr>(
					key.ToString(), // EntityTrackingKey
					"SvSrvyHdr",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvSrvyHdr();
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
					c.SvSrvyHdrId = (System.Int32)reader["SV_SRVY_HDR_ID"];
					c.OriginalSvSrvyHdrId = c.SvSrvyHdrId;
					c.SrvyTitleAr = (System.String)reader["SRVY_TITLE_AR"];
					c.SrvyTitleEn = (System.String)reader["SRVY_TITLE_EN"];
					c.SrvyDate = (System.DateTime)reader["SRVY_DATE"];
					c.SrvyBodyAr = (System.String)reader["SRVY_BODY_AR"];
					c.SrvyBodyEn = (System.String)reader["SRVY_BODY_EN"];
					c.SeUserId = (System.Decimal)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.SvCdeSrvyTypeId = (System.Int32)reader["SV_CDE_SRVY_TYPE_ID"];
					c.TempltFlg = Convert.IsDBNull(reader["TEMPLT_FLG"]) ? null : (System.Boolean?)reader["TEMPLT_FLG"];
					c.TotMark = Convert.IsDBNull(reader["TOT_MARK"]) ? null : (System.Int32?)reader["TOT_MARK"];
					c.EdAcadYearId = Convert.IsDBNull(reader["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_ID"];
					c.SaveAllFlg = Convert.IsDBNull(reader["SAVE_ALL_FLG"]) ? null : (System.Int32?)reader["SAVE_ALL_FLG"];
					c.RstrctdTimeFlg = Convert.IsDBNull(reader["RSTRCTD_TIME_FLG"]) ? null : (System.Boolean?)reader["RSTRCTD_TIME_FLG"];
					c.RsltGrdngTypeFlg = Convert.IsDBNull(reader["RSLT_GRDNG_TYPE_FLG"]) ? null : (System.Int32?)reader["RSLT_GRDNG_TYPE_FLG"];
					c.AnswrBulletFlg = Convert.IsDBNull(reader["ANSWR_BULLET_FLG"]) ? null : (System.Int32?)reader["ANSWR_BULLET_FLG"];
					c.TimeFrom = Convert.IsDBNull(reader["TIME_FROM"]) ? null : (System.TimeSpan?)reader["TIME_FROM"];
					c.TimeTo = Convert.IsDBNull(reader["TIME_TO"]) ? null : (System.TimeSpan?)reader["TIME_TO"];
					c.ApproveFlg = Convert.IsDBNull(reader["APPROVE_FLG"]) ? null : (System.Int32?)reader["APPROVE_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvSrvyHdr"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvSrvyHdr"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvSrvyHdr entity)
		{
			if (!reader.Read()) return;
			
			entity.SvSrvyHdrId = (System.Int32)reader[((int)SvSrvyHdrColumn.SvSrvyHdrId - 1)];
			entity.OriginalSvSrvyHdrId = (System.Int32)reader["SV_SRVY_HDR_ID"];
			entity.SrvyTitleAr = (System.String)reader[((int)SvSrvyHdrColumn.SrvyTitleAr - 1)];
			entity.SrvyTitleEn = (System.String)reader[((int)SvSrvyHdrColumn.SrvyTitleEn - 1)];
			entity.SrvyDate = (System.DateTime)reader[((int)SvSrvyHdrColumn.SrvyDate - 1)];
			entity.SrvyBodyAr = (System.String)reader[((int)SvSrvyHdrColumn.SrvyBodyAr - 1)];
			entity.SrvyBodyEn = (System.String)reader[((int)SvSrvyHdrColumn.SrvyBodyEn - 1)];
			entity.SeUserId = (System.Decimal)reader[((int)SvSrvyHdrColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)SvSrvyHdrColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)SvSrvyHdrColumn.LastDate - 1)];
			entity.SvCdeSrvyTypeId = (System.Int32)reader[((int)SvSrvyHdrColumn.SvCdeSrvyTypeId - 1)];
			entity.TempltFlg = (reader.IsDBNull(((int)SvSrvyHdrColumn.TempltFlg - 1)))?null:(System.Boolean?)reader[((int)SvSrvyHdrColumn.TempltFlg - 1)];
			entity.TotMark = (reader.IsDBNull(((int)SvSrvyHdrColumn.TotMark - 1)))?null:(System.Int32?)reader[((int)SvSrvyHdrColumn.TotMark - 1)];
			entity.EdAcadYearId = (reader.IsDBNull(((int)SvSrvyHdrColumn.EdAcadYearId - 1)))?null:(System.Decimal?)reader[((int)SvSrvyHdrColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (reader.IsDBNull(((int)SvSrvyHdrColumn.EdCodeSemesterId - 1)))?null:(System.Decimal?)reader[((int)SvSrvyHdrColumn.EdCodeSemesterId - 1)];
			entity.SaveAllFlg = (reader.IsDBNull(((int)SvSrvyHdrColumn.SaveAllFlg - 1)))?null:(System.Int32?)reader[((int)SvSrvyHdrColumn.SaveAllFlg - 1)];
			entity.RstrctdTimeFlg = (reader.IsDBNull(((int)SvSrvyHdrColumn.RstrctdTimeFlg - 1)))?null:(System.Boolean?)reader[((int)SvSrvyHdrColumn.RstrctdTimeFlg - 1)];
			entity.RsltGrdngTypeFlg = (reader.IsDBNull(((int)SvSrvyHdrColumn.RsltGrdngTypeFlg - 1)))?null:(System.Int32?)reader[((int)SvSrvyHdrColumn.RsltGrdngTypeFlg - 1)];
			entity.AnswrBulletFlg = (reader.IsDBNull(((int)SvSrvyHdrColumn.AnswrBulletFlg - 1)))?null:(System.Int32?)reader[((int)SvSrvyHdrColumn.AnswrBulletFlg - 1)];
			entity.TimeFrom = (reader.IsDBNull(((int)SvSrvyHdrColumn.TimeFrom - 1)))?null:(System.TimeSpan?)reader[((int)SvSrvyHdrColumn.TimeFrom - 1)];
			entity.TimeTo = (reader.IsDBNull(((int)SvSrvyHdrColumn.TimeTo - 1)))?null:(System.TimeSpan?)reader[((int)SvSrvyHdrColumn.TimeTo - 1)];
			entity.ApproveFlg = (reader.IsDBNull(((int)SvSrvyHdrColumn.ApproveFlg - 1)))?null:(System.Int32?)reader[((int)SvSrvyHdrColumn.ApproveFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvSrvyHdr"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvSrvyHdr"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvSrvyHdr entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvSrvyHdrId = (System.Int32)dataRow["SV_SRVY_HDR_ID"];
			entity.OriginalSvSrvyHdrId = (System.Int32)dataRow["SV_SRVY_HDR_ID"];
			entity.SrvyTitleAr = (System.String)dataRow["SRVY_TITLE_AR"];
			entity.SrvyTitleEn = (System.String)dataRow["SRVY_TITLE_EN"];
			entity.SrvyDate = (System.DateTime)dataRow["SRVY_DATE"];
			entity.SrvyBodyAr = (System.String)dataRow["SRVY_BODY_AR"];
			entity.SrvyBodyEn = (System.String)dataRow["SRVY_BODY_EN"];
			entity.SeUserId = (System.Decimal)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.SvCdeSrvyTypeId = (System.Int32)dataRow["SV_CDE_SRVY_TYPE_ID"];
			entity.TempltFlg = Convert.IsDBNull(dataRow["TEMPLT_FLG"]) ? null : (System.Boolean?)dataRow["TEMPLT_FLG"];
			entity.TotMark = Convert.IsDBNull(dataRow["TOT_MARK"]) ? null : (System.Int32?)dataRow["TOT_MARK"];
			entity.EdAcadYearId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_ID"];
			entity.SaveAllFlg = Convert.IsDBNull(dataRow["SAVE_ALL_FLG"]) ? null : (System.Int32?)dataRow["SAVE_ALL_FLG"];
			entity.RstrctdTimeFlg = Convert.IsDBNull(dataRow["RSTRCTD_TIME_FLG"]) ? null : (System.Boolean?)dataRow["RSTRCTD_TIME_FLG"];
			entity.RsltGrdngTypeFlg = Convert.IsDBNull(dataRow["RSLT_GRDNG_TYPE_FLG"]) ? null : (System.Int32?)dataRow["RSLT_GRDNG_TYPE_FLG"];
			entity.AnswrBulletFlg = Convert.IsDBNull(dataRow["ANSWR_BULLET_FLG"]) ? null : (System.Int32?)dataRow["ANSWR_BULLET_FLG"];
			entity.TimeFrom = Convert.IsDBNull(dataRow["TIME_FROM"]) ? null : (System.TimeSpan?)dataRow["TIME_FROM"];
			entity.TimeTo = Convert.IsDBNull(dataRow["TIME_TO"]) ? null : (System.TimeSpan?)dataRow["TIME_TO"];
			entity.ApproveFlg = Convert.IsDBNull(dataRow["APPROVE_FLG"]) ? null : (System.Int32?)dataRow["APPROVE_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvSrvyHdr"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvSrvyHdr Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvSrvyHdr entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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

			#region SeUserIdSource	
			if (CanDeepLoad(entity, "SeUser|SeUserIdSource", deepLoadType, innerList) 
				&& entity.SeUserIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SeUserId;
				SeUser tmpEntity = EntityManager.LocateEntity<SeUser>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUser), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeUserIdSource = tmpEntity;
				else
					entity.SeUserIdSource = DataRepository.SeUserProvider.GetBySeUserId(transactionManager, entity.SeUserId);		
				
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

			#region SvCdeSrvyTypeIdSource	
			if (CanDeepLoad(entity, "SvCdeSrvyType|SvCdeSrvyTypeIdSource", deepLoadType, innerList) 
				&& entity.SvCdeSrvyTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SvCdeSrvyTypeId;
				SvCdeSrvyType tmpEntity = EntityManager.LocateEntity<SvCdeSrvyType>(EntityLocator.ConstructKeyFromPkItems(typeof(SvCdeSrvyType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvCdeSrvyTypeIdSource = tmpEntity;
				else
					entity.SvCdeSrvyTypeIdSource = DataRepository.SvCdeSrvyTypeProvider.GetBySvCdeSrvyTypeId(transactionManager, entity.SvCdeSrvyTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCdeSrvyTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvCdeSrvyTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvCdeSrvyTypeProvider.DeepLoad(transactionManager, entity.SvCdeSrvyTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvCdeSrvyTypeIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySvSrvyHdrId methods when available
			
			#region SvSrvyQstnCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvSrvyQstn>|SvSrvyQstnCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvSrvyQstnCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvSrvyQstnCollection = DataRepository.SvSrvyQstnProvider.GetBySvSrvyHdrId(transactionManager, entity.SvSrvyHdrId);

				if (deep && entity.SvSrvyQstnCollection.Count > 0)
				{
					deepHandles.Add("SvSrvyQstnCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvSrvyQstn>) DataRepository.SvSrvyQstnProvider.DeepLoad,
						new object[] { transactionManager, entity.SvSrvyQstnCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.AdmPlaceExamDatetimeCollection = DataRepository.AdmPlaceExamDatetimeProvider.GetBySvSrvyHdrId(transactionManager, entity.SvSrvyHdrId);

				if (deep && entity.AdmPlaceExamDatetimeCollection.Count > 0)
				{
					deepHandles.Add("AdmPlaceExamDatetimeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmPlaceExamDatetime>) DataRepository.AdmPlaceExamDatetimeProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmPlaceExamDatetimeCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvSrvyHdr object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvSrvyHdr instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvSrvyHdr Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvSrvyHdr entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdCodeSemesterIdSource
			if (CanDeepSave(entity, "EdCodeSemester|EdCodeSemesterIdSource", deepSaveType, innerList) 
				&& entity.EdCodeSemesterIdSource != null)
			{
				DataRepository.EdCodeSemesterProvider.Save(transactionManager, entity.EdCodeSemesterIdSource);
				entity.EdCodeSemesterId = entity.EdCodeSemesterIdSource.EdCodeSemesterId;
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
			
			#region SvCdeSrvyTypeIdSource
			if (CanDeepSave(entity, "SvCdeSrvyType|SvCdeSrvyTypeIdSource", deepSaveType, innerList) 
				&& entity.SvCdeSrvyTypeIdSource != null)
			{
				DataRepository.SvCdeSrvyTypeProvider.Save(transactionManager, entity.SvCdeSrvyTypeIdSource);
				entity.SvCdeSrvyTypeId = entity.SvCdeSrvyTypeIdSource.SvCdeSrvyTypeId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SvSrvyQstn>
				if (CanDeepSave(entity.SvSrvyQstnCollection, "List<SvSrvyQstn>|SvSrvyQstnCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvSrvyQstn child in entity.SvSrvyQstnCollection)
					{
						if(child.SvSrvyHdrIdSource != null)
						{
							child.SvSrvyHdrId = child.SvSrvyHdrIdSource.SvSrvyHdrId;
						}
						else
						{
							child.SvSrvyHdrId = entity.SvSrvyHdrId;
						}

					}

					if (entity.SvSrvyQstnCollection.Count > 0 || entity.SvSrvyQstnCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvSrvyQstnProvider.Save(transactionManager, entity.SvSrvyQstnCollection);
						
						deepHandles.Add("SvSrvyQstnCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvSrvyQstn >) DataRepository.SvSrvyQstnProvider.DeepSave,
							new object[] { transactionManager, entity.SvSrvyQstnCollection, deepSaveType, childTypes, innerList }
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
						if(child.SvSrvyHdrIdSource != null)
						{
							child.SvSrvyHdrId = child.SvSrvyHdrIdSource.SvSrvyHdrId;
						}
						else
						{
							child.SvSrvyHdrId = entity.SvSrvyHdrId;
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
	
	#region SvSrvyHdrChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvSrvyHdr</c>
	///</summary>
	public enum SvSrvyHdrChildEntityTypes
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
		/// Composite Property for <c>SeUser</c> at SeUserIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
		
		///<summary>
		/// Composite Property for <c>SvCdeSrvyType</c> at SvCdeSrvyTypeIdSource
		///</summary>
		[ChildEntityType(typeof(SvCdeSrvyType))]
		SvCdeSrvyType,
		///<summary>
		/// Collection of <c>SvSrvyHdr</c> as OneToMany for SvSrvyQstnCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvSrvyQstn>))]
		SvSrvyQstnCollection,
		///<summary>
		/// Collection of <c>SvSrvyHdr</c> as OneToMany for AdmPlaceExamDatetimeCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmPlaceExamDatetime>))]
		AdmPlaceExamDatetimeCollection,
	}
	
	#endregion SvSrvyHdrChildEntityTypes
	
	#region SvSrvyHdrFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvSrvyHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvSrvyHdr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvSrvyHdrFilterBuilder : SqlFilterBuilder<SvSrvyHdrColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvSrvyHdrFilterBuilder class.
		/// </summary>
		public SvSrvyHdrFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvSrvyHdrFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvSrvyHdrFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvSrvyHdrFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvSrvyHdrFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvSrvyHdrFilterBuilder
	
	#region SvSrvyHdrParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvSrvyHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvSrvyHdr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvSrvyHdrParameterBuilder : ParameterizedSqlFilterBuilder<SvSrvyHdrColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvSrvyHdrParameterBuilder class.
		/// </summary>
		public SvSrvyHdrParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvSrvyHdrParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvSrvyHdrParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvSrvyHdrParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvSrvyHdrParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvSrvyHdrParameterBuilder
	
	#region SvSrvyHdrSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvSrvyHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvSrvyHdr"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvSrvyHdrSortBuilder : SqlSortBuilder<SvSrvyHdrColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvSrvyHdrSqlSortBuilder class.
		/// </summary>
		public SvSrvyHdrSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvSrvyHdrSortBuilder
	
} // end namespace
