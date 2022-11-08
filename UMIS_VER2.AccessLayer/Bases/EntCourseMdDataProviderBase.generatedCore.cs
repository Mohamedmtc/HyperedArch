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
	/// This class is the base class for any <see cref="EntCourseMdDataProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntCourseMdDataProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntCourseMdData, UMIS_VER2.BusinessLyer.EntCourseMdDataKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCourseMdDataKey key)
		{
			return Delete(transactionManager, key.EntCourseMdDataId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entCourseMdDataId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entCourseMdDataId)
		{
			return Delete(null, _entCourseMdDataId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCourseMdDataId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entCourseMdDataId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_MD_DATA_ED_ACAD_YEAR key.
		///		FK_ENT_COURSE_MD_DATA_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCourseMdData objects.</returns>
		public TList<EntCourseMdData> GetByEdAcadYearId(System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_MD_DATA_ED_ACAD_YEAR key.
		///		FK_ENT_COURSE_MD_DATA_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCourseMdData objects.</returns>
		/// <remarks></remarks>
		public TList<EntCourseMdData> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_MD_DATA_ED_ACAD_YEAR key.
		///		FK_ENT_COURSE_MD_DATA_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCourseMdData objects.</returns>
		public TList<EntCourseMdData> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_MD_DATA_ED_ACAD_YEAR key.
		///		fkEntCourseMdDataEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCourseMdData objects.</returns>
		public TList<EntCourseMdData> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_MD_DATA_ED_ACAD_YEAR key.
		///		fkEntCourseMdDataEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCourseMdData objects.</returns>
		public TList<EntCourseMdData> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_MD_DATA_ED_ACAD_YEAR key.
		///		FK_ENT_COURSE_MD_DATA_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCourseMdData objects.</returns>
		public abstract TList<EntCourseMdData> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_MD_DATA_ED_CODE_GRADING key.
		///		FK_ENT_COURSE_MD_DATA_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="_edCodeGradingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCourseMdData objects.</returns>
		public TList<EntCourseMdData> GetByEdCodeGradingId(System.Decimal? _edCodeGradingId)
		{
			int count = -1;
			return GetByEdCodeGradingId(_edCodeGradingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_MD_DATA_ED_CODE_GRADING key.
		///		FK_ENT_COURSE_MD_DATA_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCourseMdData objects.</returns>
		/// <remarks></remarks>
		public TList<EntCourseMdData> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _edCodeGradingId)
		{
			int count = -1;
			return GetByEdCodeGradingId(transactionManager, _edCodeGradingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_MD_DATA_ED_CODE_GRADING key.
		///		FK_ENT_COURSE_MD_DATA_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCourseMdData objects.</returns>
		public TList<EntCourseMdData> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _edCodeGradingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeGradingId(transactionManager, _edCodeGradingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_MD_DATA_ED_CODE_GRADING key.
		///		fkEntCourseMdDataEdCodeGrading Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeGradingId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCourseMdData objects.</returns>
		public TList<EntCourseMdData> GetByEdCodeGradingId(System.Decimal? _edCodeGradingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeGradingId(null, _edCodeGradingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_MD_DATA_ED_CODE_GRADING key.
		///		fkEntCourseMdDataEdCodeGrading Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeGradingId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCourseMdData objects.</returns>
		public TList<EntCourseMdData> GetByEdCodeGradingId(System.Decimal? _edCodeGradingId, int start, int pageLength,out int count)
		{
			return GetByEdCodeGradingId(null, _edCodeGradingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_MD_DATA_ED_CODE_GRADING key.
		///		FK_ENT_COURSE_MD_DATA_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCourseMdData objects.</returns>
		public abstract TList<EntCourseMdData> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _edCodeGradingId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EntCourseMdData Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCourseMdDataKey key, int start, int pageLength)
		{
			return GetByEntCourseMdDataId(transactionManager, key.EntCourseMdDataId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCourseMdData&gt;"/> class.</returns>
		public TList<EntCourseMdData> GetByEdCourseId(System.Decimal _edCourseId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCourseMdData&gt;"/> class.</returns>
		public TList<EntCourseMdData> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCourseMdData&gt;"/> class.</returns>
		public TList<EntCourseMdData> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCourseMdData&gt;"/> class.</returns>
		public TList<EntCourseMdData> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCourseMdData&gt;"/> class.</returns>
		public TList<EntCourseMdData> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCourseMdData&gt;"/> class.</returns>
		public abstract TList<EntCourseMdData> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_CODE_FULLFILL_MD_1 index.
		/// </summary>
		/// <param name="_entCodeFullfillMdId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCourseMdData&gt;"/> class.</returns>
		public TList<EntCourseMdData> GetByEntCodeFullfillMdId(System.Decimal? _entCodeFullfillMdId)
		{
			int count = -1;
			return GetByEntCodeFullfillMdId(null,_entCodeFullfillMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_FULLFILL_MD_1 index.
		/// </summary>
		/// <param name="_entCodeFullfillMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCourseMdData&gt;"/> class.</returns>
		public TList<EntCourseMdData> GetByEntCodeFullfillMdId(System.Decimal? _entCodeFullfillMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodeFullfillMdId(null, _entCodeFullfillMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_FULLFILL_MD_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeFullfillMdId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCourseMdData&gt;"/> class.</returns>
		public TList<EntCourseMdData> GetByEntCodeFullfillMdId(TransactionManager transactionManager, System.Decimal? _entCodeFullfillMdId)
		{
			int count = -1;
			return GetByEntCodeFullfillMdId(transactionManager, _entCodeFullfillMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_FULLFILL_MD_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeFullfillMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCourseMdData&gt;"/> class.</returns>
		public TList<EntCourseMdData> GetByEntCodeFullfillMdId(TransactionManager transactionManager, System.Decimal? _entCodeFullfillMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodeFullfillMdId(transactionManager, _entCodeFullfillMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_FULLFILL_MD_1 index.
		/// </summary>
		/// <param name="_entCodeFullfillMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCourseMdData&gt;"/> class.</returns>
		public TList<EntCourseMdData> GetByEntCodeFullfillMdId(System.Decimal? _entCodeFullfillMdId, int start, int pageLength, out int count)
		{
			return GetByEntCodeFullfillMdId(null, _entCodeFullfillMdId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_FULLFILL_MD_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeFullfillMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCourseMdData&gt;"/> class.</returns>
		public abstract TList<EntCourseMdData> GetByEntCodeFullfillMdId(TransactionManager transactionManager, System.Decimal? _entCodeFullfillMdId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_CODE_PRECOND_MD__1 index.
		/// </summary>
		/// <param name="_entCodePrecondMdId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCourseMdData&gt;"/> class.</returns>
		public TList<EntCourseMdData> GetByEntCodePrecondMdId(System.Decimal? _entCodePrecondMdId)
		{
			int count = -1;
			return GetByEntCodePrecondMdId(null,_entCodePrecondMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_PRECOND_MD__1 index.
		/// </summary>
		/// <param name="_entCodePrecondMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCourseMdData&gt;"/> class.</returns>
		public TList<EntCourseMdData> GetByEntCodePrecondMdId(System.Decimal? _entCodePrecondMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodePrecondMdId(null, _entCodePrecondMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_PRECOND_MD__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodePrecondMdId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCourseMdData&gt;"/> class.</returns>
		public TList<EntCourseMdData> GetByEntCodePrecondMdId(TransactionManager transactionManager, System.Decimal? _entCodePrecondMdId)
		{
			int count = -1;
			return GetByEntCodePrecondMdId(transactionManager, _entCodePrecondMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_PRECOND_MD__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodePrecondMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCourseMdData&gt;"/> class.</returns>
		public TList<EntCourseMdData> GetByEntCodePrecondMdId(TransactionManager transactionManager, System.Decimal? _entCodePrecondMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodePrecondMdId(transactionManager, _entCodePrecondMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_PRECOND_MD__1 index.
		/// </summary>
		/// <param name="_entCodePrecondMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCourseMdData&gt;"/> class.</returns>
		public TList<EntCourseMdData> GetByEntCodePrecondMdId(System.Decimal? _entCodePrecondMdId, int start, int pageLength, out int count)
		{
			return GetByEntCodePrecondMdId(null, _entCodePrecondMdId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_PRECOND_MD__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodePrecondMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCourseMdData&gt;"/> class.</returns>
		public abstract TList<EntCourseMdData> GetByEntCodePrecondMdId(TransactionManager transactionManager, System.Decimal? _entCodePrecondMdId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCourseMdData&gt;"/> class.</returns>
		public TList<EntCourseMdData> GetByEntMainId(System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(null,_entMainId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCourseMdData&gt;"/> class.</returns>
		public TList<EntCourseMdData> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCourseMdData&gt;"/> class.</returns>
		public TList<EntCourseMdData> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCourseMdData&gt;"/> class.</returns>
		public TList<EntCourseMdData> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCourseMdData&gt;"/> class.</returns>
		public TList<EntCourseMdData> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength, out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCourseMdData&gt;"/> class.</returns>
		public abstract TList<EntCourseMdData> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ENT_COURSE_MD_DATA index.
		/// </summary>
		/// <param name="_entCourseMdDataId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCourseMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCourseMdData GetByEntCourseMdDataId(System.Decimal _entCourseMdDataId)
		{
			int count = -1;
			return GetByEntCourseMdDataId(null,_entCourseMdDataId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_COURSE_MD_DATA index.
		/// </summary>
		/// <param name="_entCourseMdDataId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCourseMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCourseMdData GetByEntCourseMdDataId(System.Decimal _entCourseMdDataId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCourseMdDataId(null, _entCourseMdDataId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_COURSE_MD_DATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCourseMdDataId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCourseMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCourseMdData GetByEntCourseMdDataId(TransactionManager transactionManager, System.Decimal _entCourseMdDataId)
		{
			int count = -1;
			return GetByEntCourseMdDataId(transactionManager, _entCourseMdDataId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_COURSE_MD_DATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCourseMdDataId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCourseMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCourseMdData GetByEntCourseMdDataId(TransactionManager transactionManager, System.Decimal _entCourseMdDataId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCourseMdDataId(transactionManager, _entCourseMdDataId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_COURSE_MD_DATA index.
		/// </summary>
		/// <param name="_entCourseMdDataId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCourseMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCourseMdData GetByEntCourseMdDataId(System.Decimal _entCourseMdDataId, int start, int pageLength, out int count)
		{
			return GetByEntCourseMdDataId(null, _entCourseMdDataId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_COURSE_MD_DATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCourseMdDataId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCourseMdData"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntCourseMdData GetByEntCourseMdDataId(TransactionManager transactionManager, System.Decimal _entCourseMdDataId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntCourseMdData&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntCourseMdData&gt;"/></returns>
		public static TList<EntCourseMdData> Fill(IDataReader reader, TList<EntCourseMdData> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntCourseMdData c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntCourseMdData")
					.Append("|").Append((System.Decimal)reader["ENT_COURSE_MD_DATA_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntCourseMdData>(
					key.ToString(), // EntityTrackingKey
					"EntCourseMdData",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntCourseMdData();
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
					c.EntCourseMdDataId = (System.Decimal)reader["ENT_COURSE_MD_DATA_ID"];
					c.OriginalEntCourseMdDataId = c.EntCourseMdDataId;
					c.EntMainId = (System.Decimal)reader["ENT_MAIN_ID"];
					c.EdAcadYearId = Convert.IsDBNull(reader["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_ID"];
					c.EdCourseId = (System.Decimal)reader["ED_COURSE_ID"];
					c.EdCodeGradingId = Convert.IsDBNull(reader["ED_CODE_GRADING_ID"]) ? null : (System.Decimal?)reader["ED_CODE_GRADING_ID"];
					c.EntCodePrecondMdId = Convert.IsDBNull(reader["ENT_CODE_PRECOND_MD_ID"]) ? null : (System.Decimal?)reader["ENT_CODE_PRECOND_MD_ID"];
					c.EntCodeFullfillMdId = Convert.IsDBNull(reader["ENT_CODE_FULLFILL_MD_ID"]) ? null : (System.Decimal?)reader["ENT_CODE_FULLFILL_MD_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntCourseMdData"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntCourseMdData"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntCourseMdData entity)
		{
			if (!reader.Read()) return;
			
			entity.EntCourseMdDataId = (System.Decimal)reader[((int)EntCourseMdDataColumn.EntCourseMdDataId - 1)];
			entity.OriginalEntCourseMdDataId = (System.Decimal)reader["ENT_COURSE_MD_DATA_ID"];
			entity.EntMainId = (System.Decimal)reader[((int)EntCourseMdDataColumn.EntMainId - 1)];
			entity.EdAcadYearId = (reader.IsDBNull(((int)EntCourseMdDataColumn.EdAcadYearId - 1)))?null:(System.Decimal?)reader[((int)EntCourseMdDataColumn.EdAcadYearId - 1)];
			entity.EdCourseId = (System.Decimal)reader[((int)EntCourseMdDataColumn.EdCourseId - 1)];
			entity.EdCodeGradingId = (reader.IsDBNull(((int)EntCourseMdDataColumn.EdCodeGradingId - 1)))?null:(System.Decimal?)reader[((int)EntCourseMdDataColumn.EdCodeGradingId - 1)];
			entity.EntCodePrecondMdId = (reader.IsDBNull(((int)EntCourseMdDataColumn.EntCodePrecondMdId - 1)))?null:(System.Decimal?)reader[((int)EntCourseMdDataColumn.EntCodePrecondMdId - 1)];
			entity.EntCodeFullfillMdId = (reader.IsDBNull(((int)EntCourseMdDataColumn.EntCodeFullfillMdId - 1)))?null:(System.Decimal?)reader[((int)EntCourseMdDataColumn.EntCodeFullfillMdId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntCourseMdData"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntCourseMdData"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntCourseMdData entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntCourseMdDataId = (System.Decimal)dataRow["ENT_COURSE_MD_DATA_ID"];
			entity.OriginalEntCourseMdDataId = (System.Decimal)dataRow["ENT_COURSE_MD_DATA_ID"];
			entity.EntMainId = (System.Decimal)dataRow["ENT_MAIN_ID"];
			entity.EdAcadYearId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCourseId = (System.Decimal)dataRow["ED_COURSE_ID"];
			entity.EdCodeGradingId = Convert.IsDBNull(dataRow["ED_CODE_GRADING_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_GRADING_ID"];
			entity.EntCodePrecondMdId = Convert.IsDBNull(dataRow["ENT_CODE_PRECOND_MD_ID"]) ? null : (System.Decimal?)dataRow["ENT_CODE_PRECOND_MD_ID"];
			entity.EntCodeFullfillMdId = Convert.IsDBNull(dataRow["ENT_CODE_FULLFILL_MD_ID"]) ? null : (System.Decimal?)dataRow["ENT_CODE_FULLFILL_MD_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntCourseMdData"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntCourseMdData Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCourseMdData entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdAcadYearIdSource	
			if (CanDeepLoad(entity, "EdAcadYear|EdAcadYearIdSource", deepLoadType, innerList) 
				&& entity.EdAcadYearIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdAcadYearId ?? 0.0m);
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadYearIdSource = tmpEntity;
				else
					entity.EdAcadYearIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, (entity.EdAcadYearId ?? 0.0m));		
				
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

			#region EntCodeFullfillMdIdSource	
			if (CanDeepLoad(entity, "EntCodeFullfillMetadata|EntCodeFullfillMdIdSource", deepLoadType, innerList) 
				&& entity.EntCodeFullfillMdIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntCodeFullfillMdId ?? 0.0m);
				EntCodeFullfillMetadata tmpEntity = EntityManager.LocateEntity<EntCodeFullfillMetadata>(EntityLocator.ConstructKeyFromPkItems(typeof(EntCodeFullfillMetadata), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntCodeFullfillMdIdSource = tmpEntity;
				else
					entity.EntCodeFullfillMdIdSource = DataRepository.EntCodeFullfillMetadataProvider.GetByEntCodeFuulfillMdId(transactionManager, (entity.EntCodeFullfillMdId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCodeFullfillMdIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntCodeFullfillMdIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntCodeFullfillMetadataProvider.DeepLoad(transactionManager, entity.EntCodeFullfillMdIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntCodeFullfillMdIdSource

			#region EntCodePrecondMdIdSource	
			if (CanDeepLoad(entity, "EntCodePrecondMetadata|EntCodePrecondMdIdSource", deepLoadType, innerList) 
				&& entity.EntCodePrecondMdIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntCodePrecondMdId ?? 0.0m);
				EntCodePrecondMetadata tmpEntity = EntityManager.LocateEntity<EntCodePrecondMetadata>(EntityLocator.ConstructKeyFromPkItems(typeof(EntCodePrecondMetadata), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntCodePrecondMdIdSource = tmpEntity;
				else
					entity.EntCodePrecondMdIdSource = DataRepository.EntCodePrecondMetadataProvider.GetByEntCodePrecondMdId(transactionManager, (entity.EntCodePrecondMdId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCodePrecondMdIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntCodePrecondMdIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntCodePrecondMetadataProvider.DeepLoad(transactionManager, entity.EntCodePrecondMdIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntCodePrecondMdIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntCourseMdData object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntCourseMdData instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntCourseMdData Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCourseMdData entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdCodeGradingIdSource
			if (CanDeepSave(entity, "EdCodeGrading|EdCodeGradingIdSource", deepSaveType, innerList) 
				&& entity.EdCodeGradingIdSource != null)
			{
				DataRepository.EdCodeGradingProvider.Save(transactionManager, entity.EdCodeGradingIdSource);
				entity.EdCodeGradingId = entity.EdCodeGradingIdSource.EdCodeGradingId;
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
			
			#region EntCodeFullfillMdIdSource
			if (CanDeepSave(entity, "EntCodeFullfillMetadata|EntCodeFullfillMdIdSource", deepSaveType, innerList) 
				&& entity.EntCodeFullfillMdIdSource != null)
			{
				DataRepository.EntCodeFullfillMetadataProvider.Save(transactionManager, entity.EntCodeFullfillMdIdSource);
				entity.EntCodeFullfillMdId = entity.EntCodeFullfillMdIdSource.EntCodeFuulfillMdId;
			}
			#endregion 
			
			#region EntCodePrecondMdIdSource
			if (CanDeepSave(entity, "EntCodePrecondMetadata|EntCodePrecondMdIdSource", deepSaveType, innerList) 
				&& entity.EntCodePrecondMdIdSource != null)
			{
				DataRepository.EntCodePrecondMetadataProvider.Save(transactionManager, entity.EntCodePrecondMdIdSource);
				entity.EntCodePrecondMdId = entity.EntCodePrecondMdIdSource.EntCodePrecondMdId;
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
	
	#region EntCourseMdDataChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntCourseMdData</c>
	///</summary>
	public enum EntCourseMdDataChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>EdCodeGrading</c> at EdCodeGradingIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeGrading))]
		EdCodeGrading,
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
		
		///<summary>
		/// Composite Property for <c>EntCodeFullfillMetadata</c> at EntCodeFullfillMdIdSource
		///</summary>
		[ChildEntityType(typeof(EntCodeFullfillMetadata))]
		EntCodeFullfillMetadata,
		
		///<summary>
		/// Composite Property for <c>EntCodePrecondMetadata</c> at EntCodePrecondMdIdSource
		///</summary>
		[ChildEntityType(typeof(EntCodePrecondMetadata))]
		EntCodePrecondMetadata,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
	}
	
	#endregion EntCourseMdDataChildEntityTypes
	
	#region EntCourseMdDataFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntCourseMdDataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntCourseMdData"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntCourseMdDataFilterBuilder : SqlFilterBuilder<EntCourseMdDataColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntCourseMdDataFilterBuilder class.
		/// </summary>
		public EntCourseMdDataFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntCourseMdDataFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntCourseMdDataFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntCourseMdDataFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntCourseMdDataFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntCourseMdDataFilterBuilder
	
	#region EntCourseMdDataParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntCourseMdDataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntCourseMdData"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntCourseMdDataParameterBuilder : ParameterizedSqlFilterBuilder<EntCourseMdDataColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntCourseMdDataParameterBuilder class.
		/// </summary>
		public EntCourseMdDataParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntCourseMdDataParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntCourseMdDataParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntCourseMdDataParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntCourseMdDataParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntCourseMdDataParameterBuilder
	
	#region EntCourseMdDataSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntCourseMdDataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntCourseMdData"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntCourseMdDataSortBuilder : SqlSortBuilder<EntCourseMdDataColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntCourseMdDataSqlSortBuilder class.
		/// </summary>
		public EntCourseMdDataSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntCourseMdDataSortBuilder
	
} // end namespace
