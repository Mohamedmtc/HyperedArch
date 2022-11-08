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
	/// This class is the base class for any <see cref="EntPolicyLoadProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntPolicyLoadProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntPolicyLoad, UMIS_VER2.BusinessLyer.EntPolicyLoadKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyLoadKey key)
		{
			return Delete(transactionManager, key.EntPolicyLoadId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entPolicyLoadId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entPolicyLoadId)
		{
			return Delete(null, _entPolicyLoadId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyLoadId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entPolicyLoadId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_LOAD_ED_CODE_LEVEL key.
		///		FK_ENT_POLICY_LOAD_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="_edCodeLevelId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyLoad objects.</returns>
		public TList<EntPolicyLoad> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(_edCodeLevelId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_LOAD_ED_CODE_LEVEL key.
		///		FK_ENT_POLICY_LOAD_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyLoad objects.</returns>
		/// <remarks></remarks>
		public TList<EntPolicyLoad> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_LOAD_ED_CODE_LEVEL key.
		///		FK_ENT_POLICY_LOAD_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyLoad objects.</returns>
		public TList<EntPolicyLoad> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_LOAD_ED_CODE_LEVEL key.
		///		fkEntPolicyLoadEdCodeLevel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyLoad objects.</returns>
		public TList<EntPolicyLoad> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_LOAD_ED_CODE_LEVEL key.
		///		fkEntPolicyLoadEdCodeLevel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyLoad objects.</returns>
		public TList<EntPolicyLoad> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId, int start, int pageLength,out int count)
		{
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_LOAD_ED_CODE_LEVEL key.
		///		FK_ENT_POLICY_LOAD_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyLoad objects.</returns>
		public abstract TList<EntPolicyLoad> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EntPolicyLoad Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyLoadKey key, int start, int pageLength)
		{
			return GetByEntPolicyLoadId(transactionManager, key.EntPolicyLoadId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_BYLAW_ID_1 index.
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyLoad&gt;"/> class.</returns>
		public TList<EntPolicyLoad> GetByEdBylawId(System.Decimal? _edBylawId)
		{
			int count = -1;
			return GetByEdBylawId(null,_edBylawId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_BYLAW_ID_1 index.
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyLoad&gt;"/> class.</returns>
		public TList<EntPolicyLoad> GetByEdBylawId(System.Decimal? _edBylawId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBylawId(null, _edBylawId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_BYLAW_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyLoad&gt;"/> class.</returns>
		public TList<EntPolicyLoad> GetByEdBylawId(TransactionManager transactionManager, System.Decimal? _edBylawId)
		{
			int count = -1;
			return GetByEdBylawId(transactionManager, _edBylawId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_BYLAW_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyLoad&gt;"/> class.</returns>
		public TList<EntPolicyLoad> GetByEdBylawId(TransactionManager transactionManager, System.Decimal? _edBylawId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBylawId(transactionManager, _edBylawId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_BYLAW_ID_1 index.
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyLoad&gt;"/> class.</returns>
		public TList<EntPolicyLoad> GetByEdBylawId(System.Decimal? _edBylawId, int start, int pageLength, out int count)
		{
			return GetByEdBylawId(null, _edBylawId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_BYLAW_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyLoad&gt;"/> class.</returns>
		public abstract TList<EntPolicyLoad> GetByEdBylawId(TransactionManager transactionManager, System.Decimal? _edBylawId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_LOAD_TYPE_ID_1 index.
		/// </summary>
		/// <param name="_edCodeLoadTypeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyLoad&gt;"/> class.</returns>
		public TList<EntPolicyLoad> GetByEdCodeLoadTypeId(System.Decimal? _edCodeLoadTypeId)
		{
			int count = -1;
			return GetByEdCodeLoadTypeId(null,_edCodeLoadTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_LOAD_TYPE_ID_1 index.
		/// </summary>
		/// <param name="_edCodeLoadTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyLoad&gt;"/> class.</returns>
		public TList<EntPolicyLoad> GetByEdCodeLoadTypeId(System.Decimal? _edCodeLoadTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLoadTypeId(null, _edCodeLoadTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_LOAD_TYPE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLoadTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyLoad&gt;"/> class.</returns>
		public TList<EntPolicyLoad> GetByEdCodeLoadTypeId(TransactionManager transactionManager, System.Decimal? _edCodeLoadTypeId)
		{
			int count = -1;
			return GetByEdCodeLoadTypeId(transactionManager, _edCodeLoadTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_LOAD_TYPE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLoadTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyLoad&gt;"/> class.</returns>
		public TList<EntPolicyLoad> GetByEdCodeLoadTypeId(TransactionManager transactionManager, System.Decimal? _edCodeLoadTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLoadTypeId(transactionManager, _edCodeLoadTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_LOAD_TYPE_ID_1 index.
		/// </summary>
		/// <param name="_edCodeLoadTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyLoad&gt;"/> class.</returns>
		public TList<EntPolicyLoad> GetByEdCodeLoadTypeId(System.Decimal? _edCodeLoadTypeId, int start, int pageLength, out int count)
		{
			return GetByEdCodeLoadTypeId(null, _edCodeLoadTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_LOAD_TYPE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLoadTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyLoad&gt;"/> class.</returns>
		public abstract TList<EntPolicyLoad> GetByEdCodeLoadTypeId(TransactionManager transactionManager, System.Decimal? _edCodeLoadTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_SEMESTER_TYPE_ID_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterTypeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyLoad&gt;"/> class.</returns>
		public TList<EntPolicyLoad> GetByEdCodeSemesterTypeId(System.Decimal? _edCodeSemesterTypeId)
		{
			int count = -1;
			return GetByEdCodeSemesterTypeId(null,_edCodeSemesterTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_TYPE_ID_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyLoad&gt;"/> class.</returns>
		public TList<EntPolicyLoad> GetByEdCodeSemesterTypeId(System.Decimal? _edCodeSemesterTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterTypeId(null, _edCodeSemesterTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_TYPE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyLoad&gt;"/> class.</returns>
		public TList<EntPolicyLoad> GetByEdCodeSemesterTypeId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterTypeId)
		{
			int count = -1;
			return GetByEdCodeSemesterTypeId(transactionManager, _edCodeSemesterTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_TYPE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyLoad&gt;"/> class.</returns>
		public TList<EntPolicyLoad> GetByEdCodeSemesterTypeId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterTypeId(transactionManager, _edCodeSemesterTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_TYPE_ID_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyLoad&gt;"/> class.</returns>
		public TList<EntPolicyLoad> GetByEdCodeSemesterTypeId(System.Decimal? _edCodeSemesterTypeId, int start, int pageLength, out int count)
		{
			return GetByEdCodeSemesterTypeId(null, _edCodeSemesterTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_TYPE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyLoad&gt;"/> class.</returns>
		public abstract TList<EntPolicyLoad> GetByEdCodeSemesterTypeId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_BYLAW_CR_LOAD index.
		/// </summary>
		/// <param name="_entPolicyLoadId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyLoad"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyLoad GetByEntPolicyLoadId(System.Decimal _entPolicyLoadId)
		{
			int count = -1;
			return GetByEntPolicyLoadId(null,_entPolicyLoadId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_BYLAW_CR_LOAD index.
		/// </summary>
		/// <param name="_entPolicyLoadId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyLoad"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyLoad GetByEntPolicyLoadId(System.Decimal _entPolicyLoadId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyLoadId(null, _entPolicyLoadId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_BYLAW_CR_LOAD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyLoadId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyLoad"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyLoad GetByEntPolicyLoadId(TransactionManager transactionManager, System.Decimal _entPolicyLoadId)
		{
			int count = -1;
			return GetByEntPolicyLoadId(transactionManager, _entPolicyLoadId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_BYLAW_CR_LOAD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyLoadId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyLoad"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyLoad GetByEntPolicyLoadId(TransactionManager transactionManager, System.Decimal _entPolicyLoadId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyLoadId(transactionManager, _entPolicyLoadId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_BYLAW_CR_LOAD index.
		/// </summary>
		/// <param name="_entPolicyLoadId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyLoad"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyLoad GetByEntPolicyLoadId(System.Decimal _entPolicyLoadId, int start, int pageLength, out int count)
		{
			return GetByEntPolicyLoadId(null, _entPolicyLoadId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_BYLAW_CR_LOAD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyLoadId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyLoad"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPolicyLoad GetByEntPolicyLoadId(TransactionManager transactionManager, System.Decimal _entPolicyLoadId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ENT_POLICY_LOAD index.
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <param name="_edCodeLoadTypeId"></param>
		/// <param name="_edCodeSemesterTypeId"></param>
		/// <param name="_gpaFrom"></param>
		/// <param name="_gpaTo"></param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="_partTimeFlg"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyLoad"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyLoad GetByEdBylawIdEdCodeLoadTypeIdEdCodeSemesterTypeIdGpaFromGpaToEdCodeLevelIdPartTimeFlg(System.Decimal? _edBylawId, System.Decimal? _edCodeLoadTypeId, System.Decimal? _edCodeSemesterTypeId, System.Decimal _gpaFrom, System.Decimal _gpaTo, System.Decimal? _edCodeLevelId, System.Boolean? _partTimeFlg)
		{
			int count = -1;
			return GetByEdBylawIdEdCodeLoadTypeIdEdCodeSemesterTypeIdGpaFromGpaToEdCodeLevelIdPartTimeFlg(null,_edBylawId, _edCodeLoadTypeId, _edCodeSemesterTypeId, _gpaFrom, _gpaTo, _edCodeLevelId, _partTimeFlg, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_LOAD index.
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <param name="_edCodeLoadTypeId"></param>
		/// <param name="_edCodeSemesterTypeId"></param>
		/// <param name="_gpaFrom"></param>
		/// <param name="_gpaTo"></param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="_partTimeFlg"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyLoad"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyLoad GetByEdBylawIdEdCodeLoadTypeIdEdCodeSemesterTypeIdGpaFromGpaToEdCodeLevelIdPartTimeFlg(System.Decimal? _edBylawId, System.Decimal? _edCodeLoadTypeId, System.Decimal? _edCodeSemesterTypeId, System.Decimal _gpaFrom, System.Decimal _gpaTo, System.Decimal? _edCodeLevelId, System.Boolean? _partTimeFlg, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBylawIdEdCodeLoadTypeIdEdCodeSemesterTypeIdGpaFromGpaToEdCodeLevelIdPartTimeFlg(null, _edBylawId, _edCodeLoadTypeId, _edCodeSemesterTypeId, _gpaFrom, _gpaTo, _edCodeLevelId, _partTimeFlg, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_LOAD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="_edCodeLoadTypeId"></param>
		/// <param name="_edCodeSemesterTypeId"></param>
		/// <param name="_gpaFrom"></param>
		/// <param name="_gpaTo"></param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="_partTimeFlg"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyLoad"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyLoad GetByEdBylawIdEdCodeLoadTypeIdEdCodeSemesterTypeIdGpaFromGpaToEdCodeLevelIdPartTimeFlg(TransactionManager transactionManager, System.Decimal? _edBylawId, System.Decimal? _edCodeLoadTypeId, System.Decimal? _edCodeSemesterTypeId, System.Decimal _gpaFrom, System.Decimal _gpaTo, System.Decimal? _edCodeLevelId, System.Boolean? _partTimeFlg)
		{
			int count = -1;
			return GetByEdBylawIdEdCodeLoadTypeIdEdCodeSemesterTypeIdGpaFromGpaToEdCodeLevelIdPartTimeFlg(transactionManager, _edBylawId, _edCodeLoadTypeId, _edCodeSemesterTypeId, _gpaFrom, _gpaTo, _edCodeLevelId, _partTimeFlg, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_LOAD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="_edCodeLoadTypeId"></param>
		/// <param name="_edCodeSemesterTypeId"></param>
		/// <param name="_gpaFrom"></param>
		/// <param name="_gpaTo"></param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="_partTimeFlg"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyLoad"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyLoad GetByEdBylawIdEdCodeLoadTypeIdEdCodeSemesterTypeIdGpaFromGpaToEdCodeLevelIdPartTimeFlg(TransactionManager transactionManager, System.Decimal? _edBylawId, System.Decimal? _edCodeLoadTypeId, System.Decimal? _edCodeSemesterTypeId, System.Decimal _gpaFrom, System.Decimal _gpaTo, System.Decimal? _edCodeLevelId, System.Boolean? _partTimeFlg, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBylawIdEdCodeLoadTypeIdEdCodeSemesterTypeIdGpaFromGpaToEdCodeLevelIdPartTimeFlg(transactionManager, _edBylawId, _edCodeLoadTypeId, _edCodeSemesterTypeId, _gpaFrom, _gpaTo, _edCodeLevelId, _partTimeFlg, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_LOAD index.
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <param name="_edCodeLoadTypeId"></param>
		/// <param name="_edCodeSemesterTypeId"></param>
		/// <param name="_gpaFrom"></param>
		/// <param name="_gpaTo"></param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="_partTimeFlg"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyLoad"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyLoad GetByEdBylawIdEdCodeLoadTypeIdEdCodeSemesterTypeIdGpaFromGpaToEdCodeLevelIdPartTimeFlg(System.Decimal? _edBylawId, System.Decimal? _edCodeLoadTypeId, System.Decimal? _edCodeSemesterTypeId, System.Decimal _gpaFrom, System.Decimal _gpaTo, System.Decimal? _edCodeLevelId, System.Boolean? _partTimeFlg, int start, int pageLength, out int count)
		{
			return GetByEdBylawIdEdCodeLoadTypeIdEdCodeSemesterTypeIdGpaFromGpaToEdCodeLevelIdPartTimeFlg(null, _edBylawId, _edCodeLoadTypeId, _edCodeSemesterTypeId, _gpaFrom, _gpaTo, _edCodeLevelId, _partTimeFlg, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_LOAD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="_edCodeLoadTypeId"></param>
		/// <param name="_edCodeSemesterTypeId"></param>
		/// <param name="_gpaFrom"></param>
		/// <param name="_gpaTo"></param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="_partTimeFlg"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyLoad"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPolicyLoad GetByEdBylawIdEdCodeLoadTypeIdEdCodeSemesterTypeIdGpaFromGpaToEdCodeLevelIdPartTimeFlg(TransactionManager transactionManager, System.Decimal? _edBylawId, System.Decimal? _edCodeLoadTypeId, System.Decimal? _edCodeSemesterTypeId, System.Decimal _gpaFrom, System.Decimal _gpaTo, System.Decimal? _edCodeLevelId, System.Boolean? _partTimeFlg, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntPolicyLoad&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntPolicyLoad&gt;"/></returns>
		public static TList<EntPolicyLoad> Fill(IDataReader reader, TList<EntPolicyLoad> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntPolicyLoad c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntPolicyLoad")
					.Append("|").Append((System.Decimal)reader["ENT_POLICY_LOAD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntPolicyLoad>(
					key.ToString(), // EntityTrackingKey
					"EntPolicyLoad",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntPolicyLoad();
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
					c.EntPolicyLoadId = (System.Decimal)reader["ENT_POLICY_LOAD_ID"];
					c.OriginalEntPolicyLoadId = c.EntPolicyLoadId;
					c.EdCodeSemesterTypeId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_TYPE_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_TYPE_ID"];
					c.PartTimeFlg = Convert.IsDBNull(reader["PART_TIME_FLG"]) ? null : (System.Boolean?)reader["PART_TIME_FLG"];
					c.SrNo = (System.Decimal)reader["SR_NO"];
					c.EdCodeLoadTypeId = Convert.IsDBNull(reader["ED_CODE_LOAD_TYPE_ID"]) ? null : (System.Decimal?)reader["ED_CODE_LOAD_TYPE_ID"];
					c.GpaFrom = (System.Decimal)reader["GPA_FROM"];
					c.GpaTo = (System.Decimal)reader["GPA_TO"];
					c.NoPrvSem = (System.Decimal)reader["NO_PRV_SEM"];
					c.ContFlg = (System.Decimal)reader["CONT_FLG"];
					c.RemainCh = Convert.IsDBNull(reader["REMAIN_CH"]) ? null : (System.Decimal?)reader["REMAIN_CH"];
					c.MinCh = (System.Decimal)reader["MIN_CH"];
					c.MaxCh = (System.Decimal)reader["MAX_CH"];
					c.EdBylawId = Convert.IsDBNull(reader["ED_BYLAW_ID"]) ? null : (System.Decimal?)reader["ED_BYLAW_ID"];
					c.EdCodeLevelId = Convert.IsDBNull(reader["ED_CODE_LEVEL_ID"]) ? null : (System.Decimal?)reader["ED_CODE_LEVEL_ID"];
					c.FlgAcadWarn = (System.Decimal)reader["FLG_ACAD_WARN"];
					c.CrsCount = Convert.IsDBNull(reader["CRS_COUNT"]) ? null : (System.Decimal?)reader["CRS_COUNT"];
					c.ChCrsFlg = Convert.IsDBNull(reader["CH_CRS_FLG"]) ? null : (System.Int16?)reader["CH_CRS_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolicyLoad"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyLoad"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntPolicyLoad entity)
		{
			if (!reader.Read()) return;
			
			entity.EntPolicyLoadId = (System.Decimal)reader[((int)EntPolicyLoadColumn.EntPolicyLoadId - 1)];
			entity.OriginalEntPolicyLoadId = (System.Decimal)reader["ENT_POLICY_LOAD_ID"];
			entity.EdCodeSemesterTypeId = (reader.IsDBNull(((int)EntPolicyLoadColumn.EdCodeSemesterTypeId - 1)))?null:(System.Decimal?)reader[((int)EntPolicyLoadColumn.EdCodeSemesterTypeId - 1)];
			entity.PartTimeFlg = (reader.IsDBNull(((int)EntPolicyLoadColumn.PartTimeFlg - 1)))?null:(System.Boolean?)reader[((int)EntPolicyLoadColumn.PartTimeFlg - 1)];
			entity.SrNo = (System.Decimal)reader[((int)EntPolicyLoadColumn.SrNo - 1)];
			entity.EdCodeLoadTypeId = (reader.IsDBNull(((int)EntPolicyLoadColumn.EdCodeLoadTypeId - 1)))?null:(System.Decimal?)reader[((int)EntPolicyLoadColumn.EdCodeLoadTypeId - 1)];
			entity.GpaFrom = (System.Decimal)reader[((int)EntPolicyLoadColumn.GpaFrom - 1)];
			entity.GpaTo = (System.Decimal)reader[((int)EntPolicyLoadColumn.GpaTo - 1)];
			entity.NoPrvSem = (System.Decimal)reader[((int)EntPolicyLoadColumn.NoPrvSem - 1)];
			entity.ContFlg = (System.Decimal)reader[((int)EntPolicyLoadColumn.ContFlg - 1)];
			entity.RemainCh = (reader.IsDBNull(((int)EntPolicyLoadColumn.RemainCh - 1)))?null:(System.Decimal?)reader[((int)EntPolicyLoadColumn.RemainCh - 1)];
			entity.MinCh = (System.Decimal)reader[((int)EntPolicyLoadColumn.MinCh - 1)];
			entity.MaxCh = (System.Decimal)reader[((int)EntPolicyLoadColumn.MaxCh - 1)];
			entity.EdBylawId = (reader.IsDBNull(((int)EntPolicyLoadColumn.EdBylawId - 1)))?null:(System.Decimal?)reader[((int)EntPolicyLoadColumn.EdBylawId - 1)];
			entity.EdCodeLevelId = (reader.IsDBNull(((int)EntPolicyLoadColumn.EdCodeLevelId - 1)))?null:(System.Decimal?)reader[((int)EntPolicyLoadColumn.EdCodeLevelId - 1)];
			entity.FlgAcadWarn = (System.Decimal)reader[((int)EntPolicyLoadColumn.FlgAcadWarn - 1)];
			entity.CrsCount = (reader.IsDBNull(((int)EntPolicyLoadColumn.CrsCount - 1)))?null:(System.Decimal?)reader[((int)EntPolicyLoadColumn.CrsCount - 1)];
			entity.ChCrsFlg = (reader.IsDBNull(((int)EntPolicyLoadColumn.ChCrsFlg - 1)))?null:(System.Int16?)reader[((int)EntPolicyLoadColumn.ChCrsFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolicyLoad"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyLoad"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntPolicyLoad entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntPolicyLoadId = (System.Decimal)dataRow["ENT_POLICY_LOAD_ID"];
			entity.OriginalEntPolicyLoadId = (System.Decimal)dataRow["ENT_POLICY_LOAD_ID"];
			entity.EdCodeSemesterTypeId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_TYPE_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_TYPE_ID"];
			entity.PartTimeFlg = Convert.IsDBNull(dataRow["PART_TIME_FLG"]) ? null : (System.Boolean?)dataRow["PART_TIME_FLG"];
			entity.SrNo = (System.Decimal)dataRow["SR_NO"];
			entity.EdCodeLoadTypeId = Convert.IsDBNull(dataRow["ED_CODE_LOAD_TYPE_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_LOAD_TYPE_ID"];
			entity.GpaFrom = (System.Decimal)dataRow["GPA_FROM"];
			entity.GpaTo = (System.Decimal)dataRow["GPA_TO"];
			entity.NoPrvSem = (System.Decimal)dataRow["NO_PRV_SEM"];
			entity.ContFlg = (System.Decimal)dataRow["CONT_FLG"];
			entity.RemainCh = Convert.IsDBNull(dataRow["REMAIN_CH"]) ? null : (System.Decimal?)dataRow["REMAIN_CH"];
			entity.MinCh = (System.Decimal)dataRow["MIN_CH"];
			entity.MaxCh = (System.Decimal)dataRow["MAX_CH"];
			entity.EdBylawId = Convert.IsDBNull(dataRow["ED_BYLAW_ID"]) ? null : (System.Decimal?)dataRow["ED_BYLAW_ID"];
			entity.EdCodeLevelId = Convert.IsDBNull(dataRow["ED_CODE_LEVEL_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_LEVEL_ID"];
			entity.FlgAcadWarn = (System.Decimal)dataRow["FLG_ACAD_WARN"];
			entity.CrsCount = Convert.IsDBNull(dataRow["CRS_COUNT"]) ? null : (System.Decimal?)dataRow["CRS_COUNT"];
			entity.ChCrsFlg = Convert.IsDBNull(dataRow["CH_CRS_FLG"]) ? null : (System.Int16?)dataRow["CH_CRS_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyLoad"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolicyLoad Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyLoad entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCodeSemesterTypeIdSource	
			if (CanDeepLoad(entity, "EdCodeSemesterType|EdCodeSemesterTypeIdSource", deepLoadType, innerList) 
				&& entity.EdCodeSemesterTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeSemesterTypeId ?? 0.0m);
				EdCodeSemesterType tmpEntity = EntityManager.LocateEntity<EdCodeSemesterType>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemesterType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemesterTypeIdSource = tmpEntity;
				else
					entity.EdCodeSemesterTypeIdSource = DataRepository.EdCodeSemesterTypeProvider.GetByEdCodeSemesterTypeId(transactionManager, (entity.EdCodeSemesterTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeSemesterTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeSemesterTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeSemesterTypeProvider.DeepLoad(transactionManager, entity.EdCodeSemesterTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeSemesterTypeIdSource

			#region EdBylawIdSource	
			if (CanDeepLoad(entity, "EdBylaw|EdBylawIdSource", deepLoadType, innerList) 
				&& entity.EdBylawIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdBylawId ?? 0.0m);
				EdBylaw tmpEntity = EntityManager.LocateEntity<EdBylaw>(EntityLocator.ConstructKeyFromPkItems(typeof(EdBylaw), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdBylawIdSource = tmpEntity;
				else
					entity.EdBylawIdSource = DataRepository.EdBylawProvider.GetByEdBylawId(transactionManager, (entity.EdBylawId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdBylawIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdBylawIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdBylawProvider.DeepLoad(transactionManager, entity.EdBylawIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdBylawIdSource

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

			#region EdCodeLoadTypeIdSource	
			if (CanDeepLoad(entity, "EdCodeLoadType|EdCodeLoadTypeIdSource", deepLoadType, innerList) 
				&& entity.EdCodeLoadTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeLoadTypeId ?? 0.0m);
				EdCodeLoadType tmpEntity = EntityManager.LocateEntity<EdCodeLoadType>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeLoadType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeLoadTypeIdSource = tmpEntity;
				else
					entity.EdCodeLoadTypeIdSource = DataRepository.EdCodeLoadTypeProvider.GetByEdCodeLoadTypeId(transactionManager, (entity.EdCodeLoadTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeLoadTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeLoadTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeLoadTypeProvider.DeepLoad(transactionManager, entity.EdCodeLoadTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeLoadTypeIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntPolicyLoad object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntPolicyLoad instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolicyLoad Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyLoad entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCodeSemesterTypeIdSource
			if (CanDeepSave(entity, "EdCodeSemesterType|EdCodeSemesterTypeIdSource", deepSaveType, innerList) 
				&& entity.EdCodeSemesterTypeIdSource != null)
			{
				DataRepository.EdCodeSemesterTypeProvider.Save(transactionManager, entity.EdCodeSemesterTypeIdSource);
				entity.EdCodeSemesterTypeId = entity.EdCodeSemesterTypeIdSource.EdCodeSemesterTypeId;
			}
			#endregion 
			
			#region EdBylawIdSource
			if (CanDeepSave(entity, "EdBylaw|EdBylawIdSource", deepSaveType, innerList) 
				&& entity.EdBylawIdSource != null)
			{
				DataRepository.EdBylawProvider.Save(transactionManager, entity.EdBylawIdSource);
				entity.EdBylawId = entity.EdBylawIdSource.EdBylawId;
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
			
			#region EdCodeLoadTypeIdSource
			if (CanDeepSave(entity, "EdCodeLoadType|EdCodeLoadTypeIdSource", deepSaveType, innerList) 
				&& entity.EdCodeLoadTypeIdSource != null)
			{
				DataRepository.EdCodeLoadTypeProvider.Save(transactionManager, entity.EdCodeLoadTypeIdSource);
				entity.EdCodeLoadTypeId = entity.EdCodeLoadTypeIdSource.EdCodeLoadTypeId;
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
	
	#region EntPolicyLoadChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntPolicyLoad</c>
	///</summary>
	public enum EntPolicyLoadChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCodeSemesterType</c> at EdCodeSemesterTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemesterType))]
		EdCodeSemesterType,
		
		///<summary>
		/// Composite Property for <c>EdBylaw</c> at EdBylawIdSource
		///</summary>
		[ChildEntityType(typeof(EdBylaw))]
		EdBylaw,
		
		///<summary>
		/// Composite Property for <c>EdCodeLevel</c> at EdCodeLevelIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeLevel))]
		EdCodeLevel,
		
		///<summary>
		/// Composite Property for <c>EdCodeLoadType</c> at EdCodeLoadTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeLoadType))]
		EdCodeLoadType,
	}
	
	#endregion EntPolicyLoadChildEntityTypes
	
	#region EntPolicyLoadFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntPolicyLoadColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyLoad"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolicyLoadFilterBuilder : SqlFilterBuilder<EntPolicyLoadColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyLoadFilterBuilder class.
		/// </summary>
		public EntPolicyLoadFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyLoadFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolicyLoadFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyLoadFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolicyLoadFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolicyLoadFilterBuilder
	
	#region EntPolicyLoadParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntPolicyLoadColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyLoad"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolicyLoadParameterBuilder : ParameterizedSqlFilterBuilder<EntPolicyLoadColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyLoadParameterBuilder class.
		/// </summary>
		public EntPolicyLoadParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyLoadParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolicyLoadParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyLoadParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolicyLoadParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolicyLoadParameterBuilder
	
	#region EntPolicyLoadSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntPolicyLoadColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyLoad"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntPolicyLoadSortBuilder : SqlSortBuilder<EntPolicyLoadColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyLoadSqlSortBuilder class.
		/// </summary>
		public EntPolicyLoadSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntPolicyLoadSortBuilder
	
} // end namespace
