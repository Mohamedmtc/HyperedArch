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
	/// This class is the base class for any <see cref="EntPolicyExcuseProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntPolicyExcuseProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntPolicyExcuse, UMIS_VER2.BusinessLyer.EntPolicyExcuseKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyExcuseKey key)
		{
			return Delete(transactionManager, key.EntPolicyExcuseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entPolicyExcuseId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entPolicyExcuseId)
		{
			return Delete(null, _entPolicyExcuseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyExcuseId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entPolicyExcuseId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_EXCUSE_ED_BYLAW key.
		///		FK_ENT_POLICY_EXCUSE_ED_BYLAW Description: 
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyExcuse objects.</returns>
		public TList<EntPolicyExcuse> GetByEdBylawId(System.Decimal? _edBylawId)
		{
			int count = -1;
			return GetByEdBylawId(_edBylawId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_EXCUSE_ED_BYLAW key.
		///		FK_ENT_POLICY_EXCUSE_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyExcuse objects.</returns>
		/// <remarks></remarks>
		public TList<EntPolicyExcuse> GetByEdBylawId(TransactionManager transactionManager, System.Decimal? _edBylawId)
		{
			int count = -1;
			return GetByEdBylawId(transactionManager, _edBylawId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_EXCUSE_ED_BYLAW key.
		///		FK_ENT_POLICY_EXCUSE_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyExcuse objects.</returns>
		public TList<EntPolicyExcuse> GetByEdBylawId(TransactionManager transactionManager, System.Decimal? _edBylawId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBylawId(transactionManager, _edBylawId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_EXCUSE_ED_BYLAW key.
		///		fkEntPolicyExcuseEdBylaw Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edBylawId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyExcuse objects.</returns>
		public TList<EntPolicyExcuse> GetByEdBylawId(System.Decimal? _edBylawId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdBylawId(null, _edBylawId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_EXCUSE_ED_BYLAW key.
		///		fkEntPolicyExcuseEdBylaw Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edBylawId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyExcuse objects.</returns>
		public TList<EntPolicyExcuse> GetByEdBylawId(System.Decimal? _edBylawId, int start, int pageLength,out int count)
		{
			return GetByEdBylawId(null, _edBylawId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_EXCUSE_ED_BYLAW key.
		///		FK_ENT_POLICY_EXCUSE_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyExcuse objects.</returns>
		public abstract TList<EntPolicyExcuse> GetByEdBylawId(TransactionManager transactionManager, System.Decimal? _edBylawId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_EXCUSE_ED_CODE_ENROLL_TYPE key.
		///		FK_ENT_POLICY_EXCUSE_ED_CODE_ENROLL_TYPE Description: 
		/// </summary>
		/// <param name="_edCodeEnrollTypeId">SEM_RLTD_FLG=1 only</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyExcuse objects.</returns>
		public TList<EntPolicyExcuse> GetByEdCodeEnrollTypeId(System.Decimal _edCodeEnrollTypeId)
		{
			int count = -1;
			return GetByEdCodeEnrollTypeId(_edCodeEnrollTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_EXCUSE_ED_CODE_ENROLL_TYPE key.
		///		FK_ENT_POLICY_EXCUSE_ED_CODE_ENROLL_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeEnrollTypeId">SEM_RLTD_FLG=1 only</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyExcuse objects.</returns>
		/// <remarks></remarks>
		public TList<EntPolicyExcuse> GetByEdCodeEnrollTypeId(TransactionManager transactionManager, System.Decimal _edCodeEnrollTypeId)
		{
			int count = -1;
			return GetByEdCodeEnrollTypeId(transactionManager, _edCodeEnrollTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_EXCUSE_ED_CODE_ENROLL_TYPE key.
		///		FK_ENT_POLICY_EXCUSE_ED_CODE_ENROLL_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeEnrollTypeId">SEM_RLTD_FLG=1 only</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyExcuse objects.</returns>
		public TList<EntPolicyExcuse> GetByEdCodeEnrollTypeId(TransactionManager transactionManager, System.Decimal _edCodeEnrollTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeEnrollTypeId(transactionManager, _edCodeEnrollTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_EXCUSE_ED_CODE_ENROLL_TYPE key.
		///		fkEntPolicyExcuseEdCodeEnrollType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeEnrollTypeId">SEM_RLTD_FLG=1 only</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyExcuse objects.</returns>
		public TList<EntPolicyExcuse> GetByEdCodeEnrollTypeId(System.Decimal _edCodeEnrollTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeEnrollTypeId(null, _edCodeEnrollTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_EXCUSE_ED_CODE_ENROLL_TYPE key.
		///		fkEntPolicyExcuseEdCodeEnrollType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeEnrollTypeId">SEM_RLTD_FLG=1 only</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyExcuse objects.</returns>
		public TList<EntPolicyExcuse> GetByEdCodeEnrollTypeId(System.Decimal _edCodeEnrollTypeId, int start, int pageLength,out int count)
		{
			return GetByEdCodeEnrollTypeId(null, _edCodeEnrollTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_EXCUSE_ED_CODE_ENROLL_TYPE key.
		///		FK_ENT_POLICY_EXCUSE_ED_CODE_ENROLL_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeEnrollTypeId">SEM_RLTD_FLG=1 only</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyExcuse objects.</returns>
		public abstract TList<EntPolicyExcuse> GetByEdCodeEnrollTypeId(TransactionManager transactionManager, System.Decimal _edCodeEnrollTypeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EntPolicyExcuse Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyExcuseKey key, int start, int pageLength)
		{
			return GetByEntPolicyExcuseId(transactionManager, key.EntPolicyExcuseId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_EXCUSE_TYPE__1 index.
		/// </summary>
		/// <param name="_edCodeExcuseTypeId">XXX not used</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyExcuse&gt;"/> class.</returns>
		public TList<EntPolicyExcuse> GetByEdCodeExcuseTypeId(System.Decimal? _edCodeExcuseTypeId)
		{
			int count = -1;
			return GetByEdCodeExcuseTypeId(null,_edCodeExcuseTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_EXCUSE_TYPE__1 index.
		/// </summary>
		/// <param name="_edCodeExcuseTypeId">XXX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyExcuse&gt;"/> class.</returns>
		public TList<EntPolicyExcuse> GetByEdCodeExcuseTypeId(System.Decimal? _edCodeExcuseTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeExcuseTypeId(null, _edCodeExcuseTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_EXCUSE_TYPE__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeExcuseTypeId">XXX not used</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyExcuse&gt;"/> class.</returns>
		public TList<EntPolicyExcuse> GetByEdCodeExcuseTypeId(TransactionManager transactionManager, System.Decimal? _edCodeExcuseTypeId)
		{
			int count = -1;
			return GetByEdCodeExcuseTypeId(transactionManager, _edCodeExcuseTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_EXCUSE_TYPE__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeExcuseTypeId">XXX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyExcuse&gt;"/> class.</returns>
		public TList<EntPolicyExcuse> GetByEdCodeExcuseTypeId(TransactionManager transactionManager, System.Decimal? _edCodeExcuseTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeExcuseTypeId(transactionManager, _edCodeExcuseTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_EXCUSE_TYPE__1 index.
		/// </summary>
		/// <param name="_edCodeExcuseTypeId">XXX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyExcuse&gt;"/> class.</returns>
		public TList<EntPolicyExcuse> GetByEdCodeExcuseTypeId(System.Decimal? _edCodeExcuseTypeId, int start, int pageLength, out int count)
		{
			return GetByEdCodeExcuseTypeId(null, _edCodeExcuseTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_EXCUSE_TYPE__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeExcuseTypeId">XXX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyExcuse&gt;"/> class.</returns>
		public abstract TList<EntPolicyExcuse> GetByEdCodeExcuseTypeId(TransactionManager transactionManager, System.Decimal? _edCodeExcuseTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_BYLAW_EXCUSE index.
		/// </summary>
		/// <param name="_entPolicyExcuseId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyExcuse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyExcuse GetByEntPolicyExcuseId(System.Decimal _entPolicyExcuseId)
		{
			int count = -1;
			return GetByEntPolicyExcuseId(null,_entPolicyExcuseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_BYLAW_EXCUSE index.
		/// </summary>
		/// <param name="_entPolicyExcuseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyExcuse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyExcuse GetByEntPolicyExcuseId(System.Decimal _entPolicyExcuseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyExcuseId(null, _entPolicyExcuseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_BYLAW_EXCUSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyExcuseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyExcuse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyExcuse GetByEntPolicyExcuseId(TransactionManager transactionManager, System.Decimal _entPolicyExcuseId)
		{
			int count = -1;
			return GetByEntPolicyExcuseId(transactionManager, _entPolicyExcuseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_BYLAW_EXCUSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyExcuseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyExcuse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyExcuse GetByEntPolicyExcuseId(TransactionManager transactionManager, System.Decimal _entPolicyExcuseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyExcuseId(transactionManager, _entPolicyExcuseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_BYLAW_EXCUSE index.
		/// </summary>
		/// <param name="_entPolicyExcuseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyExcuse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyExcuse GetByEntPolicyExcuseId(System.Decimal _entPolicyExcuseId, int start, int pageLength, out int count)
		{
			return GetByEntPolicyExcuseId(null, _entPolicyExcuseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_BYLAW_EXCUSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyExcuseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyExcuse"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPolicyExcuse GetByEntPolicyExcuseId(TransactionManager transactionManager, System.Decimal _entPolicyExcuseId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ENT_POLICY_EXCUSE index.
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <param name="_edCodeEnrollTypeId">SEM_RLTD_FLG=1 only</param>
		/// <param name="_edCodeExcuseTypeId">XXX not used</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyExcuse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyExcuse GetByEdBylawIdEdCodeEnrollTypeIdEdCodeExcuseTypeId(System.Decimal? _edBylawId, System.Decimal _edCodeEnrollTypeId, System.Decimal? _edCodeExcuseTypeId)
		{
			int count = -1;
			return GetByEdBylawIdEdCodeEnrollTypeIdEdCodeExcuseTypeId(null,_edBylawId, _edCodeEnrollTypeId, _edCodeExcuseTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_EXCUSE index.
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <param name="_edCodeEnrollTypeId">SEM_RLTD_FLG=1 only</param>
		/// <param name="_edCodeExcuseTypeId">XXX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyExcuse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyExcuse GetByEdBylawIdEdCodeEnrollTypeIdEdCodeExcuseTypeId(System.Decimal? _edBylawId, System.Decimal _edCodeEnrollTypeId, System.Decimal? _edCodeExcuseTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBylawIdEdCodeEnrollTypeIdEdCodeExcuseTypeId(null, _edBylawId, _edCodeEnrollTypeId, _edCodeExcuseTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_EXCUSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="_edCodeEnrollTypeId">SEM_RLTD_FLG=1 only</param>
		/// <param name="_edCodeExcuseTypeId">XXX not used</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyExcuse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyExcuse GetByEdBylawIdEdCodeEnrollTypeIdEdCodeExcuseTypeId(TransactionManager transactionManager, System.Decimal? _edBylawId, System.Decimal _edCodeEnrollTypeId, System.Decimal? _edCodeExcuseTypeId)
		{
			int count = -1;
			return GetByEdBylawIdEdCodeEnrollTypeIdEdCodeExcuseTypeId(transactionManager, _edBylawId, _edCodeEnrollTypeId, _edCodeExcuseTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_EXCUSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="_edCodeEnrollTypeId">SEM_RLTD_FLG=1 only</param>
		/// <param name="_edCodeExcuseTypeId">XXX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyExcuse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyExcuse GetByEdBylawIdEdCodeEnrollTypeIdEdCodeExcuseTypeId(TransactionManager transactionManager, System.Decimal? _edBylawId, System.Decimal _edCodeEnrollTypeId, System.Decimal? _edCodeExcuseTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBylawIdEdCodeEnrollTypeIdEdCodeExcuseTypeId(transactionManager, _edBylawId, _edCodeEnrollTypeId, _edCodeExcuseTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_EXCUSE index.
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <param name="_edCodeEnrollTypeId">SEM_RLTD_FLG=1 only</param>
		/// <param name="_edCodeExcuseTypeId">XXX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyExcuse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyExcuse GetByEdBylawIdEdCodeEnrollTypeIdEdCodeExcuseTypeId(System.Decimal? _edBylawId, System.Decimal _edCodeEnrollTypeId, System.Decimal? _edCodeExcuseTypeId, int start, int pageLength, out int count)
		{
			return GetByEdBylawIdEdCodeEnrollTypeIdEdCodeExcuseTypeId(null, _edBylawId, _edCodeEnrollTypeId, _edCodeExcuseTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_EXCUSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="_edCodeEnrollTypeId">SEM_RLTD_FLG=1 only</param>
		/// <param name="_edCodeExcuseTypeId">XXX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyExcuse"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPolicyExcuse GetByEdBylawIdEdCodeEnrollTypeIdEdCodeExcuseTypeId(TransactionManager transactionManager, System.Decimal? _edBylawId, System.Decimal _edCodeEnrollTypeId, System.Decimal? _edCodeExcuseTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntPolicyExcuse&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntPolicyExcuse&gt;"/></returns>
		public static TList<EntPolicyExcuse> Fill(IDataReader reader, TList<EntPolicyExcuse> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntPolicyExcuse c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntPolicyExcuse")
					.Append("|").Append((System.Decimal)reader["ENT_POLICY_EXCUSE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntPolicyExcuse>(
					key.ToString(), // EntityTrackingKey
					"EntPolicyExcuse",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntPolicyExcuse();
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
					c.EntPolicyExcuseId = (System.Decimal)reader["ENT_POLICY_EXCUSE_ID"];
					c.OriginalEntPolicyExcuseId = c.EntPolicyExcuseId;
					c.EdBylawId = Convert.IsDBNull(reader["ED_BYLAW_ID"]) ? null : (System.Decimal?)reader["ED_BYLAW_ID"];
					c.EdCodeExcuseTypeId = Convert.IsDBNull(reader["ED_CODE_EXCUSE_TYPE_ID"]) ? null : (System.Decimal?)reader["ED_CODE_EXCUSE_TYPE_ID"];
					c.EdCodeEnrollTypeId = (System.Decimal)reader["ED_CODE_ENROLL_TYPE_ID"];
					c.MaxDays = (System.Decimal)reader["MAX_DAYS"];
					c.MaxMonths = (System.Decimal)reader["MAX_MONTHS"];
					c.MaxExecuseStudy = Convert.IsDBNull(reader["MAX_EXECUSE_STUDY"]) ? null : (System.Decimal?)reader["MAX_EXECUSE_STUDY"];
					c.MaxCoursePerReq = Convert.IsDBNull(reader["MAX_COURSE_PER_REQ"]) ? null : (System.Decimal?)reader["MAX_COURSE_PER_REQ"];
					c.MaxSemCount = Convert.IsDBNull(reader["MAX_SEM_COUNT"]) ? null : (System.Decimal?)reader["MAX_SEM_COUNT"];
					c.MaxSemPerReq = Convert.IsDBNull(reader["MAX_SEM_PER_REQ"]) ? null : (System.Decimal?)reader["MAX_SEM_PER_REQ"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolicyExcuse"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyExcuse"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntPolicyExcuse entity)
		{
			if (!reader.Read()) return;
			
			entity.EntPolicyExcuseId = (System.Decimal)reader[((int)EntPolicyExcuseColumn.EntPolicyExcuseId - 1)];
			entity.OriginalEntPolicyExcuseId = (System.Decimal)reader["ENT_POLICY_EXCUSE_ID"];
			entity.EdBylawId = (reader.IsDBNull(((int)EntPolicyExcuseColumn.EdBylawId - 1)))?null:(System.Decimal?)reader[((int)EntPolicyExcuseColumn.EdBylawId - 1)];
			entity.EdCodeExcuseTypeId = (reader.IsDBNull(((int)EntPolicyExcuseColumn.EdCodeExcuseTypeId - 1)))?null:(System.Decimal?)reader[((int)EntPolicyExcuseColumn.EdCodeExcuseTypeId - 1)];
			entity.EdCodeEnrollTypeId = (System.Decimal)reader[((int)EntPolicyExcuseColumn.EdCodeEnrollTypeId - 1)];
			entity.MaxDays = (System.Decimal)reader[((int)EntPolicyExcuseColumn.MaxDays - 1)];
			entity.MaxMonths = (System.Decimal)reader[((int)EntPolicyExcuseColumn.MaxMonths - 1)];
			entity.MaxExecuseStudy = (reader.IsDBNull(((int)EntPolicyExcuseColumn.MaxExecuseStudy - 1)))?null:(System.Decimal?)reader[((int)EntPolicyExcuseColumn.MaxExecuseStudy - 1)];
			entity.MaxCoursePerReq = (reader.IsDBNull(((int)EntPolicyExcuseColumn.MaxCoursePerReq - 1)))?null:(System.Decimal?)reader[((int)EntPolicyExcuseColumn.MaxCoursePerReq - 1)];
			entity.MaxSemCount = (reader.IsDBNull(((int)EntPolicyExcuseColumn.MaxSemCount - 1)))?null:(System.Decimal?)reader[((int)EntPolicyExcuseColumn.MaxSemCount - 1)];
			entity.MaxSemPerReq = (reader.IsDBNull(((int)EntPolicyExcuseColumn.MaxSemPerReq - 1)))?null:(System.Decimal?)reader[((int)EntPolicyExcuseColumn.MaxSemPerReq - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolicyExcuse"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyExcuse"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntPolicyExcuse entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntPolicyExcuseId = (System.Decimal)dataRow["ENT_POLICY_EXCUSE_ID"];
			entity.OriginalEntPolicyExcuseId = (System.Decimal)dataRow["ENT_POLICY_EXCUSE_ID"];
			entity.EdBylawId = Convert.IsDBNull(dataRow["ED_BYLAW_ID"]) ? null : (System.Decimal?)dataRow["ED_BYLAW_ID"];
			entity.EdCodeExcuseTypeId = Convert.IsDBNull(dataRow["ED_CODE_EXCUSE_TYPE_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_EXCUSE_TYPE_ID"];
			entity.EdCodeEnrollTypeId = (System.Decimal)dataRow["ED_CODE_ENROLL_TYPE_ID"];
			entity.MaxDays = (System.Decimal)dataRow["MAX_DAYS"];
			entity.MaxMonths = (System.Decimal)dataRow["MAX_MONTHS"];
			entity.MaxExecuseStudy = Convert.IsDBNull(dataRow["MAX_EXECUSE_STUDY"]) ? null : (System.Decimal?)dataRow["MAX_EXECUSE_STUDY"];
			entity.MaxCoursePerReq = Convert.IsDBNull(dataRow["MAX_COURSE_PER_REQ"]) ? null : (System.Decimal?)dataRow["MAX_COURSE_PER_REQ"];
			entity.MaxSemCount = Convert.IsDBNull(dataRow["MAX_SEM_COUNT"]) ? null : (System.Decimal?)dataRow["MAX_SEM_COUNT"];
			entity.MaxSemPerReq = Convert.IsDBNull(dataRow["MAX_SEM_PER_REQ"]) ? null : (System.Decimal?)dataRow["MAX_SEM_PER_REQ"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyExcuse"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolicyExcuse Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyExcuse entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCodeExcuseTypeIdSource	
			if (CanDeepLoad(entity, "EdCodeExcuseType|EdCodeExcuseTypeIdSource", deepLoadType, innerList) 
				&& entity.EdCodeExcuseTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeExcuseTypeId ?? 0.0m);
				EdCodeExcuseType tmpEntity = EntityManager.LocateEntity<EdCodeExcuseType>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeExcuseType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeExcuseTypeIdSource = tmpEntity;
				else
					entity.EdCodeExcuseTypeIdSource = DataRepository.EdCodeExcuseTypeProvider.GetByEdCodeExcuseId(transactionManager, (entity.EdCodeExcuseTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeExcuseTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeExcuseTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeExcuseTypeProvider.DeepLoad(transactionManager, entity.EdCodeExcuseTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeExcuseTypeIdSource

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

			#region EdCodeEnrollTypeIdSource	
			if (CanDeepLoad(entity, "EdCodeEnrollType|EdCodeEnrollTypeIdSource", deepLoadType, innerList) 
				&& entity.EdCodeEnrollTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeEnrollTypeId;
				EdCodeEnrollType tmpEntity = EntityManager.LocateEntity<EdCodeEnrollType>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeEnrollType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeEnrollTypeIdSource = tmpEntity;
				else
					entity.EdCodeEnrollTypeIdSource = DataRepository.EdCodeEnrollTypeProvider.GetByEdCodeEnrollTypeId(transactionManager, entity.EdCodeEnrollTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeEnrollTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeEnrollTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeEnrollTypeProvider.DeepLoad(transactionManager, entity.EdCodeEnrollTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeEnrollTypeIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntPolicyExcuse object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntPolicyExcuse instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolicyExcuse Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyExcuse entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCodeExcuseTypeIdSource
			if (CanDeepSave(entity, "EdCodeExcuseType|EdCodeExcuseTypeIdSource", deepSaveType, innerList) 
				&& entity.EdCodeExcuseTypeIdSource != null)
			{
				DataRepository.EdCodeExcuseTypeProvider.Save(transactionManager, entity.EdCodeExcuseTypeIdSource);
				entity.EdCodeExcuseTypeId = entity.EdCodeExcuseTypeIdSource.EdCodeExcuseId;
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
			
			#region EdCodeEnrollTypeIdSource
			if (CanDeepSave(entity, "EdCodeEnrollType|EdCodeEnrollTypeIdSource", deepSaveType, innerList) 
				&& entity.EdCodeEnrollTypeIdSource != null)
			{
				DataRepository.EdCodeEnrollTypeProvider.Save(transactionManager, entity.EdCodeEnrollTypeIdSource);
				entity.EdCodeEnrollTypeId = entity.EdCodeEnrollTypeIdSource.EdCodeEnrollTypeId;
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
	
	#region EntPolicyExcuseChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntPolicyExcuse</c>
	///</summary>
	public enum EntPolicyExcuseChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCodeExcuseType</c> at EdCodeExcuseTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeExcuseType))]
		EdCodeExcuseType,
		
		///<summary>
		/// Composite Property for <c>EdBylaw</c> at EdBylawIdSource
		///</summary>
		[ChildEntityType(typeof(EdBylaw))]
		EdBylaw,
		
		///<summary>
		/// Composite Property for <c>EdCodeEnrollType</c> at EdCodeEnrollTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeEnrollType))]
		EdCodeEnrollType,
	}
	
	#endregion EntPolicyExcuseChildEntityTypes
	
	#region EntPolicyExcuseFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntPolicyExcuseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyExcuse"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolicyExcuseFilterBuilder : SqlFilterBuilder<EntPolicyExcuseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyExcuseFilterBuilder class.
		/// </summary>
		public EntPolicyExcuseFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyExcuseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolicyExcuseFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyExcuseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolicyExcuseFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolicyExcuseFilterBuilder
	
	#region EntPolicyExcuseParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntPolicyExcuseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyExcuse"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolicyExcuseParameterBuilder : ParameterizedSqlFilterBuilder<EntPolicyExcuseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyExcuseParameterBuilder class.
		/// </summary>
		public EntPolicyExcuseParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyExcuseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolicyExcuseParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyExcuseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolicyExcuseParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolicyExcuseParameterBuilder
	
	#region EntPolicyExcuseSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntPolicyExcuseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyExcuse"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntPolicyExcuseSortBuilder : SqlSortBuilder<EntPolicyExcuseColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyExcuseSqlSortBuilder class.
		/// </summary>
		public EntPolicyExcuseSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntPolicyExcuseSortBuilder
	
} // end namespace
