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
	/// This class is the base class for any <see cref="ScScheduleDtlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScScheduleDtlProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.ScScheduleDtl, UMIS_VER2.BusinessLyer.ScScheduleDtlKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScScheduleDtlKey key)
		{
			return Delete(transactionManager, key.ScScheduleDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_scScheduleDtlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _scScheduleDtlId)
		{
			return Delete(null, _scScheduleDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _scScheduleDtlId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DETAILS_SC_SCHEDULE_HDR key.
		///		FK_SC_SCHEDULE_DETAILS_SC_SCHEDULE_HDR Description: 
		/// </summary>
		/// <param name="_scScheduleHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtl objects.</returns>
		public TList<ScScheduleDtl> GetByScScheduleHdrId(System.Decimal _scScheduleHdrId)
		{
			int count = -1;
			return GetByScScheduleHdrId(_scScheduleHdrId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DETAILS_SC_SCHEDULE_HDR key.
		///		FK_SC_SCHEDULE_DETAILS_SC_SCHEDULE_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtl objects.</returns>
		/// <remarks></remarks>
		public TList<ScScheduleDtl> GetByScScheduleHdrId(TransactionManager transactionManager, System.Decimal _scScheduleHdrId)
		{
			int count = -1;
			return GetByScScheduleHdrId(transactionManager, _scScheduleHdrId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DETAILS_SC_SCHEDULE_HDR key.
		///		FK_SC_SCHEDULE_DETAILS_SC_SCHEDULE_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtl objects.</returns>
		public TList<ScScheduleDtl> GetByScScheduleHdrId(TransactionManager transactionManager, System.Decimal _scScheduleHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleHdrId(transactionManager, _scScheduleHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DETAILS_SC_SCHEDULE_HDR key.
		///		fkScScheduleDetailsScScheduleHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scScheduleHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtl objects.</returns>
		public TList<ScScheduleDtl> GetByScScheduleHdrId(System.Decimal _scScheduleHdrId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScScheduleHdrId(null, _scScheduleHdrId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DETAILS_SC_SCHEDULE_HDR key.
		///		fkScScheduleDetailsScScheduleHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scScheduleHdrId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtl objects.</returns>
		public TList<ScScheduleDtl> GetByScScheduleHdrId(System.Decimal _scScheduleHdrId, int start, int pageLength,out int count)
		{
			return GetByScScheduleHdrId(null, _scScheduleHdrId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DETAILS_SC_SCHEDULE_HDR key.
		///		FK_SC_SCHEDULE_DETAILS_SC_SCHEDULE_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtl objects.</returns>
		public abstract TList<ScScheduleDtl> GetByScScheduleHdrId(TransactionManager transactionManager, System.Decimal _scScheduleHdrId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_AS_FACULTY_INFO key.
		///		FK_SC_SCHEDULE_DTL_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtl objects.</returns>
		public TList<ScScheduleDtl> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_AS_FACULTY_INFO key.
		///		FK_SC_SCHEDULE_DTL_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtl objects.</returns>
		/// <remarks></remarks>
		public TList<ScScheduleDtl> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_AS_FACULTY_INFO key.
		///		FK_SC_SCHEDULE_DTL_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtl objects.</returns>
		public TList<ScScheduleDtl> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_AS_FACULTY_INFO key.
		///		fkScScheduleDtlAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtl objects.</returns>
		public TList<ScScheduleDtl> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_AS_FACULTY_INFO key.
		///		fkScScheduleDtlAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtl objects.</returns>
		public TList<ScScheduleDtl> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_AS_FACULTY_INFO key.
		///		FK_SC_SCHEDULE_DTL_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtl objects.</returns>
		public abstract TList<ScScheduleDtl> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_GS_CODE_GENDER key.
		///		FK_SC_SCHEDULE_DTL_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="_gsCodeGenderId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtl objects.</returns>
		public TList<ScScheduleDtl> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId)
		{
			int count = -1;
			return GetByGsCodeGenderId(_gsCodeGenderId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_GS_CODE_GENDER key.
		///		FK_SC_SCHEDULE_DTL_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtl objects.</returns>
		/// <remarks></remarks>
		public TList<ScScheduleDtl> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId)
		{
			int count = -1;
			return GetByGsCodeGenderId(transactionManager, _gsCodeGenderId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_GS_CODE_GENDER key.
		///		FK_SC_SCHEDULE_DTL_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtl objects.</returns>
		public TList<ScScheduleDtl> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeGenderId(transactionManager, _gsCodeGenderId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_GS_CODE_GENDER key.
		///		fkScScheduleDtlGsCodeGender Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtl objects.</returns>
		public TList<ScScheduleDtl> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeGenderId(null, _gsCodeGenderId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_GS_CODE_GENDER key.
		///		fkScScheduleDtlGsCodeGender Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtl objects.</returns>
		public TList<ScScheduleDtl> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId, int start, int pageLength,out int count)
		{
			return GetByGsCodeGenderId(null, _gsCodeGenderId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_GS_CODE_GENDER key.
		///		FK_SC_SCHEDULE_DTL_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtl objects.</returns>
		public abstract TList<ScScheduleDtl> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_GS_CODE_LANGUAGE key.
		///		FK_SC_SCHEDULE_DTL_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="_gsCodeLanguageId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtl objects.</returns>
		public TList<ScScheduleDtl> GetByGsCodeLanguageId(System.Decimal? _gsCodeLanguageId)
		{
			int count = -1;
			return GetByGsCodeLanguageId(_gsCodeLanguageId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_GS_CODE_LANGUAGE key.
		///		FK_SC_SCHEDULE_DTL_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtl objects.</returns>
		/// <remarks></remarks>
		public TList<ScScheduleDtl> GetByGsCodeLanguageId(TransactionManager transactionManager, System.Decimal? _gsCodeLanguageId)
		{
			int count = -1;
			return GetByGsCodeLanguageId(transactionManager, _gsCodeLanguageId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_GS_CODE_LANGUAGE key.
		///		FK_SC_SCHEDULE_DTL_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtl objects.</returns>
		public TList<ScScheduleDtl> GetByGsCodeLanguageId(TransactionManager transactionManager, System.Decimal? _gsCodeLanguageId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeLanguageId(transactionManager, _gsCodeLanguageId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_GS_CODE_LANGUAGE key.
		///		fkScScheduleDtlGsCodeLanguage Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtl objects.</returns>
		public TList<ScScheduleDtl> GetByGsCodeLanguageId(System.Decimal? _gsCodeLanguageId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeLanguageId(null, _gsCodeLanguageId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_GS_CODE_LANGUAGE key.
		///		fkScScheduleDtlGsCodeLanguage Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtl objects.</returns>
		public TList<ScScheduleDtl> GetByGsCodeLanguageId(System.Decimal? _gsCodeLanguageId, int start, int pageLength,out int count)
		{
			return GetByGsCodeLanguageId(null, _gsCodeLanguageId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_GS_CODE_LANGUAGE key.
		///		FK_SC_SCHEDULE_DTL_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtl objects.</returns>
		public abstract TList<ScScheduleDtl> GetByGsCodeLanguageId(TransactionManager transactionManager, System.Decimal? _gsCodeLanguageId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_SE_USER key.
		///		FK_SC_SCHEDULE_DTL_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserRsultApproveId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtl objects.</returns>
		public TList<ScScheduleDtl> GetBySeUserRsultApproveId(System.Decimal? _seUserRsultApproveId)
		{
			int count = -1;
			return GetBySeUserRsultApproveId(_seUserRsultApproveId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_SE_USER key.
		///		FK_SC_SCHEDULE_DTL_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserRsultApproveId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtl objects.</returns>
		/// <remarks></remarks>
		public TList<ScScheduleDtl> GetBySeUserRsultApproveId(TransactionManager transactionManager, System.Decimal? _seUserRsultApproveId)
		{
			int count = -1;
			return GetBySeUserRsultApproveId(transactionManager, _seUserRsultApproveId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_SE_USER key.
		///		FK_SC_SCHEDULE_DTL_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserRsultApproveId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtl objects.</returns>
		public TList<ScScheduleDtl> GetBySeUserRsultApproveId(TransactionManager transactionManager, System.Decimal? _seUserRsultApproveId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserRsultApproveId(transactionManager, _seUserRsultApproveId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_SE_USER key.
		///		fkScScheduleDtlSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserRsultApproveId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtl objects.</returns>
		public TList<ScScheduleDtl> GetBySeUserRsultApproveId(System.Decimal? _seUserRsultApproveId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserRsultApproveId(null, _seUserRsultApproveId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_SE_USER key.
		///		fkScScheduleDtlSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserRsultApproveId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtl objects.</returns>
		public TList<ScScheduleDtl> GetBySeUserRsultApproveId(System.Decimal? _seUserRsultApproveId, int start, int pageLength,out int count)
		{
			return GetBySeUserRsultApproveId(null, _seUserRsultApproveId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_SE_USER key.
		///		FK_SC_SCHEDULE_DTL_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserRsultApproveId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtl objects.</returns>
		public abstract TList<ScScheduleDtl> GetBySeUserRsultApproveId(TransactionManager transactionManager, System.Decimal? _seUserRsultApproveId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.ScScheduleDtl Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScScheduleDtlKey key, int start, int pageLength)
		{
			return GetByScScheduleDtlId(transactionManager, key.ScScheduleDtlId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SC_SCHEDULE_DETAILS index.
		/// </summary>
		/// <param name="_scScheduleDtlId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtl GetByScScheduleDtlId(System.Decimal _scScheduleDtlId)
		{
			int count = -1;
			return GetByScScheduleDtlId(null,_scScheduleDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_DETAILS index.
		/// </summary>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtl GetByScScheduleDtlId(System.Decimal _scScheduleDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleDtlId(null, _scScheduleDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_DETAILS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtl GetByScScheduleDtlId(TransactionManager transactionManager, System.Decimal _scScheduleDtlId)
		{
			int count = -1;
			return GetByScScheduleDtlId(transactionManager, _scScheduleDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_DETAILS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtl GetByScScheduleDtlId(TransactionManager transactionManager, System.Decimal _scScheduleDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleDtlId(transactionManager, _scScheduleDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_DETAILS index.
		/// </summary>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtl GetByScScheduleDtlId(System.Decimal _scScheduleDtlId, int start, int pageLength, out int count)
		{
			return GetByScScheduleDtlId(null, _scScheduleDtlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_DETAILS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScScheduleDtl GetByScScheduleDtlId(TransactionManager transactionManager, System.Decimal _scScheduleDtlId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SC_SCHEDULE_DTL index.
		/// </summary>
		/// <param name="_scScheduleHdrId"></param>
		/// <param name="_groupOrder"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtl GetByScScheduleHdrIdGroupOrder(System.Decimal _scScheduleHdrId, System.Decimal? _groupOrder)
		{
			int count = -1;
			return GetByScScheduleHdrIdGroupOrder(null,_scScheduleHdrId, _groupOrder, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SCHEDULE_DTL index.
		/// </summary>
		/// <param name="_scScheduleHdrId"></param>
		/// <param name="_groupOrder"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtl GetByScScheduleHdrIdGroupOrder(System.Decimal _scScheduleHdrId, System.Decimal? _groupOrder, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleHdrIdGroupOrder(null, _scScheduleHdrId, _groupOrder, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SCHEDULE_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleHdrId"></param>
		/// <param name="_groupOrder"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtl GetByScScheduleHdrIdGroupOrder(TransactionManager transactionManager, System.Decimal _scScheduleHdrId, System.Decimal? _groupOrder)
		{
			int count = -1;
			return GetByScScheduleHdrIdGroupOrder(transactionManager, _scScheduleHdrId, _groupOrder, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SCHEDULE_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleHdrId"></param>
		/// <param name="_groupOrder"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtl GetByScScheduleHdrIdGroupOrder(TransactionManager transactionManager, System.Decimal _scScheduleHdrId, System.Decimal? _groupOrder, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleHdrIdGroupOrder(transactionManager, _scScheduleHdrId, _groupOrder, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SCHEDULE_DTL index.
		/// </summary>
		/// <param name="_scScheduleHdrId"></param>
		/// <param name="_groupOrder"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtl GetByScScheduleHdrIdGroupOrder(System.Decimal _scScheduleHdrId, System.Decimal? _groupOrder, int start, int pageLength, out int count)
		{
			return GetByScScheduleHdrIdGroupOrder(null, _scScheduleHdrId, _groupOrder, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SCHEDULE_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleHdrId"></param>
		/// <param name="_groupOrder"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScScheduleDtl GetByScScheduleHdrIdGroupOrder(TransactionManager transactionManager, System.Decimal _scScheduleHdrId, System.Decimal? _groupOrder, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SC_SCHEDULE_DTL_AR index.
		/// </summary>
		/// <param name="_scScheduleHdrId"></param>
		/// <param name="_groupDescrAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtl GetByScScheduleHdrIdGroupDescrAr(System.Decimal _scScheduleHdrId, System.String _groupDescrAr)
		{
			int count = -1;
			return GetByScScheduleHdrIdGroupDescrAr(null,_scScheduleHdrId, _groupDescrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SCHEDULE_DTL_AR index.
		/// </summary>
		/// <param name="_scScheduleHdrId"></param>
		/// <param name="_groupDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtl GetByScScheduleHdrIdGroupDescrAr(System.Decimal _scScheduleHdrId, System.String _groupDescrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleHdrIdGroupDescrAr(null, _scScheduleHdrId, _groupDescrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SCHEDULE_DTL_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleHdrId"></param>
		/// <param name="_groupDescrAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtl GetByScScheduleHdrIdGroupDescrAr(TransactionManager transactionManager, System.Decimal _scScheduleHdrId, System.String _groupDescrAr)
		{
			int count = -1;
			return GetByScScheduleHdrIdGroupDescrAr(transactionManager, _scScheduleHdrId, _groupDescrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SCHEDULE_DTL_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleHdrId"></param>
		/// <param name="_groupDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtl GetByScScheduleHdrIdGroupDescrAr(TransactionManager transactionManager, System.Decimal _scScheduleHdrId, System.String _groupDescrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleHdrIdGroupDescrAr(transactionManager, _scScheduleHdrId, _groupDescrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SCHEDULE_DTL_AR index.
		/// </summary>
		/// <param name="_scScheduleHdrId"></param>
		/// <param name="_groupDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtl GetByScScheduleHdrIdGroupDescrAr(System.Decimal _scScheduleHdrId, System.String _groupDescrAr, int start, int pageLength, out int count)
		{
			return GetByScScheduleHdrIdGroupDescrAr(null, _scScheduleHdrId, _groupDescrAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SCHEDULE_DTL_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleHdrId"></param>
		/// <param name="_groupDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScScheduleDtl GetByScScheduleHdrIdGroupDescrAr(TransactionManager transactionManager, System.Decimal _scScheduleHdrId, System.String _groupDescrAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SC_SCHEDULE_DTL_EN index.
		/// </summary>
		/// <param name="_scScheduleHdrId"></param>
		/// <param name="_groupDescrEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtl GetByScScheduleHdrIdGroupDescrEn(System.Decimal _scScheduleHdrId, System.String _groupDescrEn)
		{
			int count = -1;
			return GetByScScheduleHdrIdGroupDescrEn(null,_scScheduleHdrId, _groupDescrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SCHEDULE_DTL_EN index.
		/// </summary>
		/// <param name="_scScheduleHdrId"></param>
		/// <param name="_groupDescrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtl GetByScScheduleHdrIdGroupDescrEn(System.Decimal _scScheduleHdrId, System.String _groupDescrEn, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleHdrIdGroupDescrEn(null, _scScheduleHdrId, _groupDescrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SCHEDULE_DTL_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleHdrId"></param>
		/// <param name="_groupDescrEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtl GetByScScheduleHdrIdGroupDescrEn(TransactionManager transactionManager, System.Decimal _scScheduleHdrId, System.String _groupDescrEn)
		{
			int count = -1;
			return GetByScScheduleHdrIdGroupDescrEn(transactionManager, _scScheduleHdrId, _groupDescrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SCHEDULE_DTL_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleHdrId"></param>
		/// <param name="_groupDescrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtl GetByScScheduleHdrIdGroupDescrEn(TransactionManager transactionManager, System.Decimal _scScheduleHdrId, System.String _groupDescrEn, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleHdrIdGroupDescrEn(transactionManager, _scScheduleHdrId, _groupDescrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SCHEDULE_DTL_EN index.
		/// </summary>
		/// <param name="_scScheduleHdrId"></param>
		/// <param name="_groupDescrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtl GetByScScheduleHdrIdGroupDescrEn(System.Decimal _scScheduleHdrId, System.String _groupDescrEn, int start, int pageLength, out int count)
		{
			return GetByScScheduleHdrIdGroupDescrEn(null, _scScheduleHdrId, _groupDescrEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SCHEDULE_DTL_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleHdrId"></param>
		/// <param name="_groupDescrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScScheduleDtl GetByScScheduleHdrIdGroupDescrEn(TransactionManager transactionManager, System.Decimal _scScheduleHdrId, System.String _groupDescrEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ScScheduleDtl&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ScScheduleDtl&gt;"/></returns>
		public static TList<ScScheduleDtl> Fill(IDataReader reader, TList<ScScheduleDtl> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.ScScheduleDtl c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ScScheduleDtl")
					.Append("|").Append((System.Decimal)reader["SC_SCHEDULE_DTL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<ScScheduleDtl>(
					key.ToString(), // EntityTrackingKey
					"ScScheduleDtl",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.ScScheduleDtl();
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
					c.ScScheduleDtlId = (System.Decimal)reader["SC_SCHEDULE_DTL_ID"];
					c.OriginalScScheduleDtlId = c.ScScheduleDtlId;
					c.ScScheduleHdrId = (System.Decimal)reader["SC_SCHEDULE_HDR_ID"];
					c.GroupDescrAr = (System.String)reader["GROUP_DESCR_AR"];
					c.GroupDescrEn = (System.String)reader["GROUP_DESCR_EN"];
					c.GroupOrder = Convert.IsDBNull(reader["GROUP_ORDER"]) ? null : (System.Decimal?)reader["GROUP_ORDER"];
					c.GsCodeGenderId = Convert.IsDBNull(reader["GS_CODE_GENDER_ID"]) ? null : (System.Decimal?)reader["GS_CODE_GENDER_ID"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.IsResultApproved = (System.Decimal)reader["IS_RESULT_APPROVED"];
					c.SeUserRsultApproveId = Convert.IsDBNull(reader["SE_USER_RSULT_APPROVE_ID"]) ? null : (System.Decimal?)reader["SE_USER_RSULT_APPROVE_ID"];
					c.RsultApproveDate = Convert.IsDBNull(reader["RSULT_APPROVE_DATE"]) ? null : (System.DateTime?)reader["RSULT_APPROVE_DATE"];
					c.NoStudents = Convert.IsDBNull(reader["NO_STUDENTS"]) ? null : (System.Decimal?)reader["NO_STUDENTS"];
					c.NoStudWait = Convert.IsDBNull(reader["NO_STUD_WAIT"]) ? null : (System.Decimal?)reader["NO_STUD_WAIT"];
					c.OnlineFlg = (System.Decimal)reader["ONLINE_FLG"];
					c.IsClosed = Convert.IsDBNull(reader["IS_CLOSED"]) ? null : (System.Decimal?)reader["IS_CLOSED"];
					c.NotesEmp = Convert.IsDBNull(reader["NOTES_EMP"]) ? null : (System.String)reader["NOTES_EMP"];
					c.NoStudMax = Convert.IsDBNull(reader["NO_STUD_MAX"]) ? null : (System.Decimal?)reader["NO_STUD_MAX"];
					c.InternalFlg = (System.Decimal)reader["INTERNAL_FLG"];
					c.WaitlistFlg = Convert.IsDBNull(reader["WAITLIST_FLG"]) ? null : (System.Decimal?)reader["WAITLIST_FLG"];
					c.GsCodeLanguageId = Convert.IsDBNull(reader["GS_CODE_LANGUAGE_ID"]) ? null : (System.Decimal?)reader["GS_CODE_LANGUAGE_ID"];
					c.CnclFlg = Convert.IsDBNull(reader["CNCL_FLG"]) ? null : (System.Decimal?)reader["CNCL_FLG"];
					c.PartTimeFlg = Convert.IsDBNull(reader["PART_TIME_FLG"]) ? null : (System.Int32?)reader["PART_TIME_FLG"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtl"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtl"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.ScScheduleDtl entity)
		{
			if (!reader.Read()) return;
			
			entity.ScScheduleDtlId = (System.Decimal)reader[((int)ScScheduleDtlColumn.ScScheduleDtlId - 1)];
			entity.OriginalScScheduleDtlId = (System.Decimal)reader["SC_SCHEDULE_DTL_ID"];
			entity.ScScheduleHdrId = (System.Decimal)reader[((int)ScScheduleDtlColumn.ScScheduleHdrId - 1)];
			entity.GroupDescrAr = (System.String)reader[((int)ScScheduleDtlColumn.GroupDescrAr - 1)];
			entity.GroupDescrEn = (System.String)reader[((int)ScScheduleDtlColumn.GroupDescrEn - 1)];
			entity.GroupOrder = (reader.IsDBNull(((int)ScScheduleDtlColumn.GroupOrder - 1)))?null:(System.Decimal?)reader[((int)ScScheduleDtlColumn.GroupOrder - 1)];
			entity.GsCodeGenderId = (reader.IsDBNull(((int)ScScheduleDtlColumn.GsCodeGenderId - 1)))?null:(System.Decimal?)reader[((int)ScScheduleDtlColumn.GsCodeGenderId - 1)];
			entity.Notes = (reader.IsDBNull(((int)ScScheduleDtlColumn.Notes - 1)))?null:(System.String)reader[((int)ScScheduleDtlColumn.Notes - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)ScScheduleDtlColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)ScScheduleDtlColumn.AsFacultyInfoId - 1)];
			entity.IsResultApproved = (System.Decimal)reader[((int)ScScheduleDtlColumn.IsResultApproved - 1)];
			entity.SeUserRsultApproveId = (reader.IsDBNull(((int)ScScheduleDtlColumn.SeUserRsultApproveId - 1)))?null:(System.Decimal?)reader[((int)ScScheduleDtlColumn.SeUserRsultApproveId - 1)];
			entity.RsultApproveDate = (reader.IsDBNull(((int)ScScheduleDtlColumn.RsultApproveDate - 1)))?null:(System.DateTime?)reader[((int)ScScheduleDtlColumn.RsultApproveDate - 1)];
			entity.NoStudents = (reader.IsDBNull(((int)ScScheduleDtlColumn.NoStudents - 1)))?null:(System.Decimal?)reader[((int)ScScheduleDtlColumn.NoStudents - 1)];
			entity.NoStudWait = (reader.IsDBNull(((int)ScScheduleDtlColumn.NoStudWait - 1)))?null:(System.Decimal?)reader[((int)ScScheduleDtlColumn.NoStudWait - 1)];
			entity.OnlineFlg = (System.Decimal)reader[((int)ScScheduleDtlColumn.OnlineFlg - 1)];
			entity.IsClosed = (reader.IsDBNull(((int)ScScheduleDtlColumn.IsClosed - 1)))?null:(System.Decimal?)reader[((int)ScScheduleDtlColumn.IsClosed - 1)];
			entity.NotesEmp = (reader.IsDBNull(((int)ScScheduleDtlColumn.NotesEmp - 1)))?null:(System.String)reader[((int)ScScheduleDtlColumn.NotesEmp - 1)];
			entity.NoStudMax = (reader.IsDBNull(((int)ScScheduleDtlColumn.NoStudMax - 1)))?null:(System.Decimal?)reader[((int)ScScheduleDtlColumn.NoStudMax - 1)];
			entity.InternalFlg = (System.Decimal)reader[((int)ScScheduleDtlColumn.InternalFlg - 1)];
			entity.WaitlistFlg = (reader.IsDBNull(((int)ScScheduleDtlColumn.WaitlistFlg - 1)))?null:(System.Decimal?)reader[((int)ScScheduleDtlColumn.WaitlistFlg - 1)];
			entity.GsCodeLanguageId = (reader.IsDBNull(((int)ScScheduleDtlColumn.GsCodeLanguageId - 1)))?null:(System.Decimal?)reader[((int)ScScheduleDtlColumn.GsCodeLanguageId - 1)];
			entity.CnclFlg = (reader.IsDBNull(((int)ScScheduleDtlColumn.CnclFlg - 1)))?null:(System.Decimal?)reader[((int)ScScheduleDtlColumn.CnclFlg - 1)];
			entity.PartTimeFlg = (reader.IsDBNull(((int)ScScheduleDtlColumn.PartTimeFlg - 1)))?null:(System.Int32?)reader[((int)ScScheduleDtlColumn.PartTimeFlg - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)ScScheduleDtlColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)ScScheduleDtlColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)ScScheduleDtlColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)ScScheduleDtlColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtl"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtl"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.ScScheduleDtl entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ScScheduleDtlId = (System.Decimal)dataRow["SC_SCHEDULE_DTL_ID"];
			entity.OriginalScScheduleDtlId = (System.Decimal)dataRow["SC_SCHEDULE_DTL_ID"];
			entity.ScScheduleHdrId = (System.Decimal)dataRow["SC_SCHEDULE_HDR_ID"];
			entity.GroupDescrAr = (System.String)dataRow["GROUP_DESCR_AR"];
			entity.GroupDescrEn = (System.String)dataRow["GROUP_DESCR_EN"];
			entity.GroupOrder = Convert.IsDBNull(dataRow["GROUP_ORDER"]) ? null : (System.Decimal?)dataRow["GROUP_ORDER"];
			entity.GsCodeGenderId = Convert.IsDBNull(dataRow["GS_CODE_GENDER_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_GENDER_ID"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.IsResultApproved = (System.Decimal)dataRow["IS_RESULT_APPROVED"];
			entity.SeUserRsultApproveId = Convert.IsDBNull(dataRow["SE_USER_RSULT_APPROVE_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_RSULT_APPROVE_ID"];
			entity.RsultApproveDate = Convert.IsDBNull(dataRow["RSULT_APPROVE_DATE"]) ? null : (System.DateTime?)dataRow["RSULT_APPROVE_DATE"];
			entity.NoStudents = Convert.IsDBNull(dataRow["NO_STUDENTS"]) ? null : (System.Decimal?)dataRow["NO_STUDENTS"];
			entity.NoStudWait = Convert.IsDBNull(dataRow["NO_STUD_WAIT"]) ? null : (System.Decimal?)dataRow["NO_STUD_WAIT"];
			entity.OnlineFlg = (System.Decimal)dataRow["ONLINE_FLG"];
			entity.IsClosed = Convert.IsDBNull(dataRow["IS_CLOSED"]) ? null : (System.Decimal?)dataRow["IS_CLOSED"];
			entity.NotesEmp = Convert.IsDBNull(dataRow["NOTES_EMP"]) ? null : (System.String)dataRow["NOTES_EMP"];
			entity.NoStudMax = Convert.IsDBNull(dataRow["NO_STUD_MAX"]) ? null : (System.Decimal?)dataRow["NO_STUD_MAX"];
			entity.InternalFlg = (System.Decimal)dataRow["INTERNAL_FLG"];
			entity.WaitlistFlg = Convert.IsDBNull(dataRow["WAITLIST_FLG"]) ? null : (System.Decimal?)dataRow["WAITLIST_FLG"];
			entity.GsCodeLanguageId = Convert.IsDBNull(dataRow["GS_CODE_LANGUAGE_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_LANGUAGE_ID"];
			entity.CnclFlg = Convert.IsDBNull(dataRow["CNCL_FLG"]) ? null : (System.Decimal?)dataRow["CNCL_FLG"];
			entity.PartTimeFlg = Convert.IsDBNull(dataRow["PART_TIME_FLG"]) ? null : (System.Int32?)dataRow["PART_TIME_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtl"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScScheduleDtl Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScScheduleDtl entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region ScScheduleHdrIdSource	
			if (CanDeepLoad(entity, "ScScheduleHdr|ScScheduleHdrIdSource", deepLoadType, innerList) 
				&& entity.ScScheduleHdrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.ScScheduleHdrId;
				ScScheduleHdr tmpEntity = EntityManager.LocateEntity<ScScheduleHdr>(EntityLocator.ConstructKeyFromPkItems(typeof(ScScheduleHdr), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScScheduleHdrIdSource = tmpEntity;
				else
					entity.ScScheduleHdrIdSource = DataRepository.ScScheduleHdrProvider.GetByScScheduleHdrId(transactionManager, entity.ScScheduleHdrId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScScheduleHdrIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScScheduleHdrIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScScheduleHdrProvider.DeepLoad(transactionManager, entity.ScScheduleHdrIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScScheduleHdrIdSource

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

			#region GsCodeGenderIdSource	
			if (CanDeepLoad(entity, "GsCodeGender|GsCodeGenderIdSource", deepLoadType, innerList) 
				&& entity.GsCodeGenderIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeGenderId ?? 0.0m);
				GsCodeGender tmpEntity = EntityManager.LocateEntity<GsCodeGender>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeGender), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeGenderIdSource = tmpEntity;
				else
					entity.GsCodeGenderIdSource = DataRepository.GsCodeGenderProvider.GetByGsCodeGenderId(transactionManager, (entity.GsCodeGenderId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeGenderIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeGenderIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeGenderProvider.DeepLoad(transactionManager, entity.GsCodeGenderIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeGenderIdSource

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

			#region SeUserRsultApproveIdSource	
			if (CanDeepLoad(entity, "SeUser|SeUserRsultApproveIdSource", deepLoadType, innerList) 
				&& entity.SeUserRsultApproveIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeUserRsultApproveId ?? 0.0m);
				SeUser tmpEntity = EntityManager.LocateEntity<SeUser>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUser), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeUserRsultApproveIdSource = tmpEntity;
				else
					entity.SeUserRsultApproveIdSource = DataRepository.SeUserProvider.GetBySeUserId(transactionManager, (entity.SeUserRsultApproveId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserRsultApproveIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeUserRsultApproveIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeUserProvider.DeepLoad(transactionManager, entity.SeUserRsultApproveIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeUserRsultApproveIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByScScheduleDtlId methods when available
			
			#region ScScheduleCrossListCollectionGetByScScheduleDtlId1
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScScheduleCrossList>|ScScheduleCrossListCollectionGetByScScheduleDtlId1", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScScheduleCrossListCollectionGetByScScheduleDtlId1' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScScheduleCrossListCollectionGetByScScheduleDtlId1 = DataRepository.ScScheduleCrossListProvider.GetByScScheduleDtlId1(transactionManager, entity.ScScheduleDtlId);

				if (deep && entity.ScScheduleCrossListCollectionGetByScScheduleDtlId1.Count > 0)
				{
					deepHandles.Add("ScScheduleCrossListCollectionGetByScScheduleDtlId1",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScScheduleCrossList>) DataRepository.ScScheduleCrossListProvider.DeepLoad,
						new object[] { transactionManager, entity.ScScheduleCrossListCollectionGetByScScheduleDtlId1, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdExamSuprvsorCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdExamSuprvsor>|EdExamSuprvsorCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdExamSuprvsorCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdExamSuprvsorCollection = DataRepository.EdExamSuprvsorProvider.GetByScScheduleDtlId(transactionManager, entity.ScScheduleDtlId);

				if (deep && entity.EdExamSuprvsorCollection.Count > 0)
				{
					deepHandles.Add("EdExamSuprvsorCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdExamSuprvsor>) DataRepository.EdExamSuprvsorProvider.DeepLoad,
						new object[] { transactionManager, entity.EdExamSuprvsorCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvLecNoteCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvLecNote>|SvLecNoteCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvLecNoteCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvLecNoteCollection = DataRepository.SvLecNoteProvider.GetByScScheduleDtlId(transactionManager, entity.ScScheduleDtlId);

				if (deep && entity.SvLecNoteCollection.Count > 0)
				{
					deepHandles.Add("SvLecNoteCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvLecNote>) DataRepository.SvLecNoteProvider.DeepLoad,
						new object[] { transactionManager, entity.SvLecNoteCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCourseInstanceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourseInstance>|EdCourseInstanceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseInstanceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseInstanceCollection = DataRepository.EdCourseInstanceProvider.GetByScScheduleDtlId(transactionManager, entity.ScScheduleDtlId);

				if (deep && entity.EdCourseInstanceCollection.Count > 0)
				{
					deepHandles.Add("EdCourseInstanceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourseInstance>) DataRepository.EdCourseInstanceProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseInstanceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region WfCrsRsltApproveCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<WfCrsRsltApprove>|WfCrsRsltApproveCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'WfCrsRsltApproveCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.WfCrsRsltApproveCollection = DataRepository.WfCrsRsltApproveProvider.GetByScScheduleDtlId(transactionManager, entity.ScScheduleDtlId);

				if (deep && entity.WfCrsRsltApproveCollection.Count > 0)
				{
					deepHandles.Add("WfCrsRsltApproveCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<WfCrsRsltApprove>) DataRepository.WfCrsRsltApproveProvider.DeepLoad,
						new object[] { transactionManager, entity.WfCrsRsltApproveCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoExamSchdlPlaceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoExamSchdlPlace>|CoExamSchdlPlaceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoExamSchdlPlaceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoExamSchdlPlaceCollection = DataRepository.CoExamSchdlPlaceProvider.GetByScScheduleDtlId(transactionManager, entity.ScScheduleDtlId);

				if (deep && entity.CoExamSchdlPlaceCollection.Count > 0)
				{
					deepHandles.Add("CoExamSchdlPlaceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoExamSchdlPlace>) DataRepository.CoExamSchdlPlaceProvider.DeepLoad,
						new object[] { transactionManager, entity.CoExamSchdlPlaceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScSectionGroupDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScSectionGroupDtl>|ScSectionGroupDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScSectionGroupDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScSectionGroupDtlCollection = DataRepository.ScSectionGroupDtlProvider.GetByScScheduleDtlId(transactionManager, entity.ScScheduleDtlId);

				if (deep && entity.ScSectionGroupDtlCollection.Count > 0)
				{
					deepHandles.Add("ScSectionGroupDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScSectionGroupDtl>) DataRepository.ScSectionGroupDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.ScSectionGroupDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudGroupPreCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudGroupPre>|EdStudGroupPreCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudGroupPreCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudGroupPreCollection = DataRepository.EdStudGroupPreProvider.GetByScScheduleDtlId(transactionManager, entity.ScScheduleDtlId);

				if (deep && entity.EdStudGroupPreCollection.Count > 0)
				{
					deepHandles.Add("EdStudGroupPreCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudGroupPre>) DataRepository.EdStudGroupPreProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudGroupPreCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvPollHdrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvPollHdr>|SvPollHdrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvPollHdrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvPollHdrCollection = DataRepository.SvPollHdrProvider.GetByScScheduleDtlId(transactionManager, entity.ScScheduleDtlId);

				if (deep && entity.SvPollHdrCollection.Count > 0)
				{
					deepHandles.Add("SvPollHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvPollHdr>) DataRepository.SvPollHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.SvPollHdrCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScScheduleCrossListCollectionGetByScScheduleDtlId2
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScScheduleCrossList>|ScScheduleCrossListCollectionGetByScScheduleDtlId2", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScScheduleCrossListCollectionGetByScScheduleDtlId2' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScScheduleCrossListCollectionGetByScScheduleDtlId2 = DataRepository.ScScheduleCrossListProvider.GetByScScheduleDtlId2(transactionManager, entity.ScScheduleDtlId);

				if (deep && entity.ScScheduleCrossListCollectionGetByScScheduleDtlId2.Count > 0)
				{
					deepHandles.Add("ScScheduleCrossListCollectionGetByScScheduleDtlId2",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScScheduleCrossList>) DataRepository.ScScheduleCrossListProvider.DeepLoad,
						new object[] { transactionManager, entity.ScScheduleCrossListCollectionGetByScScheduleDtlId2, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScScheduleDtlDayCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScScheduleDtlDay>|ScScheduleDtlDayCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScScheduleDtlDayCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScScheduleDtlDayCollection = DataRepository.ScScheduleDtlDayProvider.GetByScScheduleDtlId(transactionManager, entity.ScScheduleDtlId);

				if (deep && entity.ScScheduleDtlDayCollection.Count > 0)
				{
					deepHandles.Add("ScScheduleDtlDayCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScScheduleDtlDay>) DataRepository.ScScheduleDtlDayProvider.DeepLoad,
						new object[] { transactionManager, entity.ScScheduleDtlDayCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseWaitCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseWait>|EdStudCourseWaitCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseWaitCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseWaitCollection = DataRepository.EdStudCourseWaitProvider.GetByScScheduleDtlId(transactionManager, entity.ScScheduleDtlId);

				if (deep && entity.EdStudCourseWaitCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseWaitCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseWait>) DataRepository.EdStudCourseWaitProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseWaitCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudGroupCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudGroup>|EdStudGroupCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudGroupCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudGroupCollection = DataRepository.EdStudGroupProvider.GetByScScheduleDtlId(transactionManager, entity.ScScheduleDtlId);

				if (deep && entity.EdStudGroupCollection.Count > 0)
				{
					deepHandles.Add("EdStudGroupCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudGroup>) DataRepository.EdStudGroupProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudGroupCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScScheduleRsrvCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScScheduleRsrv>|ScScheduleRsrvCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScScheduleRsrvCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScScheduleRsrvCollection = DataRepository.ScScheduleRsrvProvider.GetByScScheduleDtlId(transactionManager, entity.ScScheduleDtlId);

				if (deep && entity.ScScheduleRsrvCollection.Count > 0)
				{
					deepHandles.Add("ScScheduleRsrvCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScScheduleRsrv>) DataRepository.ScScheduleRsrvProvider.DeepLoad,
						new object[] { transactionManager, entity.ScScheduleRsrvCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScScheduleDtlExtStfCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScScheduleDtlExtStf>|ScScheduleDtlExtStfCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScScheduleDtlExtStfCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScScheduleDtlExtStfCollection = DataRepository.ScScheduleDtlExtStfProvider.GetByScScheduleDtlId(transactionManager, entity.ScScheduleDtlId);

				if (deep && entity.ScScheduleDtlExtStfCollection.Count > 0)
				{
					deepHandles.Add("ScScheduleDtlExtStfCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScScheduleDtlExtStf>) DataRepository.ScScheduleDtlExtStfProvider.DeepLoad,
						new object[] { transactionManager, entity.ScScheduleDtlExtStfCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeBlockTransCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeBlockTrans>|SeBlockTransCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeBlockTransCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeBlockTransCollection = DataRepository.SeBlockTransProvider.GetByScScheduleDtlId(transactionManager, entity.ScScheduleDtlId);

				if (deep && entity.SeBlockTransCollection.Count > 0)
				{
					deepHandles.Add("SeBlockTransCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeBlockTrans>) DataRepository.SeBlockTransProvider.DeepLoad,
						new object[] { transactionManager, entity.SeBlockTransCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.ScScheduleDtl object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.ScScheduleDtl instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScScheduleDtl Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScScheduleDtl entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region ScScheduleHdrIdSource
			if (CanDeepSave(entity, "ScScheduleHdr|ScScheduleHdrIdSource", deepSaveType, innerList) 
				&& entity.ScScheduleHdrIdSource != null)
			{
				DataRepository.ScScheduleHdrProvider.Save(transactionManager, entity.ScScheduleHdrIdSource);
				entity.ScScheduleHdrId = entity.ScScheduleHdrIdSource.ScScheduleHdrId;
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
			
			#region GsCodeGenderIdSource
			if (CanDeepSave(entity, "GsCodeGender|GsCodeGenderIdSource", deepSaveType, innerList) 
				&& entity.GsCodeGenderIdSource != null)
			{
				DataRepository.GsCodeGenderProvider.Save(transactionManager, entity.GsCodeGenderIdSource);
				entity.GsCodeGenderId = entity.GsCodeGenderIdSource.GsCodeGenderId;
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
			
			#region SeUserRsultApproveIdSource
			if (CanDeepSave(entity, "SeUser|SeUserRsultApproveIdSource", deepSaveType, innerList) 
				&& entity.SeUserRsultApproveIdSource != null)
			{
				DataRepository.SeUserProvider.Save(transactionManager, entity.SeUserRsultApproveIdSource);
				entity.SeUserRsultApproveId = entity.SeUserRsultApproveIdSource.SeUserId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<ScScheduleCrossList>
				if (CanDeepSave(entity.ScScheduleCrossListCollectionGetByScScheduleDtlId1, "List<ScScheduleCrossList>|ScScheduleCrossListCollectionGetByScScheduleDtlId1", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScScheduleCrossList child in entity.ScScheduleCrossListCollectionGetByScScheduleDtlId1)
					{
						if(child.ScScheduleDtlId1Source != null)
						{
							child.ScScheduleDtlId1 = child.ScScheduleDtlId1Source.ScScheduleDtlId;
						}
						else
						{
							child.ScScheduleDtlId1 = entity.ScScheduleDtlId;
						}

					}

					if (entity.ScScheduleCrossListCollectionGetByScScheduleDtlId1.Count > 0 || entity.ScScheduleCrossListCollectionGetByScScheduleDtlId1.DeletedItems.Count > 0)
					{
						//DataRepository.ScScheduleCrossListProvider.Save(transactionManager, entity.ScScheduleCrossListCollectionGetByScScheduleDtlId1);
						
						deepHandles.Add("ScScheduleCrossListCollectionGetByScScheduleDtlId1",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScScheduleCrossList >) DataRepository.ScScheduleCrossListProvider.DeepSave,
							new object[] { transactionManager, entity.ScScheduleCrossListCollectionGetByScScheduleDtlId1, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdExamSuprvsor>
				if (CanDeepSave(entity.EdExamSuprvsorCollection, "List<EdExamSuprvsor>|EdExamSuprvsorCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdExamSuprvsor child in entity.EdExamSuprvsorCollection)
					{
						if(child.ScScheduleDtlIdSource != null)
						{
							child.ScScheduleDtlId = child.ScScheduleDtlIdSource.ScScheduleDtlId;
						}
						else
						{
							child.ScScheduleDtlId = entity.ScScheduleDtlId;
						}

					}

					if (entity.EdExamSuprvsorCollection.Count > 0 || entity.EdExamSuprvsorCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdExamSuprvsorProvider.Save(transactionManager, entity.EdExamSuprvsorCollection);
						
						deepHandles.Add("EdExamSuprvsorCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdExamSuprvsor >) DataRepository.EdExamSuprvsorProvider.DeepSave,
							new object[] { transactionManager, entity.EdExamSuprvsorCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvLecNote>
				if (CanDeepSave(entity.SvLecNoteCollection, "List<SvLecNote>|SvLecNoteCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvLecNote child in entity.SvLecNoteCollection)
					{
						if(child.ScScheduleDtlIdSource != null)
						{
							child.ScScheduleDtlId = child.ScScheduleDtlIdSource.ScScheduleDtlId;
						}
						else
						{
							child.ScScheduleDtlId = entity.ScScheduleDtlId;
						}

					}

					if (entity.SvLecNoteCollection.Count > 0 || entity.SvLecNoteCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvLecNoteProvider.Save(transactionManager, entity.SvLecNoteCollection);
						
						deepHandles.Add("SvLecNoteCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvLecNote >) DataRepository.SvLecNoteProvider.DeepSave,
							new object[] { transactionManager, entity.SvLecNoteCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCourseInstance>
				if (CanDeepSave(entity.EdCourseInstanceCollection, "List<EdCourseInstance>|EdCourseInstanceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourseInstance child in entity.EdCourseInstanceCollection)
					{
						if(child.ScScheduleDtlIdSource != null)
						{
							child.ScScheduleDtlId = child.ScScheduleDtlIdSource.ScScheduleDtlId;
						}
						else
						{
							child.ScScheduleDtlId = entity.ScScheduleDtlId;
						}

					}

					if (entity.EdCourseInstanceCollection.Count > 0 || entity.EdCourseInstanceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseInstanceProvider.Save(transactionManager, entity.EdCourseInstanceCollection);
						
						deepHandles.Add("EdCourseInstanceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourseInstance >) DataRepository.EdCourseInstanceProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseInstanceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<WfCrsRsltApprove>
				if (CanDeepSave(entity.WfCrsRsltApproveCollection, "List<WfCrsRsltApprove>|WfCrsRsltApproveCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(WfCrsRsltApprove child in entity.WfCrsRsltApproveCollection)
					{
						if(child.ScScheduleDtlIdSource != null)
						{
							child.ScScheduleDtlId = child.ScScheduleDtlIdSource.ScScheduleDtlId;
						}
						else
						{
							child.ScScheduleDtlId = entity.ScScheduleDtlId;
						}

					}

					if (entity.WfCrsRsltApproveCollection.Count > 0 || entity.WfCrsRsltApproveCollection.DeletedItems.Count > 0)
					{
						//DataRepository.WfCrsRsltApproveProvider.Save(transactionManager, entity.WfCrsRsltApproveCollection);
						
						deepHandles.Add("WfCrsRsltApproveCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< WfCrsRsltApprove >) DataRepository.WfCrsRsltApproveProvider.DeepSave,
							new object[] { transactionManager, entity.WfCrsRsltApproveCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoExamSchdlPlace>
				if (CanDeepSave(entity.CoExamSchdlPlaceCollection, "List<CoExamSchdlPlace>|CoExamSchdlPlaceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoExamSchdlPlace child in entity.CoExamSchdlPlaceCollection)
					{
						if(child.ScScheduleDtlIdSource != null)
						{
							child.ScScheduleDtlId = child.ScScheduleDtlIdSource.ScScheduleDtlId;
						}
						else
						{
							child.ScScheduleDtlId = entity.ScScheduleDtlId;
						}

					}

					if (entity.CoExamSchdlPlaceCollection.Count > 0 || entity.CoExamSchdlPlaceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoExamSchdlPlaceProvider.Save(transactionManager, entity.CoExamSchdlPlaceCollection);
						
						deepHandles.Add("CoExamSchdlPlaceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoExamSchdlPlace >) DataRepository.CoExamSchdlPlaceProvider.DeepSave,
							new object[] { transactionManager, entity.CoExamSchdlPlaceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScSectionGroupDtl>
				if (CanDeepSave(entity.ScSectionGroupDtlCollection, "List<ScSectionGroupDtl>|ScSectionGroupDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScSectionGroupDtl child in entity.ScSectionGroupDtlCollection)
					{
						if(child.ScScheduleDtlIdSource != null)
						{
							child.ScScheduleDtlId = child.ScScheduleDtlIdSource.ScScheduleDtlId;
						}
						else
						{
							child.ScScheduleDtlId = entity.ScScheduleDtlId;
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
				
	
			#region List<EdStudGroupPre>
				if (CanDeepSave(entity.EdStudGroupPreCollection, "List<EdStudGroupPre>|EdStudGroupPreCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudGroupPre child in entity.EdStudGroupPreCollection)
					{
						if(child.ScScheduleDtlIdSource != null)
						{
							child.ScScheduleDtlId = child.ScScheduleDtlIdSource.ScScheduleDtlId;
						}
						else
						{
							child.ScScheduleDtlId = entity.ScScheduleDtlId;
						}

					}

					if (entity.EdStudGroupPreCollection.Count > 0 || entity.EdStudGroupPreCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudGroupPreProvider.Save(transactionManager, entity.EdStudGroupPreCollection);
						
						deepHandles.Add("EdStudGroupPreCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudGroupPre >) DataRepository.EdStudGroupPreProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudGroupPreCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvPollHdr>
				if (CanDeepSave(entity.SvPollHdrCollection, "List<SvPollHdr>|SvPollHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvPollHdr child in entity.SvPollHdrCollection)
					{
						if(child.ScScheduleDtlIdSource != null)
						{
							child.ScScheduleDtlId = child.ScScheduleDtlIdSource.ScScheduleDtlId;
						}
						else
						{
							child.ScScheduleDtlId = entity.ScScheduleDtlId;
						}

					}

					if (entity.SvPollHdrCollection.Count > 0 || entity.SvPollHdrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvPollHdrProvider.Save(transactionManager, entity.SvPollHdrCollection);
						
						deepHandles.Add("SvPollHdrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvPollHdr >) DataRepository.SvPollHdrProvider.DeepSave,
							new object[] { transactionManager, entity.SvPollHdrCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScScheduleCrossList>
				if (CanDeepSave(entity.ScScheduleCrossListCollectionGetByScScheduleDtlId2, "List<ScScheduleCrossList>|ScScheduleCrossListCollectionGetByScScheduleDtlId2", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScScheduleCrossList child in entity.ScScheduleCrossListCollectionGetByScScheduleDtlId2)
					{
						if(child.ScScheduleDtlId2Source != null)
						{
							child.ScScheduleDtlId2 = child.ScScheduleDtlId2Source.ScScheduleDtlId;
						}
						else
						{
							child.ScScheduleDtlId2 = entity.ScScheduleDtlId;
						}

					}

					if (entity.ScScheduleCrossListCollectionGetByScScheduleDtlId2.Count > 0 || entity.ScScheduleCrossListCollectionGetByScScheduleDtlId2.DeletedItems.Count > 0)
					{
						//DataRepository.ScScheduleCrossListProvider.Save(transactionManager, entity.ScScheduleCrossListCollectionGetByScScheduleDtlId2);
						
						deepHandles.Add("ScScheduleCrossListCollectionGetByScScheduleDtlId2",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScScheduleCrossList >) DataRepository.ScScheduleCrossListProvider.DeepSave,
							new object[] { transactionManager, entity.ScScheduleCrossListCollectionGetByScScheduleDtlId2, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScScheduleDtlDay>
				if (CanDeepSave(entity.ScScheduleDtlDayCollection, "List<ScScheduleDtlDay>|ScScheduleDtlDayCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScScheduleDtlDay child in entity.ScScheduleDtlDayCollection)
					{
						if(child.ScScheduleDtlIdSource != null)
						{
							child.ScScheduleDtlId = child.ScScheduleDtlIdSource.ScScheduleDtlId;
						}
						else
						{
							child.ScScheduleDtlId = entity.ScScheduleDtlId;
						}

					}

					if (entity.ScScheduleDtlDayCollection.Count > 0 || entity.ScScheduleDtlDayCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScScheduleDtlDayProvider.Save(transactionManager, entity.ScScheduleDtlDayCollection);
						
						deepHandles.Add("ScScheduleDtlDayCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScScheduleDtlDay >) DataRepository.ScScheduleDtlDayProvider.DeepSave,
							new object[] { transactionManager, entity.ScScheduleDtlDayCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseWait>
				if (CanDeepSave(entity.EdStudCourseWaitCollection, "List<EdStudCourseWait>|EdStudCourseWaitCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseWait child in entity.EdStudCourseWaitCollection)
					{
						if(child.ScScheduleDtlIdSource != null)
						{
							child.ScScheduleDtlId = child.ScScheduleDtlIdSource.ScScheduleDtlId;
						}
						else
						{
							child.ScScheduleDtlId = entity.ScScheduleDtlId;
						}

					}

					if (entity.EdStudCourseWaitCollection.Count > 0 || entity.EdStudCourseWaitCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseWaitProvider.Save(transactionManager, entity.EdStudCourseWaitCollection);
						
						deepHandles.Add("EdStudCourseWaitCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseWait >) DataRepository.EdStudCourseWaitProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseWaitCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudGroup>
				if (CanDeepSave(entity.EdStudGroupCollection, "List<EdStudGroup>|EdStudGroupCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudGroup child in entity.EdStudGroupCollection)
					{
						if(child.ScScheduleDtlIdSource != null)
						{
							child.ScScheduleDtlId = child.ScScheduleDtlIdSource.ScScheduleDtlId;
						}
						else
						{
							child.ScScheduleDtlId = entity.ScScheduleDtlId;
						}

					}

					if (entity.EdStudGroupCollection.Count > 0 || entity.EdStudGroupCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudGroupProvider.Save(transactionManager, entity.EdStudGroupCollection);
						
						deepHandles.Add("EdStudGroupCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudGroup >) DataRepository.EdStudGroupProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudGroupCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScScheduleRsrv>
				if (CanDeepSave(entity.ScScheduleRsrvCollection, "List<ScScheduleRsrv>|ScScheduleRsrvCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScScheduleRsrv child in entity.ScScheduleRsrvCollection)
					{
						if(child.ScScheduleDtlIdSource != null)
						{
							child.ScScheduleDtlId = child.ScScheduleDtlIdSource.ScScheduleDtlId;
						}
						else
						{
							child.ScScheduleDtlId = entity.ScScheduleDtlId;
						}

					}

					if (entity.ScScheduleRsrvCollection.Count > 0 || entity.ScScheduleRsrvCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScScheduleRsrvProvider.Save(transactionManager, entity.ScScheduleRsrvCollection);
						
						deepHandles.Add("ScScheduleRsrvCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScScheduleRsrv >) DataRepository.ScScheduleRsrvProvider.DeepSave,
							new object[] { transactionManager, entity.ScScheduleRsrvCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScScheduleDtlExtStf>
				if (CanDeepSave(entity.ScScheduleDtlExtStfCollection, "List<ScScheduleDtlExtStf>|ScScheduleDtlExtStfCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScScheduleDtlExtStf child in entity.ScScheduleDtlExtStfCollection)
					{
						if(child.ScScheduleDtlIdSource != null)
						{
							child.ScScheduleDtlId = child.ScScheduleDtlIdSource.ScScheduleDtlId;
						}
						else
						{
							child.ScScheduleDtlId = entity.ScScheduleDtlId;
						}

					}

					if (entity.ScScheduleDtlExtStfCollection.Count > 0 || entity.ScScheduleDtlExtStfCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScScheduleDtlExtStfProvider.Save(transactionManager, entity.ScScheduleDtlExtStfCollection);
						
						deepHandles.Add("ScScheduleDtlExtStfCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScScheduleDtlExtStf >) DataRepository.ScScheduleDtlExtStfProvider.DeepSave,
							new object[] { transactionManager, entity.ScScheduleDtlExtStfCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeBlockTrans>
				if (CanDeepSave(entity.SeBlockTransCollection, "List<SeBlockTrans>|SeBlockTransCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeBlockTrans child in entity.SeBlockTransCollection)
					{
						if(child.ScScheduleDtlIdSource != null)
						{
							child.ScScheduleDtlId = child.ScScheduleDtlIdSource.ScScheduleDtlId;
						}
						else
						{
							child.ScScheduleDtlId = entity.ScScheduleDtlId;
						}

					}

					if (entity.SeBlockTransCollection.Count > 0 || entity.SeBlockTransCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeBlockTransProvider.Save(transactionManager, entity.SeBlockTransCollection);
						
						deepHandles.Add("SeBlockTransCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeBlockTrans >) DataRepository.SeBlockTransProvider.DeepSave,
							new object[] { transactionManager, entity.SeBlockTransCollection, deepSaveType, childTypes, innerList }
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
	
	#region ScScheduleDtlChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.ScScheduleDtl</c>
	///</summary>
	public enum ScScheduleDtlChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>ScScheduleHdr</c> at ScScheduleHdrIdSource
		///</summary>
		[ChildEntityType(typeof(ScScheduleHdr))]
		ScScheduleHdr,
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>GsCodeGender</c> at GsCodeGenderIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeGender))]
		GsCodeGender,
		
		///<summary>
		/// Composite Property for <c>GsCodeLanguage</c> at GsCodeLanguageIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeLanguage))]
		GsCodeLanguage,
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at SeUserRsultApproveIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
		///<summary>
		/// Collection of <c>ScScheduleDtl</c> as OneToMany for ScScheduleCrossListCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScScheduleCrossList>))]
		ScScheduleCrossListCollectionGetByScScheduleDtlId1,
		///<summary>
		/// Collection of <c>ScScheduleDtl</c> as OneToMany for EdExamSuprvsorCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdExamSuprvsor>))]
		EdExamSuprvsorCollection,
		///<summary>
		/// Collection of <c>ScScheduleDtl</c> as OneToMany for SvLecNoteCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvLecNote>))]
		SvLecNoteCollection,
		///<summary>
		/// Collection of <c>ScScheduleDtl</c> as OneToMany for EdCourseInstanceCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourseInstance>))]
		EdCourseInstanceCollection,
		///<summary>
		/// Collection of <c>ScScheduleDtl</c> as OneToMany for WfCrsRsltApproveCollection
		///</summary>
		[ChildEntityType(typeof(TList<WfCrsRsltApprove>))]
		WfCrsRsltApproveCollection,
		///<summary>
		/// Collection of <c>ScScheduleDtl</c> as OneToMany for CoExamSchdlPlaceCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoExamSchdlPlace>))]
		CoExamSchdlPlaceCollection,
		///<summary>
		/// Collection of <c>ScScheduleDtl</c> as OneToMany for ScSectionGroupDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScSectionGroupDtl>))]
		ScSectionGroupDtlCollection,
		///<summary>
		/// Collection of <c>ScScheduleDtl</c> as OneToMany for EdStudGroupPreCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudGroupPre>))]
		EdStudGroupPreCollection,
		///<summary>
		/// Collection of <c>ScScheduleDtl</c> as OneToMany for SvPollHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvPollHdr>))]
		SvPollHdrCollection,
		///<summary>
		/// Collection of <c>ScScheduleDtl</c> as OneToMany for ScScheduleCrossListCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScScheduleCrossList>))]
		ScScheduleCrossListCollectionGetByScScheduleDtlId2,
		///<summary>
		/// Collection of <c>ScScheduleDtl</c> as OneToMany for ScScheduleDtlDayCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScScheduleDtlDay>))]
		ScScheduleDtlDayCollection,
		///<summary>
		/// Collection of <c>ScScheduleDtl</c> as OneToMany for EdStudCourseWaitCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseWait>))]
		EdStudCourseWaitCollection,
		///<summary>
		/// Collection of <c>ScScheduleDtl</c> as OneToMany for EdStudGroupCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudGroup>))]
		EdStudGroupCollection,
		///<summary>
		/// Collection of <c>ScScheduleDtl</c> as OneToMany for ScScheduleRsrvCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScScheduleRsrv>))]
		ScScheduleRsrvCollection,
		///<summary>
		/// Collection of <c>ScScheduleDtl</c> as OneToMany for ScScheduleDtlExtStfCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScScheduleDtlExtStf>))]
		ScScheduleDtlExtStfCollection,
		///<summary>
		/// Collection of <c>ScScheduleDtl</c> as OneToMany for SeBlockTransCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeBlockTrans>))]
		SeBlockTransCollection,
	}
	
	#endregion ScScheduleDtlChildEntityTypes
	
	#region ScScheduleDtlFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ScScheduleDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScScheduleDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScScheduleDtlFilterBuilder : SqlFilterBuilder<ScScheduleDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScScheduleDtlFilterBuilder class.
		/// </summary>
		public ScScheduleDtlFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScScheduleDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScScheduleDtlFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScScheduleDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScScheduleDtlFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScScheduleDtlFilterBuilder
	
	#region ScScheduleDtlParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ScScheduleDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScScheduleDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScScheduleDtlParameterBuilder : ParameterizedSqlFilterBuilder<ScScheduleDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScScheduleDtlParameterBuilder class.
		/// </summary>
		public ScScheduleDtlParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScScheduleDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScScheduleDtlParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScScheduleDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScScheduleDtlParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScScheduleDtlParameterBuilder
	
	#region ScScheduleDtlSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ScScheduleDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScScheduleDtl"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ScScheduleDtlSortBuilder : SqlSortBuilder<ScScheduleDtlColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScScheduleDtlSqlSortBuilder class.
		/// </summary>
		public ScScheduleDtlSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ScScheduleDtlSortBuilder
	
} // end namespace
