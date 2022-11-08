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
	/// This class is the base class for any <see cref="ScSectionGroupHdrProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScSectionGroupHdrProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.ScSectionGroupHdr, UMIS_VER2.BusinessLyer.ScSectionGroupHdrKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScSectionGroupHdrKey key)
		{
			return Delete(transactionManager, key.ScSectionGroupHdrId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_scSectionGroupHdrId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _scSectionGroupHdrId)
		{
			return Delete(null, _scSectionGroupHdrId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSectionGroupHdrId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _scSectionGroupHdrId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEC_GRP_HDR_ED_ACAD_YEAR key.
		///		FK_ED_SEC_GRP_HDR_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public TList<ScSectionGroupHdr> GetByEdAcadYearId(System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEC_GRP_HDR_ED_ACAD_YEAR key.
		///		FK_ED_SEC_GRP_HDR_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		/// <remarks></remarks>
		public TList<ScSectionGroupHdr> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEC_GRP_HDR_ED_ACAD_YEAR key.
		///		FK_ED_SEC_GRP_HDR_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public TList<ScSectionGroupHdr> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEC_GRP_HDR_ED_ACAD_YEAR key.
		///		fkEdSecGrpHdrEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public TList<ScSectionGroupHdr> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEC_GRP_HDR_ED_ACAD_YEAR key.
		///		fkEdSecGrpHdrEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public TList<ScSectionGroupHdr> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEC_GRP_HDR_ED_ACAD_YEAR key.
		///		FK_ED_SEC_GRP_HDR_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public abstract TList<ScSectionGroupHdr> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEC_GRP_HDR_ED_CODE_SEMESTER key.
		///		FK_ED_SEC_GRP_HDR_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public TList<ScSectionGroupHdr> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEC_GRP_HDR_ED_CODE_SEMESTER key.
		///		FK_ED_SEC_GRP_HDR_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		/// <remarks></remarks>
		public TList<ScSectionGroupHdr> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEC_GRP_HDR_ED_CODE_SEMESTER key.
		///		FK_ED_SEC_GRP_HDR_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public TList<ScSectionGroupHdr> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEC_GRP_HDR_ED_CODE_SEMESTER key.
		///		fkEdSecGrpHdrEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public TList<ScSectionGroupHdr> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEC_GRP_HDR_ED_CODE_SEMESTER key.
		///		fkEdSecGrpHdrEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public TList<ScSectionGroupHdr> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEC_GRP_HDR_ED_CODE_SEMESTER key.
		///		FK_ED_SEC_GRP_HDR_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public abstract TList<ScSectionGroupHdr> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_HDR_AS_CODE_DEGREE_CLASS key.
		///		FK_SC_SECTION_GROUP_HDR_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public TList<ScSectionGroupHdr> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(_asCodeDegreeClassId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_HDR_AS_CODE_DEGREE_CLASS key.
		///		FK_SC_SECTION_GROUP_HDR_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		/// <remarks></remarks>
		public TList<ScSectionGroupHdr> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_HDR_AS_CODE_DEGREE_CLASS key.
		///		FK_SC_SECTION_GROUP_HDR_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public TList<ScSectionGroupHdr> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_HDR_AS_CODE_DEGREE_CLASS key.
		///		fkScSectionGroupHdrAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public TList<ScSectionGroupHdr> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_HDR_AS_CODE_DEGREE_CLASS key.
		///		fkScSectionGroupHdrAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public TList<ScSectionGroupHdr> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_HDR_AS_CODE_DEGREE_CLASS key.
		///		FK_SC_SECTION_GROUP_HDR_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public abstract TList<ScSectionGroupHdr> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_HDR_AS_FACULTY_INFO key.
		///		FK_SC_SECTION_GROUP_HDR_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public TList<ScSectionGroupHdr> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_HDR_AS_FACULTY_INFO key.
		///		FK_SC_SECTION_GROUP_HDR_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		/// <remarks></remarks>
		public TList<ScSectionGroupHdr> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_HDR_AS_FACULTY_INFO key.
		///		FK_SC_SECTION_GROUP_HDR_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public TList<ScSectionGroupHdr> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_HDR_AS_FACULTY_INFO key.
		///		fkScSectionGroupHdrAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public TList<ScSectionGroupHdr> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_HDR_AS_FACULTY_INFO key.
		///		fkScSectionGroupHdrAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public TList<ScSectionGroupHdr> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_HDR_AS_FACULTY_INFO key.
		///		FK_SC_SECTION_GROUP_HDR_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public abstract TList<ScSectionGroupHdr> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_HDR_ED_CODE_LEVEL key.
		///		FK_SC_SECTION_GROUP_HDR_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="_edCodeLevelId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public TList<ScSectionGroupHdr> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(_edCodeLevelId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_HDR_ED_CODE_LEVEL key.
		///		FK_SC_SECTION_GROUP_HDR_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		/// <remarks></remarks>
		public TList<ScSectionGroupHdr> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_HDR_ED_CODE_LEVEL key.
		///		FK_SC_SECTION_GROUP_HDR_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public TList<ScSectionGroupHdr> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_HDR_ED_CODE_LEVEL key.
		///		fkScSectionGroupHdrEdCodeLevel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public TList<ScSectionGroupHdr> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_HDR_ED_CODE_LEVEL key.
		///		fkScSectionGroupHdrEdCodeLevel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public TList<ScSectionGroupHdr> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId, int start, int pageLength,out int count)
		{
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_HDR_ED_CODE_LEVEL key.
		///		FK_SC_SECTION_GROUP_HDR_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public abstract TList<ScSectionGroupHdr> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_HDR_ED_COURSE key.
		///		FK_SC_SECTION_GROUP_HDR_ED_COURSE Description: 
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public TList<ScSectionGroupHdr> GetByEdCourseId(System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(_edCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_HDR_ED_COURSE key.
		///		FK_SC_SECTION_GROUP_HDR_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		/// <remarks></remarks>
		public TList<ScSectionGroupHdr> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_HDR_ED_COURSE key.
		///		FK_SC_SECTION_GROUP_HDR_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public TList<ScSectionGroupHdr> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_HDR_ED_COURSE key.
		///		fkScSectionGroupHdrEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public TList<ScSectionGroupHdr> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_HDR_ED_COURSE key.
		///		fkScSectionGroupHdrEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public TList<ScSectionGroupHdr> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength,out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_HDR_ED_COURSE key.
		///		FK_SC_SECTION_GROUP_HDR_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public abstract TList<ScSectionGroupHdr> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_HDR_ENTITY_MAIN key.
		///		FK_SC_SECTION_GROUP_HDR_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public TList<ScSectionGroupHdr> GetByEntMainId(System.Decimal? _entMainId)
		{
			int count = -1;
			return GetByEntMainId(_entMainId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_HDR_ENTITY_MAIN key.
		///		FK_SC_SECTION_GROUP_HDR_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		/// <remarks></remarks>
		public TList<ScSectionGroupHdr> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_HDR_ENTITY_MAIN key.
		///		FK_SC_SECTION_GROUP_HDR_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public TList<ScSectionGroupHdr> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_HDR_ENTITY_MAIN key.
		///		fkScSectionGroupHdrEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public TList<ScSectionGroupHdr> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainId(null, _entMainId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_HDR_ENTITY_MAIN key.
		///		fkScSectionGroupHdrEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public TList<ScSectionGroupHdr> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength,out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_HDR_ENTITY_MAIN key.
		///		FK_SC_SECTION_GROUP_HDR_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public abstract TList<ScSectionGroupHdr> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_HDR_GS_CODE_LANGUAGE key.
		///		FK_SC_SECTION_GROUP_HDR_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="_gsCodeLanguageId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public TList<ScSectionGroupHdr> GetByGsCodeLanguageId(System.Decimal? _gsCodeLanguageId)
		{
			int count = -1;
			return GetByGsCodeLanguageId(_gsCodeLanguageId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_HDR_GS_CODE_LANGUAGE key.
		///		FK_SC_SECTION_GROUP_HDR_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		/// <remarks></remarks>
		public TList<ScSectionGroupHdr> GetByGsCodeLanguageId(TransactionManager transactionManager, System.Decimal? _gsCodeLanguageId)
		{
			int count = -1;
			return GetByGsCodeLanguageId(transactionManager, _gsCodeLanguageId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_HDR_GS_CODE_LANGUAGE key.
		///		FK_SC_SECTION_GROUP_HDR_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public TList<ScSectionGroupHdr> GetByGsCodeLanguageId(TransactionManager transactionManager, System.Decimal? _gsCodeLanguageId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeLanguageId(transactionManager, _gsCodeLanguageId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_HDR_GS_CODE_LANGUAGE key.
		///		fkScSectionGroupHdrGsCodeLanguage Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public TList<ScSectionGroupHdr> GetByGsCodeLanguageId(System.Decimal? _gsCodeLanguageId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeLanguageId(null, _gsCodeLanguageId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_HDR_GS_CODE_LANGUAGE key.
		///		fkScSectionGroupHdrGsCodeLanguage Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public TList<ScSectionGroupHdr> GetByGsCodeLanguageId(System.Decimal? _gsCodeLanguageId, int start, int pageLength,out int count)
		{
			return GetByGsCodeLanguageId(null, _gsCodeLanguageId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_HDR_GS_CODE_LANGUAGE key.
		///		FK_SC_SECTION_GROUP_HDR_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupHdr objects.</returns>
		public abstract TList<ScSectionGroupHdr> GetByGsCodeLanguageId(TransactionManager transactionManager, System.Decimal? _gsCodeLanguageId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.ScSectionGroupHdr Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScSectionGroupHdrKey key, int start, int pageLength)
		{
			return GetByScSectionGroupHdrId(transactionManager, key.ScSectionGroupHdrId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_SEC_GRP_HDR index.
		/// </summary>
		/// <param name="_scSectionGroupHdrId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSectionGroupHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScSectionGroupHdr GetByScSectionGroupHdrId(System.Decimal _scSectionGroupHdrId)
		{
			int count = -1;
			return GetByScSectionGroupHdrId(null,_scSectionGroupHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SEC_GRP_HDR index.
		/// </summary>
		/// <param name="_scSectionGroupHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSectionGroupHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScSectionGroupHdr GetByScSectionGroupHdrId(System.Decimal _scSectionGroupHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByScSectionGroupHdrId(null, _scSectionGroupHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SEC_GRP_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSectionGroupHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSectionGroupHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScSectionGroupHdr GetByScSectionGroupHdrId(TransactionManager transactionManager, System.Decimal _scSectionGroupHdrId)
		{
			int count = -1;
			return GetByScSectionGroupHdrId(transactionManager, _scSectionGroupHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SEC_GRP_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSectionGroupHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSectionGroupHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScSectionGroupHdr GetByScSectionGroupHdrId(TransactionManager transactionManager, System.Decimal _scSectionGroupHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByScSectionGroupHdrId(transactionManager, _scSectionGroupHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SEC_GRP_HDR index.
		/// </summary>
		/// <param name="_scSectionGroupHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSectionGroupHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScSectionGroupHdr GetByScSectionGroupHdrId(System.Decimal _scSectionGroupHdrId, int start, int pageLength, out int count)
		{
			return GetByScSectionGroupHdrId(null, _scSectionGroupHdrId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SEC_GRP_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSectionGroupHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSectionGroupHdr"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScSectionGroupHdr GetByScSectionGroupHdrId(TransactionManager transactionManager, System.Decimal _scSectionGroupHdrId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SC_SECTION_GROUP_HDR index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_groupCode"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSectionGroupHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScSectionGroupHdr GetByEdAcadYearIdEdCodeSemesterIdGroupCodeEdCourseIdAsFacultyInfoId(System.Decimal? _edAcadYearId, System.Decimal _edCodeSemesterId, System.String _groupCode, System.Decimal? _edCourseId, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdGroupCodeEdCourseIdAsFacultyInfoId(null,_edAcadYearId, _edCodeSemesterId, _groupCode, _edCourseId, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SECTION_GROUP_HDR index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_groupCode"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSectionGroupHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScSectionGroupHdr GetByEdAcadYearIdEdCodeSemesterIdGroupCodeEdCourseIdAsFacultyInfoId(System.Decimal? _edAcadYearId, System.Decimal _edCodeSemesterId, System.String _groupCode, System.Decimal? _edCourseId, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdGroupCodeEdCourseIdAsFacultyInfoId(null, _edAcadYearId, _edCodeSemesterId, _groupCode, _edCourseId, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SECTION_GROUP_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_groupCode"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSectionGroupHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScSectionGroupHdr GetByEdAcadYearIdEdCodeSemesterIdGroupCodeEdCourseIdAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, System.Decimal _edCodeSemesterId, System.String _groupCode, System.Decimal? _edCourseId, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdGroupCodeEdCourseIdAsFacultyInfoId(transactionManager, _edAcadYearId, _edCodeSemesterId, _groupCode, _edCourseId, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SECTION_GROUP_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_groupCode"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSectionGroupHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScSectionGroupHdr GetByEdAcadYearIdEdCodeSemesterIdGroupCodeEdCourseIdAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, System.Decimal _edCodeSemesterId, System.String _groupCode, System.Decimal? _edCourseId, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdGroupCodeEdCourseIdAsFacultyInfoId(transactionManager, _edAcadYearId, _edCodeSemesterId, _groupCode, _edCourseId, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SECTION_GROUP_HDR index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_groupCode"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSectionGroupHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScSectionGroupHdr GetByEdAcadYearIdEdCodeSemesterIdGroupCodeEdCourseIdAsFacultyInfoId(System.Decimal? _edAcadYearId, System.Decimal _edCodeSemesterId, System.String _groupCode, System.Decimal? _edCourseId, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count)
		{
			return GetByEdAcadYearIdEdCodeSemesterIdGroupCodeEdCourseIdAsFacultyInfoId(null, _edAcadYearId, _edCodeSemesterId, _groupCode, _edCourseId, _asFacultyInfoId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SECTION_GROUP_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_groupCode"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSectionGroupHdr"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScSectionGroupHdr GetByEdAcadYearIdEdCodeSemesterIdGroupCodeEdCourseIdAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, System.Decimal _edCodeSemesterId, System.String _groupCode, System.Decimal? _edCourseId, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ScSectionGroupHdr&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ScSectionGroupHdr&gt;"/></returns>
		public static TList<ScSectionGroupHdr> Fill(IDataReader reader, TList<ScSectionGroupHdr> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.ScSectionGroupHdr c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ScSectionGroupHdr")
					.Append("|").Append((System.Decimal)reader["SC_SECTION_GROUP_HDR_ID"]).ToString();
					c = EntityManager.LocateOrCreate<ScSectionGroupHdr>(
					key.ToString(), // EntityTrackingKey
					"ScSectionGroupHdr",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.ScSectionGroupHdr();
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
					c.ScSectionGroupHdrId = (System.Decimal)reader["SC_SECTION_GROUP_HDR_ID"];
					c.OriginalScSectionGroupHdrId = c.ScSectionGroupHdrId;
					c.GroupCode = (System.String)reader["GROUP_CODE"];
					c.EdAcadYearId = Convert.IsDBNull(reader["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.EdCodeLevelId = Convert.IsDBNull(reader["ED_CODE_LEVEL_ID"]) ? null : (System.Decimal?)reader["ED_CODE_LEVEL_ID"];
					c.GrpTypeFlg = (System.Decimal)reader["GRP_TYPE_FLG"];
					c.LoadFlg = (System.Decimal)reader["LOAD_FLG"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.EntMainId = Convert.IsDBNull(reader["ENT_MAIN_ID"]) ? null : (System.Decimal?)reader["ENT_MAIN_ID"];
					c.GsCodeLanguageId = Convert.IsDBNull(reader["GS_CODE_LANGUAGE_ID"]) ? null : (System.Decimal?)reader["GS_CODE_LANGUAGE_ID"];
					c.AsCodeDegreeClassId = Convert.IsDBNull(reader["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_CLASS_ID"];
					c.EdCourseId = Convert.IsDBNull(reader["ED_COURSE_ID"]) ? null : (System.Decimal?)reader["ED_COURSE_ID"];
					c.IsActive = Convert.IsDBNull(reader["IS_ACTIVE"]) ? null : (System.Boolean?)reader["IS_ACTIVE"];
					c.GrpDescAr = Convert.IsDBNull(reader["GRP_DESC_AR"]) ? null : (System.String)reader["GRP_DESC_AR"];
					c.GrpDescEn = Convert.IsDBNull(reader["GRP_DESC_EN"]) ? null : (System.String)reader["GRP_DESC_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScSectionGroupHdr"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScSectionGroupHdr"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.ScSectionGroupHdr entity)
		{
			if (!reader.Read()) return;
			
			entity.ScSectionGroupHdrId = (System.Decimal)reader[((int)ScSectionGroupHdrColumn.ScSectionGroupHdrId - 1)];
			entity.OriginalScSectionGroupHdrId = (System.Decimal)reader["SC_SECTION_GROUP_HDR_ID"];
			entity.GroupCode = (System.String)reader[((int)ScSectionGroupHdrColumn.GroupCode - 1)];
			entity.EdAcadYearId = (reader.IsDBNull(((int)ScSectionGroupHdrColumn.EdAcadYearId - 1)))?null:(System.Decimal?)reader[((int)ScSectionGroupHdrColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)ScSectionGroupHdrColumn.EdCodeSemesterId - 1)];
			entity.EdCodeLevelId = (reader.IsDBNull(((int)ScSectionGroupHdrColumn.EdCodeLevelId - 1)))?null:(System.Decimal?)reader[((int)ScSectionGroupHdrColumn.EdCodeLevelId - 1)];
			entity.GrpTypeFlg = (System.Decimal)reader[((int)ScSectionGroupHdrColumn.GrpTypeFlg - 1)];
			entity.LoadFlg = (System.Decimal)reader[((int)ScSectionGroupHdrColumn.LoadFlg - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)ScSectionGroupHdrColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)ScSectionGroupHdrColumn.AsFacultyInfoId - 1)];
			entity.EntMainId = (reader.IsDBNull(((int)ScSectionGroupHdrColumn.EntMainId - 1)))?null:(System.Decimal?)reader[((int)ScSectionGroupHdrColumn.EntMainId - 1)];
			entity.GsCodeLanguageId = (reader.IsDBNull(((int)ScSectionGroupHdrColumn.GsCodeLanguageId - 1)))?null:(System.Decimal?)reader[((int)ScSectionGroupHdrColumn.GsCodeLanguageId - 1)];
			entity.AsCodeDegreeClassId = (reader.IsDBNull(((int)ScSectionGroupHdrColumn.AsCodeDegreeClassId - 1)))?null:(System.Decimal?)reader[((int)ScSectionGroupHdrColumn.AsCodeDegreeClassId - 1)];
			entity.EdCourseId = (reader.IsDBNull(((int)ScSectionGroupHdrColumn.EdCourseId - 1)))?null:(System.Decimal?)reader[((int)ScSectionGroupHdrColumn.EdCourseId - 1)];
			entity.IsActive = (reader.IsDBNull(((int)ScSectionGroupHdrColumn.IsActive - 1)))?null:(System.Boolean?)reader[((int)ScSectionGroupHdrColumn.IsActive - 1)];
			entity.GrpDescAr = (reader.IsDBNull(((int)ScSectionGroupHdrColumn.GrpDescAr - 1)))?null:(System.String)reader[((int)ScSectionGroupHdrColumn.GrpDescAr - 1)];
			entity.GrpDescEn = (reader.IsDBNull(((int)ScSectionGroupHdrColumn.GrpDescEn - 1)))?null:(System.String)reader[((int)ScSectionGroupHdrColumn.GrpDescEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScSectionGroupHdr"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScSectionGroupHdr"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.ScSectionGroupHdr entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ScSectionGroupHdrId = (System.Decimal)dataRow["SC_SECTION_GROUP_HDR_ID"];
			entity.OriginalScSectionGroupHdrId = (System.Decimal)dataRow["SC_SECTION_GROUP_HDR_ID"];
			entity.GroupCode = (System.String)dataRow["GROUP_CODE"];
			entity.EdAcadYearId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.EdCodeLevelId = Convert.IsDBNull(dataRow["ED_CODE_LEVEL_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_LEVEL_ID"];
			entity.GrpTypeFlg = (System.Decimal)dataRow["GRP_TYPE_FLG"];
			entity.LoadFlg = (System.Decimal)dataRow["LOAD_FLG"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.EntMainId = Convert.IsDBNull(dataRow["ENT_MAIN_ID"]) ? null : (System.Decimal?)dataRow["ENT_MAIN_ID"];
			entity.GsCodeLanguageId = Convert.IsDBNull(dataRow["GS_CODE_LANGUAGE_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_LANGUAGE_ID"];
			entity.AsCodeDegreeClassId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_CLASS_ID"];
			entity.EdCourseId = Convert.IsDBNull(dataRow["ED_COURSE_ID"]) ? null : (System.Decimal?)dataRow["ED_COURSE_ID"];
			entity.IsActive = Convert.IsDBNull(dataRow["IS_ACTIVE"]) ? null : (System.Boolean?)dataRow["IS_ACTIVE"];
			entity.GrpDescAr = Convert.IsDBNull(dataRow["GRP_DESC_AR"]) ? null : (System.String)dataRow["GRP_DESC_AR"];
			entity.GrpDescEn = Convert.IsDBNull(dataRow["GRP_DESC_EN"]) ? null : (System.String)dataRow["GRP_DESC_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScSectionGroupHdr"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScSectionGroupHdr Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScSectionGroupHdr entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region GsCodeLanguageIdSource	
			if (CanDeepLoad(entity, "GsCodeLanguage|GsCodeLanguageIdSource", deepLoadType, innerList) 
				&& entity.GsCodeLanguageIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeLanguageId ?? 0.0m);
				GsCodeLanguage tmpEntity = EntityManager.LocateEntity<GsCodeLanguage>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeLanguage), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeLanguageIdSource = tmpEntity;
				else
					entity.GsCodeLanguageIdSource = DataRepository.GsCodeLanguageProvider.GetByGsCodeLanguageId(transactionManager, (entity.GsCodeLanguageId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeLanguageIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeLanguageIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeLanguageProvider.DeepLoad(transactionManager, entity.GsCodeLanguageIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeLanguageIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByScSectionGroupHdrId methods when available
			
			#region ScSectionGroupDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScSectionGroupDtl>|ScSectionGroupDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScSectionGroupDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScSectionGroupDtlCollection = DataRepository.ScSectionGroupDtlProvider.GetByScSectionGroupHdrId(transactionManager, entity.ScSectionGroupHdrId);

				if (deep && entity.ScSectionGroupDtlCollection.Count > 0)
				{
					deepHandles.Add("ScSectionGroupDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScSectionGroupDtl>) DataRepository.ScSectionGroupDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.ScSectionGroupDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseReg>|EdStudCourseRegCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegCollection = DataRepository.EdStudCourseRegProvider.GetByScSectionGroupHdrId(transactionManager, entity.ScSectionGroupHdrId);

				if (deep && entity.EdStudCourseRegCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseReg>) DataRepository.EdStudCourseRegProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegPreCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseRegPre>|EdStudCourseRegPreCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegPreCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegPreCollection = DataRepository.EdStudCourseRegPreProvider.GetByScSectionGroupHdrId(transactionManager, entity.ScSectionGroupHdrId);

				if (deep && entity.EdStudCourseRegPreCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegPreCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseRegPre>) DataRepository.EdStudCourseRegPreProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegPreCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.ScSectionGroupHdr object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.ScSectionGroupHdr instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScSectionGroupHdr Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScSectionGroupHdr entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdCodeLevelIdSource
			if (CanDeepSave(entity, "EdCodeLevel|EdCodeLevelIdSource", deepSaveType, innerList) 
				&& entity.EdCodeLevelIdSource != null)
			{
				DataRepository.EdCodeLevelProvider.Save(transactionManager, entity.EdCodeLevelIdSource);
				entity.EdCodeLevelId = entity.EdCodeLevelIdSource.EdCodeLevelId;
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
			
			#region EntMainIdSource
			if (CanDeepSave(entity, "EntityMain|EntMainIdSource", deepSaveType, innerList) 
				&& entity.EntMainIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.EntMainIdSource);
				entity.EntMainId = entity.EntMainIdSource.EntMainId;
			}
			#endregion 
			
			#region GsCodeLanguageIdSource
			if (CanDeepSave(entity, "GsCodeLanguage|GsCodeLanguageIdSource", deepSaveType, innerList) 
				&& entity.GsCodeLanguageIdSource != null)
			{
				DataRepository.GsCodeLanguageProvider.Save(transactionManager, entity.GsCodeLanguageIdSource);
				entity.GsCodeLanguageId = entity.GsCodeLanguageIdSource.GsCodeLanguageId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<ScSectionGroupDtl>
				if (CanDeepSave(entity.ScSectionGroupDtlCollection, "List<ScSectionGroupDtl>|ScSectionGroupDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScSectionGroupDtl child in entity.ScSectionGroupDtlCollection)
					{
						if(child.ScSectionGroupHdrIdSource != null)
						{
							child.ScSectionGroupHdrId = child.ScSectionGroupHdrIdSource.ScSectionGroupHdrId;
						}
						else
						{
							child.ScSectionGroupHdrId = entity.ScSectionGroupHdrId;
						}

					}

					if (entity.ScSectionGroupDtlCollection.Count > 0 || entity.ScSectionGroupDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScSectionGroupDtlProvider.Save(transactionManager, entity.ScSectionGroupDtlCollection);
						
						deepHandles.Add("ScSectionGroupDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScSectionGroupDtl >) DataRepository.ScSectionGroupDtlProvider.DeepSave,
							new object[] { transactionManager, entity.ScSectionGroupDtlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseReg>
				if (CanDeepSave(entity.EdStudCourseRegCollection, "List<EdStudCourseReg>|EdStudCourseRegCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseReg child in entity.EdStudCourseRegCollection)
					{
						if(child.ScSectionGroupHdrIdSource != null)
						{
							child.ScSectionGroupHdrId = child.ScSectionGroupHdrIdSource.ScSectionGroupHdrId;
						}
						else
						{
							child.ScSectionGroupHdrId = entity.ScSectionGroupHdrId;
						}

					}

					if (entity.EdStudCourseRegCollection.Count > 0 || entity.EdStudCourseRegCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegProvider.Save(transactionManager, entity.EdStudCourseRegCollection);
						
						deepHandles.Add("EdStudCourseRegCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseReg >) DataRepository.EdStudCourseRegProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseRegPre>
				if (CanDeepSave(entity.EdStudCourseRegPreCollection, "List<EdStudCourseRegPre>|EdStudCourseRegPreCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseRegPre child in entity.EdStudCourseRegPreCollection)
					{
						if(child.ScSectionGroupHdrIdSource != null)
						{
							child.ScSectionGroupHdrId = child.ScSectionGroupHdrIdSource.ScSectionGroupHdrId;
						}
						else
						{
							child.ScSectionGroupHdrId = entity.ScSectionGroupHdrId;
						}

					}

					if (entity.EdStudCourseRegPreCollection.Count > 0 || entity.EdStudCourseRegPreCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegPreProvider.Save(transactionManager, entity.EdStudCourseRegPreCollection);
						
						deepHandles.Add("EdStudCourseRegPreCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseRegPre >) DataRepository.EdStudCourseRegPreProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegPreCollection, deepSaveType, childTypes, innerList }
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
	
	#region ScSectionGroupHdrChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.ScSectionGroupHdr</c>
	///</summary>
	public enum ScSectionGroupHdrChildEntityTypes
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
		/// Composite Property for <c>EdCodeLevel</c> at EdCodeLevelIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeLevel))]
		EdCodeLevel,
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		
		///<summary>
		/// Composite Property for <c>GsCodeLanguage</c> at GsCodeLanguageIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeLanguage))]
		GsCodeLanguage,
		///<summary>
		/// Collection of <c>ScSectionGroupHdr</c> as OneToMany for ScSectionGroupDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScSectionGroupDtl>))]
		ScSectionGroupDtlCollection,
		///<summary>
		/// Collection of <c>ScSectionGroupHdr</c> as OneToMany for EdStudCourseRegCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseReg>))]
		EdStudCourseRegCollection,
		///<summary>
		/// Collection of <c>ScSectionGroupHdr</c> as OneToMany for EdStudCourseRegPreCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseRegPre>))]
		EdStudCourseRegPreCollection,
	}
	
	#endregion ScSectionGroupHdrChildEntityTypes
	
	#region ScSectionGroupHdrFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ScSectionGroupHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScSectionGroupHdr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScSectionGroupHdrFilterBuilder : SqlFilterBuilder<ScSectionGroupHdrColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScSectionGroupHdrFilterBuilder class.
		/// </summary>
		public ScSectionGroupHdrFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScSectionGroupHdrFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScSectionGroupHdrFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScSectionGroupHdrFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScSectionGroupHdrFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScSectionGroupHdrFilterBuilder
	
	#region ScSectionGroupHdrParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ScSectionGroupHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScSectionGroupHdr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScSectionGroupHdrParameterBuilder : ParameterizedSqlFilterBuilder<ScSectionGroupHdrColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScSectionGroupHdrParameterBuilder class.
		/// </summary>
		public ScSectionGroupHdrParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScSectionGroupHdrParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScSectionGroupHdrParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScSectionGroupHdrParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScSectionGroupHdrParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScSectionGroupHdrParameterBuilder
	
	#region ScSectionGroupHdrSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ScSectionGroupHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScSectionGroupHdr"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ScSectionGroupHdrSortBuilder : SqlSortBuilder<ScSectionGroupHdrColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScSectionGroupHdrSqlSortBuilder class.
		/// </summary>
		public ScSectionGroupHdrSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ScSectionGroupHdrSortBuilder
	
} // end namespace
