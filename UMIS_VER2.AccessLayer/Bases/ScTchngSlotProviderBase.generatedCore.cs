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
	/// This class is the base class for any <see cref="ScTchngSlotProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScTchngSlotProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.ScTchngSlot, UMIS_VER2.BusinessLyer.ScTchngSlotKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScTchngSlotKey key)
		{
			return Delete(transactionManager, key.ScTchngSlotId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_scTchngSlotId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _scTchngSlotId)
		{
			return Delete(null, _scTchngSlotId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scTchngSlotId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _scTchngSlotId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_TCHNG_SLOT_GS_CODE_WEEK_DAY key.
		///		FK_SC_TCHNG_SLOT_GS_CODE_WEEK_DAY Description: 
		/// </summary>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScTchngSlot objects.</returns>
		public TList<ScTchngSlot> GetByGsCodeWeekDayId(System.Decimal? _gsCodeWeekDayId)
		{
			int count = -1;
			return GetByGsCodeWeekDayId(_gsCodeWeekDayId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_TCHNG_SLOT_GS_CODE_WEEK_DAY key.
		///		FK_SC_TCHNG_SLOT_GS_CODE_WEEK_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScTchngSlot objects.</returns>
		/// <remarks></remarks>
		public TList<ScTchngSlot> GetByGsCodeWeekDayId(TransactionManager transactionManager, System.Decimal? _gsCodeWeekDayId)
		{
			int count = -1;
			return GetByGsCodeWeekDayId(transactionManager, _gsCodeWeekDayId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_TCHNG_SLOT_GS_CODE_WEEK_DAY key.
		///		FK_SC_TCHNG_SLOT_GS_CODE_WEEK_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScTchngSlot objects.</returns>
		public TList<ScTchngSlot> GetByGsCodeWeekDayId(TransactionManager transactionManager, System.Decimal? _gsCodeWeekDayId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeWeekDayId(transactionManager, _gsCodeWeekDayId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_TCHNG_SLOT_GS_CODE_WEEK_DAY key.
		///		fkScTchngSlotGsCodeWeekDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScTchngSlot objects.</returns>
		public TList<ScTchngSlot> GetByGsCodeWeekDayId(System.Decimal? _gsCodeWeekDayId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeWeekDayId(null, _gsCodeWeekDayId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_TCHNG_SLOT_GS_CODE_WEEK_DAY key.
		///		fkScTchngSlotGsCodeWeekDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScTchngSlot objects.</returns>
		public TList<ScTchngSlot> GetByGsCodeWeekDayId(System.Decimal? _gsCodeWeekDayId, int start, int pageLength,out int count)
		{
			return GetByGsCodeWeekDayId(null, _gsCodeWeekDayId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_TCHNG_SLOT_GS_CODE_WEEK_DAY key.
		///		FK_SC_TCHNG_SLOT_GS_CODE_WEEK_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScTchngSlot objects.</returns>
		public abstract TList<ScTchngSlot> GetByGsCodeWeekDayId(TransactionManager transactionManager, System.Decimal? _gsCodeWeekDayId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_TCHNG_SLOT_SC_SCHDL_PERIOD key.
		///		FK_SC_TCHNG_SLOT_SC_SCHDL_PERIOD Description: 
		/// </summary>
		/// <param name="_scSchdlPeriodId">فترات الجدول</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScTchngSlot objects.</returns>
		public TList<ScTchngSlot> GetByScSchdlPeriodId(System.Decimal? _scSchdlPeriodId)
		{
			int count = -1;
			return GetByScSchdlPeriodId(_scSchdlPeriodId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_TCHNG_SLOT_SC_SCHDL_PERIOD key.
		///		FK_SC_TCHNG_SLOT_SC_SCHDL_PERIOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchdlPeriodId">فترات الجدول</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScTchngSlot objects.</returns>
		/// <remarks></remarks>
		public TList<ScTchngSlot> GetByScSchdlPeriodId(TransactionManager transactionManager, System.Decimal? _scSchdlPeriodId)
		{
			int count = -1;
			return GetByScSchdlPeriodId(transactionManager, _scSchdlPeriodId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_TCHNG_SLOT_SC_SCHDL_PERIOD key.
		///		FK_SC_TCHNG_SLOT_SC_SCHDL_PERIOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchdlPeriodId">فترات الجدول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScTchngSlot objects.</returns>
		public TList<ScTchngSlot> GetByScSchdlPeriodId(TransactionManager transactionManager, System.Decimal? _scSchdlPeriodId, int start, int pageLength)
		{
			int count = -1;
			return GetByScSchdlPeriodId(transactionManager, _scSchdlPeriodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_TCHNG_SLOT_SC_SCHDL_PERIOD key.
		///		fkScTchngSlotScSchdlPeriod Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scSchdlPeriodId">فترات الجدول</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScTchngSlot objects.</returns>
		public TList<ScTchngSlot> GetByScSchdlPeriodId(System.Decimal? _scSchdlPeriodId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScSchdlPeriodId(null, _scSchdlPeriodId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_TCHNG_SLOT_SC_SCHDL_PERIOD key.
		///		fkScTchngSlotScSchdlPeriod Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scSchdlPeriodId">فترات الجدول</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScTchngSlot objects.</returns>
		public TList<ScTchngSlot> GetByScSchdlPeriodId(System.Decimal? _scSchdlPeriodId, int start, int pageLength,out int count)
		{
			return GetByScSchdlPeriodId(null, _scSchdlPeriodId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_TCHNG_SLOT_SC_SCHDL_PERIOD key.
		///		FK_SC_TCHNG_SLOT_SC_SCHDL_PERIOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchdlPeriodId">فترات الجدول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScTchngSlot objects.</returns>
		public abstract TList<ScTchngSlot> GetByScSchdlPeriodId(TransactionManager transactionManager, System.Decimal? _scSchdlPeriodId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.ScTchngSlot Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScTchngSlotKey key, int start, int pageLength)
		{
			return GetByScTchngSlotId(transactionManager, key.ScTchngSlotId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SC_TCHNG_SLOT index.
		/// </summary>
		/// <param name="_scTchngSlotId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScTchngSlot"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScTchngSlot GetByScTchngSlotId(System.Decimal _scTchngSlotId)
		{
			int count = -1;
			return GetByScTchngSlotId(null,_scTchngSlotId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_TCHNG_SLOT index.
		/// </summary>
		/// <param name="_scTchngSlotId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScTchngSlot"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScTchngSlot GetByScTchngSlotId(System.Decimal _scTchngSlotId, int start, int pageLength)
		{
			int count = -1;
			return GetByScTchngSlotId(null, _scTchngSlotId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_TCHNG_SLOT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scTchngSlotId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScTchngSlot"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScTchngSlot GetByScTchngSlotId(TransactionManager transactionManager, System.Decimal _scTchngSlotId)
		{
			int count = -1;
			return GetByScTchngSlotId(transactionManager, _scTchngSlotId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_TCHNG_SLOT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scTchngSlotId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScTchngSlot"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScTchngSlot GetByScTchngSlotId(TransactionManager transactionManager, System.Decimal _scTchngSlotId, int start, int pageLength)
		{
			int count = -1;
			return GetByScTchngSlotId(transactionManager, _scTchngSlotId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_TCHNG_SLOT index.
		/// </summary>
		/// <param name="_scTchngSlotId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScTchngSlot"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScTchngSlot GetByScTchngSlotId(System.Decimal _scTchngSlotId, int start, int pageLength, out int count)
		{
			return GetByScTchngSlotId(null, _scTchngSlotId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_TCHNG_SLOT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scTchngSlotId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScTchngSlot"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScTchngSlot GetByScTchngSlotId(TransactionManager transactionManager, System.Decimal _scTchngSlotId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SC_TCHNG_SLOT index.
		/// </summary>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <param name="_examFlg"></param>
		/// <param name="_fromTime"></param>
		/// <param name="_toTime"></param>
		/// <param name="_scSchdlPeriodId">فترات الجدول</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScTchngSlot"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScTchngSlot GetByGsCodeWeekDayIdExamFlgFromTimeToTimeScSchdlPeriodId(System.Decimal? _gsCodeWeekDayId, System.Decimal? _examFlg, System.DateTime _fromTime, System.DateTime _toTime, System.Decimal? _scSchdlPeriodId)
		{
			int count = -1;
			return GetByGsCodeWeekDayIdExamFlgFromTimeToTimeScSchdlPeriodId(null,_gsCodeWeekDayId, _examFlg, _fromTime, _toTime, _scSchdlPeriodId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_TCHNG_SLOT index.
		/// </summary>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <param name="_examFlg"></param>
		/// <param name="_fromTime"></param>
		/// <param name="_toTime"></param>
		/// <param name="_scSchdlPeriodId">فترات الجدول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScTchngSlot"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScTchngSlot GetByGsCodeWeekDayIdExamFlgFromTimeToTimeScSchdlPeriodId(System.Decimal? _gsCodeWeekDayId, System.Decimal? _examFlg, System.DateTime _fromTime, System.DateTime _toTime, System.Decimal? _scSchdlPeriodId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeWeekDayIdExamFlgFromTimeToTimeScSchdlPeriodId(null, _gsCodeWeekDayId, _examFlg, _fromTime, _toTime, _scSchdlPeriodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_TCHNG_SLOT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <param name="_examFlg"></param>
		/// <param name="_fromTime"></param>
		/// <param name="_toTime"></param>
		/// <param name="_scSchdlPeriodId">فترات الجدول</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScTchngSlot"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScTchngSlot GetByGsCodeWeekDayIdExamFlgFromTimeToTimeScSchdlPeriodId(TransactionManager transactionManager, System.Decimal? _gsCodeWeekDayId, System.Decimal? _examFlg, System.DateTime _fromTime, System.DateTime _toTime, System.Decimal? _scSchdlPeriodId)
		{
			int count = -1;
			return GetByGsCodeWeekDayIdExamFlgFromTimeToTimeScSchdlPeriodId(transactionManager, _gsCodeWeekDayId, _examFlg, _fromTime, _toTime, _scSchdlPeriodId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_TCHNG_SLOT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <param name="_examFlg"></param>
		/// <param name="_fromTime"></param>
		/// <param name="_toTime"></param>
		/// <param name="_scSchdlPeriodId">فترات الجدول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScTchngSlot"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScTchngSlot GetByGsCodeWeekDayIdExamFlgFromTimeToTimeScSchdlPeriodId(TransactionManager transactionManager, System.Decimal? _gsCodeWeekDayId, System.Decimal? _examFlg, System.DateTime _fromTime, System.DateTime _toTime, System.Decimal? _scSchdlPeriodId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeWeekDayIdExamFlgFromTimeToTimeScSchdlPeriodId(transactionManager, _gsCodeWeekDayId, _examFlg, _fromTime, _toTime, _scSchdlPeriodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_TCHNG_SLOT index.
		/// </summary>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <param name="_examFlg"></param>
		/// <param name="_fromTime"></param>
		/// <param name="_toTime"></param>
		/// <param name="_scSchdlPeriodId">فترات الجدول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScTchngSlot"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScTchngSlot GetByGsCodeWeekDayIdExamFlgFromTimeToTimeScSchdlPeriodId(System.Decimal? _gsCodeWeekDayId, System.Decimal? _examFlg, System.DateTime _fromTime, System.DateTime _toTime, System.Decimal? _scSchdlPeriodId, int start, int pageLength, out int count)
		{
			return GetByGsCodeWeekDayIdExamFlgFromTimeToTimeScSchdlPeriodId(null, _gsCodeWeekDayId, _examFlg, _fromTime, _toTime, _scSchdlPeriodId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_TCHNG_SLOT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <param name="_examFlg"></param>
		/// <param name="_fromTime"></param>
		/// <param name="_toTime"></param>
		/// <param name="_scSchdlPeriodId">فترات الجدول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScTchngSlot"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScTchngSlot GetByGsCodeWeekDayIdExamFlgFromTimeToTimeScSchdlPeriodId(TransactionManager transactionManager, System.Decimal? _gsCodeWeekDayId, System.Decimal? _examFlg, System.DateTime _fromTime, System.DateTime _toTime, System.Decimal? _scSchdlPeriodId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ScTchngSlot&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ScTchngSlot&gt;"/></returns>
		public static TList<ScTchngSlot> Fill(IDataReader reader, TList<ScTchngSlot> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.ScTchngSlot c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ScTchngSlot")
					.Append("|").Append((System.Decimal)reader["SC_TCHNG_SLOT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<ScTchngSlot>(
					key.ToString(), // EntityTrackingKey
					"ScTchngSlot",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.ScTchngSlot();
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
					c.ScTchngSlotId = (System.Decimal)reader["SC_TCHNG_SLOT_ID"];
					c.OriginalScTchngSlotId = c.ScTchngSlotId;
					c.DescrAr = Convert.IsDBNull(reader["DESCR_AR"]) ? null : (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.GsCodeWeekDayId = Convert.IsDBNull(reader["GS_CODE_WEEK_DAY_ID"]) ? null : (System.Decimal?)reader["GS_CODE_WEEK_DAY_ID"];
					c.FromTime = (System.DateTime)reader["FROM_TIME"];
					c.ToTime = (System.DateTime)reader["TO_TIME"];
					c.IsActive = Convert.IsDBNull(reader["IS_ACTIVE"]) ? null : (System.Decimal?)reader["IS_ACTIVE"];
					c.ExamFlg = Convert.IsDBNull(reader["EXAM_FLG"]) ? null : (System.Decimal?)reader["EXAM_FLG"];
					c.PeriodNameAr = Convert.IsDBNull(reader["PERIOD_NAME_AR"]) ? null : (System.String)reader["PERIOD_NAME_AR"];
					c.ScSchdlPeriodId = Convert.IsDBNull(reader["SC_SCHDL_PERIOD_ID"]) ? null : (System.Decimal?)reader["SC_SCHDL_PERIOD_ID"];
					c.FromTimeAlt = Convert.IsDBNull(reader["FROM_TIME_ALT"]) ? null : (System.DateTime?)reader["FROM_TIME_ALT"];
					c.ToTimeAlt = Convert.IsDBNull(reader["TO_TIME_ALT"]) ? null : (System.DateTime?)reader["TO_TIME_ALT"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScTchngSlot"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScTchngSlot"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.ScTchngSlot entity)
		{
			if (!reader.Read()) return;
			
			entity.ScTchngSlotId = (System.Decimal)reader[((int)ScTchngSlotColumn.ScTchngSlotId - 1)];
			entity.OriginalScTchngSlotId = (System.Decimal)reader["SC_TCHNG_SLOT_ID"];
			entity.DescrAr = (reader.IsDBNull(((int)ScTchngSlotColumn.DescrAr - 1)))?null:(System.String)reader[((int)ScTchngSlotColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)ScTchngSlotColumn.DescrEn - 1)))?null:(System.String)reader[((int)ScTchngSlotColumn.DescrEn - 1)];
			entity.GsCodeWeekDayId = (reader.IsDBNull(((int)ScTchngSlotColumn.GsCodeWeekDayId - 1)))?null:(System.Decimal?)reader[((int)ScTchngSlotColumn.GsCodeWeekDayId - 1)];
			entity.FromTime = (System.DateTime)reader[((int)ScTchngSlotColumn.FromTime - 1)];
			entity.ToTime = (System.DateTime)reader[((int)ScTchngSlotColumn.ToTime - 1)];
			entity.IsActive = (reader.IsDBNull(((int)ScTchngSlotColumn.IsActive - 1)))?null:(System.Decimal?)reader[((int)ScTchngSlotColumn.IsActive - 1)];
			entity.ExamFlg = (reader.IsDBNull(((int)ScTchngSlotColumn.ExamFlg - 1)))?null:(System.Decimal?)reader[((int)ScTchngSlotColumn.ExamFlg - 1)];
			entity.PeriodNameAr = (reader.IsDBNull(((int)ScTchngSlotColumn.PeriodNameAr - 1)))?null:(System.String)reader[((int)ScTchngSlotColumn.PeriodNameAr - 1)];
			entity.ScSchdlPeriodId = (reader.IsDBNull(((int)ScTchngSlotColumn.ScSchdlPeriodId - 1)))?null:(System.Decimal?)reader[((int)ScTchngSlotColumn.ScSchdlPeriodId - 1)];
			entity.FromTimeAlt = (reader.IsDBNull(((int)ScTchngSlotColumn.FromTimeAlt - 1)))?null:(System.DateTime?)reader[((int)ScTchngSlotColumn.FromTimeAlt - 1)];
			entity.ToTimeAlt = (reader.IsDBNull(((int)ScTchngSlotColumn.ToTimeAlt - 1)))?null:(System.DateTime?)reader[((int)ScTchngSlotColumn.ToTimeAlt - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScTchngSlot"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScTchngSlot"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.ScTchngSlot entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ScTchngSlotId = (System.Decimal)dataRow["SC_TCHNG_SLOT_ID"];
			entity.OriginalScTchngSlotId = (System.Decimal)dataRow["SC_TCHNG_SLOT_ID"];
			entity.DescrAr = Convert.IsDBNull(dataRow["DESCR_AR"]) ? null : (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
			entity.GsCodeWeekDayId = Convert.IsDBNull(dataRow["GS_CODE_WEEK_DAY_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_WEEK_DAY_ID"];
			entity.FromTime = (System.DateTime)dataRow["FROM_TIME"];
			entity.ToTime = (System.DateTime)dataRow["TO_TIME"];
			entity.IsActive = Convert.IsDBNull(dataRow["IS_ACTIVE"]) ? null : (System.Decimal?)dataRow["IS_ACTIVE"];
			entity.ExamFlg = Convert.IsDBNull(dataRow["EXAM_FLG"]) ? null : (System.Decimal?)dataRow["EXAM_FLG"];
			entity.PeriodNameAr = Convert.IsDBNull(dataRow["PERIOD_NAME_AR"]) ? null : (System.String)dataRow["PERIOD_NAME_AR"];
			entity.ScSchdlPeriodId = Convert.IsDBNull(dataRow["SC_SCHDL_PERIOD_ID"]) ? null : (System.Decimal?)dataRow["SC_SCHDL_PERIOD_ID"];
			entity.FromTimeAlt = Convert.IsDBNull(dataRow["FROM_TIME_ALT"]) ? null : (System.DateTime?)dataRow["FROM_TIME_ALT"];
			entity.ToTimeAlt = Convert.IsDBNull(dataRow["TO_TIME_ALT"]) ? null : (System.DateTime?)dataRow["TO_TIME_ALT"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScTchngSlot"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScTchngSlot Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScTchngSlot entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region GsCodeWeekDayIdSource	
			if (CanDeepLoad(entity, "GsCodeWeekDay|GsCodeWeekDayIdSource", deepLoadType, innerList) 
				&& entity.GsCodeWeekDayIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeWeekDayId ?? 0.0m);
				GsCodeWeekDay tmpEntity = EntityManager.LocateEntity<GsCodeWeekDay>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeWeekDay), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeWeekDayIdSource = tmpEntity;
				else
					entity.GsCodeWeekDayIdSource = DataRepository.GsCodeWeekDayProvider.GetByGsCodeWeekDayId(transactionManager, (entity.GsCodeWeekDayId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeWeekDayIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeWeekDayIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeWeekDayProvider.DeepLoad(transactionManager, entity.GsCodeWeekDayIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeWeekDayIdSource

			#region ScSchdlPeriodIdSource	
			if (CanDeepLoad(entity, "ScSchdlPeriod|ScSchdlPeriodIdSource", deepLoadType, innerList) 
				&& entity.ScSchdlPeriodIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ScSchdlPeriodId ?? 0.0m);
				ScSchdlPeriod tmpEntity = EntityManager.LocateEntity<ScSchdlPeriod>(EntityLocator.ConstructKeyFromPkItems(typeof(ScSchdlPeriod), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScSchdlPeriodIdSource = tmpEntity;
				else
					entity.ScSchdlPeriodIdSource = DataRepository.ScSchdlPeriodProvider.GetByScSchdlPeriodId(transactionManager, (entity.ScSchdlPeriodId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScSchdlPeriodIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScSchdlPeriodIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScSchdlPeriodProvider.DeepLoad(transactionManager, entity.ScSchdlPeriodIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScSchdlPeriodIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByScTchngSlotId methods when available
			
			#region ScGroupDayCollectionGetByScTchngSlotFrmId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScGroupDay>|ScGroupDayCollectionGetByScTchngSlotFrmId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScGroupDayCollectionGetByScTchngSlotFrmId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScGroupDayCollectionGetByScTchngSlotFrmId = DataRepository.ScGroupDayProvider.GetByScTchngSlotFrmId(transactionManager, entity.ScTchngSlotId);

				if (deep && entity.ScGroupDayCollectionGetByScTchngSlotFrmId.Count > 0)
				{
					deepHandles.Add("ScGroupDayCollectionGetByScTchngSlotFrmId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScGroupDay>) DataRepository.ScGroupDayProvider.DeepLoad,
						new object[] { transactionManager, entity.ScGroupDayCollectionGetByScTchngSlotFrmId, deep, deepLoadType, childTypes, innerList }
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

				entity.ScSchdlSlotCollection = DataRepository.ScSchdlSlotProvider.GetByScTchngSlotId(transactionManager, entity.ScTchngSlotId);

				if (deep && entity.ScSchdlSlotCollection.Count > 0)
				{
					deepHandles.Add("ScSchdlSlotCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScSchdlSlot>) DataRepository.ScSchdlSlotProvider.DeepLoad,
						new object[] { transactionManager, entity.ScSchdlSlotCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScGroupDayCollectionGetByScTchngSlotToId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScGroupDay>|ScGroupDayCollectionGetByScTchngSlotToId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScGroupDayCollectionGetByScTchngSlotToId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScGroupDayCollectionGetByScTchngSlotToId = DataRepository.ScGroupDayProvider.GetByScTchngSlotToId(transactionManager, entity.ScTchngSlotId);

				if (deep && entity.ScGroupDayCollectionGetByScTchngSlotToId.Count > 0)
				{
					deepHandles.Add("ScGroupDayCollectionGetByScTchngSlotToId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScGroupDay>) DataRepository.ScGroupDayProvider.DeepLoad,
						new object[] { transactionManager, entity.ScGroupDayCollectionGetByScTchngSlotToId, deep, deepLoadType, childTypes, innerList }
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

				entity.ScScheduleDtlDayCollection = DataRepository.ScScheduleDtlDayProvider.GetByScTchngSlotId(transactionManager, entity.ScTchngSlotId);

				if (deep && entity.ScScheduleDtlDayCollection.Count > 0)
				{
					deepHandles.Add("ScScheduleDtlDayCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScScheduleDtlDay>) DataRepository.ScScheduleDtlDayProvider.DeepLoad,
						new object[] { transactionManager, entity.ScScheduleDtlDayCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.ScTchngSlot object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.ScTchngSlot instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScTchngSlot Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScTchngSlot entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region GsCodeWeekDayIdSource
			if (CanDeepSave(entity, "GsCodeWeekDay|GsCodeWeekDayIdSource", deepSaveType, innerList) 
				&& entity.GsCodeWeekDayIdSource != null)
			{
				DataRepository.GsCodeWeekDayProvider.Save(transactionManager, entity.GsCodeWeekDayIdSource);
				entity.GsCodeWeekDayId = entity.GsCodeWeekDayIdSource.GsCodeWeekDayId;
			}
			#endregion 
			
			#region ScSchdlPeriodIdSource
			if (CanDeepSave(entity, "ScSchdlPeriod|ScSchdlPeriodIdSource", deepSaveType, innerList) 
				&& entity.ScSchdlPeriodIdSource != null)
			{
				DataRepository.ScSchdlPeriodProvider.Save(transactionManager, entity.ScSchdlPeriodIdSource);
				entity.ScSchdlPeriodId = entity.ScSchdlPeriodIdSource.ScSchdlPeriodId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<ScGroupDay>
				if (CanDeepSave(entity.ScGroupDayCollectionGetByScTchngSlotFrmId, "List<ScGroupDay>|ScGroupDayCollectionGetByScTchngSlotFrmId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScGroupDay child in entity.ScGroupDayCollectionGetByScTchngSlotFrmId)
					{
						if(child.ScTchngSlotFrmIdSource != null)
						{
							child.ScTchngSlotFrmId = child.ScTchngSlotFrmIdSource.ScTchngSlotId;
						}
						else
						{
							child.ScTchngSlotFrmId = entity.ScTchngSlotId;
						}

					}

					if (entity.ScGroupDayCollectionGetByScTchngSlotFrmId.Count > 0 || entity.ScGroupDayCollectionGetByScTchngSlotFrmId.DeletedItems.Count > 0)
					{
						//DataRepository.ScGroupDayProvider.Save(transactionManager, entity.ScGroupDayCollectionGetByScTchngSlotFrmId);
						
						deepHandles.Add("ScGroupDayCollectionGetByScTchngSlotFrmId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScGroupDay >) DataRepository.ScGroupDayProvider.DeepSave,
							new object[] { transactionManager, entity.ScGroupDayCollectionGetByScTchngSlotFrmId, deepSaveType, childTypes, innerList }
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
						if(child.ScTchngSlotIdSource != null)
						{
							child.ScTchngSlotId = child.ScTchngSlotIdSource.ScTchngSlotId;
						}
						else
						{
							child.ScTchngSlotId = entity.ScTchngSlotId;
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
				
	
			#region List<ScGroupDay>
				if (CanDeepSave(entity.ScGroupDayCollectionGetByScTchngSlotToId, "List<ScGroupDay>|ScGroupDayCollectionGetByScTchngSlotToId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScGroupDay child in entity.ScGroupDayCollectionGetByScTchngSlotToId)
					{
						if(child.ScTchngSlotToIdSource != null)
						{
							child.ScTchngSlotToId = child.ScTchngSlotToIdSource.ScTchngSlotId;
						}
						else
						{
							child.ScTchngSlotToId = entity.ScTchngSlotId;
						}

					}

					if (entity.ScGroupDayCollectionGetByScTchngSlotToId.Count > 0 || entity.ScGroupDayCollectionGetByScTchngSlotToId.DeletedItems.Count > 0)
					{
						//DataRepository.ScGroupDayProvider.Save(transactionManager, entity.ScGroupDayCollectionGetByScTchngSlotToId);
						
						deepHandles.Add("ScGroupDayCollectionGetByScTchngSlotToId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScGroupDay >) DataRepository.ScGroupDayProvider.DeepSave,
							new object[] { transactionManager, entity.ScGroupDayCollectionGetByScTchngSlotToId, deepSaveType, childTypes, innerList }
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
						if(child.ScTchngSlotIdSource != null)
						{
							child.ScTchngSlotId = child.ScTchngSlotIdSource.ScTchngSlotId;
						}
						else
						{
							child.ScTchngSlotId = entity.ScTchngSlotId;
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
	
	#region ScTchngSlotChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.ScTchngSlot</c>
	///</summary>
	public enum ScTchngSlotChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsCodeWeekDay</c> at GsCodeWeekDayIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeWeekDay))]
		GsCodeWeekDay,
		
		///<summary>
		/// Composite Property for <c>ScSchdlPeriod</c> at ScSchdlPeriodIdSource
		///</summary>
		[ChildEntityType(typeof(ScSchdlPeriod))]
		ScSchdlPeriod,
		///<summary>
		/// Collection of <c>ScTchngSlot</c> as OneToMany for ScGroupDayCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScGroupDay>))]
		ScGroupDayCollectionGetByScTchngSlotFrmId,
		///<summary>
		/// Collection of <c>ScTchngSlot</c> as OneToMany for ScSchdlSlotCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScSchdlSlot>))]
		ScSchdlSlotCollection,
		///<summary>
		/// Collection of <c>ScTchngSlot</c> as OneToMany for ScGroupDayCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScGroupDay>))]
		ScGroupDayCollectionGetByScTchngSlotToId,
		///<summary>
		/// Collection of <c>ScTchngSlot</c> as OneToMany for ScScheduleDtlDayCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScScheduleDtlDay>))]
		ScScheduleDtlDayCollection,
	}
	
	#endregion ScTchngSlotChildEntityTypes
	
	#region ScTchngSlotFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ScTchngSlotColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScTchngSlot"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScTchngSlotFilterBuilder : SqlFilterBuilder<ScTchngSlotColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScTchngSlotFilterBuilder class.
		/// </summary>
		public ScTchngSlotFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScTchngSlotFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScTchngSlotFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScTchngSlotFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScTchngSlotFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScTchngSlotFilterBuilder
	
	#region ScTchngSlotParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ScTchngSlotColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScTchngSlot"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScTchngSlotParameterBuilder : ParameterizedSqlFilterBuilder<ScTchngSlotColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScTchngSlotParameterBuilder class.
		/// </summary>
		public ScTchngSlotParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScTchngSlotParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScTchngSlotParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScTchngSlotParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScTchngSlotParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScTchngSlotParameterBuilder
	
	#region ScTchngSlotSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ScTchngSlotColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScTchngSlot"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ScTchngSlotSortBuilder : SqlSortBuilder<ScTchngSlotColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScTchngSlotSqlSortBuilder class.
		/// </summary>
		public ScTchngSlotSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ScTchngSlotSortBuilder
	
} // end namespace
