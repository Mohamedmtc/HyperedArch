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
	/// This class is the base class for any <see cref="PgThesisStudApproveProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PgThesisStudApproveProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.PgThesisStudApprove, UMIS_VER2.BusinessLyer.PgThesisStudApproveKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisStudApproveKey key)
		{
			return Delete(transactionManager, key.PgThesisStudApproveId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_pgThesisStudApproveId">اعتمادات بيانات الرسالة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _pgThesisStudApproveId)
		{
			return Delete(null, _pgThesisStudApproveId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudApproveId">اعتمادات بيانات الرسالة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _pgThesisStudApproveId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_GS_CODE_APPROVAL key.
		///		FK_PG_THESIS_STUD_APPROVE_GS_CODE_APPROVAL Description: 
		/// </summary>
		/// <param name="_gsCodeApprovalId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByGsCodeApprovalId(System.Decimal _gsCodeApprovalId)
		{
			int count = -1;
			return GetByGsCodeApprovalId(_gsCodeApprovalId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_GS_CODE_APPROVAL key.
		///		FK_PG_THESIS_STUD_APPROVE_GS_CODE_APPROVAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisStudApprove> GetByGsCodeApprovalId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalId)
		{
			int count = -1;
			return GetByGsCodeApprovalId(transactionManager, _gsCodeApprovalId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_GS_CODE_APPROVAL key.
		///		FK_PG_THESIS_STUD_APPROVE_GS_CODE_APPROVAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByGsCodeApprovalId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeApprovalId(transactionManager, _gsCodeApprovalId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_GS_CODE_APPROVAL key.
		///		fkPgThesisStudApproveGsCodeApproval Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeApprovalId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByGsCodeApprovalId(System.Decimal _gsCodeApprovalId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeApprovalId(null, _gsCodeApprovalId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_GS_CODE_APPROVAL key.
		///		fkPgThesisStudApproveGsCodeApproval Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeApprovalId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByGsCodeApprovalId(System.Decimal _gsCodeApprovalId, int start, int pageLength,out int count)
		{
			return GetByGsCodeApprovalId(null, _gsCodeApprovalId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_GS_CODE_APPROVAL key.
		///		FK_PG_THESIS_STUD_APPROVE_GS_CODE_APPROVAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public abstract TList<PgThesisStudApprove> GetByGsCodeApprovalId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_GS_CODE_APPROVAL_FUNC key.
		///		FK_PG_THESIS_STUD_APPROVE_GS_CODE_APPROVAL_FUNC Description: 
		/// </summary>
		/// <param name="_gsCodeApprovalFuncId">اسم الوظيفة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByGsCodeApprovalFuncId(System.Decimal _gsCodeApprovalFuncId)
		{
			int count = -1;
			return GetByGsCodeApprovalFuncId(_gsCodeApprovalFuncId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_GS_CODE_APPROVAL_FUNC key.
		///		FK_PG_THESIS_STUD_APPROVE_GS_CODE_APPROVAL_FUNC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalFuncId">اسم الوظيفة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisStudApprove> GetByGsCodeApprovalFuncId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalFuncId)
		{
			int count = -1;
			return GetByGsCodeApprovalFuncId(transactionManager, _gsCodeApprovalFuncId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_GS_CODE_APPROVAL_FUNC key.
		///		FK_PG_THESIS_STUD_APPROVE_GS_CODE_APPROVAL_FUNC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalFuncId">اسم الوظيفة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByGsCodeApprovalFuncId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalFuncId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeApprovalFuncId(transactionManager, _gsCodeApprovalFuncId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_GS_CODE_APPROVAL_FUNC key.
		///		fkPgThesisStudApproveGsCodeApprovalFunc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeApprovalFuncId">اسم الوظيفة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByGsCodeApprovalFuncId(System.Decimal _gsCodeApprovalFuncId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeApprovalFuncId(null, _gsCodeApprovalFuncId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_GS_CODE_APPROVAL_FUNC key.
		///		fkPgThesisStudApproveGsCodeApprovalFunc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeApprovalFuncId">اسم الوظيفة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByGsCodeApprovalFuncId(System.Decimal _gsCodeApprovalFuncId, int start, int pageLength,out int count)
		{
			return GetByGsCodeApprovalFuncId(null, _gsCodeApprovalFuncId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_GS_CODE_APPROVAL_FUNC key.
		///		FK_PG_THESIS_STUD_APPROVE_GS_CODE_APPROVAL_FUNC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalFuncId">اسم الوظيفة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public abstract TList<PgThesisStudApprove> GetByGsCodeApprovalFuncId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalFuncId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_STUD_TRAVEL key.
		///		FK_PG_THESIS_STUD_APPROVE_PG_STUD_TRAVEL Description: 
		/// </summary>
		/// <param name="_pgStudTravelId">سفر الطلاب للخارج</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByPgStudTravelId(System.Decimal? _pgStudTravelId)
		{
			int count = -1;
			return GetByPgStudTravelId(_pgStudTravelId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_STUD_TRAVEL key.
		///		FK_PG_THESIS_STUD_APPROVE_PG_STUD_TRAVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStudTravelId">سفر الطلاب للخارج</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisStudApprove> GetByPgStudTravelId(TransactionManager transactionManager, System.Decimal? _pgStudTravelId)
		{
			int count = -1;
			return GetByPgStudTravelId(transactionManager, _pgStudTravelId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_STUD_TRAVEL key.
		///		FK_PG_THESIS_STUD_APPROVE_PG_STUD_TRAVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStudTravelId">سفر الطلاب للخارج</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByPgStudTravelId(TransactionManager transactionManager, System.Decimal? _pgStudTravelId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgStudTravelId(transactionManager, _pgStudTravelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_STUD_TRAVEL key.
		///		fkPgThesisStudApprovePgStudTravel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgStudTravelId">سفر الطلاب للخارج</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByPgStudTravelId(System.Decimal? _pgStudTravelId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgStudTravelId(null, _pgStudTravelId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_STUD_TRAVEL key.
		///		fkPgThesisStudApprovePgStudTravel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgStudTravelId">سفر الطلاب للخارج</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByPgStudTravelId(System.Decimal? _pgStudTravelId, int start, int pageLength,out int count)
		{
			return GetByPgStudTravelId(null, _pgStudTravelId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_STUD_TRAVEL key.
		///		FK_PG_THESIS_STUD_APPROVE_PG_STUD_TRAVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStudTravelId">سفر الطلاب للخارج</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public abstract TList<PgThesisStudApprove> GetByPgStudTravelId(TransactionManager transactionManager, System.Decimal? _pgStudTravelId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_STUD_TRAVEL_EXTEND key.
		///		FK_PG_THESIS_STUD_APPROVE_PG_STUD_TRAVEL_EXTEND Description: 
		/// </summary>
		/// <param name="_pgStudTravelExtendId">مد سفر الطلاب للخارج</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByPgStudTravelExtendId(System.Decimal? _pgStudTravelExtendId)
		{
			int count = -1;
			return GetByPgStudTravelExtendId(_pgStudTravelExtendId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_STUD_TRAVEL_EXTEND key.
		///		FK_PG_THESIS_STUD_APPROVE_PG_STUD_TRAVEL_EXTEND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStudTravelExtendId">مد سفر الطلاب للخارج</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisStudApprove> GetByPgStudTravelExtendId(TransactionManager transactionManager, System.Decimal? _pgStudTravelExtendId)
		{
			int count = -1;
			return GetByPgStudTravelExtendId(transactionManager, _pgStudTravelExtendId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_STUD_TRAVEL_EXTEND key.
		///		FK_PG_THESIS_STUD_APPROVE_PG_STUD_TRAVEL_EXTEND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStudTravelExtendId">مد سفر الطلاب للخارج</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByPgStudTravelExtendId(TransactionManager transactionManager, System.Decimal? _pgStudTravelExtendId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgStudTravelExtendId(transactionManager, _pgStudTravelExtendId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_STUD_TRAVEL_EXTEND key.
		///		fkPgThesisStudApprovePgStudTravelExtend Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgStudTravelExtendId">مد سفر الطلاب للخارج</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByPgStudTravelExtendId(System.Decimal? _pgStudTravelExtendId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgStudTravelExtendId(null, _pgStudTravelExtendId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_STUD_TRAVEL_EXTEND key.
		///		fkPgThesisStudApprovePgStudTravelExtend Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgStudTravelExtendId">مد سفر الطلاب للخارج</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByPgStudTravelExtendId(System.Decimal? _pgStudTravelExtendId, int start, int pageLength,out int count)
		{
			return GetByPgStudTravelExtendId(null, _pgStudTravelExtendId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_STUD_TRAVEL_EXTEND key.
		///		FK_PG_THESIS_STUD_APPROVE_PG_STUD_TRAVEL_EXTEND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStudTravelExtendId">مد سفر الطلاب للخارج</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public abstract TList<PgThesisStudApprove> GetByPgStudTravelExtendId(TransactionManager transactionManager, System.Decimal? _pgStudTravelExtendId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_COMM_RECOMMEND key.
		///		FK_PG_THESIS_STUD_APPROVE_PG_THESIS_COMM_RECOMMEND Description: 
		/// </summary>
		/// <param name="_pgThesisCommRecommendId">توصيات لجنة المناقشة والحكم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByPgThesisCommRecommendId(System.Decimal? _pgThesisCommRecommendId)
		{
			int count = -1;
			return GetByPgThesisCommRecommendId(_pgThesisCommRecommendId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_COMM_RECOMMEND key.
		///		FK_PG_THESIS_STUD_APPROVE_PG_THESIS_COMM_RECOMMEND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommRecommendId">توصيات لجنة المناقشة والحكم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisStudApprove> GetByPgThesisCommRecommendId(TransactionManager transactionManager, System.Decimal? _pgThesisCommRecommendId)
		{
			int count = -1;
			return GetByPgThesisCommRecommendId(transactionManager, _pgThesisCommRecommendId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_COMM_RECOMMEND key.
		///		FK_PG_THESIS_STUD_APPROVE_PG_THESIS_COMM_RECOMMEND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommRecommendId">توصيات لجنة المناقشة والحكم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByPgThesisCommRecommendId(TransactionManager transactionManager, System.Decimal? _pgThesisCommRecommendId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisCommRecommendId(transactionManager, _pgThesisCommRecommendId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_COMM_RECOMMEND key.
		///		fkPgThesisStudApprovePgThesisCommRecommend Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisCommRecommendId">توصيات لجنة المناقشة والحكم</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByPgThesisCommRecommendId(System.Decimal? _pgThesisCommRecommendId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisCommRecommendId(null, _pgThesisCommRecommendId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_COMM_RECOMMEND key.
		///		fkPgThesisStudApprovePgThesisCommRecommend Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisCommRecommendId">توصيات لجنة المناقشة والحكم</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByPgThesisCommRecommendId(System.Decimal? _pgThesisCommRecommendId, int start, int pageLength,out int count)
		{
			return GetByPgThesisCommRecommendId(null, _pgThesisCommRecommendId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_COMM_RECOMMEND key.
		///		FK_PG_THESIS_STUD_APPROVE_PG_THESIS_COMM_RECOMMEND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommRecommendId">توصيات لجنة المناقشة والحكم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public abstract TList<PgThesisStudApprove> GetByPgThesisCommRecommendId(TransactionManager transactionManager, System.Decimal? _pgThesisCommRecommendId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_SEMINAR key.
		///		FK_PG_THESIS_STUD_APPROVE_PG_THESIS_SEMINAR Description: 
		/// </summary>
		/// <param name="_pgThesisSeminarId">تسجيل الندوة التعريفية (السيمينار)</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByPgThesisSeminarId(System.Decimal? _pgThesisSeminarId)
		{
			int count = -1;
			return GetByPgThesisSeminarId(_pgThesisSeminarId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_SEMINAR key.
		///		FK_PG_THESIS_STUD_APPROVE_PG_THESIS_SEMINAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisSeminarId">تسجيل الندوة التعريفية (السيمينار)</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisStudApprove> GetByPgThesisSeminarId(TransactionManager transactionManager, System.Decimal? _pgThesisSeminarId)
		{
			int count = -1;
			return GetByPgThesisSeminarId(transactionManager, _pgThesisSeminarId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_SEMINAR key.
		///		FK_PG_THESIS_STUD_APPROVE_PG_THESIS_SEMINAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisSeminarId">تسجيل الندوة التعريفية (السيمينار)</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByPgThesisSeminarId(TransactionManager transactionManager, System.Decimal? _pgThesisSeminarId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisSeminarId(transactionManager, _pgThesisSeminarId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_SEMINAR key.
		///		fkPgThesisStudApprovePgThesisSeminar Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisSeminarId">تسجيل الندوة التعريفية (السيمينار)</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByPgThesisSeminarId(System.Decimal? _pgThesisSeminarId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisSeminarId(null, _pgThesisSeminarId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_SEMINAR key.
		///		fkPgThesisStudApprovePgThesisSeminar Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisSeminarId">تسجيل الندوة التعريفية (السيمينار)</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByPgThesisSeminarId(System.Decimal? _pgThesisSeminarId, int start, int pageLength,out int count)
		{
			return GetByPgThesisSeminarId(null, _pgThesisSeminarId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_SEMINAR key.
		///		FK_PG_THESIS_STUD_APPROVE_PG_THESIS_SEMINAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisSeminarId">تسجيل الندوة التعريفية (السيمينار)</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public abstract TList<PgThesisStudApprove> GetByPgThesisSeminarId(TransactionManager transactionManager, System.Decimal? _pgThesisSeminarId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD key.
		///		FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByPgThesisStudId(System.Decimal? _pgThesisStudId)
		{
			int count = -1;
			return GetByPgThesisStudId(_pgThesisStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD key.
		///		FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisStudApprove> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal? _pgThesisStudId)
		{
			int count = -1;
			return GetByPgThesisStudId(transactionManager, _pgThesisStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD key.
		///		FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal? _pgThesisStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisStudId(transactionManager, _pgThesisStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD key.
		///		fkPgThesisStudApprovePgThesisStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByPgThesisStudId(System.Decimal? _pgThesisStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisStudId(null, _pgThesisStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD key.
		///		fkPgThesisStudApprovePgThesisStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByPgThesisStudId(System.Decimal? _pgThesisStudId, int start, int pageLength,out int count)
		{
			return GetByPgThesisStudId(null, _pgThesisStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD key.
		///		FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public abstract TList<PgThesisStudApprove> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal? _pgThesisStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD_EXTEND key.
		///		FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD_EXTEND Description: 
		/// </summary>
		/// <param name="_pgThesisStudExtendId">مد الفترة القانونية لتسجيل الرسالة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByPgThesisStudExtendId(System.Decimal? _pgThesisStudExtendId)
		{
			int count = -1;
			return GetByPgThesisStudExtendId(_pgThesisStudExtendId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD_EXTEND key.
		///		FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD_EXTEND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudExtendId">مد الفترة القانونية لتسجيل الرسالة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisStudApprove> GetByPgThesisStudExtendId(TransactionManager transactionManager, System.Decimal? _pgThesisStudExtendId)
		{
			int count = -1;
			return GetByPgThesisStudExtendId(transactionManager, _pgThesisStudExtendId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD_EXTEND key.
		///		FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD_EXTEND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudExtendId">مد الفترة القانونية لتسجيل الرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByPgThesisStudExtendId(TransactionManager transactionManager, System.Decimal? _pgThesisStudExtendId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisStudExtendId(transactionManager, _pgThesisStudExtendId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD_EXTEND key.
		///		fkPgThesisStudApprovePgThesisStudExtend Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudExtendId">مد الفترة القانونية لتسجيل الرسالة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByPgThesisStudExtendId(System.Decimal? _pgThesisStudExtendId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisStudExtendId(null, _pgThesisStudExtendId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD_EXTEND key.
		///		fkPgThesisStudApprovePgThesisStudExtend Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudExtendId">مد الفترة القانونية لتسجيل الرسالة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByPgThesisStudExtendId(System.Decimal? _pgThesisStudExtendId, int start, int pageLength,out int count)
		{
			return GetByPgThesisStudExtendId(null, _pgThesisStudExtendId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD_EXTEND key.
		///		FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD_EXTEND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudExtendId">مد الفترة القانونية لتسجيل الرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public abstract TList<PgThesisStudApprove> GetByPgThesisStudExtendId(TransactionManager transactionManager, System.Decimal? _pgThesisStudExtendId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD_RSRCH_STRTGY key.
		///		FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD_RSRCH_STRTGY Description: 
		/// </summary>
		/// <param name="_pgThesisStudRsrchStrtgyId">تسجيل الخطة البحثية للرسالة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByPgThesisStudRsrchStrtgyId(System.Decimal? _pgThesisStudRsrchStrtgyId)
		{
			int count = -1;
			return GetByPgThesisStudRsrchStrtgyId(_pgThesisStudRsrchStrtgyId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD_RSRCH_STRTGY key.
		///		FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD_RSRCH_STRTGY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudRsrchStrtgyId">تسجيل الخطة البحثية للرسالة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisStudApprove> GetByPgThesisStudRsrchStrtgyId(TransactionManager transactionManager, System.Decimal? _pgThesisStudRsrchStrtgyId)
		{
			int count = -1;
			return GetByPgThesisStudRsrchStrtgyId(transactionManager, _pgThesisStudRsrchStrtgyId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD_RSRCH_STRTGY key.
		///		FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD_RSRCH_STRTGY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudRsrchStrtgyId">تسجيل الخطة البحثية للرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByPgThesisStudRsrchStrtgyId(TransactionManager transactionManager, System.Decimal? _pgThesisStudRsrchStrtgyId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisStudRsrchStrtgyId(transactionManager, _pgThesisStudRsrchStrtgyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD_RSRCH_STRTGY key.
		///		fkPgThesisStudApprovePgThesisStudRsrchStrtgy Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudRsrchStrtgyId">تسجيل الخطة البحثية للرسالة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByPgThesisStudRsrchStrtgyId(System.Decimal? _pgThesisStudRsrchStrtgyId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisStudRsrchStrtgyId(null, _pgThesisStudRsrchStrtgyId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD_RSRCH_STRTGY key.
		///		fkPgThesisStudApprovePgThesisStudRsrchStrtgy Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudRsrchStrtgyId">تسجيل الخطة البحثية للرسالة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByPgThesisStudRsrchStrtgyId(System.Decimal? _pgThesisStudRsrchStrtgyId, int start, int pageLength,out int count)
		{
			return GetByPgThesisStudRsrchStrtgyId(null, _pgThesisStudRsrchStrtgyId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD_RSRCH_STRTGY key.
		///		FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD_RSRCH_STRTGY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudRsrchStrtgyId">تسجيل الخطة البحثية للرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public abstract TList<PgThesisStudApprove> GetByPgThesisStudRsrchStrtgyId(TransactionManager transactionManager, System.Decimal? _pgThesisStudRsrchStrtgyId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD_TOPIC key.
		///		FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD_TOPIC Description: 
		/// </summary>
		/// <param name="_pgThesisStudTopicId">عنوان ومجال  البحث</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByPgThesisStudTopicId(System.Decimal? _pgThesisStudTopicId)
		{
			int count = -1;
			return GetByPgThesisStudTopicId(_pgThesisStudTopicId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD_TOPIC key.
		///		FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD_TOPIC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudTopicId">عنوان ومجال  البحث</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisStudApprove> GetByPgThesisStudTopicId(TransactionManager transactionManager, System.Decimal? _pgThesisStudTopicId)
		{
			int count = -1;
			return GetByPgThesisStudTopicId(transactionManager, _pgThesisStudTopicId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD_TOPIC key.
		///		FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD_TOPIC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudTopicId">عنوان ومجال  البحث</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByPgThesisStudTopicId(TransactionManager transactionManager, System.Decimal? _pgThesisStudTopicId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisStudTopicId(transactionManager, _pgThesisStudTopicId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD_TOPIC key.
		///		fkPgThesisStudApprovePgThesisStudTopic Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudTopicId">عنوان ومجال  البحث</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByPgThesisStudTopicId(System.Decimal? _pgThesisStudTopicId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisStudTopicId(null, _pgThesisStudTopicId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD_TOPIC key.
		///		fkPgThesisStudApprovePgThesisStudTopic Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudTopicId">عنوان ومجال  البحث</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByPgThesisStudTopicId(System.Decimal? _pgThesisStudTopicId, int start, int pageLength,out int count)
		{
			return GetByPgThesisStudTopicId(null, _pgThesisStudTopicId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD_TOPIC key.
		///		FK_PG_THESIS_STUD_APPROVE_PG_THESIS_STUD_TOPIC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudTopicId">عنوان ومجال  البحث</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public abstract TList<PgThesisStudApprove> GetByPgThesisStudTopicId(TransactionManager transactionManager, System.Decimal? _pgThesisStudTopicId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_VALIDITY_RPT key.
		///		FK_PG_THESIS_STUD_APPROVE_PG_THESIS_VALIDITY_RPT Description: 
		/// </summary>
		/// <param name="_pgThesisValidityRptId">تقرير صلاحية الرسالة للمناقشة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByPgThesisValidityRptId(System.Decimal? _pgThesisValidityRptId)
		{
			int count = -1;
			return GetByPgThesisValidityRptId(_pgThesisValidityRptId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_VALIDITY_RPT key.
		///		FK_PG_THESIS_STUD_APPROVE_PG_THESIS_VALIDITY_RPT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisValidityRptId">تقرير صلاحية الرسالة للمناقشة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisStudApprove> GetByPgThesisValidityRptId(TransactionManager transactionManager, System.Decimal? _pgThesisValidityRptId)
		{
			int count = -1;
			return GetByPgThesisValidityRptId(transactionManager, _pgThesisValidityRptId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_VALIDITY_RPT key.
		///		FK_PG_THESIS_STUD_APPROVE_PG_THESIS_VALIDITY_RPT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisValidityRptId">تقرير صلاحية الرسالة للمناقشة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByPgThesisValidityRptId(TransactionManager transactionManager, System.Decimal? _pgThesisValidityRptId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisValidityRptId(transactionManager, _pgThesisValidityRptId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_VALIDITY_RPT key.
		///		fkPgThesisStudApprovePgThesisValidityRpt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisValidityRptId">تقرير صلاحية الرسالة للمناقشة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByPgThesisValidityRptId(System.Decimal? _pgThesisValidityRptId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisValidityRptId(null, _pgThesisValidityRptId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_VALIDITY_RPT key.
		///		fkPgThesisStudApprovePgThesisValidityRpt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisValidityRptId">تقرير صلاحية الرسالة للمناقشة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public TList<PgThesisStudApprove> GetByPgThesisValidityRptId(System.Decimal? _pgThesisValidityRptId, int start, int pageLength,out int count)
		{
			return GetByPgThesisValidityRptId(null, _pgThesisValidityRptId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_APPROVE_PG_THESIS_VALIDITY_RPT key.
		///		FK_PG_THESIS_STUD_APPROVE_PG_THESIS_VALIDITY_RPT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisValidityRptId">تقرير صلاحية الرسالة للمناقشة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudApprove objects.</returns>
		public abstract TList<PgThesisStudApprove> GetByPgThesisValidityRptId(TransactionManager transactionManager, System.Decimal? _pgThesisValidityRptId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.PgThesisStudApprove Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisStudApproveKey key, int start, int pageLength)
		{
			return GetByPgThesisStudApproveId(transactionManager, key.PgThesisStudApproveId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PG_THESIS_STUD_APPROVE index.
		/// </summary>
		/// <param name="_pgThesisStudApproveId">اعتمادات بيانات الرسالة</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisStudApprove"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisStudApprove GetByPgThesisStudApproveId(System.Decimal _pgThesisStudApproveId)
		{
			int count = -1;
			return GetByPgThesisStudApproveId(null,_pgThesisStudApproveId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_STUD_APPROVE index.
		/// </summary>
		/// <param name="_pgThesisStudApproveId">اعتمادات بيانات الرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisStudApprove"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisStudApprove GetByPgThesisStudApproveId(System.Decimal _pgThesisStudApproveId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisStudApproveId(null, _pgThesisStudApproveId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_STUD_APPROVE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudApproveId">اعتمادات بيانات الرسالة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisStudApprove"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisStudApprove GetByPgThesisStudApproveId(TransactionManager transactionManager, System.Decimal _pgThesisStudApproveId)
		{
			int count = -1;
			return GetByPgThesisStudApproveId(transactionManager, _pgThesisStudApproveId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_STUD_APPROVE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudApproveId">اعتمادات بيانات الرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisStudApprove"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisStudApprove GetByPgThesisStudApproveId(TransactionManager transactionManager, System.Decimal _pgThesisStudApproveId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisStudApproveId(transactionManager, _pgThesisStudApproveId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_STUD_APPROVE index.
		/// </summary>
		/// <param name="_pgThesisStudApproveId">اعتمادات بيانات الرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisStudApprove"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisStudApprove GetByPgThesisStudApproveId(System.Decimal _pgThesisStudApproveId, int start, int pageLength, out int count)
		{
			return GetByPgThesisStudApproveId(null, _pgThesisStudApproveId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_STUD_APPROVE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudApproveId">اعتمادات بيانات الرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisStudApprove"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgThesisStudApprove GetByPgThesisStudApproveId(TransactionManager transactionManager, System.Decimal _pgThesisStudApproveId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PgThesisStudApprove&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PgThesisStudApprove&gt;"/></returns>
		public static TList<PgThesisStudApprove> Fill(IDataReader reader, TList<PgThesisStudApprove> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.PgThesisStudApprove c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PgThesisStudApprove")
					.Append("|").Append((System.Decimal)reader["PG_THESIS_STUD_APPROVE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<PgThesisStudApprove>(
					key.ToString(), // EntityTrackingKey
					"PgThesisStudApprove",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.PgThesisStudApprove();
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
					c.PgThesisStudApproveId = (System.Decimal)reader["PG_THESIS_STUD_APPROVE_ID"];
					c.OriginalPgThesisStudApproveId = c.PgThesisStudApproveId;
					c.GsCodeApprovalFuncId = (System.Decimal)reader["GS_CODE_APPROVAL_FUNC_ID"];
					c.PgThesisStudId = Convert.IsDBNull(reader["PG_THESIS_STUD_ID"]) ? null : (System.Decimal?)reader["PG_THESIS_STUD_ID"];
					c.PgThesisStudTopicId = Convert.IsDBNull(reader["PG_THESIS_STUD_TOPIC_ID"]) ? null : (System.Decimal?)reader["PG_THESIS_STUD_TOPIC_ID"];
					c.PgThesisStudRsrchStrtgyId = Convert.IsDBNull(reader["PG_THESIS_STUD_RSRCH_STRTGY_ID"]) ? null : (System.Decimal?)reader["PG_THESIS_STUD_RSRCH_STRTGY_ID"];
					c.PgThesisSeminarId = Convert.IsDBNull(reader["PG_THESIS_SEMINAR_ID"]) ? null : (System.Decimal?)reader["PG_THESIS_SEMINAR_ID"];
					c.PgThesisStudExtendId = Convert.IsDBNull(reader["PG_THESIS_STUD_EXTEND_ID"]) ? null : (System.Decimal?)reader["PG_THESIS_STUD_EXTEND_ID"];
					c.PgStudTravelId = Convert.IsDBNull(reader["PG_STUD_TRAVEL_ID"]) ? null : (System.Decimal?)reader["PG_STUD_TRAVEL_ID"];
					c.PgStudTravelExtendId = Convert.IsDBNull(reader["PG_STUD_TRAVEL_EXTEND_ID"]) ? null : (System.Decimal?)reader["PG_STUD_TRAVEL_EXTEND_ID"];
					c.PgThesisValidityRptId = Convert.IsDBNull(reader["PG_THESIS_VALIDITY_RPT_ID"]) ? null : (System.Decimal?)reader["PG_THESIS_VALIDITY_RPT_ID"];
					c.PgThesisCommRecommendId = Convert.IsDBNull(reader["PG_THESIS_COMM_RECOMMEND_ID"]) ? null : (System.Decimal?)reader["PG_THESIS_COMM_RECOMMEND_ID"];
					c.GsCodeApprovalId = (System.Decimal)reader["GS_CODE_APPROVAL_ID"];
					c.ApproveDate = Convert.IsDBNull(reader["APPROVE_DATE"]) ? null : (System.DateTime?)reader["APPROVE_DATE"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisStudApprove"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisStudApprove"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.PgThesisStudApprove entity)
		{
			if (!reader.Read()) return;
			
			entity.PgThesisStudApproveId = (System.Decimal)reader[((int)PgThesisStudApproveColumn.PgThesisStudApproveId - 1)];
			entity.OriginalPgThesisStudApproveId = (System.Decimal)reader["PG_THESIS_STUD_APPROVE_ID"];
			entity.GsCodeApprovalFuncId = (System.Decimal)reader[((int)PgThesisStudApproveColumn.GsCodeApprovalFuncId - 1)];
			entity.PgThesisStudId = (reader.IsDBNull(((int)PgThesisStudApproveColumn.PgThesisStudId - 1)))?null:(System.Decimal?)reader[((int)PgThesisStudApproveColumn.PgThesisStudId - 1)];
			entity.PgThesisStudTopicId = (reader.IsDBNull(((int)PgThesisStudApproveColumn.PgThesisStudTopicId - 1)))?null:(System.Decimal?)reader[((int)PgThesisStudApproveColumn.PgThesisStudTopicId - 1)];
			entity.PgThesisStudRsrchStrtgyId = (reader.IsDBNull(((int)PgThesisStudApproveColumn.PgThesisStudRsrchStrtgyId - 1)))?null:(System.Decimal?)reader[((int)PgThesisStudApproveColumn.PgThesisStudRsrchStrtgyId - 1)];
			entity.PgThesisSeminarId = (reader.IsDBNull(((int)PgThesisStudApproveColumn.PgThesisSeminarId - 1)))?null:(System.Decimal?)reader[((int)PgThesisStudApproveColumn.PgThesisSeminarId - 1)];
			entity.PgThesisStudExtendId = (reader.IsDBNull(((int)PgThesisStudApproveColumn.PgThesisStudExtendId - 1)))?null:(System.Decimal?)reader[((int)PgThesisStudApproveColumn.PgThesisStudExtendId - 1)];
			entity.PgStudTravelId = (reader.IsDBNull(((int)PgThesisStudApproveColumn.PgStudTravelId - 1)))?null:(System.Decimal?)reader[((int)PgThesisStudApproveColumn.PgStudTravelId - 1)];
			entity.PgStudTravelExtendId = (reader.IsDBNull(((int)PgThesisStudApproveColumn.PgStudTravelExtendId - 1)))?null:(System.Decimal?)reader[((int)PgThesisStudApproveColumn.PgStudTravelExtendId - 1)];
			entity.PgThesisValidityRptId = (reader.IsDBNull(((int)PgThesisStudApproveColumn.PgThesisValidityRptId - 1)))?null:(System.Decimal?)reader[((int)PgThesisStudApproveColumn.PgThesisValidityRptId - 1)];
			entity.PgThesisCommRecommendId = (reader.IsDBNull(((int)PgThesisStudApproveColumn.PgThesisCommRecommendId - 1)))?null:(System.Decimal?)reader[((int)PgThesisStudApproveColumn.PgThesisCommRecommendId - 1)];
			entity.GsCodeApprovalId = (System.Decimal)reader[((int)PgThesisStudApproveColumn.GsCodeApprovalId - 1)];
			entity.ApproveDate = (reader.IsDBNull(((int)PgThesisStudApproveColumn.ApproveDate - 1)))?null:(System.DateTime?)reader[((int)PgThesisStudApproveColumn.ApproveDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)PgThesisStudApproveColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)PgThesisStudApproveColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)PgThesisStudApproveColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)PgThesisStudApproveColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisStudApprove"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisStudApprove"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.PgThesisStudApprove entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PgThesisStudApproveId = (System.Decimal)dataRow["PG_THESIS_STUD_APPROVE_ID"];
			entity.OriginalPgThesisStudApproveId = (System.Decimal)dataRow["PG_THESIS_STUD_APPROVE_ID"];
			entity.GsCodeApprovalFuncId = (System.Decimal)dataRow["GS_CODE_APPROVAL_FUNC_ID"];
			entity.PgThesisStudId = Convert.IsDBNull(dataRow["PG_THESIS_STUD_ID"]) ? null : (System.Decimal?)dataRow["PG_THESIS_STUD_ID"];
			entity.PgThesisStudTopicId = Convert.IsDBNull(dataRow["PG_THESIS_STUD_TOPIC_ID"]) ? null : (System.Decimal?)dataRow["PG_THESIS_STUD_TOPIC_ID"];
			entity.PgThesisStudRsrchStrtgyId = Convert.IsDBNull(dataRow["PG_THESIS_STUD_RSRCH_STRTGY_ID"]) ? null : (System.Decimal?)dataRow["PG_THESIS_STUD_RSRCH_STRTGY_ID"];
			entity.PgThesisSeminarId = Convert.IsDBNull(dataRow["PG_THESIS_SEMINAR_ID"]) ? null : (System.Decimal?)dataRow["PG_THESIS_SEMINAR_ID"];
			entity.PgThesisStudExtendId = Convert.IsDBNull(dataRow["PG_THESIS_STUD_EXTEND_ID"]) ? null : (System.Decimal?)dataRow["PG_THESIS_STUD_EXTEND_ID"];
			entity.PgStudTravelId = Convert.IsDBNull(dataRow["PG_STUD_TRAVEL_ID"]) ? null : (System.Decimal?)dataRow["PG_STUD_TRAVEL_ID"];
			entity.PgStudTravelExtendId = Convert.IsDBNull(dataRow["PG_STUD_TRAVEL_EXTEND_ID"]) ? null : (System.Decimal?)dataRow["PG_STUD_TRAVEL_EXTEND_ID"];
			entity.PgThesisValidityRptId = Convert.IsDBNull(dataRow["PG_THESIS_VALIDITY_RPT_ID"]) ? null : (System.Decimal?)dataRow["PG_THESIS_VALIDITY_RPT_ID"];
			entity.PgThesisCommRecommendId = Convert.IsDBNull(dataRow["PG_THESIS_COMM_RECOMMEND_ID"]) ? null : (System.Decimal?)dataRow["PG_THESIS_COMM_RECOMMEND_ID"];
			entity.GsCodeApprovalId = (System.Decimal)dataRow["GS_CODE_APPROVAL_ID"];
			entity.ApproveDate = Convert.IsDBNull(dataRow["APPROVE_DATE"]) ? null : (System.DateTime?)dataRow["APPROVE_DATE"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisStudApprove"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisStudApprove Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisStudApprove entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region GsCodeApprovalIdSource	
			if (CanDeepLoad(entity, "GsCodeApproval|GsCodeApprovalIdSource", deepLoadType, innerList) 
				&& entity.GsCodeApprovalIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodeApprovalId;
				GsCodeApproval tmpEntity = EntityManager.LocateEntity<GsCodeApproval>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeApproval), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeApprovalIdSource = tmpEntity;
				else
					entity.GsCodeApprovalIdSource = DataRepository.GsCodeApprovalProvider.GetByGsCodeApprovalId(transactionManager, entity.GsCodeApprovalId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeApprovalIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeApprovalIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeApprovalProvider.DeepLoad(transactionManager, entity.GsCodeApprovalIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeApprovalIdSource

			#region GsCodeApprovalFuncIdSource	
			if (CanDeepLoad(entity, "GsCodeApprovalFunc|GsCodeApprovalFuncIdSource", deepLoadType, innerList) 
				&& entity.GsCodeApprovalFuncIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodeApprovalFuncId;
				GsCodeApprovalFunc tmpEntity = EntityManager.LocateEntity<GsCodeApprovalFunc>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeApprovalFunc), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeApprovalFuncIdSource = tmpEntity;
				else
					entity.GsCodeApprovalFuncIdSource = DataRepository.GsCodeApprovalFuncProvider.GetByGsCodeApprovalFuncId(transactionManager, entity.GsCodeApprovalFuncId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeApprovalFuncIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeApprovalFuncIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeApprovalFuncProvider.DeepLoad(transactionManager, entity.GsCodeApprovalFuncIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeApprovalFuncIdSource

			#region PgStudTravelIdSource	
			if (CanDeepLoad(entity, "PgStudTravel|PgStudTravelIdSource", deepLoadType, innerList) 
				&& entity.PgStudTravelIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.PgStudTravelId ?? 0.0m);
				PgStudTravel tmpEntity = EntityManager.LocateEntity<PgStudTravel>(EntityLocator.ConstructKeyFromPkItems(typeof(PgStudTravel), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgStudTravelIdSource = tmpEntity;
				else
					entity.PgStudTravelIdSource = DataRepository.PgStudTravelProvider.GetByPgStudTravelId(transactionManager, (entity.PgStudTravelId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgStudTravelIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgStudTravelIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgStudTravelProvider.DeepLoad(transactionManager, entity.PgStudTravelIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgStudTravelIdSource

			#region PgStudTravelExtendIdSource	
			if (CanDeepLoad(entity, "PgStudTravelExtend|PgStudTravelExtendIdSource", deepLoadType, innerList) 
				&& entity.PgStudTravelExtendIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.PgStudTravelExtendId ?? 0.0m);
				PgStudTravelExtend tmpEntity = EntityManager.LocateEntity<PgStudTravelExtend>(EntityLocator.ConstructKeyFromPkItems(typeof(PgStudTravelExtend), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgStudTravelExtendIdSource = tmpEntity;
				else
					entity.PgStudTravelExtendIdSource = DataRepository.PgStudTravelExtendProvider.GetByPgStudTravelExtendId(transactionManager, (entity.PgStudTravelExtendId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgStudTravelExtendIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgStudTravelExtendIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgStudTravelExtendProvider.DeepLoad(transactionManager, entity.PgStudTravelExtendIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgStudTravelExtendIdSource

			#region PgThesisCommRecommendIdSource	
			if (CanDeepLoad(entity, "PgThesisCommRecommend|PgThesisCommRecommendIdSource", deepLoadType, innerList) 
				&& entity.PgThesisCommRecommendIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.PgThesisCommRecommendId ?? 0.0m);
				PgThesisCommRecommend tmpEntity = EntityManager.LocateEntity<PgThesisCommRecommend>(EntityLocator.ConstructKeyFromPkItems(typeof(PgThesisCommRecommend), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgThesisCommRecommendIdSource = tmpEntity;
				else
					entity.PgThesisCommRecommendIdSource = DataRepository.PgThesisCommRecommendProvider.GetByPgThesisCommRecommendId(transactionManager, (entity.PgThesisCommRecommendId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisCommRecommendIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgThesisCommRecommendIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgThesisCommRecommendProvider.DeepLoad(transactionManager, entity.PgThesisCommRecommendIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgThesisCommRecommendIdSource

			#region PgThesisSeminarIdSource	
			if (CanDeepLoad(entity, "PgThesisSeminar|PgThesisSeminarIdSource", deepLoadType, innerList) 
				&& entity.PgThesisSeminarIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.PgThesisSeminarId ?? 0.0m);
				PgThesisSeminar tmpEntity = EntityManager.LocateEntity<PgThesisSeminar>(EntityLocator.ConstructKeyFromPkItems(typeof(PgThesisSeminar), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgThesisSeminarIdSource = tmpEntity;
				else
					entity.PgThesisSeminarIdSource = DataRepository.PgThesisSeminarProvider.GetByPgThesisSeminarId(transactionManager, (entity.PgThesisSeminarId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisSeminarIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgThesisSeminarIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgThesisSeminarProvider.DeepLoad(transactionManager, entity.PgThesisSeminarIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgThesisSeminarIdSource

			#region PgThesisStudIdSource	
			if (CanDeepLoad(entity, "PgThesisStud|PgThesisStudIdSource", deepLoadType, innerList) 
				&& entity.PgThesisStudIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.PgThesisStudId ?? 0.0m);
				PgThesisStud tmpEntity = EntityManager.LocateEntity<PgThesisStud>(EntityLocator.ConstructKeyFromPkItems(typeof(PgThesisStud), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgThesisStudIdSource = tmpEntity;
				else
					entity.PgThesisStudIdSource = DataRepository.PgThesisStudProvider.GetByPgThesisStudId(transactionManager, (entity.PgThesisStudId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgThesisStudIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgThesisStudProvider.DeepLoad(transactionManager, entity.PgThesisStudIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgThesisStudIdSource

			#region PgThesisStudExtendIdSource	
			if (CanDeepLoad(entity, "PgThesisStudExtend|PgThesisStudExtendIdSource", deepLoadType, innerList) 
				&& entity.PgThesisStudExtendIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.PgThesisStudExtendId ?? 0.0m);
				PgThesisStudExtend tmpEntity = EntityManager.LocateEntity<PgThesisStudExtend>(EntityLocator.ConstructKeyFromPkItems(typeof(PgThesisStudExtend), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgThesisStudExtendIdSource = tmpEntity;
				else
					entity.PgThesisStudExtendIdSource = DataRepository.PgThesisStudExtendProvider.GetByPgThesisStudExtendId(transactionManager, (entity.PgThesisStudExtendId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudExtendIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgThesisStudExtendIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgThesisStudExtendProvider.DeepLoad(transactionManager, entity.PgThesisStudExtendIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgThesisStudExtendIdSource

			#region PgThesisStudRsrchStrtgyIdSource	
			if (CanDeepLoad(entity, "PgThesisStudRsrchStrtgy|PgThesisStudRsrchStrtgyIdSource", deepLoadType, innerList) 
				&& entity.PgThesisStudRsrchStrtgyIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.PgThesisStudRsrchStrtgyId ?? 0.0m);
				PgThesisStudRsrchStrtgy tmpEntity = EntityManager.LocateEntity<PgThesisStudRsrchStrtgy>(EntityLocator.ConstructKeyFromPkItems(typeof(PgThesisStudRsrchStrtgy), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgThesisStudRsrchStrtgyIdSource = tmpEntity;
				else
					entity.PgThesisStudRsrchStrtgyIdSource = DataRepository.PgThesisStudRsrchStrtgyProvider.GetByPgThesisStudRsrchStrtgyId(transactionManager, (entity.PgThesisStudRsrchStrtgyId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudRsrchStrtgyIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgThesisStudRsrchStrtgyIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgThesisStudRsrchStrtgyProvider.DeepLoad(transactionManager, entity.PgThesisStudRsrchStrtgyIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgThesisStudRsrchStrtgyIdSource

			#region PgThesisStudTopicIdSource	
			if (CanDeepLoad(entity, "PgThesisStudTopic|PgThesisStudTopicIdSource", deepLoadType, innerList) 
				&& entity.PgThesisStudTopicIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.PgThesisStudTopicId ?? 0.0m);
				PgThesisStudTopic tmpEntity = EntityManager.LocateEntity<PgThesisStudTopic>(EntityLocator.ConstructKeyFromPkItems(typeof(PgThesisStudTopic), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgThesisStudTopicIdSource = tmpEntity;
				else
					entity.PgThesisStudTopicIdSource = DataRepository.PgThesisStudTopicProvider.GetByPgThesisStudTopicId(transactionManager, (entity.PgThesisStudTopicId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudTopicIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgThesisStudTopicIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgThesisStudTopicProvider.DeepLoad(transactionManager, entity.PgThesisStudTopicIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgThesisStudTopicIdSource

			#region PgThesisValidityRptIdSource	
			if (CanDeepLoad(entity, "PgThesisValidityRpt|PgThesisValidityRptIdSource", deepLoadType, innerList) 
				&& entity.PgThesisValidityRptIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.PgThesisValidityRptId ?? 0.0m);
				PgThesisValidityRpt tmpEntity = EntityManager.LocateEntity<PgThesisValidityRpt>(EntityLocator.ConstructKeyFromPkItems(typeof(PgThesisValidityRpt), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgThesisValidityRptIdSource = tmpEntity;
				else
					entity.PgThesisValidityRptIdSource = DataRepository.PgThesisValidityRptProvider.GetByPgThesisValidityRptId(transactionManager, (entity.PgThesisValidityRptId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisValidityRptIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgThesisValidityRptIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgThesisValidityRptProvider.DeepLoad(transactionManager, entity.PgThesisValidityRptIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgThesisValidityRptIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.PgThesisStudApprove object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.PgThesisStudApprove instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisStudApprove Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisStudApprove entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region GsCodeApprovalIdSource
			if (CanDeepSave(entity, "GsCodeApproval|GsCodeApprovalIdSource", deepSaveType, innerList) 
				&& entity.GsCodeApprovalIdSource != null)
			{
				DataRepository.GsCodeApprovalProvider.Save(transactionManager, entity.GsCodeApprovalIdSource);
				entity.GsCodeApprovalId = entity.GsCodeApprovalIdSource.GsCodeApprovalId;
			}
			#endregion 
			
			#region GsCodeApprovalFuncIdSource
			if (CanDeepSave(entity, "GsCodeApprovalFunc|GsCodeApprovalFuncIdSource", deepSaveType, innerList) 
				&& entity.GsCodeApprovalFuncIdSource != null)
			{
				DataRepository.GsCodeApprovalFuncProvider.Save(transactionManager, entity.GsCodeApprovalFuncIdSource);
				entity.GsCodeApprovalFuncId = entity.GsCodeApprovalFuncIdSource.GsCodeApprovalFuncId;
			}
			#endregion 
			
			#region PgStudTravelIdSource
			if (CanDeepSave(entity, "PgStudTravel|PgStudTravelIdSource", deepSaveType, innerList) 
				&& entity.PgStudTravelIdSource != null)
			{
				DataRepository.PgStudTravelProvider.Save(transactionManager, entity.PgStudTravelIdSource);
				entity.PgStudTravelId = entity.PgStudTravelIdSource.PgStudTravelId;
			}
			#endregion 
			
			#region PgStudTravelExtendIdSource
			if (CanDeepSave(entity, "PgStudTravelExtend|PgStudTravelExtendIdSource", deepSaveType, innerList) 
				&& entity.PgStudTravelExtendIdSource != null)
			{
				DataRepository.PgStudTravelExtendProvider.Save(transactionManager, entity.PgStudTravelExtendIdSource);
				entity.PgStudTravelExtendId = entity.PgStudTravelExtendIdSource.PgStudTravelExtendId;
			}
			#endregion 
			
			#region PgThesisCommRecommendIdSource
			if (CanDeepSave(entity, "PgThesisCommRecommend|PgThesisCommRecommendIdSource", deepSaveType, innerList) 
				&& entity.PgThesisCommRecommendIdSource != null)
			{
				DataRepository.PgThesisCommRecommendProvider.Save(transactionManager, entity.PgThesisCommRecommendIdSource);
				entity.PgThesisCommRecommendId = entity.PgThesisCommRecommendIdSource.PgThesisCommRecommendId;
			}
			#endregion 
			
			#region PgThesisSeminarIdSource
			if (CanDeepSave(entity, "PgThesisSeminar|PgThesisSeminarIdSource", deepSaveType, innerList) 
				&& entity.PgThesisSeminarIdSource != null)
			{
				DataRepository.PgThesisSeminarProvider.Save(transactionManager, entity.PgThesisSeminarIdSource);
				entity.PgThesisSeminarId = entity.PgThesisSeminarIdSource.PgThesisSeminarId;
			}
			#endregion 
			
			#region PgThesisStudIdSource
			if (CanDeepSave(entity, "PgThesisStud|PgThesisStudIdSource", deepSaveType, innerList) 
				&& entity.PgThesisStudIdSource != null)
			{
				DataRepository.PgThesisStudProvider.Save(transactionManager, entity.PgThesisStudIdSource);
				entity.PgThesisStudId = entity.PgThesisStudIdSource.PgThesisStudId;
			}
			#endregion 
			
			#region PgThesisStudExtendIdSource
			if (CanDeepSave(entity, "PgThesisStudExtend|PgThesisStudExtendIdSource", deepSaveType, innerList) 
				&& entity.PgThesisStudExtendIdSource != null)
			{
				DataRepository.PgThesisStudExtendProvider.Save(transactionManager, entity.PgThesisStudExtendIdSource);
				entity.PgThesisStudExtendId = entity.PgThesisStudExtendIdSource.PgThesisStudExtendId;
			}
			#endregion 
			
			#region PgThesisStudRsrchStrtgyIdSource
			if (CanDeepSave(entity, "PgThesisStudRsrchStrtgy|PgThesisStudRsrchStrtgyIdSource", deepSaveType, innerList) 
				&& entity.PgThesisStudRsrchStrtgyIdSource != null)
			{
				DataRepository.PgThesisStudRsrchStrtgyProvider.Save(transactionManager, entity.PgThesisStudRsrchStrtgyIdSource);
				entity.PgThesisStudRsrchStrtgyId = entity.PgThesisStudRsrchStrtgyIdSource.PgThesisStudRsrchStrtgyId;
			}
			#endregion 
			
			#region PgThesisStudTopicIdSource
			if (CanDeepSave(entity, "PgThesisStudTopic|PgThesisStudTopicIdSource", deepSaveType, innerList) 
				&& entity.PgThesisStudTopicIdSource != null)
			{
				DataRepository.PgThesisStudTopicProvider.Save(transactionManager, entity.PgThesisStudTopicIdSource);
				entity.PgThesisStudTopicId = entity.PgThesisStudTopicIdSource.PgThesisStudTopicId;
			}
			#endregion 
			
			#region PgThesisValidityRptIdSource
			if (CanDeepSave(entity, "PgThesisValidityRpt|PgThesisValidityRptIdSource", deepSaveType, innerList) 
				&& entity.PgThesisValidityRptIdSource != null)
			{
				DataRepository.PgThesisValidityRptProvider.Save(transactionManager, entity.PgThesisValidityRptIdSource);
				entity.PgThesisValidityRptId = entity.PgThesisValidityRptIdSource.PgThesisValidityRptId;
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
	
	#region PgThesisStudApproveChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.PgThesisStudApprove</c>
	///</summary>
	public enum PgThesisStudApproveChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsCodeApproval</c> at GsCodeApprovalIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeApproval))]
		GsCodeApproval,
		
		///<summary>
		/// Composite Property for <c>GsCodeApprovalFunc</c> at GsCodeApprovalFuncIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeApprovalFunc))]
		GsCodeApprovalFunc,
		
		///<summary>
		/// Composite Property for <c>PgStudTravel</c> at PgStudTravelIdSource
		///</summary>
		[ChildEntityType(typeof(PgStudTravel))]
		PgStudTravel,
		
		///<summary>
		/// Composite Property for <c>PgStudTravelExtend</c> at PgStudTravelExtendIdSource
		///</summary>
		[ChildEntityType(typeof(PgStudTravelExtend))]
		PgStudTravelExtend,
		
		///<summary>
		/// Composite Property for <c>PgThesisCommRecommend</c> at PgThesisCommRecommendIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisCommRecommend))]
		PgThesisCommRecommend,
		
		///<summary>
		/// Composite Property for <c>PgThesisSeminar</c> at PgThesisSeminarIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisSeminar))]
		PgThesisSeminar,
		
		///<summary>
		/// Composite Property for <c>PgThesisStud</c> at PgThesisStudIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisStud))]
		PgThesisStud,
		
		///<summary>
		/// Composite Property for <c>PgThesisStudExtend</c> at PgThesisStudExtendIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisStudExtend))]
		PgThesisStudExtend,
		
		///<summary>
		/// Composite Property for <c>PgThesisStudRsrchStrtgy</c> at PgThesisStudRsrchStrtgyIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisStudRsrchStrtgy))]
		PgThesisStudRsrchStrtgy,
		
		///<summary>
		/// Composite Property for <c>PgThesisStudTopic</c> at PgThesisStudTopicIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisStudTopic))]
		PgThesisStudTopic,
		
		///<summary>
		/// Composite Property for <c>PgThesisValidityRpt</c> at PgThesisValidityRptIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisValidityRpt))]
		PgThesisValidityRpt,
	}
	
	#endregion PgThesisStudApproveChildEntityTypes
	
	#region PgThesisStudApproveFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PgThesisStudApproveColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisStudApprove"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisStudApproveFilterBuilder : SqlFilterBuilder<PgThesisStudApproveColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisStudApproveFilterBuilder class.
		/// </summary>
		public PgThesisStudApproveFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisStudApproveFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisStudApproveFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisStudApproveFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisStudApproveFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisStudApproveFilterBuilder
	
	#region PgThesisStudApproveParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PgThesisStudApproveColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisStudApprove"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisStudApproveParameterBuilder : ParameterizedSqlFilterBuilder<PgThesisStudApproveColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisStudApproveParameterBuilder class.
		/// </summary>
		public PgThesisStudApproveParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisStudApproveParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisStudApproveParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisStudApproveParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisStudApproveParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisStudApproveParameterBuilder
	
	#region PgThesisStudApproveSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PgThesisStudApproveColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisStudApprove"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PgThesisStudApproveSortBuilder : SqlSortBuilder<PgThesisStudApproveColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisStudApproveSqlSortBuilder class.
		/// </summary>
		public PgThesisStudApproveSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PgThesisStudApproveSortBuilder
	
} // end namespace
