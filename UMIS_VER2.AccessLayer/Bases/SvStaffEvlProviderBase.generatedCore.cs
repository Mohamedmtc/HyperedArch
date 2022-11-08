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
	/// This class is the base class for any <see cref="SvStaffEvlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvStaffEvlProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvStaffEvl, UMIS_VER2.BusinessLyer.SvStaffEvlKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStaffEvlKey key)
		{
			return Delete(transactionManager, key.SvStaffEvlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svStaffEvlId">استبيان عام لطلاب او اعضاء هيئة تدريس. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _svStaffEvlId)
		{
			return Delete(null, _svStaffEvlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStaffEvlId">استبيان عام لطلاب او اعضاء هيئة تدريس. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _svStaffEvlId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_STF_EVL_ENTITY_MAIN key.
		///		FK_SV_COURSE_STF_EVL_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_entMainId">فى حالة  استبيان موجه لاعضاء هيئة التدريس قسم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public TList<SvStaffEvl> GetByEntMainId(System.Decimal? _entMainId)
		{
			int count = -1;
			return GetByEntMainId(_entMainId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_STF_EVL_ENTITY_MAIN key.
		///		FK_SV_COURSE_STF_EVL_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">فى حالة  استبيان موجه لاعضاء هيئة التدريس قسم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		/// <remarks></remarks>
		public TList<SvStaffEvl> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_STF_EVL_ENTITY_MAIN key.
		///		FK_SV_COURSE_STF_EVL_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">فى حالة  استبيان موجه لاعضاء هيئة التدريس قسم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public TList<SvStaffEvl> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_STF_EVL_ENTITY_MAIN key.
		///		fkSvCourseStfEvlEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId">فى حالة  استبيان موجه لاعضاء هيئة التدريس قسم</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public TList<SvStaffEvl> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainId(null, _entMainId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_STF_EVL_ENTITY_MAIN key.
		///		fkSvCourseStfEvlEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId">فى حالة  استبيان موجه لاعضاء هيئة التدريس قسم</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public TList<SvStaffEvl> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength,out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_STF_EVL_ENTITY_MAIN key.
		///		FK_SV_COURSE_STF_EVL_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">فى حالة  استبيان موجه لاعضاء هيئة التدريس قسم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public abstract TList<SvStaffEvl> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_STF_EVL_SV_CODE_RATING_SCHM key.
		///		FK_SV_COURSE_STF_EVL_SV_CODE_RATING_SCHM Description: 
		/// </summary>
		/// <param name="_svCodeRatingSchmId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public TList<SvStaffEvl> GetBySvCodeRatingSchmId(System.Decimal _svCodeRatingSchmId)
		{
			int count = -1;
			return GetBySvCodeRatingSchmId(_svCodeRatingSchmId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_STF_EVL_SV_CODE_RATING_SCHM key.
		///		FK_SV_COURSE_STF_EVL_SV_CODE_RATING_SCHM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeRatingSchmId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		/// <remarks></remarks>
		public TList<SvStaffEvl> GetBySvCodeRatingSchmId(TransactionManager transactionManager, System.Decimal _svCodeRatingSchmId)
		{
			int count = -1;
			return GetBySvCodeRatingSchmId(transactionManager, _svCodeRatingSchmId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_STF_EVL_SV_CODE_RATING_SCHM key.
		///		FK_SV_COURSE_STF_EVL_SV_CODE_RATING_SCHM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeRatingSchmId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public TList<SvStaffEvl> GetBySvCodeRatingSchmId(TransactionManager transactionManager, System.Decimal _svCodeRatingSchmId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCodeRatingSchmId(transactionManager, _svCodeRatingSchmId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_STF_EVL_SV_CODE_RATING_SCHM key.
		///		fkSvCourseStfEvlSvCodeRatingSchm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCodeRatingSchmId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public TList<SvStaffEvl> GetBySvCodeRatingSchmId(System.Decimal _svCodeRatingSchmId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySvCodeRatingSchmId(null, _svCodeRatingSchmId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_STF_EVL_SV_CODE_RATING_SCHM key.
		///		fkSvCourseStfEvlSvCodeRatingSchm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCodeRatingSchmId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public TList<SvStaffEvl> GetBySvCodeRatingSchmId(System.Decimal _svCodeRatingSchmId, int start, int pageLength,out int count)
		{
			return GetBySvCodeRatingSchmId(null, _svCodeRatingSchmId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_STF_EVL_SV_CODE_RATING_SCHM key.
		///		FK_SV_COURSE_STF_EVL_SV_CODE_RATING_SCHM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeRatingSchmId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public abstract TList<SvStaffEvl> GetBySvCodeRatingSchmId(TransactionManager transactionManager, System.Decimal _svCodeRatingSchmId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_AS_FACULTY_INFO key.
		///		FK_SV_STAFF_EVL_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public TList<SvStaffEvl> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_AS_FACULTY_INFO key.
		///		FK_SV_STAFF_EVL_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		/// <remarks></remarks>
		public TList<SvStaffEvl> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_AS_FACULTY_INFO key.
		///		FK_SV_STAFF_EVL_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public TList<SvStaffEvl> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_AS_FACULTY_INFO key.
		///		fkSvStaffEvlAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public TList<SvStaffEvl> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_AS_FACULTY_INFO key.
		///		fkSvStaffEvlAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public TList<SvStaffEvl> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_AS_FACULTY_INFO key.
		///		FK_SV_STAFF_EVL_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public abstract TList<SvStaffEvl> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_ED_ACAD_YEAR key.
		///		FK_SV_STAFF_EVL_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public TList<SvStaffEvl> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_ED_ACAD_YEAR key.
		///		FK_SV_STAFF_EVL_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		/// <remarks></remarks>
		public TList<SvStaffEvl> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_ED_ACAD_YEAR key.
		///		FK_SV_STAFF_EVL_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public TList<SvStaffEvl> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_ED_ACAD_YEAR key.
		///		fkSvStaffEvlEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public TList<SvStaffEvl> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_ED_ACAD_YEAR key.
		///		fkSvStaffEvlEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public TList<SvStaffEvl> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_ED_ACAD_YEAR key.
		///		FK_SV_STAFF_EVL_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public abstract TList<SvStaffEvl> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_ED_CODE_LEVEL key.
		///		FK_SV_STAFF_EVL_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="_edCodeLevelId">المستوى فى حالة الاستبيان موجه للطلاب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public TList<SvStaffEvl> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(_edCodeLevelId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_ED_CODE_LEVEL key.
		///		FK_SV_STAFF_EVL_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId">المستوى فى حالة الاستبيان موجه للطلاب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		/// <remarks></remarks>
		public TList<SvStaffEvl> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_ED_CODE_LEVEL key.
		///		FK_SV_STAFF_EVL_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId">المستوى فى حالة الاستبيان موجه للطلاب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public TList<SvStaffEvl> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_ED_CODE_LEVEL key.
		///		fkSvStaffEvlEdCodeLevel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelId">المستوى فى حالة الاستبيان موجه للطلاب</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public TList<SvStaffEvl> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_ED_CODE_LEVEL key.
		///		fkSvStaffEvlEdCodeLevel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelId">المستوى فى حالة الاستبيان موجه للطلاب</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public TList<SvStaffEvl> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId, int start, int pageLength,out int count)
		{
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_ED_CODE_LEVEL key.
		///		FK_SV_STAFF_EVL_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId">المستوى فى حالة الاستبيان موجه للطلاب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public abstract TList<SvStaffEvl> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_ED_CODE_SEMESTER key.
		///		FK_SV_STAFF_EVL_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public TList<SvStaffEvl> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_ED_CODE_SEMESTER key.
		///		FK_SV_STAFF_EVL_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		/// <remarks></remarks>
		public TList<SvStaffEvl> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_ED_CODE_SEMESTER key.
		///		FK_SV_STAFF_EVL_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public TList<SvStaffEvl> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_ED_CODE_SEMESTER key.
		///		fkSvStaffEvlEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public TList<SvStaffEvl> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_ED_CODE_SEMESTER key.
		///		fkSvStaffEvlEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public TList<SvStaffEvl> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_ED_CODE_SEMESTER key.
		///		FK_SV_STAFF_EVL_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public abstract TList<SvStaffEvl> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_ENTITY_MAIN_MAJOR key.
		///		FK_SV_STAFF_EVL_ENTITY_MAIN_MAJOR Description: 
		/// </summary>
		/// <param name="_entMainMajorId">التخصص الرئيسي فى حالة الاستبيان موجه للطلاب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public TList<SvStaffEvl> GetByEntMainMajorId(System.Decimal? _entMainMajorId)
		{
			int count = -1;
			return GetByEntMainMajorId(_entMainMajorId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_ENTITY_MAIN_MAJOR key.
		///		FK_SV_STAFF_EVL_ENTITY_MAIN_MAJOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainMajorId">التخصص الرئيسي فى حالة الاستبيان موجه للطلاب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		/// <remarks></remarks>
		public TList<SvStaffEvl> GetByEntMainMajorId(TransactionManager transactionManager, System.Decimal? _entMainMajorId)
		{
			int count = -1;
			return GetByEntMainMajorId(transactionManager, _entMainMajorId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_ENTITY_MAIN_MAJOR key.
		///		FK_SV_STAFF_EVL_ENTITY_MAIN_MAJOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainMajorId">التخصص الرئيسي فى حالة الاستبيان موجه للطلاب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public TList<SvStaffEvl> GetByEntMainMajorId(TransactionManager transactionManager, System.Decimal? _entMainMajorId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainMajorId(transactionManager, _entMainMajorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_ENTITY_MAIN_MAJOR key.
		///		fkSvStaffEvlEntityMainMajor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainMajorId">التخصص الرئيسي فى حالة الاستبيان موجه للطلاب</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public TList<SvStaffEvl> GetByEntMainMajorId(System.Decimal? _entMainMajorId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainMajorId(null, _entMainMajorId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_ENTITY_MAIN_MAJOR key.
		///		fkSvStaffEvlEntityMainMajor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainMajorId">التخصص الرئيسي فى حالة الاستبيان موجه للطلاب</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public TList<SvStaffEvl> GetByEntMainMajorId(System.Decimal? _entMainMajorId, int start, int pageLength,out int count)
		{
			return GetByEntMainMajorId(null, _entMainMajorId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_ENTITY_MAIN_MAJOR key.
		///		FK_SV_STAFF_EVL_ENTITY_MAIN_MAJOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainMajorId">التخصص الرئيسي فى حالة الاستبيان موجه للطلاب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public abstract TList<SvStaffEvl> GetByEntMainMajorId(TransactionManager transactionManager, System.Decimal? _entMainMajorId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_ENTITY_MAIN_MINOR key.
		///		FK_SV_STAFF_EVL_ENTITY_MAIN_MINOR Description: 
		/// </summary>
		/// <param name="_entMainMinorId">التخصص الفرعى فى حالة الاستبيان موجه للطلاب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public TList<SvStaffEvl> GetByEntMainMinorId(System.Decimal? _entMainMinorId)
		{
			int count = -1;
			return GetByEntMainMinorId(_entMainMinorId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_ENTITY_MAIN_MINOR key.
		///		FK_SV_STAFF_EVL_ENTITY_MAIN_MINOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainMinorId">التخصص الفرعى فى حالة الاستبيان موجه للطلاب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		/// <remarks></remarks>
		public TList<SvStaffEvl> GetByEntMainMinorId(TransactionManager transactionManager, System.Decimal? _entMainMinorId)
		{
			int count = -1;
			return GetByEntMainMinorId(transactionManager, _entMainMinorId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_ENTITY_MAIN_MINOR key.
		///		FK_SV_STAFF_EVL_ENTITY_MAIN_MINOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainMinorId">التخصص الفرعى فى حالة الاستبيان موجه للطلاب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public TList<SvStaffEvl> GetByEntMainMinorId(TransactionManager transactionManager, System.Decimal? _entMainMinorId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainMinorId(transactionManager, _entMainMinorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_ENTITY_MAIN_MINOR key.
		///		fkSvStaffEvlEntityMainMinor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainMinorId">التخصص الفرعى فى حالة الاستبيان موجه للطلاب</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public TList<SvStaffEvl> GetByEntMainMinorId(System.Decimal? _entMainMinorId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainMinorId(null, _entMainMinorId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_ENTITY_MAIN_MINOR key.
		///		fkSvStaffEvlEntityMainMinor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainMinorId">التخصص الفرعى فى حالة الاستبيان موجه للطلاب</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public TList<SvStaffEvl> GetByEntMainMinorId(System.Decimal? _entMainMinorId, int start, int pageLength,out int count)
		{
			return GetByEntMainMinorId(null, _entMainMinorId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_ENTITY_MAIN_MINOR key.
		///		FK_SV_STAFF_EVL_ENTITY_MAIN_MINOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainMinorId">التخصص الفرعى فى حالة الاستبيان موجه للطلاب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public abstract TList<SvStaffEvl> GetByEntMainMinorId(TransactionManager transactionManager, System.Decimal? _entMainMinorId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_SE_USER key.
		///		FK_SV_STAFF_EVL_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public TList<SvStaffEvl> GetBySeUserId(System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(_seUserId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_SE_USER key.
		///		FK_SV_STAFF_EVL_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		/// <remarks></remarks>
		public TList<SvStaffEvl> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_SE_USER key.
		///		FK_SV_STAFF_EVL_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public TList<SvStaffEvl> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_SE_USER key.
		///		fkSvStaffEvlSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public TList<SvStaffEvl> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserId(null, _seUserId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_SE_USER key.
		///		fkSvStaffEvlSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public TList<SvStaffEvl> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength,out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVL_SE_USER key.
		///		FK_SV_STAFF_EVL_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvl objects.</returns>
		public abstract TList<SvStaffEvl> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SvStaffEvl Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStaffEvlKey key, int start, int pageLength)
		{
			return GetBySvStaffEvlId(transactionManager, key.SvStaffEvlId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_COURSE_STF_EVL index.
		/// </summary>
		/// <param name="_svStaffEvlId">استبيان عام لطلاب او اعضاء هيئة تدريس</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStaffEvl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStaffEvl GetBySvStaffEvlId(System.Decimal _svStaffEvlId)
		{
			int count = -1;
			return GetBySvStaffEvlId(null,_svStaffEvlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_COURSE_STF_EVL index.
		/// </summary>
		/// <param name="_svStaffEvlId">استبيان عام لطلاب او اعضاء هيئة تدريس</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStaffEvl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStaffEvl GetBySvStaffEvlId(System.Decimal _svStaffEvlId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvStaffEvlId(null, _svStaffEvlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_COURSE_STF_EVL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStaffEvlId">استبيان عام لطلاب او اعضاء هيئة تدريس</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStaffEvl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStaffEvl GetBySvStaffEvlId(TransactionManager transactionManager, System.Decimal _svStaffEvlId)
		{
			int count = -1;
			return GetBySvStaffEvlId(transactionManager, _svStaffEvlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_COURSE_STF_EVL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStaffEvlId">استبيان عام لطلاب او اعضاء هيئة تدريس</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStaffEvl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStaffEvl GetBySvStaffEvlId(TransactionManager transactionManager, System.Decimal _svStaffEvlId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvStaffEvlId(transactionManager, _svStaffEvlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_COURSE_STF_EVL index.
		/// </summary>
		/// <param name="_svStaffEvlId">استبيان عام لطلاب او اعضاء هيئة تدريس</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStaffEvl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStaffEvl GetBySvStaffEvlId(System.Decimal _svStaffEvlId, int start, int pageLength, out int count)
		{
			return GetBySvStaffEvlId(null, _svStaffEvlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_COURSE_STF_EVL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStaffEvlId">استبيان عام لطلاب او اعضاء هيئة تدريس</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStaffEvl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvStaffEvl GetBySvStaffEvlId(TransactionManager transactionManager, System.Decimal _svStaffEvlId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvStaffEvl&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvStaffEvl&gt;"/></returns>
		public static TList<SvStaffEvl> Fill(IDataReader reader, TList<SvStaffEvl> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvStaffEvl c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvStaffEvl")
					.Append("|").Append((System.Decimal)reader["SV_STAFF_EVL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvStaffEvl>(
					key.ToString(), // EntityTrackingKey
					"SvStaffEvl",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvStaffEvl();
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
					c.SvStaffEvlId = (System.Decimal)reader["SV_STAFF_EVL_ID"];
					c.OriginalSvStaffEvlId = c.SvStaffEvlId;
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EntMainId = Convert.IsDBNull(reader["ENT_MAIN_ID"]) ? null : (System.Decimal?)reader["ENT_MAIN_ID"];
					c.EdCodeLevelId = Convert.IsDBNull(reader["ED_CODE_LEVEL_ID"]) ? null : (System.Decimal?)reader["ED_CODE_LEVEL_ID"];
					c.SvCodeRatingSchmId = (System.Decimal)reader["SV_CODE_RATING_SCHM_ID"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.PubFlg = (System.Decimal)reader["PUB_FLG"];
					c.EvalTitle = Convert.IsDBNull(reader["EVAL_TITLE"]) ? null : (System.String)reader["EVAL_TITLE"];
					c.EvalDate = Convert.IsDBNull(reader["EVAL_DATE"]) ? null : (System.DateTime?)reader["EVAL_DATE"];
					c.StudStaffFlg = Convert.IsDBNull(reader["STUD_STAFF_FLG"]) ? null : (System.Int32?)reader["STUD_STAFF_FLG"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.EvalDueDate = Convert.IsDBNull(reader["EVAL_DUE_DATE"]) ? null : (System.DateTime?)reader["EVAL_DUE_DATE"];
					c.RegFlg = Convert.IsDBNull(reader["REG_FLG"]) ? null : (System.Boolean?)reader["REG_FLG"];
					c.WaitFlg = Convert.IsDBNull(reader["WAIT_FLG"]) ? null : (System.Boolean?)reader["WAIT_FLG"];
					c.RsltFlg = Convert.IsDBNull(reader["RSLT_FLG"]) ? null : (System.Boolean?)reader["RSLT_FLG"];
					c.TmpltFlg = Convert.IsDBNull(reader["TMPLT_FLG"]) ? null : (System.Boolean?)reader["TMPLT_FLG"];
					c.EntMainMajorId = Convert.IsDBNull(reader["ENT_MAIN_MAJOR_ID"]) ? null : (System.Decimal?)reader["ENT_MAIN_MAJOR_ID"];
					c.EntMainMinorId = Convert.IsDBNull(reader["ENT_MAIN_MINOR_ID"]) ? null : (System.Decimal?)reader["ENT_MAIN_MINOR_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvStaffEvl"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvStaffEvl"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvStaffEvl entity)
		{
			if (!reader.Read()) return;
			
			entity.SvStaffEvlId = (System.Decimal)reader[((int)SvStaffEvlColumn.SvStaffEvlId - 1)];
			entity.OriginalSvStaffEvlId = (System.Decimal)reader["SV_STAFF_EVL_ID"];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)SvStaffEvlColumn.EdCodeSemesterId - 1)];
			entity.EdAcadYearId = (System.Decimal)reader[((int)SvStaffEvlColumn.EdAcadYearId - 1)];
			entity.EntMainId = (reader.IsDBNull(((int)SvStaffEvlColumn.EntMainId - 1)))?null:(System.Decimal?)reader[((int)SvStaffEvlColumn.EntMainId - 1)];
			entity.EdCodeLevelId = (reader.IsDBNull(((int)SvStaffEvlColumn.EdCodeLevelId - 1)))?null:(System.Decimal?)reader[((int)SvStaffEvlColumn.EdCodeLevelId - 1)];
			entity.SvCodeRatingSchmId = (System.Decimal)reader[((int)SvStaffEvlColumn.SvCodeRatingSchmId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)SvStaffEvlColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)SvStaffEvlColumn.SeUserId - 1)];
			entity.PubFlg = (System.Decimal)reader[((int)SvStaffEvlColumn.PubFlg - 1)];
			entity.EvalTitle = (reader.IsDBNull(((int)SvStaffEvlColumn.EvalTitle - 1)))?null:(System.String)reader[((int)SvStaffEvlColumn.EvalTitle - 1)];
			entity.EvalDate = (reader.IsDBNull(((int)SvStaffEvlColumn.EvalDate - 1)))?null:(System.DateTime?)reader[((int)SvStaffEvlColumn.EvalDate - 1)];
			entity.StudStaffFlg = (reader.IsDBNull(((int)SvStaffEvlColumn.StudStaffFlg - 1)))?null:(System.Int32?)reader[((int)SvStaffEvlColumn.StudStaffFlg - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)SvStaffEvlColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)SvStaffEvlColumn.AsFacultyInfoId - 1)];
			entity.EvalDueDate = (reader.IsDBNull(((int)SvStaffEvlColumn.EvalDueDate - 1)))?null:(System.DateTime?)reader[((int)SvStaffEvlColumn.EvalDueDate - 1)];
			entity.RegFlg = (reader.IsDBNull(((int)SvStaffEvlColumn.RegFlg - 1)))?null:(System.Boolean?)reader[((int)SvStaffEvlColumn.RegFlg - 1)];
			entity.WaitFlg = (reader.IsDBNull(((int)SvStaffEvlColumn.WaitFlg - 1)))?null:(System.Boolean?)reader[((int)SvStaffEvlColumn.WaitFlg - 1)];
			entity.RsltFlg = (reader.IsDBNull(((int)SvStaffEvlColumn.RsltFlg - 1)))?null:(System.Boolean?)reader[((int)SvStaffEvlColumn.RsltFlg - 1)];
			entity.TmpltFlg = (reader.IsDBNull(((int)SvStaffEvlColumn.TmpltFlg - 1)))?null:(System.Boolean?)reader[((int)SvStaffEvlColumn.TmpltFlg - 1)];
			entity.EntMainMajorId = (reader.IsDBNull(((int)SvStaffEvlColumn.EntMainMajorId - 1)))?null:(System.Decimal?)reader[((int)SvStaffEvlColumn.EntMainMajorId - 1)];
			entity.EntMainMinorId = (reader.IsDBNull(((int)SvStaffEvlColumn.EntMainMinorId - 1)))?null:(System.Decimal?)reader[((int)SvStaffEvlColumn.EntMainMinorId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)SvStaffEvlColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)SvStaffEvlColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvStaffEvl"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvStaffEvl"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvStaffEvl entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvStaffEvlId = (System.Decimal)dataRow["SV_STAFF_EVL_ID"];
			entity.OriginalSvStaffEvlId = (System.Decimal)dataRow["SV_STAFF_EVL_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EntMainId = Convert.IsDBNull(dataRow["ENT_MAIN_ID"]) ? null : (System.Decimal?)dataRow["ENT_MAIN_ID"];
			entity.EdCodeLevelId = Convert.IsDBNull(dataRow["ED_CODE_LEVEL_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_LEVEL_ID"];
			entity.SvCodeRatingSchmId = (System.Decimal)dataRow["SV_CODE_RATING_SCHM_ID"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.PubFlg = (System.Decimal)dataRow["PUB_FLG"];
			entity.EvalTitle = Convert.IsDBNull(dataRow["EVAL_TITLE"]) ? null : (System.String)dataRow["EVAL_TITLE"];
			entity.EvalDate = Convert.IsDBNull(dataRow["EVAL_DATE"]) ? null : (System.DateTime?)dataRow["EVAL_DATE"];
			entity.StudStaffFlg = Convert.IsDBNull(dataRow["STUD_STAFF_FLG"]) ? null : (System.Int32?)dataRow["STUD_STAFF_FLG"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.EvalDueDate = Convert.IsDBNull(dataRow["EVAL_DUE_DATE"]) ? null : (System.DateTime?)dataRow["EVAL_DUE_DATE"];
			entity.RegFlg = Convert.IsDBNull(dataRow["REG_FLG"]) ? null : (System.Boolean?)dataRow["REG_FLG"];
			entity.WaitFlg = Convert.IsDBNull(dataRow["WAIT_FLG"]) ? null : (System.Boolean?)dataRow["WAIT_FLG"];
			entity.RsltFlg = Convert.IsDBNull(dataRow["RSLT_FLG"]) ? null : (System.Boolean?)dataRow["RSLT_FLG"];
			entity.TmpltFlg = Convert.IsDBNull(dataRow["TMPLT_FLG"]) ? null : (System.Boolean?)dataRow["TMPLT_FLG"];
			entity.EntMainMajorId = Convert.IsDBNull(dataRow["ENT_MAIN_MAJOR_ID"]) ? null : (System.Decimal?)dataRow["ENT_MAIN_MAJOR_ID"];
			entity.EntMainMinorId = Convert.IsDBNull(dataRow["ENT_MAIN_MINOR_ID"]) ? null : (System.Decimal?)dataRow["ENT_MAIN_MINOR_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvStaffEvl"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvStaffEvl Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStaffEvl entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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

			#region SvCodeRatingSchmIdSource	
			if (CanDeepLoad(entity, "SvCodeRatingSchm|SvCodeRatingSchmIdSource", deepLoadType, innerList) 
				&& entity.SvCodeRatingSchmIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SvCodeRatingSchmId;
				SvCodeRatingSchm tmpEntity = EntityManager.LocateEntity<SvCodeRatingSchm>(EntityLocator.ConstructKeyFromPkItems(typeof(SvCodeRatingSchm), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvCodeRatingSchmIdSource = tmpEntity;
				else
					entity.SvCodeRatingSchmIdSource = DataRepository.SvCodeRatingSchmProvider.GetBySvCodeRatingSchmId(transactionManager, entity.SvCodeRatingSchmId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCodeRatingSchmIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvCodeRatingSchmIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvCodeRatingSchmProvider.DeepLoad(transactionManager, entity.SvCodeRatingSchmIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvCodeRatingSchmIdSource

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

			#region SeUserIdSource	
			if (CanDeepLoad(entity, "SeUser|SeUserIdSource", deepLoadType, innerList) 
				&& entity.SeUserIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeUserId ?? 0.0m);
				SeUser tmpEntity = EntityManager.LocateEntity<SeUser>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUser), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeUserIdSource = tmpEntity;
				else
					entity.SeUserIdSource = DataRepository.SeUserProvider.GetBySeUserId(transactionManager, (entity.SeUserId ?? 0.0m));		
				
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
			// Deep load child collections  - Call GetBySvStaffEvlId methods when available
			
			#region SvStaffEvalItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStaffEvalItem>|SvStaffEvalItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStaffEvalItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStaffEvalItemCollection = DataRepository.SvStaffEvalItemProvider.GetBySvCourseStfEvlId(transactionManager, entity.SvStaffEvlId);

				if (deep && entity.SvStaffEvalItemCollection.Count > 0)
				{
					deepHandles.Add("SvStaffEvalItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStaffEvalItem>) DataRepository.SvStaffEvalItemProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStaffEvalItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvStaffEvalExtCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStaffEvalExt>|SvStaffEvalExtCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStaffEvalExtCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStaffEvalExtCollection = DataRepository.SvStaffEvalExtProvider.GetBySvStaffEvlId(transactionManager, entity.SvStaffEvlId);

				if (deep && entity.SvStaffEvalExtCollection.Count > 0)
				{
					deepHandles.Add("SvStaffEvalExtCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStaffEvalExt>) DataRepository.SvStaffEvalExtProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStaffEvalExtCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvStaffEvl object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvStaffEvl instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvStaffEvl Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStaffEvl entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EntMainIdSource
			if (CanDeepSave(entity, "EntityMain|EntMainIdSource", deepSaveType, innerList) 
				&& entity.EntMainIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.EntMainIdSource);
				entity.EntMainId = entity.EntMainIdSource.EntMainId;
			}
			#endregion 
			
			#region SvCodeRatingSchmIdSource
			if (CanDeepSave(entity, "SvCodeRatingSchm|SvCodeRatingSchmIdSource", deepSaveType, innerList) 
				&& entity.SvCodeRatingSchmIdSource != null)
			{
				DataRepository.SvCodeRatingSchmProvider.Save(transactionManager, entity.SvCodeRatingSchmIdSource);
				entity.SvCodeRatingSchmId = entity.SvCodeRatingSchmIdSource.SvCodeRatingSchmId;
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
			
			#region EdCodeLevelIdSource
			if (CanDeepSave(entity, "EdCodeLevel|EdCodeLevelIdSource", deepSaveType, innerList) 
				&& entity.EdCodeLevelIdSource != null)
			{
				DataRepository.EdCodeLevelProvider.Save(transactionManager, entity.EdCodeLevelIdSource);
				entity.EdCodeLevelId = entity.EdCodeLevelIdSource.EdCodeLevelId;
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
	
			#region List<SvStaffEvalItem>
				if (CanDeepSave(entity.SvStaffEvalItemCollection, "List<SvStaffEvalItem>|SvStaffEvalItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStaffEvalItem child in entity.SvStaffEvalItemCollection)
					{
						if(child.SvCourseStfEvlIdSource != null)
						{
							child.SvCourseStfEvlId = child.SvCourseStfEvlIdSource.SvStaffEvlId;
						}
						else
						{
							child.SvCourseStfEvlId = entity.SvStaffEvlId;
						}

					}

					if (entity.SvStaffEvalItemCollection.Count > 0 || entity.SvStaffEvalItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStaffEvalItemProvider.Save(transactionManager, entity.SvStaffEvalItemCollection);
						
						deepHandles.Add("SvStaffEvalItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStaffEvalItem >) DataRepository.SvStaffEvalItemProvider.DeepSave,
							new object[] { transactionManager, entity.SvStaffEvalItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvStaffEvalExt>
				if (CanDeepSave(entity.SvStaffEvalExtCollection, "List<SvStaffEvalExt>|SvStaffEvalExtCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStaffEvalExt child in entity.SvStaffEvalExtCollection)
					{
						if(child.SvStaffEvlIdSource != null)
						{
							child.SvStaffEvlId = child.SvStaffEvlIdSource.SvStaffEvlId;
						}
						else
						{
							child.SvStaffEvlId = entity.SvStaffEvlId;
						}

					}

					if (entity.SvStaffEvalExtCollection.Count > 0 || entity.SvStaffEvalExtCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStaffEvalExtProvider.Save(transactionManager, entity.SvStaffEvalExtCollection);
						
						deepHandles.Add("SvStaffEvalExtCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStaffEvalExt >) DataRepository.SvStaffEvalExtProvider.DeepSave,
							new object[] { transactionManager, entity.SvStaffEvalExtCollection, deepSaveType, childTypes, innerList }
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
	
	#region SvStaffEvlChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvStaffEvl</c>
	///</summary>
	public enum SvStaffEvlChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		
		///<summary>
		/// Composite Property for <c>SvCodeRatingSchm</c> at SvCodeRatingSchmIdSource
		///</summary>
		[ChildEntityType(typeof(SvCodeRatingSchm))]
		SvCodeRatingSchm,
		
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
		/// Composite Property for <c>EdCodeLevel</c> at EdCodeLevelIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeLevel))]
		EdCodeLevel,
		
		///<summary>
		/// Composite Property for <c>EdCodeSemester</c> at EdCodeSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemester))]
		EdCodeSemester,
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at SeUserIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
		///<summary>
		/// Collection of <c>SvStaffEvl</c> as OneToMany for SvStaffEvalItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStaffEvalItem>))]
		SvStaffEvalItemCollection,
		///<summary>
		/// Collection of <c>SvStaffEvl</c> as OneToMany for SvStaffEvalExtCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStaffEvalExt>))]
		SvStaffEvalExtCollection,
	}
	
	#endregion SvStaffEvlChildEntityTypes
	
	#region SvStaffEvlFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvStaffEvlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvStaffEvl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvStaffEvlFilterBuilder : SqlFilterBuilder<SvStaffEvlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvStaffEvlFilterBuilder class.
		/// </summary>
		public SvStaffEvlFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvStaffEvlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvStaffEvlFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvStaffEvlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvStaffEvlFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvStaffEvlFilterBuilder
	
	#region SvStaffEvlParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvStaffEvlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvStaffEvl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvStaffEvlParameterBuilder : ParameterizedSqlFilterBuilder<SvStaffEvlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvStaffEvlParameterBuilder class.
		/// </summary>
		public SvStaffEvlParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvStaffEvlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvStaffEvlParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvStaffEvlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvStaffEvlParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvStaffEvlParameterBuilder
	
	#region SvStaffEvlSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvStaffEvlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvStaffEvl"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvStaffEvlSortBuilder : SqlSortBuilder<SvStaffEvlColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvStaffEvlSqlSortBuilder class.
		/// </summary>
		public SvStaffEvlSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvStaffEvlSortBuilder
	
} // end namespace
