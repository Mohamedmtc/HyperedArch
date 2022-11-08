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
	/// This class is the base class for any <see cref="SvCourseEvalItemProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvCourseEvalItemProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvCourseEvalItem, UMIS_VER2.BusinessLyer.SvCourseEvalItemKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCourseEvalItemKey key)
		{
			return Delete(transactionManager, key.SvCourseEvalItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svCourseEvalItemId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _svCourseEvalItemId)
		{
			return Delete(null, _svCourseEvalItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseEvalItemId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _svCourseEvalItemId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_EVAL_ITEM_SV_CODE_RATING_SCHM key.
		///		FK_SV_COURSE_EVAL_ITEM_SV_CODE_RATING_SCHM Description: 
		/// </summary>
		/// <param name="_svCodeRatingSchmId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCourseEvalItem objects.</returns>
		public TList<SvCourseEvalItem> GetBySvCodeRatingSchmId(System.Decimal? _svCodeRatingSchmId)
		{
			int count = -1;
			return GetBySvCodeRatingSchmId(_svCodeRatingSchmId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_EVAL_ITEM_SV_CODE_RATING_SCHM key.
		///		FK_SV_COURSE_EVAL_ITEM_SV_CODE_RATING_SCHM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeRatingSchmId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCourseEvalItem objects.</returns>
		/// <remarks></remarks>
		public TList<SvCourseEvalItem> GetBySvCodeRatingSchmId(TransactionManager transactionManager, System.Decimal? _svCodeRatingSchmId)
		{
			int count = -1;
			return GetBySvCodeRatingSchmId(transactionManager, _svCodeRatingSchmId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_EVAL_ITEM_SV_CODE_RATING_SCHM key.
		///		FK_SV_COURSE_EVAL_ITEM_SV_CODE_RATING_SCHM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeRatingSchmId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCourseEvalItem objects.</returns>
		public TList<SvCourseEvalItem> GetBySvCodeRatingSchmId(TransactionManager transactionManager, System.Decimal? _svCodeRatingSchmId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCodeRatingSchmId(transactionManager, _svCodeRatingSchmId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_EVAL_ITEM_SV_CODE_RATING_SCHM key.
		///		fkSvCourseEvalItemSvCodeRatingSchm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCodeRatingSchmId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCourseEvalItem objects.</returns>
		public TList<SvCourseEvalItem> GetBySvCodeRatingSchmId(System.Decimal? _svCodeRatingSchmId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySvCodeRatingSchmId(null, _svCodeRatingSchmId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_EVAL_ITEM_SV_CODE_RATING_SCHM key.
		///		fkSvCourseEvalItemSvCodeRatingSchm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCodeRatingSchmId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCourseEvalItem objects.</returns>
		public TList<SvCourseEvalItem> GetBySvCodeRatingSchmId(System.Decimal? _svCodeRatingSchmId, int start, int pageLength,out int count)
		{
			return GetBySvCodeRatingSchmId(null, _svCodeRatingSchmId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_EVAL_ITEM_SV_CODE_RATING_SCHM key.
		///		FK_SV_COURSE_EVAL_ITEM_SV_CODE_RATING_SCHM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeRatingSchmId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCourseEvalItem objects.</returns>
		public abstract TList<SvCourseEvalItem> GetBySvCodeRatingSchmId(TransactionManager transactionManager, System.Decimal? _svCodeRatingSchmId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SvCourseEvalItem Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCourseEvalItemKey key, int start, int pageLength)
		{
			return GetBySvCourseEvalItemId(transactionManager, key.SvCourseEvalItemId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SV_CODE_EVAL_ITEM_ID_1 index.
		/// </summary>
		/// <param name="_svCodeEvalItemId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEvalItem&gt;"/> class.</returns>
		public TList<SvCourseEvalItem> GetBySvCodeEvalItemId(System.Decimal _svCodeEvalItemId)
		{
			int count = -1;
			return GetBySvCodeEvalItemId(null,_svCodeEvalItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_CODE_EVAL_ITEM_ID_1 index.
		/// </summary>
		/// <param name="_svCodeEvalItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEvalItem&gt;"/> class.</returns>
		public TList<SvCourseEvalItem> GetBySvCodeEvalItemId(System.Decimal _svCodeEvalItemId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCodeEvalItemId(null, _svCodeEvalItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_CODE_EVAL_ITEM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeEvalItemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEvalItem&gt;"/> class.</returns>
		public TList<SvCourseEvalItem> GetBySvCodeEvalItemId(TransactionManager transactionManager, System.Decimal _svCodeEvalItemId)
		{
			int count = -1;
			return GetBySvCodeEvalItemId(transactionManager, _svCodeEvalItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_CODE_EVAL_ITEM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeEvalItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEvalItem&gt;"/> class.</returns>
		public TList<SvCourseEvalItem> GetBySvCodeEvalItemId(TransactionManager transactionManager, System.Decimal _svCodeEvalItemId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCodeEvalItemId(transactionManager, _svCodeEvalItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_CODE_EVAL_ITEM_ID_1 index.
		/// </summary>
		/// <param name="_svCodeEvalItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEvalItem&gt;"/> class.</returns>
		public TList<SvCourseEvalItem> GetBySvCodeEvalItemId(System.Decimal _svCodeEvalItemId, int start, int pageLength, out int count)
		{
			return GetBySvCodeEvalItemId(null, _svCodeEvalItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_CODE_EVAL_ITEM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeEvalItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEvalItem&gt;"/> class.</returns>
		public abstract TList<SvCourseEvalItem> GetBySvCodeEvalItemId(TransactionManager transactionManager, System.Decimal _svCodeEvalItemId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SV_COURSE_EVAL_ID_1 index.
		/// </summary>
		/// <param name="_svCourseEvalId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEvalItem&gt;"/> class.</returns>
		public TList<SvCourseEvalItem> GetBySvCourseEvalId(System.Decimal _svCourseEvalId)
		{
			int count = -1;
			return GetBySvCourseEvalId(null,_svCourseEvalId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_COURSE_EVAL_ID_1 index.
		/// </summary>
		/// <param name="_svCourseEvalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEvalItem&gt;"/> class.</returns>
		public TList<SvCourseEvalItem> GetBySvCourseEvalId(System.Decimal _svCourseEvalId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCourseEvalId(null, _svCourseEvalId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_COURSE_EVAL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseEvalId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEvalItem&gt;"/> class.</returns>
		public TList<SvCourseEvalItem> GetBySvCourseEvalId(TransactionManager transactionManager, System.Decimal _svCourseEvalId)
		{
			int count = -1;
			return GetBySvCourseEvalId(transactionManager, _svCourseEvalId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_COURSE_EVAL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseEvalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEvalItem&gt;"/> class.</returns>
		public TList<SvCourseEvalItem> GetBySvCourseEvalId(TransactionManager transactionManager, System.Decimal _svCourseEvalId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCourseEvalId(transactionManager, _svCourseEvalId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_COURSE_EVAL_ID_1 index.
		/// </summary>
		/// <param name="_svCourseEvalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEvalItem&gt;"/> class.</returns>
		public TList<SvCourseEvalItem> GetBySvCourseEvalId(System.Decimal _svCourseEvalId, int start, int pageLength, out int count)
		{
			return GetBySvCourseEvalId(null, _svCourseEvalId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_COURSE_EVAL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseEvalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEvalItem&gt;"/> class.</returns>
		public abstract TList<SvCourseEvalItem> GetBySvCourseEvalId(TransactionManager transactionManager, System.Decimal _svCourseEvalId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_COURSE_EVAL_ITEM index.
		/// </summary>
		/// <param name="_svCourseEvalItemId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCourseEvalItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCourseEvalItem GetBySvCourseEvalItemId(System.Decimal _svCourseEvalItemId)
		{
			int count = -1;
			return GetBySvCourseEvalItemId(null,_svCourseEvalItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_COURSE_EVAL_ITEM index.
		/// </summary>
		/// <param name="_svCourseEvalItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCourseEvalItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCourseEvalItem GetBySvCourseEvalItemId(System.Decimal _svCourseEvalItemId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCourseEvalItemId(null, _svCourseEvalItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_COURSE_EVAL_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseEvalItemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCourseEvalItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCourseEvalItem GetBySvCourseEvalItemId(TransactionManager transactionManager, System.Decimal _svCourseEvalItemId)
		{
			int count = -1;
			return GetBySvCourseEvalItemId(transactionManager, _svCourseEvalItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_COURSE_EVAL_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseEvalItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCourseEvalItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCourseEvalItem GetBySvCourseEvalItemId(TransactionManager transactionManager, System.Decimal _svCourseEvalItemId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCourseEvalItemId(transactionManager, _svCourseEvalItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_COURSE_EVAL_ITEM index.
		/// </summary>
		/// <param name="_svCourseEvalItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCourseEvalItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCourseEvalItem GetBySvCourseEvalItemId(System.Decimal _svCourseEvalItemId, int start, int pageLength, out int count)
		{
			return GetBySvCourseEvalItemId(null, _svCourseEvalItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_COURSE_EVAL_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseEvalItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCourseEvalItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvCourseEvalItem GetBySvCourseEvalItemId(TransactionManager transactionManager, System.Decimal _svCourseEvalItemId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SV_COURSE_EVAL_ITEM index.
		/// </summary>
		/// <param name="_svCourseEvalId"></param>
		/// <param name="_svCodeEvalItemId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCourseEvalItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCourseEvalItem GetBySvCourseEvalIdSvCodeEvalItemId(System.Decimal _svCourseEvalId, System.Decimal _svCodeEvalItemId)
		{
			int count = -1;
			return GetBySvCourseEvalIdSvCodeEvalItemId(null,_svCourseEvalId, _svCodeEvalItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_COURSE_EVAL_ITEM index.
		/// </summary>
		/// <param name="_svCourseEvalId"></param>
		/// <param name="_svCodeEvalItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCourseEvalItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCourseEvalItem GetBySvCourseEvalIdSvCodeEvalItemId(System.Decimal _svCourseEvalId, System.Decimal _svCodeEvalItemId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCourseEvalIdSvCodeEvalItemId(null, _svCourseEvalId, _svCodeEvalItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_COURSE_EVAL_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseEvalId"></param>
		/// <param name="_svCodeEvalItemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCourseEvalItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCourseEvalItem GetBySvCourseEvalIdSvCodeEvalItemId(TransactionManager transactionManager, System.Decimal _svCourseEvalId, System.Decimal _svCodeEvalItemId)
		{
			int count = -1;
			return GetBySvCourseEvalIdSvCodeEvalItemId(transactionManager, _svCourseEvalId, _svCodeEvalItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_COURSE_EVAL_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseEvalId"></param>
		/// <param name="_svCodeEvalItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCourseEvalItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCourseEvalItem GetBySvCourseEvalIdSvCodeEvalItemId(TransactionManager transactionManager, System.Decimal _svCourseEvalId, System.Decimal _svCodeEvalItemId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCourseEvalIdSvCodeEvalItemId(transactionManager, _svCourseEvalId, _svCodeEvalItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_COURSE_EVAL_ITEM index.
		/// </summary>
		/// <param name="_svCourseEvalId"></param>
		/// <param name="_svCodeEvalItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCourseEvalItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCourseEvalItem GetBySvCourseEvalIdSvCodeEvalItemId(System.Decimal _svCourseEvalId, System.Decimal _svCodeEvalItemId, int start, int pageLength, out int count)
		{
			return GetBySvCourseEvalIdSvCodeEvalItemId(null, _svCourseEvalId, _svCodeEvalItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_COURSE_EVAL_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseEvalId"></param>
		/// <param name="_svCodeEvalItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCourseEvalItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvCourseEvalItem GetBySvCourseEvalIdSvCodeEvalItemId(TransactionManager transactionManager, System.Decimal _svCourseEvalId, System.Decimal _svCodeEvalItemId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SV_COURSE_EVAL_ITEM_ORDR index.
		/// </summary>
		/// <param name="_svCourseEvalId"></param>
		/// <param name="_itemOrdr"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEvalItem&gt;"/> class.</returns>
		public TList<SvCourseEvalItem> GetBySvCourseEvalIdItemOrdr(System.Decimal _svCourseEvalId, System.Decimal? _itemOrdr)
		{
			int count = -1;
			return GetBySvCourseEvalIdItemOrdr(null,_svCourseEvalId, _itemOrdr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_COURSE_EVAL_ITEM_ORDR index.
		/// </summary>
		/// <param name="_svCourseEvalId"></param>
		/// <param name="_itemOrdr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEvalItem&gt;"/> class.</returns>
		public TList<SvCourseEvalItem> GetBySvCourseEvalIdItemOrdr(System.Decimal _svCourseEvalId, System.Decimal? _itemOrdr, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCourseEvalIdItemOrdr(null, _svCourseEvalId, _itemOrdr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_COURSE_EVAL_ITEM_ORDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseEvalId"></param>
		/// <param name="_itemOrdr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEvalItem&gt;"/> class.</returns>
		public TList<SvCourseEvalItem> GetBySvCourseEvalIdItemOrdr(TransactionManager transactionManager, System.Decimal _svCourseEvalId, System.Decimal? _itemOrdr)
		{
			int count = -1;
			return GetBySvCourseEvalIdItemOrdr(transactionManager, _svCourseEvalId, _itemOrdr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_COURSE_EVAL_ITEM_ORDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseEvalId"></param>
		/// <param name="_itemOrdr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEvalItem&gt;"/> class.</returns>
		public TList<SvCourseEvalItem> GetBySvCourseEvalIdItemOrdr(TransactionManager transactionManager, System.Decimal _svCourseEvalId, System.Decimal? _itemOrdr, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCourseEvalIdItemOrdr(transactionManager, _svCourseEvalId, _itemOrdr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_COURSE_EVAL_ITEM_ORDR index.
		/// </summary>
		/// <param name="_svCourseEvalId"></param>
		/// <param name="_itemOrdr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEvalItem&gt;"/> class.</returns>
		public TList<SvCourseEvalItem> GetBySvCourseEvalIdItemOrdr(System.Decimal _svCourseEvalId, System.Decimal? _itemOrdr, int start, int pageLength, out int count)
		{
			return GetBySvCourseEvalIdItemOrdr(null, _svCourseEvalId, _itemOrdr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_COURSE_EVAL_ITEM_ORDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseEvalId"></param>
		/// <param name="_itemOrdr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvCourseEvalItem&gt;"/> class.</returns>
		public abstract TList<SvCourseEvalItem> GetBySvCourseEvalIdItemOrdr(TransactionManager transactionManager, System.Decimal _svCourseEvalId, System.Decimal? _itemOrdr, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvCourseEvalItem&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvCourseEvalItem&gt;"/></returns>
		public static TList<SvCourseEvalItem> Fill(IDataReader reader, TList<SvCourseEvalItem> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvCourseEvalItem c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvCourseEvalItem")
					.Append("|").Append((System.Decimal)reader["SV_COURSE_EVAL_ITEM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvCourseEvalItem>(
					key.ToString(), // EntityTrackingKey
					"SvCourseEvalItem",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvCourseEvalItem();
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
					c.SvCourseEvalItemId = (System.Decimal)reader["SV_COURSE_EVAL_ITEM_ID"];
					c.OriginalSvCourseEvalItemId = c.SvCourseEvalItemId;
					c.SvCourseEvalId = (System.Decimal)reader["SV_COURSE_EVAL_ID"];
					c.SvCodeEvalItemId = (System.Decimal)reader["SV_CODE_EVAL_ITEM_ID"];
					c.ItemOrdr = Convert.IsDBNull(reader["ITEM_ORDR"]) ? null : (System.Decimal?)reader["ITEM_ORDR"];
					c.SvCodeRatingSchmId = Convert.IsDBNull(reader["SV_CODE_RATING_SCHM_ID"]) ? null : (System.Decimal?)reader["SV_CODE_RATING_SCHM_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvCourseEvalItem"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCourseEvalItem"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvCourseEvalItem entity)
		{
			if (!reader.Read()) return;
			
			entity.SvCourseEvalItemId = (System.Decimal)reader[((int)SvCourseEvalItemColumn.SvCourseEvalItemId - 1)];
			entity.OriginalSvCourseEvalItemId = (System.Decimal)reader["SV_COURSE_EVAL_ITEM_ID"];
			entity.SvCourseEvalId = (System.Decimal)reader[((int)SvCourseEvalItemColumn.SvCourseEvalId - 1)];
			entity.SvCodeEvalItemId = (System.Decimal)reader[((int)SvCourseEvalItemColumn.SvCodeEvalItemId - 1)];
			entity.ItemOrdr = (reader.IsDBNull(((int)SvCourseEvalItemColumn.ItemOrdr - 1)))?null:(System.Decimal?)reader[((int)SvCourseEvalItemColumn.ItemOrdr - 1)];
			entity.SvCodeRatingSchmId = (reader.IsDBNull(((int)SvCourseEvalItemColumn.SvCodeRatingSchmId - 1)))?null:(System.Decimal?)reader[((int)SvCourseEvalItemColumn.SvCodeRatingSchmId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvCourseEvalItem"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCourseEvalItem"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvCourseEvalItem entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvCourseEvalItemId = (System.Decimal)dataRow["SV_COURSE_EVAL_ITEM_ID"];
			entity.OriginalSvCourseEvalItemId = (System.Decimal)dataRow["SV_COURSE_EVAL_ITEM_ID"];
			entity.SvCourseEvalId = (System.Decimal)dataRow["SV_COURSE_EVAL_ID"];
			entity.SvCodeEvalItemId = (System.Decimal)dataRow["SV_CODE_EVAL_ITEM_ID"];
			entity.ItemOrdr = Convert.IsDBNull(dataRow["ITEM_ORDR"]) ? null : (System.Decimal?)dataRow["ITEM_ORDR"];
			entity.SvCodeRatingSchmId = Convert.IsDBNull(dataRow["SV_CODE_RATING_SCHM_ID"]) ? null : (System.Decimal?)dataRow["SV_CODE_RATING_SCHM_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCourseEvalItem"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvCourseEvalItem Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCourseEvalItem entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SvCodeEvalItemIdSource	
			if (CanDeepLoad(entity, "SvCodeEvalItem|SvCodeEvalItemIdSource", deepLoadType, innerList) 
				&& entity.SvCodeEvalItemIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SvCodeEvalItemId;
				SvCodeEvalItem tmpEntity = EntityManager.LocateEntity<SvCodeEvalItem>(EntityLocator.ConstructKeyFromPkItems(typeof(SvCodeEvalItem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvCodeEvalItemIdSource = tmpEntity;
				else
					entity.SvCodeEvalItemIdSource = DataRepository.SvCodeEvalItemProvider.GetBySvCodeEvalItemId(transactionManager, entity.SvCodeEvalItemId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCodeEvalItemIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvCodeEvalItemIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvCodeEvalItemProvider.DeepLoad(transactionManager, entity.SvCodeEvalItemIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvCodeEvalItemIdSource

			#region SvCodeRatingSchmIdSource	
			if (CanDeepLoad(entity, "SvCodeRatingSchm|SvCodeRatingSchmIdSource", deepLoadType, innerList) 
				&& entity.SvCodeRatingSchmIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SvCodeRatingSchmId ?? 0.0m);
				SvCodeRatingSchm tmpEntity = EntityManager.LocateEntity<SvCodeRatingSchm>(EntityLocator.ConstructKeyFromPkItems(typeof(SvCodeRatingSchm), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvCodeRatingSchmIdSource = tmpEntity;
				else
					entity.SvCodeRatingSchmIdSource = DataRepository.SvCodeRatingSchmProvider.GetBySvCodeRatingSchmId(transactionManager, (entity.SvCodeRatingSchmId ?? 0.0m));		
				
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

			#region SvCourseEvalIdSource	
			if (CanDeepLoad(entity, "SvCourseEval|SvCourseEvalIdSource", deepLoadType, innerList) 
				&& entity.SvCourseEvalIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SvCourseEvalId;
				SvCourseEval tmpEntity = EntityManager.LocateEntity<SvCourseEval>(EntityLocator.ConstructKeyFromPkItems(typeof(SvCourseEval), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvCourseEvalIdSource = tmpEntity;
				else
					entity.SvCourseEvalIdSource = DataRepository.SvCourseEvalProvider.GetBySvCourseEvalId(transactionManager, entity.SvCourseEvalId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCourseEvalIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvCourseEvalIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvCourseEvalProvider.DeepLoad(transactionManager, entity.SvCourseEvalIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvCourseEvalIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySvCourseEvalItemId methods when available
			
			#region SvStudCourseEvalCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStudCourseEval>|SvStudCourseEvalCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStudCourseEvalCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStudCourseEvalCollection = DataRepository.SvStudCourseEvalProvider.GetBySvCourseEvalItemId(transactionManager, entity.SvCourseEvalItemId);

				if (deep && entity.SvStudCourseEvalCollection.Count > 0)
				{
					deepHandles.Add("SvStudCourseEvalCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStudCourseEval>) DataRepository.SvStudCourseEvalProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStudCourseEvalCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvCourseEvalItem object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvCourseEvalItem instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvCourseEvalItem Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCourseEvalItem entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SvCodeEvalItemIdSource
			if (CanDeepSave(entity, "SvCodeEvalItem|SvCodeEvalItemIdSource", deepSaveType, innerList) 
				&& entity.SvCodeEvalItemIdSource != null)
			{
				DataRepository.SvCodeEvalItemProvider.Save(transactionManager, entity.SvCodeEvalItemIdSource);
				entity.SvCodeEvalItemId = entity.SvCodeEvalItemIdSource.SvCodeEvalItemId;
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
			
			#region SvCourseEvalIdSource
			if (CanDeepSave(entity, "SvCourseEval|SvCourseEvalIdSource", deepSaveType, innerList) 
				&& entity.SvCourseEvalIdSource != null)
			{
				DataRepository.SvCourseEvalProvider.Save(transactionManager, entity.SvCourseEvalIdSource);
				entity.SvCourseEvalId = entity.SvCourseEvalIdSource.SvCourseEvalId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SvStudCourseEval>
				if (CanDeepSave(entity.SvStudCourseEvalCollection, "List<SvStudCourseEval>|SvStudCourseEvalCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStudCourseEval child in entity.SvStudCourseEvalCollection)
					{
						if(child.SvCourseEvalItemIdSource != null)
						{
							child.SvCourseEvalItemId = child.SvCourseEvalItemIdSource.SvCourseEvalItemId;
						}
						else
						{
							child.SvCourseEvalItemId = entity.SvCourseEvalItemId;
						}

					}

					if (entity.SvStudCourseEvalCollection.Count > 0 || entity.SvStudCourseEvalCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStudCourseEvalProvider.Save(transactionManager, entity.SvStudCourseEvalCollection);
						
						deepHandles.Add("SvStudCourseEvalCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStudCourseEval >) DataRepository.SvStudCourseEvalProvider.DeepSave,
							new object[] { transactionManager, entity.SvStudCourseEvalCollection, deepSaveType, childTypes, innerList }
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
	
	#region SvCourseEvalItemChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvCourseEvalItem</c>
	///</summary>
	public enum SvCourseEvalItemChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SvCodeEvalItem</c> at SvCodeEvalItemIdSource
		///</summary>
		[ChildEntityType(typeof(SvCodeEvalItem))]
		SvCodeEvalItem,
		
		///<summary>
		/// Composite Property for <c>SvCodeRatingSchm</c> at SvCodeRatingSchmIdSource
		///</summary>
		[ChildEntityType(typeof(SvCodeRatingSchm))]
		SvCodeRatingSchm,
		
		///<summary>
		/// Composite Property for <c>SvCourseEval</c> at SvCourseEvalIdSource
		///</summary>
		[ChildEntityType(typeof(SvCourseEval))]
		SvCourseEval,
		///<summary>
		/// Collection of <c>SvCourseEvalItem</c> as OneToMany for SvStudCourseEvalCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStudCourseEval>))]
		SvStudCourseEvalCollection,
	}
	
	#endregion SvCourseEvalItemChildEntityTypes
	
	#region SvCourseEvalItemFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvCourseEvalItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCourseEvalItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvCourseEvalItemFilterBuilder : SqlFilterBuilder<SvCourseEvalItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCourseEvalItemFilterBuilder class.
		/// </summary>
		public SvCourseEvalItemFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvCourseEvalItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvCourseEvalItemFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvCourseEvalItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvCourseEvalItemFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvCourseEvalItemFilterBuilder
	
	#region SvCourseEvalItemParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvCourseEvalItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCourseEvalItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvCourseEvalItemParameterBuilder : ParameterizedSqlFilterBuilder<SvCourseEvalItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCourseEvalItemParameterBuilder class.
		/// </summary>
		public SvCourseEvalItemParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvCourseEvalItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvCourseEvalItemParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvCourseEvalItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvCourseEvalItemParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvCourseEvalItemParameterBuilder
	
	#region SvCourseEvalItemSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvCourseEvalItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCourseEvalItem"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvCourseEvalItemSortBuilder : SqlSortBuilder<SvCourseEvalItemColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCourseEvalItemSqlSortBuilder class.
		/// </summary>
		public SvCourseEvalItemSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvCourseEvalItemSortBuilder
	
} // end namespace
