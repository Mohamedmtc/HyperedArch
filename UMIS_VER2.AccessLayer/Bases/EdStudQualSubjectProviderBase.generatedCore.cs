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
	/// This class is the base class for any <see cref="EdStudQualSubjectProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudQualSubjectProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudQualSubject, UMIS_VER2.BusinessLyer.EdStudQualSubjectKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudQualSubjectKey key)
		{
			return Delete(transactionManager, key.EdStudQualSubjectId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudQualSubjectId">مقررات مجموعات مؤهل الطالب. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudQualSubjectId)
		{
			return Delete(null, _edStudQualSubjectId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudQualSubjectId">مقررات مجموعات مؤهل الطالب. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudQualSubjectId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_SUBJECT_ADM_CDE_EXAM_GRDNG key.
		///		FK_ED_STUD_QUAL_SUBJECT_ADM_CDE_EXAM_GRDNG Description: 
		/// </summary>
		/// <param name="_admCdeExamGrdngId">Subject grade تقدير الطالب بالمادة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualSubject objects.</returns>
		public TList<EdStudQualSubject> GetByAdmCdeExamGrdngId(System.Decimal? _admCdeExamGrdngId)
		{
			int count = -1;
			return GetByAdmCdeExamGrdngId(_admCdeExamGrdngId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_SUBJECT_ADM_CDE_EXAM_GRDNG key.
		///		FK_ED_STUD_QUAL_SUBJECT_ADM_CDE_EXAM_GRDNG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeExamGrdngId">Subject grade تقدير الطالب بالمادة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualSubject objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudQualSubject> GetByAdmCdeExamGrdngId(TransactionManager transactionManager, System.Decimal? _admCdeExamGrdngId)
		{
			int count = -1;
			return GetByAdmCdeExamGrdngId(transactionManager, _admCdeExamGrdngId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_SUBJECT_ADM_CDE_EXAM_GRDNG key.
		///		FK_ED_STUD_QUAL_SUBJECT_ADM_CDE_EXAM_GRDNG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeExamGrdngId">Subject grade تقدير الطالب بالمادة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualSubject objects.</returns>
		public TList<EdStudQualSubject> GetByAdmCdeExamGrdngId(TransactionManager transactionManager, System.Decimal? _admCdeExamGrdngId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeExamGrdngId(transactionManager, _admCdeExamGrdngId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_SUBJECT_ADM_CDE_EXAM_GRDNG key.
		///		fkEdStudQualSubjectAdmCdeExamGrdng Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeExamGrdngId">Subject grade تقدير الطالب بالمادة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualSubject objects.</returns>
		public TList<EdStudQualSubject> GetByAdmCdeExamGrdngId(System.Decimal? _admCdeExamGrdngId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCdeExamGrdngId(null, _admCdeExamGrdngId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_SUBJECT_ADM_CDE_EXAM_GRDNG key.
		///		fkEdStudQualSubjectAdmCdeExamGrdng Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeExamGrdngId">Subject grade تقدير الطالب بالمادة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualSubject objects.</returns>
		public TList<EdStudQualSubject> GetByAdmCdeExamGrdngId(System.Decimal? _admCdeExamGrdngId, int start, int pageLength,out int count)
		{
			return GetByAdmCdeExamGrdngId(null, _admCdeExamGrdngId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_SUBJECT_ADM_CDE_EXAM_GRDNG key.
		///		FK_ED_STUD_QUAL_SUBJECT_ADM_CDE_EXAM_GRDNG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeExamGrdngId">Subject grade تقدير الطالب بالمادة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualSubject objects.</returns>
		public abstract TList<EdStudQualSubject> GetByAdmCdeExamGrdngId(TransactionManager transactionManager, System.Decimal? _admCdeExamGrdngId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_SUBJECT_AS_FACULTY_INFO key.
		///		FK_ED_STUD_QUAL_SUBJECT_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId">الكلية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualSubject objects.</returns>
		public TList<EdStudQualSubject> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_SUBJECT_AS_FACULTY_INFO key.
		///		FK_ED_STUD_QUAL_SUBJECT_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId">الكلية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualSubject objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudQualSubject> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_SUBJECT_AS_FACULTY_INFO key.
		///		FK_ED_STUD_QUAL_SUBJECT_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId">الكلية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualSubject objects.</returns>
		public TList<EdStudQualSubject> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_SUBJECT_AS_FACULTY_INFO key.
		///		fkEdStudQualSubjectAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId">الكلية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualSubject objects.</returns>
		public TList<EdStudQualSubject> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_SUBJECT_AS_FACULTY_INFO key.
		///		fkEdStudQualSubjectAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId">الكلية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualSubject objects.</returns>
		public TList<EdStudQualSubject> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_SUBJECT_AS_FACULTY_INFO key.
		///		FK_ED_STUD_QUAL_SUBJECT_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId">الكلية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualSubject objects.</returns>
		public abstract TList<EdStudQualSubject> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_SUBJECT_ED_CODE_QUAL_GROUP key.
		///		FK_ED_STUD_QUAL_SUBJECT_ED_CODE_QUAL_GROUP Description: 
		/// </summary>
		/// <param name="_edCodeQualGroupId">SAT1-Sat2-OL-AS-AL</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualSubject objects.</returns>
		public TList<EdStudQualSubject> GetByEdCodeQualGroupId(System.Decimal? _edCodeQualGroupId)
		{
			int count = -1;
			return GetByEdCodeQualGroupId(_edCodeQualGroupId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_SUBJECT_ED_CODE_QUAL_GROUP key.
		///		FK_ED_STUD_QUAL_SUBJECT_ED_CODE_QUAL_GROUP Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualGroupId">SAT1-Sat2-OL-AS-AL</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualSubject objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudQualSubject> GetByEdCodeQualGroupId(TransactionManager transactionManager, System.Decimal? _edCodeQualGroupId)
		{
			int count = -1;
			return GetByEdCodeQualGroupId(transactionManager, _edCodeQualGroupId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_SUBJECT_ED_CODE_QUAL_GROUP key.
		///		FK_ED_STUD_QUAL_SUBJECT_ED_CODE_QUAL_GROUP Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualGroupId">SAT1-Sat2-OL-AS-AL</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualSubject objects.</returns>
		public TList<EdStudQualSubject> GetByEdCodeQualGroupId(TransactionManager transactionManager, System.Decimal? _edCodeQualGroupId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeQualGroupId(transactionManager, _edCodeQualGroupId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_SUBJECT_ED_CODE_QUAL_GROUP key.
		///		fkEdStudQualSubjectEdCodeQualGroup Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeQualGroupId">SAT1-Sat2-OL-AS-AL</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualSubject objects.</returns>
		public TList<EdStudQualSubject> GetByEdCodeQualGroupId(System.Decimal? _edCodeQualGroupId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeQualGroupId(null, _edCodeQualGroupId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_SUBJECT_ED_CODE_QUAL_GROUP key.
		///		fkEdStudQualSubjectEdCodeQualGroup Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeQualGroupId">SAT1-Sat2-OL-AS-AL</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualSubject objects.</returns>
		public TList<EdStudQualSubject> GetByEdCodeQualGroupId(System.Decimal? _edCodeQualGroupId, int start, int pageLength,out int count)
		{
			return GetByEdCodeQualGroupId(null, _edCodeQualGroupId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_SUBJECT_ED_CODE_QUAL_GROUP key.
		///		FK_ED_STUD_QUAL_SUBJECT_ED_CODE_QUAL_GROUP Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualGroupId">SAT1-Sat2-OL-AS-AL</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualSubject objects.</returns>
		public abstract TList<EdStudQualSubject> GetByEdCodeQualGroupId(TransactionManager transactionManager, System.Decimal? _edCodeQualGroupId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_SUBJECT_ED_CODE_QUAL_SUBJECT key.
		///		FK_ED_STUD_QUAL_SUBJECT_ED_CODE_QUAL_SUBJECT Description: 
		/// </summary>
		/// <param name="_edCodeQualSubjectId">مسلسل المادة داخل النظام</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualSubject objects.</returns>
		public TList<EdStudQualSubject> GetByEdCodeQualSubjectId(System.Decimal _edCodeQualSubjectId)
		{
			int count = -1;
			return GetByEdCodeQualSubjectId(_edCodeQualSubjectId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_SUBJECT_ED_CODE_QUAL_SUBJECT key.
		///		FK_ED_STUD_QUAL_SUBJECT_ED_CODE_QUAL_SUBJECT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualSubjectId">مسلسل المادة داخل النظام</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualSubject objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudQualSubject> GetByEdCodeQualSubjectId(TransactionManager transactionManager, System.Decimal _edCodeQualSubjectId)
		{
			int count = -1;
			return GetByEdCodeQualSubjectId(transactionManager, _edCodeQualSubjectId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_SUBJECT_ED_CODE_QUAL_SUBJECT key.
		///		FK_ED_STUD_QUAL_SUBJECT_ED_CODE_QUAL_SUBJECT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualSubjectId">مسلسل المادة داخل النظام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualSubject objects.</returns>
		public TList<EdStudQualSubject> GetByEdCodeQualSubjectId(TransactionManager transactionManager, System.Decimal _edCodeQualSubjectId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeQualSubjectId(transactionManager, _edCodeQualSubjectId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_SUBJECT_ED_CODE_QUAL_SUBJECT key.
		///		fkEdStudQualSubjectEdCodeQualSubject Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeQualSubjectId">مسلسل المادة داخل النظام</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualSubject objects.</returns>
		public TList<EdStudQualSubject> GetByEdCodeQualSubjectId(System.Decimal _edCodeQualSubjectId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeQualSubjectId(null, _edCodeQualSubjectId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_SUBJECT_ED_CODE_QUAL_SUBJECT key.
		///		fkEdStudQualSubjectEdCodeQualSubject Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeQualSubjectId">مسلسل المادة داخل النظام</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualSubject objects.</returns>
		public TList<EdStudQualSubject> GetByEdCodeQualSubjectId(System.Decimal _edCodeQualSubjectId, int start, int pageLength,out int count)
		{
			return GetByEdCodeQualSubjectId(null, _edCodeQualSubjectId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_SUBJECT_ED_CODE_QUAL_SUBJECT key.
		///		FK_ED_STUD_QUAL_SUBJECT_ED_CODE_QUAL_SUBJECT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualSubjectId">مسلسل المادة داخل النظام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualSubject objects.</returns>
		public abstract TList<EdStudQualSubject> GetByEdCodeQualSubjectId(TransactionManager transactionManager, System.Decimal _edCodeQualSubjectId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_SUBJECT_ED_STUD_QUAL key.
		///		FK_ED_STUD_QUAL_SUBJECT_ED_STUD_QUAL Description: 
		/// </summary>
		/// <param name="_edStudQualId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualSubject objects.</returns>
		public TList<EdStudQualSubject> GetByEdStudQualId(System.Decimal? _edStudQualId)
		{
			int count = -1;
			return GetByEdStudQualId(_edStudQualId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_SUBJECT_ED_STUD_QUAL key.
		///		FK_ED_STUD_QUAL_SUBJECT_ED_STUD_QUAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudQualId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualSubject objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudQualSubject> GetByEdStudQualId(TransactionManager transactionManager, System.Decimal? _edStudQualId)
		{
			int count = -1;
			return GetByEdStudQualId(transactionManager, _edStudQualId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_SUBJECT_ED_STUD_QUAL key.
		///		FK_ED_STUD_QUAL_SUBJECT_ED_STUD_QUAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualSubject objects.</returns>
		public TList<EdStudQualSubject> GetByEdStudQualId(TransactionManager transactionManager, System.Decimal? _edStudQualId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudQualId(transactionManager, _edStudQualId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_SUBJECT_ED_STUD_QUAL key.
		///		fkEdStudQualSubjectEdStudQual Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudQualId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualSubject objects.</returns>
		public TList<EdStudQualSubject> GetByEdStudQualId(System.Decimal? _edStudQualId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudQualId(null, _edStudQualId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_SUBJECT_ED_STUD_QUAL key.
		///		fkEdStudQualSubjectEdStudQual Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudQualId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualSubject objects.</returns>
		public TList<EdStudQualSubject> GetByEdStudQualId(System.Decimal? _edStudQualId, int start, int pageLength,out int count)
		{
			return GetByEdStudQualId(null, _edStudQualId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_SUBJECT_ED_STUD_QUAL key.
		///		FK_ED_STUD_QUAL_SUBJECT_ED_STUD_QUAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualSubject objects.</returns>
		public abstract TList<EdStudQualSubject> GetByEdStudQualId(TransactionManager transactionManager, System.Decimal? _edStudQualId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudQualSubject Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudQualSubjectKey key, int start, int pageLength)
		{
			return GetByEdStudQualSubjectId(transactionManager, key.EdStudQualSubjectId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_QUAL_SUBJECT index.
		/// </summary>
		/// <param name="_edStudQualSubjectId">مقررات مجموعات مؤهل الطالب</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudQualSubject"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudQualSubject GetByEdStudQualSubjectId(System.Decimal _edStudQualSubjectId)
		{
			int count = -1;
			return GetByEdStudQualSubjectId(null,_edStudQualSubjectId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_QUAL_SUBJECT index.
		/// </summary>
		/// <param name="_edStudQualSubjectId">مقررات مجموعات مؤهل الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudQualSubject"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudQualSubject GetByEdStudQualSubjectId(System.Decimal _edStudQualSubjectId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudQualSubjectId(null, _edStudQualSubjectId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_QUAL_SUBJECT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudQualSubjectId">مقررات مجموعات مؤهل الطالب</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudQualSubject"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudQualSubject GetByEdStudQualSubjectId(TransactionManager transactionManager, System.Decimal _edStudQualSubjectId)
		{
			int count = -1;
			return GetByEdStudQualSubjectId(transactionManager, _edStudQualSubjectId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_QUAL_SUBJECT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudQualSubjectId">مقررات مجموعات مؤهل الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudQualSubject"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudQualSubject GetByEdStudQualSubjectId(TransactionManager transactionManager, System.Decimal _edStudQualSubjectId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudQualSubjectId(transactionManager, _edStudQualSubjectId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_QUAL_SUBJECT index.
		/// </summary>
		/// <param name="_edStudQualSubjectId">مقررات مجموعات مؤهل الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudQualSubject"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudQualSubject GetByEdStudQualSubjectId(System.Decimal _edStudQualSubjectId, int start, int pageLength, out int count)
		{
			return GetByEdStudQualSubjectId(null, _edStudQualSubjectId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_QUAL_SUBJECT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudQualSubjectId">مقررات مجموعات مؤهل الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudQualSubject"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudQualSubject GetByEdStudQualSubjectId(TransactionManager transactionManager, System.Decimal _edStudQualSubjectId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudQualSubject&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudQualSubject&gt;"/></returns>
		public static TList<EdStudQualSubject> Fill(IDataReader reader, TList<EdStudQualSubject> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudQualSubject c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudQualSubject")
					.Append("|").Append((System.Decimal)reader["ED_STUD_QUAL_SUBJECT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudQualSubject>(
					key.ToString(), // EntityTrackingKey
					"EdStudQualSubject",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudQualSubject();
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
					c.EdStudQualSubjectId = (System.Decimal)reader["ED_STUD_QUAL_SUBJECT_ID"];
					c.OriginalEdStudQualSubjectId = c.EdStudQualSubjectId;
					c.EdStudQualId = Convert.IsDBNull(reader["ED_STUD_QUAL_ID"]) ? null : (System.Decimal?)reader["ED_STUD_QUAL_ID"];
					c.EdCodeQualSubjectId = (System.Decimal)reader["ED_CODE_QUAL_SUBJECT_ID"];
					c.StudMark = (System.Decimal)reader["STUD_MARK"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.AdmCdeExamGrdngId = Convert.IsDBNull(reader["ADM_CDE_EXAM_GRDNG_ID"]) ? null : (System.Decimal?)reader["ADM_CDE_EXAM_GRDNG_ID"];
					c.AddTotalFlg = (System.Boolean)reader["ADD_TOTAL_FLG"];
					c.GradeId = Convert.IsDBNull(reader["GRADE_ID"]) ? null : (System.Int32?)reader["GRADE_ID"];
					c.EdCodeQualGroupId = Convert.IsDBNull(reader["ED_CODE_QUAL_GROUP_ID"]) ? null : (System.Decimal?)reader["ED_CODE_QUAL_GROUP_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudQualSubject"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudQualSubject"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudQualSubject entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudQualSubjectId = (System.Decimal)reader[((int)EdStudQualSubjectColumn.EdStudQualSubjectId - 1)];
			entity.OriginalEdStudQualSubjectId = (System.Decimal)reader["ED_STUD_QUAL_SUBJECT_ID"];
			entity.EdStudQualId = (reader.IsDBNull(((int)EdStudQualSubjectColumn.EdStudQualId - 1)))?null:(System.Decimal?)reader[((int)EdStudQualSubjectColumn.EdStudQualId - 1)];
			entity.EdCodeQualSubjectId = (System.Decimal)reader[((int)EdStudQualSubjectColumn.EdCodeQualSubjectId - 1)];
			entity.StudMark = (System.Decimal)reader[((int)EdStudQualSubjectColumn.StudMark - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)EdStudQualSubjectColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)EdStudQualSubjectColumn.AsFacultyInfoId - 1)];
			entity.AdmCdeExamGrdngId = (reader.IsDBNull(((int)EdStudQualSubjectColumn.AdmCdeExamGrdngId - 1)))?null:(System.Decimal?)reader[((int)EdStudQualSubjectColumn.AdmCdeExamGrdngId - 1)];
			entity.AddTotalFlg = (System.Boolean)reader[((int)EdStudQualSubjectColumn.AddTotalFlg - 1)];
			entity.GradeId = (reader.IsDBNull(((int)EdStudQualSubjectColumn.GradeId - 1)))?null:(System.Int32?)reader[((int)EdStudQualSubjectColumn.GradeId - 1)];
			entity.EdCodeQualGroupId = (reader.IsDBNull(((int)EdStudQualSubjectColumn.EdCodeQualGroupId - 1)))?null:(System.Decimal?)reader[((int)EdStudQualSubjectColumn.EdCodeQualGroupId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudQualSubject"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudQualSubject"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudQualSubject entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudQualSubjectId = (System.Decimal)dataRow["ED_STUD_QUAL_SUBJECT_ID"];
			entity.OriginalEdStudQualSubjectId = (System.Decimal)dataRow["ED_STUD_QUAL_SUBJECT_ID"];
			entity.EdStudQualId = Convert.IsDBNull(dataRow["ED_STUD_QUAL_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_QUAL_ID"];
			entity.EdCodeQualSubjectId = (System.Decimal)dataRow["ED_CODE_QUAL_SUBJECT_ID"];
			entity.StudMark = (System.Decimal)dataRow["STUD_MARK"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.AdmCdeExamGrdngId = Convert.IsDBNull(dataRow["ADM_CDE_EXAM_GRDNG_ID"]) ? null : (System.Decimal?)dataRow["ADM_CDE_EXAM_GRDNG_ID"];
			entity.AddTotalFlg = (System.Boolean)dataRow["ADD_TOTAL_FLG"];
			entity.GradeId = Convert.IsDBNull(dataRow["GRADE_ID"]) ? null : (System.Int32?)dataRow["GRADE_ID"];
			entity.EdCodeQualGroupId = Convert.IsDBNull(dataRow["ED_CODE_QUAL_GROUP_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_QUAL_GROUP_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudQualSubject"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudQualSubject Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudQualSubject entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmCdeExamGrdngIdSource	
			if (CanDeepLoad(entity, "AdmCdeExamGrdng|AdmCdeExamGrdngIdSource", deepLoadType, innerList) 
				&& entity.AdmCdeExamGrdngIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmCdeExamGrdngId ?? 0.0m);
				AdmCdeExamGrdng tmpEntity = EntityManager.LocateEntity<AdmCdeExamGrdng>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCdeExamGrdng), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCdeExamGrdngIdSource = tmpEntity;
				else
					entity.AdmCdeExamGrdngIdSource = DataRepository.AdmCdeExamGrdngProvider.GetByAdmCdeExamGrdngId(transactionManager, (entity.AdmCdeExamGrdngId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeExamGrdngIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCdeExamGrdngIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCdeExamGrdngProvider.DeepLoad(transactionManager, entity.AdmCdeExamGrdngIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCdeExamGrdngIdSource

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

			#region EdCodeQualGroupIdSource	
			if (CanDeepLoad(entity, "EdCodeQualGroup|EdCodeQualGroupIdSource", deepLoadType, innerList) 
				&& entity.EdCodeQualGroupIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeQualGroupId ?? 0.0m);
				EdCodeQualGroup tmpEntity = EntityManager.LocateEntity<EdCodeQualGroup>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeQualGroup), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeQualGroupIdSource = tmpEntity;
				else
					entity.EdCodeQualGroupIdSource = DataRepository.EdCodeQualGroupProvider.GetByEdCodeQualGroupId(transactionManager, (entity.EdCodeQualGroupId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeQualGroupIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeQualGroupIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeQualGroupProvider.DeepLoad(transactionManager, entity.EdCodeQualGroupIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeQualGroupIdSource

			#region EdCodeQualSubjectIdSource	
			if (CanDeepLoad(entity, "EdCodeQualSubject|EdCodeQualSubjectIdSource", deepLoadType, innerList) 
				&& entity.EdCodeQualSubjectIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeQualSubjectId;
				EdCodeQualSubject tmpEntity = EntityManager.LocateEntity<EdCodeQualSubject>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeQualSubject), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeQualSubjectIdSource = tmpEntity;
				else
					entity.EdCodeQualSubjectIdSource = DataRepository.EdCodeQualSubjectProvider.GetByEdCodeQualSubjectId(transactionManager, entity.EdCodeQualSubjectId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeQualSubjectIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeQualSubjectIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeQualSubjectProvider.DeepLoad(transactionManager, entity.EdCodeQualSubjectIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeQualSubjectIdSource

			#region EdStudQualIdSource	
			if (CanDeepLoad(entity, "EdStudQual|EdStudQualIdSource", deepLoadType, innerList) 
				&& entity.EdStudQualIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdStudQualId ?? 0.0m);
				EdStudQual tmpEntity = EntityManager.LocateEntity<EdStudQual>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudQual), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudQualIdSource = tmpEntity;
				else
					entity.EdStudQualIdSource = DataRepository.EdStudQualProvider.GetByEdStudQualId(transactionManager, (entity.EdStudQualId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudQualIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudQualIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudQualProvider.DeepLoad(transactionManager, entity.EdStudQualIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudQualIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudQualSubject object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudQualSubject instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudQualSubject Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudQualSubject entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmCdeExamGrdngIdSource
			if (CanDeepSave(entity, "AdmCdeExamGrdng|AdmCdeExamGrdngIdSource", deepSaveType, innerList) 
				&& entity.AdmCdeExamGrdngIdSource != null)
			{
				DataRepository.AdmCdeExamGrdngProvider.Save(transactionManager, entity.AdmCdeExamGrdngIdSource);
				entity.AdmCdeExamGrdngId = entity.AdmCdeExamGrdngIdSource.AdmCdeExamGrdngId;
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
			
			#region EdCodeQualGroupIdSource
			if (CanDeepSave(entity, "EdCodeQualGroup|EdCodeQualGroupIdSource", deepSaveType, innerList) 
				&& entity.EdCodeQualGroupIdSource != null)
			{
				DataRepository.EdCodeQualGroupProvider.Save(transactionManager, entity.EdCodeQualGroupIdSource);
				entity.EdCodeQualGroupId = entity.EdCodeQualGroupIdSource.EdCodeQualGroupId;
			}
			#endregion 
			
			#region EdCodeQualSubjectIdSource
			if (CanDeepSave(entity, "EdCodeQualSubject|EdCodeQualSubjectIdSource", deepSaveType, innerList) 
				&& entity.EdCodeQualSubjectIdSource != null)
			{
				DataRepository.EdCodeQualSubjectProvider.Save(transactionManager, entity.EdCodeQualSubjectIdSource);
				entity.EdCodeQualSubjectId = entity.EdCodeQualSubjectIdSource.EdCodeQualSubjectId;
			}
			#endregion 
			
			#region EdStudQualIdSource
			if (CanDeepSave(entity, "EdStudQual|EdStudQualIdSource", deepSaveType, innerList) 
				&& entity.EdStudQualIdSource != null)
			{
				DataRepository.EdStudQualProvider.Save(transactionManager, entity.EdStudQualIdSource);
				entity.EdStudQualId = entity.EdStudQualIdSource.EdStudQualId;
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
	
	#region EdStudQualSubjectChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudQualSubject</c>
	///</summary>
	public enum EdStudQualSubjectChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmCdeExamGrdng</c> at AdmCdeExamGrdngIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdeExamGrdng))]
		AdmCdeExamGrdng,
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>EdCodeQualGroup</c> at EdCodeQualGroupIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeQualGroup))]
		EdCodeQualGroup,
		
		///<summary>
		/// Composite Property for <c>EdCodeQualSubject</c> at EdCodeQualSubjectIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeQualSubject))]
		EdCodeQualSubject,
		
		///<summary>
		/// Composite Property for <c>EdStudQual</c> at EdStudQualIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudQual))]
		EdStudQual,
	}
	
	#endregion EdStudQualSubjectChildEntityTypes
	
	#region EdStudQualSubjectFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudQualSubjectColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudQualSubject"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudQualSubjectFilterBuilder : SqlFilterBuilder<EdStudQualSubjectColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudQualSubjectFilterBuilder class.
		/// </summary>
		public EdStudQualSubjectFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudQualSubjectFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudQualSubjectFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudQualSubjectFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudQualSubjectFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudQualSubjectFilterBuilder
	
	#region EdStudQualSubjectParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudQualSubjectColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudQualSubject"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudQualSubjectParameterBuilder : ParameterizedSqlFilterBuilder<EdStudQualSubjectColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudQualSubjectParameterBuilder class.
		/// </summary>
		public EdStudQualSubjectParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudQualSubjectParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudQualSubjectParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudQualSubjectParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudQualSubjectParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudQualSubjectParameterBuilder
	
	#region EdStudQualSubjectSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudQualSubjectColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudQualSubject"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudQualSubjectSortBuilder : SqlSortBuilder<EdStudQualSubjectColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudQualSubjectSqlSortBuilder class.
		/// </summary>
		public EdStudQualSubjectSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudQualSubjectSortBuilder
	
} // end namespace
