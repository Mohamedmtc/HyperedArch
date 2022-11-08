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
	/// This class is the base class for any <see cref="SvStudStaffEvalProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvStudStaffEvalProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvStudStaffEval, UMIS_VER2.BusinessLyer.SvStudStaffEvalKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStudStaffEvalKey key)
		{
			return Delete(transactionManager, key.SvStudStaffEvalId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svStudStaffEvalId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _svStudStaffEvalId)
		{
			return Delete(null, _svStudStaffEvalId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStudStaffEvalId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _svStudStaffEvalId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_ED_STUD key.
		///		FK_SV_STUD_STAFF_EVAL_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId">فى حالة STUD_STAFF_FLG=2</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEval objects.</returns>
		public TList<SvStudStaffEval> GetByEdStudId(System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_ED_STUD key.
		///		FK_SV_STUD_STAFF_EVAL_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">فى حالة STUD_STAFF_FLG=2</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEval objects.</returns>
		/// <remarks></remarks>
		public TList<SvStudStaffEval> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_ED_STUD key.
		///		FK_SV_STUD_STAFF_EVAL_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">فى حالة STUD_STAFF_FLG=2</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEval objects.</returns>
		public TList<SvStudStaffEval> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_ED_STUD key.
		///		fkSvStudStaffEvalEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">فى حالة STUD_STAFF_FLG=2</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEval objects.</returns>
		public TList<SvStudStaffEval> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_ED_STUD key.
		///		fkSvStudStaffEvalEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">فى حالة STUD_STAFF_FLG=2</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEval objects.</returns>
		public TList<SvStudStaffEval> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_ED_STUD key.
		///		FK_SV_STUD_STAFF_EVAL_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">فى حالة STUD_STAFF_FLG=2</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEval objects.</returns>
		public abstract TList<SvStudStaffEval> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_SA_STF_MEMBER key.
		///		FK_SV_STUD_STAFF_EVAL_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEval objects.</returns>
		public TList<SvStudStaffEval> GetBySaStfMemberId(System.Decimal? _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_SA_STF_MEMBER key.
		///		FK_SV_STUD_STAFF_EVAL_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEval objects.</returns>
		/// <remarks></remarks>
		public TList<SvStudStaffEval> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_SA_STF_MEMBER key.
		///		FK_SV_STUD_STAFF_EVAL_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEval objects.</returns>
		public TList<SvStudStaffEval> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_SA_STF_MEMBER key.
		///		fkSvStudStaffEvalSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEval objects.</returns>
		public TList<SvStudStaffEval> GetBySaStfMemberId(System.Decimal? _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_SA_STF_MEMBER key.
		///		fkSvStudStaffEvalSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEval objects.</returns>
		public TList<SvStudStaffEval> GetBySaStfMemberId(System.Decimal? _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_SA_STF_MEMBER key.
		///		FK_SV_STUD_STAFF_EVAL_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEval objects.</returns>
		public abstract TList<SvStudStaffEval> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_SV_CODE_RATING_SCHM_DTL key.
		///		FK_SV_STUD_STAFF_EVAL_SV_CODE_RATING_SCHM_DTL Description: 
		/// </summary>
		/// <param name="_svCodeRatingSchmDtlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEval objects.</returns>
		public TList<SvStudStaffEval> GetBySvCodeRatingSchmDtlId(System.Decimal _svCodeRatingSchmDtlId)
		{
			int count = -1;
			return GetBySvCodeRatingSchmDtlId(_svCodeRatingSchmDtlId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_SV_CODE_RATING_SCHM_DTL key.
		///		FK_SV_STUD_STAFF_EVAL_SV_CODE_RATING_SCHM_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeRatingSchmDtlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEval objects.</returns>
		/// <remarks></remarks>
		public TList<SvStudStaffEval> GetBySvCodeRatingSchmDtlId(TransactionManager transactionManager, System.Decimal _svCodeRatingSchmDtlId)
		{
			int count = -1;
			return GetBySvCodeRatingSchmDtlId(transactionManager, _svCodeRatingSchmDtlId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_SV_CODE_RATING_SCHM_DTL key.
		///		FK_SV_STUD_STAFF_EVAL_SV_CODE_RATING_SCHM_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeRatingSchmDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEval objects.</returns>
		public TList<SvStudStaffEval> GetBySvCodeRatingSchmDtlId(TransactionManager transactionManager, System.Decimal _svCodeRatingSchmDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCodeRatingSchmDtlId(transactionManager, _svCodeRatingSchmDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_SV_CODE_RATING_SCHM_DTL key.
		///		fkSvStudStaffEvalSvCodeRatingSchmDtl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCodeRatingSchmDtlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEval objects.</returns>
		public TList<SvStudStaffEval> GetBySvCodeRatingSchmDtlId(System.Decimal _svCodeRatingSchmDtlId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySvCodeRatingSchmDtlId(null, _svCodeRatingSchmDtlId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_SV_CODE_RATING_SCHM_DTL key.
		///		fkSvStudStaffEvalSvCodeRatingSchmDtl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCodeRatingSchmDtlId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEval objects.</returns>
		public TList<SvStudStaffEval> GetBySvCodeRatingSchmDtlId(System.Decimal _svCodeRatingSchmDtlId, int start, int pageLength,out int count)
		{
			return GetBySvCodeRatingSchmDtlId(null, _svCodeRatingSchmDtlId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_SV_CODE_RATING_SCHM_DTL key.
		///		FK_SV_STUD_STAFF_EVAL_SV_CODE_RATING_SCHM_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCodeRatingSchmDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEval objects.</returns>
		public abstract TList<SvStudStaffEval> GetBySvCodeRatingSchmDtlId(TransactionManager transactionManager, System.Decimal _svCodeRatingSchmDtlId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_SV_STAFF_EVAL_ITEM key.
		///		FK_SV_STUD_STAFF_EVAL_SV_STAFF_EVAL_ITEM Description: 
		/// </summary>
		/// <param name="_svStaffEvalItemId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEval objects.</returns>
		public TList<SvStudStaffEval> GetBySvStaffEvalItemId(System.Decimal _svStaffEvalItemId)
		{
			int count = -1;
			return GetBySvStaffEvalItemId(_svStaffEvalItemId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_SV_STAFF_EVAL_ITEM key.
		///		FK_SV_STUD_STAFF_EVAL_SV_STAFF_EVAL_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStaffEvalItemId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEval objects.</returns>
		/// <remarks></remarks>
		public TList<SvStudStaffEval> GetBySvStaffEvalItemId(TransactionManager transactionManager, System.Decimal _svStaffEvalItemId)
		{
			int count = -1;
			return GetBySvStaffEvalItemId(transactionManager, _svStaffEvalItemId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_SV_STAFF_EVAL_ITEM key.
		///		FK_SV_STUD_STAFF_EVAL_SV_STAFF_EVAL_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStaffEvalItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEval objects.</returns>
		public TList<SvStudStaffEval> GetBySvStaffEvalItemId(TransactionManager transactionManager, System.Decimal _svStaffEvalItemId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvStaffEvalItemId(transactionManager, _svStaffEvalItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_SV_STAFF_EVAL_ITEM key.
		///		fkSvStudStaffEvalSvStaffEvalItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svStaffEvalItemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEval objects.</returns>
		public TList<SvStudStaffEval> GetBySvStaffEvalItemId(System.Decimal _svStaffEvalItemId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySvStaffEvalItemId(null, _svStaffEvalItemId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_SV_STAFF_EVAL_ITEM key.
		///		fkSvStudStaffEvalSvStaffEvalItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svStaffEvalItemId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEval objects.</returns>
		public TList<SvStudStaffEval> GetBySvStaffEvalItemId(System.Decimal _svStaffEvalItemId, int start, int pageLength,out int count)
		{
			return GetBySvStaffEvalItemId(null, _svStaffEvalItemId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_SV_STAFF_EVAL_ITEM key.
		///		FK_SV_STUD_STAFF_EVAL_SV_STAFF_EVAL_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStaffEvalItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEval objects.</returns>
		public abstract TList<SvStudStaffEval> GetBySvStaffEvalItemId(TransactionManager transactionManager, System.Decimal _svStaffEvalItemId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SvStudStaffEval Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStudStaffEvalKey key, int start, int pageLength)
		{
			return GetBySvStudStaffEvalId(transactionManager, key.SvStudStaffEvalId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_STUD_STAFF_EVAL index.
		/// </summary>
		/// <param name="_svStudStaffEvalId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudStaffEval"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudStaffEval GetBySvStudStaffEvalId(System.Decimal _svStudStaffEvalId)
		{
			int count = -1;
			return GetBySvStudStaffEvalId(null,_svStudStaffEvalId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_STAFF_EVAL index.
		/// </summary>
		/// <param name="_svStudStaffEvalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudStaffEval"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudStaffEval GetBySvStudStaffEvalId(System.Decimal _svStudStaffEvalId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvStudStaffEvalId(null, _svStudStaffEvalId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_STAFF_EVAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStudStaffEvalId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudStaffEval"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudStaffEval GetBySvStudStaffEvalId(TransactionManager transactionManager, System.Decimal _svStudStaffEvalId)
		{
			int count = -1;
			return GetBySvStudStaffEvalId(transactionManager, _svStudStaffEvalId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_STAFF_EVAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStudStaffEvalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudStaffEval"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudStaffEval GetBySvStudStaffEvalId(TransactionManager transactionManager, System.Decimal _svStudStaffEvalId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvStudStaffEvalId(transactionManager, _svStudStaffEvalId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_STAFF_EVAL index.
		/// </summary>
		/// <param name="_svStudStaffEvalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudStaffEval"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudStaffEval GetBySvStudStaffEvalId(System.Decimal _svStudStaffEvalId, int start, int pageLength, out int count)
		{
			return GetBySvStudStaffEvalId(null, _svStudStaffEvalId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_STAFF_EVAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStudStaffEvalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudStaffEval"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvStudStaffEval GetBySvStudStaffEvalId(TransactionManager transactionManager, System.Decimal _svStudStaffEvalId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvStudStaffEval&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvStudStaffEval&gt;"/></returns>
		public static TList<SvStudStaffEval> Fill(IDataReader reader, TList<SvStudStaffEval> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvStudStaffEval c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvStudStaffEval")
					.Append("|").Append((System.Decimal)reader["SV_STUD_STAFF_EVAL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvStudStaffEval>(
					key.ToString(), // EntityTrackingKey
					"SvStudStaffEval",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvStudStaffEval();
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
					c.SvStudStaffEvalId = (System.Decimal)reader["SV_STUD_STAFF_EVAL_ID"];
					c.OriginalSvStudStaffEvalId = c.SvStudStaffEvalId;
					c.EdStudId = Convert.IsDBNull(reader["ED_STUD_ID"]) ? null : (System.Decimal?)reader["ED_STUD_ID"];
					c.SaStfMemberId = Convert.IsDBNull(reader["SA_STF_MEMBER_ID"]) ? null : (System.Decimal?)reader["SA_STF_MEMBER_ID"];
					c.SvStaffEvalItemId = (System.Decimal)reader["SV_STAFF_EVAL_ITEM_ID"];
					c.SvCodeRatingSchmDtlId = (System.Decimal)reader["SV_CODE_RATING_SCHM_DTL_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvStudStaffEval"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvStudStaffEval"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvStudStaffEval entity)
		{
			if (!reader.Read()) return;
			
			entity.SvStudStaffEvalId = (System.Decimal)reader[((int)SvStudStaffEvalColumn.SvStudStaffEvalId - 1)];
			entity.OriginalSvStudStaffEvalId = (System.Decimal)reader["SV_STUD_STAFF_EVAL_ID"];
			entity.EdStudId = (reader.IsDBNull(((int)SvStudStaffEvalColumn.EdStudId - 1)))?null:(System.Decimal?)reader[((int)SvStudStaffEvalColumn.EdStudId - 1)];
			entity.SaStfMemberId = (reader.IsDBNull(((int)SvStudStaffEvalColumn.SaStfMemberId - 1)))?null:(System.Decimal?)reader[((int)SvStudStaffEvalColumn.SaStfMemberId - 1)];
			entity.SvStaffEvalItemId = (System.Decimal)reader[((int)SvStudStaffEvalColumn.SvStaffEvalItemId - 1)];
			entity.SvCodeRatingSchmDtlId = (System.Decimal)reader[((int)SvStudStaffEvalColumn.SvCodeRatingSchmDtlId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvStudStaffEval"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvStudStaffEval"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvStudStaffEval entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvStudStaffEvalId = (System.Decimal)dataRow["SV_STUD_STAFF_EVAL_ID"];
			entity.OriginalSvStudStaffEvalId = (System.Decimal)dataRow["SV_STUD_STAFF_EVAL_ID"];
			entity.EdStudId = Convert.IsDBNull(dataRow["ED_STUD_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_ID"];
			entity.SaStfMemberId = Convert.IsDBNull(dataRow["SA_STF_MEMBER_ID"]) ? null : (System.Decimal?)dataRow["SA_STF_MEMBER_ID"];
			entity.SvStaffEvalItemId = (System.Decimal)dataRow["SV_STAFF_EVAL_ITEM_ID"];
			entity.SvCodeRatingSchmDtlId = (System.Decimal)dataRow["SV_CODE_RATING_SCHM_DTL_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvStudStaffEval"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvStudStaffEval Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStudStaffEval entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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

			#region SvCodeRatingSchmDtlIdSource	
			if (CanDeepLoad(entity, "SvCodeRatingSchmDtl|SvCodeRatingSchmDtlIdSource", deepLoadType, innerList) 
				&& entity.SvCodeRatingSchmDtlIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SvCodeRatingSchmDtlId;
				SvCodeRatingSchmDtl tmpEntity = EntityManager.LocateEntity<SvCodeRatingSchmDtl>(EntityLocator.ConstructKeyFromPkItems(typeof(SvCodeRatingSchmDtl), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvCodeRatingSchmDtlIdSource = tmpEntity;
				else
					entity.SvCodeRatingSchmDtlIdSource = DataRepository.SvCodeRatingSchmDtlProvider.GetBySvCodeRatingSchmDtlId(transactionManager, entity.SvCodeRatingSchmDtlId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCodeRatingSchmDtlIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvCodeRatingSchmDtlIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvCodeRatingSchmDtlProvider.DeepLoad(transactionManager, entity.SvCodeRatingSchmDtlIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvCodeRatingSchmDtlIdSource

			#region SvStaffEvalItemIdSource	
			if (CanDeepLoad(entity, "SvStaffEvalItem|SvStaffEvalItemIdSource", deepLoadType, innerList) 
				&& entity.SvStaffEvalItemIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SvStaffEvalItemId;
				SvStaffEvalItem tmpEntity = EntityManager.LocateEntity<SvStaffEvalItem>(EntityLocator.ConstructKeyFromPkItems(typeof(SvStaffEvalItem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvStaffEvalItemIdSource = tmpEntity;
				else
					entity.SvStaffEvalItemIdSource = DataRepository.SvStaffEvalItemProvider.GetBySvStaffEvalItemId(transactionManager, entity.SvStaffEvalItemId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStaffEvalItemIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvStaffEvalItemIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvStaffEvalItemProvider.DeepLoad(transactionManager, entity.SvStaffEvalItemIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvStaffEvalItemIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvStudStaffEval object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvStudStaffEval instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvStudStaffEval Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStudStaffEval entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
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
			
			#region SvCodeRatingSchmDtlIdSource
			if (CanDeepSave(entity, "SvCodeRatingSchmDtl|SvCodeRatingSchmDtlIdSource", deepSaveType, innerList) 
				&& entity.SvCodeRatingSchmDtlIdSource != null)
			{
				DataRepository.SvCodeRatingSchmDtlProvider.Save(transactionManager, entity.SvCodeRatingSchmDtlIdSource);
				entity.SvCodeRatingSchmDtlId = entity.SvCodeRatingSchmDtlIdSource.SvCodeRatingSchmDtlId;
			}
			#endregion 
			
			#region SvStaffEvalItemIdSource
			if (CanDeepSave(entity, "SvStaffEvalItem|SvStaffEvalItemIdSource", deepSaveType, innerList) 
				&& entity.SvStaffEvalItemIdSource != null)
			{
				DataRepository.SvStaffEvalItemProvider.Save(transactionManager, entity.SvStaffEvalItemIdSource);
				entity.SvStaffEvalItemId = entity.SvStaffEvalItemIdSource.SvStaffEvalItemId;
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
	
	#region SvStudStaffEvalChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvStudStaffEval</c>
	///</summary>
	public enum SvStudStaffEvalChildEntityTypes
	{
		
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
		/// Composite Property for <c>SvCodeRatingSchmDtl</c> at SvCodeRatingSchmDtlIdSource
		///</summary>
		[ChildEntityType(typeof(SvCodeRatingSchmDtl))]
		SvCodeRatingSchmDtl,
		
		///<summary>
		/// Composite Property for <c>SvStaffEvalItem</c> at SvStaffEvalItemIdSource
		///</summary>
		[ChildEntityType(typeof(SvStaffEvalItem))]
		SvStaffEvalItem,
	}
	
	#endregion SvStudStaffEvalChildEntityTypes
	
	#region SvStudStaffEvalFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvStudStaffEvalColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvStudStaffEval"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvStudStaffEvalFilterBuilder : SqlFilterBuilder<SvStudStaffEvalColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvStudStaffEvalFilterBuilder class.
		/// </summary>
		public SvStudStaffEvalFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvStudStaffEvalFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvStudStaffEvalFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvStudStaffEvalFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvStudStaffEvalFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvStudStaffEvalFilterBuilder
	
	#region SvStudStaffEvalParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvStudStaffEvalColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvStudStaffEval"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvStudStaffEvalParameterBuilder : ParameterizedSqlFilterBuilder<SvStudStaffEvalColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvStudStaffEvalParameterBuilder class.
		/// </summary>
		public SvStudStaffEvalParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvStudStaffEvalParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvStudStaffEvalParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvStudStaffEvalParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvStudStaffEvalParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvStudStaffEvalParameterBuilder
	
	#region SvStudStaffEvalSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvStudStaffEvalColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvStudStaffEval"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvStudStaffEvalSortBuilder : SqlSortBuilder<SvStudStaffEvalColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvStudStaffEvalSqlSortBuilder class.
		/// </summary>
		public SvStudStaffEvalSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvStudStaffEvalSortBuilder
	
} // end namespace
