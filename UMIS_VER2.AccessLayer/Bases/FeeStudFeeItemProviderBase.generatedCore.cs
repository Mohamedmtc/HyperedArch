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
	/// This class is the base class for any <see cref="FeeStudFeeItemProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeStudFeeItemProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeStudFeeItem, UMIS_VER2.BusinessLyer.FeeStudFeeItemKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudFeeItemKey key)
		{
			return Delete(transactionManager, key.FeeStudFeeItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeStudFeeItemId)
		{
			return Delete(null, _feeStudFeeItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeStudFeeItemId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_003c key.
		///		FK_AUTO_003c Description: 
		/// </summary>
		/// <param name="_feeCodeItemId">NULL:Downpayment  Add 2 Balance</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFeeItem objects.</returns>
		public TList<FeeStudFeeItem> GetByFeeCodeItemId(System.Decimal _feeCodeItemId)
		{
			int count = -1;
			return GetByFeeCodeItemId(_feeCodeItemId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_003c key.
		///		FK_AUTO_003c Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId">NULL:Downpayment  Add 2 Balance</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFeeItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudFeeItem> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal _feeCodeItemId)
		{
			int count = -1;
			return GetByFeeCodeItemId(transactionManager, _feeCodeItemId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_003c key.
		///		FK_AUTO_003c Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId">NULL:Downpayment  Add 2 Balance</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFeeItem objects.</returns>
		public TList<FeeStudFeeItem> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal _feeCodeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeItemId(transactionManager, _feeCodeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_003c key.
		///		fkAuto003c Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeItemId">NULL:Downpayment  Add 2 Balance</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFeeItem objects.</returns>
		public TList<FeeStudFeeItem> GetByFeeCodeItemId(System.Decimal _feeCodeItemId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCodeItemId(null, _feeCodeItemId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_003c key.
		///		fkAuto003c Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeItemId">NULL:Downpayment  Add 2 Balance</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFeeItem objects.</returns>
		public TList<FeeStudFeeItem> GetByFeeCodeItemId(System.Decimal _feeCodeItemId, int start, int pageLength,out int count)
		{
			return GetByFeeCodeItemId(null, _feeCodeItemId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_003c key.
		///		FK_AUTO_003c Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId">NULL:Downpayment  Add 2 Balance</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFeeItem objects.</returns>
		public abstract TList<FeeStudFeeItem> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal _feeCodeItemId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FEE_ITEM_ED_CODE_SEM_ACTVITY key.
		///		FK_FEE_STUD_FEE_ITEM_ED_CODE_SEM_ACTVITY Description: 
		/// </summary>
		/// <param name="_edCodeSemActvityId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFeeItem objects.</returns>
		public TList<FeeStudFeeItem> GetByEdCodeSemActvityId(System.Decimal? _edCodeSemActvityId)
		{
			int count = -1;
			return GetByEdCodeSemActvityId(_edCodeSemActvityId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FEE_ITEM_ED_CODE_SEM_ACTVITY key.
		///		FK_FEE_STUD_FEE_ITEM_ED_CODE_SEM_ACTVITY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemActvityId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFeeItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudFeeItem> GetByEdCodeSemActvityId(TransactionManager transactionManager, System.Decimal? _edCodeSemActvityId)
		{
			int count = -1;
			return GetByEdCodeSemActvityId(transactionManager, _edCodeSemActvityId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FEE_ITEM_ED_CODE_SEM_ACTVITY key.
		///		FK_FEE_STUD_FEE_ITEM_ED_CODE_SEM_ACTVITY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemActvityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFeeItem objects.</returns>
		public TList<FeeStudFeeItem> GetByEdCodeSemActvityId(TransactionManager transactionManager, System.Decimal? _edCodeSemActvityId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemActvityId(transactionManager, _edCodeSemActvityId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FEE_ITEM_ED_CODE_SEM_ACTVITY key.
		///		fkFeeStudFeeItemEdCodeSemActvity Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemActvityId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFeeItem objects.</returns>
		public TList<FeeStudFeeItem> GetByEdCodeSemActvityId(System.Decimal? _edCodeSemActvityId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemActvityId(null, _edCodeSemActvityId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FEE_ITEM_ED_CODE_SEM_ACTVITY key.
		///		fkFeeStudFeeItemEdCodeSemActvity Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemActvityId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFeeItem objects.</returns>
		public TList<FeeStudFeeItem> GetByEdCodeSemActvityId(System.Decimal? _edCodeSemActvityId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemActvityId(null, _edCodeSemActvityId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FEE_ITEM_ED_CODE_SEM_ACTVITY key.
		///		FK_FEE_STUD_FEE_ITEM_ED_CODE_SEM_ACTVITY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemActvityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFeeItem objects.</returns>
		public abstract TList<FeeStudFeeItem> GetByEdCodeSemActvityId(TransactionManager transactionManager, System.Decimal? _edCodeSemActvityId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FEE_ITEM_SE_FORM key.
		///		FK_FEE_STUD_FEE_ITEM_SE_FORM Description: 
		/// </summary>
		/// <param name="_seFormId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFeeItem objects.</returns>
		public TList<FeeStudFeeItem> GetBySeFormId(System.Decimal? _seFormId)
		{
			int count = -1;
			return GetBySeFormId(_seFormId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FEE_ITEM_SE_FORM key.
		///		FK_FEE_STUD_FEE_ITEM_SE_FORM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFeeItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudFeeItem> GetBySeFormId(TransactionManager transactionManager, System.Decimal? _seFormId)
		{
			int count = -1;
			return GetBySeFormId(transactionManager, _seFormId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FEE_ITEM_SE_FORM key.
		///		FK_FEE_STUD_FEE_ITEM_SE_FORM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFeeItem objects.</returns>
		public TList<FeeStudFeeItem> GetBySeFormId(TransactionManager transactionManager, System.Decimal? _seFormId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeFormId(transactionManager, _seFormId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FEE_ITEM_SE_FORM key.
		///		fkFeeStudFeeItemSeForm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seFormId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFeeItem objects.</returns>
		public TList<FeeStudFeeItem> GetBySeFormId(System.Decimal? _seFormId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeFormId(null, _seFormId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FEE_ITEM_SE_FORM key.
		///		fkFeeStudFeeItemSeForm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seFormId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFeeItem objects.</returns>
		public TList<FeeStudFeeItem> GetBySeFormId(System.Decimal? _seFormId, int start, int pageLength,out int count)
		{
			return GetBySeFormId(null, _seFormId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FEE_ITEM_SE_FORM key.
		///		FK_FEE_STUD_FEE_ITEM_SE_FORM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFeeItem objects.</returns>
		public abstract TList<FeeStudFeeItem> GetBySeFormId(TransactionManager transactionManager, System.Decimal? _seFormId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FEE_ITEM_SE_USER key.
		///		FK_FEE_STUD_FEE_ITEM_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFeeItem objects.</returns>
		public TList<FeeStudFeeItem> GetBySeUserId(System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(_seUserId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FEE_ITEM_SE_USER key.
		///		FK_FEE_STUD_FEE_ITEM_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFeeItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudFeeItem> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FEE_ITEM_SE_USER key.
		///		FK_FEE_STUD_FEE_ITEM_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFeeItem objects.</returns>
		public TList<FeeStudFeeItem> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FEE_ITEM_SE_USER key.
		///		fkFeeStudFeeItemSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFeeItem objects.</returns>
		public TList<FeeStudFeeItem> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserId(null, _seUserId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FEE_ITEM_SE_USER key.
		///		fkFeeStudFeeItemSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFeeItem objects.</returns>
		public TList<FeeStudFeeItem> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength,out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FEE_ITEM_SE_USER key.
		///		FK_FEE_STUD_FEE_ITEM_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFeeItem objects.</returns>
		public abstract TList<FeeStudFeeItem> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeStudFeeItem Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudFeeItemKey key, int start, int pageLength)
		{
			return GetByFeeStudFeeItemId(transactionManager, key.FeeStudFeeItemId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null,_asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public abstract TList<FeeStudFeeItem> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByEdAcadYearId(System.Decimal _edAcadYearId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public abstract TList<FeeStudFeeItem> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public abstract TList<FeeStudFeeItem> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByEdStudId(System.Decimal _edStudId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public abstract TList<FeeStudFeeItem> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_FEE_CODE_TYPE_ID_1 index.
		/// </summary>
		/// <param name="_feeCodeTypeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByFeeCodeTypeId(System.Decimal _feeCodeTypeId)
		{
			int count = -1;
			return GetByFeeCodeTypeId(null,_feeCodeTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_CODE_TYPE_ID_1 index.
		/// </summary>
		/// <param name="_feeCodeTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByFeeCodeTypeId(System.Decimal _feeCodeTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeTypeId(null, _feeCodeTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_CODE_TYPE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByFeeCodeTypeId(TransactionManager transactionManager, System.Decimal _feeCodeTypeId)
		{
			int count = -1;
			return GetByFeeCodeTypeId(transactionManager, _feeCodeTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_CODE_TYPE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByFeeCodeTypeId(TransactionManager transactionManager, System.Decimal _feeCodeTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeTypeId(transactionManager, _feeCodeTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_CODE_TYPE_ID_1 index.
		/// </summary>
		/// <param name="_feeCodeTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByFeeCodeTypeId(System.Decimal _feeCodeTypeId, int start, int pageLength, out int count)
		{
			return GetByFeeCodeTypeId(null, _feeCodeTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_CODE_TYPE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public abstract TList<FeeStudFeeItem> GetByFeeCodeTypeId(TransactionManager transactionManager, System.Decimal _feeCodeTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_FEE_FACULTY_ITEM_ID_1 index.
		/// </summary>
		/// <param name="_feeFacultyItemId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByFeeFacultyItemId(System.Decimal? _feeFacultyItemId)
		{
			int count = -1;
			return GetByFeeFacultyItemId(null,_feeFacultyItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_FACULTY_ITEM_ID_1 index.
		/// </summary>
		/// <param name="_feeFacultyItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByFeeFacultyItemId(System.Decimal? _feeFacultyItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeFacultyItemId(null, _feeFacultyItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_FACULTY_ITEM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFacultyItemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByFeeFacultyItemId(TransactionManager transactionManager, System.Decimal? _feeFacultyItemId)
		{
			int count = -1;
			return GetByFeeFacultyItemId(transactionManager, _feeFacultyItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_FACULTY_ITEM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFacultyItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByFeeFacultyItemId(TransactionManager transactionManager, System.Decimal? _feeFacultyItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeFacultyItemId(transactionManager, _feeFacultyItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_FACULTY_ITEM_ID_1 index.
		/// </summary>
		/// <param name="_feeFacultyItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByFeeFacultyItemId(System.Decimal? _feeFacultyItemId, int start, int pageLength, out int count)
		{
			return GetByFeeFacultyItemId(null, _feeFacultyItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_FACULTY_ITEM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFacultyItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public abstract TList<FeeStudFeeItem> GetByFeeFacultyItemId(TransactionManager transactionManager, System.Decimal? _feeFacultyItemId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_CODE_CURRENCY_ID_1 index.
		/// </summary>
		/// <param name="_gsCodeCurrencyId">قيمة التخفيض</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(null,_gsCodeCurrencyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_CURRENCY_ID_1 index.
		/// </summary>
		/// <param name="_gsCodeCurrencyId">قيمة التخفيض</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(null, _gsCodeCurrencyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_CURRENCY_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId">قيمة التخفيض</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(transactionManager, _gsCodeCurrencyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_CURRENCY_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId">قيمة التخفيض</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(transactionManager, _gsCodeCurrencyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_CURRENCY_ID_1 index.
		/// </summary>
		/// <param name="_gsCodeCurrencyId">قيمة التخفيض</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId, int start, int pageLength, out int count)
		{
			return GetByGsCodeCurrencyId(null, _gsCodeCurrencyId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_CURRENCY_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId">قيمة التخفيض</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public abstract TList<FeeStudFeeItem> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_STUD_FEE_ITEM index.
		/// </summary>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudFeeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudFeeItem GetByFeeStudFeeItemId(System.Decimal _feeStudFeeItemId)
		{
			int count = -1;
			return GetByFeeStudFeeItemId(null,_feeStudFeeItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_FEE_ITEM index.
		/// </summary>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudFeeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudFeeItem GetByFeeStudFeeItemId(System.Decimal _feeStudFeeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudFeeItemId(null, _feeStudFeeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_FEE_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudFeeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudFeeItem GetByFeeStudFeeItemId(TransactionManager transactionManager, System.Decimal _feeStudFeeItemId)
		{
			int count = -1;
			return GetByFeeStudFeeItemId(transactionManager, _feeStudFeeItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_FEE_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudFeeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudFeeItem GetByFeeStudFeeItemId(TransactionManager transactionManager, System.Decimal _feeStudFeeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudFeeItemId(transactionManager, _feeStudFeeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_FEE_ITEM index.
		/// </summary>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudFeeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudFeeItem GetByFeeStudFeeItemId(System.Decimal _feeStudFeeItemId, int start, int pageLength, out int count)
		{
			return GetByFeeStudFeeItemId(null, _feeStudFeeItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_FEE_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudFeeItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeStudFeeItem GetByFeeStudFeeItemId(TransactionManager transactionManager, System.Decimal _feeStudFeeItemId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_FEE_STUD_FEE_ITEM index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_feeCodeItemId">NULL:Downpayment  Add 2 Balance</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByEdAcadYearIdEdCodeSemesterIdEdStudIdFeeCodeItemId(System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal _edStudId, System.Decimal _feeCodeItemId)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEdStudIdFeeCodeItemId(null,_edAcadYearId, _edCodeSemesterId, _edStudId, _feeCodeItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_FEE_ITEM index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_feeCodeItemId">NULL:Downpayment  Add 2 Balance</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByEdAcadYearIdEdCodeSemesterIdEdStudIdFeeCodeItemId(System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal _edStudId, System.Decimal _feeCodeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEdStudIdFeeCodeItemId(null, _edAcadYearId, _edCodeSemesterId, _edStudId, _feeCodeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_FEE_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_feeCodeItemId">NULL:Downpayment  Add 2 Balance</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByEdAcadYearIdEdCodeSemesterIdEdStudIdFeeCodeItemId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal _edStudId, System.Decimal _feeCodeItemId)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEdStudIdFeeCodeItemId(transactionManager, _edAcadYearId, _edCodeSemesterId, _edStudId, _feeCodeItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_FEE_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_feeCodeItemId">NULL:Downpayment  Add 2 Balance</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByEdAcadYearIdEdCodeSemesterIdEdStudIdFeeCodeItemId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal _edStudId, System.Decimal _feeCodeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEdStudIdFeeCodeItemId(transactionManager, _edAcadYearId, _edCodeSemesterId, _edStudId, _feeCodeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_FEE_ITEM index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_feeCodeItemId">NULL:Downpayment  Add 2 Balance</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public TList<FeeStudFeeItem> GetByEdAcadYearIdEdCodeSemesterIdEdStudIdFeeCodeItemId(System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal _edStudId, System.Decimal _feeCodeItemId, int start, int pageLength, out int count)
		{
			return GetByEdAcadYearIdEdCodeSemesterIdEdStudIdFeeCodeItemId(null, _edAcadYearId, _edCodeSemesterId, _edStudId, _feeCodeItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_FEE_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_feeCodeItemId">NULL:Downpayment  Add 2 Balance</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudFeeItem&gt;"/> class.</returns>
		public abstract TList<FeeStudFeeItem> GetByEdAcadYearIdEdCodeSemesterIdEdStudIdFeeCodeItemId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal _edStudId, System.Decimal _feeCodeItemId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeStudFeeItem&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeStudFeeItem&gt;"/></returns>
		public static TList<FeeStudFeeItem> Fill(IDataReader reader, TList<FeeStudFeeItem> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeStudFeeItem c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeStudFeeItem")
					.Append("|").Append((System.Decimal)reader["FEE_STUD_FEE_ITEM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeStudFeeItem>(
					key.ToString(), // EntityTrackingKey
					"FeeStudFeeItem",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeStudFeeItem();
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
					c.FeeStudFeeItemId = (System.Decimal)reader["FEE_STUD_FEE_ITEM_ID"];
					c.OriginalFeeStudFeeItemId = c.FeeStudFeeItemId;
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_ID"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.FeeCodeTypeId = (System.Decimal)reader["FEE_CODE_TYPE_ID"];
					c.FeeFacultyItemId = Convert.IsDBNull(reader["FEE_FACULTY_ITEM_ID"]) ? null : (System.Decimal?)reader["FEE_FACULTY_ITEM_ID"];
					c.FeeItemValue = (System.Decimal)reader["FEE_ITEM_VALUE"];
					c.RemainAmount = (System.Decimal)reader["REMAIN_AMOUNT"];
					c.GsCodeCurrencyId = (System.Decimal)reader["GS_CODE_CURRENCY_ID"];
					c.DiscAmount = Convert.IsDBNull(reader["DISC_AMOUNT"]) ? null : (System.Decimal?)reader["DISC_AMOUNT"];
					c.SpoAmount = Convert.IsDBNull(reader["SPO_AMOUNT"]) ? null : (System.Decimal?)reader["SPO_AMOUNT"];
					c.FeeCodeItemId = (System.Decimal)reader["FEE_CODE_ITEM_ID"];
					c.EdCodeSemActvityId = Convert.IsDBNull(reader["ED_CODE_SEM_ACTVITY_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEM_ACTVITY_ID"];
					c.TransId = Convert.IsDBNull(reader["TRANS_ID"]) ? null : (System.Decimal?)reader["TRANS_ID"];
					c.ItemDesc = Convert.IsDBNull(reader["ITEM_DESC"]) ? null : (System.String)reader["ITEM_DESC"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.DueDate = Convert.IsDBNull(reader["DUE_DATE"]) ? null : (System.DateTime?)reader["DUE_DATE"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.LoadDate = Convert.IsDBNull(reader["LOAD_DATE"]) ? null : (System.DateTime?)reader["LOAD_DATE"];
					c.SeFormId = Convert.IsDBNull(reader["SE_FORM_ID"]) ? null : (System.Decimal?)reader["SE_FORM_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeStudFeeItem"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudFeeItem"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeStudFeeItem entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeStudFeeItemId = (System.Decimal)reader[((int)FeeStudFeeItemColumn.FeeStudFeeItemId - 1)];
			entity.OriginalFeeStudFeeItemId = (System.Decimal)reader["FEE_STUD_FEE_ITEM_ID"];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)FeeStudFeeItemColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)FeeStudFeeItemColumn.AsFacultyInfoId - 1)];
			entity.EdAcadYearId = (System.Decimal)reader[((int)FeeStudFeeItemColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (reader.IsDBNull(((int)FeeStudFeeItemColumn.EdCodeSemesterId - 1)))?null:(System.Decimal?)reader[((int)FeeStudFeeItemColumn.EdCodeSemesterId - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)FeeStudFeeItemColumn.EdStudId - 1)];
			entity.FeeCodeTypeId = (System.Decimal)reader[((int)FeeStudFeeItemColumn.FeeCodeTypeId - 1)];
			entity.FeeFacultyItemId = (reader.IsDBNull(((int)FeeStudFeeItemColumn.FeeFacultyItemId - 1)))?null:(System.Decimal?)reader[((int)FeeStudFeeItemColumn.FeeFacultyItemId - 1)];
			entity.FeeItemValue = (System.Decimal)reader[((int)FeeStudFeeItemColumn.FeeItemValue - 1)];
			entity.RemainAmount = (System.Decimal)reader[((int)FeeStudFeeItemColumn.RemainAmount - 1)];
			entity.GsCodeCurrencyId = (System.Decimal)reader[((int)FeeStudFeeItemColumn.GsCodeCurrencyId - 1)];
			entity.DiscAmount = (reader.IsDBNull(((int)FeeStudFeeItemColumn.DiscAmount - 1)))?null:(System.Decimal?)reader[((int)FeeStudFeeItemColumn.DiscAmount - 1)];
			entity.SpoAmount = (reader.IsDBNull(((int)FeeStudFeeItemColumn.SpoAmount - 1)))?null:(System.Decimal?)reader[((int)FeeStudFeeItemColumn.SpoAmount - 1)];
			entity.FeeCodeItemId = (System.Decimal)reader[((int)FeeStudFeeItemColumn.FeeCodeItemId - 1)];
			entity.EdCodeSemActvityId = (reader.IsDBNull(((int)FeeStudFeeItemColumn.EdCodeSemActvityId - 1)))?null:(System.Decimal?)reader[((int)FeeStudFeeItemColumn.EdCodeSemActvityId - 1)];
			entity.TransId = (reader.IsDBNull(((int)FeeStudFeeItemColumn.TransId - 1)))?null:(System.Decimal?)reader[((int)FeeStudFeeItemColumn.TransId - 1)];
			entity.ItemDesc = (reader.IsDBNull(((int)FeeStudFeeItemColumn.ItemDesc - 1)))?null:(System.String)reader[((int)FeeStudFeeItemColumn.ItemDesc - 1)];
			entity.Notes = (reader.IsDBNull(((int)FeeStudFeeItemColumn.Notes - 1)))?null:(System.String)reader[((int)FeeStudFeeItemColumn.Notes - 1)];
			entity.DueDate = (reader.IsDBNull(((int)FeeStudFeeItemColumn.DueDate - 1)))?null:(System.DateTime?)reader[((int)FeeStudFeeItemColumn.DueDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)FeeStudFeeItemColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)FeeStudFeeItemColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)FeeStudFeeItemColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)FeeStudFeeItemColumn.LastDate - 1)];
			entity.LoadDate = (reader.IsDBNull(((int)FeeStudFeeItemColumn.LoadDate - 1)))?null:(System.DateTime?)reader[((int)FeeStudFeeItemColumn.LoadDate - 1)];
			entity.SeFormId = (reader.IsDBNull(((int)FeeStudFeeItemColumn.SeFormId - 1)))?null:(System.Decimal?)reader[((int)FeeStudFeeItemColumn.SeFormId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeStudFeeItem"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudFeeItem"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeStudFeeItem entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeStudFeeItemId = (System.Decimal)dataRow["FEE_STUD_FEE_ITEM_ID"];
			entity.OriginalFeeStudFeeItemId = (System.Decimal)dataRow["FEE_STUD_FEE_ITEM_ID"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.FeeCodeTypeId = (System.Decimal)dataRow["FEE_CODE_TYPE_ID"];
			entity.FeeFacultyItemId = Convert.IsDBNull(dataRow["FEE_FACULTY_ITEM_ID"]) ? null : (System.Decimal?)dataRow["FEE_FACULTY_ITEM_ID"];
			entity.FeeItemValue = (System.Decimal)dataRow["FEE_ITEM_VALUE"];
			entity.RemainAmount = (System.Decimal)dataRow["REMAIN_AMOUNT"];
			entity.GsCodeCurrencyId = (System.Decimal)dataRow["GS_CODE_CURRENCY_ID"];
			entity.DiscAmount = Convert.IsDBNull(dataRow["DISC_AMOUNT"]) ? null : (System.Decimal?)dataRow["DISC_AMOUNT"];
			entity.SpoAmount = Convert.IsDBNull(dataRow["SPO_AMOUNT"]) ? null : (System.Decimal?)dataRow["SPO_AMOUNT"];
			entity.FeeCodeItemId = (System.Decimal)dataRow["FEE_CODE_ITEM_ID"];
			entity.EdCodeSemActvityId = Convert.IsDBNull(dataRow["ED_CODE_SEM_ACTVITY_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEM_ACTVITY_ID"];
			entity.TransId = Convert.IsDBNull(dataRow["TRANS_ID"]) ? null : (System.Decimal?)dataRow["TRANS_ID"];
			entity.ItemDesc = Convert.IsDBNull(dataRow["ITEM_DESC"]) ? null : (System.String)dataRow["ITEM_DESC"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.DueDate = Convert.IsDBNull(dataRow["DUE_DATE"]) ? null : (System.DateTime?)dataRow["DUE_DATE"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.LoadDate = Convert.IsDBNull(dataRow["LOAD_DATE"]) ? null : (System.DateTime?)dataRow["LOAD_DATE"];
			entity.SeFormId = Convert.IsDBNull(dataRow["SE_FORM_ID"]) ? null : (System.Decimal?)dataRow["SE_FORM_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudFeeItem"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeStudFeeItem Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudFeeItem entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region FeeCodeItemIdSource	
			if (CanDeepLoad(entity, "FeeCodeItem|FeeCodeItemIdSource", deepLoadType, innerList) 
				&& entity.FeeCodeItemIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeCodeItemId;
				FeeCodeItem tmpEntity = EntityManager.LocateEntity<FeeCodeItem>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCodeItem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCodeItemIdSource = tmpEntity;
				else
					entity.FeeCodeItemIdSource = DataRepository.FeeCodeItemProvider.GetByFeeCodeItemId(transactionManager, entity.FeeCodeItemId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCodeItemIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeCodeItemIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeCodeItemProvider.DeepLoad(transactionManager, entity.FeeCodeItemIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeCodeItemIdSource

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

			#region EdCodeSemActvityIdSource	
			if (CanDeepLoad(entity, "EdCodeSemActvity|EdCodeSemActvityIdSource", deepLoadType, innerList) 
				&& entity.EdCodeSemActvityIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeSemActvityId ?? 0.0m);
				EdCodeSemActvity tmpEntity = EntityManager.LocateEntity<EdCodeSemActvity>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemActvity), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemActvityIdSource = tmpEntity;
				else
					entity.EdCodeSemActvityIdSource = DataRepository.EdCodeSemActvityProvider.GetByEdCodeSemActvityId(transactionManager, (entity.EdCodeSemActvityId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeSemActvityIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeSemActvityIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeSemActvityProvider.DeepLoad(transactionManager, entity.EdCodeSemActvityIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeSemActvityIdSource

			#region EdCodeSemesterIdSource	
			if (CanDeepLoad(entity, "EdCodeSemester|EdCodeSemesterIdSource", deepLoadType, innerList) 
				&& entity.EdCodeSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeSemesterId ?? 0.0m);
				EdCodeSemester tmpEntity = EntityManager.LocateEntity<EdCodeSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemesterIdSource = tmpEntity;
				else
					entity.EdCodeSemesterIdSource = DataRepository.EdCodeSemesterProvider.GetByEdCodeSemesterId(transactionManager, (entity.EdCodeSemesterId ?? 0.0m));		
				
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

			#region FeeCodeTypeIdSource	
			if (CanDeepLoad(entity, "FeeCodeType|FeeCodeTypeIdSource", deepLoadType, innerList) 
				&& entity.FeeCodeTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeCodeTypeId;
				FeeCodeType tmpEntity = EntityManager.LocateEntity<FeeCodeType>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCodeType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCodeTypeIdSource = tmpEntity;
				else
					entity.FeeCodeTypeIdSource = DataRepository.FeeCodeTypeProvider.GetByFeeCodeTypeId(transactionManager, entity.FeeCodeTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCodeTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeCodeTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeCodeTypeProvider.DeepLoad(transactionManager, entity.FeeCodeTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeCodeTypeIdSource

			#region FeeFacultyItemIdSource	
			if (CanDeepLoad(entity, "FeeFacultyItem|FeeFacultyItemIdSource", deepLoadType, innerList) 
				&& entity.FeeFacultyItemIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeFacultyItemId ?? 0.0m);
				FeeFacultyItem tmpEntity = EntityManager.LocateEntity<FeeFacultyItem>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeFacultyItem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeFacultyItemIdSource = tmpEntity;
				else
					entity.FeeFacultyItemIdSource = DataRepository.FeeFacultyItemProvider.GetByFeeFacultyItemId(transactionManager, (entity.FeeFacultyItemId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeFacultyItemIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeFacultyItemIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeFacultyItemProvider.DeepLoad(transactionManager, entity.FeeFacultyItemIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeFacultyItemIdSource

			#region GsCodeCurrencyIdSource	
			if (CanDeepLoad(entity, "GsCodeCurrency|GsCodeCurrencyIdSource", deepLoadType, innerList) 
				&& entity.GsCodeCurrencyIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodeCurrencyId;
				GsCodeCurrency tmpEntity = EntityManager.LocateEntity<GsCodeCurrency>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeCurrency), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeCurrencyIdSource = tmpEntity;
				else
					entity.GsCodeCurrencyIdSource = DataRepository.GsCodeCurrencyProvider.GetByGsCodeCurrencyId(transactionManager, entity.GsCodeCurrencyId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeCurrencyIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeCurrencyIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeCurrencyProvider.DeepLoad(transactionManager, entity.GsCodeCurrencyIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeCurrencyIdSource

			#region SeFormIdSource	
			if (CanDeepLoad(entity, "SeForm|SeFormIdSource", deepLoadType, innerList) 
				&& entity.SeFormIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeFormId ?? 0.0m);
				SeForm tmpEntity = EntityManager.LocateEntity<SeForm>(EntityLocator.ConstructKeyFromPkItems(typeof(SeForm), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeFormIdSource = tmpEntity;
				else
					entity.SeFormIdSource = DataRepository.SeFormProvider.GetBySeFormId(transactionManager, (entity.SeFormId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeFormIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeFormIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeFormProvider.DeepLoad(transactionManager, entity.SeFormIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeFormIdSource

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
			// Deep load child collections  - Call GetByFeeStudFeeItemId methods when available
			
			#region FeeStudVoucherItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudVoucherItem>|FeeStudVoucherItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudVoucherItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudVoucherItemCollection = DataRepository.FeeStudVoucherItemProvider.GetByFeeStudFeeItemId(transactionManager, entity.FeeStudFeeItemId);

				if (deep && entity.FeeStudVoucherItemCollection.Count > 0)
				{
					deepHandles.Add("FeeStudVoucherItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudVoucherItem>) DataRepository.FeeStudVoucherItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudVoucherItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomStudReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudReq>|AccomStudReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudReqCollection = DataRepository.AccomStudReqProvider.GetByFeeStudFeeItemId(transactionManager, entity.FeeStudFeeItemId);

				if (deep && entity.AccomStudReqCollection.Count > 0)
				{
					deepHandles.Add("AccomStudReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudReq>) DataRepository.AccomStudReqProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudCoursesItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudCoursesItem>|FeeStudCoursesItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudCoursesItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudCoursesItemCollection = DataRepository.FeeStudCoursesItemProvider.GetByFeeStudFeeItemId(transactionManager, entity.FeeStudFeeItemId);

				if (deep && entity.FeeStudCoursesItemCollection.Count > 0)
				{
					deepHandles.Add("FeeStudCoursesItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudCoursesItem>) DataRepository.FeeStudCoursesItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudCoursesItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SpoStudFeeItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoStudFeeItem>|SpoStudFeeItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoStudFeeItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoStudFeeItemCollection = DataRepository.SpoStudFeeItemProvider.GetByFeeStudFeeItemId(transactionManager, entity.FeeStudFeeItemId);

				if (deep && entity.SpoStudFeeItemCollection.Count > 0)
				{
					deepHandles.Add("SpoStudFeeItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoStudFeeItem>) DataRepository.SpoStudFeeItemProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoStudFeeItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisStudExtendCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisStudExtend>|PgThesisStudExtendCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudExtendCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisStudExtendCollection = DataRepository.PgThesisStudExtendProvider.GetByFeeStudFeeItemId(transactionManager, entity.FeeStudFeeItemId);

				if (deep && entity.PgThesisStudExtendCollection.Count > 0)
				{
					deepHandles.Add("PgThesisStudExtendCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisStudExtend>) DataRepository.PgThesisStudExtendProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisStudExtendCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseGrdChngCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseGrdChng>|EdStudCourseGrdChngCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseGrdChngCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseGrdChngCollection = DataRepository.EdStudCourseGrdChngProvider.GetByFeeStudFeeItemId(transactionManager, entity.FeeStudFeeItemId);

				if (deep && entity.EdStudCourseGrdChngCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseGrdChngCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseGrdChng>) DataRepository.EdStudCourseGrdChngProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseGrdChngCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeInvoiceItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeInvoiceItem>|FeeInvoiceItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeInvoiceItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeInvoiceItemCollection = DataRepository.FeeInvoiceItemProvider.GetByFeeStudFeeItemId(transactionManager, entity.FeeStudFeeItemId);

				if (deep && entity.FeeInvoiceItemCollection.Count > 0)
				{
					deepHandles.Add("FeeInvoiceItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeInvoiceItem>) DataRepository.FeeInvoiceItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeInvoiceItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudDiscFeeItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudDiscFeeItem>|FeeStudDiscFeeItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudDiscFeeItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudDiscFeeItemCollection = DataRepository.FeeStudDiscFeeItemProvider.GetByFeeStudFeeItemId(transactionManager, entity.FeeStudFeeItemId);

				if (deep && entity.FeeStudDiscFeeItemCollection.Count > 0)
				{
					deepHandles.Add("FeeStudDiscFeeItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudDiscFeeItem>) DataRepository.FeeStudDiscFeeItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudDiscFeeItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdPrintReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdPrintReq>|EdPrintReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdPrintReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdPrintReqCollection = DataRepository.EdPrintReqProvider.GetByFeeStudFeeItemId(transactionManager, entity.FeeStudFeeItemId);

				if (deep && entity.EdPrintReqCollection.Count > 0)
				{
					deepHandles.Add("EdPrintReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdPrintReq>) DataRepository.EdPrintReqProvider.DeepLoad,
						new object[] { transactionManager, entity.EdPrintReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeItemTrnsBlncCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeItemTrnsBlnc>|FeeItemTrnsBlncCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeItemTrnsBlncCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeItemTrnsBlncCollection = DataRepository.FeeItemTrnsBlncProvider.GetByFeeStudFeeItemId(transactionManager, entity.FeeStudFeeItemId);

				if (deep && entity.FeeItemTrnsBlncCollection.Count > 0)
				{
					deepHandles.Add("FeeItemTrnsBlncCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeItemTrnsBlnc>) DataRepository.FeeItemTrnsBlncProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeItemTrnsBlncCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeRefndStdDetCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeRefndStdDet>|FeeRefndStdDetCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeRefndStdDetCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeRefndStdDetCollection = DataRepository.FeeRefndStdDetProvider.GetByFeeStudFeeItemId(transactionManager, entity.FeeStudFeeItemId);

				if (deep && entity.FeeRefndStdDetCollection.Count > 0)
				{
					deepHandles.Add("FeeRefndStdDetCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeRefndStdDet>) DataRepository.FeeRefndStdDetProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeRefndStdDetCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeStudFeeItem object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeStudFeeItem instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeStudFeeItem Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudFeeItem entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region FeeCodeItemIdSource
			if (CanDeepSave(entity, "FeeCodeItem|FeeCodeItemIdSource", deepSaveType, innerList) 
				&& entity.FeeCodeItemIdSource != null)
			{
				DataRepository.FeeCodeItemProvider.Save(transactionManager, entity.FeeCodeItemIdSource);
				entity.FeeCodeItemId = entity.FeeCodeItemIdSource.FeeCodeItemId;
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
			
			#region EdCodeSemActvityIdSource
			if (CanDeepSave(entity, "EdCodeSemActvity|EdCodeSemActvityIdSource", deepSaveType, innerList) 
				&& entity.EdCodeSemActvityIdSource != null)
			{
				DataRepository.EdCodeSemActvityProvider.Save(transactionManager, entity.EdCodeSemActvityIdSource);
				entity.EdCodeSemActvityId = entity.EdCodeSemActvityIdSource.EdCodeSemActvityId;
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
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
			}
			#endregion 
			
			#region FeeCodeTypeIdSource
			if (CanDeepSave(entity, "FeeCodeType|FeeCodeTypeIdSource", deepSaveType, innerList) 
				&& entity.FeeCodeTypeIdSource != null)
			{
				DataRepository.FeeCodeTypeProvider.Save(transactionManager, entity.FeeCodeTypeIdSource);
				entity.FeeCodeTypeId = entity.FeeCodeTypeIdSource.FeeCodeTypeId;
			}
			#endregion 
			
			#region FeeFacultyItemIdSource
			if (CanDeepSave(entity, "FeeFacultyItem|FeeFacultyItemIdSource", deepSaveType, innerList) 
				&& entity.FeeFacultyItemIdSource != null)
			{
				DataRepository.FeeFacultyItemProvider.Save(transactionManager, entity.FeeFacultyItemIdSource);
				entity.FeeFacultyItemId = entity.FeeFacultyItemIdSource.FeeFacultyItemId;
			}
			#endregion 
			
			#region GsCodeCurrencyIdSource
			if (CanDeepSave(entity, "GsCodeCurrency|GsCodeCurrencyIdSource", deepSaveType, innerList) 
				&& entity.GsCodeCurrencyIdSource != null)
			{
				DataRepository.GsCodeCurrencyProvider.Save(transactionManager, entity.GsCodeCurrencyIdSource);
				entity.GsCodeCurrencyId = entity.GsCodeCurrencyIdSource.GsCodeCurrencyId;
			}
			#endregion 
			
			#region SeFormIdSource
			if (CanDeepSave(entity, "SeForm|SeFormIdSource", deepSaveType, innerList) 
				&& entity.SeFormIdSource != null)
			{
				DataRepository.SeFormProvider.Save(transactionManager, entity.SeFormIdSource);
				entity.SeFormId = entity.SeFormIdSource.SeFormId;
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
	
			#region List<FeeStudVoucherItem>
				if (CanDeepSave(entity.FeeStudVoucherItemCollection, "List<FeeStudVoucherItem>|FeeStudVoucherItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudVoucherItem child in entity.FeeStudVoucherItemCollection)
					{
						if(child.FeeStudFeeItemIdSource != null)
						{
							child.FeeStudFeeItemId = child.FeeStudFeeItemIdSource.FeeStudFeeItemId;
						}
						else
						{
							child.FeeStudFeeItemId = entity.FeeStudFeeItemId;
						}

					}

					if (entity.FeeStudVoucherItemCollection.Count > 0 || entity.FeeStudVoucherItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudVoucherItemProvider.Save(transactionManager, entity.FeeStudVoucherItemCollection);
						
						deepHandles.Add("FeeStudVoucherItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudVoucherItem >) DataRepository.FeeStudVoucherItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudVoucherItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomStudReq>
				if (CanDeepSave(entity.AccomStudReqCollection, "List<AccomStudReq>|AccomStudReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudReq child in entity.AccomStudReqCollection)
					{
						if(child.FeeStudFeeItemIdSource != null)
						{
							child.FeeStudFeeItemId = child.FeeStudFeeItemIdSource.FeeStudFeeItemId;
						}
						else
						{
							child.FeeStudFeeItemId = entity.FeeStudFeeItemId;
						}

					}

					if (entity.AccomStudReqCollection.Count > 0 || entity.AccomStudReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudReqProvider.Save(transactionManager, entity.AccomStudReqCollection);
						
						deepHandles.Add("AccomStudReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudReq >) DataRepository.AccomStudReqProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudCoursesItem>
				if (CanDeepSave(entity.FeeStudCoursesItemCollection, "List<FeeStudCoursesItem>|FeeStudCoursesItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudCoursesItem child in entity.FeeStudCoursesItemCollection)
					{
						if(child.FeeStudFeeItemIdSource != null)
						{
							child.FeeStudFeeItemId = child.FeeStudFeeItemIdSource.FeeStudFeeItemId;
						}
						else
						{
							child.FeeStudFeeItemId = entity.FeeStudFeeItemId;
						}

					}

					if (entity.FeeStudCoursesItemCollection.Count > 0 || entity.FeeStudCoursesItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudCoursesItemProvider.Save(transactionManager, entity.FeeStudCoursesItemCollection);
						
						deepHandles.Add("FeeStudCoursesItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudCoursesItem >) DataRepository.FeeStudCoursesItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudCoursesItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SpoStudFeeItem>
				if (CanDeepSave(entity.SpoStudFeeItemCollection, "List<SpoStudFeeItem>|SpoStudFeeItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoStudFeeItem child in entity.SpoStudFeeItemCollection)
					{
						if(child.FeeStudFeeItemIdSource != null)
						{
							child.FeeStudFeeItemId = child.FeeStudFeeItemIdSource.FeeStudFeeItemId;
						}
						else
						{
							child.FeeStudFeeItemId = entity.FeeStudFeeItemId;
						}

					}

					if (entity.SpoStudFeeItemCollection.Count > 0 || entity.SpoStudFeeItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SpoStudFeeItemProvider.Save(transactionManager, entity.SpoStudFeeItemCollection);
						
						deepHandles.Add("SpoStudFeeItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoStudFeeItem >) DataRepository.SpoStudFeeItemProvider.DeepSave,
							new object[] { transactionManager, entity.SpoStudFeeItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisStudExtend>
				if (CanDeepSave(entity.PgThesisStudExtendCollection, "List<PgThesisStudExtend>|PgThesisStudExtendCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisStudExtend child in entity.PgThesisStudExtendCollection)
					{
						if(child.FeeStudFeeItemIdSource != null)
						{
							child.FeeStudFeeItemId = child.FeeStudFeeItemIdSource.FeeStudFeeItemId;
						}
						else
						{
							child.FeeStudFeeItemId = entity.FeeStudFeeItemId;
						}

					}

					if (entity.PgThesisStudExtendCollection.Count > 0 || entity.PgThesisStudExtendCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisStudExtendProvider.Save(transactionManager, entity.PgThesisStudExtendCollection);
						
						deepHandles.Add("PgThesisStudExtendCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisStudExtend >) DataRepository.PgThesisStudExtendProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisStudExtendCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseGrdChng>
				if (CanDeepSave(entity.EdStudCourseGrdChngCollection, "List<EdStudCourseGrdChng>|EdStudCourseGrdChngCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseGrdChng child in entity.EdStudCourseGrdChngCollection)
					{
						if(child.FeeStudFeeItemIdSource != null)
						{
							child.FeeStudFeeItemId = child.FeeStudFeeItemIdSource.FeeStudFeeItemId;
						}
						else
						{
							child.FeeStudFeeItemId = entity.FeeStudFeeItemId;
						}

					}

					if (entity.EdStudCourseGrdChngCollection.Count > 0 || entity.EdStudCourseGrdChngCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseGrdChngProvider.Save(transactionManager, entity.EdStudCourseGrdChngCollection);
						
						deepHandles.Add("EdStudCourseGrdChngCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseGrdChng >) DataRepository.EdStudCourseGrdChngProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseGrdChngCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeInvoiceItem>
				if (CanDeepSave(entity.FeeInvoiceItemCollection, "List<FeeInvoiceItem>|FeeInvoiceItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeInvoiceItem child in entity.FeeInvoiceItemCollection)
					{
						if(child.FeeStudFeeItemIdSource != null)
						{
							child.FeeStudFeeItemId = child.FeeStudFeeItemIdSource.FeeStudFeeItemId;
						}
						else
						{
							child.FeeStudFeeItemId = entity.FeeStudFeeItemId;
						}

					}

					if (entity.FeeInvoiceItemCollection.Count > 0 || entity.FeeInvoiceItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeInvoiceItemProvider.Save(transactionManager, entity.FeeInvoiceItemCollection);
						
						deepHandles.Add("FeeInvoiceItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeInvoiceItem >) DataRepository.FeeInvoiceItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeInvoiceItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudDiscFeeItem>
				if (CanDeepSave(entity.FeeStudDiscFeeItemCollection, "List<FeeStudDiscFeeItem>|FeeStudDiscFeeItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudDiscFeeItem child in entity.FeeStudDiscFeeItemCollection)
					{
						if(child.FeeStudFeeItemIdSource != null)
						{
							child.FeeStudFeeItemId = child.FeeStudFeeItemIdSource.FeeStudFeeItemId;
						}
						else
						{
							child.FeeStudFeeItemId = entity.FeeStudFeeItemId;
						}

					}

					if (entity.FeeStudDiscFeeItemCollection.Count > 0 || entity.FeeStudDiscFeeItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudDiscFeeItemProvider.Save(transactionManager, entity.FeeStudDiscFeeItemCollection);
						
						deepHandles.Add("FeeStudDiscFeeItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudDiscFeeItem >) DataRepository.FeeStudDiscFeeItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudDiscFeeItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdPrintReq>
				if (CanDeepSave(entity.EdPrintReqCollection, "List<EdPrintReq>|EdPrintReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdPrintReq child in entity.EdPrintReqCollection)
					{
						if(child.FeeStudFeeItemIdSource != null)
						{
							child.FeeStudFeeItemId = child.FeeStudFeeItemIdSource.FeeStudFeeItemId;
						}
						else
						{
							child.FeeStudFeeItemId = entity.FeeStudFeeItemId;
						}

					}

					if (entity.EdPrintReqCollection.Count > 0 || entity.EdPrintReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdPrintReqProvider.Save(transactionManager, entity.EdPrintReqCollection);
						
						deepHandles.Add("EdPrintReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdPrintReq >) DataRepository.EdPrintReqProvider.DeepSave,
							new object[] { transactionManager, entity.EdPrintReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeItemTrnsBlnc>
				if (CanDeepSave(entity.FeeItemTrnsBlncCollection, "List<FeeItemTrnsBlnc>|FeeItemTrnsBlncCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeItemTrnsBlnc child in entity.FeeItemTrnsBlncCollection)
					{
						if(child.FeeStudFeeItemIdSource != null)
						{
							child.FeeStudFeeItemId = child.FeeStudFeeItemIdSource.FeeStudFeeItemId;
						}
						else
						{
							child.FeeStudFeeItemId = entity.FeeStudFeeItemId;
						}

					}

					if (entity.FeeItemTrnsBlncCollection.Count > 0 || entity.FeeItemTrnsBlncCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeItemTrnsBlncProvider.Save(transactionManager, entity.FeeItemTrnsBlncCollection);
						
						deepHandles.Add("FeeItemTrnsBlncCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeItemTrnsBlnc >) DataRepository.FeeItemTrnsBlncProvider.DeepSave,
							new object[] { transactionManager, entity.FeeItemTrnsBlncCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeRefndStdDet>
				if (CanDeepSave(entity.FeeRefndStdDetCollection, "List<FeeRefndStdDet>|FeeRefndStdDetCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeRefndStdDet child in entity.FeeRefndStdDetCollection)
					{
						if(child.FeeStudFeeItemIdSource != null)
						{
							child.FeeStudFeeItemId = child.FeeStudFeeItemIdSource.FeeStudFeeItemId;
						}
						else
						{
							child.FeeStudFeeItemId = entity.FeeStudFeeItemId;
						}

					}

					if (entity.FeeRefndStdDetCollection.Count > 0 || entity.FeeRefndStdDetCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeRefndStdDetProvider.Save(transactionManager, entity.FeeRefndStdDetCollection);
						
						deepHandles.Add("FeeRefndStdDetCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeRefndStdDet >) DataRepository.FeeRefndStdDetProvider.DeepSave,
							new object[] { transactionManager, entity.FeeRefndStdDetCollection, deepSaveType, childTypes, innerList }
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
	
	#region FeeStudFeeItemChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeStudFeeItem</c>
	///</summary>
	public enum FeeStudFeeItemChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>FeeCodeItem</c> at FeeCodeItemIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCodeItem))]
		FeeCodeItem,
		
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
		/// Composite Property for <c>EdCodeSemActvity</c> at EdCodeSemActvityIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemActvity))]
		EdCodeSemActvity,
		
		///<summary>
		/// Composite Property for <c>EdCodeSemester</c> at EdCodeSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemester))]
		EdCodeSemester,
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>FeeCodeType</c> at FeeCodeTypeIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCodeType))]
		FeeCodeType,
		
		///<summary>
		/// Composite Property for <c>FeeFacultyItem</c> at FeeFacultyItemIdSource
		///</summary>
		[ChildEntityType(typeof(FeeFacultyItem))]
		FeeFacultyItem,
		
		///<summary>
		/// Composite Property for <c>GsCodeCurrency</c> at GsCodeCurrencyIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeCurrency))]
		GsCodeCurrency,
		
		///<summary>
		/// Composite Property for <c>SeForm</c> at SeFormIdSource
		///</summary>
		[ChildEntityType(typeof(SeForm))]
		SeForm,
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at SeUserIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
		///<summary>
		/// Collection of <c>FeeStudFeeItem</c> as OneToMany for FeeStudVoucherItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudVoucherItem>))]
		FeeStudVoucherItemCollection,
		///<summary>
		/// Collection of <c>FeeStudFeeItem</c> as OneToMany for AccomStudReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudReq>))]
		AccomStudReqCollection,
		///<summary>
		/// Collection of <c>FeeStudFeeItem</c> as OneToMany for FeeStudCoursesItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudCoursesItem>))]
		FeeStudCoursesItemCollection,
		///<summary>
		/// Collection of <c>FeeStudFeeItem</c> as OneToMany for SpoStudFeeItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoStudFeeItem>))]
		SpoStudFeeItemCollection,
		///<summary>
		/// Collection of <c>FeeStudFeeItem</c> as OneToMany for PgThesisStudExtendCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisStudExtend>))]
		PgThesisStudExtendCollection,
		///<summary>
		/// Collection of <c>FeeStudFeeItem</c> as OneToMany for EdStudCourseGrdChngCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseGrdChng>))]
		EdStudCourseGrdChngCollection,
		///<summary>
		/// Collection of <c>FeeStudFeeItem</c> as OneToMany for FeeInvoiceItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeInvoiceItem>))]
		FeeInvoiceItemCollection,
		///<summary>
		/// Collection of <c>FeeStudFeeItem</c> as OneToMany for FeeStudDiscFeeItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudDiscFeeItem>))]
		FeeStudDiscFeeItemCollection,
		///<summary>
		/// Collection of <c>FeeStudFeeItem</c> as OneToMany for EdPrintReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdPrintReq>))]
		EdPrintReqCollection,
		///<summary>
		/// Collection of <c>FeeStudFeeItem</c> as OneToMany for FeeItemTrnsBlncCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeItemTrnsBlnc>))]
		FeeItemTrnsBlncCollection,
		///<summary>
		/// Collection of <c>FeeStudFeeItem</c> as OneToMany for FeeRefndStdDetCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeRefndStdDet>))]
		FeeRefndStdDetCollection,
	}
	
	#endregion FeeStudFeeItemChildEntityTypes
	
	#region FeeStudFeeItemFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeStudFeeItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudFeeItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeStudFeeItemFilterBuilder : SqlFilterBuilder<FeeStudFeeItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudFeeItemFilterBuilder class.
		/// </summary>
		public FeeStudFeeItemFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeStudFeeItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeStudFeeItemFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeStudFeeItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeStudFeeItemFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeStudFeeItemFilterBuilder
	
	#region FeeStudFeeItemParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeStudFeeItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudFeeItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeStudFeeItemParameterBuilder : ParameterizedSqlFilterBuilder<FeeStudFeeItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudFeeItemParameterBuilder class.
		/// </summary>
		public FeeStudFeeItemParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeStudFeeItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeStudFeeItemParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeStudFeeItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeStudFeeItemParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeStudFeeItemParameterBuilder
	
	#region FeeStudFeeItemSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeStudFeeItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudFeeItem"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeStudFeeItemSortBuilder : SqlSortBuilder<FeeStudFeeItemColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudFeeItemSqlSortBuilder class.
		/// </summary>
		public FeeStudFeeItemSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeStudFeeItemSortBuilder
	
} // end namespace
