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
	/// This class is the base class for any <see cref="EntPrecondMdDataProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntPrecondMdDataProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntPrecondMdData, UMIS_VER2.BusinessLyer.EntPrecondMdDataKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPrecondMdDataKey key)
		{
			return Delete(transactionManager, key.EntPrecondDataMdId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entPrecondDataMdId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entPrecondDataMdId)
		{
			return Delete(null, _entPrecondDataMdId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPrecondDataMdId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entPrecondDataMdId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_PRECOND_MD_DATA_ED_ACAD_YEAR key.
		///		FK_ENT_PRECOND_MD_DATA_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPrecondMdData objects.</returns>
		public TList<EntPrecondMdData> GetByEdAcadYearId(System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_PRECOND_MD_DATA_ED_ACAD_YEAR key.
		///		FK_ENT_PRECOND_MD_DATA_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPrecondMdData objects.</returns>
		/// <remarks></remarks>
		public TList<EntPrecondMdData> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_PRECOND_MD_DATA_ED_ACAD_YEAR key.
		///		FK_ENT_PRECOND_MD_DATA_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPrecondMdData objects.</returns>
		public TList<EntPrecondMdData> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_PRECOND_MD_DATA_ED_ACAD_YEAR key.
		///		fkEntPrecondMdDataEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPrecondMdData objects.</returns>
		public TList<EntPrecondMdData> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_PRECOND_MD_DATA_ED_ACAD_YEAR key.
		///		fkEntPrecondMdDataEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPrecondMdData objects.</returns>
		public TList<EntPrecondMdData> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_PRECOND_MD_DATA_ED_ACAD_YEAR key.
		///		FK_ENT_PRECOND_MD_DATA_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPrecondMdData objects.</returns>
		public abstract TList<EntPrecondMdData> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EntPrecondMdData Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPrecondMdDataKey key, int start, int pageLength)
		{
			return GetByEntPrecondDataMdId(transactionManager, key.EntPrecondDataMdId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPrecondMdData&gt;"/> class.</returns>
		public TList<EntPrecondMdData> GetByEntMainId(System.Decimal _entMainId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPrecondMdData&gt;"/> class.</returns>
		public TList<EntPrecondMdData> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPrecondMdData&gt;"/> class.</returns>
		public TList<EntPrecondMdData> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPrecondMdData&gt;"/> class.</returns>
		public TList<EntPrecondMdData> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPrecondMdData&gt;"/> class.</returns>
		public TList<EntPrecondMdData> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPrecondMdData&gt;"/> class.</returns>
		public abstract TList<EntPrecondMdData> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_PRECOND_MD_ID_1 index.
		/// </summary>
		/// <param name="_entPrecondMdId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPrecondMdData&gt;"/> class.</returns>
		public TList<EntPrecondMdData> GetByEntPrecondMdId(System.Decimal _entPrecondMdId)
		{
			int count = -1;
			return GetByEntPrecondMdId(null,_entPrecondMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_PRECOND_MD_ID_1 index.
		/// </summary>
		/// <param name="_entPrecondMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPrecondMdData&gt;"/> class.</returns>
		public TList<EntPrecondMdData> GetByEntPrecondMdId(System.Decimal _entPrecondMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPrecondMdId(null, _entPrecondMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_PRECOND_MD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPrecondMdId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPrecondMdData&gt;"/> class.</returns>
		public TList<EntPrecondMdData> GetByEntPrecondMdId(TransactionManager transactionManager, System.Decimal _entPrecondMdId)
		{
			int count = -1;
			return GetByEntPrecondMdId(transactionManager, _entPrecondMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_PRECOND_MD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPrecondMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPrecondMdData&gt;"/> class.</returns>
		public TList<EntPrecondMdData> GetByEntPrecondMdId(TransactionManager transactionManager, System.Decimal _entPrecondMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPrecondMdId(transactionManager, _entPrecondMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_PRECOND_MD_ID_1 index.
		/// </summary>
		/// <param name="_entPrecondMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPrecondMdData&gt;"/> class.</returns>
		public TList<EntPrecondMdData> GetByEntPrecondMdId(System.Decimal _entPrecondMdId, int start, int pageLength, out int count)
		{
			return GetByEntPrecondMdId(null, _entPrecondMdId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_PRECOND_MD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPrecondMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPrecondMdData&gt;"/> class.</returns>
		public abstract TList<EntPrecondMdData> GetByEntPrecondMdId(TransactionManager transactionManager, System.Decimal _entPrecondMdId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ENT_PRECOND_MD_DATA_ID index.
		/// </summary>
		/// <param name="_entPrecondDataMdId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPrecondMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPrecondMdData GetByEntPrecondDataMdId(System.Decimal _entPrecondDataMdId)
		{
			int count = -1;
			return GetByEntPrecondDataMdId(null,_entPrecondDataMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_PRECOND_MD_DATA_ID index.
		/// </summary>
		/// <param name="_entPrecondDataMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPrecondMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPrecondMdData GetByEntPrecondDataMdId(System.Decimal _entPrecondDataMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPrecondDataMdId(null, _entPrecondDataMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_PRECOND_MD_DATA_ID index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPrecondDataMdId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPrecondMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPrecondMdData GetByEntPrecondDataMdId(TransactionManager transactionManager, System.Decimal _entPrecondDataMdId)
		{
			int count = -1;
			return GetByEntPrecondDataMdId(transactionManager, _entPrecondDataMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_PRECOND_MD_DATA_ID index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPrecondDataMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPrecondMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPrecondMdData GetByEntPrecondDataMdId(TransactionManager transactionManager, System.Decimal _entPrecondDataMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPrecondDataMdId(transactionManager, _entPrecondDataMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_PRECOND_MD_DATA_ID index.
		/// </summary>
		/// <param name="_entPrecondDataMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPrecondMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPrecondMdData GetByEntPrecondDataMdId(System.Decimal _entPrecondDataMdId, int start, int pageLength, out int count)
		{
			return GetByEntPrecondDataMdId(null, _entPrecondDataMdId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_PRECOND_MD_DATA_ID index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPrecondDataMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPrecondMdData"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPrecondMdData GetByEntPrecondDataMdId(TransactionManager transactionManager, System.Decimal _entPrecondDataMdId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ENT_PRECOND_MD_DATA index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="_entPrecondMdId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPrecondMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPrecondMdData GetByEdAcadYearIdEntMainIdEntPrecondMdId(System.Decimal? _edAcadYearId, System.Decimal _entMainId, System.Decimal _entPrecondMdId)
		{
			int count = -1;
			return GetByEdAcadYearIdEntMainIdEntPrecondMdId(null,_edAcadYearId, _entMainId, _entPrecondMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_PRECOND_MD_DATA index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="_entPrecondMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPrecondMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPrecondMdData GetByEdAcadYearIdEntMainIdEntPrecondMdId(System.Decimal? _edAcadYearId, System.Decimal _entMainId, System.Decimal _entPrecondMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEntMainIdEntPrecondMdId(null, _edAcadYearId, _entMainId, _entPrecondMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_PRECOND_MD_DATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="_entPrecondMdId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPrecondMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPrecondMdData GetByEdAcadYearIdEntMainIdEntPrecondMdId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, System.Decimal _entMainId, System.Decimal _entPrecondMdId)
		{
			int count = -1;
			return GetByEdAcadYearIdEntMainIdEntPrecondMdId(transactionManager, _edAcadYearId, _entMainId, _entPrecondMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_PRECOND_MD_DATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="_entPrecondMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPrecondMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPrecondMdData GetByEdAcadYearIdEntMainIdEntPrecondMdId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, System.Decimal _entMainId, System.Decimal _entPrecondMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEntMainIdEntPrecondMdId(transactionManager, _edAcadYearId, _entMainId, _entPrecondMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_PRECOND_MD_DATA index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="_entPrecondMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPrecondMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPrecondMdData GetByEdAcadYearIdEntMainIdEntPrecondMdId(System.Decimal? _edAcadYearId, System.Decimal _entMainId, System.Decimal _entPrecondMdId, int start, int pageLength, out int count)
		{
			return GetByEdAcadYearIdEntMainIdEntPrecondMdId(null, _edAcadYearId, _entMainId, _entPrecondMdId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_PRECOND_MD_DATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="_entPrecondMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPrecondMdData"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPrecondMdData GetByEdAcadYearIdEntMainIdEntPrecondMdId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, System.Decimal _entMainId, System.Decimal _entPrecondMdId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntPrecondMdData&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntPrecondMdData&gt;"/></returns>
		public static TList<EntPrecondMdData> Fill(IDataReader reader, TList<EntPrecondMdData> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntPrecondMdData c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntPrecondMdData")
					.Append("|").Append((System.Decimal)reader["ENT_PRECOND_DATA_MD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntPrecondMdData>(
					key.ToString(), // EntityTrackingKey
					"EntPrecondMdData",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntPrecondMdData();
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
					c.EntPrecondDataMdId = (System.Decimal)reader["ENT_PRECOND_DATA_MD_ID"];
					c.OriginalEntPrecondDataMdId = c.EntPrecondDataMdId;
					c.EntPrecondMdId = (System.Decimal)reader["ENT_PRECOND_MD_ID"];
					c.MdValue2 = (System.String)reader["MD_VALUE_2"];
					c.MdValue1 = (System.String)reader["MD_VALUE_1"];
					c.EntMainId = (System.Decimal)reader["ENT_MAIN_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPrecondMdData"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPrecondMdData"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntPrecondMdData entity)
		{
			if (!reader.Read()) return;
			
			entity.EntPrecondDataMdId = (System.Decimal)reader[((int)EntPrecondMdDataColumn.EntPrecondDataMdId - 1)];
			entity.OriginalEntPrecondDataMdId = (System.Decimal)reader["ENT_PRECOND_DATA_MD_ID"];
			entity.EntPrecondMdId = (System.Decimal)reader[((int)EntPrecondMdDataColumn.EntPrecondMdId - 1)];
			entity.MdValue2 = (System.String)reader[((int)EntPrecondMdDataColumn.MdValue2 - 1)];
			entity.MdValue1 = (System.String)reader[((int)EntPrecondMdDataColumn.MdValue1 - 1)];
			entity.EntMainId = (System.Decimal)reader[((int)EntPrecondMdDataColumn.EntMainId - 1)];
			entity.EdAcadYearId = (reader.IsDBNull(((int)EntPrecondMdDataColumn.EdAcadYearId - 1)))?null:(System.Decimal?)reader[((int)EntPrecondMdDataColumn.EdAcadYearId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPrecondMdData"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPrecondMdData"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntPrecondMdData entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntPrecondDataMdId = (System.Decimal)dataRow["ENT_PRECOND_DATA_MD_ID"];
			entity.OriginalEntPrecondDataMdId = (System.Decimal)dataRow["ENT_PRECOND_DATA_MD_ID"];
			entity.EntPrecondMdId = (System.Decimal)dataRow["ENT_PRECOND_MD_ID"];
			entity.MdValue2 = (System.String)dataRow["MD_VALUE_2"];
			entity.MdValue1 = (System.String)dataRow["MD_VALUE_1"];
			entity.EntMainId = (System.Decimal)dataRow["ENT_MAIN_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPrecondMdData"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPrecondMdData Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPrecondMdData entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region EntPrecondMdIdSource	
			if (CanDeepLoad(entity, "EntPrecondMetadata|EntPrecondMdIdSource", deepLoadType, innerList) 
				&& entity.EntPrecondMdIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EntPrecondMdId;
				EntPrecondMetadata tmpEntity = EntityManager.LocateEntity<EntPrecondMetadata>(EntityLocator.ConstructKeyFromPkItems(typeof(EntPrecondMetadata), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntPrecondMdIdSource = tmpEntity;
				else
					entity.EntPrecondMdIdSource = DataRepository.EntPrecondMetadataProvider.GetByEntPrecondMdId(transactionManager, entity.EntPrecondMdId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPrecondMdIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntPrecondMdIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntPrecondMetadataProvider.DeepLoad(transactionManager, entity.EntPrecondMdIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntPrecondMdIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntPrecondMdData object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntPrecondMdData instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPrecondMdData Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPrecondMdData entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EntMainIdSource
			if (CanDeepSave(entity, "EntityMain|EntMainIdSource", deepSaveType, innerList) 
				&& entity.EntMainIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.EntMainIdSource);
				entity.EntMainId = entity.EntMainIdSource.EntMainId;
			}
			#endregion 
			
			#region EntPrecondMdIdSource
			if (CanDeepSave(entity, "EntPrecondMetadata|EntPrecondMdIdSource", deepSaveType, innerList) 
				&& entity.EntPrecondMdIdSource != null)
			{
				DataRepository.EntPrecondMetadataProvider.Save(transactionManager, entity.EntPrecondMdIdSource);
				entity.EntPrecondMdId = entity.EntPrecondMdIdSource.EntPrecondMdId;
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
	
	#region EntPrecondMdDataChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntPrecondMdData</c>
	///</summary>
	public enum EntPrecondMdDataChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		
		///<summary>
		/// Composite Property for <c>EntPrecondMetadata</c> at EntPrecondMdIdSource
		///</summary>
		[ChildEntityType(typeof(EntPrecondMetadata))]
		EntPrecondMetadata,
	}
	
	#endregion EntPrecondMdDataChildEntityTypes
	
	#region EntPrecondMdDataFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntPrecondMdDataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPrecondMdData"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPrecondMdDataFilterBuilder : SqlFilterBuilder<EntPrecondMdDataColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPrecondMdDataFilterBuilder class.
		/// </summary>
		public EntPrecondMdDataFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPrecondMdDataFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPrecondMdDataFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPrecondMdDataFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPrecondMdDataFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPrecondMdDataFilterBuilder
	
	#region EntPrecondMdDataParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntPrecondMdDataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPrecondMdData"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPrecondMdDataParameterBuilder : ParameterizedSqlFilterBuilder<EntPrecondMdDataColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPrecondMdDataParameterBuilder class.
		/// </summary>
		public EntPrecondMdDataParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPrecondMdDataParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPrecondMdDataParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPrecondMdDataParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPrecondMdDataParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPrecondMdDataParameterBuilder
	
	#region EntPrecondMdDataSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntPrecondMdDataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPrecondMdData"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntPrecondMdDataSortBuilder : SqlSortBuilder<EntPrecondMdDataColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPrecondMdDataSqlSortBuilder class.
		/// </summary>
		public EntPrecondMdDataSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntPrecondMdDataSortBuilder
	
} // end namespace
