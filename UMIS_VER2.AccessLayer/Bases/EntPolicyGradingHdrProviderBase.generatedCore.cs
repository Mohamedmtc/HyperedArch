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
	/// This class is the base class for any <see cref="EntPolicyGradingHdrProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntPolicyGradingHdrProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntPolicyGradingHdr, UMIS_VER2.BusinessLyer.EntPolicyGradingHdrKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyGradingHdrKey key)
		{
			return Delete(transactionManager, key.EntPolicyGradingHdrId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entPolicyGradingHdrId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entPolicyGradingHdrId)
		{
			return Delete(null, _entPolicyGradingHdrId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingHdrId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entPolicyGradingHdrId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_HDR_ED_BYLAW key.
		///		FK_ENT_POLICY_GRADING_HDR_ED_BYLAW Description: 
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingHdr objects.</returns>
		public TList<EntPolicyGradingHdr> GetByEdBylawId(System.Decimal? _edBylawId)
		{
			int count = -1;
			return GetByEdBylawId(_edBylawId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_HDR_ED_BYLAW key.
		///		FK_ENT_POLICY_GRADING_HDR_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingHdr objects.</returns>
		/// <remarks></remarks>
		public TList<EntPolicyGradingHdr> GetByEdBylawId(TransactionManager transactionManager, System.Decimal? _edBylawId)
		{
			int count = -1;
			return GetByEdBylawId(transactionManager, _edBylawId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_HDR_ED_BYLAW key.
		///		FK_ENT_POLICY_GRADING_HDR_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingHdr objects.</returns>
		public TList<EntPolicyGradingHdr> GetByEdBylawId(TransactionManager transactionManager, System.Decimal? _edBylawId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBylawId(transactionManager, _edBylawId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_HDR_ED_BYLAW key.
		///		fkEntPolicyGradingHdrEdBylaw Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edBylawId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingHdr objects.</returns>
		public TList<EntPolicyGradingHdr> GetByEdBylawId(System.Decimal? _edBylawId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdBylawId(null, _edBylawId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_HDR_ED_BYLAW key.
		///		fkEntPolicyGradingHdrEdBylaw Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edBylawId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingHdr objects.</returns>
		public TList<EntPolicyGradingHdr> GetByEdBylawId(System.Decimal? _edBylawId, int start, int pageLength,out int count)
		{
			return GetByEdBylawId(null, _edBylawId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_HDR_ED_BYLAW key.
		///		FK_ENT_POLICY_GRADING_HDR_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingHdr objects.</returns>
		public abstract TList<EntPolicyGradingHdr> GetByEdBylawId(TransactionManager transactionManager, System.Decimal? _edBylawId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EntPolicyGradingHdr Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyGradingHdrKey key, int start, int pageLength)
		{
			return GetByEntPolicyGradingHdrId(transactionManager, key.EntPolicyGradingHdrId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_GRADING_TYPE_1 index.
		/// </summary>
		/// <param name="_edCodeGradingTypeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyGradingHdr&gt;"/> class.</returns>
		public TList<EntPolicyGradingHdr> GetByEdCodeGradingTypeId(System.Decimal _edCodeGradingTypeId)
		{
			int count = -1;
			return GetByEdCodeGradingTypeId(null,_edCodeGradingTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_GRADING_TYPE_1 index.
		/// </summary>
		/// <param name="_edCodeGradingTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyGradingHdr&gt;"/> class.</returns>
		public TList<EntPolicyGradingHdr> GetByEdCodeGradingTypeId(System.Decimal _edCodeGradingTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeGradingTypeId(null, _edCodeGradingTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_GRADING_TYPE_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyGradingHdr&gt;"/> class.</returns>
		public TList<EntPolicyGradingHdr> GetByEdCodeGradingTypeId(TransactionManager transactionManager, System.Decimal _edCodeGradingTypeId)
		{
			int count = -1;
			return GetByEdCodeGradingTypeId(transactionManager, _edCodeGradingTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_GRADING_TYPE_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyGradingHdr&gt;"/> class.</returns>
		public TList<EntPolicyGradingHdr> GetByEdCodeGradingTypeId(TransactionManager transactionManager, System.Decimal _edCodeGradingTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeGradingTypeId(transactionManager, _edCodeGradingTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_GRADING_TYPE_1 index.
		/// </summary>
		/// <param name="_edCodeGradingTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyGradingHdr&gt;"/> class.</returns>
		public TList<EntPolicyGradingHdr> GetByEdCodeGradingTypeId(System.Decimal _edCodeGradingTypeId, int start, int pageLength, out int count)
		{
			return GetByEdCodeGradingTypeId(null, _edCodeGradingTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_GRADING_TYPE_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyGradingHdr&gt;"/> class.</returns>
		public abstract TList<EntPolicyGradingHdr> GetByEdCodeGradingTypeId(TransactionManager transactionManager, System.Decimal _edCodeGradingTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ENT_POLICY_GRADING_HDR index.
		/// </summary>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingHdr GetByEntPolicyGradingHdrId(System.Decimal _entPolicyGradingHdrId)
		{
			int count = -1;
			return GetByEntPolicyGradingHdrId(null,_entPolicyGradingHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_GRADING_HDR index.
		/// </summary>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingHdr GetByEntPolicyGradingHdrId(System.Decimal _entPolicyGradingHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyGradingHdrId(null, _entPolicyGradingHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_GRADING_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingHdr GetByEntPolicyGradingHdrId(TransactionManager transactionManager, System.Decimal _entPolicyGradingHdrId)
		{
			int count = -1;
			return GetByEntPolicyGradingHdrId(transactionManager, _entPolicyGradingHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_GRADING_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingHdr GetByEntPolicyGradingHdrId(TransactionManager transactionManager, System.Decimal _entPolicyGradingHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyGradingHdrId(transactionManager, _entPolicyGradingHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_GRADING_HDR index.
		/// </summary>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingHdr GetByEntPolicyGradingHdrId(System.Decimal _entPolicyGradingHdrId, int start, int pageLength, out int count)
		{
			return GetByEntPolicyGradingHdrId(null, _entPolicyGradingHdrId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_GRADING_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingHdr"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPolicyGradingHdr GetByEntPolicyGradingHdrId(TransactionManager transactionManager, System.Decimal _entPolicyGradingHdrId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ENT_POLICY_GRADING_HDR_AR index.
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <param name="_descrAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingHdr GetByEdBylawIdDescrAr(System.Decimal? _edBylawId, System.String _descrAr)
		{
			int count = -1;
			return GetByEdBylawIdDescrAr(null,_edBylawId, _descrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_GRADING_HDR_AR index.
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingHdr GetByEdBylawIdDescrAr(System.Decimal? _edBylawId, System.String _descrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBylawIdDescrAr(null, _edBylawId, _descrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_GRADING_HDR_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="_descrAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingHdr GetByEdBylawIdDescrAr(TransactionManager transactionManager, System.Decimal? _edBylawId, System.String _descrAr)
		{
			int count = -1;
			return GetByEdBylawIdDescrAr(transactionManager, _edBylawId, _descrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_GRADING_HDR_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingHdr GetByEdBylawIdDescrAr(TransactionManager transactionManager, System.Decimal? _edBylawId, System.String _descrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBylawIdDescrAr(transactionManager, _edBylawId, _descrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_GRADING_HDR_AR index.
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingHdr GetByEdBylawIdDescrAr(System.Decimal? _edBylawId, System.String _descrAr, int start, int pageLength, out int count)
		{
			return GetByEdBylawIdDescrAr(null, _edBylawId, _descrAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_GRADING_HDR_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingHdr"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPolicyGradingHdr GetByEdBylawIdDescrAr(TransactionManager transactionManager, System.Decimal? _edBylawId, System.String _descrAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ENT_POLICY_GRADING_HDR_EN index.
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <param name="_descrEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingHdr GetByEdBylawIdDescrEn(System.Decimal? _edBylawId, System.String _descrEn)
		{
			int count = -1;
			return GetByEdBylawIdDescrEn(null,_edBylawId, _descrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_GRADING_HDR_EN index.
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingHdr GetByEdBylawIdDescrEn(System.Decimal? _edBylawId, System.String _descrEn, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBylawIdDescrEn(null, _edBylawId, _descrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_GRADING_HDR_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="_descrEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingHdr GetByEdBylawIdDescrEn(TransactionManager transactionManager, System.Decimal? _edBylawId, System.String _descrEn)
		{
			int count = -1;
			return GetByEdBylawIdDescrEn(transactionManager, _edBylawId, _descrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_GRADING_HDR_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingHdr GetByEdBylawIdDescrEn(TransactionManager transactionManager, System.Decimal? _edBylawId, System.String _descrEn, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBylawIdDescrEn(transactionManager, _edBylawId, _descrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_GRADING_HDR_EN index.
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingHdr GetByEdBylawIdDescrEn(System.Decimal? _edBylawId, System.String _descrEn, int start, int pageLength, out int count)
		{
			return GetByEdBylawIdDescrEn(null, _edBylawId, _descrEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_GRADING_HDR_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingHdr"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPolicyGradingHdr GetByEdBylawIdDescrEn(TransactionManager transactionManager, System.Decimal? _edBylawId, System.String _descrEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntPolicyGradingHdr&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntPolicyGradingHdr&gt;"/></returns>
		public static TList<EntPolicyGradingHdr> Fill(IDataReader reader, TList<EntPolicyGradingHdr> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntPolicyGradingHdr c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntPolicyGradingHdr")
					.Append("|").Append((System.Decimal)reader["ENT_POLICY_GRADING_HDR_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntPolicyGradingHdr>(
					key.ToString(), // EntityTrackingKey
					"EntPolicyGradingHdr",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntPolicyGradingHdr();
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
					c.EntPolicyGradingHdrId = (System.Decimal)reader["ENT_POLICY_GRADING_HDR_ID"];
					c.OriginalEntPolicyGradingHdrId = c.EntPolicyGradingHdrId;
					c.DescrEn = (System.String)reader["DESCR_EN"];
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.EdBylawId = Convert.IsDBNull(reader["ED_BYLAW_ID"]) ? null : (System.Decimal?)reader["ED_BYLAW_ID"];
					c.IsGeneral = Convert.IsDBNull(reader["IS_GENERAL"]) ? null : (System.Decimal?)reader["IS_GENERAL"];
					c.EdCodeGradingTypeId = (System.Decimal)reader["ED_CODE_GRADING_TYPE_ID"];
					c.RoundTotFlg = Convert.IsDBNull(reader["ROUND_TOT_FLG"]) ? null : (System.Decimal?)reader["ROUND_TOT_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingHdr"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingHdr"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntPolicyGradingHdr entity)
		{
			if (!reader.Read()) return;
			
			entity.EntPolicyGradingHdrId = (System.Decimal)reader[((int)EntPolicyGradingHdrColumn.EntPolicyGradingHdrId - 1)];
			entity.OriginalEntPolicyGradingHdrId = (System.Decimal)reader["ENT_POLICY_GRADING_HDR_ID"];
			entity.DescrEn = (System.String)reader[((int)EntPolicyGradingHdrColumn.DescrEn - 1)];
			entity.DescrAr = (System.String)reader[((int)EntPolicyGradingHdrColumn.DescrAr - 1)];
			entity.EdBylawId = (reader.IsDBNull(((int)EntPolicyGradingHdrColumn.EdBylawId - 1)))?null:(System.Decimal?)reader[((int)EntPolicyGradingHdrColumn.EdBylawId - 1)];
			entity.IsGeneral = (reader.IsDBNull(((int)EntPolicyGradingHdrColumn.IsGeneral - 1)))?null:(System.Decimal?)reader[((int)EntPolicyGradingHdrColumn.IsGeneral - 1)];
			entity.EdCodeGradingTypeId = (System.Decimal)reader[((int)EntPolicyGradingHdrColumn.EdCodeGradingTypeId - 1)];
			entity.RoundTotFlg = (reader.IsDBNull(((int)EntPolicyGradingHdrColumn.RoundTotFlg - 1)))?null:(System.Decimal?)reader[((int)EntPolicyGradingHdrColumn.RoundTotFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingHdr"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingHdr"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntPolicyGradingHdr entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntPolicyGradingHdrId = (System.Decimal)dataRow["ENT_POLICY_GRADING_HDR_ID"];
			entity.OriginalEntPolicyGradingHdrId = (System.Decimal)dataRow["ENT_POLICY_GRADING_HDR_ID"];
			entity.DescrEn = (System.String)dataRow["DESCR_EN"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.EdBylawId = Convert.IsDBNull(dataRow["ED_BYLAW_ID"]) ? null : (System.Decimal?)dataRow["ED_BYLAW_ID"];
			entity.IsGeneral = Convert.IsDBNull(dataRow["IS_GENERAL"]) ? null : (System.Decimal?)dataRow["IS_GENERAL"];
			entity.EdCodeGradingTypeId = (System.Decimal)dataRow["ED_CODE_GRADING_TYPE_ID"];
			entity.RoundTotFlg = Convert.IsDBNull(dataRow["ROUND_TOT_FLG"]) ? null : (System.Decimal?)dataRow["ROUND_TOT_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingHdr"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolicyGradingHdr Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyGradingHdr entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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

			#region EdCodeGradingTypeIdSource	
			if (CanDeepLoad(entity, "EdCodeGradingType|EdCodeGradingTypeIdSource", deepLoadType, innerList) 
				&& entity.EdCodeGradingTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeGradingTypeId;
				EdCodeGradingType tmpEntity = EntityManager.LocateEntity<EdCodeGradingType>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeGradingType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeGradingTypeIdSource = tmpEntity;
				else
					entity.EdCodeGradingTypeIdSource = DataRepository.EdCodeGradingTypeProvider.GetByEdCodeGradingTypeId(transactionManager, entity.EdCodeGradingTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeGradingTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeGradingTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeGradingTypeProvider.DeepLoad(transactionManager, entity.EdCodeGradingTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeGradingTypeIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEntPolicyGradingHdrId methods when available
			
			#region EntPolicyGradingDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyGradingDtl>|EntPolicyGradingDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyGradingDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyGradingDtlCollection = DataRepository.EntPolicyGradingDtlProvider.GetByEntPolicyGradingHdrId(transactionManager, entity.EntPolicyGradingHdrId);

				if (deep && entity.EntPolicyGradingDtlCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyGradingDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyGradingDtl>) DataRepository.EntPolicyGradingDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyGradingDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppTransToCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppTransToCourse>|AdmAppTransToCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppTransToCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppTransToCourseCollection = DataRepository.AdmAppTransToCourseProvider.GetByEntPolicyGradingHdrId(transactionManager, entity.EntPolicyGradingHdrId);

				if (deep && entity.AdmAppTransToCourseCollection.Count > 0)
				{
					deepHandles.Add("AdmAppTransToCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppTransToCourse>) DataRepository.AdmAppTransToCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppTransToCourseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTrnsCourseFromCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrnsCourseFrom>|EdStudIntTrnsCourseFromCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsCourseFromCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsCourseFromCollection = DataRepository.EdStudIntTrnsCourseFromProvider.GetByEntPolicyGradingHdrId(transactionManager, entity.EntPolicyGradingHdrId);

				if (deep && entity.EdStudIntTrnsCourseFromCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsCourseFromCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsCourseFrom>) DataRepository.EdStudIntTrnsCourseFromProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsCourseFromCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseReg>|EdStudCourseRegCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegCollection = DataRepository.EdStudCourseRegProvider.GetByEntPolicyGradingHdrId(transactionManager, entity.EntPolicyGradingHdrId);

				if (deep && entity.EdStudCourseRegCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseReg>) DataRepository.EdStudCourseRegProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicyCourseRepeatCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyCourseRepeat>|EntPolicyCourseRepeatCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyCourseRepeatCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyCourseRepeatCollection = DataRepository.EntPolicyCourseRepeatProvider.GetByEntPolicyGradingHdrId(transactionManager, entity.EntPolicyGradingHdrId);

				if (deep && entity.EntPolicyCourseRepeatCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyCourseRepeatCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyCourseRepeat>) DataRepository.EntPolicyCourseRepeatProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyCourseRepeatCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegTempCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseRegTemp>|EdStudCourseRegTempCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegTempCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegTempCollection = DataRepository.EdStudCourseRegTempProvider.GetByEntPolicyGradingHdrId(transactionManager, entity.EntPolicyGradingHdrId);

				if (deep && entity.EdStudCourseRegTempCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegTempCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseRegTemp>) DataRepository.EdStudCourseRegTempProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegTempCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTrnsCourseToCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrnsCourseTo>|EdStudIntTrnsCourseToCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsCourseToCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsCourseToCollection = DataRepository.EdStudIntTrnsCourseToProvider.GetByEntPolicyGradingHdrId(transactionManager, entity.EntPolicyGradingHdrId);

				if (deep && entity.EdStudIntTrnsCourseToCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsCourseToCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsCourseTo>) DataRepository.EdStudIntTrnsCourseToProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsCourseToCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicyGradingCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyGradingCourse>|EntPolicyGradingCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyGradingCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyGradingCourseCollection = DataRepository.EntPolicyGradingCourseProvider.GetByEntPolicyGradingHdrId(transactionManager, entity.EntPolicyGradingHdrId);

				if (deep && entity.EntPolicyGradingCourseCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyGradingCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyGradingCourse>) DataRepository.EntPolicyGradingCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyGradingCourseCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntPolicyGradingHdr object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntPolicyGradingHdr instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolicyGradingHdr Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyGradingHdr entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdBylawIdSource
			if (CanDeepSave(entity, "EdBylaw|EdBylawIdSource", deepSaveType, innerList) 
				&& entity.EdBylawIdSource != null)
			{
				DataRepository.EdBylawProvider.Save(transactionManager, entity.EdBylawIdSource);
				entity.EdBylawId = entity.EdBylawIdSource.EdBylawId;
			}
			#endregion 
			
			#region EdCodeGradingTypeIdSource
			if (CanDeepSave(entity, "EdCodeGradingType|EdCodeGradingTypeIdSource", deepSaveType, innerList) 
				&& entity.EdCodeGradingTypeIdSource != null)
			{
				DataRepository.EdCodeGradingTypeProvider.Save(transactionManager, entity.EdCodeGradingTypeIdSource);
				entity.EdCodeGradingTypeId = entity.EdCodeGradingTypeIdSource.EdCodeGradingTypeId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EntPolicyGradingDtl>
				if (CanDeepSave(entity.EntPolicyGradingDtlCollection, "List<EntPolicyGradingDtl>|EntPolicyGradingDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyGradingDtl child in entity.EntPolicyGradingDtlCollection)
					{
						if(child.EntPolicyGradingHdrIdSource != null)
						{
							child.EntPolicyGradingHdrId = child.EntPolicyGradingHdrIdSource.EntPolicyGradingHdrId;
						}
						else
						{
							child.EntPolicyGradingHdrId = entity.EntPolicyGradingHdrId;
						}

					}

					if (entity.EntPolicyGradingDtlCollection.Count > 0 || entity.EntPolicyGradingDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyGradingDtlProvider.Save(transactionManager, entity.EntPolicyGradingDtlCollection);
						
						deepHandles.Add("EntPolicyGradingDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyGradingDtl >) DataRepository.EntPolicyGradingDtlProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyGradingDtlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppTransToCourse>
				if (CanDeepSave(entity.AdmAppTransToCourseCollection, "List<AdmAppTransToCourse>|AdmAppTransToCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppTransToCourse child in entity.AdmAppTransToCourseCollection)
					{
						if(child.EntPolicyGradingHdrIdSource != null)
						{
							child.EntPolicyGradingHdrId = child.EntPolicyGradingHdrIdSource.EntPolicyGradingHdrId;
						}
						else
						{
							child.EntPolicyGradingHdrId = entity.EntPolicyGradingHdrId;
						}

					}

					if (entity.AdmAppTransToCourseCollection.Count > 0 || entity.AdmAppTransToCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppTransToCourseProvider.Save(transactionManager, entity.AdmAppTransToCourseCollection);
						
						deepHandles.Add("AdmAppTransToCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppTransToCourse >) DataRepository.AdmAppTransToCourseProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppTransToCourseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudIntTrnsCourseFrom>
				if (CanDeepSave(entity.EdStudIntTrnsCourseFromCollection, "List<EdStudIntTrnsCourseFrom>|EdStudIntTrnsCourseFromCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrnsCourseFrom child in entity.EdStudIntTrnsCourseFromCollection)
					{
						if(child.EntPolicyGradingHdrIdSource != null)
						{
							child.EntPolicyGradingHdrId = child.EntPolicyGradingHdrIdSource.EntPolicyGradingHdrId;
						}
						else
						{
							child.EntPolicyGradingHdrId = entity.EntPolicyGradingHdrId;
						}

					}

					if (entity.EdStudIntTrnsCourseFromCollection.Count > 0 || entity.EdStudIntTrnsCourseFromCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsCourseFromProvider.Save(transactionManager, entity.EdStudIntTrnsCourseFromCollection);
						
						deepHandles.Add("EdStudIntTrnsCourseFromCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrnsCourseFrom >) DataRepository.EdStudIntTrnsCourseFromProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsCourseFromCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseReg>
				if (CanDeepSave(entity.EdStudCourseRegCollection, "List<EdStudCourseReg>|EdStudCourseRegCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseReg child in entity.EdStudCourseRegCollection)
					{
						if(child.EntPolicyGradingHdrIdSource != null)
						{
							child.EntPolicyGradingHdrId = child.EntPolicyGradingHdrIdSource.EntPolicyGradingHdrId;
						}
						else
						{
							child.EntPolicyGradingHdrId = entity.EntPolicyGradingHdrId;
						}

					}

					if (entity.EdStudCourseRegCollection.Count > 0 || entity.EdStudCourseRegCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegProvider.Save(transactionManager, entity.EdStudCourseRegCollection);
						
						deepHandles.Add("EdStudCourseRegCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseReg >) DataRepository.EdStudCourseRegProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolicyCourseRepeat>
				if (CanDeepSave(entity.EntPolicyCourseRepeatCollection, "List<EntPolicyCourseRepeat>|EntPolicyCourseRepeatCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyCourseRepeat child in entity.EntPolicyCourseRepeatCollection)
					{
						if(child.EntPolicyGradingHdrIdSource != null)
						{
							child.EntPolicyGradingHdrId = child.EntPolicyGradingHdrIdSource.EntPolicyGradingHdrId;
						}
						else
						{
							child.EntPolicyGradingHdrId = entity.EntPolicyGradingHdrId;
						}

					}

					if (entity.EntPolicyCourseRepeatCollection.Count > 0 || entity.EntPolicyCourseRepeatCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyCourseRepeatProvider.Save(transactionManager, entity.EntPolicyCourseRepeatCollection);
						
						deepHandles.Add("EntPolicyCourseRepeatCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyCourseRepeat >) DataRepository.EntPolicyCourseRepeatProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyCourseRepeatCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseRegTemp>
				if (CanDeepSave(entity.EdStudCourseRegTempCollection, "List<EdStudCourseRegTemp>|EdStudCourseRegTempCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseRegTemp child in entity.EdStudCourseRegTempCollection)
					{
						if(child.EntPolicyGradingHdrIdSource != null)
						{
							child.EntPolicyGradingHdrId = child.EntPolicyGradingHdrIdSource.EntPolicyGradingHdrId;
						}
						else
						{
							child.EntPolicyGradingHdrId = entity.EntPolicyGradingHdrId;
						}

					}

					if (entity.EdStudCourseRegTempCollection.Count > 0 || entity.EdStudCourseRegTempCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegTempProvider.Save(transactionManager, entity.EdStudCourseRegTempCollection);
						
						deepHandles.Add("EdStudCourseRegTempCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseRegTemp >) DataRepository.EdStudCourseRegTempProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegTempCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudIntTrnsCourseTo>
				if (CanDeepSave(entity.EdStudIntTrnsCourseToCollection, "List<EdStudIntTrnsCourseTo>|EdStudIntTrnsCourseToCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrnsCourseTo child in entity.EdStudIntTrnsCourseToCollection)
					{
						if(child.EntPolicyGradingHdrIdSource != null)
						{
							child.EntPolicyGradingHdrId = child.EntPolicyGradingHdrIdSource.EntPolicyGradingHdrId;
						}
						else
						{
							child.EntPolicyGradingHdrId = entity.EntPolicyGradingHdrId;
						}

					}

					if (entity.EdStudIntTrnsCourseToCollection.Count > 0 || entity.EdStudIntTrnsCourseToCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsCourseToProvider.Save(transactionManager, entity.EdStudIntTrnsCourseToCollection);
						
						deepHandles.Add("EdStudIntTrnsCourseToCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrnsCourseTo >) DataRepository.EdStudIntTrnsCourseToProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsCourseToCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolicyGradingCourse>
				if (CanDeepSave(entity.EntPolicyGradingCourseCollection, "List<EntPolicyGradingCourse>|EntPolicyGradingCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyGradingCourse child in entity.EntPolicyGradingCourseCollection)
					{
						if(child.EntPolicyGradingHdrIdSource != null)
						{
							child.EntPolicyGradingHdrId = child.EntPolicyGradingHdrIdSource.EntPolicyGradingHdrId;
						}
						else
						{
							child.EntPolicyGradingHdrId = entity.EntPolicyGradingHdrId;
						}

					}

					if (entity.EntPolicyGradingCourseCollection.Count > 0 || entity.EntPolicyGradingCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyGradingCourseProvider.Save(transactionManager, entity.EntPolicyGradingCourseCollection);
						
						deepHandles.Add("EntPolicyGradingCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyGradingCourse >) DataRepository.EntPolicyGradingCourseProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyGradingCourseCollection, deepSaveType, childTypes, innerList }
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
	
	#region EntPolicyGradingHdrChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntPolicyGradingHdr</c>
	///</summary>
	public enum EntPolicyGradingHdrChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdBylaw</c> at EdBylawIdSource
		///</summary>
		[ChildEntityType(typeof(EdBylaw))]
		EdBylaw,
		
		///<summary>
		/// Composite Property for <c>EdCodeGradingType</c> at EdCodeGradingTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeGradingType))]
		EdCodeGradingType,
		///<summary>
		/// Collection of <c>EntPolicyGradingHdr</c> as OneToMany for EntPolicyGradingDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyGradingDtl>))]
		EntPolicyGradingDtlCollection,
		///<summary>
		/// Collection of <c>EntPolicyGradingHdr</c> as OneToMany for AdmAppTransToCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppTransToCourse>))]
		AdmAppTransToCourseCollection,
		///<summary>
		/// Collection of <c>EntPolicyGradingHdr</c> as OneToMany for EdStudIntTrnsCourseFromCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsCourseFrom>))]
		EdStudIntTrnsCourseFromCollection,
		///<summary>
		/// Collection of <c>EntPolicyGradingHdr</c> as OneToMany for EdStudCourseRegCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseReg>))]
		EdStudCourseRegCollection,
		///<summary>
		/// Collection of <c>EntPolicyGradingHdr</c> as OneToMany for EntPolicyCourseRepeatCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyCourseRepeat>))]
		EntPolicyCourseRepeatCollection,
		///<summary>
		/// Collection of <c>EntPolicyGradingHdr</c> as OneToMany for EdStudCourseRegTempCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseRegTemp>))]
		EdStudCourseRegTempCollection,
		///<summary>
		/// Collection of <c>EntPolicyGradingHdr</c> as OneToMany for EdStudIntTrnsCourseToCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsCourseTo>))]
		EdStudIntTrnsCourseToCollection,
		///<summary>
		/// Collection of <c>EntPolicyGradingHdr</c> as OneToMany for EntPolicyGradingCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyGradingCourse>))]
		EntPolicyGradingCourseCollection,
	}
	
	#endregion EntPolicyGradingHdrChildEntityTypes
	
	#region EntPolicyGradingHdrFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntPolicyGradingHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyGradingHdr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolicyGradingHdrFilterBuilder : SqlFilterBuilder<EntPolicyGradingHdrColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyGradingHdrFilterBuilder class.
		/// </summary>
		public EntPolicyGradingHdrFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyGradingHdrFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolicyGradingHdrFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyGradingHdrFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolicyGradingHdrFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolicyGradingHdrFilterBuilder
	
	#region EntPolicyGradingHdrParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntPolicyGradingHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyGradingHdr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolicyGradingHdrParameterBuilder : ParameterizedSqlFilterBuilder<EntPolicyGradingHdrColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyGradingHdrParameterBuilder class.
		/// </summary>
		public EntPolicyGradingHdrParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyGradingHdrParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolicyGradingHdrParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyGradingHdrParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolicyGradingHdrParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolicyGradingHdrParameterBuilder
	
	#region EntPolicyGradingHdrSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntPolicyGradingHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyGradingHdr"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntPolicyGradingHdrSortBuilder : SqlSortBuilder<EntPolicyGradingHdrColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyGradingHdrSqlSortBuilder class.
		/// </summary>
		public EntPolicyGradingHdrSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntPolicyGradingHdrSortBuilder
	
} // end namespace
