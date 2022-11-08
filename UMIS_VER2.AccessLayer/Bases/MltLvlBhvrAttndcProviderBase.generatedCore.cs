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
	/// This class is the base class for any <see cref="MltLvlBhvrAttndcProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class MltLvlBhvrAttndcProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc, UMIS_VER2.BusinessLyer.MltLvlBhvrAttndcKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltLvlBhvrAttndcKey key)
		{
			return Delete(transactionManager, key.MltLvlBhvrAttndcId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_mltLvlBhvrAttndcId">درجات السلوك والمواظبة لكل فصل مستوى. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _mltLvlBhvrAttndcId)
		{
			return Delete(null, _mltLvlBhvrAttndcId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltLvlBhvrAttndcId">درجات السلوك والمواظبة لكل فصل مستوى. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _mltLvlBhvrAttndcId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_LVL_BHVR_ATTNDC_ED_CODE_LEVEL key.
		///		FK_MLT_LVL_BHVR_ATTNDC_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="_edCodeLevelId">if null  then foundation المستوى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc objects.</returns>
		public TList<MltLvlBhvrAttndc> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(_edCodeLevelId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_LVL_BHVR_ATTNDC_ED_CODE_LEVEL key.
		///		FK_MLT_LVL_BHVR_ATTNDC_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId">if null  then foundation المستوى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc objects.</returns>
		/// <remarks></remarks>
		public TList<MltLvlBhvrAttndc> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_LVL_BHVR_ATTNDC_ED_CODE_LEVEL key.
		///		FK_MLT_LVL_BHVR_ATTNDC_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId">if null  then foundation المستوى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc objects.</returns>
		public TList<MltLvlBhvrAttndc> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_LVL_BHVR_ATTNDC_ED_CODE_LEVEL key.
		///		fkMltLvlBhvrAttndcEdCodeLevel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelId">if null  then foundation المستوى</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc objects.</returns>
		public TList<MltLvlBhvrAttndc> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_LVL_BHVR_ATTNDC_ED_CODE_LEVEL key.
		///		fkMltLvlBhvrAttndcEdCodeLevel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelId">if null  then foundation المستوى</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc objects.</returns>
		public TList<MltLvlBhvrAttndc> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId, int start, int pageLength,out int count)
		{
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_LVL_BHVR_ATTNDC_ED_CODE_LEVEL key.
		///		FK_MLT_LVL_BHVR_ATTNDC_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId">if null  then foundation المستوى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc objects.</returns>
		public abstract TList<MltLvlBhvrAttndc> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_LVL_BHVR_ATTNDC_ED_CODE_SEMESTER key.
		///		FK_MLT_LVL_BHVR_ATTNDC_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc objects.</returns>
		public TList<MltLvlBhvrAttndc> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_LVL_BHVR_ATTNDC_ED_CODE_SEMESTER key.
		///		FK_MLT_LVL_BHVR_ATTNDC_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc objects.</returns>
		/// <remarks></remarks>
		public TList<MltLvlBhvrAttndc> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_LVL_BHVR_ATTNDC_ED_CODE_SEMESTER key.
		///		FK_MLT_LVL_BHVR_ATTNDC_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc objects.</returns>
		public TList<MltLvlBhvrAttndc> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_LVL_BHVR_ATTNDC_ED_CODE_SEMESTER key.
		///		fkMltLvlBhvrAttndcEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc objects.</returns>
		public TList<MltLvlBhvrAttndc> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_LVL_BHVR_ATTNDC_ED_CODE_SEMESTER key.
		///		fkMltLvlBhvrAttndcEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc objects.</returns>
		public TList<MltLvlBhvrAttndc> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_LVL_BHVR_ATTNDC_ED_CODE_SEMESTER key.
		///		FK_MLT_LVL_BHVR_ATTNDC_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc objects.</returns>
		public abstract TList<MltLvlBhvrAttndc> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltLvlBhvrAttndcKey key, int start, int pageLength)
		{
			return GetByMltLvlBhvrAttndcId(transactionManager, key.MltLvlBhvrAttndcId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_MLT_LVL_BHVR_ATTNDC index.
		/// </summary>
		/// <param name="_mltLvlBhvrAttndcId">درجات السلوك والمواظبة لكل فصل مستوى</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc GetByMltLvlBhvrAttndcId(System.Decimal _mltLvlBhvrAttndcId)
		{
			int count = -1;
			return GetByMltLvlBhvrAttndcId(null,_mltLvlBhvrAttndcId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_LVL_BHVR_ATTNDC index.
		/// </summary>
		/// <param name="_mltLvlBhvrAttndcId">درجات السلوك والمواظبة لكل فصل مستوى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc GetByMltLvlBhvrAttndcId(System.Decimal _mltLvlBhvrAttndcId, int start, int pageLength)
		{
			int count = -1;
			return GetByMltLvlBhvrAttndcId(null, _mltLvlBhvrAttndcId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_LVL_BHVR_ATTNDC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltLvlBhvrAttndcId">درجات السلوك والمواظبة لكل فصل مستوى</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc GetByMltLvlBhvrAttndcId(TransactionManager transactionManager, System.Decimal _mltLvlBhvrAttndcId)
		{
			int count = -1;
			return GetByMltLvlBhvrAttndcId(transactionManager, _mltLvlBhvrAttndcId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_LVL_BHVR_ATTNDC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltLvlBhvrAttndcId">درجات السلوك والمواظبة لكل فصل مستوى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc GetByMltLvlBhvrAttndcId(TransactionManager transactionManager, System.Decimal _mltLvlBhvrAttndcId, int start, int pageLength)
		{
			int count = -1;
			return GetByMltLvlBhvrAttndcId(transactionManager, _mltLvlBhvrAttndcId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_LVL_BHVR_ATTNDC index.
		/// </summary>
		/// <param name="_mltLvlBhvrAttndcId">درجات السلوك والمواظبة لكل فصل مستوى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc GetByMltLvlBhvrAttndcId(System.Decimal _mltLvlBhvrAttndcId, int start, int pageLength, out int count)
		{
			return GetByMltLvlBhvrAttndcId(null, _mltLvlBhvrAttndcId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_LVL_BHVR_ATTNDC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltLvlBhvrAttndcId">درجات السلوك والمواظبة لكل فصل مستوى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc GetByMltLvlBhvrAttndcId(TransactionManager transactionManager, System.Decimal _mltLvlBhvrAttndcId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_MLT_LVL_BHVR_ATTNDC index.
		/// </summary>
		/// <param name="_edCodeLevelId">if null  then foundation المستوى</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc GetByEdCodeLevelIdEdCodeSemesterId(System.Decimal? _edCodeLevelId, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeLevelIdEdCodeSemesterId(null,_edCodeLevelId, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MLT_LVL_BHVR_ATTNDC index.
		/// </summary>
		/// <param name="_edCodeLevelId">if null  then foundation المستوى</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc GetByEdCodeLevelIdEdCodeSemesterId(System.Decimal? _edCodeLevelId, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLevelIdEdCodeSemesterId(null, _edCodeLevelId, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MLT_LVL_BHVR_ATTNDC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId">if null  then foundation المستوى</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc GetByEdCodeLevelIdEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeLevelIdEdCodeSemesterId(transactionManager, _edCodeLevelId, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MLT_LVL_BHVR_ATTNDC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId">if null  then foundation المستوى</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc GetByEdCodeLevelIdEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLevelIdEdCodeSemesterId(transactionManager, _edCodeLevelId, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MLT_LVL_BHVR_ATTNDC index.
		/// </summary>
		/// <param name="_edCodeLevelId">if null  then foundation المستوى</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc GetByEdCodeLevelIdEdCodeSemesterId(System.Decimal? _edCodeLevelId, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count)
		{
			return GetByEdCodeLevelIdEdCodeSemesterId(null, _edCodeLevelId, _edCodeSemesterId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MLT_LVL_BHVR_ATTNDC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId">if null  then foundation المستوى</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc GetByEdCodeLevelIdEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;MltLvlBhvrAttndc&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;MltLvlBhvrAttndc&gt;"/></returns>
		public static TList<MltLvlBhvrAttndc> Fill(IDataReader reader, TList<MltLvlBhvrAttndc> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("MltLvlBhvrAttndc")
					.Append("|").Append((System.Decimal)reader["MLT_LVL_BHVR_ATTNDC_ID"]).ToString();
					c = EntityManager.LocateOrCreate<MltLvlBhvrAttndc>(
					key.ToString(), // EntityTrackingKey
					"MltLvlBhvrAttndc",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc();
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
					c.MltLvlBhvrAttndcId = (System.Decimal)reader["MLT_LVL_BHVR_ATTNDC_ID"];
					c.OriginalMltLvlBhvrAttndcId = c.MltLvlBhvrAttndcId;
					c.EdCodeLevelId = Convert.IsDBNull(reader["ED_CODE_LEVEL_ID"]) ? null : (System.Decimal?)reader["ED_CODE_LEVEL_ID"];
					c.EdCodeSemesterId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_ID"];
					c.BhvMarkMin = Convert.IsDBNull(reader["BHV_MARK_MIN"]) ? null : (System.Decimal?)reader["BHV_MARK_MIN"];
					c.BhvrMarkMax = Convert.IsDBNull(reader["BHVR_MARK_MAX"]) ? null : (System.Decimal?)reader["BHVR_MARK_MAX"];
					c.AttndMarkMin = Convert.IsDBNull(reader["ATTND_MARK_MIN"]) ? null : (System.Decimal?)reader["ATTND_MARK_MIN"];
					c.AttndMarkMax = Convert.IsDBNull(reader["ATTND_MARK_MAX"]) ? null : (System.Decimal?)reader["ATTND_MARK_MAX"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc entity)
		{
			if (!reader.Read()) return;
			
			entity.MltLvlBhvrAttndcId = (System.Decimal)reader[((int)MltLvlBhvrAttndcColumn.MltLvlBhvrAttndcId - 1)];
			entity.OriginalMltLvlBhvrAttndcId = (System.Decimal)reader["MLT_LVL_BHVR_ATTNDC_ID"];
			entity.EdCodeLevelId = (reader.IsDBNull(((int)MltLvlBhvrAttndcColumn.EdCodeLevelId - 1)))?null:(System.Decimal?)reader[((int)MltLvlBhvrAttndcColumn.EdCodeLevelId - 1)];
			entity.EdCodeSemesterId = (reader.IsDBNull(((int)MltLvlBhvrAttndcColumn.EdCodeSemesterId - 1)))?null:(System.Decimal?)reader[((int)MltLvlBhvrAttndcColumn.EdCodeSemesterId - 1)];
			entity.BhvMarkMin = (reader.IsDBNull(((int)MltLvlBhvrAttndcColumn.BhvMarkMin - 1)))?null:(System.Decimal?)reader[((int)MltLvlBhvrAttndcColumn.BhvMarkMin - 1)];
			entity.BhvrMarkMax = (reader.IsDBNull(((int)MltLvlBhvrAttndcColumn.BhvrMarkMax - 1)))?null:(System.Decimal?)reader[((int)MltLvlBhvrAttndcColumn.BhvrMarkMax - 1)];
			entity.AttndMarkMin = (reader.IsDBNull(((int)MltLvlBhvrAttndcColumn.AttndMarkMin - 1)))?null:(System.Decimal?)reader[((int)MltLvlBhvrAttndcColumn.AttndMarkMin - 1)];
			entity.AttndMarkMax = (reader.IsDBNull(((int)MltLvlBhvrAttndcColumn.AttndMarkMax - 1)))?null:(System.Decimal?)reader[((int)MltLvlBhvrAttndcColumn.AttndMarkMax - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MltLvlBhvrAttndcId = (System.Decimal)dataRow["MLT_LVL_BHVR_ATTNDC_ID"];
			entity.OriginalMltLvlBhvrAttndcId = (System.Decimal)dataRow["MLT_LVL_BHVR_ATTNDC_ID"];
			entity.EdCodeLevelId = Convert.IsDBNull(dataRow["ED_CODE_LEVEL_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_LEVEL_ID"];
			entity.EdCodeSemesterId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_ID"];
			entity.BhvMarkMin = Convert.IsDBNull(dataRow["BHV_MARK_MIN"]) ? null : (System.Decimal?)dataRow["BHV_MARK_MIN"];
			entity.BhvrMarkMax = Convert.IsDBNull(dataRow["BHVR_MARK_MAX"]) ? null : (System.Decimal?)dataRow["BHVR_MARK_MAX"];
			entity.AttndMarkMin = Convert.IsDBNull(dataRow["ATTND_MARK_MIN"]) ? null : (System.Decimal?)dataRow["ATTND_MARK_MIN"];
			entity.AttndMarkMax = Convert.IsDBNull(dataRow["ATTND_MARK_MAX"]) ? null : (System.Decimal?)dataRow["ATTND_MARK_MAX"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMltLvlBhvrAttndcId methods when available
			
			#region MltStudBhvrAttndcCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MltStudBhvrAttndc>|MltStudBhvrAttndcCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MltStudBhvrAttndcCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MltStudBhvrAttndcCollection = DataRepository.MltStudBhvrAttndcProvider.GetByMltLvlBhvrAttndcId(transactionManager, entity.MltLvlBhvrAttndcId);

				if (deep && entity.MltStudBhvrAttndcCollection.Count > 0)
				{
					deepHandles.Add("MltStudBhvrAttndcCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MltStudBhvrAttndc>) DataRepository.MltStudBhvrAttndcProvider.DeepLoad,
						new object[] { transactionManager, entity.MltStudBhvrAttndcCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCodeLevelIdSource
			if (CanDeepSave(entity, "EdCodeLevel|EdCodeLevelIdSource", deepSaveType, innerList) 
				&& entity.EdCodeLevelIdSource != null)
			{
				DataRepository.EdCodeLevelProvider.Save(transactionManager, entity.EdCodeLevelIdSource);
				entity.EdCodeLevelId = entity.EdCodeLevelIdSource.EdCodeLevelId;
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
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<MltStudBhvrAttndc>
				if (CanDeepSave(entity.MltStudBhvrAttndcCollection, "List<MltStudBhvrAttndc>|MltStudBhvrAttndcCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MltStudBhvrAttndc child in entity.MltStudBhvrAttndcCollection)
					{
						if(child.MltLvlBhvrAttndcIdSource != null)
						{
							child.MltLvlBhvrAttndcId = child.MltLvlBhvrAttndcIdSource.MltLvlBhvrAttndcId;
						}
						else
						{
							child.MltLvlBhvrAttndcId = entity.MltLvlBhvrAttndcId;
						}

					}

					if (entity.MltStudBhvrAttndcCollection.Count > 0 || entity.MltStudBhvrAttndcCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MltStudBhvrAttndcProvider.Save(transactionManager, entity.MltStudBhvrAttndcCollection);
						
						deepHandles.Add("MltStudBhvrAttndcCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MltStudBhvrAttndc >) DataRepository.MltStudBhvrAttndcProvider.DeepSave,
							new object[] { transactionManager, entity.MltStudBhvrAttndcCollection, deepSaveType, childTypes, innerList }
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
	
	#region MltLvlBhvrAttndcChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.MltLvlBhvrAttndc</c>
	///</summary>
	public enum MltLvlBhvrAttndcChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCodeLevel</c> at EdCodeLevelIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeLevel))]
		EdCodeLevel,
		
		///<summary>
		/// Composite Property for <c>EdCodeSemester</c> at EdCodeSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemester))]
		EdCodeSemester,
		///<summary>
		/// Collection of <c>MltLvlBhvrAttndc</c> as OneToMany for MltStudBhvrAttndcCollection
		///</summary>
		[ChildEntityType(typeof(TList<MltStudBhvrAttndc>))]
		MltStudBhvrAttndcCollection,
	}
	
	#endregion MltLvlBhvrAttndcChildEntityTypes
	
	#region MltLvlBhvrAttndcFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;MltLvlBhvrAttndcColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MltLvlBhvrAttndc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MltLvlBhvrAttndcFilterBuilder : SqlFilterBuilder<MltLvlBhvrAttndcColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MltLvlBhvrAttndcFilterBuilder class.
		/// </summary>
		public MltLvlBhvrAttndcFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MltLvlBhvrAttndcFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MltLvlBhvrAttndcFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MltLvlBhvrAttndcFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MltLvlBhvrAttndcFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MltLvlBhvrAttndcFilterBuilder
	
	#region MltLvlBhvrAttndcParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;MltLvlBhvrAttndcColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MltLvlBhvrAttndc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MltLvlBhvrAttndcParameterBuilder : ParameterizedSqlFilterBuilder<MltLvlBhvrAttndcColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MltLvlBhvrAttndcParameterBuilder class.
		/// </summary>
		public MltLvlBhvrAttndcParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MltLvlBhvrAttndcParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MltLvlBhvrAttndcParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MltLvlBhvrAttndcParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MltLvlBhvrAttndcParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MltLvlBhvrAttndcParameterBuilder
	
	#region MltLvlBhvrAttndcSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;MltLvlBhvrAttndcColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MltLvlBhvrAttndc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class MltLvlBhvrAttndcSortBuilder : SqlSortBuilder<MltLvlBhvrAttndcColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MltLvlBhvrAttndcSqlSortBuilder class.
		/// </summary>
		public MltLvlBhvrAttndcSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion MltLvlBhvrAttndcSortBuilder
	
} // end namespace
