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
	/// This class is the base class for any <see cref="SaTrainingCourseProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaTrainingCourseProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaTrainingCourse, UMIS_VER2.BusinessLyer.SaTrainingCourseKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaTrainingCourseKey key)
		{
			return Delete(transactionManager, key.SaTrainingCourseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saTrainingCourseId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saTrainingCourseId)
		{
			return Delete(null, _saTrainingCourseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saTrainingCourseId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saTrainingCourseId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0371 key.
		///		FK_AUTO_0371 Description: 
		/// </summary>
		/// <param name="_saCodeTrainingFlgId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public TList<SaTrainingCourse> GetBySaCodeTrainingFlgId(System.Decimal _saCodeTrainingFlgId)
		{
			int count = -1;
			return GetBySaCodeTrainingFlgId(_saCodeTrainingFlgId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0371 key.
		///		FK_AUTO_0371 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeTrainingFlgId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		/// <remarks></remarks>
		public TList<SaTrainingCourse> GetBySaCodeTrainingFlgId(TransactionManager transactionManager, System.Decimal _saCodeTrainingFlgId)
		{
			int count = -1;
			return GetBySaCodeTrainingFlgId(transactionManager, _saCodeTrainingFlgId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0371 key.
		///		FK_AUTO_0371 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeTrainingFlgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public TList<SaTrainingCourse> GetBySaCodeTrainingFlgId(TransactionManager transactionManager, System.Decimal _saCodeTrainingFlgId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeTrainingFlgId(transactionManager, _saCodeTrainingFlgId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0371 key.
		///		fkAuto0371 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeTrainingFlgId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public TList<SaTrainingCourse> GetBySaCodeTrainingFlgId(System.Decimal _saCodeTrainingFlgId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaCodeTrainingFlgId(null, _saCodeTrainingFlgId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0371 key.
		///		fkAuto0371 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeTrainingFlgId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public TList<SaTrainingCourse> GetBySaCodeTrainingFlgId(System.Decimal _saCodeTrainingFlgId, int start, int pageLength,out int count)
		{
			return GetBySaCodeTrainingFlgId(null, _saCodeTrainingFlgId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0371 key.
		///		FK_AUTO_0371 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeTrainingFlgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public abstract TList<SaTrainingCourse> GetBySaCodeTrainingFlgId(TransactionManager transactionManager, System.Decimal _saCodeTrainingFlgId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_03d5 key.
		///		FK_AUTO_03d5 Description: 
		/// </summary>
		/// <param name="_saCodeTrainingOrgId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public TList<SaTrainingCourse> GetBySaCodeTrainingOrgId(System.Decimal? _saCodeTrainingOrgId)
		{
			int count = -1;
			return GetBySaCodeTrainingOrgId(_saCodeTrainingOrgId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_03d5 key.
		///		FK_AUTO_03d5 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeTrainingOrgId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		/// <remarks></remarks>
		public TList<SaTrainingCourse> GetBySaCodeTrainingOrgId(TransactionManager transactionManager, System.Decimal? _saCodeTrainingOrgId)
		{
			int count = -1;
			return GetBySaCodeTrainingOrgId(transactionManager, _saCodeTrainingOrgId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_03d5 key.
		///		FK_AUTO_03d5 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeTrainingOrgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public TList<SaTrainingCourse> GetBySaCodeTrainingOrgId(TransactionManager transactionManager, System.Decimal? _saCodeTrainingOrgId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeTrainingOrgId(transactionManager, _saCodeTrainingOrgId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_03d5 key.
		///		fkAuto03d5 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeTrainingOrgId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public TList<SaTrainingCourse> GetBySaCodeTrainingOrgId(System.Decimal? _saCodeTrainingOrgId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaCodeTrainingOrgId(null, _saCodeTrainingOrgId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_03d5 key.
		///		fkAuto03d5 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeTrainingOrgId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public TList<SaTrainingCourse> GetBySaCodeTrainingOrgId(System.Decimal? _saCodeTrainingOrgId, int start, int pageLength,out int count)
		{
			return GetBySaCodeTrainingOrgId(null, _saCodeTrainingOrgId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_03d5 key.
		///		FK_AUTO_03d5 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeTrainingOrgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public abstract TList<SaTrainingCourse> GetBySaCodeTrainingOrgId(TransactionManager transactionManager, System.Decimal? _saCodeTrainingOrgId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_050a key.
		///		FK_AUTO_050a Description: 
		/// </summary>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public TList<SaTrainingCourse> GetByGsCodeCurrencyId(System.Decimal? _gsCodeCurrencyId)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(_gsCodeCurrencyId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_050a key.
		///		FK_AUTO_050a Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		/// <remarks></remarks>
		public TList<SaTrainingCourse> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal? _gsCodeCurrencyId)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(transactionManager, _gsCodeCurrencyId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_050a key.
		///		FK_AUTO_050a Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public TList<SaTrainingCourse> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal? _gsCodeCurrencyId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(transactionManager, _gsCodeCurrencyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_050a key.
		///		fkAuto050a Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public TList<SaTrainingCourse> GetByGsCodeCurrencyId(System.Decimal? _gsCodeCurrencyId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeCurrencyId(null, _gsCodeCurrencyId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_050a key.
		///		fkAuto050a Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public TList<SaTrainingCourse> GetByGsCodeCurrencyId(System.Decimal? _gsCodeCurrencyId, int start, int pageLength,out int count)
		{
			return GetByGsCodeCurrencyId(null, _gsCodeCurrencyId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_050a key.
		///		FK_AUTO_050a Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public abstract TList<SaTrainingCourse> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal? _gsCodeCurrencyId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_050b key.
		///		FK_AUTO_050b Description: 
		/// </summary>
		/// <param name="_saCodeCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public TList<SaTrainingCourse> GetBySaCodeCourseId(System.Decimal _saCodeCourseId)
		{
			int count = -1;
			return GetBySaCodeCourseId(_saCodeCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_050b key.
		///		FK_AUTO_050b Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		/// <remarks></remarks>
		public TList<SaTrainingCourse> GetBySaCodeCourseId(TransactionManager transactionManager, System.Decimal _saCodeCourseId)
		{
			int count = -1;
			return GetBySaCodeCourseId(transactionManager, _saCodeCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_050b key.
		///		FK_AUTO_050b Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public TList<SaTrainingCourse> GetBySaCodeCourseId(TransactionManager transactionManager, System.Decimal _saCodeCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeCourseId(transactionManager, _saCodeCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_050b key.
		///		fkAuto050b Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public TList<SaTrainingCourse> GetBySaCodeCourseId(System.Decimal _saCodeCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaCodeCourseId(null, _saCodeCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_050b key.
		///		fkAuto050b Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeCourseId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public TList<SaTrainingCourse> GetBySaCodeCourseId(System.Decimal _saCodeCourseId, int start, int pageLength,out int count)
		{
			return GetBySaCodeCourseId(null, _saCodeCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_050b key.
		///		FK_AUTO_050b Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public abstract TList<SaTrainingCourse> GetBySaCodeCourseId(TransactionManager transactionManager, System.Decimal _saCodeCourseId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_TRAINING_COURSE_AS_FACULTY_INFO key.
		///		FK_SA_TRAINING_COURSE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public TList<SaTrainingCourse> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_TRAINING_COURSE_AS_FACULTY_INFO key.
		///		FK_SA_TRAINING_COURSE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		/// <remarks></remarks>
		public TList<SaTrainingCourse> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_TRAINING_COURSE_AS_FACULTY_INFO key.
		///		FK_SA_TRAINING_COURSE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public TList<SaTrainingCourse> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_TRAINING_COURSE_AS_FACULTY_INFO key.
		///		fkSaTrainingCourseAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public TList<SaTrainingCourse> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_TRAINING_COURSE_AS_FACULTY_INFO key.
		///		fkSaTrainingCourseAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public TList<SaTrainingCourse> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_TRAINING_COURSE_AS_FACULTY_INFO key.
		///		FK_SA_TRAINING_COURSE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public abstract TList<SaTrainingCourse> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_TRAINING_COURSE_ENTITY_MAIN key.
		///		FK_SA_TRAINING_COURSE_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_asNodeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public TList<SaTrainingCourse> GetByAsNodeId(System.Decimal? _asNodeId)
		{
			int count = -1;
			return GetByAsNodeId(_asNodeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_TRAINING_COURSE_ENTITY_MAIN key.
		///		FK_SA_TRAINING_COURSE_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asNodeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		/// <remarks></remarks>
		public TList<SaTrainingCourse> GetByAsNodeId(TransactionManager transactionManager, System.Decimal? _asNodeId)
		{
			int count = -1;
			return GetByAsNodeId(transactionManager, _asNodeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_TRAINING_COURSE_ENTITY_MAIN key.
		///		FK_SA_TRAINING_COURSE_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public TList<SaTrainingCourse> GetByAsNodeId(TransactionManager transactionManager, System.Decimal? _asNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsNodeId(transactionManager, _asNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_TRAINING_COURSE_ENTITY_MAIN key.
		///		fkSaTrainingCourseEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asNodeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public TList<SaTrainingCourse> GetByAsNodeId(System.Decimal? _asNodeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsNodeId(null, _asNodeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_TRAINING_COURSE_ENTITY_MAIN key.
		///		fkSaTrainingCourseEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asNodeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public TList<SaTrainingCourse> GetByAsNodeId(System.Decimal? _asNodeId, int start, int pageLength,out int count)
		{
			return GetByAsNodeId(null, _asNodeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_TRAINING_COURSE_ENTITY_MAIN key.
		///		FK_SA_TRAINING_COURSE_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public abstract TList<SaTrainingCourse> GetByAsNodeId(TransactionManager transactionManager, System.Decimal? _asNodeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_TRAINING_COURSE_SA_CODE_COURSE_SCORE key.
		///		FK_SA_TRAINING_COURSE_SA_CODE_COURSE_SCORE Description: 
		/// </summary>
		/// <param name="_saCodeCourseScoreId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public TList<SaTrainingCourse> GetBySaCodeCourseScoreId(System.Decimal _saCodeCourseScoreId)
		{
			int count = -1;
			return GetBySaCodeCourseScoreId(_saCodeCourseScoreId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_TRAINING_COURSE_SA_CODE_COURSE_SCORE key.
		///		FK_SA_TRAINING_COURSE_SA_CODE_COURSE_SCORE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeCourseScoreId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		/// <remarks></remarks>
		public TList<SaTrainingCourse> GetBySaCodeCourseScoreId(TransactionManager transactionManager, System.Decimal _saCodeCourseScoreId)
		{
			int count = -1;
			return GetBySaCodeCourseScoreId(transactionManager, _saCodeCourseScoreId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_TRAINING_COURSE_SA_CODE_COURSE_SCORE key.
		///		FK_SA_TRAINING_COURSE_SA_CODE_COURSE_SCORE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeCourseScoreId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public TList<SaTrainingCourse> GetBySaCodeCourseScoreId(TransactionManager transactionManager, System.Decimal _saCodeCourseScoreId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeCourseScoreId(transactionManager, _saCodeCourseScoreId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_TRAINING_COURSE_SA_CODE_COURSE_SCORE key.
		///		fkSaTrainingCourseSaCodeCourseScore Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeCourseScoreId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public TList<SaTrainingCourse> GetBySaCodeCourseScoreId(System.Decimal _saCodeCourseScoreId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaCodeCourseScoreId(null, _saCodeCourseScoreId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_TRAINING_COURSE_SA_CODE_COURSE_SCORE key.
		///		fkSaTrainingCourseSaCodeCourseScore Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeCourseScoreId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public TList<SaTrainingCourse> GetBySaCodeCourseScoreId(System.Decimal _saCodeCourseScoreId, int start, int pageLength,out int count)
		{
			return GetBySaCodeCourseScoreId(null, _saCodeCourseScoreId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_TRAINING_COURSE_SA_CODE_COURSE_SCORE key.
		///		FK_SA_TRAINING_COURSE_SA_CODE_COURSE_SCORE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeCourseScoreId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public abstract TList<SaTrainingCourse> GetBySaCodeCourseScoreId(TransactionManager transactionManager, System.Decimal _saCodeCourseScoreId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_TRAINING_COURSE_SA_STF_MEMBER key.
		///		FK_SA_TRAINING_COURSE_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public TList<SaTrainingCourse> GetBySaStfMemberId(System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_TRAINING_COURSE_SA_STF_MEMBER key.
		///		FK_SA_TRAINING_COURSE_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		/// <remarks></remarks>
		public TList<SaTrainingCourse> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_TRAINING_COURSE_SA_STF_MEMBER key.
		///		FK_SA_TRAINING_COURSE_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public TList<SaTrainingCourse> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_TRAINING_COURSE_SA_STF_MEMBER key.
		///		fkSaTrainingCourseSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public TList<SaTrainingCourse> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_TRAINING_COURSE_SA_STF_MEMBER key.
		///		fkSaTrainingCourseSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public TList<SaTrainingCourse> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_TRAINING_COURSE_SA_STF_MEMBER key.
		///		FK_SA_TRAINING_COURSE_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTrainingCourse objects.</returns>
		public abstract TList<SaTrainingCourse> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SaTrainingCourse Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaTrainingCourseKey key, int start, int pageLength)
		{
			return GetBySaTrainingCourseId(transactionManager, key.SaTrainingCourseId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_TRAINING_COURSE index.
		/// </summary>
		/// <param name="_saTrainingCourseId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaTrainingCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaTrainingCourse GetBySaTrainingCourseId(System.Decimal _saTrainingCourseId)
		{
			int count = -1;
			return GetBySaTrainingCourseId(null,_saTrainingCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_TRAINING_COURSE index.
		/// </summary>
		/// <param name="_saTrainingCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaTrainingCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaTrainingCourse GetBySaTrainingCourseId(System.Decimal _saTrainingCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaTrainingCourseId(null, _saTrainingCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_TRAINING_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saTrainingCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaTrainingCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaTrainingCourse GetBySaTrainingCourseId(TransactionManager transactionManager, System.Decimal _saTrainingCourseId)
		{
			int count = -1;
			return GetBySaTrainingCourseId(transactionManager, _saTrainingCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_TRAINING_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saTrainingCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaTrainingCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaTrainingCourse GetBySaTrainingCourseId(TransactionManager transactionManager, System.Decimal _saTrainingCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaTrainingCourseId(transactionManager, _saTrainingCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_TRAINING_COURSE index.
		/// </summary>
		/// <param name="_saTrainingCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaTrainingCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaTrainingCourse GetBySaTrainingCourseId(System.Decimal _saTrainingCourseId, int start, int pageLength, out int count)
		{
			return GetBySaTrainingCourseId(null, _saTrainingCourseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_TRAINING_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saTrainingCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaTrainingCourse"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaTrainingCourse GetBySaTrainingCourseId(TransactionManager transactionManager, System.Decimal _saTrainingCourseId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaTrainingCourse&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaTrainingCourse&gt;"/></returns>
		public static TList<SaTrainingCourse> Fill(IDataReader reader, TList<SaTrainingCourse> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaTrainingCourse c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaTrainingCourse")
					.Append("|").Append((System.Decimal)reader["SA_TRAINING_COURSE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaTrainingCourse>(
					key.ToString(), // EntityTrackingKey
					"SaTrainingCourse",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaTrainingCourse();
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
					c.SaTrainingCourseId = (System.Decimal)reader["SA_TRAINING_COURSE_ID"];
					c.OriginalSaTrainingCourseId = c.SaTrainingCourseId;
					c.StartDate = (System.DateTime)reader["START_DATE"];
					c.EndDate = (System.DateTime)reader["END_DATE"];
					c.IsOrgUni = (System.Decimal)reader["IS_ORG_UNI"];
					c.CourseCost = Convert.IsDBNull(reader["COURSE_COST"]) ? null : (System.Decimal?)reader["COURSE_COST"];
					c.CourseHrs = Convert.IsDBNull(reader["COURSE_HRS"]) ? null : (System.Decimal?)reader["COURSE_HRS"];
					c.UniParticipationAmt = Convert.IsDBNull(reader["UNI_PARTICIPATION_AMT"]) ? null : (System.Decimal?)reader["UNI_PARTICIPATION_AMT"];
					c.SaCodeTrainingFlgId = (System.Decimal)reader["SA_CODE_TRAINING_FLG_ID"];
					c.TrainerName = Convert.IsDBNull(reader["TRAINER_NAME"]) ? null : (System.String)reader["TRAINER_NAME"];
					c.GsCodeCurrencyId = Convert.IsDBNull(reader["GS_CODE_CURRENCY_ID"]) ? null : (System.Decimal?)reader["GS_CODE_CURRENCY_ID"];
					c.SaStfMemberId = (System.Decimal)reader["SA_STF_MEMBER_ID"];
					c.SaCodeCourseId = (System.Decimal)reader["SA_CODE_COURSE_ID"];
					c.SaCodeCourseScoreId = (System.Decimal)reader["SA_CODE_COURSE_SCORE_ID"];
					c.GsCountryNodeId = (System.Decimal)reader["GS_COUNTRY_NODE_ID"];
					c.AsNodeId = Convert.IsDBNull(reader["AS_NODE_ID"]) ? null : (System.Decimal?)reader["AS_NODE_ID"];
					c.SaCodeTrainingOrgId = Convert.IsDBNull(reader["SA_CODE_TRAINING_ORG_ID"]) ? null : (System.Decimal?)reader["SA_CODE_TRAINING_ORG_ID"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.TrainingPlace = Convert.IsDBNull(reader["TRAINING_PLACE"]) ? null : (System.String)reader["TRAINING_PLACE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaTrainingCourse"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaTrainingCourse"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaTrainingCourse entity)
		{
			if (!reader.Read()) return;
			
			entity.SaTrainingCourseId = (System.Decimal)reader[((int)SaTrainingCourseColumn.SaTrainingCourseId - 1)];
			entity.OriginalSaTrainingCourseId = (System.Decimal)reader["SA_TRAINING_COURSE_ID"];
			entity.StartDate = (System.DateTime)reader[((int)SaTrainingCourseColumn.StartDate - 1)];
			entity.EndDate = (System.DateTime)reader[((int)SaTrainingCourseColumn.EndDate - 1)];
			entity.IsOrgUni = (System.Decimal)reader[((int)SaTrainingCourseColumn.IsOrgUni - 1)];
			entity.CourseCost = (reader.IsDBNull(((int)SaTrainingCourseColumn.CourseCost - 1)))?null:(System.Decimal?)reader[((int)SaTrainingCourseColumn.CourseCost - 1)];
			entity.CourseHrs = (reader.IsDBNull(((int)SaTrainingCourseColumn.CourseHrs - 1)))?null:(System.Decimal?)reader[((int)SaTrainingCourseColumn.CourseHrs - 1)];
			entity.UniParticipationAmt = (reader.IsDBNull(((int)SaTrainingCourseColumn.UniParticipationAmt - 1)))?null:(System.Decimal?)reader[((int)SaTrainingCourseColumn.UniParticipationAmt - 1)];
			entity.SaCodeTrainingFlgId = (System.Decimal)reader[((int)SaTrainingCourseColumn.SaCodeTrainingFlgId - 1)];
			entity.TrainerName = (reader.IsDBNull(((int)SaTrainingCourseColumn.TrainerName - 1)))?null:(System.String)reader[((int)SaTrainingCourseColumn.TrainerName - 1)];
			entity.GsCodeCurrencyId = (reader.IsDBNull(((int)SaTrainingCourseColumn.GsCodeCurrencyId - 1)))?null:(System.Decimal?)reader[((int)SaTrainingCourseColumn.GsCodeCurrencyId - 1)];
			entity.SaStfMemberId = (System.Decimal)reader[((int)SaTrainingCourseColumn.SaStfMemberId - 1)];
			entity.SaCodeCourseId = (System.Decimal)reader[((int)SaTrainingCourseColumn.SaCodeCourseId - 1)];
			entity.SaCodeCourseScoreId = (System.Decimal)reader[((int)SaTrainingCourseColumn.SaCodeCourseScoreId - 1)];
			entity.GsCountryNodeId = (System.Decimal)reader[((int)SaTrainingCourseColumn.GsCountryNodeId - 1)];
			entity.AsNodeId = (reader.IsDBNull(((int)SaTrainingCourseColumn.AsNodeId - 1)))?null:(System.Decimal?)reader[((int)SaTrainingCourseColumn.AsNodeId - 1)];
			entity.SaCodeTrainingOrgId = (reader.IsDBNull(((int)SaTrainingCourseColumn.SaCodeTrainingOrgId - 1)))?null:(System.Decimal?)reader[((int)SaTrainingCourseColumn.SaCodeTrainingOrgId - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)SaTrainingCourseColumn.AsFacultyInfoId - 1)];
			entity.TrainingPlace = (reader.IsDBNull(((int)SaTrainingCourseColumn.TrainingPlace - 1)))?null:(System.String)reader[((int)SaTrainingCourseColumn.TrainingPlace - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaTrainingCourse"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaTrainingCourse"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaTrainingCourse entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaTrainingCourseId = (System.Decimal)dataRow["SA_TRAINING_COURSE_ID"];
			entity.OriginalSaTrainingCourseId = (System.Decimal)dataRow["SA_TRAINING_COURSE_ID"];
			entity.StartDate = (System.DateTime)dataRow["START_DATE"];
			entity.EndDate = (System.DateTime)dataRow["END_DATE"];
			entity.IsOrgUni = (System.Decimal)dataRow["IS_ORG_UNI"];
			entity.CourseCost = Convert.IsDBNull(dataRow["COURSE_COST"]) ? null : (System.Decimal?)dataRow["COURSE_COST"];
			entity.CourseHrs = Convert.IsDBNull(dataRow["COURSE_HRS"]) ? null : (System.Decimal?)dataRow["COURSE_HRS"];
			entity.UniParticipationAmt = Convert.IsDBNull(dataRow["UNI_PARTICIPATION_AMT"]) ? null : (System.Decimal?)dataRow["UNI_PARTICIPATION_AMT"];
			entity.SaCodeTrainingFlgId = (System.Decimal)dataRow["SA_CODE_TRAINING_FLG_ID"];
			entity.TrainerName = Convert.IsDBNull(dataRow["TRAINER_NAME"]) ? null : (System.String)dataRow["TRAINER_NAME"];
			entity.GsCodeCurrencyId = Convert.IsDBNull(dataRow["GS_CODE_CURRENCY_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_CURRENCY_ID"];
			entity.SaStfMemberId = (System.Decimal)dataRow["SA_STF_MEMBER_ID"];
			entity.SaCodeCourseId = (System.Decimal)dataRow["SA_CODE_COURSE_ID"];
			entity.SaCodeCourseScoreId = (System.Decimal)dataRow["SA_CODE_COURSE_SCORE_ID"];
			entity.GsCountryNodeId = (System.Decimal)dataRow["GS_COUNTRY_NODE_ID"];
			entity.AsNodeId = Convert.IsDBNull(dataRow["AS_NODE_ID"]) ? null : (System.Decimal?)dataRow["AS_NODE_ID"];
			entity.SaCodeTrainingOrgId = Convert.IsDBNull(dataRow["SA_CODE_TRAINING_ORG_ID"]) ? null : (System.Decimal?)dataRow["SA_CODE_TRAINING_ORG_ID"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
			entity.TrainingPlace = Convert.IsDBNull(dataRow["TRAINING_PLACE"]) ? null : (System.String)dataRow["TRAINING_PLACE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaTrainingCourse"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaTrainingCourse Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaTrainingCourse entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SaCodeTrainingFlgIdSource	
			if (CanDeepLoad(entity, "SaCodeTrainingFlg|SaCodeTrainingFlgIdSource", deepLoadType, innerList) 
				&& entity.SaCodeTrainingFlgIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaCodeTrainingFlgId;
				SaCodeTrainingFlg tmpEntity = EntityManager.LocateEntity<SaCodeTrainingFlg>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeTrainingFlg), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeTrainingFlgIdSource = tmpEntity;
				else
					entity.SaCodeTrainingFlgIdSource = DataRepository.SaCodeTrainingFlgProvider.GetBySaCodeTrainingFlgId(transactionManager, entity.SaCodeTrainingFlgId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeTrainingFlgIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodeTrainingFlgIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeTrainingFlgProvider.DeepLoad(transactionManager, entity.SaCodeTrainingFlgIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodeTrainingFlgIdSource

			#region SaCodeTrainingOrgIdSource	
			if (CanDeepLoad(entity, "SaCodeTrainingOrg|SaCodeTrainingOrgIdSource", deepLoadType, innerList) 
				&& entity.SaCodeTrainingOrgIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaCodeTrainingOrgId ?? 0.0m);
				SaCodeTrainingOrg tmpEntity = EntityManager.LocateEntity<SaCodeTrainingOrg>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeTrainingOrg), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeTrainingOrgIdSource = tmpEntity;
				else
					entity.SaCodeTrainingOrgIdSource = DataRepository.SaCodeTrainingOrgProvider.GetBySaCodeTrainingOrgId(transactionManager, (entity.SaCodeTrainingOrgId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeTrainingOrgIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodeTrainingOrgIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeTrainingOrgProvider.DeepLoad(transactionManager, entity.SaCodeTrainingOrgIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodeTrainingOrgIdSource

			#region GsCodeCurrencyIdSource	
			if (CanDeepLoad(entity, "GsCodeCurrency|GsCodeCurrencyIdSource", deepLoadType, innerList) 
				&& entity.GsCodeCurrencyIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeCurrencyId ?? 0.0m);
				GsCodeCurrency tmpEntity = EntityManager.LocateEntity<GsCodeCurrency>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeCurrency), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeCurrencyIdSource = tmpEntity;
				else
					entity.GsCodeCurrencyIdSource = DataRepository.GsCodeCurrencyProvider.GetByGsCodeCurrencyId(transactionManager, (entity.GsCodeCurrencyId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeCurrencyIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeCurrencyIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeCurrencyProvider.DeepLoad(transactionManager, entity.GsCodeCurrencyIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeCurrencyIdSource

			#region SaCodeCourseIdSource	
			if (CanDeepLoad(entity, "SaCodeCourse|SaCodeCourseIdSource", deepLoadType, innerList) 
				&& entity.SaCodeCourseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaCodeCourseId;
				SaCodeCourse tmpEntity = EntityManager.LocateEntity<SaCodeCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeCourseIdSource = tmpEntity;
				else
					entity.SaCodeCourseIdSource = DataRepository.SaCodeCourseProvider.GetBySaCodeCourseId(transactionManager, entity.SaCodeCourseId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeCourseIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodeCourseIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeCourseProvider.DeepLoad(transactionManager, entity.SaCodeCourseIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodeCourseIdSource

			#region AsFacultyInfoIdSource	
			if (CanDeepLoad(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepLoadType, innerList) 
				&& entity.AsFacultyInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AsFacultyInfoId;
				AsFacultyInfo tmpEntity = EntityManager.LocateEntity<AsFacultyInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AsFacultyInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsFacultyInfoIdSource = tmpEntity;
				else
					entity.AsFacultyInfoIdSource = DataRepository.AsFacultyInfoProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);		
				
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

			#region AsNodeIdSource	
			if (CanDeepLoad(entity, "EntityMain|AsNodeIdSource", deepLoadType, innerList) 
				&& entity.AsNodeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsNodeId ?? 0.0m);
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsNodeIdSource = tmpEntity;
				else
					entity.AsNodeIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, (entity.AsNodeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsNodeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsNodeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntityMainProvider.DeepLoad(transactionManager, entity.AsNodeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsNodeIdSource

			#region SaCodeCourseScoreIdSource	
			if (CanDeepLoad(entity, "SaCodeCourseScore|SaCodeCourseScoreIdSource", deepLoadType, innerList) 
				&& entity.SaCodeCourseScoreIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaCodeCourseScoreId;
				SaCodeCourseScore tmpEntity = EntityManager.LocateEntity<SaCodeCourseScore>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeCourseScore), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeCourseScoreIdSource = tmpEntity;
				else
					entity.SaCodeCourseScoreIdSource = DataRepository.SaCodeCourseScoreProvider.GetBySaCodeCourseScoreId(transactionManager, entity.SaCodeCourseScoreId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeCourseScoreIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodeCourseScoreIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeCourseScoreProvider.DeepLoad(transactionManager, entity.SaCodeCourseScoreIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodeCourseScoreIdSource

			#region SaStfMemberIdSource	
			if (CanDeepLoad(entity, "SaStfMember|SaStfMemberIdSource", deepLoadType, innerList) 
				&& entity.SaStfMemberIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaStfMemberId;
				SaStfMember tmpEntity = EntityManager.LocateEntity<SaStfMember>(EntityLocator.ConstructKeyFromPkItems(typeof(SaStfMember), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaStfMemberIdSource = tmpEntity;
				else
					entity.SaStfMemberIdSource = DataRepository.SaStfMemberProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaStfMemberIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaStfMemberIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaStfMemberProvider.DeepLoad(transactionManager, entity.SaStfMemberIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaStfMemberIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaTrainingCourse object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaTrainingCourse instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaTrainingCourse Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaTrainingCourse entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SaCodeTrainingFlgIdSource
			if (CanDeepSave(entity, "SaCodeTrainingFlg|SaCodeTrainingFlgIdSource", deepSaveType, innerList) 
				&& entity.SaCodeTrainingFlgIdSource != null)
			{
				DataRepository.SaCodeTrainingFlgProvider.Save(transactionManager, entity.SaCodeTrainingFlgIdSource);
				entity.SaCodeTrainingFlgId = entity.SaCodeTrainingFlgIdSource.SaCodeTrainingFlgId;
			}
			#endregion 
			
			#region SaCodeTrainingOrgIdSource
			if (CanDeepSave(entity, "SaCodeTrainingOrg|SaCodeTrainingOrgIdSource", deepSaveType, innerList) 
				&& entity.SaCodeTrainingOrgIdSource != null)
			{
				DataRepository.SaCodeTrainingOrgProvider.Save(transactionManager, entity.SaCodeTrainingOrgIdSource);
				entity.SaCodeTrainingOrgId = entity.SaCodeTrainingOrgIdSource.SaCodeTrainingOrgId;
			}
			#endregion 
			
			#region GsCodeCurrencyIdSource
			if (CanDeepSave(entity, "GsCodeCurrency|GsCodeCurrencyIdSource", deepSaveType, innerList) 
				&& entity.GsCodeCurrencyIdSource != null)
			{
				DataRepository.GsCodeCurrencyProvider.Save(transactionManager, entity.GsCodeCurrencyIdSource);
				entity.GsCodeCurrencyId = entity.GsCodeCurrencyIdSource.GsCodeCurrencyId;
			}
			#endregion 
			
			#region SaCodeCourseIdSource
			if (CanDeepSave(entity, "SaCodeCourse|SaCodeCourseIdSource", deepSaveType, innerList) 
				&& entity.SaCodeCourseIdSource != null)
			{
				DataRepository.SaCodeCourseProvider.Save(transactionManager, entity.SaCodeCourseIdSource);
				entity.SaCodeCourseId = entity.SaCodeCourseIdSource.SaCodeCourseId;
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
			
			#region AsNodeIdSource
			if (CanDeepSave(entity, "EntityMain|AsNodeIdSource", deepSaveType, innerList) 
				&& entity.AsNodeIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.AsNodeIdSource);
				entity.AsNodeId = entity.AsNodeIdSource.EntMainId;
			}
			#endregion 
			
			#region SaCodeCourseScoreIdSource
			if (CanDeepSave(entity, "SaCodeCourseScore|SaCodeCourseScoreIdSource", deepSaveType, innerList) 
				&& entity.SaCodeCourseScoreIdSource != null)
			{
				DataRepository.SaCodeCourseScoreProvider.Save(transactionManager, entity.SaCodeCourseScoreIdSource);
				entity.SaCodeCourseScoreId = entity.SaCodeCourseScoreIdSource.SaCodeCourseScoreId;
			}
			#endregion 
			
			#region SaStfMemberIdSource
			if (CanDeepSave(entity, "SaStfMember|SaStfMemberIdSource", deepSaveType, innerList) 
				&& entity.SaStfMemberIdSource != null)
			{
				DataRepository.SaStfMemberProvider.Save(transactionManager, entity.SaStfMemberIdSource);
				entity.SaStfMemberId = entity.SaStfMemberIdSource.SaStfMemberId;
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
	
	#region SaTrainingCourseChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaTrainingCourse</c>
	///</summary>
	public enum SaTrainingCourseChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SaCodeTrainingFlg</c> at SaCodeTrainingFlgIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeTrainingFlg))]
		SaCodeTrainingFlg,
		
		///<summary>
		/// Composite Property for <c>SaCodeTrainingOrg</c> at SaCodeTrainingOrgIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeTrainingOrg))]
		SaCodeTrainingOrg,
		
		///<summary>
		/// Composite Property for <c>GsCodeCurrency</c> at GsCodeCurrencyIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeCurrency))]
		GsCodeCurrency,
		
		///<summary>
		/// Composite Property for <c>SaCodeCourse</c> at SaCodeCourseIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeCourse))]
		SaCodeCourse,
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at AsNodeIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		
		///<summary>
		/// Composite Property for <c>SaCodeCourseScore</c> at SaCodeCourseScoreIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeCourseScore))]
		SaCodeCourseScore,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
	}
	
	#endregion SaTrainingCourseChildEntityTypes
	
	#region SaTrainingCourseFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaTrainingCourseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaTrainingCourse"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaTrainingCourseFilterBuilder : SqlFilterBuilder<SaTrainingCourseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaTrainingCourseFilterBuilder class.
		/// </summary>
		public SaTrainingCourseFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaTrainingCourseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaTrainingCourseFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaTrainingCourseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaTrainingCourseFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaTrainingCourseFilterBuilder
	
	#region SaTrainingCourseParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaTrainingCourseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaTrainingCourse"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaTrainingCourseParameterBuilder : ParameterizedSqlFilterBuilder<SaTrainingCourseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaTrainingCourseParameterBuilder class.
		/// </summary>
		public SaTrainingCourseParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaTrainingCourseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaTrainingCourseParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaTrainingCourseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaTrainingCourseParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaTrainingCourseParameterBuilder
	
	#region SaTrainingCourseSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaTrainingCourseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaTrainingCourse"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaTrainingCourseSortBuilder : SqlSortBuilder<SaTrainingCourseColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaTrainingCourseSqlSortBuilder class.
		/// </summary>
		public SaTrainingCourseSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaTrainingCourseSortBuilder
	
} // end namespace
