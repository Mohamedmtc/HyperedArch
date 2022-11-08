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
	/// This class is the base class for any <see cref="RsrchCommStaffRecomProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class RsrchCommStaffRecomProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.RsrchCommStaffRecom, UMIS_VER2.BusinessLyer.RsrchCommStaffRecomKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.RsrchCommStaffRecomKey key)
		{
			return Delete(transactionManager, key.RsrchCommStaffRecomId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_rsrchCommStaffRecomId">تعليق الاعضاء على عناوين الابحاث المقترحة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _rsrchCommStaffRecomId)
		{
			return Delete(null, _rsrchCommStaffRecomId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchCommStaffRecomId">تعليق الاعضاء على عناوين الابحاث المقترحة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _rsrchCommStaffRecomId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_COMM_STAFF_RECOM_GS_COMM_STAFF key.
		///		FK_RSRCH_COMM_STAFF_RECOM_GS_COMM_STAFF Description: 
		/// </summary>
		/// <param name="_gsCommStaffId">أعضاء اللجنة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchCommStaffRecom objects.</returns>
		public TList<RsrchCommStaffRecom> GetByGsCommStaffId(System.Decimal _gsCommStaffId)
		{
			int count = -1;
			return GetByGsCommStaffId(_gsCommStaffId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_COMM_STAFF_RECOM_GS_COMM_STAFF key.
		///		FK_RSRCH_COMM_STAFF_RECOM_GS_COMM_STAFF Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommStaffId">أعضاء اللجنة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchCommStaffRecom objects.</returns>
		/// <remarks></remarks>
		public TList<RsrchCommStaffRecom> GetByGsCommStaffId(TransactionManager transactionManager, System.Decimal _gsCommStaffId)
		{
			int count = -1;
			return GetByGsCommStaffId(transactionManager, _gsCommStaffId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_COMM_STAFF_RECOM_GS_COMM_STAFF key.
		///		FK_RSRCH_COMM_STAFF_RECOM_GS_COMM_STAFF Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommStaffId">أعضاء اللجنة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchCommStaffRecom objects.</returns>
		public TList<RsrchCommStaffRecom> GetByGsCommStaffId(TransactionManager transactionManager, System.Decimal _gsCommStaffId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCommStaffId(transactionManager, _gsCommStaffId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_COMM_STAFF_RECOM_GS_COMM_STAFF key.
		///		fkRsrchCommStaffRecomGsCommStaff Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCommStaffId">أعضاء اللجنة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchCommStaffRecom objects.</returns>
		public TList<RsrchCommStaffRecom> GetByGsCommStaffId(System.Decimal _gsCommStaffId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCommStaffId(null, _gsCommStaffId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_COMM_STAFF_RECOM_GS_COMM_STAFF key.
		///		fkRsrchCommStaffRecomGsCommStaff Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCommStaffId">أعضاء اللجنة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchCommStaffRecom objects.</returns>
		public TList<RsrchCommStaffRecom> GetByGsCommStaffId(System.Decimal _gsCommStaffId, int start, int pageLength,out int count)
		{
			return GetByGsCommStaffId(null, _gsCommStaffId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_COMM_STAFF_RECOM_GS_COMM_STAFF key.
		///		FK_RSRCH_COMM_STAFF_RECOM_GS_COMM_STAFF Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommStaffId">أعضاء اللجنة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchCommStaffRecom objects.</returns>
		public abstract TList<RsrchCommStaffRecom> GetByGsCommStaffId(TransactionManager transactionManager, System.Decimal _gsCommStaffId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_COMM_STAFF_RECOM_RSRCH_STUD_REGISTER_DTL key.
		///		FK_RSRCH_COMM_STAFF_RECOM_RSRCH_STUD_REGISTER_DTL Description: 
		/// </summary>
		/// <param name="_rsrchStudRegisterDtlId">عنواين البحث العلمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchCommStaffRecom objects.</returns>
		public TList<RsrchCommStaffRecom> GetByRsrchStudRegisterDtlId(System.Decimal _rsrchStudRegisterDtlId)
		{
			int count = -1;
			return GetByRsrchStudRegisterDtlId(_rsrchStudRegisterDtlId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_COMM_STAFF_RECOM_RSRCH_STUD_REGISTER_DTL key.
		///		FK_RSRCH_COMM_STAFF_RECOM_RSRCH_STUD_REGISTER_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchStudRegisterDtlId">عنواين البحث العلمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchCommStaffRecom objects.</returns>
		/// <remarks></remarks>
		public TList<RsrchCommStaffRecom> GetByRsrchStudRegisterDtlId(TransactionManager transactionManager, System.Decimal _rsrchStudRegisterDtlId)
		{
			int count = -1;
			return GetByRsrchStudRegisterDtlId(transactionManager, _rsrchStudRegisterDtlId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_COMM_STAFF_RECOM_RSRCH_STUD_REGISTER_DTL key.
		///		FK_RSRCH_COMM_STAFF_RECOM_RSRCH_STUD_REGISTER_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchStudRegisterDtlId">عنواين البحث العلمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchCommStaffRecom objects.</returns>
		public TList<RsrchCommStaffRecom> GetByRsrchStudRegisterDtlId(TransactionManager transactionManager, System.Decimal _rsrchStudRegisterDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByRsrchStudRegisterDtlId(transactionManager, _rsrchStudRegisterDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_COMM_STAFF_RECOM_RSRCH_STUD_REGISTER_DTL key.
		///		fkRsrchCommStaffRecomRsrchStudRegisterDtl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_rsrchStudRegisterDtlId">عنواين البحث العلمى</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchCommStaffRecom objects.</returns>
		public TList<RsrchCommStaffRecom> GetByRsrchStudRegisterDtlId(System.Decimal _rsrchStudRegisterDtlId, int start, int pageLength)
		{
			int count =  -1;
			return GetByRsrchStudRegisterDtlId(null, _rsrchStudRegisterDtlId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_COMM_STAFF_RECOM_RSRCH_STUD_REGISTER_DTL key.
		///		fkRsrchCommStaffRecomRsrchStudRegisterDtl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_rsrchStudRegisterDtlId">عنواين البحث العلمى</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchCommStaffRecom objects.</returns>
		public TList<RsrchCommStaffRecom> GetByRsrchStudRegisterDtlId(System.Decimal _rsrchStudRegisterDtlId, int start, int pageLength,out int count)
		{
			return GetByRsrchStudRegisterDtlId(null, _rsrchStudRegisterDtlId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_COMM_STAFF_RECOM_RSRCH_STUD_REGISTER_DTL key.
		///		FK_RSRCH_COMM_STAFF_RECOM_RSRCH_STUD_REGISTER_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchStudRegisterDtlId">عنواين البحث العلمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchCommStaffRecom objects.</returns>
		public abstract TList<RsrchCommStaffRecom> GetByRsrchStudRegisterDtlId(TransactionManager transactionManager, System.Decimal _rsrchStudRegisterDtlId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.RsrchCommStaffRecom Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.RsrchCommStaffRecomKey key, int start, int pageLength)
		{
			return GetByRsrchCommStaffRecomId(transactionManager, key.RsrchCommStaffRecomId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_RSRCH_COMM_STAFF_RECOM index.
		/// </summary>
		/// <param name="_rsrchCommStaffRecomId">تعليق الاعضاء على عناوين الابحاث المقترحة</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.RsrchCommStaffRecom"/> class.</returns>
		public UMIS_VER2.BusinessLyer.RsrchCommStaffRecom GetByRsrchCommStaffRecomId(System.Decimal _rsrchCommStaffRecomId)
		{
			int count = -1;
			return GetByRsrchCommStaffRecomId(null,_rsrchCommStaffRecomId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_RSRCH_COMM_STAFF_RECOM index.
		/// </summary>
		/// <param name="_rsrchCommStaffRecomId">تعليق الاعضاء على عناوين الابحاث المقترحة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.RsrchCommStaffRecom"/> class.</returns>
		public UMIS_VER2.BusinessLyer.RsrchCommStaffRecom GetByRsrchCommStaffRecomId(System.Decimal _rsrchCommStaffRecomId, int start, int pageLength)
		{
			int count = -1;
			return GetByRsrchCommStaffRecomId(null, _rsrchCommStaffRecomId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_RSRCH_COMM_STAFF_RECOM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchCommStaffRecomId">تعليق الاعضاء على عناوين الابحاث المقترحة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.RsrchCommStaffRecom"/> class.</returns>
		public UMIS_VER2.BusinessLyer.RsrchCommStaffRecom GetByRsrchCommStaffRecomId(TransactionManager transactionManager, System.Decimal _rsrchCommStaffRecomId)
		{
			int count = -1;
			return GetByRsrchCommStaffRecomId(transactionManager, _rsrchCommStaffRecomId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_RSRCH_COMM_STAFF_RECOM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchCommStaffRecomId">تعليق الاعضاء على عناوين الابحاث المقترحة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.RsrchCommStaffRecom"/> class.</returns>
		public UMIS_VER2.BusinessLyer.RsrchCommStaffRecom GetByRsrchCommStaffRecomId(TransactionManager transactionManager, System.Decimal _rsrchCommStaffRecomId, int start, int pageLength)
		{
			int count = -1;
			return GetByRsrchCommStaffRecomId(transactionManager, _rsrchCommStaffRecomId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_RSRCH_COMM_STAFF_RECOM index.
		/// </summary>
		/// <param name="_rsrchCommStaffRecomId">تعليق الاعضاء على عناوين الابحاث المقترحة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.RsrchCommStaffRecom"/> class.</returns>
		public UMIS_VER2.BusinessLyer.RsrchCommStaffRecom GetByRsrchCommStaffRecomId(System.Decimal _rsrchCommStaffRecomId, int start, int pageLength, out int count)
		{
			return GetByRsrchCommStaffRecomId(null, _rsrchCommStaffRecomId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_RSRCH_COMM_STAFF_RECOM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchCommStaffRecomId">تعليق الاعضاء على عناوين الابحاث المقترحة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.RsrchCommStaffRecom"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.RsrchCommStaffRecom GetByRsrchCommStaffRecomId(TransactionManager transactionManager, System.Decimal _rsrchCommStaffRecomId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_RSRCH_COMM_STAFF_RECOM index.
		/// </summary>
		/// <param name="_rsrchStudRegisterDtlId">عنواين البحث العلمى</param>
		/// <param name="_gsCommStaffId">أعضاء اللجنة</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;RsrchCommStaffRecom&gt;"/> class.</returns>
		public TList<RsrchCommStaffRecom> GetByRsrchStudRegisterDtlIdGsCommStaffId(System.Decimal _rsrchStudRegisterDtlId, System.Decimal _gsCommStaffId)
		{
			int count = -1;
			return GetByRsrchStudRegisterDtlIdGsCommStaffId(null,_rsrchStudRegisterDtlId, _gsCommStaffId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_RSRCH_COMM_STAFF_RECOM index.
		/// </summary>
		/// <param name="_rsrchStudRegisterDtlId">عنواين البحث العلمى</param>
		/// <param name="_gsCommStaffId">أعضاء اللجنة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;RsrchCommStaffRecom&gt;"/> class.</returns>
		public TList<RsrchCommStaffRecom> GetByRsrchStudRegisterDtlIdGsCommStaffId(System.Decimal _rsrchStudRegisterDtlId, System.Decimal _gsCommStaffId, int start, int pageLength)
		{
			int count = -1;
			return GetByRsrchStudRegisterDtlIdGsCommStaffId(null, _rsrchStudRegisterDtlId, _gsCommStaffId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_RSRCH_COMM_STAFF_RECOM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchStudRegisterDtlId">عنواين البحث العلمى</param>
		/// <param name="_gsCommStaffId">أعضاء اللجنة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;RsrchCommStaffRecom&gt;"/> class.</returns>
		public TList<RsrchCommStaffRecom> GetByRsrchStudRegisterDtlIdGsCommStaffId(TransactionManager transactionManager, System.Decimal _rsrchStudRegisterDtlId, System.Decimal _gsCommStaffId)
		{
			int count = -1;
			return GetByRsrchStudRegisterDtlIdGsCommStaffId(transactionManager, _rsrchStudRegisterDtlId, _gsCommStaffId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_RSRCH_COMM_STAFF_RECOM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchStudRegisterDtlId">عنواين البحث العلمى</param>
		/// <param name="_gsCommStaffId">أعضاء اللجنة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;RsrchCommStaffRecom&gt;"/> class.</returns>
		public TList<RsrchCommStaffRecom> GetByRsrchStudRegisterDtlIdGsCommStaffId(TransactionManager transactionManager, System.Decimal _rsrchStudRegisterDtlId, System.Decimal _gsCommStaffId, int start, int pageLength)
		{
			int count = -1;
			return GetByRsrchStudRegisterDtlIdGsCommStaffId(transactionManager, _rsrchStudRegisterDtlId, _gsCommStaffId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_RSRCH_COMM_STAFF_RECOM index.
		/// </summary>
		/// <param name="_rsrchStudRegisterDtlId">عنواين البحث العلمى</param>
		/// <param name="_gsCommStaffId">أعضاء اللجنة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;RsrchCommStaffRecom&gt;"/> class.</returns>
		public TList<RsrchCommStaffRecom> GetByRsrchStudRegisterDtlIdGsCommStaffId(System.Decimal _rsrchStudRegisterDtlId, System.Decimal _gsCommStaffId, int start, int pageLength, out int count)
		{
			return GetByRsrchStudRegisterDtlIdGsCommStaffId(null, _rsrchStudRegisterDtlId, _gsCommStaffId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_RSRCH_COMM_STAFF_RECOM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchStudRegisterDtlId">عنواين البحث العلمى</param>
		/// <param name="_gsCommStaffId">أعضاء اللجنة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;RsrchCommStaffRecom&gt;"/> class.</returns>
		public abstract TList<RsrchCommStaffRecom> GetByRsrchStudRegisterDtlIdGsCommStaffId(TransactionManager transactionManager, System.Decimal _rsrchStudRegisterDtlId, System.Decimal _gsCommStaffId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;RsrchCommStaffRecom&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;RsrchCommStaffRecom&gt;"/></returns>
		public static TList<RsrchCommStaffRecom> Fill(IDataReader reader, TList<RsrchCommStaffRecom> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.RsrchCommStaffRecom c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("RsrchCommStaffRecom")
					.Append("|").Append((System.Decimal)reader["RSRCH_COMM_STAFF_RECOM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<RsrchCommStaffRecom>(
					key.ToString(), // EntityTrackingKey
					"RsrchCommStaffRecom",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.RsrchCommStaffRecom();
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
					c.RsrchCommStaffRecomId = (System.Decimal)reader["RSRCH_COMM_STAFF_RECOM_ID"];
					c.OriginalRsrchCommStaffRecomId = c.RsrchCommStaffRecomId;
					c.GsCommStaffId = (System.Decimal)reader["GS_COMM_STAFF_ID"];
					c.RsrchStudRegisterDtlId = (System.Decimal)reader["RSRCH_STUD_REGISTER_DTL_ID"];
					c.RecomDtl = Convert.IsDBNull(reader["RECOM_DTL"]) ? null : (System.String)reader["RECOM_DTL"];
					c.RecomNote = Convert.IsDBNull(reader["RECOM_NOTE"]) ? null : (System.String)reader["RECOM_NOTE"];
					c.RecomDate = Convert.IsDBNull(reader["RECOM_DATE"]) ? null : (System.String)reader["RECOM_DATE"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.RsrchCommStaffRecom"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.RsrchCommStaffRecom"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.RsrchCommStaffRecom entity)
		{
			if (!reader.Read()) return;
			
			entity.RsrchCommStaffRecomId = (System.Decimal)reader[((int)RsrchCommStaffRecomColumn.RsrchCommStaffRecomId - 1)];
			entity.OriginalRsrchCommStaffRecomId = (System.Decimal)reader["RSRCH_COMM_STAFF_RECOM_ID"];
			entity.GsCommStaffId = (System.Decimal)reader[((int)RsrchCommStaffRecomColumn.GsCommStaffId - 1)];
			entity.RsrchStudRegisterDtlId = (System.Decimal)reader[((int)RsrchCommStaffRecomColumn.RsrchStudRegisterDtlId - 1)];
			entity.RecomDtl = (reader.IsDBNull(((int)RsrchCommStaffRecomColumn.RecomDtl - 1)))?null:(System.String)reader[((int)RsrchCommStaffRecomColumn.RecomDtl - 1)];
			entity.RecomNote = (reader.IsDBNull(((int)RsrchCommStaffRecomColumn.RecomNote - 1)))?null:(System.String)reader[((int)RsrchCommStaffRecomColumn.RecomNote - 1)];
			entity.RecomDate = (reader.IsDBNull(((int)RsrchCommStaffRecomColumn.RecomDate - 1)))?null:(System.String)reader[((int)RsrchCommStaffRecomColumn.RecomDate - 1)];
			entity.LastDate = (reader.IsDBNull(((int)RsrchCommStaffRecomColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)RsrchCommStaffRecomColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)RsrchCommStaffRecomColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)RsrchCommStaffRecomColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.RsrchCommStaffRecom"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.RsrchCommStaffRecom"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.RsrchCommStaffRecom entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.RsrchCommStaffRecomId = (System.Decimal)dataRow["RSRCH_COMM_STAFF_RECOM_ID"];
			entity.OriginalRsrchCommStaffRecomId = (System.Decimal)dataRow["RSRCH_COMM_STAFF_RECOM_ID"];
			entity.GsCommStaffId = (System.Decimal)dataRow["GS_COMM_STAFF_ID"];
			entity.RsrchStudRegisterDtlId = (System.Decimal)dataRow["RSRCH_STUD_REGISTER_DTL_ID"];
			entity.RecomDtl = Convert.IsDBNull(dataRow["RECOM_DTL"]) ? null : (System.String)dataRow["RECOM_DTL"];
			entity.RecomNote = Convert.IsDBNull(dataRow["RECOM_NOTE"]) ? null : (System.String)dataRow["RECOM_NOTE"];
			entity.RecomDate = Convert.IsDBNull(dataRow["RECOM_DATE"]) ? null : (System.String)dataRow["RECOM_DATE"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.RsrchCommStaffRecom"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.RsrchCommStaffRecom Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.RsrchCommStaffRecom entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region GsCommStaffIdSource	
			if (CanDeepLoad(entity, "GsCommStaff|GsCommStaffIdSource", deepLoadType, innerList) 
				&& entity.GsCommStaffIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCommStaffId;
				GsCommStaff tmpEntity = EntityManager.LocateEntity<GsCommStaff>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCommStaff), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCommStaffIdSource = tmpEntity;
				else
					entity.GsCommStaffIdSource = DataRepository.GsCommStaffProvider.GetByGsCommStaffId(transactionManager, entity.GsCommStaffId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCommStaffIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCommStaffIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCommStaffProvider.DeepLoad(transactionManager, entity.GsCommStaffIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCommStaffIdSource

			#region RsrchStudRegisterDtlIdSource	
			if (CanDeepLoad(entity, "RsrchStudRegisterDtl|RsrchStudRegisterDtlIdSource", deepLoadType, innerList) 
				&& entity.RsrchStudRegisterDtlIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.RsrchStudRegisterDtlId;
				RsrchStudRegisterDtl tmpEntity = EntityManager.LocateEntity<RsrchStudRegisterDtl>(EntityLocator.ConstructKeyFromPkItems(typeof(RsrchStudRegisterDtl), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.RsrchStudRegisterDtlIdSource = tmpEntity;
				else
					entity.RsrchStudRegisterDtlIdSource = DataRepository.RsrchStudRegisterDtlProvider.GetByRsrchStudRegisterDtlId(transactionManager, entity.RsrchStudRegisterDtlId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'RsrchStudRegisterDtlIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.RsrchStudRegisterDtlIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.RsrchStudRegisterDtlProvider.DeepLoad(transactionManager, entity.RsrchStudRegisterDtlIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion RsrchStudRegisterDtlIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.RsrchCommStaffRecom object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.RsrchCommStaffRecom instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.RsrchCommStaffRecom Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.RsrchCommStaffRecom entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region GsCommStaffIdSource
			if (CanDeepSave(entity, "GsCommStaff|GsCommStaffIdSource", deepSaveType, innerList) 
				&& entity.GsCommStaffIdSource != null)
			{
				DataRepository.GsCommStaffProvider.Save(transactionManager, entity.GsCommStaffIdSource);
				entity.GsCommStaffId = entity.GsCommStaffIdSource.GsCommStaffId;
			}
			#endregion 
			
			#region RsrchStudRegisterDtlIdSource
			if (CanDeepSave(entity, "RsrchStudRegisterDtl|RsrchStudRegisterDtlIdSource", deepSaveType, innerList) 
				&& entity.RsrchStudRegisterDtlIdSource != null)
			{
				DataRepository.RsrchStudRegisterDtlProvider.Save(transactionManager, entity.RsrchStudRegisterDtlIdSource);
				entity.RsrchStudRegisterDtlId = entity.RsrchStudRegisterDtlIdSource.RsrchStudRegisterDtlId;
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
	
	#region RsrchCommStaffRecomChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.RsrchCommStaffRecom</c>
	///</summary>
	public enum RsrchCommStaffRecomChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsCommStaff</c> at GsCommStaffIdSource
		///</summary>
		[ChildEntityType(typeof(GsCommStaff))]
		GsCommStaff,
		
		///<summary>
		/// Composite Property for <c>RsrchStudRegisterDtl</c> at RsrchStudRegisterDtlIdSource
		///</summary>
		[ChildEntityType(typeof(RsrchStudRegisterDtl))]
		RsrchStudRegisterDtl,
	}
	
	#endregion RsrchCommStaffRecomChildEntityTypes
	
	#region RsrchCommStaffRecomFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;RsrchCommStaffRecomColumn&gt;"/> class
	/// that is used exclusively with a <see cref="RsrchCommStaffRecom"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class RsrchCommStaffRecomFilterBuilder : SqlFilterBuilder<RsrchCommStaffRecomColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the RsrchCommStaffRecomFilterBuilder class.
		/// </summary>
		public RsrchCommStaffRecomFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the RsrchCommStaffRecomFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public RsrchCommStaffRecomFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the RsrchCommStaffRecomFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public RsrchCommStaffRecomFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion RsrchCommStaffRecomFilterBuilder
	
	#region RsrchCommStaffRecomParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;RsrchCommStaffRecomColumn&gt;"/> class
	/// that is used exclusively with a <see cref="RsrchCommStaffRecom"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class RsrchCommStaffRecomParameterBuilder : ParameterizedSqlFilterBuilder<RsrchCommStaffRecomColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the RsrchCommStaffRecomParameterBuilder class.
		/// </summary>
		public RsrchCommStaffRecomParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the RsrchCommStaffRecomParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public RsrchCommStaffRecomParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the RsrchCommStaffRecomParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public RsrchCommStaffRecomParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion RsrchCommStaffRecomParameterBuilder
	
	#region RsrchCommStaffRecomSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;RsrchCommStaffRecomColumn&gt;"/> class
	/// that is used exclusively with a <see cref="RsrchCommStaffRecom"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class RsrchCommStaffRecomSortBuilder : SqlSortBuilder<RsrchCommStaffRecomColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the RsrchCommStaffRecomSqlSortBuilder class.
		/// </summary>
		public RsrchCommStaffRecomSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion RsrchCommStaffRecomSortBuilder
	
} // end namespace
