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
	/// This class is the base class for any <see cref="RsrchStudRegisterDtlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class RsrchStudRegisterDtlProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl, UMIS_VER2.BusinessLyer.RsrchStudRegisterDtlKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.RsrchStudRegisterDtlKey key)
		{
			return Delete(transactionManager, key.RsrchStudRegisterDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_rsrchStudRegisterDtlId">عنواين البحث العلمى. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _rsrchStudRegisterDtlId)
		{
			return Delete(null, _rsrchStudRegisterDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchStudRegisterDtlId">عنواين البحث العلمى. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _rsrchStudRegisterDtlId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_REGISTER_DTL_RSRCH_CDE_STATUS key.
		///		FK_RSRCH_STUD_REGISTER_DTL_RSRCH_CDE_STATUS Description: 
		/// </summary>
		/// <param name="_rsrchCdeStatusId">حالة عنوان البحث العلمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl objects.</returns>
		public TList<RsrchStudRegisterDtl> GetByRsrchCdeStatusId(System.Int32 _rsrchCdeStatusId)
		{
			int count = -1;
			return GetByRsrchCdeStatusId(_rsrchCdeStatusId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_REGISTER_DTL_RSRCH_CDE_STATUS key.
		///		FK_RSRCH_STUD_REGISTER_DTL_RSRCH_CDE_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchCdeStatusId">حالة عنوان البحث العلمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl objects.</returns>
		/// <remarks></remarks>
		public TList<RsrchStudRegisterDtl> GetByRsrchCdeStatusId(TransactionManager transactionManager, System.Int32 _rsrchCdeStatusId)
		{
			int count = -1;
			return GetByRsrchCdeStatusId(transactionManager, _rsrchCdeStatusId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_REGISTER_DTL_RSRCH_CDE_STATUS key.
		///		FK_RSRCH_STUD_REGISTER_DTL_RSRCH_CDE_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchCdeStatusId">حالة عنوان البحث العلمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl objects.</returns>
		public TList<RsrchStudRegisterDtl> GetByRsrchCdeStatusId(TransactionManager transactionManager, System.Int32 _rsrchCdeStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByRsrchCdeStatusId(transactionManager, _rsrchCdeStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_REGISTER_DTL_RSRCH_CDE_STATUS key.
		///		fkRsrchStudRegisterDtlRsrchCdeStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_rsrchCdeStatusId">حالة عنوان البحث العلمى</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl objects.</returns>
		public TList<RsrchStudRegisterDtl> GetByRsrchCdeStatusId(System.Int32 _rsrchCdeStatusId, int start, int pageLength)
		{
			int count =  -1;
			return GetByRsrchCdeStatusId(null, _rsrchCdeStatusId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_REGISTER_DTL_RSRCH_CDE_STATUS key.
		///		fkRsrchStudRegisterDtlRsrchCdeStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_rsrchCdeStatusId">حالة عنوان البحث العلمى</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl objects.</returns>
		public TList<RsrchStudRegisterDtl> GetByRsrchCdeStatusId(System.Int32 _rsrchCdeStatusId, int start, int pageLength,out int count)
		{
			return GetByRsrchCdeStatusId(null, _rsrchCdeStatusId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_REGISTER_DTL_RSRCH_CDE_STATUS key.
		///		FK_RSRCH_STUD_REGISTER_DTL_RSRCH_CDE_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchCdeStatusId">حالة عنوان البحث العلمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl objects.</returns>
		public abstract TList<RsrchStudRegisterDtl> GetByRsrchCdeStatusId(TransactionManager transactionManager, System.Int32 _rsrchCdeStatusId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_REGISTER_DTL_RSRCH_STUD_REGISTER key.
		///		FK_RSRCH_STUD_REGISTER_DTL_RSRCH_STUD_REGISTER Description: 
		/// </summary>
		/// <param name="_rsrchStudRegisterId">اختيار العنوان المقترح للبحث العلمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl objects.</returns>
		public TList<RsrchStudRegisterDtl> GetByRsrchStudRegisterId(System.Decimal _rsrchStudRegisterId)
		{
			int count = -1;
			return GetByRsrchStudRegisterId(_rsrchStudRegisterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_REGISTER_DTL_RSRCH_STUD_REGISTER key.
		///		FK_RSRCH_STUD_REGISTER_DTL_RSRCH_STUD_REGISTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchStudRegisterId">اختيار العنوان المقترح للبحث العلمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl objects.</returns>
		/// <remarks></remarks>
		public TList<RsrchStudRegisterDtl> GetByRsrchStudRegisterId(TransactionManager transactionManager, System.Decimal _rsrchStudRegisterId)
		{
			int count = -1;
			return GetByRsrchStudRegisterId(transactionManager, _rsrchStudRegisterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_REGISTER_DTL_RSRCH_STUD_REGISTER key.
		///		FK_RSRCH_STUD_REGISTER_DTL_RSRCH_STUD_REGISTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchStudRegisterId">اختيار العنوان المقترح للبحث العلمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl objects.</returns>
		public TList<RsrchStudRegisterDtl> GetByRsrchStudRegisterId(TransactionManager transactionManager, System.Decimal _rsrchStudRegisterId, int start, int pageLength)
		{
			int count = -1;
			return GetByRsrchStudRegisterId(transactionManager, _rsrchStudRegisterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_REGISTER_DTL_RSRCH_STUD_REGISTER key.
		///		fkRsrchStudRegisterDtlRsrchStudRegister Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_rsrchStudRegisterId">اختيار العنوان المقترح للبحث العلمى</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl objects.</returns>
		public TList<RsrchStudRegisterDtl> GetByRsrchStudRegisterId(System.Decimal _rsrchStudRegisterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByRsrchStudRegisterId(null, _rsrchStudRegisterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_REGISTER_DTL_RSRCH_STUD_REGISTER key.
		///		fkRsrchStudRegisterDtlRsrchStudRegister Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_rsrchStudRegisterId">اختيار العنوان المقترح للبحث العلمى</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl objects.</returns>
		public TList<RsrchStudRegisterDtl> GetByRsrchStudRegisterId(System.Decimal _rsrchStudRegisterId, int start, int pageLength,out int count)
		{
			return GetByRsrchStudRegisterId(null, _rsrchStudRegisterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_REGISTER_DTL_RSRCH_STUD_REGISTER key.
		///		FK_RSRCH_STUD_REGISTER_DTL_RSRCH_STUD_REGISTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchStudRegisterId">اختيار العنوان المقترح للبحث العلمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl objects.</returns>
		public abstract TList<RsrchStudRegisterDtl> GetByRsrchStudRegisterId(TransactionManager transactionManager, System.Decimal _rsrchStudRegisterId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.RsrchStudRegisterDtlKey key, int start, int pageLength)
		{
			return GetByRsrchStudRegisterDtlId(transactionManager, key.RsrchStudRegisterDtlId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_RSRCH_STUD_REGISTER_DTL index.
		/// </summary>
		/// <param name="_rsrchStudRegisterDtlId">عنواين البحث العلمى</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl GetByRsrchStudRegisterDtlId(System.Decimal _rsrchStudRegisterDtlId)
		{
			int count = -1;
			return GetByRsrchStudRegisterDtlId(null,_rsrchStudRegisterDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_RSRCH_STUD_REGISTER_DTL index.
		/// </summary>
		/// <param name="_rsrchStudRegisterDtlId">عنواين البحث العلمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl GetByRsrchStudRegisterDtlId(System.Decimal _rsrchStudRegisterDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByRsrchStudRegisterDtlId(null, _rsrchStudRegisterDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_RSRCH_STUD_REGISTER_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchStudRegisterDtlId">عنواين البحث العلمى</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl GetByRsrchStudRegisterDtlId(TransactionManager transactionManager, System.Decimal _rsrchStudRegisterDtlId)
		{
			int count = -1;
			return GetByRsrchStudRegisterDtlId(transactionManager, _rsrchStudRegisterDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_RSRCH_STUD_REGISTER_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchStudRegisterDtlId">عنواين البحث العلمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl GetByRsrchStudRegisterDtlId(TransactionManager transactionManager, System.Decimal _rsrchStudRegisterDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByRsrchStudRegisterDtlId(transactionManager, _rsrchStudRegisterDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_RSRCH_STUD_REGISTER_DTL index.
		/// </summary>
		/// <param name="_rsrchStudRegisterDtlId">عنواين البحث العلمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl GetByRsrchStudRegisterDtlId(System.Decimal _rsrchStudRegisterDtlId, int start, int pageLength, out int count)
		{
			return GetByRsrchStudRegisterDtlId(null, _rsrchStudRegisterDtlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_RSRCH_STUD_REGISTER_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchStudRegisterDtlId">عنواين البحث العلمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl GetByRsrchStudRegisterDtlId(TransactionManager transactionManager, System.Decimal _rsrchStudRegisterDtlId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_RSRCH_STUD_REGISTER_DTL index.
		/// </summary>
		/// <param name="_rsrchStudRegisterId">اختيار العنوان المقترح للبحث العلمى</param>
		/// <param name="_titleAr">عنوان البحث العلمى</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;RsrchStudRegisterDtl&gt;"/> class.</returns>
		public TList<RsrchStudRegisterDtl> GetByRsrchStudRegisterIdTitleAr(System.Decimal _rsrchStudRegisterId, System.String _titleAr)
		{
			int count = -1;
			return GetByRsrchStudRegisterIdTitleAr(null,_rsrchStudRegisterId, _titleAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_RSRCH_STUD_REGISTER_DTL index.
		/// </summary>
		/// <param name="_rsrchStudRegisterId">اختيار العنوان المقترح للبحث العلمى</param>
		/// <param name="_titleAr">عنوان البحث العلمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;RsrchStudRegisterDtl&gt;"/> class.</returns>
		public TList<RsrchStudRegisterDtl> GetByRsrchStudRegisterIdTitleAr(System.Decimal _rsrchStudRegisterId, System.String _titleAr, int start, int pageLength)
		{
			int count = -1;
			return GetByRsrchStudRegisterIdTitleAr(null, _rsrchStudRegisterId, _titleAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_RSRCH_STUD_REGISTER_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchStudRegisterId">اختيار العنوان المقترح للبحث العلمى</param>
		/// <param name="_titleAr">عنوان البحث العلمى</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;RsrchStudRegisterDtl&gt;"/> class.</returns>
		public TList<RsrchStudRegisterDtl> GetByRsrchStudRegisterIdTitleAr(TransactionManager transactionManager, System.Decimal _rsrchStudRegisterId, System.String _titleAr)
		{
			int count = -1;
			return GetByRsrchStudRegisterIdTitleAr(transactionManager, _rsrchStudRegisterId, _titleAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_RSRCH_STUD_REGISTER_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchStudRegisterId">اختيار العنوان المقترح للبحث العلمى</param>
		/// <param name="_titleAr">عنوان البحث العلمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;RsrchStudRegisterDtl&gt;"/> class.</returns>
		public TList<RsrchStudRegisterDtl> GetByRsrchStudRegisterIdTitleAr(TransactionManager transactionManager, System.Decimal _rsrchStudRegisterId, System.String _titleAr, int start, int pageLength)
		{
			int count = -1;
			return GetByRsrchStudRegisterIdTitleAr(transactionManager, _rsrchStudRegisterId, _titleAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_RSRCH_STUD_REGISTER_DTL index.
		/// </summary>
		/// <param name="_rsrchStudRegisterId">اختيار العنوان المقترح للبحث العلمى</param>
		/// <param name="_titleAr">عنوان البحث العلمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;RsrchStudRegisterDtl&gt;"/> class.</returns>
		public TList<RsrchStudRegisterDtl> GetByRsrchStudRegisterIdTitleAr(System.Decimal _rsrchStudRegisterId, System.String _titleAr, int start, int pageLength, out int count)
		{
			return GetByRsrchStudRegisterIdTitleAr(null, _rsrchStudRegisterId, _titleAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_RSRCH_STUD_REGISTER_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchStudRegisterId">اختيار العنوان المقترح للبحث العلمى</param>
		/// <param name="_titleAr">عنوان البحث العلمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;RsrchStudRegisterDtl&gt;"/> class.</returns>
		public abstract TList<RsrchStudRegisterDtl> GetByRsrchStudRegisterIdTitleAr(TransactionManager transactionManager, System.Decimal _rsrchStudRegisterId, System.String _titleAr, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;RsrchStudRegisterDtl&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;RsrchStudRegisterDtl&gt;"/></returns>
		public static TList<RsrchStudRegisterDtl> Fill(IDataReader reader, TList<RsrchStudRegisterDtl> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("RsrchStudRegisterDtl")
					.Append("|").Append((System.Decimal)reader["RSRCH_STUD_REGISTER_DTL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<RsrchStudRegisterDtl>(
					key.ToString(), // EntityTrackingKey
					"RsrchStudRegisterDtl",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl();
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
					c.RsrchStudRegisterDtlId = (System.Decimal)reader["RSRCH_STUD_REGISTER_DTL_ID"];
					c.OriginalRsrchStudRegisterDtlId = c.RsrchStudRegisterDtlId;
					c.RsrchStudRegisterId = (System.Decimal)reader["RSRCH_STUD_REGISTER_ID"];
					c.TitleAr = (System.String)reader["TITLE_AR"];
					c.RsrchTypeFlg = Convert.IsDBNull(reader["RSRCH_TYPE_FLG"]) ? null : (System.Int16?)reader["RSRCH_TYPE_FLG"];
					c.RsrchCdeStatusId = (System.Int32)reader["RSRCH_CDE_STATUS_ID"];
					c.RsrchValue = Convert.IsDBNull(reader["RSRCH_VALUE"]) ? null : (System.String)reader["RSRCH_VALUE"];
					c.RsrchReason = Convert.IsDBNull(reader["RSRCH_REASON"]) ? null : (System.String)reader["RSRCH_REASON"];
					c.RsrchReference = Convert.IsDBNull(reader["RSRCH_REFERENCE"]) ? null : (System.String)reader["RSRCH_REFERENCE"];
					c.RsrchSummary = Convert.IsDBNull(reader["RSRCH_SUMMARY"]) ? null : (System.String)reader["RSRCH_SUMMARY"];
					c.AuditStatusFlg = Convert.IsDBNull(reader["AUDIT_STATUS_FLG"]) ? null : (System.Int16?)reader["AUDIT_STATUS_FLG"];
					c.AuditNote = Convert.IsDBNull(reader["AUDIT_NOTE"]) ? null : (System.String)reader["AUDIT_NOTE"];
					c.RsrchOrdr = Convert.IsDBNull(reader["RSRCH_ORDR"]) ? null : (System.Int32?)reader["RSRCH_ORDR"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl entity)
		{
			if (!reader.Read()) return;
			
			entity.RsrchStudRegisterDtlId = (System.Decimal)reader[((int)RsrchStudRegisterDtlColumn.RsrchStudRegisterDtlId - 1)];
			entity.OriginalRsrchStudRegisterDtlId = (System.Decimal)reader["RSRCH_STUD_REGISTER_DTL_ID"];
			entity.RsrchStudRegisterId = (System.Decimal)reader[((int)RsrchStudRegisterDtlColumn.RsrchStudRegisterId - 1)];
			entity.TitleAr = (System.String)reader[((int)RsrchStudRegisterDtlColumn.TitleAr - 1)];
			entity.RsrchTypeFlg = (reader.IsDBNull(((int)RsrchStudRegisterDtlColumn.RsrchTypeFlg - 1)))?null:(System.Int16?)reader[((int)RsrchStudRegisterDtlColumn.RsrchTypeFlg - 1)];
			entity.RsrchCdeStatusId = (System.Int32)reader[((int)RsrchStudRegisterDtlColumn.RsrchCdeStatusId - 1)];
			entity.RsrchValue = (reader.IsDBNull(((int)RsrchStudRegisterDtlColumn.RsrchValue - 1)))?null:(System.String)reader[((int)RsrchStudRegisterDtlColumn.RsrchValue - 1)];
			entity.RsrchReason = (reader.IsDBNull(((int)RsrchStudRegisterDtlColumn.RsrchReason - 1)))?null:(System.String)reader[((int)RsrchStudRegisterDtlColumn.RsrchReason - 1)];
			entity.RsrchReference = (reader.IsDBNull(((int)RsrchStudRegisterDtlColumn.RsrchReference - 1)))?null:(System.String)reader[((int)RsrchStudRegisterDtlColumn.RsrchReference - 1)];
			entity.RsrchSummary = (reader.IsDBNull(((int)RsrchStudRegisterDtlColumn.RsrchSummary - 1)))?null:(System.String)reader[((int)RsrchStudRegisterDtlColumn.RsrchSummary - 1)];
			entity.AuditStatusFlg = (reader.IsDBNull(((int)RsrchStudRegisterDtlColumn.AuditStatusFlg - 1)))?null:(System.Int16?)reader[((int)RsrchStudRegisterDtlColumn.AuditStatusFlg - 1)];
			entity.AuditNote = (reader.IsDBNull(((int)RsrchStudRegisterDtlColumn.AuditNote - 1)))?null:(System.String)reader[((int)RsrchStudRegisterDtlColumn.AuditNote - 1)];
			entity.RsrchOrdr = (reader.IsDBNull(((int)RsrchStudRegisterDtlColumn.RsrchOrdr - 1)))?null:(System.Int32?)reader[((int)RsrchStudRegisterDtlColumn.RsrchOrdr - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)RsrchStudRegisterDtlColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)RsrchStudRegisterDtlColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)RsrchStudRegisterDtlColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)RsrchStudRegisterDtlColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.RsrchStudRegisterDtlId = (System.Decimal)dataRow["RSRCH_STUD_REGISTER_DTL_ID"];
			entity.OriginalRsrchStudRegisterDtlId = (System.Decimal)dataRow["RSRCH_STUD_REGISTER_DTL_ID"];
			entity.RsrchStudRegisterId = (System.Decimal)dataRow["RSRCH_STUD_REGISTER_ID"];
			entity.TitleAr = (System.String)dataRow["TITLE_AR"];
			entity.RsrchTypeFlg = Convert.IsDBNull(dataRow["RSRCH_TYPE_FLG"]) ? null : (System.Int16?)dataRow["RSRCH_TYPE_FLG"];
			entity.RsrchCdeStatusId = (System.Int32)dataRow["RSRCH_CDE_STATUS_ID"];
			entity.RsrchValue = Convert.IsDBNull(dataRow["RSRCH_VALUE"]) ? null : (System.String)dataRow["RSRCH_VALUE"];
			entity.RsrchReason = Convert.IsDBNull(dataRow["RSRCH_REASON"]) ? null : (System.String)dataRow["RSRCH_REASON"];
			entity.RsrchReference = Convert.IsDBNull(dataRow["RSRCH_REFERENCE"]) ? null : (System.String)dataRow["RSRCH_REFERENCE"];
			entity.RsrchSummary = Convert.IsDBNull(dataRow["RSRCH_SUMMARY"]) ? null : (System.String)dataRow["RSRCH_SUMMARY"];
			entity.AuditStatusFlg = Convert.IsDBNull(dataRow["AUDIT_STATUS_FLG"]) ? null : (System.Int16?)dataRow["AUDIT_STATUS_FLG"];
			entity.AuditNote = Convert.IsDBNull(dataRow["AUDIT_NOTE"]) ? null : (System.String)dataRow["AUDIT_NOTE"];
			entity.RsrchOrdr = Convert.IsDBNull(dataRow["RSRCH_ORDR"]) ? null : (System.Int32?)dataRow["RSRCH_ORDR"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region RsrchCdeStatusIdSource	
			if (CanDeepLoad(entity, "RsrchCdeStatus|RsrchCdeStatusIdSource", deepLoadType, innerList) 
				&& entity.RsrchCdeStatusIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.RsrchCdeStatusId;
				RsrchCdeStatus tmpEntity = EntityManager.LocateEntity<RsrchCdeStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(RsrchCdeStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.RsrchCdeStatusIdSource = tmpEntity;
				else
					entity.RsrchCdeStatusIdSource = DataRepository.RsrchCdeStatusProvider.GetByRsrchCdeStatusId(transactionManager, entity.RsrchCdeStatusId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'RsrchCdeStatusIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.RsrchCdeStatusIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.RsrchCdeStatusProvider.DeepLoad(transactionManager, entity.RsrchCdeStatusIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion RsrchCdeStatusIdSource

			#region RsrchStudRegisterIdSource	
			if (CanDeepLoad(entity, "RsrchStudRegister|RsrchStudRegisterIdSource", deepLoadType, innerList) 
				&& entity.RsrchStudRegisterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.RsrchStudRegisterId;
				RsrchStudRegister tmpEntity = EntityManager.LocateEntity<RsrchStudRegister>(EntityLocator.ConstructKeyFromPkItems(typeof(RsrchStudRegister), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.RsrchStudRegisterIdSource = tmpEntity;
				else
					entity.RsrchStudRegisterIdSource = DataRepository.RsrchStudRegisterProvider.GetByRsrchStudRegisterId(transactionManager, entity.RsrchStudRegisterId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'RsrchStudRegisterIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.RsrchStudRegisterIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.RsrchStudRegisterProvider.DeepLoad(transactionManager, entity.RsrchStudRegisterIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion RsrchStudRegisterIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByRsrchStudRegisterDtlId methods when available
			
			#region RsrchCommStaffRecomCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<RsrchCommStaffRecom>|RsrchCommStaffRecomCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'RsrchCommStaffRecomCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.RsrchCommStaffRecomCollection = DataRepository.RsrchCommStaffRecomProvider.GetByRsrchStudRegisterDtlId(transactionManager, entity.RsrchStudRegisterDtlId);

				if (deep && entity.RsrchCommStaffRecomCollection.Count > 0)
				{
					deepHandles.Add("RsrchCommStaffRecomCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<RsrchCommStaffRecom>) DataRepository.RsrchCommStaffRecomProvider.DeepLoad,
						new object[] { transactionManager, entity.RsrchCommStaffRecomCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisStud>|PgThesisStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisStudCollection = DataRepository.PgThesisStudProvider.GetByRsrchStudRegisterDtlId(transactionManager, entity.RsrchStudRegisterDtlId);

				if (deep && entity.PgThesisStudCollection.Count > 0)
				{
					deepHandles.Add("PgThesisStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisStud>) DataRepository.PgThesisStudProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisStudCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region RsrchCdeStatusIdSource
			if (CanDeepSave(entity, "RsrchCdeStatus|RsrchCdeStatusIdSource", deepSaveType, innerList) 
				&& entity.RsrchCdeStatusIdSource != null)
			{
				DataRepository.RsrchCdeStatusProvider.Save(transactionManager, entity.RsrchCdeStatusIdSource);
				entity.RsrchCdeStatusId = entity.RsrchCdeStatusIdSource.RsrchCdeStatusId;
			}
			#endregion 
			
			#region RsrchStudRegisterIdSource
			if (CanDeepSave(entity, "RsrchStudRegister|RsrchStudRegisterIdSource", deepSaveType, innerList) 
				&& entity.RsrchStudRegisterIdSource != null)
			{
				DataRepository.RsrchStudRegisterProvider.Save(transactionManager, entity.RsrchStudRegisterIdSource);
				entity.RsrchStudRegisterId = entity.RsrchStudRegisterIdSource.RsrchStudRegisterId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<RsrchCommStaffRecom>
				if (CanDeepSave(entity.RsrchCommStaffRecomCollection, "List<RsrchCommStaffRecom>|RsrchCommStaffRecomCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(RsrchCommStaffRecom child in entity.RsrchCommStaffRecomCollection)
					{
						if(child.RsrchStudRegisterDtlIdSource != null)
						{
							child.RsrchStudRegisterDtlId = child.RsrchStudRegisterDtlIdSource.RsrchStudRegisterDtlId;
						}
						else
						{
							child.RsrchStudRegisterDtlId = entity.RsrchStudRegisterDtlId;
						}

					}

					if (entity.RsrchCommStaffRecomCollection.Count > 0 || entity.RsrchCommStaffRecomCollection.DeletedItems.Count > 0)
					{
						//DataRepository.RsrchCommStaffRecomProvider.Save(transactionManager, entity.RsrchCommStaffRecomCollection);
						
						deepHandles.Add("RsrchCommStaffRecomCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< RsrchCommStaffRecom >) DataRepository.RsrchCommStaffRecomProvider.DeepSave,
							new object[] { transactionManager, entity.RsrchCommStaffRecomCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisStud>
				if (CanDeepSave(entity.PgThesisStudCollection, "List<PgThesisStud>|PgThesisStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisStud child in entity.PgThesisStudCollection)
					{
						if(child.RsrchStudRegisterDtlIdSource != null)
						{
							child.RsrchStudRegisterDtlId = child.RsrchStudRegisterDtlIdSource.RsrchStudRegisterDtlId;
						}
						else
						{
							child.RsrchStudRegisterDtlId = entity.RsrchStudRegisterDtlId;
						}

					}

					if (entity.PgThesisStudCollection.Count > 0 || entity.PgThesisStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisStudProvider.Save(transactionManager, entity.PgThesisStudCollection);
						
						deepHandles.Add("PgThesisStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisStud >) DataRepository.PgThesisStudProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisStudCollection, deepSaveType, childTypes, innerList }
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
	
	#region RsrchStudRegisterDtlChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.RsrchStudRegisterDtl</c>
	///</summary>
	public enum RsrchStudRegisterDtlChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>RsrchCdeStatus</c> at RsrchCdeStatusIdSource
		///</summary>
		[ChildEntityType(typeof(RsrchCdeStatus))]
		RsrchCdeStatus,
		
		///<summary>
		/// Composite Property for <c>RsrchStudRegister</c> at RsrchStudRegisterIdSource
		///</summary>
		[ChildEntityType(typeof(RsrchStudRegister))]
		RsrchStudRegister,
		///<summary>
		/// Collection of <c>RsrchStudRegisterDtl</c> as OneToMany for RsrchCommStaffRecomCollection
		///</summary>
		[ChildEntityType(typeof(TList<RsrchCommStaffRecom>))]
		RsrchCommStaffRecomCollection,
		///<summary>
		/// Collection of <c>RsrchStudRegisterDtl</c> as OneToMany for PgThesisStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisStud>))]
		PgThesisStudCollection,
	}
	
	#endregion RsrchStudRegisterDtlChildEntityTypes
	
	#region RsrchStudRegisterDtlFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;RsrchStudRegisterDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="RsrchStudRegisterDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class RsrchStudRegisterDtlFilterBuilder : SqlFilterBuilder<RsrchStudRegisterDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the RsrchStudRegisterDtlFilterBuilder class.
		/// </summary>
		public RsrchStudRegisterDtlFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the RsrchStudRegisterDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public RsrchStudRegisterDtlFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the RsrchStudRegisterDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public RsrchStudRegisterDtlFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion RsrchStudRegisterDtlFilterBuilder
	
	#region RsrchStudRegisterDtlParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;RsrchStudRegisterDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="RsrchStudRegisterDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class RsrchStudRegisterDtlParameterBuilder : ParameterizedSqlFilterBuilder<RsrchStudRegisterDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the RsrchStudRegisterDtlParameterBuilder class.
		/// </summary>
		public RsrchStudRegisterDtlParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the RsrchStudRegisterDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public RsrchStudRegisterDtlParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the RsrchStudRegisterDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public RsrchStudRegisterDtlParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion RsrchStudRegisterDtlParameterBuilder
	
	#region RsrchStudRegisterDtlSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;RsrchStudRegisterDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="RsrchStudRegisterDtl"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class RsrchStudRegisterDtlSortBuilder : SqlSortBuilder<RsrchStudRegisterDtlColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the RsrchStudRegisterDtlSqlSortBuilder class.
		/// </summary>
		public RsrchStudRegisterDtlSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion RsrchStudRegisterDtlSortBuilder
	
} // end namespace
