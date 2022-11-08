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
	/// This class is the base class for any <see cref="CoControlRoomProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CoControlRoomProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.CoControlRoom, UMIS_VER2.BusinessLyer.CoControlRoomKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoControlRoomKey key)
		{
			return Delete(transactionManager, key.CoControlRoomId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_coControlRoomId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _coControlRoomId)
		{
			return Delete(null, _coControlRoomId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlRoomId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _coControlRoomId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
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
		public override UMIS_VER2.BusinessLyer.CoControlRoom Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoControlRoomKey key, int start, int pageLength)
		{
			return GetByCoControlRoomId(transactionManager, key.CoControlRoomId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlRoom&gt;"/> class.</returns>
		public TList<CoControlRoom> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null,_asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlRoom&gt;"/> class.</returns>
		public TList<CoControlRoom> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlRoom&gt;"/> class.</returns>
		public TList<CoControlRoom> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlRoom&gt;"/> class.</returns>
		public TList<CoControlRoom> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlRoom&gt;"/> class.</returns>
		public TList<CoControlRoom> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength, out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlRoom&gt;"/> class.</returns>
		public abstract TList<CoControlRoom> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_CO_CONTROL_ID_1 index.
		/// </summary>
		/// <param name="_coControlId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlRoom&gt;"/> class.</returns>
		public TList<CoControlRoom> GetByCoControlId(System.Decimal _coControlId)
		{
			int count = -1;
			return GetByCoControlId(null,_coControlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CO_CONTROL_ID_1 index.
		/// </summary>
		/// <param name="_coControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlRoom&gt;"/> class.</returns>
		public TList<CoControlRoom> GetByCoControlId(System.Decimal _coControlId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoControlId(null, _coControlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CO_CONTROL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlRoom&gt;"/> class.</returns>
		public TList<CoControlRoom> GetByCoControlId(TransactionManager transactionManager, System.Decimal _coControlId)
		{
			int count = -1;
			return GetByCoControlId(transactionManager, _coControlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CO_CONTROL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlRoom&gt;"/> class.</returns>
		public TList<CoControlRoom> GetByCoControlId(TransactionManager transactionManager, System.Decimal _coControlId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoControlId(transactionManager, _coControlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CO_CONTROL_ID_1 index.
		/// </summary>
		/// <param name="_coControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlRoom&gt;"/> class.</returns>
		public TList<CoControlRoom> GetByCoControlId(System.Decimal _coControlId, int start, int pageLength, out int count)
		{
			return GetByCoControlId(null, _coControlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CO_CONTROL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlRoom&gt;"/> class.</returns>
		public abstract TList<CoControlRoom> GetByCoControlId(TransactionManager transactionManager, System.Decimal _coControlId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_LEVEL_ID_1 index.
		/// </summary>
		/// <param name="_edCodeLevelId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlRoom&gt;"/> class.</returns>
		public TList<CoControlRoom> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(null,_edCodeLevelId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_LEVEL_ID_1 index.
		/// </summary>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlRoom&gt;"/> class.</returns>
		public TList<CoControlRoom> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_LEVEL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlRoom&gt;"/> class.</returns>
		public TList<CoControlRoom> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_LEVEL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlRoom&gt;"/> class.</returns>
		public TList<CoControlRoom> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_LEVEL_ID_1 index.
		/// </summary>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlRoom&gt;"/> class.</returns>
		public TList<CoControlRoom> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId, int start, int pageLength, out int count)
		{
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_LEVEL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlRoom&gt;"/> class.</returns>
		public abstract TList<CoControlRoom> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlRoom&gt;"/> class.</returns>
		public TList<CoControlRoom> GetByEntMainId(System.Decimal _entMainId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlRoom&gt;"/> class.</returns>
		public TList<CoControlRoom> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlRoom&gt;"/> class.</returns>
		public TList<CoControlRoom> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlRoom&gt;"/> class.</returns>
		public TList<CoControlRoom> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlRoom&gt;"/> class.</returns>
		public TList<CoControlRoom> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlRoom&gt;"/> class.</returns>
		public abstract TList<CoControlRoom> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CO_CONTROL_PHASE index.
		/// </summary>
		/// <param name="_coControlRoomId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoControlRoom"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoControlRoom GetByCoControlRoomId(System.Decimal _coControlRoomId)
		{
			int count = -1;
			return GetByCoControlRoomId(null,_coControlRoomId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_CONTROL_PHASE index.
		/// </summary>
		/// <param name="_coControlRoomId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoControlRoom"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoControlRoom GetByCoControlRoomId(System.Decimal _coControlRoomId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoControlRoomId(null, _coControlRoomId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_CONTROL_PHASE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlRoomId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoControlRoom"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoControlRoom GetByCoControlRoomId(TransactionManager transactionManager, System.Decimal _coControlRoomId)
		{
			int count = -1;
			return GetByCoControlRoomId(transactionManager, _coControlRoomId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_CONTROL_PHASE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlRoomId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoControlRoom"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoControlRoom GetByCoControlRoomId(TransactionManager transactionManager, System.Decimal _coControlRoomId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoControlRoomId(transactionManager, _coControlRoomId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_CONTROL_PHASE index.
		/// </summary>
		/// <param name="_coControlRoomId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoControlRoom"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoControlRoom GetByCoControlRoomId(System.Decimal _coControlRoomId, int start, int pageLength, out int count)
		{
			return GetByCoControlRoomId(null, _coControlRoomId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_CONTROL_PHASE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlRoomId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoControlRoom"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CoControlRoom GetByCoControlRoomId(TransactionManager transactionManager, System.Decimal _coControlRoomId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_CO_CONTROL_ROOM index.
		/// </summary>
		/// <param name="_coControlId"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="_edCodeLevelId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoControlRoom"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoControlRoom GetByCoControlIdAsFacultyInfoIdEntMainIdEdCodeLevelId(System.Decimal _coControlId, System.Decimal _asFacultyInfoId, System.Decimal _entMainId, System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByCoControlIdAsFacultyInfoIdEntMainIdEdCodeLevelId(null,_coControlId, _asFacultyInfoId, _entMainId, _edCodeLevelId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CO_CONTROL_ROOM index.
		/// </summary>
		/// <param name="_coControlId"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoControlRoom"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoControlRoom GetByCoControlIdAsFacultyInfoIdEntMainIdEdCodeLevelId(System.Decimal _coControlId, System.Decimal _asFacultyInfoId, System.Decimal _entMainId, System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoControlIdAsFacultyInfoIdEntMainIdEdCodeLevelId(null, _coControlId, _asFacultyInfoId, _entMainId, _edCodeLevelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CO_CONTROL_ROOM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlId"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="_edCodeLevelId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoControlRoom"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoControlRoom GetByCoControlIdAsFacultyInfoIdEntMainIdEdCodeLevelId(TransactionManager transactionManager, System.Decimal _coControlId, System.Decimal _asFacultyInfoId, System.Decimal _entMainId, System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByCoControlIdAsFacultyInfoIdEntMainIdEdCodeLevelId(transactionManager, _coControlId, _asFacultyInfoId, _entMainId, _edCodeLevelId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CO_CONTROL_ROOM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlId"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoControlRoom"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoControlRoom GetByCoControlIdAsFacultyInfoIdEntMainIdEdCodeLevelId(TransactionManager transactionManager, System.Decimal _coControlId, System.Decimal _asFacultyInfoId, System.Decimal _entMainId, System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoControlIdAsFacultyInfoIdEntMainIdEdCodeLevelId(transactionManager, _coControlId, _asFacultyInfoId, _entMainId, _edCodeLevelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CO_CONTROL_ROOM index.
		/// </summary>
		/// <param name="_coControlId"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoControlRoom"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoControlRoom GetByCoControlIdAsFacultyInfoIdEntMainIdEdCodeLevelId(System.Decimal _coControlId, System.Decimal _asFacultyInfoId, System.Decimal _entMainId, System.Decimal? _edCodeLevelId, int start, int pageLength, out int count)
		{
			return GetByCoControlIdAsFacultyInfoIdEntMainIdEdCodeLevelId(null, _coControlId, _asFacultyInfoId, _entMainId, _edCodeLevelId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CO_CONTROL_ROOM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlId"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoControlRoom"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CoControlRoom GetByCoControlIdAsFacultyInfoIdEntMainIdEdCodeLevelId(TransactionManager transactionManager, System.Decimal _coControlId, System.Decimal _asFacultyInfoId, System.Decimal _entMainId, System.Decimal? _edCodeLevelId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CoControlRoom&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CoControlRoom&gt;"/></returns>
		public static TList<CoControlRoom> Fill(IDataReader reader, TList<CoControlRoom> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.CoControlRoom c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CoControlRoom")
					.Append("|").Append((System.Decimal)reader["CO_CONTROL_ROOM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<CoControlRoom>(
					key.ToString(), // EntityTrackingKey
					"CoControlRoom",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.CoControlRoom();
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
					c.CoControlRoomId = (System.Decimal)reader["CO_CONTROL_ROOM_ID"];
					c.OriginalCoControlRoomId = c.CoControlRoomId;
					c.EntMainId = (System.Decimal)reader["ENT_MAIN_ID"];
					c.EdCodeLevelId = Convert.IsDBNull(reader["ED_CODE_LEVEL_ID"]) ? null : (System.Decimal?)reader["ED_CODE_LEVEL_ID"];
					c.CoControlId = (System.Decimal)reader["CO_CONTROL_ID"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.MarkMethod = (System.Decimal)reader["MARK_METHOD"];
					c.CloseFlg = (System.Decimal)reader["CLOSE_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CoControlRoom"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoControlRoom"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.CoControlRoom entity)
		{
			if (!reader.Read()) return;
			
			entity.CoControlRoomId = (System.Decimal)reader[((int)CoControlRoomColumn.CoControlRoomId - 1)];
			entity.OriginalCoControlRoomId = (System.Decimal)reader["CO_CONTROL_ROOM_ID"];
			entity.EntMainId = (System.Decimal)reader[((int)CoControlRoomColumn.EntMainId - 1)];
			entity.EdCodeLevelId = (reader.IsDBNull(((int)CoControlRoomColumn.EdCodeLevelId - 1)))?null:(System.Decimal?)reader[((int)CoControlRoomColumn.EdCodeLevelId - 1)];
			entity.CoControlId = (System.Decimal)reader[((int)CoControlRoomColumn.CoControlId - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)CoControlRoomColumn.AsFacultyInfoId - 1)];
			entity.MarkMethod = (System.Decimal)reader[((int)CoControlRoomColumn.MarkMethod - 1)];
			entity.CloseFlg = (System.Decimal)reader[((int)CoControlRoomColumn.CloseFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CoControlRoom"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoControlRoom"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.CoControlRoom entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CoControlRoomId = (System.Decimal)dataRow["CO_CONTROL_ROOM_ID"];
			entity.OriginalCoControlRoomId = (System.Decimal)dataRow["CO_CONTROL_ROOM_ID"];
			entity.EntMainId = (System.Decimal)dataRow["ENT_MAIN_ID"];
			entity.EdCodeLevelId = Convert.IsDBNull(dataRow["ED_CODE_LEVEL_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_LEVEL_ID"];
			entity.CoControlId = (System.Decimal)dataRow["CO_CONTROL_ID"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
			entity.MarkMethod = (System.Decimal)dataRow["MARK_METHOD"];
			entity.CloseFlg = (System.Decimal)dataRow["CLOSE_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoControlRoom"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CoControlRoom Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoControlRoom entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsFacultyInfoIdSource	
			if (CanDeepLoad(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepLoadType, innerList) 
				&& entity.AsFacultyInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AsFacultyInfoId;
				AsFacultyInfo tmpEntity = EntityManager.LocateEntity<AsFacultyInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AsFacultyInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsFacultyInfoIdSource = tmpEntity;
				else
					entity.AsFacultyInfoIdSource = DataRepository.AsFacultyInfoProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);		
				
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

			#region CoControlIdSource	
			if (CanDeepLoad(entity, "CoControl|CoControlIdSource", deepLoadType, innerList) 
				&& entity.CoControlIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.CoControlId;
				CoControl tmpEntity = EntityManager.LocateEntity<CoControl>(EntityLocator.ConstructKeyFromPkItems(typeof(CoControl), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.CoControlIdSource = tmpEntity;
				else
					entity.CoControlIdSource = DataRepository.CoControlProvider.GetByCoControlId(transactionManager, entity.CoControlId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoControlIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.CoControlIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.CoControlProvider.DeepLoad(transactionManager, entity.CoControlIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion CoControlIdSource

			#region EdCodeLevelIdSource	
			if (CanDeepLoad(entity, "EdCodeLevel|EdCodeLevelIdSource", deepLoadType, innerList) 
				&& entity.EdCodeLevelIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeLevelId ?? 0.0m);
				EdCodeLevel tmpEntity = EntityManager.LocateEntity<EdCodeLevel>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeLevel), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeLevelIdSource = tmpEntity;
				else
					entity.EdCodeLevelIdSource = DataRepository.EdCodeLevelProvider.GetByEdCodeLevelId(transactionManager, (entity.EdCodeLevelId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeLevelIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeLevelIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeLevelProvider.DeepLoad(transactionManager, entity.EdCodeLevelIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeLevelIdSource

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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByCoControlRoomId methods when available
			
			#region CoCourseResultCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoCourseResult>|CoCourseResultCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoCourseResultCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoCourseResultCollection = DataRepository.CoCourseResultProvider.GetByCoControlRoomId(transactionManager, entity.CoControlRoomId);

				if (deep && entity.CoCourseResultCollection.Count > 0)
				{
					deepHandles.Add("CoCourseResultCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoCourseResult>) DataRepository.CoCourseResultProvider.DeepLoad,
						new object[] { transactionManager, entity.CoCourseResultCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoContRoomMemberCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoContRoomMember>|CoContRoomMemberCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoContRoomMemberCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoContRoomMemberCollection = DataRepository.CoContRoomMemberProvider.GetByCoControlRoomId(transactionManager, entity.CoControlRoomId);

				if (deep && entity.CoContRoomMemberCollection.Count > 0)
				{
					deepHandles.Add("CoContRoomMemberCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoContRoomMember>) DataRepository.CoContRoomMemberProvider.DeepLoad,
						new object[] { transactionManager, entity.CoContRoomMemberCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.CoControlRoom object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.CoControlRoom instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CoControlRoom Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoControlRoom entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region CoControlIdSource
			if (CanDeepSave(entity, "CoControl|CoControlIdSource", deepSaveType, innerList) 
				&& entity.CoControlIdSource != null)
			{
				DataRepository.CoControlProvider.Save(transactionManager, entity.CoControlIdSource);
				entity.CoControlId = entity.CoControlIdSource.CoControlId;
			}
			#endregion 
			
			#region EdCodeLevelIdSource
			if (CanDeepSave(entity, "EdCodeLevel|EdCodeLevelIdSource", deepSaveType, innerList) 
				&& entity.EdCodeLevelIdSource != null)
			{
				DataRepository.EdCodeLevelProvider.Save(transactionManager, entity.EdCodeLevelIdSource);
				entity.EdCodeLevelId = entity.EdCodeLevelIdSource.EdCodeLevelId;
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
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<CoCourseResult>
				if (CanDeepSave(entity.CoCourseResultCollection, "List<CoCourseResult>|CoCourseResultCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoCourseResult child in entity.CoCourseResultCollection)
					{
						if(child.CoControlRoomIdSource != null)
						{
							child.CoControlRoomId = child.CoControlRoomIdSource.CoControlRoomId;
						}
						else
						{
							child.CoControlRoomId = entity.CoControlRoomId;
						}

					}

					if (entity.CoCourseResultCollection.Count > 0 || entity.CoCourseResultCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoCourseResultProvider.Save(transactionManager, entity.CoCourseResultCollection);
						
						deepHandles.Add("CoCourseResultCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoCourseResult >) DataRepository.CoCourseResultProvider.DeepSave,
							new object[] { transactionManager, entity.CoCourseResultCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoContRoomMember>
				if (CanDeepSave(entity.CoContRoomMemberCollection, "List<CoContRoomMember>|CoContRoomMemberCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoContRoomMember child in entity.CoContRoomMemberCollection)
					{
						if(child.CoControlRoomIdSource != null)
						{
							child.CoControlRoomId = child.CoControlRoomIdSource.CoControlRoomId;
						}
						else
						{
							child.CoControlRoomId = entity.CoControlRoomId;
						}

					}

					if (entity.CoContRoomMemberCollection.Count > 0 || entity.CoContRoomMemberCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoContRoomMemberProvider.Save(transactionManager, entity.CoContRoomMemberCollection);
						
						deepHandles.Add("CoContRoomMemberCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoContRoomMember >) DataRepository.CoContRoomMemberProvider.DeepSave,
							new object[] { transactionManager, entity.CoContRoomMemberCollection, deepSaveType, childTypes, innerList }
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
	
	#region CoControlRoomChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.CoControlRoom</c>
	///</summary>
	public enum CoControlRoomChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>CoControl</c> at CoControlIdSource
		///</summary>
		[ChildEntityType(typeof(CoControl))]
		CoControl,
		
		///<summary>
		/// Composite Property for <c>EdCodeLevel</c> at EdCodeLevelIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeLevel))]
		EdCodeLevel,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		///<summary>
		/// Collection of <c>CoControlRoom</c> as OneToMany for CoCourseResultCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoCourseResult>))]
		CoCourseResultCollection,
		///<summary>
		/// Collection of <c>CoControlRoom</c> as OneToMany for CoContRoomMemberCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoContRoomMember>))]
		CoContRoomMemberCollection,
	}
	
	#endregion CoControlRoomChildEntityTypes
	
	#region CoControlRoomFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CoControlRoomColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoControlRoom"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoControlRoomFilterBuilder : SqlFilterBuilder<CoControlRoomColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoControlRoomFilterBuilder class.
		/// </summary>
		public CoControlRoomFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoControlRoomFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoControlRoomFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoControlRoomFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoControlRoomFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoControlRoomFilterBuilder
	
	#region CoControlRoomParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CoControlRoomColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoControlRoom"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoControlRoomParameterBuilder : ParameterizedSqlFilterBuilder<CoControlRoomColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoControlRoomParameterBuilder class.
		/// </summary>
		public CoControlRoomParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoControlRoomParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoControlRoomParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoControlRoomParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoControlRoomParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoControlRoomParameterBuilder
	
	#region CoControlRoomSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CoControlRoomColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoControlRoom"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CoControlRoomSortBuilder : SqlSortBuilder<CoControlRoomColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoControlRoomSqlSortBuilder class.
		/// </summary>
		public CoControlRoomSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CoControlRoomSortBuilder
	
} // end namespace
