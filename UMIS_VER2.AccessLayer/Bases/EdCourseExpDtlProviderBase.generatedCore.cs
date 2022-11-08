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
	/// This class is the base class for any <see cref="EdCourseExpDtlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCourseExpDtlProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCourseExpDtl, UMIS_VER2.BusinessLyer.EdCourseExpDtlKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseExpDtlKey key)
		{
			return Delete(transactionManager, key.EdCourseExpDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCourseExpDtlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCourseExpDtlId)
		{
			return Delete(null, _edCourseExpDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseExpDtlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCourseExpDtlId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_EXPRESSION_ED_CODE_GRADING key.
		///		FK_ED_COURSE_EXPRESSION_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="_edCodeGradingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseExpDtl objects.</returns>
		public TList<EdCourseExpDtl> GetByEdCodeGradingId(System.Decimal? _edCodeGradingId)
		{
			int count = -1;
			return GetByEdCodeGradingId(_edCodeGradingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_EXPRESSION_ED_CODE_GRADING key.
		///		FK_ED_COURSE_EXPRESSION_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseExpDtl objects.</returns>
		/// <remarks></remarks>
		public TList<EdCourseExpDtl> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _edCodeGradingId)
		{
			int count = -1;
			return GetByEdCodeGradingId(transactionManager, _edCodeGradingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_EXPRESSION_ED_CODE_GRADING key.
		///		FK_ED_COURSE_EXPRESSION_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseExpDtl objects.</returns>
		public TList<EdCourseExpDtl> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _edCodeGradingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeGradingId(transactionManager, _edCodeGradingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_EXPRESSION_ED_CODE_GRADING key.
		///		fkEdCourseExpressionEdCodeGrading Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeGradingId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseExpDtl objects.</returns>
		public TList<EdCourseExpDtl> GetByEdCodeGradingId(System.Decimal? _edCodeGradingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeGradingId(null, _edCodeGradingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_EXPRESSION_ED_CODE_GRADING key.
		///		fkEdCourseExpressionEdCodeGrading Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeGradingId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseExpDtl objects.</returns>
		public TList<EdCourseExpDtl> GetByEdCodeGradingId(System.Decimal? _edCodeGradingId, int start, int pageLength,out int count)
		{
			return GetByEdCodeGradingId(null, _edCodeGradingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_EXPRESSION_ED_CODE_GRADING key.
		///		FK_ED_COURSE_EXPRESSION_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseExpDtl objects.</returns>
		public abstract TList<EdCourseExpDtl> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _edCodeGradingId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_EXPRESSION_ED_COURSE key.
		///		FK_ED_COURSE_EXPRESSION_ED_COURSE Description: 
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseExpDtl objects.</returns>
		public TList<EdCourseExpDtl> GetByEdCourseId(System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(_edCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_EXPRESSION_ED_COURSE key.
		///		FK_ED_COURSE_EXPRESSION_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseExpDtl objects.</returns>
		/// <remarks></remarks>
		public TList<EdCourseExpDtl> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_EXPRESSION_ED_COURSE key.
		///		FK_ED_COURSE_EXPRESSION_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseExpDtl objects.</returns>
		public TList<EdCourseExpDtl> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_EXPRESSION_ED_COURSE key.
		///		fkEdCourseExpressionEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseExpDtl objects.</returns>
		public TList<EdCourseExpDtl> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_EXPRESSION_ED_COURSE key.
		///		fkEdCourseExpressionEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseExpDtl objects.</returns>
		public TList<EdCourseExpDtl> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength,out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_EXPRESSION_ED_COURSE key.
		///		FK_ED_COURSE_EXPRESSION_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseExpDtl objects.</returns>
		public abstract TList<EdCourseExpDtl> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_EXPRESSION_ED_COURSE_EXP_HDR key.
		///		FK_ED_COURSE_EXPRESSION_ED_COURSE_EXP_HDR Description: 
		/// </summary>
		/// <param name="_edCourseExpHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseExpDtl objects.</returns>
		public TList<EdCourseExpDtl> GetByEdCourseExpHdrId(System.Decimal _edCourseExpHdrId)
		{
			int count = -1;
			return GetByEdCourseExpHdrId(_edCourseExpHdrId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_EXPRESSION_ED_COURSE_EXP_HDR key.
		///		FK_ED_COURSE_EXPRESSION_ED_COURSE_EXP_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseExpHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseExpDtl objects.</returns>
		/// <remarks></remarks>
		public TList<EdCourseExpDtl> GetByEdCourseExpHdrId(TransactionManager transactionManager, System.Decimal _edCourseExpHdrId)
		{
			int count = -1;
			return GetByEdCourseExpHdrId(transactionManager, _edCourseExpHdrId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_EXPRESSION_ED_COURSE_EXP_HDR key.
		///		FK_ED_COURSE_EXPRESSION_ED_COURSE_EXP_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseExpHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseExpDtl objects.</returns>
		public TList<EdCourseExpDtl> GetByEdCourseExpHdrId(TransactionManager transactionManager, System.Decimal _edCourseExpHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseExpHdrId(transactionManager, _edCourseExpHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_EXPRESSION_ED_COURSE_EXP_HDR key.
		///		fkEdCourseExpressionEdCourseExpHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseExpHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseExpDtl objects.</returns>
		public TList<EdCourseExpDtl> GetByEdCourseExpHdrId(System.Decimal _edCourseExpHdrId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseExpHdrId(null, _edCourseExpHdrId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_EXPRESSION_ED_COURSE_EXP_HDR key.
		///		fkEdCourseExpressionEdCourseExpHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseExpHdrId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseExpDtl objects.</returns>
		public TList<EdCourseExpDtl> GetByEdCourseExpHdrId(System.Decimal _edCourseExpHdrId, int start, int pageLength,out int count)
		{
			return GetByEdCourseExpHdrId(null, _edCourseExpHdrId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_EXPRESSION_ED_COURSE_EXP_HDR key.
		///		FK_ED_COURSE_EXPRESSION_ED_COURSE_EXP_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseExpHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseExpDtl objects.</returns>
		public abstract TList<EdCourseExpDtl> GetByEdCourseExpHdrId(TransactionManager transactionManager, System.Decimal _edCourseExpHdrId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_EXPRESSION_ED_COURSE_PRFX key.
		///		FK_ED_COURSE_EXPRESSION_ED_COURSE_PRFX Description: 
		/// </summary>
		/// <param name="_edCoursePrfxId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseExpDtl objects.</returns>
		public TList<EdCourseExpDtl> GetByEdCoursePrfxId(System.Decimal? _edCoursePrfxId)
		{
			int count = -1;
			return GetByEdCoursePrfxId(_edCoursePrfxId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_EXPRESSION_ED_COURSE_PRFX key.
		///		FK_ED_COURSE_EXPRESSION_ED_COURSE_PRFX Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCoursePrfxId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseExpDtl objects.</returns>
		/// <remarks></remarks>
		public TList<EdCourseExpDtl> GetByEdCoursePrfxId(TransactionManager transactionManager, System.Decimal? _edCoursePrfxId)
		{
			int count = -1;
			return GetByEdCoursePrfxId(transactionManager, _edCoursePrfxId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_EXPRESSION_ED_COURSE_PRFX key.
		///		FK_ED_COURSE_EXPRESSION_ED_COURSE_PRFX Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCoursePrfxId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseExpDtl objects.</returns>
		public TList<EdCourseExpDtl> GetByEdCoursePrfxId(TransactionManager transactionManager, System.Decimal? _edCoursePrfxId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCoursePrfxId(transactionManager, _edCoursePrfxId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_EXPRESSION_ED_COURSE_PRFX key.
		///		fkEdCourseExpressionEdCoursePrfx Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCoursePrfxId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseExpDtl objects.</returns>
		public TList<EdCourseExpDtl> GetByEdCoursePrfxId(System.Decimal? _edCoursePrfxId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCoursePrfxId(null, _edCoursePrfxId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_EXPRESSION_ED_COURSE_PRFX key.
		///		fkEdCourseExpressionEdCoursePrfx Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCoursePrfxId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseExpDtl objects.</returns>
		public TList<EdCourseExpDtl> GetByEdCoursePrfxId(System.Decimal? _edCoursePrfxId, int start, int pageLength,out int count)
		{
			return GetByEdCoursePrfxId(null, _edCoursePrfxId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_EXPRESSION_ED_COURSE_PRFX key.
		///		FK_ED_COURSE_EXPRESSION_ED_COURSE_PRFX Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCoursePrfxId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseExpDtl objects.</returns>
		public abstract TList<EdCourseExpDtl> GetByEdCoursePrfxId(TransactionManager transactionManager, System.Decimal? _edCoursePrfxId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdCourseExpDtl Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseExpDtlKey key, int start, int pageLength)
		{
			return GetByEdCourseExpDtlId(transactionManager, key.EdCourseExpDtlId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_COURSE_EXPRESSION index.
		/// </summary>
		/// <param name="_edCourseExpDtlId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseExpDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseExpDtl GetByEdCourseExpDtlId(System.Decimal _edCourseExpDtlId)
		{
			int count = -1;
			return GetByEdCourseExpDtlId(null,_edCourseExpDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_EXPRESSION index.
		/// </summary>
		/// <param name="_edCourseExpDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseExpDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseExpDtl GetByEdCourseExpDtlId(System.Decimal _edCourseExpDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseExpDtlId(null, _edCourseExpDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_EXPRESSION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseExpDtlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseExpDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseExpDtl GetByEdCourseExpDtlId(TransactionManager transactionManager, System.Decimal _edCourseExpDtlId)
		{
			int count = -1;
			return GetByEdCourseExpDtlId(transactionManager, _edCourseExpDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_EXPRESSION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseExpDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseExpDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseExpDtl GetByEdCourseExpDtlId(TransactionManager transactionManager, System.Decimal _edCourseExpDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseExpDtlId(transactionManager, _edCourseExpDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_EXPRESSION index.
		/// </summary>
		/// <param name="_edCourseExpDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseExpDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseExpDtl GetByEdCourseExpDtlId(System.Decimal _edCourseExpDtlId, int start, int pageLength, out int count)
		{
			return GetByEdCourseExpDtlId(null, _edCourseExpDtlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_EXPRESSION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseExpDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseExpDtl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCourseExpDtl GetByEdCourseExpDtlId(TransactionManager transactionManager, System.Decimal _edCourseExpDtlId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCourseExpDtl&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCourseExpDtl&gt;"/></returns>
		public static TList<EdCourseExpDtl> Fill(IDataReader reader, TList<EdCourseExpDtl> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCourseExpDtl c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCourseExpDtl")
					.Append("|").Append((System.Decimal)reader["ED_COURSE_EXP_DTL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCourseExpDtl>(
					key.ToString(), // EntityTrackingKey
					"EdCourseExpDtl",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCourseExpDtl();
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
					c.EdCourseExpDtlId = (System.Decimal)reader["ED_COURSE_EXP_DTL_ID"];
					c.OriginalEdCourseExpDtlId = c.EdCourseExpDtlId;
					c.EdCourseExpHdrId = (System.Decimal)reader["ED_COURSE_EXP_HDR_ID"];
					c.RecType = Convert.IsDBNull(reader["REC_TYPE"]) ? null : (System.Decimal?)reader["REC_TYPE"];
					c.EdCourseId = Convert.IsDBNull(reader["ED_COURSE_ID"]) ? null : (System.Decimal?)reader["ED_COURSE_ID"];
					c.EdCoursePrfxId = Convert.IsDBNull(reader["ED_COURSE_PRFX_ID"]) ? null : (System.Decimal?)reader["ED_COURSE_PRFX_ID"];
					c.CrsNumber = Convert.IsDBNull(reader["CRS_NUMBER"]) ? null : (System.String)reader["CRS_NUMBER"];
					c.EdCodeGradingId = Convert.IsDBNull(reader["ED_CODE_GRADING_ID"]) ? null : (System.Decimal?)reader["ED_CODE_GRADING_ID"];
					c.MinCh = Convert.IsDBNull(reader["MIN_CH"]) ? null : (System.Decimal?)reader["MIN_CH"];
					c.MinMjrCh = Convert.IsDBNull(reader["MIN_MJR_CH"]) ? null : (System.Decimal?)reader["MIN_MJR_CH"];
					c.MinCgpa = Convert.IsDBNull(reader["MIN_CGPA"]) ? null : (System.Decimal?)reader["MIN_CGPA"];
					c.MinMjrCgpa = Convert.IsDBNull(reader["MIN_MJR_CGPA"]) ? null : (System.Decimal?)reader["MIN_MJR_CGPA"];
					c.LogOpr = Convert.IsDBNull(reader["LOG_OPR"]) ? null : (System.String)reader["LOG_OPR"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCourseExpDtl"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCourseExpDtl"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCourseExpDtl entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCourseExpDtlId = (System.Decimal)reader[((int)EdCourseExpDtlColumn.EdCourseExpDtlId - 1)];
			entity.OriginalEdCourseExpDtlId = (System.Decimal)reader["ED_COURSE_EXP_DTL_ID"];
			entity.EdCourseExpHdrId = (System.Decimal)reader[((int)EdCourseExpDtlColumn.EdCourseExpHdrId - 1)];
			entity.RecType = (reader.IsDBNull(((int)EdCourseExpDtlColumn.RecType - 1)))?null:(System.Decimal?)reader[((int)EdCourseExpDtlColumn.RecType - 1)];
			entity.EdCourseId = (reader.IsDBNull(((int)EdCourseExpDtlColumn.EdCourseId - 1)))?null:(System.Decimal?)reader[((int)EdCourseExpDtlColumn.EdCourseId - 1)];
			entity.EdCoursePrfxId = (reader.IsDBNull(((int)EdCourseExpDtlColumn.EdCoursePrfxId - 1)))?null:(System.Decimal?)reader[((int)EdCourseExpDtlColumn.EdCoursePrfxId - 1)];
			entity.CrsNumber = (reader.IsDBNull(((int)EdCourseExpDtlColumn.CrsNumber - 1)))?null:(System.String)reader[((int)EdCourseExpDtlColumn.CrsNumber - 1)];
			entity.EdCodeGradingId = (reader.IsDBNull(((int)EdCourseExpDtlColumn.EdCodeGradingId - 1)))?null:(System.Decimal?)reader[((int)EdCourseExpDtlColumn.EdCodeGradingId - 1)];
			entity.MinCh = (reader.IsDBNull(((int)EdCourseExpDtlColumn.MinCh - 1)))?null:(System.Decimal?)reader[((int)EdCourseExpDtlColumn.MinCh - 1)];
			entity.MinMjrCh = (reader.IsDBNull(((int)EdCourseExpDtlColumn.MinMjrCh - 1)))?null:(System.Decimal?)reader[((int)EdCourseExpDtlColumn.MinMjrCh - 1)];
			entity.MinCgpa = (reader.IsDBNull(((int)EdCourseExpDtlColumn.MinCgpa - 1)))?null:(System.Decimal?)reader[((int)EdCourseExpDtlColumn.MinCgpa - 1)];
			entity.MinMjrCgpa = (reader.IsDBNull(((int)EdCourseExpDtlColumn.MinMjrCgpa - 1)))?null:(System.Decimal?)reader[((int)EdCourseExpDtlColumn.MinMjrCgpa - 1)];
			entity.LogOpr = (reader.IsDBNull(((int)EdCourseExpDtlColumn.LogOpr - 1)))?null:(System.String)reader[((int)EdCourseExpDtlColumn.LogOpr - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCourseExpDtl"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCourseExpDtl"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCourseExpDtl entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCourseExpDtlId = (System.Decimal)dataRow["ED_COURSE_EXP_DTL_ID"];
			entity.OriginalEdCourseExpDtlId = (System.Decimal)dataRow["ED_COURSE_EXP_DTL_ID"];
			entity.EdCourseExpHdrId = (System.Decimal)dataRow["ED_COURSE_EXP_HDR_ID"];
			entity.RecType = Convert.IsDBNull(dataRow["REC_TYPE"]) ? null : (System.Decimal?)dataRow["REC_TYPE"];
			entity.EdCourseId = Convert.IsDBNull(dataRow["ED_COURSE_ID"]) ? null : (System.Decimal?)dataRow["ED_COURSE_ID"];
			entity.EdCoursePrfxId = Convert.IsDBNull(dataRow["ED_COURSE_PRFX_ID"]) ? null : (System.Decimal?)dataRow["ED_COURSE_PRFX_ID"];
			entity.CrsNumber = Convert.IsDBNull(dataRow["CRS_NUMBER"]) ? null : (System.String)dataRow["CRS_NUMBER"];
			entity.EdCodeGradingId = Convert.IsDBNull(dataRow["ED_CODE_GRADING_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_GRADING_ID"];
			entity.MinCh = Convert.IsDBNull(dataRow["MIN_CH"]) ? null : (System.Decimal?)dataRow["MIN_CH"];
			entity.MinMjrCh = Convert.IsDBNull(dataRow["MIN_MJR_CH"]) ? null : (System.Decimal?)dataRow["MIN_MJR_CH"];
			entity.MinCgpa = Convert.IsDBNull(dataRow["MIN_CGPA"]) ? null : (System.Decimal?)dataRow["MIN_CGPA"];
			entity.MinMjrCgpa = Convert.IsDBNull(dataRow["MIN_MJR_CGPA"]) ? null : (System.Decimal?)dataRow["MIN_MJR_CGPA"];
			entity.LogOpr = Convert.IsDBNull(dataRow["LOG_OPR"]) ? null : (System.String)dataRow["LOG_OPR"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCourseExpDtl"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCourseExpDtl Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseExpDtl entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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

			#region EdCourseExpHdrIdSource	
			if (CanDeepLoad(entity, "EdCourseExpHdr|EdCourseExpHdrIdSource", deepLoadType, innerList) 
				&& entity.EdCourseExpHdrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCourseExpHdrId;
				EdCourseExpHdr tmpEntity = EntityManager.LocateEntity<EdCourseExpHdr>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourseExpHdr), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseExpHdrIdSource = tmpEntity;
				else
					entity.EdCourseExpHdrIdSource = DataRepository.EdCourseExpHdrProvider.GetByEdCourseExpHdrId(transactionManager, entity.EdCourseExpHdrId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseExpHdrIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCourseExpHdrIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCourseExpHdrProvider.DeepLoad(transactionManager, entity.EdCourseExpHdrIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCourseExpHdrIdSource

			#region EdCoursePrfxIdSource	
			if (CanDeepLoad(entity, "EdCoursePrfx|EdCoursePrfxIdSource", deepLoadType, innerList) 
				&& entity.EdCoursePrfxIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCoursePrfxId ?? 0.0m);
				EdCoursePrfx tmpEntity = EntityManager.LocateEntity<EdCoursePrfx>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCoursePrfx), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCoursePrfxIdSource = tmpEntity;
				else
					entity.EdCoursePrfxIdSource = DataRepository.EdCoursePrfxProvider.GetByEdCoursePrfxId(transactionManager, (entity.EdCoursePrfxId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCoursePrfxIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCoursePrfxIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCoursePrfxProvider.DeepLoad(transactionManager, entity.EdCoursePrfxIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCoursePrfxIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCourseExpDtl object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCourseExpDtl instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCourseExpDtl Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseExpDtl entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
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
			
			#region EdCourseExpHdrIdSource
			if (CanDeepSave(entity, "EdCourseExpHdr|EdCourseExpHdrIdSource", deepSaveType, innerList) 
				&& entity.EdCourseExpHdrIdSource != null)
			{
				DataRepository.EdCourseExpHdrProvider.Save(transactionManager, entity.EdCourseExpHdrIdSource);
				entity.EdCourseExpHdrId = entity.EdCourseExpHdrIdSource.EdCourseExpHdrId;
			}
			#endregion 
			
			#region EdCoursePrfxIdSource
			if (CanDeepSave(entity, "EdCoursePrfx|EdCoursePrfxIdSource", deepSaveType, innerList) 
				&& entity.EdCoursePrfxIdSource != null)
			{
				DataRepository.EdCoursePrfxProvider.Save(transactionManager, entity.EdCoursePrfxIdSource);
				entity.EdCoursePrfxId = entity.EdCoursePrfxIdSource.EdCoursePrfxId;
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
	
	#region EdCourseExpDtlChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCourseExpDtl</c>
	///</summary>
	public enum EdCourseExpDtlChildEntityTypes
	{
		
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
		/// Composite Property for <c>EdCourseExpHdr</c> at EdCourseExpHdrIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourseExpHdr))]
		EdCourseExpHdr,
		
		///<summary>
		/// Composite Property for <c>EdCoursePrfx</c> at EdCoursePrfxIdSource
		///</summary>
		[ChildEntityType(typeof(EdCoursePrfx))]
		EdCoursePrfx,
	}
	
	#endregion EdCourseExpDtlChildEntityTypes
	
	#region EdCourseExpDtlFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCourseExpDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCourseExpDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCourseExpDtlFilterBuilder : SqlFilterBuilder<EdCourseExpDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCourseExpDtlFilterBuilder class.
		/// </summary>
		public EdCourseExpDtlFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCourseExpDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCourseExpDtlFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCourseExpDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCourseExpDtlFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCourseExpDtlFilterBuilder
	
	#region EdCourseExpDtlParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCourseExpDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCourseExpDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCourseExpDtlParameterBuilder : ParameterizedSqlFilterBuilder<EdCourseExpDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCourseExpDtlParameterBuilder class.
		/// </summary>
		public EdCourseExpDtlParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCourseExpDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCourseExpDtlParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCourseExpDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCourseExpDtlParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCourseExpDtlParameterBuilder
	
	#region EdCourseExpDtlSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCourseExpDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCourseExpDtl"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCourseExpDtlSortBuilder : SqlSortBuilder<EdCourseExpDtlColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCourseExpDtlSqlSortBuilder class.
		/// </summary>
		public EdCourseExpDtlSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCourseExpDtlSortBuilder
	
} // end namespace
