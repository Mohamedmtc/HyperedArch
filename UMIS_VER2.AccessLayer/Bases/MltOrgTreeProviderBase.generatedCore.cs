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
	/// This class is the base class for any <see cref="MltOrgTreeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class MltOrgTreeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.MltOrgTree, UMIS_VER2.BusinessLyer.MltOrgTreeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltOrgTreeKey key)
		{
			return Delete(transactionManager, key.MltOrgTreeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_mltOrgTreeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _mltOrgTreeId)
		{
			return Delete(null, _mltOrgTreeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltOrgTreeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _mltOrgTreeId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_ORG_TREE_AS_FACULTY_INFO key.
		///		FK_MLT_ORG_TREE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltOrgTree objects.</returns>
		public TList<MltOrgTree> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_ORG_TREE_AS_FACULTY_INFO key.
		///		FK_MLT_ORG_TREE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltOrgTree objects.</returns>
		/// <remarks></remarks>
		public TList<MltOrgTree> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_ORG_TREE_AS_FACULTY_INFO key.
		///		FK_MLT_ORG_TREE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltOrgTree objects.</returns>
		public TList<MltOrgTree> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_ORG_TREE_AS_FACULTY_INFO key.
		///		fkMltOrgTreeAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltOrgTree objects.</returns>
		public TList<MltOrgTree> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_ORG_TREE_AS_FACULTY_INFO key.
		///		fkMltOrgTreeAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltOrgTree objects.</returns>
		public TList<MltOrgTree> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_ORG_TREE_AS_FACULTY_INFO key.
		///		FK_MLT_ORG_TREE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltOrgTree objects.</returns>
		public abstract TList<MltOrgTree> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_ORG_TREE_MLT_CDE_ORG_TYPE key.
		///		FK_MLT_ORG_TREE_MLT_CDE_ORG_TYPE Description: 
		/// </summary>
		/// <param name="_mltCdeOrgTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltOrgTree objects.</returns>
		public TList<MltOrgTree> GetByMltCdeOrgTypeId(System.Decimal _mltCdeOrgTypeId)
		{
			int count = -1;
			return GetByMltCdeOrgTypeId(_mltCdeOrgTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_ORG_TREE_MLT_CDE_ORG_TYPE key.
		///		FK_MLT_ORG_TREE_MLT_CDE_ORG_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltCdeOrgTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltOrgTree objects.</returns>
		/// <remarks></remarks>
		public TList<MltOrgTree> GetByMltCdeOrgTypeId(TransactionManager transactionManager, System.Decimal _mltCdeOrgTypeId)
		{
			int count = -1;
			return GetByMltCdeOrgTypeId(transactionManager, _mltCdeOrgTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_ORG_TREE_MLT_CDE_ORG_TYPE key.
		///		FK_MLT_ORG_TREE_MLT_CDE_ORG_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltCdeOrgTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltOrgTree objects.</returns>
		public TList<MltOrgTree> GetByMltCdeOrgTypeId(TransactionManager transactionManager, System.Decimal _mltCdeOrgTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByMltCdeOrgTypeId(transactionManager, _mltCdeOrgTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_ORG_TREE_MLT_CDE_ORG_TYPE key.
		///		fkMltOrgTreeMltCdeOrgType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mltCdeOrgTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltOrgTree objects.</returns>
		public TList<MltOrgTree> GetByMltCdeOrgTypeId(System.Decimal _mltCdeOrgTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByMltCdeOrgTypeId(null, _mltCdeOrgTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_ORG_TREE_MLT_CDE_ORG_TYPE key.
		///		fkMltOrgTreeMltCdeOrgType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mltCdeOrgTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltOrgTree objects.</returns>
		public TList<MltOrgTree> GetByMltCdeOrgTypeId(System.Decimal _mltCdeOrgTypeId, int start, int pageLength,out int count)
		{
			return GetByMltCdeOrgTypeId(null, _mltCdeOrgTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_ORG_TREE_MLT_CDE_ORG_TYPE key.
		///		FK_MLT_ORG_TREE_MLT_CDE_ORG_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltCdeOrgTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltOrgTree objects.</returns>
		public abstract TList<MltOrgTree> GetByMltCdeOrgTypeId(TransactionManager transactionManager, System.Decimal _mltCdeOrgTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_ORG_TREE_MLT_ORG_TREE key.
		///		FK_MLT_ORG_TREE_MLT_ORG_TREE Description: 
		/// </summary>
		/// <param name="_orgParentId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltOrgTree objects.</returns>
		public TList<MltOrgTree> GetByOrgParentId(System.Decimal? _orgParentId)
		{
			int count = -1;
			return GetByOrgParentId(_orgParentId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_ORG_TREE_MLT_ORG_TREE key.
		///		FK_MLT_ORG_TREE_MLT_ORG_TREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_orgParentId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltOrgTree objects.</returns>
		/// <remarks></remarks>
		public TList<MltOrgTree> GetByOrgParentId(TransactionManager transactionManager, System.Decimal? _orgParentId)
		{
			int count = -1;
			return GetByOrgParentId(transactionManager, _orgParentId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_ORG_TREE_MLT_ORG_TREE key.
		///		FK_MLT_ORG_TREE_MLT_ORG_TREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_orgParentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltOrgTree objects.</returns>
		public TList<MltOrgTree> GetByOrgParentId(TransactionManager transactionManager, System.Decimal? _orgParentId, int start, int pageLength)
		{
			int count = -1;
			return GetByOrgParentId(transactionManager, _orgParentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_ORG_TREE_MLT_ORG_TREE key.
		///		fkMltOrgTreeMltOrgTree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_orgParentId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltOrgTree objects.</returns>
		public TList<MltOrgTree> GetByOrgParentId(System.Decimal? _orgParentId, int start, int pageLength)
		{
			int count =  -1;
			return GetByOrgParentId(null, _orgParentId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_ORG_TREE_MLT_ORG_TREE key.
		///		fkMltOrgTreeMltOrgTree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_orgParentId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltOrgTree objects.</returns>
		public TList<MltOrgTree> GetByOrgParentId(System.Decimal? _orgParentId, int start, int pageLength,out int count)
		{
			return GetByOrgParentId(null, _orgParentId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_ORG_TREE_MLT_ORG_TREE key.
		///		FK_MLT_ORG_TREE_MLT_ORG_TREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_orgParentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltOrgTree objects.</returns>
		public abstract TList<MltOrgTree> GetByOrgParentId(TransactionManager transactionManager, System.Decimal? _orgParentId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.MltOrgTree Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltOrgTreeKey key, int start, int pageLength)
		{
			return GetByMltOrgTreeId(transactionManager, key.MltOrgTreeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_MLT_ORG_TREE index.
		/// </summary>
		/// <param name="_mltOrgTreeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltOrgTree"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltOrgTree GetByMltOrgTreeId(System.Decimal _mltOrgTreeId)
		{
			int count = -1;
			return GetByMltOrgTreeId(null,_mltOrgTreeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_ORG_TREE index.
		/// </summary>
		/// <param name="_mltOrgTreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltOrgTree"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltOrgTree GetByMltOrgTreeId(System.Decimal _mltOrgTreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByMltOrgTreeId(null, _mltOrgTreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_ORG_TREE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltOrgTreeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltOrgTree"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltOrgTree GetByMltOrgTreeId(TransactionManager transactionManager, System.Decimal _mltOrgTreeId)
		{
			int count = -1;
			return GetByMltOrgTreeId(transactionManager, _mltOrgTreeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_ORG_TREE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltOrgTreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltOrgTree"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltOrgTree GetByMltOrgTreeId(TransactionManager transactionManager, System.Decimal _mltOrgTreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByMltOrgTreeId(transactionManager, _mltOrgTreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_ORG_TREE index.
		/// </summary>
		/// <param name="_mltOrgTreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltOrgTree"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltOrgTree GetByMltOrgTreeId(System.Decimal _mltOrgTreeId, int start, int pageLength, out int count)
		{
			return GetByMltOrgTreeId(null, _mltOrgTreeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_ORG_TREE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltOrgTreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltOrgTree"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MltOrgTree GetByMltOrgTreeId(TransactionManager transactionManager, System.Decimal _mltOrgTreeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_MLT_ORG_TREE_AR index.
		/// </summary>
		/// <param name="_orgParentId"></param>
		/// <param name="_orgDscrAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltOrgTree"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltOrgTree GetByOrgParentIdOrgDscrAr(System.Decimal? _orgParentId, System.String _orgDscrAr)
		{
			int count = -1;
			return GetByOrgParentIdOrgDscrAr(null,_orgParentId, _orgDscrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MLT_ORG_TREE_AR index.
		/// </summary>
		/// <param name="_orgParentId"></param>
		/// <param name="_orgDscrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltOrgTree"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltOrgTree GetByOrgParentIdOrgDscrAr(System.Decimal? _orgParentId, System.String _orgDscrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByOrgParentIdOrgDscrAr(null, _orgParentId, _orgDscrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MLT_ORG_TREE_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_orgParentId"></param>
		/// <param name="_orgDscrAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltOrgTree"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltOrgTree GetByOrgParentIdOrgDscrAr(TransactionManager transactionManager, System.Decimal? _orgParentId, System.String _orgDscrAr)
		{
			int count = -1;
			return GetByOrgParentIdOrgDscrAr(transactionManager, _orgParentId, _orgDscrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MLT_ORG_TREE_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_orgParentId"></param>
		/// <param name="_orgDscrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltOrgTree"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltOrgTree GetByOrgParentIdOrgDscrAr(TransactionManager transactionManager, System.Decimal? _orgParentId, System.String _orgDscrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByOrgParentIdOrgDscrAr(transactionManager, _orgParentId, _orgDscrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MLT_ORG_TREE_AR index.
		/// </summary>
		/// <param name="_orgParentId"></param>
		/// <param name="_orgDscrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltOrgTree"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltOrgTree GetByOrgParentIdOrgDscrAr(System.Decimal? _orgParentId, System.String _orgDscrAr, int start, int pageLength, out int count)
		{
			return GetByOrgParentIdOrgDscrAr(null, _orgParentId, _orgDscrAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MLT_ORG_TREE_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_orgParentId"></param>
		/// <param name="_orgDscrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltOrgTree"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MltOrgTree GetByOrgParentIdOrgDscrAr(TransactionManager transactionManager, System.Decimal? _orgParentId, System.String _orgDscrAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_MLT_ORG_TREE_EN index.
		/// </summary>
		/// <param name="_orgParentId"></param>
		/// <param name="_orgDscrEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltOrgTree"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltOrgTree GetByOrgParentIdOrgDscrEn(System.Decimal? _orgParentId, System.String _orgDscrEn)
		{
			int count = -1;
			return GetByOrgParentIdOrgDscrEn(null,_orgParentId, _orgDscrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MLT_ORG_TREE_EN index.
		/// </summary>
		/// <param name="_orgParentId"></param>
		/// <param name="_orgDscrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltOrgTree"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltOrgTree GetByOrgParentIdOrgDscrEn(System.Decimal? _orgParentId, System.String _orgDscrEn, int start, int pageLength)
		{
			int count = -1;
			return GetByOrgParentIdOrgDscrEn(null, _orgParentId, _orgDscrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MLT_ORG_TREE_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_orgParentId"></param>
		/// <param name="_orgDscrEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltOrgTree"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltOrgTree GetByOrgParentIdOrgDscrEn(TransactionManager transactionManager, System.Decimal? _orgParentId, System.String _orgDscrEn)
		{
			int count = -1;
			return GetByOrgParentIdOrgDscrEn(transactionManager, _orgParentId, _orgDscrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MLT_ORG_TREE_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_orgParentId"></param>
		/// <param name="_orgDscrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltOrgTree"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltOrgTree GetByOrgParentIdOrgDscrEn(TransactionManager transactionManager, System.Decimal? _orgParentId, System.String _orgDscrEn, int start, int pageLength)
		{
			int count = -1;
			return GetByOrgParentIdOrgDscrEn(transactionManager, _orgParentId, _orgDscrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MLT_ORG_TREE_EN index.
		/// </summary>
		/// <param name="_orgParentId"></param>
		/// <param name="_orgDscrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltOrgTree"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltOrgTree GetByOrgParentIdOrgDscrEn(System.Decimal? _orgParentId, System.String _orgDscrEn, int start, int pageLength, out int count)
		{
			return GetByOrgParentIdOrgDscrEn(null, _orgParentId, _orgDscrEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MLT_ORG_TREE_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_orgParentId"></param>
		/// <param name="_orgDscrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltOrgTree"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MltOrgTree GetByOrgParentIdOrgDscrEn(TransactionManager transactionManager, System.Decimal? _orgParentId, System.String _orgDscrEn, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_MLT_ORG_TREE_PATH index.
		/// </summary>
		/// <param name="_nodePath"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltOrgTree"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltOrgTree GetByNodePath(System.String _nodePath)
		{
			int count = -1;
			return GetByNodePath(null,_nodePath, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MLT_ORG_TREE_PATH index.
		/// </summary>
		/// <param name="_nodePath"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltOrgTree"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltOrgTree GetByNodePath(System.String _nodePath, int start, int pageLength)
		{
			int count = -1;
			return GetByNodePath(null, _nodePath, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MLT_ORG_TREE_PATH index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_nodePath"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltOrgTree"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltOrgTree GetByNodePath(TransactionManager transactionManager, System.String _nodePath)
		{
			int count = -1;
			return GetByNodePath(transactionManager, _nodePath, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MLT_ORG_TREE_PATH index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_nodePath"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltOrgTree"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltOrgTree GetByNodePath(TransactionManager transactionManager, System.String _nodePath, int start, int pageLength)
		{
			int count = -1;
			return GetByNodePath(transactionManager, _nodePath, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MLT_ORG_TREE_PATH index.
		/// </summary>
		/// <param name="_nodePath"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltOrgTree"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltOrgTree GetByNodePath(System.String _nodePath, int start, int pageLength, out int count)
		{
			return GetByNodePath(null, _nodePath, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MLT_ORG_TREE_PATH index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_nodePath"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltOrgTree"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MltOrgTree GetByNodePath(TransactionManager transactionManager, System.String _nodePath, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;MltOrgTree&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;MltOrgTree&gt;"/></returns>
		public static TList<MltOrgTree> Fill(IDataReader reader, TList<MltOrgTree> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.MltOrgTree c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("MltOrgTree")
					.Append("|").Append((System.Decimal)reader["MLT_ORG_TREE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<MltOrgTree>(
					key.ToString(), // EntityTrackingKey
					"MltOrgTree",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.MltOrgTree();
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
					c.MltOrgTreeId = (System.Decimal)reader["MLT_ORG_TREE_ID"];
					c.OriginalMltOrgTreeId = c.MltOrgTreeId;
					c.OrgParentId = Convert.IsDBNull(reader["ORG_PARENT_ID"]) ? null : (System.Decimal?)reader["ORG_PARENT_ID"];
					c.NodePath = (System.String)reader["NODE_PATH"];
					c.NodeOrder = (System.Decimal)reader["NODE_ORDER"];
					c.NodeLevel = (System.Decimal)reader["NODE_LEVEL"];
					c.OrgDscrAr = (System.String)reader["ORG_DSCR_AR"];
					c.OrgDscrEn = (System.String)reader["ORG_DSCR_EN"];
					c.MltCdeOrgTypeId = (System.Decimal)reader["MLT_CDE_ORG_TYPE_ID"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MltOrgTree"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MltOrgTree"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.MltOrgTree entity)
		{
			if (!reader.Read()) return;
			
			entity.MltOrgTreeId = (System.Decimal)reader[((int)MltOrgTreeColumn.MltOrgTreeId - 1)];
			entity.OriginalMltOrgTreeId = (System.Decimal)reader["MLT_ORG_TREE_ID"];
			entity.OrgParentId = (reader.IsDBNull(((int)MltOrgTreeColumn.OrgParentId - 1)))?null:(System.Decimal?)reader[((int)MltOrgTreeColumn.OrgParentId - 1)];
			entity.NodePath = (System.String)reader[((int)MltOrgTreeColumn.NodePath - 1)];
			entity.NodeOrder = (System.Decimal)reader[((int)MltOrgTreeColumn.NodeOrder - 1)];
			entity.NodeLevel = (System.Decimal)reader[((int)MltOrgTreeColumn.NodeLevel - 1)];
			entity.OrgDscrAr = (System.String)reader[((int)MltOrgTreeColumn.OrgDscrAr - 1)];
			entity.OrgDscrEn = (System.String)reader[((int)MltOrgTreeColumn.OrgDscrEn - 1)];
			entity.MltCdeOrgTypeId = (System.Decimal)reader[((int)MltOrgTreeColumn.MltCdeOrgTypeId - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)MltOrgTreeColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)MltOrgTreeColumn.AsFacultyInfoId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MltOrgTree"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MltOrgTree"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.MltOrgTree entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MltOrgTreeId = (System.Decimal)dataRow["MLT_ORG_TREE_ID"];
			entity.OriginalMltOrgTreeId = (System.Decimal)dataRow["MLT_ORG_TREE_ID"];
			entity.OrgParentId = Convert.IsDBNull(dataRow["ORG_PARENT_ID"]) ? null : (System.Decimal?)dataRow["ORG_PARENT_ID"];
			entity.NodePath = (System.String)dataRow["NODE_PATH"];
			entity.NodeOrder = (System.Decimal)dataRow["NODE_ORDER"];
			entity.NodeLevel = (System.Decimal)dataRow["NODE_LEVEL"];
			entity.OrgDscrAr = (System.String)dataRow["ORG_DSCR_AR"];
			entity.OrgDscrEn = (System.String)dataRow["ORG_DSCR_EN"];
			entity.MltCdeOrgTypeId = (System.Decimal)dataRow["MLT_CDE_ORG_TYPE_ID"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MltOrgTree"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MltOrgTree Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltOrgTree entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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

			#region MltCdeOrgTypeIdSource	
			if (CanDeepLoad(entity, "MltCdeOrgType|MltCdeOrgTypeIdSource", deepLoadType, innerList) 
				&& entity.MltCdeOrgTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.MltCdeOrgTypeId;
				MltCdeOrgType tmpEntity = EntityManager.LocateEntity<MltCdeOrgType>(EntityLocator.ConstructKeyFromPkItems(typeof(MltCdeOrgType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MltCdeOrgTypeIdSource = tmpEntity;
				else
					entity.MltCdeOrgTypeIdSource = DataRepository.MltCdeOrgTypeProvider.GetByMltCdeOrgTypeId(transactionManager, entity.MltCdeOrgTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MltCdeOrgTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MltCdeOrgTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.MltCdeOrgTypeProvider.DeepLoad(transactionManager, entity.MltCdeOrgTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MltCdeOrgTypeIdSource

			#region OrgParentIdSource	
			if (CanDeepLoad(entity, "MltOrgTree|OrgParentIdSource", deepLoadType, innerList) 
				&& entity.OrgParentIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.OrgParentId ?? 0.0m);
				MltOrgTree tmpEntity = EntityManager.LocateEntity<MltOrgTree>(EntityLocator.ConstructKeyFromPkItems(typeof(MltOrgTree), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.OrgParentIdSource = tmpEntity;
				else
					entity.OrgParentIdSource = DataRepository.MltOrgTreeProvider.GetByMltOrgTreeId(transactionManager, (entity.OrgParentId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'OrgParentIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.OrgParentIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.MltOrgTreeProvider.DeepLoad(transactionManager, entity.OrgParentIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion OrgParentIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMltOrgTreeId methods when available
			
			#region MltOrgTreeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MltOrgTree>|MltOrgTreeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MltOrgTreeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MltOrgTreeCollection = DataRepository.MltOrgTreeProvider.GetByOrgParentId(transactionManager, entity.MltOrgTreeId);

				if (deep && entity.MltOrgTreeCollection.Count > 0)
				{
					deepHandles.Add("MltOrgTreeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MltOrgTree>) DataRepository.MltOrgTreeProvider.DeepLoad,
						new object[] { transactionManager, entity.MltOrgTreeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region MltRptDayStudStsCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MltRptDayStudSts>|MltRptDayStudStsCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MltRptDayStudStsCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MltRptDayStudStsCollection = DataRepository.MltRptDayStudStsProvider.GetByMltOrgTreeId(transactionManager, entity.MltOrgTreeId);

				if (deep && entity.MltRptDayStudStsCollection.Count > 0)
				{
					deepHandles.Add("MltRptDayStudStsCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MltRptDayStudSts>) DataRepository.MltRptDayStudStsProvider.DeepLoad,
						new object[] { transactionManager, entity.MltRptDayStudStsCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region MltStudInfoCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MltStudInfo>|MltStudInfoCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MltStudInfoCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MltStudInfoCollection = DataRepository.MltStudInfoProvider.GetByMltOrgTreeId(transactionManager, entity.MltOrgTreeId);

				if (deep && entity.MltStudInfoCollection.Count > 0)
				{
					deepHandles.Add("MltStudInfoCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MltStudInfo>) DataRepository.MltStudInfoProvider.DeepLoad,
						new object[] { transactionManager, entity.MltStudInfoCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.MltOrgTree object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.MltOrgTree instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MltOrgTree Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltOrgTree entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AsFacultyInfoIdSource
			if (CanDeepSave(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepSaveType, innerList) 
				&& entity.AsFacultyInfoIdSource != null)
			{
				DataRepository.AsFacultyInfoProvider.Save(transactionManager, entity.AsFacultyInfoIdSource);
				entity.AsFacultyInfoId = entity.AsFacultyInfoIdSource.AsFacultyInfoId;
			}
			#endregion 
			
			#region MltCdeOrgTypeIdSource
			if (CanDeepSave(entity, "MltCdeOrgType|MltCdeOrgTypeIdSource", deepSaveType, innerList) 
				&& entity.MltCdeOrgTypeIdSource != null)
			{
				DataRepository.MltCdeOrgTypeProvider.Save(transactionManager, entity.MltCdeOrgTypeIdSource);
				entity.MltCdeOrgTypeId = entity.MltCdeOrgTypeIdSource.MltCdeOrgTypeId;
			}
			#endregion 
			
			#region OrgParentIdSource
			if (CanDeepSave(entity, "MltOrgTree|OrgParentIdSource", deepSaveType, innerList) 
				&& entity.OrgParentIdSource != null)
			{
				DataRepository.MltOrgTreeProvider.Save(transactionManager, entity.OrgParentIdSource);
				entity.OrgParentId = entity.OrgParentIdSource.MltOrgTreeId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<MltOrgTree>
				if (CanDeepSave(entity.MltOrgTreeCollection, "List<MltOrgTree>|MltOrgTreeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MltOrgTree child in entity.MltOrgTreeCollection)
					{
						if(child.OrgParentIdSource != null)
						{
							child.OrgParentId = child.OrgParentIdSource.MltOrgTreeId;
						}
						else
						{
							child.OrgParentId = entity.MltOrgTreeId;
						}

					}

					if (entity.MltOrgTreeCollection.Count > 0 || entity.MltOrgTreeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MltOrgTreeProvider.Save(transactionManager, entity.MltOrgTreeCollection);
						
						deepHandles.Add("MltOrgTreeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MltOrgTree >) DataRepository.MltOrgTreeProvider.DeepSave,
							new object[] { transactionManager, entity.MltOrgTreeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<MltRptDayStudSts>
				if (CanDeepSave(entity.MltRptDayStudStsCollection, "List<MltRptDayStudSts>|MltRptDayStudStsCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MltRptDayStudSts child in entity.MltRptDayStudStsCollection)
					{
						if(child.MltOrgTreeIdSource != null)
						{
							child.MltOrgTreeId = child.MltOrgTreeIdSource.MltOrgTreeId;
						}
						else
						{
							child.MltOrgTreeId = entity.MltOrgTreeId;
						}

					}

					if (entity.MltRptDayStudStsCollection.Count > 0 || entity.MltRptDayStudStsCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MltRptDayStudStsProvider.Save(transactionManager, entity.MltRptDayStudStsCollection);
						
						deepHandles.Add("MltRptDayStudStsCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MltRptDayStudSts >) DataRepository.MltRptDayStudStsProvider.DeepSave,
							new object[] { transactionManager, entity.MltRptDayStudStsCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<MltStudInfo>
				if (CanDeepSave(entity.MltStudInfoCollection, "List<MltStudInfo>|MltStudInfoCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MltStudInfo child in entity.MltStudInfoCollection)
					{
						if(child.MltOrgTreeIdSource != null)
						{
							child.MltOrgTreeId = child.MltOrgTreeIdSource.MltOrgTreeId;
						}
						else
						{
							child.MltOrgTreeId = entity.MltOrgTreeId;
						}

					}

					if (entity.MltStudInfoCollection.Count > 0 || entity.MltStudInfoCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MltStudInfoProvider.Save(transactionManager, entity.MltStudInfoCollection);
						
						deepHandles.Add("MltStudInfoCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MltStudInfo >) DataRepository.MltStudInfoProvider.DeepSave,
							new object[] { transactionManager, entity.MltStudInfoCollection, deepSaveType, childTypes, innerList }
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
	
	#region MltOrgTreeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.MltOrgTree</c>
	///</summary>
	public enum MltOrgTreeChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>MltCdeOrgType</c> at MltCdeOrgTypeIdSource
		///</summary>
		[ChildEntityType(typeof(MltCdeOrgType))]
		MltCdeOrgType,
		
		///<summary>
		/// Composite Property for <c>MltOrgTree</c> at OrgParentIdSource
		///</summary>
		[ChildEntityType(typeof(MltOrgTree))]
		MltOrgTree,
		///<summary>
		/// Collection of <c>MltOrgTree</c> as OneToMany for MltOrgTreeCollection
		///</summary>
		[ChildEntityType(typeof(TList<MltOrgTree>))]
		MltOrgTreeCollection,
		///<summary>
		/// Collection of <c>MltOrgTree</c> as OneToMany for MltRptDayStudStsCollection
		///</summary>
		[ChildEntityType(typeof(TList<MltRptDayStudSts>))]
		MltRptDayStudStsCollection,
		///<summary>
		/// Collection of <c>MltOrgTree</c> as OneToMany for MltStudInfoCollection
		///</summary>
		[ChildEntityType(typeof(TList<MltStudInfo>))]
		MltStudInfoCollection,
	}
	
	#endregion MltOrgTreeChildEntityTypes
	
	#region MltOrgTreeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;MltOrgTreeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MltOrgTree"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MltOrgTreeFilterBuilder : SqlFilterBuilder<MltOrgTreeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MltOrgTreeFilterBuilder class.
		/// </summary>
		public MltOrgTreeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MltOrgTreeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MltOrgTreeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MltOrgTreeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MltOrgTreeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MltOrgTreeFilterBuilder
	
	#region MltOrgTreeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;MltOrgTreeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MltOrgTree"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MltOrgTreeParameterBuilder : ParameterizedSqlFilterBuilder<MltOrgTreeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MltOrgTreeParameterBuilder class.
		/// </summary>
		public MltOrgTreeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MltOrgTreeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MltOrgTreeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MltOrgTreeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MltOrgTreeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MltOrgTreeParameterBuilder
	
	#region MltOrgTreeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;MltOrgTreeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MltOrgTree"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class MltOrgTreeSortBuilder : SqlSortBuilder<MltOrgTreeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MltOrgTreeSqlSortBuilder class.
		/// </summary>
		public MltOrgTreeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion MltOrgTreeSortBuilder
	
} // end namespace
