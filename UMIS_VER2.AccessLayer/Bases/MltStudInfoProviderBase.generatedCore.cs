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
	/// This class is the base class for any <see cref="MltStudInfoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class MltStudInfoProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.MltStudInfo, UMIS_VER2.BusinessLyer.MltStudInfoKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltStudInfoKey key)
		{
			return Delete(transactionManager, key.MltStudInfoId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_mltStudInfoId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _mltStudInfoId)
		{
			return Delete(null, _mltStudInfoId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltStudInfoId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _mltStudInfoId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_INFO_ED_ACAD_YEAR key.
		///		FK_MLT_STUD_INFO_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudInfo objects.</returns>
		public TList<MltStudInfo> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_INFO_ED_ACAD_YEAR key.
		///		FK_MLT_STUD_INFO_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudInfo objects.</returns>
		/// <remarks></remarks>
		public TList<MltStudInfo> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_INFO_ED_ACAD_YEAR key.
		///		FK_MLT_STUD_INFO_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudInfo objects.</returns>
		public TList<MltStudInfo> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_INFO_ED_ACAD_YEAR key.
		///		fkMltStudInfoEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudInfo objects.</returns>
		public TList<MltStudInfo> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_INFO_ED_ACAD_YEAR key.
		///		fkMltStudInfoEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudInfo objects.</returns>
		public TList<MltStudInfo> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_INFO_ED_ACAD_YEAR key.
		///		FK_MLT_STUD_INFO_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudInfo objects.</returns>
		public abstract TList<MltStudInfo> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_INFO_ED_CODE_SEMESTER key.
		///		FK_MLT_STUD_INFO_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudInfo objects.</returns>
		public TList<MltStudInfo> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_INFO_ED_CODE_SEMESTER key.
		///		FK_MLT_STUD_INFO_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudInfo objects.</returns>
		/// <remarks></remarks>
		public TList<MltStudInfo> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_INFO_ED_CODE_SEMESTER key.
		///		FK_MLT_STUD_INFO_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudInfo objects.</returns>
		public TList<MltStudInfo> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_INFO_ED_CODE_SEMESTER key.
		///		fkMltStudInfoEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudInfo objects.</returns>
		public TList<MltStudInfo> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_INFO_ED_CODE_SEMESTER key.
		///		fkMltStudInfoEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudInfo objects.</returns>
		public TList<MltStudInfo> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_INFO_ED_CODE_SEMESTER key.
		///		FK_MLT_STUD_INFO_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudInfo objects.</returns>
		public abstract TList<MltStudInfo> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_INFO_ED_STUD key.
		///		FK_MLT_STUD_INFO_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudInfo objects.</returns>
		public TList<MltStudInfo> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_INFO_ED_STUD key.
		///		FK_MLT_STUD_INFO_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudInfo objects.</returns>
		/// <remarks></remarks>
		public TList<MltStudInfo> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_INFO_ED_STUD key.
		///		FK_MLT_STUD_INFO_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudInfo objects.</returns>
		public TList<MltStudInfo> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_INFO_ED_STUD key.
		///		fkMltStudInfoEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudInfo objects.</returns>
		public TList<MltStudInfo> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_INFO_ED_STUD key.
		///		fkMltStudInfoEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudInfo objects.</returns>
		public TList<MltStudInfo> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_INFO_ED_STUD key.
		///		FK_MLT_STUD_INFO_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudInfo objects.</returns>
		public abstract TList<MltStudInfo> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_INFO_MLT_CDE_STUD_DEGREE key.
		///		FK_MLT_STUD_INFO_MLT_CDE_STUD_DEGREE Description: 
		/// </summary>
		/// <param name="_mltCdeDegreeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudInfo objects.</returns>
		public TList<MltStudInfo> GetByMltCdeDegreeId(System.Decimal? _mltCdeDegreeId)
		{
			int count = -1;
			return GetByMltCdeDegreeId(_mltCdeDegreeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_INFO_MLT_CDE_STUD_DEGREE key.
		///		FK_MLT_STUD_INFO_MLT_CDE_STUD_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltCdeDegreeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudInfo objects.</returns>
		/// <remarks></remarks>
		public TList<MltStudInfo> GetByMltCdeDegreeId(TransactionManager transactionManager, System.Decimal? _mltCdeDegreeId)
		{
			int count = -1;
			return GetByMltCdeDegreeId(transactionManager, _mltCdeDegreeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_INFO_MLT_CDE_STUD_DEGREE key.
		///		FK_MLT_STUD_INFO_MLT_CDE_STUD_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltCdeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudInfo objects.</returns>
		public TList<MltStudInfo> GetByMltCdeDegreeId(TransactionManager transactionManager, System.Decimal? _mltCdeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByMltCdeDegreeId(transactionManager, _mltCdeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_INFO_MLT_CDE_STUD_DEGREE key.
		///		fkMltStudInfoMltCdeStudDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mltCdeDegreeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudInfo objects.</returns>
		public TList<MltStudInfo> GetByMltCdeDegreeId(System.Decimal? _mltCdeDegreeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByMltCdeDegreeId(null, _mltCdeDegreeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_INFO_MLT_CDE_STUD_DEGREE key.
		///		fkMltStudInfoMltCdeStudDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mltCdeDegreeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudInfo objects.</returns>
		public TList<MltStudInfo> GetByMltCdeDegreeId(System.Decimal? _mltCdeDegreeId, int start, int pageLength,out int count)
		{
			return GetByMltCdeDegreeId(null, _mltCdeDegreeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_INFO_MLT_CDE_STUD_DEGREE key.
		///		FK_MLT_STUD_INFO_MLT_CDE_STUD_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltCdeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudInfo objects.</returns>
		public abstract TList<MltStudInfo> GetByMltCdeDegreeId(TransactionManager transactionManager, System.Decimal? _mltCdeDegreeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_INFO_MLT_ORG_TREE key.
		///		FK_MLT_STUD_INFO_MLT_ORG_TREE Description: 
		/// </summary>
		/// <param name="_mltOrgTreeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudInfo objects.</returns>
		public TList<MltStudInfo> GetByMltOrgTreeId(System.Decimal _mltOrgTreeId)
		{
			int count = -1;
			return GetByMltOrgTreeId(_mltOrgTreeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_INFO_MLT_ORG_TREE key.
		///		FK_MLT_STUD_INFO_MLT_ORG_TREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltOrgTreeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudInfo objects.</returns>
		/// <remarks></remarks>
		public TList<MltStudInfo> GetByMltOrgTreeId(TransactionManager transactionManager, System.Decimal _mltOrgTreeId)
		{
			int count = -1;
			return GetByMltOrgTreeId(transactionManager, _mltOrgTreeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_INFO_MLT_ORG_TREE key.
		///		FK_MLT_STUD_INFO_MLT_ORG_TREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltOrgTreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudInfo objects.</returns>
		public TList<MltStudInfo> GetByMltOrgTreeId(TransactionManager transactionManager, System.Decimal _mltOrgTreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByMltOrgTreeId(transactionManager, _mltOrgTreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_INFO_MLT_ORG_TREE key.
		///		fkMltStudInfoMltOrgTree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mltOrgTreeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudInfo objects.</returns>
		public TList<MltStudInfo> GetByMltOrgTreeId(System.Decimal _mltOrgTreeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByMltOrgTreeId(null, _mltOrgTreeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_INFO_MLT_ORG_TREE key.
		///		fkMltStudInfoMltOrgTree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mltOrgTreeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudInfo objects.</returns>
		public TList<MltStudInfo> GetByMltOrgTreeId(System.Decimal _mltOrgTreeId, int start, int pageLength,out int count)
		{
			return GetByMltOrgTreeId(null, _mltOrgTreeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_STUD_INFO_MLT_ORG_TREE key.
		///		FK_MLT_STUD_INFO_MLT_ORG_TREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltOrgTreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltStudInfo objects.</returns>
		public abstract TList<MltStudInfo> GetByMltOrgTreeId(TransactionManager transactionManager, System.Decimal _mltOrgTreeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.MltStudInfo Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltStudInfoKey key, int start, int pageLength)
		{
			return GetByMltStudInfoId(transactionManager, key.MltStudInfoId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_MLT_STUD_INFO index.
		/// </summary>
		/// <param name="_mltStudInfoId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltStudInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltStudInfo GetByMltStudInfoId(System.Decimal _mltStudInfoId)
		{
			int count = -1;
			return GetByMltStudInfoId(null,_mltStudInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_STUD_INFO index.
		/// </summary>
		/// <param name="_mltStudInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltStudInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltStudInfo GetByMltStudInfoId(System.Decimal _mltStudInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByMltStudInfoId(null, _mltStudInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_STUD_INFO index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltStudInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltStudInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltStudInfo GetByMltStudInfoId(TransactionManager transactionManager, System.Decimal _mltStudInfoId)
		{
			int count = -1;
			return GetByMltStudInfoId(transactionManager, _mltStudInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_STUD_INFO index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltStudInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltStudInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltStudInfo GetByMltStudInfoId(TransactionManager transactionManager, System.Decimal _mltStudInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByMltStudInfoId(transactionManager, _mltStudInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_STUD_INFO index.
		/// </summary>
		/// <param name="_mltStudInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltStudInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltStudInfo GetByMltStudInfoId(System.Decimal _mltStudInfoId, int start, int pageLength, out int count)
		{
			return GetByMltStudInfoId(null, _mltStudInfoId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_STUD_INFO index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltStudInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltStudInfo"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MltStudInfo GetByMltStudInfoId(TransactionManager transactionManager, System.Decimal _mltStudInfoId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_MLT_STUD_INFO index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltStudInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltStudInfo GetByEdAcadYearIdEdCodeSemesterIdEdStudId(System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEdStudId(null,_edAcadYearId, _edCodeSemesterId, _edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MLT_STUD_INFO index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltStudInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltStudInfo GetByEdAcadYearIdEdCodeSemesterIdEdStudId(System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEdStudId(null, _edAcadYearId, _edCodeSemesterId, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MLT_STUD_INFO index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltStudInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltStudInfo GetByEdAcadYearIdEdCodeSemesterIdEdStudId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEdStudId(transactionManager, _edAcadYearId, _edCodeSemesterId, _edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MLT_STUD_INFO index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltStudInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltStudInfo GetByEdAcadYearIdEdCodeSemesterIdEdStudId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEdStudId(transactionManager, _edAcadYearId, _edCodeSemesterId, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MLT_STUD_INFO index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltStudInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltStudInfo GetByEdAcadYearIdEdCodeSemesterIdEdStudId(System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal _edStudId, int start, int pageLength, out int count)
		{
			return GetByEdAcadYearIdEdCodeSemesterIdEdStudId(null, _edAcadYearId, _edCodeSemesterId, _edStudId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MLT_STUD_INFO index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltStudInfo"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MltStudInfo GetByEdAcadYearIdEdCodeSemesterIdEdStudId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal _edStudId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;MltStudInfo&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;MltStudInfo&gt;"/></returns>
		public static TList<MltStudInfo> Fill(IDataReader reader, TList<MltStudInfo> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.MltStudInfo c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("MltStudInfo")
					.Append("|").Append((System.Decimal)reader["MLT_STUD_INFO_ID"]).ToString();
					c = EntityManager.LocateOrCreate<MltStudInfo>(
					key.ToString(), // EntityTrackingKey
					"MltStudInfo",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.MltStudInfo();
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
					c.MltStudInfoId = (System.Decimal)reader["MLT_STUD_INFO_ID"];
					c.OriginalMltStudInfoId = c.MltStudInfoId;
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.EdCodeSemesterId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_ID"];
					c.MltOrgTreeId = (System.Decimal)reader["MLT_ORG_TREE_ID"];
					c.MltCdeDegreeId = Convert.IsDBNull(reader["MLT_CDE_DEGREE_ID"]) ? null : (System.Decimal?)reader["MLT_CDE_DEGREE_ID"];
					c.SeniorityLvl = Convert.IsDBNull(reader["SENIORITY_LVL"]) ? null : (System.Decimal?)reader["SENIORITY_LVL"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MltStudInfo"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MltStudInfo"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.MltStudInfo entity)
		{
			if (!reader.Read()) return;
			
			entity.MltStudInfoId = (System.Decimal)reader[((int)MltStudInfoColumn.MltStudInfoId - 1)];
			entity.OriginalMltStudInfoId = (System.Decimal)reader["MLT_STUD_INFO_ID"];
			entity.EdAcadYearId = (System.Decimal)reader[((int)MltStudInfoColumn.EdAcadYearId - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)MltStudInfoColumn.EdStudId - 1)];
			entity.EdCodeSemesterId = (reader.IsDBNull(((int)MltStudInfoColumn.EdCodeSemesterId - 1)))?null:(System.Decimal?)reader[((int)MltStudInfoColumn.EdCodeSemesterId - 1)];
			entity.MltOrgTreeId = (System.Decimal)reader[((int)MltStudInfoColumn.MltOrgTreeId - 1)];
			entity.MltCdeDegreeId = (reader.IsDBNull(((int)MltStudInfoColumn.MltCdeDegreeId - 1)))?null:(System.Decimal?)reader[((int)MltStudInfoColumn.MltCdeDegreeId - 1)];
			entity.SeniorityLvl = (reader.IsDBNull(((int)MltStudInfoColumn.SeniorityLvl - 1)))?null:(System.Decimal?)reader[((int)MltStudInfoColumn.SeniorityLvl - 1)];
			entity.Notes = (reader.IsDBNull(((int)MltStudInfoColumn.Notes - 1)))?null:(System.String)reader[((int)MltStudInfoColumn.Notes - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MltStudInfo"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MltStudInfo"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.MltStudInfo entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MltStudInfoId = (System.Decimal)dataRow["MLT_STUD_INFO_ID"];
			entity.OriginalMltStudInfoId = (System.Decimal)dataRow["MLT_STUD_INFO_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.EdCodeSemesterId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_ID"];
			entity.MltOrgTreeId = (System.Decimal)dataRow["MLT_ORG_TREE_ID"];
			entity.MltCdeDegreeId = Convert.IsDBNull(dataRow["MLT_CDE_DEGREE_ID"]) ? null : (System.Decimal?)dataRow["MLT_CDE_DEGREE_ID"];
			entity.SeniorityLvl = Convert.IsDBNull(dataRow["SENIORITY_LVL"]) ? null : (System.Decimal?)dataRow["SENIORITY_LVL"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MltStudInfo"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MltStudInfo Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltStudInfo entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region MltCdeDegreeIdSource	
			if (CanDeepLoad(entity, "MltCdeStudDegree|MltCdeDegreeIdSource", deepLoadType, innerList) 
				&& entity.MltCdeDegreeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MltCdeDegreeId ?? 0.0m);
				MltCdeStudDegree tmpEntity = EntityManager.LocateEntity<MltCdeStudDegree>(EntityLocator.ConstructKeyFromPkItems(typeof(MltCdeStudDegree), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MltCdeDegreeIdSource = tmpEntity;
				else
					entity.MltCdeDegreeIdSource = DataRepository.MltCdeStudDegreeProvider.GetByMltCdeDegreeId(transactionManager, (entity.MltCdeDegreeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MltCdeDegreeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MltCdeDegreeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.MltCdeStudDegreeProvider.DeepLoad(transactionManager, entity.MltCdeDegreeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MltCdeDegreeIdSource

			#region MltOrgTreeIdSource	
			if (CanDeepLoad(entity, "MltOrgTree|MltOrgTreeIdSource", deepLoadType, innerList) 
				&& entity.MltOrgTreeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.MltOrgTreeId;
				MltOrgTree tmpEntity = EntityManager.LocateEntity<MltOrgTree>(EntityLocator.ConstructKeyFromPkItems(typeof(MltOrgTree), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MltOrgTreeIdSource = tmpEntity;
				else
					entity.MltOrgTreeIdSource = DataRepository.MltOrgTreeProvider.GetByMltOrgTreeId(transactionManager, entity.MltOrgTreeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MltOrgTreeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MltOrgTreeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.MltOrgTreeProvider.DeepLoad(transactionManager, entity.MltOrgTreeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MltOrgTreeIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.MltStudInfo object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.MltStudInfo instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MltStudInfo Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltStudInfo entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
			}
			#endregion 
			
			#region MltCdeDegreeIdSource
			if (CanDeepSave(entity, "MltCdeStudDegree|MltCdeDegreeIdSource", deepSaveType, innerList) 
				&& entity.MltCdeDegreeIdSource != null)
			{
				DataRepository.MltCdeStudDegreeProvider.Save(transactionManager, entity.MltCdeDegreeIdSource);
				entity.MltCdeDegreeId = entity.MltCdeDegreeIdSource.MltCdeDegreeId;
			}
			#endregion 
			
			#region MltOrgTreeIdSource
			if (CanDeepSave(entity, "MltOrgTree|MltOrgTreeIdSource", deepSaveType, innerList) 
				&& entity.MltOrgTreeIdSource != null)
			{
				DataRepository.MltOrgTreeProvider.Save(transactionManager, entity.MltOrgTreeIdSource);
				entity.MltOrgTreeId = entity.MltOrgTreeIdSource.MltOrgTreeId;
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
	
	#region MltStudInfoChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.MltStudInfo</c>
	///</summary>
	public enum MltStudInfoChildEntityTypes
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
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>MltCdeStudDegree</c> at MltCdeDegreeIdSource
		///</summary>
		[ChildEntityType(typeof(MltCdeStudDegree))]
		MltCdeStudDegree,
		
		///<summary>
		/// Composite Property for <c>MltOrgTree</c> at MltOrgTreeIdSource
		///</summary>
		[ChildEntityType(typeof(MltOrgTree))]
		MltOrgTree,
	}
	
	#endregion MltStudInfoChildEntityTypes
	
	#region MltStudInfoFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;MltStudInfoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MltStudInfo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MltStudInfoFilterBuilder : SqlFilterBuilder<MltStudInfoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MltStudInfoFilterBuilder class.
		/// </summary>
		public MltStudInfoFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MltStudInfoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MltStudInfoFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MltStudInfoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MltStudInfoFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MltStudInfoFilterBuilder
	
	#region MltStudInfoParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;MltStudInfoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MltStudInfo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MltStudInfoParameterBuilder : ParameterizedSqlFilterBuilder<MltStudInfoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MltStudInfoParameterBuilder class.
		/// </summary>
		public MltStudInfoParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MltStudInfoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MltStudInfoParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MltStudInfoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MltStudInfoParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MltStudInfoParameterBuilder
	
	#region MltStudInfoSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;MltStudInfoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MltStudInfo"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class MltStudInfoSortBuilder : SqlSortBuilder<MltStudInfoColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MltStudInfoSqlSortBuilder class.
		/// </summary>
		public MltStudInfoSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion MltStudInfoSortBuilder
	
} // end namespace
