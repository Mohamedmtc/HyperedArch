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
	/// This class is the base class for any <see cref="FeeItemSemesterProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeItemSemesterProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeItemSemester, UMIS_VER2.BusinessLyer.FeeItemSemesterKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeItemSemesterKey key)
		{
			return Delete(transactionManager, key.FeeItemSemesterId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeItemSemesterId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeItemSemesterId)
		{
			return Delete(null, _feeItemSemesterId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeItemSemesterId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeItemSemesterId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_SEMESTER_ED_ACAD_YEAR key.
		///		FK_FEE_ITEM_SEMESTER_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearJoinId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemSemester objects.</returns>
		public TList<FeeItemSemester> GetByEdAcadYearJoinId(System.Decimal? _edAcadYearJoinId)
		{
			int count = -1;
			return GetByEdAcadYearJoinId(_edAcadYearJoinId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_SEMESTER_ED_ACAD_YEAR key.
		///		FK_FEE_ITEM_SEMESTER_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearJoinId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemSemester objects.</returns>
		/// <remarks></remarks>
		public TList<FeeItemSemester> GetByEdAcadYearJoinId(TransactionManager transactionManager, System.Decimal? _edAcadYearJoinId)
		{
			int count = -1;
			return GetByEdAcadYearJoinId(transactionManager, _edAcadYearJoinId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_SEMESTER_ED_ACAD_YEAR key.
		///		FK_FEE_ITEM_SEMESTER_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearJoinId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemSemester objects.</returns>
		public TList<FeeItemSemester> GetByEdAcadYearJoinId(TransactionManager transactionManager, System.Decimal? _edAcadYearJoinId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearJoinId(transactionManager, _edAcadYearJoinId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_SEMESTER_ED_ACAD_YEAR key.
		///		fkFeeItemSemesterEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearJoinId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemSemester objects.</returns>
		public TList<FeeItemSemester> GetByEdAcadYearJoinId(System.Decimal? _edAcadYearJoinId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearJoinId(null, _edAcadYearJoinId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_SEMESTER_ED_ACAD_YEAR key.
		///		fkFeeItemSemesterEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearJoinId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemSemester objects.</returns>
		public TList<FeeItemSemester> GetByEdAcadYearJoinId(System.Decimal? _edAcadYearJoinId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearJoinId(null, _edAcadYearJoinId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_SEMESTER_ED_ACAD_YEAR key.
		///		FK_FEE_ITEM_SEMESTER_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearJoinId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemSemester objects.</returns>
		public abstract TList<FeeItemSemester> GetByEdAcadYearJoinId(TransactionManager transactionManager, System.Decimal? _edAcadYearJoinId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_SEMESTER_ED_CODE_SEMESTER key.
		///		FK_FEE_ITEM_SEMESTER_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemSemester objects.</returns>
		public TList<FeeItemSemester> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_SEMESTER_ED_CODE_SEMESTER key.
		///		FK_FEE_ITEM_SEMESTER_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemSemester objects.</returns>
		/// <remarks></remarks>
		public TList<FeeItemSemester> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_SEMESTER_ED_CODE_SEMESTER key.
		///		FK_FEE_ITEM_SEMESTER_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemSemester objects.</returns>
		public TList<FeeItemSemester> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_SEMESTER_ED_CODE_SEMESTER key.
		///		fkFeeItemSemesterEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemSemester objects.</returns>
		public TList<FeeItemSemester> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_SEMESTER_ED_CODE_SEMESTER key.
		///		fkFeeItemSemesterEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemSemester objects.</returns>
		public TList<FeeItemSemester> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_SEMESTER_ED_CODE_SEMESTER key.
		///		FK_FEE_ITEM_SEMESTER_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemSemester objects.</returns>
		public abstract TList<FeeItemSemester> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_SEMESTER_FEE_CODE_ITEM key.
		///		FK_FEE_ITEM_SEMESTER_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="_feeCodeItemId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemSemester objects.</returns>
		public TList<FeeItemSemester> GetByFeeCodeItemId(System.Decimal _feeCodeItemId)
		{
			int count = -1;
			return GetByFeeCodeItemId(_feeCodeItemId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_SEMESTER_FEE_CODE_ITEM key.
		///		FK_FEE_ITEM_SEMESTER_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemSemester objects.</returns>
		/// <remarks></remarks>
		public TList<FeeItemSemester> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal _feeCodeItemId)
		{
			int count = -1;
			return GetByFeeCodeItemId(transactionManager, _feeCodeItemId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_SEMESTER_FEE_CODE_ITEM key.
		///		FK_FEE_ITEM_SEMESTER_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemSemester objects.</returns>
		public TList<FeeItemSemester> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal _feeCodeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeItemId(transactionManager, _feeCodeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_SEMESTER_FEE_CODE_ITEM key.
		///		fkFeeItemSemesterFeeCodeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeItemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemSemester objects.</returns>
		public TList<FeeItemSemester> GetByFeeCodeItemId(System.Decimal _feeCodeItemId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCodeItemId(null, _feeCodeItemId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_SEMESTER_FEE_CODE_ITEM key.
		///		fkFeeItemSemesterFeeCodeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeItemId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemSemester objects.</returns>
		public TList<FeeItemSemester> GetByFeeCodeItemId(System.Decimal _feeCodeItemId, int start, int pageLength,out int count)
		{
			return GetByFeeCodeItemId(null, _feeCodeItemId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_SEMESTER_FEE_CODE_ITEM key.
		///		FK_FEE_ITEM_SEMESTER_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemSemester objects.</returns>
		public abstract TList<FeeItemSemester> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal _feeCodeItemId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_SEMESTER_FEE_FACULTY_RULE key.
		///		FK_FEE_ITEM_SEMESTER_FEE_FACULTY_RULE Description: 
		/// </summary>
		/// <param name="_feeFacultyRuleId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemSemester objects.</returns>
		public TList<FeeItemSemester> GetByFeeFacultyRuleId(System.Decimal _feeFacultyRuleId)
		{
			int count = -1;
			return GetByFeeFacultyRuleId(_feeFacultyRuleId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_SEMESTER_FEE_FACULTY_RULE key.
		///		FK_FEE_ITEM_SEMESTER_FEE_FACULTY_RULE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFacultyRuleId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemSemester objects.</returns>
		/// <remarks></remarks>
		public TList<FeeItemSemester> GetByFeeFacultyRuleId(TransactionManager transactionManager, System.Decimal _feeFacultyRuleId)
		{
			int count = -1;
			return GetByFeeFacultyRuleId(transactionManager, _feeFacultyRuleId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_SEMESTER_FEE_FACULTY_RULE key.
		///		FK_FEE_ITEM_SEMESTER_FEE_FACULTY_RULE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFacultyRuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemSemester objects.</returns>
		public TList<FeeItemSemester> GetByFeeFacultyRuleId(TransactionManager transactionManager, System.Decimal _feeFacultyRuleId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeFacultyRuleId(transactionManager, _feeFacultyRuleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_SEMESTER_FEE_FACULTY_RULE key.
		///		fkFeeItemSemesterFeeFacultyRule Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeFacultyRuleId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemSemester objects.</returns>
		public TList<FeeItemSemester> GetByFeeFacultyRuleId(System.Decimal _feeFacultyRuleId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeFacultyRuleId(null, _feeFacultyRuleId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_SEMESTER_FEE_FACULTY_RULE key.
		///		fkFeeItemSemesterFeeFacultyRule Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeFacultyRuleId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemSemester objects.</returns>
		public TList<FeeItemSemester> GetByFeeFacultyRuleId(System.Decimal _feeFacultyRuleId, int start, int pageLength,out int count)
		{
			return GetByFeeFacultyRuleId(null, _feeFacultyRuleId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ITEM_SEMESTER_FEE_FACULTY_RULE key.
		///		FK_FEE_ITEM_SEMESTER_FEE_FACULTY_RULE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFacultyRuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeItemSemester objects.</returns>
		public abstract TList<FeeItemSemester> GetByFeeFacultyRuleId(TransactionManager transactionManager, System.Decimal _feeFacultyRuleId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeItemSemester Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeItemSemesterKey key, int start, int pageLength)
		{
			return GetByFeeItemSemesterId(transactionManager, key.FeeItemSemesterId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_ITEM_SEMESTER index.
		/// </summary>
		/// <param name="_feeItemSemesterId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeItemSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeItemSemester GetByFeeItemSemesterId(System.Decimal _feeItemSemesterId)
		{
			int count = -1;
			return GetByFeeItemSemesterId(null,_feeItemSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_ITEM_SEMESTER index.
		/// </summary>
		/// <param name="_feeItemSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeItemSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeItemSemester GetByFeeItemSemesterId(System.Decimal _feeItemSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeItemSemesterId(null, _feeItemSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_ITEM_SEMESTER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeItemSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeItemSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeItemSemester GetByFeeItemSemesterId(TransactionManager transactionManager, System.Decimal _feeItemSemesterId)
		{
			int count = -1;
			return GetByFeeItemSemesterId(transactionManager, _feeItemSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_ITEM_SEMESTER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeItemSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeItemSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeItemSemester GetByFeeItemSemesterId(TransactionManager transactionManager, System.Decimal _feeItemSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeItemSemesterId(transactionManager, _feeItemSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_ITEM_SEMESTER index.
		/// </summary>
		/// <param name="_feeItemSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeItemSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeItemSemester GetByFeeItemSemesterId(System.Decimal _feeItemSemesterId, int start, int pageLength, out int count)
		{
			return GetByFeeItemSemesterId(null, _feeItemSemesterId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_ITEM_SEMESTER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeItemSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeItemSemester"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeItemSemester GetByFeeItemSemesterId(TransactionManager transactionManager, System.Decimal _feeItemSemesterId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeItemSemester&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeItemSemester&gt;"/></returns>
		public static TList<FeeItemSemester> Fill(IDataReader reader, TList<FeeItemSemester> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeItemSemester c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeItemSemester")
					.Append("|").Append((System.Decimal)reader["FEE_ITEM_SEMESTER_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeItemSemester>(
					key.ToString(), // EntityTrackingKey
					"FeeItemSemester",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeItemSemester();
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
					c.FeeItemSemesterId = (System.Decimal)reader["FEE_ITEM_SEMESTER_ID"];
					c.OriginalFeeItemSemesterId = c.FeeItemSemesterId;
					c.FeeFacultyRuleId = (System.Decimal)reader["FEE_FACULTY_RULE_ID"];
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.FeeCodeItemId = (System.Decimal)reader["FEE_CODE_ITEM_ID"];
					c.Prcnt = (System.Decimal)reader["PRCNT"];
					c.RegFlg = Convert.IsDBNull(reader["REG_FLG"]) ? null : (System.Int16?)reader["REG_FLG"];
					c.PayValue = Convert.IsDBNull(reader["PAY_VALUE"]) ? null : (System.Decimal?)reader["PAY_VALUE"];
					c.EdAcadYearJoinId = Convert.IsDBNull(reader["ED_ACAD_YEAR_JOIN_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_JOIN_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeItemSemester"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeItemSemester"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeItemSemester entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeItemSemesterId = (System.Decimal)reader[((int)FeeItemSemesterColumn.FeeItemSemesterId - 1)];
			entity.OriginalFeeItemSemesterId = (System.Decimal)reader["FEE_ITEM_SEMESTER_ID"];
			entity.FeeFacultyRuleId = (System.Decimal)reader[((int)FeeItemSemesterColumn.FeeFacultyRuleId - 1)];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)FeeItemSemesterColumn.EdCodeSemesterId - 1)];
			entity.FeeCodeItemId = (System.Decimal)reader[((int)FeeItemSemesterColumn.FeeCodeItemId - 1)];
			entity.Prcnt = (System.Decimal)reader[((int)FeeItemSemesterColumn.Prcnt - 1)];
			entity.RegFlg = (reader.IsDBNull(((int)FeeItemSemesterColumn.RegFlg - 1)))?null:(System.Int16?)reader[((int)FeeItemSemesterColumn.RegFlg - 1)];
			entity.PayValue = (reader.IsDBNull(((int)FeeItemSemesterColumn.PayValue - 1)))?null:(System.Decimal?)reader[((int)FeeItemSemesterColumn.PayValue - 1)];
			entity.EdAcadYearJoinId = (reader.IsDBNull(((int)FeeItemSemesterColumn.EdAcadYearJoinId - 1)))?null:(System.Decimal?)reader[((int)FeeItemSemesterColumn.EdAcadYearJoinId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeItemSemester"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeItemSemester"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeItemSemester entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeItemSemesterId = (System.Decimal)dataRow["FEE_ITEM_SEMESTER_ID"];
			entity.OriginalFeeItemSemesterId = (System.Decimal)dataRow["FEE_ITEM_SEMESTER_ID"];
			entity.FeeFacultyRuleId = (System.Decimal)dataRow["FEE_FACULTY_RULE_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.FeeCodeItemId = (System.Decimal)dataRow["FEE_CODE_ITEM_ID"];
			entity.Prcnt = (System.Decimal)dataRow["PRCNT"];
			entity.RegFlg = Convert.IsDBNull(dataRow["REG_FLG"]) ? null : (System.Int16?)dataRow["REG_FLG"];
			entity.PayValue = Convert.IsDBNull(dataRow["PAY_VALUE"]) ? null : (System.Decimal?)dataRow["PAY_VALUE"];
			entity.EdAcadYearJoinId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_JOIN_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_JOIN_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeItemSemester"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeItemSemester Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeItemSemester entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdAcadYearJoinIdSource	
			if (CanDeepLoad(entity, "EdAcadYear|EdAcadYearJoinIdSource", deepLoadType, innerList) 
				&& entity.EdAcadYearJoinIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdAcadYearJoinId ?? 0.0m);
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadYearJoinIdSource = tmpEntity;
				else
					entity.EdAcadYearJoinIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, (entity.EdAcadYearJoinId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadYearJoinIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdAcadYearJoinIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdAcadYearProvider.DeepLoad(transactionManager, entity.EdAcadYearJoinIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdAcadYearJoinIdSource

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

			#region FeeFacultyRuleIdSource	
			if (CanDeepLoad(entity, "FeeFacultyRule|FeeFacultyRuleIdSource", deepLoadType, innerList) 
				&& entity.FeeFacultyRuleIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeFacultyRuleId;
				FeeFacultyRule tmpEntity = EntityManager.LocateEntity<FeeFacultyRule>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeFacultyRule), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeFacultyRuleIdSource = tmpEntity;
				else
					entity.FeeFacultyRuleIdSource = DataRepository.FeeFacultyRuleProvider.GetByFeeFacultyRuleId(transactionManager, entity.FeeFacultyRuleId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeFacultyRuleIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeFacultyRuleIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeFacultyRuleProvider.DeepLoad(transactionManager, entity.FeeFacultyRuleIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeFacultyRuleIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeItemSemester object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeItemSemester instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeItemSemester Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeItemSemester entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdAcadYearJoinIdSource
			if (CanDeepSave(entity, "EdAcadYear|EdAcadYearJoinIdSource", deepSaveType, innerList) 
				&& entity.EdAcadYearJoinIdSource != null)
			{
				DataRepository.EdAcadYearProvider.Save(transactionManager, entity.EdAcadYearJoinIdSource);
				entity.EdAcadYearJoinId = entity.EdAcadYearJoinIdSource.EdAcadYearId;
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
			
			#region FeeCodeItemIdSource
			if (CanDeepSave(entity, "FeeCodeItem|FeeCodeItemIdSource", deepSaveType, innerList) 
				&& entity.FeeCodeItemIdSource != null)
			{
				DataRepository.FeeCodeItemProvider.Save(transactionManager, entity.FeeCodeItemIdSource);
				entity.FeeCodeItemId = entity.FeeCodeItemIdSource.FeeCodeItemId;
			}
			#endregion 
			
			#region FeeFacultyRuleIdSource
			if (CanDeepSave(entity, "FeeFacultyRule|FeeFacultyRuleIdSource", deepSaveType, innerList) 
				&& entity.FeeFacultyRuleIdSource != null)
			{
				DataRepository.FeeFacultyRuleProvider.Save(transactionManager, entity.FeeFacultyRuleIdSource);
				entity.FeeFacultyRuleId = entity.FeeFacultyRuleIdSource.FeeFacultyRuleId;
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
	
	#region FeeItemSemesterChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeItemSemester</c>
	///</summary>
	public enum FeeItemSemesterChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearJoinIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>EdCodeSemester</c> at EdCodeSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemester))]
		EdCodeSemester,
		
		///<summary>
		/// Composite Property for <c>FeeCodeItem</c> at FeeCodeItemIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCodeItem))]
		FeeCodeItem,
		
		///<summary>
		/// Composite Property for <c>FeeFacultyRule</c> at FeeFacultyRuleIdSource
		///</summary>
		[ChildEntityType(typeof(FeeFacultyRule))]
		FeeFacultyRule,
	}
	
	#endregion FeeItemSemesterChildEntityTypes
	
	#region FeeItemSemesterFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeItemSemesterColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeItemSemester"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeItemSemesterFilterBuilder : SqlFilterBuilder<FeeItemSemesterColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeItemSemesterFilterBuilder class.
		/// </summary>
		public FeeItemSemesterFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeItemSemesterFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeItemSemesterFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeItemSemesterFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeItemSemesterFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeItemSemesterFilterBuilder
	
	#region FeeItemSemesterParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeItemSemesterColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeItemSemester"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeItemSemesterParameterBuilder : ParameterizedSqlFilterBuilder<FeeItemSemesterColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeItemSemesterParameterBuilder class.
		/// </summary>
		public FeeItemSemesterParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeItemSemesterParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeItemSemesterParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeItemSemesterParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeItemSemesterParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeItemSemesterParameterBuilder
	
	#region FeeItemSemesterSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeItemSemesterColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeItemSemester"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeItemSemesterSortBuilder : SqlSortBuilder<FeeItemSemesterColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeItemSemesterSqlSortBuilder class.
		/// </summary>
		public FeeItemSemesterSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeItemSemesterSortBuilder
	
} // end namespace
