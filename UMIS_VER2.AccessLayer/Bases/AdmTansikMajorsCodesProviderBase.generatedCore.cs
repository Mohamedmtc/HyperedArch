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
	/// This class is the base class for any <see cref="AdmTansikMajorsCodesProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmTansikMajorsCodesProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes, UMIS_VER2.BusinessLyer.AdmTansikMajorsCodesKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmTansikMajorsCodesKey key)
		{
			return Delete(transactionManager, key.AdmTansikMajorsCodesId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admTansikMajorsCodesId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admTansikMajorsCodesId)
		{
			return Delete(null, _admTansikMajorsCodesId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admTansikMajorsCodesId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admTansikMajorsCodesId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Majors_Codes_ADM_OPEN_ACAD_SEMESTER key.
		///		FK_ADM_Tansik_Majors_Codes_ADM_OPEN_ACAD_SEMESTER Description: 
		/// </summary>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes objects.</returns>
		public TList<AdmTansikMajorsCodes> GetByAdmOpenAcadSemesterId(System.Decimal _admOpenAcadSemesterId)
		{
			int count = -1;
			return GetByAdmOpenAcadSemesterId(_admOpenAcadSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Majors_Codes_ADM_OPEN_ACAD_SEMESTER key.
		///		FK_ADM_Tansik_Majors_Codes_ADM_OPEN_ACAD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes objects.</returns>
		/// <remarks></remarks>
		public TList<AdmTansikMajorsCodes> GetByAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal _admOpenAcadSemesterId)
		{
			int count = -1;
			return GetByAdmOpenAcadSemesterId(transactionManager, _admOpenAcadSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Majors_Codes_ADM_OPEN_ACAD_SEMESTER key.
		///		FK_ADM_Tansik_Majors_Codes_ADM_OPEN_ACAD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes objects.</returns>
		public TList<AdmTansikMajorsCodes> GetByAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal _admOpenAcadSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmOpenAcadSemesterId(transactionManager, _admOpenAcadSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Majors_Codes_ADM_OPEN_ACAD_SEMESTER key.
		///		fkAdmTansikMajorsCodesAdmOpenAcadSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes objects.</returns>
		public TList<AdmTansikMajorsCodes> GetByAdmOpenAcadSemesterId(System.Decimal _admOpenAcadSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmOpenAcadSemesterId(null, _admOpenAcadSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Majors_Codes_ADM_OPEN_ACAD_SEMESTER key.
		///		fkAdmTansikMajorsCodesAdmOpenAcadSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes objects.</returns>
		public TList<AdmTansikMajorsCodes> GetByAdmOpenAcadSemesterId(System.Decimal _admOpenAcadSemesterId, int start, int pageLength,out int count)
		{
			return GetByAdmOpenAcadSemesterId(null, _admOpenAcadSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Majors_Codes_ADM_OPEN_ACAD_SEMESTER key.
		///		FK_ADM_Tansik_Majors_Codes_ADM_OPEN_ACAD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes objects.</returns>
		public abstract TList<AdmTansikMajorsCodes> GetByAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal _admOpenAcadSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Majors_Codes_ADM_Tansik_Codes key.
		///		FK_ADM_Tansik_Majors_Codes_ADM_Tansik_Codes Description: 
		/// </summary>
		/// <param name="_admTansikCodesId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes objects.</returns>
		public TList<AdmTansikMajorsCodes> GetByAdmTansikCodesId(System.Decimal _admTansikCodesId)
		{
			int count = -1;
			return GetByAdmTansikCodesId(_admTansikCodesId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Majors_Codes_ADM_Tansik_Codes key.
		///		FK_ADM_Tansik_Majors_Codes_ADM_Tansik_Codes Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admTansikCodesId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes objects.</returns>
		/// <remarks></remarks>
		public TList<AdmTansikMajorsCodes> GetByAdmTansikCodesId(TransactionManager transactionManager, System.Decimal _admTansikCodesId)
		{
			int count = -1;
			return GetByAdmTansikCodesId(transactionManager, _admTansikCodesId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Majors_Codes_ADM_Tansik_Codes key.
		///		FK_ADM_Tansik_Majors_Codes_ADM_Tansik_Codes Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admTansikCodesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes objects.</returns>
		public TList<AdmTansikMajorsCodes> GetByAdmTansikCodesId(TransactionManager transactionManager, System.Decimal _admTansikCodesId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmTansikCodesId(transactionManager, _admTansikCodesId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Majors_Codes_ADM_Tansik_Codes key.
		///		fkAdmTansikMajorsCodesAdmTansikCodes Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admTansikCodesId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes objects.</returns>
		public TList<AdmTansikMajorsCodes> GetByAdmTansikCodesId(System.Decimal _admTansikCodesId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmTansikCodesId(null, _admTansikCodesId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Majors_Codes_ADM_Tansik_Codes key.
		///		fkAdmTansikMajorsCodesAdmTansikCodes Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admTansikCodesId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes objects.</returns>
		public TList<AdmTansikMajorsCodes> GetByAdmTansikCodesId(System.Decimal _admTansikCodesId, int start, int pageLength,out int count)
		{
			return GetByAdmTansikCodesId(null, _admTansikCodesId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Majors_Codes_ADM_Tansik_Codes key.
		///		FK_ADM_Tansik_Majors_Codes_ADM_Tansik_Codes Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admTansikCodesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes objects.</returns>
		public abstract TList<AdmTansikMajorsCodes> GetByAdmTansikCodesId(TransactionManager transactionManager, System.Decimal _admTansikCodesId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Majors_Codes_ENTITY_MAIN key.
		///		FK_ADM_Tansik_Majors_Codes_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes objects.</returns>
		public TList<AdmTansikMajorsCodes> GetByEntMainId(System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(_entMainId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Majors_Codes_ENTITY_MAIN key.
		///		FK_ADM_Tansik_Majors_Codes_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes objects.</returns>
		/// <remarks></remarks>
		public TList<AdmTansikMajorsCodes> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Majors_Codes_ENTITY_MAIN key.
		///		FK_ADM_Tansik_Majors_Codes_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes objects.</returns>
		public TList<AdmTansikMajorsCodes> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Majors_Codes_ENTITY_MAIN key.
		///		fkAdmTansikMajorsCodesEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes objects.</returns>
		public TList<AdmTansikMajorsCodes> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainId(null, _entMainId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Majors_Codes_ENTITY_MAIN key.
		///		fkAdmTansikMajorsCodesEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes objects.</returns>
		public TList<AdmTansikMajorsCodes> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength,out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Majors_Codes_ENTITY_MAIN key.
		///		FK_ADM_Tansik_Majors_Codes_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes objects.</returns>
		public abstract TList<AdmTansikMajorsCodes> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Majors_Codes_SE_USER key.
		///		FK_ADM_Tansik_Majors_Codes_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes objects.</returns>
		public TList<AdmTansikMajorsCodes> GetBySeUserId(System.Decimal _seUserId)
		{
			int count = -1;
			return GetBySeUserId(_seUserId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Majors_Codes_SE_USER key.
		///		FK_ADM_Tansik_Majors_Codes_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes objects.</returns>
		/// <remarks></remarks>
		public TList<AdmTansikMajorsCodes> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Majors_Codes_SE_USER key.
		///		FK_ADM_Tansik_Majors_Codes_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes objects.</returns>
		public TList<AdmTansikMajorsCodes> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Majors_Codes_SE_USER key.
		///		fkAdmTansikMajorsCodesSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes objects.</returns>
		public TList<AdmTansikMajorsCodes> GetBySeUserId(System.Decimal _seUserId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserId(null, _seUserId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Majors_Codes_SE_USER key.
		///		fkAdmTansikMajorsCodesSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes objects.</returns>
		public TList<AdmTansikMajorsCodes> GetBySeUserId(System.Decimal _seUserId, int start, int pageLength,out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Majors_Codes_SE_USER key.
		///		FK_ADM_Tansik_Majors_Codes_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes objects.</returns>
		public abstract TList<AdmTansikMajorsCodes> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmTansikMajorsCodesKey key, int start, int pageLength)
		{
			return GetByAdmTansikMajorsCodesId(transactionManager, key.AdmTansikMajorsCodesId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_Tansik_Majors_Codes index.
		/// </summary>
		/// <param name="_admTansikMajorsCodesId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes GetByAdmTansikMajorsCodesId(System.Decimal _admTansikMajorsCodesId)
		{
			int count = -1;
			return GetByAdmTansikMajorsCodesId(null,_admTansikMajorsCodesId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_Tansik_Majors_Codes index.
		/// </summary>
		/// <param name="_admTansikMajorsCodesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes GetByAdmTansikMajorsCodesId(System.Decimal _admTansikMajorsCodesId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmTansikMajorsCodesId(null, _admTansikMajorsCodesId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_Tansik_Majors_Codes index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admTansikMajorsCodesId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes GetByAdmTansikMajorsCodesId(TransactionManager transactionManager, System.Decimal _admTansikMajorsCodesId)
		{
			int count = -1;
			return GetByAdmTansikMajorsCodesId(transactionManager, _admTansikMajorsCodesId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_Tansik_Majors_Codes index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admTansikMajorsCodesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes GetByAdmTansikMajorsCodesId(TransactionManager transactionManager, System.Decimal _admTansikMajorsCodesId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmTansikMajorsCodesId(transactionManager, _admTansikMajorsCodesId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_Tansik_Majors_Codes index.
		/// </summary>
		/// <param name="_admTansikMajorsCodesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes GetByAdmTansikMajorsCodesId(System.Decimal _admTansikMajorsCodesId, int start, int pageLength, out int count)
		{
			return GetByAdmTansikMajorsCodesId(null, _admTansikMajorsCodesId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_Tansik_Majors_Codes index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admTansikMajorsCodesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes GetByAdmTansikMajorsCodesId(TransactionManager transactionManager, System.Decimal _admTansikMajorsCodesId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmTansikMajorsCodes&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmTansikMajorsCodes&gt;"/></returns>
		public static TList<AdmTansikMajorsCodes> Fill(IDataReader reader, TList<AdmTansikMajorsCodes> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmTansikMajorsCodes")
					.Append("|").Append((System.Decimal)reader["ADM_Tansik_Majors_Codes_Id"]).ToString();
					c = EntityManager.LocateOrCreate<AdmTansikMajorsCodes>(
					key.ToString(), // EntityTrackingKey
					"AdmTansikMajorsCodes",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes();
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
					c.AdmTansikMajorsCodesId = (System.Decimal)reader["ADM_Tansik_Majors_Codes_Id"];
					c.OriginalAdmTansikMajorsCodesId = c.AdmTansikMajorsCodesId;
					c.AdmTansikCodesId = (System.Decimal)reader["ADM_Tansik_Codes_ID"];
					c.EntMainId = (System.Decimal)reader["ENT_MAIN_ID"];
					c.LastDate = Convert.IsDBNull(reader["Last_Date"]) ? null : (System.DateTime?)reader["Last_Date"];
					c.SeUserId = (System.Decimal)reader["SE_USER_ID"];
					c.AdmOpenAcadSemesterId = (System.Decimal)reader["ADM_OPEN_ACAD_SEMESTER_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmTansikMajorsCodesId = (System.Decimal)reader[((int)AdmTansikMajorsCodesColumn.AdmTansikMajorsCodesId - 1)];
			entity.OriginalAdmTansikMajorsCodesId = (System.Decimal)reader["ADM_Tansik_Majors_Codes_Id"];
			entity.AdmTansikCodesId = (System.Decimal)reader[((int)AdmTansikMajorsCodesColumn.AdmTansikCodesId - 1)];
			entity.EntMainId = (System.Decimal)reader[((int)AdmTansikMajorsCodesColumn.EntMainId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AdmTansikMajorsCodesColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AdmTansikMajorsCodesColumn.LastDate - 1)];
			entity.SeUserId = (System.Decimal)reader[((int)AdmTansikMajorsCodesColumn.SeUserId - 1)];
			entity.AdmOpenAcadSemesterId = (System.Decimal)reader[((int)AdmTansikMajorsCodesColumn.AdmOpenAcadSemesterId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmTansikMajorsCodesId = (System.Decimal)dataRow["ADM_Tansik_Majors_Codes_Id"];
			entity.OriginalAdmTansikMajorsCodesId = (System.Decimal)dataRow["ADM_Tansik_Majors_Codes_Id"];
			entity.AdmTansikCodesId = (System.Decimal)dataRow["ADM_Tansik_Codes_ID"];
			entity.EntMainId = (System.Decimal)dataRow["ENT_MAIN_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["Last_Date"]) ? null : (System.DateTime?)dataRow["Last_Date"];
			entity.SeUserId = (System.Decimal)dataRow["SE_USER_ID"];
			entity.AdmOpenAcadSemesterId = (System.Decimal)dataRow["ADM_OPEN_ACAD_SEMESTER_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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

			#region AdmTansikCodesIdSource	
			if (CanDeepLoad(entity, "AdmTansikCodes|AdmTansikCodesIdSource", deepLoadType, innerList) 
				&& entity.AdmTansikCodesIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmTansikCodesId;
				AdmTansikCodes tmpEntity = EntityManager.LocateEntity<AdmTansikCodes>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmTansikCodes), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmTansikCodesIdSource = tmpEntity;
				else
					entity.AdmTansikCodesIdSource = DataRepository.AdmTansikCodesProvider.GetByAdmTansikCodesId(transactionManager, entity.AdmTansikCodesId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmTansikCodesIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmTansikCodesIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmTansikCodesProvider.DeepLoad(transactionManager, entity.AdmTansikCodesIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmTansikCodesIdSource

			#region EntMainIdSource	
			if (CanDeepLoad(entity, "EntityMain|EntMainIdSource", deepLoadType, innerList) 
				&& entity.EntMainIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EntMainId;
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntMainIdSource = tmpEntity;
				else
					entity.EntMainIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, entity.EntMainId);		
				
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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAdmTansikMajorsCodesId methods when available
			
			#region AdmAppPrefCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppPref>|AdmAppPrefCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppPrefCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppPrefCollection = DataRepository.AdmAppPrefProvider.GetByAdmTansikMajorsCodesId(transactionManager, entity.AdmTansikMajorsCodesId);

				if (deep && entity.AdmAppPrefCollection.Count > 0)
				{
					deepHandles.Add("AdmAppPrefCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppPref>) DataRepository.AdmAppPrefProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppPrefCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmOpenAcadSemesterIdSource
			if (CanDeepSave(entity, "AdmOpenAcadSemester|AdmOpenAcadSemesterIdSource", deepSaveType, innerList) 
				&& entity.AdmOpenAcadSemesterIdSource != null)
			{
				DataRepository.AdmOpenAcadSemesterProvider.Save(transactionManager, entity.AdmOpenAcadSemesterIdSource);
				entity.AdmOpenAcadSemesterId = entity.AdmOpenAcadSemesterIdSource.AdmOpenAcadSemesterId;
			}
			#endregion 
			
			#region AdmTansikCodesIdSource
			if (CanDeepSave(entity, "AdmTansikCodes|AdmTansikCodesIdSource", deepSaveType, innerList) 
				&& entity.AdmTansikCodesIdSource != null)
			{
				DataRepository.AdmTansikCodesProvider.Save(transactionManager, entity.AdmTansikCodesIdSource);
				entity.AdmTansikCodesId = entity.AdmTansikCodesIdSource.AdmTansikCodesId;
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
			
			#region SeUserIdSource
			if (CanDeepSave(entity, "SeUser|SeUserIdSource", deepSaveType, innerList) 
				&& entity.SeUserIdSource != null)
			{
				DataRepository.SeUserProvider.Save(transactionManager, entity.SeUserIdSource);
				entity.SeUserId = entity.SeUserIdSource.SeUserId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<AdmAppPref>
				if (CanDeepSave(entity.AdmAppPrefCollection, "List<AdmAppPref>|AdmAppPrefCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppPref child in entity.AdmAppPrefCollection)
					{
						if(child.AdmTansikMajorsCodesIdSource != null)
						{
							child.AdmTansikMajorsCodesId = child.AdmTansikMajorsCodesIdSource.AdmTansikMajorsCodesId;
						}
						else
						{
							child.AdmTansikMajorsCodesId = entity.AdmTansikMajorsCodesId;
						}

					}

					if (entity.AdmAppPrefCollection.Count > 0 || entity.AdmAppPrefCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppPrefProvider.Save(transactionManager, entity.AdmAppPrefCollection);
						
						deepHandles.Add("AdmAppPrefCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppPref >) DataRepository.AdmAppPrefProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppPrefCollection, deepSaveType, childTypes, innerList }
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
	
	#region AdmTansikMajorsCodesChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmTansikMajorsCodes</c>
	///</summary>
	public enum AdmTansikMajorsCodesChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmOpenAcadSemester</c> at AdmOpenAcadSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(AdmOpenAcadSemester))]
		AdmOpenAcadSemester,
		
		///<summary>
		/// Composite Property for <c>AdmTansikCodes</c> at AdmTansikCodesIdSource
		///</summary>
		[ChildEntityType(typeof(AdmTansikCodes))]
		AdmTansikCodes,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at SeUserIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
		///<summary>
		/// Collection of <c>AdmTansikMajorsCodes</c> as OneToMany for AdmAppPrefCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppPref>))]
		AdmAppPrefCollection,
	}
	
	#endregion AdmTansikMajorsCodesChildEntityTypes
	
	#region AdmTansikMajorsCodesFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmTansikMajorsCodesColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmTansikMajorsCodes"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmTansikMajorsCodesFilterBuilder : SqlFilterBuilder<AdmTansikMajorsCodesColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmTansikMajorsCodesFilterBuilder class.
		/// </summary>
		public AdmTansikMajorsCodesFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmTansikMajorsCodesFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmTansikMajorsCodesFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmTansikMajorsCodesFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmTansikMajorsCodesFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmTansikMajorsCodesFilterBuilder
	
	#region AdmTansikMajorsCodesParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmTansikMajorsCodesColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmTansikMajorsCodes"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmTansikMajorsCodesParameterBuilder : ParameterizedSqlFilterBuilder<AdmTansikMajorsCodesColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmTansikMajorsCodesParameterBuilder class.
		/// </summary>
		public AdmTansikMajorsCodesParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmTansikMajorsCodesParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmTansikMajorsCodesParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmTansikMajorsCodesParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmTansikMajorsCodesParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmTansikMajorsCodesParameterBuilder
	
	#region AdmTansikMajorsCodesSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmTansikMajorsCodesColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmTansikMajorsCodes"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmTansikMajorsCodesSortBuilder : SqlSortBuilder<AdmTansikMajorsCodesColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmTansikMajorsCodesSqlSortBuilder class.
		/// </summary>
		public AdmTansikMajorsCodesSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmTansikMajorsCodesSortBuilder
	
} // end namespace
