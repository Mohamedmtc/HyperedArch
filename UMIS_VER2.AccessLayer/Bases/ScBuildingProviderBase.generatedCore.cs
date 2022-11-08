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
	/// This class is the base class for any <see cref="ScBuildingProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScBuildingProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.ScBuilding, UMIS_VER2.BusinessLyer.ScBuildingKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScBuildingKey key)
		{
			return Delete(transactionManager, key.ScBuildingId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_scBuildingId">المبانى. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _scBuildingId)
		{
			return Delete(null, _scBuildingId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId">المبانى. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _scBuildingId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0032 key.
		///		FK_AUTO_0032 Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScBuilding objects.</returns>
		public TList<ScBuilding> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0032 key.
		///		FK_AUTO_0032 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScBuilding objects.</returns>
		/// <remarks></remarks>
		public TList<ScBuilding> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0032 key.
		///		FK_AUTO_0032 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScBuilding objects.</returns>
		public TList<ScBuilding> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0032 key.
		///		fkAuto0032 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScBuilding objects.</returns>
		public TList<ScBuilding> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0032 key.
		///		fkAuto0032 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScBuilding objects.</returns>
		public TList<ScBuilding> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0032 key.
		///		FK_AUTO_0032 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScBuilding objects.</returns>
		public abstract TList<ScBuilding> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_BUILDING_GS_CDE_CAMPUS key.
		///		FK_SC_BUILDING_GS_CDE_CAMPUS Description: 
		/// </summary>
		/// <param name="_gsCdeCampusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScBuilding objects.</returns>
		public TList<ScBuilding> GetByGsCdeCampusId(System.Decimal? _gsCdeCampusId)
		{
			int count = -1;
			return GetByGsCdeCampusId(_gsCdeCampusId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_BUILDING_GS_CDE_CAMPUS key.
		///		FK_SC_BUILDING_GS_CDE_CAMPUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeCampusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScBuilding objects.</returns>
		/// <remarks></remarks>
		public TList<ScBuilding> GetByGsCdeCampusId(TransactionManager transactionManager, System.Decimal? _gsCdeCampusId)
		{
			int count = -1;
			return GetByGsCdeCampusId(transactionManager, _gsCdeCampusId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_BUILDING_GS_CDE_CAMPUS key.
		///		FK_SC_BUILDING_GS_CDE_CAMPUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeCampusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScBuilding objects.</returns>
		public TList<ScBuilding> GetByGsCdeCampusId(TransactionManager transactionManager, System.Decimal? _gsCdeCampusId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeCampusId(transactionManager, _gsCdeCampusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_BUILDING_GS_CDE_CAMPUS key.
		///		fkScBuildingGsCdeCampus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeCampusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScBuilding objects.</returns>
		public TList<ScBuilding> GetByGsCdeCampusId(System.Decimal? _gsCdeCampusId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeCampusId(null, _gsCdeCampusId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_BUILDING_GS_CDE_CAMPUS key.
		///		fkScBuildingGsCdeCampus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeCampusId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScBuilding objects.</returns>
		public TList<ScBuilding> GetByGsCdeCampusId(System.Decimal? _gsCdeCampusId, int start, int pageLength,out int count)
		{
			return GetByGsCdeCampusId(null, _gsCdeCampusId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_BUILDING_GS_CDE_CAMPUS key.
		///		FK_SC_BUILDING_GS_CDE_CAMPUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeCampusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScBuilding objects.</returns>
		public abstract TList<ScBuilding> GetByGsCdeCampusId(TransactionManager transactionManager, System.Decimal? _gsCdeCampusId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.ScBuilding Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScBuildingKey key, int start, int pageLength)
		{
			return GetByScBuildingId(transactionManager, key.ScBuildingId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SC_BUILDING index.
		/// </summary>
		/// <param name="_scBuildingId">المبانى</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScBuilding"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScBuilding GetByScBuildingId(System.Decimal _scBuildingId)
		{
			int count = -1;
			return GetByScBuildingId(null,_scBuildingId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_BUILDING index.
		/// </summary>
		/// <param name="_scBuildingId">المبانى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScBuilding"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScBuilding GetByScBuildingId(System.Decimal _scBuildingId, int start, int pageLength)
		{
			int count = -1;
			return GetByScBuildingId(null, _scBuildingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_BUILDING index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId">المبانى</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScBuilding"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScBuilding GetByScBuildingId(TransactionManager transactionManager, System.Decimal _scBuildingId)
		{
			int count = -1;
			return GetByScBuildingId(transactionManager, _scBuildingId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_BUILDING index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId">المبانى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScBuilding"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScBuilding GetByScBuildingId(TransactionManager transactionManager, System.Decimal _scBuildingId, int start, int pageLength)
		{
			int count = -1;
			return GetByScBuildingId(transactionManager, _scBuildingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_BUILDING index.
		/// </summary>
		/// <param name="_scBuildingId">المبانى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScBuilding"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScBuilding GetByScBuildingId(System.Decimal _scBuildingId, int start, int pageLength, out int count)
		{
			return GetByScBuildingId(null, _scBuildingId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_BUILDING index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId">المبانى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScBuilding"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScBuilding GetByScBuildingId(TransactionManager transactionManager, System.Decimal _scBuildingId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_BUILDING_CODE index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_buildCode"></param>
		/// <param name="_gsCdeCampusId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScBuilding"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScBuilding GetByAsFacultyInfoIdBuildCodeGsCdeCampusId(System.Decimal? _asFacultyInfoId, System.String _buildCode, System.Decimal? _gsCdeCampusId)
		{
			int count = -1;
			return GetByAsFacultyInfoIdBuildCodeGsCdeCampusId(null,_asFacultyInfoId, _buildCode, _gsCdeCampusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_BUILDING_CODE index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_buildCode"></param>
		/// <param name="_gsCdeCampusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScBuilding"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScBuilding GetByAsFacultyInfoIdBuildCodeGsCdeCampusId(System.Decimal? _asFacultyInfoId, System.String _buildCode, System.Decimal? _gsCdeCampusId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoIdBuildCodeGsCdeCampusId(null, _asFacultyInfoId, _buildCode, _gsCdeCampusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_BUILDING_CODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_buildCode"></param>
		/// <param name="_gsCdeCampusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScBuilding"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScBuilding GetByAsFacultyInfoIdBuildCodeGsCdeCampusId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.String _buildCode, System.Decimal? _gsCdeCampusId)
		{
			int count = -1;
			return GetByAsFacultyInfoIdBuildCodeGsCdeCampusId(transactionManager, _asFacultyInfoId, _buildCode, _gsCdeCampusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_BUILDING_CODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_buildCode"></param>
		/// <param name="_gsCdeCampusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScBuilding"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScBuilding GetByAsFacultyInfoIdBuildCodeGsCdeCampusId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.String _buildCode, System.Decimal? _gsCdeCampusId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoIdBuildCodeGsCdeCampusId(transactionManager, _asFacultyInfoId, _buildCode, _gsCdeCampusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_BUILDING_CODE index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_buildCode"></param>
		/// <param name="_gsCdeCampusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScBuilding"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScBuilding GetByAsFacultyInfoIdBuildCodeGsCdeCampusId(System.Decimal? _asFacultyInfoId, System.String _buildCode, System.Decimal? _gsCdeCampusId, int start, int pageLength, out int count)
		{
			return GetByAsFacultyInfoIdBuildCodeGsCdeCampusId(null, _asFacultyInfoId, _buildCode, _gsCdeCampusId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_BUILDING_CODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_buildCode"></param>
		/// <param name="_gsCdeCampusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScBuilding"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScBuilding GetByAsFacultyInfoIdBuildCodeGsCdeCampusId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.String _buildCode, System.Decimal? _gsCdeCampusId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_BUILDING_DESC_AR index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="_gsCdeCampusId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScBuilding"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScBuilding GetByAsFacultyInfoIdDescrArGsCdeCampusId(System.Decimal? _asFacultyInfoId, System.String _descrAr, System.Decimal? _gsCdeCampusId)
		{
			int count = -1;
			return GetByAsFacultyInfoIdDescrArGsCdeCampusId(null,_asFacultyInfoId, _descrAr, _gsCdeCampusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_BUILDING_DESC_AR index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="_gsCdeCampusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScBuilding"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScBuilding GetByAsFacultyInfoIdDescrArGsCdeCampusId(System.Decimal? _asFacultyInfoId, System.String _descrAr, System.Decimal? _gsCdeCampusId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoIdDescrArGsCdeCampusId(null, _asFacultyInfoId, _descrAr, _gsCdeCampusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_BUILDING_DESC_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="_gsCdeCampusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScBuilding"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScBuilding GetByAsFacultyInfoIdDescrArGsCdeCampusId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.String _descrAr, System.Decimal? _gsCdeCampusId)
		{
			int count = -1;
			return GetByAsFacultyInfoIdDescrArGsCdeCampusId(transactionManager, _asFacultyInfoId, _descrAr, _gsCdeCampusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_BUILDING_DESC_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="_gsCdeCampusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScBuilding"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScBuilding GetByAsFacultyInfoIdDescrArGsCdeCampusId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.String _descrAr, System.Decimal? _gsCdeCampusId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoIdDescrArGsCdeCampusId(transactionManager, _asFacultyInfoId, _descrAr, _gsCdeCampusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_BUILDING_DESC_AR index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="_gsCdeCampusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScBuilding"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScBuilding GetByAsFacultyInfoIdDescrArGsCdeCampusId(System.Decimal? _asFacultyInfoId, System.String _descrAr, System.Decimal? _gsCdeCampusId, int start, int pageLength, out int count)
		{
			return GetByAsFacultyInfoIdDescrArGsCdeCampusId(null, _asFacultyInfoId, _descrAr, _gsCdeCampusId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_BUILDING_DESC_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="_gsCdeCampusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScBuilding"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScBuilding GetByAsFacultyInfoIdDescrArGsCdeCampusId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.String _descrAr, System.Decimal? _gsCdeCampusId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_BUILDING_DESC_EN index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_descrEn"></param>
		/// <param name="_gsCdeCampusId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScBuilding"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScBuilding GetByAsFacultyInfoIdDescrEnGsCdeCampusId(System.Decimal? _asFacultyInfoId, System.String _descrEn, System.Decimal? _gsCdeCampusId)
		{
			int count = -1;
			return GetByAsFacultyInfoIdDescrEnGsCdeCampusId(null,_asFacultyInfoId, _descrEn, _gsCdeCampusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_BUILDING_DESC_EN index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_descrEn"></param>
		/// <param name="_gsCdeCampusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScBuilding"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScBuilding GetByAsFacultyInfoIdDescrEnGsCdeCampusId(System.Decimal? _asFacultyInfoId, System.String _descrEn, System.Decimal? _gsCdeCampusId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoIdDescrEnGsCdeCampusId(null, _asFacultyInfoId, _descrEn, _gsCdeCampusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_BUILDING_DESC_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_descrEn"></param>
		/// <param name="_gsCdeCampusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScBuilding"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScBuilding GetByAsFacultyInfoIdDescrEnGsCdeCampusId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.String _descrEn, System.Decimal? _gsCdeCampusId)
		{
			int count = -1;
			return GetByAsFacultyInfoIdDescrEnGsCdeCampusId(transactionManager, _asFacultyInfoId, _descrEn, _gsCdeCampusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_BUILDING_DESC_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_descrEn"></param>
		/// <param name="_gsCdeCampusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScBuilding"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScBuilding GetByAsFacultyInfoIdDescrEnGsCdeCampusId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.String _descrEn, System.Decimal? _gsCdeCampusId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoIdDescrEnGsCdeCampusId(transactionManager, _asFacultyInfoId, _descrEn, _gsCdeCampusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_BUILDING_DESC_EN index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_descrEn"></param>
		/// <param name="_gsCdeCampusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScBuilding"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScBuilding GetByAsFacultyInfoIdDescrEnGsCdeCampusId(System.Decimal? _asFacultyInfoId, System.String _descrEn, System.Decimal? _gsCdeCampusId, int start, int pageLength, out int count)
		{
			return GetByAsFacultyInfoIdDescrEnGsCdeCampusId(null, _asFacultyInfoId, _descrEn, _gsCdeCampusId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_BUILDING_DESC_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_descrEn"></param>
		/// <param name="_gsCdeCampusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScBuilding"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScBuilding GetByAsFacultyInfoIdDescrEnGsCdeCampusId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.String _descrEn, System.Decimal? _gsCdeCampusId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ScBuilding&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ScBuilding&gt;"/></returns>
		public static TList<ScBuilding> Fill(IDataReader reader, TList<ScBuilding> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.ScBuilding c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ScBuilding")
					.Append("|").Append((System.Decimal)reader["SC_BUILDING_ID"]).ToString();
					c = EntityManager.LocateOrCreate<ScBuilding>(
					key.ToString(), // EntityTrackingKey
					"ScBuilding",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.ScBuilding();
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
					c.ScBuildingId = (System.Decimal)reader["SC_BUILDING_ID"];
					c.OriginalScBuildingId = c.ScBuildingId;
					c.BuildCode = (System.String)reader["BUILD_CODE"];
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.GsCdeCampusId = Convert.IsDBNull(reader["GS_CDE_CAMPUS_ID"]) ? null : (System.Decimal?)reader["GS_CDE_CAMPUS_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScBuilding"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScBuilding"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.ScBuilding entity)
		{
			if (!reader.Read()) return;
			
			entity.ScBuildingId = (System.Decimal)reader[((int)ScBuildingColumn.ScBuildingId - 1)];
			entity.OriginalScBuildingId = (System.Decimal)reader["SC_BUILDING_ID"];
			entity.BuildCode = (System.String)reader[((int)ScBuildingColumn.BuildCode - 1)];
			entity.DescrAr = (System.String)reader[((int)ScBuildingColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)ScBuildingColumn.DescrEn - 1)))?null:(System.String)reader[((int)ScBuildingColumn.DescrEn - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)ScBuildingColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)ScBuildingColumn.AsFacultyInfoId - 1)];
			entity.GsCdeCampusId = (reader.IsDBNull(((int)ScBuildingColumn.GsCdeCampusId - 1)))?null:(System.Decimal?)reader[((int)ScBuildingColumn.GsCdeCampusId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScBuilding"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScBuilding"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.ScBuilding entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ScBuildingId = (System.Decimal)dataRow["SC_BUILDING_ID"];
			entity.OriginalScBuildingId = (System.Decimal)dataRow["SC_BUILDING_ID"];
			entity.BuildCode = (System.String)dataRow["BUILD_CODE"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.GsCdeCampusId = Convert.IsDBNull(dataRow["GS_CDE_CAMPUS_ID"]) ? null : (System.Decimal?)dataRow["GS_CDE_CAMPUS_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScBuilding"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScBuilding Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScBuilding entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByScBuildingId methods when available
			
			#region EdStudCheatCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCheat>|EdStudCheatCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCheatCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCheatCollection = DataRepository.EdStudCheatProvider.GetByScBuildingId(transactionManager, entity.ScBuildingId);

				if (deep && entity.EdStudCheatCollection.Count > 0)
				{
					deepHandles.Add("EdStudCheatCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCheat>) DataRepository.EdStudCheatProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCheatCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvStudLockerReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStudLockerReq>|SvStudLockerReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStudLockerReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStudLockerReqCollection = DataRepository.SvStudLockerReqProvider.GetByScBuildingId(transactionManager, entity.ScBuildingId);

				if (deep && entity.SvStudLockerReqCollection.Count > 0)
				{
					deepHandles.Add("SvStudLockerReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStudLockerReq>) DataRepository.SvStudLockerReqProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStudLockerReqCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.PgThesisDiscussionDateCollection = DataRepository.PgThesisDiscussionDateProvider.GetByScBuildingId(transactionManager, entity.ScBuildingId);

				if (deep && entity.PgThesisDiscussionDateCollection.Count > 0)
				{
					deepHandles.Add("PgThesisDiscussionDateCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisDiscussionDate>) DataRepository.PgThesisDiscussionDateProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisDiscussionDateCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvCdeLockerCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvCdeLocker>|SvCdeLockerCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCdeLockerCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvCdeLockerCollection = DataRepository.SvCdeLockerProvider.GetByScBuildingId(transactionManager, entity.ScBuildingId);

				if (deep && entity.SvCdeLockerCollection.Count > 0)
				{
					deepHandles.Add("SvCdeLockerCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvCdeLocker>) DataRepository.SvCdeLockerProvider.DeepLoad,
						new object[] { transactionManager, entity.SvCdeLockerCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.ScGroupDayCollection = DataRepository.ScGroupDayProvider.GetByScBuildingId(transactionManager, entity.ScBuildingId);

				if (deep && entity.ScGroupDayCollection.Count > 0)
				{
					deepHandles.Add("ScGroupDayCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScGroupDay>) DataRepository.ScGroupDayProvider.DeepLoad,
						new object[] { transactionManager, entity.ScGroupDayCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScHallCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScHall>|ScHallCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScHallCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScHallCollection = DataRepository.ScHallProvider.GetByScBuildingId(transactionManager, entity.ScBuildingId);

				if (deep && entity.ScHallCollection.Count > 0)
				{
					deepHandles.Add("ScHallCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScHall>) DataRepository.ScHallProvider.DeepLoad,
						new object[] { transactionManager, entity.ScHallCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.CoExamSchdlPlaceCollection = DataRepository.CoExamSchdlPlaceProvider.GetByScBuildingId(transactionManager, entity.ScBuildingId);

				if (deep && entity.CoExamSchdlPlaceCollection.Count > 0)
				{
					deepHandles.Add("CoExamSchdlPlaceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoExamSchdlPlace>) DataRepository.CoExamSchdlPlaceProvider.DeepLoad,
						new object[] { transactionManager, entity.CoExamSchdlPlaceCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.AdmPlaceExamDatetimeCollection = DataRepository.AdmPlaceExamDatetimeProvider.GetByScBuildingId(transactionManager, entity.ScBuildingId);

				if (deep && entity.AdmPlaceExamDatetimeCollection.Count > 0)
				{
					deepHandles.Add("AdmPlaceExamDatetimeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmPlaceExamDatetime>) DataRepository.AdmPlaceExamDatetimeProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmPlaceExamDatetimeCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.PgThesisSeminarCollection = DataRepository.PgThesisSeminarProvider.GetByScBuildingId(transactionManager, entity.ScBuildingId);

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

				entity.ScSchdlSlotCollection = DataRepository.ScSchdlSlotProvider.GetByScBuildingId(transactionManager, entity.ScBuildingId);

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

				entity.AdmPlaceExamLocCollection = DataRepository.AdmPlaceExamLocProvider.GetByScBuildingId(transactionManager, entity.ScBuildingId);

				if (deep && entity.AdmPlaceExamLocCollection.Count > 0)
				{
					deepHandles.Add("AdmPlaceExamLocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmPlaceExamLoc>) DataRepository.AdmPlaceExamLocProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmPlaceExamLocCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.ScScheduleDtlDayExceptionCollection = DataRepository.ScScheduleDtlDayExceptionProvider.GetByScBuildingId(transactionManager, entity.ScBuildingId);

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

				entity.ScScheduleDtlDayCollection = DataRepository.ScScheduleDtlDayProvider.GetByScBuildingId(transactionManager, entity.ScBuildingId);

				if (deep && entity.ScScheduleDtlDayCollection.Count > 0)
				{
					deepHandles.Add("ScScheduleDtlDayCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScScheduleDtlDay>) DataRepository.ScScheduleDtlDayProvider.DeepLoad,
						new object[] { transactionManager, entity.ScScheduleDtlDayCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.CoExamCommitteeCollection = DataRepository.CoExamCommitteeProvider.GetByScBuildingId(transactionManager, entity.ScBuildingId);

				if (deep && entity.CoExamCommitteeCollection.Count > 0)
				{
					deepHandles.Add("CoExamCommitteeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoExamCommittee>) DataRepository.CoExamCommitteeProvider.DeepLoad,
						new object[] { transactionManager, entity.CoExamCommitteeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudViolCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudViol>|EdStudViolCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudViolCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudViolCollection = DataRepository.EdStudViolProvider.GetByScBuildingId(transactionManager, entity.ScBuildingId);

				if (deep && entity.EdStudViolCollection.Count > 0)
				{
					deepHandles.Add("EdStudViolCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudViol>) DataRepository.EdStudViolProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudViolCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.ScBuilding object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.ScBuilding instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScBuilding Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScBuilding entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region GsCdeCampusIdSource
			if (CanDeepSave(entity, "GsCdeCampus|GsCdeCampusIdSource", deepSaveType, innerList) 
				&& entity.GsCdeCampusIdSource != null)
			{
				DataRepository.GsCdeCampusProvider.Save(transactionManager, entity.GsCdeCampusIdSource);
				entity.GsCdeCampusId = entity.GsCdeCampusIdSource.GsCdeCampusId;
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
						if(child.ScBuildingIdSource != null)
						{
							child.ScBuildingId = child.ScBuildingIdSource.ScBuildingId;
						}
						else
						{
							child.ScBuildingId = entity.ScBuildingId;
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
				
	
			#region List<SvStudLockerReq>
				if (CanDeepSave(entity.SvStudLockerReqCollection, "List<SvStudLockerReq>|SvStudLockerReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStudLockerReq child in entity.SvStudLockerReqCollection)
					{
						if(child.ScBuildingIdSource != null)
						{
							child.ScBuildingId = child.ScBuildingIdSource.ScBuildingId;
						}
						else
						{
							child.ScBuildingId = entity.ScBuildingId;
						}

					}

					if (entity.SvStudLockerReqCollection.Count > 0 || entity.SvStudLockerReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStudLockerReqProvider.Save(transactionManager, entity.SvStudLockerReqCollection);
						
						deepHandles.Add("SvStudLockerReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStudLockerReq >) DataRepository.SvStudLockerReqProvider.DeepSave,
							new object[] { transactionManager, entity.SvStudLockerReqCollection, deepSaveType, childTypes, innerList }
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
						if(child.ScBuildingIdSource != null)
						{
							child.ScBuildingId = child.ScBuildingIdSource.ScBuildingId;
						}
						else
						{
							child.ScBuildingId = entity.ScBuildingId;
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
				
	
			#region List<SvCdeLocker>
				if (CanDeepSave(entity.SvCdeLockerCollection, "List<SvCdeLocker>|SvCdeLockerCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvCdeLocker child in entity.SvCdeLockerCollection)
					{
						if(child.ScBuildingIdSource != null)
						{
							child.ScBuildingId = child.ScBuildingIdSource.ScBuildingId;
						}
						else
						{
							child.ScBuildingId = entity.ScBuildingId;
						}

					}

					if (entity.SvCdeLockerCollection.Count > 0 || entity.SvCdeLockerCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvCdeLockerProvider.Save(transactionManager, entity.SvCdeLockerCollection);
						
						deepHandles.Add("SvCdeLockerCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvCdeLocker >) DataRepository.SvCdeLockerProvider.DeepSave,
							new object[] { transactionManager, entity.SvCdeLockerCollection, deepSaveType, childTypes, innerList }
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
						if(child.ScBuildingIdSource != null)
						{
							child.ScBuildingId = child.ScBuildingIdSource.ScBuildingId;
						}
						else
						{
							child.ScBuildingId = entity.ScBuildingId;
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
				
	
			#region List<ScHall>
				if (CanDeepSave(entity.ScHallCollection, "List<ScHall>|ScHallCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScHall child in entity.ScHallCollection)
					{
						if(child.ScBuildingIdSource != null)
						{
							child.ScBuildingId = child.ScBuildingIdSource.ScBuildingId;
						}
						else
						{
							child.ScBuildingId = entity.ScBuildingId;
						}

					}

					if (entity.ScHallCollection.Count > 0 || entity.ScHallCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScHallProvider.Save(transactionManager, entity.ScHallCollection);
						
						deepHandles.Add("ScHallCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScHall >) DataRepository.ScHallProvider.DeepSave,
							new object[] { transactionManager, entity.ScHallCollection, deepSaveType, childTypes, innerList }
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
						if(child.ScBuildingIdSource != null)
						{
							child.ScBuildingId = child.ScBuildingIdSource.ScBuildingId;
						}
						else
						{
							child.ScBuildingId = entity.ScBuildingId;
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
				
	
			#region List<AdmPlaceExamDatetime>
				if (CanDeepSave(entity.AdmPlaceExamDatetimeCollection, "List<AdmPlaceExamDatetime>|AdmPlaceExamDatetimeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmPlaceExamDatetime child in entity.AdmPlaceExamDatetimeCollection)
					{
						if(child.ScBuildingIdSource != null)
						{
							child.ScBuildingId = child.ScBuildingIdSource.ScBuildingId;
						}
						else
						{
							child.ScBuildingId = entity.ScBuildingId;
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
				
	
			#region List<PgThesisSeminar>
				if (CanDeepSave(entity.PgThesisSeminarCollection, "List<PgThesisSeminar>|PgThesisSeminarCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisSeminar child in entity.PgThesisSeminarCollection)
					{
						if(child.ScBuildingIdSource != null)
						{
							child.ScBuildingId = child.ScBuildingIdSource.ScBuildingId;
						}
						else
						{
							child.ScBuildingId = entity.ScBuildingId;
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
						if(child.ScBuildingIdSource != null)
						{
							child.ScBuildingId = child.ScBuildingIdSource.ScBuildingId;
						}
						else
						{
							child.ScBuildingId = entity.ScBuildingId;
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
						if(child.ScBuildingIdSource != null)
						{
							child.ScBuildingId = child.ScBuildingIdSource.ScBuildingId;
						}
						else
						{
							child.ScBuildingId = entity.ScBuildingId;
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
				
	
			#region List<ScScheduleDtlDayException>
				if (CanDeepSave(entity.ScScheduleDtlDayExceptionCollection, "List<ScScheduleDtlDayException>|ScScheduleDtlDayExceptionCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScScheduleDtlDayException child in entity.ScScheduleDtlDayExceptionCollection)
					{
						if(child.ScBuildingIdSource != null)
						{
							child.ScBuildingId = child.ScBuildingIdSource.ScBuildingId;
						}
						else
						{
							child.ScBuildingId = entity.ScBuildingId;
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
						if(child.ScBuildingIdSource != null)
						{
							child.ScBuildingId = child.ScBuildingIdSource.ScBuildingId;
						}
						else
						{
							child.ScBuildingId = entity.ScBuildingId;
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
				
	
			#region List<CoExamCommittee>
				if (CanDeepSave(entity.CoExamCommitteeCollection, "List<CoExamCommittee>|CoExamCommitteeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoExamCommittee child in entity.CoExamCommitteeCollection)
					{
						if(child.ScBuildingIdSource != null)
						{
							child.ScBuildingId = child.ScBuildingIdSource.ScBuildingId;
						}
						else
						{
							child.ScBuildingId = entity.ScBuildingId;
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
				
	
			#region List<EdStudViol>
				if (CanDeepSave(entity.EdStudViolCollection, "List<EdStudViol>|EdStudViolCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudViol child in entity.EdStudViolCollection)
					{
						if(child.ScBuildingIdSource != null)
						{
							child.ScBuildingId = child.ScBuildingIdSource.ScBuildingId;
						}
						else
						{
							child.ScBuildingId = entity.ScBuildingId;
						}

					}

					if (entity.EdStudViolCollection.Count > 0 || entity.EdStudViolCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudViolProvider.Save(transactionManager, entity.EdStudViolCollection);
						
						deepHandles.Add("EdStudViolCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudViol >) DataRepository.EdStudViolProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudViolCollection, deepSaveType, childTypes, innerList }
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
	
	#region ScBuildingChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.ScBuilding</c>
	///</summary>
	public enum ScBuildingChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>GsCdeCampus</c> at GsCdeCampusIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeCampus))]
		GsCdeCampus,
		///<summary>
		/// Collection of <c>ScBuilding</c> as OneToMany for EdStudCheatCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCheat>))]
		EdStudCheatCollection,
		///<summary>
		/// Collection of <c>ScBuilding</c> as OneToMany for SvStudLockerReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStudLockerReq>))]
		SvStudLockerReqCollection,
		///<summary>
		/// Collection of <c>ScBuilding</c> as OneToMany for PgThesisDiscussionDateCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisDiscussionDate>))]
		PgThesisDiscussionDateCollection,
		///<summary>
		/// Collection of <c>ScBuilding</c> as OneToMany for SvCdeLockerCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvCdeLocker>))]
		SvCdeLockerCollection,
		///<summary>
		/// Collection of <c>ScBuilding</c> as OneToMany for ScGroupDayCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScGroupDay>))]
		ScGroupDayCollection,
		///<summary>
		/// Collection of <c>ScBuilding</c> as OneToMany for ScHallCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScHall>))]
		ScHallCollection,
		///<summary>
		/// Collection of <c>ScBuilding</c> as OneToMany for CoExamSchdlPlaceCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoExamSchdlPlace>))]
		CoExamSchdlPlaceCollection,
		///<summary>
		/// Collection of <c>ScBuilding</c> as OneToMany for AdmPlaceExamDatetimeCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmPlaceExamDatetime>))]
		AdmPlaceExamDatetimeCollection,
		///<summary>
		/// Collection of <c>ScBuilding</c> as OneToMany for PgThesisSeminarCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisSeminar>))]
		PgThesisSeminarCollection,
		///<summary>
		/// Collection of <c>ScBuilding</c> as OneToMany for ScSchdlSlotCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScSchdlSlot>))]
		ScSchdlSlotCollection,
		///<summary>
		/// Collection of <c>ScBuilding</c> as OneToMany for AdmPlaceExamLocCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmPlaceExamLoc>))]
		AdmPlaceExamLocCollection,
		///<summary>
		/// Collection of <c>ScBuilding</c> as OneToMany for ScScheduleDtlDayExceptionCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScScheduleDtlDayException>))]
		ScScheduleDtlDayExceptionCollection,
		///<summary>
		/// Collection of <c>ScBuilding</c> as OneToMany for ScScheduleDtlDayCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScScheduleDtlDay>))]
		ScScheduleDtlDayCollection,
		///<summary>
		/// Collection of <c>ScBuilding</c> as OneToMany for CoExamCommitteeCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoExamCommittee>))]
		CoExamCommitteeCollection,
		///<summary>
		/// Collection of <c>ScBuilding</c> as OneToMany for EdStudViolCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudViol>))]
		EdStudViolCollection,
	}
	
	#endregion ScBuildingChildEntityTypes
	
	#region ScBuildingFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ScBuildingColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScBuilding"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScBuildingFilterBuilder : SqlFilterBuilder<ScBuildingColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScBuildingFilterBuilder class.
		/// </summary>
		public ScBuildingFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScBuildingFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScBuildingFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScBuildingFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScBuildingFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScBuildingFilterBuilder
	
	#region ScBuildingParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ScBuildingColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScBuilding"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScBuildingParameterBuilder : ParameterizedSqlFilterBuilder<ScBuildingColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScBuildingParameterBuilder class.
		/// </summary>
		public ScBuildingParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScBuildingParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScBuildingParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScBuildingParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScBuildingParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScBuildingParameterBuilder
	
	#region ScBuildingSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ScBuildingColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScBuilding"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ScBuildingSortBuilder : SqlSortBuilder<ScBuildingColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScBuildingSqlSortBuilder class.
		/// </summary>
		public ScBuildingSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ScBuildingSortBuilder
	
} // end namespace
