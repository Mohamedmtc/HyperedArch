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
	/// This class is the base class for any <see cref="SpoSponsorOfferExtProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SpoSponsorOfferExtProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SpoSponsorOfferExt, UMIS_VER2.BusinessLyer.SpoSponsorOfferExtKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoSponsorOfferExtKey key)
		{
			return Delete(transactionManager, key.SpoSponsorOfferExtId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_spoSponsorOfferExtId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _spoSponsorOfferExtId)
		{
			return Delete(null, _spoSponsorOfferExtId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorOfferExtId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _spoSponsorOfferExtId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_EXT_ED_ACAD_YEAR key.
		///		FK_SPO_SPONSOR_OFFER_EXT_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId">عام  الخطة الدراسية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOfferExt objects.</returns>
		public TList<SpoSponsorOfferExt> GetByEdAcadYearId(System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_EXT_ED_ACAD_YEAR key.
		///		FK_SPO_SPONSOR_OFFER_EXT_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">عام  الخطة الدراسية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOfferExt objects.</returns>
		/// <remarks></remarks>
		public TList<SpoSponsorOfferExt> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_EXT_ED_ACAD_YEAR key.
		///		FK_SPO_SPONSOR_OFFER_EXT_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">عام  الخطة الدراسية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOfferExt objects.</returns>
		public TList<SpoSponsorOfferExt> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_EXT_ED_ACAD_YEAR key.
		///		fkSpoSponsorOfferExtEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">عام  الخطة الدراسية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOfferExt objects.</returns>
		public TList<SpoSponsorOfferExt> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_EXT_ED_ACAD_YEAR key.
		///		fkSpoSponsorOfferExtEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">عام  الخطة الدراسية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOfferExt objects.</returns>
		public TList<SpoSponsorOfferExt> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_EXT_ED_ACAD_YEAR key.
		///		FK_SPO_SPONSOR_OFFER_EXT_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">عام  الخطة الدراسية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOfferExt objects.</returns>
		public abstract TList<SpoSponsorOfferExt> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_EXT_ED_CDE_STUD_TYPE key.
		///		FK_SPO_SPONSOR_OFFER_EXT_ED_CDE_STUD_TYPE Description: 
		/// </summary>
		/// <param name="_edCdeStudTypeId">burimi student type</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOfferExt objects.</returns>
		public TList<SpoSponsorOfferExt> GetByEdCdeStudTypeId(System.Int32? _edCdeStudTypeId)
		{
			int count = -1;
			return GetByEdCdeStudTypeId(_edCdeStudTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_EXT_ED_CDE_STUD_TYPE key.
		///		FK_SPO_SPONSOR_OFFER_EXT_ED_CDE_STUD_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeStudTypeId">burimi student type</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOfferExt objects.</returns>
		/// <remarks></remarks>
		public TList<SpoSponsorOfferExt> GetByEdCdeStudTypeId(TransactionManager transactionManager, System.Int32? _edCdeStudTypeId)
		{
			int count = -1;
			return GetByEdCdeStudTypeId(transactionManager, _edCdeStudTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_EXT_ED_CDE_STUD_TYPE key.
		///		FK_SPO_SPONSOR_OFFER_EXT_ED_CDE_STUD_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeStudTypeId">burimi student type</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOfferExt objects.</returns>
		public TList<SpoSponsorOfferExt> GetByEdCdeStudTypeId(TransactionManager transactionManager, System.Int32? _edCdeStudTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeStudTypeId(transactionManager, _edCdeStudTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_EXT_ED_CDE_STUD_TYPE key.
		///		fkSpoSponsorOfferExtEdCdeStudType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeStudTypeId">burimi student type</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOfferExt objects.</returns>
		public TList<SpoSponsorOfferExt> GetByEdCdeStudTypeId(System.Int32? _edCdeStudTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeStudTypeId(null, _edCdeStudTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_EXT_ED_CDE_STUD_TYPE key.
		///		fkSpoSponsorOfferExtEdCdeStudType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeStudTypeId">burimi student type</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOfferExt objects.</returns>
		public TList<SpoSponsorOfferExt> GetByEdCdeStudTypeId(System.Int32? _edCdeStudTypeId, int start, int pageLength,out int count)
		{
			return GetByEdCdeStudTypeId(null, _edCdeStudTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_EXT_ED_CDE_STUD_TYPE key.
		///		FK_SPO_SPONSOR_OFFER_EXT_ED_CDE_STUD_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeStudTypeId">burimi student type</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOfferExt objects.</returns>
		public abstract TList<SpoSponsorOfferExt> GetByEdCdeStudTypeId(TransactionManager transactionManager, System.Int32? _edCdeStudTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_EXT_ENTITY_MAIN key.
		///		FK_SPO_SPONSOR_OFFER_EXT_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_entMainId">الخطة الدراسية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOfferExt objects.</returns>
		public TList<SpoSponsorOfferExt> GetByEntMainId(System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(_entMainId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_EXT_ENTITY_MAIN key.
		///		FK_SPO_SPONSOR_OFFER_EXT_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">الخطة الدراسية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOfferExt objects.</returns>
		/// <remarks></remarks>
		public TList<SpoSponsorOfferExt> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_EXT_ENTITY_MAIN key.
		///		FK_SPO_SPONSOR_OFFER_EXT_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">الخطة الدراسية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOfferExt objects.</returns>
		public TList<SpoSponsorOfferExt> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_EXT_ENTITY_MAIN key.
		///		fkSpoSponsorOfferExtEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId">الخطة الدراسية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOfferExt objects.</returns>
		public TList<SpoSponsorOfferExt> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainId(null, _entMainId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_EXT_ENTITY_MAIN key.
		///		fkSpoSponsorOfferExtEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId">الخطة الدراسية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOfferExt objects.</returns>
		public TList<SpoSponsorOfferExt> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength,out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_EXT_ENTITY_MAIN key.
		///		FK_SPO_SPONSOR_OFFER_EXT_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">الخطة الدراسية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOfferExt objects.</returns>
		public abstract TList<SpoSponsorOfferExt> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_EXT_SPO_SPONSOR_OFFER key.
		///		FK_SPO_SPONSOR_OFFER_EXT_SPO_SPONSOR_OFFER Description: 
		/// </summary>
		/// <param name="_spoSponsorOfferId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOfferExt objects.</returns>
		public TList<SpoSponsorOfferExt> GetBySpoSponsorOfferId(System.Decimal _spoSponsorOfferId)
		{
			int count = -1;
			return GetBySpoSponsorOfferId(_spoSponsorOfferId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_EXT_SPO_SPONSOR_OFFER key.
		///		FK_SPO_SPONSOR_OFFER_EXT_SPO_SPONSOR_OFFER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOfferExt objects.</returns>
		/// <remarks></remarks>
		public TList<SpoSponsorOfferExt> GetBySpoSponsorOfferId(TransactionManager transactionManager, System.Decimal _spoSponsorOfferId)
		{
			int count = -1;
			return GetBySpoSponsorOfferId(transactionManager, _spoSponsorOfferId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_EXT_SPO_SPONSOR_OFFER key.
		///		FK_SPO_SPONSOR_OFFER_EXT_SPO_SPONSOR_OFFER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOfferExt objects.</returns>
		public TList<SpoSponsorOfferExt> GetBySpoSponsorOfferId(TransactionManager transactionManager, System.Decimal _spoSponsorOfferId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorOfferId(transactionManager, _spoSponsorOfferId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_EXT_SPO_SPONSOR_OFFER key.
		///		fkSpoSponsorOfferExtSpoSponsorOffer Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOfferExt objects.</returns>
		public TList<SpoSponsorOfferExt> GetBySpoSponsorOfferId(System.Decimal _spoSponsorOfferId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySpoSponsorOfferId(null, _spoSponsorOfferId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_EXT_SPO_SPONSOR_OFFER key.
		///		fkSpoSponsorOfferExtSpoSponsorOffer Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOfferExt objects.</returns>
		public TList<SpoSponsorOfferExt> GetBySpoSponsorOfferId(System.Decimal _spoSponsorOfferId, int start, int pageLength,out int count)
		{
			return GetBySpoSponsorOfferId(null, _spoSponsorOfferId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_EXT_SPO_SPONSOR_OFFER key.
		///		FK_SPO_SPONSOR_OFFER_EXT_SPO_SPONSOR_OFFER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOfferExt objects.</returns>
		public abstract TList<SpoSponsorOfferExt> GetBySpoSponsorOfferId(TransactionManager transactionManager, System.Decimal _spoSponsorOfferId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SpoSponsorOfferExt Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoSponsorOfferExtKey key, int start, int pageLength)
		{
			return GetBySpoSponsorOfferExtId(transactionManager, key.SpoSponsorOfferExtId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SPO_SPONSOR_OFFER_EXT index.
		/// </summary>
		/// <param name="_spoSponsorOfferExtId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorOfferExt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorOfferExt GetBySpoSponsorOfferExtId(System.Decimal _spoSponsorOfferExtId)
		{
			int count = -1;
			return GetBySpoSponsorOfferExtId(null,_spoSponsorOfferExtId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_SPONSOR_OFFER_EXT index.
		/// </summary>
		/// <param name="_spoSponsorOfferExtId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorOfferExt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorOfferExt GetBySpoSponsorOfferExtId(System.Decimal _spoSponsorOfferExtId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorOfferExtId(null, _spoSponsorOfferExtId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_SPONSOR_OFFER_EXT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorOfferExtId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorOfferExt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorOfferExt GetBySpoSponsorOfferExtId(TransactionManager transactionManager, System.Decimal _spoSponsorOfferExtId)
		{
			int count = -1;
			return GetBySpoSponsorOfferExtId(transactionManager, _spoSponsorOfferExtId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_SPONSOR_OFFER_EXT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorOfferExtId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorOfferExt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorOfferExt GetBySpoSponsorOfferExtId(TransactionManager transactionManager, System.Decimal _spoSponsorOfferExtId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorOfferExtId(transactionManager, _spoSponsorOfferExtId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_SPONSOR_OFFER_EXT index.
		/// </summary>
		/// <param name="_spoSponsorOfferExtId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorOfferExt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorOfferExt GetBySpoSponsorOfferExtId(System.Decimal _spoSponsorOfferExtId, int start, int pageLength, out int count)
		{
			return GetBySpoSponsorOfferExtId(null, _spoSponsorOfferExtId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_SPONSOR_OFFER_EXT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorOfferExtId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorOfferExt"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SpoSponsorOfferExt GetBySpoSponsorOfferExtId(TransactionManager transactionManager, System.Decimal _spoSponsorOfferExtId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SpoSponsorOfferExt&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SpoSponsorOfferExt&gt;"/></returns>
		public static TList<SpoSponsorOfferExt> Fill(IDataReader reader, TList<SpoSponsorOfferExt> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SpoSponsorOfferExt c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SpoSponsorOfferExt")
					.Append("|").Append((System.Decimal)reader["SPO_SPONSOR_OFFER_EXT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SpoSponsorOfferExt>(
					key.ToString(), // EntityTrackingKey
					"SpoSponsorOfferExt",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SpoSponsorOfferExt();
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
					c.SpoSponsorOfferExtId = (System.Decimal)reader["SPO_SPONSOR_OFFER_EXT_ID"];
					c.OriginalSpoSponsorOfferExtId = c.SpoSponsorOfferExtId;
					c.SpoSponsorOfferId = (System.Decimal)reader["SPO_SPONSOR_OFFER_ID"];
					c.SemCount = Convert.IsDBNull(reader["SEM_COUNT"]) ? null : (System.Decimal?)reader["SEM_COUNT"];
					c.EdCdeStudTypeId = Convert.IsDBNull(reader["ED_CDE_STUD_TYPE_ID"]) ? null : (System.Int32?)reader["ED_CDE_STUD_TYPE_ID"];
					c.EntMainId = (System.Decimal)reader["ENT_MAIN_ID"];
					c.EdAcadYearId = Convert.IsDBNull(reader["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_ID"];
					c.EdAcadYearAdmId = Convert.IsDBNull(reader["ED_ACAD_YEAR_ADM_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_ADM_ID"];
					c.PersonInCharge = Convert.IsDBNull(reader["PERSON_IN_CHARGE"]) ? null : (System.String)reader["PERSON_IN_CHARGE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorOfferExt"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoSponsorOfferExt"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SpoSponsorOfferExt entity)
		{
			if (!reader.Read()) return;
			
			entity.SpoSponsorOfferExtId = (System.Decimal)reader[((int)SpoSponsorOfferExtColumn.SpoSponsorOfferExtId - 1)];
			entity.OriginalSpoSponsorOfferExtId = (System.Decimal)reader["SPO_SPONSOR_OFFER_EXT_ID"];
			entity.SpoSponsorOfferId = (System.Decimal)reader[((int)SpoSponsorOfferExtColumn.SpoSponsorOfferId - 1)];
			entity.SemCount = (reader.IsDBNull(((int)SpoSponsorOfferExtColumn.SemCount - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorOfferExtColumn.SemCount - 1)];
			entity.EdCdeStudTypeId = (reader.IsDBNull(((int)SpoSponsorOfferExtColumn.EdCdeStudTypeId - 1)))?null:(System.Int32?)reader[((int)SpoSponsorOfferExtColumn.EdCdeStudTypeId - 1)];
			entity.EntMainId = (System.Decimal)reader[((int)SpoSponsorOfferExtColumn.EntMainId - 1)];
			entity.EdAcadYearId = (reader.IsDBNull(((int)SpoSponsorOfferExtColumn.EdAcadYearId - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorOfferExtColumn.EdAcadYearId - 1)];
			entity.EdAcadYearAdmId = (reader.IsDBNull(((int)SpoSponsorOfferExtColumn.EdAcadYearAdmId - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorOfferExtColumn.EdAcadYearAdmId - 1)];
			entity.PersonInCharge = (reader.IsDBNull(((int)SpoSponsorOfferExtColumn.PersonInCharge - 1)))?null:(System.String)reader[((int)SpoSponsorOfferExtColumn.PersonInCharge - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorOfferExt"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoSponsorOfferExt"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SpoSponsorOfferExt entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SpoSponsorOfferExtId = (System.Decimal)dataRow["SPO_SPONSOR_OFFER_EXT_ID"];
			entity.OriginalSpoSponsorOfferExtId = (System.Decimal)dataRow["SPO_SPONSOR_OFFER_EXT_ID"];
			entity.SpoSponsorOfferId = (System.Decimal)dataRow["SPO_SPONSOR_OFFER_ID"];
			entity.SemCount = Convert.IsDBNull(dataRow["SEM_COUNT"]) ? null : (System.Decimal?)dataRow["SEM_COUNT"];
			entity.EdCdeStudTypeId = Convert.IsDBNull(dataRow["ED_CDE_STUD_TYPE_ID"]) ? null : (System.Int32?)dataRow["ED_CDE_STUD_TYPE_ID"];
			entity.EntMainId = (System.Decimal)dataRow["ENT_MAIN_ID"];
			entity.EdAcadYearId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdAcadYearAdmId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_ADM_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_ADM_ID"];
			entity.PersonInCharge = Convert.IsDBNull(dataRow["PERSON_IN_CHARGE"]) ? null : (System.String)dataRow["PERSON_IN_CHARGE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoSponsorOfferExt"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SpoSponsorOfferExt Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoSponsorOfferExt entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region EdCdeStudTypeIdSource	
			if (CanDeepLoad(entity, "EdCdeStudType|EdCdeStudTypeIdSource", deepLoadType, innerList) 
				&& entity.EdCdeStudTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCdeStudTypeId ?? (int)0);
				EdCdeStudType tmpEntity = EntityManager.LocateEntity<EdCdeStudType>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeStudType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCdeStudTypeIdSource = tmpEntity;
				else
					entity.EdCdeStudTypeIdSource = DataRepository.EdCdeStudTypeProvider.GetByEdCdeStudTypeId(transactionManager, (entity.EdCdeStudTypeId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeStudTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCdeStudTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCdeStudTypeProvider.DeepLoad(transactionManager, entity.EdCdeStudTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCdeStudTypeIdSource

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

			#region SpoSponsorOfferIdSource	
			if (CanDeepLoad(entity, "SpoSponsorOffer|SpoSponsorOfferIdSource", deepLoadType, innerList) 
				&& entity.SpoSponsorOfferIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SpoSponsorOfferId;
				SpoSponsorOffer tmpEntity = EntityManager.LocateEntity<SpoSponsorOffer>(EntityLocator.ConstructKeyFromPkItems(typeof(SpoSponsorOffer), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SpoSponsorOfferIdSource = tmpEntity;
				else
					entity.SpoSponsorOfferIdSource = DataRepository.SpoSponsorOfferProvider.GetBySpoSponsorOfferId(transactionManager, entity.SpoSponsorOfferId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorOfferIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SpoSponsorOfferIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SpoSponsorOfferProvider.DeepLoad(transactionManager, entity.SpoSponsorOfferIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SpoSponsorOfferIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SpoSponsorOfferExt object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SpoSponsorOfferExt instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SpoSponsorOfferExt Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoSponsorOfferExt entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdCdeStudTypeIdSource
			if (CanDeepSave(entity, "EdCdeStudType|EdCdeStudTypeIdSource", deepSaveType, innerList) 
				&& entity.EdCdeStudTypeIdSource != null)
			{
				DataRepository.EdCdeStudTypeProvider.Save(transactionManager, entity.EdCdeStudTypeIdSource);
				entity.EdCdeStudTypeId = entity.EdCdeStudTypeIdSource.EdCdeStudTypeId;
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
			
			#region SpoSponsorOfferIdSource
			if (CanDeepSave(entity, "SpoSponsorOffer|SpoSponsorOfferIdSource", deepSaveType, innerList) 
				&& entity.SpoSponsorOfferIdSource != null)
			{
				DataRepository.SpoSponsorOfferProvider.Save(transactionManager, entity.SpoSponsorOfferIdSource);
				entity.SpoSponsorOfferId = entity.SpoSponsorOfferIdSource.SpoSponsorOfferId;
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
	
	#region SpoSponsorOfferExtChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SpoSponsorOfferExt</c>
	///</summary>
	public enum SpoSponsorOfferExtChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>EdCdeStudType</c> at EdCdeStudTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeStudType))]
		EdCdeStudType,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		
		///<summary>
		/// Composite Property for <c>SpoSponsorOffer</c> at SpoSponsorOfferIdSource
		///</summary>
		[ChildEntityType(typeof(SpoSponsorOffer))]
		SpoSponsorOffer,
	}
	
	#endregion SpoSponsorOfferExtChildEntityTypes
	
	#region SpoSponsorOfferExtFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SpoSponsorOfferExtColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoSponsorOfferExt"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SpoSponsorOfferExtFilterBuilder : SqlFilterBuilder<SpoSponsorOfferExtColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoSponsorOfferExtFilterBuilder class.
		/// </summary>
		public SpoSponsorOfferExtFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SpoSponsorOfferExtFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SpoSponsorOfferExtFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SpoSponsorOfferExtFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SpoSponsorOfferExtFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SpoSponsorOfferExtFilterBuilder
	
	#region SpoSponsorOfferExtParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SpoSponsorOfferExtColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoSponsorOfferExt"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SpoSponsorOfferExtParameterBuilder : ParameterizedSqlFilterBuilder<SpoSponsorOfferExtColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoSponsorOfferExtParameterBuilder class.
		/// </summary>
		public SpoSponsorOfferExtParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SpoSponsorOfferExtParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SpoSponsorOfferExtParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SpoSponsorOfferExtParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SpoSponsorOfferExtParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SpoSponsorOfferExtParameterBuilder
	
	#region SpoSponsorOfferExtSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SpoSponsorOfferExtColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoSponsorOfferExt"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SpoSponsorOfferExtSortBuilder : SqlSortBuilder<SpoSponsorOfferExtColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoSponsorOfferExtSqlSortBuilder class.
		/// </summary>
		public SpoSponsorOfferExtSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SpoSponsorOfferExtSortBuilder
	
} // end namespace
