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
	/// This class is the base class for any <see cref="GsCommProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCommProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsComm, UMIS_VER2.BusinessLyer.GsCommKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCommKey key)
		{
			return Delete(transactionManager, key.GsCommId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCommId">انشاء لجان الابحاث العلمية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCommId)
		{
			return Delete(null, _gsCommId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommId">انشاء لجان الابحاث العلمية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCommId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_AS_FACULTY_INFO key.
		///		FK_GS_COMM_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId">الكلية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsComm objects.</returns>
		public TList<GsComm> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_AS_FACULTY_INFO key.
		///		FK_GS_COMM_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId">الكلية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsComm objects.</returns>
		/// <remarks></remarks>
		public TList<GsComm> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_AS_FACULTY_INFO key.
		///		FK_GS_COMM_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId">الكلية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsComm objects.</returns>
		public TList<GsComm> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_AS_FACULTY_INFO key.
		///		fkGsCommAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId">الكلية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsComm objects.</returns>
		public TList<GsComm> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_AS_FACULTY_INFO key.
		///		fkGsCommAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId">الكلية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsComm objects.</returns>
		public TList<GsComm> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_AS_FACULTY_INFO key.
		///		FK_GS_COMM_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId">الكلية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsComm objects.</returns>
		public abstract TList<GsComm> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_ED_ACAD_YEAR key.
		///		FK_GS_COMM_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId">العام الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsComm objects.</returns>
		public TList<GsComm> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_ED_ACAD_YEAR key.
		///		FK_GS_COMM_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsComm objects.</returns>
		/// <remarks></remarks>
		public TList<GsComm> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_ED_ACAD_YEAR key.
		///		FK_GS_COMM_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsComm objects.</returns>
		public TList<GsComm> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_ED_ACAD_YEAR key.
		///		fkGsCommEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">العام الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsComm objects.</returns>
		public TList<GsComm> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_ED_ACAD_YEAR key.
		///		fkGsCommEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">العام الدراسي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsComm objects.</returns>
		public TList<GsComm> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_ED_ACAD_YEAR key.
		///		FK_GS_COMM_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsComm objects.</returns>
		public abstract TList<GsComm> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_ED_CODE_SEMESTER key.
		///		FK_GS_COMM_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edSemesterId">XX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsComm objects.</returns>
		public TList<GsComm> GetByEdSemesterId(System.Decimal? _edSemesterId)
		{
			int count = -1;
			return GetByEdSemesterId(_edSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_ED_CODE_SEMESTER key.
		///		FK_GS_COMM_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemesterId">XX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsComm objects.</returns>
		/// <remarks></remarks>
		public TList<GsComm> GetByEdSemesterId(TransactionManager transactionManager, System.Decimal? _edSemesterId)
		{
			int count = -1;
			return GetByEdSemesterId(transactionManager, _edSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_ED_CODE_SEMESTER key.
		///		FK_GS_COMM_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemesterId">XX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsComm objects.</returns>
		public TList<GsComm> GetByEdSemesterId(TransactionManager transactionManager, System.Decimal? _edSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdSemesterId(transactionManager, _edSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_ED_CODE_SEMESTER key.
		///		fkGsCommEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edSemesterId">XX</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsComm objects.</returns>
		public TList<GsComm> GetByEdSemesterId(System.Decimal? _edSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdSemesterId(null, _edSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_ED_CODE_SEMESTER key.
		///		fkGsCommEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edSemesterId">XX</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsComm objects.</returns>
		public TList<GsComm> GetByEdSemesterId(System.Decimal? _edSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdSemesterId(null, _edSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_ED_CODE_SEMESTER key.
		///		FK_GS_COMM_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemesterId">XX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsComm objects.</returns>
		public abstract TList<GsComm> GetByEdSemesterId(TransactionManager transactionManager, System.Decimal? _edSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_ENTITY_MAIN key.
		///		FK_GS_COMM_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_entMainMajorId">التخصص الرئيسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsComm objects.</returns>
		public TList<GsComm> GetByEntMainMajorId(System.Decimal? _entMainMajorId)
		{
			int count = -1;
			return GetByEntMainMajorId(_entMainMajorId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_ENTITY_MAIN key.
		///		FK_GS_COMM_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainMajorId">التخصص الرئيسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsComm objects.</returns>
		/// <remarks></remarks>
		public TList<GsComm> GetByEntMainMajorId(TransactionManager transactionManager, System.Decimal? _entMainMajorId)
		{
			int count = -1;
			return GetByEntMainMajorId(transactionManager, _entMainMajorId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_ENTITY_MAIN key.
		///		FK_GS_COMM_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainMajorId">التخصص الرئيسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsComm objects.</returns>
		public TList<GsComm> GetByEntMainMajorId(TransactionManager transactionManager, System.Decimal? _entMainMajorId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainMajorId(transactionManager, _entMainMajorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_ENTITY_MAIN key.
		///		fkGsCommEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainMajorId">التخصص الرئيسي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsComm objects.</returns>
		public TList<GsComm> GetByEntMainMajorId(System.Decimal? _entMainMajorId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainMajorId(null, _entMainMajorId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_ENTITY_MAIN key.
		///		fkGsCommEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainMajorId">التخصص الرئيسي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsComm objects.</returns>
		public TList<GsComm> GetByEntMainMajorId(System.Decimal? _entMainMajorId, int start, int pageLength,out int count)
		{
			return GetByEntMainMajorId(null, _entMainMajorId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_ENTITY_MAIN key.
		///		FK_GS_COMM_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainMajorId">التخصص الرئيسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsComm objects.</returns>
		public abstract TList<GsComm> GetByEntMainMajorId(TransactionManager transactionManager, System.Decimal? _entMainMajorId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_ENTITY_MAIN1 key.
		///		FK_GS_COMM_ENTITY_MAIN1 Description: 
		/// </summary>
		/// <param name="_entMainMinorId">التخصص الفرعي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsComm objects.</returns>
		public TList<GsComm> GetByEntMainMinorId(System.Decimal? _entMainMinorId)
		{
			int count = -1;
			return GetByEntMainMinorId(_entMainMinorId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_ENTITY_MAIN1 key.
		///		FK_GS_COMM_ENTITY_MAIN1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainMinorId">التخصص الفرعي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsComm objects.</returns>
		/// <remarks></remarks>
		public TList<GsComm> GetByEntMainMinorId(TransactionManager transactionManager, System.Decimal? _entMainMinorId)
		{
			int count = -1;
			return GetByEntMainMinorId(transactionManager, _entMainMinorId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_ENTITY_MAIN1 key.
		///		FK_GS_COMM_ENTITY_MAIN1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainMinorId">التخصص الفرعي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsComm objects.</returns>
		public TList<GsComm> GetByEntMainMinorId(TransactionManager transactionManager, System.Decimal? _entMainMinorId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainMinorId(transactionManager, _entMainMinorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_ENTITY_MAIN1 key.
		///		fkGsCommEntityMain1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainMinorId">التخصص الفرعي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsComm objects.</returns>
		public TList<GsComm> GetByEntMainMinorId(System.Decimal? _entMainMinorId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainMinorId(null, _entMainMinorId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_ENTITY_MAIN1 key.
		///		fkGsCommEntityMain1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainMinorId">التخصص الفرعي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsComm objects.</returns>
		public TList<GsComm> GetByEntMainMinorId(System.Decimal? _entMainMinorId, int start, int pageLength,out int count)
		{
			return GetByEntMainMinorId(null, _entMainMinorId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_ENTITY_MAIN1 key.
		///		FK_GS_COMM_ENTITY_MAIN1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainMinorId">التخصص الفرعي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsComm objects.</returns>
		public abstract TList<GsComm> GetByEntMainMinorId(TransactionManager transactionManager, System.Decimal? _entMainMinorId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_GS_COMM_PURPOSE key.
		///		FK_GS_COMM_GS_COMM_PURPOSE Description: 
		/// </summary>
		/// <param name="_gsCommPurposeId">XX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsComm objects.</returns>
		public TList<GsComm> GetByGsCommPurposeId(System.Decimal? _gsCommPurposeId)
		{
			int count = -1;
			return GetByGsCommPurposeId(_gsCommPurposeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_GS_COMM_PURPOSE key.
		///		FK_GS_COMM_GS_COMM_PURPOSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommPurposeId">XX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsComm objects.</returns>
		/// <remarks></remarks>
		public TList<GsComm> GetByGsCommPurposeId(TransactionManager transactionManager, System.Decimal? _gsCommPurposeId)
		{
			int count = -1;
			return GetByGsCommPurposeId(transactionManager, _gsCommPurposeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_GS_COMM_PURPOSE key.
		///		FK_GS_COMM_GS_COMM_PURPOSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommPurposeId">XX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsComm objects.</returns>
		public TList<GsComm> GetByGsCommPurposeId(TransactionManager transactionManager, System.Decimal? _gsCommPurposeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCommPurposeId(transactionManager, _gsCommPurposeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_GS_COMM_PURPOSE key.
		///		fkGsCommGsCommPurpose Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCommPurposeId">XX</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsComm objects.</returns>
		public TList<GsComm> GetByGsCommPurposeId(System.Decimal? _gsCommPurposeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCommPurposeId(null, _gsCommPurposeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_GS_COMM_PURPOSE key.
		///		fkGsCommGsCommPurpose Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCommPurposeId">XX</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsComm objects.</returns>
		public TList<GsComm> GetByGsCommPurposeId(System.Decimal? _gsCommPurposeId, int start, int pageLength,out int count)
		{
			return GetByGsCommPurposeId(null, _gsCommPurposeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_GS_COMM_PURPOSE key.
		///		FK_GS_COMM_GS_COMM_PURPOSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommPurposeId">XX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsComm objects.</returns>
		public abstract TList<GsComm> GetByGsCommPurposeId(TransactionManager transactionManager, System.Decimal? _gsCommPurposeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.GsComm Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCommKey key, int start, int pageLength)
		{
			return GetByGsCommId(transactionManager, key.GsCommId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_COMM index.
		/// </summary>
		/// <param name="_gsCommId">انشاء لجان الابحاث العلمية</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsComm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsComm GetByGsCommId(System.Decimal _gsCommId)
		{
			int count = -1;
			return GetByGsCommId(null,_gsCommId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_COMM index.
		/// </summary>
		/// <param name="_gsCommId">انشاء لجان الابحاث العلمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsComm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsComm GetByGsCommId(System.Decimal _gsCommId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCommId(null, _gsCommId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_COMM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommId">انشاء لجان الابحاث العلمية</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsComm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsComm GetByGsCommId(TransactionManager transactionManager, System.Decimal _gsCommId)
		{
			int count = -1;
			return GetByGsCommId(transactionManager, _gsCommId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_COMM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommId">انشاء لجان الابحاث العلمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsComm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsComm GetByGsCommId(TransactionManager transactionManager, System.Decimal _gsCommId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCommId(transactionManager, _gsCommId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_COMM index.
		/// </summary>
		/// <param name="_gsCommId">انشاء لجان الابحاث العلمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsComm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsComm GetByGsCommId(System.Decimal _gsCommId, int start, int pageLength, out int count)
		{
			return GetByGsCommId(null, _gsCommId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_COMM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommId">انشاء لجان الابحاث العلمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsComm"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsComm GetByGsCommId(TransactionManager transactionManager, System.Decimal _gsCommId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_GS_COMM index.
		/// </summary>
		/// <param name="_entMainMajorId">التخصص الرئيسي</param>
		/// <param name="_asFacultyInfoId">الكلية</param>
		/// <param name="_entMainMinorId">التخصص الفرعي</param>
		/// <param name="_edAcadYearId">العام الدراسي</param>
		/// <param name="_edSemesterId">XX</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsComm&gt;"/> class.</returns>
		public TList<GsComm> GetByEntMainMajorIdAsFacultyInfoIdEntMainMinorIdEdAcadYearIdEdSemesterId(System.Decimal? _entMainMajorId, System.Decimal? _asFacultyInfoId, System.Decimal? _entMainMinorId, System.Decimal _edAcadYearId, System.Decimal? _edSemesterId)
		{
			int count = -1;
			return GetByEntMainMajorIdAsFacultyInfoIdEntMainMinorIdEdAcadYearIdEdSemesterId(null,_entMainMajorId, _asFacultyInfoId, _entMainMinorId, _edAcadYearId, _edSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_COMM index.
		/// </summary>
		/// <param name="_entMainMajorId">التخصص الرئيسي</param>
		/// <param name="_asFacultyInfoId">الكلية</param>
		/// <param name="_entMainMinorId">التخصص الفرعي</param>
		/// <param name="_edAcadYearId">العام الدراسي</param>
		/// <param name="_edSemesterId">XX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsComm&gt;"/> class.</returns>
		public TList<GsComm> GetByEntMainMajorIdAsFacultyInfoIdEntMainMinorIdEdAcadYearIdEdSemesterId(System.Decimal? _entMainMajorId, System.Decimal? _asFacultyInfoId, System.Decimal? _entMainMinorId, System.Decimal _edAcadYearId, System.Decimal? _edSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainMajorIdAsFacultyInfoIdEntMainMinorIdEdAcadYearIdEdSemesterId(null, _entMainMajorId, _asFacultyInfoId, _entMainMinorId, _edAcadYearId, _edSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_COMM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainMajorId">التخصص الرئيسي</param>
		/// <param name="_asFacultyInfoId">الكلية</param>
		/// <param name="_entMainMinorId">التخصص الفرعي</param>
		/// <param name="_edAcadYearId">العام الدراسي</param>
		/// <param name="_edSemesterId">XX</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsComm&gt;"/> class.</returns>
		public TList<GsComm> GetByEntMainMajorIdAsFacultyInfoIdEntMainMinorIdEdAcadYearIdEdSemesterId(TransactionManager transactionManager, System.Decimal? _entMainMajorId, System.Decimal? _asFacultyInfoId, System.Decimal? _entMainMinorId, System.Decimal _edAcadYearId, System.Decimal? _edSemesterId)
		{
			int count = -1;
			return GetByEntMainMajorIdAsFacultyInfoIdEntMainMinorIdEdAcadYearIdEdSemesterId(transactionManager, _entMainMajorId, _asFacultyInfoId, _entMainMinorId, _edAcadYearId, _edSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_COMM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainMajorId">التخصص الرئيسي</param>
		/// <param name="_asFacultyInfoId">الكلية</param>
		/// <param name="_entMainMinorId">التخصص الفرعي</param>
		/// <param name="_edAcadYearId">العام الدراسي</param>
		/// <param name="_edSemesterId">XX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsComm&gt;"/> class.</returns>
		public TList<GsComm> GetByEntMainMajorIdAsFacultyInfoIdEntMainMinorIdEdAcadYearIdEdSemesterId(TransactionManager transactionManager, System.Decimal? _entMainMajorId, System.Decimal? _asFacultyInfoId, System.Decimal? _entMainMinorId, System.Decimal _edAcadYearId, System.Decimal? _edSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainMajorIdAsFacultyInfoIdEntMainMinorIdEdAcadYearIdEdSemesterId(transactionManager, _entMainMajorId, _asFacultyInfoId, _entMainMinorId, _edAcadYearId, _edSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_COMM index.
		/// </summary>
		/// <param name="_entMainMajorId">التخصص الرئيسي</param>
		/// <param name="_asFacultyInfoId">الكلية</param>
		/// <param name="_entMainMinorId">التخصص الفرعي</param>
		/// <param name="_edAcadYearId">العام الدراسي</param>
		/// <param name="_edSemesterId">XX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsComm&gt;"/> class.</returns>
		public TList<GsComm> GetByEntMainMajorIdAsFacultyInfoIdEntMainMinorIdEdAcadYearIdEdSemesterId(System.Decimal? _entMainMajorId, System.Decimal? _asFacultyInfoId, System.Decimal? _entMainMinorId, System.Decimal _edAcadYearId, System.Decimal? _edSemesterId, int start, int pageLength, out int count)
		{
			return GetByEntMainMajorIdAsFacultyInfoIdEntMainMinorIdEdAcadYearIdEdSemesterId(null, _entMainMajorId, _asFacultyInfoId, _entMainMinorId, _edAcadYearId, _edSemesterId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_COMM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainMajorId">التخصص الرئيسي</param>
		/// <param name="_asFacultyInfoId">الكلية</param>
		/// <param name="_entMainMinorId">التخصص الفرعي</param>
		/// <param name="_edAcadYearId">العام الدراسي</param>
		/// <param name="_edSemesterId">XX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsComm&gt;"/> class.</returns>
		public abstract TList<GsComm> GetByEntMainMajorIdAsFacultyInfoIdEntMainMinorIdEdAcadYearIdEdSemesterId(TransactionManager transactionManager, System.Decimal? _entMainMajorId, System.Decimal? _asFacultyInfoId, System.Decimal? _entMainMinorId, System.Decimal _edAcadYearId, System.Decimal? _edSemesterId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsComm&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsComm&gt;"/></returns>
		public static TList<GsComm> Fill(IDataReader reader, TList<GsComm> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsComm c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsComm")
					.Append("|").Append((System.Decimal)reader["GS_COMM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsComm>(
					key.ToString(), // EntityTrackingKey
					"GsComm",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsComm();
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
					c.GsCommId = (System.Decimal)reader["GS_COMM_ID"];
					c.OriginalGsCommId = c.GsCommId;
					c.CommDate = Convert.IsDBNull(reader["COMM_DATE"]) ? null : (System.DateTime?)reader["COMM_DATE"];
					c.CommNum = Convert.IsDBNull(reader["COMM_NUM"]) ? null : (System.String)reader["COMM_NUM"];
					c.CommName = Convert.IsDBNull(reader["COMM_NAME"]) ? null : (System.String)reader["COMM_NAME"];
					c.CommApprovedBy = Convert.IsDBNull(reader["COMM_APPROVED_BY"]) ? null : (System.Decimal?)reader["COMM_APPROVED_BY"];
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdSemesterId = Convert.IsDBNull(reader["ED_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_SEMESTER_ID"];
					c.LawNo = Convert.IsDBNull(reader["LAW_NO"]) ? null : (System.Decimal?)reader["LAW_NO"];
					c.LawYear = Convert.IsDBNull(reader["LAW_YEAR"]) ? null : (System.Decimal?)reader["LAW_YEAR"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.EntMainMajorId = Convert.IsDBNull(reader["ENT_MAIN_MAJOR_ID"]) ? null : (System.Decimal?)reader["ENT_MAIN_MAJOR_ID"];
					c.EntMainMinorId = Convert.IsDBNull(reader["ENT_MAIN_MINOR_ID"]) ? null : (System.Decimal?)reader["ENT_MAIN_MINOR_ID"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.GsCommPurposeId = Convert.IsDBNull(reader["GS_COMM_PURPOSE_ID"]) ? null : (System.Decimal?)reader["GS_COMM_PURPOSE_ID"];
					c.CommOnlineStat = Convert.IsDBNull(reader["COMM_ONLINE_STAT"]) ? null : (System.Decimal?)reader["COMM_ONLINE_STAT"];
					c.DecisionImage = Convert.IsDBNull(reader["DECISION_IMAGE"]) ? null : (System.String)reader["DECISION_IMAGE"];
					c.CopyTo = Convert.IsDBNull(reader["COPY_TO"]) ? null : (System.String)reader["COPY_TO"];
					c.CommFolder = Convert.IsDBNull(reader["COMM_FOLDER"]) ? null : (System.String)reader["COMM_FOLDER"];
					c.CommCloseDate = Convert.IsDBNull(reader["COMM_CLOSE_DATE"]) ? null : (System.DateTime?)reader["COMM_CLOSE_DATE"];
					c.CommCloseFlg = (System.Decimal)reader["COMM_CLOSE_FLG"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsComm"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsComm"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsComm entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCommId = (System.Decimal)reader[((int)GsCommColumn.GsCommId - 1)];
			entity.OriginalGsCommId = (System.Decimal)reader["GS_COMM_ID"];
			entity.CommDate = (reader.IsDBNull(((int)GsCommColumn.CommDate - 1)))?null:(System.DateTime?)reader[((int)GsCommColumn.CommDate - 1)];
			entity.CommNum = (reader.IsDBNull(((int)GsCommColumn.CommNum - 1)))?null:(System.String)reader[((int)GsCommColumn.CommNum - 1)];
			entity.CommName = (reader.IsDBNull(((int)GsCommColumn.CommName - 1)))?null:(System.String)reader[((int)GsCommColumn.CommName - 1)];
			entity.CommApprovedBy = (reader.IsDBNull(((int)GsCommColumn.CommApprovedBy - 1)))?null:(System.Decimal?)reader[((int)GsCommColumn.CommApprovedBy - 1)];
			entity.EdAcadYearId = (System.Decimal)reader[((int)GsCommColumn.EdAcadYearId - 1)];
			entity.EdSemesterId = (reader.IsDBNull(((int)GsCommColumn.EdSemesterId - 1)))?null:(System.Decimal?)reader[((int)GsCommColumn.EdSemesterId - 1)];
			entity.LawNo = (reader.IsDBNull(((int)GsCommColumn.LawNo - 1)))?null:(System.Decimal?)reader[((int)GsCommColumn.LawNo - 1)];
			entity.LawYear = (reader.IsDBNull(((int)GsCommColumn.LawYear - 1)))?null:(System.Decimal?)reader[((int)GsCommColumn.LawYear - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)GsCommColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)GsCommColumn.AsFacultyInfoId - 1)];
			entity.EntMainMajorId = (reader.IsDBNull(((int)GsCommColumn.EntMainMajorId - 1)))?null:(System.Decimal?)reader[((int)GsCommColumn.EntMainMajorId - 1)];
			entity.EntMainMinorId = (reader.IsDBNull(((int)GsCommColumn.EntMainMinorId - 1)))?null:(System.Decimal?)reader[((int)GsCommColumn.EntMainMinorId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)GsCommColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)GsCommColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)GsCommColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)GsCommColumn.LastDate - 1)];
			entity.GsCommPurposeId = (reader.IsDBNull(((int)GsCommColumn.GsCommPurposeId - 1)))?null:(System.Decimal?)reader[((int)GsCommColumn.GsCommPurposeId - 1)];
			entity.CommOnlineStat = (reader.IsDBNull(((int)GsCommColumn.CommOnlineStat - 1)))?null:(System.Decimal?)reader[((int)GsCommColumn.CommOnlineStat - 1)];
			entity.DecisionImage = (reader.IsDBNull(((int)GsCommColumn.DecisionImage - 1)))?null:(System.String)reader[((int)GsCommColumn.DecisionImage - 1)];
			entity.CopyTo = (reader.IsDBNull(((int)GsCommColumn.CopyTo - 1)))?null:(System.String)reader[((int)GsCommColumn.CopyTo - 1)];
			entity.CommFolder = (reader.IsDBNull(((int)GsCommColumn.CommFolder - 1)))?null:(System.String)reader[((int)GsCommColumn.CommFolder - 1)];
			entity.CommCloseDate = (reader.IsDBNull(((int)GsCommColumn.CommCloseDate - 1)))?null:(System.DateTime?)reader[((int)GsCommColumn.CommCloseDate - 1)];
			entity.CommCloseFlg = (System.Decimal)reader[((int)GsCommColumn.CommCloseFlg - 1)];
			entity.Notes = (reader.IsDBNull(((int)GsCommColumn.Notes - 1)))?null:(System.String)reader[((int)GsCommColumn.Notes - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsComm"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsComm"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsComm entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCommId = (System.Decimal)dataRow["GS_COMM_ID"];
			entity.OriginalGsCommId = (System.Decimal)dataRow["GS_COMM_ID"];
			entity.CommDate = Convert.IsDBNull(dataRow["COMM_DATE"]) ? null : (System.DateTime?)dataRow["COMM_DATE"];
			entity.CommNum = Convert.IsDBNull(dataRow["COMM_NUM"]) ? null : (System.String)dataRow["COMM_NUM"];
			entity.CommName = Convert.IsDBNull(dataRow["COMM_NAME"]) ? null : (System.String)dataRow["COMM_NAME"];
			entity.CommApprovedBy = Convert.IsDBNull(dataRow["COMM_APPROVED_BY"]) ? null : (System.Decimal?)dataRow["COMM_APPROVED_BY"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdSemesterId = Convert.IsDBNull(dataRow["ED_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_SEMESTER_ID"];
			entity.LawNo = Convert.IsDBNull(dataRow["LAW_NO"]) ? null : (System.Decimal?)dataRow["LAW_NO"];
			entity.LawYear = Convert.IsDBNull(dataRow["LAW_YEAR"]) ? null : (System.Decimal?)dataRow["LAW_YEAR"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.EntMainMajorId = Convert.IsDBNull(dataRow["ENT_MAIN_MAJOR_ID"]) ? null : (System.Decimal?)dataRow["ENT_MAIN_MAJOR_ID"];
			entity.EntMainMinorId = Convert.IsDBNull(dataRow["ENT_MAIN_MINOR_ID"]) ? null : (System.Decimal?)dataRow["ENT_MAIN_MINOR_ID"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.GsCommPurposeId = Convert.IsDBNull(dataRow["GS_COMM_PURPOSE_ID"]) ? null : (System.Decimal?)dataRow["GS_COMM_PURPOSE_ID"];
			entity.CommOnlineStat = Convert.IsDBNull(dataRow["COMM_ONLINE_STAT"]) ? null : (System.Decimal?)dataRow["COMM_ONLINE_STAT"];
			entity.DecisionImage = Convert.IsDBNull(dataRow["DECISION_IMAGE"]) ? null : (System.String)dataRow["DECISION_IMAGE"];
			entity.CopyTo = Convert.IsDBNull(dataRow["COPY_TO"]) ? null : (System.String)dataRow["COPY_TO"];
			entity.CommFolder = Convert.IsDBNull(dataRow["COMM_FOLDER"]) ? null : (System.String)dataRow["COMM_FOLDER"];
			entity.CommCloseDate = Convert.IsDBNull(dataRow["COMM_CLOSE_DATE"]) ? null : (System.DateTime?)dataRow["COMM_CLOSE_DATE"];
			entity.CommCloseFlg = (System.Decimal)dataRow["COMM_CLOSE_FLG"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsComm"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsComm Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsComm entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region EdSemesterIdSource	
			if (CanDeepLoad(entity, "EdCodeSemester|EdSemesterIdSource", deepLoadType, innerList) 
				&& entity.EdSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdSemesterId ?? 0.0m);
				EdCodeSemester tmpEntity = EntityManager.LocateEntity<EdCodeSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdSemesterIdSource = tmpEntity;
				else
					entity.EdSemesterIdSource = DataRepository.EdCodeSemesterProvider.GetByEdCodeSemesterId(transactionManager, (entity.EdSemesterId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdSemesterIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdSemesterIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeSemesterProvider.DeepLoad(transactionManager, entity.EdSemesterIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdSemesterIdSource

			#region EntMainMajorIdSource	
			if (CanDeepLoad(entity, "EntityMain|EntMainMajorIdSource", deepLoadType, innerList) 
				&& entity.EntMainMajorIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntMainMajorId ?? 0.0m);
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntMainMajorIdSource = tmpEntity;
				else
					entity.EntMainMajorIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, (entity.EntMainMajorId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMainMajorIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntMainMajorIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntityMainProvider.DeepLoad(transactionManager, entity.EntMainMajorIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntMainMajorIdSource

			#region EntMainMinorIdSource	
			if (CanDeepLoad(entity, "EntityMain|EntMainMinorIdSource", deepLoadType, innerList) 
				&& entity.EntMainMinorIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntMainMinorId ?? 0.0m);
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntMainMinorIdSource = tmpEntity;
				else
					entity.EntMainMinorIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, (entity.EntMainMinorId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMainMinorIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntMainMinorIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntityMainProvider.DeepLoad(transactionManager, entity.EntMainMinorIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntMainMinorIdSource

			#region GsCommPurposeIdSource	
			if (CanDeepLoad(entity, "GsCommPurpose|GsCommPurposeIdSource", deepLoadType, innerList) 
				&& entity.GsCommPurposeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCommPurposeId ?? 0.0m);
				GsCommPurpose tmpEntity = EntityManager.LocateEntity<GsCommPurpose>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCommPurpose), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCommPurposeIdSource = tmpEntity;
				else
					entity.GsCommPurposeIdSource = DataRepository.GsCommPurposeProvider.GetByGsCommPurposeId(transactionManager, (entity.GsCommPurposeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCommPurposeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCommPurposeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCommPurposeProvider.DeepLoad(transactionManager, entity.GsCommPurposeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCommPurposeIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCommId methods when available
			
			#region GsCommRecomCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsCommRecom>|GsCommRecomCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCommRecomCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCommRecomCollection = DataRepository.GsCommRecomProvider.GetByGsCommId(transactionManager, entity.GsCommId);

				if (deep && entity.GsCommRecomCollection.Count > 0)
				{
					deepHandles.Add("GsCommRecomCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsCommRecom>) DataRepository.GsCommRecomProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCommRecomCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsCommDuttyCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsCommDutty>|GsCommDuttyCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCommDuttyCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCommDuttyCollection = DataRepository.GsCommDuttyProvider.GetByGsCommId(transactionManager, entity.GsCommId);

				if (deep && entity.GsCommDuttyCollection.Count > 0)
				{
					deepHandles.Add("GsCommDuttyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsCommDutty>) DataRepository.GsCommDuttyProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCommDuttyCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsCommStaffCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsCommStaff>|GsCommStaffCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCommStaffCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCommStaffCollection = DataRepository.GsCommStaffProvider.GetByGsCommId(transactionManager, entity.GsCommId);

				if (deep && entity.GsCommStaffCollection.Count > 0)
				{
					deepHandles.Add("GsCommStaffCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsCommStaff>) DataRepository.GsCommStaffProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCommStaffCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsComm object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsComm instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsComm Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsComm entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdSemesterIdSource
			if (CanDeepSave(entity, "EdCodeSemester|EdSemesterIdSource", deepSaveType, innerList) 
				&& entity.EdSemesterIdSource != null)
			{
				DataRepository.EdCodeSemesterProvider.Save(transactionManager, entity.EdSemesterIdSource);
				entity.EdSemesterId = entity.EdSemesterIdSource.EdCodeSemesterId;
			}
			#endregion 
			
			#region EntMainMajorIdSource
			if (CanDeepSave(entity, "EntityMain|EntMainMajorIdSource", deepSaveType, innerList) 
				&& entity.EntMainMajorIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.EntMainMajorIdSource);
				entity.EntMainMajorId = entity.EntMainMajorIdSource.EntMainId;
			}
			#endregion 
			
			#region EntMainMinorIdSource
			if (CanDeepSave(entity, "EntityMain|EntMainMinorIdSource", deepSaveType, innerList) 
				&& entity.EntMainMinorIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.EntMainMinorIdSource);
				entity.EntMainMinorId = entity.EntMainMinorIdSource.EntMainId;
			}
			#endregion 
			
			#region GsCommPurposeIdSource
			if (CanDeepSave(entity, "GsCommPurpose|GsCommPurposeIdSource", deepSaveType, innerList) 
				&& entity.GsCommPurposeIdSource != null)
			{
				DataRepository.GsCommPurposeProvider.Save(transactionManager, entity.GsCommPurposeIdSource);
				entity.GsCommPurposeId = entity.GsCommPurposeIdSource.GsCommPurposeId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<GsCommRecom>
				if (CanDeepSave(entity.GsCommRecomCollection, "List<GsCommRecom>|GsCommRecomCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsCommRecom child in entity.GsCommRecomCollection)
					{
						if(child.GsCommIdSource != null)
						{
							child.GsCommId = child.GsCommIdSource.GsCommId;
						}
						else
						{
							child.GsCommId = entity.GsCommId;
						}

					}

					if (entity.GsCommRecomCollection.Count > 0 || entity.GsCommRecomCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCommRecomProvider.Save(transactionManager, entity.GsCommRecomCollection);
						
						deepHandles.Add("GsCommRecomCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsCommRecom >) DataRepository.GsCommRecomProvider.DeepSave,
							new object[] { transactionManager, entity.GsCommRecomCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GsCommDutty>
				if (CanDeepSave(entity.GsCommDuttyCollection, "List<GsCommDutty>|GsCommDuttyCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsCommDutty child in entity.GsCommDuttyCollection)
					{
						if(child.GsCommIdSource != null)
						{
							child.GsCommId = child.GsCommIdSource.GsCommId;
						}
						else
						{
							child.GsCommId = entity.GsCommId;
						}

					}

					if (entity.GsCommDuttyCollection.Count > 0 || entity.GsCommDuttyCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCommDuttyProvider.Save(transactionManager, entity.GsCommDuttyCollection);
						
						deepHandles.Add("GsCommDuttyCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsCommDutty >) DataRepository.GsCommDuttyProvider.DeepSave,
							new object[] { transactionManager, entity.GsCommDuttyCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GsCommStaff>
				if (CanDeepSave(entity.GsCommStaffCollection, "List<GsCommStaff>|GsCommStaffCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsCommStaff child in entity.GsCommStaffCollection)
					{
						if(child.GsCommIdSource != null)
						{
							child.GsCommId = child.GsCommIdSource.GsCommId;
						}
						else
						{
							child.GsCommId = entity.GsCommId;
						}

					}

					if (entity.GsCommStaffCollection.Count > 0 || entity.GsCommStaffCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCommStaffProvider.Save(transactionManager, entity.GsCommStaffCollection);
						
						deepHandles.Add("GsCommStaffCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsCommStaff >) DataRepository.GsCommStaffProvider.DeepSave,
							new object[] { transactionManager, entity.GsCommStaffCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsCommChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsComm</c>
	///</summary>
	public enum GsCommChildEntityTypes
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
		/// Composite Property for <c>EdCodeSemester</c> at EdSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemester))]
		EdCodeSemester,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainMajorIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		
		///<summary>
		/// Composite Property for <c>GsCommPurpose</c> at GsCommPurposeIdSource
		///</summary>
		[ChildEntityType(typeof(GsCommPurpose))]
		GsCommPurpose,
		///<summary>
		/// Collection of <c>GsComm</c> as OneToMany for GsCommRecomCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsCommRecom>))]
		GsCommRecomCollection,
		///<summary>
		/// Collection of <c>GsComm</c> as OneToMany for GsCommDuttyCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsCommDutty>))]
		GsCommDuttyCollection,
		///<summary>
		/// Collection of <c>GsComm</c> as OneToMany for GsCommStaffCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsCommStaff>))]
		GsCommStaffCollection,
	}
	
	#endregion GsCommChildEntityTypes
	
	#region GsCommFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCommColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsComm"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCommFilterBuilder : SqlFilterBuilder<GsCommColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCommFilterBuilder class.
		/// </summary>
		public GsCommFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCommFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCommFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCommFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCommFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCommFilterBuilder
	
	#region GsCommParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCommColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsComm"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCommParameterBuilder : ParameterizedSqlFilterBuilder<GsCommColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCommParameterBuilder class.
		/// </summary>
		public GsCommParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCommParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCommParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCommParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCommParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCommParameterBuilder
	
	#region GsCommSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCommColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsComm"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCommSortBuilder : SqlSortBuilder<GsCommColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCommSqlSortBuilder class.
		/// </summary>
		public GsCommSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCommSortBuilder
	
} // end namespace
