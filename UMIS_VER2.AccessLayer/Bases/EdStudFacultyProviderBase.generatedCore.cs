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
	/// This class is the base class for any <see cref="EdStudFacultyProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudFacultyProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudFaculty, UMIS_VER2.BusinessLyer.EdStudFacultyKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudFacultyKey key)
		{
			return Delete(transactionManager, key.EdStudFacultyId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudFacultyId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudFacultyId)
		{
			return Delete(null, _edStudFacultyId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudFacultyId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudFacultyId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ADM_CDE_APP_TYPE key.
		///		FK_ED_STUD_FACULTY_ADM_CDE_APP_TYPE Description: 
		/// </summary>
		/// <param name="_admCdeAppTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByAdmCdeAppTypeId(System.Decimal? _admCdeAppTypeId)
		{
			int count = -1;
			return GetByAdmCdeAppTypeId(_admCdeAppTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ADM_CDE_APP_TYPE key.
		///		FK_ED_STUD_FACULTY_ADM_CDE_APP_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudFaculty> GetByAdmCdeAppTypeId(TransactionManager transactionManager, System.Decimal? _admCdeAppTypeId)
		{
			int count = -1;
			return GetByAdmCdeAppTypeId(transactionManager, _admCdeAppTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ADM_CDE_APP_TYPE key.
		///		FK_ED_STUD_FACULTY_ADM_CDE_APP_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByAdmCdeAppTypeId(TransactionManager transactionManager, System.Decimal? _admCdeAppTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeAppTypeId(transactionManager, _admCdeAppTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ADM_CDE_APP_TYPE key.
		///		fkEdStudFacultyAdmCdeAppType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByAdmCdeAppTypeId(System.Decimal? _admCdeAppTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCdeAppTypeId(null, _admCdeAppTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ADM_CDE_APP_TYPE key.
		///		fkEdStudFacultyAdmCdeAppType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByAdmCdeAppTypeId(System.Decimal? _admCdeAppTypeId, int start, int pageLength,out int count)
		{
			return GetByAdmCdeAppTypeId(null, _admCdeAppTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ADM_CDE_APP_TYPE key.
		///		FK_ED_STUD_FACULTY_ADM_CDE_APP_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public abstract TList<EdStudFaculty> GetByAdmCdeAppTypeId(TransactionManager transactionManager, System.Decimal? _admCdeAppTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ADM_CODE_TRANSFER_TYPE key.
		///		FK_ED_STUD_FACULTY_ADM_CODE_TRANSFER_TYPE Description: 
		/// </summary>
		/// <param name="_admCodeTransferTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByAdmCodeTransferTypeId(System.Decimal? _admCodeTransferTypeId)
		{
			int count = -1;
			return GetByAdmCodeTransferTypeId(_admCodeTransferTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ADM_CODE_TRANSFER_TYPE key.
		///		FK_ED_STUD_FACULTY_ADM_CODE_TRANSFER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCodeTransferTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudFaculty> GetByAdmCodeTransferTypeId(TransactionManager transactionManager, System.Decimal? _admCodeTransferTypeId)
		{
			int count = -1;
			return GetByAdmCodeTransferTypeId(transactionManager, _admCodeTransferTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ADM_CODE_TRANSFER_TYPE key.
		///		FK_ED_STUD_FACULTY_ADM_CODE_TRANSFER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCodeTransferTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByAdmCodeTransferTypeId(TransactionManager transactionManager, System.Decimal? _admCodeTransferTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCodeTransferTypeId(transactionManager, _admCodeTransferTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ADM_CODE_TRANSFER_TYPE key.
		///		fkEdStudFacultyAdmCodeTransferType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCodeTransferTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByAdmCodeTransferTypeId(System.Decimal? _admCodeTransferTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCodeTransferTypeId(null, _admCodeTransferTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ADM_CODE_TRANSFER_TYPE key.
		///		fkEdStudFacultyAdmCodeTransferType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCodeTransferTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByAdmCodeTransferTypeId(System.Decimal? _admCodeTransferTypeId, int start, int pageLength,out int count)
		{
			return GetByAdmCodeTransferTypeId(null, _admCodeTransferTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ADM_CODE_TRANSFER_TYPE key.
		///		FK_ED_STUD_FACULTY_ADM_CODE_TRANSFER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCodeTransferTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public abstract TList<EdStudFaculty> GetByAdmCodeTransferTypeId(TransactionManager transactionManager, System.Decimal? _admCodeTransferTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_AS_CODE_DEGREE key.
		///		FK_ED_STUD_FACULTY_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="_asCodeDegreeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByAsCodeDegreeId(System.Decimal _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(_asCodeDegreeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_AS_CODE_DEGREE key.
		///		FK_ED_STUD_FACULTY_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudFaculty> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_AS_CODE_DEGREE key.
		///		FK_ED_STUD_FACULTY_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal _asCodeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_AS_CODE_DEGREE key.
		///		fkEdStudFacultyAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByAsCodeDegreeId(System.Decimal _asCodeDegreeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_AS_CODE_DEGREE key.
		///		fkEdStudFacultyAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByAsCodeDegreeId(System.Decimal _asCodeDegreeId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_AS_CODE_DEGREE key.
		///		FK_ED_STUD_FACULTY_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public abstract TList<EdStudFaculty> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal _asCodeDegreeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ED_BYLAW key.
		///		FK_ED_STUD_FACULTY_ED_BYLAW Description: 
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEdBylawId(System.Decimal? _edBylawId)
		{
			int count = -1;
			return GetByEdBylawId(_edBylawId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ED_BYLAW key.
		///		FK_ED_STUD_FACULTY_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudFaculty> GetByEdBylawId(TransactionManager transactionManager, System.Decimal? _edBylawId)
		{
			int count = -1;
			return GetByEdBylawId(transactionManager, _edBylawId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ED_BYLAW key.
		///		FK_ED_STUD_FACULTY_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEdBylawId(TransactionManager transactionManager, System.Decimal? _edBylawId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBylawId(transactionManager, _edBylawId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ED_BYLAW key.
		///		fkEdStudFacultyEdBylaw Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edBylawId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEdBylawId(System.Decimal? _edBylawId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdBylawId(null, _edBylawId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ED_BYLAW key.
		///		fkEdStudFacultyEdBylaw Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edBylawId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEdBylawId(System.Decimal? _edBylawId, int start, int pageLength,out int count)
		{
			return GetByEdBylawId(null, _edBylawId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ED_BYLAW key.
		///		FK_ED_STUD_FACULTY_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public abstract TList<EdStudFaculty> GetByEdBylawId(TransactionManager transactionManager, System.Decimal? _edBylawId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ED_CDE_QUAL_PHASE key.
		///		FK_ED_STUD_FACULTY_ED_CDE_QUAL_PHASE Description: 
		/// </summary>
		/// <param name="_edCdeQualPhase"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEdCdeQualPhase(System.Decimal? _edCdeQualPhase)
		{
			int count = -1;
			return GetByEdCdeQualPhase(_edCdeQualPhase, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ED_CDE_QUAL_PHASE key.
		///		FK_ED_STUD_FACULTY_ED_CDE_QUAL_PHASE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualPhase"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudFaculty> GetByEdCdeQualPhase(TransactionManager transactionManager, System.Decimal? _edCdeQualPhase)
		{
			int count = -1;
			return GetByEdCdeQualPhase(transactionManager, _edCdeQualPhase, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ED_CDE_QUAL_PHASE key.
		///		FK_ED_STUD_FACULTY_ED_CDE_QUAL_PHASE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualPhase"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEdCdeQualPhase(TransactionManager transactionManager, System.Decimal? _edCdeQualPhase, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeQualPhase(transactionManager, _edCdeQualPhase, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ED_CDE_QUAL_PHASE key.
		///		fkEdStudFacultyEdCdeQualPhase Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeQualPhase"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEdCdeQualPhase(System.Decimal? _edCdeQualPhase, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeQualPhase(null, _edCdeQualPhase, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ED_CDE_QUAL_PHASE key.
		///		fkEdStudFacultyEdCdeQualPhase Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeQualPhase"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEdCdeQualPhase(System.Decimal? _edCdeQualPhase, int start, int pageLength,out int count)
		{
			return GetByEdCdeQualPhase(null, _edCdeQualPhase, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ED_CDE_QUAL_PHASE key.
		///		FK_ED_STUD_FACULTY_ED_CDE_QUAL_PHASE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualPhase"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public abstract TList<EdStudFaculty> GetByEdCdeQualPhase(TransactionManager transactionManager, System.Decimal? _edCdeQualPhase, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_FACULTY_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterJoinId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEdCodeSemesterJoinId(System.Decimal? _edCodeSemesterJoinId)
		{
			int count = -1;
			return GetByEdCodeSemesterJoinId(_edCodeSemesterJoinId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_FACULTY_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterJoinId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudFaculty> GetByEdCodeSemesterJoinId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterJoinId)
		{
			int count = -1;
			return GetByEdCodeSemesterJoinId(transactionManager, _edCodeSemesterJoinId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_FACULTY_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterJoinId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEdCodeSemesterJoinId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterJoinId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterJoinId(transactionManager, _edCodeSemesterJoinId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ED_CODE_SEMESTER key.
		///		fkEdStudFacultyEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterJoinId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEdCodeSemesterJoinId(System.Decimal? _edCodeSemesterJoinId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterJoinId(null, _edCodeSemesterJoinId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ED_CODE_SEMESTER key.
		///		fkEdStudFacultyEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterJoinId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEdCodeSemesterJoinId(System.Decimal? _edCodeSemesterJoinId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterJoinId(null, _edCodeSemesterJoinId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_FACULTY_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterJoinId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public abstract TList<EdStudFaculty> GetByEdCodeSemesterJoinId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterJoinId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ED_CODE_SEMESTER1 key.
		///		FK_ED_STUD_FACULTY_ED_CODE_SEMESTER1 Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ED_CODE_SEMESTER1 key.
		///		FK_ED_STUD_FACULTY_ED_CODE_SEMESTER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudFaculty> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ED_CODE_SEMESTER1 key.
		///		FK_ED_STUD_FACULTY_ED_CODE_SEMESTER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ED_CODE_SEMESTER1 key.
		///		fkEdStudFacultyEdCodeSemester1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ED_CODE_SEMESTER1 key.
		///		fkEdStudFacultyEdCodeSemester1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ED_CODE_SEMESTER1 key.
		///		FK_ED_STUD_FACULTY_ED_CODE_SEMESTER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public abstract TList<EdStudFaculty> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ED_STUD_QUAL key.
		///		FK_ED_STUD_FACULTY_ED_STUD_QUAL Description: 
		/// </summary>
		/// <param name="_edStudQualId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEdStudQualId(System.Decimal? _edStudQualId)
		{
			int count = -1;
			return GetByEdStudQualId(_edStudQualId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ED_STUD_QUAL key.
		///		FK_ED_STUD_FACULTY_ED_STUD_QUAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudQualId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudFaculty> GetByEdStudQualId(TransactionManager transactionManager, System.Decimal? _edStudQualId)
		{
			int count = -1;
			return GetByEdStudQualId(transactionManager, _edStudQualId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ED_STUD_QUAL key.
		///		FK_ED_STUD_FACULTY_ED_STUD_QUAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEdStudQualId(TransactionManager transactionManager, System.Decimal? _edStudQualId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudQualId(transactionManager, _edStudQualId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ED_STUD_QUAL key.
		///		fkEdStudFacultyEdStudQual Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudQualId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEdStudQualId(System.Decimal? _edStudQualId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudQualId(null, _edStudQualId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ED_STUD_QUAL key.
		///		fkEdStudFacultyEdStudQual Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudQualId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEdStudQualId(System.Decimal? _edStudQualId, int start, int pageLength,out int count)
		{
			return GetByEdStudQualId(null, _edStudQualId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ED_STUD_QUAL key.
		///		FK_ED_STUD_FACULTY_ED_STUD_QUAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public abstract TList<EdStudFaculty> GetByEdStudQualId(TransactionManager transactionManager, System.Decimal? _edStudQualId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ENT_MAIN_MATRIX key.
		///		FK_ED_STUD_FACULTY_ENT_MAIN_MATRIX Description: 
		/// </summary>
		/// <param name="_entMainMatrixId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEntMainMatrixId(System.Decimal? _entMainMatrixId)
		{
			int count = -1;
			return GetByEntMainMatrixId(_entMainMatrixId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ENT_MAIN_MATRIX key.
		///		FK_ED_STUD_FACULTY_ENT_MAIN_MATRIX Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainMatrixId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudFaculty> GetByEntMainMatrixId(TransactionManager transactionManager, System.Decimal? _entMainMatrixId)
		{
			int count = -1;
			return GetByEntMainMatrixId(transactionManager, _entMainMatrixId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ENT_MAIN_MATRIX key.
		///		FK_ED_STUD_FACULTY_ENT_MAIN_MATRIX Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainMatrixId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEntMainMatrixId(TransactionManager transactionManager, System.Decimal? _entMainMatrixId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainMatrixId(transactionManager, _entMainMatrixId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ENT_MAIN_MATRIX key.
		///		fkEdStudFacultyEntMainMatrix Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainMatrixId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEntMainMatrixId(System.Decimal? _entMainMatrixId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainMatrixId(null, _entMainMatrixId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ENT_MAIN_MATRIX key.
		///		fkEdStudFacultyEntMainMatrix Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainMatrixId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEntMainMatrixId(System.Decimal? _entMainMatrixId, int start, int pageLength,out int count)
		{
			return GetByEntMainMatrixId(null, _entMainMatrixId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ENT_MAIN_MATRIX key.
		///		FK_ED_STUD_FACULTY_ENT_MAIN_MATRIX Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainMatrixId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public abstract TList<EdStudFaculty> GetByEntMainMatrixId(TransactionManager transactionManager, System.Decimal? _entMainMatrixId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ENT_POLICY_ACCUM_HONOR key.
		///		FK_ED_STUD_FACULTY_ENT_POLICY_ACCUM_HONOR Description: 
		/// </summary>
		/// <param name="_entPolicyAccumHonorId">XXXXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEntPolicyAccumHonorId(System.Decimal? _entPolicyAccumHonorId)
		{
			int count = -1;
			return GetByEntPolicyAccumHonorId(_entPolicyAccumHonorId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ENT_POLICY_ACCUM_HONOR key.
		///		FK_ED_STUD_FACULTY_ENT_POLICY_ACCUM_HONOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAccumHonorId">XXXXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudFaculty> GetByEntPolicyAccumHonorId(TransactionManager transactionManager, System.Decimal? _entPolicyAccumHonorId)
		{
			int count = -1;
			return GetByEntPolicyAccumHonorId(transactionManager, _entPolicyAccumHonorId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ENT_POLICY_ACCUM_HONOR key.
		///		FK_ED_STUD_FACULTY_ENT_POLICY_ACCUM_HONOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAccumHonorId">XXXXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEntPolicyAccumHonorId(TransactionManager transactionManager, System.Decimal? _entPolicyAccumHonorId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyAccumHonorId(transactionManager, _entPolicyAccumHonorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ENT_POLICY_ACCUM_HONOR key.
		///		fkEdStudFacultyEntPolicyAccumHonor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entPolicyAccumHonorId">XXXXX</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEntPolicyAccumHonorId(System.Decimal? _entPolicyAccumHonorId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntPolicyAccumHonorId(null, _entPolicyAccumHonorId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ENT_POLICY_ACCUM_HONOR key.
		///		fkEdStudFacultyEntPolicyAccumHonor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entPolicyAccumHonorId">XXXXX</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEntPolicyAccumHonorId(System.Decimal? _entPolicyAccumHonorId, int start, int pageLength,out int count)
		{
			return GetByEntPolicyAccumHonorId(null, _entPolicyAccumHonorId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ENT_POLICY_ACCUM_HONOR key.
		///		FK_ED_STUD_FACULTY_ENT_POLICY_ACCUM_HONOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAccumHonorId">XXXXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public abstract TList<EdStudFaculty> GetByEntPolicyAccumHonorId(TransactionManager transactionManager, System.Decimal? _entPolicyAccumHonorId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ENTITY_MAIN key.
		///		FK_ED_STUD_FACULTY_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_entMainGrad1"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEntMainGrad1(System.Decimal? _entMainGrad1)
		{
			int count = -1;
			return GetByEntMainGrad1(_entMainGrad1, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ENTITY_MAIN key.
		///		FK_ED_STUD_FACULTY_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainGrad1"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudFaculty> GetByEntMainGrad1(TransactionManager transactionManager, System.Decimal? _entMainGrad1)
		{
			int count = -1;
			return GetByEntMainGrad1(transactionManager, _entMainGrad1, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ENTITY_MAIN key.
		///		FK_ED_STUD_FACULTY_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainGrad1"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEntMainGrad1(TransactionManager transactionManager, System.Decimal? _entMainGrad1, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainGrad1(transactionManager, _entMainGrad1, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ENTITY_MAIN key.
		///		fkEdStudFacultyEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainGrad1"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEntMainGrad1(System.Decimal? _entMainGrad1, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainGrad1(null, _entMainGrad1, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ENTITY_MAIN key.
		///		fkEdStudFacultyEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainGrad1"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEntMainGrad1(System.Decimal? _entMainGrad1, int start, int pageLength,out int count)
		{
			return GetByEntMainGrad1(null, _entMainGrad1, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ENTITY_MAIN key.
		///		FK_ED_STUD_FACULTY_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainGrad1"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public abstract TList<EdStudFaculty> GetByEntMainGrad1(TransactionManager transactionManager, System.Decimal? _entMainGrad1, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ENTITY_MAIN1 key.
		///		FK_ED_STUD_FACULTY_ENTITY_MAIN1 Description: 
		/// </summary>
		/// <param name="_entMainGrad2"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEntMainGrad2(System.Decimal? _entMainGrad2)
		{
			int count = -1;
			return GetByEntMainGrad2(_entMainGrad2, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ENTITY_MAIN1 key.
		///		FK_ED_STUD_FACULTY_ENTITY_MAIN1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainGrad2"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudFaculty> GetByEntMainGrad2(TransactionManager transactionManager, System.Decimal? _entMainGrad2)
		{
			int count = -1;
			return GetByEntMainGrad2(transactionManager, _entMainGrad2, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ENTITY_MAIN1 key.
		///		FK_ED_STUD_FACULTY_ENTITY_MAIN1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainGrad2"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEntMainGrad2(TransactionManager transactionManager, System.Decimal? _entMainGrad2, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainGrad2(transactionManager, _entMainGrad2, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ENTITY_MAIN1 key.
		///		fkEdStudFacultyEntityMain1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainGrad2"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEntMainGrad2(System.Decimal? _entMainGrad2, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainGrad2(null, _entMainGrad2, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ENTITY_MAIN1 key.
		///		fkEdStudFacultyEntityMain1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainGrad2"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEntMainGrad2(System.Decimal? _entMainGrad2, int start, int pageLength,out int count)
		{
			return GetByEntMainGrad2(null, _entMainGrad2, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ENTITY_MAIN1 key.
		///		FK_ED_STUD_FACULTY_ENTITY_MAIN1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainGrad2"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public abstract TList<EdStudFaculty> GetByEntMainGrad2(TransactionManager transactionManager, System.Decimal? _entMainGrad2, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ENTITY_MAIN2 key.
		///		FK_ED_STUD_FACULTY_ENTITY_MAIN2 Description: 
		/// </summary>
		/// <param name="_entMainGrad3"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEntMainGrad3(System.Decimal? _entMainGrad3)
		{
			int count = -1;
			return GetByEntMainGrad3(_entMainGrad3, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ENTITY_MAIN2 key.
		///		FK_ED_STUD_FACULTY_ENTITY_MAIN2 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainGrad3"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudFaculty> GetByEntMainGrad3(TransactionManager transactionManager, System.Decimal? _entMainGrad3)
		{
			int count = -1;
			return GetByEntMainGrad3(transactionManager, _entMainGrad3, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ENTITY_MAIN2 key.
		///		FK_ED_STUD_FACULTY_ENTITY_MAIN2 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainGrad3"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEntMainGrad3(TransactionManager transactionManager, System.Decimal? _entMainGrad3, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainGrad3(transactionManager, _entMainGrad3, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ENTITY_MAIN2 key.
		///		fkEdStudFacultyEntityMain2 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainGrad3"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEntMainGrad3(System.Decimal? _entMainGrad3, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainGrad3(null, _entMainGrad3, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ENTITY_MAIN2 key.
		///		fkEdStudFacultyEntityMain2 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainGrad3"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByEntMainGrad3(System.Decimal? _entMainGrad3, int start, int pageLength,out int count)
		{
			return GetByEntMainGrad3(null, _entMainGrad3, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_ENTITY_MAIN2 key.
		///		FK_ED_STUD_FACULTY_ENTITY_MAIN2 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainGrad3"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public abstract TList<EdStudFaculty> GetByEntMainGrad3(TransactionManager transactionManager, System.Decimal? _entMainGrad3, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_GS_CDE_HONOR key.
		///		FK_ED_STUD_FACULTY_GS_CDE_HONOR Description: 
		/// </summary>
		/// <param name="_gsCdeHonorId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByGsCdeHonorId(System.Decimal? _gsCdeHonorId)
		{
			int count = -1;
			return GetByGsCdeHonorId(_gsCdeHonorId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_GS_CDE_HONOR key.
		///		FK_ED_STUD_FACULTY_GS_CDE_HONOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeHonorId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudFaculty> GetByGsCdeHonorId(TransactionManager transactionManager, System.Decimal? _gsCdeHonorId)
		{
			int count = -1;
			return GetByGsCdeHonorId(transactionManager, _gsCdeHonorId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_GS_CDE_HONOR key.
		///		FK_ED_STUD_FACULTY_GS_CDE_HONOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeHonorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByGsCdeHonorId(TransactionManager transactionManager, System.Decimal? _gsCdeHonorId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeHonorId(transactionManager, _gsCdeHonorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_GS_CDE_HONOR key.
		///		fkEdStudFacultyGsCdeHonor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeHonorId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByGsCdeHonorId(System.Decimal? _gsCdeHonorId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeHonorId(null, _gsCdeHonorId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_GS_CDE_HONOR key.
		///		fkEdStudFacultyGsCdeHonor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeHonorId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public TList<EdStudFaculty> GetByGsCdeHonorId(System.Decimal? _gsCdeHonorId, int start, int pageLength,out int count)
		{
			return GetByGsCdeHonorId(null, _gsCdeHonorId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_FACULTY_GS_CDE_HONOR key.
		///		FK_ED_STUD_FACULTY_GS_CDE_HONOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeHonorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudFaculty objects.</returns>
		public abstract TList<EdStudFaculty> GetByGsCdeHonorId(TransactionManager transactionManager, System.Decimal? _gsCdeHonorId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudFaculty Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudFacultyKey key, int start, int pageLength)
		{
			return GetByEdStudFacultyId(transactionManager, key.EdStudFacultyId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudFaculty&gt;"/> class.</returns>
		public TList<EdStudFaculty> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null,_asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudFaculty&gt;"/> class.</returns>
		public TList<EdStudFaculty> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudFaculty&gt;"/> class.</returns>
		public TList<EdStudFaculty> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudFaculty&gt;"/> class.</returns>
		public TList<EdStudFaculty> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudFaculty&gt;"/> class.</returns>
		public TList<EdStudFaculty> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudFaculty&gt;"/> class.</returns>
		public abstract TList<EdStudFaculty> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudFaculty&gt;"/> class.</returns>
		public TList<EdStudFaculty> GetByEdAcadYearId(System.Decimal? _edAcadYearId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudFaculty&gt;"/> class.</returns>
		public TList<EdStudFaculty> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudFaculty&gt;"/> class.</returns>
		public TList<EdStudFaculty> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudFaculty&gt;"/> class.</returns>
		public TList<EdStudFaculty> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudFaculty&gt;"/> class.</returns>
		public TList<EdStudFaculty> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudFaculty&gt;"/> class.</returns>
		public abstract TList<EdStudFaculty> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_ACAD_YEAR_JOIN_ID_1 index.
		/// </summary>
		/// <param name="_edAcadYearJoinId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudFaculty&gt;"/> class.</returns>
		public TList<EdStudFaculty> GetByEdAcadYearJoinId(System.Decimal? _edAcadYearJoinId)
		{
			int count = -1;
			return GetByEdAcadYearJoinId(null,_edAcadYearJoinId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_JOIN_ID_1 index.
		/// </summary>
		/// <param name="_edAcadYearJoinId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudFaculty&gt;"/> class.</returns>
		public TList<EdStudFaculty> GetByEdAcadYearJoinId(System.Decimal? _edAcadYearJoinId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearJoinId(null, _edAcadYearJoinId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_JOIN_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearJoinId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudFaculty&gt;"/> class.</returns>
		public TList<EdStudFaculty> GetByEdAcadYearJoinId(TransactionManager transactionManager, System.Decimal? _edAcadYearJoinId)
		{
			int count = -1;
			return GetByEdAcadYearJoinId(transactionManager, _edAcadYearJoinId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_JOIN_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearJoinId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudFaculty&gt;"/> class.</returns>
		public TList<EdStudFaculty> GetByEdAcadYearJoinId(TransactionManager transactionManager, System.Decimal? _edAcadYearJoinId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearJoinId(transactionManager, _edAcadYearJoinId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_JOIN_ID_1 index.
		/// </summary>
		/// <param name="_edAcadYearJoinId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudFaculty&gt;"/> class.</returns>
		public TList<EdStudFaculty> GetByEdAcadYearJoinId(System.Decimal? _edAcadYearJoinId, int start, int pageLength, out int count)
		{
			return GetByEdAcadYearJoinId(null, _edAcadYearJoinId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_JOIN_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearJoinId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudFaculty&gt;"/> class.</returns>
		public abstract TList<EdStudFaculty> GetByEdAcadYearJoinId(TransactionManager transactionManager, System.Decimal? _edAcadYearJoinId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_GRADING_ID_1 index.
		/// </summary>
		/// <param name="_edCodeGradingId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudFaculty&gt;"/> class.</returns>
		public TList<EdStudFaculty> GetByEdCodeGradingId(System.Decimal? _edCodeGradingId)
		{
			int count = -1;
			return GetByEdCodeGradingId(null,_edCodeGradingId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_GRADING_ID_1 index.
		/// </summary>
		/// <param name="_edCodeGradingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudFaculty&gt;"/> class.</returns>
		public TList<EdStudFaculty> GetByEdCodeGradingId(System.Decimal? _edCodeGradingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeGradingId(null, _edCodeGradingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_GRADING_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudFaculty&gt;"/> class.</returns>
		public TList<EdStudFaculty> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _edCodeGradingId)
		{
			int count = -1;
			return GetByEdCodeGradingId(transactionManager, _edCodeGradingId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_GRADING_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudFaculty&gt;"/> class.</returns>
		public TList<EdStudFaculty> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _edCodeGradingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeGradingId(transactionManager, _edCodeGradingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_GRADING_ID_1 index.
		/// </summary>
		/// <param name="_edCodeGradingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudFaculty&gt;"/> class.</returns>
		public TList<EdStudFaculty> GetByEdCodeGradingId(System.Decimal? _edCodeGradingId, int start, int pageLength, out int count)
		{
			return GetByEdCodeGradingId(null, _edCodeGradingId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_GRADING_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudFaculty&gt;"/> class.</returns>
		public abstract TList<EdStudFaculty> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _edCodeGradingId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudFaculty&gt;"/> class.</returns>
		public TList<EdStudFaculty> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(null,_edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudFaculty&gt;"/> class.</returns>
		public TList<EdStudFaculty> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudFaculty&gt;"/> class.</returns>
		public TList<EdStudFaculty> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudFaculty&gt;"/> class.</returns>
		public TList<EdStudFaculty> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudFaculty&gt;"/> class.</returns>
		public TList<EdStudFaculty> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength, out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudFaculty&gt;"/> class.</returns>
		public abstract TList<EdStudFaculty> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_FACULTY index.
		/// </summary>
		/// <param name="_edStudFacultyId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudFaculty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudFaculty GetByEdStudFacultyId(System.Decimal _edStudFacultyId)
		{
			int count = -1;
			return GetByEdStudFacultyId(null,_edStudFacultyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_FACULTY index.
		/// </summary>
		/// <param name="_edStudFacultyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudFaculty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudFaculty GetByEdStudFacultyId(System.Decimal _edStudFacultyId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudFacultyId(null, _edStudFacultyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_FACULTY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudFacultyId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudFaculty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudFaculty GetByEdStudFacultyId(TransactionManager transactionManager, System.Decimal _edStudFacultyId)
		{
			int count = -1;
			return GetByEdStudFacultyId(transactionManager, _edStudFacultyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_FACULTY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudFacultyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudFaculty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudFaculty GetByEdStudFacultyId(TransactionManager transactionManager, System.Decimal _edStudFacultyId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudFacultyId(transactionManager, _edStudFacultyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_FACULTY index.
		/// </summary>
		/// <param name="_edStudFacultyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudFaculty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudFaculty GetByEdStudFacultyId(System.Decimal _edStudFacultyId, int start, int pageLength, out int count)
		{
			return GetByEdStudFacultyId(null, _edStudFacultyId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_FACULTY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudFacultyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudFaculty"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudFaculty GetByEdStudFacultyId(TransactionManager transactionManager, System.Decimal _edStudFacultyId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_STUD_FACULTY index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudFaculty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudFaculty GetByEdStudIdAsFacultyInfoIdAsCodeDegreeId(System.Decimal _edStudId, System.Decimal? _asFacultyInfoId, System.Decimal _asCodeDegreeId)
		{
			int count = -1;
			return GetByEdStudIdAsFacultyInfoIdAsCodeDegreeId(null,_edStudId, _asFacultyInfoId, _asCodeDegreeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_FACULTY index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudFaculty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudFaculty GetByEdStudIdAsFacultyInfoIdAsCodeDegreeId(System.Decimal _edStudId, System.Decimal? _asFacultyInfoId, System.Decimal _asCodeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIdAsFacultyInfoIdAsCodeDegreeId(null, _edStudId, _asFacultyInfoId, _asCodeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_FACULTY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudFaculty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudFaculty GetByEdStudIdAsFacultyInfoIdAsCodeDegreeId(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal? _asFacultyInfoId, System.Decimal _asCodeDegreeId)
		{
			int count = -1;
			return GetByEdStudIdAsFacultyInfoIdAsCodeDegreeId(transactionManager, _edStudId, _asFacultyInfoId, _asCodeDegreeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_FACULTY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudFaculty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudFaculty GetByEdStudIdAsFacultyInfoIdAsCodeDegreeId(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal? _asFacultyInfoId, System.Decimal _asCodeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIdAsFacultyInfoIdAsCodeDegreeId(transactionManager, _edStudId, _asFacultyInfoId, _asCodeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_FACULTY index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudFaculty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudFaculty GetByEdStudIdAsFacultyInfoIdAsCodeDegreeId(System.Decimal _edStudId, System.Decimal? _asFacultyInfoId, System.Decimal _asCodeDegreeId, int start, int pageLength, out int count)
		{
			return GetByEdStudIdAsFacultyInfoIdAsCodeDegreeId(null, _edStudId, _asFacultyInfoId, _asCodeDegreeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_FACULTY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudFaculty"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudFaculty GetByEdStudIdAsFacultyInfoIdAsCodeDegreeId(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal? _asFacultyInfoId, System.Decimal _asCodeDegreeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_STUD_FACULTY_CODE index.
		/// </summary>
		/// <param name="_studFacultyCode"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudFaculty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudFaculty GetByStudFacultyCodeAsFacultyInfoIdAsCodeDegreeId(System.String _studFacultyCode, System.Decimal? _asFacultyInfoId, System.Decimal _asCodeDegreeId)
		{
			int count = -1;
			return GetByStudFacultyCodeAsFacultyInfoIdAsCodeDegreeId(null,_studFacultyCode, _asFacultyInfoId, _asCodeDegreeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_FACULTY_CODE index.
		/// </summary>
		/// <param name="_studFacultyCode"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudFaculty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudFaculty GetByStudFacultyCodeAsFacultyInfoIdAsCodeDegreeId(System.String _studFacultyCode, System.Decimal? _asFacultyInfoId, System.Decimal _asCodeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByStudFacultyCodeAsFacultyInfoIdAsCodeDegreeId(null, _studFacultyCode, _asFacultyInfoId, _asCodeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_FACULTY_CODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_studFacultyCode"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudFaculty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudFaculty GetByStudFacultyCodeAsFacultyInfoIdAsCodeDegreeId(TransactionManager transactionManager, System.String _studFacultyCode, System.Decimal? _asFacultyInfoId, System.Decimal _asCodeDegreeId)
		{
			int count = -1;
			return GetByStudFacultyCodeAsFacultyInfoIdAsCodeDegreeId(transactionManager, _studFacultyCode, _asFacultyInfoId, _asCodeDegreeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_FACULTY_CODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_studFacultyCode"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudFaculty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudFaculty GetByStudFacultyCodeAsFacultyInfoIdAsCodeDegreeId(TransactionManager transactionManager, System.String _studFacultyCode, System.Decimal? _asFacultyInfoId, System.Decimal _asCodeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByStudFacultyCodeAsFacultyInfoIdAsCodeDegreeId(transactionManager, _studFacultyCode, _asFacultyInfoId, _asCodeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_FACULTY_CODE index.
		/// </summary>
		/// <param name="_studFacultyCode"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudFaculty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudFaculty GetByStudFacultyCodeAsFacultyInfoIdAsCodeDegreeId(System.String _studFacultyCode, System.Decimal? _asFacultyInfoId, System.Decimal _asCodeDegreeId, int start, int pageLength, out int count)
		{
			return GetByStudFacultyCodeAsFacultyInfoIdAsCodeDegreeId(null, _studFacultyCode, _asFacultyInfoId, _asCodeDegreeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_FACULTY_CODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_studFacultyCode"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudFaculty"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudFaculty GetByStudFacultyCodeAsFacultyInfoIdAsCodeDegreeId(TransactionManager transactionManager, System.String _studFacultyCode, System.Decimal? _asFacultyInfoId, System.Decimal _asCodeDegreeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudFaculty&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudFaculty&gt;"/></returns>
		public static TList<EdStudFaculty> Fill(IDataReader reader, TList<EdStudFaculty> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudFaculty c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudFaculty")
					.Append("|").Append((System.Decimal)reader["ED_STUD_FACULTY_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudFaculty>(
					key.ToString(), // EntityTrackingKey
					"EdStudFaculty",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudFaculty();
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
					c.EdStudFacultyId = (System.Decimal)reader["ED_STUD_FACULTY_ID"];
					c.OriginalEdStudFacultyId = c.EdStudFacultyId;
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.AsCodeDegreeId = (System.Decimal)reader["AS_CODE_DEGREE_ID"];
					c.StudFacultyCode = Convert.IsDBNull(reader["STUD_FACULTY_CODE"]) ? null : (System.String)reader["STUD_FACULTY_CODE"];
					c.AdmCdeAppTypeId = Convert.IsDBNull(reader["ADM_CDE_APP_TYPE_ID"]) ? null : (System.Decimal?)reader["ADM_CDE_APP_TYPE_ID"];
					c.EdAcadYearJoinId = Convert.IsDBNull(reader["ED_ACAD_YEAR_JOIN_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_JOIN_ID"];
					c.EdCodeSemesterJoinId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_JOIN_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_JOIN_ID"];
					c.EnrollDate = Convert.IsDBNull(reader["ENROLL_DATE"]) ? null : (System.DateTime?)reader["ENROLL_DATE"];
					c.ComptativeRate = Convert.IsDBNull(reader["COMPTATIVE_RATE"]) ? null : (System.Decimal?)reader["COMPTATIVE_RATE"];
					c.FullTimeFlg = Convert.IsDBNull(reader["FULL_TIME_FLG"]) ? null : (System.Decimal?)reader["FULL_TIME_FLG"];
					c.EdCdeQualPhase = Convert.IsDBNull(reader["ED_CDE_QUAL_PHASE"]) ? null : (System.Decimal?)reader["ED_CDE_QUAL_PHASE"];
					c.EdStudQualId = Convert.IsDBNull(reader["ED_STUD_QUAL_ID"]) ? null : (System.Decimal?)reader["ED_STUD_QUAL_ID"];
					c.GraduatesFlag = (System.Decimal)reader["GRADUATES_FLAG"];
					c.EdAcadYearId = Convert.IsDBNull(reader["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_ID"];
					c.WithHonor = Convert.IsDBNull(reader["WITH_HONOR"]) ? null : (System.Decimal?)reader["WITH_HONOR"];
					c.EntPolicyAccumHonorId = Convert.IsDBNull(reader["ENT_POLICY_ACCUM_HONOR_ID"]) ? null : (System.Decimal?)reader["ENT_POLICY_ACCUM_HONOR_ID"];
					c.AccumCredit = Convert.IsDBNull(reader["ACCUM_CREDIT"]) ? null : (System.Decimal?)reader["ACCUM_CREDIT"];
					c.AccumPoints = Convert.IsDBNull(reader["ACCUM_POINTS"]) ? null : (System.Decimal?)reader["ACCUM_POINTS"];
					c.EntMainGrad1 = Convert.IsDBNull(reader["ENT_MAIN_GRAD_1"]) ? null : (System.Decimal?)reader["ENT_MAIN_GRAD_1"];
					c.EntMainGrad2 = Convert.IsDBNull(reader["ENT_MAIN_GRAD_2"]) ? null : (System.Decimal?)reader["ENT_MAIN_GRAD_2"];
					c.EntMainGrad3 = Convert.IsDBNull(reader["ENT_MAIN_GRAD_3"]) ? null : (System.Decimal?)reader["ENT_MAIN_GRAD_3"];
					c.EntMainMatrixId = Convert.IsDBNull(reader["ENT_MAIN_MATRIX_ID"]) ? null : (System.Decimal?)reader["ENT_MAIN_MATRIX_ID"];
					c.TransferFlg = Convert.IsDBNull(reader["TRANSFER_FLG"]) ? null : (System.Decimal?)reader["TRANSFER_FLG"];
					c.AdmCodeTransferTypeId = Convert.IsDBNull(reader["ADM_CODE_TRANSFER_TYPE_ID"]) ? null : (System.Decimal?)reader["ADM_CODE_TRANSFER_TYPE_ID"];
					c.UnivApproveDate = Convert.IsDBNull(reader["UNIV_APPROVE_DATE"]) ? null : (System.DateTime?)reader["UNIV_APPROVE_DATE"];
					c.FacApproveDate = Convert.IsDBNull(reader["FAC_APPROVE_DATE"]) ? null : (System.DateTime?)reader["FAC_APPROVE_DATE"];
					c.DeptApproveDate = Convert.IsDBNull(reader["DEPT_APPROVE_DATE"]) ? null : (System.DateTime?)reader["DEPT_APPROVE_DATE"];
					c.EdCodeGradingId = Convert.IsDBNull(reader["ED_CODE_GRADING_ID"]) ? null : (System.Decimal?)reader["ED_CODE_GRADING_ID"];
					c.IsActive = (System.Decimal)reader["IS_ACTIVE"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.MajorCgpa = Convert.IsDBNull(reader["MAJOR_CGPA"]) ? null : (System.Decimal?)reader["MAJOR_CGPA"];
					c.Cgpa = Convert.IsDBNull(reader["CGPA"]) ? null : (System.Decimal?)reader["CGPA"];
					c.EdBylawId = Convert.IsDBNull(reader["ED_BYLAW_ID"]) ? null : (System.Decimal?)reader["ED_BYLAW_ID"];
					c.OldAlumniFlg = Convert.IsDBNull(reader["OLD_ALUMNI_FLG"]) ? null : (System.Decimal?)reader["OLD_ALUMNI_FLG"];
					c.StudCardFlg = Convert.IsDBNull(reader["STUD_CARD_FLG"]) ? null : (System.Decimal?)reader["STUD_CARD_FLG"];
					c.GrantingCode = Convert.IsDBNull(reader["GRANTING_CODE"]) ? null : (System.String)reader["GRANTING_CODE"];
					c.IsLast = Convert.IsDBNull(reader["IS_LAST"]) ? null : (System.Decimal?)reader["IS_LAST"];
					c.AmanestPermanentStopFlag = Convert.IsDBNull(reader["AMANEST_PERMANENT_STOP_FLAG"]) ? null : (System.Decimal?)reader["AMANEST_PERMANENT_STOP_FLAG"];
					c.BatchNo = Convert.IsDBNull(reader["BATCH_NO"]) ? null : (System.String)reader["BATCH_NO"];
					c.GsCdeHonorId = Convert.IsDBNull(reader["GS_CDE_HONOR_ID"]) ? null : (System.Decimal?)reader["GS_CDE_HONOR_ID"];
					c.TrnsfrFrom = Convert.IsDBNull(reader["TRNSFR_FROM"]) ? null : (System.String)reader["TRNSFR_FROM"];
					c.TrnsfrNotes = Convert.IsDBNull(reader["TRNSFR_NOTES"]) ? null : (System.String)reader["TRNSFR_NOTES"];
					c.TrnsfrDate = Convert.IsDBNull(reader["TRNSFR_DATE"]) ? null : (System.DateTime?)reader["TRNSFR_DATE"];
					c.OrgFacultyNameAr = Convert.IsDBNull(reader["ORG_FACULTY_NAME_AR"]) ? null : (System.String)reader["ORG_FACULTY_NAME_AR"];
					c.StudFeeBalance = Convert.IsDBNull(reader["STUD_FEE_BALANCE"]) ? null : (System.Decimal?)reader["STUD_FEE_BALANCE"];
					c.AccumPrcent = Convert.IsDBNull(reader["ACCUM_PRCENT"]) ? null : (System.Decimal?)reader["ACCUM_PRCENT"];
					c.HecId = Convert.IsDBNull(reader["HEC_ID"]) ? null : (System.String)reader["HEC_ID"];
					c.ExpctdGradDate = Convert.IsDBNull(reader["EXPCTD_GRAD_DATE"]) ? null : (System.DateTime?)reader["EXPCTD_GRAD_DATE"];
					c.AccumMarks = Convert.IsDBNull(reader["ACCUM_MARKS"]) ? null : (System.Decimal?)reader["ACCUM_MARKS"];
					c.AccumCourseMarks = Convert.IsDBNull(reader["ACCUM_COURSE_MARKS"]) ? null : (System.Decimal?)reader["ACCUM_COURSE_MARKS"];
					c.MotherId = Convert.IsDBNull(reader["Mother_ID"]) ? null : (System.String)reader["Mother_ID"];
					c.PartTimeFlg = Convert.IsDBNull(reader["PART_TIME_FLG"]) ? null : (System.Boolean?)reader["PART_TIME_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudFaculty"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudFaculty"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudFaculty entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudFacultyId = (System.Decimal)reader[((int)EdStudFacultyColumn.EdStudFacultyId - 1)];
			entity.OriginalEdStudFacultyId = (System.Decimal)reader["ED_STUD_FACULTY_ID"];
			entity.EdStudId = (System.Decimal)reader[((int)EdStudFacultyColumn.EdStudId - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)EdStudFacultyColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)EdStudFacultyColumn.AsFacultyInfoId - 1)];
			entity.AsCodeDegreeId = (System.Decimal)reader[((int)EdStudFacultyColumn.AsCodeDegreeId - 1)];
			entity.StudFacultyCode = (reader.IsDBNull(((int)EdStudFacultyColumn.StudFacultyCode - 1)))?null:(System.String)reader[((int)EdStudFacultyColumn.StudFacultyCode - 1)];
			entity.AdmCdeAppTypeId = (reader.IsDBNull(((int)EdStudFacultyColumn.AdmCdeAppTypeId - 1)))?null:(System.Decimal?)reader[((int)EdStudFacultyColumn.AdmCdeAppTypeId - 1)];
			entity.EdAcadYearJoinId = (reader.IsDBNull(((int)EdStudFacultyColumn.EdAcadYearJoinId - 1)))?null:(System.Decimal?)reader[((int)EdStudFacultyColumn.EdAcadYearJoinId - 1)];
			entity.EdCodeSemesterJoinId = (reader.IsDBNull(((int)EdStudFacultyColumn.EdCodeSemesterJoinId - 1)))?null:(System.Decimal?)reader[((int)EdStudFacultyColumn.EdCodeSemesterJoinId - 1)];
			entity.EnrollDate = (reader.IsDBNull(((int)EdStudFacultyColumn.EnrollDate - 1)))?null:(System.DateTime?)reader[((int)EdStudFacultyColumn.EnrollDate - 1)];
			entity.ComptativeRate = (reader.IsDBNull(((int)EdStudFacultyColumn.ComptativeRate - 1)))?null:(System.Decimal?)reader[((int)EdStudFacultyColumn.ComptativeRate - 1)];
			entity.FullTimeFlg = (reader.IsDBNull(((int)EdStudFacultyColumn.FullTimeFlg - 1)))?null:(System.Decimal?)reader[((int)EdStudFacultyColumn.FullTimeFlg - 1)];
			entity.EdCdeQualPhase = (reader.IsDBNull(((int)EdStudFacultyColumn.EdCdeQualPhase - 1)))?null:(System.Decimal?)reader[((int)EdStudFacultyColumn.EdCdeQualPhase - 1)];
			entity.EdStudQualId = (reader.IsDBNull(((int)EdStudFacultyColumn.EdStudQualId - 1)))?null:(System.Decimal?)reader[((int)EdStudFacultyColumn.EdStudQualId - 1)];
			entity.GraduatesFlag = (System.Decimal)reader[((int)EdStudFacultyColumn.GraduatesFlag - 1)];
			entity.EdAcadYearId = (reader.IsDBNull(((int)EdStudFacultyColumn.EdAcadYearId - 1)))?null:(System.Decimal?)reader[((int)EdStudFacultyColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (reader.IsDBNull(((int)EdStudFacultyColumn.EdCodeSemesterId - 1)))?null:(System.Decimal?)reader[((int)EdStudFacultyColumn.EdCodeSemesterId - 1)];
			entity.WithHonor = (reader.IsDBNull(((int)EdStudFacultyColumn.WithHonor - 1)))?null:(System.Decimal?)reader[((int)EdStudFacultyColumn.WithHonor - 1)];
			entity.EntPolicyAccumHonorId = (reader.IsDBNull(((int)EdStudFacultyColumn.EntPolicyAccumHonorId - 1)))?null:(System.Decimal?)reader[((int)EdStudFacultyColumn.EntPolicyAccumHonorId - 1)];
			entity.AccumCredit = (reader.IsDBNull(((int)EdStudFacultyColumn.AccumCredit - 1)))?null:(System.Decimal?)reader[((int)EdStudFacultyColumn.AccumCredit - 1)];
			entity.AccumPoints = (reader.IsDBNull(((int)EdStudFacultyColumn.AccumPoints - 1)))?null:(System.Decimal?)reader[((int)EdStudFacultyColumn.AccumPoints - 1)];
			entity.EntMainGrad1 = (reader.IsDBNull(((int)EdStudFacultyColumn.EntMainGrad1 - 1)))?null:(System.Decimal?)reader[((int)EdStudFacultyColumn.EntMainGrad1 - 1)];
			entity.EntMainGrad2 = (reader.IsDBNull(((int)EdStudFacultyColumn.EntMainGrad2 - 1)))?null:(System.Decimal?)reader[((int)EdStudFacultyColumn.EntMainGrad2 - 1)];
			entity.EntMainGrad3 = (reader.IsDBNull(((int)EdStudFacultyColumn.EntMainGrad3 - 1)))?null:(System.Decimal?)reader[((int)EdStudFacultyColumn.EntMainGrad3 - 1)];
			entity.EntMainMatrixId = (reader.IsDBNull(((int)EdStudFacultyColumn.EntMainMatrixId - 1)))?null:(System.Decimal?)reader[((int)EdStudFacultyColumn.EntMainMatrixId - 1)];
			entity.TransferFlg = (reader.IsDBNull(((int)EdStudFacultyColumn.TransferFlg - 1)))?null:(System.Decimal?)reader[((int)EdStudFacultyColumn.TransferFlg - 1)];
			entity.AdmCodeTransferTypeId = (reader.IsDBNull(((int)EdStudFacultyColumn.AdmCodeTransferTypeId - 1)))?null:(System.Decimal?)reader[((int)EdStudFacultyColumn.AdmCodeTransferTypeId - 1)];
			entity.UnivApproveDate = (reader.IsDBNull(((int)EdStudFacultyColumn.UnivApproveDate - 1)))?null:(System.DateTime?)reader[((int)EdStudFacultyColumn.UnivApproveDate - 1)];
			entity.FacApproveDate = (reader.IsDBNull(((int)EdStudFacultyColumn.FacApproveDate - 1)))?null:(System.DateTime?)reader[((int)EdStudFacultyColumn.FacApproveDate - 1)];
			entity.DeptApproveDate = (reader.IsDBNull(((int)EdStudFacultyColumn.DeptApproveDate - 1)))?null:(System.DateTime?)reader[((int)EdStudFacultyColumn.DeptApproveDate - 1)];
			entity.EdCodeGradingId = (reader.IsDBNull(((int)EdStudFacultyColumn.EdCodeGradingId - 1)))?null:(System.Decimal?)reader[((int)EdStudFacultyColumn.EdCodeGradingId - 1)];
			entity.IsActive = (System.Decimal)reader[((int)EdStudFacultyColumn.IsActive - 1)];
			entity.Notes = (reader.IsDBNull(((int)EdStudFacultyColumn.Notes - 1)))?null:(System.String)reader[((int)EdStudFacultyColumn.Notes - 1)];
			entity.MajorCgpa = (reader.IsDBNull(((int)EdStudFacultyColumn.MajorCgpa - 1)))?null:(System.Decimal?)reader[((int)EdStudFacultyColumn.MajorCgpa - 1)];
			entity.Cgpa = (reader.IsDBNull(((int)EdStudFacultyColumn.Cgpa - 1)))?null:(System.Decimal?)reader[((int)EdStudFacultyColumn.Cgpa - 1)];
			entity.EdBylawId = (reader.IsDBNull(((int)EdStudFacultyColumn.EdBylawId - 1)))?null:(System.Decimal?)reader[((int)EdStudFacultyColumn.EdBylawId - 1)];
			entity.OldAlumniFlg = (reader.IsDBNull(((int)EdStudFacultyColumn.OldAlumniFlg - 1)))?null:(System.Decimal?)reader[((int)EdStudFacultyColumn.OldAlumniFlg - 1)];
			entity.StudCardFlg = (reader.IsDBNull(((int)EdStudFacultyColumn.StudCardFlg - 1)))?null:(System.Decimal?)reader[((int)EdStudFacultyColumn.StudCardFlg - 1)];
			entity.GrantingCode = (reader.IsDBNull(((int)EdStudFacultyColumn.GrantingCode - 1)))?null:(System.String)reader[((int)EdStudFacultyColumn.GrantingCode - 1)];
			entity.IsLast = (reader.IsDBNull(((int)EdStudFacultyColumn.IsLast - 1)))?null:(System.Decimal?)reader[((int)EdStudFacultyColumn.IsLast - 1)];
			entity.AmanestPermanentStopFlag = (reader.IsDBNull(((int)EdStudFacultyColumn.AmanestPermanentStopFlag - 1)))?null:(System.Decimal?)reader[((int)EdStudFacultyColumn.AmanestPermanentStopFlag - 1)];
			entity.BatchNo = (reader.IsDBNull(((int)EdStudFacultyColumn.BatchNo - 1)))?null:(System.String)reader[((int)EdStudFacultyColumn.BatchNo - 1)];
			entity.GsCdeHonorId = (reader.IsDBNull(((int)EdStudFacultyColumn.GsCdeHonorId - 1)))?null:(System.Decimal?)reader[((int)EdStudFacultyColumn.GsCdeHonorId - 1)];
			entity.TrnsfrFrom = (reader.IsDBNull(((int)EdStudFacultyColumn.TrnsfrFrom - 1)))?null:(System.String)reader[((int)EdStudFacultyColumn.TrnsfrFrom - 1)];
			entity.TrnsfrNotes = (reader.IsDBNull(((int)EdStudFacultyColumn.TrnsfrNotes - 1)))?null:(System.String)reader[((int)EdStudFacultyColumn.TrnsfrNotes - 1)];
			entity.TrnsfrDate = (reader.IsDBNull(((int)EdStudFacultyColumn.TrnsfrDate - 1)))?null:(System.DateTime?)reader[((int)EdStudFacultyColumn.TrnsfrDate - 1)];
			entity.OrgFacultyNameAr = (reader.IsDBNull(((int)EdStudFacultyColumn.OrgFacultyNameAr - 1)))?null:(System.String)reader[((int)EdStudFacultyColumn.OrgFacultyNameAr - 1)];
			entity.StudFeeBalance = (reader.IsDBNull(((int)EdStudFacultyColumn.StudFeeBalance - 1)))?null:(System.Decimal?)reader[((int)EdStudFacultyColumn.StudFeeBalance - 1)];
			entity.AccumPrcent = (reader.IsDBNull(((int)EdStudFacultyColumn.AccumPrcent - 1)))?null:(System.Decimal?)reader[((int)EdStudFacultyColumn.AccumPrcent - 1)];
			entity.HecId = (reader.IsDBNull(((int)EdStudFacultyColumn.HecId - 1)))?null:(System.String)reader[((int)EdStudFacultyColumn.HecId - 1)];
			entity.ExpctdGradDate = (reader.IsDBNull(((int)EdStudFacultyColumn.ExpctdGradDate - 1)))?null:(System.DateTime?)reader[((int)EdStudFacultyColumn.ExpctdGradDate - 1)];
			entity.AccumMarks = (reader.IsDBNull(((int)EdStudFacultyColumn.AccumMarks - 1)))?null:(System.Decimal?)reader[((int)EdStudFacultyColumn.AccumMarks - 1)];
			entity.AccumCourseMarks = (reader.IsDBNull(((int)EdStudFacultyColumn.AccumCourseMarks - 1)))?null:(System.Decimal?)reader[((int)EdStudFacultyColumn.AccumCourseMarks - 1)];
			entity.MotherId = (reader.IsDBNull(((int)EdStudFacultyColumn.MotherId - 1)))?null:(System.String)reader[((int)EdStudFacultyColumn.MotherId - 1)];
			entity.PartTimeFlg = (reader.IsDBNull(((int)EdStudFacultyColumn.PartTimeFlg - 1)))?null:(System.Boolean?)reader[((int)EdStudFacultyColumn.PartTimeFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudFaculty"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudFaculty"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudFaculty entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudFacultyId = (System.Decimal)dataRow["ED_STUD_FACULTY_ID"];
			entity.OriginalEdStudFacultyId = (System.Decimal)dataRow["ED_STUD_FACULTY_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.AsCodeDegreeId = (System.Decimal)dataRow["AS_CODE_DEGREE_ID"];
			entity.StudFacultyCode = Convert.IsDBNull(dataRow["STUD_FACULTY_CODE"]) ? null : (System.String)dataRow["STUD_FACULTY_CODE"];
			entity.AdmCdeAppTypeId = Convert.IsDBNull(dataRow["ADM_CDE_APP_TYPE_ID"]) ? null : (System.Decimal?)dataRow["ADM_CDE_APP_TYPE_ID"];
			entity.EdAcadYearJoinId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_JOIN_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_JOIN_ID"];
			entity.EdCodeSemesterJoinId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_JOIN_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_JOIN_ID"];
			entity.EnrollDate = Convert.IsDBNull(dataRow["ENROLL_DATE"]) ? null : (System.DateTime?)dataRow["ENROLL_DATE"];
			entity.ComptativeRate = Convert.IsDBNull(dataRow["COMPTATIVE_RATE"]) ? null : (System.Decimal?)dataRow["COMPTATIVE_RATE"];
			entity.FullTimeFlg = Convert.IsDBNull(dataRow["FULL_TIME_FLG"]) ? null : (System.Decimal?)dataRow["FULL_TIME_FLG"];
			entity.EdCdeQualPhase = Convert.IsDBNull(dataRow["ED_CDE_QUAL_PHASE"]) ? null : (System.Decimal?)dataRow["ED_CDE_QUAL_PHASE"];
			entity.EdStudQualId = Convert.IsDBNull(dataRow["ED_STUD_QUAL_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_QUAL_ID"];
			entity.GraduatesFlag = (System.Decimal)dataRow["GRADUATES_FLAG"];
			entity.EdAcadYearId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_ID"];
			entity.WithHonor = Convert.IsDBNull(dataRow["WITH_HONOR"]) ? null : (System.Decimal?)dataRow["WITH_HONOR"];
			entity.EntPolicyAccumHonorId = Convert.IsDBNull(dataRow["ENT_POLICY_ACCUM_HONOR_ID"]) ? null : (System.Decimal?)dataRow["ENT_POLICY_ACCUM_HONOR_ID"];
			entity.AccumCredit = Convert.IsDBNull(dataRow["ACCUM_CREDIT"]) ? null : (System.Decimal?)dataRow["ACCUM_CREDIT"];
			entity.AccumPoints = Convert.IsDBNull(dataRow["ACCUM_POINTS"]) ? null : (System.Decimal?)dataRow["ACCUM_POINTS"];
			entity.EntMainGrad1 = Convert.IsDBNull(dataRow["ENT_MAIN_GRAD_1"]) ? null : (System.Decimal?)dataRow["ENT_MAIN_GRAD_1"];
			entity.EntMainGrad2 = Convert.IsDBNull(dataRow["ENT_MAIN_GRAD_2"]) ? null : (System.Decimal?)dataRow["ENT_MAIN_GRAD_2"];
			entity.EntMainGrad3 = Convert.IsDBNull(dataRow["ENT_MAIN_GRAD_3"]) ? null : (System.Decimal?)dataRow["ENT_MAIN_GRAD_3"];
			entity.EntMainMatrixId = Convert.IsDBNull(dataRow["ENT_MAIN_MATRIX_ID"]) ? null : (System.Decimal?)dataRow["ENT_MAIN_MATRIX_ID"];
			entity.TransferFlg = Convert.IsDBNull(dataRow["TRANSFER_FLG"]) ? null : (System.Decimal?)dataRow["TRANSFER_FLG"];
			entity.AdmCodeTransferTypeId = Convert.IsDBNull(dataRow["ADM_CODE_TRANSFER_TYPE_ID"]) ? null : (System.Decimal?)dataRow["ADM_CODE_TRANSFER_TYPE_ID"];
			entity.UnivApproveDate = Convert.IsDBNull(dataRow["UNIV_APPROVE_DATE"]) ? null : (System.DateTime?)dataRow["UNIV_APPROVE_DATE"];
			entity.FacApproveDate = Convert.IsDBNull(dataRow["FAC_APPROVE_DATE"]) ? null : (System.DateTime?)dataRow["FAC_APPROVE_DATE"];
			entity.DeptApproveDate = Convert.IsDBNull(dataRow["DEPT_APPROVE_DATE"]) ? null : (System.DateTime?)dataRow["DEPT_APPROVE_DATE"];
			entity.EdCodeGradingId = Convert.IsDBNull(dataRow["ED_CODE_GRADING_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_GRADING_ID"];
			entity.IsActive = (System.Decimal)dataRow["IS_ACTIVE"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.MajorCgpa = Convert.IsDBNull(dataRow["MAJOR_CGPA"]) ? null : (System.Decimal?)dataRow["MAJOR_CGPA"];
			entity.Cgpa = Convert.IsDBNull(dataRow["CGPA"]) ? null : (System.Decimal?)dataRow["CGPA"];
			entity.EdBylawId = Convert.IsDBNull(dataRow["ED_BYLAW_ID"]) ? null : (System.Decimal?)dataRow["ED_BYLAW_ID"];
			entity.OldAlumniFlg = Convert.IsDBNull(dataRow["OLD_ALUMNI_FLG"]) ? null : (System.Decimal?)dataRow["OLD_ALUMNI_FLG"];
			entity.StudCardFlg = Convert.IsDBNull(dataRow["STUD_CARD_FLG"]) ? null : (System.Decimal?)dataRow["STUD_CARD_FLG"];
			entity.GrantingCode = Convert.IsDBNull(dataRow["GRANTING_CODE"]) ? null : (System.String)dataRow["GRANTING_CODE"];
			entity.IsLast = Convert.IsDBNull(dataRow["IS_LAST"]) ? null : (System.Decimal?)dataRow["IS_LAST"];
			entity.AmanestPermanentStopFlag = Convert.IsDBNull(dataRow["AMANEST_PERMANENT_STOP_FLAG"]) ? null : (System.Decimal?)dataRow["AMANEST_PERMANENT_STOP_FLAG"];
			entity.BatchNo = Convert.IsDBNull(dataRow["BATCH_NO"]) ? null : (System.String)dataRow["BATCH_NO"];
			entity.GsCdeHonorId = Convert.IsDBNull(dataRow["GS_CDE_HONOR_ID"]) ? null : (System.Decimal?)dataRow["GS_CDE_HONOR_ID"];
			entity.TrnsfrFrom = Convert.IsDBNull(dataRow["TRNSFR_FROM"]) ? null : (System.String)dataRow["TRNSFR_FROM"];
			entity.TrnsfrNotes = Convert.IsDBNull(dataRow["TRNSFR_NOTES"]) ? null : (System.String)dataRow["TRNSFR_NOTES"];
			entity.TrnsfrDate = Convert.IsDBNull(dataRow["TRNSFR_DATE"]) ? null : (System.DateTime?)dataRow["TRNSFR_DATE"];
			entity.OrgFacultyNameAr = Convert.IsDBNull(dataRow["ORG_FACULTY_NAME_AR"]) ? null : (System.String)dataRow["ORG_FACULTY_NAME_AR"];
			entity.StudFeeBalance = Convert.IsDBNull(dataRow["STUD_FEE_BALANCE"]) ? null : (System.Decimal?)dataRow["STUD_FEE_BALANCE"];
			entity.AccumPrcent = Convert.IsDBNull(dataRow["ACCUM_PRCENT"]) ? null : (System.Decimal?)dataRow["ACCUM_PRCENT"];
			entity.HecId = Convert.IsDBNull(dataRow["HEC_ID"]) ? null : (System.String)dataRow["HEC_ID"];
			entity.ExpctdGradDate = Convert.IsDBNull(dataRow["EXPCTD_GRAD_DATE"]) ? null : (System.DateTime?)dataRow["EXPCTD_GRAD_DATE"];
			entity.AccumMarks = Convert.IsDBNull(dataRow["ACCUM_MARKS"]) ? null : (System.Decimal?)dataRow["ACCUM_MARKS"];
			entity.AccumCourseMarks = Convert.IsDBNull(dataRow["ACCUM_COURSE_MARKS"]) ? null : (System.Decimal?)dataRow["ACCUM_COURSE_MARKS"];
			entity.MotherId = Convert.IsDBNull(dataRow["Mother_ID"]) ? null : (System.String)dataRow["Mother_ID"];
			entity.PartTimeFlg = Convert.IsDBNull(dataRow["PART_TIME_FLG"]) ? null : (System.Boolean?)dataRow["PART_TIME_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudFaculty"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudFaculty Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudFaculty entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region AdmCdeAppTypeIdSource	
			if (CanDeepLoad(entity, "AdmCdeAppType|AdmCdeAppTypeIdSource", deepLoadType, innerList) 
				&& entity.AdmCdeAppTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmCdeAppTypeId ?? 0.0m);
				AdmCdeAppType tmpEntity = EntityManager.LocateEntity<AdmCdeAppType>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCdeAppType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCdeAppTypeIdSource = tmpEntity;
				else
					entity.AdmCdeAppTypeIdSource = DataRepository.AdmCdeAppTypeProvider.GetByAdmCdeAppTypeId(transactionManager, (entity.AdmCdeAppTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeAppTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCdeAppTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCdeAppTypeProvider.DeepLoad(transactionManager, entity.AdmCdeAppTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCdeAppTypeIdSource

			#region AdmCodeTransferTypeIdSource	
			if (CanDeepLoad(entity, "AdmCodeTransferType|AdmCodeTransferTypeIdSource", deepLoadType, innerList) 
				&& entity.AdmCodeTransferTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmCodeTransferTypeId ?? 0.0m);
				AdmCodeTransferType tmpEntity = EntityManager.LocateEntity<AdmCodeTransferType>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCodeTransferType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCodeTransferTypeIdSource = tmpEntity;
				else
					entity.AdmCodeTransferTypeIdSource = DataRepository.AdmCodeTransferTypeProvider.GetByAdmCodeTransferTypeId(transactionManager, (entity.AdmCodeTransferTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCodeTransferTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCodeTransferTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCodeTransferTypeProvider.DeepLoad(transactionManager, entity.AdmCodeTransferTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCodeTransferTypeIdSource

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

			#region EdAcadYearJoinIdSource	
			if (CanDeepLoad(entity, "EdAcadYear|EdAcadYearJoinIdSource", deepLoadType, innerList) 
				&& entity.EdAcadYearJoinIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdAcadYearJoinId ?? 0.0m);
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadYearJoinIdSource = tmpEntity;
				else
					entity.EdAcadYearJoinIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, (entity.EdAcadYearJoinId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadYearJoinIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdAcadYearJoinIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdAcadYearProvider.DeepLoad(transactionManager, entity.EdAcadYearJoinIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdAcadYearJoinIdSource

			#region EdBylawIdSource	
			if (CanDeepLoad(entity, "EdBylaw|EdBylawIdSource", deepLoadType, innerList) 
				&& entity.EdBylawIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdBylawId ?? 0.0m);
				EdBylaw tmpEntity = EntityManager.LocateEntity<EdBylaw>(EntityLocator.ConstructKeyFromPkItems(typeof(EdBylaw), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdBylawIdSource = tmpEntity;
				else
					entity.EdBylawIdSource = DataRepository.EdBylawProvider.GetByEdBylawId(transactionManager, (entity.EdBylawId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdBylawIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdBylawIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdBylawProvider.DeepLoad(transactionManager, entity.EdBylawIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdBylawIdSource

			#region EdCdeQualPhaseSource	
			if (CanDeepLoad(entity, "EdCdeQualPhase|EdCdeQualPhaseSource", deepLoadType, innerList) 
				&& entity.EdCdeQualPhaseSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCdeQualPhase ?? 0.0m);
				EdCdeQualPhase tmpEntity = EntityManager.LocateEntity<EdCdeQualPhase>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeQualPhase), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCdeQualPhaseSource = tmpEntity;
				else
					entity.EdCdeQualPhaseSource = DataRepository.EdCdeQualPhaseProvider.GetByEdCdeQualPhase(transactionManager, (entity.EdCdeQualPhase ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeQualPhaseSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCdeQualPhaseSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCdeQualPhaseProvider.DeepLoad(transactionManager, entity.EdCdeQualPhaseSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCdeQualPhaseSource

			#region EdCodeGradingIdSource	
			if (CanDeepLoad(entity, "EdCodeGrading|EdCodeGradingIdSource", deepLoadType, innerList) 
				&& entity.EdCodeGradingIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeGradingId ?? 0.0m);
				EdCodeGrading tmpEntity = EntityManager.LocateEntity<EdCodeGrading>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeGrading), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeGradingIdSource = tmpEntity;
				else
					entity.EdCodeGradingIdSource = DataRepository.EdCodeGradingProvider.GetByEdCodeGradingId(transactionManager, (entity.EdCodeGradingId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeGradingIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeGradingIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeGradingProvider.DeepLoad(transactionManager, entity.EdCodeGradingIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeGradingIdSource

			#region EdCodeSemesterJoinIdSource	
			if (CanDeepLoad(entity, "EdCodeSemester|EdCodeSemesterJoinIdSource", deepLoadType, innerList) 
				&& entity.EdCodeSemesterJoinIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeSemesterJoinId ?? 0.0m);
				EdCodeSemester tmpEntity = EntityManager.LocateEntity<EdCodeSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemesterJoinIdSource = tmpEntity;
				else
					entity.EdCodeSemesterJoinIdSource = DataRepository.EdCodeSemesterProvider.GetByEdCodeSemesterId(transactionManager, (entity.EdCodeSemesterJoinId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeSemesterJoinIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeSemesterJoinIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeSemesterProvider.DeepLoad(transactionManager, entity.EdCodeSemesterJoinIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeSemesterJoinIdSource

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

			#region EdStudQualIdSource	
			if (CanDeepLoad(entity, "EdStudQual|EdStudQualIdSource", deepLoadType, innerList) 
				&& entity.EdStudQualIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdStudQualId ?? 0.0m);
				EdStudQual tmpEntity = EntityManager.LocateEntity<EdStudQual>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudQual), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudQualIdSource = tmpEntity;
				else
					entity.EdStudQualIdSource = DataRepository.EdStudQualProvider.GetByEdStudQualId(transactionManager, (entity.EdStudQualId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudQualIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudQualIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudQualProvider.DeepLoad(transactionManager, entity.EdStudQualIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudQualIdSource

			#region EntMainMatrixIdSource	
			if (CanDeepLoad(entity, "EntMainMatrix|EntMainMatrixIdSource", deepLoadType, innerList) 
				&& entity.EntMainMatrixIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntMainMatrixId ?? 0.0m);
				EntMainMatrix tmpEntity = EntityManager.LocateEntity<EntMainMatrix>(EntityLocator.ConstructKeyFromPkItems(typeof(EntMainMatrix), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntMainMatrixIdSource = tmpEntity;
				else
					entity.EntMainMatrixIdSource = DataRepository.EntMainMatrixProvider.GetByEntMainMatrixId(transactionManager, (entity.EntMainMatrixId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMainMatrixIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntMainMatrixIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntMainMatrixProvider.DeepLoad(transactionManager, entity.EntMainMatrixIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntMainMatrixIdSource

			#region EntPolicyAccumHonorIdSource	
			if (CanDeepLoad(entity, "EntPolicyAccumHonor|EntPolicyAccumHonorIdSource", deepLoadType, innerList) 
				&& entity.EntPolicyAccumHonorIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntPolicyAccumHonorId ?? 0.0m);
				EntPolicyAccumHonor tmpEntity = EntityManager.LocateEntity<EntPolicyAccumHonor>(EntityLocator.ConstructKeyFromPkItems(typeof(EntPolicyAccumHonor), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntPolicyAccumHonorIdSource = tmpEntity;
				else
					entity.EntPolicyAccumHonorIdSource = DataRepository.EntPolicyAccumHonorProvider.GetByEntPolicyAccumHonorId(transactionManager, (entity.EntPolicyAccumHonorId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyAccumHonorIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntPolicyAccumHonorIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntPolicyAccumHonorProvider.DeepLoad(transactionManager, entity.EntPolicyAccumHonorIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntPolicyAccumHonorIdSource

			#region EntMainGrad1Source	
			if (CanDeepLoad(entity, "EntityMain|EntMainGrad1Source", deepLoadType, innerList) 
				&& entity.EntMainGrad1Source == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntMainGrad1 ?? 0.0m);
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntMainGrad1Source = tmpEntity;
				else
					entity.EntMainGrad1Source = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, (entity.EntMainGrad1 ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMainGrad1Source' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntMainGrad1Source != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntityMainProvider.DeepLoad(transactionManager, entity.EntMainGrad1Source, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntMainGrad1Source

			#region EntMainGrad2Source	
			if (CanDeepLoad(entity, "EntityMain|EntMainGrad2Source", deepLoadType, innerList) 
				&& entity.EntMainGrad2Source == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntMainGrad2 ?? 0.0m);
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntMainGrad2Source = tmpEntity;
				else
					entity.EntMainGrad2Source = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, (entity.EntMainGrad2 ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMainGrad2Source' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntMainGrad2Source != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntityMainProvider.DeepLoad(transactionManager, entity.EntMainGrad2Source, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntMainGrad2Source

			#region EntMainGrad3Source	
			if (CanDeepLoad(entity, "EntityMain|EntMainGrad3Source", deepLoadType, innerList) 
				&& entity.EntMainGrad3Source == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntMainGrad3 ?? 0.0m);
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntMainGrad3Source = tmpEntity;
				else
					entity.EntMainGrad3Source = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, (entity.EntMainGrad3 ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMainGrad3Source' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntMainGrad3Source != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntityMainProvider.DeepLoad(transactionManager, entity.EntMainGrad3Source, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntMainGrad3Source

			#region GsCdeHonorIdSource	
			if (CanDeepLoad(entity, "GsCdeHonor|GsCdeHonorIdSource", deepLoadType, innerList) 
				&& entity.GsCdeHonorIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCdeHonorId ?? 0.0m);
				GsCdeHonor tmpEntity = EntityManager.LocateEntity<GsCdeHonor>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeHonor), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeHonorIdSource = tmpEntity;
				else
					entity.GsCdeHonorIdSource = DataRepository.GsCdeHonorProvider.GetByGsCdeHonorId(transactionManager, (entity.GsCdeHonorId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeHonorIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeHonorIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeHonorProvider.DeepLoad(transactionManager, entity.GsCdeHonorIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeHonorIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdStudFacultyId methods when available
			
			#region PgThesisStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisStud>|PgThesisStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisStudCollection = DataRepository.PgThesisStudProvider.GetByEdStudFacultyId(transactionManager, entity.EdStudFacultyId);

				if (deep && entity.PgThesisStudCollection.Count > 0)
				{
					deepHandles.Add("PgThesisStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisStud>) DataRepository.PgThesisStudProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisStudCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudFaculty object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudFaculty instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudFaculty Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudFaculty entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
			}
			#endregion 
			
			#region AdmCdeAppTypeIdSource
			if (CanDeepSave(entity, "AdmCdeAppType|AdmCdeAppTypeIdSource", deepSaveType, innerList) 
				&& entity.AdmCdeAppTypeIdSource != null)
			{
				DataRepository.AdmCdeAppTypeProvider.Save(transactionManager, entity.AdmCdeAppTypeIdSource);
				entity.AdmCdeAppTypeId = entity.AdmCdeAppTypeIdSource.AdmCdeAppTypeId;
			}
			#endregion 
			
			#region AdmCodeTransferTypeIdSource
			if (CanDeepSave(entity, "AdmCodeTransferType|AdmCodeTransferTypeIdSource", deepSaveType, innerList) 
				&& entity.AdmCodeTransferTypeIdSource != null)
			{
				DataRepository.AdmCodeTransferTypeProvider.Save(transactionManager, entity.AdmCodeTransferTypeIdSource);
				entity.AdmCodeTransferTypeId = entity.AdmCodeTransferTypeIdSource.AdmCodeTransferTypeId;
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
			
			#region AsFacultyInfoIdSource
			if (CanDeepSave(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepSaveType, innerList) 
				&& entity.AsFacultyInfoIdSource != null)
			{
				DataRepository.AsFacultyInfoProvider.Save(transactionManager, entity.AsFacultyInfoIdSource);
				entity.AsFacultyInfoId = entity.AsFacultyInfoIdSource.AsFacultyInfoId;
			}
			#endregion 
			
			#region EdAcadYearJoinIdSource
			if (CanDeepSave(entity, "EdAcadYear|EdAcadYearJoinIdSource", deepSaveType, innerList) 
				&& entity.EdAcadYearJoinIdSource != null)
			{
				DataRepository.EdAcadYearProvider.Save(transactionManager, entity.EdAcadYearJoinIdSource);
				entity.EdAcadYearJoinId = entity.EdAcadYearJoinIdSource.EdAcadYearId;
			}
			#endregion 
			
			#region EdBylawIdSource
			if (CanDeepSave(entity, "EdBylaw|EdBylawIdSource", deepSaveType, innerList) 
				&& entity.EdBylawIdSource != null)
			{
				DataRepository.EdBylawProvider.Save(transactionManager, entity.EdBylawIdSource);
				entity.EdBylawId = entity.EdBylawIdSource.EdBylawId;
			}
			#endregion 
			
			#region EdCdeQualPhaseSource
			if (CanDeepSave(entity, "EdCdeQualPhase|EdCdeQualPhaseSource", deepSaveType, innerList) 
				&& entity.EdCdeQualPhaseSource != null)
			{
				DataRepository.EdCdeQualPhaseProvider.Save(transactionManager, entity.EdCdeQualPhaseSource);
				entity.EdCdeQualPhase = entity.EdCdeQualPhaseSource.EdCdeQualPhase;
			}
			#endregion 
			
			#region EdCodeGradingIdSource
			if (CanDeepSave(entity, "EdCodeGrading|EdCodeGradingIdSource", deepSaveType, innerList) 
				&& entity.EdCodeGradingIdSource != null)
			{
				DataRepository.EdCodeGradingProvider.Save(transactionManager, entity.EdCodeGradingIdSource);
				entity.EdCodeGradingId = entity.EdCodeGradingIdSource.EdCodeGradingId;
			}
			#endregion 
			
			#region EdCodeSemesterJoinIdSource
			if (CanDeepSave(entity, "EdCodeSemester|EdCodeSemesterJoinIdSource", deepSaveType, innerList) 
				&& entity.EdCodeSemesterJoinIdSource != null)
			{
				DataRepository.EdCodeSemesterProvider.Save(transactionManager, entity.EdCodeSemesterJoinIdSource);
				entity.EdCodeSemesterJoinId = entity.EdCodeSemesterJoinIdSource.EdCodeSemesterId;
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
			
			#region EdStudQualIdSource
			if (CanDeepSave(entity, "EdStudQual|EdStudQualIdSource", deepSaveType, innerList) 
				&& entity.EdStudQualIdSource != null)
			{
				DataRepository.EdStudQualProvider.Save(transactionManager, entity.EdStudQualIdSource);
				entity.EdStudQualId = entity.EdStudQualIdSource.EdStudQualId;
			}
			#endregion 
			
			#region EntMainMatrixIdSource
			if (CanDeepSave(entity, "EntMainMatrix|EntMainMatrixIdSource", deepSaveType, innerList) 
				&& entity.EntMainMatrixIdSource != null)
			{
				DataRepository.EntMainMatrixProvider.Save(transactionManager, entity.EntMainMatrixIdSource);
				entity.EntMainMatrixId = entity.EntMainMatrixIdSource.EntMainMatrixId;
			}
			#endregion 
			
			#region EntPolicyAccumHonorIdSource
			if (CanDeepSave(entity, "EntPolicyAccumHonor|EntPolicyAccumHonorIdSource", deepSaveType, innerList) 
				&& entity.EntPolicyAccumHonorIdSource != null)
			{
				DataRepository.EntPolicyAccumHonorProvider.Save(transactionManager, entity.EntPolicyAccumHonorIdSource);
				entity.EntPolicyAccumHonorId = entity.EntPolicyAccumHonorIdSource.EntPolicyAccumHonorId;
			}
			#endregion 
			
			#region EntMainGrad1Source
			if (CanDeepSave(entity, "EntityMain|EntMainGrad1Source", deepSaveType, innerList) 
				&& entity.EntMainGrad1Source != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.EntMainGrad1Source);
				entity.EntMainGrad1 = entity.EntMainGrad1Source.EntMainId;
			}
			#endregion 
			
			#region EntMainGrad2Source
			if (CanDeepSave(entity, "EntityMain|EntMainGrad2Source", deepSaveType, innerList) 
				&& entity.EntMainGrad2Source != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.EntMainGrad2Source);
				entity.EntMainGrad2 = entity.EntMainGrad2Source.EntMainId;
			}
			#endregion 
			
			#region EntMainGrad3Source
			if (CanDeepSave(entity, "EntityMain|EntMainGrad3Source", deepSaveType, innerList) 
				&& entity.EntMainGrad3Source != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.EntMainGrad3Source);
				entity.EntMainGrad3 = entity.EntMainGrad3Source.EntMainId;
			}
			#endregion 
			
			#region GsCdeHonorIdSource
			if (CanDeepSave(entity, "GsCdeHonor|GsCdeHonorIdSource", deepSaveType, innerList) 
				&& entity.GsCdeHonorIdSource != null)
			{
				DataRepository.GsCdeHonorProvider.Save(transactionManager, entity.GsCdeHonorIdSource);
				entity.GsCdeHonorId = entity.GsCdeHonorIdSource.GsCdeHonorId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<PgThesisStud>
				if (CanDeepSave(entity.PgThesisStudCollection, "List<PgThesisStud>|PgThesisStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisStud child in entity.PgThesisStudCollection)
					{
						if(child.EdStudFacultyIdSource != null)
						{
							child.EdStudFacultyId = child.EdStudFacultyIdSource.EdStudFacultyId;
						}
						else
						{
							child.EdStudFacultyId = entity.EdStudFacultyId;
						}

					}

					if (entity.PgThesisStudCollection.Count > 0 || entity.PgThesisStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisStudProvider.Save(transactionManager, entity.PgThesisStudCollection);
						
						deepHandles.Add("PgThesisStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisStud >) DataRepository.PgThesisStudProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisStudCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdStudFacultyChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudFaculty</c>
	///</summary>
	public enum EdStudFacultyChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>AdmCdeAppType</c> at AdmCdeAppTypeIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdeAppType))]
		AdmCdeAppType,
		
		///<summary>
		/// Composite Property for <c>AdmCodeTransferType</c> at AdmCodeTransferTypeIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCodeTransferType))]
		AdmCodeTransferType,
		
		///<summary>
		/// Composite Property for <c>AsCodeDegree</c> at AsCodeDegreeIdSource
		///</summary>
		[ChildEntityType(typeof(AsCodeDegree))]
		AsCodeDegree,
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>EdBylaw</c> at EdBylawIdSource
		///</summary>
		[ChildEntityType(typeof(EdBylaw))]
		EdBylaw,
		
		///<summary>
		/// Composite Property for <c>EdCdeQualPhase</c> at EdCdeQualPhaseSource
		///</summary>
		[ChildEntityType(typeof(EdCdeQualPhase))]
		EdCdeQualPhase,
		
		///<summary>
		/// Composite Property for <c>EdCodeGrading</c> at EdCodeGradingIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeGrading))]
		EdCodeGrading,
		
		///<summary>
		/// Composite Property for <c>EdCodeSemester</c> at EdCodeSemesterJoinIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemester))]
		EdCodeSemester,
		
		///<summary>
		/// Composite Property for <c>EdStudQual</c> at EdStudQualIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudQual))]
		EdStudQual,
		
		///<summary>
		/// Composite Property for <c>EntMainMatrix</c> at EntMainMatrixIdSource
		///</summary>
		[ChildEntityType(typeof(EntMainMatrix))]
		EntMainMatrix,
		
		///<summary>
		/// Composite Property for <c>EntPolicyAccumHonor</c> at EntPolicyAccumHonorIdSource
		///</summary>
		[ChildEntityType(typeof(EntPolicyAccumHonor))]
		EntPolicyAccumHonor,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainGrad1Source
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		
		///<summary>
		/// Composite Property for <c>GsCdeHonor</c> at GsCdeHonorIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeHonor))]
		GsCdeHonor,
		///<summary>
		/// Collection of <c>EdStudFaculty</c> as OneToMany for PgThesisStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisStud>))]
		PgThesisStudCollection,
	}
	
	#endregion EdStudFacultyChildEntityTypes
	
	#region EdStudFacultyFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudFacultyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudFaculty"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudFacultyFilterBuilder : SqlFilterBuilder<EdStudFacultyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudFacultyFilterBuilder class.
		/// </summary>
		public EdStudFacultyFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudFacultyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudFacultyFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudFacultyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudFacultyFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudFacultyFilterBuilder
	
	#region EdStudFacultyParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudFacultyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudFaculty"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudFacultyParameterBuilder : ParameterizedSqlFilterBuilder<EdStudFacultyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudFacultyParameterBuilder class.
		/// </summary>
		public EdStudFacultyParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudFacultyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudFacultyParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudFacultyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudFacultyParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudFacultyParameterBuilder
	
	#region EdStudFacultySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudFacultyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudFaculty"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudFacultySortBuilder : SqlSortBuilder<EdStudFacultyColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudFacultySqlSortBuilder class.
		/// </summary>
		public EdStudFacultySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudFacultySortBuilder
	
} // end namespace
