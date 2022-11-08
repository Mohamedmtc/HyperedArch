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
	/// This class is the base class for any <see cref="FeeCodeItemProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeCodeItemProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeCodeItem, UMIS_VER2.BusinessLyer.FeeCodeItemKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCodeItemKey key)
		{
			return Delete(transactionManager, key.FeeCodeItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeCodeItemId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeCodeItemId)
		{
			return Delete(null, _feeCodeItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeCodeItemId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CODE_ITEM_AS_CODE_DEGREE key.
		///		FK_FEE_CODE_ITEM_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="_asCodeDegreeId">XX to be deleted</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCodeItem objects.</returns>
		public TList<FeeCodeItem> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(_asCodeDegreeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CODE_ITEM_AS_CODE_DEGREE key.
		///		FK_FEE_CODE_ITEM_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">XX to be deleted</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCodeItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeCodeItem> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CODE_ITEM_AS_CODE_DEGREE key.
		///		FK_FEE_CODE_ITEM_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">XX to be deleted</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCodeItem objects.</returns>
		public TList<FeeCodeItem> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CODE_ITEM_AS_CODE_DEGREE key.
		///		fkFeeCodeItemAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId">XX to be deleted</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCodeItem objects.</returns>
		public TList<FeeCodeItem> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CODE_ITEM_AS_CODE_DEGREE key.
		///		fkFeeCodeItemAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId">XX to be deleted</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCodeItem objects.</returns>
		public TList<FeeCodeItem> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CODE_ITEM_AS_CODE_DEGREE key.
		///		FK_FEE_CODE_ITEM_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">XX to be deleted</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCodeItem objects.</returns>
		public abstract TList<FeeCodeItem> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CODE_ITEM_AS_CODE_DEGREE_CLASS key.
		///		FK_FEE_CODE_ITEM_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="_asCodeDegreeClassId">نوع الدرجة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCodeItem objects.</returns>
		public TList<FeeCodeItem> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(_asCodeDegreeClassId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CODE_ITEM_AS_CODE_DEGREE_CLASS key.
		///		FK_FEE_CODE_ITEM_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId">نوع الدرجة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCodeItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeCodeItem> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CODE_ITEM_AS_CODE_DEGREE_CLASS key.
		///		FK_FEE_CODE_ITEM_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId">نوع الدرجة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCodeItem objects.</returns>
		public TList<FeeCodeItem> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CODE_ITEM_AS_CODE_DEGREE_CLASS key.
		///		fkFeeCodeItemAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId">نوع الدرجة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCodeItem objects.</returns>
		public TList<FeeCodeItem> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CODE_ITEM_AS_CODE_DEGREE_CLASS key.
		///		fkFeeCodeItemAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId">نوع الدرجة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCodeItem objects.</returns>
		public TList<FeeCodeItem> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CODE_ITEM_AS_CODE_DEGREE_CLASS key.
		///		FK_FEE_CODE_ITEM_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId">نوع الدرجة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCodeItem objects.</returns>
		public abstract TList<FeeCodeItem> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CODE_ITEM_ED_CODE_SEMESTER key.
		///		FK_FEE_CODE_ITEM_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCodeItem objects.</returns>
		public TList<FeeCodeItem> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CODE_ITEM_ED_CODE_SEMESTER key.
		///		FK_FEE_CODE_ITEM_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCodeItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeCodeItem> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CODE_ITEM_ED_CODE_SEMESTER key.
		///		FK_FEE_CODE_ITEM_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCodeItem objects.</returns>
		public TList<FeeCodeItem> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CODE_ITEM_ED_CODE_SEMESTER key.
		///		fkFeeCodeItemEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCodeItem objects.</returns>
		public TList<FeeCodeItem> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CODE_ITEM_ED_CODE_SEMESTER key.
		///		fkFeeCodeItemEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCodeItem objects.</returns>
		public TList<FeeCodeItem> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CODE_ITEM_ED_CODE_SEMESTER key.
		///		FK_FEE_CODE_ITEM_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCodeItem objects.</returns>
		public abstract TList<FeeCodeItem> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeCodeItem Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCodeItemKey key, int start, int pageLength)
		{
			return GetByFeeCodeItemId(transactionManager, key.FeeCodeItemId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_FEE_CODE_TYPE_ID_1 index.
		/// </summary>
		/// <param name="_feeCodeTypeId">نوع البند</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeCodeItem&gt;"/> class.</returns>
		public TList<FeeCodeItem> GetByFeeCodeTypeId(System.Decimal _feeCodeTypeId)
		{
			int count = -1;
			return GetByFeeCodeTypeId(null,_feeCodeTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_CODE_TYPE_ID_1 index.
		/// </summary>
		/// <param name="_feeCodeTypeId">نوع البند</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeCodeItem&gt;"/> class.</returns>
		public TList<FeeCodeItem> GetByFeeCodeTypeId(System.Decimal _feeCodeTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeTypeId(null, _feeCodeTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_CODE_TYPE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeTypeId">نوع البند</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeCodeItem&gt;"/> class.</returns>
		public TList<FeeCodeItem> GetByFeeCodeTypeId(TransactionManager transactionManager, System.Decimal _feeCodeTypeId)
		{
			int count = -1;
			return GetByFeeCodeTypeId(transactionManager, _feeCodeTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_CODE_TYPE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeTypeId">نوع البند</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeCodeItem&gt;"/> class.</returns>
		public TList<FeeCodeItem> GetByFeeCodeTypeId(TransactionManager transactionManager, System.Decimal _feeCodeTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeTypeId(transactionManager, _feeCodeTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_CODE_TYPE_ID_1 index.
		/// </summary>
		/// <param name="_feeCodeTypeId">نوع البند</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeCodeItem&gt;"/> class.</returns>
		public TList<FeeCodeItem> GetByFeeCodeTypeId(System.Decimal _feeCodeTypeId, int start, int pageLength, out int count)
		{
			return GetByFeeCodeTypeId(null, _feeCodeTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_CODE_TYPE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeTypeId">نوع البند</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeCodeItem&gt;"/> class.</returns>
		public abstract TList<FeeCodeItem> GetByFeeCodeTypeId(TransactionManager transactionManager, System.Decimal _feeCodeTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_CODE_ITEM index.
		/// </summary>
		/// <param name="_feeCodeItemId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCodeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCodeItem GetByFeeCodeItemId(System.Decimal _feeCodeItemId)
		{
			int count = -1;
			return GetByFeeCodeItemId(null,_feeCodeItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CODE_ITEM index.
		/// </summary>
		/// <param name="_feeCodeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCodeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCodeItem GetByFeeCodeItemId(System.Decimal _feeCodeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeItemId(null, _feeCodeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CODE_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCodeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCodeItem GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal _feeCodeItemId)
		{
			int count = -1;
			return GetByFeeCodeItemId(transactionManager, _feeCodeItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CODE_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCodeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCodeItem GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal _feeCodeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeItemId(transactionManager, _feeCodeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CODE_ITEM index.
		/// </summary>
		/// <param name="_feeCodeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCodeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCodeItem GetByFeeCodeItemId(System.Decimal _feeCodeItemId, int start, int pageLength, out int count)
		{
			return GetByFeeCodeItemId(null, _feeCodeItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CODE_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCodeItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeCodeItem GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal _feeCodeItemId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_FEE_CODE_ITEM_AR index.
		/// </summary>
		/// <param name="_asCodeDegreeId">XX to be deleted</param>
		/// <param name="_feeCodeTypeId">نوع البند</param>
		/// <param name="_descrAr">اسم البند</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCodeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCodeItem GetByAsCodeDegreeIdFeeCodeTypeIdDescrAr(System.Decimal? _asCodeDegreeId, System.Decimal _feeCodeTypeId, System.String _descrAr)
		{
			int count = -1;
			return GetByAsCodeDegreeIdFeeCodeTypeIdDescrAr(null,_asCodeDegreeId, _feeCodeTypeId, _descrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_CODE_ITEM_AR index.
		/// </summary>
		/// <param name="_asCodeDegreeId">XX to be deleted</param>
		/// <param name="_feeCodeTypeId">نوع البند</param>
		/// <param name="_descrAr">اسم البند</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCodeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCodeItem GetByAsCodeDegreeIdFeeCodeTypeIdDescrAr(System.Decimal? _asCodeDegreeId, System.Decimal _feeCodeTypeId, System.String _descrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeIdFeeCodeTypeIdDescrAr(null, _asCodeDegreeId, _feeCodeTypeId, _descrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_CODE_ITEM_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">XX to be deleted</param>
		/// <param name="_feeCodeTypeId">نوع البند</param>
		/// <param name="_descrAr">اسم البند</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCodeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCodeItem GetByAsCodeDegreeIdFeeCodeTypeIdDescrAr(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, System.Decimal _feeCodeTypeId, System.String _descrAr)
		{
			int count = -1;
			return GetByAsCodeDegreeIdFeeCodeTypeIdDescrAr(transactionManager, _asCodeDegreeId, _feeCodeTypeId, _descrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_CODE_ITEM_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">XX to be deleted</param>
		/// <param name="_feeCodeTypeId">نوع البند</param>
		/// <param name="_descrAr">اسم البند</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCodeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCodeItem GetByAsCodeDegreeIdFeeCodeTypeIdDescrAr(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, System.Decimal _feeCodeTypeId, System.String _descrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeIdFeeCodeTypeIdDescrAr(transactionManager, _asCodeDegreeId, _feeCodeTypeId, _descrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_CODE_ITEM_AR index.
		/// </summary>
		/// <param name="_asCodeDegreeId">XX to be deleted</param>
		/// <param name="_feeCodeTypeId">نوع البند</param>
		/// <param name="_descrAr">اسم البند</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCodeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCodeItem GetByAsCodeDegreeIdFeeCodeTypeIdDescrAr(System.Decimal? _asCodeDegreeId, System.Decimal _feeCodeTypeId, System.String _descrAr, int start, int pageLength, out int count)
		{
			return GetByAsCodeDegreeIdFeeCodeTypeIdDescrAr(null, _asCodeDegreeId, _feeCodeTypeId, _descrAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_CODE_ITEM_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">XX to be deleted</param>
		/// <param name="_feeCodeTypeId">نوع البند</param>
		/// <param name="_descrAr">اسم البند</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCodeItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeCodeItem GetByAsCodeDegreeIdFeeCodeTypeIdDescrAr(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, System.Decimal _feeCodeTypeId, System.String _descrAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_FEE_CODE_ITEM_EN index.
		/// </summary>
		/// <param name="_asCodeDegreeId">XX to be deleted</param>
		/// <param name="_feeCodeTypeId">نوع البند</param>
		/// <param name="_descrEn">اسم البند</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCodeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCodeItem GetByAsCodeDegreeIdFeeCodeTypeIdDescrEn(System.Decimal? _asCodeDegreeId, System.Decimal _feeCodeTypeId, System.String _descrEn)
		{
			int count = -1;
			return GetByAsCodeDegreeIdFeeCodeTypeIdDescrEn(null,_asCodeDegreeId, _feeCodeTypeId, _descrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_CODE_ITEM_EN index.
		/// </summary>
		/// <param name="_asCodeDegreeId">XX to be deleted</param>
		/// <param name="_feeCodeTypeId">نوع البند</param>
		/// <param name="_descrEn">اسم البند</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCodeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCodeItem GetByAsCodeDegreeIdFeeCodeTypeIdDescrEn(System.Decimal? _asCodeDegreeId, System.Decimal _feeCodeTypeId, System.String _descrEn, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeIdFeeCodeTypeIdDescrEn(null, _asCodeDegreeId, _feeCodeTypeId, _descrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_CODE_ITEM_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">XX to be deleted</param>
		/// <param name="_feeCodeTypeId">نوع البند</param>
		/// <param name="_descrEn">اسم البند</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCodeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCodeItem GetByAsCodeDegreeIdFeeCodeTypeIdDescrEn(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, System.Decimal _feeCodeTypeId, System.String _descrEn)
		{
			int count = -1;
			return GetByAsCodeDegreeIdFeeCodeTypeIdDescrEn(transactionManager, _asCodeDegreeId, _feeCodeTypeId, _descrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_CODE_ITEM_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">XX to be deleted</param>
		/// <param name="_feeCodeTypeId">نوع البند</param>
		/// <param name="_descrEn">اسم البند</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCodeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCodeItem GetByAsCodeDegreeIdFeeCodeTypeIdDescrEn(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, System.Decimal _feeCodeTypeId, System.String _descrEn, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeIdFeeCodeTypeIdDescrEn(transactionManager, _asCodeDegreeId, _feeCodeTypeId, _descrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_CODE_ITEM_EN index.
		/// </summary>
		/// <param name="_asCodeDegreeId">XX to be deleted</param>
		/// <param name="_feeCodeTypeId">نوع البند</param>
		/// <param name="_descrEn">اسم البند</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCodeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCodeItem GetByAsCodeDegreeIdFeeCodeTypeIdDescrEn(System.Decimal? _asCodeDegreeId, System.Decimal _feeCodeTypeId, System.String _descrEn, int start, int pageLength, out int count)
		{
			return GetByAsCodeDegreeIdFeeCodeTypeIdDescrEn(null, _asCodeDegreeId, _feeCodeTypeId, _descrEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_CODE_ITEM_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">XX to be deleted</param>
		/// <param name="_feeCodeTypeId">نوع البند</param>
		/// <param name="_descrEn">اسم البند</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCodeItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeCodeItem GetByAsCodeDegreeIdFeeCodeTypeIdDescrEn(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, System.Decimal _feeCodeTypeId, System.String _descrEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeCodeItem&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeCodeItem&gt;"/></returns>
		public static TList<FeeCodeItem> Fill(IDataReader reader, TList<FeeCodeItem> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeCodeItem c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeCodeItem")
					.Append("|").Append((System.Decimal)reader["FEE_CODE_ITEM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeCodeItem>(
					key.ToString(), // EntityTrackingKey
					"FeeCodeItem",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeCodeItem();
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
					c.FeeCodeItemId = (System.Decimal)reader["FEE_CODE_ITEM_ID"];
					c.OriginalFeeCodeItemId = c.FeeCodeItemId;
					c.FeeCodeTypeId = (System.Decimal)reader["FEE_CODE_TYPE_ID"];
					c.DescrAr = Convert.IsDBNull(reader["DESCR_AR"]) ? null : (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.AsCodeDegreeClassId = Convert.IsDBNull(reader["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_CLASS_ID"];
					c.AsCodeDegreeId = Convert.IsDBNull(reader["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_ID"];
					c.ItemOrdr = Convert.IsDBNull(reader["ITEM_ORDR"]) ? null : (System.Int32?)reader["ITEM_ORDR"];
					c.OldId = Convert.IsDBNull(reader["OldId"]) ? null : (System.Int32?)reader["OldId"];
					c.EdCodeSemesterId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_ID"];
					c.EditFlg = Convert.IsDBNull(reader["EDIT_FLG"]) ? null : (System.Boolean?)reader["EDIT_FLG"];
					c.EnumId = Convert.IsDBNull(reader["ENUM_ID"]) ? null : (System.Int32?)reader["ENUM_ID"];
					c.AccNo = Convert.IsDBNull(reader["ACC_NO"]) ? null : (System.Int32?)reader["ACC_NO"];
					c.PrntId = Convert.IsDBNull(reader["PRNT_ID"]) ? null : (System.Int32?)reader["PRNT_ID"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.TaxPercent = Convert.IsDBNull(reader["TAX_PERCENT"]) ? null : (System.Decimal?)reader["TAX_PERCENT"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeCodeItem"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCodeItem"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeCodeItem entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeCodeItemId = (System.Decimal)reader[((int)FeeCodeItemColumn.FeeCodeItemId - 1)];
			entity.OriginalFeeCodeItemId = (System.Decimal)reader["FEE_CODE_ITEM_ID"];
			entity.FeeCodeTypeId = (System.Decimal)reader[((int)FeeCodeItemColumn.FeeCodeTypeId - 1)];
			entity.DescrAr = (reader.IsDBNull(((int)FeeCodeItemColumn.DescrAr - 1)))?null:(System.String)reader[((int)FeeCodeItemColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)FeeCodeItemColumn.DescrEn - 1)))?null:(System.String)reader[((int)FeeCodeItemColumn.DescrEn - 1)];
			entity.AsCodeDegreeClassId = (reader.IsDBNull(((int)FeeCodeItemColumn.AsCodeDegreeClassId - 1)))?null:(System.Decimal?)reader[((int)FeeCodeItemColumn.AsCodeDegreeClassId - 1)];
			entity.AsCodeDegreeId = (reader.IsDBNull(((int)FeeCodeItemColumn.AsCodeDegreeId - 1)))?null:(System.Decimal?)reader[((int)FeeCodeItemColumn.AsCodeDegreeId - 1)];
			entity.ItemOrdr = (reader.IsDBNull(((int)FeeCodeItemColumn.ItemOrdr - 1)))?null:(System.Int32?)reader[((int)FeeCodeItemColumn.ItemOrdr - 1)];
			entity.OldId = (reader.IsDBNull(((int)FeeCodeItemColumn.OldId - 1)))?null:(System.Int32?)reader[((int)FeeCodeItemColumn.OldId - 1)];
			entity.EdCodeSemesterId = (reader.IsDBNull(((int)FeeCodeItemColumn.EdCodeSemesterId - 1)))?null:(System.Decimal?)reader[((int)FeeCodeItemColumn.EdCodeSemesterId - 1)];
			entity.EditFlg = (reader.IsDBNull(((int)FeeCodeItemColumn.EditFlg - 1)))?null:(System.Boolean?)reader[((int)FeeCodeItemColumn.EditFlg - 1)];
			entity.EnumId = (reader.IsDBNull(((int)FeeCodeItemColumn.EnumId - 1)))?null:(System.Int32?)reader[((int)FeeCodeItemColumn.EnumId - 1)];
			entity.AccNo = (reader.IsDBNull(((int)FeeCodeItemColumn.AccNo - 1)))?null:(System.Int32?)reader[((int)FeeCodeItemColumn.AccNo - 1)];
			entity.PrntId = (reader.IsDBNull(((int)FeeCodeItemColumn.PrntId - 1)))?null:(System.Int32?)reader[((int)FeeCodeItemColumn.PrntId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)FeeCodeItemColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)FeeCodeItemColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)FeeCodeItemColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)FeeCodeItemColumn.LastDate - 1)];
			entity.TaxPercent = (reader.IsDBNull(((int)FeeCodeItemColumn.TaxPercent - 1)))?null:(System.Decimal?)reader[((int)FeeCodeItemColumn.TaxPercent - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeCodeItem"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCodeItem"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeCodeItem entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeCodeItemId = (System.Decimal)dataRow["FEE_CODE_ITEM_ID"];
			entity.OriginalFeeCodeItemId = (System.Decimal)dataRow["FEE_CODE_ITEM_ID"];
			entity.FeeCodeTypeId = (System.Decimal)dataRow["FEE_CODE_TYPE_ID"];
			entity.DescrAr = Convert.IsDBNull(dataRow["DESCR_AR"]) ? null : (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
			entity.AsCodeDegreeClassId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_CLASS_ID"];
			entity.AsCodeDegreeId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_ID"];
			entity.ItemOrdr = Convert.IsDBNull(dataRow["ITEM_ORDR"]) ? null : (System.Int32?)dataRow["ITEM_ORDR"];
			entity.OldId = Convert.IsDBNull(dataRow["OldId"]) ? null : (System.Int32?)dataRow["OldId"];
			entity.EdCodeSemesterId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_ID"];
			entity.EditFlg = Convert.IsDBNull(dataRow["EDIT_FLG"]) ? null : (System.Boolean?)dataRow["EDIT_FLG"];
			entity.EnumId = Convert.IsDBNull(dataRow["ENUM_ID"]) ? null : (System.Int32?)dataRow["ENUM_ID"];
			entity.AccNo = Convert.IsDBNull(dataRow["ACC_NO"]) ? null : (System.Int32?)dataRow["ACC_NO"];
			entity.PrntId = Convert.IsDBNull(dataRow["PRNT_ID"]) ? null : (System.Int32?)dataRow["PRNT_ID"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.TaxPercent = Convert.IsDBNull(dataRow["TAX_PERCENT"]) ? null : (System.Decimal?)dataRow["TAX_PERCENT"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCodeItem"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeCodeItem Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCodeItem entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsCodeDegreeIdSource	
			if (CanDeepLoad(entity, "AsCodeDegree|AsCodeDegreeIdSource", deepLoadType, innerList) 
				&& entity.AsCodeDegreeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsCodeDegreeId ?? 0.0m);
				AsCodeDegree tmpEntity = EntityManager.LocateEntity<AsCodeDegree>(EntityLocator.ConstructKeyFromPkItems(typeof(AsCodeDegree), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsCodeDegreeIdSource = tmpEntity;
				else
					entity.AsCodeDegreeIdSource = DataRepository.AsCodeDegreeProvider.GetByAsCodeDegreeId(transactionManager, (entity.AsCodeDegreeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsCodeDegreeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsCodeDegreeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsCodeDegreeProvider.DeepLoad(transactionManager, entity.AsCodeDegreeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsCodeDegreeIdSource

			#region AsCodeDegreeClassIdSource	
			if (CanDeepLoad(entity, "AsCodeDegreeClass|AsCodeDegreeClassIdSource", deepLoadType, innerList) 
				&& entity.AsCodeDegreeClassIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsCodeDegreeClassId ?? 0.0m);
				AsCodeDegreeClass tmpEntity = EntityManager.LocateEntity<AsCodeDegreeClass>(EntityLocator.ConstructKeyFromPkItems(typeof(AsCodeDegreeClass), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsCodeDegreeClassIdSource = tmpEntity;
				else
					entity.AsCodeDegreeClassIdSource = DataRepository.AsCodeDegreeClassProvider.GetByAsCodeDegreeClassId(transactionManager, (entity.AsCodeDegreeClassId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsCodeDegreeClassIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsCodeDegreeClassIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsCodeDegreeClassProvider.DeepLoad(transactionManager, entity.AsCodeDegreeClassIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsCodeDegreeClassIdSource

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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByFeeCodeItemId methods when available
			
			#region FeeBusLineItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeBusLineItem>|FeeBusLineItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeBusLineItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeBusLineItemCollection = DataRepository.FeeBusLineItemProvider.GetByFeeCodeItemId(transactionManager, entity.FeeCodeItemId);

				if (deep && entity.FeeBusLineItemCollection.Count > 0)
				{
					deepHandles.Add("FeeBusLineItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeBusLineItem>) DataRepository.FeeBusLineItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeBusLineItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeItemSemesterCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeItemSemester>|FeeItemSemesterCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeItemSemesterCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeItemSemesterCollection = DataRepository.FeeItemSemesterProvider.GetByFeeCodeItemId(transactionManager, entity.FeeCodeItemId);

				if (deep && entity.FeeItemSemesterCollection.Count > 0)
				{
					deepHandles.Add("FeeItemSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeItemSemester>) DataRepository.FeeItemSemesterProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeItemSemesterCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmCdeFeeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmCdeFee>|AdmCdeFeeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeFeeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmCdeFeeCollection = DataRepository.AdmCdeFeeProvider.GetByFeeCodeItemId(transactionManager, entity.FeeCodeItemId);

				if (deep && entity.AdmCdeFeeCollection.Count > 0)
				{
					deepHandles.Add("AdmCdeFeeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmCdeFee>) DataRepository.AdmCdeFeeProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmCdeFeeCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.FeeStudCoursesItemCollection = DataRepository.FeeStudCoursesItemProvider.GetByFeeCodeItemId(transactionManager, entity.FeeCodeItemId);

				if (deep && entity.FeeStudCoursesItemCollection.Count > 0)
				{
					deepHandles.Add("FeeStudCoursesItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudCoursesItem>) DataRepository.FeeStudCoursesItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudCoursesItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeRefundCodeDtlCollectionGetByFeeCodeItemPnftId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeRefundCodeDtl>|FeeRefundCodeDtlCollectionGetByFeeCodeItemPnftId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeRefundCodeDtlCollectionGetByFeeCodeItemPnftId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeRefundCodeDtlCollectionGetByFeeCodeItemPnftId = DataRepository.FeeRefundCodeDtlProvider.GetByFeeCodeItemPnftId(transactionManager, entity.FeeCodeItemId);

				if (deep && entity.FeeRefundCodeDtlCollectionGetByFeeCodeItemPnftId.Count > 0)
				{
					deepHandles.Add("FeeRefundCodeDtlCollectionGetByFeeCodeItemPnftId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeRefundCodeDtl>) DataRepository.FeeRefundCodeDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeRefundCodeDtlCollectionGetByFeeCodeItemPnftId, deep, deepLoadType, childTypes, innerList }
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

				entity.FeeItemTrnsBlncCollection = DataRepository.FeeItemTrnsBlncProvider.GetByFeeCodeItemId(transactionManager, entity.FeeCodeItemId);

				if (deep && entity.FeeItemTrnsBlncCollection.Count > 0)
				{
					deepHandles.Add("FeeItemTrnsBlncCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeItemTrnsBlnc>) DataRepository.FeeItemTrnsBlncProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeItemTrnsBlncCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdPrintReqCollection = DataRepository.EdPrintReqProvider.GetByFeeCodeItemId(transactionManager, entity.FeeCodeItemId);

				if (deep && entity.EdPrintReqCollection.Count > 0)
				{
					deepHandles.Add("EdPrintReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdPrintReq>) DataRepository.EdPrintReqProvider.DeepLoad,
						new object[] { transactionManager, entity.EdPrintReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SpoSponsorFeeItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoSponsorFeeItem>|SpoSponsorFeeItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorFeeItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoSponsorFeeItemCollection = DataRepository.SpoSponsorFeeItemProvider.GetByFeeCodeItemId(transactionManager, entity.FeeCodeItemId);

				if (deep && entity.SpoSponsorFeeItemCollection.Count > 0)
				{
					deepHandles.Add("SpoSponsorFeeItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoSponsorFeeItem>) DataRepository.SpoSponsorFeeItemProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoSponsorFeeItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeFineCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeFine>|FeeFineCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeFineCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeFineCollection = DataRepository.FeeFineProvider.GetByFeeCodeItemId(transactionManager, entity.FeeCodeItemId);

				if (deep && entity.FeeFineCollection.Count > 0)
				{
					deepHandles.Add("FeeFineCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeFine>) DataRepository.FeeFineProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeFineCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudFeeItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudFeeItem>|FeeStudFeeItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudFeeItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudFeeItemCollection = DataRepository.FeeStudFeeItemProvider.GetByFeeCodeItemId(transactionManager, entity.FeeCodeItemId);

				if (deep && entity.FeeStudFeeItemCollection.Count > 0)
				{
					deepHandles.Add("FeeStudFeeItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudFeeItem>) DataRepository.FeeStudFeeItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudFeeItemCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.FeeStudDiscFeeItemCollection = DataRepository.FeeStudDiscFeeItemProvider.GetByFeeCodeItemId(transactionManager, entity.FeeCodeItemId);

				if (deep && entity.FeeStudDiscFeeItemCollection.Count > 0)
				{
					deepHandles.Add("FeeStudDiscFeeItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudDiscFeeItem>) DataRepository.FeeStudDiscFeeItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudDiscFeeItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeSemesterAgendaCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeSemesterAgenda>|FeeSemesterAgendaCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeSemesterAgendaCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeSemesterAgendaCollection = DataRepository.FeeSemesterAgendaProvider.GetByFeeCodeItemId(transactionManager, entity.FeeCodeItemId);

				if (deep && entity.FeeSemesterAgendaCollection.Count > 0)
				{
					deepHandles.Add("FeeSemesterAgendaCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeSemesterAgenda>) DataRepository.FeeSemesterAgendaProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeSemesterAgendaCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeRefundCodeDtlCollectionGetByFeeCodeItemRltId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeRefundCodeDtl>|FeeRefundCodeDtlCollectionGetByFeeCodeItemRltId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeRefundCodeDtlCollectionGetByFeeCodeItemRltId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeRefundCodeDtlCollectionGetByFeeCodeItemRltId = DataRepository.FeeRefundCodeDtlProvider.GetByFeeCodeItemRltId(transactionManager, entity.FeeCodeItemId);

				if (deep && entity.FeeRefundCodeDtlCollectionGetByFeeCodeItemRltId.Count > 0)
				{
					deepHandles.Add("FeeRefundCodeDtlCollectionGetByFeeCodeItemRltId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeRefundCodeDtl>) DataRepository.FeeRefundCodeDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeRefundCodeDtlCollectionGetByFeeCodeItemRltId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeFacultyItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeFacultyItem>|FeeFacultyItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeFacultyItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeFacultyItemCollection = DataRepository.FeeFacultyItemProvider.GetByFeeCodeItemId(transactionManager, entity.FeeCodeItemId);

				if (deep && entity.FeeFacultyItemCollection.Count > 0)
				{
					deepHandles.Add("FeeFacultyItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeFacultyItem>) DataRepository.FeeFacultyItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeFacultyItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeRefundCodeDtlCollectionGetByFeeCodeItemId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeRefundCodeDtl>|FeeRefundCodeDtlCollectionGetByFeeCodeItemId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeRefundCodeDtlCollectionGetByFeeCodeItemId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeRefundCodeDtlCollectionGetByFeeCodeItemId = DataRepository.FeeRefundCodeDtlProvider.GetByFeeCodeItemId(transactionManager, entity.FeeCodeItemId);

				if (deep && entity.FeeRefundCodeDtlCollectionGetByFeeCodeItemId.Count > 0)
				{
					deepHandles.Add("FeeRefundCodeDtlCollectionGetByFeeCodeItemId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeRefundCodeDtl>) DataRepository.FeeRefundCodeDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeRefundCodeDtlCollectionGetByFeeCodeItemId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudItemCnclCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudItemCncl>|FeeStudItemCnclCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudItemCnclCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudItemCnclCollection = DataRepository.FeeStudItemCnclProvider.GetByFeeCodeItemId(transactionManager, entity.FeeCodeItemId);

				if (deep && entity.FeeStudItemCnclCollection.Count > 0)
				{
					deepHandles.Add("FeeStudItemCnclCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudItemCncl>) DataRepository.FeeStudItemCnclProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudItemCnclCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.AccomStudReqCollection = DataRepository.AccomStudReqProvider.GetByFeeCodeItemId(transactionManager, entity.FeeCodeItemId);

				if (deep && entity.AccomStudReqCollection.Count > 0)
				{
					deepHandles.Add("AccomStudReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudReq>) DataRepository.AccomStudReqProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudDiscCodeItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudDiscCodeItem>|FeeStudDiscCodeItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudDiscCodeItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudDiscCodeItemCollection = DataRepository.FeeStudDiscCodeItemProvider.GetByFeeCodeItemId(transactionManager, entity.FeeCodeItemId);

				if (deep && entity.FeeStudDiscCodeItemCollection.Count > 0)
				{
					deepHandles.Add("FeeStudDiscCodeItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudDiscCodeItem>) DataRepository.FeeStudDiscCodeItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudDiscCodeItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeAccomItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeAccomItem>|FeeAccomItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeAccomItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeAccomItemCollection = DataRepository.FeeAccomItemProvider.GetByFeeCodeItemId(transactionManager, entity.FeeCodeItemId);

				if (deep && entity.FeeAccomItemCollection.Count > 0)
				{
					deepHandles.Add("FeeAccomItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeAccomItem>) DataRepository.FeeAccomItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeAccomItemCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeCodeItem object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeCodeItem instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeCodeItem Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCodeItem entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AsCodeDegreeIdSource
			if (CanDeepSave(entity, "AsCodeDegree|AsCodeDegreeIdSource", deepSaveType, innerList) 
				&& entity.AsCodeDegreeIdSource != null)
			{
				DataRepository.AsCodeDegreeProvider.Save(transactionManager, entity.AsCodeDegreeIdSource);
				entity.AsCodeDegreeId = entity.AsCodeDegreeIdSource.AsCodeDegreeId;
			}
			#endregion 
			
			#region AsCodeDegreeClassIdSource
			if (CanDeepSave(entity, "AsCodeDegreeClass|AsCodeDegreeClassIdSource", deepSaveType, innerList) 
				&& entity.AsCodeDegreeClassIdSource != null)
			{
				DataRepository.AsCodeDegreeClassProvider.Save(transactionManager, entity.AsCodeDegreeClassIdSource);
				entity.AsCodeDegreeClassId = entity.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
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
			
			#region FeeCodeTypeIdSource
			if (CanDeepSave(entity, "FeeCodeType|FeeCodeTypeIdSource", deepSaveType, innerList) 
				&& entity.FeeCodeTypeIdSource != null)
			{
				DataRepository.FeeCodeTypeProvider.Save(transactionManager, entity.FeeCodeTypeIdSource);
				entity.FeeCodeTypeId = entity.FeeCodeTypeIdSource.FeeCodeTypeId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<FeeBusLineItem>
				if (CanDeepSave(entity.FeeBusLineItemCollection, "List<FeeBusLineItem>|FeeBusLineItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeBusLineItem child in entity.FeeBusLineItemCollection)
					{
						if(child.FeeCodeItemIdSource != null)
						{
							child.FeeCodeItemId = child.FeeCodeItemIdSource.FeeCodeItemId;
						}
						else
						{
							child.FeeCodeItemId = entity.FeeCodeItemId;
						}

					}

					if (entity.FeeBusLineItemCollection.Count > 0 || entity.FeeBusLineItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeBusLineItemProvider.Save(transactionManager, entity.FeeBusLineItemCollection);
						
						deepHandles.Add("FeeBusLineItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeBusLineItem >) DataRepository.FeeBusLineItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeBusLineItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeItemSemester>
				if (CanDeepSave(entity.FeeItemSemesterCollection, "List<FeeItemSemester>|FeeItemSemesterCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeItemSemester child in entity.FeeItemSemesterCollection)
					{
						if(child.FeeCodeItemIdSource != null)
						{
							child.FeeCodeItemId = child.FeeCodeItemIdSource.FeeCodeItemId;
						}
						else
						{
							child.FeeCodeItemId = entity.FeeCodeItemId;
						}

					}

					if (entity.FeeItemSemesterCollection.Count > 0 || entity.FeeItemSemesterCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeItemSemesterProvider.Save(transactionManager, entity.FeeItemSemesterCollection);
						
						deepHandles.Add("FeeItemSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeItemSemester >) DataRepository.FeeItemSemesterProvider.DeepSave,
							new object[] { transactionManager, entity.FeeItemSemesterCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmCdeFee>
				if (CanDeepSave(entity.AdmCdeFeeCollection, "List<AdmCdeFee>|AdmCdeFeeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmCdeFee child in entity.AdmCdeFeeCollection)
					{
						if(child.FeeCodeItemIdSource != null)
						{
							child.FeeCodeItemId = child.FeeCodeItemIdSource.FeeCodeItemId;
						}
						else
						{
							child.FeeCodeItemId = entity.FeeCodeItemId;
						}

					}

					if (entity.AdmCdeFeeCollection.Count > 0 || entity.AdmCdeFeeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmCdeFeeProvider.Save(transactionManager, entity.AdmCdeFeeCollection);
						
						deepHandles.Add("AdmCdeFeeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmCdeFee >) DataRepository.AdmCdeFeeProvider.DeepSave,
							new object[] { transactionManager, entity.AdmCdeFeeCollection, deepSaveType, childTypes, innerList }
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
						if(child.FeeCodeItemIdSource != null)
						{
							child.FeeCodeItemId = child.FeeCodeItemIdSource.FeeCodeItemId;
						}
						else
						{
							child.FeeCodeItemId = entity.FeeCodeItemId;
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
				
	
			#region List<FeeRefundCodeDtl>
				if (CanDeepSave(entity.FeeRefundCodeDtlCollectionGetByFeeCodeItemPnftId, "List<FeeRefundCodeDtl>|FeeRefundCodeDtlCollectionGetByFeeCodeItemPnftId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeRefundCodeDtl child in entity.FeeRefundCodeDtlCollectionGetByFeeCodeItemPnftId)
					{
						if(child.FeeCodeItemPnftIdSource != null)
						{
							child.FeeCodeItemPnftId = child.FeeCodeItemPnftIdSource.FeeCodeItemId;
						}
						else
						{
							child.FeeCodeItemPnftId = entity.FeeCodeItemId;
						}

					}

					if (entity.FeeRefundCodeDtlCollectionGetByFeeCodeItemPnftId.Count > 0 || entity.FeeRefundCodeDtlCollectionGetByFeeCodeItemPnftId.DeletedItems.Count > 0)
					{
						//DataRepository.FeeRefundCodeDtlProvider.Save(transactionManager, entity.FeeRefundCodeDtlCollectionGetByFeeCodeItemPnftId);
						
						deepHandles.Add("FeeRefundCodeDtlCollectionGetByFeeCodeItemPnftId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeRefundCodeDtl >) DataRepository.FeeRefundCodeDtlProvider.DeepSave,
							new object[] { transactionManager, entity.FeeRefundCodeDtlCollectionGetByFeeCodeItemPnftId, deepSaveType, childTypes, innerList }
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
						if(child.FeeCodeItemIdSource != null)
						{
							child.FeeCodeItemId = child.FeeCodeItemIdSource.FeeCodeItemId;
						}
						else
						{
							child.FeeCodeItemId = entity.FeeCodeItemId;
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
				
	
			#region List<EdPrintReq>
				if (CanDeepSave(entity.EdPrintReqCollection, "List<EdPrintReq>|EdPrintReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdPrintReq child in entity.EdPrintReqCollection)
					{
						if(child.FeeCodeItemIdSource != null)
						{
							child.FeeCodeItemId = child.FeeCodeItemIdSource.FeeCodeItemId;
						}
						else
						{
							child.FeeCodeItemId = entity.FeeCodeItemId;
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
				
	
			#region List<SpoSponsorFeeItem>
				if (CanDeepSave(entity.SpoSponsorFeeItemCollection, "List<SpoSponsorFeeItem>|SpoSponsorFeeItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoSponsorFeeItem child in entity.SpoSponsorFeeItemCollection)
					{
						if(child.FeeCodeItemIdSource != null)
						{
							child.FeeCodeItemId = child.FeeCodeItemIdSource.FeeCodeItemId;
						}
						else
						{
							child.FeeCodeItemId = entity.FeeCodeItemId;
						}

					}

					if (entity.SpoSponsorFeeItemCollection.Count > 0 || entity.SpoSponsorFeeItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SpoSponsorFeeItemProvider.Save(transactionManager, entity.SpoSponsorFeeItemCollection);
						
						deepHandles.Add("SpoSponsorFeeItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoSponsorFeeItem >) DataRepository.SpoSponsorFeeItemProvider.DeepSave,
							new object[] { transactionManager, entity.SpoSponsorFeeItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeFine>
				if (CanDeepSave(entity.FeeFineCollection, "List<FeeFine>|FeeFineCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeFine child in entity.FeeFineCollection)
					{
						if(child.FeeCodeItemIdSource != null)
						{
							child.FeeCodeItemId = child.FeeCodeItemIdSource.FeeCodeItemId;
						}
						else
						{
							child.FeeCodeItemId = entity.FeeCodeItemId;
						}

					}

					if (entity.FeeFineCollection.Count > 0 || entity.FeeFineCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeFineProvider.Save(transactionManager, entity.FeeFineCollection);
						
						deepHandles.Add("FeeFineCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeFine >) DataRepository.FeeFineProvider.DeepSave,
							new object[] { transactionManager, entity.FeeFineCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudFeeItem>
				if (CanDeepSave(entity.FeeStudFeeItemCollection, "List<FeeStudFeeItem>|FeeStudFeeItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudFeeItem child in entity.FeeStudFeeItemCollection)
					{
						if(child.FeeCodeItemIdSource != null)
						{
							child.FeeCodeItemId = child.FeeCodeItemIdSource.FeeCodeItemId;
						}
						else
						{
							child.FeeCodeItemId = entity.FeeCodeItemId;
						}

					}

					if (entity.FeeStudFeeItemCollection.Count > 0 || entity.FeeStudFeeItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudFeeItemProvider.Save(transactionManager, entity.FeeStudFeeItemCollection);
						
						deepHandles.Add("FeeStudFeeItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudFeeItem >) DataRepository.FeeStudFeeItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudFeeItemCollection, deepSaveType, childTypes, innerList }
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
						if(child.FeeCodeItemIdSource != null)
						{
							child.FeeCodeItemId = child.FeeCodeItemIdSource.FeeCodeItemId;
						}
						else
						{
							child.FeeCodeItemId = entity.FeeCodeItemId;
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
				
	
			#region List<FeeSemesterAgenda>
				if (CanDeepSave(entity.FeeSemesterAgendaCollection, "List<FeeSemesterAgenda>|FeeSemesterAgendaCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeSemesterAgenda child in entity.FeeSemesterAgendaCollection)
					{
						if(child.FeeCodeItemIdSource != null)
						{
							child.FeeCodeItemId = child.FeeCodeItemIdSource.FeeCodeItemId;
						}
						else
						{
							child.FeeCodeItemId = entity.FeeCodeItemId;
						}

					}

					if (entity.FeeSemesterAgendaCollection.Count > 0 || entity.FeeSemesterAgendaCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeSemesterAgendaProvider.Save(transactionManager, entity.FeeSemesterAgendaCollection);
						
						deepHandles.Add("FeeSemesterAgendaCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeSemesterAgenda >) DataRepository.FeeSemesterAgendaProvider.DeepSave,
							new object[] { transactionManager, entity.FeeSemesterAgendaCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeRefundCodeDtl>
				if (CanDeepSave(entity.FeeRefundCodeDtlCollectionGetByFeeCodeItemRltId, "List<FeeRefundCodeDtl>|FeeRefundCodeDtlCollectionGetByFeeCodeItemRltId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeRefundCodeDtl child in entity.FeeRefundCodeDtlCollectionGetByFeeCodeItemRltId)
					{
						if(child.FeeCodeItemRltIdSource != null)
						{
							child.FeeCodeItemRltId = child.FeeCodeItemRltIdSource.FeeCodeItemId;
						}
						else
						{
							child.FeeCodeItemRltId = entity.FeeCodeItemId;
						}

					}

					if (entity.FeeRefundCodeDtlCollectionGetByFeeCodeItemRltId.Count > 0 || entity.FeeRefundCodeDtlCollectionGetByFeeCodeItemRltId.DeletedItems.Count > 0)
					{
						//DataRepository.FeeRefundCodeDtlProvider.Save(transactionManager, entity.FeeRefundCodeDtlCollectionGetByFeeCodeItemRltId);
						
						deepHandles.Add("FeeRefundCodeDtlCollectionGetByFeeCodeItemRltId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeRefundCodeDtl >) DataRepository.FeeRefundCodeDtlProvider.DeepSave,
							new object[] { transactionManager, entity.FeeRefundCodeDtlCollectionGetByFeeCodeItemRltId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeFacultyItem>
				if (CanDeepSave(entity.FeeFacultyItemCollection, "List<FeeFacultyItem>|FeeFacultyItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeFacultyItem child in entity.FeeFacultyItemCollection)
					{
						if(child.FeeCodeItemIdSource != null)
						{
							child.FeeCodeItemId = child.FeeCodeItemIdSource.FeeCodeItemId;
						}
						else
						{
							child.FeeCodeItemId = entity.FeeCodeItemId;
						}

					}

					if (entity.FeeFacultyItemCollection.Count > 0 || entity.FeeFacultyItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeFacultyItemProvider.Save(transactionManager, entity.FeeFacultyItemCollection);
						
						deepHandles.Add("FeeFacultyItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeFacultyItem >) DataRepository.FeeFacultyItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeFacultyItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeRefundCodeDtl>
				if (CanDeepSave(entity.FeeRefundCodeDtlCollectionGetByFeeCodeItemId, "List<FeeRefundCodeDtl>|FeeRefundCodeDtlCollectionGetByFeeCodeItemId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeRefundCodeDtl child in entity.FeeRefundCodeDtlCollectionGetByFeeCodeItemId)
					{
						if(child.FeeCodeItemIdSource != null)
						{
							child.FeeCodeItemId = child.FeeCodeItemIdSource.FeeCodeItemId;
						}
						else
						{
							child.FeeCodeItemId = entity.FeeCodeItemId;
						}

					}

					if (entity.FeeRefundCodeDtlCollectionGetByFeeCodeItemId.Count > 0 || entity.FeeRefundCodeDtlCollectionGetByFeeCodeItemId.DeletedItems.Count > 0)
					{
						//DataRepository.FeeRefundCodeDtlProvider.Save(transactionManager, entity.FeeRefundCodeDtlCollectionGetByFeeCodeItemId);
						
						deepHandles.Add("FeeRefundCodeDtlCollectionGetByFeeCodeItemId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeRefundCodeDtl >) DataRepository.FeeRefundCodeDtlProvider.DeepSave,
							new object[] { transactionManager, entity.FeeRefundCodeDtlCollectionGetByFeeCodeItemId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudItemCncl>
				if (CanDeepSave(entity.FeeStudItemCnclCollection, "List<FeeStudItemCncl>|FeeStudItemCnclCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudItemCncl child in entity.FeeStudItemCnclCollection)
					{
						if(child.FeeCodeItemIdSource != null)
						{
							child.FeeCodeItemId = child.FeeCodeItemIdSource.FeeCodeItemId;
						}
						else
						{
							child.FeeCodeItemId = entity.FeeCodeItemId;
						}

					}

					if (entity.FeeStudItemCnclCollection.Count > 0 || entity.FeeStudItemCnclCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudItemCnclProvider.Save(transactionManager, entity.FeeStudItemCnclCollection);
						
						deepHandles.Add("FeeStudItemCnclCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudItemCncl >) DataRepository.FeeStudItemCnclProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudItemCnclCollection, deepSaveType, childTypes, innerList }
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
						if(child.FeeCodeItemIdSource != null)
						{
							child.FeeCodeItemId = child.FeeCodeItemIdSource.FeeCodeItemId;
						}
						else
						{
							child.FeeCodeItemId = entity.FeeCodeItemId;
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
				
	
			#region List<FeeStudDiscCodeItem>
				if (CanDeepSave(entity.FeeStudDiscCodeItemCollection, "List<FeeStudDiscCodeItem>|FeeStudDiscCodeItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudDiscCodeItem child in entity.FeeStudDiscCodeItemCollection)
					{
						if(child.FeeCodeItemIdSource != null)
						{
							child.FeeCodeItemId = child.FeeCodeItemIdSource.FeeCodeItemId;
						}
						else
						{
							child.FeeCodeItemId = entity.FeeCodeItemId;
						}

					}

					if (entity.FeeStudDiscCodeItemCollection.Count > 0 || entity.FeeStudDiscCodeItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudDiscCodeItemProvider.Save(transactionManager, entity.FeeStudDiscCodeItemCollection);
						
						deepHandles.Add("FeeStudDiscCodeItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudDiscCodeItem >) DataRepository.FeeStudDiscCodeItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudDiscCodeItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeAccomItem>
				if (CanDeepSave(entity.FeeAccomItemCollection, "List<FeeAccomItem>|FeeAccomItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeAccomItem child in entity.FeeAccomItemCollection)
					{
						if(child.FeeCodeItemIdSource != null)
						{
							child.FeeCodeItemId = child.FeeCodeItemIdSource.FeeCodeItemId;
						}
						else
						{
							child.FeeCodeItemId = entity.FeeCodeItemId;
						}

					}

					if (entity.FeeAccomItemCollection.Count > 0 || entity.FeeAccomItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeAccomItemProvider.Save(transactionManager, entity.FeeAccomItemCollection);
						
						deepHandles.Add("FeeAccomItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeAccomItem >) DataRepository.FeeAccomItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeAccomItemCollection, deepSaveType, childTypes, innerList }
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
	
	#region FeeCodeItemChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeCodeItem</c>
	///</summary>
	public enum FeeCodeItemChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsCodeDegree</c> at AsCodeDegreeIdSource
		///</summary>
		[ChildEntityType(typeof(AsCodeDegree))]
		AsCodeDegree,
		
		///<summary>
		/// Composite Property for <c>AsCodeDegreeClass</c> at AsCodeDegreeClassIdSource
		///</summary>
		[ChildEntityType(typeof(AsCodeDegreeClass))]
		AsCodeDegreeClass,
		
		///<summary>
		/// Composite Property for <c>EdCodeSemester</c> at EdCodeSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemester))]
		EdCodeSemester,
		
		///<summary>
		/// Composite Property for <c>FeeCodeType</c> at FeeCodeTypeIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCodeType))]
		FeeCodeType,
		///<summary>
		/// Collection of <c>FeeCodeItem</c> as OneToMany for FeeBusLineItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeBusLineItem>))]
		FeeBusLineItemCollection,
		///<summary>
		/// Collection of <c>FeeCodeItem</c> as OneToMany for FeeItemSemesterCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeItemSemester>))]
		FeeItemSemesterCollection,
		///<summary>
		/// Collection of <c>FeeCodeItem</c> as OneToMany for AdmCdeFeeCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmCdeFee>))]
		AdmCdeFeeCollection,
		///<summary>
		/// Collection of <c>FeeCodeItem</c> as OneToMany for FeeStudCoursesItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudCoursesItem>))]
		FeeStudCoursesItemCollection,
		///<summary>
		/// Collection of <c>FeeCodeItem</c> as OneToMany for FeeRefundCodeDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeRefundCodeDtl>))]
		FeeRefundCodeDtlCollectionGetByFeeCodeItemPnftId,
		///<summary>
		/// Collection of <c>FeeCodeItem</c> as OneToMany for FeeItemTrnsBlncCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeItemTrnsBlnc>))]
		FeeItemTrnsBlncCollection,
		///<summary>
		/// Collection of <c>FeeCodeItem</c> as OneToMany for EdPrintReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdPrintReq>))]
		EdPrintReqCollection,
		///<summary>
		/// Collection of <c>FeeCodeItem</c> as OneToMany for SpoSponsorFeeItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoSponsorFeeItem>))]
		SpoSponsorFeeItemCollection,
		///<summary>
		/// Collection of <c>FeeCodeItem</c> as OneToMany for FeeFineCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeFine>))]
		FeeFineCollection,
		///<summary>
		/// Collection of <c>FeeCodeItem</c> as OneToMany for FeeStudFeeItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudFeeItem>))]
		FeeStudFeeItemCollection,
		///<summary>
		/// Collection of <c>FeeCodeItem</c> as OneToMany for FeeStudDiscFeeItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudDiscFeeItem>))]
		FeeStudDiscFeeItemCollection,
		///<summary>
		/// Collection of <c>FeeCodeItem</c> as OneToMany for FeeSemesterAgendaCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeSemesterAgenda>))]
		FeeSemesterAgendaCollection,
		///<summary>
		/// Collection of <c>FeeCodeItem</c> as OneToMany for FeeRefundCodeDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeRefundCodeDtl>))]
		FeeRefundCodeDtlCollectionGetByFeeCodeItemRltId,
		///<summary>
		/// Collection of <c>FeeCodeItem</c> as OneToMany for FeeFacultyItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeFacultyItem>))]
		FeeFacultyItemCollection,
		///<summary>
		/// Collection of <c>FeeCodeItem</c> as OneToMany for FeeRefundCodeDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeRefundCodeDtl>))]
		FeeRefundCodeDtlCollectionGetByFeeCodeItemId,
		///<summary>
		/// Collection of <c>FeeCodeItem</c> as OneToMany for FeeStudItemCnclCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudItemCncl>))]
		FeeStudItemCnclCollection,
		///<summary>
		/// Collection of <c>FeeCodeItem</c> as OneToMany for AccomStudReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudReq>))]
		AccomStudReqCollection,
		///<summary>
		/// Collection of <c>FeeCodeItem</c> as OneToMany for FeeStudDiscCodeItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudDiscCodeItem>))]
		FeeStudDiscCodeItemCollection,
		///<summary>
		/// Collection of <c>FeeCodeItem</c> as OneToMany for FeeAccomItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeAccomItem>))]
		FeeAccomItemCollection,
	}
	
	#endregion FeeCodeItemChildEntityTypes
	
	#region FeeCodeItemFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeCodeItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCodeItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeCodeItemFilterBuilder : SqlFilterBuilder<FeeCodeItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCodeItemFilterBuilder class.
		/// </summary>
		public FeeCodeItemFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeCodeItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeCodeItemFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeCodeItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeCodeItemFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeCodeItemFilterBuilder
	
	#region FeeCodeItemParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeCodeItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCodeItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeCodeItemParameterBuilder : ParameterizedSqlFilterBuilder<FeeCodeItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCodeItemParameterBuilder class.
		/// </summary>
		public FeeCodeItemParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeCodeItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeCodeItemParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeCodeItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeCodeItemParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeCodeItemParameterBuilder
	
	#region FeeCodeItemSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeCodeItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCodeItem"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeCodeItemSortBuilder : SqlSortBuilder<FeeCodeItemColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCodeItemSqlSortBuilder class.
		/// </summary>
		public FeeCodeItemSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeCodeItemSortBuilder
	
} // end namespace
