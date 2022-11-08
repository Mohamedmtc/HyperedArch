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
	/// This class is the base class for any <see cref="SvSrvyQstnProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvSrvyQstnProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvSrvyQstn, UMIS_VER2.BusinessLyer.SvSrvyQstnKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvSrvyQstnKey key)
		{
			return Delete(transactionManager, key.SvSrvyQstnId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svSrvyQstnId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _svSrvyQstnId)
		{
			return Delete(null, _svSrvyQstnId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyQstnId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _svSrvyQstnId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_QSTN_SV_CDE_QSTN_TYPE key.
		///		FK_SV_SRVY_QSTN_SV_CDE_QSTN_TYPE Description: 
		/// </summary>
		/// <param name="_svCdeQstnTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyQstn objects.</returns>
		public TList<SvSrvyQstn> GetBySvCdeQstnTypeId(System.Int32? _svCdeQstnTypeId)
		{
			int count = -1;
			return GetBySvCdeQstnTypeId(_svCdeQstnTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_QSTN_SV_CDE_QSTN_TYPE key.
		///		FK_SV_SRVY_QSTN_SV_CDE_QSTN_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeQstnTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyQstn objects.</returns>
		/// <remarks></remarks>
		public TList<SvSrvyQstn> GetBySvCdeQstnTypeId(TransactionManager transactionManager, System.Int32? _svCdeQstnTypeId)
		{
			int count = -1;
			return GetBySvCdeQstnTypeId(transactionManager, _svCdeQstnTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_QSTN_SV_CDE_QSTN_TYPE key.
		///		FK_SV_SRVY_QSTN_SV_CDE_QSTN_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeQstnTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyQstn objects.</returns>
		public TList<SvSrvyQstn> GetBySvCdeQstnTypeId(TransactionManager transactionManager, System.Int32? _svCdeQstnTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeQstnTypeId(transactionManager, _svCdeQstnTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_QSTN_SV_CDE_QSTN_TYPE key.
		///		fkSvSrvyQstnSvCdeQstnType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCdeQstnTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyQstn objects.</returns>
		public TList<SvSrvyQstn> GetBySvCdeQstnTypeId(System.Int32? _svCdeQstnTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySvCdeQstnTypeId(null, _svCdeQstnTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_QSTN_SV_CDE_QSTN_TYPE key.
		///		fkSvSrvyQstnSvCdeQstnType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCdeQstnTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyQstn objects.</returns>
		public TList<SvSrvyQstn> GetBySvCdeQstnTypeId(System.Int32? _svCdeQstnTypeId, int start, int pageLength,out int count)
		{
			return GetBySvCdeQstnTypeId(null, _svCdeQstnTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_QSTN_SV_CDE_QSTN_TYPE key.
		///		FK_SV_SRVY_QSTN_SV_CDE_QSTN_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeQstnTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyQstn objects.</returns>
		public abstract TList<SvSrvyQstn> GetBySvCdeQstnTypeId(TransactionManager transactionManager, System.Int32? _svCdeQstnTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_QSTN_SV_SRVY_HDR key.
		///		FK_SV_SRVY_QSTN_SV_SRVY_HDR Description: 
		/// </summary>
		/// <param name="_svSrvyHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyQstn objects.</returns>
		public TList<SvSrvyQstn> GetBySvSrvyHdrId(System.Int32? _svSrvyHdrId)
		{
			int count = -1;
			return GetBySvSrvyHdrId(_svSrvyHdrId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_QSTN_SV_SRVY_HDR key.
		///		FK_SV_SRVY_QSTN_SV_SRVY_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyQstn objects.</returns>
		/// <remarks></remarks>
		public TList<SvSrvyQstn> GetBySvSrvyHdrId(TransactionManager transactionManager, System.Int32? _svSrvyHdrId)
		{
			int count = -1;
			return GetBySvSrvyHdrId(transactionManager, _svSrvyHdrId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_QSTN_SV_SRVY_HDR key.
		///		FK_SV_SRVY_QSTN_SV_SRVY_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyQstn objects.</returns>
		public TList<SvSrvyQstn> GetBySvSrvyHdrId(TransactionManager transactionManager, System.Int32? _svSrvyHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvSrvyHdrId(transactionManager, _svSrvyHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_QSTN_SV_SRVY_HDR key.
		///		fkSvSrvyQstnSvSrvyHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svSrvyHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyQstn objects.</returns>
		public TList<SvSrvyQstn> GetBySvSrvyHdrId(System.Int32? _svSrvyHdrId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySvSrvyHdrId(null, _svSrvyHdrId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_QSTN_SV_SRVY_HDR key.
		///		fkSvSrvyQstnSvSrvyHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svSrvyHdrId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyQstn objects.</returns>
		public TList<SvSrvyQstn> GetBySvSrvyHdrId(System.Int32? _svSrvyHdrId, int start, int pageLength,out int count)
		{
			return GetBySvSrvyHdrId(null, _svSrvyHdrId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_QSTN_SV_SRVY_HDR key.
		///		FK_SV_SRVY_QSTN_SV_SRVY_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyQstn objects.</returns>
		public abstract TList<SvSrvyQstn> GetBySvSrvyHdrId(TransactionManager transactionManager, System.Int32? _svSrvyHdrId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SvSrvyQstn Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvSrvyQstnKey key, int start, int pageLength)
		{
			return GetBySvSrvyQstnId(transactionManager, key.SvSrvyQstnId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_SRVY_QSTN index.
		/// </summary>
		/// <param name="_svSrvyQstnId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyQstn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyQstn GetBySvSrvyQstnId(System.Int32 _svSrvyQstnId)
		{
			int count = -1;
			return GetBySvSrvyQstnId(null,_svSrvyQstnId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_SRVY_QSTN index.
		/// </summary>
		/// <param name="_svSrvyQstnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyQstn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyQstn GetBySvSrvyQstnId(System.Int32 _svSrvyQstnId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvSrvyQstnId(null, _svSrvyQstnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_SRVY_QSTN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyQstnId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyQstn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyQstn GetBySvSrvyQstnId(TransactionManager transactionManager, System.Int32 _svSrvyQstnId)
		{
			int count = -1;
			return GetBySvSrvyQstnId(transactionManager, _svSrvyQstnId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_SRVY_QSTN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyQstnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyQstn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyQstn GetBySvSrvyQstnId(TransactionManager transactionManager, System.Int32 _svSrvyQstnId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvSrvyQstnId(transactionManager, _svSrvyQstnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_SRVY_QSTN index.
		/// </summary>
		/// <param name="_svSrvyQstnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyQstn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyQstn GetBySvSrvyQstnId(System.Int32 _svSrvyQstnId, int start, int pageLength, out int count)
		{
			return GetBySvSrvyQstnId(null, _svSrvyQstnId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_SRVY_QSTN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyQstnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyQstn"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvSrvyQstn GetBySvSrvyQstnId(TransactionManager transactionManager, System.Int32 _svSrvyQstnId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SV_SRVY_QSTN_AR index.
		/// </summary>
		/// <param name="_svSrvyHdrId"></param>
		/// <param name="_qstnAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyQstn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyQstn GetBySvSrvyHdrIdQstnAr(System.Int32? _svSrvyHdrId, System.String _qstnAr)
		{
			int count = -1;
			return GetBySvSrvyHdrIdQstnAr(null,_svSrvyHdrId, _qstnAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_SRVY_QSTN_AR index.
		/// </summary>
		/// <param name="_svSrvyHdrId"></param>
		/// <param name="_qstnAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyQstn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyQstn GetBySvSrvyHdrIdQstnAr(System.Int32? _svSrvyHdrId, System.String _qstnAr, int start, int pageLength)
		{
			int count = -1;
			return GetBySvSrvyHdrIdQstnAr(null, _svSrvyHdrId, _qstnAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_SRVY_QSTN_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyHdrId"></param>
		/// <param name="_qstnAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyQstn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyQstn GetBySvSrvyHdrIdQstnAr(TransactionManager transactionManager, System.Int32? _svSrvyHdrId, System.String _qstnAr)
		{
			int count = -1;
			return GetBySvSrvyHdrIdQstnAr(transactionManager, _svSrvyHdrId, _qstnAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_SRVY_QSTN_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyHdrId"></param>
		/// <param name="_qstnAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyQstn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyQstn GetBySvSrvyHdrIdQstnAr(TransactionManager transactionManager, System.Int32? _svSrvyHdrId, System.String _qstnAr, int start, int pageLength)
		{
			int count = -1;
			return GetBySvSrvyHdrIdQstnAr(transactionManager, _svSrvyHdrId, _qstnAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_SRVY_QSTN_AR index.
		/// </summary>
		/// <param name="_svSrvyHdrId"></param>
		/// <param name="_qstnAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyQstn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyQstn GetBySvSrvyHdrIdQstnAr(System.Int32? _svSrvyHdrId, System.String _qstnAr, int start, int pageLength, out int count)
		{
			return GetBySvSrvyHdrIdQstnAr(null, _svSrvyHdrId, _qstnAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_SRVY_QSTN_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyHdrId"></param>
		/// <param name="_qstnAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyQstn"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvSrvyQstn GetBySvSrvyHdrIdQstnAr(TransactionManager transactionManager, System.Int32? _svSrvyHdrId, System.String _qstnAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SV_SRVY_QSTN_EN index.
		/// </summary>
		/// <param name="_svSrvyHdrId"></param>
		/// <param name="_qstnEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyQstn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyQstn GetBySvSrvyHdrIdQstnEn(System.Int32? _svSrvyHdrId, System.String _qstnEn)
		{
			int count = -1;
			return GetBySvSrvyHdrIdQstnEn(null,_svSrvyHdrId, _qstnEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_SRVY_QSTN_EN index.
		/// </summary>
		/// <param name="_svSrvyHdrId"></param>
		/// <param name="_qstnEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyQstn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyQstn GetBySvSrvyHdrIdQstnEn(System.Int32? _svSrvyHdrId, System.String _qstnEn, int start, int pageLength)
		{
			int count = -1;
			return GetBySvSrvyHdrIdQstnEn(null, _svSrvyHdrId, _qstnEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_SRVY_QSTN_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyHdrId"></param>
		/// <param name="_qstnEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyQstn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyQstn GetBySvSrvyHdrIdQstnEn(TransactionManager transactionManager, System.Int32? _svSrvyHdrId, System.String _qstnEn)
		{
			int count = -1;
			return GetBySvSrvyHdrIdQstnEn(transactionManager, _svSrvyHdrId, _qstnEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_SRVY_QSTN_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyHdrId"></param>
		/// <param name="_qstnEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyQstn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyQstn GetBySvSrvyHdrIdQstnEn(TransactionManager transactionManager, System.Int32? _svSrvyHdrId, System.String _qstnEn, int start, int pageLength)
		{
			int count = -1;
			return GetBySvSrvyHdrIdQstnEn(transactionManager, _svSrvyHdrId, _qstnEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_SRVY_QSTN_EN index.
		/// </summary>
		/// <param name="_svSrvyHdrId"></param>
		/// <param name="_qstnEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyQstn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyQstn GetBySvSrvyHdrIdQstnEn(System.Int32? _svSrvyHdrId, System.String _qstnEn, int start, int pageLength, out int count)
		{
			return GetBySvSrvyHdrIdQstnEn(null, _svSrvyHdrId, _qstnEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_SRVY_QSTN_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyHdrId"></param>
		/// <param name="_qstnEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyQstn"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvSrvyQstn GetBySvSrvyHdrIdQstnEn(TransactionManager transactionManager, System.Int32? _svSrvyHdrId, System.String _qstnEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvSrvyQstn&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvSrvyQstn&gt;"/></returns>
		public static TList<SvSrvyQstn> Fill(IDataReader reader, TList<SvSrvyQstn> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvSrvyQstn c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvSrvyQstn")
					.Append("|").Append((System.Int32)reader["SV_SRVY_QSTN_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvSrvyQstn>(
					key.ToString(), // EntityTrackingKey
					"SvSrvyQstn",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvSrvyQstn();
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
					c.SvSrvyQstnId = (System.Int32)reader["SV_SRVY_QSTN_ID"];
					c.OriginalSvSrvyQstnId = c.SvSrvyQstnId;
					c.SvSrvyHdrId = Convert.IsDBNull(reader["SV_SRVY_HDR_ID"]) ? null : (System.Int32?)reader["SV_SRVY_HDR_ID"];
					c.QstnAr = (System.String)reader["QSTN_AR"];
					c.QstnEn = (System.String)reader["QSTN_EN"];
					c.HntAr = Convert.IsDBNull(reader["HNT_AR"]) ? null : (System.String)reader["HNT_AR"];
					c.HntEn = Convert.IsDBNull(reader["HNT_EN"]) ? null : (System.String)reader["HNT_EN"];
					c.QstnOrdr = (System.Int32)reader["QSTN_ORDR"];
					c.SvCdeQstnTypeId = Convert.IsDBNull(reader["SV_CDE_QSTN_TYPE_ID"]) ? null : (System.Int32?)reader["SV_CDE_QSTN_TYPE_ID"];
					c.QstnMark = Convert.IsDBNull(reader["QSTN_MARK"]) ? null : (System.Decimal?)reader["QSTN_MARK"];
					c.QstnImg = Convert.IsDBNull(reader["QSTN_IMG"]) ? null : (System.String)reader["QSTN_IMG"];
					c.QstnTblFlg = Convert.IsDBNull(reader["QSTN_TBL_FLG"]) ? null : (System.Boolean?)reader["QSTN_TBL_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvSrvyQstn"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvSrvyQstn"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvSrvyQstn entity)
		{
			if (!reader.Read()) return;
			
			entity.SvSrvyQstnId = (System.Int32)reader[((int)SvSrvyQstnColumn.SvSrvyQstnId - 1)];
			entity.OriginalSvSrvyQstnId = (System.Int32)reader["SV_SRVY_QSTN_ID"];
			entity.SvSrvyHdrId = (reader.IsDBNull(((int)SvSrvyQstnColumn.SvSrvyHdrId - 1)))?null:(System.Int32?)reader[((int)SvSrvyQstnColumn.SvSrvyHdrId - 1)];
			entity.QstnAr = (System.String)reader[((int)SvSrvyQstnColumn.QstnAr - 1)];
			entity.QstnEn = (System.String)reader[((int)SvSrvyQstnColumn.QstnEn - 1)];
			entity.HntAr = (reader.IsDBNull(((int)SvSrvyQstnColumn.HntAr - 1)))?null:(System.String)reader[((int)SvSrvyQstnColumn.HntAr - 1)];
			entity.HntEn = (reader.IsDBNull(((int)SvSrvyQstnColumn.HntEn - 1)))?null:(System.String)reader[((int)SvSrvyQstnColumn.HntEn - 1)];
			entity.QstnOrdr = (System.Int32)reader[((int)SvSrvyQstnColumn.QstnOrdr - 1)];
			entity.SvCdeQstnTypeId = (reader.IsDBNull(((int)SvSrvyQstnColumn.SvCdeQstnTypeId - 1)))?null:(System.Int32?)reader[((int)SvSrvyQstnColumn.SvCdeQstnTypeId - 1)];
			entity.QstnMark = (reader.IsDBNull(((int)SvSrvyQstnColumn.QstnMark - 1)))?null:(System.Decimal?)reader[((int)SvSrvyQstnColumn.QstnMark - 1)];
			entity.QstnImg = (reader.IsDBNull(((int)SvSrvyQstnColumn.QstnImg - 1)))?null:(System.String)reader[((int)SvSrvyQstnColumn.QstnImg - 1)];
			entity.QstnTblFlg = (reader.IsDBNull(((int)SvSrvyQstnColumn.QstnTblFlg - 1)))?null:(System.Boolean?)reader[((int)SvSrvyQstnColumn.QstnTblFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvSrvyQstn"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvSrvyQstn"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvSrvyQstn entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvSrvyQstnId = (System.Int32)dataRow["SV_SRVY_QSTN_ID"];
			entity.OriginalSvSrvyQstnId = (System.Int32)dataRow["SV_SRVY_QSTN_ID"];
			entity.SvSrvyHdrId = Convert.IsDBNull(dataRow["SV_SRVY_HDR_ID"]) ? null : (System.Int32?)dataRow["SV_SRVY_HDR_ID"];
			entity.QstnAr = (System.String)dataRow["QSTN_AR"];
			entity.QstnEn = (System.String)dataRow["QSTN_EN"];
			entity.HntAr = Convert.IsDBNull(dataRow["HNT_AR"]) ? null : (System.String)dataRow["HNT_AR"];
			entity.HntEn = Convert.IsDBNull(dataRow["HNT_EN"]) ? null : (System.String)dataRow["HNT_EN"];
			entity.QstnOrdr = (System.Int32)dataRow["QSTN_ORDR"];
			entity.SvCdeQstnTypeId = Convert.IsDBNull(dataRow["SV_CDE_QSTN_TYPE_ID"]) ? null : (System.Int32?)dataRow["SV_CDE_QSTN_TYPE_ID"];
			entity.QstnMark = Convert.IsDBNull(dataRow["QSTN_MARK"]) ? null : (System.Decimal?)dataRow["QSTN_MARK"];
			entity.QstnImg = Convert.IsDBNull(dataRow["QSTN_IMG"]) ? null : (System.String)dataRow["QSTN_IMG"];
			entity.QstnTblFlg = Convert.IsDBNull(dataRow["QSTN_TBL_FLG"]) ? null : (System.Boolean?)dataRow["QSTN_TBL_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvSrvyQstn"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvSrvyQstn Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvSrvyQstn entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SvCdeQstnTypeIdSource	
			if (CanDeepLoad(entity, "SvCdeQstnType|SvCdeQstnTypeIdSource", deepLoadType, innerList) 
				&& entity.SvCdeQstnTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SvCdeQstnTypeId ?? (int)0);
				SvCdeQstnType tmpEntity = EntityManager.LocateEntity<SvCdeQstnType>(EntityLocator.ConstructKeyFromPkItems(typeof(SvCdeQstnType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvCdeQstnTypeIdSource = tmpEntity;
				else
					entity.SvCdeQstnTypeIdSource = DataRepository.SvCdeQstnTypeProvider.GetBySvCdeQstnTypeId(transactionManager, (entity.SvCdeQstnTypeId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCdeQstnTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvCdeQstnTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvCdeQstnTypeProvider.DeepLoad(transactionManager, entity.SvCdeQstnTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvCdeQstnTypeIdSource

			#region SvSrvyHdrIdSource	
			if (CanDeepLoad(entity, "SvSrvyHdr|SvSrvyHdrIdSource", deepLoadType, innerList) 
				&& entity.SvSrvyHdrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SvSrvyHdrId ?? (int)0);
				SvSrvyHdr tmpEntity = EntityManager.LocateEntity<SvSrvyHdr>(EntityLocator.ConstructKeyFromPkItems(typeof(SvSrvyHdr), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvSrvyHdrIdSource = tmpEntity;
				else
					entity.SvSrvyHdrIdSource = DataRepository.SvSrvyHdrProvider.GetBySvSrvyHdrId(transactionManager, (entity.SvSrvyHdrId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvSrvyHdrIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvSrvyHdrIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvSrvyHdrProvider.DeepLoad(transactionManager, entity.SvSrvyHdrIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvSrvyHdrIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySvSrvyQstnId methods when available
			
			#region SvSrvyAnswrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvSrvyAnswr>|SvSrvyAnswrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvSrvyAnswrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvSrvyAnswrCollection = DataRepository.SvSrvyAnswrProvider.GetBySvSrvyQstnId(transactionManager, entity.SvSrvyQstnId);

				if (deep && entity.SvSrvyAnswrCollection.Count > 0)
				{
					deepHandles.Add("SvSrvyAnswrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvSrvyAnswr>) DataRepository.SvSrvyAnswrProvider.DeepLoad,
						new object[] { transactionManager, entity.SvSrvyAnswrCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvSrvyRespondQstnCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvSrvyRespondQstn>|SvSrvyRespondQstnCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvSrvyRespondQstnCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvSrvyRespondQstnCollection = DataRepository.SvSrvyRespondQstnProvider.GetBySvSrvyQstnId(transactionManager, entity.SvSrvyQstnId);

				if (deep && entity.SvSrvyRespondQstnCollection.Count > 0)
				{
					deepHandles.Add("SvSrvyRespondQstnCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvSrvyRespondQstn>) DataRepository.SvSrvyRespondQstnProvider.DeepLoad,
						new object[] { transactionManager, entity.SvSrvyRespondQstnCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvSrvyQstn object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvSrvyQstn instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvSrvyQstn Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvSrvyQstn entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SvCdeQstnTypeIdSource
			if (CanDeepSave(entity, "SvCdeQstnType|SvCdeQstnTypeIdSource", deepSaveType, innerList) 
				&& entity.SvCdeQstnTypeIdSource != null)
			{
				DataRepository.SvCdeQstnTypeProvider.Save(transactionManager, entity.SvCdeQstnTypeIdSource);
				entity.SvCdeQstnTypeId = entity.SvCdeQstnTypeIdSource.SvCdeQstnTypeId;
			}
			#endregion 
			
			#region SvSrvyHdrIdSource
			if (CanDeepSave(entity, "SvSrvyHdr|SvSrvyHdrIdSource", deepSaveType, innerList) 
				&& entity.SvSrvyHdrIdSource != null)
			{
				DataRepository.SvSrvyHdrProvider.Save(transactionManager, entity.SvSrvyHdrIdSource);
				entity.SvSrvyHdrId = entity.SvSrvyHdrIdSource.SvSrvyHdrId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SvSrvyAnswr>
				if (CanDeepSave(entity.SvSrvyAnswrCollection, "List<SvSrvyAnswr>|SvSrvyAnswrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvSrvyAnswr child in entity.SvSrvyAnswrCollection)
					{
						if(child.SvSrvyQstnIdSource != null)
						{
							child.SvSrvyQstnId = child.SvSrvyQstnIdSource.SvSrvyQstnId;
						}
						else
						{
							child.SvSrvyQstnId = entity.SvSrvyQstnId;
						}

					}

					if (entity.SvSrvyAnswrCollection.Count > 0 || entity.SvSrvyAnswrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvSrvyAnswrProvider.Save(transactionManager, entity.SvSrvyAnswrCollection);
						
						deepHandles.Add("SvSrvyAnswrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvSrvyAnswr >) DataRepository.SvSrvyAnswrProvider.DeepSave,
							new object[] { transactionManager, entity.SvSrvyAnswrCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvSrvyRespondQstn>
				if (CanDeepSave(entity.SvSrvyRespondQstnCollection, "List<SvSrvyRespondQstn>|SvSrvyRespondQstnCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvSrvyRespondQstn child in entity.SvSrvyRespondQstnCollection)
					{
						if(child.SvSrvyQstnIdSource != null)
						{
							child.SvSrvyQstnId = child.SvSrvyQstnIdSource.SvSrvyQstnId;
						}
						else
						{
							child.SvSrvyQstnId = entity.SvSrvyQstnId;
						}

					}

					if (entity.SvSrvyRespondQstnCollection.Count > 0 || entity.SvSrvyRespondQstnCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvSrvyRespondQstnProvider.Save(transactionManager, entity.SvSrvyRespondQstnCollection);
						
						deepHandles.Add("SvSrvyRespondQstnCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvSrvyRespondQstn >) DataRepository.SvSrvyRespondQstnProvider.DeepSave,
							new object[] { transactionManager, entity.SvSrvyRespondQstnCollection, deepSaveType, childTypes, innerList }
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
	
	#region SvSrvyQstnChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvSrvyQstn</c>
	///</summary>
	public enum SvSrvyQstnChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SvCdeQstnType</c> at SvCdeQstnTypeIdSource
		///</summary>
		[ChildEntityType(typeof(SvCdeQstnType))]
		SvCdeQstnType,
		
		///<summary>
		/// Composite Property for <c>SvSrvyHdr</c> at SvSrvyHdrIdSource
		///</summary>
		[ChildEntityType(typeof(SvSrvyHdr))]
		SvSrvyHdr,
		///<summary>
		/// Collection of <c>SvSrvyQstn</c> as OneToMany for SvSrvyAnswrCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvSrvyAnswr>))]
		SvSrvyAnswrCollection,
		///<summary>
		/// Collection of <c>SvSrvyQstn</c> as OneToMany for SvSrvyRespondQstnCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvSrvyRespondQstn>))]
		SvSrvyRespondQstnCollection,
	}
	
	#endregion SvSrvyQstnChildEntityTypes
	
	#region SvSrvyQstnFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvSrvyQstnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvSrvyQstn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvSrvyQstnFilterBuilder : SqlFilterBuilder<SvSrvyQstnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvSrvyQstnFilterBuilder class.
		/// </summary>
		public SvSrvyQstnFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvSrvyQstnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvSrvyQstnFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvSrvyQstnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvSrvyQstnFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvSrvyQstnFilterBuilder
	
	#region SvSrvyQstnParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvSrvyQstnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvSrvyQstn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvSrvyQstnParameterBuilder : ParameterizedSqlFilterBuilder<SvSrvyQstnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvSrvyQstnParameterBuilder class.
		/// </summary>
		public SvSrvyQstnParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvSrvyQstnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvSrvyQstnParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvSrvyQstnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvSrvyQstnParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvSrvyQstnParameterBuilder
	
	#region SvSrvyQstnSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvSrvyQstnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvSrvyQstn"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvSrvyQstnSortBuilder : SqlSortBuilder<SvSrvyQstnColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvSrvyQstnSqlSortBuilder class.
		/// </summary>
		public SvSrvyQstnSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvSrvyQstnSortBuilder
	
} // end namespace
