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
	/// This class is the base class for any <see cref="AdmPlaceExamDatetimeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmPlaceExamDatetimeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime, UMIS_VER2.BusinessLyer.AdmPlaceExamDatetimeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmPlaceExamDatetimeKey key)
		{
			return Delete(transactionManager, key.AdmPlaceExamDatetimeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admPlaceExamDatetimeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admPlaceExamDatetimeId)
		{
			return Delete(null, _admPlaceExamDatetimeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admPlaceExamDatetimeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admPlaceExamDatetimeId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_ADM_CDE_APP_TYPE key.
		///		FK_ADM_PLACE_EXAM_DATETIME_ADM_CDE_APP_TYPE Description: 
		/// </summary>
		/// <param name="_admCdeAppTypeId">CSS</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public TList<AdmPlaceExamDatetime> GetByAdmCdeAppTypeId(System.Decimal? _admCdeAppTypeId)
		{
			int count = -1;
			return GetByAdmCdeAppTypeId(_admCdeAppTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_ADM_CDE_APP_TYPE key.
		///		FK_ADM_PLACE_EXAM_DATETIME_ADM_CDE_APP_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAppTypeId">CSS</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		/// <remarks></remarks>
		public TList<AdmPlaceExamDatetime> GetByAdmCdeAppTypeId(TransactionManager transactionManager, System.Decimal? _admCdeAppTypeId)
		{
			int count = -1;
			return GetByAdmCdeAppTypeId(transactionManager, _admCdeAppTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_ADM_CDE_APP_TYPE key.
		///		FK_ADM_PLACE_EXAM_DATETIME_ADM_CDE_APP_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAppTypeId">CSS</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public TList<AdmPlaceExamDatetime> GetByAdmCdeAppTypeId(TransactionManager transactionManager, System.Decimal? _admCdeAppTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeAppTypeId(transactionManager, _admCdeAppTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_ADM_CDE_APP_TYPE key.
		///		fkAdmPlaceExamDatetimeAdmCdeAppType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeAppTypeId">CSS</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public TList<AdmPlaceExamDatetime> GetByAdmCdeAppTypeId(System.Decimal? _admCdeAppTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCdeAppTypeId(null, _admCdeAppTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_ADM_CDE_APP_TYPE key.
		///		fkAdmPlaceExamDatetimeAdmCdeAppType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeAppTypeId">CSS</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public TList<AdmPlaceExamDatetime> GetByAdmCdeAppTypeId(System.Decimal? _admCdeAppTypeId, int start, int pageLength,out int count)
		{
			return GetByAdmCdeAppTypeId(null, _admCdeAppTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_ADM_CDE_APP_TYPE key.
		///		FK_ADM_PLACE_EXAM_DATETIME_ADM_CDE_APP_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAppTypeId">CSS</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public abstract TList<AdmPlaceExamDatetime> GetByAdmCdeAppTypeId(TransactionManager transactionManager, System.Decimal? _admCdeAppTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_ADM_CDE_PLACEMENT_EXAM key.
		///		FK_ADM_PLACE_EXAM_DATETIME_ADM_CDE_PLACEMENT_EXAM Description: 
		/// </summary>
		/// <param name="_admCdePlacementExamId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public TList<AdmPlaceExamDatetime> GetByAdmCdePlacementExamId(System.Decimal _admCdePlacementExamId)
		{
			int count = -1;
			return GetByAdmCdePlacementExamId(_admCdePlacementExamId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_ADM_CDE_PLACEMENT_EXAM key.
		///		FK_ADM_PLACE_EXAM_DATETIME_ADM_CDE_PLACEMENT_EXAM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdePlacementExamId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		/// <remarks></remarks>
		public TList<AdmPlaceExamDatetime> GetByAdmCdePlacementExamId(TransactionManager transactionManager, System.Decimal _admCdePlacementExamId)
		{
			int count = -1;
			return GetByAdmCdePlacementExamId(transactionManager, _admCdePlacementExamId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_ADM_CDE_PLACEMENT_EXAM key.
		///		FK_ADM_PLACE_EXAM_DATETIME_ADM_CDE_PLACEMENT_EXAM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdePlacementExamId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public TList<AdmPlaceExamDatetime> GetByAdmCdePlacementExamId(TransactionManager transactionManager, System.Decimal _admCdePlacementExamId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdePlacementExamId(transactionManager, _admCdePlacementExamId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_ADM_CDE_PLACEMENT_EXAM key.
		///		fkAdmPlaceExamDatetimeAdmCdePlacementExam Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdePlacementExamId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public TList<AdmPlaceExamDatetime> GetByAdmCdePlacementExamId(System.Decimal _admCdePlacementExamId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCdePlacementExamId(null, _admCdePlacementExamId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_ADM_CDE_PLACEMENT_EXAM key.
		///		fkAdmPlaceExamDatetimeAdmCdePlacementExam Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdePlacementExamId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public TList<AdmPlaceExamDatetime> GetByAdmCdePlacementExamId(System.Decimal _admCdePlacementExamId, int start, int pageLength,out int count)
		{
			return GetByAdmCdePlacementExamId(null, _admCdePlacementExamId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_ADM_CDE_PLACEMENT_EXAM key.
		///		FK_ADM_PLACE_EXAM_DATETIME_ADM_CDE_PLACEMENT_EXAM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdePlacementExamId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public abstract TList<AdmPlaceExamDatetime> GetByAdmCdePlacementExamId(TransactionManager transactionManager, System.Decimal _admCdePlacementExamId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_ADM_OPEN_ACAD_SEMESTER key.
		///		FK_ADM_PLACE_EXAM_DATETIME_ADM_OPEN_ACAD_SEMESTER Description: 
		/// </summary>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public TList<AdmPlaceExamDatetime> GetByAdmOpenAcadSemesterId(System.Decimal? _admOpenAcadSemesterId)
		{
			int count = -1;
			return GetByAdmOpenAcadSemesterId(_admOpenAcadSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_ADM_OPEN_ACAD_SEMESTER key.
		///		FK_ADM_PLACE_EXAM_DATETIME_ADM_OPEN_ACAD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		/// <remarks></remarks>
		public TList<AdmPlaceExamDatetime> GetByAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal? _admOpenAcadSemesterId)
		{
			int count = -1;
			return GetByAdmOpenAcadSemesterId(transactionManager, _admOpenAcadSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_ADM_OPEN_ACAD_SEMESTER key.
		///		FK_ADM_PLACE_EXAM_DATETIME_ADM_OPEN_ACAD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public TList<AdmPlaceExamDatetime> GetByAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal? _admOpenAcadSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmOpenAcadSemesterId(transactionManager, _admOpenAcadSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_ADM_OPEN_ACAD_SEMESTER key.
		///		fkAdmPlaceExamDatetimeAdmOpenAcadSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public TList<AdmPlaceExamDatetime> GetByAdmOpenAcadSemesterId(System.Decimal? _admOpenAcadSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmOpenAcadSemesterId(null, _admOpenAcadSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_ADM_OPEN_ACAD_SEMESTER key.
		///		fkAdmPlaceExamDatetimeAdmOpenAcadSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public TList<AdmPlaceExamDatetime> GetByAdmOpenAcadSemesterId(System.Decimal? _admOpenAcadSemesterId, int start, int pageLength,out int count)
		{
			return GetByAdmOpenAcadSemesterId(null, _admOpenAcadSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_ADM_OPEN_ACAD_SEMESTER key.
		///		FK_ADM_PLACE_EXAM_DATETIME_ADM_OPEN_ACAD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public abstract TList<AdmPlaceExamDatetime> GetByAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal? _admOpenAcadSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_ENTITY_MAIN key.
		///		FK_ADM_PLACE_EXAM_DATETIME_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public TList<AdmPlaceExamDatetime> GetByEntMainId(System.Decimal? _entMainId)
		{
			int count = -1;
			return GetByEntMainId(_entMainId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_ENTITY_MAIN key.
		///		FK_ADM_PLACE_EXAM_DATETIME_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		/// <remarks></remarks>
		public TList<AdmPlaceExamDatetime> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_ENTITY_MAIN key.
		///		FK_ADM_PLACE_EXAM_DATETIME_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public TList<AdmPlaceExamDatetime> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_ENTITY_MAIN key.
		///		fkAdmPlaceExamDatetimeEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public TList<AdmPlaceExamDatetime> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainId(null, _entMainId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_ENTITY_MAIN key.
		///		fkAdmPlaceExamDatetimeEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public TList<AdmPlaceExamDatetime> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength,out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_ENTITY_MAIN key.
		///		FK_ADM_PLACE_EXAM_DATETIME_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public abstract TList<AdmPlaceExamDatetime> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_GS_CODE_GENDER key.
		///		FK_ADM_PLACE_EXAM_DATETIME_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="_gsCodeGenderId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public TList<AdmPlaceExamDatetime> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId)
		{
			int count = -1;
			return GetByGsCodeGenderId(_gsCodeGenderId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_GS_CODE_GENDER key.
		///		FK_ADM_PLACE_EXAM_DATETIME_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		/// <remarks></remarks>
		public TList<AdmPlaceExamDatetime> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId)
		{
			int count = -1;
			return GetByGsCodeGenderId(transactionManager, _gsCodeGenderId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_GS_CODE_GENDER key.
		///		FK_ADM_PLACE_EXAM_DATETIME_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public TList<AdmPlaceExamDatetime> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeGenderId(transactionManager, _gsCodeGenderId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_GS_CODE_GENDER key.
		///		fkAdmPlaceExamDatetimeGsCodeGender Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public TList<AdmPlaceExamDatetime> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeGenderId(null, _gsCodeGenderId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_GS_CODE_GENDER key.
		///		fkAdmPlaceExamDatetimeGsCodeGender Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public TList<AdmPlaceExamDatetime> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId, int start, int pageLength,out int count)
		{
			return GetByGsCodeGenderId(null, _gsCodeGenderId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_GS_CODE_GENDER key.
		///		FK_ADM_PLACE_EXAM_DATETIME_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public abstract TList<AdmPlaceExamDatetime> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_SC_BUILDING key.
		///		FK_ADM_PLACE_EXAM_DATETIME_SC_BUILDING Description: 
		/// </summary>
		/// <param name="_scBuildingId">XXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public TList<AdmPlaceExamDatetime> GetByScBuildingId(System.Decimal? _scBuildingId)
		{
			int count = -1;
			return GetByScBuildingId(_scBuildingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_SC_BUILDING key.
		///		FK_ADM_PLACE_EXAM_DATETIME_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId">XXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		/// <remarks></remarks>
		public TList<AdmPlaceExamDatetime> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId)
		{
			int count = -1;
			return GetByScBuildingId(transactionManager, _scBuildingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_SC_BUILDING key.
		///		FK_ADM_PLACE_EXAM_DATETIME_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public TList<AdmPlaceExamDatetime> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId, int start, int pageLength)
		{
			int count = -1;
			return GetByScBuildingId(transactionManager, _scBuildingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_SC_BUILDING key.
		///		fkAdmPlaceExamDatetimeScBuilding Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scBuildingId">XXX</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public TList<AdmPlaceExamDatetime> GetByScBuildingId(System.Decimal? _scBuildingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScBuildingId(null, _scBuildingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_SC_BUILDING key.
		///		fkAdmPlaceExamDatetimeScBuilding Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scBuildingId">XXX</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public TList<AdmPlaceExamDatetime> GetByScBuildingId(System.Decimal? _scBuildingId, int start, int pageLength,out int count)
		{
			return GetByScBuildingId(null, _scBuildingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_SC_BUILDING key.
		///		FK_ADM_PLACE_EXAM_DATETIME_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public abstract TList<AdmPlaceExamDatetime> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_SC_HALL key.
		///		FK_ADM_PLACE_EXAM_DATETIME_SC_HALL Description: 
		/// </summary>
		/// <param name="_scHallId">XXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public TList<AdmPlaceExamDatetime> GetByScHallId(System.Decimal? _scHallId)
		{
			int count = -1;
			return GetByScHallId(_scHallId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_SC_HALL key.
		///		FK_ADM_PLACE_EXAM_DATETIME_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId">XXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		/// <remarks></remarks>
		public TList<AdmPlaceExamDatetime> GetByScHallId(TransactionManager transactionManager, System.Decimal? _scHallId)
		{
			int count = -1;
			return GetByScHallId(transactionManager, _scHallId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_SC_HALL key.
		///		FK_ADM_PLACE_EXAM_DATETIME_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public TList<AdmPlaceExamDatetime> GetByScHallId(TransactionManager transactionManager, System.Decimal? _scHallId, int start, int pageLength)
		{
			int count = -1;
			return GetByScHallId(transactionManager, _scHallId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_SC_HALL key.
		///		fkAdmPlaceExamDatetimeScHall Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scHallId">XXX</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public TList<AdmPlaceExamDatetime> GetByScHallId(System.Decimal? _scHallId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScHallId(null, _scHallId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_SC_HALL key.
		///		fkAdmPlaceExamDatetimeScHall Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scHallId">XXX</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public TList<AdmPlaceExamDatetime> GetByScHallId(System.Decimal? _scHallId, int start, int pageLength,out int count)
		{
			return GetByScHallId(null, _scHallId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_SC_HALL key.
		///		FK_ADM_PLACE_EXAM_DATETIME_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public abstract TList<AdmPlaceExamDatetime> GetByScHallId(TransactionManager transactionManager, System.Decimal? _scHallId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_SV_SRVY_HDR key.
		///		FK_ADM_PLACE_EXAM_DATETIME_SV_SRVY_HDR Description: 
		/// </summary>
		/// <param name="_svSrvyHdrId">Dynamic question Template</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public TList<AdmPlaceExamDatetime> GetBySvSrvyHdrId(System.Int32? _svSrvyHdrId)
		{
			int count = -1;
			return GetBySvSrvyHdrId(_svSrvyHdrId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_SV_SRVY_HDR key.
		///		FK_ADM_PLACE_EXAM_DATETIME_SV_SRVY_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyHdrId">Dynamic question Template</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		/// <remarks></remarks>
		public TList<AdmPlaceExamDatetime> GetBySvSrvyHdrId(TransactionManager transactionManager, System.Int32? _svSrvyHdrId)
		{
			int count = -1;
			return GetBySvSrvyHdrId(transactionManager, _svSrvyHdrId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_SV_SRVY_HDR key.
		///		FK_ADM_PLACE_EXAM_DATETIME_SV_SRVY_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyHdrId">Dynamic question Template</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public TList<AdmPlaceExamDatetime> GetBySvSrvyHdrId(TransactionManager transactionManager, System.Int32? _svSrvyHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvSrvyHdrId(transactionManager, _svSrvyHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_SV_SRVY_HDR key.
		///		fkAdmPlaceExamDatetimeSvSrvyHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svSrvyHdrId">Dynamic question Template</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public TList<AdmPlaceExamDatetime> GetBySvSrvyHdrId(System.Int32? _svSrvyHdrId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySvSrvyHdrId(null, _svSrvyHdrId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_SV_SRVY_HDR key.
		///		fkAdmPlaceExamDatetimeSvSrvyHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svSrvyHdrId">Dynamic question Template</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public TList<AdmPlaceExamDatetime> GetBySvSrvyHdrId(System.Int32? _svSrvyHdrId, int start, int pageLength,out int count)
		{
			return GetBySvSrvyHdrId(null, _svSrvyHdrId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_DATETIME_SV_SRVY_HDR key.
		///		FK_ADM_PLACE_EXAM_DATETIME_SV_SRVY_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyHdrId">Dynamic question Template</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime objects.</returns>
		public abstract TList<AdmPlaceExamDatetime> GetBySvSrvyHdrId(TransactionManager transactionManager, System.Int32? _svSrvyHdrId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmPlaceExamDatetimeKey key, int start, int pageLength)
		{
			return GetByAdmPlaceExamDatetimeId(transactionManager, key.AdmPlaceExamDatetimeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_PLACEMENT_EXAM_TIME index.
		/// </summary>
		/// <param name="_admPlaceExamDatetimeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime GetByAdmPlaceExamDatetimeId(System.Decimal _admPlaceExamDatetimeId)
		{
			int count = -1;
			return GetByAdmPlaceExamDatetimeId(null,_admPlaceExamDatetimeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_PLACEMENT_EXAM_TIME index.
		/// </summary>
		/// <param name="_admPlaceExamDatetimeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime GetByAdmPlaceExamDatetimeId(System.Decimal _admPlaceExamDatetimeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmPlaceExamDatetimeId(null, _admPlaceExamDatetimeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_PLACEMENT_EXAM_TIME index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admPlaceExamDatetimeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime GetByAdmPlaceExamDatetimeId(TransactionManager transactionManager, System.Decimal _admPlaceExamDatetimeId)
		{
			int count = -1;
			return GetByAdmPlaceExamDatetimeId(transactionManager, _admPlaceExamDatetimeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_PLACEMENT_EXAM_TIME index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admPlaceExamDatetimeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime GetByAdmPlaceExamDatetimeId(TransactionManager transactionManager, System.Decimal _admPlaceExamDatetimeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmPlaceExamDatetimeId(transactionManager, _admPlaceExamDatetimeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_PLACEMENT_EXAM_TIME index.
		/// </summary>
		/// <param name="_admPlaceExamDatetimeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime GetByAdmPlaceExamDatetimeId(System.Decimal _admPlaceExamDatetimeId, int start, int pageLength, out int count)
		{
			return GetByAdmPlaceExamDatetimeId(null, _admPlaceExamDatetimeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_PLACEMENT_EXAM_TIME index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admPlaceExamDatetimeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime GetByAdmPlaceExamDatetimeId(TransactionManager transactionManager, System.Decimal _admPlaceExamDatetimeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmPlaceExamDatetime&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmPlaceExamDatetime&gt;"/></returns>
		public static TList<AdmPlaceExamDatetime> Fill(IDataReader reader, TList<AdmPlaceExamDatetime> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmPlaceExamDatetime")
					.Append("|").Append((System.Decimal)reader["ADM_PLACE_EXAM_DATETIME_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmPlaceExamDatetime>(
					key.ToString(), // EntityTrackingKey
					"AdmPlaceExamDatetime",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime();
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
					c.AdmPlaceExamDatetimeId = (System.Decimal)reader["ADM_PLACE_EXAM_DATETIME_ID"];
					c.OriginalAdmPlaceExamDatetimeId = c.AdmPlaceExamDatetimeId;
					c.AdmCdePlacementExamId = (System.Decimal)reader["ADM_CDE_PLACEMENT_EXAM_ID"];
					c.ExamDate = (System.DateTime)reader["EXAM_DATE"];
					c.ExamTimeFrom = (System.DateTime)reader["EXAM_TIME_FROM"];
					c.ExamTimeTo = (System.DateTime)reader["EXAM_TIME_TO"];
					c.AdmOpenAcadSemesterId = Convert.IsDBNull(reader["ADM_OPEN_ACAD_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ADM_OPEN_ACAD_SEMESTER_ID"];
					c.Location = Convert.IsDBNull(reader["LOCATION"]) ? null : (System.String)reader["LOCATION"];
					c.IsOptionalExam = Convert.IsDBNull(reader["IS_OPTIONAL_EXAM"]) ? null : (System.Decimal?)reader["IS_OPTIONAL_EXAM"];
					c.QualPercentageFromPriv = Convert.IsDBNull(reader["QUAL_PERCENTAGE_FROM_PRIV"]) ? null : (System.Decimal?)reader["QUAL_PERCENTAGE_FROM_PRIV"];
					c.QualPercentageToPriv = Convert.IsDBNull(reader["QUAL_PERCENTAGE_TO_PRIV"]) ? null : (System.Decimal?)reader["QUAL_PERCENTAGE_TO_PRIV"];
					c.RelatedToProgram = Convert.IsDBNull(reader["RELATED_To_PROGRAM"]) ? null : (System.Decimal?)reader["RELATED_To_PROGRAM"];
					c.EntMainId = Convert.IsDBNull(reader["ENT_MAIN_ID"]) ? null : (System.Decimal?)reader["ENT_MAIN_ID"];
					c.QualPercentageToPub = Convert.IsDBNull(reader["QUAL_PERCENTAGE_TO_PUB"]) ? null : (System.Decimal?)reader["QUAL_PERCENTAGE_TO_PUB"];
					c.QualPercentageFromPub = Convert.IsDBNull(reader["QUAL_PERCENTAGE_FROM_PUB"]) ? null : (System.Decimal?)reader["QUAL_PERCENTAGE_FROM_PUB"];
					c.ScBuildingId = Convert.IsDBNull(reader["SC_BUILDING_ID"]) ? null : (System.Decimal?)reader["SC_BUILDING_ID"];
					c.ScHallId = Convert.IsDBNull(reader["SC_HALL_ID"]) ? null : (System.Decimal?)reader["SC_HALL_ID"];
					c.ApproveFlg = Convert.IsDBNull(reader["APPROVE_FLG"]) ? null : (System.Boolean?)reader["APPROVE_FLG"];
					c.GsCodeGenderId = Convert.IsDBNull(reader["GS_CODE_GENDER_ID"]) ? null : (System.Decimal?)reader["GS_CODE_GENDER_ID"];
					c.AdmCdeAppTypeId = Convert.IsDBNull(reader["ADM_CDE_APP_TYPE_ID"]) ? null : (System.Decimal?)reader["ADM_CDE_APP_TYPE_ID"];
					c.AwkafFlg = Convert.IsDBNull(reader["AWKAF_FLG"]) ? null : (System.Boolean?)reader["AWKAF_FLG"];
					c.SvSrvyHdrId = Convert.IsDBNull(reader["SV_SRVY_HDR_ID"]) ? null : (System.Int32?)reader["SV_SRVY_HDR_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmPlaceExamDatetimeId = (System.Decimal)reader[((int)AdmPlaceExamDatetimeColumn.AdmPlaceExamDatetimeId - 1)];
			entity.OriginalAdmPlaceExamDatetimeId = (System.Decimal)reader["ADM_PLACE_EXAM_DATETIME_ID"];
			entity.AdmCdePlacementExamId = (System.Decimal)reader[((int)AdmPlaceExamDatetimeColumn.AdmCdePlacementExamId - 1)];
			entity.ExamDate = (System.DateTime)reader[((int)AdmPlaceExamDatetimeColumn.ExamDate - 1)];
			entity.ExamTimeFrom = (System.DateTime)reader[((int)AdmPlaceExamDatetimeColumn.ExamTimeFrom - 1)];
			entity.ExamTimeTo = (System.DateTime)reader[((int)AdmPlaceExamDatetimeColumn.ExamTimeTo - 1)];
			entity.AdmOpenAcadSemesterId = (reader.IsDBNull(((int)AdmPlaceExamDatetimeColumn.AdmOpenAcadSemesterId - 1)))?null:(System.Decimal?)reader[((int)AdmPlaceExamDatetimeColumn.AdmOpenAcadSemesterId - 1)];
			entity.Location = (reader.IsDBNull(((int)AdmPlaceExamDatetimeColumn.Location - 1)))?null:(System.String)reader[((int)AdmPlaceExamDatetimeColumn.Location - 1)];
			entity.IsOptionalExam = (reader.IsDBNull(((int)AdmPlaceExamDatetimeColumn.IsOptionalExam - 1)))?null:(System.Decimal?)reader[((int)AdmPlaceExamDatetimeColumn.IsOptionalExam - 1)];
			entity.QualPercentageFromPriv = (reader.IsDBNull(((int)AdmPlaceExamDatetimeColumn.QualPercentageFromPriv - 1)))?null:(System.Decimal?)reader[((int)AdmPlaceExamDatetimeColumn.QualPercentageFromPriv - 1)];
			entity.QualPercentageToPriv = (reader.IsDBNull(((int)AdmPlaceExamDatetimeColumn.QualPercentageToPriv - 1)))?null:(System.Decimal?)reader[((int)AdmPlaceExamDatetimeColumn.QualPercentageToPriv - 1)];
			entity.RelatedToProgram = (reader.IsDBNull(((int)AdmPlaceExamDatetimeColumn.RelatedToProgram - 1)))?null:(System.Decimal?)reader[((int)AdmPlaceExamDatetimeColumn.RelatedToProgram - 1)];
			entity.EntMainId = (reader.IsDBNull(((int)AdmPlaceExamDatetimeColumn.EntMainId - 1)))?null:(System.Decimal?)reader[((int)AdmPlaceExamDatetimeColumn.EntMainId - 1)];
			entity.QualPercentageToPub = (reader.IsDBNull(((int)AdmPlaceExamDatetimeColumn.QualPercentageToPub - 1)))?null:(System.Decimal?)reader[((int)AdmPlaceExamDatetimeColumn.QualPercentageToPub - 1)];
			entity.QualPercentageFromPub = (reader.IsDBNull(((int)AdmPlaceExamDatetimeColumn.QualPercentageFromPub - 1)))?null:(System.Decimal?)reader[((int)AdmPlaceExamDatetimeColumn.QualPercentageFromPub - 1)];
			entity.ScBuildingId = (reader.IsDBNull(((int)AdmPlaceExamDatetimeColumn.ScBuildingId - 1)))?null:(System.Decimal?)reader[((int)AdmPlaceExamDatetimeColumn.ScBuildingId - 1)];
			entity.ScHallId = (reader.IsDBNull(((int)AdmPlaceExamDatetimeColumn.ScHallId - 1)))?null:(System.Decimal?)reader[((int)AdmPlaceExamDatetimeColumn.ScHallId - 1)];
			entity.ApproveFlg = (reader.IsDBNull(((int)AdmPlaceExamDatetimeColumn.ApproveFlg - 1)))?null:(System.Boolean?)reader[((int)AdmPlaceExamDatetimeColumn.ApproveFlg - 1)];
			entity.GsCodeGenderId = (reader.IsDBNull(((int)AdmPlaceExamDatetimeColumn.GsCodeGenderId - 1)))?null:(System.Decimal?)reader[((int)AdmPlaceExamDatetimeColumn.GsCodeGenderId - 1)];
			entity.AdmCdeAppTypeId = (reader.IsDBNull(((int)AdmPlaceExamDatetimeColumn.AdmCdeAppTypeId - 1)))?null:(System.Decimal?)reader[((int)AdmPlaceExamDatetimeColumn.AdmCdeAppTypeId - 1)];
			entity.AwkafFlg = (reader.IsDBNull(((int)AdmPlaceExamDatetimeColumn.AwkafFlg - 1)))?null:(System.Boolean?)reader[((int)AdmPlaceExamDatetimeColumn.AwkafFlg - 1)];
			entity.SvSrvyHdrId = (reader.IsDBNull(((int)AdmPlaceExamDatetimeColumn.SvSrvyHdrId - 1)))?null:(System.Int32?)reader[((int)AdmPlaceExamDatetimeColumn.SvSrvyHdrId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AdmPlaceExamDatetimeColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AdmPlaceExamDatetimeColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AdmPlaceExamDatetimeColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AdmPlaceExamDatetimeColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmPlaceExamDatetimeId = (System.Decimal)dataRow["ADM_PLACE_EXAM_DATETIME_ID"];
			entity.OriginalAdmPlaceExamDatetimeId = (System.Decimal)dataRow["ADM_PLACE_EXAM_DATETIME_ID"];
			entity.AdmCdePlacementExamId = (System.Decimal)dataRow["ADM_CDE_PLACEMENT_EXAM_ID"];
			entity.ExamDate = (System.DateTime)dataRow["EXAM_DATE"];
			entity.ExamTimeFrom = (System.DateTime)dataRow["EXAM_TIME_FROM"];
			entity.ExamTimeTo = (System.DateTime)dataRow["EXAM_TIME_TO"];
			entity.AdmOpenAcadSemesterId = Convert.IsDBNull(dataRow["ADM_OPEN_ACAD_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ADM_OPEN_ACAD_SEMESTER_ID"];
			entity.Location = Convert.IsDBNull(dataRow["LOCATION"]) ? null : (System.String)dataRow["LOCATION"];
			entity.IsOptionalExam = Convert.IsDBNull(dataRow["IS_OPTIONAL_EXAM"]) ? null : (System.Decimal?)dataRow["IS_OPTIONAL_EXAM"];
			entity.QualPercentageFromPriv = Convert.IsDBNull(dataRow["QUAL_PERCENTAGE_FROM_PRIV"]) ? null : (System.Decimal?)dataRow["QUAL_PERCENTAGE_FROM_PRIV"];
			entity.QualPercentageToPriv = Convert.IsDBNull(dataRow["QUAL_PERCENTAGE_TO_PRIV"]) ? null : (System.Decimal?)dataRow["QUAL_PERCENTAGE_TO_PRIV"];
			entity.RelatedToProgram = Convert.IsDBNull(dataRow["RELATED_To_PROGRAM"]) ? null : (System.Decimal?)dataRow["RELATED_To_PROGRAM"];
			entity.EntMainId = Convert.IsDBNull(dataRow["ENT_MAIN_ID"]) ? null : (System.Decimal?)dataRow["ENT_MAIN_ID"];
			entity.QualPercentageToPub = Convert.IsDBNull(dataRow["QUAL_PERCENTAGE_TO_PUB"]) ? null : (System.Decimal?)dataRow["QUAL_PERCENTAGE_TO_PUB"];
			entity.QualPercentageFromPub = Convert.IsDBNull(dataRow["QUAL_PERCENTAGE_FROM_PUB"]) ? null : (System.Decimal?)dataRow["QUAL_PERCENTAGE_FROM_PUB"];
			entity.ScBuildingId = Convert.IsDBNull(dataRow["SC_BUILDING_ID"]) ? null : (System.Decimal?)dataRow["SC_BUILDING_ID"];
			entity.ScHallId = Convert.IsDBNull(dataRow["SC_HALL_ID"]) ? null : (System.Decimal?)dataRow["SC_HALL_ID"];
			entity.ApproveFlg = Convert.IsDBNull(dataRow["APPROVE_FLG"]) ? null : (System.Boolean?)dataRow["APPROVE_FLG"];
			entity.GsCodeGenderId = Convert.IsDBNull(dataRow["GS_CODE_GENDER_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_GENDER_ID"];
			entity.AdmCdeAppTypeId = Convert.IsDBNull(dataRow["ADM_CDE_APP_TYPE_ID"]) ? null : (System.Decimal?)dataRow["ADM_CDE_APP_TYPE_ID"];
			entity.AwkafFlg = Convert.IsDBNull(dataRow["AWKAF_FLG"]) ? null : (System.Boolean?)dataRow["AWKAF_FLG"];
			entity.SvSrvyHdrId = Convert.IsDBNull(dataRow["SV_SRVY_HDR_ID"]) ? null : (System.Int32?)dataRow["SV_SRVY_HDR_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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

			#region AdmCdePlacementExamIdSource	
			if (CanDeepLoad(entity, "AdmCdePlacementExam|AdmCdePlacementExamIdSource", deepLoadType, innerList) 
				&& entity.AdmCdePlacementExamIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmCdePlacementExamId;
				AdmCdePlacementExam tmpEntity = EntityManager.LocateEntity<AdmCdePlacementExam>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCdePlacementExam), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCdePlacementExamIdSource = tmpEntity;
				else
					entity.AdmCdePlacementExamIdSource = DataRepository.AdmCdePlacementExamProvider.GetByAdmCdePlacementExamId(transactionManager, entity.AdmCdePlacementExamId);		
				
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

			#region AdmOpenAcadSemesterIdSource	
			if (CanDeepLoad(entity, "AdmOpenAcadSemester|AdmOpenAcadSemesterIdSource", deepLoadType, innerList) 
				&& entity.AdmOpenAcadSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmOpenAcadSemesterId ?? 0.0m);
				AdmOpenAcadSemester tmpEntity = EntityManager.LocateEntity<AdmOpenAcadSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmOpenAcadSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmOpenAcadSemesterIdSource = tmpEntity;
				else
					entity.AdmOpenAcadSemesterIdSource = DataRepository.AdmOpenAcadSemesterProvider.GetByAdmOpenAcadSemesterId(transactionManager, (entity.AdmOpenAcadSemesterId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmOpenAcadSemesterIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmOpenAcadSemesterIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmOpenAcadSemesterProvider.DeepLoad(transactionManager, entity.AdmOpenAcadSemesterIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmOpenAcadSemesterIdSource

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

			#region ScBuildingIdSource	
			if (CanDeepLoad(entity, "ScBuilding|ScBuildingIdSource", deepLoadType, innerList) 
				&& entity.ScBuildingIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ScBuildingId ?? 0.0m);
				ScBuilding tmpEntity = EntityManager.LocateEntity<ScBuilding>(EntityLocator.ConstructKeyFromPkItems(typeof(ScBuilding), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScBuildingIdSource = tmpEntity;
				else
					entity.ScBuildingIdSource = DataRepository.ScBuildingProvider.GetByScBuildingId(transactionManager, (entity.ScBuildingId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScBuildingIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScBuildingIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScBuildingProvider.DeepLoad(transactionManager, entity.ScBuildingIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScBuildingIdSource

			#region ScHallIdSource	
			if (CanDeepLoad(entity, "ScHall|ScHallIdSource", deepLoadType, innerList) 
				&& entity.ScHallIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ScHallId ?? 0.0m);
				ScHall tmpEntity = EntityManager.LocateEntity<ScHall>(EntityLocator.ConstructKeyFromPkItems(typeof(ScHall), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScHallIdSource = tmpEntity;
				else
					entity.ScHallIdSource = DataRepository.ScHallProvider.GetByScHallId(transactionManager, (entity.ScHallId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScHallIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScHallIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScHallProvider.DeepLoad(transactionManager, entity.ScHallIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScHallIdSource

			#region SvSrvyHdrIdSource	
			if (CanDeepLoad(entity, "SvSrvyHdr|SvSrvyHdrIdSource", deepLoadType, innerList) 
				&& entity.SvSrvyHdrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SvSrvyHdrId ?? (int)0);
				SvSrvyHdr tmpEntity = EntityManager.LocateEntity<SvSrvyHdr>(EntityLocator.ConstructKeyFromPkItems(typeof(SvSrvyHdr), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvSrvyHdrIdSource = tmpEntity;
				else
					entity.SvSrvyHdrIdSource = DataRepository.SvSrvyHdrProvider.GetBySvSrvyHdrId(transactionManager, (entity.SvSrvyHdrId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvSrvyHdrIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvSrvyHdrIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvSrvyHdrProvider.DeepLoad(transactionManager, entity.SvSrvyHdrIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvSrvyHdrIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAdmPlaceExamDatetimeId methods when available
			
			#region AdmPlaceExamLocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmPlaceExamLoc>|AdmPlaceExamLocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmPlaceExamLocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmPlaceExamLocCollection = DataRepository.AdmPlaceExamLocProvider.GetByAdmPlaceExamDatetimeId(transactionManager, entity.AdmPlaceExamDatetimeId);

				if (deep && entity.AdmPlaceExamLocCollection.Count > 0)
				{
					deepHandles.Add("AdmPlaceExamLocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmPlaceExamLoc>) DataRepository.AdmPlaceExamLocProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmPlaceExamLocCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.AdmAppPlacementExamCollection = DataRepository.AdmAppPlacementExamProvider.GetByAdmPlaceExamDatetimeId(transactionManager, entity.AdmPlaceExamDatetimeId);

				if (deep && entity.AdmAppPlacementExamCollection.Count > 0)
				{
					deepHandles.Add("AdmAppPlacementExamCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppPlacementExam>) DataRepository.AdmAppPlacementExamProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppPlacementExamCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmCdeAppTypeIdSource
			if (CanDeepSave(entity, "AdmCdeAppType|AdmCdeAppTypeIdSource", deepSaveType, innerList) 
				&& entity.AdmCdeAppTypeIdSource != null)
			{
				DataRepository.AdmCdeAppTypeProvider.Save(transactionManager, entity.AdmCdeAppTypeIdSource);
				entity.AdmCdeAppTypeId = entity.AdmCdeAppTypeIdSource.AdmCdeAppTypeId;
			}
			#endregion 
			
			#region AdmCdePlacementExamIdSource
			if (CanDeepSave(entity, "AdmCdePlacementExam|AdmCdePlacementExamIdSource", deepSaveType, innerList) 
				&& entity.AdmCdePlacementExamIdSource != null)
			{
				DataRepository.AdmCdePlacementExamProvider.Save(transactionManager, entity.AdmCdePlacementExamIdSource);
				entity.AdmCdePlacementExamId = entity.AdmCdePlacementExamIdSource.AdmCdePlacementExamId;
			}
			#endregion 
			
			#region AdmOpenAcadSemesterIdSource
			if (CanDeepSave(entity, "AdmOpenAcadSemester|AdmOpenAcadSemesterIdSource", deepSaveType, innerList) 
				&& entity.AdmOpenAcadSemesterIdSource != null)
			{
				DataRepository.AdmOpenAcadSemesterProvider.Save(transactionManager, entity.AdmOpenAcadSemesterIdSource);
				entity.AdmOpenAcadSemesterId = entity.AdmOpenAcadSemesterIdSource.AdmOpenAcadSemesterId;
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
			
			#region GsCodeGenderIdSource
			if (CanDeepSave(entity, "GsCodeGender|GsCodeGenderIdSource", deepSaveType, innerList) 
				&& entity.GsCodeGenderIdSource != null)
			{
				DataRepository.GsCodeGenderProvider.Save(transactionManager, entity.GsCodeGenderIdSource);
				entity.GsCodeGenderId = entity.GsCodeGenderIdSource.GsCodeGenderId;
			}
			#endregion 
			
			#region ScBuildingIdSource
			if (CanDeepSave(entity, "ScBuilding|ScBuildingIdSource", deepSaveType, innerList) 
				&& entity.ScBuildingIdSource != null)
			{
				DataRepository.ScBuildingProvider.Save(transactionManager, entity.ScBuildingIdSource);
				entity.ScBuildingId = entity.ScBuildingIdSource.ScBuildingId;
			}
			#endregion 
			
			#region ScHallIdSource
			if (CanDeepSave(entity, "ScHall|ScHallIdSource", deepSaveType, innerList) 
				&& entity.ScHallIdSource != null)
			{
				DataRepository.ScHallProvider.Save(transactionManager, entity.ScHallIdSource);
				entity.ScHallId = entity.ScHallIdSource.ScHallId;
			}
			#endregion 
			
			#region SvSrvyHdrIdSource
			if (CanDeepSave(entity, "SvSrvyHdr|SvSrvyHdrIdSource", deepSaveType, innerList) 
				&& entity.SvSrvyHdrIdSource != null)
			{
				DataRepository.SvSrvyHdrProvider.Save(transactionManager, entity.SvSrvyHdrIdSource);
				entity.SvSrvyHdrId = entity.SvSrvyHdrIdSource.SvSrvyHdrId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<AdmPlaceExamLoc>
				if (CanDeepSave(entity.AdmPlaceExamLocCollection, "List<AdmPlaceExamLoc>|AdmPlaceExamLocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmPlaceExamLoc child in entity.AdmPlaceExamLocCollection)
					{
						if(child.AdmPlaceExamDatetimeIdSource != null)
						{
							child.AdmPlaceExamDatetimeId = child.AdmPlaceExamDatetimeIdSource.AdmPlaceExamDatetimeId;
						}
						else
						{
							child.AdmPlaceExamDatetimeId = entity.AdmPlaceExamDatetimeId;
						}

					}

					if (entity.AdmPlaceExamLocCollection.Count > 0 || entity.AdmPlaceExamLocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmPlaceExamLocProvider.Save(transactionManager, entity.AdmPlaceExamLocCollection);
						
						deepHandles.Add("AdmPlaceExamLocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmPlaceExamLoc >) DataRepository.AdmPlaceExamLocProvider.DeepSave,
							new object[] { transactionManager, entity.AdmPlaceExamLocCollection, deepSaveType, childTypes, innerList }
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
						if(child.AdmPlaceExamDatetimeIdSource != null)
						{
							child.AdmPlaceExamDatetimeId = child.AdmPlaceExamDatetimeIdSource.AdmPlaceExamDatetimeId;
						}
						else
						{
							child.AdmPlaceExamDatetimeId = entity.AdmPlaceExamDatetimeId;
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
	
	#region AdmPlaceExamDatetimeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmPlaceExamDatetime</c>
	///</summary>
	public enum AdmPlaceExamDatetimeChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmCdeAppType</c> at AdmCdeAppTypeIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdeAppType))]
		AdmCdeAppType,
		
		///<summary>
		/// Composite Property for <c>AdmCdePlacementExam</c> at AdmCdePlacementExamIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdePlacementExam))]
		AdmCdePlacementExam,
		
		///<summary>
		/// Composite Property for <c>AdmOpenAcadSemester</c> at AdmOpenAcadSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(AdmOpenAcadSemester))]
		AdmOpenAcadSemester,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		
		///<summary>
		/// Composite Property for <c>GsCodeGender</c> at GsCodeGenderIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeGender))]
		GsCodeGender,
		
		///<summary>
		/// Composite Property for <c>ScBuilding</c> at ScBuildingIdSource
		///</summary>
		[ChildEntityType(typeof(ScBuilding))]
		ScBuilding,
		
		///<summary>
		/// Composite Property for <c>ScHall</c> at ScHallIdSource
		///</summary>
		[ChildEntityType(typeof(ScHall))]
		ScHall,
		
		///<summary>
		/// Composite Property for <c>SvSrvyHdr</c> at SvSrvyHdrIdSource
		///</summary>
		[ChildEntityType(typeof(SvSrvyHdr))]
		SvSrvyHdr,
		///<summary>
		/// Collection of <c>AdmPlaceExamDatetime</c> as OneToMany for AdmPlaceExamLocCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmPlaceExamLoc>))]
		AdmPlaceExamLocCollection,
		///<summary>
		/// Collection of <c>AdmPlaceExamDatetime</c> as OneToMany for AdmAppPlacementExamCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppPlacementExam>))]
		AdmAppPlacementExamCollection,
	}
	
	#endregion AdmPlaceExamDatetimeChildEntityTypes
	
	#region AdmPlaceExamDatetimeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmPlaceExamDatetimeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmPlaceExamDatetime"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmPlaceExamDatetimeFilterBuilder : SqlFilterBuilder<AdmPlaceExamDatetimeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmPlaceExamDatetimeFilterBuilder class.
		/// </summary>
		public AdmPlaceExamDatetimeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmPlaceExamDatetimeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmPlaceExamDatetimeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmPlaceExamDatetimeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmPlaceExamDatetimeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmPlaceExamDatetimeFilterBuilder
	
	#region AdmPlaceExamDatetimeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmPlaceExamDatetimeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmPlaceExamDatetime"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmPlaceExamDatetimeParameterBuilder : ParameterizedSqlFilterBuilder<AdmPlaceExamDatetimeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmPlaceExamDatetimeParameterBuilder class.
		/// </summary>
		public AdmPlaceExamDatetimeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmPlaceExamDatetimeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmPlaceExamDatetimeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmPlaceExamDatetimeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmPlaceExamDatetimeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmPlaceExamDatetimeParameterBuilder
	
	#region AdmPlaceExamDatetimeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmPlaceExamDatetimeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmPlaceExamDatetime"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmPlaceExamDatetimeSortBuilder : SqlSortBuilder<AdmPlaceExamDatetimeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmPlaceExamDatetimeSqlSortBuilder class.
		/// </summary>
		public AdmPlaceExamDatetimeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmPlaceExamDatetimeSortBuilder
	
} // end namespace
