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
	/// This class is the base class for any <see cref="TrnsLineProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class TrnsLineProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.TrnsLine, UMIS_VER2.BusinessLyer.TrnsLineKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.TrnsLineKey key)
		{
			return Delete(transactionManager, key.TrnsLineId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_trnsLineId">خطوط الباصات. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _trnsLineId)
		{
			return Delete(null, _trnsLineId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsLineId">خطوط الباصات. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _trnsLineId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_ED_ACAD_YEAR key.
		///		FK_TRNS_LINE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLine objects.</returns>
		public TList<TrnsLine> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_ED_ACAD_YEAR key.
		///		FK_TRNS_LINE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLine objects.</returns>
		/// <remarks></remarks>
		public TList<TrnsLine> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_ED_ACAD_YEAR key.
		///		FK_TRNS_LINE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLine objects.</returns>
		public TList<TrnsLine> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_ED_ACAD_YEAR key.
		///		fkTrnsLineEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLine objects.</returns>
		public TList<TrnsLine> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_ED_ACAD_YEAR key.
		///		fkTrnsLineEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLine objects.</returns>
		public TList<TrnsLine> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_ED_ACAD_YEAR key.
		///		FK_TRNS_LINE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLine objects.</returns>
		public abstract TList<TrnsLine> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_ED_CODE_SEMESTER key.
		///		FK_TRNS_LINE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLine objects.</returns>
		public TList<TrnsLine> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_ED_CODE_SEMESTER key.
		///		FK_TRNS_LINE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLine objects.</returns>
		/// <remarks></remarks>
		public TList<TrnsLine> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_ED_CODE_SEMESTER key.
		///		FK_TRNS_LINE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLine objects.</returns>
		public TList<TrnsLine> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_ED_CODE_SEMESTER key.
		///		fkTrnsLineEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLine objects.</returns>
		public TList<TrnsLine> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_ED_CODE_SEMESTER key.
		///		fkTrnsLineEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLine objects.</returns>
		public TList<TrnsLine> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_ED_CODE_SEMESTER key.
		///		FK_TRNS_LINE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLine objects.</returns>
		public abstract TList<TrnsLine> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_GS_CDE_CAMPUS key.
		///		FK_TRNS_LINE_GS_CDE_CAMPUS Description: 
		/// </summary>
		/// <param name="_gsCdeCampusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLine objects.</returns>
		public TList<TrnsLine> GetByGsCdeCampusId(System.Decimal? _gsCdeCampusId)
		{
			int count = -1;
			return GetByGsCdeCampusId(_gsCdeCampusId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_GS_CDE_CAMPUS key.
		///		FK_TRNS_LINE_GS_CDE_CAMPUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeCampusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLine objects.</returns>
		/// <remarks></remarks>
		public TList<TrnsLine> GetByGsCdeCampusId(TransactionManager transactionManager, System.Decimal? _gsCdeCampusId)
		{
			int count = -1;
			return GetByGsCdeCampusId(transactionManager, _gsCdeCampusId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_GS_CDE_CAMPUS key.
		///		FK_TRNS_LINE_GS_CDE_CAMPUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeCampusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLine objects.</returns>
		public TList<TrnsLine> GetByGsCdeCampusId(TransactionManager transactionManager, System.Decimal? _gsCdeCampusId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeCampusId(transactionManager, _gsCdeCampusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_GS_CDE_CAMPUS key.
		///		fkTrnsLineGsCdeCampus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeCampusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLine objects.</returns>
		public TList<TrnsLine> GetByGsCdeCampusId(System.Decimal? _gsCdeCampusId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeCampusId(null, _gsCdeCampusId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_GS_CDE_CAMPUS key.
		///		fkTrnsLineGsCdeCampus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeCampusId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLine objects.</returns>
		public TList<TrnsLine> GetByGsCdeCampusId(System.Decimal? _gsCdeCampusId, int start, int pageLength,out int count)
		{
			return GetByGsCdeCampusId(null, _gsCdeCampusId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_GS_CDE_CAMPUS key.
		///		FK_TRNS_LINE_GS_CDE_CAMPUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeCampusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLine objects.</returns>
		public abstract TList<TrnsLine> GetByGsCdeCampusId(TransactionManager transactionManager, System.Decimal? _gsCdeCampusId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_GS_COUNTRY_NODE key.
		///		FK_TRNS_LINE_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="_gsCountryNodeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLine objects.</returns>
		public TList<TrnsLine> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(_gsCountryNodeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_GS_COUNTRY_NODE key.
		///		FK_TRNS_LINE_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLine objects.</returns>
		/// <remarks></remarks>
		public TList<TrnsLine> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_GS_COUNTRY_NODE key.
		///		FK_TRNS_LINE_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLine objects.</returns>
		public TList<TrnsLine> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_GS_COUNTRY_NODE key.
		///		fkTrnsLineGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLine objects.</returns>
		public TList<TrnsLine> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_GS_COUNTRY_NODE key.
		///		fkTrnsLineGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLine objects.</returns>
		public TList<TrnsLine> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength,out int count)
		{
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_GS_COUNTRY_NODE key.
		///		FK_TRNS_LINE_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLine objects.</returns>
		public abstract TList<TrnsLine> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_TRNS_CDE_BUS key.
		///		FK_TRNS_LINE_TRNS_CDE_BUS Description: 
		/// </summary>
		/// <param name="_trnsCdeBusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLine objects.</returns>
		public TList<TrnsLine> GetByTrnsCdeBusId(System.Decimal? _trnsCdeBusId)
		{
			int count = -1;
			return GetByTrnsCdeBusId(_trnsCdeBusId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_TRNS_CDE_BUS key.
		///		FK_TRNS_LINE_TRNS_CDE_BUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsCdeBusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLine objects.</returns>
		/// <remarks></remarks>
		public TList<TrnsLine> GetByTrnsCdeBusId(TransactionManager transactionManager, System.Decimal? _trnsCdeBusId)
		{
			int count = -1;
			return GetByTrnsCdeBusId(transactionManager, _trnsCdeBusId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_TRNS_CDE_BUS key.
		///		FK_TRNS_LINE_TRNS_CDE_BUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsCdeBusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLine objects.</returns>
		public TList<TrnsLine> GetByTrnsCdeBusId(TransactionManager transactionManager, System.Decimal? _trnsCdeBusId, int start, int pageLength)
		{
			int count = -1;
			return GetByTrnsCdeBusId(transactionManager, _trnsCdeBusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_TRNS_CDE_BUS key.
		///		fkTrnsLineTrnsCdeBus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_trnsCdeBusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLine objects.</returns>
		public TList<TrnsLine> GetByTrnsCdeBusId(System.Decimal? _trnsCdeBusId, int start, int pageLength)
		{
			int count =  -1;
			return GetByTrnsCdeBusId(null, _trnsCdeBusId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_TRNS_CDE_BUS key.
		///		fkTrnsLineTrnsCdeBus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_trnsCdeBusId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLine objects.</returns>
		public TList<TrnsLine> GetByTrnsCdeBusId(System.Decimal? _trnsCdeBusId, int start, int pageLength,out int count)
		{
			return GetByTrnsCdeBusId(null, _trnsCdeBusId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_TRNS_CDE_BUS key.
		///		FK_TRNS_LINE_TRNS_CDE_BUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsCdeBusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLine objects.</returns>
		public abstract TList<TrnsLine> GetByTrnsCdeBusId(TransactionManager transactionManager, System.Decimal? _trnsCdeBusId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_TRNS_CDE_DRVR key.
		///		FK_TRNS_LINE_TRNS_CDE_DRVR Description: 
		/// </summary>
		/// <param name="_trnsCdeDrvrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLine objects.</returns>
		public TList<TrnsLine> GetByTrnsCdeDrvrId(System.Decimal? _trnsCdeDrvrId)
		{
			int count = -1;
			return GetByTrnsCdeDrvrId(_trnsCdeDrvrId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_TRNS_CDE_DRVR key.
		///		FK_TRNS_LINE_TRNS_CDE_DRVR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsCdeDrvrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLine objects.</returns>
		/// <remarks></remarks>
		public TList<TrnsLine> GetByTrnsCdeDrvrId(TransactionManager transactionManager, System.Decimal? _trnsCdeDrvrId)
		{
			int count = -1;
			return GetByTrnsCdeDrvrId(transactionManager, _trnsCdeDrvrId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_TRNS_CDE_DRVR key.
		///		FK_TRNS_LINE_TRNS_CDE_DRVR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsCdeDrvrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLine objects.</returns>
		public TList<TrnsLine> GetByTrnsCdeDrvrId(TransactionManager transactionManager, System.Decimal? _trnsCdeDrvrId, int start, int pageLength)
		{
			int count = -1;
			return GetByTrnsCdeDrvrId(transactionManager, _trnsCdeDrvrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_TRNS_CDE_DRVR key.
		///		fkTrnsLineTrnsCdeDrvr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_trnsCdeDrvrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLine objects.</returns>
		public TList<TrnsLine> GetByTrnsCdeDrvrId(System.Decimal? _trnsCdeDrvrId, int start, int pageLength)
		{
			int count =  -1;
			return GetByTrnsCdeDrvrId(null, _trnsCdeDrvrId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_TRNS_CDE_DRVR key.
		///		fkTrnsLineTrnsCdeDrvr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_trnsCdeDrvrId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLine objects.</returns>
		public TList<TrnsLine> GetByTrnsCdeDrvrId(System.Decimal? _trnsCdeDrvrId, int start, int pageLength,out int count)
		{
			return GetByTrnsCdeDrvrId(null, _trnsCdeDrvrId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_TRNS_CDE_DRVR key.
		///		FK_TRNS_LINE_TRNS_CDE_DRVR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsCdeDrvrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLine objects.</returns>
		public abstract TList<TrnsLine> GetByTrnsCdeDrvrId(TransactionManager transactionManager, System.Decimal? _trnsCdeDrvrId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.TrnsLine Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.TrnsLineKey key, int start, int pageLength)
		{
			return GetByTrnsLineId(transactionManager, key.TrnsLineId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_TRNS_LINE_1 index.
		/// </summary>
		/// <param name="_trnsLineId">خطوط الباصات</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsLine"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsLine GetByTrnsLineId(System.Decimal _trnsLineId)
		{
			int count = -1;
			return GetByTrnsLineId(null,_trnsLineId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_LINE_1 index.
		/// </summary>
		/// <param name="_trnsLineId">خطوط الباصات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsLine"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsLine GetByTrnsLineId(System.Decimal _trnsLineId, int start, int pageLength)
		{
			int count = -1;
			return GetByTrnsLineId(null, _trnsLineId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_LINE_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsLineId">خطوط الباصات</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsLine"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsLine GetByTrnsLineId(TransactionManager transactionManager, System.Decimal _trnsLineId)
		{
			int count = -1;
			return GetByTrnsLineId(transactionManager, _trnsLineId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_LINE_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsLineId">خطوط الباصات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsLine"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsLine GetByTrnsLineId(TransactionManager transactionManager, System.Decimal _trnsLineId, int start, int pageLength)
		{
			int count = -1;
			return GetByTrnsLineId(transactionManager, _trnsLineId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_LINE_1 index.
		/// </summary>
		/// <param name="_trnsLineId">خطوط الباصات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsLine"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsLine GetByTrnsLineId(System.Decimal _trnsLineId, int start, int pageLength, out int count)
		{
			return GetByTrnsLineId(null, _trnsLineId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_LINE_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsLineId">خطوط الباصات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsLine"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.TrnsLine GetByTrnsLineId(TransactionManager transactionManager, System.Decimal _trnsLineId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_TRNS_LINE_AR index.
		/// </summary>
		/// <param name="_lineDescrAr"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsLine"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsLine GetByLineDescrArEdAcadYearIdEdCodeSemesterId(System.String _lineDescrAr, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByLineDescrArEdAcadYearIdEdCodeSemesterId(null,_lineDescrAr, _edAcadYearId, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_LINE_AR index.
		/// </summary>
		/// <param name="_lineDescrAr"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsLine"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsLine GetByLineDescrArEdAcadYearIdEdCodeSemesterId(System.String _lineDescrAr, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByLineDescrArEdAcadYearIdEdCodeSemesterId(null, _lineDescrAr, _edAcadYearId, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_LINE_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_lineDescrAr"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsLine"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsLine GetByLineDescrArEdAcadYearIdEdCodeSemesterId(TransactionManager transactionManager, System.String _lineDescrAr, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByLineDescrArEdAcadYearIdEdCodeSemesterId(transactionManager, _lineDescrAr, _edAcadYearId, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_LINE_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_lineDescrAr"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsLine"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsLine GetByLineDescrArEdAcadYearIdEdCodeSemesterId(TransactionManager transactionManager, System.String _lineDescrAr, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByLineDescrArEdAcadYearIdEdCodeSemesterId(transactionManager, _lineDescrAr, _edAcadYearId, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_LINE_AR index.
		/// </summary>
		/// <param name="_lineDescrAr"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsLine"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsLine GetByLineDescrArEdAcadYearIdEdCodeSemesterId(System.String _lineDescrAr, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count)
		{
			return GetByLineDescrArEdAcadYearIdEdCodeSemesterId(null, _lineDescrAr, _edAcadYearId, _edCodeSemesterId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_LINE_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_lineDescrAr"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsLine"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.TrnsLine GetByLineDescrArEdAcadYearIdEdCodeSemesterId(TransactionManager transactionManager, System.String _lineDescrAr, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_TRNS_LINE_EN index.
		/// </summary>
		/// <param name="_lineDescrEn"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsLine"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsLine GetByLineDescrEnEdAcadYearIdEdCodeSemesterId(System.String _lineDescrEn, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByLineDescrEnEdAcadYearIdEdCodeSemesterId(null,_lineDescrEn, _edAcadYearId, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_LINE_EN index.
		/// </summary>
		/// <param name="_lineDescrEn"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsLine"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsLine GetByLineDescrEnEdAcadYearIdEdCodeSemesterId(System.String _lineDescrEn, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByLineDescrEnEdAcadYearIdEdCodeSemesterId(null, _lineDescrEn, _edAcadYearId, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_LINE_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_lineDescrEn"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsLine"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsLine GetByLineDescrEnEdAcadYearIdEdCodeSemesterId(TransactionManager transactionManager, System.String _lineDescrEn, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByLineDescrEnEdAcadYearIdEdCodeSemesterId(transactionManager, _lineDescrEn, _edAcadYearId, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_LINE_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_lineDescrEn"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsLine"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsLine GetByLineDescrEnEdAcadYearIdEdCodeSemesterId(TransactionManager transactionManager, System.String _lineDescrEn, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByLineDescrEnEdAcadYearIdEdCodeSemesterId(transactionManager, _lineDescrEn, _edAcadYearId, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_LINE_EN index.
		/// </summary>
		/// <param name="_lineDescrEn"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsLine"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsLine GetByLineDescrEnEdAcadYearIdEdCodeSemesterId(System.String _lineDescrEn, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count)
		{
			return GetByLineDescrEnEdAcadYearIdEdCodeSemesterId(null, _lineDescrEn, _edAcadYearId, _edCodeSemesterId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_LINE_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_lineDescrEn"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsLine"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.TrnsLine GetByLineDescrEnEdAcadYearIdEdCodeSemesterId(TransactionManager transactionManager, System.String _lineDescrEn, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;TrnsLine&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;TrnsLine&gt;"/></returns>
		public static TList<TrnsLine> Fill(IDataReader reader, TList<TrnsLine> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.TrnsLine c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("TrnsLine")
					.Append("|").Append((System.Decimal)reader["TRNS_LINE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<TrnsLine>(
					key.ToString(), // EntityTrackingKey
					"TrnsLine",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.TrnsLine();
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
					c.TrnsLineId = (System.Decimal)reader["TRNS_LINE_ID"];
					c.OriginalTrnsLineId = c.TrnsLineId;
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_ID"];
					c.LineNo = (System.Decimal)reader["LINE_NO"];
					c.LineDescrEn = (System.String)reader["LINE_DESCR_EN"];
					c.LineDescrAr = (System.String)reader["LINE_DESCR_AR"];
					c.TrnsCdeDrvrId = Convert.IsDBNull(reader["TRNS_CDE_DRVR_ID"]) ? null : (System.Decimal?)reader["TRNS_CDE_DRVR_ID"];
					c.TrnsCdeBusId = Convert.IsDBNull(reader["TRNS_CDE_BUS_ID"]) ? null : (System.Decimal?)reader["TRNS_CDE_BUS_ID"];
					c.GsCdeCampusId = Convert.IsDBNull(reader["GS_CDE_CAMPUS_ID"]) ? null : (System.Decimal?)reader["GS_CDE_CAMPUS_ID"];
					c.GsCountryNodeId = Convert.IsDBNull(reader["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)reader["GS_COUNTRY_NODE_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.TrnsLine"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.TrnsLine"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.TrnsLine entity)
		{
			if (!reader.Read()) return;
			
			entity.TrnsLineId = (System.Decimal)reader[((int)TrnsLineColumn.TrnsLineId - 1)];
			entity.OriginalTrnsLineId = (System.Decimal)reader["TRNS_LINE_ID"];
			entity.EdAcadYearId = (System.Decimal)reader[((int)TrnsLineColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (reader.IsDBNull(((int)TrnsLineColumn.EdCodeSemesterId - 1)))?null:(System.Decimal?)reader[((int)TrnsLineColumn.EdCodeSemesterId - 1)];
			entity.LineNo = (System.Decimal)reader[((int)TrnsLineColumn.LineNo - 1)];
			entity.LineDescrEn = (System.String)reader[((int)TrnsLineColumn.LineDescrEn - 1)];
			entity.LineDescrAr = (System.String)reader[((int)TrnsLineColumn.LineDescrAr - 1)];
			entity.TrnsCdeDrvrId = (reader.IsDBNull(((int)TrnsLineColumn.TrnsCdeDrvrId - 1)))?null:(System.Decimal?)reader[((int)TrnsLineColumn.TrnsCdeDrvrId - 1)];
			entity.TrnsCdeBusId = (reader.IsDBNull(((int)TrnsLineColumn.TrnsCdeBusId - 1)))?null:(System.Decimal?)reader[((int)TrnsLineColumn.TrnsCdeBusId - 1)];
			entity.GsCdeCampusId = (reader.IsDBNull(((int)TrnsLineColumn.GsCdeCampusId - 1)))?null:(System.Decimal?)reader[((int)TrnsLineColumn.GsCdeCampusId - 1)];
			entity.GsCountryNodeId = (reader.IsDBNull(((int)TrnsLineColumn.GsCountryNodeId - 1)))?null:(System.Decimal?)reader[((int)TrnsLineColumn.GsCountryNodeId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.TrnsLine"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.TrnsLine"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.TrnsLine entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.TrnsLineId = (System.Decimal)dataRow["TRNS_LINE_ID"];
			entity.OriginalTrnsLineId = (System.Decimal)dataRow["TRNS_LINE_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_ID"];
			entity.LineNo = (System.Decimal)dataRow["LINE_NO"];
			entity.LineDescrEn = (System.String)dataRow["LINE_DESCR_EN"];
			entity.LineDescrAr = (System.String)dataRow["LINE_DESCR_AR"];
			entity.TrnsCdeDrvrId = Convert.IsDBNull(dataRow["TRNS_CDE_DRVR_ID"]) ? null : (System.Decimal?)dataRow["TRNS_CDE_DRVR_ID"];
			entity.TrnsCdeBusId = Convert.IsDBNull(dataRow["TRNS_CDE_BUS_ID"]) ? null : (System.Decimal?)dataRow["TRNS_CDE_BUS_ID"];
			entity.GsCdeCampusId = Convert.IsDBNull(dataRow["GS_CDE_CAMPUS_ID"]) ? null : (System.Decimal?)dataRow["GS_CDE_CAMPUS_ID"];
			entity.GsCountryNodeId = Convert.IsDBNull(dataRow["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)dataRow["GS_COUNTRY_NODE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.TrnsLine"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.TrnsLine Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.TrnsLine entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region GsCdeCampusIdSource	
			if (CanDeepLoad(entity, "GsCdeCampus|GsCdeCampusIdSource", deepLoadType, innerList) 
				&& entity.GsCdeCampusIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCdeCampusId ?? 0.0m);
				GsCdeCampus tmpEntity = EntityManager.LocateEntity<GsCdeCampus>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeCampus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeCampusIdSource = tmpEntity;
				else
					entity.GsCdeCampusIdSource = DataRepository.GsCdeCampusProvider.GetByGsCdeCampusId(transactionManager, (entity.GsCdeCampusId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeCampusIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeCampusIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeCampusProvider.DeepLoad(transactionManager, entity.GsCdeCampusIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeCampusIdSource

			#region GsCountryNodeIdSource	
			if (CanDeepLoad(entity, "GsCountryNode|GsCountryNodeIdSource", deepLoadType, innerList) 
				&& entity.GsCountryNodeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCountryNodeId ?? 0.0m);
				GsCountryNode tmpEntity = EntityManager.LocateEntity<GsCountryNode>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCountryNode), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCountryNodeIdSource = tmpEntity;
				else
					entity.GsCountryNodeIdSource = DataRepository.GsCountryNodeProvider.GetByGsCountryNodeId(transactionManager, (entity.GsCountryNodeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCountryNodeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCountryNodeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCountryNodeProvider.DeepLoad(transactionManager, entity.GsCountryNodeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCountryNodeIdSource

			#region TrnsCdeBusIdSource	
			if (CanDeepLoad(entity, "TrnsCdeBus|TrnsCdeBusIdSource", deepLoadType, innerList) 
				&& entity.TrnsCdeBusIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.TrnsCdeBusId ?? 0.0m);
				TrnsCdeBus tmpEntity = EntityManager.LocateEntity<TrnsCdeBus>(EntityLocator.ConstructKeyFromPkItems(typeof(TrnsCdeBus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.TrnsCdeBusIdSource = tmpEntity;
				else
					entity.TrnsCdeBusIdSource = DataRepository.TrnsCdeBusProvider.GetByTrnsCdeBusId(transactionManager, (entity.TrnsCdeBusId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'TrnsCdeBusIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.TrnsCdeBusIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.TrnsCdeBusProvider.DeepLoad(transactionManager, entity.TrnsCdeBusIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion TrnsCdeBusIdSource

			#region TrnsCdeDrvrIdSource	
			if (CanDeepLoad(entity, "TrnsCdeDrvr|TrnsCdeDrvrIdSource", deepLoadType, innerList) 
				&& entity.TrnsCdeDrvrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.TrnsCdeDrvrId ?? 0.0m);
				TrnsCdeDrvr tmpEntity = EntityManager.LocateEntity<TrnsCdeDrvr>(EntityLocator.ConstructKeyFromPkItems(typeof(TrnsCdeDrvr), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.TrnsCdeDrvrIdSource = tmpEntity;
				else
					entity.TrnsCdeDrvrIdSource = DataRepository.TrnsCdeDrvrProvider.GetByTrnsCdeDrvrId(transactionManager, (entity.TrnsCdeDrvrId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'TrnsCdeDrvrIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.TrnsCdeDrvrIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.TrnsCdeDrvrProvider.DeepLoad(transactionManager, entity.TrnsCdeDrvrIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion TrnsCdeDrvrIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByTrnsLineId methods when available
			
			#region TrnsLineStopCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<TrnsLineStop>|TrnsLineStopCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'TrnsLineStopCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.TrnsLineStopCollection = DataRepository.TrnsLineStopProvider.GetByTrnsLineId(transactionManager, entity.TrnsLineId);

				if (deep && entity.TrnsLineStopCollection.Count > 0)
				{
					deepHandles.Add("TrnsLineStopCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<TrnsLineStop>) DataRepository.TrnsLineStopProvider.DeepLoad,
						new object[] { transactionManager, entity.TrnsLineStopCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region TrnsStudReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<TrnsStudReq>|TrnsStudReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'TrnsStudReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.TrnsStudReqCollection = DataRepository.TrnsStudReqProvider.GetByTrnsLineId(transactionManager, entity.TrnsLineId);

				if (deep && entity.TrnsStudReqCollection.Count > 0)
				{
					deepHandles.Add("TrnsStudReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<TrnsStudReq>) DataRepository.TrnsStudReqProvider.DeepLoad,
						new object[] { transactionManager, entity.TrnsStudReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeBusLineItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeBusLineItem>|FeeBusLineItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeBusLineItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeBusLineItemCollection = DataRepository.FeeBusLineItemProvider.GetByTrnsLineId(transactionManager, entity.TrnsLineId);

				if (deep && entity.FeeBusLineItemCollection.Count > 0)
				{
					deepHandles.Add("FeeBusLineItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeBusLineItem>) DataRepository.FeeBusLineItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeBusLineItemCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.TrnsLine object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.TrnsLine instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.TrnsLine Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.TrnsLine entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region GsCdeCampusIdSource
			if (CanDeepSave(entity, "GsCdeCampus|GsCdeCampusIdSource", deepSaveType, innerList) 
				&& entity.GsCdeCampusIdSource != null)
			{
				DataRepository.GsCdeCampusProvider.Save(transactionManager, entity.GsCdeCampusIdSource);
				entity.GsCdeCampusId = entity.GsCdeCampusIdSource.GsCdeCampusId;
			}
			#endregion 
			
			#region GsCountryNodeIdSource
			if (CanDeepSave(entity, "GsCountryNode|GsCountryNodeIdSource", deepSaveType, innerList) 
				&& entity.GsCountryNodeIdSource != null)
			{
				DataRepository.GsCountryNodeProvider.Save(transactionManager, entity.GsCountryNodeIdSource);
				entity.GsCountryNodeId = entity.GsCountryNodeIdSource.GsCountryNodeId;
			}
			#endregion 
			
			#region TrnsCdeBusIdSource
			if (CanDeepSave(entity, "TrnsCdeBus|TrnsCdeBusIdSource", deepSaveType, innerList) 
				&& entity.TrnsCdeBusIdSource != null)
			{
				DataRepository.TrnsCdeBusProvider.Save(transactionManager, entity.TrnsCdeBusIdSource);
				entity.TrnsCdeBusId = entity.TrnsCdeBusIdSource.TrnsCdeBusId;
			}
			#endregion 
			
			#region TrnsCdeDrvrIdSource
			if (CanDeepSave(entity, "TrnsCdeDrvr|TrnsCdeDrvrIdSource", deepSaveType, innerList) 
				&& entity.TrnsCdeDrvrIdSource != null)
			{
				DataRepository.TrnsCdeDrvrProvider.Save(transactionManager, entity.TrnsCdeDrvrIdSource);
				entity.TrnsCdeDrvrId = entity.TrnsCdeDrvrIdSource.TrnsCdeDrvrId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<TrnsLineStop>
				if (CanDeepSave(entity.TrnsLineStopCollection, "List<TrnsLineStop>|TrnsLineStopCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(TrnsLineStop child in entity.TrnsLineStopCollection)
					{
						if(child.TrnsLineIdSource != null)
						{
							child.TrnsLineId = child.TrnsLineIdSource.TrnsLineId;
						}
						else
						{
							child.TrnsLineId = entity.TrnsLineId;
						}

					}

					if (entity.TrnsLineStopCollection.Count > 0 || entity.TrnsLineStopCollection.DeletedItems.Count > 0)
					{
						//DataRepository.TrnsLineStopProvider.Save(transactionManager, entity.TrnsLineStopCollection);
						
						deepHandles.Add("TrnsLineStopCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< TrnsLineStop >) DataRepository.TrnsLineStopProvider.DeepSave,
							new object[] { transactionManager, entity.TrnsLineStopCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<TrnsStudReq>
				if (CanDeepSave(entity.TrnsStudReqCollection, "List<TrnsStudReq>|TrnsStudReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(TrnsStudReq child in entity.TrnsStudReqCollection)
					{
						if(child.TrnsLineIdSource != null)
						{
							child.TrnsLineId = child.TrnsLineIdSource.TrnsLineId;
						}
						else
						{
							child.TrnsLineId = entity.TrnsLineId;
						}

					}

					if (entity.TrnsStudReqCollection.Count > 0 || entity.TrnsStudReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.TrnsStudReqProvider.Save(transactionManager, entity.TrnsStudReqCollection);
						
						deepHandles.Add("TrnsStudReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< TrnsStudReq >) DataRepository.TrnsStudReqProvider.DeepSave,
							new object[] { transactionManager, entity.TrnsStudReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeBusLineItem>
				if (CanDeepSave(entity.FeeBusLineItemCollection, "List<FeeBusLineItem>|FeeBusLineItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeBusLineItem child in entity.FeeBusLineItemCollection)
					{
						if(child.TrnsLineIdSource != null)
						{
							child.TrnsLineId = child.TrnsLineIdSource.TrnsLineId;
						}
						else
						{
							child.TrnsLineId = entity.TrnsLineId;
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
	
	#region TrnsLineChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.TrnsLine</c>
	///</summary>
	public enum TrnsLineChildEntityTypes
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
		/// Composite Property for <c>GsCdeCampus</c> at GsCdeCampusIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeCampus))]
		GsCdeCampus,
		
		///<summary>
		/// Composite Property for <c>GsCountryNode</c> at GsCountryNodeIdSource
		///</summary>
		[ChildEntityType(typeof(GsCountryNode))]
		GsCountryNode,
		
		///<summary>
		/// Composite Property for <c>TrnsCdeBus</c> at TrnsCdeBusIdSource
		///</summary>
		[ChildEntityType(typeof(TrnsCdeBus))]
		TrnsCdeBus,
		
		///<summary>
		/// Composite Property for <c>TrnsCdeDrvr</c> at TrnsCdeDrvrIdSource
		///</summary>
		[ChildEntityType(typeof(TrnsCdeDrvr))]
		TrnsCdeDrvr,
		///<summary>
		/// Collection of <c>TrnsLine</c> as OneToMany for TrnsLineStopCollection
		///</summary>
		[ChildEntityType(typeof(TList<TrnsLineStop>))]
		TrnsLineStopCollection,
		///<summary>
		/// Collection of <c>TrnsLine</c> as OneToMany for TrnsStudReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<TrnsStudReq>))]
		TrnsStudReqCollection,
		///<summary>
		/// Collection of <c>TrnsLine</c> as OneToMany for FeeBusLineItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeBusLineItem>))]
		FeeBusLineItemCollection,
	}
	
	#endregion TrnsLineChildEntityTypes
	
	#region TrnsLineFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;TrnsLineColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrnsLine"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrnsLineFilterBuilder : SqlFilterBuilder<TrnsLineColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrnsLineFilterBuilder class.
		/// </summary>
		public TrnsLineFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TrnsLineFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TrnsLineFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TrnsLineFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TrnsLineFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TrnsLineFilterBuilder
	
	#region TrnsLineParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;TrnsLineColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrnsLine"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrnsLineParameterBuilder : ParameterizedSqlFilterBuilder<TrnsLineColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrnsLineParameterBuilder class.
		/// </summary>
		public TrnsLineParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TrnsLineParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TrnsLineParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TrnsLineParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TrnsLineParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TrnsLineParameterBuilder
	
	#region TrnsLineSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;TrnsLineColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrnsLine"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class TrnsLineSortBuilder : SqlSortBuilder<TrnsLineColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrnsLineSqlSortBuilder class.
		/// </summary>
		public TrnsLineSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion TrnsLineSortBuilder
	
} // end namespace
