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
	/// This class is the base class for any <see cref="SvCourseEvalProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvCourseEvalProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvCourseEval, UMIS_VER2.BusinessLyer.SvCourseEvalKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCourseEvalKey key)
		{
			return Delete(transactionManager, key.SvCourseEvalId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svCourseEvalId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _svCourseEvalId)
		{
			return Delete(null, _svCourseEvalId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseEvalId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _svCourseEvalId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_EVAL_ENTITY_MAIN key.
		///		FK_SV_COURSE_EVAL_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCourseEval objects.</returns>
		public TList<SvCourseEval> GetByEntMainId(System.Decimal? _entMainId)
		{
			int count = -1;
			return GetByEntMainId(_entMainId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_EVAL_ENTITY_MAIN key.
		///		FK_SV_COURSE_EVAL_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCourseEval objects.</returns>
		/// <remarks></remarks>
		public TList<SvCourseEval> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_EVAL_ENTITY_MAIN key.
		///		FK_SV_COURSE_EVAL_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCourseEval objects.</returns>
		public TList<SvCourseEval> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_EVAL_ENTITY_MAIN key.
		///		fkSvCourseEvalEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCourseEval objects.</returns>
		public TList<SvCourseEval> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainId(null, _entMainId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_EVAL_ENTITY_MAIN key.
		///		fkSvCourseEvalEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCourseEval objects.</returns>
		public TList<SvCourseEval> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength,out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_EVAL_ENTITY_MAIN key.
		///		FK_SV_COURSE_EVAL_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCourseEval objects.</returns>
		public abstract TList<SvCourseEval> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SvCourseEval Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCourseEvalKey key, int start, int pageLength)
		{
			return GetBySvCourseEvalId(transactionManager, key.SvCourseEvalId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEval&gt;"/> class.</returns>
		public TList<SvCourseEval> GetByEdAcadYearId(System.Decimal _edAcadYearId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEval&gt;"/> class.</returns>
		public TList<SvCourseEval> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEval&gt;"/> class.</returns>
		public TList<SvCourseEval> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEval&gt;"/> class.</returns>
		public TList<SvCourseEval> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEval&gt;"/> class.</returns>
		public TList<SvCourseEval> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEval&gt;"/> class.</returns>
		public abstract TList<SvCourseEval> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEval&gt;"/> class.</returns>
		public TList<SvCourseEval> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(null,_edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEval&gt;"/> class.</returns>
		public TList<SvCourseEval> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEval&gt;"/> class.</returns>
		public TList<SvCourseEval> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEval&gt;"/> class.</returns>
		public TList<SvCourseEval> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEval&gt;"/> class.</returns>
		public TList<SvCourseEval> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength, out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEval&gt;"/> class.</returns>
		public abstract TList<SvCourseEval> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEval&gt;"/> class.</returns>
		public TList<SvCourseEval> GetByEdCourseId(System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(null,_edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEval&gt;"/> class.</returns>
		public TList<SvCourseEval> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEval&gt;"/> class.</returns>
		public TList<SvCourseEval> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEval&gt;"/> class.</returns>
		public TList<SvCourseEval> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEval&gt;"/> class.</returns>
		public TList<SvCourseEval> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength, out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEval&gt;"/> class.</returns>
		public abstract TList<SvCourseEval> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SE_USER_ID_1 index.
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEval&gt;"/> class.</returns>
		public TList<SvCourseEval> GetBySeUserId(System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(null,_seUserId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_USER_ID_1 index.
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEval&gt;"/> class.</returns>
		public TList<SvCourseEval> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_USER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEval&gt;"/> class.</returns>
		public TList<SvCourseEval> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_USER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEval&gt;"/> class.</returns>
		public TList<SvCourseEval> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_USER_ID_1 index.
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEval&gt;"/> class.</returns>
		public TList<SvCourseEval> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength, out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_USER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEval&gt;"/> class.</returns>
		public abstract TList<SvCourseEval> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SV_CODE_RATING_SCHM__1 index.
		/// </summary>
		/// <param name="_svCodeRatingSchmId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEval&gt;"/> class.</returns>
		public TList<SvCourseEval> GetBySvCodeRatingSchmId(System.Decimal _svCodeRatingSchmId)
		{
			int count = -1;
			return GetBySvCodeRatingSchmId(null,_svCodeRatingSchmId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_CODE_RATING_SCHM__1 index.
		/// </summary>
		/// <param name="_svCodeRatingSchmId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEval&gt;"/> class.</returns>
		public TList<SvCourseEval> GetBySvCodeRatingSchmId(System.Decimal _svCodeRatingSchmId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCodeRatingSchmId(null, _svCodeRatingSchmId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_CODE_RATING_SCHM__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeRatingSchmId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEval&gt;"/> class.</returns>
		public TList<SvCourseEval> GetBySvCodeRatingSchmId(TransactionManager transactionManager, System.Decimal _svCodeRatingSchmId)
		{
			int count = -1;
			return GetBySvCodeRatingSchmId(transactionManager, _svCodeRatingSchmId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_CODE_RATING_SCHM__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeRatingSchmId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEval&gt;"/> class.</returns>
		public TList<SvCourseEval> GetBySvCodeRatingSchmId(TransactionManager transactionManager, System.Decimal _svCodeRatingSchmId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCodeRatingSchmId(transactionManager, _svCodeRatingSchmId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_CODE_RATING_SCHM__1 index.
		/// </summary>
		/// <param name="_svCodeRatingSchmId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEval&gt;"/> class.</returns>
		public TList<SvCourseEval> GetBySvCodeRatingSchmId(System.Decimal _svCodeRatingSchmId, int start, int pageLength, out int count)
		{
			return GetBySvCodeRatingSchmId(null, _svCodeRatingSchmId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_CODE_RATING_SCHM__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeRatingSchmId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEval&gt;"/> class.</returns>
		public abstract TList<SvCourseEval> GetBySvCodeRatingSchmId(TransactionManager transactionManager, System.Decimal _svCodeRatingSchmId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_COURSE_EVAL index.
		/// </summary>
		/// <param name="_svCourseEvalId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCourseEval"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCourseEval GetBySvCourseEvalId(System.Decimal _svCourseEvalId)
		{
			int count = -1;
			return GetBySvCourseEvalId(null,_svCourseEvalId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_COURSE_EVAL index.
		/// </summary>
		/// <param name="_svCourseEvalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCourseEval"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCourseEval GetBySvCourseEvalId(System.Decimal _svCourseEvalId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCourseEvalId(null, _svCourseEvalId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_COURSE_EVAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseEvalId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCourseEval"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCourseEval GetBySvCourseEvalId(TransactionManager transactionManager, System.Decimal _svCourseEvalId)
		{
			int count = -1;
			return GetBySvCourseEvalId(transactionManager, _svCourseEvalId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_COURSE_EVAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseEvalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCourseEval"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCourseEval GetBySvCourseEvalId(TransactionManager transactionManager, System.Decimal _svCourseEvalId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCourseEvalId(transactionManager, _svCourseEvalId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_COURSE_EVAL index.
		/// </summary>
		/// <param name="_svCourseEvalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCourseEval"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCourseEval GetBySvCourseEvalId(System.Decimal _svCourseEvalId, int start, int pageLength, out int count)
		{
			return GetBySvCourseEvalId(null, _svCourseEvalId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_COURSE_EVAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseEvalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCourseEval"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvCourseEval GetBySvCourseEvalId(TransactionManager transactionManager, System.Decimal _svCourseEvalId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvCourseEval&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvCourseEval&gt;"/></returns>
		public static TList<SvCourseEval> Fill(IDataReader reader, TList<SvCourseEval> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvCourseEval c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvCourseEval")
					.Append("|").Append((System.Decimal)reader["SV_COURSE_EVAL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvCourseEval>(
					key.ToString(), // EntityTrackingKey
					"SvCourseEval",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvCourseEval();
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
					c.SvCourseEvalId = (System.Decimal)reader["SV_COURSE_EVAL_ID"];
					c.OriginalSvCourseEvalId = c.SvCourseEvalId;
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EntMainId = Convert.IsDBNull(reader["ENT_MAIN_ID"]) ? null : (System.Decimal?)reader["ENT_MAIN_ID"];
					c.EdCourseId = Convert.IsDBNull(reader["ED_COURSE_ID"]) ? null : (System.Decimal?)reader["ED_COURSE_ID"];
					c.SvCodeRatingSchmId = (System.Decimal)reader["SV_CODE_RATING_SCHM_ID"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.PubFlg = (System.Decimal)reader["PUB_FLG"];
					c.EvalTitle = Convert.IsDBNull(reader["EVAL_TITLE"]) ? null : (System.String)reader["EVAL_TITLE"];
					c.EvalDate = Convert.IsDBNull(reader["EVAL_DATE"]) ? null : (System.DateTime?)reader["EVAL_DATE"];
					c.EvalDueDate = Convert.IsDBNull(reader["EVAL_DUE_DATE"]) ? null : (System.DateTime?)reader["EVAL_DUE_DATE"];
					c.RegFlg = Convert.IsDBNull(reader["REG_FLG"]) ? null : (System.Boolean?)reader["REG_FLG"];
					c.WaitFlg = Convert.IsDBNull(reader["WAIT_FLG"]) ? null : (System.Boolean?)reader["WAIT_FLG"];
					c.RsltFlg = Convert.IsDBNull(reader["RSLT_FLG"]) ? null : (System.Boolean?)reader["RSLT_FLG"];
					c.TmpltFlg = Convert.IsDBNull(reader["TMPLT_FLG"]) ? null : (System.Boolean?)reader["TMPLT_FLG"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvCourseEval"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCourseEval"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvCourseEval entity)
		{
			if (!reader.Read()) return;
			
			entity.SvCourseEvalId = (System.Decimal)reader[((int)SvCourseEvalColumn.SvCourseEvalId - 1)];
			entity.OriginalSvCourseEvalId = (System.Decimal)reader["SV_COURSE_EVAL_ID"];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)SvCourseEvalColumn.EdCodeSemesterId - 1)];
			entity.EdAcadYearId = (System.Decimal)reader[((int)SvCourseEvalColumn.EdAcadYearId - 1)];
			entity.EntMainId = (reader.IsDBNull(((int)SvCourseEvalColumn.EntMainId - 1)))?null:(System.Decimal?)reader[((int)SvCourseEvalColumn.EntMainId - 1)];
			entity.EdCourseId = (reader.IsDBNull(((int)SvCourseEvalColumn.EdCourseId - 1)))?null:(System.Decimal?)reader[((int)SvCourseEvalColumn.EdCourseId - 1)];
			entity.SvCodeRatingSchmId = (System.Decimal)reader[((int)SvCourseEvalColumn.SvCodeRatingSchmId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)SvCourseEvalColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)SvCourseEvalColumn.SeUserId - 1)];
			entity.PubFlg = (System.Decimal)reader[((int)SvCourseEvalColumn.PubFlg - 1)];
			entity.EvalTitle = (reader.IsDBNull(((int)SvCourseEvalColumn.EvalTitle - 1)))?null:(System.String)reader[((int)SvCourseEvalColumn.EvalTitle - 1)];
			entity.EvalDate = (reader.IsDBNull(((int)SvCourseEvalColumn.EvalDate - 1)))?null:(System.DateTime?)reader[((int)SvCourseEvalColumn.EvalDate - 1)];
			entity.EvalDueDate = (reader.IsDBNull(((int)SvCourseEvalColumn.EvalDueDate - 1)))?null:(System.DateTime?)reader[((int)SvCourseEvalColumn.EvalDueDate - 1)];
			entity.RegFlg = (reader.IsDBNull(((int)SvCourseEvalColumn.RegFlg - 1)))?null:(System.Boolean?)reader[((int)SvCourseEvalColumn.RegFlg - 1)];
			entity.WaitFlg = (reader.IsDBNull(((int)SvCourseEvalColumn.WaitFlg - 1)))?null:(System.Boolean?)reader[((int)SvCourseEvalColumn.WaitFlg - 1)];
			entity.RsltFlg = (reader.IsDBNull(((int)SvCourseEvalColumn.RsltFlg - 1)))?null:(System.Boolean?)reader[((int)SvCourseEvalColumn.RsltFlg - 1)];
			entity.TmpltFlg = (reader.IsDBNull(((int)SvCourseEvalColumn.TmpltFlg - 1)))?null:(System.Boolean?)reader[((int)SvCourseEvalColumn.TmpltFlg - 1)];
			entity.LastDate = (reader.IsDBNull(((int)SvCourseEvalColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)SvCourseEvalColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvCourseEval"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCourseEval"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvCourseEval entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvCourseEvalId = (System.Decimal)dataRow["SV_COURSE_EVAL_ID"];
			entity.OriginalSvCourseEvalId = (System.Decimal)dataRow["SV_COURSE_EVAL_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EntMainId = Convert.IsDBNull(dataRow["ENT_MAIN_ID"]) ? null : (System.Decimal?)dataRow["ENT_MAIN_ID"];
			entity.EdCourseId = Convert.IsDBNull(dataRow["ED_COURSE_ID"]) ? null : (System.Decimal?)dataRow["ED_COURSE_ID"];
			entity.SvCodeRatingSchmId = (System.Decimal)dataRow["SV_CODE_RATING_SCHM_ID"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.PubFlg = (System.Decimal)dataRow["PUB_FLG"];
			entity.EvalTitle = Convert.IsDBNull(dataRow["EVAL_TITLE"]) ? null : (System.String)dataRow["EVAL_TITLE"];
			entity.EvalDate = Convert.IsDBNull(dataRow["EVAL_DATE"]) ? null : (System.DateTime?)dataRow["EVAL_DATE"];
			entity.EvalDueDate = Convert.IsDBNull(dataRow["EVAL_DUE_DATE"]) ? null : (System.DateTime?)dataRow["EVAL_DUE_DATE"];
			entity.RegFlg = Convert.IsDBNull(dataRow["REG_FLG"]) ? null : (System.Boolean?)dataRow["REG_FLG"];
			entity.WaitFlg = Convert.IsDBNull(dataRow["WAIT_FLG"]) ? null : (System.Boolean?)dataRow["WAIT_FLG"];
			entity.RsltFlg = Convert.IsDBNull(dataRow["RSLT_FLG"]) ? null : (System.Boolean?)dataRow["RSLT_FLG"];
			entity.TmpltFlg = Convert.IsDBNull(dataRow["TMPLT_FLG"]) ? null : (System.Boolean?)dataRow["TMPLT_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCourseEval"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvCourseEval Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCourseEval entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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

			#region EdCourseIdSource	
			if (CanDeepLoad(entity, "EdCourse|EdCourseIdSource", deepLoadType, innerList) 
				&& entity.EdCourseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCourseId ?? 0.0m);
				EdCourse tmpEntity = EntityManager.LocateEntity<EdCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseIdSource = tmpEntity;
				else
					entity.EdCourseIdSource = DataRepository.EdCourseProvider.GetByEdCourseId(transactionManager, (entity.EdCourseId ?? 0.0m));		
				
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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySvCourseEvalId methods when available
			
			#region SvCourseEvalExtCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvCourseEvalExt>|SvCourseEvalExtCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCourseEvalExtCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvCourseEvalExtCollection = DataRepository.SvCourseEvalExtProvider.GetBySvCourseEvalId(transactionManager, entity.SvCourseEvalId);

				if (deep && entity.SvCourseEvalExtCollection.Count > 0)
				{
					deepHandles.Add("SvCourseEvalExtCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvCourseEvalExt>) DataRepository.SvCourseEvalExtProvider.DeepLoad,
						new object[] { transactionManager, entity.SvCourseEvalExtCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvCourseEvalItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvCourseEvalItem>|SvCourseEvalItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCourseEvalItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvCourseEvalItemCollection = DataRepository.SvCourseEvalItemProvider.GetBySvCourseEvalId(transactionManager, entity.SvCourseEvalId);

				if (deep && entity.SvCourseEvalItemCollection.Count > 0)
				{
					deepHandles.Add("SvCourseEvalItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvCourseEvalItem>) DataRepository.SvCourseEvalItemProvider.DeepLoad,
						new object[] { transactionManager, entity.SvCourseEvalItemCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvCourseEval object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvCourseEval instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvCourseEval Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCourseEval entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
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
			
			#region EdCourseIdSource
			if (CanDeepSave(entity, "EdCourse|EdCourseIdSource", deepSaveType, innerList) 
				&& entity.EdCourseIdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseIdSource);
				entity.EdCourseId = entity.EdCourseIdSource.EdCourseId;
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
			
			#region SvCodeRatingSchmIdSource
			if (CanDeepSave(entity, "SvCodeRatingSchm|SvCodeRatingSchmIdSource", deepSaveType, innerList) 
				&& entity.SvCodeRatingSchmIdSource != null)
			{
				DataRepository.SvCodeRatingSchmProvider.Save(transactionManager, entity.SvCodeRatingSchmIdSource);
				entity.SvCodeRatingSchmId = entity.SvCodeRatingSchmIdSource.SvCodeRatingSchmId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SvCourseEvalExt>
				if (CanDeepSave(entity.SvCourseEvalExtCollection, "List<SvCourseEvalExt>|SvCourseEvalExtCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvCourseEvalExt child in entity.SvCourseEvalExtCollection)
					{
						if(child.SvCourseEvalIdSource != null)
						{
							child.SvCourseEvalId = child.SvCourseEvalIdSource.SvCourseEvalId;
						}
						else
						{
							child.SvCourseEvalId = entity.SvCourseEvalId;
						}

					}

					if (entity.SvCourseEvalExtCollection.Count > 0 || entity.SvCourseEvalExtCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvCourseEvalExtProvider.Save(transactionManager, entity.SvCourseEvalExtCollection);
						
						deepHandles.Add("SvCourseEvalExtCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvCourseEvalExt >) DataRepository.SvCourseEvalExtProvider.DeepSave,
							new object[] { transactionManager, entity.SvCourseEvalExtCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvCourseEvalItem>
				if (CanDeepSave(entity.SvCourseEvalItemCollection, "List<SvCourseEvalItem>|SvCourseEvalItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvCourseEvalItem child in entity.SvCourseEvalItemCollection)
					{
						if(child.SvCourseEvalIdSource != null)
						{
							child.SvCourseEvalId = child.SvCourseEvalIdSource.SvCourseEvalId;
						}
						else
						{
							child.SvCourseEvalId = entity.SvCourseEvalId;
						}

					}

					if (entity.SvCourseEvalItemCollection.Count > 0 || entity.SvCourseEvalItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvCourseEvalItemProvider.Save(transactionManager, entity.SvCourseEvalItemCollection);
						
						deepHandles.Add("SvCourseEvalItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvCourseEvalItem >) DataRepository.SvCourseEvalItemProvider.DeepSave,
							new object[] { transactionManager, entity.SvCourseEvalItemCollection, deepSaveType, childTypes, innerList }
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
	
	#region SvCourseEvalChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvCourseEval</c>
	///</summary>
	public enum SvCourseEvalChildEntityTypes
	{
		
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
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
		
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
		/// Composite Property for <c>SvCodeRatingSchm</c> at SvCodeRatingSchmIdSource
		///</summary>
		[ChildEntityType(typeof(SvCodeRatingSchm))]
		SvCodeRatingSchm,
		///<summary>
		/// Collection of <c>SvCourseEval</c> as OneToMany for SvCourseEvalExtCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvCourseEvalExt>))]
		SvCourseEvalExtCollection,
		///<summary>
		/// Collection of <c>SvCourseEval</c> as OneToMany for SvCourseEvalItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvCourseEvalItem>))]
		SvCourseEvalItemCollection,
	}
	
	#endregion SvCourseEvalChildEntityTypes
	
	#region SvCourseEvalFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvCourseEvalColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCourseEval"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvCourseEvalFilterBuilder : SqlFilterBuilder<SvCourseEvalColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCourseEvalFilterBuilder class.
		/// </summary>
		public SvCourseEvalFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvCourseEvalFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvCourseEvalFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvCourseEvalFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvCourseEvalFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvCourseEvalFilterBuilder
	
	#region SvCourseEvalParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvCourseEvalColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCourseEval"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvCourseEvalParameterBuilder : ParameterizedSqlFilterBuilder<SvCourseEvalColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCourseEvalParameterBuilder class.
		/// </summary>
		public SvCourseEvalParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvCourseEvalParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvCourseEvalParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvCourseEvalParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvCourseEvalParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvCourseEvalParameterBuilder
	
	#region SvCourseEvalSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvCourseEvalColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCourseEval"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvCourseEvalSortBuilder : SqlSortBuilder<SvCourseEvalColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCourseEvalSqlSortBuilder class.
		/// </summary>
		public SvCourseEvalSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvCourseEvalSortBuilder
	
} // end namespace
