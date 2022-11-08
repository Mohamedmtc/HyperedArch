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
	/// This class is the base class for any <see cref="EntPolicyAccumHonorProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntPolicyAccumHonorProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntPolicyAccumHonor, UMIS_VER2.BusinessLyer.EntPolicyAccumHonorKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyAccumHonorKey key)
		{
			return Delete(transactionManager, key.EntPolicyAccumHonorId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entPolicyAccumHonorId">مراتب الشرف  التراكمية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entPolicyAccumHonorId)
		{
			return Delete(null, _entPolicyAccumHonorId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAccumHonorId">مراتب الشرف  التراكمية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entPolicyAccumHonorId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ACCUM_HONOR_ED_BYLAW key.
		///		FK_ENT_POLICY_ACCUM_HONOR_ED_BYLAW Description: 
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAccumHonor objects.</returns>
		public TList<EntPolicyAccumHonor> GetByEdBylawId(System.Decimal? _edBylawId)
		{
			int count = -1;
			return GetByEdBylawId(_edBylawId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ACCUM_HONOR_ED_BYLAW key.
		///		FK_ENT_POLICY_ACCUM_HONOR_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAccumHonor objects.</returns>
		/// <remarks></remarks>
		public TList<EntPolicyAccumHonor> GetByEdBylawId(TransactionManager transactionManager, System.Decimal? _edBylawId)
		{
			int count = -1;
			return GetByEdBylawId(transactionManager, _edBylawId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ACCUM_HONOR_ED_BYLAW key.
		///		FK_ENT_POLICY_ACCUM_HONOR_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAccumHonor objects.</returns>
		public TList<EntPolicyAccumHonor> GetByEdBylawId(TransactionManager transactionManager, System.Decimal? _edBylawId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBylawId(transactionManager, _edBylawId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ACCUM_HONOR_ED_BYLAW key.
		///		fkEntPolicyAccumHonorEdBylaw Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edBylawId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAccumHonor objects.</returns>
		public TList<EntPolicyAccumHonor> GetByEdBylawId(System.Decimal? _edBylawId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdBylawId(null, _edBylawId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ACCUM_HONOR_ED_BYLAW key.
		///		fkEntPolicyAccumHonorEdBylaw Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edBylawId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAccumHonor objects.</returns>
		public TList<EntPolicyAccumHonor> GetByEdBylawId(System.Decimal? _edBylawId, int start, int pageLength,out int count)
		{
			return GetByEdBylawId(null, _edBylawId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ACCUM_HONOR_ED_BYLAW key.
		///		FK_ENT_POLICY_ACCUM_HONOR_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAccumHonor objects.</returns>
		public abstract TList<EntPolicyAccumHonor> GetByEdBylawId(TransactionManager transactionManager, System.Decimal? _edBylawId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ACCUM_HONOR_GS_CDE_HONOR key.
		///		FK_ENT_POLICY_ACCUM_HONOR_GS_CDE_HONOR Description: 
		/// </summary>
		/// <param name="_gsCdeHonorId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAccumHonor objects.</returns>
		public TList<EntPolicyAccumHonor> GetByGsCdeHonorId(System.Decimal? _gsCdeHonorId)
		{
			int count = -1;
			return GetByGsCdeHonorId(_gsCdeHonorId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ACCUM_HONOR_GS_CDE_HONOR key.
		///		FK_ENT_POLICY_ACCUM_HONOR_GS_CDE_HONOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeHonorId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAccumHonor objects.</returns>
		/// <remarks></remarks>
		public TList<EntPolicyAccumHonor> GetByGsCdeHonorId(TransactionManager transactionManager, System.Decimal? _gsCdeHonorId)
		{
			int count = -1;
			return GetByGsCdeHonorId(transactionManager, _gsCdeHonorId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ACCUM_HONOR_GS_CDE_HONOR key.
		///		FK_ENT_POLICY_ACCUM_HONOR_GS_CDE_HONOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeHonorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAccumHonor objects.</returns>
		public TList<EntPolicyAccumHonor> GetByGsCdeHonorId(TransactionManager transactionManager, System.Decimal? _gsCdeHonorId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeHonorId(transactionManager, _gsCdeHonorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ACCUM_HONOR_GS_CDE_HONOR key.
		///		fkEntPolicyAccumHonorGsCdeHonor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeHonorId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAccumHonor objects.</returns>
		public TList<EntPolicyAccumHonor> GetByGsCdeHonorId(System.Decimal? _gsCdeHonorId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeHonorId(null, _gsCdeHonorId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ACCUM_HONOR_GS_CDE_HONOR key.
		///		fkEntPolicyAccumHonorGsCdeHonor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeHonorId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAccumHonor objects.</returns>
		public TList<EntPolicyAccumHonor> GetByGsCdeHonorId(System.Decimal? _gsCdeHonorId, int start, int pageLength,out int count)
		{
			return GetByGsCdeHonorId(null, _gsCdeHonorId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ACCUM_HONOR_GS_CDE_HONOR key.
		///		FK_ENT_POLICY_ACCUM_HONOR_GS_CDE_HONOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeHonorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAccumHonor objects.</returns>
		public abstract TList<EntPolicyAccumHonor> GetByGsCdeHonorId(TransactionManager transactionManager, System.Decimal? _gsCdeHonorId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EntPolicyAccumHonor Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyAccumHonorKey key, int start, int pageLength)
		{
			return GetByEntPolicyAccumHonorId(transactionManager, key.EntPolicyAccumHonorId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_MIN_LVL_GRADE_ID_1 index.
		/// </summary>
		/// <param name="_minLvlGradeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyAccumHonor&gt;"/> class.</returns>
		public TList<EntPolicyAccumHonor> GetByMinLvlGradeId(System.Decimal? _minLvlGradeId)
		{
			int count = -1;
			return GetByMinLvlGradeId(null,_minLvlGradeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_MIN_LVL_GRADE_ID_1 index.
		/// </summary>
		/// <param name="_minLvlGradeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyAccumHonor&gt;"/> class.</returns>
		public TList<EntPolicyAccumHonor> GetByMinLvlGradeId(System.Decimal? _minLvlGradeId, int start, int pageLength)
		{
			int count = -1;
			return GetByMinLvlGradeId(null, _minLvlGradeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_MIN_LVL_GRADE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_minLvlGradeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyAccumHonor&gt;"/> class.</returns>
		public TList<EntPolicyAccumHonor> GetByMinLvlGradeId(TransactionManager transactionManager, System.Decimal? _minLvlGradeId)
		{
			int count = -1;
			return GetByMinLvlGradeId(transactionManager, _minLvlGradeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_MIN_LVL_GRADE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_minLvlGradeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyAccumHonor&gt;"/> class.</returns>
		public TList<EntPolicyAccumHonor> GetByMinLvlGradeId(TransactionManager transactionManager, System.Decimal? _minLvlGradeId, int start, int pageLength)
		{
			int count = -1;
			return GetByMinLvlGradeId(transactionManager, _minLvlGradeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_MIN_LVL_GRADE_ID_1 index.
		/// </summary>
		/// <param name="_minLvlGradeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyAccumHonor&gt;"/> class.</returns>
		public TList<EntPolicyAccumHonor> GetByMinLvlGradeId(System.Decimal? _minLvlGradeId, int start, int pageLength, out int count)
		{
			return GetByMinLvlGradeId(null, _minLvlGradeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_MIN_LVL_GRADE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_minLvlGradeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyAccumHonor&gt;"/> class.</returns>
		public abstract TList<EntPolicyAccumHonor> GetByMinLvlGradeId(TransactionManager transactionManager, System.Decimal? _minLvlGradeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_ACCUM_HONOR index.
		/// </summary>
		/// <param name="_entPolicyAccumHonorId">مراتب الشرف  التراكمية</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAccumHonor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAccumHonor GetByEntPolicyAccumHonorId(System.Decimal _entPolicyAccumHonorId)
		{
			int count = -1;
			return GetByEntPolicyAccumHonorId(null,_entPolicyAccumHonorId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_ACCUM_HONOR index.
		/// </summary>
		/// <param name="_entPolicyAccumHonorId">مراتب الشرف  التراكمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAccumHonor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAccumHonor GetByEntPolicyAccumHonorId(System.Decimal _entPolicyAccumHonorId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyAccumHonorId(null, _entPolicyAccumHonorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_ACCUM_HONOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAccumHonorId">مراتب الشرف  التراكمية</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAccumHonor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAccumHonor GetByEntPolicyAccumHonorId(TransactionManager transactionManager, System.Decimal _entPolicyAccumHonorId)
		{
			int count = -1;
			return GetByEntPolicyAccumHonorId(transactionManager, _entPolicyAccumHonorId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_ACCUM_HONOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAccumHonorId">مراتب الشرف  التراكمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAccumHonor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAccumHonor GetByEntPolicyAccumHonorId(TransactionManager transactionManager, System.Decimal _entPolicyAccumHonorId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyAccumHonorId(transactionManager, _entPolicyAccumHonorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_ACCUM_HONOR index.
		/// </summary>
		/// <param name="_entPolicyAccumHonorId">مراتب الشرف  التراكمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAccumHonor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAccumHonor GetByEntPolicyAccumHonorId(System.Decimal _entPolicyAccumHonorId, int start, int pageLength, out int count)
		{
			return GetByEntPolicyAccumHonorId(null, _entPolicyAccumHonorId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_ACCUM_HONOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAccumHonorId">مراتب الشرف  التراكمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAccumHonor"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPolicyAccumHonor GetByEntPolicyAccumHonorId(TransactionManager transactionManager, System.Decimal _entPolicyAccumHonorId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ENT_POLICY_ACCUM_HONOR index.
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <param name="_gsCdeHonorId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAccumHonor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAccumHonor GetByEdBylawIdGsCdeHonorId(System.Decimal? _edBylawId, System.Decimal? _gsCdeHonorId)
		{
			int count = -1;
			return GetByEdBylawIdGsCdeHonorId(null,_edBylawId, _gsCdeHonorId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_ACCUM_HONOR index.
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <param name="_gsCdeHonorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAccumHonor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAccumHonor GetByEdBylawIdGsCdeHonorId(System.Decimal? _edBylawId, System.Decimal? _gsCdeHonorId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBylawIdGsCdeHonorId(null, _edBylawId, _gsCdeHonorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_ACCUM_HONOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="_gsCdeHonorId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAccumHonor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAccumHonor GetByEdBylawIdGsCdeHonorId(TransactionManager transactionManager, System.Decimal? _edBylawId, System.Decimal? _gsCdeHonorId)
		{
			int count = -1;
			return GetByEdBylawIdGsCdeHonorId(transactionManager, _edBylawId, _gsCdeHonorId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_ACCUM_HONOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="_gsCdeHonorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAccumHonor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAccumHonor GetByEdBylawIdGsCdeHonorId(TransactionManager transactionManager, System.Decimal? _edBylawId, System.Decimal? _gsCdeHonorId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBylawIdGsCdeHonorId(transactionManager, _edBylawId, _gsCdeHonorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_ACCUM_HONOR index.
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <param name="_gsCdeHonorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAccumHonor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAccumHonor GetByEdBylawIdGsCdeHonorId(System.Decimal? _edBylawId, System.Decimal? _gsCdeHonorId, int start, int pageLength, out int count)
		{
			return GetByEdBylawIdGsCdeHonorId(null, _edBylawId, _gsCdeHonorId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_ACCUM_HONOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="_gsCdeHonorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAccumHonor"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPolicyAccumHonor GetByEdBylawIdGsCdeHonorId(TransactionManager transactionManager, System.Decimal? _edBylawId, System.Decimal? _gsCdeHonorId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntPolicyAccumHonor&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntPolicyAccumHonor&gt;"/></returns>
		public static TList<EntPolicyAccumHonor> Fill(IDataReader reader, TList<EntPolicyAccumHonor> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntPolicyAccumHonor c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntPolicyAccumHonor")
					.Append("|").Append((System.Decimal)reader["ENT_POLICY_ACCUM_HONOR_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntPolicyAccumHonor>(
					key.ToString(), // EntityTrackingKey
					"EntPolicyAccumHonor",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntPolicyAccumHonor();
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
					c.EntPolicyAccumHonorId = (System.Decimal)reader["ENT_POLICY_ACCUM_HONOR_ID"];
					c.OriginalEntPolicyAccumHonorId = c.EntPolicyAccumHonorId;
					c.GsCdeHonorId = Convert.IsDBNull(reader["GS_CDE_HONOR_ID"]) ? null : (System.Decimal?)reader["GS_CDE_HONOR_ID"];
					c.AllowSubjFailure = Convert.IsDBNull(reader["ALLOW_SUBJ_FAILURE"]) ? null : (System.Decimal?)reader["ALLOW_SUBJ_FAILURE"];
					c.MaxNoYears = Convert.IsDBNull(reader["MAX_NO_YEARS"]) ? null : (System.Decimal?)reader["MAX_NO_YEARS"];
					c.GpaPointFrm = Convert.IsDBNull(reader["GPA_POINT_FRM"]) ? null : (System.Decimal?)reader["GPA_POINT_FRM"];
					c.GpaPointTo = Convert.IsDBNull(reader["GPA_POINT_TO"]) ? null : (System.Decimal?)reader["GPA_POINT_TO"];
					c.MinLvlGradeId = Convert.IsDBNull(reader["MIN_LVL_GRADE_ID"]) ? null : (System.Decimal?)reader["MIN_LVL_GRADE_ID"];
					c.MinLvlRate = Convert.IsDBNull(reader["MIN_LVL_RATE"]) ? null : (System.Decimal?)reader["MIN_LVL_RATE"];
					c.ActivityHourFlg = Convert.IsDBNull(reader["ACTIVITY_HOUR_FLG"]) ? null : (System.Decimal?)reader["ACTIVITY_HOUR_FLG"];
					c.CourseRepeatFlg = Convert.IsDBNull(reader["COURSE_REPEAT_FLG"]) ? null : (System.Boolean?)reader["COURSE_REPEAT_FLG"];
					c.PenltyFlg = Convert.IsDBNull(reader["PENLTY_FLG"]) ? null : (System.Boolean?)reader["PENLTY_FLG"];
					c.EdBylawId = Convert.IsDBNull(reader["ED_BYLAW_ID"]) ? null : (System.Decimal?)reader["ED_BYLAW_ID"];
					c.NoRaiseFlg = Convert.IsDBNull(reader["NO_RAISE_FLG"]) ? null : (System.Boolean?)reader["NO_RAISE_FLG"];
					c.ExcludeFrstYearFlg = Convert.IsDBNull(reader["EXCLUDE_FRST_YEAR_FLG"]) ? null : (System.Boolean?)reader["EXCLUDE_FRST_YEAR_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAccumHonor"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyAccumHonor"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntPolicyAccumHonor entity)
		{
			if (!reader.Read()) return;
			
			entity.EntPolicyAccumHonorId = (System.Decimal)reader[((int)EntPolicyAccumHonorColumn.EntPolicyAccumHonorId - 1)];
			entity.OriginalEntPolicyAccumHonorId = (System.Decimal)reader["ENT_POLICY_ACCUM_HONOR_ID"];
			entity.GsCdeHonorId = (reader.IsDBNull(((int)EntPolicyAccumHonorColumn.GsCdeHonorId - 1)))?null:(System.Decimal?)reader[((int)EntPolicyAccumHonorColumn.GsCdeHonorId - 1)];
			entity.AllowSubjFailure = (reader.IsDBNull(((int)EntPolicyAccumHonorColumn.AllowSubjFailure - 1)))?null:(System.Decimal?)reader[((int)EntPolicyAccumHonorColumn.AllowSubjFailure - 1)];
			entity.MaxNoYears = (reader.IsDBNull(((int)EntPolicyAccumHonorColumn.MaxNoYears - 1)))?null:(System.Decimal?)reader[((int)EntPolicyAccumHonorColumn.MaxNoYears - 1)];
			entity.GpaPointFrm = (reader.IsDBNull(((int)EntPolicyAccumHonorColumn.GpaPointFrm - 1)))?null:(System.Decimal?)reader[((int)EntPolicyAccumHonorColumn.GpaPointFrm - 1)];
			entity.GpaPointTo = (reader.IsDBNull(((int)EntPolicyAccumHonorColumn.GpaPointTo - 1)))?null:(System.Decimal?)reader[((int)EntPolicyAccumHonorColumn.GpaPointTo - 1)];
			entity.MinLvlGradeId = (reader.IsDBNull(((int)EntPolicyAccumHonorColumn.MinLvlGradeId - 1)))?null:(System.Decimal?)reader[((int)EntPolicyAccumHonorColumn.MinLvlGradeId - 1)];
			entity.MinLvlRate = (reader.IsDBNull(((int)EntPolicyAccumHonorColumn.MinLvlRate - 1)))?null:(System.Decimal?)reader[((int)EntPolicyAccumHonorColumn.MinLvlRate - 1)];
			entity.ActivityHourFlg = (reader.IsDBNull(((int)EntPolicyAccumHonorColumn.ActivityHourFlg - 1)))?null:(System.Decimal?)reader[((int)EntPolicyAccumHonorColumn.ActivityHourFlg - 1)];
			entity.CourseRepeatFlg = (reader.IsDBNull(((int)EntPolicyAccumHonorColumn.CourseRepeatFlg - 1)))?null:(System.Boolean?)reader[((int)EntPolicyAccumHonorColumn.CourseRepeatFlg - 1)];
			entity.PenltyFlg = (reader.IsDBNull(((int)EntPolicyAccumHonorColumn.PenltyFlg - 1)))?null:(System.Boolean?)reader[((int)EntPolicyAccumHonorColumn.PenltyFlg - 1)];
			entity.EdBylawId = (reader.IsDBNull(((int)EntPolicyAccumHonorColumn.EdBylawId - 1)))?null:(System.Decimal?)reader[((int)EntPolicyAccumHonorColumn.EdBylawId - 1)];
			entity.NoRaiseFlg = (reader.IsDBNull(((int)EntPolicyAccumHonorColumn.NoRaiseFlg - 1)))?null:(System.Boolean?)reader[((int)EntPolicyAccumHonorColumn.NoRaiseFlg - 1)];
			entity.ExcludeFrstYearFlg = (reader.IsDBNull(((int)EntPolicyAccumHonorColumn.ExcludeFrstYearFlg - 1)))?null:(System.Boolean?)reader[((int)EntPolicyAccumHonorColumn.ExcludeFrstYearFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAccumHonor"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyAccumHonor"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntPolicyAccumHonor entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntPolicyAccumHonorId = (System.Decimal)dataRow["ENT_POLICY_ACCUM_HONOR_ID"];
			entity.OriginalEntPolicyAccumHonorId = (System.Decimal)dataRow["ENT_POLICY_ACCUM_HONOR_ID"];
			entity.GsCdeHonorId = Convert.IsDBNull(dataRow["GS_CDE_HONOR_ID"]) ? null : (System.Decimal?)dataRow["GS_CDE_HONOR_ID"];
			entity.AllowSubjFailure = Convert.IsDBNull(dataRow["ALLOW_SUBJ_FAILURE"]) ? null : (System.Decimal?)dataRow["ALLOW_SUBJ_FAILURE"];
			entity.MaxNoYears = Convert.IsDBNull(dataRow["MAX_NO_YEARS"]) ? null : (System.Decimal?)dataRow["MAX_NO_YEARS"];
			entity.GpaPointFrm = Convert.IsDBNull(dataRow["GPA_POINT_FRM"]) ? null : (System.Decimal?)dataRow["GPA_POINT_FRM"];
			entity.GpaPointTo = Convert.IsDBNull(dataRow["GPA_POINT_TO"]) ? null : (System.Decimal?)dataRow["GPA_POINT_TO"];
			entity.MinLvlGradeId = Convert.IsDBNull(dataRow["MIN_LVL_GRADE_ID"]) ? null : (System.Decimal?)dataRow["MIN_LVL_GRADE_ID"];
			entity.MinLvlRate = Convert.IsDBNull(dataRow["MIN_LVL_RATE"]) ? null : (System.Decimal?)dataRow["MIN_LVL_RATE"];
			entity.ActivityHourFlg = Convert.IsDBNull(dataRow["ACTIVITY_HOUR_FLG"]) ? null : (System.Decimal?)dataRow["ACTIVITY_HOUR_FLG"];
			entity.CourseRepeatFlg = Convert.IsDBNull(dataRow["COURSE_REPEAT_FLG"]) ? null : (System.Boolean?)dataRow["COURSE_REPEAT_FLG"];
			entity.PenltyFlg = Convert.IsDBNull(dataRow["PENLTY_FLG"]) ? null : (System.Boolean?)dataRow["PENLTY_FLG"];
			entity.EdBylawId = Convert.IsDBNull(dataRow["ED_BYLAW_ID"]) ? null : (System.Decimal?)dataRow["ED_BYLAW_ID"];
			entity.NoRaiseFlg = Convert.IsDBNull(dataRow["NO_RAISE_FLG"]) ? null : (System.Boolean?)dataRow["NO_RAISE_FLG"];
			entity.ExcludeFrstYearFlg = Convert.IsDBNull(dataRow["EXCLUDE_FRST_YEAR_FLG"]) ? null : (System.Boolean?)dataRow["EXCLUDE_FRST_YEAR_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyAccumHonor"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolicyAccumHonor Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyAccumHonor entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region MinLvlGradeIdSource	
			if (CanDeepLoad(entity, "EdCodeGrading|MinLvlGradeIdSource", deepLoadType, innerList) 
				&& entity.MinLvlGradeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MinLvlGradeId ?? 0.0m);
				EdCodeGrading tmpEntity = EntityManager.LocateEntity<EdCodeGrading>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeGrading), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MinLvlGradeIdSource = tmpEntity;
				else
					entity.MinLvlGradeIdSource = DataRepository.EdCodeGradingProvider.GetByEdCodeGradingId(transactionManager, (entity.MinLvlGradeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MinLvlGradeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MinLvlGradeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeGradingProvider.DeepLoad(transactionManager, entity.MinLvlGradeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MinLvlGradeIdSource

			#region GsCdeHonorIdSource	
			if (CanDeepLoad(entity, "GsCdeHonor|GsCdeHonorIdSource", deepLoadType, innerList) 
				&& entity.GsCdeHonorIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCdeHonorId ?? 0.0m);
				GsCdeHonor tmpEntity = EntityManager.LocateEntity<GsCdeHonor>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeHonor), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeHonorIdSource = tmpEntity;
				else
					entity.GsCdeHonorIdSource = DataRepository.GsCdeHonorProvider.GetByGsCdeHonorId(transactionManager, (entity.GsCdeHonorId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeHonorIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeHonorIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeHonorProvider.DeepLoad(transactionManager, entity.GsCdeHonorIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeHonorIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEntPolicyAccumHonorId methods when available
			
			#region EdStudFacultyCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudFaculty>|EdStudFacultyCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudFacultyCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudFacultyCollection = DataRepository.EdStudFacultyProvider.GetByEntPolicyAccumHonorId(transactionManager, entity.EntPolicyAccumHonorId);

				if (deep && entity.EdStudFacultyCollection.Count > 0)
				{
					deepHandles.Add("EdStudFacultyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudFaculty>) DataRepository.EdStudFacultyProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudFacultyCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntPolicyAccumHonor object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntPolicyAccumHonor instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolicyAccumHonor Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyAccumHonor entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region MinLvlGradeIdSource
			if (CanDeepSave(entity, "EdCodeGrading|MinLvlGradeIdSource", deepSaveType, innerList) 
				&& entity.MinLvlGradeIdSource != null)
			{
				DataRepository.EdCodeGradingProvider.Save(transactionManager, entity.MinLvlGradeIdSource);
				entity.MinLvlGradeId = entity.MinLvlGradeIdSource.EdCodeGradingId;
			}
			#endregion 
			
			#region GsCdeHonorIdSource
			if (CanDeepSave(entity, "GsCdeHonor|GsCdeHonorIdSource", deepSaveType, innerList) 
				&& entity.GsCdeHonorIdSource != null)
			{
				DataRepository.GsCdeHonorProvider.Save(transactionManager, entity.GsCdeHonorIdSource);
				entity.GsCdeHonorId = entity.GsCdeHonorIdSource.GsCdeHonorId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EdStudFaculty>
				if (CanDeepSave(entity.EdStudFacultyCollection, "List<EdStudFaculty>|EdStudFacultyCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudFaculty child in entity.EdStudFacultyCollection)
					{
						if(child.EntPolicyAccumHonorIdSource != null)
						{
							child.EntPolicyAccumHonorId = child.EntPolicyAccumHonorIdSource.EntPolicyAccumHonorId;
						}
						else
						{
							child.EntPolicyAccumHonorId = entity.EntPolicyAccumHonorId;
						}

					}

					if (entity.EdStudFacultyCollection.Count > 0 || entity.EdStudFacultyCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudFacultyProvider.Save(transactionManager, entity.EdStudFacultyCollection);
						
						deepHandles.Add("EdStudFacultyCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudFaculty >) DataRepository.EdStudFacultyProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudFacultyCollection, deepSaveType, childTypes, innerList }
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
	
	#region EntPolicyAccumHonorChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntPolicyAccumHonor</c>
	///</summary>
	public enum EntPolicyAccumHonorChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdBylaw</c> at EdBylawIdSource
		///</summary>
		[ChildEntityType(typeof(EdBylaw))]
		EdBylaw,
		
		///<summary>
		/// Composite Property for <c>EdCodeGrading</c> at MinLvlGradeIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeGrading))]
		EdCodeGrading,
		
		///<summary>
		/// Composite Property for <c>GsCdeHonor</c> at GsCdeHonorIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeHonor))]
		GsCdeHonor,
		///<summary>
		/// Collection of <c>EntPolicyAccumHonor</c> as OneToMany for EdStudFacultyCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudFaculty>))]
		EdStudFacultyCollection,
	}
	
	#endregion EntPolicyAccumHonorChildEntityTypes
	
	#region EntPolicyAccumHonorFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntPolicyAccumHonorColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyAccumHonor"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolicyAccumHonorFilterBuilder : SqlFilterBuilder<EntPolicyAccumHonorColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyAccumHonorFilterBuilder class.
		/// </summary>
		public EntPolicyAccumHonorFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyAccumHonorFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolicyAccumHonorFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyAccumHonorFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolicyAccumHonorFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolicyAccumHonorFilterBuilder
	
	#region EntPolicyAccumHonorParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntPolicyAccumHonorColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyAccumHonor"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolicyAccumHonorParameterBuilder : ParameterizedSqlFilterBuilder<EntPolicyAccumHonorColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyAccumHonorParameterBuilder class.
		/// </summary>
		public EntPolicyAccumHonorParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyAccumHonorParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolicyAccumHonorParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyAccumHonorParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolicyAccumHonorParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolicyAccumHonorParameterBuilder
	
	#region EntPolicyAccumHonorSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntPolicyAccumHonorColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyAccumHonor"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntPolicyAccumHonorSortBuilder : SqlSortBuilder<EntPolicyAccumHonorColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyAccumHonorSqlSortBuilder class.
		/// </summary>
		public EntPolicyAccumHonorSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntPolicyAccumHonorSortBuilder
	
} // end namespace
