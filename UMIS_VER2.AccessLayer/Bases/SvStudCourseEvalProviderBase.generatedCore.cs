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
	/// This class is the base class for any <see cref="SvStudCourseEvalProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvStudCourseEvalProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvStudCourseEval, UMIS_VER2.BusinessLyer.SvStudCourseEvalKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStudCourseEvalKey key)
		{
			return Delete(transactionManager, key.SvStudCourseEvalId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svStudCourseEvalId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _svStudCourseEvalId)
		{
			return Delete(null, _svStudCourseEvalId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStudCourseEvalId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _svStudCourseEvalId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COURSE_EVAL_ED_COURSE key.
		///		FK_SV_STUD_COURSE_EVAL_ED_COURSE Description: 
		/// </summary>
		/// <param name="_edCourseId">OHI in case of survey course all ED_SCOURSE_ID=null</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudCourseEval objects.</returns>
		public TList<SvStudCourseEval> GetByEdCourseId(System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(_edCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COURSE_EVAL_ED_COURSE key.
		///		FK_SV_STUD_COURSE_EVAL_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId">OHI in case of survey course all ED_SCOURSE_ID=null</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudCourseEval objects.</returns>
		/// <remarks></remarks>
		public TList<SvStudCourseEval> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COURSE_EVAL_ED_COURSE key.
		///		FK_SV_STUD_COURSE_EVAL_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId">OHI in case of survey course all ED_SCOURSE_ID=null</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudCourseEval objects.</returns>
		public TList<SvStudCourseEval> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COURSE_EVAL_ED_COURSE key.
		///		fkSvStudCourseEvalEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId">OHI in case of survey course all ED_SCOURSE_ID=null</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudCourseEval objects.</returns>
		public TList<SvStudCourseEval> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COURSE_EVAL_ED_COURSE key.
		///		fkSvStudCourseEvalEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId">OHI in case of survey course all ED_SCOURSE_ID=null</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudCourseEval objects.</returns>
		public TList<SvStudCourseEval> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength,out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COURSE_EVAL_ED_COURSE key.
		///		FK_SV_STUD_COURSE_EVAL_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId">OHI in case of survey course all ED_SCOURSE_ID=null</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudCourseEval objects.</returns>
		public abstract TList<SvStudCourseEval> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SvStudCourseEval Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStudCourseEvalKey key, int start, int pageLength)
		{
			return GetBySvStudCourseEvalId(transactionManager, key.SvStudCourseEvalId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudCourseEval&gt;"/> class.</returns>
		public TList<SvStudCourseEval> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(null,_edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudCourseEval&gt;"/> class.</returns>
		public TList<SvStudCourseEval> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudCourseEval&gt;"/> class.</returns>
		public TList<SvStudCourseEval> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudCourseEval&gt;"/> class.</returns>
		public TList<SvStudCourseEval> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudCourseEval&gt;"/> class.</returns>
		public TList<SvStudCourseEval> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength, out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudCourseEval&gt;"/> class.</returns>
		public abstract TList<SvStudCourseEval> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SV_CODE_RATING_SCHM__1 index.
		/// </summary>
		/// <param name="_svCodeRatingSchmDtlId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudCourseEval&gt;"/> class.</returns>
		public TList<SvStudCourseEval> GetBySvCodeRatingSchmDtlId(System.Decimal _svCodeRatingSchmDtlId)
		{
			int count = -1;
			return GetBySvCodeRatingSchmDtlId(null,_svCodeRatingSchmDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_CODE_RATING_SCHM__1 index.
		/// </summary>
		/// <param name="_svCodeRatingSchmDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudCourseEval&gt;"/> class.</returns>
		public TList<SvStudCourseEval> GetBySvCodeRatingSchmDtlId(System.Decimal _svCodeRatingSchmDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCodeRatingSchmDtlId(null, _svCodeRatingSchmDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_CODE_RATING_SCHM__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeRatingSchmDtlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudCourseEval&gt;"/> class.</returns>
		public TList<SvStudCourseEval> GetBySvCodeRatingSchmDtlId(TransactionManager transactionManager, System.Decimal _svCodeRatingSchmDtlId)
		{
			int count = -1;
			return GetBySvCodeRatingSchmDtlId(transactionManager, _svCodeRatingSchmDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_CODE_RATING_SCHM__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeRatingSchmDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudCourseEval&gt;"/> class.</returns>
		public TList<SvStudCourseEval> GetBySvCodeRatingSchmDtlId(TransactionManager transactionManager, System.Decimal _svCodeRatingSchmDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCodeRatingSchmDtlId(transactionManager, _svCodeRatingSchmDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_CODE_RATING_SCHM__1 index.
		/// </summary>
		/// <param name="_svCodeRatingSchmDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudCourseEval&gt;"/> class.</returns>
		public TList<SvStudCourseEval> GetBySvCodeRatingSchmDtlId(System.Decimal _svCodeRatingSchmDtlId, int start, int pageLength, out int count)
		{
			return GetBySvCodeRatingSchmDtlId(null, _svCodeRatingSchmDtlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_CODE_RATING_SCHM__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeRatingSchmDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudCourseEval&gt;"/> class.</returns>
		public abstract TList<SvStudCourseEval> GetBySvCodeRatingSchmDtlId(TransactionManager transactionManager, System.Decimal _svCodeRatingSchmDtlId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SV_COURSE_EVAL_ITEM__1 index.
		/// </summary>
		/// <param name="_svCourseEvalItemId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudCourseEval&gt;"/> class.</returns>
		public TList<SvStudCourseEval> GetBySvCourseEvalItemId(System.Decimal _svCourseEvalItemId)
		{
			int count = -1;
			return GetBySvCourseEvalItemId(null,_svCourseEvalItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_COURSE_EVAL_ITEM__1 index.
		/// </summary>
		/// <param name="_svCourseEvalItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudCourseEval&gt;"/> class.</returns>
		public TList<SvStudCourseEval> GetBySvCourseEvalItemId(System.Decimal _svCourseEvalItemId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCourseEvalItemId(null, _svCourseEvalItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_COURSE_EVAL_ITEM__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseEvalItemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudCourseEval&gt;"/> class.</returns>
		public TList<SvStudCourseEval> GetBySvCourseEvalItemId(TransactionManager transactionManager, System.Decimal _svCourseEvalItemId)
		{
			int count = -1;
			return GetBySvCourseEvalItemId(transactionManager, _svCourseEvalItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_COURSE_EVAL_ITEM__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseEvalItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudCourseEval&gt;"/> class.</returns>
		public TList<SvStudCourseEval> GetBySvCourseEvalItemId(TransactionManager transactionManager, System.Decimal _svCourseEvalItemId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCourseEvalItemId(transactionManager, _svCourseEvalItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_COURSE_EVAL_ITEM__1 index.
		/// </summary>
		/// <param name="_svCourseEvalItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudCourseEval&gt;"/> class.</returns>
		public TList<SvStudCourseEval> GetBySvCourseEvalItemId(System.Decimal _svCourseEvalItemId, int start, int pageLength, out int count)
		{
			return GetBySvCourseEvalItemId(null, _svCourseEvalItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_COURSE_EVAL_ITEM__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseEvalItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudCourseEval&gt;"/> class.</returns>
		public abstract TList<SvStudCourseEval> GetBySvCourseEvalItemId(TransactionManager transactionManager, System.Decimal _svCourseEvalItemId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_STUD_COURSE_EVAL index.
		/// </summary>
		/// <param name="_svStudCourseEvalId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudCourseEval"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudCourseEval GetBySvStudCourseEvalId(System.Decimal _svStudCourseEvalId)
		{
			int count = -1;
			return GetBySvStudCourseEvalId(null,_svStudCourseEvalId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_COURSE_EVAL index.
		/// </summary>
		/// <param name="_svStudCourseEvalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudCourseEval"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudCourseEval GetBySvStudCourseEvalId(System.Decimal _svStudCourseEvalId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvStudCourseEvalId(null, _svStudCourseEvalId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_COURSE_EVAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStudCourseEvalId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudCourseEval"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudCourseEval GetBySvStudCourseEvalId(TransactionManager transactionManager, System.Decimal _svStudCourseEvalId)
		{
			int count = -1;
			return GetBySvStudCourseEvalId(transactionManager, _svStudCourseEvalId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_COURSE_EVAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStudCourseEvalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudCourseEval"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudCourseEval GetBySvStudCourseEvalId(TransactionManager transactionManager, System.Decimal _svStudCourseEvalId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvStudCourseEvalId(transactionManager, _svStudCourseEvalId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_COURSE_EVAL index.
		/// </summary>
		/// <param name="_svStudCourseEvalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudCourseEval"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudCourseEval GetBySvStudCourseEvalId(System.Decimal _svStudCourseEvalId, int start, int pageLength, out int count)
		{
			return GetBySvStudCourseEvalId(null, _svStudCourseEvalId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_COURSE_EVAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStudCourseEvalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudCourseEval"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvStudCourseEval GetBySvStudCourseEvalId(TransactionManager transactionManager, System.Decimal _svStudCourseEvalId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvStudCourseEval&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvStudCourseEval&gt;"/></returns>
		public static TList<SvStudCourseEval> Fill(IDataReader reader, TList<SvStudCourseEval> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvStudCourseEval c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvStudCourseEval")
					.Append("|").Append((System.Decimal)reader["SV_STUD_COURSE_EVAL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvStudCourseEval>(
					key.ToString(), // EntityTrackingKey
					"SvStudCourseEval",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvStudCourseEval();
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
					c.SvStudCourseEvalId = (System.Decimal)reader["SV_STUD_COURSE_EVAL_ID"];
					c.OriginalSvStudCourseEvalId = c.SvStudCourseEvalId;
					c.SvCourseEvalItemId = (System.Decimal)reader["SV_COURSE_EVAL_ITEM_ID"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.SvCodeRatingSchmDtlId = (System.Decimal)reader["SV_CODE_RATING_SCHM_DTL_ID"];
					c.EdCourseId = Convert.IsDBNull(reader["ED_COURSE_ID"]) ? null : (System.Decimal?)reader["ED_COURSE_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvStudCourseEval"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvStudCourseEval"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvStudCourseEval entity)
		{
			if (!reader.Read()) return;
			
			entity.SvStudCourseEvalId = (System.Decimal)reader[((int)SvStudCourseEvalColumn.SvStudCourseEvalId - 1)];
			entity.OriginalSvStudCourseEvalId = (System.Decimal)reader["SV_STUD_COURSE_EVAL_ID"];
			entity.SvCourseEvalItemId = (System.Decimal)reader[((int)SvStudCourseEvalColumn.SvCourseEvalItemId - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)SvStudCourseEvalColumn.EdStudId - 1)];
			entity.SvCodeRatingSchmDtlId = (System.Decimal)reader[((int)SvStudCourseEvalColumn.SvCodeRatingSchmDtlId - 1)];
			entity.EdCourseId = (reader.IsDBNull(((int)SvStudCourseEvalColumn.EdCourseId - 1)))?null:(System.Decimal?)reader[((int)SvStudCourseEvalColumn.EdCourseId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvStudCourseEval"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvStudCourseEval"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvStudCourseEval entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvStudCourseEvalId = (System.Decimal)dataRow["SV_STUD_COURSE_EVAL_ID"];
			entity.OriginalSvStudCourseEvalId = (System.Decimal)dataRow["SV_STUD_COURSE_EVAL_ID"];
			entity.SvCourseEvalItemId = (System.Decimal)dataRow["SV_COURSE_EVAL_ITEM_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.SvCodeRatingSchmDtlId = (System.Decimal)dataRow["SV_CODE_RATING_SCHM_DTL_ID"];
			entity.EdCourseId = Convert.IsDBNull(dataRow["ED_COURSE_ID"]) ? null : (System.Decimal?)dataRow["ED_COURSE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvStudCourseEval"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvStudCourseEval Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStudCourseEval entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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

			#region EdStudIdSource	
			if (CanDeepLoad(entity, "EdStud|EdStudIdSource", deepLoadType, innerList) 
				&& entity.EdStudIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudId;
				EdStud tmpEntity = EntityManager.LocateEntity<EdStud>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStud), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudIdSource = tmpEntity;
				else
					entity.EdStudIdSource = DataRepository.EdStudProvider.GetByEdStudId(transactionManager, entity.EdStudId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudProvider.DeepLoad(transactionManager, entity.EdStudIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudIdSource

			#region SvCodeRatingSchmDtlIdSource	
			if (CanDeepLoad(entity, "SvCodeRatingSchmDtl|SvCodeRatingSchmDtlIdSource", deepLoadType, innerList) 
				&& entity.SvCodeRatingSchmDtlIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SvCodeRatingSchmDtlId;
				SvCodeRatingSchmDtl tmpEntity = EntityManager.LocateEntity<SvCodeRatingSchmDtl>(EntityLocator.ConstructKeyFromPkItems(typeof(SvCodeRatingSchmDtl), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvCodeRatingSchmDtlIdSource = tmpEntity;
				else
					entity.SvCodeRatingSchmDtlIdSource = DataRepository.SvCodeRatingSchmDtlProvider.GetBySvCodeRatingSchmDtlId(transactionManager, entity.SvCodeRatingSchmDtlId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCodeRatingSchmDtlIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvCodeRatingSchmDtlIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvCodeRatingSchmDtlProvider.DeepLoad(transactionManager, entity.SvCodeRatingSchmDtlIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvCodeRatingSchmDtlIdSource

			#region SvCourseEvalItemIdSource	
			if (CanDeepLoad(entity, "SvCourseEvalItem|SvCourseEvalItemIdSource", deepLoadType, innerList) 
				&& entity.SvCourseEvalItemIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SvCourseEvalItemId;
				SvCourseEvalItem tmpEntity = EntityManager.LocateEntity<SvCourseEvalItem>(EntityLocator.ConstructKeyFromPkItems(typeof(SvCourseEvalItem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvCourseEvalItemIdSource = tmpEntity;
				else
					entity.SvCourseEvalItemIdSource = DataRepository.SvCourseEvalItemProvider.GetBySvCourseEvalItemId(transactionManager, entity.SvCourseEvalItemId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCourseEvalItemIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvCourseEvalItemIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvCourseEvalItemProvider.DeepLoad(transactionManager, entity.SvCourseEvalItemIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvCourseEvalItemIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvStudCourseEval object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvStudCourseEval instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvStudCourseEval Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStudCourseEval entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCourseIdSource
			if (CanDeepSave(entity, "EdCourse|EdCourseIdSource", deepSaveType, innerList) 
				&& entity.EdCourseIdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseIdSource);
				entity.EdCourseId = entity.EdCourseIdSource.EdCourseId;
			}
			#endregion 
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
			}
			#endregion 
			
			#region SvCodeRatingSchmDtlIdSource
			if (CanDeepSave(entity, "SvCodeRatingSchmDtl|SvCodeRatingSchmDtlIdSource", deepSaveType, innerList) 
				&& entity.SvCodeRatingSchmDtlIdSource != null)
			{
				DataRepository.SvCodeRatingSchmDtlProvider.Save(transactionManager, entity.SvCodeRatingSchmDtlIdSource);
				entity.SvCodeRatingSchmDtlId = entity.SvCodeRatingSchmDtlIdSource.SvCodeRatingSchmDtlId;
			}
			#endregion 
			
			#region SvCourseEvalItemIdSource
			if (CanDeepSave(entity, "SvCourseEvalItem|SvCourseEvalItemIdSource", deepSaveType, innerList) 
				&& entity.SvCourseEvalItemIdSource != null)
			{
				DataRepository.SvCourseEvalItemProvider.Save(transactionManager, entity.SvCourseEvalItemIdSource);
				entity.SvCourseEvalItemId = entity.SvCourseEvalItemIdSource.SvCourseEvalItemId;
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
	
	#region SvStudCourseEvalChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvStudCourseEval</c>
	///</summary>
	public enum SvStudCourseEvalChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>SvCodeRatingSchmDtl</c> at SvCodeRatingSchmDtlIdSource
		///</summary>
		[ChildEntityType(typeof(SvCodeRatingSchmDtl))]
		SvCodeRatingSchmDtl,
		
		///<summary>
		/// Composite Property for <c>SvCourseEvalItem</c> at SvCourseEvalItemIdSource
		///</summary>
		[ChildEntityType(typeof(SvCourseEvalItem))]
		SvCourseEvalItem,
	}
	
	#endregion SvStudCourseEvalChildEntityTypes
	
	#region SvStudCourseEvalFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvStudCourseEvalColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvStudCourseEval"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvStudCourseEvalFilterBuilder : SqlFilterBuilder<SvStudCourseEvalColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvStudCourseEvalFilterBuilder class.
		/// </summary>
		public SvStudCourseEvalFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvStudCourseEvalFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvStudCourseEvalFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvStudCourseEvalFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvStudCourseEvalFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvStudCourseEvalFilterBuilder
	
	#region SvStudCourseEvalParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvStudCourseEvalColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvStudCourseEval"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvStudCourseEvalParameterBuilder : ParameterizedSqlFilterBuilder<SvStudCourseEvalColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvStudCourseEvalParameterBuilder class.
		/// </summary>
		public SvStudCourseEvalParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvStudCourseEvalParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvStudCourseEvalParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvStudCourseEvalParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvStudCourseEvalParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvStudCourseEvalParameterBuilder
	
	#region SvStudCourseEvalSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvStudCourseEvalColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvStudCourseEval"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvStudCourseEvalSortBuilder : SqlSortBuilder<SvStudCourseEvalColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvStudCourseEvalSqlSortBuilder class.
		/// </summary>
		public SvStudCourseEvalSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvStudCourseEvalSortBuilder
	
} // end namespace
