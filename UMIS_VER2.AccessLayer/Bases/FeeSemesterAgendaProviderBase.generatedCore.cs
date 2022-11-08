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
	/// This class is the base class for any <see cref="FeeSemesterAgendaProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeSemesterAgendaProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeSemesterAgenda, UMIS_VER2.BusinessLyer.FeeSemesterAgendaKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeSemesterAgendaKey key)
		{
			return Delete(transactionManager, key.FeeSemesterAgendaId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeSemesterAgendaId">XXXXX not used. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeSemesterAgendaId)
		{
			return Delete(null, _feeSemesterAgendaId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeSemesterAgendaId">XXXXX not used. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeSemesterAgendaId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_SEMESTER_AGENDA_ENTITY_MAIN key.
		///		FK_FEE_SEMESTER_AGENDA_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeSemesterAgenda objects.</returns>
		public TList<FeeSemesterAgenda> GetByEntMainId(System.Decimal? _entMainId)
		{
			int count = -1;
			return GetByEntMainId(_entMainId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_SEMESTER_AGENDA_ENTITY_MAIN key.
		///		FK_FEE_SEMESTER_AGENDA_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeSemesterAgenda objects.</returns>
		/// <remarks></remarks>
		public TList<FeeSemesterAgenda> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_SEMESTER_AGENDA_ENTITY_MAIN key.
		///		FK_FEE_SEMESTER_AGENDA_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeSemesterAgenda objects.</returns>
		public TList<FeeSemesterAgenda> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_SEMESTER_AGENDA_ENTITY_MAIN key.
		///		fkFeeSemesterAgendaEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeSemesterAgenda objects.</returns>
		public TList<FeeSemesterAgenda> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainId(null, _entMainId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_SEMESTER_AGENDA_ENTITY_MAIN key.
		///		fkFeeSemesterAgendaEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeSemesterAgenda objects.</returns>
		public TList<FeeSemesterAgenda> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength,out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_SEMESTER_AGENDA_ENTITY_MAIN key.
		///		FK_FEE_SEMESTER_AGENDA_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeSemesterAgenda objects.</returns>
		public abstract TList<FeeSemesterAgenda> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeSemesterAgenda Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeSemesterAgendaKey key, int start, int pageLength)
		{
			return GetByFeeSemesterAgendaId(transactionManager, key.FeeSemesterAgendaId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_SEMESTER_AGENDA_I_1 index.
		/// </summary>
		/// <param name="_edCodeSemActvityId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeSemesterAgenda&gt;"/> class.</returns>
		public TList<FeeSemesterAgenda> GetByEdCodeSemActvityId(System.Decimal _edCodeSemActvityId)
		{
			int count = -1;
			return GetByEdCodeSemActvityId(null,_edCodeSemActvityId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_SEMESTER_AGENDA_I_1 index.
		/// </summary>
		/// <param name="_edCodeSemActvityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeSemesterAgenda&gt;"/> class.</returns>
		public TList<FeeSemesterAgenda> GetByEdCodeSemActvityId(System.Decimal _edCodeSemActvityId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemActvityId(null, _edCodeSemActvityId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_SEMESTER_AGENDA_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemActvityId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeSemesterAgenda&gt;"/> class.</returns>
		public TList<FeeSemesterAgenda> GetByEdCodeSemActvityId(TransactionManager transactionManager, System.Decimal _edCodeSemActvityId)
		{
			int count = -1;
			return GetByEdCodeSemActvityId(transactionManager, _edCodeSemActvityId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_SEMESTER_AGENDA_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemActvityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeSemesterAgenda&gt;"/> class.</returns>
		public TList<FeeSemesterAgenda> GetByEdCodeSemActvityId(TransactionManager transactionManager, System.Decimal _edCodeSemActvityId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemActvityId(transactionManager, _edCodeSemActvityId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_SEMESTER_AGENDA_I_1 index.
		/// </summary>
		/// <param name="_edCodeSemActvityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeSemesterAgenda&gt;"/> class.</returns>
		public TList<FeeSemesterAgenda> GetByEdCodeSemActvityId(System.Decimal _edCodeSemActvityId, int start, int pageLength, out int count)
		{
			return GetByEdCodeSemActvityId(null, _edCodeSemActvityId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_SEMESTER_AGENDA_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemActvityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeSemesterAgenda&gt;"/> class.</returns>
		public abstract TList<FeeSemesterAgenda> GetByEdCodeSemActvityId(TransactionManager transactionManager, System.Decimal _edCodeSemActvityId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_FEE_CODE_ITEM_ID_1 index.
		/// </summary>
		/// <param name="_feeCodeItemId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeSemesterAgenda&gt;"/> class.</returns>
		public TList<FeeSemesterAgenda> GetByFeeCodeItemId(System.Decimal _feeCodeItemId)
		{
			int count = -1;
			return GetByFeeCodeItemId(null,_feeCodeItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_CODE_ITEM_ID_1 index.
		/// </summary>
		/// <param name="_feeCodeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeSemesterAgenda&gt;"/> class.</returns>
		public TList<FeeSemesterAgenda> GetByFeeCodeItemId(System.Decimal _feeCodeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeItemId(null, _feeCodeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_CODE_ITEM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeSemesterAgenda&gt;"/> class.</returns>
		public TList<FeeSemesterAgenda> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal _feeCodeItemId)
		{
			int count = -1;
			return GetByFeeCodeItemId(transactionManager, _feeCodeItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_CODE_ITEM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeSemesterAgenda&gt;"/> class.</returns>
		public TList<FeeSemesterAgenda> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal _feeCodeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeItemId(transactionManager, _feeCodeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_CODE_ITEM_ID_1 index.
		/// </summary>
		/// <param name="_feeCodeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeSemesterAgenda&gt;"/> class.</returns>
		public TList<FeeSemesterAgenda> GetByFeeCodeItemId(System.Decimal _feeCodeItemId, int start, int pageLength, out int count)
		{
			return GetByFeeCodeItemId(null, _feeCodeItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_CODE_ITEM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeSemesterAgenda&gt;"/> class.</returns>
		public abstract TList<FeeSemesterAgenda> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal _feeCodeItemId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_FEE_SEMESTER_AGENDA index.
		/// </summary>
		/// <param name="_feeCodeItemId"></param>
		/// <param name="_edCodeSemActvityId"></param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="_entMainId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeSemesterAgenda"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeSemesterAgenda GetByFeeCodeItemIdEdCodeSemActvityIdGsCodeCurrencyIdEntMainId(System.Decimal _feeCodeItemId, System.Decimal _edCodeSemActvityId, System.Decimal _gsCodeCurrencyId, System.Decimal? _entMainId)
		{
			int count = -1;
			return GetByFeeCodeItemIdEdCodeSemActvityIdGsCodeCurrencyIdEntMainId(null,_feeCodeItemId, _edCodeSemActvityId, _gsCodeCurrencyId, _entMainId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_SEMESTER_AGENDA index.
		/// </summary>
		/// <param name="_feeCodeItemId"></param>
		/// <param name="_edCodeSemActvityId"></param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeSemesterAgenda"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeSemesterAgenda GetByFeeCodeItemIdEdCodeSemActvityIdGsCodeCurrencyIdEntMainId(System.Decimal _feeCodeItemId, System.Decimal _edCodeSemActvityId, System.Decimal _gsCodeCurrencyId, System.Decimal? _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeItemIdEdCodeSemActvityIdGsCodeCurrencyIdEntMainId(null, _feeCodeItemId, _edCodeSemActvityId, _gsCodeCurrencyId, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_SEMESTER_AGENDA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId"></param>
		/// <param name="_edCodeSemActvityId"></param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="_entMainId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeSemesterAgenda"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeSemesterAgenda GetByFeeCodeItemIdEdCodeSemActvityIdGsCodeCurrencyIdEntMainId(TransactionManager transactionManager, System.Decimal _feeCodeItemId, System.Decimal _edCodeSemActvityId, System.Decimal _gsCodeCurrencyId, System.Decimal? _entMainId)
		{
			int count = -1;
			return GetByFeeCodeItemIdEdCodeSemActvityIdGsCodeCurrencyIdEntMainId(transactionManager, _feeCodeItemId, _edCodeSemActvityId, _gsCodeCurrencyId, _entMainId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_SEMESTER_AGENDA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId"></param>
		/// <param name="_edCodeSemActvityId"></param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeSemesterAgenda"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeSemesterAgenda GetByFeeCodeItemIdEdCodeSemActvityIdGsCodeCurrencyIdEntMainId(TransactionManager transactionManager, System.Decimal _feeCodeItemId, System.Decimal _edCodeSemActvityId, System.Decimal _gsCodeCurrencyId, System.Decimal? _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeItemIdEdCodeSemActvityIdGsCodeCurrencyIdEntMainId(transactionManager, _feeCodeItemId, _edCodeSemActvityId, _gsCodeCurrencyId, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_SEMESTER_AGENDA index.
		/// </summary>
		/// <param name="_feeCodeItemId"></param>
		/// <param name="_edCodeSemActvityId"></param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeSemesterAgenda"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeSemesterAgenda GetByFeeCodeItemIdEdCodeSemActvityIdGsCodeCurrencyIdEntMainId(System.Decimal _feeCodeItemId, System.Decimal _edCodeSemActvityId, System.Decimal _gsCodeCurrencyId, System.Decimal? _entMainId, int start, int pageLength, out int count)
		{
			return GetByFeeCodeItemIdEdCodeSemActvityIdGsCodeCurrencyIdEntMainId(null, _feeCodeItemId, _edCodeSemActvityId, _gsCodeCurrencyId, _entMainId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_SEMESTER_AGENDA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId"></param>
		/// <param name="_edCodeSemActvityId"></param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeSemesterAgenda"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeSemesterAgenda GetByFeeCodeItemIdEdCodeSemActvityIdGsCodeCurrencyIdEntMainId(TransactionManager transactionManager, System.Decimal _feeCodeItemId, System.Decimal _edCodeSemActvityId, System.Decimal _gsCodeCurrencyId, System.Decimal? _entMainId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_CODE_CURRENCY_ID_1 index.
		/// </summary>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeSemesterAgenda&gt;"/> class.</returns>
		public TList<FeeSemesterAgenda> GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeSemesterAgenda&gt;"/> class.</returns>
		public TList<FeeSemesterAgenda> GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeSemesterAgenda&gt;"/> class.</returns>
		public TList<FeeSemesterAgenda> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeSemesterAgenda&gt;"/> class.</returns>
		public TList<FeeSemesterAgenda> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeSemesterAgenda&gt;"/> class.</returns>
		public TList<FeeSemesterAgenda> GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeSemesterAgenda&gt;"/> class.</returns>
		public abstract TList<FeeSemesterAgenda> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_SEMESTER_AGENDA index.
		/// </summary>
		/// <param name="_feeSemesterAgendaId">XXXXX not used</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeSemesterAgenda"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeSemesterAgenda GetByFeeSemesterAgendaId(System.Decimal _feeSemesterAgendaId)
		{
			int count = -1;
			return GetByFeeSemesterAgendaId(null,_feeSemesterAgendaId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_SEMESTER_AGENDA index.
		/// </summary>
		/// <param name="_feeSemesterAgendaId">XXXXX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeSemesterAgenda"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeSemesterAgenda GetByFeeSemesterAgendaId(System.Decimal _feeSemesterAgendaId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeSemesterAgendaId(null, _feeSemesterAgendaId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_SEMESTER_AGENDA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeSemesterAgendaId">XXXXX not used</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeSemesterAgenda"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeSemesterAgenda GetByFeeSemesterAgendaId(TransactionManager transactionManager, System.Decimal _feeSemesterAgendaId)
		{
			int count = -1;
			return GetByFeeSemesterAgendaId(transactionManager, _feeSemesterAgendaId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_SEMESTER_AGENDA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeSemesterAgendaId">XXXXX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeSemesterAgenda"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeSemesterAgenda GetByFeeSemesterAgendaId(TransactionManager transactionManager, System.Decimal _feeSemesterAgendaId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeSemesterAgendaId(transactionManager, _feeSemesterAgendaId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_SEMESTER_AGENDA index.
		/// </summary>
		/// <param name="_feeSemesterAgendaId">XXXXX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeSemesterAgenda"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeSemesterAgenda GetByFeeSemesterAgendaId(System.Decimal _feeSemesterAgendaId, int start, int pageLength, out int count)
		{
			return GetByFeeSemesterAgendaId(null, _feeSemesterAgendaId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_SEMESTER_AGENDA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeSemesterAgendaId">XXXXX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeSemesterAgenda"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeSemesterAgenda GetByFeeSemesterAgendaId(TransactionManager transactionManager, System.Decimal _feeSemesterAgendaId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeSemesterAgenda&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeSemesterAgenda&gt;"/></returns>
		public static TList<FeeSemesterAgenda> Fill(IDataReader reader, TList<FeeSemesterAgenda> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeSemesterAgenda c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeSemesterAgenda")
					.Append("|").Append((System.Decimal)reader["FEE_SEMESTER_AGENDA_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeSemesterAgenda>(
					key.ToString(), // EntityTrackingKey
					"FeeSemesterAgenda",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeSemesterAgenda();
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
					c.FeeSemesterAgendaId = (System.Decimal)reader["FEE_SEMESTER_AGENDA_ID"];
					c.OriginalFeeSemesterAgendaId = c.FeeSemesterAgendaId;
					c.EdCodeSemActvityId = (System.Decimal)reader["ED_CODE_SEM_ACTVITY_ID"];
					c.FeeCodeItemId = (System.Decimal)reader["FEE_CODE_ITEM_ID"];
					c.Amount = (System.Decimal)reader["AMOUNT"];
					c.AmntPrcntFlg = (System.Boolean)reader["AMNT_PRCNT_FLG"];
					c.GsCodeCurrencyId = (System.Decimal)reader["GS_CODE_CURRENCY_ID"];
					c.EntMainId = Convert.IsDBNull(reader["ENT_MAIN_ID"]) ? null : (System.Decimal?)reader["ENT_MAIN_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeSemesterAgenda"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeSemesterAgenda"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeSemesterAgenda entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeSemesterAgendaId = (System.Decimal)reader[((int)FeeSemesterAgendaColumn.FeeSemesterAgendaId - 1)];
			entity.OriginalFeeSemesterAgendaId = (System.Decimal)reader["FEE_SEMESTER_AGENDA_ID"];
			entity.EdCodeSemActvityId = (System.Decimal)reader[((int)FeeSemesterAgendaColumn.EdCodeSemActvityId - 1)];
			entity.FeeCodeItemId = (System.Decimal)reader[((int)FeeSemesterAgendaColumn.FeeCodeItemId - 1)];
			entity.Amount = (System.Decimal)reader[((int)FeeSemesterAgendaColumn.Amount - 1)];
			entity.AmntPrcntFlg = (System.Boolean)reader[((int)FeeSemesterAgendaColumn.AmntPrcntFlg - 1)];
			entity.GsCodeCurrencyId = (System.Decimal)reader[((int)FeeSemesterAgendaColumn.GsCodeCurrencyId - 1)];
			entity.EntMainId = (reader.IsDBNull(((int)FeeSemesterAgendaColumn.EntMainId - 1)))?null:(System.Decimal?)reader[((int)FeeSemesterAgendaColumn.EntMainId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeSemesterAgenda"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeSemesterAgenda"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeSemesterAgenda entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeSemesterAgendaId = (System.Decimal)dataRow["FEE_SEMESTER_AGENDA_ID"];
			entity.OriginalFeeSemesterAgendaId = (System.Decimal)dataRow["FEE_SEMESTER_AGENDA_ID"];
			entity.EdCodeSemActvityId = (System.Decimal)dataRow["ED_CODE_SEM_ACTVITY_ID"];
			entity.FeeCodeItemId = (System.Decimal)dataRow["FEE_CODE_ITEM_ID"];
			entity.Amount = (System.Decimal)dataRow["AMOUNT"];
			entity.AmntPrcntFlg = (System.Boolean)dataRow["AMNT_PRCNT_FLG"];
			entity.GsCodeCurrencyId = (System.Decimal)dataRow["GS_CODE_CURRENCY_ID"];
			entity.EntMainId = Convert.IsDBNull(dataRow["ENT_MAIN_ID"]) ? null : (System.Decimal?)dataRow["ENT_MAIN_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeSemesterAgenda"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeSemesterAgenda Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeSemesterAgenda entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCodeSemActvityIdSource	
			if (CanDeepLoad(entity, "EdCodeSemActvity|EdCodeSemActvityIdSource", deepLoadType, innerList) 
				&& entity.EdCodeSemActvityIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeSemActvityId;
				EdCodeSemActvity tmpEntity = EntityManager.LocateEntity<EdCodeSemActvity>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemActvity), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemActvityIdSource = tmpEntity;
				else
					entity.EdCodeSemActvityIdSource = DataRepository.EdCodeSemActvityProvider.GetByEdCodeSemActvityId(transactionManager, entity.EdCodeSemActvityId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeSemActvityIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeSemActvityIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeSemActvityProvider.DeepLoad(transactionManager, entity.EdCodeSemActvityIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeSemActvityIdSource

			#region EntMainIdSource	
			if (CanDeepLoad(entity, "EntityMain|EntMainIdSource", deepLoadType, innerList) 
				&& entity.EntMainIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntMainId ?? 0.0m);
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntMainIdSource = tmpEntity;
				else
					entity.EntMainIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, (entity.EntMainId ?? 0.0m));		
				
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
				pkItems[0] = entity.FeeCodeItemId;
				FeeCodeItem tmpEntity = EntityManager.LocateEntity<FeeCodeItem>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCodeItem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCodeItemIdSource = tmpEntity;
				else
					entity.FeeCodeItemIdSource = DataRepository.FeeCodeItemProvider.GetByFeeCodeItemId(transactionManager, entity.FeeCodeItemId);		
				
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeSemesterAgenda object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeSemesterAgenda instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeSemesterAgenda Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeSemesterAgenda entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCodeSemActvityIdSource
			if (CanDeepSave(entity, "EdCodeSemActvity|EdCodeSemActvityIdSource", deepSaveType, innerList) 
				&& entity.EdCodeSemActvityIdSource != null)
			{
				DataRepository.EdCodeSemActvityProvider.Save(transactionManager, entity.EdCodeSemActvityIdSource);
				entity.EdCodeSemActvityId = entity.EdCodeSemActvityIdSource.EdCodeSemActvityId;
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
	
	#region FeeSemesterAgendaChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeSemesterAgenda</c>
	///</summary>
	public enum FeeSemesterAgendaChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCodeSemActvity</c> at EdCodeSemActvityIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemActvity))]
		EdCodeSemActvity,
		
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
	}
	
	#endregion FeeSemesterAgendaChildEntityTypes
	
	#region FeeSemesterAgendaFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeSemesterAgendaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeSemesterAgenda"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeSemesterAgendaFilterBuilder : SqlFilterBuilder<FeeSemesterAgendaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeSemesterAgendaFilterBuilder class.
		/// </summary>
		public FeeSemesterAgendaFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeSemesterAgendaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeSemesterAgendaFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeSemesterAgendaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeSemesterAgendaFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeSemesterAgendaFilterBuilder
	
	#region FeeSemesterAgendaParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeSemesterAgendaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeSemesterAgenda"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeSemesterAgendaParameterBuilder : ParameterizedSqlFilterBuilder<FeeSemesterAgendaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeSemesterAgendaParameterBuilder class.
		/// </summary>
		public FeeSemesterAgendaParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeSemesterAgendaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeSemesterAgendaParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeSemesterAgendaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeSemesterAgendaParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeSemesterAgendaParameterBuilder
	
	#region FeeSemesterAgendaSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeSemesterAgendaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeSemesterAgenda"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeSemesterAgendaSortBuilder : SqlSortBuilder<FeeSemesterAgendaColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeSemesterAgendaSqlSortBuilder class.
		/// </summary>
		public FeeSemesterAgendaSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeSemesterAgendaSortBuilder
	
} // end namespace
