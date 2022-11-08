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
	/// This class is the base class for any <see cref="FeeStudDiscProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeStudDiscProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeStudDisc, UMIS_VER2.BusinessLyer.FeeStudDiscKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudDiscKey key)
		{
			return Delete(transactionManager, key.FeeStudDiscId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeStudDiscId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeStudDiscId)
		{
			return Delete(null, _feeStudDiscId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudDiscId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeStudDiscId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_000b key.
		///		FK_AUTO_000b Description: 
		/// </summary>
		/// <param name="_edStudId">NU:applicant request</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDisc objects.</returns>
		public TList<FeeStudDisc> GetByEdStudId(System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_000b key.
		///		FK_AUTO_000b Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">NU:applicant request</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDisc objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudDisc> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_000b key.
		///		FK_AUTO_000b Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">NU:applicant request</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDisc objects.</returns>
		public TList<FeeStudDisc> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_000b key.
		///		fkAuto000b Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">NU:applicant request</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDisc objects.</returns>
		public TList<FeeStudDisc> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_000b key.
		///		fkAuto000b Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">NU:applicant request</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDisc objects.</returns>
		public TList<FeeStudDisc> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_000b key.
		///		FK_AUTO_000b Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">NU:applicant request</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDisc objects.</returns>
		public abstract TList<FeeStudDisc> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_ADM_APP_REG_HISTORY key.
		///		FK_FEE_STUD_DISC_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="_admAppRegHistoryId">NU:applicant disc req.XXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDisc objects.</returns>
		public TList<FeeStudDisc> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(_admAppRegHistoryId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_ADM_APP_REG_HISTORY key.
		///		FK_FEE_STUD_DISC_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId">NU:applicant disc req.XXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDisc objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudDisc> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_ADM_APP_REG_HISTORY key.
		///		FK_FEE_STUD_DISC_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId">NU:applicant disc req.XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDisc objects.</returns>
		public TList<FeeStudDisc> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_ADM_APP_REG_HISTORY key.
		///		fkFeeStudDiscAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId">NU:applicant disc req.XXX</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDisc objects.</returns>
		public TList<FeeStudDisc> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_ADM_APP_REG_HISTORY key.
		///		fkFeeStudDiscAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId">NU:applicant disc req.XXX</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDisc objects.</returns>
		public TList<FeeStudDisc> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId, int start, int pageLength,out int count)
		{
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_ADM_APP_REG_HISTORY key.
		///		FK_FEE_STUD_DISC_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId">NU:applicant disc req.XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDisc objects.</returns>
		public abstract TList<FeeStudDisc> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_ED_CODE_SEMESTER key.
		///		FK_FEE_STUD_DISC_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي
		/// 		/// فى حالة التخفيض على فصل وليس عام</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDisc objects.</returns>
		public TList<FeeStudDisc> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_ED_CODE_SEMESTER key.
		///		FK_FEE_STUD_DISC_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي
		/// 		/// فى حالة التخفيض على فصل وليس عام</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDisc objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudDisc> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_ED_CODE_SEMESTER key.
		///		FK_FEE_STUD_DISC_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي
		/// 		/// فى حالة التخفيض على فصل وليس عام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDisc objects.</returns>
		public TList<FeeStudDisc> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_ED_CODE_SEMESTER key.
		///		fkFeeStudDiscEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي
		/// 		/// فى حالة التخفيض على فصل وليس عام</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDisc objects.</returns>
		public TList<FeeStudDisc> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_ED_CODE_SEMESTER key.
		///		fkFeeStudDiscEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي
		/// 		/// فى حالة التخفيض على فصل وليس عام</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDisc objects.</returns>
		public TList<FeeStudDisc> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_ED_CODE_SEMESTER key.
		///		FK_FEE_STUD_DISC_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي
		/// 		/// فى حالة التخفيض على فصل وليس عام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDisc objects.</returns>
		public abstract TList<FeeStudDisc> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_SPO_SPONSOR key.
		///		FK_FEE_STUD_DISC_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="_spoSponsorId">NU:Sponsor RelatedXXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDisc objects.</returns>
		public TList<FeeStudDisc> GetBySpoSponsorId(System.Decimal? _spoSponsorId)
		{
			int count = -1;
			return GetBySpoSponsorId(_spoSponsorId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_SPO_SPONSOR key.
		///		FK_FEE_STUD_DISC_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId">NU:Sponsor RelatedXXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDisc objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudDisc> GetBySpoSponsorId(TransactionManager transactionManager, System.Decimal? _spoSponsorId)
		{
			int count = -1;
			return GetBySpoSponsorId(transactionManager, _spoSponsorId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_SPO_SPONSOR key.
		///		FK_FEE_STUD_DISC_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId">NU:Sponsor RelatedXXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDisc objects.</returns>
		public TList<FeeStudDisc> GetBySpoSponsorId(TransactionManager transactionManager, System.Decimal? _spoSponsorId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorId(transactionManager, _spoSponsorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_SPO_SPONSOR key.
		///		fkFeeStudDiscSpoSponsor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorId">NU:Sponsor RelatedXXX</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDisc objects.</returns>
		public TList<FeeStudDisc> GetBySpoSponsorId(System.Decimal? _spoSponsorId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySpoSponsorId(null, _spoSponsorId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_SPO_SPONSOR key.
		///		fkFeeStudDiscSpoSponsor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorId">NU:Sponsor RelatedXXX</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDisc objects.</returns>
		public TList<FeeStudDisc> GetBySpoSponsorId(System.Decimal? _spoSponsorId, int start, int pageLength,out int count)
		{
			return GetBySpoSponsorId(null, _spoSponsorId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_SPO_SPONSOR key.
		///		FK_FEE_STUD_DISC_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId">NU:Sponsor RelatedXXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDisc objects.</returns>
		public abstract TList<FeeStudDisc> GetBySpoSponsorId(TransactionManager transactionManager, System.Decimal? _spoSponsorId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeStudDisc Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudDiscKey key, int start, int pageLength)
		{
			return GetByFeeStudDiscId(transactionManager, key.FeeStudDiscId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudDisc&gt;"/> class.</returns>
		public TList<FeeStudDisc> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudDisc&gt;"/> class.</returns>
		public TList<FeeStudDisc> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudDisc&gt;"/> class.</returns>
		public TList<FeeStudDisc> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudDisc&gt;"/> class.</returns>
		public TList<FeeStudDisc> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudDisc&gt;"/> class.</returns>
		public TList<FeeStudDisc> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudDisc&gt;"/> class.</returns>
		public abstract TList<FeeStudDisc> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudDisc&gt;"/> class.</returns>
		public TList<FeeStudDisc> GetByEdAcadYearId(System.Decimal _edAcadYearId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudDisc&gt;"/> class.</returns>
		public TList<FeeStudDisc> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudDisc&gt;"/> class.</returns>
		public TList<FeeStudDisc> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudDisc&gt;"/> class.</returns>
		public TList<FeeStudDisc> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudDisc&gt;"/> class.</returns>
		public TList<FeeStudDisc> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudDisc&gt;"/> class.</returns>
		public abstract TList<FeeStudDisc> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_FEE_CDE_DISC_TYPE_ID_1 index.
		/// </summary>
		/// <param name="_feeCdeDiscTypeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudDisc&gt;"/> class.</returns>
		public TList<FeeStudDisc> GetByFeeCdeDiscTypeId(System.Decimal _feeCdeDiscTypeId)
		{
			int count = -1;
			return GetByFeeCdeDiscTypeId(null,_feeCdeDiscTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_CDE_DISC_TYPE_ID_1 index.
		/// </summary>
		/// <param name="_feeCdeDiscTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudDisc&gt;"/> class.</returns>
		public TList<FeeStudDisc> GetByFeeCdeDiscTypeId(System.Decimal _feeCdeDiscTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeDiscTypeId(null, _feeCdeDiscTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_CDE_DISC_TYPE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeDiscTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudDisc&gt;"/> class.</returns>
		public TList<FeeStudDisc> GetByFeeCdeDiscTypeId(TransactionManager transactionManager, System.Decimal _feeCdeDiscTypeId)
		{
			int count = -1;
			return GetByFeeCdeDiscTypeId(transactionManager, _feeCdeDiscTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_CDE_DISC_TYPE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeDiscTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudDisc&gt;"/> class.</returns>
		public TList<FeeStudDisc> GetByFeeCdeDiscTypeId(TransactionManager transactionManager, System.Decimal _feeCdeDiscTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeDiscTypeId(transactionManager, _feeCdeDiscTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_CDE_DISC_TYPE_ID_1 index.
		/// </summary>
		/// <param name="_feeCdeDiscTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudDisc&gt;"/> class.</returns>
		public TList<FeeStudDisc> GetByFeeCdeDiscTypeId(System.Decimal _feeCdeDiscTypeId, int start, int pageLength, out int count)
		{
			return GetByFeeCdeDiscTypeId(null, _feeCdeDiscTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_CDE_DISC_TYPE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeDiscTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudDisc&gt;"/> class.</returns>
		public abstract TList<FeeStudDisc> GetByFeeCdeDiscTypeId(TransactionManager transactionManager, System.Decimal _feeCdeDiscTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_FEE_STUD_DISC index.
		/// </summary>
		/// <param name="_edStudId">NU:applicant request</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudDisc&gt;"/> class.</returns>
		public TList<FeeStudDisc> GetByEdStudIdEdAcadYearId(System.Decimal? _edStudId, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdStudIdEdAcadYearId(null,_edStudId, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_STUD_DISC index.
		/// </summary>
		/// <param name="_edStudId">NU:applicant request</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudDisc&gt;"/> class.</returns>
		public TList<FeeStudDisc> GetByEdStudIdEdAcadYearId(System.Decimal? _edStudId, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIdEdAcadYearId(null, _edStudId, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_STUD_DISC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">NU:applicant request</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudDisc&gt;"/> class.</returns>
		public TList<FeeStudDisc> GetByEdStudIdEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edStudId, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdStudIdEdAcadYearId(transactionManager, _edStudId, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_STUD_DISC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">NU:applicant request</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudDisc&gt;"/> class.</returns>
		public TList<FeeStudDisc> GetByEdStudIdEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edStudId, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIdEdAcadYearId(transactionManager, _edStudId, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_STUD_DISC index.
		/// </summary>
		/// <param name="_edStudId">NU:applicant request</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudDisc&gt;"/> class.</returns>
		public TList<FeeStudDisc> GetByEdStudIdEdAcadYearId(System.Decimal? _edStudId, System.Decimal _edAcadYearId, int start, int pageLength, out int count)
		{
			return GetByEdStudIdEdAcadYearId(null, _edStudId, _edAcadYearId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_STUD_DISC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">NU:applicant request</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudDisc&gt;"/> class.</returns>
		public abstract TList<FeeStudDisc> GetByEdStudIdEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edStudId, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_CODE_REQ_STATUS_I_1 index.
		/// </summary>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudDisc&gt;"/> class.</returns>
		public TList<FeeStudDisc> GetByGsCodeReqStatusId(System.Decimal _gsCodeReqStatusId)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(null,_gsCodeReqStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_REQ_STATUS_I_1 index.
		/// </summary>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudDisc&gt;"/> class.</returns>
		public TList<FeeStudDisc> GetByGsCodeReqStatusId(System.Decimal _gsCodeReqStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(null, _gsCodeReqStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_REQ_STATUS_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudDisc&gt;"/> class.</returns>
		public TList<FeeStudDisc> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal _gsCodeReqStatusId)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(transactionManager, _gsCodeReqStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_REQ_STATUS_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudDisc&gt;"/> class.</returns>
		public TList<FeeStudDisc> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal _gsCodeReqStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(transactionManager, _gsCodeReqStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_REQ_STATUS_I_1 index.
		/// </summary>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudDisc&gt;"/> class.</returns>
		public TList<FeeStudDisc> GetByGsCodeReqStatusId(System.Decimal _gsCodeReqStatusId, int start, int pageLength, out int count)
		{
			return GetByGsCodeReqStatusId(null, _gsCodeReqStatusId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_REQ_STATUS_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudDisc&gt;"/> class.</returns>
		public abstract TList<FeeStudDisc> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal _gsCodeReqStatusId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_CDE_STUD_DISC index.
		/// </summary>
		/// <param name="_feeStudDiscId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudDisc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudDisc GetByFeeStudDiscId(System.Decimal _feeStudDiscId)
		{
			int count = -1;
			return GetByFeeStudDiscId(null,_feeStudDiscId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_STUD_DISC index.
		/// </summary>
		/// <param name="_feeStudDiscId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudDisc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudDisc GetByFeeStudDiscId(System.Decimal _feeStudDiscId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudDiscId(null, _feeStudDiscId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_STUD_DISC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudDiscId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudDisc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudDisc GetByFeeStudDiscId(TransactionManager transactionManager, System.Decimal _feeStudDiscId)
		{
			int count = -1;
			return GetByFeeStudDiscId(transactionManager, _feeStudDiscId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_STUD_DISC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudDiscId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudDisc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudDisc GetByFeeStudDiscId(TransactionManager transactionManager, System.Decimal _feeStudDiscId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudDiscId(transactionManager, _feeStudDiscId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_STUD_DISC index.
		/// </summary>
		/// <param name="_feeStudDiscId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudDisc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudDisc GetByFeeStudDiscId(System.Decimal _feeStudDiscId, int start, int pageLength, out int count)
		{
			return GetByFeeStudDiscId(null, _feeStudDiscId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_STUD_DISC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudDiscId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudDisc"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeStudDisc GetByFeeStudDiscId(TransactionManager transactionManager, System.Decimal _feeStudDiscId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeStudDisc&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeStudDisc&gt;"/></returns>
		public static TList<FeeStudDisc> Fill(IDataReader reader, TList<FeeStudDisc> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeStudDisc c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeStudDisc")
					.Append("|").Append((System.Decimal)reader["FEE_STUD_DISC_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeStudDisc>(
					key.ToString(), // EntityTrackingKey
					"FeeStudDisc",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeStudDisc();
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
					c.FeeStudDiscId = (System.Decimal)reader["FEE_STUD_DISC_ID"];
					c.OriginalFeeStudDiscId = c.FeeStudDiscId;
					c.DiscReqDate = (System.DateTime)reader["DISC_REQ_DATE"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.EdStudId = Convert.IsDBNull(reader["ED_STUD_ID"]) ? null : (System.Decimal?)reader["ED_STUD_ID"];
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.FeeCdeDiscTypeId = (System.Decimal)reader["FEE_CDE_DISC_TYPE_ID"];
					c.DiscPercent = (System.Decimal)reader["DISC_PERCENT"];
					c.StopFlg = (System.Decimal)reader["STOP_FLG"];
					c.GsCodeReqStatusId = (System.Decimal)reader["GS_CODE_REQ_STATUS_ID"];
					c.UpdatedPercent = (System.Decimal)reader["UPDATED_PERCENT"];
					c.LastUpdated = (System.DateTime)reader["LAST_UPDATED"];
					c.DiscAmnt = Convert.IsDBNull(reader["DISC_AMNT"]) ? null : (System.Decimal?)reader["DISC_AMNT"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.TypeFlg = Convert.IsDBNull(reader["TYPE_FLG"]) ? null : (System.Int32?)reader["TYPE_FLG"];
					c.AdmAppRegHistoryId = Convert.IsDBNull(reader["ADM_APP_REG_HISTORY_ID"]) ? null : (System.Decimal?)reader["ADM_APP_REG_HISTORY_ID"];
					c.SpoSponsorId = Convert.IsDBNull(reader["SPO_SPONSOR_ID"]) ? null : (System.Decimal?)reader["SPO_SPONSOR_ID"];
					c.SeUserApproveId = Convert.IsDBNull(reader["SE_USER_APPROVE_ID"]) ? null : (System.Decimal?)reader["SE_USER_APPROVE_ID"];
					c.ApproveDate = Convert.IsDBNull(reader["APPROVE_DATE"]) ? null : (System.DateTime?)reader["APPROVE_DATE"];
					c.SemYearFlg = Convert.IsDBNull(reader["SEM_YEAR_FLG"]) ? null : (System.Int32?)reader["SEM_YEAR_FLG"];
					c.LoadFlg = Convert.IsDBNull(reader["LOAD_FLG"]) ? null : (System.Boolean?)reader["LOAD_FLG"];
					c.EdCodeSemesterId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeStudDisc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudDisc"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeStudDisc entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeStudDiscId = (System.Decimal)reader[((int)FeeStudDiscColumn.FeeStudDiscId - 1)];
			entity.OriginalFeeStudDiscId = (System.Decimal)reader["FEE_STUD_DISC_ID"];
			entity.DiscReqDate = (System.DateTime)reader[((int)FeeStudDiscColumn.DiscReqDate - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)FeeStudDiscColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)FeeStudDiscColumn.AsFacultyInfoId - 1)];
			entity.EdStudId = (reader.IsDBNull(((int)FeeStudDiscColumn.EdStudId - 1)))?null:(System.Decimal?)reader[((int)FeeStudDiscColumn.EdStudId - 1)];
			entity.EdAcadYearId = (System.Decimal)reader[((int)FeeStudDiscColumn.EdAcadYearId - 1)];
			entity.FeeCdeDiscTypeId = (System.Decimal)reader[((int)FeeStudDiscColumn.FeeCdeDiscTypeId - 1)];
			entity.DiscPercent = (System.Decimal)reader[((int)FeeStudDiscColumn.DiscPercent - 1)];
			entity.StopFlg = (System.Decimal)reader[((int)FeeStudDiscColumn.StopFlg - 1)];
			entity.GsCodeReqStatusId = (System.Decimal)reader[((int)FeeStudDiscColumn.GsCodeReqStatusId - 1)];
			entity.UpdatedPercent = (System.Decimal)reader[((int)FeeStudDiscColumn.UpdatedPercent - 1)];
			entity.LastUpdated = (System.DateTime)reader[((int)FeeStudDiscColumn.LastUpdated - 1)];
			entity.DiscAmnt = (reader.IsDBNull(((int)FeeStudDiscColumn.DiscAmnt - 1)))?null:(System.Decimal?)reader[((int)FeeStudDiscColumn.DiscAmnt - 1)];
			entity.Notes = (reader.IsDBNull(((int)FeeStudDiscColumn.Notes - 1)))?null:(System.String)reader[((int)FeeStudDiscColumn.Notes - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)FeeStudDiscColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)FeeStudDiscColumn.SeUserId - 1)];
			entity.TypeFlg = (reader.IsDBNull(((int)FeeStudDiscColumn.TypeFlg - 1)))?null:(System.Int32?)reader[((int)FeeStudDiscColumn.TypeFlg - 1)];
			entity.AdmAppRegHistoryId = (reader.IsDBNull(((int)FeeStudDiscColumn.AdmAppRegHistoryId - 1)))?null:(System.Decimal?)reader[((int)FeeStudDiscColumn.AdmAppRegHistoryId - 1)];
			entity.SpoSponsorId = (reader.IsDBNull(((int)FeeStudDiscColumn.SpoSponsorId - 1)))?null:(System.Decimal?)reader[((int)FeeStudDiscColumn.SpoSponsorId - 1)];
			entity.SeUserApproveId = (reader.IsDBNull(((int)FeeStudDiscColumn.SeUserApproveId - 1)))?null:(System.Decimal?)reader[((int)FeeStudDiscColumn.SeUserApproveId - 1)];
			entity.ApproveDate = (reader.IsDBNull(((int)FeeStudDiscColumn.ApproveDate - 1)))?null:(System.DateTime?)reader[((int)FeeStudDiscColumn.ApproveDate - 1)];
			entity.SemYearFlg = (reader.IsDBNull(((int)FeeStudDiscColumn.SemYearFlg - 1)))?null:(System.Int32?)reader[((int)FeeStudDiscColumn.SemYearFlg - 1)];
			entity.LoadFlg = (reader.IsDBNull(((int)FeeStudDiscColumn.LoadFlg - 1)))?null:(System.Boolean?)reader[((int)FeeStudDiscColumn.LoadFlg - 1)];
			entity.EdCodeSemesterId = (reader.IsDBNull(((int)FeeStudDiscColumn.EdCodeSemesterId - 1)))?null:(System.Decimal?)reader[((int)FeeStudDiscColumn.EdCodeSemesterId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeStudDisc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudDisc"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeStudDisc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeStudDiscId = (System.Decimal)dataRow["FEE_STUD_DISC_ID"];
			entity.OriginalFeeStudDiscId = (System.Decimal)dataRow["FEE_STUD_DISC_ID"];
			entity.DiscReqDate = (System.DateTime)dataRow["DISC_REQ_DATE"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.EdStudId = Convert.IsDBNull(dataRow["ED_STUD_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.FeeCdeDiscTypeId = (System.Decimal)dataRow["FEE_CDE_DISC_TYPE_ID"];
			entity.DiscPercent = (System.Decimal)dataRow["DISC_PERCENT"];
			entity.StopFlg = (System.Decimal)dataRow["STOP_FLG"];
			entity.GsCodeReqStatusId = (System.Decimal)dataRow["GS_CODE_REQ_STATUS_ID"];
			entity.UpdatedPercent = (System.Decimal)dataRow["UPDATED_PERCENT"];
			entity.LastUpdated = (System.DateTime)dataRow["LAST_UPDATED"];
			entity.DiscAmnt = Convert.IsDBNull(dataRow["DISC_AMNT"]) ? null : (System.Decimal?)dataRow["DISC_AMNT"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.TypeFlg = Convert.IsDBNull(dataRow["TYPE_FLG"]) ? null : (System.Int32?)dataRow["TYPE_FLG"];
			entity.AdmAppRegHistoryId = Convert.IsDBNull(dataRow["ADM_APP_REG_HISTORY_ID"]) ? null : (System.Decimal?)dataRow["ADM_APP_REG_HISTORY_ID"];
			entity.SpoSponsorId = Convert.IsDBNull(dataRow["SPO_SPONSOR_ID"]) ? null : (System.Decimal?)dataRow["SPO_SPONSOR_ID"];
			entity.SeUserApproveId = Convert.IsDBNull(dataRow["SE_USER_APPROVE_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_APPROVE_ID"];
			entity.ApproveDate = Convert.IsDBNull(dataRow["APPROVE_DATE"]) ? null : (System.DateTime?)dataRow["APPROVE_DATE"];
			entity.SemYearFlg = Convert.IsDBNull(dataRow["SEM_YEAR_FLG"]) ? null : (System.Int32?)dataRow["SEM_YEAR_FLG"];
			entity.LoadFlg = Convert.IsDBNull(dataRow["LOAD_FLG"]) ? null : (System.Boolean?)dataRow["LOAD_FLG"];
			entity.EdCodeSemesterId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudDisc"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeStudDisc Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudDisc entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdStudIdSource	
			if (CanDeepLoad(entity, "EdStud|EdStudIdSource", deepLoadType, innerList) 
				&& entity.EdStudIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdStudId ?? 0.0m);
				EdStud tmpEntity = EntityManager.LocateEntity<EdStud>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStud), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudIdSource = tmpEntity;
				else
					entity.EdStudIdSource = DataRepository.EdStudProvider.GetByEdStudId(transactionManager, (entity.EdStudId ?? 0.0m));		
				
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

			#region AdmAppRegHistoryIdSource	
			if (CanDeepLoad(entity, "AdmAppRegHistory|AdmAppRegHistoryIdSource", deepLoadType, innerList) 
				&& entity.AdmAppRegHistoryIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmAppRegHistoryId ?? 0.0m);
				AdmAppRegHistory tmpEntity = EntityManager.LocateEntity<AdmAppRegHistory>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmAppRegHistory), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmAppRegHistoryIdSource = tmpEntity;
				else
					entity.AdmAppRegHistoryIdSource = DataRepository.AdmAppRegHistoryProvider.GetByAdmAppRegHistoryId(transactionManager, (entity.AdmAppRegHistoryId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppRegHistoryIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmAppRegHistoryIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmAppRegHistoryProvider.DeepLoad(transactionManager, entity.AdmAppRegHistoryIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmAppRegHistoryIdSource

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

			#region FeeCdeDiscTypeIdSource	
			if (CanDeepLoad(entity, "FeeCdeDiscType|FeeCdeDiscTypeIdSource", deepLoadType, innerList) 
				&& entity.FeeCdeDiscTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeCdeDiscTypeId;
				FeeCdeDiscType tmpEntity = EntityManager.LocateEntity<FeeCdeDiscType>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCdeDiscType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCdeDiscTypeIdSource = tmpEntity;
				else
					entity.FeeCdeDiscTypeIdSource = DataRepository.FeeCdeDiscTypeProvider.GetByFeeCdeDiscTypeId(transactionManager, entity.FeeCdeDiscTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCdeDiscTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeCdeDiscTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeCdeDiscTypeProvider.DeepLoad(transactionManager, entity.FeeCdeDiscTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeCdeDiscTypeIdSource

			#region GsCodeReqStatusIdSource	
			if (CanDeepLoad(entity, "GsCodeReqStatus|GsCodeReqStatusIdSource", deepLoadType, innerList) 
				&& entity.GsCodeReqStatusIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodeReqStatusId;
				GsCodeReqStatus tmpEntity = EntityManager.LocateEntity<GsCodeReqStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeReqStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeReqStatusIdSource = tmpEntity;
				else
					entity.GsCodeReqStatusIdSource = DataRepository.GsCodeReqStatusProvider.GetByGsCodeReqStatusId(transactionManager, entity.GsCodeReqStatusId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeReqStatusIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeReqStatusIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeReqStatusProvider.DeepLoad(transactionManager, entity.GsCodeReqStatusIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeReqStatusIdSource

			#region SpoSponsorIdSource	
			if (CanDeepLoad(entity, "SpoSponsor|SpoSponsorIdSource", deepLoadType, innerList) 
				&& entity.SpoSponsorIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SpoSponsorId ?? 0.0m);
				SpoSponsor tmpEntity = EntityManager.LocateEntity<SpoSponsor>(EntityLocator.ConstructKeyFromPkItems(typeof(SpoSponsor), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SpoSponsorIdSource = tmpEntity;
				else
					entity.SpoSponsorIdSource = DataRepository.SpoSponsorProvider.GetBySpoSponsorId(transactionManager, (entity.SpoSponsorId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SpoSponsorIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SpoSponsorProvider.DeepLoad(transactionManager, entity.SpoSponsorIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SpoSponsorIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByFeeStudDiscId methods when available
			
			#region FeeItemTrnsBlncCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeItemTrnsBlnc>|FeeItemTrnsBlncCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeItemTrnsBlncCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeItemTrnsBlncCollection = DataRepository.FeeItemTrnsBlncProvider.GetByFeeStudDiscId(transactionManager, entity.FeeStudDiscId);

				if (deep && entity.FeeItemTrnsBlncCollection.Count > 0)
				{
					deepHandles.Add("FeeItemTrnsBlncCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeItemTrnsBlnc>) DataRepository.FeeItemTrnsBlncProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeItemTrnsBlncCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudDiscSemesterCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudDiscSemester>|FeeStudDiscSemesterCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudDiscSemesterCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudDiscSemesterCollection = DataRepository.FeeStudDiscSemesterProvider.GetByFeeStudDiscId(transactionManager, entity.FeeStudDiscId);

				if (deep && entity.FeeStudDiscSemesterCollection.Count > 0)
				{
					deepHandles.Add("FeeStudDiscSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudDiscSemester>) DataRepository.FeeStudDiscSemesterProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudDiscSemesterCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsAttchdDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsAttchdDoc>|GsAttchdDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsAttchdDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsAttchdDocCollection = DataRepository.GsAttchdDocProvider.GetByFeeStudDiscId(transactionManager, entity.FeeStudDiscId);

				if (deep && entity.GsAttchdDocCollection.Count > 0)
				{
					deepHandles.Add("GsAttchdDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsAttchdDoc>) DataRepository.GsAttchdDocProvider.DeepLoad,
						new object[] { transactionManager, entity.GsAttchdDocCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudDiscFeeItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudDiscFeeItem>|FeeStudDiscFeeItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudDiscFeeItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudDiscFeeItemCollection = DataRepository.FeeStudDiscFeeItemProvider.GetByFeeStudDiscId(transactionManager, entity.FeeStudDiscId);

				if (deep && entity.FeeStudDiscFeeItemCollection.Count > 0)
				{
					deepHandles.Add("FeeStudDiscFeeItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudDiscFeeItem>) DataRepository.FeeStudDiscFeeItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudDiscFeeItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudDiscCodeItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudDiscCodeItem>|FeeStudDiscCodeItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudDiscCodeItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudDiscCodeItemCollection = DataRepository.FeeStudDiscCodeItemProvider.GetByFeeStudDiscId(transactionManager, entity.FeeStudDiscId);

				if (deep && entity.FeeStudDiscCodeItemCollection.Count > 0)
				{
					deepHandles.Add("FeeStudDiscCodeItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudDiscCodeItem>) DataRepository.FeeStudDiscCodeItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudDiscCodeItemCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeStudDisc object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeStudDisc instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeStudDisc Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudDisc entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
			}
			#endregion 
			
			#region AdmAppRegHistoryIdSource
			if (CanDeepSave(entity, "AdmAppRegHistory|AdmAppRegHistoryIdSource", deepSaveType, innerList) 
				&& entity.AdmAppRegHistoryIdSource != null)
			{
				DataRepository.AdmAppRegHistoryProvider.Save(transactionManager, entity.AdmAppRegHistoryIdSource);
				entity.AdmAppRegHistoryId = entity.AdmAppRegHistoryIdSource.AdmAppRegHistoryId;
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
			
			#region FeeCdeDiscTypeIdSource
			if (CanDeepSave(entity, "FeeCdeDiscType|FeeCdeDiscTypeIdSource", deepSaveType, innerList) 
				&& entity.FeeCdeDiscTypeIdSource != null)
			{
				DataRepository.FeeCdeDiscTypeProvider.Save(transactionManager, entity.FeeCdeDiscTypeIdSource);
				entity.FeeCdeDiscTypeId = entity.FeeCdeDiscTypeIdSource.FeeCdeDiscTypeId;
			}
			#endregion 
			
			#region GsCodeReqStatusIdSource
			if (CanDeepSave(entity, "GsCodeReqStatus|GsCodeReqStatusIdSource", deepSaveType, innerList) 
				&& entity.GsCodeReqStatusIdSource != null)
			{
				DataRepository.GsCodeReqStatusProvider.Save(transactionManager, entity.GsCodeReqStatusIdSource);
				entity.GsCodeReqStatusId = entity.GsCodeReqStatusIdSource.GsCodeReqStatusId;
			}
			#endregion 
			
			#region SpoSponsorIdSource
			if (CanDeepSave(entity, "SpoSponsor|SpoSponsorIdSource", deepSaveType, innerList) 
				&& entity.SpoSponsorIdSource != null)
			{
				DataRepository.SpoSponsorProvider.Save(transactionManager, entity.SpoSponsorIdSource);
				entity.SpoSponsorId = entity.SpoSponsorIdSource.SpoSponsorId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<FeeItemTrnsBlnc>
				if (CanDeepSave(entity.FeeItemTrnsBlncCollection, "List<FeeItemTrnsBlnc>|FeeItemTrnsBlncCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeItemTrnsBlnc child in entity.FeeItemTrnsBlncCollection)
					{
						if(child.FeeStudDiscIdSource != null)
						{
							child.FeeStudDiscId = child.FeeStudDiscIdSource.FeeStudDiscId;
						}
						else
						{
							child.FeeStudDiscId = entity.FeeStudDiscId;
						}

					}

					if (entity.FeeItemTrnsBlncCollection.Count > 0 || entity.FeeItemTrnsBlncCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeItemTrnsBlncProvider.Save(transactionManager, entity.FeeItemTrnsBlncCollection);
						
						deepHandles.Add("FeeItemTrnsBlncCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeItemTrnsBlnc >) DataRepository.FeeItemTrnsBlncProvider.DeepSave,
							new object[] { transactionManager, entity.FeeItemTrnsBlncCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudDiscSemester>
				if (CanDeepSave(entity.FeeStudDiscSemesterCollection, "List<FeeStudDiscSemester>|FeeStudDiscSemesterCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudDiscSemester child in entity.FeeStudDiscSemesterCollection)
					{
						if(child.FeeStudDiscIdSource != null)
						{
							child.FeeStudDiscId = child.FeeStudDiscIdSource.FeeStudDiscId;
						}
						else
						{
							child.FeeStudDiscId = entity.FeeStudDiscId;
						}

					}

					if (entity.FeeStudDiscSemesterCollection.Count > 0 || entity.FeeStudDiscSemesterCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudDiscSemesterProvider.Save(transactionManager, entity.FeeStudDiscSemesterCollection);
						
						deepHandles.Add("FeeStudDiscSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudDiscSemester >) DataRepository.FeeStudDiscSemesterProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudDiscSemesterCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GsAttchdDoc>
				if (CanDeepSave(entity.GsAttchdDocCollection, "List<GsAttchdDoc>|GsAttchdDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsAttchdDoc child in entity.GsAttchdDocCollection)
					{
						if(child.FeeStudDiscIdSource != null)
						{
							child.FeeStudDiscId = child.FeeStudDiscIdSource.FeeStudDiscId;
						}
						else
						{
							child.FeeStudDiscId = entity.FeeStudDiscId;
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
				
	
			#region List<FeeStudDiscFeeItem>
				if (CanDeepSave(entity.FeeStudDiscFeeItemCollection, "List<FeeStudDiscFeeItem>|FeeStudDiscFeeItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudDiscFeeItem child in entity.FeeStudDiscFeeItemCollection)
					{
						if(child.FeeStudDiscIdSource != null)
						{
							child.FeeStudDiscId = child.FeeStudDiscIdSource.FeeStudDiscId;
						}
						else
						{
							child.FeeStudDiscId = entity.FeeStudDiscId;
						}

					}

					if (entity.FeeStudDiscFeeItemCollection.Count > 0 || entity.FeeStudDiscFeeItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudDiscFeeItemProvider.Save(transactionManager, entity.FeeStudDiscFeeItemCollection);
						
						deepHandles.Add("FeeStudDiscFeeItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudDiscFeeItem >) DataRepository.FeeStudDiscFeeItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudDiscFeeItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudDiscCodeItem>
				if (CanDeepSave(entity.FeeStudDiscCodeItemCollection, "List<FeeStudDiscCodeItem>|FeeStudDiscCodeItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudDiscCodeItem child in entity.FeeStudDiscCodeItemCollection)
					{
						if(child.FeeStudDiscIdSource != null)
						{
							child.FeeStudDiscId = child.FeeStudDiscIdSource.FeeStudDiscId;
						}
						else
						{
							child.FeeStudDiscId = entity.FeeStudDiscId;
						}

					}

					if (entity.FeeStudDiscCodeItemCollection.Count > 0 || entity.FeeStudDiscCodeItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudDiscCodeItemProvider.Save(transactionManager, entity.FeeStudDiscCodeItemCollection);
						
						deepHandles.Add("FeeStudDiscCodeItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudDiscCodeItem >) DataRepository.FeeStudDiscCodeItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudDiscCodeItemCollection, deepSaveType, childTypes, innerList }
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
	
	#region FeeStudDiscChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeStudDisc</c>
	///</summary>
	public enum FeeStudDiscChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>AdmAppRegHistory</c> at AdmAppRegHistoryIdSource
		///</summary>
		[ChildEntityType(typeof(AdmAppRegHistory))]
		AdmAppRegHistory,
		
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
		/// Composite Property for <c>FeeCdeDiscType</c> at FeeCdeDiscTypeIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCdeDiscType))]
		FeeCdeDiscType,
		
		///<summary>
		/// Composite Property for <c>GsCodeReqStatus</c> at GsCodeReqStatusIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeReqStatus))]
		GsCodeReqStatus,
		
		///<summary>
		/// Composite Property for <c>SpoSponsor</c> at SpoSponsorIdSource
		///</summary>
		[ChildEntityType(typeof(SpoSponsor))]
		SpoSponsor,
		///<summary>
		/// Collection of <c>FeeStudDisc</c> as OneToMany for FeeItemTrnsBlncCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeItemTrnsBlnc>))]
		FeeItemTrnsBlncCollection,
		///<summary>
		/// Collection of <c>FeeStudDisc</c> as OneToMany for FeeStudDiscSemesterCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudDiscSemester>))]
		FeeStudDiscSemesterCollection,
		///<summary>
		/// Collection of <c>FeeStudDisc</c> as OneToMany for GsAttchdDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsAttchdDoc>))]
		GsAttchdDocCollection,
		///<summary>
		/// Collection of <c>FeeStudDisc</c> as OneToMany for FeeStudDiscFeeItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudDiscFeeItem>))]
		FeeStudDiscFeeItemCollection,
		///<summary>
		/// Collection of <c>FeeStudDisc</c> as OneToMany for FeeStudDiscCodeItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudDiscCodeItem>))]
		FeeStudDiscCodeItemCollection,
	}
	
	#endregion FeeStudDiscChildEntityTypes
	
	#region FeeStudDiscFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeStudDiscColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudDisc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeStudDiscFilterBuilder : SqlFilterBuilder<FeeStudDiscColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudDiscFilterBuilder class.
		/// </summary>
		public FeeStudDiscFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeStudDiscFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeStudDiscFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeStudDiscFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeStudDiscFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeStudDiscFilterBuilder
	
	#region FeeStudDiscParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeStudDiscColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudDisc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeStudDiscParameterBuilder : ParameterizedSqlFilterBuilder<FeeStudDiscColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudDiscParameterBuilder class.
		/// </summary>
		public FeeStudDiscParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeStudDiscParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeStudDiscParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeStudDiscParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeStudDiscParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeStudDiscParameterBuilder
	
	#region FeeStudDiscSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeStudDiscColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudDisc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeStudDiscSortBuilder : SqlSortBuilder<FeeStudDiscColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudDiscSqlSortBuilder class.
		/// </summary>
		public FeeStudDiscSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeStudDiscSortBuilder
	
} // end namespace
