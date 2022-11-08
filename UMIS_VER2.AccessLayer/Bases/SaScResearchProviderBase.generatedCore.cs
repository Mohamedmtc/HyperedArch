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
	/// This class is the base class for any <see cref="SaScResearchProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaScResearchProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaScResearch, UMIS_VER2.BusinessLyer.SaScResearchKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaScResearchKey key)
		{
			return Delete(transactionManager, key.SaScResearchId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saScResearchId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saScResearchId)
		{
			return Delete(null, _saScResearchId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saScResearchId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saScResearchId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_005d key.
		///		FK_AUTO_005d Description: 
		/// </summary>
		/// <param name="_saScCommId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScResearch objects.</returns>
		public TList<SaScResearch> GetBySaScCommId(System.Decimal? _saScCommId)
		{
			int count = -1;
			return GetBySaScCommId(_saScCommId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_005d key.
		///		FK_AUTO_005d Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saScCommId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScResearch objects.</returns>
		/// <remarks></remarks>
		public TList<SaScResearch> GetBySaScCommId(TransactionManager transactionManager, System.Decimal? _saScCommId)
		{
			int count = -1;
			return GetBySaScCommId(transactionManager, _saScCommId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_005d key.
		///		FK_AUTO_005d Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saScCommId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScResearch objects.</returns>
		public TList<SaScResearch> GetBySaScCommId(TransactionManager transactionManager, System.Decimal? _saScCommId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaScCommId(transactionManager, _saScCommId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_005d key.
		///		fkAuto005d Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saScCommId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScResearch objects.</returns>
		public TList<SaScResearch> GetBySaScCommId(System.Decimal? _saScCommId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaScCommId(null, _saScCommId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_005d key.
		///		fkAuto005d Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saScCommId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScResearch objects.</returns>
		public TList<SaScResearch> GetBySaScCommId(System.Decimal? _saScCommId, int start, int pageLength,out int count)
		{
			return GetBySaScCommId(null, _saScCommId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_005d key.
		///		FK_AUTO_005d Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saScCommId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScResearch objects.</returns>
		public abstract TList<SaScResearch> GetBySaScCommId(TransactionManager transactionManager, System.Decimal? _saScCommId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_06ad key.
		///		FK_AUTO_06ad Description: 
		/// </summary>
		/// <param name="_saPromotionRequestId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScResearch objects.</returns>
		public TList<SaScResearch> GetBySaPromotionRequestId(System.Decimal? _saPromotionRequestId)
		{
			int count = -1;
			return GetBySaPromotionRequestId(_saPromotionRequestId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_06ad key.
		///		FK_AUTO_06ad Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPromotionRequestId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScResearch objects.</returns>
		/// <remarks></remarks>
		public TList<SaScResearch> GetBySaPromotionRequestId(TransactionManager transactionManager, System.Decimal? _saPromotionRequestId)
		{
			int count = -1;
			return GetBySaPromotionRequestId(transactionManager, _saPromotionRequestId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_06ad key.
		///		FK_AUTO_06ad Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPromotionRequestId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScResearch objects.</returns>
		public TList<SaScResearch> GetBySaPromotionRequestId(TransactionManager transactionManager, System.Decimal? _saPromotionRequestId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaPromotionRequestId(transactionManager, _saPromotionRequestId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_06ad key.
		///		fkAuto06ad Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saPromotionRequestId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScResearch objects.</returns>
		public TList<SaScResearch> GetBySaPromotionRequestId(System.Decimal? _saPromotionRequestId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaPromotionRequestId(null, _saPromotionRequestId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_06ad key.
		///		fkAuto06ad Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saPromotionRequestId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScResearch objects.</returns>
		public TList<SaScResearch> GetBySaPromotionRequestId(System.Decimal? _saPromotionRequestId, int start, int pageLength,out int count)
		{
			return GetBySaPromotionRequestId(null, _saPromotionRequestId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_06ad key.
		///		FK_AUTO_06ad Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPromotionRequestId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScResearch objects.</returns>
		public abstract TList<SaScResearch> GetBySaPromotionRequestId(TransactionManager transactionManager, System.Decimal? _saPromotionRequestId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_RESEARCH_AS_FACULTY_INFO key.
		///		FK_SA_SC_RESEARCH_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScResearch objects.</returns>
		public TList<SaScResearch> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_RESEARCH_AS_FACULTY_INFO key.
		///		FK_SA_SC_RESEARCH_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScResearch objects.</returns>
		/// <remarks></remarks>
		public TList<SaScResearch> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_RESEARCH_AS_FACULTY_INFO key.
		///		FK_SA_SC_RESEARCH_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScResearch objects.</returns>
		public TList<SaScResearch> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_RESEARCH_AS_FACULTY_INFO key.
		///		fkSaScResearchAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScResearch objects.</returns>
		public TList<SaScResearch> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_RESEARCH_AS_FACULTY_INFO key.
		///		fkSaScResearchAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScResearch objects.</returns>
		public TList<SaScResearch> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_RESEARCH_AS_FACULTY_INFO key.
		///		FK_SA_SC_RESEARCH_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScResearch objects.</returns>
		public abstract TList<SaScResearch> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_RESEARCH_GS_APPROVAL_H key.
		///		FK_SA_SC_RESEARCH_GS_APPROVAL_H Description: 
		/// </summary>
		/// <param name="_gsApprovalHId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScResearch objects.</returns>
		public TList<SaScResearch> GetByGsApprovalHId(System.Decimal _gsApprovalHId)
		{
			int count = -1;
			return GetByGsApprovalHId(_gsApprovalHId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_RESEARCH_GS_APPROVAL_H key.
		///		FK_SA_SC_RESEARCH_GS_APPROVAL_H Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsApprovalHId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScResearch objects.</returns>
		/// <remarks></remarks>
		public TList<SaScResearch> GetByGsApprovalHId(TransactionManager transactionManager, System.Decimal _gsApprovalHId)
		{
			int count = -1;
			return GetByGsApprovalHId(transactionManager, _gsApprovalHId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_RESEARCH_GS_APPROVAL_H key.
		///		FK_SA_SC_RESEARCH_GS_APPROVAL_H Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsApprovalHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScResearch objects.</returns>
		public TList<SaScResearch> GetByGsApprovalHId(TransactionManager transactionManager, System.Decimal _gsApprovalHId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsApprovalHId(transactionManager, _gsApprovalHId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_RESEARCH_GS_APPROVAL_H key.
		///		fkSaScResearchGsApprovalH Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsApprovalHId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScResearch objects.</returns>
		public TList<SaScResearch> GetByGsApprovalHId(System.Decimal _gsApprovalHId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsApprovalHId(null, _gsApprovalHId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_RESEARCH_GS_APPROVAL_H key.
		///		fkSaScResearchGsApprovalH Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsApprovalHId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScResearch objects.</returns>
		public TList<SaScResearch> GetByGsApprovalHId(System.Decimal _gsApprovalHId, int start, int pageLength,out int count)
		{
			return GetByGsApprovalHId(null, _gsApprovalHId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_RESEARCH_GS_APPROVAL_H key.
		///		FK_SA_SC_RESEARCH_GS_APPROVAL_H Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsApprovalHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScResearch objects.</returns>
		public abstract TList<SaScResearch> GetByGsApprovalHId(TransactionManager transactionManager, System.Decimal _gsApprovalHId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SaScResearch Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaScResearchKey key, int start, int pageLength)
		{
			return GetBySaScResearchId(transactionManager, key.SaScResearchId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_SC_RESEARCH index.
		/// </summary>
		/// <param name="_saScResearchId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaScResearch"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaScResearch GetBySaScResearchId(System.Decimal _saScResearchId)
		{
			int count = -1;
			return GetBySaScResearchId(null,_saScResearchId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_SC_RESEARCH index.
		/// </summary>
		/// <param name="_saScResearchId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaScResearch"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaScResearch GetBySaScResearchId(System.Decimal _saScResearchId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaScResearchId(null, _saScResearchId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_SC_RESEARCH index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saScResearchId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaScResearch"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaScResearch GetBySaScResearchId(TransactionManager transactionManager, System.Decimal _saScResearchId)
		{
			int count = -1;
			return GetBySaScResearchId(transactionManager, _saScResearchId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_SC_RESEARCH index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saScResearchId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaScResearch"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaScResearch GetBySaScResearchId(TransactionManager transactionManager, System.Decimal _saScResearchId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaScResearchId(transactionManager, _saScResearchId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_SC_RESEARCH index.
		/// </summary>
		/// <param name="_saScResearchId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaScResearch"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaScResearch GetBySaScResearchId(System.Decimal _saScResearchId, int start, int pageLength, out int count)
		{
			return GetBySaScResearchId(null, _saScResearchId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_SC_RESEARCH index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saScResearchId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaScResearch"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaScResearch GetBySaScResearchId(TransactionManager transactionManager, System.Decimal _saScResearchId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaScResearch&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaScResearch&gt;"/></returns>
		public static TList<SaScResearch> Fill(IDataReader reader, TList<SaScResearch> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaScResearch c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaScResearch")
					.Append("|").Append((System.Decimal)reader["SA_SC_RESEARCH_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaScResearch>(
					key.ToString(), // EntityTrackingKey
					"SaScResearch",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaScResearch();
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
					c.SaScResearchId = (System.Decimal)reader["SA_SC_RESEARCH_ID"];
					c.OriginalSaScResearchId = c.SaScResearchId;
					c.ResearchCode = Convert.IsDBNull(reader["RESEARCH_CODE"]) ? null : (System.String)reader["RESEARCH_CODE"];
					c.ResearchSummAr = Convert.IsDBNull(reader["RESEARCH_SUMM_AR"]) ? null : (System.String)reader["RESEARCH_SUMM_AR"];
					c.ResearchSummEn = Convert.IsDBNull(reader["RESEARCH_SUMM_EN"]) ? null : (System.String)reader["RESEARCH_SUMM_EN"];
					c.ResearchTitle = (System.String)reader["RESEARCH_TITLE"];
					c.PgSubjectDefinition = Convert.IsDBNull(reader["PG_SUBJECT_DEFINITION"]) ? null : (System.Decimal?)reader["PG_SUBJECT_DEFINITION"];
					c.ApprovalDate = Convert.IsDBNull(reader["APPROVAL_DATE"]) ? null : (System.DateTime?)reader["APPROVAL_DATE"];
					c.PagesNum = Convert.IsDBNull(reader["PAGES_NUM"]) ? null : (System.Decimal?)reader["PAGES_NUM"];
					c.ResearchPlace = Convert.IsDBNull(reader["RESEARCH_PLACE"]) ? null : (System.String)reader["RESEARCH_PLACE"];
					c.ResearchEval = Convert.IsDBNull(reader["RESEARCH_EVAL"]) ? null : (System.String)reader["RESEARCH_EVAL"];
					c.Comments = Convert.IsDBNull(reader["COMMENTS"]) ? null : (System.String)reader["COMMENTS"];
					c.GsApprovalHId = (System.Decimal)reader["GS_APPROVAL_H_ID"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.ResearchType = (System.Decimal)reader["RESEARCH_TYPE"];
					c.SaPromotionRequestId = Convert.IsDBNull(reader["SA_PROMOTION_REQUEST_ID"]) ? null : (System.Decimal?)reader["SA_PROMOTION_REQUEST_ID"];
					c.SaScCommId = Convert.IsDBNull(reader["SA_SC_COMM_ID"]) ? null : (System.Decimal?)reader["SA_SC_COMM_ID"];
					c.PgCodeResearchStrategyId = Convert.IsDBNull(reader["PG_CODE_RESEARCH_STRATEGY_ID"]) ? null : (System.Decimal?)reader["PG_CODE_RESEARCH_STRATEGY_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaScResearch"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaScResearch"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaScResearch entity)
		{
			if (!reader.Read()) return;
			
			entity.SaScResearchId = (System.Decimal)reader[((int)SaScResearchColumn.SaScResearchId - 1)];
			entity.OriginalSaScResearchId = (System.Decimal)reader["SA_SC_RESEARCH_ID"];
			entity.ResearchCode = (reader.IsDBNull(((int)SaScResearchColumn.ResearchCode - 1)))?null:(System.String)reader[((int)SaScResearchColumn.ResearchCode - 1)];
			entity.ResearchSummAr = (reader.IsDBNull(((int)SaScResearchColumn.ResearchSummAr - 1)))?null:(System.String)reader[((int)SaScResearchColumn.ResearchSummAr - 1)];
			entity.ResearchSummEn = (reader.IsDBNull(((int)SaScResearchColumn.ResearchSummEn - 1)))?null:(System.String)reader[((int)SaScResearchColumn.ResearchSummEn - 1)];
			entity.ResearchTitle = (System.String)reader[((int)SaScResearchColumn.ResearchTitle - 1)];
			entity.PgSubjectDefinition = (reader.IsDBNull(((int)SaScResearchColumn.PgSubjectDefinition - 1)))?null:(System.Decimal?)reader[((int)SaScResearchColumn.PgSubjectDefinition - 1)];
			entity.ApprovalDate = (reader.IsDBNull(((int)SaScResearchColumn.ApprovalDate - 1)))?null:(System.DateTime?)reader[((int)SaScResearchColumn.ApprovalDate - 1)];
			entity.PagesNum = (reader.IsDBNull(((int)SaScResearchColumn.PagesNum - 1)))?null:(System.Decimal?)reader[((int)SaScResearchColumn.PagesNum - 1)];
			entity.ResearchPlace = (reader.IsDBNull(((int)SaScResearchColumn.ResearchPlace - 1)))?null:(System.String)reader[((int)SaScResearchColumn.ResearchPlace - 1)];
			entity.ResearchEval = (reader.IsDBNull(((int)SaScResearchColumn.ResearchEval - 1)))?null:(System.String)reader[((int)SaScResearchColumn.ResearchEval - 1)];
			entity.Comments = (reader.IsDBNull(((int)SaScResearchColumn.Comments - 1)))?null:(System.String)reader[((int)SaScResearchColumn.Comments - 1)];
			entity.GsApprovalHId = (System.Decimal)reader[((int)SaScResearchColumn.GsApprovalHId - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)SaScResearchColumn.AsFacultyInfoId - 1)];
			entity.ResearchType = (System.Decimal)reader[((int)SaScResearchColumn.ResearchType - 1)];
			entity.SaPromotionRequestId = (reader.IsDBNull(((int)SaScResearchColumn.SaPromotionRequestId - 1)))?null:(System.Decimal?)reader[((int)SaScResearchColumn.SaPromotionRequestId - 1)];
			entity.SaScCommId = (reader.IsDBNull(((int)SaScResearchColumn.SaScCommId - 1)))?null:(System.Decimal?)reader[((int)SaScResearchColumn.SaScCommId - 1)];
			entity.PgCodeResearchStrategyId = (reader.IsDBNull(((int)SaScResearchColumn.PgCodeResearchStrategyId - 1)))?null:(System.Decimal?)reader[((int)SaScResearchColumn.PgCodeResearchStrategyId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaScResearch"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaScResearch"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaScResearch entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaScResearchId = (System.Decimal)dataRow["SA_SC_RESEARCH_ID"];
			entity.OriginalSaScResearchId = (System.Decimal)dataRow["SA_SC_RESEARCH_ID"];
			entity.ResearchCode = Convert.IsDBNull(dataRow["RESEARCH_CODE"]) ? null : (System.String)dataRow["RESEARCH_CODE"];
			entity.ResearchSummAr = Convert.IsDBNull(dataRow["RESEARCH_SUMM_AR"]) ? null : (System.String)dataRow["RESEARCH_SUMM_AR"];
			entity.ResearchSummEn = Convert.IsDBNull(dataRow["RESEARCH_SUMM_EN"]) ? null : (System.String)dataRow["RESEARCH_SUMM_EN"];
			entity.ResearchTitle = (System.String)dataRow["RESEARCH_TITLE"];
			entity.PgSubjectDefinition = Convert.IsDBNull(dataRow["PG_SUBJECT_DEFINITION"]) ? null : (System.Decimal?)dataRow["PG_SUBJECT_DEFINITION"];
			entity.ApprovalDate = Convert.IsDBNull(dataRow["APPROVAL_DATE"]) ? null : (System.DateTime?)dataRow["APPROVAL_DATE"];
			entity.PagesNum = Convert.IsDBNull(dataRow["PAGES_NUM"]) ? null : (System.Decimal?)dataRow["PAGES_NUM"];
			entity.ResearchPlace = Convert.IsDBNull(dataRow["RESEARCH_PLACE"]) ? null : (System.String)dataRow["RESEARCH_PLACE"];
			entity.ResearchEval = Convert.IsDBNull(dataRow["RESEARCH_EVAL"]) ? null : (System.String)dataRow["RESEARCH_EVAL"];
			entity.Comments = Convert.IsDBNull(dataRow["COMMENTS"]) ? null : (System.String)dataRow["COMMENTS"];
			entity.GsApprovalHId = (System.Decimal)dataRow["GS_APPROVAL_H_ID"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
			entity.ResearchType = (System.Decimal)dataRow["RESEARCH_TYPE"];
			entity.SaPromotionRequestId = Convert.IsDBNull(dataRow["SA_PROMOTION_REQUEST_ID"]) ? null : (System.Decimal?)dataRow["SA_PROMOTION_REQUEST_ID"];
			entity.SaScCommId = Convert.IsDBNull(dataRow["SA_SC_COMM_ID"]) ? null : (System.Decimal?)dataRow["SA_SC_COMM_ID"];
			entity.PgCodeResearchStrategyId = Convert.IsDBNull(dataRow["PG_CODE_RESEARCH_STRATEGY_ID"]) ? null : (System.Decimal?)dataRow["PG_CODE_RESEARCH_STRATEGY_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaScResearch"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaScResearch Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaScResearch entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SaScCommIdSource	
			if (CanDeepLoad(entity, "SaScComm|SaScCommIdSource", deepLoadType, innerList) 
				&& entity.SaScCommIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaScCommId ?? 0.0m);
				SaScComm tmpEntity = EntityManager.LocateEntity<SaScComm>(EntityLocator.ConstructKeyFromPkItems(typeof(SaScComm), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaScCommIdSource = tmpEntity;
				else
					entity.SaScCommIdSource = DataRepository.SaScCommProvider.GetBySaScCommId(transactionManager, (entity.SaScCommId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaScCommIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaScCommIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaScCommProvider.DeepLoad(transactionManager, entity.SaScCommIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaScCommIdSource

			#region SaPromotionRequestIdSource	
			if (CanDeepLoad(entity, "SaPromotionRequest|SaPromotionRequestIdSource", deepLoadType, innerList) 
				&& entity.SaPromotionRequestIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaPromotionRequestId ?? 0.0m);
				SaPromotionRequest tmpEntity = EntityManager.LocateEntity<SaPromotionRequest>(EntityLocator.ConstructKeyFromPkItems(typeof(SaPromotionRequest), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaPromotionRequestIdSource = tmpEntity;
				else
					entity.SaPromotionRequestIdSource = DataRepository.SaPromotionRequestProvider.GetBySaPromotionRequestId(transactionManager, (entity.SaPromotionRequestId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaPromotionRequestIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaPromotionRequestIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaPromotionRequestProvider.DeepLoad(transactionManager, entity.SaPromotionRequestIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaPromotionRequestIdSource

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

			#region GsApprovalHIdSource	
			if (CanDeepLoad(entity, "GsApprovalH|GsApprovalHIdSource", deepLoadType, innerList) 
				&& entity.GsApprovalHIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsApprovalHId;
				GsApprovalH tmpEntity = EntityManager.LocateEntity<GsApprovalH>(EntityLocator.ConstructKeyFromPkItems(typeof(GsApprovalH), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsApprovalHIdSource = tmpEntity;
				else
					entity.GsApprovalHIdSource = DataRepository.GsApprovalHProvider.GetByGsApprovalHId(transactionManager, entity.GsApprovalHId);		
				
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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySaScResearchId methods when available
			
			#region SaPublicationCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaPublication>|SaPublicationCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaPublicationCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaPublicationCollection = DataRepository.SaPublicationProvider.GetBySaScResearchId(transactionManager, entity.SaScResearchId);

				if (deep && entity.SaPublicationCollection.Count > 0)
				{
					deepHandles.Add("SaPublicationCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaPublication>) DataRepository.SaPublicationProvider.DeepLoad,
						new object[] { transactionManager, entity.SaPublicationCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaResearchTeamCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaResearchTeam>|SaResearchTeamCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaResearchTeamCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaResearchTeamCollection = DataRepository.SaResearchTeamProvider.GetBySaScResearchId(transactionManager, entity.SaScResearchId);

				if (deep && entity.SaResearchTeamCollection.Count > 0)
				{
					deepHandles.Add("SaResearchTeamCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaResearchTeam>) DataRepository.SaResearchTeamProvider.DeepLoad,
						new object[] { transactionManager, entity.SaResearchTeamCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaScResearch object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaScResearch instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaScResearch Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaScResearch entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SaScCommIdSource
			if (CanDeepSave(entity, "SaScComm|SaScCommIdSource", deepSaveType, innerList) 
				&& entity.SaScCommIdSource != null)
			{
				DataRepository.SaScCommProvider.Save(transactionManager, entity.SaScCommIdSource);
				entity.SaScCommId = entity.SaScCommIdSource.SaScCommId;
			}
			#endregion 
			
			#region SaPromotionRequestIdSource
			if (CanDeepSave(entity, "SaPromotionRequest|SaPromotionRequestIdSource", deepSaveType, innerList) 
				&& entity.SaPromotionRequestIdSource != null)
			{
				DataRepository.SaPromotionRequestProvider.Save(transactionManager, entity.SaPromotionRequestIdSource);
				entity.SaPromotionRequestId = entity.SaPromotionRequestIdSource.SaPromotionRequestId;
			}
			#endregion 
			
			#region AsFacultyInfoIdSource
			if (CanDeepSave(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepSaveType, innerList) 
				&& entity.AsFacultyInfoIdSource != null)
			{
				DataRepository.AsFacultyInfoProvider.Save(transactionManager, entity.AsFacultyInfoIdSource);
				entity.AsFacultyInfoId = entity.AsFacultyInfoIdSource.AsFacultyInfoId;
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
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SaPublication>
				if (CanDeepSave(entity.SaPublicationCollection, "List<SaPublication>|SaPublicationCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaPublication child in entity.SaPublicationCollection)
					{
						if(child.SaScResearchIdSource != null)
						{
							child.SaScResearchId = child.SaScResearchIdSource.SaScResearchId;
						}
						else
						{
							child.SaScResearchId = entity.SaScResearchId;
						}

					}

					if (entity.SaPublicationCollection.Count > 0 || entity.SaPublicationCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaPublicationProvider.Save(transactionManager, entity.SaPublicationCollection);
						
						deepHandles.Add("SaPublicationCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaPublication >) DataRepository.SaPublicationProvider.DeepSave,
							new object[] { transactionManager, entity.SaPublicationCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaResearchTeam>
				if (CanDeepSave(entity.SaResearchTeamCollection, "List<SaResearchTeam>|SaResearchTeamCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaResearchTeam child in entity.SaResearchTeamCollection)
					{
						if(child.SaScResearchIdSource != null)
						{
							child.SaScResearchId = child.SaScResearchIdSource.SaScResearchId;
						}
						else
						{
							child.SaScResearchId = entity.SaScResearchId;
						}

					}

					if (entity.SaResearchTeamCollection.Count > 0 || entity.SaResearchTeamCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaResearchTeamProvider.Save(transactionManager, entity.SaResearchTeamCollection);
						
						deepHandles.Add("SaResearchTeamCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaResearchTeam >) DataRepository.SaResearchTeamProvider.DeepSave,
							new object[] { transactionManager, entity.SaResearchTeamCollection, deepSaveType, childTypes, innerList }
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
	
	#region SaScResearchChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaScResearch</c>
	///</summary>
	public enum SaScResearchChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SaScComm</c> at SaScCommIdSource
		///</summary>
		[ChildEntityType(typeof(SaScComm))]
		SaScComm,
		
		///<summary>
		/// Composite Property for <c>SaPromotionRequest</c> at SaPromotionRequestIdSource
		///</summary>
		[ChildEntityType(typeof(SaPromotionRequest))]
		SaPromotionRequest,
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>GsApprovalH</c> at GsApprovalHIdSource
		///</summary>
		[ChildEntityType(typeof(GsApprovalH))]
		GsApprovalH,
		///<summary>
		/// Collection of <c>SaScResearch</c> as OneToMany for SaPublicationCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaPublication>))]
		SaPublicationCollection,
		///<summary>
		/// Collection of <c>SaScResearch</c> as OneToMany for SaResearchTeamCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaResearchTeam>))]
		SaResearchTeamCollection,
	}
	
	#endregion SaScResearchChildEntityTypes
	
	#region SaScResearchFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaScResearchColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaScResearch"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaScResearchFilterBuilder : SqlFilterBuilder<SaScResearchColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaScResearchFilterBuilder class.
		/// </summary>
		public SaScResearchFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaScResearchFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaScResearchFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaScResearchFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaScResearchFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaScResearchFilterBuilder
	
	#region SaScResearchParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaScResearchColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaScResearch"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaScResearchParameterBuilder : ParameterizedSqlFilterBuilder<SaScResearchColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaScResearchParameterBuilder class.
		/// </summary>
		public SaScResearchParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaScResearchParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaScResearchParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaScResearchParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaScResearchParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaScResearchParameterBuilder
	
	#region SaScResearchSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaScResearchColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaScResearch"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaScResearchSortBuilder : SqlSortBuilder<SaScResearchColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaScResearchSqlSortBuilder class.
		/// </summary>
		public SaScResearchSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaScResearchSortBuilder
	
} // end namespace
