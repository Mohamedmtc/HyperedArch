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
	/// This class is the base class for any <see cref="SvStudAskAdvReProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvStudAskAdvReProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvStudAskAdvRe, UMIS_VER2.BusinessLyer.SvStudAskAdvReKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStudAskAdvReKey key)
		{
			return Delete(transactionManager, key.SvStudAskAdvReId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svStudAskAdvReId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _svStudAskAdvReId)
		{
			return Delete(null, _svStudAskAdvReId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStudAskAdvReId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _svStudAskAdvReId);		
		
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
		public override UMIS_VER2.BusinessLyer.SvStudAskAdvRe Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStudAskAdvReKey key, int start, int pageLength)
		{
			return GetBySvStudAskAdvReId(transactionManager, key.SvStudAskAdvReId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudAskAdvRe&gt;"/> class.</returns>
		public TList<SvStudAskAdvRe> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudAskAdvRe&gt;"/> class.</returns>
		public TList<SvStudAskAdvRe> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudAskAdvRe&gt;"/> class.</returns>
		public TList<SvStudAskAdvRe> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudAskAdvRe&gt;"/> class.</returns>
		public TList<SvStudAskAdvRe> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudAskAdvRe&gt;"/> class.</returns>
		public TList<SvStudAskAdvRe> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudAskAdvRe&gt;"/> class.</returns>
		public abstract TList<SvStudAskAdvRe> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudAskAdvRe&gt;"/> class.</returns>
		public TList<SvStudAskAdvRe> GetByEdStudId(System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(null,_edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudAskAdvRe&gt;"/> class.</returns>
		public TList<SvStudAskAdvRe> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudAskAdvRe&gt;"/> class.</returns>
		public TList<SvStudAskAdvRe> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudAskAdvRe&gt;"/> class.</returns>
		public TList<SvStudAskAdvRe> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudAskAdvRe&gt;"/> class.</returns>
		public TList<SvStudAskAdvRe> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength, out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudAskAdvRe&gt;"/> class.</returns>
		public abstract TList<SvStudAskAdvRe> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudAskAdvRe&gt;"/> class.</returns>
		public TList<SvStudAskAdvRe> GetBySaStfMemberId(System.Decimal? _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(null,_saStfMemberId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudAskAdvRe&gt;"/> class.</returns>
		public TList<SvStudAskAdvRe> GetBySaStfMemberId(System.Decimal? _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudAskAdvRe&gt;"/> class.</returns>
		public TList<SvStudAskAdvRe> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudAskAdvRe&gt;"/> class.</returns>
		public TList<SvStudAskAdvRe> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudAskAdvRe&gt;"/> class.</returns>
		public TList<SvStudAskAdvRe> GetBySaStfMemberId(System.Decimal? _saStfMemberId, int start, int pageLength, out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudAskAdvRe&gt;"/> class.</returns>
		public abstract TList<SvStudAskAdvRe> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SV_STUD_ASK_ADV_ID_1 index.
		/// </summary>
		/// <param name="_svStudAskAdvId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudAskAdvRe&gt;"/> class.</returns>
		public TList<SvStudAskAdvRe> GetBySvStudAskAdvId(System.Decimal _svStudAskAdvId)
		{
			int count = -1;
			return GetBySvStudAskAdvId(null,_svStudAskAdvId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_STUD_ASK_ADV_ID_1 index.
		/// </summary>
		/// <param name="_svStudAskAdvId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudAskAdvRe&gt;"/> class.</returns>
		public TList<SvStudAskAdvRe> GetBySvStudAskAdvId(System.Decimal _svStudAskAdvId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvStudAskAdvId(null, _svStudAskAdvId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_STUD_ASK_ADV_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStudAskAdvId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudAskAdvRe&gt;"/> class.</returns>
		public TList<SvStudAskAdvRe> GetBySvStudAskAdvId(TransactionManager transactionManager, System.Decimal _svStudAskAdvId)
		{
			int count = -1;
			return GetBySvStudAskAdvId(transactionManager, _svStudAskAdvId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_STUD_ASK_ADV_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStudAskAdvId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudAskAdvRe&gt;"/> class.</returns>
		public TList<SvStudAskAdvRe> GetBySvStudAskAdvId(TransactionManager transactionManager, System.Decimal _svStudAskAdvId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvStudAskAdvId(transactionManager, _svStudAskAdvId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_STUD_ASK_ADV_ID_1 index.
		/// </summary>
		/// <param name="_svStudAskAdvId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudAskAdvRe&gt;"/> class.</returns>
		public TList<SvStudAskAdvRe> GetBySvStudAskAdvId(System.Decimal _svStudAskAdvId, int start, int pageLength, out int count)
		{
			return GetBySvStudAskAdvId(null, _svStudAskAdvId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_STUD_ASK_ADV_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStudAskAdvId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudAskAdvRe&gt;"/> class.</returns>
		public abstract TList<SvStudAskAdvRe> GetBySvStudAskAdvId(TransactionManager transactionManager, System.Decimal _svStudAskAdvId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_STUD_ASK_ADV_RE index.
		/// </summary>
		/// <param name="_svStudAskAdvReId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudAskAdvRe"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudAskAdvRe GetBySvStudAskAdvReId(System.Decimal _svStudAskAdvReId)
		{
			int count = -1;
			return GetBySvStudAskAdvReId(null,_svStudAskAdvReId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_ASK_ADV_RE index.
		/// </summary>
		/// <param name="_svStudAskAdvReId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudAskAdvRe"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudAskAdvRe GetBySvStudAskAdvReId(System.Decimal _svStudAskAdvReId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvStudAskAdvReId(null, _svStudAskAdvReId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_ASK_ADV_RE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStudAskAdvReId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudAskAdvRe"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudAskAdvRe GetBySvStudAskAdvReId(TransactionManager transactionManager, System.Decimal _svStudAskAdvReId)
		{
			int count = -1;
			return GetBySvStudAskAdvReId(transactionManager, _svStudAskAdvReId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_ASK_ADV_RE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStudAskAdvReId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudAskAdvRe"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudAskAdvRe GetBySvStudAskAdvReId(TransactionManager transactionManager, System.Decimal _svStudAskAdvReId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvStudAskAdvReId(transactionManager, _svStudAskAdvReId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_ASK_ADV_RE index.
		/// </summary>
		/// <param name="_svStudAskAdvReId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudAskAdvRe"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudAskAdvRe GetBySvStudAskAdvReId(System.Decimal _svStudAskAdvReId, int start, int pageLength, out int count)
		{
			return GetBySvStudAskAdvReId(null, _svStudAskAdvReId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_ASK_ADV_RE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStudAskAdvReId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudAskAdvRe"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvStudAskAdvRe GetBySvStudAskAdvReId(TransactionManager transactionManager, System.Decimal _svStudAskAdvReId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvStudAskAdvRe&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvStudAskAdvRe&gt;"/></returns>
		public static TList<SvStudAskAdvRe> Fill(IDataReader reader, TList<SvStudAskAdvRe> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvStudAskAdvRe c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvStudAskAdvRe")
					.Append("|").Append((System.Decimal)reader["SV_STUD_ASK_ADV_RE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvStudAskAdvRe>(
					key.ToString(), // EntityTrackingKey
					"SvStudAskAdvRe",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvStudAskAdvRe();
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
					c.SvStudAskAdvReId = (System.Decimal)reader["SV_STUD_ASK_ADV_RE_ID"];
					c.OriginalSvStudAskAdvReId = c.SvStudAskAdvReId;
					c.SvStudAskAdvId = (System.Decimal)reader["SV_STUD_ASK_ADV_ID"];
					c.ReDate = (System.DateTime)reader["RE_DATE"];
					c.ReDtl = (System.String)reader["RE_DTL"];
					c.SaStfMemberId = Convert.IsDBNull(reader["SA_STF_MEMBER_ID"]) ? null : (System.Decimal?)reader["SA_STF_MEMBER_ID"];
					c.EdStudId = Convert.IsDBNull(reader["ED_STUD_ID"]) ? null : (System.Decimal?)reader["ED_STUD_ID"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.FromStud = Convert.IsDBNull(reader["FROM_STUD"]) ? null : (System.Boolean?)reader["FROM_STUD"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvStudAskAdvRe"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvStudAskAdvRe"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvStudAskAdvRe entity)
		{
			if (!reader.Read()) return;
			
			entity.SvStudAskAdvReId = (System.Decimal)reader[((int)SvStudAskAdvReColumn.SvStudAskAdvReId - 1)];
			entity.OriginalSvStudAskAdvReId = (System.Decimal)reader["SV_STUD_ASK_ADV_RE_ID"];
			entity.SvStudAskAdvId = (System.Decimal)reader[((int)SvStudAskAdvReColumn.SvStudAskAdvId - 1)];
			entity.ReDate = (System.DateTime)reader[((int)SvStudAskAdvReColumn.ReDate - 1)];
			entity.ReDtl = (System.String)reader[((int)SvStudAskAdvReColumn.ReDtl - 1)];
			entity.SaStfMemberId = (reader.IsDBNull(((int)SvStudAskAdvReColumn.SaStfMemberId - 1)))?null:(System.Decimal?)reader[((int)SvStudAskAdvReColumn.SaStfMemberId - 1)];
			entity.EdStudId = (reader.IsDBNull(((int)SvStudAskAdvReColumn.EdStudId - 1)))?null:(System.Decimal?)reader[((int)SvStudAskAdvReColumn.EdStudId - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)SvStudAskAdvReColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)SvStudAskAdvReColumn.AsFacultyInfoId - 1)];
			entity.FromStud = (reader.IsDBNull(((int)SvStudAskAdvReColumn.FromStud - 1)))?null:(System.Boolean?)reader[((int)SvStudAskAdvReColumn.FromStud - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvStudAskAdvRe"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvStudAskAdvRe"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvStudAskAdvRe entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvStudAskAdvReId = (System.Decimal)dataRow["SV_STUD_ASK_ADV_RE_ID"];
			entity.OriginalSvStudAskAdvReId = (System.Decimal)dataRow["SV_STUD_ASK_ADV_RE_ID"];
			entity.SvStudAskAdvId = (System.Decimal)dataRow["SV_STUD_ASK_ADV_ID"];
			entity.ReDate = (System.DateTime)dataRow["RE_DATE"];
			entity.ReDtl = (System.String)dataRow["RE_DTL"];
			entity.SaStfMemberId = Convert.IsDBNull(dataRow["SA_STF_MEMBER_ID"]) ? null : (System.Decimal?)dataRow["SA_STF_MEMBER_ID"];
			entity.EdStudId = Convert.IsDBNull(dataRow["ED_STUD_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_ID"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.FromStud = Convert.IsDBNull(dataRow["FROM_STUD"]) ? null : (System.Boolean?)dataRow["FROM_STUD"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvStudAskAdvRe"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvStudAskAdvRe Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStudAskAdvRe entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region EdStudIdSource	
			if (CanDeepLoad(entity, "EdStud|EdStudIdSource", deepLoadType, innerList) 
				&& entity.EdStudIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdStudId ?? 0.0m);
				EdStud tmpEntity = EntityManager.LocateEntity<EdStud>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStud), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudIdSource = tmpEntity;
				else
					entity.EdStudIdSource = DataRepository.EdStudProvider.GetByEdStudId(transactionManager, (entity.EdStudId ?? 0.0m));		
				
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

			#region SaStfMemberIdSource	
			if (CanDeepLoad(entity, "SaStfMember|SaStfMemberIdSource", deepLoadType, innerList) 
				&& entity.SaStfMemberIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaStfMemberId ?? 0.0m);
				SaStfMember tmpEntity = EntityManager.LocateEntity<SaStfMember>(EntityLocator.ConstructKeyFromPkItems(typeof(SaStfMember), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaStfMemberIdSource = tmpEntity;
				else
					entity.SaStfMemberIdSource = DataRepository.SaStfMemberProvider.GetBySaStfMemberId(transactionManager, (entity.SaStfMemberId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaStfMemberIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaStfMemberIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaStfMemberProvider.DeepLoad(transactionManager, entity.SaStfMemberIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaStfMemberIdSource

			#region SvStudAskAdvIdSource	
			if (CanDeepLoad(entity, "SvStudAskAdv|SvStudAskAdvIdSource", deepLoadType, innerList) 
				&& entity.SvStudAskAdvIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SvStudAskAdvId;
				SvStudAskAdv tmpEntity = EntityManager.LocateEntity<SvStudAskAdv>(EntityLocator.ConstructKeyFromPkItems(typeof(SvStudAskAdv), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvStudAskAdvIdSource = tmpEntity;
				else
					entity.SvStudAskAdvIdSource = DataRepository.SvStudAskAdvProvider.GetBySvStudAskAdvId(transactionManager, entity.SvStudAskAdvId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStudAskAdvIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvStudAskAdvIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvStudAskAdvProvider.DeepLoad(transactionManager, entity.SvStudAskAdvIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvStudAskAdvIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvStudAskAdvRe object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvStudAskAdvRe instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvStudAskAdvRe Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStudAskAdvRe entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
			}
			#endregion 
			
			#region SaStfMemberIdSource
			if (CanDeepSave(entity, "SaStfMember|SaStfMemberIdSource", deepSaveType, innerList) 
				&& entity.SaStfMemberIdSource != null)
			{
				DataRepository.SaStfMemberProvider.Save(transactionManager, entity.SaStfMemberIdSource);
				entity.SaStfMemberId = entity.SaStfMemberIdSource.SaStfMemberId;
			}
			#endregion 
			
			#region SvStudAskAdvIdSource
			if (CanDeepSave(entity, "SvStudAskAdv|SvStudAskAdvIdSource", deepSaveType, innerList) 
				&& entity.SvStudAskAdvIdSource != null)
			{
				DataRepository.SvStudAskAdvProvider.Save(transactionManager, entity.SvStudAskAdvIdSource);
				entity.SvStudAskAdvId = entity.SvStudAskAdvIdSource.SvStudAskAdvId;
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
	
	#region SvStudAskAdvReChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvStudAskAdvRe</c>
	///</summary>
	public enum SvStudAskAdvReChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
		
		///<summary>
		/// Composite Property for <c>SvStudAskAdv</c> at SvStudAskAdvIdSource
		///</summary>
		[ChildEntityType(typeof(SvStudAskAdv))]
		SvStudAskAdv,
	}
	
	#endregion SvStudAskAdvReChildEntityTypes
	
	#region SvStudAskAdvReFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvStudAskAdvReColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvStudAskAdvRe"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvStudAskAdvReFilterBuilder : SqlFilterBuilder<SvStudAskAdvReColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvStudAskAdvReFilterBuilder class.
		/// </summary>
		public SvStudAskAdvReFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvStudAskAdvReFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvStudAskAdvReFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvStudAskAdvReFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvStudAskAdvReFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvStudAskAdvReFilterBuilder
	
	#region SvStudAskAdvReParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvStudAskAdvReColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvStudAskAdvRe"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvStudAskAdvReParameterBuilder : ParameterizedSqlFilterBuilder<SvStudAskAdvReColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvStudAskAdvReParameterBuilder class.
		/// </summary>
		public SvStudAskAdvReParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvStudAskAdvReParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvStudAskAdvReParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvStudAskAdvReParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvStudAskAdvReParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvStudAskAdvReParameterBuilder
	
	#region SvStudAskAdvReSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvStudAskAdvReColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvStudAskAdvRe"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvStudAskAdvReSortBuilder : SqlSortBuilder<SvStudAskAdvReColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvStudAskAdvReSqlSortBuilder class.
		/// </summary>
		public SvStudAskAdvReSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvStudAskAdvReSortBuilder
	
} // end namespace
