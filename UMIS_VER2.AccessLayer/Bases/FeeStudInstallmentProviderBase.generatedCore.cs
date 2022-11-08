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
	/// This class is the base class for any <see cref="FeeStudInstallmentProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeStudInstallmentProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeStudInstallment, UMIS_VER2.BusinessLyer.FeeStudInstallmentKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudInstallmentKey key)
		{
			return Delete(transactionManager, key.FeeStudInstallmentId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeStudInstallmentId">طلب تقسيط طالب. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeStudInstallmentId)
		{
			return Delete(null, _feeStudInstallmentId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudInstallmentId">طلب تقسيط طالب. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeStudInstallmentId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FEE_STUD_INSTALLMENT_fk key.
		///		FEE_STUD_INSTALLMENT_fk Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudInstallment objects.</returns>
		public TList<FeeStudInstallment> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FEE_STUD_INSTALLMENT_fk key.
		///		FEE_STUD_INSTALLMENT_fk Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudInstallment objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudInstallment> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FEE_STUD_INSTALLMENT_fk key.
		///		FEE_STUD_INSTALLMENT_fk Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudInstallment objects.</returns>
		public TList<FeeStudInstallment> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FEE_STUD_INSTALLMENT_fk key.
		///		feeStudInstallmentFk Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudInstallment objects.</returns>
		public TList<FeeStudInstallment> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FEE_STUD_INSTALLMENT_fk key.
		///		feeStudInstallmentFk Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudInstallment objects.</returns>
		public TList<FeeStudInstallment> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FEE_STUD_INSTALLMENT_fk key.
		///		FEE_STUD_INSTALLMENT_fk Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudInstallment objects.</returns>
		public abstract TList<FeeStudInstallment> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FEE_STUD_INSTALLMENT_fk2 key.
		///		FEE_STUD_INSTALLMENT_fk2 Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudInstallment objects.</returns>
		public TList<FeeStudInstallment> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FEE_STUD_INSTALLMENT_fk2 key.
		///		FEE_STUD_INSTALLMENT_fk2 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudInstallment objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudInstallment> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FEE_STUD_INSTALLMENT_fk2 key.
		///		FEE_STUD_INSTALLMENT_fk2 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudInstallment objects.</returns>
		public TList<FeeStudInstallment> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FEE_STUD_INSTALLMENT_fk2 key.
		///		feeStudInstallmentFk2 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudInstallment objects.</returns>
		public TList<FeeStudInstallment> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FEE_STUD_INSTALLMENT_fk2 key.
		///		feeStudInstallmentFk2 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudInstallment objects.</returns>
		public TList<FeeStudInstallment> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FEE_STUD_INSTALLMENT_fk2 key.
		///		FEE_STUD_INSTALLMENT_fk2 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudInstallment objects.</returns>
		public abstract TList<FeeStudInstallment> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FEE_STUD_INSTALLMENT_fk4 key.
		///		FEE_STUD_INSTALLMENT_fk4 Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudInstallment objects.</returns>
		public TList<FeeStudInstallment> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FEE_STUD_INSTALLMENT_fk4 key.
		///		FEE_STUD_INSTALLMENT_fk4 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudInstallment objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudInstallment> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FEE_STUD_INSTALLMENT_fk4 key.
		///		FEE_STUD_INSTALLMENT_fk4 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudInstallment objects.</returns>
		public TList<FeeStudInstallment> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FEE_STUD_INSTALLMENT_fk4 key.
		///		feeStudInstallmentFk4 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudInstallment objects.</returns>
		public TList<FeeStudInstallment> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FEE_STUD_INSTALLMENT_fk4 key.
		///		feeStudInstallmentFk4 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudInstallment objects.</returns>
		public TList<FeeStudInstallment> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FEE_STUD_INSTALLMENT_fk4 key.
		///		FEE_STUD_INSTALLMENT_fk4 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudInstallment objects.</returns>
		public abstract TList<FeeStudInstallment> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FEE_STUD_INSTALLMENT_fk5 key.
		///		FEE_STUD_INSTALLMENT_fk5 Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudInstallment objects.</returns>
		public TList<FeeStudInstallment> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FEE_STUD_INSTALLMENT_fk5 key.
		///		FEE_STUD_INSTALLMENT_fk5 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudInstallment objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudInstallment> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FEE_STUD_INSTALLMENT_fk5 key.
		///		FEE_STUD_INSTALLMENT_fk5 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudInstallment objects.</returns>
		public TList<FeeStudInstallment> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FEE_STUD_INSTALLMENT_fk5 key.
		///		feeStudInstallmentFk5 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudInstallment objects.</returns>
		public TList<FeeStudInstallment> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FEE_STUD_INSTALLMENT_fk5 key.
		///		feeStudInstallmentFk5 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudInstallment objects.</returns>
		public TList<FeeStudInstallment> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FEE_STUD_INSTALLMENT_fk5 key.
		///		FEE_STUD_INSTALLMENT_fk5 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudInstallment objects.</returns>
		public abstract TList<FeeStudInstallment> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_INSTALLMENT_FEE_STUD_INSTALLMENT_REQUEST key.
		///		FK_FEE_STUD_INSTALLMENT_FEE_STUD_INSTALLMENT_REQUEST Description: 
		/// </summary>
		/// <param name="_feeStudInstallmentRequestId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudInstallment objects.</returns>
		public TList<FeeStudInstallment> GetByFeeStudInstallmentRequestId(System.Decimal? _feeStudInstallmentRequestId)
		{
			int count = -1;
			return GetByFeeStudInstallmentRequestId(_feeStudInstallmentRequestId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_INSTALLMENT_FEE_STUD_INSTALLMENT_REQUEST key.
		///		FK_FEE_STUD_INSTALLMENT_FEE_STUD_INSTALLMENT_REQUEST Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudInstallmentRequestId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudInstallment objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudInstallment> GetByFeeStudInstallmentRequestId(TransactionManager transactionManager, System.Decimal? _feeStudInstallmentRequestId)
		{
			int count = -1;
			return GetByFeeStudInstallmentRequestId(transactionManager, _feeStudInstallmentRequestId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_INSTALLMENT_FEE_STUD_INSTALLMENT_REQUEST key.
		///		FK_FEE_STUD_INSTALLMENT_FEE_STUD_INSTALLMENT_REQUEST Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudInstallmentRequestId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudInstallment objects.</returns>
		public TList<FeeStudInstallment> GetByFeeStudInstallmentRequestId(TransactionManager transactionManager, System.Decimal? _feeStudInstallmentRequestId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudInstallmentRequestId(transactionManager, _feeStudInstallmentRequestId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_INSTALLMENT_FEE_STUD_INSTALLMENT_REQUEST key.
		///		fkFeeStudInstallmentFeeStudInstallmentRequest Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudInstallmentRequestId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudInstallment objects.</returns>
		public TList<FeeStudInstallment> GetByFeeStudInstallmentRequestId(System.Decimal? _feeStudInstallmentRequestId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeStudInstallmentRequestId(null, _feeStudInstallmentRequestId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_INSTALLMENT_FEE_STUD_INSTALLMENT_REQUEST key.
		///		fkFeeStudInstallmentFeeStudInstallmentRequest Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudInstallmentRequestId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudInstallment objects.</returns>
		public TList<FeeStudInstallment> GetByFeeStudInstallmentRequestId(System.Decimal? _feeStudInstallmentRequestId, int start, int pageLength,out int count)
		{
			return GetByFeeStudInstallmentRequestId(null, _feeStudInstallmentRequestId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_INSTALLMENT_FEE_STUD_INSTALLMENT_REQUEST key.
		///		FK_FEE_STUD_INSTALLMENT_FEE_STUD_INSTALLMENT_REQUEST Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudInstallmentRequestId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudInstallment objects.</returns>
		public abstract TList<FeeStudInstallment> GetByFeeStudInstallmentRequestId(TransactionManager transactionManager, System.Decimal? _feeStudInstallmentRequestId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_INSTALLMENT_GS_CODE_CURRENCY key.
		///		FK_FEE_STUD_INSTALLMENT_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudInstallment objects.</returns>
		public TList<FeeStudInstallment> GetByGsCodeCurrencyId(System.Decimal? _gsCodeCurrencyId)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(_gsCodeCurrencyId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_INSTALLMENT_GS_CODE_CURRENCY key.
		///		FK_FEE_STUD_INSTALLMENT_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudInstallment objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudInstallment> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal? _gsCodeCurrencyId)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(transactionManager, _gsCodeCurrencyId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_INSTALLMENT_GS_CODE_CURRENCY key.
		///		FK_FEE_STUD_INSTALLMENT_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudInstallment objects.</returns>
		public TList<FeeStudInstallment> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal? _gsCodeCurrencyId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(transactionManager, _gsCodeCurrencyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_INSTALLMENT_GS_CODE_CURRENCY key.
		///		fkFeeStudInstallmentGsCodeCurrency Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudInstallment objects.</returns>
		public TList<FeeStudInstallment> GetByGsCodeCurrencyId(System.Decimal? _gsCodeCurrencyId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeCurrencyId(null, _gsCodeCurrencyId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_INSTALLMENT_GS_CODE_CURRENCY key.
		///		fkFeeStudInstallmentGsCodeCurrency Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudInstallment objects.</returns>
		public TList<FeeStudInstallment> GetByGsCodeCurrencyId(System.Decimal? _gsCodeCurrencyId, int start, int pageLength,out int count)
		{
			return GetByGsCodeCurrencyId(null, _gsCodeCurrencyId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_INSTALLMENT_GS_CODE_CURRENCY key.
		///		FK_FEE_STUD_INSTALLMENT_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudInstallment objects.</returns>
		public abstract TList<FeeStudInstallment> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal? _gsCodeCurrencyId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeStudInstallment Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudInstallmentKey key, int start, int pageLength)
		{
			return GetByFeeStudInstallmentId(transactionManager, key.FeeStudInstallmentId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_STUD_INSTALLMENT index.
		/// </summary>
		/// <param name="_feeStudInstallmentId">طلب تقسيط طالب</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudInstallment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudInstallment GetByFeeStudInstallmentId(System.Decimal _feeStudInstallmentId)
		{
			int count = -1;
			return GetByFeeStudInstallmentId(null,_feeStudInstallmentId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_INSTALLMENT index.
		/// </summary>
		/// <param name="_feeStudInstallmentId">طلب تقسيط طالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudInstallment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudInstallment GetByFeeStudInstallmentId(System.Decimal _feeStudInstallmentId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudInstallmentId(null, _feeStudInstallmentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_INSTALLMENT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudInstallmentId">طلب تقسيط طالب</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudInstallment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudInstallment GetByFeeStudInstallmentId(TransactionManager transactionManager, System.Decimal _feeStudInstallmentId)
		{
			int count = -1;
			return GetByFeeStudInstallmentId(transactionManager, _feeStudInstallmentId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_INSTALLMENT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudInstallmentId">طلب تقسيط طالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudInstallment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudInstallment GetByFeeStudInstallmentId(TransactionManager transactionManager, System.Decimal _feeStudInstallmentId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudInstallmentId(transactionManager, _feeStudInstallmentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_INSTALLMENT index.
		/// </summary>
		/// <param name="_feeStudInstallmentId">طلب تقسيط طالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudInstallment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudInstallment GetByFeeStudInstallmentId(System.Decimal _feeStudInstallmentId, int start, int pageLength, out int count)
		{
			return GetByFeeStudInstallmentId(null, _feeStudInstallmentId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_INSTALLMENT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudInstallmentId">طلب تقسيط طالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudInstallment"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeStudInstallment GetByFeeStudInstallmentId(TransactionManager transactionManager, System.Decimal _feeStudInstallmentId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeStudInstallment&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeStudInstallment&gt;"/></returns>
		public static TList<FeeStudInstallment> Fill(IDataReader reader, TList<FeeStudInstallment> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeStudInstallment c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeStudInstallment")
					.Append("|").Append((System.Decimal)reader["FEE_STUD_INSTALLMENT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeStudInstallment>(
					key.ToString(), // EntityTrackingKey
					"FeeStudInstallment",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeStudInstallment();
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
					c.FeeStudInstallmentId = (System.Decimal)reader["FEE_STUD_INSTALLMENT_ID"];
					c.OriginalFeeStudInstallmentId = c.FeeStudInstallmentId;
					c.FeeStudInstallmentRequestId = Convert.IsDBNull(reader["FEE_STUD_INSTALLMENT_REQUEST_ID"]) ? null : (System.Decimal?)reader["FEE_STUD_INSTALLMENT_REQUEST_ID"];
					c.InstallmentOrder = (System.Decimal)reader["INSTALLMENT_ORDER"];
					c.InstallmentDate = (System.DateTime)reader["INSTALLMENT_DATE"];
					c.InstallmentPercentage = (System.Decimal)reader["INSTALLMENT_PERCENTAGE"];
					c.InstallmentAmount = Convert.IsDBNull(reader["INSTALLMENT_AMOUNT"]) ? null : (System.Decimal?)reader["INSTALLMENT_AMOUNT"];
					c.PaidFlg = (System.Decimal)reader["PAID_FLG"];
					c.AllInOne = (System.Decimal)reader["ALL_IN_ONE"];
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.GsCodeCurrencyId = Convert.IsDBNull(reader["GS_CODE_CURRENCY_ID"]) ? null : (System.Decimal?)reader["GS_CODE_CURRENCY_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeStudInstallment"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudInstallment"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeStudInstallment entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeStudInstallmentId = (System.Decimal)reader[((int)FeeStudInstallmentColumn.FeeStudInstallmentId - 1)];
			entity.OriginalFeeStudInstallmentId = (System.Decimal)reader["FEE_STUD_INSTALLMENT_ID"];
			entity.FeeStudInstallmentRequestId = (reader.IsDBNull(((int)FeeStudInstallmentColumn.FeeStudInstallmentRequestId - 1)))?null:(System.Decimal?)reader[((int)FeeStudInstallmentColumn.FeeStudInstallmentRequestId - 1)];
			entity.InstallmentOrder = (System.Decimal)reader[((int)FeeStudInstallmentColumn.InstallmentOrder - 1)];
			entity.InstallmentDate = (System.DateTime)reader[((int)FeeStudInstallmentColumn.InstallmentDate - 1)];
			entity.InstallmentPercentage = (System.Decimal)reader[((int)FeeStudInstallmentColumn.InstallmentPercentage - 1)];
			entity.InstallmentAmount = (reader.IsDBNull(((int)FeeStudInstallmentColumn.InstallmentAmount - 1)))?null:(System.Decimal?)reader[((int)FeeStudInstallmentColumn.InstallmentAmount - 1)];
			entity.PaidFlg = (System.Decimal)reader[((int)FeeStudInstallmentColumn.PaidFlg - 1)];
			entity.AllInOne = (System.Decimal)reader[((int)FeeStudInstallmentColumn.AllInOne - 1)];
			entity.EdAcadYearId = (System.Decimal)reader[((int)FeeStudInstallmentColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)FeeStudInstallmentColumn.EdCodeSemesterId - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)FeeStudInstallmentColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)FeeStudInstallmentColumn.AsFacultyInfoId - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)FeeStudInstallmentColumn.EdStudId - 1)];
			entity.GsCodeCurrencyId = (reader.IsDBNull(((int)FeeStudInstallmentColumn.GsCodeCurrencyId - 1)))?null:(System.Decimal?)reader[((int)FeeStudInstallmentColumn.GsCodeCurrencyId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeStudInstallment"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudInstallment"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeStudInstallment entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeStudInstallmentId = (System.Decimal)dataRow["FEE_STUD_INSTALLMENT_ID"];
			entity.OriginalFeeStudInstallmentId = (System.Decimal)dataRow["FEE_STUD_INSTALLMENT_ID"];
			entity.FeeStudInstallmentRequestId = Convert.IsDBNull(dataRow["FEE_STUD_INSTALLMENT_REQUEST_ID"]) ? null : (System.Decimal?)dataRow["FEE_STUD_INSTALLMENT_REQUEST_ID"];
			entity.InstallmentOrder = (System.Decimal)dataRow["INSTALLMENT_ORDER"];
			entity.InstallmentDate = (System.DateTime)dataRow["INSTALLMENT_DATE"];
			entity.InstallmentPercentage = (System.Decimal)dataRow["INSTALLMENT_PERCENTAGE"];
			entity.InstallmentAmount = Convert.IsDBNull(dataRow["INSTALLMENT_AMOUNT"]) ? null : (System.Decimal?)dataRow["INSTALLMENT_AMOUNT"];
			entity.PaidFlg = (System.Decimal)dataRow["PAID_FLG"];
			entity.AllInOne = (System.Decimal)dataRow["ALL_IN_ONE"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.GsCodeCurrencyId = Convert.IsDBNull(dataRow["GS_CODE_CURRENCY_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_CURRENCY_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudInstallment"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeStudInstallment Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudInstallment entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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

			#region EdCodeSemesterIdSource	
			if (CanDeepLoad(entity, "EdCodeSemester|EdCodeSemesterIdSource", deepLoadType, innerList) 
				&& entity.EdCodeSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeSemesterId;
				EdCodeSemester tmpEntity = EntityManager.LocateEntity<EdCodeSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemesterIdSource = tmpEntity;
				else
					entity.EdCodeSemesterIdSource = DataRepository.EdCodeSemesterProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);		
				
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

			#region FeeStudInstallmentRequestIdSource	
			if (CanDeepLoad(entity, "FeeStudInstallmentRequest|FeeStudInstallmentRequestIdSource", deepLoadType, innerList) 
				&& entity.FeeStudInstallmentRequestIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeStudInstallmentRequestId ?? 0.0m);
				FeeStudInstallmentRequest tmpEntity = EntityManager.LocateEntity<FeeStudInstallmentRequest>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeStudInstallmentRequest), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeStudInstallmentRequestIdSource = tmpEntity;
				else
					entity.FeeStudInstallmentRequestIdSource = DataRepository.FeeStudInstallmentRequestProvider.GetByFeeStudInstallmentRequestId(transactionManager, (entity.FeeStudInstallmentRequestId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudInstallmentRequestIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeStudInstallmentRequestIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeStudInstallmentRequestProvider.DeepLoad(transactionManager, entity.FeeStudInstallmentRequestIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeStudInstallmentRequestIdSource

			#region GsCodeCurrencyIdSource	
			if (CanDeepLoad(entity, "GsCodeCurrency|GsCodeCurrencyIdSource", deepLoadType, innerList) 
				&& entity.GsCodeCurrencyIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeCurrencyId ?? 0.0m);
				GsCodeCurrency tmpEntity = EntityManager.LocateEntity<GsCodeCurrency>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeCurrency), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeCurrencyIdSource = tmpEntity;
				else
					entity.GsCodeCurrencyIdSource = DataRepository.GsCodeCurrencyProvider.GetByGsCodeCurrencyId(transactionManager, (entity.GsCodeCurrencyId ?? 0.0m));		
				
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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByFeeStudInstallmentId methods when available
			
			#region FeeStudVoucherItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudVoucherItem>|FeeStudVoucherItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudVoucherItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudVoucherItemCollection = DataRepository.FeeStudVoucherItemProvider.GetByFeeStudInstallmentId(transactionManager, entity.FeeStudInstallmentId);

				if (deep && entity.FeeStudVoucherItemCollection.Count > 0)
				{
					deepHandles.Add("FeeStudVoucherItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudVoucherItem>) DataRepository.FeeStudVoucherItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudVoucherItemCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeStudInstallment object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeStudInstallment instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeStudInstallment Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudInstallment entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdCodeSemesterIdSource
			if (CanDeepSave(entity, "EdCodeSemester|EdCodeSemesterIdSource", deepSaveType, innerList) 
				&& entity.EdCodeSemesterIdSource != null)
			{
				DataRepository.EdCodeSemesterProvider.Save(transactionManager, entity.EdCodeSemesterIdSource);
				entity.EdCodeSemesterId = entity.EdCodeSemesterIdSource.EdCodeSemesterId;
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
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
			}
			#endregion 
			
			#region FeeStudInstallmentRequestIdSource
			if (CanDeepSave(entity, "FeeStudInstallmentRequest|FeeStudInstallmentRequestIdSource", deepSaveType, innerList) 
				&& entity.FeeStudInstallmentRequestIdSource != null)
			{
				DataRepository.FeeStudInstallmentRequestProvider.Save(transactionManager, entity.FeeStudInstallmentRequestIdSource);
				entity.FeeStudInstallmentRequestId = entity.FeeStudInstallmentRequestIdSource.FeeStudInstallmentRequestId;
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
						if(child.FeeStudInstallmentIdSource != null)
						{
							child.FeeStudInstallmentId = child.FeeStudInstallmentIdSource.FeeStudInstallmentId;
						}
						else
						{
							child.FeeStudInstallmentId = entity.FeeStudInstallmentId;
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
	
	#region FeeStudInstallmentChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeStudInstallment</c>
	///</summary>
	public enum FeeStudInstallmentChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>EdCodeSemester</c> at EdCodeSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemester))]
		EdCodeSemester,
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>FeeStudInstallmentRequest</c> at FeeStudInstallmentRequestIdSource
		///</summary>
		[ChildEntityType(typeof(FeeStudInstallmentRequest))]
		FeeStudInstallmentRequest,
		
		///<summary>
		/// Composite Property for <c>GsCodeCurrency</c> at GsCodeCurrencyIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeCurrency))]
		GsCodeCurrency,
		///<summary>
		/// Collection of <c>FeeStudInstallment</c> as OneToMany for FeeStudVoucherItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudVoucherItem>))]
		FeeStudVoucherItemCollection,
	}
	
	#endregion FeeStudInstallmentChildEntityTypes
	
	#region FeeStudInstallmentFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeStudInstallmentColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudInstallment"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeStudInstallmentFilterBuilder : SqlFilterBuilder<FeeStudInstallmentColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudInstallmentFilterBuilder class.
		/// </summary>
		public FeeStudInstallmentFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeStudInstallmentFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeStudInstallmentFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeStudInstallmentFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeStudInstallmentFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeStudInstallmentFilterBuilder
	
	#region FeeStudInstallmentParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeStudInstallmentColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudInstallment"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeStudInstallmentParameterBuilder : ParameterizedSqlFilterBuilder<FeeStudInstallmentColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudInstallmentParameterBuilder class.
		/// </summary>
		public FeeStudInstallmentParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeStudInstallmentParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeStudInstallmentParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeStudInstallmentParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeStudInstallmentParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeStudInstallmentParameterBuilder
	
	#region FeeStudInstallmentSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeStudInstallmentColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudInstallment"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeStudInstallmentSortBuilder : SqlSortBuilder<FeeStudInstallmentColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudInstallmentSqlSortBuilder class.
		/// </summary>
		public FeeStudInstallmentSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeStudInstallmentSortBuilder
	
} // end namespace
