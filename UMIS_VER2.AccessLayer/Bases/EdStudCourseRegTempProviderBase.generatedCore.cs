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
	/// This class is the base class for any <see cref="EdStudCourseRegTempProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudCourseRegTempProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudCourseRegTemp, UMIS_VER2.BusinessLyer.EdStudCourseRegTempKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseRegTempKey key)
		{
			return Delete(transactionManager, key.EdStudCourseRegTempId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudCourseRegTempId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudCourseRegTempId)
		{
			return Delete(null, _edStudCourseRegTempId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegTempId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudCourseRegTempId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_TEMP_ED_CODE_COURSE_STATUS key.
		///		FK_ED_STUD_COURSE_REG_TEMP_ED_CODE_COURSE_STATUS Description: 
		/// </summary>
		/// <param name="_edCodeCourseStatusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		public TList<EdStudCourseRegTemp> GetByEdCodeCourseStatusId(System.Decimal? _edCodeCourseStatusId)
		{
			int count = -1;
			return GetByEdCodeCourseStatusId(_edCodeCourseStatusId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_TEMP_ED_CODE_COURSE_STATUS key.
		///		FK_ED_STUD_COURSE_REG_TEMP_ED_CODE_COURSE_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseStatusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseRegTemp> GetByEdCodeCourseStatusId(TransactionManager transactionManager, System.Decimal? _edCodeCourseStatusId)
		{
			int count = -1;
			return GetByEdCodeCourseStatusId(transactionManager, _edCodeCourseStatusId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_TEMP_ED_CODE_COURSE_STATUS key.
		///		FK_ED_STUD_COURSE_REG_TEMP_ED_CODE_COURSE_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		public TList<EdStudCourseRegTemp> GetByEdCodeCourseStatusId(TransactionManager transactionManager, System.Decimal? _edCodeCourseStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseStatusId(transactionManager, _edCodeCourseStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_TEMP_ED_CODE_COURSE_STATUS key.
		///		fkEdStudCourseRegTempEdCodeCourseStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		public TList<EdStudCourseRegTemp> GetByEdCodeCourseStatusId(System.Decimal? _edCodeCourseStatusId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeCourseStatusId(null, _edCodeCourseStatusId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_TEMP_ED_CODE_COURSE_STATUS key.
		///		fkEdStudCourseRegTempEdCodeCourseStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseStatusId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		public TList<EdStudCourseRegTemp> GetByEdCodeCourseStatusId(System.Decimal? _edCodeCourseStatusId, int start, int pageLength,out int count)
		{
			return GetByEdCodeCourseStatusId(null, _edCodeCourseStatusId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_TEMP_ED_CODE_COURSE_STATUS key.
		///		FK_ED_STUD_COURSE_REG_TEMP_ED_CODE_COURSE_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		public abstract TList<EdStudCourseRegTemp> GetByEdCodeCourseStatusId(TransactionManager transactionManager, System.Decimal? _edCodeCourseStatusId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_TEMP_ED_CODE_GRADING key.
		///		FK_ED_STUD_COURSE_REG_TEMP_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="_edCodeGradingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		public TList<EdStudCourseRegTemp> GetByEdCodeGradingId(System.Decimal? _edCodeGradingId)
		{
			int count = -1;
			return GetByEdCodeGradingId(_edCodeGradingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_TEMP_ED_CODE_GRADING key.
		///		FK_ED_STUD_COURSE_REG_TEMP_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseRegTemp> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _edCodeGradingId)
		{
			int count = -1;
			return GetByEdCodeGradingId(transactionManager, _edCodeGradingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_TEMP_ED_CODE_GRADING key.
		///		FK_ED_STUD_COURSE_REG_TEMP_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		public TList<EdStudCourseRegTemp> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _edCodeGradingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeGradingId(transactionManager, _edCodeGradingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_TEMP_ED_CODE_GRADING key.
		///		fkEdStudCourseRegTempEdCodeGrading Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeGradingId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		public TList<EdStudCourseRegTemp> GetByEdCodeGradingId(System.Decimal? _edCodeGradingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeGradingId(null, _edCodeGradingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_TEMP_ED_CODE_GRADING key.
		///		fkEdStudCourseRegTempEdCodeGrading Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeGradingId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		public TList<EdStudCourseRegTemp> GetByEdCodeGradingId(System.Decimal? _edCodeGradingId, int start, int pageLength,out int count)
		{
			return GetByEdCodeGradingId(null, _edCodeGradingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_TEMP_ED_CODE_GRADING key.
		///		FK_ED_STUD_COURSE_REG_TEMP_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		public abstract TList<EdStudCourseRegTemp> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _edCodeGradingId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_TEMP_ED_STUD_SEMESTER key.
		///		FK_ED_STUD_COURSE_REG_TEMP_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		public TList<EdStudCourseRegTemp> GetByEdStudSemesterId(System.Decimal? _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(_edStudSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_TEMP_ED_STUD_SEMESTER key.
		///		FK_ED_STUD_COURSE_REG_TEMP_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseRegTemp> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal? _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_TEMP_ED_STUD_SEMESTER key.
		///		FK_ED_STUD_COURSE_REG_TEMP_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		public TList<EdStudCourseRegTemp> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal? _edStudSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_TEMP_ED_STUD_SEMESTER key.
		///		fkEdStudCourseRegTempEdStudSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		public TList<EdStudCourseRegTemp> GetByEdStudSemesterId(System.Decimal? _edStudSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_TEMP_ED_STUD_SEMESTER key.
		///		fkEdStudCourseRegTempEdStudSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		public TList<EdStudCourseRegTemp> GetByEdStudSemesterId(System.Decimal? _edStudSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_TEMP_ED_STUD_SEMESTER key.
		///		FK_ED_STUD_COURSE_REG_TEMP_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		public abstract TList<EdStudCourseRegTemp> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal? _edStudSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_TEMP_ENT_POLICY_ASSESS_HDR key.
		///		FK_ED_STUD_COURSE_REG_TEMP_ENT_POLICY_ASSESS_HDR Description: 
		/// </summary>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		public TList<EdStudCourseRegTemp> GetByEntPolicyAssessHdrId(System.Decimal? _entPolicyAssessHdrId)
		{
			int count = -1;
			return GetByEntPolicyAssessHdrId(_entPolicyAssessHdrId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_TEMP_ENT_POLICY_ASSESS_HDR key.
		///		FK_ED_STUD_COURSE_REG_TEMP_ENT_POLICY_ASSESS_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseRegTemp> GetByEntPolicyAssessHdrId(TransactionManager transactionManager, System.Decimal? _entPolicyAssessHdrId)
		{
			int count = -1;
			return GetByEntPolicyAssessHdrId(transactionManager, _entPolicyAssessHdrId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_TEMP_ENT_POLICY_ASSESS_HDR key.
		///		FK_ED_STUD_COURSE_REG_TEMP_ENT_POLICY_ASSESS_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		public TList<EdStudCourseRegTemp> GetByEntPolicyAssessHdrId(TransactionManager transactionManager, System.Decimal? _entPolicyAssessHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyAssessHdrId(transactionManager, _entPolicyAssessHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_TEMP_ENT_POLICY_ASSESS_HDR key.
		///		fkEdStudCourseRegTempEntPolicyAssessHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		public TList<EdStudCourseRegTemp> GetByEntPolicyAssessHdrId(System.Decimal? _entPolicyAssessHdrId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntPolicyAssessHdrId(null, _entPolicyAssessHdrId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_TEMP_ENT_POLICY_ASSESS_HDR key.
		///		fkEdStudCourseRegTempEntPolicyAssessHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		public TList<EdStudCourseRegTemp> GetByEntPolicyAssessHdrId(System.Decimal? _entPolicyAssessHdrId, int start, int pageLength,out int count)
		{
			return GetByEntPolicyAssessHdrId(null, _entPolicyAssessHdrId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_TEMP_ENT_POLICY_ASSESS_HDR key.
		///		FK_ED_STUD_COURSE_REG_TEMP_ENT_POLICY_ASSESS_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		public abstract TList<EdStudCourseRegTemp> GetByEntPolicyAssessHdrId(TransactionManager transactionManager, System.Decimal? _entPolicyAssessHdrId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_TEMP_ENT_POLICY_GRADING_HDR key.
		///		FK_ED_STUD_COURSE_REG_TEMP_ENT_POLICY_GRADING_HDR Description: 
		/// </summary>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		public TList<EdStudCourseRegTemp> GetByEntPolicyGradingHdrId(System.Decimal? _entPolicyGradingHdrId)
		{
			int count = -1;
			return GetByEntPolicyGradingHdrId(_entPolicyGradingHdrId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_TEMP_ENT_POLICY_GRADING_HDR key.
		///		FK_ED_STUD_COURSE_REG_TEMP_ENT_POLICY_GRADING_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseRegTemp> GetByEntPolicyGradingHdrId(TransactionManager transactionManager, System.Decimal? _entPolicyGradingHdrId)
		{
			int count = -1;
			return GetByEntPolicyGradingHdrId(transactionManager, _entPolicyGradingHdrId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_TEMP_ENT_POLICY_GRADING_HDR key.
		///		FK_ED_STUD_COURSE_REG_TEMP_ENT_POLICY_GRADING_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		public TList<EdStudCourseRegTemp> GetByEntPolicyGradingHdrId(TransactionManager transactionManager, System.Decimal? _entPolicyGradingHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyGradingHdrId(transactionManager, _entPolicyGradingHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_TEMP_ENT_POLICY_GRADING_HDR key.
		///		fkEdStudCourseRegTempEntPolicyGradingHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		public TList<EdStudCourseRegTemp> GetByEntPolicyGradingHdrId(System.Decimal? _entPolicyGradingHdrId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntPolicyGradingHdrId(null, _entPolicyGradingHdrId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_TEMP_ENT_POLICY_GRADING_HDR key.
		///		fkEdStudCourseRegTempEntPolicyGradingHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		public TList<EdStudCourseRegTemp> GetByEntPolicyGradingHdrId(System.Decimal? _entPolicyGradingHdrId, int start, int pageLength,out int count)
		{
			return GetByEntPolicyGradingHdrId(null, _entPolicyGradingHdrId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_TEMP_ENT_POLICY_GRADING_HDR key.
		///		FK_ED_STUD_COURSE_REG_TEMP_ENT_POLICY_GRADING_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		public abstract TList<EdStudCourseRegTemp> GetByEntPolicyGradingHdrId(TransactionManager transactionManager, System.Decimal? _entPolicyGradingHdrId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_TEMP_GS_CODE_PASS_FAIL key.
		///		FK_ED_STUD_COURSE_REG_TEMP_GS_CODE_PASS_FAIL Description: 
		/// </summary>
		/// <param name="_gsCodePassFailId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		public TList<EdStudCourseRegTemp> GetByGsCodePassFailId(System.Decimal? _gsCodePassFailId)
		{
			int count = -1;
			return GetByGsCodePassFailId(_gsCodePassFailId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_TEMP_GS_CODE_PASS_FAIL key.
		///		FK_ED_STUD_COURSE_REG_TEMP_GS_CODE_PASS_FAIL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseRegTemp> GetByGsCodePassFailId(TransactionManager transactionManager, System.Decimal? _gsCodePassFailId)
		{
			int count = -1;
			return GetByGsCodePassFailId(transactionManager, _gsCodePassFailId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_TEMP_GS_CODE_PASS_FAIL key.
		///		FK_ED_STUD_COURSE_REG_TEMP_GS_CODE_PASS_FAIL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		public TList<EdStudCourseRegTemp> GetByGsCodePassFailId(TransactionManager transactionManager, System.Decimal? _gsCodePassFailId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodePassFailId(transactionManager, _gsCodePassFailId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_TEMP_GS_CODE_PASS_FAIL key.
		///		fkEdStudCourseRegTempGsCodePassFail Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		public TList<EdStudCourseRegTemp> GetByGsCodePassFailId(System.Decimal? _gsCodePassFailId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodePassFailId(null, _gsCodePassFailId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_TEMP_GS_CODE_PASS_FAIL key.
		///		fkEdStudCourseRegTempGsCodePassFail Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		public TList<EdStudCourseRegTemp> GetByGsCodePassFailId(System.Decimal? _gsCodePassFailId, int start, int pageLength,out int count)
		{
			return GetByGsCodePassFailId(null, _gsCodePassFailId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_TEMP_GS_CODE_PASS_FAIL key.
		///		FK_ED_STUD_COURSE_REG_TEMP_GS_CODE_PASS_FAIL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		public abstract TList<EdStudCourseRegTemp> GetByGsCodePassFailId(TransactionManager transactionManager, System.Decimal? _gsCodePassFailId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_STUD_COURSE_REG_TMP_ED_COURSE key.
		///		FK_STUD_COURSE_REG_TMP_ED_COURSE Description: 
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		public TList<EdStudCourseRegTemp> GetByEdCourseId(System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(_edCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_STUD_COURSE_REG_TMP_ED_COURSE key.
		///		FK_STUD_COURSE_REG_TMP_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseRegTemp> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_STUD_COURSE_REG_TMP_ED_COURSE key.
		///		FK_STUD_COURSE_REG_TMP_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		public TList<EdStudCourseRegTemp> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_STUD_COURSE_REG_TMP_ED_COURSE key.
		///		fkStudCourseRegTmpEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		public TList<EdStudCourseRegTemp> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_STUD_COURSE_REG_TMP_ED_COURSE key.
		///		fkStudCourseRegTmpEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		public TList<EdStudCourseRegTemp> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength,out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_STUD_COURSE_REG_TMP_ED_COURSE key.
		///		FK_STUD_COURSE_REG_TMP_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegTemp objects.</returns>
		public abstract TList<EdStudCourseRegTemp> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudCourseRegTemp Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseRegTempKey key, int start, int pageLength)
		{
			return GetByEdStudCourseRegTempId(transactionManager, key.EdStudCourseRegTempId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_STUD_COURSE_REG_TEMP index.
		/// </summary>
		/// <param name="_edStudCourseRegTempId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegTemp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRegTemp GetByEdStudCourseRegTempId(System.Decimal _edStudCourseRegTempId)
		{
			int count = -1;
			return GetByEdStudCourseRegTempId(null,_edStudCourseRegTempId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_STUD_COURSE_REG_TEMP index.
		/// </summary>
		/// <param name="_edStudCourseRegTempId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegTemp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRegTemp GetByEdStudCourseRegTempId(System.Decimal _edStudCourseRegTempId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseRegTempId(null, _edStudCourseRegTempId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_STUD_COURSE_REG_TEMP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegTempId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegTemp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRegTemp GetByEdStudCourseRegTempId(TransactionManager transactionManager, System.Decimal _edStudCourseRegTempId)
		{
			int count = -1;
			return GetByEdStudCourseRegTempId(transactionManager, _edStudCourseRegTempId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_STUD_COURSE_REG_TEMP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegTempId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegTemp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRegTemp GetByEdStudCourseRegTempId(TransactionManager transactionManager, System.Decimal _edStudCourseRegTempId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseRegTempId(transactionManager, _edStudCourseRegTempId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_STUD_COURSE_REG_TEMP index.
		/// </summary>
		/// <param name="_edStudCourseRegTempId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegTemp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRegTemp GetByEdStudCourseRegTempId(System.Decimal _edStudCourseRegTempId, int start, int pageLength, out int count)
		{
			return GetByEdStudCourseRegTempId(null, _edStudCourseRegTempId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_STUD_COURSE_REG_TEMP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegTempId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegTemp"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudCourseRegTemp GetByEdStudCourseRegTempId(TransactionManager transactionManager, System.Decimal _edStudCourseRegTempId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudCourseRegTemp&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudCourseRegTemp&gt;"/></returns>
		public static TList<EdStudCourseRegTemp> Fill(IDataReader reader, TList<EdStudCourseRegTemp> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudCourseRegTemp c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudCourseRegTemp")
					.Append("|").Append((System.Decimal)reader["ED_STUD_COURSE_REG_TEMP_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudCourseRegTemp>(
					key.ToString(), // EntityTrackingKey
					"EdStudCourseRegTemp",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudCourseRegTemp();
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
					c.EdStudCourseRegTempId = (System.Decimal)reader["ED_STUD_COURSE_REG_TEMP_ID"];
					c.OriginalEdStudCourseRegTempId = c.EdStudCourseRegTempId;
					c.EdCourseId = (System.Decimal)reader["ED_COURSE_ID"];
					c.RegDate = Convert.IsDBNull(reader["REG_DATE"]) ? null : (System.DateTime?)reader["REG_DATE"];
					c.AuditFlg = (System.Decimal)reader["AUDIT_FLG"];
					c.RepeatFlg = (System.Decimal)reader["REPEAT_FLG"];
					c.IsLast = (System.Decimal)reader["IS_LAST"];
					c.IsApproved = (System.Decimal)reader["IS_APPROVED"];
					c.ApproveDate = Convert.IsDBNull(reader["APPROVE_DATE"]) ? null : (System.DateTime?)reader["APPROVE_DATE"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.EdCodeCourseStatusId = Convert.IsDBNull(reader["ED_CODE_COURSE_STATUS_ID"]) ? null : (System.Decimal?)reader["ED_CODE_COURSE_STATUS_ID"];
					c.EdCodeGradingId = Convert.IsDBNull(reader["ED_CODE_GRADING_ID"]) ? null : (System.Decimal?)reader["ED_CODE_GRADING_ID"];
					c.CourseDegree = Convert.IsDBNull(reader["COURSE_DEGREE"]) ? null : (System.Decimal?)reader["COURSE_DEGREE"];
					c.CoursePoint = Convert.IsDBNull(reader["COURSE_POINT"]) ? null : (System.Decimal?)reader["COURSE_POINT"];
					c.EntPolicyGradingHdrId = Convert.IsDBNull(reader["ENT_POLICY_GRADING_HDR_ID"]) ? null : (System.Decimal?)reader["ENT_POLICY_GRADING_HDR_ID"];
					c.GsCodePassFailId = Convert.IsDBNull(reader["GS_CODE_PASS_FAIL_ID"]) ? null : (System.Decimal?)reader["GS_CODE_PASS_FAIL_ID"];
					c.EdStudSemesterId = Convert.IsDBNull(reader["ED_STUD_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_STUD_SEMESTER_ID"];
					c.AddGpaFlg = (System.Decimal)reader["ADD_GPA_FLG"];
					c.EntPolicyAssessHdrId = Convert.IsDBNull(reader["ENT_POLICY_ASSESS_HDR_ID"]) ? null : (System.Decimal?)reader["ENT_POLICY_ASSESS_HDR_ID"];
					c.IncompFlg = (System.Decimal)reader["INCOMP_FLG"];
					c.HideFlg = (System.Decimal)reader["HIDE_FLG"];
					c.HideReason = Convert.IsDBNull(reader["HIDE_REASON"]) ? null : (System.String)reader["HIDE_REASON"];
					c.EdCourseSubId = Convert.IsDBNull(reader["ED_COURSE_SUB_ID"]) ? null : (System.Decimal?)reader["ED_COURSE_SUB_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.SeFormId = Convert.IsDBNull(reader["SE_FORM_ID"]) ? null : (System.Decimal?)reader["SE_FORM_ID"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.EdAcadYearId = Convert.IsDBNull(reader["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_ID"];
					c.EdStudId = Convert.IsDBNull(reader["ED_STUD_ID"]) ? null : (System.Decimal?)reader["ED_STUD_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegTemp"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegTemp"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudCourseRegTemp entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudCourseRegTempId = (System.Decimal)reader[((int)EdStudCourseRegTempColumn.EdStudCourseRegTempId - 1)];
			entity.OriginalEdStudCourseRegTempId = (System.Decimal)reader["ED_STUD_COURSE_REG_TEMP_ID"];
			entity.EdCourseId = (System.Decimal)reader[((int)EdStudCourseRegTempColumn.EdCourseId - 1)];
			entity.RegDate = (reader.IsDBNull(((int)EdStudCourseRegTempColumn.RegDate - 1)))?null:(System.DateTime?)reader[((int)EdStudCourseRegTempColumn.RegDate - 1)];
			entity.AuditFlg = (System.Decimal)reader[((int)EdStudCourseRegTempColumn.AuditFlg - 1)];
			entity.RepeatFlg = (System.Decimal)reader[((int)EdStudCourseRegTempColumn.RepeatFlg - 1)];
			entity.IsLast = (System.Decimal)reader[((int)EdStudCourseRegTempColumn.IsLast - 1)];
			entity.IsApproved = (System.Decimal)reader[((int)EdStudCourseRegTempColumn.IsApproved - 1)];
			entity.ApproveDate = (reader.IsDBNull(((int)EdStudCourseRegTempColumn.ApproveDate - 1)))?null:(System.DateTime?)reader[((int)EdStudCourseRegTempColumn.ApproveDate - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)EdStudCourseRegTempColumn.AsFacultyInfoId - 1)];
			entity.EdCodeCourseStatusId = (reader.IsDBNull(((int)EdStudCourseRegTempColumn.EdCodeCourseStatusId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegTempColumn.EdCodeCourseStatusId - 1)];
			entity.EdCodeGradingId = (reader.IsDBNull(((int)EdStudCourseRegTempColumn.EdCodeGradingId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegTempColumn.EdCodeGradingId - 1)];
			entity.CourseDegree = (reader.IsDBNull(((int)EdStudCourseRegTempColumn.CourseDegree - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegTempColumn.CourseDegree - 1)];
			entity.CoursePoint = (reader.IsDBNull(((int)EdStudCourseRegTempColumn.CoursePoint - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegTempColumn.CoursePoint - 1)];
			entity.EntPolicyGradingHdrId = (reader.IsDBNull(((int)EdStudCourseRegTempColumn.EntPolicyGradingHdrId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegTempColumn.EntPolicyGradingHdrId - 1)];
			entity.GsCodePassFailId = (reader.IsDBNull(((int)EdStudCourseRegTempColumn.GsCodePassFailId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegTempColumn.GsCodePassFailId - 1)];
			entity.EdStudSemesterId = (reader.IsDBNull(((int)EdStudCourseRegTempColumn.EdStudSemesterId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegTempColumn.EdStudSemesterId - 1)];
			entity.AddGpaFlg = (System.Decimal)reader[((int)EdStudCourseRegTempColumn.AddGpaFlg - 1)];
			entity.EntPolicyAssessHdrId = (reader.IsDBNull(((int)EdStudCourseRegTempColumn.EntPolicyAssessHdrId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegTempColumn.EntPolicyAssessHdrId - 1)];
			entity.IncompFlg = (System.Decimal)reader[((int)EdStudCourseRegTempColumn.IncompFlg - 1)];
			entity.HideFlg = (System.Decimal)reader[((int)EdStudCourseRegTempColumn.HideFlg - 1)];
			entity.HideReason = (reader.IsDBNull(((int)EdStudCourseRegTempColumn.HideReason - 1)))?null:(System.String)reader[((int)EdStudCourseRegTempColumn.HideReason - 1)];
			entity.EdCourseSubId = (reader.IsDBNull(((int)EdStudCourseRegTempColumn.EdCourseSubId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegTempColumn.EdCourseSubId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EdStudCourseRegTempColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EdStudCourseRegTempColumn.LastDate - 1)];
			entity.SeFormId = (reader.IsDBNull(((int)EdStudCourseRegTempColumn.SeFormId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegTempColumn.SeFormId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EdStudCourseRegTempColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegTempColumn.SeUserId - 1)];
			entity.EdAcadYearId = (reader.IsDBNull(((int)EdStudCourseRegTempColumn.EdAcadYearId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegTempColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (reader.IsDBNull(((int)EdStudCourseRegTempColumn.EdCodeSemesterId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegTempColumn.EdCodeSemesterId - 1)];
			entity.EdStudId = (reader.IsDBNull(((int)EdStudCourseRegTempColumn.EdStudId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegTempColumn.EdStudId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegTemp"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegTemp"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudCourseRegTemp entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudCourseRegTempId = (System.Decimal)dataRow["ED_STUD_COURSE_REG_TEMP_ID"];
			entity.OriginalEdStudCourseRegTempId = (System.Decimal)dataRow["ED_STUD_COURSE_REG_TEMP_ID"];
			entity.EdCourseId = (System.Decimal)dataRow["ED_COURSE_ID"];
			entity.RegDate = Convert.IsDBNull(dataRow["REG_DATE"]) ? null : (System.DateTime?)dataRow["REG_DATE"];
			entity.AuditFlg = (System.Decimal)dataRow["AUDIT_FLG"];
			entity.RepeatFlg = (System.Decimal)dataRow["REPEAT_FLG"];
			entity.IsLast = (System.Decimal)dataRow["IS_LAST"];
			entity.IsApproved = (System.Decimal)dataRow["IS_APPROVED"];
			entity.ApproveDate = Convert.IsDBNull(dataRow["APPROVE_DATE"]) ? null : (System.DateTime?)dataRow["APPROVE_DATE"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
			entity.EdCodeCourseStatusId = Convert.IsDBNull(dataRow["ED_CODE_COURSE_STATUS_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_COURSE_STATUS_ID"];
			entity.EdCodeGradingId = Convert.IsDBNull(dataRow["ED_CODE_GRADING_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_GRADING_ID"];
			entity.CourseDegree = Convert.IsDBNull(dataRow["COURSE_DEGREE"]) ? null : (System.Decimal?)dataRow["COURSE_DEGREE"];
			entity.CoursePoint = Convert.IsDBNull(dataRow["COURSE_POINT"]) ? null : (System.Decimal?)dataRow["COURSE_POINT"];
			entity.EntPolicyGradingHdrId = Convert.IsDBNull(dataRow["ENT_POLICY_GRADING_HDR_ID"]) ? null : (System.Decimal?)dataRow["ENT_POLICY_GRADING_HDR_ID"];
			entity.GsCodePassFailId = Convert.IsDBNull(dataRow["GS_CODE_PASS_FAIL_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_PASS_FAIL_ID"];
			entity.EdStudSemesterId = Convert.IsDBNull(dataRow["ED_STUD_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_SEMESTER_ID"];
			entity.AddGpaFlg = (System.Decimal)dataRow["ADD_GPA_FLG"];
			entity.EntPolicyAssessHdrId = Convert.IsDBNull(dataRow["ENT_POLICY_ASSESS_HDR_ID"]) ? null : (System.Decimal?)dataRow["ENT_POLICY_ASSESS_HDR_ID"];
			entity.IncompFlg = (System.Decimal)dataRow["INCOMP_FLG"];
			entity.HideFlg = (System.Decimal)dataRow["HIDE_FLG"];
			entity.HideReason = Convert.IsDBNull(dataRow["HIDE_REASON"]) ? null : (System.String)dataRow["HIDE_REASON"];
			entity.EdCourseSubId = Convert.IsDBNull(dataRow["ED_COURSE_SUB_ID"]) ? null : (System.Decimal?)dataRow["ED_COURSE_SUB_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.SeFormId = Convert.IsDBNull(dataRow["SE_FORM_ID"]) ? null : (System.Decimal?)dataRow["SE_FORM_ID"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.EdAcadYearId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_ID"];
			entity.EdStudId = Convert.IsDBNull(dataRow["ED_STUD_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegTemp"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudCourseRegTemp Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseRegTemp entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCodeCourseStatusIdSource	
			if (CanDeepLoad(entity, "EdCodeCourseStatus|EdCodeCourseStatusIdSource", deepLoadType, innerList) 
				&& entity.EdCodeCourseStatusIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeCourseStatusId ?? 0.0m);
				EdCodeCourseStatus tmpEntity = EntityManager.LocateEntity<EdCodeCourseStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeCourseStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeCourseStatusIdSource = tmpEntity;
				else
					entity.EdCodeCourseStatusIdSource = DataRepository.EdCodeCourseStatusProvider.GetByEdCodeCourseStatusId(transactionManager, (entity.EdCodeCourseStatusId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeCourseStatusIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeCourseStatusIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeCourseStatusProvider.DeepLoad(transactionManager, entity.EdCodeCourseStatusIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeCourseStatusIdSource

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

			#region EdStudSemesterIdSource	
			if (CanDeepLoad(entity, "EdStudSemester|EdStudSemesterIdSource", deepLoadType, innerList) 
				&& entity.EdStudSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdStudSemesterId ?? 0.0m);
				EdStudSemester tmpEntity = EntityManager.LocateEntity<EdStudSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudSemesterIdSource = tmpEntity;
				else
					entity.EdStudSemesterIdSource = DataRepository.EdStudSemesterProvider.GetByEdStudSemesterId(transactionManager, (entity.EdStudSemesterId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudSemesterIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudSemesterIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudSemesterProvider.DeepLoad(transactionManager, entity.EdStudSemesterIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudSemesterIdSource

			#region EntPolicyAssessHdrIdSource	
			if (CanDeepLoad(entity, "EntPolicyAssessHdr|EntPolicyAssessHdrIdSource", deepLoadType, innerList) 
				&& entity.EntPolicyAssessHdrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntPolicyAssessHdrId ?? 0.0m);
				EntPolicyAssessHdr tmpEntity = EntityManager.LocateEntity<EntPolicyAssessHdr>(EntityLocator.ConstructKeyFromPkItems(typeof(EntPolicyAssessHdr), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntPolicyAssessHdrIdSource = tmpEntity;
				else
					entity.EntPolicyAssessHdrIdSource = DataRepository.EntPolicyAssessHdrProvider.GetByEntPolicyAssessHdrId(transactionManager, (entity.EntPolicyAssessHdrId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyAssessHdrIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntPolicyAssessHdrIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntPolicyAssessHdrProvider.DeepLoad(transactionManager, entity.EntPolicyAssessHdrIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntPolicyAssessHdrIdSource

			#region EntPolicyGradingHdrIdSource	
			if (CanDeepLoad(entity, "EntPolicyGradingHdr|EntPolicyGradingHdrIdSource", deepLoadType, innerList) 
				&& entity.EntPolicyGradingHdrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntPolicyGradingHdrId ?? 0.0m);
				EntPolicyGradingHdr tmpEntity = EntityManager.LocateEntity<EntPolicyGradingHdr>(EntityLocator.ConstructKeyFromPkItems(typeof(EntPolicyGradingHdr), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntPolicyGradingHdrIdSource = tmpEntity;
				else
					entity.EntPolicyGradingHdrIdSource = DataRepository.EntPolicyGradingHdrProvider.GetByEntPolicyGradingHdrId(transactionManager, (entity.EntPolicyGradingHdrId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyGradingHdrIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntPolicyGradingHdrIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntPolicyGradingHdrProvider.DeepLoad(transactionManager, entity.EntPolicyGradingHdrIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntPolicyGradingHdrIdSource

			#region GsCodePassFailIdSource	
			if (CanDeepLoad(entity, "GsCodePassFail|GsCodePassFailIdSource", deepLoadType, innerList) 
				&& entity.GsCodePassFailIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodePassFailId ?? 0.0m);
				GsCodePassFail tmpEntity = EntityManager.LocateEntity<GsCodePassFail>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodePassFail), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodePassFailIdSource = tmpEntity;
				else
					entity.GsCodePassFailIdSource = DataRepository.GsCodePassFailProvider.GetByGsCodePassFailId(transactionManager, (entity.GsCodePassFailId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodePassFailIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodePassFailIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodePassFailProvider.DeepLoad(transactionManager, entity.GsCodePassFailIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodePassFailIdSource

			#region EdCourseIdSource	
			if (CanDeepLoad(entity, "EdCourse|EdCourseIdSource", deepLoadType, innerList) 
				&& entity.EdCourseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCourseId;
				EdCourse tmpEntity = EntityManager.LocateEntity<EdCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseIdSource = tmpEntity;
				else
					entity.EdCourseIdSource = DataRepository.EdCourseProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);		
				
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudCourseRegTemp object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudCourseRegTemp instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudCourseRegTemp Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseRegTemp entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCodeCourseStatusIdSource
			if (CanDeepSave(entity, "EdCodeCourseStatus|EdCodeCourseStatusIdSource", deepSaveType, innerList) 
				&& entity.EdCodeCourseStatusIdSource != null)
			{
				DataRepository.EdCodeCourseStatusProvider.Save(transactionManager, entity.EdCodeCourseStatusIdSource);
				entity.EdCodeCourseStatusId = entity.EdCodeCourseStatusIdSource.EdCodeCourseStatusId;
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
			
			#region EdStudSemesterIdSource
			if (CanDeepSave(entity, "EdStudSemester|EdStudSemesterIdSource", deepSaveType, innerList) 
				&& entity.EdStudSemesterIdSource != null)
			{
				DataRepository.EdStudSemesterProvider.Save(transactionManager, entity.EdStudSemesterIdSource);
				entity.EdStudSemesterId = entity.EdStudSemesterIdSource.EdStudSemesterId;
			}
			#endregion 
			
			#region EntPolicyAssessHdrIdSource
			if (CanDeepSave(entity, "EntPolicyAssessHdr|EntPolicyAssessHdrIdSource", deepSaveType, innerList) 
				&& entity.EntPolicyAssessHdrIdSource != null)
			{
				DataRepository.EntPolicyAssessHdrProvider.Save(transactionManager, entity.EntPolicyAssessHdrIdSource);
				entity.EntPolicyAssessHdrId = entity.EntPolicyAssessHdrIdSource.EntPolicyAssessHdrId;
			}
			#endregion 
			
			#region EntPolicyGradingHdrIdSource
			if (CanDeepSave(entity, "EntPolicyGradingHdr|EntPolicyGradingHdrIdSource", deepSaveType, innerList) 
				&& entity.EntPolicyGradingHdrIdSource != null)
			{
				DataRepository.EntPolicyGradingHdrProvider.Save(transactionManager, entity.EntPolicyGradingHdrIdSource);
				entity.EntPolicyGradingHdrId = entity.EntPolicyGradingHdrIdSource.EntPolicyGradingHdrId;
			}
			#endregion 
			
			#region GsCodePassFailIdSource
			if (CanDeepSave(entity, "GsCodePassFail|GsCodePassFailIdSource", deepSaveType, innerList) 
				&& entity.GsCodePassFailIdSource != null)
			{
				DataRepository.GsCodePassFailProvider.Save(transactionManager, entity.GsCodePassFailIdSource);
				entity.GsCodePassFailId = entity.GsCodePassFailIdSource.GsCodePassFailId;
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
	
	#region EdStudCourseRegTempChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudCourseRegTemp</c>
	///</summary>
	public enum EdStudCourseRegTempChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCodeCourseStatus</c> at EdCodeCourseStatusIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeCourseStatus))]
		EdCodeCourseStatus,
		
		///<summary>
		/// Composite Property for <c>EdCodeGrading</c> at EdCodeGradingIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeGrading))]
		EdCodeGrading,
		
		///<summary>
		/// Composite Property for <c>EdStudSemester</c> at EdStudSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudSemester))]
		EdStudSemester,
		
		///<summary>
		/// Composite Property for <c>EntPolicyAssessHdr</c> at EntPolicyAssessHdrIdSource
		///</summary>
		[ChildEntityType(typeof(EntPolicyAssessHdr))]
		EntPolicyAssessHdr,
		
		///<summary>
		/// Composite Property for <c>EntPolicyGradingHdr</c> at EntPolicyGradingHdrIdSource
		///</summary>
		[ChildEntityType(typeof(EntPolicyGradingHdr))]
		EntPolicyGradingHdr,
		
		///<summary>
		/// Composite Property for <c>GsCodePassFail</c> at GsCodePassFailIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodePassFail))]
		GsCodePassFail,
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
	}
	
	#endregion EdStudCourseRegTempChildEntityTypes
	
	#region EdStudCourseRegTempFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudCourseRegTempColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudCourseRegTemp"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudCourseRegTempFilterBuilder : SqlFilterBuilder<EdStudCourseRegTempColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegTempFilterBuilder class.
		/// </summary>
		public EdStudCourseRegTempFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegTempFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudCourseRegTempFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegTempFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudCourseRegTempFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudCourseRegTempFilterBuilder
	
	#region EdStudCourseRegTempParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudCourseRegTempColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudCourseRegTemp"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudCourseRegTempParameterBuilder : ParameterizedSqlFilterBuilder<EdStudCourseRegTempColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegTempParameterBuilder class.
		/// </summary>
		public EdStudCourseRegTempParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegTempParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudCourseRegTempParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegTempParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudCourseRegTempParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudCourseRegTempParameterBuilder
	
	#region EdStudCourseRegTempSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudCourseRegTempColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudCourseRegTemp"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudCourseRegTempSortBuilder : SqlSortBuilder<EdStudCourseRegTempColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegTempSqlSortBuilder class.
		/// </summary>
		public EdStudCourseRegTempSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudCourseRegTempSortBuilder
	
} // end namespace
