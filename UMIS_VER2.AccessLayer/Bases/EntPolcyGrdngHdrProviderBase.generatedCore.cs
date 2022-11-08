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
	/// This class is the base class for any <see cref="EntPolcyGrdngHdrProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntPolcyGrdngHdrProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr, UMIS_VER2.BusinessLyer.EntPolcyGrdngHdrKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolcyGrdngHdrKey key)
		{
			return Delete(transactionManager, key.EntPolcyGrdngHdrId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entPolcyGrdngHdrId">قواعد الرصد المؤقتة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entPolcyGrdngHdrId)
		{
			return Delete(null, _entPolcyGrdngHdrId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolcyGrdngHdrId">قواعد الرصد المؤقتة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entPolcyGrdngHdrId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_AS_FACULTY_INFO key.
		///		FK_ENT_POLCY_GRDNG_HDR_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_AS_FACULTY_INFO key.
		///		FK_ENT_POLCY_GRDNG_HDR_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		/// <remarks></remarks>
		public TList<EntPolcyGrdngHdr> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_AS_FACULTY_INFO key.
		///		FK_ENT_POLCY_GRDNG_HDR_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_AS_FACULTY_INFO key.
		///		fkEntPolcyGrdngHdrAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_AS_FACULTY_INFO key.
		///		fkEntPolcyGrdngHdrAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_AS_FACULTY_INFO key.
		///		FK_ENT_POLCY_GRDNG_HDR_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public abstract TList<EntPolcyGrdngHdr> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_ACAD_YEAR key.
		///		FK_ENT_POLCY_GRDNG_HDR_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_ACAD_YEAR key.
		///		FK_ENT_POLCY_GRDNG_HDR_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		/// <remarks></remarks>
		public TList<EntPolcyGrdngHdr> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_ACAD_YEAR key.
		///		FK_ENT_POLCY_GRDNG_HDR_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_ACAD_YEAR key.
		///		fkEntPolcyGrdngHdrEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_ACAD_YEAR key.
		///		fkEntPolcyGrdngHdrEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_ACAD_YEAR key.
		///		FK_ENT_POLCY_GRDNG_HDR_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public abstract TList<EntPolcyGrdngHdr> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_BYLAW key.
		///		FK_ENT_POLCY_GRDNG_HDR_ED_BYLAW Description: 
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByEdBylawId(System.Decimal? _edBylawId)
		{
			int count = -1;
			return GetByEdBylawId(_edBylawId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_BYLAW key.
		///		FK_ENT_POLCY_GRDNG_HDR_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		/// <remarks></remarks>
		public TList<EntPolcyGrdngHdr> GetByEdBylawId(TransactionManager transactionManager, System.Decimal? _edBylawId)
		{
			int count = -1;
			return GetByEdBylawId(transactionManager, _edBylawId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_BYLAW key.
		///		FK_ENT_POLCY_GRDNG_HDR_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByEdBylawId(TransactionManager transactionManager, System.Decimal? _edBylawId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBylawId(transactionManager, _edBylawId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_BYLAW key.
		///		fkEntPolcyGrdngHdrEdBylaw Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edBylawId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByEdBylawId(System.Decimal? _edBylawId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdBylawId(null, _edBylawId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_BYLAW key.
		///		fkEntPolcyGrdngHdrEdBylaw Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edBylawId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByEdBylawId(System.Decimal? _edBylawId, int start, int pageLength,out int count)
		{
			return GetByEdBylawId(null, _edBylawId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_BYLAW key.
		///		FK_ENT_POLCY_GRDNG_HDR_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public abstract TList<EntPolcyGrdngHdr> GetByEdBylawId(TransactionManager transactionManager, System.Decimal? _edBylawId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_CODE_COURSE_ASSESS key.
		///		FK_ENT_POLCY_GRDNG_HDR_ED_CODE_COURSE_ASSESS Description: 
		/// </summary>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByEdCodeCourseAssessId(System.Decimal? _edCodeCourseAssessId)
		{
			int count = -1;
			return GetByEdCodeCourseAssessId(_edCodeCourseAssessId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_CODE_COURSE_ASSESS key.
		///		FK_ENT_POLCY_GRDNG_HDR_ED_CODE_COURSE_ASSESS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		/// <remarks></remarks>
		public TList<EntPolcyGrdngHdr> GetByEdCodeCourseAssessId(TransactionManager transactionManager, System.Decimal? _edCodeCourseAssessId)
		{
			int count = -1;
			return GetByEdCodeCourseAssessId(transactionManager, _edCodeCourseAssessId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_CODE_COURSE_ASSESS key.
		///		FK_ENT_POLCY_GRDNG_HDR_ED_CODE_COURSE_ASSESS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByEdCodeCourseAssessId(TransactionManager transactionManager, System.Decimal? _edCodeCourseAssessId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseAssessId(transactionManager, _edCodeCourseAssessId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_CODE_COURSE_ASSESS key.
		///		fkEntPolcyGrdngHdrEdCodeCourseAssess Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByEdCodeCourseAssessId(System.Decimal? _edCodeCourseAssessId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeCourseAssessId(null, _edCodeCourseAssessId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_CODE_COURSE_ASSESS key.
		///		fkEntPolcyGrdngHdrEdCodeCourseAssess Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByEdCodeCourseAssessId(System.Decimal? _edCodeCourseAssessId, int start, int pageLength,out int count)
		{
			return GetByEdCodeCourseAssessId(null, _edCodeCourseAssessId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_CODE_COURSE_ASSESS key.
		///		FK_ENT_POLCY_GRDNG_HDR_ED_CODE_COURSE_ASSESS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public abstract TList<EntPolcyGrdngHdr> GetByEdCodeCourseAssessId(TransactionManager transactionManager, System.Decimal? _edCodeCourseAssessId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_CODE_COURSE_STATUS key.
		///		FK_ENT_POLCY_GRDNG_HDR_ED_CODE_COURSE_STATUS Description: 
		/// </summary>
		/// <param name="_edCodeCourseStatusNewId">الحاله الجديدة للمقرر على الطلاب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByEdCodeCourseStatusNewId(System.Decimal? _edCodeCourseStatusNewId)
		{
			int count = -1;
			return GetByEdCodeCourseStatusNewId(_edCodeCourseStatusNewId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_CODE_COURSE_STATUS key.
		///		FK_ENT_POLCY_GRDNG_HDR_ED_CODE_COURSE_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseStatusNewId">الحاله الجديدة للمقرر على الطلاب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		/// <remarks></remarks>
		public TList<EntPolcyGrdngHdr> GetByEdCodeCourseStatusNewId(TransactionManager transactionManager, System.Decimal? _edCodeCourseStatusNewId)
		{
			int count = -1;
			return GetByEdCodeCourseStatusNewId(transactionManager, _edCodeCourseStatusNewId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_CODE_COURSE_STATUS key.
		///		FK_ENT_POLCY_GRDNG_HDR_ED_CODE_COURSE_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseStatusNewId">الحاله الجديدة للمقرر على الطلاب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByEdCodeCourseStatusNewId(TransactionManager transactionManager, System.Decimal? _edCodeCourseStatusNewId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseStatusNewId(transactionManager, _edCodeCourseStatusNewId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_CODE_COURSE_STATUS key.
		///		fkEntPolcyGrdngHdrEdCodeCourseStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseStatusNewId">الحاله الجديدة للمقرر على الطلاب</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByEdCodeCourseStatusNewId(System.Decimal? _edCodeCourseStatusNewId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeCourseStatusNewId(null, _edCodeCourseStatusNewId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_CODE_COURSE_STATUS key.
		///		fkEntPolcyGrdngHdrEdCodeCourseStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseStatusNewId">الحاله الجديدة للمقرر على الطلاب</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByEdCodeCourseStatusNewId(System.Decimal? _edCodeCourseStatusNewId, int start, int pageLength,out int count)
		{
			return GetByEdCodeCourseStatusNewId(null, _edCodeCourseStatusNewId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_CODE_COURSE_STATUS key.
		///		FK_ENT_POLCY_GRDNG_HDR_ED_CODE_COURSE_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseStatusNewId">الحاله الجديدة للمقرر على الطلاب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public abstract TList<EntPolcyGrdngHdr> GetByEdCodeCourseStatusNewId(TransactionManager transactionManager, System.Decimal? _edCodeCourseStatusNewId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_CODE_GRADING key.
		///		FK_ENT_POLCY_GRDNG_HDR_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="_edCodeMaxGradId">اقصى تقدير</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByEdCodeMaxGradId(System.Decimal? _edCodeMaxGradId)
		{
			int count = -1;
			return GetByEdCodeMaxGradId(_edCodeMaxGradId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_CODE_GRADING key.
		///		FK_ENT_POLCY_GRDNG_HDR_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeMaxGradId">اقصى تقدير</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		/// <remarks></remarks>
		public TList<EntPolcyGrdngHdr> GetByEdCodeMaxGradId(TransactionManager transactionManager, System.Decimal? _edCodeMaxGradId)
		{
			int count = -1;
			return GetByEdCodeMaxGradId(transactionManager, _edCodeMaxGradId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_CODE_GRADING key.
		///		FK_ENT_POLCY_GRDNG_HDR_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeMaxGradId">اقصى تقدير</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByEdCodeMaxGradId(TransactionManager transactionManager, System.Decimal? _edCodeMaxGradId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeMaxGradId(transactionManager, _edCodeMaxGradId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_CODE_GRADING key.
		///		fkEntPolcyGrdngHdrEdCodeGrading Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeMaxGradId">اقصى تقدير</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByEdCodeMaxGradId(System.Decimal? _edCodeMaxGradId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeMaxGradId(null, _edCodeMaxGradId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_CODE_GRADING key.
		///		fkEntPolcyGrdngHdrEdCodeGrading Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeMaxGradId">اقصى تقدير</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByEdCodeMaxGradId(System.Decimal? _edCodeMaxGradId, int start, int pageLength,out int count)
		{
			return GetByEdCodeMaxGradId(null, _edCodeMaxGradId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_CODE_GRADING key.
		///		FK_ENT_POLCY_GRDNG_HDR_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeMaxGradId">اقصى تقدير</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public abstract TList<EntPolcyGrdngHdr> GetByEdCodeMaxGradId(TransactionManager transactionManager, System.Decimal? _edCodeMaxGradId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_CODE_LEVEL key.
		///		FK_ENT_POLCY_GRDNG_HDR_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="_edCodeLevelId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(_edCodeLevelId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_CODE_LEVEL key.
		///		FK_ENT_POLCY_GRDNG_HDR_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		/// <remarks></remarks>
		public TList<EntPolcyGrdngHdr> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_CODE_LEVEL key.
		///		FK_ENT_POLCY_GRDNG_HDR_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_CODE_LEVEL key.
		///		fkEntPolcyGrdngHdrEdCodeLevel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_CODE_LEVEL key.
		///		fkEntPolcyGrdngHdrEdCodeLevel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId, int start, int pageLength,out int count)
		{
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_CODE_LEVEL key.
		///		FK_ENT_POLCY_GRDNG_HDR_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public abstract TList<EntPolcyGrdngHdr> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_CODE_LOAD_TYPE key.
		///		FK_ENT_POLCY_GRDNG_HDR_ED_CODE_LOAD_TYPE Description: 
		/// </summary>
		/// <param name="_edCodeLoadTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByEdCodeLoadTypeId(System.Decimal _edCodeLoadTypeId)
		{
			int count = -1;
			return GetByEdCodeLoadTypeId(_edCodeLoadTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_CODE_LOAD_TYPE key.
		///		FK_ENT_POLCY_GRDNG_HDR_ED_CODE_LOAD_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLoadTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		/// <remarks></remarks>
		public TList<EntPolcyGrdngHdr> GetByEdCodeLoadTypeId(TransactionManager transactionManager, System.Decimal _edCodeLoadTypeId)
		{
			int count = -1;
			return GetByEdCodeLoadTypeId(transactionManager, _edCodeLoadTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_CODE_LOAD_TYPE key.
		///		FK_ENT_POLCY_GRDNG_HDR_ED_CODE_LOAD_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLoadTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByEdCodeLoadTypeId(TransactionManager transactionManager, System.Decimal _edCodeLoadTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLoadTypeId(transactionManager, _edCodeLoadTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_CODE_LOAD_TYPE key.
		///		fkEntPolcyGrdngHdrEdCodeLoadType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLoadTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByEdCodeLoadTypeId(System.Decimal _edCodeLoadTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeLoadTypeId(null, _edCodeLoadTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_CODE_LOAD_TYPE key.
		///		fkEntPolcyGrdngHdrEdCodeLoadType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLoadTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByEdCodeLoadTypeId(System.Decimal _edCodeLoadTypeId, int start, int pageLength,out int count)
		{
			return GetByEdCodeLoadTypeId(null, _edCodeLoadTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_CODE_LOAD_TYPE key.
		///		FK_ENT_POLCY_GRDNG_HDR_ED_CODE_LOAD_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLoadTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public abstract TList<EntPolcyGrdngHdr> GetByEdCodeLoadTypeId(TransactionManager transactionManager, System.Decimal _edCodeLoadTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_CODE_SEMESTER key.
		///		FK_ENT_POLCY_GRDNG_HDR_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_CODE_SEMESTER key.
		///		FK_ENT_POLCY_GRDNG_HDR_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		/// <remarks></remarks>
		public TList<EntPolcyGrdngHdr> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_CODE_SEMESTER key.
		///		FK_ENT_POLCY_GRDNG_HDR_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_CODE_SEMESTER key.
		///		fkEntPolcyGrdngHdrEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_CODE_SEMESTER key.
		///		fkEntPolcyGrdngHdrEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ED_CODE_SEMESTER key.
		///		FK_ENT_POLCY_GRDNG_HDR_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public abstract TList<EntPolcyGrdngHdr> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ENTITY_MAIN key.
		///		FK_ENT_POLCY_GRDNG_HDR_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByEntMainId(System.Decimal? _entMainId)
		{
			int count = -1;
			return GetByEntMainId(_entMainId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ENTITY_MAIN key.
		///		FK_ENT_POLCY_GRDNG_HDR_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		/// <remarks></remarks>
		public TList<EntPolcyGrdngHdr> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ENTITY_MAIN key.
		///		FK_ENT_POLCY_GRDNG_HDR_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ENTITY_MAIN key.
		///		fkEntPolcyGrdngHdrEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainId(null, _entMainId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ENTITY_MAIN key.
		///		fkEntPolcyGrdngHdrEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public TList<EntPolcyGrdngHdr> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength,out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GRDNG_HDR_ENTITY_MAIN key.
		///		FK_ENT_POLCY_GRDNG_HDR_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr objects.</returns>
		public abstract TList<EntPolcyGrdngHdr> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolcyGrdngHdrKey key, int start, int pageLength)
		{
			return GetByEntPolcyGrdngHdrId(transactionManager, key.EntPolcyGrdngHdrId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ENT_POLCY_GRDNG_HDR index.
		/// </summary>
		/// <param name="_entPolcyGrdngHdrId">قواعد الرصد المؤقتة</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr GetByEntPolcyGrdngHdrId(System.Decimal _entPolcyGrdngHdrId)
		{
			int count = -1;
			return GetByEntPolcyGrdngHdrId(null,_entPolcyGrdngHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLCY_GRDNG_HDR index.
		/// </summary>
		/// <param name="_entPolcyGrdngHdrId">قواعد الرصد المؤقتة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr GetByEntPolcyGrdngHdrId(System.Decimal _entPolcyGrdngHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolcyGrdngHdrId(null, _entPolcyGrdngHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLCY_GRDNG_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolcyGrdngHdrId">قواعد الرصد المؤقتة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr GetByEntPolcyGrdngHdrId(TransactionManager transactionManager, System.Decimal _entPolcyGrdngHdrId)
		{
			int count = -1;
			return GetByEntPolcyGrdngHdrId(transactionManager, _entPolcyGrdngHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLCY_GRDNG_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolcyGrdngHdrId">قواعد الرصد المؤقتة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr GetByEntPolcyGrdngHdrId(TransactionManager transactionManager, System.Decimal _entPolcyGrdngHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolcyGrdngHdrId(transactionManager, _entPolcyGrdngHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLCY_GRDNG_HDR index.
		/// </summary>
		/// <param name="_entPolcyGrdngHdrId">قواعد الرصد المؤقتة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr GetByEntPolcyGrdngHdrId(System.Decimal _entPolcyGrdngHdrId, int start, int pageLength, out int count)
		{
			return GetByEntPolcyGrdngHdrId(null, _entPolcyGrdngHdrId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLCY_GRDNG_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolcyGrdngHdrId">قواعد الرصد المؤقتة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr GetByEntPolcyGrdngHdrId(TransactionManager transactionManager, System.Decimal _entPolcyGrdngHdrId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntPolcyGrdngHdr&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntPolcyGrdngHdr&gt;"/></returns>
		public static TList<EntPolcyGrdngHdr> Fill(IDataReader reader, TList<EntPolcyGrdngHdr> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntPolcyGrdngHdr")
					.Append("|").Append((System.Decimal)reader["ENT_POLCY_GRDNG_HDR_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntPolcyGrdngHdr>(
					key.ToString(), // EntityTrackingKey
					"EntPolcyGrdngHdr",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr();
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
					c.EntPolcyGrdngHdrId = (System.Decimal)reader["ENT_POLCY_GRDNG_HDR_ID"];
					c.OriginalEntPolcyGrdngHdrId = c.EntPolcyGrdngHdrId;
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.EntMainId = Convert.IsDBNull(reader["ENT_MAIN_ID"]) ? null : (System.Decimal?)reader["ENT_MAIN_ID"];
					c.EdCodeLevelId = Convert.IsDBNull(reader["ED_CODE_LEVEL_ID"]) ? null : (System.Decimal?)reader["ED_CODE_LEVEL_ID"];
					c.EdBylawId = Convert.IsDBNull(reader["ED_BYLAW_ID"]) ? null : (System.Decimal?)reader["ED_BYLAW_ID"];
					c.EdCodeLoadTypeId = (System.Decimal)reader["ED_CODE_LOAD_TYPE_ID"];
					c.RepeatTypeFlg = Convert.IsDBNull(reader["REPEAT_TYPE_FLG"]) ? null : (System.Int16?)reader["REPEAT_TYPE_FLG"];
					c.EdCodeCourseAssessId = Convert.IsDBNull(reader["ED_CODE_COURSE_ASSESS_ID"]) ? null : (System.Decimal?)reader["ED_CODE_COURSE_ASSESS_ID"];
					c.PfFlg = Convert.IsDBNull(reader["PF_FLG"]) ? null : (System.Int16?)reader["PF_FLG"];
					c.EdCodeMaxGradId = Convert.IsDBNull(reader["ED_CODE_MAX_GRAD_ID"]) ? null : (System.Decimal?)reader["ED_CODE_MAX_GRAD_ID"];
					c.AcadWarnFlg = Convert.IsDBNull(reader["ACAD_WARN_FLG"]) ? null : (System.Int16?)reader["ACAD_WARN_FLG"];
					c.AddGpaFlg = (System.Decimal)reader["ADD_GPA_FLG"];
					c.EdCodeCourseStatusNewId = Convert.IsDBNull(reader["ED_CODE_COURSE_STATUS_NEW_ID"]) ? null : (System.Decimal?)reader["ED_CODE_COURSE_STATUS_NEW_ID"];
					c.IsApplied = Convert.IsDBNull(reader["IS_APPLIED"]) ? null : (System.Boolean?)reader["IS_APPLIED"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr entity)
		{
			if (!reader.Read()) return;
			
			entity.EntPolcyGrdngHdrId = (System.Decimal)reader[((int)EntPolcyGrdngHdrColumn.EntPolcyGrdngHdrId - 1)];
			entity.OriginalEntPolcyGrdngHdrId = (System.Decimal)reader["ENT_POLCY_GRDNG_HDR_ID"];
			entity.EdAcadYearId = (System.Decimal)reader[((int)EntPolcyGrdngHdrColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)EntPolcyGrdngHdrColumn.EdCodeSemesterId - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)EntPolcyGrdngHdrColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)EntPolcyGrdngHdrColumn.AsFacultyInfoId - 1)];
			entity.EntMainId = (reader.IsDBNull(((int)EntPolcyGrdngHdrColumn.EntMainId - 1)))?null:(System.Decimal?)reader[((int)EntPolcyGrdngHdrColumn.EntMainId - 1)];
			entity.EdCodeLevelId = (reader.IsDBNull(((int)EntPolcyGrdngHdrColumn.EdCodeLevelId - 1)))?null:(System.Decimal?)reader[((int)EntPolcyGrdngHdrColumn.EdCodeLevelId - 1)];
			entity.EdBylawId = (reader.IsDBNull(((int)EntPolcyGrdngHdrColumn.EdBylawId - 1)))?null:(System.Decimal?)reader[((int)EntPolcyGrdngHdrColumn.EdBylawId - 1)];
			entity.EdCodeLoadTypeId = (System.Decimal)reader[((int)EntPolcyGrdngHdrColumn.EdCodeLoadTypeId - 1)];
			entity.RepeatTypeFlg = (reader.IsDBNull(((int)EntPolcyGrdngHdrColumn.RepeatTypeFlg - 1)))?null:(System.Int16?)reader[((int)EntPolcyGrdngHdrColumn.RepeatTypeFlg - 1)];
			entity.EdCodeCourseAssessId = (reader.IsDBNull(((int)EntPolcyGrdngHdrColumn.EdCodeCourseAssessId - 1)))?null:(System.Decimal?)reader[((int)EntPolcyGrdngHdrColumn.EdCodeCourseAssessId - 1)];
			entity.PfFlg = (reader.IsDBNull(((int)EntPolcyGrdngHdrColumn.PfFlg - 1)))?null:(System.Int16?)reader[((int)EntPolcyGrdngHdrColumn.PfFlg - 1)];
			entity.EdCodeMaxGradId = (reader.IsDBNull(((int)EntPolcyGrdngHdrColumn.EdCodeMaxGradId - 1)))?null:(System.Decimal?)reader[((int)EntPolcyGrdngHdrColumn.EdCodeMaxGradId - 1)];
			entity.AcadWarnFlg = (reader.IsDBNull(((int)EntPolcyGrdngHdrColumn.AcadWarnFlg - 1)))?null:(System.Int16?)reader[((int)EntPolcyGrdngHdrColumn.AcadWarnFlg - 1)];
			entity.AddGpaFlg = (System.Decimal)reader[((int)EntPolcyGrdngHdrColumn.AddGpaFlg - 1)];
			entity.EdCodeCourseStatusNewId = (reader.IsDBNull(((int)EntPolcyGrdngHdrColumn.EdCodeCourseStatusNewId - 1)))?null:(System.Decimal?)reader[((int)EntPolcyGrdngHdrColumn.EdCodeCourseStatusNewId - 1)];
			entity.IsApplied = (reader.IsDBNull(((int)EntPolcyGrdngHdrColumn.IsApplied - 1)))?null:(System.Boolean?)reader[((int)EntPolcyGrdngHdrColumn.IsApplied - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EntPolcyGrdngHdrColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EntPolcyGrdngHdrColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EntPolcyGrdngHdrColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EntPolcyGrdngHdrColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntPolcyGrdngHdrId = (System.Decimal)dataRow["ENT_POLCY_GRDNG_HDR_ID"];
			entity.OriginalEntPolcyGrdngHdrId = (System.Decimal)dataRow["ENT_POLCY_GRDNG_HDR_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.EntMainId = Convert.IsDBNull(dataRow["ENT_MAIN_ID"]) ? null : (System.Decimal?)dataRow["ENT_MAIN_ID"];
			entity.EdCodeLevelId = Convert.IsDBNull(dataRow["ED_CODE_LEVEL_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_LEVEL_ID"];
			entity.EdBylawId = Convert.IsDBNull(dataRow["ED_BYLAW_ID"]) ? null : (System.Decimal?)dataRow["ED_BYLAW_ID"];
			entity.EdCodeLoadTypeId = (System.Decimal)dataRow["ED_CODE_LOAD_TYPE_ID"];
			entity.RepeatTypeFlg = Convert.IsDBNull(dataRow["REPEAT_TYPE_FLG"]) ? null : (System.Int16?)dataRow["REPEAT_TYPE_FLG"];
			entity.EdCodeCourseAssessId = Convert.IsDBNull(dataRow["ED_CODE_COURSE_ASSESS_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_COURSE_ASSESS_ID"];
			entity.PfFlg = Convert.IsDBNull(dataRow["PF_FLG"]) ? null : (System.Int16?)dataRow["PF_FLG"];
			entity.EdCodeMaxGradId = Convert.IsDBNull(dataRow["ED_CODE_MAX_GRAD_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_MAX_GRAD_ID"];
			entity.AcadWarnFlg = Convert.IsDBNull(dataRow["ACAD_WARN_FLG"]) ? null : (System.Int16?)dataRow["ACAD_WARN_FLG"];
			entity.AddGpaFlg = (System.Decimal)dataRow["ADD_GPA_FLG"];
			entity.EdCodeCourseStatusNewId = Convert.IsDBNull(dataRow["ED_CODE_COURSE_STATUS_NEW_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_COURSE_STATUS_NEW_ID"];
			entity.IsApplied = Convert.IsDBNull(dataRow["IS_APPLIED"]) ? null : (System.Boolean?)dataRow["IS_APPLIED"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region EdCodeCourseAssessIdSource	
			if (CanDeepLoad(entity, "EdCodeCourseAssess|EdCodeCourseAssessIdSource", deepLoadType, innerList) 
				&& entity.EdCodeCourseAssessIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeCourseAssessId ?? 0.0m);
				EdCodeCourseAssess tmpEntity = EntityManager.LocateEntity<EdCodeCourseAssess>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeCourseAssess), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeCourseAssessIdSource = tmpEntity;
				else
					entity.EdCodeCourseAssessIdSource = DataRepository.EdCodeCourseAssessProvider.GetByEdCodeCourseAssessId(transactionManager, (entity.EdCodeCourseAssessId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeCourseAssessIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeCourseAssessIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeCourseAssessProvider.DeepLoad(transactionManager, entity.EdCodeCourseAssessIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeCourseAssessIdSource

			#region EdCodeCourseStatusNewIdSource	
			if (CanDeepLoad(entity, "EdCodeCourseStatus|EdCodeCourseStatusNewIdSource", deepLoadType, innerList) 
				&& entity.EdCodeCourseStatusNewIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeCourseStatusNewId ?? 0.0m);
				EdCodeCourseStatus tmpEntity = EntityManager.LocateEntity<EdCodeCourseStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeCourseStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeCourseStatusNewIdSource = tmpEntity;
				else
					entity.EdCodeCourseStatusNewIdSource = DataRepository.EdCodeCourseStatusProvider.GetByEdCodeCourseStatusId(transactionManager, (entity.EdCodeCourseStatusNewId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeCourseStatusNewIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeCourseStatusNewIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeCourseStatusProvider.DeepLoad(transactionManager, entity.EdCodeCourseStatusNewIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeCourseStatusNewIdSource

			#region EdCodeMaxGradIdSource	
			if (CanDeepLoad(entity, "EdCodeGrading|EdCodeMaxGradIdSource", deepLoadType, innerList) 
				&& entity.EdCodeMaxGradIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeMaxGradId ?? 0.0m);
				EdCodeGrading tmpEntity = EntityManager.LocateEntity<EdCodeGrading>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeGrading), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeMaxGradIdSource = tmpEntity;
				else
					entity.EdCodeMaxGradIdSource = DataRepository.EdCodeGradingProvider.GetByEdCodeGradingId(transactionManager, (entity.EdCodeMaxGradId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeMaxGradIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeMaxGradIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeGradingProvider.DeepLoad(transactionManager, entity.EdCodeMaxGradIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeMaxGradIdSource

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

			#region EdCodeLoadTypeIdSource	
			if (CanDeepLoad(entity, "EdCodeLoadType|EdCodeLoadTypeIdSource", deepLoadType, innerList) 
				&& entity.EdCodeLoadTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeLoadTypeId;
				EdCodeLoadType tmpEntity = EntityManager.LocateEntity<EdCodeLoadType>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeLoadType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeLoadTypeIdSource = tmpEntity;
				else
					entity.EdCodeLoadTypeIdSource = DataRepository.EdCodeLoadTypeProvider.GetByEdCodeLoadTypeId(transactionManager, entity.EdCodeLoadTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeLoadTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeLoadTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeLoadTypeProvider.DeepLoad(transactionManager, entity.EdCodeLoadTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeLoadTypeIdSource

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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEntPolcyGrdngHdrId methods when available
			
			#region EntPolcyGrdngCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolcyGrdngCourse>|EntPolcyGrdngCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolcyGrdngCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolcyGrdngCourseCollection = DataRepository.EntPolcyGrdngCourseProvider.GetByEntPolcyGrdngHdrId(transactionManager, entity.EntPolcyGrdngHdrId);

				if (deep && entity.EntPolcyGrdngCourseCollection.Count > 0)
				{
					deepHandles.Add("EntPolcyGrdngCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolcyGrdngCourse>) DataRepository.EntPolcyGrdngCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolcyGrdngCourseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegPolcyCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseRegPolcy>|EdStudCourseRegPolcyCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegPolcyCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegPolcyCollection = DataRepository.EdStudCourseRegPolcyProvider.GetByEntPolcyGrdngHdrId(transactionManager, entity.EntPolcyGrdngHdrId);

				if (deep && entity.EdStudCourseRegPolcyCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegPolcyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseRegPolcy>) DataRepository.EdStudCourseRegPolcyProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegPolcyCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdBylawIdSource
			if (CanDeepSave(entity, "EdBylaw|EdBylawIdSource", deepSaveType, innerList) 
				&& entity.EdBylawIdSource != null)
			{
				DataRepository.EdBylawProvider.Save(transactionManager, entity.EdBylawIdSource);
				entity.EdBylawId = entity.EdBylawIdSource.EdBylawId;
			}
			#endregion 
			
			#region EdCodeCourseAssessIdSource
			if (CanDeepSave(entity, "EdCodeCourseAssess|EdCodeCourseAssessIdSource", deepSaveType, innerList) 
				&& entity.EdCodeCourseAssessIdSource != null)
			{
				DataRepository.EdCodeCourseAssessProvider.Save(transactionManager, entity.EdCodeCourseAssessIdSource);
				entity.EdCodeCourseAssessId = entity.EdCodeCourseAssessIdSource.EdCodeCourseAssessId;
			}
			#endregion 
			
			#region EdCodeCourseStatusNewIdSource
			if (CanDeepSave(entity, "EdCodeCourseStatus|EdCodeCourseStatusNewIdSource", deepSaveType, innerList) 
				&& entity.EdCodeCourseStatusNewIdSource != null)
			{
				DataRepository.EdCodeCourseStatusProvider.Save(transactionManager, entity.EdCodeCourseStatusNewIdSource);
				entity.EdCodeCourseStatusNewId = entity.EdCodeCourseStatusNewIdSource.EdCodeCourseStatusId;
			}
			#endregion 
			
			#region EdCodeMaxGradIdSource
			if (CanDeepSave(entity, "EdCodeGrading|EdCodeMaxGradIdSource", deepSaveType, innerList) 
				&& entity.EdCodeMaxGradIdSource != null)
			{
				DataRepository.EdCodeGradingProvider.Save(transactionManager, entity.EdCodeMaxGradIdSource);
				entity.EdCodeMaxGradId = entity.EdCodeMaxGradIdSource.EdCodeGradingId;
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
			
			#region EdCodeLoadTypeIdSource
			if (CanDeepSave(entity, "EdCodeLoadType|EdCodeLoadTypeIdSource", deepSaveType, innerList) 
				&& entity.EdCodeLoadTypeIdSource != null)
			{
				DataRepository.EdCodeLoadTypeProvider.Save(transactionManager, entity.EdCodeLoadTypeIdSource);
				entity.EdCodeLoadTypeId = entity.EdCodeLoadTypeIdSource.EdCodeLoadTypeId;
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
	
			#region List<EntPolcyGrdngCourse>
				if (CanDeepSave(entity.EntPolcyGrdngCourseCollection, "List<EntPolcyGrdngCourse>|EntPolcyGrdngCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolcyGrdngCourse child in entity.EntPolcyGrdngCourseCollection)
					{
						if(child.EntPolcyGrdngHdrIdSource != null)
						{
							child.EntPolcyGrdngHdrId = child.EntPolcyGrdngHdrIdSource.EntPolcyGrdngHdrId;
						}
						else
						{
							child.EntPolcyGrdngHdrId = entity.EntPolcyGrdngHdrId;
						}

					}

					if (entity.EntPolcyGrdngCourseCollection.Count > 0 || entity.EntPolcyGrdngCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolcyGrdngCourseProvider.Save(transactionManager, entity.EntPolcyGrdngCourseCollection);
						
						deepHandles.Add("EntPolcyGrdngCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolcyGrdngCourse >) DataRepository.EntPolcyGrdngCourseProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolcyGrdngCourseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseRegPolcy>
				if (CanDeepSave(entity.EdStudCourseRegPolcyCollection, "List<EdStudCourseRegPolcy>|EdStudCourseRegPolcyCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseRegPolcy child in entity.EdStudCourseRegPolcyCollection)
					{
						if(child.EntPolcyGrdngHdrIdSource != null)
						{
							child.EntPolcyGrdngHdrId = child.EntPolcyGrdngHdrIdSource.EntPolcyGrdngHdrId;
						}
						else
						{
							child.EntPolcyGrdngHdrId = entity.EntPolcyGrdngHdrId;
						}

					}

					if (entity.EdStudCourseRegPolcyCollection.Count > 0 || entity.EdStudCourseRegPolcyCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegPolcyProvider.Save(transactionManager, entity.EdStudCourseRegPolcyCollection);
						
						deepHandles.Add("EdStudCourseRegPolcyCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseRegPolcy >) DataRepository.EdStudCourseRegPolcyProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegPolcyCollection, deepSaveType, childTypes, innerList }
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
	
	#region EntPolcyGrdngHdrChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntPolcyGrdngHdr</c>
	///</summary>
	public enum EntPolcyGrdngHdrChildEntityTypes
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
		/// Composite Property for <c>EdBylaw</c> at EdBylawIdSource
		///</summary>
		[ChildEntityType(typeof(EdBylaw))]
		EdBylaw,
		
		///<summary>
		/// Composite Property for <c>EdCodeCourseAssess</c> at EdCodeCourseAssessIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeCourseAssess))]
		EdCodeCourseAssess,
		
		///<summary>
		/// Composite Property for <c>EdCodeCourseStatus</c> at EdCodeCourseStatusNewIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeCourseStatus))]
		EdCodeCourseStatus,
		
		///<summary>
		/// Composite Property for <c>EdCodeGrading</c> at EdCodeMaxGradIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeGrading))]
		EdCodeGrading,
		
		///<summary>
		/// Composite Property for <c>EdCodeLevel</c> at EdCodeLevelIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeLevel))]
		EdCodeLevel,
		
		///<summary>
		/// Composite Property for <c>EdCodeLoadType</c> at EdCodeLoadTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeLoadType))]
		EdCodeLoadType,
		
		///<summary>
		/// Composite Property for <c>EdCodeSemester</c> at EdCodeSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemester))]
		EdCodeSemester,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		///<summary>
		/// Collection of <c>EntPolcyGrdngHdr</c> as OneToMany for EntPolcyGrdngCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolcyGrdngCourse>))]
		EntPolcyGrdngCourseCollection,
		///<summary>
		/// Collection of <c>EntPolcyGrdngHdr</c> as OneToMany for EdStudCourseRegPolcyCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseRegPolcy>))]
		EdStudCourseRegPolcyCollection,
	}
	
	#endregion EntPolcyGrdngHdrChildEntityTypes
	
	#region EntPolcyGrdngHdrFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntPolcyGrdngHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolcyGrdngHdr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolcyGrdngHdrFilterBuilder : SqlFilterBuilder<EntPolcyGrdngHdrColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolcyGrdngHdrFilterBuilder class.
		/// </summary>
		public EntPolcyGrdngHdrFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolcyGrdngHdrFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolcyGrdngHdrFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolcyGrdngHdrFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolcyGrdngHdrFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolcyGrdngHdrFilterBuilder
	
	#region EntPolcyGrdngHdrParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntPolcyGrdngHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolcyGrdngHdr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolcyGrdngHdrParameterBuilder : ParameterizedSqlFilterBuilder<EntPolcyGrdngHdrColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolcyGrdngHdrParameterBuilder class.
		/// </summary>
		public EntPolcyGrdngHdrParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolcyGrdngHdrParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolcyGrdngHdrParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolcyGrdngHdrParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolcyGrdngHdrParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolcyGrdngHdrParameterBuilder
	
	#region EntPolcyGrdngHdrSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntPolcyGrdngHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolcyGrdngHdr"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntPolcyGrdngHdrSortBuilder : SqlSortBuilder<EntPolcyGrdngHdrColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolcyGrdngHdrSqlSortBuilder class.
		/// </summary>
		public EntPolcyGrdngHdrSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntPolcyGrdngHdrSortBuilder
	
} // end namespace
