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
	/// This class is the base class for any <see cref="EntFullfillMdDataProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntFullfillMdDataProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntFullfillMdData, UMIS_VER2.BusinessLyer.EntFullfillMdDataKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntFullfillMdDataKey key)
		{
			return Delete(transactionManager, key.EntFullfillMdDataId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entFullfillMdDataId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entFullfillMdDataId)
		{
			return Delete(null, _entFullfillMdDataId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entFullfillMdDataId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entFullfillMdDataId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_FULLFILL_MD_DATA_ED_ACAD_YEAR key.
		///		FK_ENT_FULLFILL_MD_DATA_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntFullfillMdData objects.</returns>
		public TList<EntFullfillMdData> GetByEdAcadYearId(System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_FULLFILL_MD_DATA_ED_ACAD_YEAR key.
		///		FK_ENT_FULLFILL_MD_DATA_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntFullfillMdData objects.</returns>
		/// <remarks></remarks>
		public TList<EntFullfillMdData> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_FULLFILL_MD_DATA_ED_ACAD_YEAR key.
		///		FK_ENT_FULLFILL_MD_DATA_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntFullfillMdData objects.</returns>
		public TList<EntFullfillMdData> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_FULLFILL_MD_DATA_ED_ACAD_YEAR key.
		///		fkEntFullfillMdDataEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntFullfillMdData objects.</returns>
		public TList<EntFullfillMdData> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_FULLFILL_MD_DATA_ED_ACAD_YEAR key.
		///		fkEntFullfillMdDataEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntFullfillMdData objects.</returns>
		public TList<EntFullfillMdData> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_FULLFILL_MD_DATA_ED_ACAD_YEAR key.
		///		FK_ENT_FULLFILL_MD_DATA_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntFullfillMdData objects.</returns>
		public abstract TList<EntFullfillMdData> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EntFullfillMdData Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntFullfillMdDataKey key, int start, int pageLength)
		{
			return GetByEntFullfillMdDataId(transactionManager, key.EntFullfillMdDataId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_FULLFILL_MD_ID_1 index.
		/// </summary>
		/// <param name="_entFullfillMdId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntFullfillMdData&gt;"/> class.</returns>
		public TList<EntFullfillMdData> GetByEntFullfillMdId(System.Decimal _entFullfillMdId)
		{
			int count = -1;
			return GetByEntFullfillMdId(null,_entFullfillMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_FULLFILL_MD_ID_1 index.
		/// </summary>
		/// <param name="_entFullfillMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntFullfillMdData&gt;"/> class.</returns>
		public TList<EntFullfillMdData> GetByEntFullfillMdId(System.Decimal _entFullfillMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntFullfillMdId(null, _entFullfillMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_FULLFILL_MD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entFullfillMdId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntFullfillMdData&gt;"/> class.</returns>
		public TList<EntFullfillMdData> GetByEntFullfillMdId(TransactionManager transactionManager, System.Decimal _entFullfillMdId)
		{
			int count = -1;
			return GetByEntFullfillMdId(transactionManager, _entFullfillMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_FULLFILL_MD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entFullfillMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntFullfillMdData&gt;"/> class.</returns>
		public TList<EntFullfillMdData> GetByEntFullfillMdId(TransactionManager transactionManager, System.Decimal _entFullfillMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntFullfillMdId(transactionManager, _entFullfillMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_FULLFILL_MD_ID_1 index.
		/// </summary>
		/// <param name="_entFullfillMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntFullfillMdData&gt;"/> class.</returns>
		public TList<EntFullfillMdData> GetByEntFullfillMdId(System.Decimal _entFullfillMdId, int start, int pageLength, out int count)
		{
			return GetByEntFullfillMdId(null, _entFullfillMdId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_FULLFILL_MD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entFullfillMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntFullfillMdData&gt;"/> class.</returns>
		public abstract TList<EntFullfillMdData> GetByEntFullfillMdId(TransactionManager transactionManager, System.Decimal _entFullfillMdId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntFullfillMdData&gt;"/> class.</returns>
		public TList<EntFullfillMdData> GetByEntMainId(System.Decimal _entMainId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntFullfillMdData&gt;"/> class.</returns>
		public TList<EntFullfillMdData> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntFullfillMdData&gt;"/> class.</returns>
		public TList<EntFullfillMdData> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntFullfillMdData&gt;"/> class.</returns>
		public TList<EntFullfillMdData> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntFullfillMdData&gt;"/> class.</returns>
		public TList<EntFullfillMdData> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntFullfillMdData&gt;"/> class.</returns>
		public abstract TList<EntFullfillMdData> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ENT_FULLFILL_MD_DATA index.
		/// </summary>
		/// <param name="_entFullfillMdDataId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntFullfillMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntFullfillMdData GetByEntFullfillMdDataId(System.Decimal _entFullfillMdDataId)
		{
			int count = -1;
			return GetByEntFullfillMdDataId(null,_entFullfillMdDataId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_FULLFILL_MD_DATA index.
		/// </summary>
		/// <param name="_entFullfillMdDataId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntFullfillMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntFullfillMdData GetByEntFullfillMdDataId(System.Decimal _entFullfillMdDataId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntFullfillMdDataId(null, _entFullfillMdDataId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_FULLFILL_MD_DATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entFullfillMdDataId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntFullfillMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntFullfillMdData GetByEntFullfillMdDataId(TransactionManager transactionManager, System.Decimal _entFullfillMdDataId)
		{
			int count = -1;
			return GetByEntFullfillMdDataId(transactionManager, _entFullfillMdDataId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_FULLFILL_MD_DATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entFullfillMdDataId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntFullfillMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntFullfillMdData GetByEntFullfillMdDataId(TransactionManager transactionManager, System.Decimal _entFullfillMdDataId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntFullfillMdDataId(transactionManager, _entFullfillMdDataId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_FULLFILL_MD_DATA index.
		/// </summary>
		/// <param name="_entFullfillMdDataId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntFullfillMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntFullfillMdData GetByEntFullfillMdDataId(System.Decimal _entFullfillMdDataId, int start, int pageLength, out int count)
		{
			return GetByEntFullfillMdDataId(null, _entFullfillMdDataId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_FULLFILL_MD_DATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entFullfillMdDataId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntFullfillMdData"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntFullfillMdData GetByEntFullfillMdDataId(TransactionManager transactionManager, System.Decimal _entFullfillMdDataId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ENT_FULLFILL_MD_DATA index.
		/// </summary>
		/// <param name="_entFullfillMdId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_entMainId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntFullfillMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntFullfillMdData GetByEntFullfillMdIdEdAcadYearIdEntMainId(System.Decimal _entFullfillMdId, System.Decimal? _edAcadYearId, System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntFullfillMdIdEdAcadYearIdEntMainId(null,_entFullfillMdId, _edAcadYearId, _entMainId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_FULLFILL_MD_DATA index.
		/// </summary>
		/// <param name="_entFullfillMdId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntFullfillMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntFullfillMdData GetByEntFullfillMdIdEdAcadYearIdEntMainId(System.Decimal _entFullfillMdId, System.Decimal? _edAcadYearId, System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntFullfillMdIdEdAcadYearIdEntMainId(null, _entFullfillMdId, _edAcadYearId, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_FULLFILL_MD_DATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entFullfillMdId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_entMainId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntFullfillMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntFullfillMdData GetByEntFullfillMdIdEdAcadYearIdEntMainId(TransactionManager transactionManager, System.Decimal _entFullfillMdId, System.Decimal? _edAcadYearId, System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntFullfillMdIdEdAcadYearIdEntMainId(transactionManager, _entFullfillMdId, _edAcadYearId, _entMainId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_FULLFILL_MD_DATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entFullfillMdId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntFullfillMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntFullfillMdData GetByEntFullfillMdIdEdAcadYearIdEntMainId(TransactionManager transactionManager, System.Decimal _entFullfillMdId, System.Decimal? _edAcadYearId, System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntFullfillMdIdEdAcadYearIdEntMainId(transactionManager, _entFullfillMdId, _edAcadYearId, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_FULLFILL_MD_DATA index.
		/// </summary>
		/// <param name="_entFullfillMdId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntFullfillMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntFullfillMdData GetByEntFullfillMdIdEdAcadYearIdEntMainId(System.Decimal _entFullfillMdId, System.Decimal? _edAcadYearId, System.Decimal _entMainId, int start, int pageLength, out int count)
		{
			return GetByEntFullfillMdIdEdAcadYearIdEntMainId(null, _entFullfillMdId, _edAcadYearId, _entMainId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_FULLFILL_MD_DATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entFullfillMdId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntFullfillMdData"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntFullfillMdData GetByEntFullfillMdIdEdAcadYearIdEntMainId(TransactionManager transactionManager, System.Decimal _entFullfillMdId, System.Decimal? _edAcadYearId, System.Decimal _entMainId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntFullfillMdData&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntFullfillMdData&gt;"/></returns>
		public static TList<EntFullfillMdData> Fill(IDataReader reader, TList<EntFullfillMdData> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntFullfillMdData c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntFullfillMdData")
					.Append("|").Append((System.Decimal)reader["ENT_FULLFILL_MD_DATA_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntFullfillMdData>(
					key.ToString(), // EntityTrackingKey
					"EntFullfillMdData",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntFullfillMdData();
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
					c.EntFullfillMdDataId = (System.Decimal)reader["ENT_FULLFILL_MD_DATA_ID"];
					c.OriginalEntFullfillMdDataId = c.EntFullfillMdDataId;
					c.EntFullfillMdId = (System.Decimal)reader["ENT_FULLFILL_MD_ID"];
					c.EntMainId = (System.Decimal)reader["ENT_MAIN_ID"];
					c.MdValue1 = (System.String)reader["MD_VALUE_1"];
					c.MdValue2 = (System.String)reader["MD_VALUE_2"];
					c.EdAcadYearId = Convert.IsDBNull(reader["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntFullfillMdData"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntFullfillMdData"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntFullfillMdData entity)
		{
			if (!reader.Read()) return;
			
			entity.EntFullfillMdDataId = (System.Decimal)reader[((int)EntFullfillMdDataColumn.EntFullfillMdDataId - 1)];
			entity.OriginalEntFullfillMdDataId = (System.Decimal)reader["ENT_FULLFILL_MD_DATA_ID"];
			entity.EntFullfillMdId = (System.Decimal)reader[((int)EntFullfillMdDataColumn.EntFullfillMdId - 1)];
			entity.EntMainId = (System.Decimal)reader[((int)EntFullfillMdDataColumn.EntMainId - 1)];
			entity.MdValue1 = (System.String)reader[((int)EntFullfillMdDataColumn.MdValue1 - 1)];
			entity.MdValue2 = (System.String)reader[((int)EntFullfillMdDataColumn.MdValue2 - 1)];
			entity.EdAcadYearId = (reader.IsDBNull(((int)EntFullfillMdDataColumn.EdAcadYearId - 1)))?null:(System.Decimal?)reader[((int)EntFullfillMdDataColumn.EdAcadYearId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntFullfillMdData"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntFullfillMdData"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntFullfillMdData entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntFullfillMdDataId = (System.Decimal)dataRow["ENT_FULLFILL_MD_DATA_ID"];
			entity.OriginalEntFullfillMdDataId = (System.Decimal)dataRow["ENT_FULLFILL_MD_DATA_ID"];
			entity.EntFullfillMdId = (System.Decimal)dataRow["ENT_FULLFILL_MD_ID"];
			entity.EntMainId = (System.Decimal)dataRow["ENT_MAIN_ID"];
			entity.MdValue1 = (System.String)dataRow["MD_VALUE_1"];
			entity.MdValue2 = (System.String)dataRow["MD_VALUE_2"];
			entity.EdAcadYearId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntFullfillMdData"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntFullfillMdData Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntFullfillMdData entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdAcadYearIdSource	
			if (CanDeepLoad(entity, "EdAcadYear|EdAcadYearIdSource", deepLoadType, innerList) 
				&& entity.EdAcadYearIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdAcadYearId ?? 0.0m);
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadYearIdSource = tmpEntity;
				else
					entity.EdAcadYearIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, (entity.EdAcadYearId ?? 0.0m));		
				
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

			#region EntFullfillMdIdSource	
			if (CanDeepLoad(entity, "EntFullfillMetadata|EntFullfillMdIdSource", deepLoadType, innerList) 
				&& entity.EntFullfillMdIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EntFullfillMdId;
				EntFullfillMetadata tmpEntity = EntityManager.LocateEntity<EntFullfillMetadata>(EntityLocator.ConstructKeyFromPkItems(typeof(EntFullfillMetadata), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntFullfillMdIdSource = tmpEntity;
				else
					entity.EntFullfillMdIdSource = DataRepository.EntFullfillMetadataProvider.GetByEntFullfillMdId(transactionManager, entity.EntFullfillMdId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntFullfillMdIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntFullfillMdIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntFullfillMetadataProvider.DeepLoad(transactionManager, entity.EntFullfillMdIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntFullfillMdIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntFullfillMdData object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntFullfillMdData instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntFullfillMdData Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntFullfillMdData entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EntFullfillMdIdSource
			if (CanDeepSave(entity, "EntFullfillMetadata|EntFullfillMdIdSource", deepSaveType, innerList) 
				&& entity.EntFullfillMdIdSource != null)
			{
				DataRepository.EntFullfillMetadataProvider.Save(transactionManager, entity.EntFullfillMdIdSource);
				entity.EntFullfillMdId = entity.EntFullfillMdIdSource.EntFullfillMdId;
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
	
	#region EntFullfillMdDataChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntFullfillMdData</c>
	///</summary>
	public enum EntFullfillMdDataChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>EntFullfillMetadata</c> at EntFullfillMdIdSource
		///</summary>
		[ChildEntityType(typeof(EntFullfillMetadata))]
		EntFullfillMetadata,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
	}
	
	#endregion EntFullfillMdDataChildEntityTypes
	
	#region EntFullfillMdDataFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntFullfillMdDataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntFullfillMdData"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntFullfillMdDataFilterBuilder : SqlFilterBuilder<EntFullfillMdDataColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntFullfillMdDataFilterBuilder class.
		/// </summary>
		public EntFullfillMdDataFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntFullfillMdDataFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntFullfillMdDataFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntFullfillMdDataFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntFullfillMdDataFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntFullfillMdDataFilterBuilder
	
	#region EntFullfillMdDataParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntFullfillMdDataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntFullfillMdData"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntFullfillMdDataParameterBuilder : ParameterizedSqlFilterBuilder<EntFullfillMdDataColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntFullfillMdDataParameterBuilder class.
		/// </summary>
		public EntFullfillMdDataParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntFullfillMdDataParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntFullfillMdDataParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntFullfillMdDataParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntFullfillMdDataParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntFullfillMdDataParameterBuilder
	
	#region EntFullfillMdDataSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntFullfillMdDataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntFullfillMdData"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntFullfillMdDataSortBuilder : SqlSortBuilder<EntFullfillMdDataColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntFullfillMdDataSqlSortBuilder class.
		/// </summary>
		public EntFullfillMdDataSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntFullfillMdDataSortBuilder
	
} // end namespace
