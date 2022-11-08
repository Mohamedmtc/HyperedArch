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
	/// This class is the base class for any <see cref="AdmCdeFeeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmCdeFeeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmCdeFee, UMIS_VER2.BusinessLyer.AdmCdeFeeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeFeeKey key)
		{
			return Delete(transactionManager, key.AdmCdeFeeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admCdeFeeId">لائحة بنود مصروفات القبول. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admCdeFeeId)
		{
			return Delete(null, _admCdeFeeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeFeeId">لائحة بنود مصروفات القبول. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admCdeFeeId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_FEE_ADM_CDE_PLACEMENT_EXAM key.
		///		FK_ADM_CDE_FEE_ADM_CDE_PLACEMENT_EXAM Description: 
		/// </summary>
		/// <param name="_admCdePlacementExamId">NU</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeFee objects.</returns>
		public TList<AdmCdeFee> GetByAdmCdePlacementExamId(System.Decimal? _admCdePlacementExamId)
		{
			int count = -1;
			return GetByAdmCdePlacementExamId(_admCdePlacementExamId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_FEE_ADM_CDE_PLACEMENT_EXAM key.
		///		FK_ADM_CDE_FEE_ADM_CDE_PLACEMENT_EXAM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdePlacementExamId">NU</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeFee objects.</returns>
		/// <remarks></remarks>
		public TList<AdmCdeFee> GetByAdmCdePlacementExamId(TransactionManager transactionManager, System.Decimal? _admCdePlacementExamId)
		{
			int count = -1;
			return GetByAdmCdePlacementExamId(transactionManager, _admCdePlacementExamId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_FEE_ADM_CDE_PLACEMENT_EXAM key.
		///		FK_ADM_CDE_FEE_ADM_CDE_PLACEMENT_EXAM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdePlacementExamId">NU</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeFee objects.</returns>
		public TList<AdmCdeFee> GetByAdmCdePlacementExamId(TransactionManager transactionManager, System.Decimal? _admCdePlacementExamId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdePlacementExamId(transactionManager, _admCdePlacementExamId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_FEE_ADM_CDE_PLACEMENT_EXAM key.
		///		fkAdmCdeFeeAdmCdePlacementExam Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdePlacementExamId">NU</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeFee objects.</returns>
		public TList<AdmCdeFee> GetByAdmCdePlacementExamId(System.Decimal? _admCdePlacementExamId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCdePlacementExamId(null, _admCdePlacementExamId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_FEE_ADM_CDE_PLACEMENT_EXAM key.
		///		fkAdmCdeFeeAdmCdePlacementExam Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdePlacementExamId">NU</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeFee objects.</returns>
		public TList<AdmCdeFee> GetByAdmCdePlacementExamId(System.Decimal? _admCdePlacementExamId, int start, int pageLength,out int count)
		{
			return GetByAdmCdePlacementExamId(null, _admCdePlacementExamId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_FEE_ADM_CDE_PLACEMENT_EXAM key.
		///		FK_ADM_CDE_FEE_ADM_CDE_PLACEMENT_EXAM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdePlacementExamId">NU</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeFee objects.</returns>
		public abstract TList<AdmCdeFee> GetByAdmCdePlacementExamId(TransactionManager transactionManager, System.Decimal? _admCdePlacementExamId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_FEE_AS_CODE_DEGREE key.
		///		FK_ADM_CDE_FEE_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="_asCodeDegreeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeFee objects.</returns>
		public TList<AdmCdeFee> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(_asCodeDegreeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_FEE_AS_CODE_DEGREE key.
		///		FK_ADM_CDE_FEE_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeFee objects.</returns>
		/// <remarks></remarks>
		public TList<AdmCdeFee> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_FEE_AS_CODE_DEGREE key.
		///		FK_ADM_CDE_FEE_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeFee objects.</returns>
		public TList<AdmCdeFee> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_FEE_AS_CODE_DEGREE key.
		///		fkAdmCdeFeeAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeFee objects.</returns>
		public TList<AdmCdeFee> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_FEE_AS_CODE_DEGREE key.
		///		fkAdmCdeFeeAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeFee objects.</returns>
		public TList<AdmCdeFee> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_FEE_AS_CODE_DEGREE key.
		///		FK_ADM_CDE_FEE_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeFee objects.</returns>
		public abstract TList<AdmCdeFee> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_FEE_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_CDE_FEE_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeFee objects.</returns>
		public TList<AdmCdeFee> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(_asCodeDegreeClassId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_FEE_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_CDE_FEE_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeFee objects.</returns>
		/// <remarks></remarks>
		public TList<AdmCdeFee> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_FEE_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_CDE_FEE_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeFee objects.</returns>
		public TList<AdmCdeFee> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_FEE_AS_CODE_DEGREE_CLASS key.
		///		fkAdmCdeFeeAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeFee objects.</returns>
		public TList<AdmCdeFee> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_FEE_AS_CODE_DEGREE_CLASS key.
		///		fkAdmCdeFeeAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeFee objects.</returns>
		public TList<AdmCdeFee> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_FEE_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_CDE_FEE_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeFee objects.</returns>
		public abstract TList<AdmCdeFee> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_FEE_FEE_CODE_ITEM key.
		///		FK_ADM_CDE_FEE_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="_feeCodeItemId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeFee objects.</returns>
		public TList<AdmCdeFee> GetByFeeCodeItemId(System.Decimal? _feeCodeItemId)
		{
			int count = -1;
			return GetByFeeCodeItemId(_feeCodeItemId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_FEE_FEE_CODE_ITEM key.
		///		FK_ADM_CDE_FEE_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeFee objects.</returns>
		/// <remarks></remarks>
		public TList<AdmCdeFee> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal? _feeCodeItemId)
		{
			int count = -1;
			return GetByFeeCodeItemId(transactionManager, _feeCodeItemId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_FEE_FEE_CODE_ITEM key.
		///		FK_ADM_CDE_FEE_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeFee objects.</returns>
		public TList<AdmCdeFee> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal? _feeCodeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeItemId(transactionManager, _feeCodeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_FEE_FEE_CODE_ITEM key.
		///		fkAdmCdeFeeFeeCodeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeItemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeFee objects.</returns>
		public TList<AdmCdeFee> GetByFeeCodeItemId(System.Decimal? _feeCodeItemId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCodeItemId(null, _feeCodeItemId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_FEE_FEE_CODE_ITEM key.
		///		fkAdmCdeFeeFeeCodeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeItemId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeFee objects.</returns>
		public TList<AdmCdeFee> GetByFeeCodeItemId(System.Decimal? _feeCodeItemId, int start, int pageLength,out int count)
		{
			return GetByFeeCodeItemId(null, _feeCodeItemId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_FEE_FEE_CODE_ITEM key.
		///		FK_ADM_CDE_FEE_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeFee objects.</returns>
		public abstract TList<AdmCdeFee> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal? _feeCodeItemId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmCdeFee Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeFeeKey key, int start, int pageLength)
		{
			return GetByAdmCdeFeeId(transactionManager, key.AdmCdeFeeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmCdeFee&gt;"/> class.</returns>
		public TList<AdmCdeFee> GetByEntMainId(System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(null,_entMainId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmCdeFee&gt;"/> class.</returns>
		public TList<AdmCdeFee> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmCdeFee&gt;"/> class.</returns>
		public TList<AdmCdeFee> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmCdeFee&gt;"/> class.</returns>
		public TList<AdmCdeFee> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmCdeFee&gt;"/> class.</returns>
		public TList<AdmCdeFee> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength, out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmCdeFee&gt;"/> class.</returns>
		public abstract TList<AdmCdeFee> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_CODE_CURRENCY_ID_1 index.
		/// </summary>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmCdeFee&gt;"/> class.</returns>
		public TList<AdmCdeFee> GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(null,_gsCodeCurrencyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_CURRENCY_ID_1 index.
		/// </summary>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmCdeFee&gt;"/> class.</returns>
		public TList<AdmCdeFee> GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(null, _gsCodeCurrencyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_CURRENCY_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmCdeFee&gt;"/> class.</returns>
		public TList<AdmCdeFee> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(transactionManager, _gsCodeCurrencyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_CURRENCY_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmCdeFee&gt;"/> class.</returns>
		public TList<AdmCdeFee> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(transactionManager, _gsCodeCurrencyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_CURRENCY_ID_1 index.
		/// </summary>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmCdeFee&gt;"/> class.</returns>
		public TList<AdmCdeFee> GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId, int start, int pageLength, out int count)
		{
			return GetByGsCodeCurrencyId(null, _gsCodeCurrencyId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_CURRENCY_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmCdeFee&gt;"/> class.</returns>
		public abstract TList<AdmCdeFee> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_CDE_FEE index.
		/// </summary>
		/// <param name="_admCdeFeeId">لائحة بنود مصروفات القبول</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeFee"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeFee GetByAdmCdeFeeId(System.Decimal _admCdeFeeId)
		{
			int count = -1;
			return GetByAdmCdeFeeId(null,_admCdeFeeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_FEE index.
		/// </summary>
		/// <param name="_admCdeFeeId">لائحة بنود مصروفات القبول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeFee"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeFee GetByAdmCdeFeeId(System.Decimal _admCdeFeeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeFeeId(null, _admCdeFeeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_FEE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeFeeId">لائحة بنود مصروفات القبول</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeFee"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeFee GetByAdmCdeFeeId(TransactionManager transactionManager, System.Decimal _admCdeFeeId)
		{
			int count = -1;
			return GetByAdmCdeFeeId(transactionManager, _admCdeFeeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_FEE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeFeeId">لائحة بنود مصروفات القبول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeFee"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeFee GetByAdmCdeFeeId(TransactionManager transactionManager, System.Decimal _admCdeFeeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeFeeId(transactionManager, _admCdeFeeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_FEE index.
		/// </summary>
		/// <param name="_admCdeFeeId">لائحة بنود مصروفات القبول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeFee"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeFee GetByAdmCdeFeeId(System.Decimal _admCdeFeeId, int start, int pageLength, out int count)
		{
			return GetByAdmCdeFeeId(null, _admCdeFeeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_FEE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeFeeId">لائحة بنود مصروفات القبول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeFee"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmCdeFee GetByAdmCdeFeeId(TransactionManager transactionManager, System.Decimal _admCdeFeeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ADM_CDE_FEE index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <param name="_descrEn">auto load from fee_code_item</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="_nationalityFlg">FOREIGN_FLG
		/// 		/// 0 مواطن
		/// 		/// 2 وافد
		/// 		/// 3 الكل
		/// 		/// 
		/// 		/// 
		/// 		/// مواطن >> 0
		/// 		/// 
		/// 		/// خليجي >> 1
		/// 		/// 
		/// 		/// وافد>> 2
		/// 		/// 
		/// 		/// الكل >> 3</param>
		/// <param name="_transAppFlg"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeFee"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeFee GetByEntMainIdDescrEnAsCodeDegreeClassIdAsCodeDegreeIdNationalityFlgTransAppFlg(System.Decimal _entMainId, System.String _descrEn, System.Decimal? _asCodeDegreeClassId, System.Decimal? _asCodeDegreeId, System.Decimal _nationalityFlg, System.Decimal _transAppFlg)
		{
			int count = -1;
			return GetByEntMainIdDescrEnAsCodeDegreeClassIdAsCodeDegreeIdNationalityFlgTransAppFlg(null,_entMainId, _descrEn, _asCodeDegreeClassId, _asCodeDegreeId, _nationalityFlg, _transAppFlg, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_CDE_FEE index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <param name="_descrEn">auto load from fee_code_item</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="_nationalityFlg">FOREIGN_FLG
		/// 		/// 0 مواطن
		/// 		/// 2 وافد
		/// 		/// 3 الكل
		/// 		/// 
		/// 		/// 
		/// 		/// مواطن >> 0
		/// 		/// 
		/// 		/// خليجي >> 1
		/// 		/// 
		/// 		/// وافد>> 2
		/// 		/// 
		/// 		/// الكل >> 3</param>
		/// <param name="_transAppFlg"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeFee"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeFee GetByEntMainIdDescrEnAsCodeDegreeClassIdAsCodeDegreeIdNationalityFlgTransAppFlg(System.Decimal _entMainId, System.String _descrEn, System.Decimal? _asCodeDegreeClassId, System.Decimal? _asCodeDegreeId, System.Decimal _nationalityFlg, System.Decimal _transAppFlg, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainIdDescrEnAsCodeDegreeClassIdAsCodeDegreeIdNationalityFlgTransAppFlg(null, _entMainId, _descrEn, _asCodeDegreeClassId, _asCodeDegreeId, _nationalityFlg, _transAppFlg, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_CDE_FEE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="_descrEn">auto load from fee_code_item</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="_nationalityFlg">FOREIGN_FLG
		/// 		/// 0 مواطن
		/// 		/// 2 وافد
		/// 		/// 3 الكل
		/// 		/// 
		/// 		/// 
		/// 		/// مواطن >> 0
		/// 		/// 
		/// 		/// خليجي >> 1
		/// 		/// 
		/// 		/// وافد>> 2
		/// 		/// 
		/// 		/// الكل >> 3</param>
		/// <param name="_transAppFlg"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeFee"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeFee GetByEntMainIdDescrEnAsCodeDegreeClassIdAsCodeDegreeIdNationalityFlgTransAppFlg(TransactionManager transactionManager, System.Decimal _entMainId, System.String _descrEn, System.Decimal? _asCodeDegreeClassId, System.Decimal? _asCodeDegreeId, System.Decimal _nationalityFlg, System.Decimal _transAppFlg)
		{
			int count = -1;
			return GetByEntMainIdDescrEnAsCodeDegreeClassIdAsCodeDegreeIdNationalityFlgTransAppFlg(transactionManager, _entMainId, _descrEn, _asCodeDegreeClassId, _asCodeDegreeId, _nationalityFlg, _transAppFlg, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_CDE_FEE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="_descrEn">auto load from fee_code_item</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="_nationalityFlg">FOREIGN_FLG
		/// 		/// 0 مواطن
		/// 		/// 2 وافد
		/// 		/// 3 الكل
		/// 		/// 
		/// 		/// 
		/// 		/// مواطن >> 0
		/// 		/// 
		/// 		/// خليجي >> 1
		/// 		/// 
		/// 		/// وافد>> 2
		/// 		/// 
		/// 		/// الكل >> 3</param>
		/// <param name="_transAppFlg"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeFee"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeFee GetByEntMainIdDescrEnAsCodeDegreeClassIdAsCodeDegreeIdNationalityFlgTransAppFlg(TransactionManager transactionManager, System.Decimal _entMainId, System.String _descrEn, System.Decimal? _asCodeDegreeClassId, System.Decimal? _asCodeDegreeId, System.Decimal _nationalityFlg, System.Decimal _transAppFlg, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainIdDescrEnAsCodeDegreeClassIdAsCodeDegreeIdNationalityFlgTransAppFlg(transactionManager, _entMainId, _descrEn, _asCodeDegreeClassId, _asCodeDegreeId, _nationalityFlg, _transAppFlg, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_CDE_FEE index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <param name="_descrEn">auto load from fee_code_item</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="_nationalityFlg">FOREIGN_FLG
		/// 		/// 0 مواطن
		/// 		/// 2 وافد
		/// 		/// 3 الكل
		/// 		/// 
		/// 		/// 
		/// 		/// مواطن >> 0
		/// 		/// 
		/// 		/// خليجي >> 1
		/// 		/// 
		/// 		/// وافد>> 2
		/// 		/// 
		/// 		/// الكل >> 3</param>
		/// <param name="_transAppFlg"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeFee"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeFee GetByEntMainIdDescrEnAsCodeDegreeClassIdAsCodeDegreeIdNationalityFlgTransAppFlg(System.Decimal _entMainId, System.String _descrEn, System.Decimal? _asCodeDegreeClassId, System.Decimal? _asCodeDegreeId, System.Decimal _nationalityFlg, System.Decimal _transAppFlg, int start, int pageLength, out int count)
		{
			return GetByEntMainIdDescrEnAsCodeDegreeClassIdAsCodeDegreeIdNationalityFlgTransAppFlg(null, _entMainId, _descrEn, _asCodeDegreeClassId, _asCodeDegreeId, _nationalityFlg, _transAppFlg, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_CDE_FEE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="_descrEn">auto load from fee_code_item</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="_nationalityFlg">FOREIGN_FLG
		/// 		/// 0 مواطن
		/// 		/// 2 وافد
		/// 		/// 3 الكل
		/// 		/// 
		/// 		/// 
		/// 		/// مواطن >> 0
		/// 		/// 
		/// 		/// خليجي >> 1
		/// 		/// 
		/// 		/// وافد>> 2
		/// 		/// 
		/// 		/// الكل >> 3</param>
		/// <param name="_transAppFlg"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeFee"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmCdeFee GetByEntMainIdDescrEnAsCodeDegreeClassIdAsCodeDegreeIdNationalityFlgTransAppFlg(TransactionManager transactionManager, System.Decimal _entMainId, System.String _descrEn, System.Decimal? _asCodeDegreeClassId, System.Decimal? _asCodeDegreeId, System.Decimal _nationalityFlg, System.Decimal _transAppFlg, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmCdeFee&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmCdeFee&gt;"/></returns>
		public static TList<AdmCdeFee> Fill(IDataReader reader, TList<AdmCdeFee> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmCdeFee c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmCdeFee")
					.Append("|").Append((System.Decimal)reader["ADM_CDE_FEE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmCdeFee>(
					key.ToString(), // EntityTrackingKey
					"AdmCdeFee",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmCdeFee();
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
					c.AdmCdeFeeId = (System.Decimal)reader["ADM_CDE_FEE_ID"];
					c.OriginalAdmCdeFeeId = c.AdmCdeFeeId;
					c.EntMainId = (System.Decimal)reader["ENT_MAIN_ID"];
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = (System.String)reader["DESCR_EN"];
					c.Amount = (System.Decimal)reader["AMOUNT"];
					c.NationalityFlg = (System.Decimal)reader["NATIONALITY_FLG"];
					c.GsCodeCurrencyId = (System.Decimal)reader["GS_CODE_CURRENCY_ID"];
					c.AutoloadFlg = (System.Decimal)reader["AUTOLOAD_FLG"];
					c.TransAppFlg = (System.Decimal)reader["TRANS_APP_FLG"];
					c.AsCodeDegreeId = Convert.IsDBNull(reader["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_ID"];
					c.AsCodeDegreeClassId = Convert.IsDBNull(reader["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_CLASS_ID"];
					c.DelFlg = Convert.IsDBNull(reader["DEL_FLG"]) ? null : (System.Decimal?)reader["DEL_FLG"];
					c.AdmCdePlacementExamId = Convert.IsDBNull(reader["ADM_CDE_PLACEMENT_EXAM_ID"]) ? null : (System.Decimal?)reader["ADM_CDE_PLACEMENT_EXAM_ID"];
					c.RefundFlg = Convert.IsDBNull(reader["REFUND_FLG"]) ? null : (System.Boolean?)reader["REFUND_FLG"];
					c.FeeCodeItemId = Convert.IsDBNull(reader["FEE_CODE_ITEM_ID"]) ? null : (System.Decimal?)reader["FEE_CODE_ITEM_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmCdeFee"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCdeFee"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmCdeFee entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmCdeFeeId = (System.Decimal)reader[((int)AdmCdeFeeColumn.AdmCdeFeeId - 1)];
			entity.OriginalAdmCdeFeeId = (System.Decimal)reader["ADM_CDE_FEE_ID"];
			entity.EntMainId = (System.Decimal)reader[((int)AdmCdeFeeColumn.EntMainId - 1)];
			entity.DescrAr = (System.String)reader[((int)AdmCdeFeeColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)AdmCdeFeeColumn.DescrEn - 1)];
			entity.Amount = (System.Decimal)reader[((int)AdmCdeFeeColumn.Amount - 1)];
			entity.NationalityFlg = (System.Decimal)reader[((int)AdmCdeFeeColumn.NationalityFlg - 1)];
			entity.GsCodeCurrencyId = (System.Decimal)reader[((int)AdmCdeFeeColumn.GsCodeCurrencyId - 1)];
			entity.AutoloadFlg = (System.Decimal)reader[((int)AdmCdeFeeColumn.AutoloadFlg - 1)];
			entity.TransAppFlg = (System.Decimal)reader[((int)AdmCdeFeeColumn.TransAppFlg - 1)];
			entity.AsCodeDegreeId = (reader.IsDBNull(((int)AdmCdeFeeColumn.AsCodeDegreeId - 1)))?null:(System.Decimal?)reader[((int)AdmCdeFeeColumn.AsCodeDegreeId - 1)];
			entity.AsCodeDegreeClassId = (reader.IsDBNull(((int)AdmCdeFeeColumn.AsCodeDegreeClassId - 1)))?null:(System.Decimal?)reader[((int)AdmCdeFeeColumn.AsCodeDegreeClassId - 1)];
			entity.DelFlg = (reader.IsDBNull(((int)AdmCdeFeeColumn.DelFlg - 1)))?null:(System.Decimal?)reader[((int)AdmCdeFeeColumn.DelFlg - 1)];
			entity.AdmCdePlacementExamId = (reader.IsDBNull(((int)AdmCdeFeeColumn.AdmCdePlacementExamId - 1)))?null:(System.Decimal?)reader[((int)AdmCdeFeeColumn.AdmCdePlacementExamId - 1)];
			entity.RefundFlg = (reader.IsDBNull(((int)AdmCdeFeeColumn.RefundFlg - 1)))?null:(System.Boolean?)reader[((int)AdmCdeFeeColumn.RefundFlg - 1)];
			entity.FeeCodeItemId = (reader.IsDBNull(((int)AdmCdeFeeColumn.FeeCodeItemId - 1)))?null:(System.Decimal?)reader[((int)AdmCdeFeeColumn.FeeCodeItemId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AdmCdeFeeColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AdmCdeFeeColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AdmCdeFeeColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AdmCdeFeeColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmCdeFee"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCdeFee"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmCdeFee entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmCdeFeeId = (System.Decimal)dataRow["ADM_CDE_FEE_ID"];
			entity.OriginalAdmCdeFeeId = (System.Decimal)dataRow["ADM_CDE_FEE_ID"];
			entity.EntMainId = (System.Decimal)dataRow["ENT_MAIN_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = (System.String)dataRow["DESCR_EN"];
			entity.Amount = (System.Decimal)dataRow["AMOUNT"];
			entity.NationalityFlg = (System.Decimal)dataRow["NATIONALITY_FLG"];
			entity.GsCodeCurrencyId = (System.Decimal)dataRow["GS_CODE_CURRENCY_ID"];
			entity.AutoloadFlg = (System.Decimal)dataRow["AUTOLOAD_FLG"];
			entity.TransAppFlg = (System.Decimal)dataRow["TRANS_APP_FLG"];
			entity.AsCodeDegreeId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_ID"];
			entity.AsCodeDegreeClassId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_CLASS_ID"];
			entity.DelFlg = Convert.IsDBNull(dataRow["DEL_FLG"]) ? null : (System.Decimal?)dataRow["DEL_FLG"];
			entity.AdmCdePlacementExamId = Convert.IsDBNull(dataRow["ADM_CDE_PLACEMENT_EXAM_ID"]) ? null : (System.Decimal?)dataRow["ADM_CDE_PLACEMENT_EXAM_ID"];
			entity.RefundFlg = Convert.IsDBNull(dataRow["REFUND_FLG"]) ? null : (System.Boolean?)dataRow["REFUND_FLG"];
			entity.FeeCodeItemId = Convert.IsDBNull(dataRow["FEE_CODE_ITEM_ID"]) ? null : (System.Decimal?)dataRow["FEE_CODE_ITEM_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCdeFee"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmCdeFee Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeFee entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmCdePlacementExamIdSource	
			if (CanDeepLoad(entity, "AdmCdePlacementExam|AdmCdePlacementExamIdSource", deepLoadType, innerList) 
				&& entity.AdmCdePlacementExamIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmCdePlacementExamId ?? 0.0m);
				AdmCdePlacementExam tmpEntity = EntityManager.LocateEntity<AdmCdePlacementExam>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCdePlacementExam), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCdePlacementExamIdSource = tmpEntity;
				else
					entity.AdmCdePlacementExamIdSource = DataRepository.AdmCdePlacementExamProvider.GetByAdmCdePlacementExamId(transactionManager, (entity.AdmCdePlacementExamId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdePlacementExamIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCdePlacementExamIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCdePlacementExamProvider.DeepLoad(transactionManager, entity.AdmCdePlacementExamIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCdePlacementExamIdSource

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

			#region EntMainIdSource	
			if (CanDeepLoad(entity, "EntityMain|EntMainIdSource", deepLoadType, innerList) 
				&& entity.EntMainIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EntMainId;
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntMainIdSource = tmpEntity;
				else
					entity.EntMainIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, entity.EntMainId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMainIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntMainIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntityMainProvider.DeepLoad(transactionManager, entity.EntMainIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntMainIdSource

			#region FeeCodeItemIdSource	
			if (CanDeepLoad(entity, "FeeCodeItem|FeeCodeItemIdSource", deepLoadType, innerList) 
				&& entity.FeeCodeItemIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeCodeItemId ?? 0.0m);
				FeeCodeItem tmpEntity = EntityManager.LocateEntity<FeeCodeItem>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCodeItem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCodeItemIdSource = tmpEntity;
				else
					entity.FeeCodeItemIdSource = DataRepository.FeeCodeItemProvider.GetByFeeCodeItemId(transactionManager, (entity.FeeCodeItemId ?? 0.0m));		
				
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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAdmCdeFeeId methods when available
			
			#region AdmAppFeesCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppFees>|AdmAppFeesCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppFeesCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppFeesCollection = DataRepository.AdmAppFeesProvider.GetByAdmCdeFeeId(transactionManager, entity.AdmCdeFeeId);

				if (deep && entity.AdmAppFeesCollection.Count > 0)
				{
					deepHandles.Add("AdmAppFeesCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppFees>) DataRepository.AdmAppFeesProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppFeesCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeRefundCodeDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeRefundCodeDtl>|FeeRefundCodeDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeRefundCodeDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeRefundCodeDtlCollection = DataRepository.FeeRefundCodeDtlProvider.GetByAdmCdeFeeId(transactionManager, entity.AdmCdeFeeId);

				if (deep && entity.FeeRefundCodeDtlCollection.Count > 0)
				{
					deepHandles.Add("FeeRefundCodeDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeRefundCodeDtl>) DataRepository.FeeRefundCodeDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeRefundCodeDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmCdeAppStatusCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmCdeAppStatus>|AdmCdeAppStatusCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeAppStatusCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmCdeAppStatusCollection = DataRepository.AdmCdeAppStatusProvider.GetByAdmCdeFeeId(transactionManager, entity.AdmCdeFeeId);

				if (deep && entity.AdmCdeAppStatusCollection.Count > 0)
				{
					deepHandles.Add("AdmCdeAppStatusCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmCdeAppStatus>) DataRepository.AdmCdeAppStatusProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmCdeAppStatusCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmFeeQualCatCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmFeeQualCat>|AdmFeeQualCatCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmFeeQualCatCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmFeeQualCatCollection = DataRepository.AdmFeeQualCatProvider.GetByAdmCdeFeeId(transactionManager, entity.AdmCdeFeeId);

				if (deep && entity.AdmFeeQualCatCollection.Count > 0)
				{
					deepHandles.Add("AdmFeeQualCatCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmFeeQualCat>) DataRepository.AdmFeeQualCatProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmFeeQualCatCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmCdeFee object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmCdeFee instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmCdeFee Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeFee entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmCdePlacementExamIdSource
			if (CanDeepSave(entity, "AdmCdePlacementExam|AdmCdePlacementExamIdSource", deepSaveType, innerList) 
				&& entity.AdmCdePlacementExamIdSource != null)
			{
				DataRepository.AdmCdePlacementExamProvider.Save(transactionManager, entity.AdmCdePlacementExamIdSource);
				entity.AdmCdePlacementExamId = entity.AdmCdePlacementExamIdSource.AdmCdePlacementExamId;
			}
			#endregion 
			
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
			
			#region EntMainIdSource
			if (CanDeepSave(entity, "EntityMain|EntMainIdSource", deepSaveType, innerList) 
				&& entity.EntMainIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.EntMainIdSource);
				entity.EntMainId = entity.EntMainIdSource.EntMainId;
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
	
			#region List<AdmAppFees>
				if (CanDeepSave(entity.AdmAppFeesCollection, "List<AdmAppFees>|AdmAppFeesCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppFees child in entity.AdmAppFeesCollection)
					{
						if(child.AdmCdeFeeIdSource != null)
						{
							child.AdmCdeFeeId = child.AdmCdeFeeIdSource.AdmCdeFeeId;
						}
						else
						{
							child.AdmCdeFeeId = entity.AdmCdeFeeId;
						}

					}

					if (entity.AdmAppFeesCollection.Count > 0 || entity.AdmAppFeesCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppFeesProvider.Save(transactionManager, entity.AdmAppFeesCollection);
						
						deepHandles.Add("AdmAppFeesCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppFees >) DataRepository.AdmAppFeesProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppFeesCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeRefundCodeDtl>
				if (CanDeepSave(entity.FeeRefundCodeDtlCollection, "List<FeeRefundCodeDtl>|FeeRefundCodeDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeRefundCodeDtl child in entity.FeeRefundCodeDtlCollection)
					{
						if(child.AdmCdeFeeIdSource != null)
						{
							child.AdmCdeFeeId = child.AdmCdeFeeIdSource.AdmCdeFeeId;
						}
						else
						{
							child.AdmCdeFeeId = entity.AdmCdeFeeId;
						}

					}

					if (entity.FeeRefundCodeDtlCollection.Count > 0 || entity.FeeRefundCodeDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeRefundCodeDtlProvider.Save(transactionManager, entity.FeeRefundCodeDtlCollection);
						
						deepHandles.Add("FeeRefundCodeDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeRefundCodeDtl >) DataRepository.FeeRefundCodeDtlProvider.DeepSave,
							new object[] { transactionManager, entity.FeeRefundCodeDtlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmCdeAppStatus>
				if (CanDeepSave(entity.AdmCdeAppStatusCollection, "List<AdmCdeAppStatus>|AdmCdeAppStatusCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmCdeAppStatus child in entity.AdmCdeAppStatusCollection)
					{
						if(child.AdmCdeFeeIdSource != null)
						{
							child.AdmCdeFeeId = child.AdmCdeFeeIdSource.AdmCdeFeeId;
						}
						else
						{
							child.AdmCdeFeeId = entity.AdmCdeFeeId;
						}

					}

					if (entity.AdmCdeAppStatusCollection.Count > 0 || entity.AdmCdeAppStatusCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmCdeAppStatusProvider.Save(transactionManager, entity.AdmCdeAppStatusCollection);
						
						deepHandles.Add("AdmCdeAppStatusCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmCdeAppStatus >) DataRepository.AdmCdeAppStatusProvider.DeepSave,
							new object[] { transactionManager, entity.AdmCdeAppStatusCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmFeeQualCat>
				if (CanDeepSave(entity.AdmFeeQualCatCollection, "List<AdmFeeQualCat>|AdmFeeQualCatCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmFeeQualCat child in entity.AdmFeeQualCatCollection)
					{
						if(child.AdmCdeFeeIdSource != null)
						{
							child.AdmCdeFeeId = child.AdmCdeFeeIdSource.AdmCdeFeeId;
						}
						else
						{
							child.AdmCdeFeeId = entity.AdmCdeFeeId;
						}

					}

					if (entity.AdmFeeQualCatCollection.Count > 0 || entity.AdmFeeQualCatCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmFeeQualCatProvider.Save(transactionManager, entity.AdmFeeQualCatCollection);
						
						deepHandles.Add("AdmFeeQualCatCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmFeeQualCat >) DataRepository.AdmFeeQualCatProvider.DeepSave,
							new object[] { transactionManager, entity.AdmFeeQualCatCollection, deepSaveType, childTypes, innerList }
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
	
	#region AdmCdeFeeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmCdeFee</c>
	///</summary>
	public enum AdmCdeFeeChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmCdePlacementExam</c> at AdmCdePlacementExamIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdePlacementExam))]
		AdmCdePlacementExam,
		
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
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		
		///<summary>
		/// Composite Property for <c>FeeCodeItem</c> at FeeCodeItemIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCodeItem))]
		FeeCodeItem,
		
		///<summary>
		/// Composite Property for <c>GsCodeCurrency</c> at GsCodeCurrencyIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeCurrency))]
		GsCodeCurrency,
		///<summary>
		/// Collection of <c>AdmCdeFee</c> as OneToMany for AdmAppFeesCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppFees>))]
		AdmAppFeesCollection,
		///<summary>
		/// Collection of <c>AdmCdeFee</c> as OneToMany for FeeRefundCodeDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeRefundCodeDtl>))]
		FeeRefundCodeDtlCollection,
		///<summary>
		/// Collection of <c>AdmCdeFee</c> as OneToMany for AdmCdeAppStatusCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmCdeAppStatus>))]
		AdmCdeAppStatusCollection,
		///<summary>
		/// Collection of <c>AdmCdeFee</c> as OneToMany for AdmFeeQualCatCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmFeeQualCat>))]
		AdmFeeQualCatCollection,
	}
	
	#endregion AdmCdeFeeChildEntityTypes
	
	#region AdmCdeFeeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmCdeFeeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCdeFee"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmCdeFeeFilterBuilder : SqlFilterBuilder<AdmCdeFeeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCdeFeeFilterBuilder class.
		/// </summary>
		public AdmCdeFeeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeFeeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmCdeFeeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeFeeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmCdeFeeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmCdeFeeFilterBuilder
	
	#region AdmCdeFeeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmCdeFeeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCdeFee"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmCdeFeeParameterBuilder : ParameterizedSqlFilterBuilder<AdmCdeFeeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCdeFeeParameterBuilder class.
		/// </summary>
		public AdmCdeFeeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeFeeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmCdeFeeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeFeeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmCdeFeeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmCdeFeeParameterBuilder
	
	#region AdmCdeFeeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmCdeFeeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCdeFee"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmCdeFeeSortBuilder : SqlSortBuilder<AdmCdeFeeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCdeFeeSqlSortBuilder class.
		/// </summary>
		public AdmCdeFeeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmCdeFeeSortBuilder
	
} // end namespace
