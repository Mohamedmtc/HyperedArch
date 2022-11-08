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
	/// This class is the base class for any <see cref="SvStaffEvalItemProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvStaffEvalItemProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvStaffEvalItem, UMIS_VER2.BusinessLyer.SvStaffEvalItemKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStaffEvalItemKey key)
		{
			return Delete(transactionManager, key.SvStaffEvalItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svStaffEvalItemId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _svStaffEvalItemId)
		{
			return Delete(null, _svStaffEvalItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStaffEvalItemId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _svStaffEvalItemId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_STF_EVL_ITEM_SV_CODE_EVAL_ITEM key.
		///		FK_SV_COURSE_STF_EVL_ITEM_SV_CODE_EVAL_ITEM Description: 
		/// </summary>
		/// <param name="_svCodeEvalItemId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvalItem objects.</returns>
		public TList<SvStaffEvalItem> GetBySvCodeEvalItemId(System.Decimal _svCodeEvalItemId)
		{
			int count = -1;
			return GetBySvCodeEvalItemId(_svCodeEvalItemId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_STF_EVL_ITEM_SV_CODE_EVAL_ITEM key.
		///		FK_SV_COURSE_STF_EVL_ITEM_SV_CODE_EVAL_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeEvalItemId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvalItem objects.</returns>
		/// <remarks></remarks>
		public TList<SvStaffEvalItem> GetBySvCodeEvalItemId(TransactionManager transactionManager, System.Decimal _svCodeEvalItemId)
		{
			int count = -1;
			return GetBySvCodeEvalItemId(transactionManager, _svCodeEvalItemId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_STF_EVL_ITEM_SV_CODE_EVAL_ITEM key.
		///		FK_SV_COURSE_STF_EVL_ITEM_SV_CODE_EVAL_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeEvalItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvalItem objects.</returns>
		public TList<SvStaffEvalItem> GetBySvCodeEvalItemId(TransactionManager transactionManager, System.Decimal _svCodeEvalItemId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCodeEvalItemId(transactionManager, _svCodeEvalItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_STF_EVL_ITEM_SV_CODE_EVAL_ITEM key.
		///		fkSvCourseStfEvlItemSvCodeEvalItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCodeEvalItemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvalItem objects.</returns>
		public TList<SvStaffEvalItem> GetBySvCodeEvalItemId(System.Decimal _svCodeEvalItemId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySvCodeEvalItemId(null, _svCodeEvalItemId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_STF_EVL_ITEM_SV_CODE_EVAL_ITEM key.
		///		fkSvCourseStfEvlItemSvCodeEvalItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCodeEvalItemId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvalItem objects.</returns>
		public TList<SvStaffEvalItem> GetBySvCodeEvalItemId(System.Decimal _svCodeEvalItemId, int start, int pageLength,out int count)
		{
			return GetBySvCodeEvalItemId(null, _svCodeEvalItemId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_STF_EVL_ITEM_SV_CODE_EVAL_ITEM key.
		///		FK_SV_COURSE_STF_EVL_ITEM_SV_CODE_EVAL_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeEvalItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvalItem objects.</returns>
		public abstract TList<SvStaffEvalItem> GetBySvCodeEvalItemId(TransactionManager transactionManager, System.Decimal _svCodeEvalItemId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_STF_EVL_ITEM_SV_COURSE_STF_EVL key.
		///		FK_SV_COURSE_STF_EVL_ITEM_SV_COURSE_STF_EVL Description: 
		/// </summary>
		/// <param name="_svCourseStfEvlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvalItem objects.</returns>
		public TList<SvStaffEvalItem> GetBySvCourseStfEvlId(System.Decimal _svCourseStfEvlId)
		{
			int count = -1;
			return GetBySvCourseStfEvlId(_svCourseStfEvlId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_STF_EVL_ITEM_SV_COURSE_STF_EVL key.
		///		FK_SV_COURSE_STF_EVL_ITEM_SV_COURSE_STF_EVL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseStfEvlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvalItem objects.</returns>
		/// <remarks></remarks>
		public TList<SvStaffEvalItem> GetBySvCourseStfEvlId(TransactionManager transactionManager, System.Decimal _svCourseStfEvlId)
		{
			int count = -1;
			return GetBySvCourseStfEvlId(transactionManager, _svCourseStfEvlId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_STF_EVL_ITEM_SV_COURSE_STF_EVL key.
		///		FK_SV_COURSE_STF_EVL_ITEM_SV_COURSE_STF_EVL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseStfEvlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvalItem objects.</returns>
		public TList<SvStaffEvalItem> GetBySvCourseStfEvlId(TransactionManager transactionManager, System.Decimal _svCourseStfEvlId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCourseStfEvlId(transactionManager, _svCourseStfEvlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_STF_EVL_ITEM_SV_COURSE_STF_EVL key.
		///		fkSvCourseStfEvlItemSvCourseStfEvl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCourseStfEvlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvalItem objects.</returns>
		public TList<SvStaffEvalItem> GetBySvCourseStfEvlId(System.Decimal _svCourseStfEvlId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySvCourseStfEvlId(null, _svCourseStfEvlId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_STF_EVL_ITEM_SV_COURSE_STF_EVL key.
		///		fkSvCourseStfEvlItemSvCourseStfEvl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCourseStfEvlId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvalItem objects.</returns>
		public TList<SvStaffEvalItem> GetBySvCourseStfEvlId(System.Decimal _svCourseStfEvlId, int start, int pageLength,out int count)
		{
			return GetBySvCourseStfEvlId(null, _svCourseStfEvlId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_STF_EVL_ITEM_SV_COURSE_STF_EVL key.
		///		FK_SV_COURSE_STF_EVL_ITEM_SV_COURSE_STF_EVL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseStfEvlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvalItem objects.</returns>
		public abstract TList<SvStaffEvalItem> GetBySvCourseStfEvlId(TransactionManager transactionManager, System.Decimal _svCourseStfEvlId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVAL_ITEM_SV_CODE_RATING_SCHM key.
		///		FK_SV_STAFF_EVAL_ITEM_SV_CODE_RATING_SCHM Description: 
		/// </summary>
		/// <param name="_svCodeRatingSchmId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvalItem objects.</returns>
		public TList<SvStaffEvalItem> GetBySvCodeRatingSchmId(System.Decimal? _svCodeRatingSchmId)
		{
			int count = -1;
			return GetBySvCodeRatingSchmId(_svCodeRatingSchmId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVAL_ITEM_SV_CODE_RATING_SCHM key.
		///		FK_SV_STAFF_EVAL_ITEM_SV_CODE_RATING_SCHM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeRatingSchmId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvalItem objects.</returns>
		/// <remarks></remarks>
		public TList<SvStaffEvalItem> GetBySvCodeRatingSchmId(TransactionManager transactionManager, System.Decimal? _svCodeRatingSchmId)
		{
			int count = -1;
			return GetBySvCodeRatingSchmId(transactionManager, _svCodeRatingSchmId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVAL_ITEM_SV_CODE_RATING_SCHM key.
		///		FK_SV_STAFF_EVAL_ITEM_SV_CODE_RATING_SCHM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeRatingSchmId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvalItem objects.</returns>
		public TList<SvStaffEvalItem> GetBySvCodeRatingSchmId(TransactionManager transactionManager, System.Decimal? _svCodeRatingSchmId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCodeRatingSchmId(transactionManager, _svCodeRatingSchmId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVAL_ITEM_SV_CODE_RATING_SCHM key.
		///		fkSvStaffEvalItemSvCodeRatingSchm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCodeRatingSchmId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvalItem objects.</returns>
		public TList<SvStaffEvalItem> GetBySvCodeRatingSchmId(System.Decimal? _svCodeRatingSchmId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySvCodeRatingSchmId(null, _svCodeRatingSchmId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVAL_ITEM_SV_CODE_RATING_SCHM key.
		///		fkSvStaffEvalItemSvCodeRatingSchm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCodeRatingSchmId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvalItem objects.</returns>
		public TList<SvStaffEvalItem> GetBySvCodeRatingSchmId(System.Decimal? _svCodeRatingSchmId, int start, int pageLength,out int count)
		{
			return GetBySvCodeRatingSchmId(null, _svCodeRatingSchmId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVAL_ITEM_SV_CODE_RATING_SCHM key.
		///		FK_SV_STAFF_EVAL_ITEM_SV_CODE_RATING_SCHM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeRatingSchmId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvalItem objects.</returns>
		public abstract TList<SvStaffEvalItem> GetBySvCodeRatingSchmId(TransactionManager transactionManager, System.Decimal? _svCodeRatingSchmId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SvStaffEvalItem Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStaffEvalItemKey key, int start, int pageLength)
		{
			return GetBySvStaffEvalItemId(transactionManager, key.SvStaffEvalItemId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_COURSE_STF_EVL_ITEM index.
		/// </summary>
		/// <param name="_svStaffEvalItemId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStaffEvalItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStaffEvalItem GetBySvStaffEvalItemId(System.Decimal _svStaffEvalItemId)
		{
			int count = -1;
			return GetBySvStaffEvalItemId(null,_svStaffEvalItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_COURSE_STF_EVL_ITEM index.
		/// </summary>
		/// <param name="_svStaffEvalItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStaffEvalItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStaffEvalItem GetBySvStaffEvalItemId(System.Decimal _svStaffEvalItemId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvStaffEvalItemId(null, _svStaffEvalItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_COURSE_STF_EVL_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStaffEvalItemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStaffEvalItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStaffEvalItem GetBySvStaffEvalItemId(TransactionManager transactionManager, System.Decimal _svStaffEvalItemId)
		{
			int count = -1;
			return GetBySvStaffEvalItemId(transactionManager, _svStaffEvalItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_COURSE_STF_EVL_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStaffEvalItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStaffEvalItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStaffEvalItem GetBySvStaffEvalItemId(TransactionManager transactionManager, System.Decimal _svStaffEvalItemId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvStaffEvalItemId(transactionManager, _svStaffEvalItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_COURSE_STF_EVL_ITEM index.
		/// </summary>
		/// <param name="_svStaffEvalItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStaffEvalItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStaffEvalItem GetBySvStaffEvalItemId(System.Decimal _svStaffEvalItemId, int start, int pageLength, out int count)
		{
			return GetBySvStaffEvalItemId(null, _svStaffEvalItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_COURSE_STF_EVL_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStaffEvalItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStaffEvalItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvStaffEvalItem GetBySvStaffEvalItemId(TransactionManager transactionManager, System.Decimal _svStaffEvalItemId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SV_STAFF_EVAL_ITEM index.
		/// </summary>
		/// <param name="_svCourseStfEvlId"></param>
		/// <param name="_svCodeEvalItemId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStaffEvalItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStaffEvalItem GetBySvCourseStfEvlIdSvCodeEvalItemId(System.Decimal _svCourseStfEvlId, System.Decimal _svCodeEvalItemId)
		{
			int count = -1;
			return GetBySvCourseStfEvlIdSvCodeEvalItemId(null,_svCourseStfEvlId, _svCodeEvalItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_STAFF_EVAL_ITEM index.
		/// </summary>
		/// <param name="_svCourseStfEvlId"></param>
		/// <param name="_svCodeEvalItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStaffEvalItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStaffEvalItem GetBySvCourseStfEvlIdSvCodeEvalItemId(System.Decimal _svCourseStfEvlId, System.Decimal _svCodeEvalItemId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCourseStfEvlIdSvCodeEvalItemId(null, _svCourseStfEvlId, _svCodeEvalItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_STAFF_EVAL_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseStfEvlId"></param>
		/// <param name="_svCodeEvalItemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStaffEvalItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStaffEvalItem GetBySvCourseStfEvlIdSvCodeEvalItemId(TransactionManager transactionManager, System.Decimal _svCourseStfEvlId, System.Decimal _svCodeEvalItemId)
		{
			int count = -1;
			return GetBySvCourseStfEvlIdSvCodeEvalItemId(transactionManager, _svCourseStfEvlId, _svCodeEvalItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_STAFF_EVAL_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseStfEvlId"></param>
		/// <param name="_svCodeEvalItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStaffEvalItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStaffEvalItem GetBySvCourseStfEvlIdSvCodeEvalItemId(TransactionManager transactionManager, System.Decimal _svCourseStfEvlId, System.Decimal _svCodeEvalItemId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCourseStfEvlIdSvCodeEvalItemId(transactionManager, _svCourseStfEvlId, _svCodeEvalItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_STAFF_EVAL_ITEM index.
		/// </summary>
		/// <param name="_svCourseStfEvlId"></param>
		/// <param name="_svCodeEvalItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStaffEvalItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStaffEvalItem GetBySvCourseStfEvlIdSvCodeEvalItemId(System.Decimal _svCourseStfEvlId, System.Decimal _svCodeEvalItemId, int start, int pageLength, out int count)
		{
			return GetBySvCourseStfEvlIdSvCodeEvalItemId(null, _svCourseStfEvlId, _svCodeEvalItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_STAFF_EVAL_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseStfEvlId"></param>
		/// <param name="_svCodeEvalItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStaffEvalItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvStaffEvalItem GetBySvCourseStfEvlIdSvCodeEvalItemId(TransactionManager transactionManager, System.Decimal _svCourseStfEvlId, System.Decimal _svCodeEvalItemId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SV_STAFF_EVAL_ITEM_ORD index.
		/// </summary>
		/// <param name="_svCourseStfEvlId"></param>
		/// <param name="_itemOrdr"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStaffEvalItem&gt;"/> class.</returns>
		public TList<SvStaffEvalItem> GetBySvCourseStfEvlIdItemOrdr(System.Decimal _svCourseStfEvlId, System.Decimal? _itemOrdr)
		{
			int count = -1;
			return GetBySvCourseStfEvlIdItemOrdr(null,_svCourseStfEvlId, _itemOrdr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_STAFF_EVAL_ITEM_ORD index.
		/// </summary>
		/// <param name="_svCourseStfEvlId"></param>
		/// <param name="_itemOrdr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStaffEvalItem&gt;"/> class.</returns>
		public TList<SvStaffEvalItem> GetBySvCourseStfEvlIdItemOrdr(System.Decimal _svCourseStfEvlId, System.Decimal? _itemOrdr, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCourseStfEvlIdItemOrdr(null, _svCourseStfEvlId, _itemOrdr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_STAFF_EVAL_ITEM_ORD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseStfEvlId"></param>
		/// <param name="_itemOrdr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStaffEvalItem&gt;"/> class.</returns>
		public TList<SvStaffEvalItem> GetBySvCourseStfEvlIdItemOrdr(TransactionManager transactionManager, System.Decimal _svCourseStfEvlId, System.Decimal? _itemOrdr)
		{
			int count = -1;
			return GetBySvCourseStfEvlIdItemOrdr(transactionManager, _svCourseStfEvlId, _itemOrdr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_STAFF_EVAL_ITEM_ORD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseStfEvlId"></param>
		/// <param name="_itemOrdr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStaffEvalItem&gt;"/> class.</returns>
		public TList<SvStaffEvalItem> GetBySvCourseStfEvlIdItemOrdr(TransactionManager transactionManager, System.Decimal _svCourseStfEvlId, System.Decimal? _itemOrdr, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCourseStfEvlIdItemOrdr(transactionManager, _svCourseStfEvlId, _itemOrdr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_STAFF_EVAL_ITEM_ORD index.
		/// </summary>
		/// <param name="_svCourseStfEvlId"></param>
		/// <param name="_itemOrdr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStaffEvalItem&gt;"/> class.</returns>
		public TList<SvStaffEvalItem> GetBySvCourseStfEvlIdItemOrdr(System.Decimal _svCourseStfEvlId, System.Decimal? _itemOrdr, int start, int pageLength, out int count)
		{
			return GetBySvCourseStfEvlIdItemOrdr(null, _svCourseStfEvlId, _itemOrdr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_STAFF_EVAL_ITEM_ORD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseStfEvlId"></param>
		/// <param name="_itemOrdr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStaffEvalItem&gt;"/> class.</returns>
		public abstract TList<SvStaffEvalItem> GetBySvCourseStfEvlIdItemOrdr(TransactionManager transactionManager, System.Decimal _svCourseStfEvlId, System.Decimal? _itemOrdr, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvStaffEvalItem&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvStaffEvalItem&gt;"/></returns>
		public static TList<SvStaffEvalItem> Fill(IDataReader reader, TList<SvStaffEvalItem> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvStaffEvalItem c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvStaffEvalItem")
					.Append("|").Append((System.Decimal)reader["SV_STAFF_EVAL_ITEM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvStaffEvalItem>(
					key.ToString(), // EntityTrackingKey
					"SvStaffEvalItem",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvStaffEvalItem();
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
					c.SvStaffEvalItemId = (System.Decimal)reader["SV_STAFF_EVAL_ITEM_ID"];
					c.OriginalSvStaffEvalItemId = c.SvStaffEvalItemId;
					c.SvCourseStfEvlId = (System.Decimal)reader["SV_COURSE_STF_EVL_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvStaffEvalItem"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvStaffEvalItem"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvStaffEvalItem entity)
		{
			if (!reader.Read()) return;
			
			entity.SvStaffEvalItemId = (System.Decimal)reader[((int)SvStaffEvalItemColumn.SvStaffEvalItemId - 1)];
			entity.OriginalSvStaffEvalItemId = (System.Decimal)reader["SV_STAFF_EVAL_ITEM_ID"];
			entity.SvCourseStfEvlId = (System.Decimal)reader[((int)SvStaffEvalItemColumn.SvCourseStfEvlId - 1)];
			entity.SvCodeEvalItemId = (System.Decimal)reader[((int)SvStaffEvalItemColumn.SvCodeEvalItemId - 1)];
			entity.ItemOrdr = (reader.IsDBNull(((int)SvStaffEvalItemColumn.ItemOrdr - 1)))?null:(System.Decimal?)reader[((int)SvStaffEvalItemColumn.ItemOrdr - 1)];
			entity.SvCodeRatingSchmId = (reader.IsDBNull(((int)SvStaffEvalItemColumn.SvCodeRatingSchmId - 1)))?null:(System.Decimal?)reader[((int)SvStaffEvalItemColumn.SvCodeRatingSchmId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvStaffEvalItem"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvStaffEvalItem"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvStaffEvalItem entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvStaffEvalItemId = (System.Decimal)dataRow["SV_STAFF_EVAL_ITEM_ID"];
			entity.OriginalSvStaffEvalItemId = (System.Decimal)dataRow["SV_STAFF_EVAL_ITEM_ID"];
			entity.SvCourseStfEvlId = (System.Decimal)dataRow["SV_COURSE_STF_EVL_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvStaffEvalItem"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvStaffEvalItem Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStaffEvalItem entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region SvCourseStfEvlIdSource	
			if (CanDeepLoad(entity, "SvStaffEvl|SvCourseStfEvlIdSource", deepLoadType, innerList) 
				&& entity.SvCourseStfEvlIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SvCourseStfEvlId;
				SvStaffEvl tmpEntity = EntityManager.LocateEntity<SvStaffEvl>(EntityLocator.ConstructKeyFromPkItems(typeof(SvStaffEvl), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvCourseStfEvlIdSource = tmpEntity;
				else
					entity.SvCourseStfEvlIdSource = DataRepository.SvStaffEvlProvider.GetBySvStaffEvlId(transactionManager, entity.SvCourseStfEvlId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCourseStfEvlIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvCourseStfEvlIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvStaffEvlProvider.DeepLoad(transactionManager, entity.SvCourseStfEvlIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvCourseStfEvlIdSource

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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySvStaffEvalItemId methods when available
			
			#region SvStudStaffEvalCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStudStaffEval>|SvStudStaffEvalCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStudStaffEvalCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStudStaffEvalCollection = DataRepository.SvStudStaffEvalProvider.GetBySvStaffEvalItemId(transactionManager, entity.SvStaffEvalItemId);

				if (deep && entity.SvStudStaffEvalCollection.Count > 0)
				{
					deepHandles.Add("SvStudStaffEvalCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStudStaffEval>) DataRepository.SvStudStaffEvalProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStudStaffEvalCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvStaffEvalItem object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvStaffEvalItem instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvStaffEvalItem Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStaffEvalItem entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region SvCourseStfEvlIdSource
			if (CanDeepSave(entity, "SvStaffEvl|SvCourseStfEvlIdSource", deepSaveType, innerList) 
				&& entity.SvCourseStfEvlIdSource != null)
			{
				DataRepository.SvStaffEvlProvider.Save(transactionManager, entity.SvCourseStfEvlIdSource);
				entity.SvCourseStfEvlId = entity.SvCourseStfEvlIdSource.SvStaffEvlId;
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
	
			#region List<SvStudStaffEval>
				if (CanDeepSave(entity.SvStudStaffEvalCollection, "List<SvStudStaffEval>|SvStudStaffEvalCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStudStaffEval child in entity.SvStudStaffEvalCollection)
					{
						if(child.SvStaffEvalItemIdSource != null)
						{
							child.SvStaffEvalItemId = child.SvStaffEvalItemIdSource.SvStaffEvalItemId;
						}
						else
						{
							child.SvStaffEvalItemId = entity.SvStaffEvalItemId;
						}

					}

					if (entity.SvStudStaffEvalCollection.Count > 0 || entity.SvStudStaffEvalCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStudStaffEvalProvider.Save(transactionManager, entity.SvStudStaffEvalCollection);
						
						deepHandles.Add("SvStudStaffEvalCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStudStaffEval >) DataRepository.SvStudStaffEvalProvider.DeepSave,
							new object[] { transactionManager, entity.SvStudStaffEvalCollection, deepSaveType, childTypes, innerList }
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
	
	#region SvStaffEvalItemChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvStaffEvalItem</c>
	///</summary>
	public enum SvStaffEvalItemChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SvCodeEvalItem</c> at SvCodeEvalItemIdSource
		///</summary>
		[ChildEntityType(typeof(SvCodeEvalItem))]
		SvCodeEvalItem,
		
		///<summary>
		/// Composite Property for <c>SvStaffEvl</c> at SvCourseStfEvlIdSource
		///</summary>
		[ChildEntityType(typeof(SvStaffEvl))]
		SvStaffEvl,
		
		///<summary>
		/// Composite Property for <c>SvCodeRatingSchm</c> at SvCodeRatingSchmIdSource
		///</summary>
		[ChildEntityType(typeof(SvCodeRatingSchm))]
		SvCodeRatingSchm,
		///<summary>
		/// Collection of <c>SvStaffEvalItem</c> as OneToMany for SvStudStaffEvalCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStudStaffEval>))]
		SvStudStaffEvalCollection,
	}
	
	#endregion SvStaffEvalItemChildEntityTypes
	
	#region SvStaffEvalItemFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvStaffEvalItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvStaffEvalItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvStaffEvalItemFilterBuilder : SqlFilterBuilder<SvStaffEvalItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvStaffEvalItemFilterBuilder class.
		/// </summary>
		public SvStaffEvalItemFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvStaffEvalItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvStaffEvalItemFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvStaffEvalItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvStaffEvalItemFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvStaffEvalItemFilterBuilder
	
	#region SvStaffEvalItemParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvStaffEvalItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvStaffEvalItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvStaffEvalItemParameterBuilder : ParameterizedSqlFilterBuilder<SvStaffEvalItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvStaffEvalItemParameterBuilder class.
		/// </summary>
		public SvStaffEvalItemParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvStaffEvalItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvStaffEvalItemParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvStaffEvalItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvStaffEvalItemParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvStaffEvalItemParameterBuilder
	
	#region SvStaffEvalItemSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvStaffEvalItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvStaffEvalItem"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvStaffEvalItemSortBuilder : SqlSortBuilder<SvStaffEvalItemColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvStaffEvalItemSqlSortBuilder class.
		/// </summary>
		public SvStaffEvalItemSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvStaffEvalItemSortBuilder
	
} // end namespace
