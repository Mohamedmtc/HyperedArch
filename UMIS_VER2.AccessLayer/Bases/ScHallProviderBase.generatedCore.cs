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
	/// This class is the base class for any <see cref="ScHallProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScHallProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.ScHall, UMIS_VER2.BusinessLyer.ScHallKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScHallKey key)
		{
			return Delete(transactionManager, key.ScHallId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_scHallId">القاعات. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _scHallId)
		{
			return Delete(null, _scHallId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId">القاعات. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _scHallId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_HALL_SC_BUILDING key.
		///		FK_SC_HALL_SC_BUILDING Description: 
		/// </summary>
		/// <param name="_scBuildingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHall objects.</returns>
		public TList<ScHall> GetByScBuildingId(System.Decimal _scBuildingId)
		{
			int count = -1;
			return GetByScBuildingId(_scBuildingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_HALL_SC_BUILDING key.
		///		FK_SC_HALL_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHall objects.</returns>
		/// <remarks></remarks>
		public TList<ScHall> GetByScBuildingId(TransactionManager transactionManager, System.Decimal _scBuildingId)
		{
			int count = -1;
			return GetByScBuildingId(transactionManager, _scBuildingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_HALL_SC_BUILDING key.
		///		FK_SC_HALL_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHall objects.</returns>
		public TList<ScHall> GetByScBuildingId(TransactionManager transactionManager, System.Decimal _scBuildingId, int start, int pageLength)
		{
			int count = -1;
			return GetByScBuildingId(transactionManager, _scBuildingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_HALL_SC_BUILDING key.
		///		fkScHallScBuilding Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scBuildingId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHall objects.</returns>
		public TList<ScHall> GetByScBuildingId(System.Decimal _scBuildingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScBuildingId(null, _scBuildingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_HALL_SC_BUILDING key.
		///		fkScHallScBuilding Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHall objects.</returns>
		public TList<ScHall> GetByScBuildingId(System.Decimal _scBuildingId, int start, int pageLength,out int count)
		{
			return GetByScBuildingId(null, _scBuildingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_HALL_SC_BUILDING key.
		///		FK_SC_HALL_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHall objects.</returns>
		public abstract TList<ScHall> GetByScBuildingId(TransactionManager transactionManager, System.Decimal _scBuildingId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_HALL_SC_CDE_HALL_TYPE key.
		///		FK_SC_HALL_SC_CDE_HALL_TYPE Description: 
		/// </summary>
		/// <param name="_scCdeHallTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHall objects.</returns>
		public TList<ScHall> GetByScCdeHallTypeId(System.Decimal? _scCdeHallTypeId)
		{
			int count = -1;
			return GetByScCdeHallTypeId(_scCdeHallTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_HALL_SC_CDE_HALL_TYPE key.
		///		FK_SC_HALL_SC_CDE_HALL_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scCdeHallTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHall objects.</returns>
		/// <remarks></remarks>
		public TList<ScHall> GetByScCdeHallTypeId(TransactionManager transactionManager, System.Decimal? _scCdeHallTypeId)
		{
			int count = -1;
			return GetByScCdeHallTypeId(transactionManager, _scCdeHallTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_HALL_SC_CDE_HALL_TYPE key.
		///		FK_SC_HALL_SC_CDE_HALL_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scCdeHallTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHall objects.</returns>
		public TList<ScHall> GetByScCdeHallTypeId(TransactionManager transactionManager, System.Decimal? _scCdeHallTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByScCdeHallTypeId(transactionManager, _scCdeHallTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_HALL_SC_CDE_HALL_TYPE key.
		///		fkScHallScCdeHallType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scCdeHallTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHall objects.</returns>
		public TList<ScHall> GetByScCdeHallTypeId(System.Decimal? _scCdeHallTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScCdeHallTypeId(null, _scCdeHallTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_HALL_SC_CDE_HALL_TYPE key.
		///		fkScHallScCdeHallType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scCdeHallTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHall objects.</returns>
		public TList<ScHall> GetByScCdeHallTypeId(System.Decimal? _scCdeHallTypeId, int start, int pageLength,out int count)
		{
			return GetByScCdeHallTypeId(null, _scCdeHallTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_HALL_SC_CDE_HALL_TYPE key.
		///		FK_SC_HALL_SC_CDE_HALL_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scCdeHallTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHall objects.</returns>
		public abstract TList<ScHall> GetByScCdeHallTypeId(TransactionManager transactionManager, System.Decimal? _scCdeHallTypeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.ScHall Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScHallKey key, int start, int pageLength)
		{
			return GetByScHallId(transactionManager, key.ScHallId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SC_HALL index.
		/// </summary>
		/// <param name="_scHallId">القاعات</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHall"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScHall GetByScHallId(System.Decimal _scHallId)
		{
			int count = -1;
			return GetByScHallId(null,_scHallId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_HALL index.
		/// </summary>
		/// <param name="_scHallId">القاعات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHall"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScHall GetByScHallId(System.Decimal _scHallId, int start, int pageLength)
		{
			int count = -1;
			return GetByScHallId(null, _scHallId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_HALL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId">القاعات</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHall"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScHall GetByScHallId(TransactionManager transactionManager, System.Decimal _scHallId)
		{
			int count = -1;
			return GetByScHallId(transactionManager, _scHallId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_HALL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId">القاعات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHall"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScHall GetByScHallId(TransactionManager transactionManager, System.Decimal _scHallId, int start, int pageLength)
		{
			int count = -1;
			return GetByScHallId(transactionManager, _scHallId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_HALL index.
		/// </summary>
		/// <param name="_scHallId">القاعات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHall"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScHall GetByScHallId(System.Decimal _scHallId, int start, int pageLength, out int count)
		{
			return GetByScHallId(null, _scHallId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_HALL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId">القاعات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHall"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScHall GetByScHallId(TransactionManager transactionManager, System.Decimal _scHallId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SC_HALL index.
		/// </summary>
		/// <param name="_scBuildingId"></param>
		/// <param name="_hallCode"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHall"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScHall GetByScBuildingIdHallCode(System.Decimal _scBuildingId, System.String _hallCode)
		{
			int count = -1;
			return GetByScBuildingIdHallCode(null,_scBuildingId, _hallCode, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_HALL index.
		/// </summary>
		/// <param name="_scBuildingId"></param>
		/// <param name="_hallCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHall"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScHall GetByScBuildingIdHallCode(System.Decimal _scBuildingId, System.String _hallCode, int start, int pageLength)
		{
			int count = -1;
			return GetByScBuildingIdHallCode(null, _scBuildingId, _hallCode, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_HALL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="_hallCode"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHall"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScHall GetByScBuildingIdHallCode(TransactionManager transactionManager, System.Decimal _scBuildingId, System.String _hallCode)
		{
			int count = -1;
			return GetByScBuildingIdHallCode(transactionManager, _scBuildingId, _hallCode, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_HALL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="_hallCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHall"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScHall GetByScBuildingIdHallCode(TransactionManager transactionManager, System.Decimal _scBuildingId, System.String _hallCode, int start, int pageLength)
		{
			int count = -1;
			return GetByScBuildingIdHallCode(transactionManager, _scBuildingId, _hallCode, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_HALL index.
		/// </summary>
		/// <param name="_scBuildingId"></param>
		/// <param name="_hallCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHall"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScHall GetByScBuildingIdHallCode(System.Decimal _scBuildingId, System.String _hallCode, int start, int pageLength, out int count)
		{
			return GetByScBuildingIdHallCode(null, _scBuildingId, _hallCode, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_HALL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="_hallCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHall"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScHall GetByScBuildingIdHallCode(TransactionManager transactionManager, System.Decimal _scBuildingId, System.String _hallCode, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SC_HALL_AR index.
		/// </summary>
		/// <param name="_scBuildingId"></param>
		/// <param name="_descrAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHall"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScHall GetByScBuildingIdDescrAr(System.Decimal _scBuildingId, System.String _descrAr)
		{
			int count = -1;
			return GetByScBuildingIdDescrAr(null,_scBuildingId, _descrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_HALL_AR index.
		/// </summary>
		/// <param name="_scBuildingId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHall"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScHall GetByScBuildingIdDescrAr(System.Decimal _scBuildingId, System.String _descrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByScBuildingIdDescrAr(null, _scBuildingId, _descrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_HALL_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="_descrAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHall"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScHall GetByScBuildingIdDescrAr(TransactionManager transactionManager, System.Decimal _scBuildingId, System.String _descrAr)
		{
			int count = -1;
			return GetByScBuildingIdDescrAr(transactionManager, _scBuildingId, _descrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_HALL_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHall"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScHall GetByScBuildingIdDescrAr(TransactionManager transactionManager, System.Decimal _scBuildingId, System.String _descrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByScBuildingIdDescrAr(transactionManager, _scBuildingId, _descrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_HALL_AR index.
		/// </summary>
		/// <param name="_scBuildingId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHall"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScHall GetByScBuildingIdDescrAr(System.Decimal _scBuildingId, System.String _descrAr, int start, int pageLength, out int count)
		{
			return GetByScBuildingIdDescrAr(null, _scBuildingId, _descrAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_HALL_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHall"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScHall GetByScBuildingIdDescrAr(TransactionManager transactionManager, System.Decimal _scBuildingId, System.String _descrAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SC_HALL_EN index.
		/// </summary>
		/// <param name="_scBuildingId"></param>
		/// <param name="_descrEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHall"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScHall GetByScBuildingIdDescrEn(System.Decimal _scBuildingId, System.String _descrEn)
		{
			int count = -1;
			return GetByScBuildingIdDescrEn(null,_scBuildingId, _descrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_HALL_EN index.
		/// </summary>
		/// <param name="_scBuildingId"></param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHall"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScHall GetByScBuildingIdDescrEn(System.Decimal _scBuildingId, System.String _descrEn, int start, int pageLength)
		{
			int count = -1;
			return GetByScBuildingIdDescrEn(null, _scBuildingId, _descrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_HALL_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="_descrEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHall"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScHall GetByScBuildingIdDescrEn(TransactionManager transactionManager, System.Decimal _scBuildingId, System.String _descrEn)
		{
			int count = -1;
			return GetByScBuildingIdDescrEn(transactionManager, _scBuildingId, _descrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_HALL_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHall"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScHall GetByScBuildingIdDescrEn(TransactionManager transactionManager, System.Decimal _scBuildingId, System.String _descrEn, int start, int pageLength)
		{
			int count = -1;
			return GetByScBuildingIdDescrEn(transactionManager, _scBuildingId, _descrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_HALL_EN index.
		/// </summary>
		/// <param name="_scBuildingId"></param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHall"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScHall GetByScBuildingIdDescrEn(System.Decimal _scBuildingId, System.String _descrEn, int start, int pageLength, out int count)
		{
			return GetByScBuildingIdDescrEn(null, _scBuildingId, _descrEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_HALL_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHall"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScHall GetByScBuildingIdDescrEn(TransactionManager transactionManager, System.Decimal _scBuildingId, System.String _descrEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ScHall&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ScHall&gt;"/></returns>
		public static TList<ScHall> Fill(IDataReader reader, TList<ScHall> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.ScHall c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ScHall")
					.Append("|").Append((System.Decimal)reader["SC_HALL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<ScHall>(
					key.ToString(), // EntityTrackingKey
					"ScHall",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.ScHall();
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
					c.ScHallId = (System.Decimal)reader["SC_HALL_ID"];
					c.OriginalScHallId = c.ScHallId;
					c.ScBuildingId = (System.Decimal)reader["SC_BUILDING_ID"];
					c.HallCode = (System.String)reader["HALL_CODE"];
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.Capacity = (System.Decimal)reader["CAPACITY"];
					c.IsShared = (System.Decimal)reader["IS_SHARED"];
					c.IsActive = (System.Decimal)reader["IS_ACTIVE"];
					c.DescrEn = (System.String)reader["DESCR_EN"];
					c.ExmCapcity = Convert.IsDBNull(reader["EXM_CAPCITY"]) ? null : (System.Decimal?)reader["EXM_CAPCITY"];
					c.CapacityMax = Convert.IsDBNull(reader["CAPACITY_MAX"]) ? null : (System.Decimal?)reader["CAPACITY_MAX"];
					c.Floor = Convert.IsDBNull(reader["FLOOR"]) ? null : (System.String)reader["FLOOR"];
					c.ScCdeHallTypeId = Convert.IsDBNull(reader["SC_CDE_HALL_TYPE_ID"]) ? null : (System.Decimal?)reader["SC_CDE_HALL_TYPE_ID"];
					c.CrsSharedFlg = Convert.IsDBNull(reader["CRS_SHARED_FLG"]) ? null : (System.Boolean?)reader["CRS_SHARED_FLG"];
					c.OnlineFlg = Convert.IsDBNull(reader["ONLINE_FLG"]) ? null : (System.Boolean?)reader["ONLINE_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScHall"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScHall"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.ScHall entity)
		{
			if (!reader.Read()) return;
			
			entity.ScHallId = (System.Decimal)reader[((int)ScHallColumn.ScHallId - 1)];
			entity.OriginalScHallId = (System.Decimal)reader["SC_HALL_ID"];
			entity.ScBuildingId = (System.Decimal)reader[((int)ScHallColumn.ScBuildingId - 1)];
			entity.HallCode = (System.String)reader[((int)ScHallColumn.HallCode - 1)];
			entity.DescrAr = (System.String)reader[((int)ScHallColumn.DescrAr - 1)];
			entity.Capacity = (System.Decimal)reader[((int)ScHallColumn.Capacity - 1)];
			entity.IsShared = (System.Decimal)reader[((int)ScHallColumn.IsShared - 1)];
			entity.IsActive = (System.Decimal)reader[((int)ScHallColumn.IsActive - 1)];
			entity.DescrEn = (System.String)reader[((int)ScHallColumn.DescrEn - 1)];
			entity.ExmCapcity = (reader.IsDBNull(((int)ScHallColumn.ExmCapcity - 1)))?null:(System.Decimal?)reader[((int)ScHallColumn.ExmCapcity - 1)];
			entity.CapacityMax = (reader.IsDBNull(((int)ScHallColumn.CapacityMax - 1)))?null:(System.Decimal?)reader[((int)ScHallColumn.CapacityMax - 1)];
			entity.Floor = (reader.IsDBNull(((int)ScHallColumn.Floor - 1)))?null:(System.String)reader[((int)ScHallColumn.Floor - 1)];
			entity.ScCdeHallTypeId = (reader.IsDBNull(((int)ScHallColumn.ScCdeHallTypeId - 1)))?null:(System.Decimal?)reader[((int)ScHallColumn.ScCdeHallTypeId - 1)];
			entity.CrsSharedFlg = (reader.IsDBNull(((int)ScHallColumn.CrsSharedFlg - 1)))?null:(System.Boolean?)reader[((int)ScHallColumn.CrsSharedFlg - 1)];
			entity.OnlineFlg = (reader.IsDBNull(((int)ScHallColumn.OnlineFlg - 1)))?null:(System.Boolean?)reader[((int)ScHallColumn.OnlineFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScHall"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScHall"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.ScHall entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ScHallId = (System.Decimal)dataRow["SC_HALL_ID"];
			entity.OriginalScHallId = (System.Decimal)dataRow["SC_HALL_ID"];
			entity.ScBuildingId = (System.Decimal)dataRow["SC_BUILDING_ID"];
			entity.HallCode = (System.String)dataRow["HALL_CODE"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.Capacity = (System.Decimal)dataRow["CAPACITY"];
			entity.IsShared = (System.Decimal)dataRow["IS_SHARED"];
			entity.IsActive = (System.Decimal)dataRow["IS_ACTIVE"];
			entity.DescrEn = (System.String)dataRow["DESCR_EN"];
			entity.ExmCapcity = Convert.IsDBNull(dataRow["EXM_CAPCITY"]) ? null : (System.Decimal?)dataRow["EXM_CAPCITY"];
			entity.CapacityMax = Convert.IsDBNull(dataRow["CAPACITY_MAX"]) ? null : (System.Decimal?)dataRow["CAPACITY_MAX"];
			entity.Floor = Convert.IsDBNull(dataRow["FLOOR"]) ? null : (System.String)dataRow["FLOOR"];
			entity.ScCdeHallTypeId = Convert.IsDBNull(dataRow["SC_CDE_HALL_TYPE_ID"]) ? null : (System.Decimal?)dataRow["SC_CDE_HALL_TYPE_ID"];
			entity.CrsSharedFlg = Convert.IsDBNull(dataRow["CRS_SHARED_FLG"]) ? null : (System.Boolean?)dataRow["CRS_SHARED_FLG"];
			entity.OnlineFlg = Convert.IsDBNull(dataRow["ONLINE_FLG"]) ? null : (System.Boolean?)dataRow["ONLINE_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScHall"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScHall Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScHall entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region ScBuildingIdSource	
			if (CanDeepLoad(entity, "ScBuilding|ScBuildingIdSource", deepLoadType, innerList) 
				&& entity.ScBuildingIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.ScBuildingId;
				ScBuilding tmpEntity = EntityManager.LocateEntity<ScBuilding>(EntityLocator.ConstructKeyFromPkItems(typeof(ScBuilding), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScBuildingIdSource = tmpEntity;
				else
					entity.ScBuildingIdSource = DataRepository.ScBuildingProvider.GetByScBuildingId(transactionManager, entity.ScBuildingId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScBuildingIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScBuildingIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScBuildingProvider.DeepLoad(transactionManager, entity.ScBuildingIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScBuildingIdSource

			#region ScCdeHallTypeIdSource	
			if (CanDeepLoad(entity, "ScCdeHallType|ScCdeHallTypeIdSource", deepLoadType, innerList) 
				&& entity.ScCdeHallTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ScCdeHallTypeId ?? 0.0m);
				ScCdeHallType tmpEntity = EntityManager.LocateEntity<ScCdeHallType>(EntityLocator.ConstructKeyFromPkItems(typeof(ScCdeHallType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScCdeHallTypeIdSource = tmpEntity;
				else
					entity.ScCdeHallTypeIdSource = DataRepository.ScCdeHallTypeProvider.GetByScCdeHallTypeId(transactionManager, (entity.ScCdeHallTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScCdeHallTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScCdeHallTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScCdeHallTypeProvider.DeepLoad(transactionManager, entity.ScCdeHallTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScCdeHallTypeIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByScHallId methods when available
			
			#region EdStudCheatCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCheat>|EdStudCheatCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCheatCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCheatCollection = DataRepository.EdStudCheatProvider.GetByScHallId(transactionManager, entity.ScHallId);

				if (deep && entity.EdStudCheatCollection.Count > 0)
				{
					deepHandles.Add("EdStudCheatCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCheat>) DataRepository.EdStudCheatProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCheatCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisDiscussionDateCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisDiscussionDate>|PgThesisDiscussionDateCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisDiscussionDateCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisDiscussionDateCollection = DataRepository.PgThesisDiscussionDateProvider.GetByScHallId(transactionManager, entity.ScHallId);

				if (deep && entity.PgThesisDiscussionDateCollection.Count > 0)
				{
					deepHandles.Add("PgThesisDiscussionDateCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisDiscussionDate>) DataRepository.PgThesisDiscussionDateProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisDiscussionDateCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScHallRsrvCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScHallRsrv>|ScHallRsrvCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScHallRsrvCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScHallRsrvCollection = DataRepository.ScHallRsrvProvider.GetByScHallId(transactionManager, entity.ScHallId);

				if (deep && entity.ScHallRsrvCollection.Count > 0)
				{
					deepHandles.Add("ScHallRsrvCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScHallRsrv>) DataRepository.ScHallRsrvProvider.DeepLoad,
						new object[] { transactionManager, entity.ScHallRsrvCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScGroupDayCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScGroupDay>|ScGroupDayCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScGroupDayCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScGroupDayCollection = DataRepository.ScGroupDayProvider.GetByScHallId(transactionManager, entity.ScHallId);

				if (deep && entity.ScGroupDayCollection.Count > 0)
				{
					deepHandles.Add("ScGroupDayCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScGroupDay>) DataRepository.ScGroupDayProvider.DeepLoad,
						new object[] { transactionManager, entity.ScGroupDayCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoExamSchdlPlaceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoExamSchdlPlace>|CoExamSchdlPlaceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoExamSchdlPlaceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoExamSchdlPlaceCollection = DataRepository.CoExamSchdlPlaceProvider.GetByScHallId(transactionManager, entity.ScHallId);

				if (deep && entity.CoExamSchdlPlaceCollection.Count > 0)
				{
					deepHandles.Add("CoExamSchdlPlaceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoExamSchdlPlace>) DataRepository.CoExamSchdlPlaceProvider.DeepLoad,
						new object[] { transactionManager, entity.CoExamSchdlPlaceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisSeminarCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisSeminar>|PgThesisSeminarCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisSeminarCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisSeminarCollection = DataRepository.PgThesisSeminarProvider.GetByScHallId(transactionManager, entity.ScHallId);

				if (deep && entity.PgThesisSeminarCollection.Count > 0)
				{
					deepHandles.Add("PgThesisSeminarCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisSeminar>) DataRepository.PgThesisSeminarProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisSeminarCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScSchdlSlotCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScSchdlSlot>|ScSchdlSlotCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScSchdlSlotCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScSchdlSlotCollection = DataRepository.ScSchdlSlotProvider.GetByScHallId(transactionManager, entity.ScHallId);

				if (deep && entity.ScSchdlSlotCollection.Count > 0)
				{
					deepHandles.Add("ScSchdlSlotCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScSchdlSlot>) DataRepository.ScSchdlSlotProvider.DeepLoad,
						new object[] { transactionManager, entity.ScSchdlSlotCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmPlaceExamLocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmPlaceExamLoc>|AdmPlaceExamLocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmPlaceExamLocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmPlaceExamLocCollection = DataRepository.AdmPlaceExamLocProvider.GetByScHallId(transactionManager, entity.ScHallId);

				if (deep && entity.AdmPlaceExamLocCollection.Count > 0)
				{
					deepHandles.Add("AdmPlaceExamLocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmPlaceExamLoc>) DataRepository.AdmPlaceExamLocProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmPlaceExamLocCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmPlaceExamDatetimeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmPlaceExamDatetime>|AdmPlaceExamDatetimeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmPlaceExamDatetimeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmPlaceExamDatetimeCollection = DataRepository.AdmPlaceExamDatetimeProvider.GetByScHallId(transactionManager, entity.ScHallId);

				if (deep && entity.AdmPlaceExamDatetimeCollection.Count > 0)
				{
					deepHandles.Add("AdmPlaceExamDatetimeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmPlaceExamDatetime>) DataRepository.AdmPlaceExamDatetimeProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmPlaceExamDatetimeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScScheduleDtlDayExceptionCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScScheduleDtlDayException>|ScScheduleDtlDayExceptionCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScScheduleDtlDayExceptionCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScScheduleDtlDayExceptionCollection = DataRepository.ScScheduleDtlDayExceptionProvider.GetByScHallId(transactionManager, entity.ScHallId);

				if (deep && entity.ScScheduleDtlDayExceptionCollection.Count > 0)
				{
					deepHandles.Add("ScScheduleDtlDayExceptionCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScScheduleDtlDayException>) DataRepository.ScScheduleDtlDayExceptionProvider.DeepLoad,
						new object[] { transactionManager, entity.ScScheduleDtlDayExceptionCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScScheduleDtlDayCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScScheduleDtlDay>|ScScheduleDtlDayCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScScheduleDtlDayCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScScheduleDtlDayCollection = DataRepository.ScScheduleDtlDayProvider.GetByScHallId(transactionManager, entity.ScHallId);

				if (deep && entity.ScScheduleDtlDayCollection.Count > 0)
				{
					deepHandles.Add("ScScheduleDtlDayCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScScheduleDtlDay>) DataRepository.ScScheduleDtlDayProvider.DeepLoad,
						new object[] { transactionManager, entity.ScScheduleDtlDayCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScHallEquipCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScHallEquip>|ScHallEquipCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScHallEquipCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScHallEquipCollection = DataRepository.ScHallEquipProvider.GetByScHallId(transactionManager, entity.ScHallId);

				if (deep && entity.ScHallEquipCollection.Count > 0)
				{
					deepHandles.Add("ScHallEquipCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScHallEquip>) DataRepository.ScHallEquipProvider.DeepLoad,
						new object[] { transactionManager, entity.ScHallEquipCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoExamCommitteeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoExamCommittee>|CoExamCommitteeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoExamCommitteeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoExamCommitteeCollection = DataRepository.CoExamCommitteeProvider.GetByScHallId(transactionManager, entity.ScHallId);

				if (deep && entity.CoExamCommitteeCollection.Count > 0)
				{
					deepHandles.Add("CoExamCommitteeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoExamCommittee>) DataRepository.CoExamCommitteeProvider.DeepLoad,
						new object[] { transactionManager, entity.CoExamCommitteeCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.ScHall object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.ScHall instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScHall Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScHall entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region ScBuildingIdSource
			if (CanDeepSave(entity, "ScBuilding|ScBuildingIdSource", deepSaveType, innerList) 
				&& entity.ScBuildingIdSource != null)
			{
				DataRepository.ScBuildingProvider.Save(transactionManager, entity.ScBuildingIdSource);
				entity.ScBuildingId = entity.ScBuildingIdSource.ScBuildingId;
			}
			#endregion 
			
			#region ScCdeHallTypeIdSource
			if (CanDeepSave(entity, "ScCdeHallType|ScCdeHallTypeIdSource", deepSaveType, innerList) 
				&& entity.ScCdeHallTypeIdSource != null)
			{
				DataRepository.ScCdeHallTypeProvider.Save(transactionManager, entity.ScCdeHallTypeIdSource);
				entity.ScCdeHallTypeId = entity.ScCdeHallTypeIdSource.ScCdeHallTypeId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EdStudCheat>
				if (CanDeepSave(entity.EdStudCheatCollection, "List<EdStudCheat>|EdStudCheatCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCheat child in entity.EdStudCheatCollection)
					{
						if(child.ScHallIdSource != null)
						{
							child.ScHallId = child.ScHallIdSource.ScHallId;
						}
						else
						{
							child.ScHallId = entity.ScHallId;
						}

					}

					if (entity.EdStudCheatCollection.Count > 0 || entity.EdStudCheatCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCheatProvider.Save(transactionManager, entity.EdStudCheatCollection);
						
						deepHandles.Add("EdStudCheatCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCheat >) DataRepository.EdStudCheatProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCheatCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisDiscussionDate>
				if (CanDeepSave(entity.PgThesisDiscussionDateCollection, "List<PgThesisDiscussionDate>|PgThesisDiscussionDateCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisDiscussionDate child in entity.PgThesisDiscussionDateCollection)
					{
						if(child.ScHallIdSource != null)
						{
							child.ScHallId = child.ScHallIdSource.ScHallId;
						}
						else
						{
							child.ScHallId = entity.ScHallId;
						}

					}

					if (entity.PgThesisDiscussionDateCollection.Count > 0 || entity.PgThesisDiscussionDateCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisDiscussionDateProvider.Save(transactionManager, entity.PgThesisDiscussionDateCollection);
						
						deepHandles.Add("PgThesisDiscussionDateCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisDiscussionDate >) DataRepository.PgThesisDiscussionDateProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisDiscussionDateCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScHallRsrv>
				if (CanDeepSave(entity.ScHallRsrvCollection, "List<ScHallRsrv>|ScHallRsrvCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScHallRsrv child in entity.ScHallRsrvCollection)
					{
						if(child.ScHallIdSource != null)
						{
							child.ScHallId = child.ScHallIdSource.ScHallId;
						}
						else
						{
							child.ScHallId = entity.ScHallId;
						}

					}

					if (entity.ScHallRsrvCollection.Count > 0 || entity.ScHallRsrvCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScHallRsrvProvider.Save(transactionManager, entity.ScHallRsrvCollection);
						
						deepHandles.Add("ScHallRsrvCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScHallRsrv >) DataRepository.ScHallRsrvProvider.DeepSave,
							new object[] { transactionManager, entity.ScHallRsrvCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScGroupDay>
				if (CanDeepSave(entity.ScGroupDayCollection, "List<ScGroupDay>|ScGroupDayCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScGroupDay child in entity.ScGroupDayCollection)
					{
						if(child.ScHallIdSource != null)
						{
							child.ScHallId = child.ScHallIdSource.ScHallId;
						}
						else
						{
							child.ScHallId = entity.ScHallId;
						}

					}

					if (entity.ScGroupDayCollection.Count > 0 || entity.ScGroupDayCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScGroupDayProvider.Save(transactionManager, entity.ScGroupDayCollection);
						
						deepHandles.Add("ScGroupDayCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScGroupDay >) DataRepository.ScGroupDayProvider.DeepSave,
							new object[] { transactionManager, entity.ScGroupDayCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoExamSchdlPlace>
				if (CanDeepSave(entity.CoExamSchdlPlaceCollection, "List<CoExamSchdlPlace>|CoExamSchdlPlaceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoExamSchdlPlace child in entity.CoExamSchdlPlaceCollection)
					{
						if(child.ScHallIdSource != null)
						{
							child.ScHallId = child.ScHallIdSource.ScHallId;
						}
						else
						{
							child.ScHallId = entity.ScHallId;
						}

					}

					if (entity.CoExamSchdlPlaceCollection.Count > 0 || entity.CoExamSchdlPlaceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoExamSchdlPlaceProvider.Save(transactionManager, entity.CoExamSchdlPlaceCollection);
						
						deepHandles.Add("CoExamSchdlPlaceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoExamSchdlPlace >) DataRepository.CoExamSchdlPlaceProvider.DeepSave,
							new object[] { transactionManager, entity.CoExamSchdlPlaceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisSeminar>
				if (CanDeepSave(entity.PgThesisSeminarCollection, "List<PgThesisSeminar>|PgThesisSeminarCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisSeminar child in entity.PgThesisSeminarCollection)
					{
						if(child.ScHallIdSource != null)
						{
							child.ScHallId = child.ScHallIdSource.ScHallId;
						}
						else
						{
							child.ScHallId = entity.ScHallId;
						}

					}

					if (entity.PgThesisSeminarCollection.Count > 0 || entity.PgThesisSeminarCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisSeminarProvider.Save(transactionManager, entity.PgThesisSeminarCollection);
						
						deepHandles.Add("PgThesisSeminarCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisSeminar >) DataRepository.PgThesisSeminarProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisSeminarCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScSchdlSlot>
				if (CanDeepSave(entity.ScSchdlSlotCollection, "List<ScSchdlSlot>|ScSchdlSlotCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScSchdlSlot child in entity.ScSchdlSlotCollection)
					{
						if(child.ScHallIdSource != null)
						{
							child.ScHallId = child.ScHallIdSource.ScHallId;
						}
						else
						{
							child.ScHallId = entity.ScHallId;
						}

					}

					if (entity.ScSchdlSlotCollection.Count > 0 || entity.ScSchdlSlotCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScSchdlSlotProvider.Save(transactionManager, entity.ScSchdlSlotCollection);
						
						deepHandles.Add("ScSchdlSlotCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScSchdlSlot >) DataRepository.ScSchdlSlotProvider.DeepSave,
							new object[] { transactionManager, entity.ScSchdlSlotCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmPlaceExamLoc>
				if (CanDeepSave(entity.AdmPlaceExamLocCollection, "List<AdmPlaceExamLoc>|AdmPlaceExamLocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmPlaceExamLoc child in entity.AdmPlaceExamLocCollection)
					{
						if(child.ScHallIdSource != null)
						{
							child.ScHallId = child.ScHallIdSource.ScHallId;
						}
						else
						{
							child.ScHallId = entity.ScHallId;
						}

					}

					if (entity.AdmPlaceExamLocCollection.Count > 0 || entity.AdmPlaceExamLocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmPlaceExamLocProvider.Save(transactionManager, entity.AdmPlaceExamLocCollection);
						
						deepHandles.Add("AdmPlaceExamLocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmPlaceExamLoc >) DataRepository.AdmPlaceExamLocProvider.DeepSave,
							new object[] { transactionManager, entity.AdmPlaceExamLocCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmPlaceExamDatetime>
				if (CanDeepSave(entity.AdmPlaceExamDatetimeCollection, "List<AdmPlaceExamDatetime>|AdmPlaceExamDatetimeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmPlaceExamDatetime child in entity.AdmPlaceExamDatetimeCollection)
					{
						if(child.ScHallIdSource != null)
						{
							child.ScHallId = child.ScHallIdSource.ScHallId;
						}
						else
						{
							child.ScHallId = entity.ScHallId;
						}

					}

					if (entity.AdmPlaceExamDatetimeCollection.Count > 0 || entity.AdmPlaceExamDatetimeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmPlaceExamDatetimeProvider.Save(transactionManager, entity.AdmPlaceExamDatetimeCollection);
						
						deepHandles.Add("AdmPlaceExamDatetimeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmPlaceExamDatetime >) DataRepository.AdmPlaceExamDatetimeProvider.DeepSave,
							new object[] { transactionManager, entity.AdmPlaceExamDatetimeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScScheduleDtlDayException>
				if (CanDeepSave(entity.ScScheduleDtlDayExceptionCollection, "List<ScScheduleDtlDayException>|ScScheduleDtlDayExceptionCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScScheduleDtlDayException child in entity.ScScheduleDtlDayExceptionCollection)
					{
						if(child.ScHallIdSource != null)
						{
							child.ScHallId = child.ScHallIdSource.ScHallId;
						}
						else
						{
							child.ScHallId = entity.ScHallId;
						}

					}

					if (entity.ScScheduleDtlDayExceptionCollection.Count > 0 || entity.ScScheduleDtlDayExceptionCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScScheduleDtlDayExceptionProvider.Save(transactionManager, entity.ScScheduleDtlDayExceptionCollection);
						
						deepHandles.Add("ScScheduleDtlDayExceptionCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScScheduleDtlDayException >) DataRepository.ScScheduleDtlDayExceptionProvider.DeepSave,
							new object[] { transactionManager, entity.ScScheduleDtlDayExceptionCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScScheduleDtlDay>
				if (CanDeepSave(entity.ScScheduleDtlDayCollection, "List<ScScheduleDtlDay>|ScScheduleDtlDayCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScScheduleDtlDay child in entity.ScScheduleDtlDayCollection)
					{
						if(child.ScHallIdSource != null)
						{
							child.ScHallId = child.ScHallIdSource.ScHallId;
						}
						else
						{
							child.ScHallId = entity.ScHallId;
						}

					}

					if (entity.ScScheduleDtlDayCollection.Count > 0 || entity.ScScheduleDtlDayCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScScheduleDtlDayProvider.Save(transactionManager, entity.ScScheduleDtlDayCollection);
						
						deepHandles.Add("ScScheduleDtlDayCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScScheduleDtlDay >) DataRepository.ScScheduleDtlDayProvider.DeepSave,
							new object[] { transactionManager, entity.ScScheduleDtlDayCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScHallEquip>
				if (CanDeepSave(entity.ScHallEquipCollection, "List<ScHallEquip>|ScHallEquipCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScHallEquip child in entity.ScHallEquipCollection)
					{
						if(child.ScHallIdSource != null)
						{
							child.ScHallId = child.ScHallIdSource.ScHallId;
						}
						else
						{
							child.ScHallId = entity.ScHallId;
						}

					}

					if (entity.ScHallEquipCollection.Count > 0 || entity.ScHallEquipCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScHallEquipProvider.Save(transactionManager, entity.ScHallEquipCollection);
						
						deepHandles.Add("ScHallEquipCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScHallEquip >) DataRepository.ScHallEquipProvider.DeepSave,
							new object[] { transactionManager, entity.ScHallEquipCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoExamCommittee>
				if (CanDeepSave(entity.CoExamCommitteeCollection, "List<CoExamCommittee>|CoExamCommitteeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoExamCommittee child in entity.CoExamCommitteeCollection)
					{
						if(child.ScHallIdSource != null)
						{
							child.ScHallId = child.ScHallIdSource.ScHallId;
						}
						else
						{
							child.ScHallId = entity.ScHallId;
						}

					}

					if (entity.CoExamCommitteeCollection.Count > 0 || entity.CoExamCommitteeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoExamCommitteeProvider.Save(transactionManager, entity.CoExamCommitteeCollection);
						
						deepHandles.Add("CoExamCommitteeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoExamCommittee >) DataRepository.CoExamCommitteeProvider.DeepSave,
							new object[] { transactionManager, entity.CoExamCommitteeCollection, deepSaveType, childTypes, innerList }
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
	
	#region ScHallChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.ScHall</c>
	///</summary>
	public enum ScHallChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>ScBuilding</c> at ScBuildingIdSource
		///</summary>
		[ChildEntityType(typeof(ScBuilding))]
		ScBuilding,
		
		///<summary>
		/// Composite Property for <c>ScCdeHallType</c> at ScCdeHallTypeIdSource
		///</summary>
		[ChildEntityType(typeof(ScCdeHallType))]
		ScCdeHallType,
		///<summary>
		/// Collection of <c>ScHall</c> as OneToMany for EdStudCheatCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCheat>))]
		EdStudCheatCollection,
		///<summary>
		/// Collection of <c>ScHall</c> as OneToMany for PgThesisDiscussionDateCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisDiscussionDate>))]
		PgThesisDiscussionDateCollection,
		///<summary>
		/// Collection of <c>ScHall</c> as OneToMany for ScHallRsrvCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScHallRsrv>))]
		ScHallRsrvCollection,
		///<summary>
		/// Collection of <c>ScHall</c> as OneToMany for ScGroupDayCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScGroupDay>))]
		ScGroupDayCollection,
		///<summary>
		/// Collection of <c>ScHall</c> as OneToMany for CoExamSchdlPlaceCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoExamSchdlPlace>))]
		CoExamSchdlPlaceCollection,
		///<summary>
		/// Collection of <c>ScHall</c> as OneToMany for PgThesisSeminarCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisSeminar>))]
		PgThesisSeminarCollection,
		///<summary>
		/// Collection of <c>ScHall</c> as OneToMany for ScSchdlSlotCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScSchdlSlot>))]
		ScSchdlSlotCollection,
		///<summary>
		/// Collection of <c>ScHall</c> as OneToMany for AdmPlaceExamLocCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmPlaceExamLoc>))]
		AdmPlaceExamLocCollection,
		///<summary>
		/// Collection of <c>ScHall</c> as OneToMany for AdmPlaceExamDatetimeCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmPlaceExamDatetime>))]
		AdmPlaceExamDatetimeCollection,
		///<summary>
		/// Collection of <c>ScHall</c> as OneToMany for ScScheduleDtlDayExceptionCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScScheduleDtlDayException>))]
		ScScheduleDtlDayExceptionCollection,
		///<summary>
		/// Collection of <c>ScHall</c> as OneToMany for ScScheduleDtlDayCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScScheduleDtlDay>))]
		ScScheduleDtlDayCollection,
		///<summary>
		/// Collection of <c>ScHall</c> as OneToMany for ScHallEquipCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScHallEquip>))]
		ScHallEquipCollection,
		///<summary>
		/// Collection of <c>ScHall</c> as OneToMany for CoExamCommitteeCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoExamCommittee>))]
		CoExamCommitteeCollection,
	}
	
	#endregion ScHallChildEntityTypes
	
	#region ScHallFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ScHallColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScHall"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScHallFilterBuilder : SqlFilterBuilder<ScHallColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScHallFilterBuilder class.
		/// </summary>
		public ScHallFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScHallFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScHallFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScHallFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScHallFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScHallFilterBuilder
	
	#region ScHallParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ScHallColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScHall"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScHallParameterBuilder : ParameterizedSqlFilterBuilder<ScHallColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScHallParameterBuilder class.
		/// </summary>
		public ScHallParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScHallParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScHallParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScHallParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScHallParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScHallParameterBuilder
	
	#region ScHallSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ScHallColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScHall"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ScHallSortBuilder : SqlSortBuilder<ScHallColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScHallSqlSortBuilder class.
		/// </summary>
		public ScHallSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ScHallSortBuilder
	
} // end namespace
