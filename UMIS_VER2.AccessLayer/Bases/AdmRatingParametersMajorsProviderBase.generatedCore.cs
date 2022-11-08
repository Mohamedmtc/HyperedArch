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
	/// This class is the base class for any <see cref="AdmRatingParametersMajorsProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmRatingParametersMajorsProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmRatingParametersMajors, UMIS_VER2.BusinessLyer.AdmRatingParametersMajorsKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmRatingParametersMajorsKey key)
		{
			return Delete(transactionManager, key.AdmRatingParametersMajorsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admRatingParametersMajorsId">خطة الأعداد المقترحة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admRatingParametersMajorsId)
		{
			return Delete(null, _admRatingParametersMajorsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admRatingParametersMajorsId">خطة الأعداد المقترحة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admRatingParametersMajorsId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_ADM_ADMISSION_BAND key.
		///		FK_ADM_RATING_PARAMETERS_MAJORS_ADM_ADMISSION_BAND Description: 
		/// </summary>
		/// <param name="_admAdmissionBandId">XXXX default=0/1</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		public TList<AdmRatingParametersMajors> GetByAdmAdmissionBandId(System.Decimal? _admAdmissionBandId)
		{
			int count = -1;
			return GetByAdmAdmissionBandId(_admAdmissionBandId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_ADM_ADMISSION_BAND key.
		///		FK_ADM_RATING_PARAMETERS_MAJORS_ADM_ADMISSION_BAND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAdmissionBandId">XXXX default=0/1</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		/// <remarks></remarks>
		public TList<AdmRatingParametersMajors> GetByAdmAdmissionBandId(TransactionManager transactionManager, System.Decimal? _admAdmissionBandId)
		{
			int count = -1;
			return GetByAdmAdmissionBandId(transactionManager, _admAdmissionBandId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_ADM_ADMISSION_BAND key.
		///		FK_ADM_RATING_PARAMETERS_MAJORS_ADM_ADMISSION_BAND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAdmissionBandId">XXXX default=0/1</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		public TList<AdmRatingParametersMajors> GetByAdmAdmissionBandId(TransactionManager transactionManager, System.Decimal? _admAdmissionBandId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAdmissionBandId(transactionManager, _admAdmissionBandId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_ADM_ADMISSION_BAND key.
		///		fkAdmRatingParametersMajorsAdmAdmissionBand Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAdmissionBandId">XXXX default=0/1</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		public TList<AdmRatingParametersMajors> GetByAdmAdmissionBandId(System.Decimal? _admAdmissionBandId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmAdmissionBandId(null, _admAdmissionBandId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_ADM_ADMISSION_BAND key.
		///		fkAdmRatingParametersMajorsAdmAdmissionBand Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAdmissionBandId">XXXX default=0/1</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		public TList<AdmRatingParametersMajors> GetByAdmAdmissionBandId(System.Decimal? _admAdmissionBandId, int start, int pageLength,out int count)
		{
			return GetByAdmAdmissionBandId(null, _admAdmissionBandId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_ADM_ADMISSION_BAND key.
		///		FK_ADM_RATING_PARAMETERS_MAJORS_ADM_ADMISSION_BAND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAdmissionBandId">XXXX default=0/1</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		public abstract TList<AdmRatingParametersMajors> GetByAdmAdmissionBandId(TransactionManager transactionManager, System.Decimal? _admAdmissionBandId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_ADM_CDE_APP_TYPE key.
		///		FK_ADM_RATING_PARAMETERS_MAJORS_ADM_CDE_APP_TYPE Description: 
		/// </summary>
		/// <param name="_admCdeAppTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		public TList<AdmRatingParametersMajors> GetByAdmCdeAppTypeId(System.Decimal? _admCdeAppTypeId)
		{
			int count = -1;
			return GetByAdmCdeAppTypeId(_admCdeAppTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_ADM_CDE_APP_TYPE key.
		///		FK_ADM_RATING_PARAMETERS_MAJORS_ADM_CDE_APP_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		/// <remarks></remarks>
		public TList<AdmRatingParametersMajors> GetByAdmCdeAppTypeId(TransactionManager transactionManager, System.Decimal? _admCdeAppTypeId)
		{
			int count = -1;
			return GetByAdmCdeAppTypeId(transactionManager, _admCdeAppTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_ADM_CDE_APP_TYPE key.
		///		FK_ADM_RATING_PARAMETERS_MAJORS_ADM_CDE_APP_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		public TList<AdmRatingParametersMajors> GetByAdmCdeAppTypeId(TransactionManager transactionManager, System.Decimal? _admCdeAppTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeAppTypeId(transactionManager, _admCdeAppTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_ADM_CDE_APP_TYPE key.
		///		fkAdmRatingParametersMajorsAdmCdeAppType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		public TList<AdmRatingParametersMajors> GetByAdmCdeAppTypeId(System.Decimal? _admCdeAppTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCdeAppTypeId(null, _admCdeAppTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_ADM_CDE_APP_TYPE key.
		///		fkAdmRatingParametersMajorsAdmCdeAppType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		public TList<AdmRatingParametersMajors> GetByAdmCdeAppTypeId(System.Decimal? _admCdeAppTypeId, int start, int pageLength,out int count)
		{
			return GetByAdmCdeAppTypeId(null, _admCdeAppTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_ADM_CDE_APP_TYPE key.
		///		FK_ADM_RATING_PARAMETERS_MAJORS_ADM_CDE_APP_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		public abstract TList<AdmRatingParametersMajors> GetByAdmCdeAppTypeId(TransactionManager transactionManager, System.Decimal? _admCdeAppTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_ADM_OPEN_ACAD_SEMESTER key.
		///		FK_ADM_RATING_PARAMETERS_MAJORS_ADM_OPEN_ACAD_SEMESTER Description: 
		/// </summary>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		public TList<AdmRatingParametersMajors> GetByAdmOpenAcadSemesterId(System.Decimal _admOpenAcadSemesterId)
		{
			int count = -1;
			return GetByAdmOpenAcadSemesterId(_admOpenAcadSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_ADM_OPEN_ACAD_SEMESTER key.
		///		FK_ADM_RATING_PARAMETERS_MAJORS_ADM_OPEN_ACAD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		/// <remarks></remarks>
		public TList<AdmRatingParametersMajors> GetByAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal _admOpenAcadSemesterId)
		{
			int count = -1;
			return GetByAdmOpenAcadSemesterId(transactionManager, _admOpenAcadSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_ADM_OPEN_ACAD_SEMESTER key.
		///		FK_ADM_RATING_PARAMETERS_MAJORS_ADM_OPEN_ACAD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		public TList<AdmRatingParametersMajors> GetByAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal _admOpenAcadSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmOpenAcadSemesterId(transactionManager, _admOpenAcadSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_ADM_OPEN_ACAD_SEMESTER key.
		///		fkAdmRatingParametersMajorsAdmOpenAcadSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		public TList<AdmRatingParametersMajors> GetByAdmOpenAcadSemesterId(System.Decimal _admOpenAcadSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmOpenAcadSemesterId(null, _admOpenAcadSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_ADM_OPEN_ACAD_SEMESTER key.
		///		fkAdmRatingParametersMajorsAdmOpenAcadSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		public TList<AdmRatingParametersMajors> GetByAdmOpenAcadSemesterId(System.Decimal _admOpenAcadSemesterId, int start, int pageLength,out int count)
		{
			return GetByAdmOpenAcadSemesterId(null, _admOpenAcadSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_ADM_OPEN_ACAD_SEMESTER key.
		///		FK_ADM_RATING_PARAMETERS_MAJORS_ADM_OPEN_ACAD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		public abstract TList<AdmRatingParametersMajors> GetByAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal _admOpenAcadSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_AS_CODE_DEGREE key.
		///		FK_ADM_RATING_PARAMETERS_MAJORS_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="_asCodeDegreeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		public TList<AdmRatingParametersMajors> GetByAsCodeDegreeId(System.Decimal _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(_asCodeDegreeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_AS_CODE_DEGREE key.
		///		FK_ADM_RATING_PARAMETERS_MAJORS_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		/// <remarks></remarks>
		public TList<AdmRatingParametersMajors> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_AS_CODE_DEGREE key.
		///		FK_ADM_RATING_PARAMETERS_MAJORS_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		public TList<AdmRatingParametersMajors> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal _asCodeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_AS_CODE_DEGREE key.
		///		fkAdmRatingParametersMajorsAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		public TList<AdmRatingParametersMajors> GetByAsCodeDegreeId(System.Decimal _asCodeDegreeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_AS_CODE_DEGREE key.
		///		fkAdmRatingParametersMajorsAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		public TList<AdmRatingParametersMajors> GetByAsCodeDegreeId(System.Decimal _asCodeDegreeId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_AS_CODE_DEGREE key.
		///		FK_ADM_RATING_PARAMETERS_MAJORS_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		public abstract TList<AdmRatingParametersMajors> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal _asCodeDegreeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_RATING_PARAMETERS_MAJORS_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		public TList<AdmRatingParametersMajors> GetByAsCodeDegreeClassId(System.Decimal _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(_asCodeDegreeClassId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_RATING_PARAMETERS_MAJORS_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		/// <remarks></remarks>
		public TList<AdmRatingParametersMajors> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_RATING_PARAMETERS_MAJORS_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		public TList<AdmRatingParametersMajors> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_AS_CODE_DEGREE_CLASS key.
		///		fkAdmRatingParametersMajorsAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		public TList<AdmRatingParametersMajors> GetByAsCodeDegreeClassId(System.Decimal _asCodeDegreeClassId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_AS_CODE_DEGREE_CLASS key.
		///		fkAdmRatingParametersMajorsAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		public TList<AdmRatingParametersMajors> GetByAsCodeDegreeClassId(System.Decimal _asCodeDegreeClassId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_RATING_PARAMETERS_MAJORS_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		public abstract TList<AdmRatingParametersMajors> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _asCodeDegreeClassId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_AS_FACULTY_INFO key.
		///		FK_ADM_RATING_PARAMETERS_MAJORS_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		public TList<AdmRatingParametersMajors> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_AS_FACULTY_INFO key.
		///		FK_ADM_RATING_PARAMETERS_MAJORS_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		/// <remarks></remarks>
		public TList<AdmRatingParametersMajors> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_AS_FACULTY_INFO key.
		///		FK_ADM_RATING_PARAMETERS_MAJORS_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		public TList<AdmRatingParametersMajors> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_AS_FACULTY_INFO key.
		///		fkAdmRatingParametersMajorsAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		public TList<AdmRatingParametersMajors> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_AS_FACULTY_INFO key.
		///		fkAdmRatingParametersMajorsAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		public TList<AdmRatingParametersMajors> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_AS_FACULTY_INFO key.
		///		FK_ADM_RATING_PARAMETERS_MAJORS_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		public abstract TList<AdmRatingParametersMajors> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_ENTITY_MAIN key.
		///		FK_ADM_RATING_PARAMETERS_MAJORS_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		public TList<AdmRatingParametersMajors> GetByEntMainId(System.Decimal? _entMainId)
		{
			int count = -1;
			return GetByEntMainId(_entMainId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_ENTITY_MAIN key.
		///		FK_ADM_RATING_PARAMETERS_MAJORS_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		/// <remarks></remarks>
		public TList<AdmRatingParametersMajors> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_ENTITY_MAIN key.
		///		FK_ADM_RATING_PARAMETERS_MAJORS_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		public TList<AdmRatingParametersMajors> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_ENTITY_MAIN key.
		///		fkAdmRatingParametersMajorsEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		public TList<AdmRatingParametersMajors> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainId(null, _entMainId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_ENTITY_MAIN key.
		///		fkAdmRatingParametersMajorsEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		public TList<AdmRatingParametersMajors> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength,out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_MAJORS_ENTITY_MAIN key.
		///		FK_ADM_RATING_PARAMETERS_MAJORS_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParametersMajors objects.</returns>
		public abstract TList<AdmRatingParametersMajors> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmRatingParametersMajors Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmRatingParametersMajorsKey key, int start, int pageLength)
		{
			return GetByAdmRatingParametersMajorsId(transactionManager, key.AdmRatingParametersMajorsId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_RATING_PARAMETERS_MAJORS index.
		/// </summary>
		/// <param name="_admRatingParametersMajorsId">خطة الأعداد المقترحة</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRatingParametersMajors"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRatingParametersMajors GetByAdmRatingParametersMajorsId(System.Decimal _admRatingParametersMajorsId)
		{
			int count = -1;
			return GetByAdmRatingParametersMajorsId(null,_admRatingParametersMajorsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_RATING_PARAMETERS_MAJORS index.
		/// </summary>
		/// <param name="_admRatingParametersMajorsId">خطة الأعداد المقترحة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRatingParametersMajors"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRatingParametersMajors GetByAdmRatingParametersMajorsId(System.Decimal _admRatingParametersMajorsId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmRatingParametersMajorsId(null, _admRatingParametersMajorsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_RATING_PARAMETERS_MAJORS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admRatingParametersMajorsId">خطة الأعداد المقترحة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRatingParametersMajors"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRatingParametersMajors GetByAdmRatingParametersMajorsId(TransactionManager transactionManager, System.Decimal _admRatingParametersMajorsId)
		{
			int count = -1;
			return GetByAdmRatingParametersMajorsId(transactionManager, _admRatingParametersMajorsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_RATING_PARAMETERS_MAJORS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admRatingParametersMajorsId">خطة الأعداد المقترحة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRatingParametersMajors"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRatingParametersMajors GetByAdmRatingParametersMajorsId(TransactionManager transactionManager, System.Decimal _admRatingParametersMajorsId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmRatingParametersMajorsId(transactionManager, _admRatingParametersMajorsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_RATING_PARAMETERS_MAJORS index.
		/// </summary>
		/// <param name="_admRatingParametersMajorsId">خطة الأعداد المقترحة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRatingParametersMajors"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRatingParametersMajors GetByAdmRatingParametersMajorsId(System.Decimal _admRatingParametersMajorsId, int start, int pageLength, out int count)
		{
			return GetByAdmRatingParametersMajorsId(null, _admRatingParametersMajorsId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_RATING_PARAMETERS_MAJORS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admRatingParametersMajorsId">خطة الأعداد المقترحة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRatingParametersMajors"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmRatingParametersMajors GetByAdmRatingParametersMajorsId(TransactionManager transactionManager, System.Decimal _admRatingParametersMajorsId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ADM_RATING_PARAMETERS_MAJORS index.
		/// </summary>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRatingParametersMajors"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRatingParametersMajors GetByAsCodeDegreeClassIdAsCodeDegreeIdAsFacultyInfoIdEntMainIdAdmOpenAcadSemesterIdAdmCdeAppTypeId(System.Decimal _asCodeDegreeClassId, System.Decimal _asCodeDegreeId, System.Decimal? _asFacultyInfoId, System.Decimal? _entMainId, System.Decimal _admOpenAcadSemesterId, System.Decimal? _admCdeAppTypeId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassIdAsCodeDegreeIdAsFacultyInfoIdEntMainIdAdmOpenAcadSemesterIdAdmCdeAppTypeId(null,_asCodeDegreeClassId, _asCodeDegreeId, _asFacultyInfoId, _entMainId, _admOpenAcadSemesterId, _admCdeAppTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_RATING_PARAMETERS_MAJORS index.
		/// </summary>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRatingParametersMajors"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRatingParametersMajors GetByAsCodeDegreeClassIdAsCodeDegreeIdAsFacultyInfoIdEntMainIdAdmOpenAcadSemesterIdAdmCdeAppTypeId(System.Decimal _asCodeDegreeClassId, System.Decimal _asCodeDegreeId, System.Decimal? _asFacultyInfoId, System.Decimal? _entMainId, System.Decimal _admOpenAcadSemesterId, System.Decimal? _admCdeAppTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeClassIdAsCodeDegreeIdAsFacultyInfoIdEntMainIdAdmOpenAcadSemesterIdAdmCdeAppTypeId(null, _asCodeDegreeClassId, _asCodeDegreeId, _asFacultyInfoId, _entMainId, _admOpenAcadSemesterId, _admCdeAppTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_RATING_PARAMETERS_MAJORS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRatingParametersMajors"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRatingParametersMajors GetByAsCodeDegreeClassIdAsCodeDegreeIdAsFacultyInfoIdEntMainIdAdmOpenAcadSemesterIdAdmCdeAppTypeId(TransactionManager transactionManager, System.Decimal _asCodeDegreeClassId, System.Decimal _asCodeDegreeId, System.Decimal? _asFacultyInfoId, System.Decimal? _entMainId, System.Decimal _admOpenAcadSemesterId, System.Decimal? _admCdeAppTypeId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassIdAsCodeDegreeIdAsFacultyInfoIdEntMainIdAdmOpenAcadSemesterIdAdmCdeAppTypeId(transactionManager, _asCodeDegreeClassId, _asCodeDegreeId, _asFacultyInfoId, _entMainId, _admOpenAcadSemesterId, _admCdeAppTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_RATING_PARAMETERS_MAJORS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRatingParametersMajors"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRatingParametersMajors GetByAsCodeDegreeClassIdAsCodeDegreeIdAsFacultyInfoIdEntMainIdAdmOpenAcadSemesterIdAdmCdeAppTypeId(TransactionManager transactionManager, System.Decimal _asCodeDegreeClassId, System.Decimal _asCodeDegreeId, System.Decimal? _asFacultyInfoId, System.Decimal? _entMainId, System.Decimal _admOpenAcadSemesterId, System.Decimal? _admCdeAppTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeClassIdAsCodeDegreeIdAsFacultyInfoIdEntMainIdAdmOpenAcadSemesterIdAdmCdeAppTypeId(transactionManager, _asCodeDegreeClassId, _asCodeDegreeId, _asFacultyInfoId, _entMainId, _admOpenAcadSemesterId, _admCdeAppTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_RATING_PARAMETERS_MAJORS index.
		/// </summary>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRatingParametersMajors"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRatingParametersMajors GetByAsCodeDegreeClassIdAsCodeDegreeIdAsFacultyInfoIdEntMainIdAdmOpenAcadSemesterIdAdmCdeAppTypeId(System.Decimal _asCodeDegreeClassId, System.Decimal _asCodeDegreeId, System.Decimal? _asFacultyInfoId, System.Decimal? _entMainId, System.Decimal _admOpenAcadSemesterId, System.Decimal? _admCdeAppTypeId, int start, int pageLength, out int count)
		{
			return GetByAsCodeDegreeClassIdAsCodeDegreeIdAsFacultyInfoIdEntMainIdAdmOpenAcadSemesterIdAdmCdeAppTypeId(null, _asCodeDegreeClassId, _asCodeDegreeId, _asFacultyInfoId, _entMainId, _admOpenAcadSemesterId, _admCdeAppTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_RATING_PARAMETERS_MAJORS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRatingParametersMajors"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmRatingParametersMajors GetByAsCodeDegreeClassIdAsCodeDegreeIdAsFacultyInfoIdEntMainIdAdmOpenAcadSemesterIdAdmCdeAppTypeId(TransactionManager transactionManager, System.Decimal _asCodeDegreeClassId, System.Decimal _asCodeDegreeId, System.Decimal? _asFacultyInfoId, System.Decimal? _entMainId, System.Decimal _admOpenAcadSemesterId, System.Decimal? _admCdeAppTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmRatingParametersMajors&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmRatingParametersMajors&gt;"/></returns>
		public static TList<AdmRatingParametersMajors> Fill(IDataReader reader, TList<AdmRatingParametersMajors> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmRatingParametersMajors c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmRatingParametersMajors")
					.Append("|").Append((System.Decimal)reader["ADM_RATING_PARAMETERS_MAJORS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmRatingParametersMajors>(
					key.ToString(), // EntityTrackingKey
					"AdmRatingParametersMajors",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmRatingParametersMajors();
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
					c.AdmRatingParametersMajorsId = (System.Decimal)reader["ADM_RATING_PARAMETERS_MAJORS_ID"];
					c.OriginalAdmRatingParametersMajorsId = c.AdmRatingParametersMajorsId;
					c.AdmOpenAcadSemesterId = (System.Decimal)reader["ADM_OPEN_ACAD_SEMESTER_ID"];
					c.EntMainId = Convert.IsDBNull(reader["ENT_MAIN_ID"]) ? null : (System.Decimal?)reader["ENT_MAIN_ID"];
					c.AsCodeDegreeId = (System.Decimal)reader["AS_CODE_DEGREE_ID"];
					c.AsCodeDegreeClassId = (System.Decimal)reader["AS_CODE_DEGREE_CLASS_ID"];
					c.AllRequiredNumbers = Convert.IsDBNull(reader["ALL_REQUIRED_NUMBERS"]) ? null : (System.Decimal?)reader["ALL_REQUIRED_NUMBERS"];
					c.MaleNumbers = Convert.IsDBNull(reader["MALE_NUMBERS"]) ? null : (System.Decimal?)reader["MALE_NUMBERS"];
					c.FemaleNumbers = Convert.IsDBNull(reader["FEMALE_NUMBERS"]) ? null : (System.Decimal?)reader["FEMALE_NUMBERS"];
					c.AdmAdmissionBandId = Convert.IsDBNull(reader["ADM_ADMISSION_BAND_ID"]) ? null : (System.Decimal?)reader["ADM_ADMISSION_BAND_ID"];
					c.TransMaleNumbers = Convert.IsDBNull(reader["TRANS_MALE_NUMBERS"]) ? null : (System.Decimal?)reader["TRANS_MALE_NUMBERS"];
					c.TransFemaleNumbers = Convert.IsDBNull(reader["TRANS_FEMALE_NUMBERS"]) ? null : (System.Decimal?)reader["TRANS_FEMALE_NUMBERS"];
					c.TransAllNumbers = Convert.IsDBNull(reader["TRANS_ALL_NUMBERS"]) ? null : (System.Decimal?)reader["TRANS_ALL_NUMBERS"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.AllRequiredNumbersProv = Convert.IsDBNull(reader["ALL_REQUIRED_NUMBERS_PROV"]) ? null : (System.Decimal?)reader["ALL_REQUIRED_NUMBERS_PROV"];
					c.GsCdeOperator = Convert.IsDBNull(reader["GS_CDE_OPERATOR"]) ? null : (System.String)reader["GS_CDE_OPERATOR"];
					c.QualPrcnt = Convert.IsDBNull(reader["QUAL_PRCNT"]) ? null : (System.Decimal?)reader["QUAL_PRCNT"];
					c.ExemptFlg = Convert.IsDBNull(reader["EXEMPT_FLG"]) ? null : (System.Boolean?)reader["EXEMPT_FLG"];
					c.AdmCdeAppTypeId = Convert.IsDBNull(reader["ADM_CDE_APP_TYPE_ID"]) ? null : (System.Decimal?)reader["ADM_CDE_APP_TYPE_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmRatingParametersMajors"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmRatingParametersMajors"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmRatingParametersMajors entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmRatingParametersMajorsId = (System.Decimal)reader[((int)AdmRatingParametersMajorsColumn.AdmRatingParametersMajorsId - 1)];
			entity.OriginalAdmRatingParametersMajorsId = (System.Decimal)reader["ADM_RATING_PARAMETERS_MAJORS_ID"];
			entity.AdmOpenAcadSemesterId = (System.Decimal)reader[((int)AdmRatingParametersMajorsColumn.AdmOpenAcadSemesterId - 1)];
			entity.EntMainId = (reader.IsDBNull(((int)AdmRatingParametersMajorsColumn.EntMainId - 1)))?null:(System.Decimal?)reader[((int)AdmRatingParametersMajorsColumn.EntMainId - 1)];
			entity.AsCodeDegreeId = (System.Decimal)reader[((int)AdmRatingParametersMajorsColumn.AsCodeDegreeId - 1)];
			entity.AsCodeDegreeClassId = (System.Decimal)reader[((int)AdmRatingParametersMajorsColumn.AsCodeDegreeClassId - 1)];
			entity.AllRequiredNumbers = (reader.IsDBNull(((int)AdmRatingParametersMajorsColumn.AllRequiredNumbers - 1)))?null:(System.Decimal?)reader[((int)AdmRatingParametersMajorsColumn.AllRequiredNumbers - 1)];
			entity.MaleNumbers = (reader.IsDBNull(((int)AdmRatingParametersMajorsColumn.MaleNumbers - 1)))?null:(System.Decimal?)reader[((int)AdmRatingParametersMajorsColumn.MaleNumbers - 1)];
			entity.FemaleNumbers = (reader.IsDBNull(((int)AdmRatingParametersMajorsColumn.FemaleNumbers - 1)))?null:(System.Decimal?)reader[((int)AdmRatingParametersMajorsColumn.FemaleNumbers - 1)];
			entity.AdmAdmissionBandId = (reader.IsDBNull(((int)AdmRatingParametersMajorsColumn.AdmAdmissionBandId - 1)))?null:(System.Decimal?)reader[((int)AdmRatingParametersMajorsColumn.AdmAdmissionBandId - 1)];
			entity.TransMaleNumbers = (reader.IsDBNull(((int)AdmRatingParametersMajorsColumn.TransMaleNumbers - 1)))?null:(System.Decimal?)reader[((int)AdmRatingParametersMajorsColumn.TransMaleNumbers - 1)];
			entity.TransFemaleNumbers = (reader.IsDBNull(((int)AdmRatingParametersMajorsColumn.TransFemaleNumbers - 1)))?null:(System.Decimal?)reader[((int)AdmRatingParametersMajorsColumn.TransFemaleNumbers - 1)];
			entity.TransAllNumbers = (reader.IsDBNull(((int)AdmRatingParametersMajorsColumn.TransAllNumbers - 1)))?null:(System.Decimal?)reader[((int)AdmRatingParametersMajorsColumn.TransAllNumbers - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)AdmRatingParametersMajorsColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)AdmRatingParametersMajorsColumn.AsFacultyInfoId - 1)];
			entity.AllRequiredNumbersProv = (reader.IsDBNull(((int)AdmRatingParametersMajorsColumn.AllRequiredNumbersProv - 1)))?null:(System.Decimal?)reader[((int)AdmRatingParametersMajorsColumn.AllRequiredNumbersProv - 1)];
			entity.GsCdeOperator = (reader.IsDBNull(((int)AdmRatingParametersMajorsColumn.GsCdeOperator - 1)))?null:(System.String)reader[((int)AdmRatingParametersMajorsColumn.GsCdeOperator - 1)];
			entity.QualPrcnt = (reader.IsDBNull(((int)AdmRatingParametersMajorsColumn.QualPrcnt - 1)))?null:(System.Decimal?)reader[((int)AdmRatingParametersMajorsColumn.QualPrcnt - 1)];
			entity.ExemptFlg = (reader.IsDBNull(((int)AdmRatingParametersMajorsColumn.ExemptFlg - 1)))?null:(System.Boolean?)reader[((int)AdmRatingParametersMajorsColumn.ExemptFlg - 1)];
			entity.AdmCdeAppTypeId = (reader.IsDBNull(((int)AdmRatingParametersMajorsColumn.AdmCdeAppTypeId - 1)))?null:(System.Decimal?)reader[((int)AdmRatingParametersMajorsColumn.AdmCdeAppTypeId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmRatingParametersMajors"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmRatingParametersMajors"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmRatingParametersMajors entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmRatingParametersMajorsId = (System.Decimal)dataRow["ADM_RATING_PARAMETERS_MAJORS_ID"];
			entity.OriginalAdmRatingParametersMajorsId = (System.Decimal)dataRow["ADM_RATING_PARAMETERS_MAJORS_ID"];
			entity.AdmOpenAcadSemesterId = (System.Decimal)dataRow["ADM_OPEN_ACAD_SEMESTER_ID"];
			entity.EntMainId = Convert.IsDBNull(dataRow["ENT_MAIN_ID"]) ? null : (System.Decimal?)dataRow["ENT_MAIN_ID"];
			entity.AsCodeDegreeId = (System.Decimal)dataRow["AS_CODE_DEGREE_ID"];
			entity.AsCodeDegreeClassId = (System.Decimal)dataRow["AS_CODE_DEGREE_CLASS_ID"];
			entity.AllRequiredNumbers = Convert.IsDBNull(dataRow["ALL_REQUIRED_NUMBERS"]) ? null : (System.Decimal?)dataRow["ALL_REQUIRED_NUMBERS"];
			entity.MaleNumbers = Convert.IsDBNull(dataRow["MALE_NUMBERS"]) ? null : (System.Decimal?)dataRow["MALE_NUMBERS"];
			entity.FemaleNumbers = Convert.IsDBNull(dataRow["FEMALE_NUMBERS"]) ? null : (System.Decimal?)dataRow["FEMALE_NUMBERS"];
			entity.AdmAdmissionBandId = Convert.IsDBNull(dataRow["ADM_ADMISSION_BAND_ID"]) ? null : (System.Decimal?)dataRow["ADM_ADMISSION_BAND_ID"];
			entity.TransMaleNumbers = Convert.IsDBNull(dataRow["TRANS_MALE_NUMBERS"]) ? null : (System.Decimal?)dataRow["TRANS_MALE_NUMBERS"];
			entity.TransFemaleNumbers = Convert.IsDBNull(dataRow["TRANS_FEMALE_NUMBERS"]) ? null : (System.Decimal?)dataRow["TRANS_FEMALE_NUMBERS"];
			entity.TransAllNumbers = Convert.IsDBNull(dataRow["TRANS_ALL_NUMBERS"]) ? null : (System.Decimal?)dataRow["TRANS_ALL_NUMBERS"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.AllRequiredNumbersProv = Convert.IsDBNull(dataRow["ALL_REQUIRED_NUMBERS_PROV"]) ? null : (System.Decimal?)dataRow["ALL_REQUIRED_NUMBERS_PROV"];
			entity.GsCdeOperator = Convert.IsDBNull(dataRow["GS_CDE_OPERATOR"]) ? null : (System.String)dataRow["GS_CDE_OPERATOR"];
			entity.QualPrcnt = Convert.IsDBNull(dataRow["QUAL_PRCNT"]) ? null : (System.Decimal?)dataRow["QUAL_PRCNT"];
			entity.ExemptFlg = Convert.IsDBNull(dataRow["EXEMPT_FLG"]) ? null : (System.Boolean?)dataRow["EXEMPT_FLG"];
			entity.AdmCdeAppTypeId = Convert.IsDBNull(dataRow["ADM_CDE_APP_TYPE_ID"]) ? null : (System.Decimal?)dataRow["ADM_CDE_APP_TYPE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmRatingParametersMajors"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmRatingParametersMajors Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmRatingParametersMajors entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmAdmissionBandIdSource	
			if (CanDeepLoad(entity, "AdmAdmissionBand|AdmAdmissionBandIdSource", deepLoadType, innerList) 
				&& entity.AdmAdmissionBandIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmAdmissionBandId ?? 0.0m);
				AdmAdmissionBand tmpEntity = EntityManager.LocateEntity<AdmAdmissionBand>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmAdmissionBand), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmAdmissionBandIdSource = tmpEntity;
				else
					entity.AdmAdmissionBandIdSource = DataRepository.AdmAdmissionBandProvider.GetByAdmAdmissionBandId(transactionManager, (entity.AdmAdmissionBandId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAdmissionBandIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmAdmissionBandIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmAdmissionBandProvider.DeepLoad(transactionManager, entity.AdmAdmissionBandIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmAdmissionBandIdSource

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

			#region AdmOpenAcadSemesterIdSource	
			if (CanDeepLoad(entity, "AdmOpenAcadSemester|AdmOpenAcadSemesterIdSource", deepLoadType, innerList) 
				&& entity.AdmOpenAcadSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmOpenAcadSemesterId;
				AdmOpenAcadSemester tmpEntity = EntityManager.LocateEntity<AdmOpenAcadSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmOpenAcadSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmOpenAcadSemesterIdSource = tmpEntity;
				else
					entity.AdmOpenAcadSemesterIdSource = DataRepository.AdmOpenAcadSemesterProvider.GetByAdmOpenAcadSemesterId(transactionManager, entity.AdmOpenAcadSemesterId);		
				
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

			#region AsCodeDegreeClassIdSource	
			if (CanDeepLoad(entity, "AsCodeDegreeClass|AsCodeDegreeClassIdSource", deepLoadType, innerList) 
				&& entity.AsCodeDegreeClassIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AsCodeDegreeClassId;
				AsCodeDegreeClass tmpEntity = EntityManager.LocateEntity<AsCodeDegreeClass>(EntityLocator.ConstructKeyFromPkItems(typeof(AsCodeDegreeClass), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsCodeDegreeClassIdSource = tmpEntity;
				else
					entity.AsCodeDegreeClassIdSource = DataRepository.AsCodeDegreeClassProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);		
				
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
			// Deep load child collections  - Call GetByAdmRatingParametersMajorsId methods when available
			
			#region AdmParamMajorPhaseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmParamMajorPhase>|AdmParamMajorPhaseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmParamMajorPhaseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmParamMajorPhaseCollection = DataRepository.AdmParamMajorPhaseProvider.GetByAdmRatingParametersMajorsId(transactionManager, entity.AdmRatingParametersMajorsId);

				if (deep && entity.AdmParamMajorPhaseCollection.Count > 0)
				{
					deepHandles.Add("AdmParamMajorPhaseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmParamMajorPhase>) DataRepository.AdmParamMajorPhaseProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmParamMajorPhaseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmRatingParamMajorTypeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmRatingParamMajorType>|AdmRatingParamMajorTypeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmRatingParamMajorTypeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmRatingParamMajorTypeCollection = DataRepository.AdmRatingParamMajorTypeProvider.GetByAdmRatingParametersMajorsId(transactionManager, entity.AdmRatingParametersMajorsId);

				if (deep && entity.AdmRatingParamMajorTypeCollection.Count > 0)
				{
					deepHandles.Add("AdmRatingParamMajorTypeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmRatingParamMajorType>) DataRepository.AdmRatingParamMajorTypeProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmRatingParamMajorTypeCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmRatingParametersMajors object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmRatingParametersMajors instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmRatingParametersMajors Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmRatingParametersMajors entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmAdmissionBandIdSource
			if (CanDeepSave(entity, "AdmAdmissionBand|AdmAdmissionBandIdSource", deepSaveType, innerList) 
				&& entity.AdmAdmissionBandIdSource != null)
			{
				DataRepository.AdmAdmissionBandProvider.Save(transactionManager, entity.AdmAdmissionBandIdSource);
				entity.AdmAdmissionBandId = entity.AdmAdmissionBandIdSource.AdmAdmissionBandId;
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
			
			#region AdmOpenAcadSemesterIdSource
			if (CanDeepSave(entity, "AdmOpenAcadSemester|AdmOpenAcadSemesterIdSource", deepSaveType, innerList) 
				&& entity.AdmOpenAcadSemesterIdSource != null)
			{
				DataRepository.AdmOpenAcadSemesterProvider.Save(transactionManager, entity.AdmOpenAcadSemesterIdSource);
				entity.AdmOpenAcadSemesterId = entity.AdmOpenAcadSemesterIdSource.AdmOpenAcadSemesterId;
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
			
			#region AsFacultyInfoIdSource
			if (CanDeepSave(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepSaveType, innerList) 
				&& entity.AsFacultyInfoIdSource != null)
			{
				DataRepository.AsFacultyInfoProvider.Save(transactionManager, entity.AsFacultyInfoIdSource);
				entity.AsFacultyInfoId = entity.AsFacultyInfoIdSource.AsFacultyInfoId;
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
	
			#region List<AdmParamMajorPhase>
				if (CanDeepSave(entity.AdmParamMajorPhaseCollection, "List<AdmParamMajorPhase>|AdmParamMajorPhaseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmParamMajorPhase child in entity.AdmParamMajorPhaseCollection)
					{
						if(child.AdmRatingParametersMajorsIdSource != null)
						{
							child.AdmRatingParametersMajorsId = child.AdmRatingParametersMajorsIdSource.AdmRatingParametersMajorsId;
						}
						else
						{
							child.AdmRatingParametersMajorsId = entity.AdmRatingParametersMajorsId;
						}

					}

					if (entity.AdmParamMajorPhaseCollection.Count > 0 || entity.AdmParamMajorPhaseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmParamMajorPhaseProvider.Save(transactionManager, entity.AdmParamMajorPhaseCollection);
						
						deepHandles.Add("AdmParamMajorPhaseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmParamMajorPhase >) DataRepository.AdmParamMajorPhaseProvider.DeepSave,
							new object[] { transactionManager, entity.AdmParamMajorPhaseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmRatingParamMajorType>
				if (CanDeepSave(entity.AdmRatingParamMajorTypeCollection, "List<AdmRatingParamMajorType>|AdmRatingParamMajorTypeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmRatingParamMajorType child in entity.AdmRatingParamMajorTypeCollection)
					{
						if(child.AdmRatingParametersMajorsIdSource != null)
						{
							child.AdmRatingParametersMajorsId = child.AdmRatingParametersMajorsIdSource.AdmRatingParametersMajorsId;
						}
						else
						{
							child.AdmRatingParametersMajorsId = entity.AdmRatingParametersMajorsId;
						}

					}

					if (entity.AdmRatingParamMajorTypeCollection.Count > 0 || entity.AdmRatingParamMajorTypeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmRatingParamMajorTypeProvider.Save(transactionManager, entity.AdmRatingParamMajorTypeCollection);
						
						deepHandles.Add("AdmRatingParamMajorTypeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmRatingParamMajorType >) DataRepository.AdmRatingParamMajorTypeProvider.DeepSave,
							new object[] { transactionManager, entity.AdmRatingParamMajorTypeCollection, deepSaveType, childTypes, innerList }
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
	
	#region AdmRatingParametersMajorsChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmRatingParametersMajors</c>
	///</summary>
	public enum AdmRatingParametersMajorsChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmAdmissionBand</c> at AdmAdmissionBandIdSource
		///</summary>
		[ChildEntityType(typeof(AdmAdmissionBand))]
		AdmAdmissionBand,
		
		///<summary>
		/// Composite Property for <c>AdmCdeAppType</c> at AdmCdeAppTypeIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdeAppType))]
		AdmCdeAppType,
		
		///<summary>
		/// Composite Property for <c>AdmOpenAcadSemester</c> at AdmOpenAcadSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(AdmOpenAcadSemester))]
		AdmOpenAcadSemester,
		
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
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		///<summary>
		/// Collection of <c>AdmRatingParametersMajors</c> as OneToMany for AdmParamMajorPhaseCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmParamMajorPhase>))]
		AdmParamMajorPhaseCollection,
		///<summary>
		/// Collection of <c>AdmRatingParametersMajors</c> as OneToMany for AdmRatingParamMajorTypeCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmRatingParamMajorType>))]
		AdmRatingParamMajorTypeCollection,
	}
	
	#endregion AdmRatingParametersMajorsChildEntityTypes
	
	#region AdmRatingParametersMajorsFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmRatingParametersMajorsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmRatingParametersMajors"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmRatingParametersMajorsFilterBuilder : SqlFilterBuilder<AdmRatingParametersMajorsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmRatingParametersMajorsFilterBuilder class.
		/// </summary>
		public AdmRatingParametersMajorsFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmRatingParametersMajorsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmRatingParametersMajorsFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmRatingParametersMajorsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmRatingParametersMajorsFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmRatingParametersMajorsFilterBuilder
	
	#region AdmRatingParametersMajorsParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmRatingParametersMajorsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmRatingParametersMajors"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmRatingParametersMajorsParameterBuilder : ParameterizedSqlFilterBuilder<AdmRatingParametersMajorsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmRatingParametersMajorsParameterBuilder class.
		/// </summary>
		public AdmRatingParametersMajorsParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmRatingParametersMajorsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmRatingParametersMajorsParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmRatingParametersMajorsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmRatingParametersMajorsParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmRatingParametersMajorsParameterBuilder
	
	#region AdmRatingParametersMajorsSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmRatingParametersMajorsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmRatingParametersMajors"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmRatingParametersMajorsSortBuilder : SqlSortBuilder<AdmRatingParametersMajorsColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmRatingParametersMajorsSqlSortBuilder class.
		/// </summary>
		public AdmRatingParametersMajorsSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmRatingParametersMajorsSortBuilder
	
} // end namespace
