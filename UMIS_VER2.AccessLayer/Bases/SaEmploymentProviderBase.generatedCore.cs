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
	/// This class is the base class for any <see cref="SaEmploymentProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaEmploymentProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaEmployment, UMIS_VER2.BusinessLyer.SaEmploymentKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaEmploymentKey key)
		{
			return Delete(transactionManager, key.SaEmploymentId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saEmploymentId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saEmploymentId)
		{
			return Delete(null, _saEmploymentId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saEmploymentId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saEmploymentId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0015 key.
		///		FK_AUTO_0015 Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaEmployment objects.</returns>
		public TList<SaEmployment> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0015 key.
		///		FK_AUTO_0015 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaEmployment objects.</returns>
		/// <remarks></remarks>
		public TList<SaEmployment> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0015 key.
		///		FK_AUTO_0015 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaEmployment objects.</returns>
		public TList<SaEmployment> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0015 key.
		///		fkAuto0015 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaEmployment objects.</returns>
		public TList<SaEmployment> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0015 key.
		///		fkAuto0015 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaEmployment objects.</returns>
		public TList<SaEmployment> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0015 key.
		///		FK_AUTO_0015 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaEmployment objects.</returns>
		public abstract TList<SaEmployment> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0016 key.
		///		FK_AUTO_0016 Description: 
		/// </summary>
		/// <param name="_pgThesisGeneralSpecId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaEmployment objects.</returns>
		public TList<SaEmployment> GetByPgThesisGeneralSpecId(System.Decimal? _pgThesisGeneralSpecId)
		{
			int count = -1;
			return GetByPgThesisGeneralSpecId(_pgThesisGeneralSpecId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0016 key.
		///		FK_AUTO_0016 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisGeneralSpecId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaEmployment objects.</returns>
		/// <remarks></remarks>
		public TList<SaEmployment> GetByPgThesisGeneralSpecId(TransactionManager transactionManager, System.Decimal? _pgThesisGeneralSpecId)
		{
			int count = -1;
			return GetByPgThesisGeneralSpecId(transactionManager, _pgThesisGeneralSpecId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0016 key.
		///		FK_AUTO_0016 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisGeneralSpecId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaEmployment objects.</returns>
		public TList<SaEmployment> GetByPgThesisGeneralSpecId(TransactionManager transactionManager, System.Decimal? _pgThesisGeneralSpecId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisGeneralSpecId(transactionManager, _pgThesisGeneralSpecId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0016 key.
		///		fkAuto0016 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisGeneralSpecId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaEmployment objects.</returns>
		public TList<SaEmployment> GetByPgThesisGeneralSpecId(System.Decimal? _pgThesisGeneralSpecId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisGeneralSpecId(null, _pgThesisGeneralSpecId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0016 key.
		///		fkAuto0016 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisGeneralSpecId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaEmployment objects.</returns>
		public TList<SaEmployment> GetByPgThesisGeneralSpecId(System.Decimal? _pgThesisGeneralSpecId, int start, int pageLength,out int count)
		{
			return GetByPgThesisGeneralSpecId(null, _pgThesisGeneralSpecId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0016 key.
		///		FK_AUTO_0016 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisGeneralSpecId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaEmployment objects.</returns>
		public abstract TList<SaEmployment> GetByPgThesisGeneralSpecId(TransactionManager transactionManager, System.Decimal? _pgThesisGeneralSpecId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0017 key.
		///		FK_AUTO_0017 Description: 
		/// </summary>
		/// <param name="_saScQualId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaEmployment objects.</returns>
		public TList<SaEmployment> GetBySaScQualId(System.Decimal? _saScQualId)
		{
			int count = -1;
			return GetBySaScQualId(_saScQualId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0017 key.
		///		FK_AUTO_0017 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saScQualId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaEmployment objects.</returns>
		/// <remarks></remarks>
		public TList<SaEmployment> GetBySaScQualId(TransactionManager transactionManager, System.Decimal? _saScQualId)
		{
			int count = -1;
			return GetBySaScQualId(transactionManager, _saScQualId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0017 key.
		///		FK_AUTO_0017 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saScQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaEmployment objects.</returns>
		public TList<SaEmployment> GetBySaScQualId(TransactionManager transactionManager, System.Decimal? _saScQualId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaScQualId(transactionManager, _saScQualId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0017 key.
		///		fkAuto0017 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saScQualId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaEmployment objects.</returns>
		public TList<SaEmployment> GetBySaScQualId(System.Decimal? _saScQualId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaScQualId(null, _saScQualId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0017 key.
		///		fkAuto0017 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saScQualId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaEmployment objects.</returns>
		public TList<SaEmployment> GetBySaScQualId(System.Decimal? _saScQualId, int start, int pageLength,out int count)
		{
			return GetBySaScQualId(null, _saScQualId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0017 key.
		///		FK_AUTO_0017 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saScQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaEmployment objects.</returns>
		public abstract TList<SaEmployment> GetBySaScQualId(TransactionManager transactionManager, System.Decimal? _saScQualId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0018 key.
		///		FK_AUTO_0018 Description: 
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaEmployment objects.</returns>
		public TList<SaEmployment> GetBySaStfMemberId(System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0018 key.
		///		FK_AUTO_0018 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaEmployment objects.</returns>
		/// <remarks></remarks>
		public TList<SaEmployment> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0018 key.
		///		FK_AUTO_0018 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaEmployment objects.</returns>
		public TList<SaEmployment> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0018 key.
		///		fkAuto0018 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaEmployment objects.</returns>
		public TList<SaEmployment> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0018 key.
		///		fkAuto0018 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaEmployment objects.</returns>
		public TList<SaEmployment> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0018 key.
		///		FK_AUTO_0018 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaEmployment objects.</returns>
		public abstract TList<SaEmployment> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SaEmployment Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaEmploymentKey key, int start, int pageLength)
		{
			return GetBySaEmploymentId(transactionManager, key.SaEmploymentId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_APPROVAL_H_ID_1 index.
		/// </summary>
		/// <param name="_gsApprovalHId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaEmployment&gt;"/> class.</returns>
		public TList<SaEmployment> GetByGsApprovalHId(System.Decimal? _gsApprovalHId)
		{
			int count = -1;
			return GetByGsApprovalHId(null,_gsApprovalHId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_APPROVAL_H_ID_1 index.
		/// </summary>
		/// <param name="_gsApprovalHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaEmployment&gt;"/> class.</returns>
		public TList<SaEmployment> GetByGsApprovalHId(System.Decimal? _gsApprovalHId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsApprovalHId(null, _gsApprovalHId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_APPROVAL_H_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsApprovalHId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaEmployment&gt;"/> class.</returns>
		public TList<SaEmployment> GetByGsApprovalHId(TransactionManager transactionManager, System.Decimal? _gsApprovalHId)
		{
			int count = -1;
			return GetByGsApprovalHId(transactionManager, _gsApprovalHId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_APPROVAL_H_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsApprovalHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaEmployment&gt;"/> class.</returns>
		public TList<SaEmployment> GetByGsApprovalHId(TransactionManager transactionManager, System.Decimal? _gsApprovalHId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsApprovalHId(transactionManager, _gsApprovalHId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_APPROVAL_H_ID_1 index.
		/// </summary>
		/// <param name="_gsApprovalHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaEmployment&gt;"/> class.</returns>
		public TList<SaEmployment> GetByGsApprovalHId(System.Decimal? _gsApprovalHId, int start, int pageLength, out int count)
		{
			return GetByGsApprovalHId(null, _gsApprovalHId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_APPROVAL_H_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsApprovalHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaEmployment&gt;"/> class.</returns>
		public abstract TList<SaEmployment> GetByGsApprovalHId(TransactionManager transactionManager, System.Decimal? _gsApprovalHId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_PG_THESIS_DETAILED_S_1 index.
		/// </summary>
		/// <param name="_pgThesisDetailedSpecId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaEmployment&gt;"/> class.</returns>
		public TList<SaEmployment> GetByPgThesisDetailedSpecId(System.Decimal? _pgThesisDetailedSpecId)
		{
			int count = -1;
			return GetByPgThesisDetailedSpecId(null,_pgThesisDetailedSpecId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_PG_THESIS_DETAILED_S_1 index.
		/// </summary>
		/// <param name="_pgThesisDetailedSpecId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaEmployment&gt;"/> class.</returns>
		public TList<SaEmployment> GetByPgThesisDetailedSpecId(System.Decimal? _pgThesisDetailedSpecId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisDetailedSpecId(null, _pgThesisDetailedSpecId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_PG_THESIS_DETAILED_S_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisDetailedSpecId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaEmployment&gt;"/> class.</returns>
		public TList<SaEmployment> GetByPgThesisDetailedSpecId(TransactionManager transactionManager, System.Decimal? _pgThesisDetailedSpecId)
		{
			int count = -1;
			return GetByPgThesisDetailedSpecId(transactionManager, _pgThesisDetailedSpecId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_PG_THESIS_DETAILED_S_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisDetailedSpecId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaEmployment&gt;"/> class.</returns>
		public TList<SaEmployment> GetByPgThesisDetailedSpecId(TransactionManager transactionManager, System.Decimal? _pgThesisDetailedSpecId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisDetailedSpecId(transactionManager, _pgThesisDetailedSpecId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_PG_THESIS_DETAILED_S_1 index.
		/// </summary>
		/// <param name="_pgThesisDetailedSpecId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaEmployment&gt;"/> class.</returns>
		public TList<SaEmployment> GetByPgThesisDetailedSpecId(System.Decimal? _pgThesisDetailedSpecId, int start, int pageLength, out int count)
		{
			return GetByPgThesisDetailedSpecId(null, _pgThesisDetailedSpecId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_PG_THESIS_DETAILED_S_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisDetailedSpecId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaEmployment&gt;"/> class.</returns>
		public abstract TList<SaEmployment> GetByPgThesisDetailedSpecId(TransactionManager transactionManager, System.Decimal? _pgThesisDetailedSpecId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SA_CODE_EMP_METHOD_I_1 index.
		/// </summary>
		/// <param name="_saCodeEmpMethodId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaEmployment&gt;"/> class.</returns>
		public TList<SaEmployment> GetBySaCodeEmpMethodId(System.Decimal _saCodeEmpMethodId)
		{
			int count = -1;
			return GetBySaCodeEmpMethodId(null,_saCodeEmpMethodId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_EMP_METHOD_I_1 index.
		/// </summary>
		/// <param name="_saCodeEmpMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaEmployment&gt;"/> class.</returns>
		public TList<SaEmployment> GetBySaCodeEmpMethodId(System.Decimal _saCodeEmpMethodId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeEmpMethodId(null, _saCodeEmpMethodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_EMP_METHOD_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeEmpMethodId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaEmployment&gt;"/> class.</returns>
		public TList<SaEmployment> GetBySaCodeEmpMethodId(TransactionManager transactionManager, System.Decimal _saCodeEmpMethodId)
		{
			int count = -1;
			return GetBySaCodeEmpMethodId(transactionManager, _saCodeEmpMethodId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_EMP_METHOD_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeEmpMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaEmployment&gt;"/> class.</returns>
		public TList<SaEmployment> GetBySaCodeEmpMethodId(TransactionManager transactionManager, System.Decimal _saCodeEmpMethodId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeEmpMethodId(transactionManager, _saCodeEmpMethodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_EMP_METHOD_I_1 index.
		/// </summary>
		/// <param name="_saCodeEmpMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaEmployment&gt;"/> class.</returns>
		public TList<SaEmployment> GetBySaCodeEmpMethodId(System.Decimal _saCodeEmpMethodId, int start, int pageLength, out int count)
		{
			return GetBySaCodeEmpMethodId(null, _saCodeEmpMethodId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_EMP_METHOD_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeEmpMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaEmployment&gt;"/> class.</returns>
		public abstract TList<SaEmployment> GetBySaCodeEmpMethodId(TransactionManager transactionManager, System.Decimal _saCodeEmpMethodId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SA_CODE_SC_DEG_ID_1 index.
		/// </summary>
		/// <param name="_saCodeScDegId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaEmployment&gt;"/> class.</returns>
		public TList<SaEmployment> GetBySaCodeScDegId(System.Decimal _saCodeScDegId)
		{
			int count = -1;
			return GetBySaCodeScDegId(null,_saCodeScDegId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_SC_DEG_ID_1 index.
		/// </summary>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaEmployment&gt;"/> class.</returns>
		public TList<SaEmployment> GetBySaCodeScDegId(System.Decimal _saCodeScDegId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeScDegId(null, _saCodeScDegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_SC_DEG_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaEmployment&gt;"/> class.</returns>
		public TList<SaEmployment> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal _saCodeScDegId)
		{
			int count = -1;
			return GetBySaCodeScDegId(transactionManager, _saCodeScDegId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_SC_DEG_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaEmployment&gt;"/> class.</returns>
		public TList<SaEmployment> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal _saCodeScDegId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeScDegId(transactionManager, _saCodeScDegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_SC_DEG_ID_1 index.
		/// </summary>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaEmployment&gt;"/> class.</returns>
		public TList<SaEmployment> GetBySaCodeScDegId(System.Decimal _saCodeScDegId, int start, int pageLength, out int count)
		{
			return GetBySaCodeScDegId(null, _saCodeScDegId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_SC_DEG_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaEmployment&gt;"/> class.</returns>
		public abstract TList<SaEmployment> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal _saCodeScDegId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SA_JOB_START_STATMEN_1 index.
		/// </summary>
		/// <param name="_saJobStartStatmentId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaEmployment&gt;"/> class.</returns>
		public TList<SaEmployment> GetBySaJobStartStatmentId(System.Decimal? _saJobStartStatmentId)
		{
			int count = -1;
			return GetBySaJobStartStatmentId(null,_saJobStartStatmentId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_JOB_START_STATMEN_1 index.
		/// </summary>
		/// <param name="_saJobStartStatmentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaEmployment&gt;"/> class.</returns>
		public TList<SaEmployment> GetBySaJobStartStatmentId(System.Decimal? _saJobStartStatmentId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaJobStartStatmentId(null, _saJobStartStatmentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_JOB_START_STATMEN_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saJobStartStatmentId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaEmployment&gt;"/> class.</returns>
		public TList<SaEmployment> GetBySaJobStartStatmentId(TransactionManager transactionManager, System.Decimal? _saJobStartStatmentId)
		{
			int count = -1;
			return GetBySaJobStartStatmentId(transactionManager, _saJobStartStatmentId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_JOB_START_STATMEN_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saJobStartStatmentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaEmployment&gt;"/> class.</returns>
		public TList<SaEmployment> GetBySaJobStartStatmentId(TransactionManager transactionManager, System.Decimal? _saJobStartStatmentId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaJobStartStatmentId(transactionManager, _saJobStartStatmentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_JOB_START_STATMEN_1 index.
		/// </summary>
		/// <param name="_saJobStartStatmentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaEmployment&gt;"/> class.</returns>
		public TList<SaEmployment> GetBySaJobStartStatmentId(System.Decimal? _saJobStartStatmentId, int start, int pageLength, out int count)
		{
			return GetBySaJobStartStatmentId(null, _saJobStartStatmentId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_JOB_START_STATMEN_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saJobStartStatmentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaEmployment&gt;"/> class.</returns>
		public abstract TList<SaEmployment> GetBySaJobStartStatmentId(TransactionManager transactionManager, System.Decimal? _saJobStartStatmentId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_EMPLOYMENT index.
		/// </summary>
		/// <param name="_saEmploymentId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaEmployment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaEmployment GetBySaEmploymentId(System.Decimal _saEmploymentId)
		{
			int count = -1;
			return GetBySaEmploymentId(null,_saEmploymentId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_EMPLOYMENT index.
		/// </summary>
		/// <param name="_saEmploymentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaEmployment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaEmployment GetBySaEmploymentId(System.Decimal _saEmploymentId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaEmploymentId(null, _saEmploymentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_EMPLOYMENT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saEmploymentId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaEmployment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaEmployment GetBySaEmploymentId(TransactionManager transactionManager, System.Decimal _saEmploymentId)
		{
			int count = -1;
			return GetBySaEmploymentId(transactionManager, _saEmploymentId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_EMPLOYMENT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saEmploymentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaEmployment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaEmployment GetBySaEmploymentId(TransactionManager transactionManager, System.Decimal _saEmploymentId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaEmploymentId(transactionManager, _saEmploymentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_EMPLOYMENT index.
		/// </summary>
		/// <param name="_saEmploymentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaEmployment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaEmployment GetBySaEmploymentId(System.Decimal _saEmploymentId, int start, int pageLength, out int count)
		{
			return GetBySaEmploymentId(null, _saEmploymentId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_EMPLOYMENT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saEmploymentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaEmployment"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaEmployment GetBySaEmploymentId(TransactionManager transactionManager, System.Decimal _saEmploymentId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaEmployment&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaEmployment&gt;"/></returns>
		public static TList<SaEmployment> Fill(IDataReader reader, TList<SaEmployment> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaEmployment c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaEmployment")
					.Append("|").Append((System.Decimal)reader["SA_EMPLOYMENT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaEmployment>(
					key.ToString(), // EntityTrackingKey
					"SaEmployment",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaEmployment();
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
					c.SaEmploymentId = (System.Decimal)reader["SA_EMPLOYMENT_ID"];
					c.OriginalSaEmploymentId = c.SaEmploymentId;
					c.DecisionNum = (System.String)reader["DECISION_NUM"];
					c.DecisionDate = (System.DateTime)reader["DECISION_DATE"];
					c.DecisionSumm = Convert.IsDBNull(reader["DECISION_SUMM"]) ? null : (System.String)reader["DECISION_SUMM"];
					c.AdvertNum = Convert.IsDBNull(reader["ADVERT_NUM"]) ? null : (System.String)reader["ADVERT_NUM"];
					c.AdvertDate = Convert.IsDBNull(reader["ADVERT_DATE"]) ? null : (System.DateTime?)reader["ADVERT_DATE"];
					c.ValidTilDate = Convert.IsDBNull(reader["VALID_TIL_DATE"]) ? null : (System.DateTime?)reader["VALID_TIL_DATE"];
					c.EmpDatePre = Convert.IsDBNull(reader["EMP_DATE_PRE"]) ? null : (System.DateTime?)reader["EMP_DATE_PRE"];
					c.InsuranceNum = Convert.IsDBNull(reader["INSURANCE_NUM"]) ? null : (System.String)reader["INSURANCE_NUM"];
					c.AllEmpIssuesDone = (System.Decimal)reader["ALL_EMP_ISSUES_DONE"];
					c.BasicSalary = (System.Decimal)reader["BASIC_SALARY"];
					c.Comments = Convert.IsDBNull(reader["COMMENTS"]) ? null : (System.String)reader["COMMENTS"];
					c.AffectsStaffState = (System.Decimal)reader["AFFECTS_STAFF_STATE"];
					c.SaStfMemberId = (System.Decimal)reader["SA_STF_MEMBER_ID"];
					c.SaCodeEmpMethodId = (System.Decimal)reader["SA_CODE_EMP_METHOD_ID"];
					c.AsNodeId = (System.Decimal)reader["AS_NODE_ID"];
					c.SaCodeScDegId = (System.Decimal)reader["SA_CODE_SC_DEG_ID"];
					c.GsApprovalHId = Convert.IsDBNull(reader["GS_APPROVAL_H_ID"]) ? null : (System.Decimal?)reader["GS_APPROVAL_H_ID"];
					c.SaJobStartStatmentId = Convert.IsDBNull(reader["SA_JOB_START_STATMENT_ID"]) ? null : (System.Decimal?)reader["SA_JOB_START_STATMENT_ID"];
					c.PgThesisGeneralSpecId = Convert.IsDBNull(reader["PG_THESIS_GENERAL_SPEC_ID"]) ? null : (System.Decimal?)reader["PG_THESIS_GENERAL_SPEC_ID"];
					c.PgThesisDetailedSpecId = Convert.IsDBNull(reader["PG_THESIS_DETAILED_SPEC_ID"]) ? null : (System.Decimal?)reader["PG_THESIS_DETAILED_SPEC_ID"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.GsCodeHealthStateId = Convert.IsDBNull(reader["GS_CODE_HEALTH_STATE_ID"]) ? null : (System.Decimal?)reader["GS_CODE_HEALTH_STATE_ID"];
					c.EmploymentDate = (System.DateTime)reader["EMPLOYMENT_DATE"];
					c.DecisionType = (System.Decimal)reader["DECISION_TYPE"];
					c.ScDegDate = Convert.IsDBNull(reader["SC_DEG_DATE"]) ? null : (System.DateTime?)reader["SC_DEG_DATE"];
					c.SaScQualId = Convert.IsDBNull(reader["SA_SC_QUAL_ID"]) ? null : (System.Decimal?)reader["SA_SC_QUAL_ID"];
					c.Elawa = (System.Decimal)reader["ELAWA"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaEmployment"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaEmployment"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaEmployment entity)
		{
			if (!reader.Read()) return;
			
			entity.SaEmploymentId = (System.Decimal)reader[((int)SaEmploymentColumn.SaEmploymentId - 1)];
			entity.OriginalSaEmploymentId = (System.Decimal)reader["SA_EMPLOYMENT_ID"];
			entity.DecisionNum = (System.String)reader[((int)SaEmploymentColumn.DecisionNum - 1)];
			entity.DecisionDate = (System.DateTime)reader[((int)SaEmploymentColumn.DecisionDate - 1)];
			entity.DecisionSumm = (reader.IsDBNull(((int)SaEmploymentColumn.DecisionSumm - 1)))?null:(System.String)reader[((int)SaEmploymentColumn.DecisionSumm - 1)];
			entity.AdvertNum = (reader.IsDBNull(((int)SaEmploymentColumn.AdvertNum - 1)))?null:(System.String)reader[((int)SaEmploymentColumn.AdvertNum - 1)];
			entity.AdvertDate = (reader.IsDBNull(((int)SaEmploymentColumn.AdvertDate - 1)))?null:(System.DateTime?)reader[((int)SaEmploymentColumn.AdvertDate - 1)];
			entity.ValidTilDate = (reader.IsDBNull(((int)SaEmploymentColumn.ValidTilDate - 1)))?null:(System.DateTime?)reader[((int)SaEmploymentColumn.ValidTilDate - 1)];
			entity.EmpDatePre = (reader.IsDBNull(((int)SaEmploymentColumn.EmpDatePre - 1)))?null:(System.DateTime?)reader[((int)SaEmploymentColumn.EmpDatePre - 1)];
			entity.InsuranceNum = (reader.IsDBNull(((int)SaEmploymentColumn.InsuranceNum - 1)))?null:(System.String)reader[((int)SaEmploymentColumn.InsuranceNum - 1)];
			entity.AllEmpIssuesDone = (System.Decimal)reader[((int)SaEmploymentColumn.AllEmpIssuesDone - 1)];
			entity.BasicSalary = (System.Decimal)reader[((int)SaEmploymentColumn.BasicSalary - 1)];
			entity.Comments = (reader.IsDBNull(((int)SaEmploymentColumn.Comments - 1)))?null:(System.String)reader[((int)SaEmploymentColumn.Comments - 1)];
			entity.AffectsStaffState = (System.Decimal)reader[((int)SaEmploymentColumn.AffectsStaffState - 1)];
			entity.SaStfMemberId = (System.Decimal)reader[((int)SaEmploymentColumn.SaStfMemberId - 1)];
			entity.SaCodeEmpMethodId = (System.Decimal)reader[((int)SaEmploymentColumn.SaCodeEmpMethodId - 1)];
			entity.AsNodeId = (System.Decimal)reader[((int)SaEmploymentColumn.AsNodeId - 1)];
			entity.SaCodeScDegId = (System.Decimal)reader[((int)SaEmploymentColumn.SaCodeScDegId - 1)];
			entity.GsApprovalHId = (reader.IsDBNull(((int)SaEmploymentColumn.GsApprovalHId - 1)))?null:(System.Decimal?)reader[((int)SaEmploymentColumn.GsApprovalHId - 1)];
			entity.SaJobStartStatmentId = (reader.IsDBNull(((int)SaEmploymentColumn.SaJobStartStatmentId - 1)))?null:(System.Decimal?)reader[((int)SaEmploymentColumn.SaJobStartStatmentId - 1)];
			entity.PgThesisGeneralSpecId = (reader.IsDBNull(((int)SaEmploymentColumn.PgThesisGeneralSpecId - 1)))?null:(System.Decimal?)reader[((int)SaEmploymentColumn.PgThesisGeneralSpecId - 1)];
			entity.PgThesisDetailedSpecId = (reader.IsDBNull(((int)SaEmploymentColumn.PgThesisDetailedSpecId - 1)))?null:(System.Decimal?)reader[((int)SaEmploymentColumn.PgThesisDetailedSpecId - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)SaEmploymentColumn.AsFacultyInfoId - 1)];
			entity.GsCodeHealthStateId = (reader.IsDBNull(((int)SaEmploymentColumn.GsCodeHealthStateId - 1)))?null:(System.Decimal?)reader[((int)SaEmploymentColumn.GsCodeHealthStateId - 1)];
			entity.EmploymentDate = (System.DateTime)reader[((int)SaEmploymentColumn.EmploymentDate - 1)];
			entity.DecisionType = (System.Decimal)reader[((int)SaEmploymentColumn.DecisionType - 1)];
			entity.ScDegDate = (reader.IsDBNull(((int)SaEmploymentColumn.ScDegDate - 1)))?null:(System.DateTime?)reader[((int)SaEmploymentColumn.ScDegDate - 1)];
			entity.SaScQualId = (reader.IsDBNull(((int)SaEmploymentColumn.SaScQualId - 1)))?null:(System.Decimal?)reader[((int)SaEmploymentColumn.SaScQualId - 1)];
			entity.Elawa = (System.Decimal)reader[((int)SaEmploymentColumn.Elawa - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaEmployment"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaEmployment"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaEmployment entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaEmploymentId = (System.Decimal)dataRow["SA_EMPLOYMENT_ID"];
			entity.OriginalSaEmploymentId = (System.Decimal)dataRow["SA_EMPLOYMENT_ID"];
			entity.DecisionNum = (System.String)dataRow["DECISION_NUM"];
			entity.DecisionDate = (System.DateTime)dataRow["DECISION_DATE"];
			entity.DecisionSumm = Convert.IsDBNull(dataRow["DECISION_SUMM"]) ? null : (System.String)dataRow["DECISION_SUMM"];
			entity.AdvertNum = Convert.IsDBNull(dataRow["ADVERT_NUM"]) ? null : (System.String)dataRow["ADVERT_NUM"];
			entity.AdvertDate = Convert.IsDBNull(dataRow["ADVERT_DATE"]) ? null : (System.DateTime?)dataRow["ADVERT_DATE"];
			entity.ValidTilDate = Convert.IsDBNull(dataRow["VALID_TIL_DATE"]) ? null : (System.DateTime?)dataRow["VALID_TIL_DATE"];
			entity.EmpDatePre = Convert.IsDBNull(dataRow["EMP_DATE_PRE"]) ? null : (System.DateTime?)dataRow["EMP_DATE_PRE"];
			entity.InsuranceNum = Convert.IsDBNull(dataRow["INSURANCE_NUM"]) ? null : (System.String)dataRow["INSURANCE_NUM"];
			entity.AllEmpIssuesDone = (System.Decimal)dataRow["ALL_EMP_ISSUES_DONE"];
			entity.BasicSalary = (System.Decimal)dataRow["BASIC_SALARY"];
			entity.Comments = Convert.IsDBNull(dataRow["COMMENTS"]) ? null : (System.String)dataRow["COMMENTS"];
			entity.AffectsStaffState = (System.Decimal)dataRow["AFFECTS_STAFF_STATE"];
			entity.SaStfMemberId = (System.Decimal)dataRow["SA_STF_MEMBER_ID"];
			entity.SaCodeEmpMethodId = (System.Decimal)dataRow["SA_CODE_EMP_METHOD_ID"];
			entity.AsNodeId = (System.Decimal)dataRow["AS_NODE_ID"];
			entity.SaCodeScDegId = (System.Decimal)dataRow["SA_CODE_SC_DEG_ID"];
			entity.GsApprovalHId = Convert.IsDBNull(dataRow["GS_APPROVAL_H_ID"]) ? null : (System.Decimal?)dataRow["GS_APPROVAL_H_ID"];
			entity.SaJobStartStatmentId = Convert.IsDBNull(dataRow["SA_JOB_START_STATMENT_ID"]) ? null : (System.Decimal?)dataRow["SA_JOB_START_STATMENT_ID"];
			entity.PgThesisGeneralSpecId = Convert.IsDBNull(dataRow["PG_THESIS_GENERAL_SPEC_ID"]) ? null : (System.Decimal?)dataRow["PG_THESIS_GENERAL_SPEC_ID"];
			entity.PgThesisDetailedSpecId = Convert.IsDBNull(dataRow["PG_THESIS_DETAILED_SPEC_ID"]) ? null : (System.Decimal?)dataRow["PG_THESIS_DETAILED_SPEC_ID"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
			entity.GsCodeHealthStateId = Convert.IsDBNull(dataRow["GS_CODE_HEALTH_STATE_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_HEALTH_STATE_ID"];
			entity.EmploymentDate = (System.DateTime)dataRow["EMPLOYMENT_DATE"];
			entity.DecisionType = (System.Decimal)dataRow["DECISION_TYPE"];
			entity.ScDegDate = Convert.IsDBNull(dataRow["SC_DEG_DATE"]) ? null : (System.DateTime?)dataRow["SC_DEG_DATE"];
			entity.SaScQualId = Convert.IsDBNull(dataRow["SA_SC_QUAL_ID"]) ? null : (System.Decimal?)dataRow["SA_SC_QUAL_ID"];
			entity.Elawa = (System.Decimal)dataRow["ELAWA"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaEmployment"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaEmployment Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaEmployment entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsFacultyInfoIdSource	
			if (CanDeepLoad(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepLoadType, innerList) 
				&& entity.AsFacultyInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AsFacultyInfoId;
				AsFacultyInfo tmpEntity = EntityManager.LocateEntity<AsFacultyInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AsFacultyInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsFacultyInfoIdSource = tmpEntity;
				else
					entity.AsFacultyInfoIdSource = DataRepository.AsFacultyInfoProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);		
				
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

			#region PgThesisGeneralSpecIdSource	
			if (CanDeepLoad(entity, "PgThesisGeneralSpec|PgThesisGeneralSpecIdSource", deepLoadType, innerList) 
				&& entity.PgThesisGeneralSpecIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.PgThesisGeneralSpecId ?? 0.0m);
				PgThesisGeneralSpec tmpEntity = EntityManager.LocateEntity<PgThesisGeneralSpec>(EntityLocator.ConstructKeyFromPkItems(typeof(PgThesisGeneralSpec), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgThesisGeneralSpecIdSource = tmpEntity;
				else
					entity.PgThesisGeneralSpecIdSource = DataRepository.PgThesisGeneralSpecProvider.GetByPgThesisGeneralSpecId(transactionManager, (entity.PgThesisGeneralSpecId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisGeneralSpecIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgThesisGeneralSpecIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgThesisGeneralSpecProvider.DeepLoad(transactionManager, entity.PgThesisGeneralSpecIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgThesisGeneralSpecIdSource

			#region SaScQualIdSource	
			if (CanDeepLoad(entity, "SaScQual|SaScQualIdSource", deepLoadType, innerList) 
				&& entity.SaScQualIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaScQualId ?? 0.0m);
				SaScQual tmpEntity = EntityManager.LocateEntity<SaScQual>(EntityLocator.ConstructKeyFromPkItems(typeof(SaScQual), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaScQualIdSource = tmpEntity;
				else
					entity.SaScQualIdSource = DataRepository.SaScQualProvider.GetBySaScQualId(transactionManager, (entity.SaScQualId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaScQualIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaScQualIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaScQualProvider.DeepLoad(transactionManager, entity.SaScQualIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaScQualIdSource

			#region SaStfMemberIdSource	
			if (CanDeepLoad(entity, "SaStfMember|SaStfMemberIdSource", deepLoadType, innerList) 
				&& entity.SaStfMemberIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaStfMemberId;
				SaStfMember tmpEntity = EntityManager.LocateEntity<SaStfMember>(EntityLocator.ConstructKeyFromPkItems(typeof(SaStfMember), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaStfMemberIdSource = tmpEntity;
				else
					entity.SaStfMemberIdSource = DataRepository.SaStfMemberProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);		
				
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

			#region GsApprovalHIdSource	
			if (CanDeepLoad(entity, "GsApprovalH|GsApprovalHIdSource", deepLoadType, innerList) 
				&& entity.GsApprovalHIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsApprovalHId ?? 0.0m);
				GsApprovalH tmpEntity = EntityManager.LocateEntity<GsApprovalH>(EntityLocator.ConstructKeyFromPkItems(typeof(GsApprovalH), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsApprovalHIdSource = tmpEntity;
				else
					entity.GsApprovalHIdSource = DataRepository.GsApprovalHProvider.GetByGsApprovalHId(transactionManager, (entity.GsApprovalHId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsApprovalHIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsApprovalHIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsApprovalHProvider.DeepLoad(transactionManager, entity.GsApprovalHIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsApprovalHIdSource

			#region PgThesisDetailedSpecIdSource	
			if (CanDeepLoad(entity, "PgThesisDetailedSpec|PgThesisDetailedSpecIdSource", deepLoadType, innerList) 
				&& entity.PgThesisDetailedSpecIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.PgThesisDetailedSpecId ?? 0.0m);
				PgThesisDetailedSpec tmpEntity = EntityManager.LocateEntity<PgThesisDetailedSpec>(EntityLocator.ConstructKeyFromPkItems(typeof(PgThesisDetailedSpec), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgThesisDetailedSpecIdSource = tmpEntity;
				else
					entity.PgThesisDetailedSpecIdSource = DataRepository.PgThesisDetailedSpecProvider.GetByPgThesisDetailedSpecId(transactionManager, (entity.PgThesisDetailedSpecId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisDetailedSpecIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgThesisDetailedSpecIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgThesisDetailedSpecProvider.DeepLoad(transactionManager, entity.PgThesisDetailedSpecIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgThesisDetailedSpecIdSource

			#region SaCodeEmpMethodIdSource	
			if (CanDeepLoad(entity, "SaCodeEmpMethod|SaCodeEmpMethodIdSource", deepLoadType, innerList) 
				&& entity.SaCodeEmpMethodIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaCodeEmpMethodId;
				SaCodeEmpMethod tmpEntity = EntityManager.LocateEntity<SaCodeEmpMethod>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeEmpMethod), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeEmpMethodIdSource = tmpEntity;
				else
					entity.SaCodeEmpMethodIdSource = DataRepository.SaCodeEmpMethodProvider.GetBySaCodeEmpMethodId(transactionManager, entity.SaCodeEmpMethodId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeEmpMethodIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodeEmpMethodIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeEmpMethodProvider.DeepLoad(transactionManager, entity.SaCodeEmpMethodIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodeEmpMethodIdSource

			#region SaCodeScDegIdSource	
			if (CanDeepLoad(entity, "SaCodeScDeg|SaCodeScDegIdSource", deepLoadType, innerList) 
				&& entity.SaCodeScDegIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaCodeScDegId;
				SaCodeScDeg tmpEntity = EntityManager.LocateEntity<SaCodeScDeg>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeScDeg), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeScDegIdSource = tmpEntity;
				else
					entity.SaCodeScDegIdSource = DataRepository.SaCodeScDegProvider.GetBySaCodeScDegId(transactionManager, entity.SaCodeScDegId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeScDegIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodeScDegIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeScDegProvider.DeepLoad(transactionManager, entity.SaCodeScDegIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodeScDegIdSource

			#region SaJobStartStatmentIdSource	
			if (CanDeepLoad(entity, "SaJobStartStatment|SaJobStartStatmentIdSource", deepLoadType, innerList) 
				&& entity.SaJobStartStatmentIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaJobStartStatmentId ?? 0.0m);
				SaJobStartStatment tmpEntity = EntityManager.LocateEntity<SaJobStartStatment>(EntityLocator.ConstructKeyFromPkItems(typeof(SaJobStartStatment), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaJobStartStatmentIdSource = tmpEntity;
				else
					entity.SaJobStartStatmentIdSource = DataRepository.SaJobStartStatmentProvider.GetBySaJobStartStatmentId(transactionManager, (entity.SaJobStartStatmentId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaJobStartStatmentIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaJobStartStatmentIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaJobStartStatmentProvider.DeepLoad(transactionManager, entity.SaJobStartStatmentIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaJobStartStatmentIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaEmployment object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaEmployment instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaEmployment Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaEmployment entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region PgThesisGeneralSpecIdSource
			if (CanDeepSave(entity, "PgThesisGeneralSpec|PgThesisGeneralSpecIdSource", deepSaveType, innerList) 
				&& entity.PgThesisGeneralSpecIdSource != null)
			{
				DataRepository.PgThesisGeneralSpecProvider.Save(transactionManager, entity.PgThesisGeneralSpecIdSource);
				entity.PgThesisGeneralSpecId = entity.PgThesisGeneralSpecIdSource.PgThesisGeneralSpecId;
			}
			#endregion 
			
			#region SaScQualIdSource
			if (CanDeepSave(entity, "SaScQual|SaScQualIdSource", deepSaveType, innerList) 
				&& entity.SaScQualIdSource != null)
			{
				DataRepository.SaScQualProvider.Save(transactionManager, entity.SaScQualIdSource);
				entity.SaScQualId = entity.SaScQualIdSource.SaScQualId;
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
			
			#region GsApprovalHIdSource
			if (CanDeepSave(entity, "GsApprovalH|GsApprovalHIdSource", deepSaveType, innerList) 
				&& entity.GsApprovalHIdSource != null)
			{
				DataRepository.GsApprovalHProvider.Save(transactionManager, entity.GsApprovalHIdSource);
				entity.GsApprovalHId = entity.GsApprovalHIdSource.GsApprovalHId;
			}
			#endregion 
			
			#region PgThesisDetailedSpecIdSource
			if (CanDeepSave(entity, "PgThesisDetailedSpec|PgThesisDetailedSpecIdSource", deepSaveType, innerList) 
				&& entity.PgThesisDetailedSpecIdSource != null)
			{
				DataRepository.PgThesisDetailedSpecProvider.Save(transactionManager, entity.PgThesisDetailedSpecIdSource);
				entity.PgThesisDetailedSpecId = entity.PgThesisDetailedSpecIdSource.PgThesisDetailedSpecId;
			}
			#endregion 
			
			#region SaCodeEmpMethodIdSource
			if (CanDeepSave(entity, "SaCodeEmpMethod|SaCodeEmpMethodIdSource", deepSaveType, innerList) 
				&& entity.SaCodeEmpMethodIdSource != null)
			{
				DataRepository.SaCodeEmpMethodProvider.Save(transactionManager, entity.SaCodeEmpMethodIdSource);
				entity.SaCodeEmpMethodId = entity.SaCodeEmpMethodIdSource.SaCodeEmpMethodId;
			}
			#endregion 
			
			#region SaCodeScDegIdSource
			if (CanDeepSave(entity, "SaCodeScDeg|SaCodeScDegIdSource", deepSaveType, innerList) 
				&& entity.SaCodeScDegIdSource != null)
			{
				DataRepository.SaCodeScDegProvider.Save(transactionManager, entity.SaCodeScDegIdSource);
				entity.SaCodeScDegId = entity.SaCodeScDegIdSource.SaCodeScDegId;
			}
			#endregion 
			
			#region SaJobStartStatmentIdSource
			if (CanDeepSave(entity, "SaJobStartStatment|SaJobStartStatmentIdSource", deepSaveType, innerList) 
				&& entity.SaJobStartStatmentIdSource != null)
			{
				DataRepository.SaJobStartStatmentProvider.Save(transactionManager, entity.SaJobStartStatmentIdSource);
				entity.SaJobStartStatmentId = entity.SaJobStartStatmentIdSource.SaJobStartStatmentId;
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
	
	#region SaEmploymentChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaEmployment</c>
	///</summary>
	public enum SaEmploymentChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>PgThesisGeneralSpec</c> at PgThesisGeneralSpecIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisGeneralSpec))]
		PgThesisGeneralSpec,
		
		///<summary>
		/// Composite Property for <c>SaScQual</c> at SaScQualIdSource
		///</summary>
		[ChildEntityType(typeof(SaScQual))]
		SaScQual,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
		
		///<summary>
		/// Composite Property for <c>GsApprovalH</c> at GsApprovalHIdSource
		///</summary>
		[ChildEntityType(typeof(GsApprovalH))]
		GsApprovalH,
		
		///<summary>
		/// Composite Property for <c>PgThesisDetailedSpec</c> at PgThesisDetailedSpecIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisDetailedSpec))]
		PgThesisDetailedSpec,
		
		///<summary>
		/// Composite Property for <c>SaCodeEmpMethod</c> at SaCodeEmpMethodIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeEmpMethod))]
		SaCodeEmpMethod,
		
		///<summary>
		/// Composite Property for <c>SaCodeScDeg</c> at SaCodeScDegIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeScDeg))]
		SaCodeScDeg,
		
		///<summary>
		/// Composite Property for <c>SaJobStartStatment</c> at SaJobStartStatmentIdSource
		///</summary>
		[ChildEntityType(typeof(SaJobStartStatment))]
		SaJobStartStatment,
	}
	
	#endregion SaEmploymentChildEntityTypes
	
	#region SaEmploymentFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaEmploymentColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaEmployment"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaEmploymentFilterBuilder : SqlFilterBuilder<SaEmploymentColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaEmploymentFilterBuilder class.
		/// </summary>
		public SaEmploymentFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaEmploymentFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaEmploymentFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaEmploymentFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaEmploymentFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaEmploymentFilterBuilder
	
	#region SaEmploymentParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaEmploymentColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaEmployment"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaEmploymentParameterBuilder : ParameterizedSqlFilterBuilder<SaEmploymentColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaEmploymentParameterBuilder class.
		/// </summary>
		public SaEmploymentParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaEmploymentParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaEmploymentParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaEmploymentParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaEmploymentParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaEmploymentParameterBuilder
	
	#region SaEmploymentSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaEmploymentColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaEmployment"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaEmploymentSortBuilder : SqlSortBuilder<SaEmploymentColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaEmploymentSqlSortBuilder class.
		/// </summary>
		public SaEmploymentSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaEmploymentSortBuilder
	
} // end namespace
