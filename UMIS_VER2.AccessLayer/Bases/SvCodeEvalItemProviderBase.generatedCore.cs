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
	/// This class is the base class for any <see cref="SvCodeEvalItemProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvCodeEvalItemProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvCodeEvalItem, UMIS_VER2.BusinessLyer.SvCodeEvalItemKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCodeEvalItemKey key)
		{
			return Delete(transactionManager, key.SvCodeEvalItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svCodeEvalItemId">اكواد  الاستبيانات. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _svCodeEvalItemId)
		{
			return Delete(null, _svCodeEvalItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeEvalItemId">اكواد  الاستبيانات. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _svCodeEvalItemId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_CODE_EVAL_ITEM_SV_CDE_EVAL_ITEM_HDR key.
		///		FK_SV_CODE_EVAL_ITEM_SV_CDE_EVAL_ITEM_HDR Description: 
		/// </summary>
		/// <param name="_svCdeEvalItemHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCodeEvalItem objects.</returns>
		public TList<SvCodeEvalItem> GetBySvCdeEvalItemHdrId(System.Int32? _svCdeEvalItemHdrId)
		{
			int count = -1;
			return GetBySvCdeEvalItemHdrId(_svCdeEvalItemHdrId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_CODE_EVAL_ITEM_SV_CDE_EVAL_ITEM_HDR key.
		///		FK_SV_CODE_EVAL_ITEM_SV_CDE_EVAL_ITEM_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeEvalItemHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCodeEvalItem objects.</returns>
		/// <remarks></remarks>
		public TList<SvCodeEvalItem> GetBySvCdeEvalItemHdrId(TransactionManager transactionManager, System.Int32? _svCdeEvalItemHdrId)
		{
			int count = -1;
			return GetBySvCdeEvalItemHdrId(transactionManager, _svCdeEvalItemHdrId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_CODE_EVAL_ITEM_SV_CDE_EVAL_ITEM_HDR key.
		///		FK_SV_CODE_EVAL_ITEM_SV_CDE_EVAL_ITEM_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeEvalItemHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCodeEvalItem objects.</returns>
		public TList<SvCodeEvalItem> GetBySvCdeEvalItemHdrId(TransactionManager transactionManager, System.Int32? _svCdeEvalItemHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeEvalItemHdrId(transactionManager, _svCdeEvalItemHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_CODE_EVAL_ITEM_SV_CDE_EVAL_ITEM_HDR key.
		///		fkSvCodeEvalItemSvCdeEvalItemHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCdeEvalItemHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCodeEvalItem objects.</returns>
		public TList<SvCodeEvalItem> GetBySvCdeEvalItemHdrId(System.Int32? _svCdeEvalItemHdrId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySvCdeEvalItemHdrId(null, _svCdeEvalItemHdrId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_CODE_EVAL_ITEM_SV_CDE_EVAL_ITEM_HDR key.
		///		fkSvCodeEvalItemSvCdeEvalItemHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCdeEvalItemHdrId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCodeEvalItem objects.</returns>
		public TList<SvCodeEvalItem> GetBySvCdeEvalItemHdrId(System.Int32? _svCdeEvalItemHdrId, int start, int pageLength,out int count)
		{
			return GetBySvCdeEvalItemHdrId(null, _svCdeEvalItemHdrId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_CODE_EVAL_ITEM_SV_CDE_EVAL_ITEM_HDR key.
		///		FK_SV_CODE_EVAL_ITEM_SV_CDE_EVAL_ITEM_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeEvalItemHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCodeEvalItem objects.</returns>
		public abstract TList<SvCodeEvalItem> GetBySvCdeEvalItemHdrId(TransactionManager transactionManager, System.Int32? _svCdeEvalItemHdrId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SvCodeEvalItem Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCodeEvalItemKey key, int start, int pageLength)
		{
			return GetBySvCodeEvalItemId(transactionManager, key.SvCodeEvalItemId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_CODE_EVAL_ITEM index.
		/// </summary>
		/// <param name="_svCodeEvalItemId">اكواد  الاستبيانات</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCodeEvalItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCodeEvalItem GetBySvCodeEvalItemId(System.Decimal _svCodeEvalItemId)
		{
			int count = -1;
			return GetBySvCodeEvalItemId(null,_svCodeEvalItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CODE_EVAL_ITEM index.
		/// </summary>
		/// <param name="_svCodeEvalItemId">اكواد  الاستبيانات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCodeEvalItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCodeEvalItem GetBySvCodeEvalItemId(System.Decimal _svCodeEvalItemId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCodeEvalItemId(null, _svCodeEvalItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CODE_EVAL_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeEvalItemId">اكواد  الاستبيانات</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCodeEvalItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCodeEvalItem GetBySvCodeEvalItemId(TransactionManager transactionManager, System.Decimal _svCodeEvalItemId)
		{
			int count = -1;
			return GetBySvCodeEvalItemId(transactionManager, _svCodeEvalItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CODE_EVAL_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeEvalItemId">اكواد  الاستبيانات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCodeEvalItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCodeEvalItem GetBySvCodeEvalItemId(TransactionManager transactionManager, System.Decimal _svCodeEvalItemId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCodeEvalItemId(transactionManager, _svCodeEvalItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CODE_EVAL_ITEM index.
		/// </summary>
		/// <param name="_svCodeEvalItemId">اكواد  الاستبيانات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCodeEvalItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCodeEvalItem GetBySvCodeEvalItemId(System.Decimal _svCodeEvalItemId, int start, int pageLength, out int count)
		{
			return GetBySvCodeEvalItemId(null, _svCodeEvalItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CODE_EVAL_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeEvalItemId">اكواد  الاستبيانات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCodeEvalItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvCodeEvalItem GetBySvCodeEvalItemId(TransactionManager transactionManager, System.Decimal _svCodeEvalItemId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SV_CODE_EVAL_ITEM index.
		/// </summary>
		/// <param name="_svCdeEvalItemHdrId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="_groupFlg">مؤشر Staff=2  & Course=1 & ExtraEval 3--0 general  for all</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCodeEvalItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCodeEvalItem GetBySvCdeEvalItemHdrIdDescrArGroupFlg(System.Int32? _svCdeEvalItemHdrId, System.String _descrAr, System.Decimal? _groupFlg)
		{
			int count = -1;
			return GetBySvCdeEvalItemHdrIdDescrArGroupFlg(null,_svCdeEvalItemHdrId, _descrAr, _groupFlg, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_CODE_EVAL_ITEM index.
		/// </summary>
		/// <param name="_svCdeEvalItemHdrId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="_groupFlg">مؤشر Staff=2  & Course=1 & ExtraEval 3--0 general  for all</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCodeEvalItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCodeEvalItem GetBySvCdeEvalItemHdrIdDescrArGroupFlg(System.Int32? _svCdeEvalItemHdrId, System.String _descrAr, System.Decimal? _groupFlg, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeEvalItemHdrIdDescrArGroupFlg(null, _svCdeEvalItemHdrId, _descrAr, _groupFlg, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_CODE_EVAL_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeEvalItemHdrId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="_groupFlg">مؤشر Staff=2  & Course=1 & ExtraEval 3--0 general  for all</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCodeEvalItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCodeEvalItem GetBySvCdeEvalItemHdrIdDescrArGroupFlg(TransactionManager transactionManager, System.Int32? _svCdeEvalItemHdrId, System.String _descrAr, System.Decimal? _groupFlg)
		{
			int count = -1;
			return GetBySvCdeEvalItemHdrIdDescrArGroupFlg(transactionManager, _svCdeEvalItemHdrId, _descrAr, _groupFlg, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_CODE_EVAL_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeEvalItemHdrId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="_groupFlg">مؤشر Staff=2  & Course=1 & ExtraEval 3--0 general  for all</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCodeEvalItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCodeEvalItem GetBySvCdeEvalItemHdrIdDescrArGroupFlg(TransactionManager transactionManager, System.Int32? _svCdeEvalItemHdrId, System.String _descrAr, System.Decimal? _groupFlg, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeEvalItemHdrIdDescrArGroupFlg(transactionManager, _svCdeEvalItemHdrId, _descrAr, _groupFlg, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_CODE_EVAL_ITEM index.
		/// </summary>
		/// <param name="_svCdeEvalItemHdrId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="_groupFlg">مؤشر Staff=2  & Course=1 & ExtraEval 3--0 general  for all</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCodeEvalItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCodeEvalItem GetBySvCdeEvalItemHdrIdDescrArGroupFlg(System.Int32? _svCdeEvalItemHdrId, System.String _descrAr, System.Decimal? _groupFlg, int start, int pageLength, out int count)
		{
			return GetBySvCdeEvalItemHdrIdDescrArGroupFlg(null, _svCdeEvalItemHdrId, _descrAr, _groupFlg, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_CODE_EVAL_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeEvalItemHdrId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="_groupFlg">مؤشر Staff=2  & Course=1 & ExtraEval 3--0 general  for all</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCodeEvalItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvCodeEvalItem GetBySvCdeEvalItemHdrIdDescrArGroupFlg(TransactionManager transactionManager, System.Int32? _svCdeEvalItemHdrId, System.String _descrAr, System.Decimal? _groupFlg, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SV_CODE_EVAL_ITEM_EN index.
		/// </summary>
		/// <param name="_descrEn"></param>
		/// <param name="_svCdeEvalItemHdrId"></param>
		/// <param name="_groupFlg">مؤشر Staff=2  & Course=1 & ExtraEval 3--0 general  for all</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCodeEvalItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCodeEvalItem GetByDescrEnSvCdeEvalItemHdrIdGroupFlg(System.String _descrEn, System.Int32? _svCdeEvalItemHdrId, System.Decimal? _groupFlg)
		{
			int count = -1;
			return GetByDescrEnSvCdeEvalItemHdrIdGroupFlg(null,_descrEn, _svCdeEvalItemHdrId, _groupFlg, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_CODE_EVAL_ITEM_EN index.
		/// </summary>
		/// <param name="_descrEn"></param>
		/// <param name="_svCdeEvalItemHdrId"></param>
		/// <param name="_groupFlg">مؤشر Staff=2  & Course=1 & ExtraEval 3--0 general  for all</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCodeEvalItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCodeEvalItem GetByDescrEnSvCdeEvalItemHdrIdGroupFlg(System.String _descrEn, System.Int32? _svCdeEvalItemHdrId, System.Decimal? _groupFlg, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrEnSvCdeEvalItemHdrIdGroupFlg(null, _descrEn, _svCdeEvalItemHdrId, _groupFlg, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_CODE_EVAL_ITEM_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrEn"></param>
		/// <param name="_svCdeEvalItemHdrId"></param>
		/// <param name="_groupFlg">مؤشر Staff=2  & Course=1 & ExtraEval 3--0 general  for all</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCodeEvalItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCodeEvalItem GetByDescrEnSvCdeEvalItemHdrIdGroupFlg(TransactionManager transactionManager, System.String _descrEn, System.Int32? _svCdeEvalItemHdrId, System.Decimal? _groupFlg)
		{
			int count = -1;
			return GetByDescrEnSvCdeEvalItemHdrIdGroupFlg(transactionManager, _descrEn, _svCdeEvalItemHdrId, _groupFlg, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_CODE_EVAL_ITEM_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrEn"></param>
		/// <param name="_svCdeEvalItemHdrId"></param>
		/// <param name="_groupFlg">مؤشر Staff=2  & Course=1 & ExtraEval 3--0 general  for all</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCodeEvalItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCodeEvalItem GetByDescrEnSvCdeEvalItemHdrIdGroupFlg(TransactionManager transactionManager, System.String _descrEn, System.Int32? _svCdeEvalItemHdrId, System.Decimal? _groupFlg, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrEnSvCdeEvalItemHdrIdGroupFlg(transactionManager, _descrEn, _svCdeEvalItemHdrId, _groupFlg, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_CODE_EVAL_ITEM_EN index.
		/// </summary>
		/// <param name="_descrEn"></param>
		/// <param name="_svCdeEvalItemHdrId"></param>
		/// <param name="_groupFlg">مؤشر Staff=2  & Course=1 & ExtraEval 3--0 general  for all</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCodeEvalItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCodeEvalItem GetByDescrEnSvCdeEvalItemHdrIdGroupFlg(System.String _descrEn, System.Int32? _svCdeEvalItemHdrId, System.Decimal? _groupFlg, int start, int pageLength, out int count)
		{
			return GetByDescrEnSvCdeEvalItemHdrIdGroupFlg(null, _descrEn, _svCdeEvalItemHdrId, _groupFlg, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_CODE_EVAL_ITEM_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrEn"></param>
		/// <param name="_svCdeEvalItemHdrId"></param>
		/// <param name="_groupFlg">مؤشر Staff=2  & Course=1 & ExtraEval 3--0 general  for all</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCodeEvalItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvCodeEvalItem GetByDescrEnSvCdeEvalItemHdrIdGroupFlg(TransactionManager transactionManager, System.String _descrEn, System.Int32? _svCdeEvalItemHdrId, System.Decimal? _groupFlg, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvCodeEvalItem&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvCodeEvalItem&gt;"/></returns>
		public static TList<SvCodeEvalItem> Fill(IDataReader reader, TList<SvCodeEvalItem> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvCodeEvalItem c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvCodeEvalItem")
					.Append("|").Append((System.Decimal)reader["SV_CODE_EVAL_ITEM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvCodeEvalItem>(
					key.ToString(), // EntityTrackingKey
					"SvCodeEvalItem",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvCodeEvalItem();
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
					c.SvCodeEvalItemId = (System.Decimal)reader["SV_CODE_EVAL_ITEM_ID"];
					c.OriginalSvCodeEvalItemId = c.SvCodeEvalItemId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = (System.String)reader["DESCR_EN"];
					c.IsActive = (System.Decimal)reader["IS_ACTIVE"];
					c.GroupFlg = Convert.IsDBNull(reader["GROUP_FLG"]) ? null : (System.Decimal?)reader["GROUP_FLG"];
					c.SvCdeEvalItemHdrId = Convert.IsDBNull(reader["SV_CDE_EVAL_ITEM_HDR_ID"]) ? null : (System.Int32?)reader["SV_CDE_EVAL_ITEM_HDR_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvCodeEvalItem"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCodeEvalItem"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvCodeEvalItem entity)
		{
			if (!reader.Read()) return;
			
			entity.SvCodeEvalItemId = (System.Decimal)reader[((int)SvCodeEvalItemColumn.SvCodeEvalItemId - 1)];
			entity.OriginalSvCodeEvalItemId = (System.Decimal)reader["SV_CODE_EVAL_ITEM_ID"];
			entity.DescrAr = (System.String)reader[((int)SvCodeEvalItemColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)SvCodeEvalItemColumn.DescrEn - 1)];
			entity.IsActive = (System.Decimal)reader[((int)SvCodeEvalItemColumn.IsActive - 1)];
			entity.GroupFlg = (reader.IsDBNull(((int)SvCodeEvalItemColumn.GroupFlg - 1)))?null:(System.Decimal?)reader[((int)SvCodeEvalItemColumn.GroupFlg - 1)];
			entity.SvCdeEvalItemHdrId = (reader.IsDBNull(((int)SvCodeEvalItemColumn.SvCdeEvalItemHdrId - 1)))?null:(System.Int32?)reader[((int)SvCodeEvalItemColumn.SvCdeEvalItemHdrId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvCodeEvalItem"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCodeEvalItem"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvCodeEvalItem entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvCodeEvalItemId = (System.Decimal)dataRow["SV_CODE_EVAL_ITEM_ID"];
			entity.OriginalSvCodeEvalItemId = (System.Decimal)dataRow["SV_CODE_EVAL_ITEM_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = (System.String)dataRow["DESCR_EN"];
			entity.IsActive = (System.Decimal)dataRow["IS_ACTIVE"];
			entity.GroupFlg = Convert.IsDBNull(dataRow["GROUP_FLG"]) ? null : (System.Decimal?)dataRow["GROUP_FLG"];
			entity.SvCdeEvalItemHdrId = Convert.IsDBNull(dataRow["SV_CDE_EVAL_ITEM_HDR_ID"]) ? null : (System.Int32?)dataRow["SV_CDE_EVAL_ITEM_HDR_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCodeEvalItem"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvCodeEvalItem Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCodeEvalItem entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SvCdeEvalItemHdrIdSource	
			if (CanDeepLoad(entity, "SvCdeEvalItemHdr|SvCdeEvalItemHdrIdSource", deepLoadType, innerList) 
				&& entity.SvCdeEvalItemHdrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SvCdeEvalItemHdrId ?? (int)0);
				SvCdeEvalItemHdr tmpEntity = EntityManager.LocateEntity<SvCdeEvalItemHdr>(EntityLocator.ConstructKeyFromPkItems(typeof(SvCdeEvalItemHdr), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvCdeEvalItemHdrIdSource = tmpEntity;
				else
					entity.SvCdeEvalItemHdrIdSource = DataRepository.SvCdeEvalItemHdrProvider.GetBySvCdeEvalItemHdrId(transactionManager, (entity.SvCdeEvalItemHdrId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCdeEvalItemHdrIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvCdeEvalItemHdrIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvCdeEvalItemHdrProvider.DeepLoad(transactionManager, entity.SvCdeEvalItemHdrIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvCdeEvalItemHdrIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySvCodeEvalItemId methods when available
			
			#region SvCourseEvalItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvCourseEvalItem>|SvCourseEvalItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCourseEvalItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvCourseEvalItemCollection = DataRepository.SvCourseEvalItemProvider.GetBySvCodeEvalItemId(transactionManager, entity.SvCodeEvalItemId);

				if (deep && entity.SvCourseEvalItemCollection.Count > 0)
				{
					deepHandles.Add("SvCourseEvalItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvCourseEvalItem>) DataRepository.SvCourseEvalItemProvider.DeepLoad,
						new object[] { transactionManager, entity.SvCourseEvalItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvStaffEvalItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStaffEvalItem>|SvStaffEvalItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStaffEvalItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStaffEvalItemCollection = DataRepository.SvStaffEvalItemProvider.GetBySvCodeEvalItemId(transactionManager, entity.SvCodeEvalItemId);

				if (deep && entity.SvStaffEvalItemCollection.Count > 0)
				{
					deepHandles.Add("SvStaffEvalItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStaffEvalItem>) DataRepository.SvStaffEvalItemProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStaffEvalItemCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvCodeEvalItem object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvCodeEvalItem instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvCodeEvalItem Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCodeEvalItem entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SvCdeEvalItemHdrIdSource
			if (CanDeepSave(entity, "SvCdeEvalItemHdr|SvCdeEvalItemHdrIdSource", deepSaveType, innerList) 
				&& entity.SvCdeEvalItemHdrIdSource != null)
			{
				DataRepository.SvCdeEvalItemHdrProvider.Save(transactionManager, entity.SvCdeEvalItemHdrIdSource);
				entity.SvCdeEvalItemHdrId = entity.SvCdeEvalItemHdrIdSource.SvCdeEvalItemHdrId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SvCourseEvalItem>
				if (CanDeepSave(entity.SvCourseEvalItemCollection, "List<SvCourseEvalItem>|SvCourseEvalItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvCourseEvalItem child in entity.SvCourseEvalItemCollection)
					{
						if(child.SvCodeEvalItemIdSource != null)
						{
							child.SvCodeEvalItemId = child.SvCodeEvalItemIdSource.SvCodeEvalItemId;
						}
						else
						{
							child.SvCodeEvalItemId = entity.SvCodeEvalItemId;
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
				
	
			#region List<SvStaffEvalItem>
				if (CanDeepSave(entity.SvStaffEvalItemCollection, "List<SvStaffEvalItem>|SvStaffEvalItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStaffEvalItem child in entity.SvStaffEvalItemCollection)
					{
						if(child.SvCodeEvalItemIdSource != null)
						{
							child.SvCodeEvalItemId = child.SvCodeEvalItemIdSource.SvCodeEvalItemId;
						}
						else
						{
							child.SvCodeEvalItemId = entity.SvCodeEvalItemId;
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
	
	#region SvCodeEvalItemChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvCodeEvalItem</c>
	///</summary>
	public enum SvCodeEvalItemChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SvCdeEvalItemHdr</c> at SvCdeEvalItemHdrIdSource
		///</summary>
		[ChildEntityType(typeof(SvCdeEvalItemHdr))]
		SvCdeEvalItemHdr,
		///<summary>
		/// Collection of <c>SvCodeEvalItem</c> as OneToMany for SvCourseEvalItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvCourseEvalItem>))]
		SvCourseEvalItemCollection,
		///<summary>
		/// Collection of <c>SvCodeEvalItem</c> as OneToMany for SvStaffEvalItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStaffEvalItem>))]
		SvStaffEvalItemCollection,
	}
	
	#endregion SvCodeEvalItemChildEntityTypes
	
	#region SvCodeEvalItemFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvCodeEvalItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCodeEvalItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvCodeEvalItemFilterBuilder : SqlFilterBuilder<SvCodeEvalItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCodeEvalItemFilterBuilder class.
		/// </summary>
		public SvCodeEvalItemFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvCodeEvalItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvCodeEvalItemFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvCodeEvalItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvCodeEvalItemFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvCodeEvalItemFilterBuilder
	
	#region SvCodeEvalItemParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvCodeEvalItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCodeEvalItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvCodeEvalItemParameterBuilder : ParameterizedSqlFilterBuilder<SvCodeEvalItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCodeEvalItemParameterBuilder class.
		/// </summary>
		public SvCodeEvalItemParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvCodeEvalItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvCodeEvalItemParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvCodeEvalItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvCodeEvalItemParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvCodeEvalItemParameterBuilder
	
	#region SvCodeEvalItemSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvCodeEvalItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCodeEvalItem"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvCodeEvalItemSortBuilder : SqlSortBuilder<SvCodeEvalItemColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCodeEvalItemSqlSortBuilder class.
		/// </summary>
		public SvCodeEvalItemSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvCodeEvalItemSortBuilder
	
} // end namespace
