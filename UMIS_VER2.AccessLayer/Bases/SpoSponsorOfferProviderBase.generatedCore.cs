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
	/// This class is the base class for any <see cref="SpoSponsorOfferProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SpoSponsorOfferProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SpoSponsorOffer, UMIS_VER2.BusinessLyer.SpoSponsorOfferKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoSponsorOfferKey key)
		{
			return Delete(transactionManager, key.SpoSponsorOfferId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_spoSponsorOfferId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _spoSponsorOfferId)
		{
			return Delete(null, _spoSponsorOfferId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorOfferId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _spoSponsorOfferId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_AS_CODE_DEGREE_CLASS key.
		///		FK_SPO_SPONSOR_OFFER_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="_asCodeDegreeClassId">Default=All</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public TList<SpoSponsorOffer> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(_asCodeDegreeClassId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_AS_CODE_DEGREE_CLASS key.
		///		FK_SPO_SPONSOR_OFFER_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId">Default=All</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		/// <remarks></remarks>
		public TList<SpoSponsorOffer> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_AS_CODE_DEGREE_CLASS key.
		///		FK_SPO_SPONSOR_OFFER_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId">Default=All</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public TList<SpoSponsorOffer> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_AS_CODE_DEGREE_CLASS key.
		///		fkSpoSponsorOfferAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId">Default=All</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public TList<SpoSponsorOffer> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_AS_CODE_DEGREE_CLASS key.
		///		fkSpoSponsorOfferAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId">Default=All</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public TList<SpoSponsorOffer> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_AS_CODE_DEGREE_CLASS key.
		///		FK_SPO_SPONSOR_OFFER_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId">Default=All</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public abstract TList<SpoSponsorOffer> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_AS_FACULTY_INFO key.
		///		FK_SPO_SPONSOR_OFFER_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId">NULL default=UNIV</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public TList<SpoSponsorOffer> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_AS_FACULTY_INFO key.
		///		FK_SPO_SPONSOR_OFFER_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId">NULL default=UNIV</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		/// <remarks></remarks>
		public TList<SpoSponsorOffer> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_AS_FACULTY_INFO key.
		///		FK_SPO_SPONSOR_OFFER_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId">NULL default=UNIV</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public TList<SpoSponsorOffer> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_AS_FACULTY_INFO key.
		///		fkSpoSponsorOfferAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId">NULL default=UNIV</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public TList<SpoSponsorOffer> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_AS_FACULTY_INFO key.
		///		fkSpoSponsorOfferAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId">NULL default=UNIV</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public TList<SpoSponsorOffer> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_AS_FACULTY_INFO key.
		///		FK_SPO_SPONSOR_OFFER_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId">NULL default=UNIV</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public abstract TList<SpoSponsorOffer> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_ED_ACAD_YEAR key.
		///		FK_SPO_SPONSOR_OFFER_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearFromId">من عام</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public TList<SpoSponsorOffer> GetByEdAcadYearFromId(System.Decimal? _edAcadYearFromId)
		{
			int count = -1;
			return GetByEdAcadYearFromId(_edAcadYearFromId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_ED_ACAD_YEAR key.
		///		FK_SPO_SPONSOR_OFFER_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearFromId">من عام</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		/// <remarks></remarks>
		public TList<SpoSponsorOffer> GetByEdAcadYearFromId(TransactionManager transactionManager, System.Decimal? _edAcadYearFromId)
		{
			int count = -1;
			return GetByEdAcadYearFromId(transactionManager, _edAcadYearFromId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_ED_ACAD_YEAR key.
		///		FK_SPO_SPONSOR_OFFER_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearFromId">من عام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public TList<SpoSponsorOffer> GetByEdAcadYearFromId(TransactionManager transactionManager, System.Decimal? _edAcadYearFromId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearFromId(transactionManager, _edAcadYearFromId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_ED_ACAD_YEAR key.
		///		fkSpoSponsorOfferEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearFromId">من عام</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public TList<SpoSponsorOffer> GetByEdAcadYearFromId(System.Decimal? _edAcadYearFromId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearFromId(null, _edAcadYearFromId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_ED_ACAD_YEAR key.
		///		fkSpoSponsorOfferEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearFromId">من عام</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public TList<SpoSponsorOffer> GetByEdAcadYearFromId(System.Decimal? _edAcadYearFromId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearFromId(null, _edAcadYearFromId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_ED_ACAD_YEAR key.
		///		FK_SPO_SPONSOR_OFFER_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearFromId">من عام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public abstract TList<SpoSponsorOffer> GetByEdAcadYearFromId(TransactionManager transactionManager, System.Decimal? _edAcadYearFromId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_ED_ACAD_YEAR1 key.
		///		FK_SPO_SPONSOR_OFFER_ED_ACAD_YEAR1 Description: 
		/// </summary>
		/// <param name="_edAcadYearToId">الى عام</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public TList<SpoSponsorOffer> GetByEdAcadYearToId(System.Decimal? _edAcadYearToId)
		{
			int count = -1;
			return GetByEdAcadYearToId(_edAcadYearToId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_ED_ACAD_YEAR1 key.
		///		FK_SPO_SPONSOR_OFFER_ED_ACAD_YEAR1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearToId">الى عام</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		/// <remarks></remarks>
		public TList<SpoSponsorOffer> GetByEdAcadYearToId(TransactionManager transactionManager, System.Decimal? _edAcadYearToId)
		{
			int count = -1;
			return GetByEdAcadYearToId(transactionManager, _edAcadYearToId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_ED_ACAD_YEAR1 key.
		///		FK_SPO_SPONSOR_OFFER_ED_ACAD_YEAR1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearToId">الى عام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public TList<SpoSponsorOffer> GetByEdAcadYearToId(TransactionManager transactionManager, System.Decimal? _edAcadYearToId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearToId(transactionManager, _edAcadYearToId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_ED_ACAD_YEAR1 key.
		///		fkSpoSponsorOfferEdAcadYear1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearToId">الى عام</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public TList<SpoSponsorOffer> GetByEdAcadYearToId(System.Decimal? _edAcadYearToId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearToId(null, _edAcadYearToId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_ED_ACAD_YEAR1 key.
		///		fkSpoSponsorOfferEdAcadYear1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearToId">الى عام</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public TList<SpoSponsorOffer> GetByEdAcadYearToId(System.Decimal? _edAcadYearToId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearToId(null, _edAcadYearToId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_ED_ACAD_YEAR1 key.
		///		FK_SPO_SPONSOR_OFFER_ED_ACAD_YEAR1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearToId">الى عام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public abstract TList<SpoSponsorOffer> GetByEdAcadYearToId(TransactionManager transactionManager, System.Decimal? _edAcadYearToId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_ED_CODE_SEMESTER key.
		///		FK_SPO_SPONSOR_OFFER_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterToId">الى فصل</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public TList<SpoSponsorOffer> GetByEdCodeSemesterToId(System.Decimal? _edCodeSemesterToId)
		{
			int count = -1;
			return GetByEdCodeSemesterToId(_edCodeSemesterToId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_ED_CODE_SEMESTER key.
		///		FK_SPO_SPONSOR_OFFER_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterToId">الى فصل</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		/// <remarks></remarks>
		public TList<SpoSponsorOffer> GetByEdCodeSemesterToId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterToId)
		{
			int count = -1;
			return GetByEdCodeSemesterToId(transactionManager, _edCodeSemesterToId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_ED_CODE_SEMESTER key.
		///		FK_SPO_SPONSOR_OFFER_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterToId">الى فصل</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public TList<SpoSponsorOffer> GetByEdCodeSemesterToId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterToId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterToId(transactionManager, _edCodeSemesterToId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_ED_CODE_SEMESTER key.
		///		fkSpoSponsorOfferEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterToId">الى فصل</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public TList<SpoSponsorOffer> GetByEdCodeSemesterToId(System.Decimal? _edCodeSemesterToId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterToId(null, _edCodeSemesterToId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_ED_CODE_SEMESTER key.
		///		fkSpoSponsorOfferEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterToId">الى فصل</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public TList<SpoSponsorOffer> GetByEdCodeSemesterToId(System.Decimal? _edCodeSemesterToId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterToId(null, _edCodeSemesterToId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_ED_CODE_SEMESTER key.
		///		FK_SPO_SPONSOR_OFFER_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterToId">الى فصل</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public abstract TList<SpoSponsorOffer> GetByEdCodeSemesterToId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterToId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_ED_CODE_SEMESTER1 key.
		///		FK_SPO_SPONSOR_OFFER_ED_CODE_SEMESTER1 Description: 
		/// </summary>
		/// <param name="_edCodeSemesterFromId">من فصل</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public TList<SpoSponsorOffer> GetByEdCodeSemesterFromId(System.Decimal? _edCodeSemesterFromId)
		{
			int count = -1;
			return GetByEdCodeSemesterFromId(_edCodeSemesterFromId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_ED_CODE_SEMESTER1 key.
		///		FK_SPO_SPONSOR_OFFER_ED_CODE_SEMESTER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterFromId">من فصل</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		/// <remarks></remarks>
		public TList<SpoSponsorOffer> GetByEdCodeSemesterFromId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterFromId)
		{
			int count = -1;
			return GetByEdCodeSemesterFromId(transactionManager, _edCodeSemesterFromId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_ED_CODE_SEMESTER1 key.
		///		FK_SPO_SPONSOR_OFFER_ED_CODE_SEMESTER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterFromId">من فصل</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public TList<SpoSponsorOffer> GetByEdCodeSemesterFromId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterFromId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterFromId(transactionManager, _edCodeSemesterFromId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_ED_CODE_SEMESTER1 key.
		///		fkSpoSponsorOfferEdCodeSemester1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterFromId">من فصل</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public TList<SpoSponsorOffer> GetByEdCodeSemesterFromId(System.Decimal? _edCodeSemesterFromId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterFromId(null, _edCodeSemesterFromId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_ED_CODE_SEMESTER1 key.
		///		fkSpoSponsorOfferEdCodeSemester1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterFromId">من فصل</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public TList<SpoSponsorOffer> GetByEdCodeSemesterFromId(System.Decimal? _edCodeSemesterFromId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterFromId(null, _edCodeSemesterFromId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_ED_CODE_SEMESTER1 key.
		///		FK_SPO_SPONSOR_OFFER_ED_CODE_SEMESTER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterFromId">من فصل</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public abstract TList<SpoSponsorOffer> GetByEdCodeSemesterFromId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterFromId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_FEE_CODE_TYPE key.
		///		FK_SPO_SPONSOR_OFFER_FEE_CODE_TYPE Description: 
		/// </summary>
		/// <param name="_feeCodeTypeId">نوع المصروف "الكل - دراسي – اخريXXX "</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public TList<SpoSponsorOffer> GetByFeeCodeTypeId(System.Decimal? _feeCodeTypeId)
		{
			int count = -1;
			return GetByFeeCodeTypeId(_feeCodeTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_FEE_CODE_TYPE key.
		///		FK_SPO_SPONSOR_OFFER_FEE_CODE_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeTypeId">نوع المصروف "الكل - دراسي – اخريXXX "</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		/// <remarks></remarks>
		public TList<SpoSponsorOffer> GetByFeeCodeTypeId(TransactionManager transactionManager, System.Decimal? _feeCodeTypeId)
		{
			int count = -1;
			return GetByFeeCodeTypeId(transactionManager, _feeCodeTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_FEE_CODE_TYPE key.
		///		FK_SPO_SPONSOR_OFFER_FEE_CODE_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeTypeId">نوع المصروف "الكل - دراسي – اخريXXX "</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public TList<SpoSponsorOffer> GetByFeeCodeTypeId(TransactionManager transactionManager, System.Decimal? _feeCodeTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeTypeId(transactionManager, _feeCodeTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_FEE_CODE_TYPE key.
		///		fkSpoSponsorOfferFeeCodeType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeTypeId">نوع المصروف "الكل - دراسي – اخريXXX "</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public TList<SpoSponsorOffer> GetByFeeCodeTypeId(System.Decimal? _feeCodeTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCodeTypeId(null, _feeCodeTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_FEE_CODE_TYPE key.
		///		fkSpoSponsorOfferFeeCodeType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeTypeId">نوع المصروف "الكل - دراسي – اخريXXX "</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public TList<SpoSponsorOffer> GetByFeeCodeTypeId(System.Decimal? _feeCodeTypeId, int start, int pageLength,out int count)
		{
			return GetByFeeCodeTypeId(null, _feeCodeTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_FEE_CODE_TYPE key.
		///		FK_SPO_SPONSOR_OFFER_FEE_CODE_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeTypeId">نوع المصروف "الكل - دراسي – اخريXXX "</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public abstract TList<SpoSponsorOffer> GetByFeeCodeTypeId(TransactionManager transactionManager, System.Decimal? _feeCodeTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_GS_CODE_CURRENCY key.
		///		FK_SPO_SPONSOR_OFFER_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="_gsCodeCurrencyId">XXX Later</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public TList<SpoSponsorOffer> GetByGsCodeCurrencyId(System.Decimal? _gsCodeCurrencyId)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(_gsCodeCurrencyId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_GS_CODE_CURRENCY key.
		///		FK_SPO_SPONSOR_OFFER_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId">XXX Later</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		/// <remarks></remarks>
		public TList<SpoSponsorOffer> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal? _gsCodeCurrencyId)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(transactionManager, _gsCodeCurrencyId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_GS_CODE_CURRENCY key.
		///		FK_SPO_SPONSOR_OFFER_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId">XXX Later</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public TList<SpoSponsorOffer> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal? _gsCodeCurrencyId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(transactionManager, _gsCodeCurrencyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_GS_CODE_CURRENCY key.
		///		fkSpoSponsorOfferGsCodeCurrency Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeCurrencyId">XXX Later</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public TList<SpoSponsorOffer> GetByGsCodeCurrencyId(System.Decimal? _gsCodeCurrencyId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeCurrencyId(null, _gsCodeCurrencyId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_GS_CODE_CURRENCY key.
		///		fkSpoSponsorOfferGsCodeCurrency Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeCurrencyId">XXX Later</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public TList<SpoSponsorOffer> GetByGsCodeCurrencyId(System.Decimal? _gsCodeCurrencyId, int start, int pageLength,out int count)
		{
			return GetByGsCodeCurrencyId(null, _gsCodeCurrencyId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_GS_CODE_CURRENCY key.
		///		FK_SPO_SPONSOR_OFFER_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId">XXX Later</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public abstract TList<SpoSponsorOffer> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal? _gsCodeCurrencyId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_SPO_SPONSOR key.
		///		FK_SPO_SPONSOR_OFFER_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="_spoSponsorId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public TList<SpoSponsorOffer> GetBySpoSponsorId(System.Decimal _spoSponsorId)
		{
			int count = -1;
			return GetBySpoSponsorId(_spoSponsorId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_SPO_SPONSOR key.
		///		FK_SPO_SPONSOR_OFFER_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		/// <remarks></remarks>
		public TList<SpoSponsorOffer> GetBySpoSponsorId(TransactionManager transactionManager, System.Decimal _spoSponsorId)
		{
			int count = -1;
			return GetBySpoSponsorId(transactionManager, _spoSponsorId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_SPO_SPONSOR key.
		///		FK_SPO_SPONSOR_OFFER_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public TList<SpoSponsorOffer> GetBySpoSponsorId(TransactionManager transactionManager, System.Decimal _spoSponsorId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorId(transactionManager, _spoSponsorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_SPO_SPONSOR key.
		///		fkSpoSponsorOfferSpoSponsor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public TList<SpoSponsorOffer> GetBySpoSponsorId(System.Decimal _spoSponsorId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySpoSponsorId(null, _spoSponsorId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_SPO_SPONSOR key.
		///		fkSpoSponsorOfferSpoSponsor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public TList<SpoSponsorOffer> GetBySpoSponsorId(System.Decimal _spoSponsorId, int start, int pageLength,out int count)
		{
			return GetBySpoSponsorId(null, _spoSponsorId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_OFFER_SPO_SPONSOR key.
		///		FK_SPO_SPONSOR_OFFER_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorOffer objects.</returns>
		public abstract TList<SpoSponsorOffer> GetBySpoSponsorId(TransactionManager transactionManager, System.Decimal _spoSponsorId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SpoSponsorOffer Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoSponsorOfferKey key, int start, int pageLength)
		{
			return GetBySpoSponsorOfferId(transactionManager, key.SpoSponsorOfferId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SPO_SPONSOR_OFFER index.
		/// </summary>
		/// <param name="_spoSponsorOfferId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorOffer"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorOffer GetBySpoSponsorOfferId(System.Decimal _spoSponsorOfferId)
		{
			int count = -1;
			return GetBySpoSponsorOfferId(null,_spoSponsorOfferId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_SPONSOR_OFFER index.
		/// </summary>
		/// <param name="_spoSponsorOfferId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorOffer"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorOffer GetBySpoSponsorOfferId(System.Decimal _spoSponsorOfferId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorOfferId(null, _spoSponsorOfferId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_SPONSOR_OFFER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorOffer"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorOffer GetBySpoSponsorOfferId(TransactionManager transactionManager, System.Decimal _spoSponsorOfferId)
		{
			int count = -1;
			return GetBySpoSponsorOfferId(transactionManager, _spoSponsorOfferId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_SPONSOR_OFFER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorOffer"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorOffer GetBySpoSponsorOfferId(TransactionManager transactionManager, System.Decimal _spoSponsorOfferId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorOfferId(transactionManager, _spoSponsorOfferId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_SPONSOR_OFFER index.
		/// </summary>
		/// <param name="_spoSponsorOfferId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorOffer"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorOffer GetBySpoSponsorOfferId(System.Decimal _spoSponsorOfferId, int start, int pageLength, out int count)
		{
			return GetBySpoSponsorOfferId(null, _spoSponsorOfferId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_SPONSOR_OFFER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorOffer"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SpoSponsorOffer GetBySpoSponsorOfferId(TransactionManager transactionManager, System.Decimal _spoSponsorOfferId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SpoSponsorOffer&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SpoSponsorOffer&gt;"/></returns>
		public static TList<SpoSponsorOffer> Fill(IDataReader reader, TList<SpoSponsorOffer> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SpoSponsorOffer c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SpoSponsorOffer")
					.Append("|").Append((System.Decimal)reader["SPO_SPONSOR_OFFER_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SpoSponsorOffer>(
					key.ToString(), // EntityTrackingKey
					"SpoSponsorOffer",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SpoSponsorOffer();
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
					c.SpoSponsorOfferId = (System.Decimal)reader["SPO_SPONSOR_OFFER_ID"];
					c.OriginalSpoSponsorOfferId = c.SpoSponsorOfferId;
					c.SpoSponsorId = (System.Decimal)reader["SPO_SPONSOR_ID"];
					c.OfferNameAr = Convert.IsDBNull(reader["OFFER_NAME_AR"]) ? null : (System.String)reader["OFFER_NAME_AR"];
					c.OfferNameEn = Convert.IsDBNull(reader["OFFER_NAME_EN"]) ? null : (System.String)reader["OFFER_NAME_EN"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.AsCodeDegreeClassId = Convert.IsDBNull(reader["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_CLASS_ID"];
					c.ReqDate = Convert.IsDBNull(reader["REQ_DATE"]) ? null : (System.DateTime?)reader["REQ_DATE"];
					c.IsActive = Convert.IsDBNull(reader["IS_ACTIVE"]) ? null : (System.Boolean?)reader["IS_ACTIVE"];
					c.MaxStudCount = Convert.IsDBNull(reader["MAX_STUD_COUNT"]) ? null : (System.Int32?)reader["MAX_STUD_COUNT"];
					c.SpoPercent = Convert.IsDBNull(reader["SPO_PERCENT"]) ? null : (System.Decimal?)reader["SPO_PERCENT"];
					c.SpoAmount = Convert.IsDBNull(reader["SPO_AMOUNT"]) ? null : (System.Decimal?)reader["SPO_AMOUNT"];
					c.GsCodeCurrencyId = Convert.IsDBNull(reader["GS_CODE_CURRENCY_ID"]) ? null : (System.Decimal?)reader["GS_CODE_CURRENCY_ID"];
					c.RepeatCrsFlg = Convert.IsDBNull(reader["REPEAT_CRS_FLG"]) ? null : (System.Boolean?)reader["REPEAT_CRS_FLG"];
					c.RepeatCrsCount = Convert.IsDBNull(reader["REPEAT_CRS_COUNT"]) ? null : (System.Int32?)reader["REPEAT_CRS_COUNT"];
					c.WthdrwCrsFlg = Convert.IsDBNull(reader["WTHDRW_CRS_FLG"]) ? null : (System.Boolean?)reader["WTHDRW_CRS_FLG"];
					c.WthdrwCrsCount = Convert.IsDBNull(reader["WTHDRW_CRS_COUNT"]) ? null : (System.Int32?)reader["WTHDRW_CRS_COUNT"];
					c.RepeatAbsCrsFlg = Convert.IsDBNull(reader["REPEAT_ABS_CRS_FLG"]) ? null : (System.Boolean?)reader["REPEAT_ABS_CRS_FLG"];
					c.RepeatPassedCrsFlg = Convert.IsDBNull(reader["REPEAT_PASSED_CRS_FLG"]) ? null : (System.Boolean?)reader["REPEAT_PASSED_CRS_FLG"];
					c.ThesisFlg = Convert.IsDBNull(reader["THESIS_FLG"]) ? null : (System.Boolean?)reader["THESIS_FLG"];
					c.SemTypeFlg = Convert.IsDBNull(reader["SEM_TYPE_FLG"]) ? null : (System.Decimal?)reader["SEM_TYPE_FLG"];
					c.FeeTypeFlg = Convert.IsDBNull(reader["FEE_TYPE_FLG"]) ? null : (System.Int32?)reader["FEE_TYPE_FLG"];
					c.FeeCodeTypeId = Convert.IsDBNull(reader["FEE_CODE_TYPE_ID"]) ? null : (System.Decimal?)reader["FEE_CODE_TYPE_ID"];
					c.OrientSemCount = Convert.IsDBNull(reader["ORIENT_SEM_COUNT"]) ? null : (System.Decimal?)reader["ORIENT_SEM_COUNT"];
					c.SemCount = Convert.IsDBNull(reader["SEM_COUNT"]) ? null : (System.Decimal?)reader["SEM_COUNT"];
					c.EdAcadYearFromId = Convert.IsDBNull(reader["ED_ACAD_YEAR_FROM_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_FROM_ID"];
					c.EdCodeSemesterFromId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_FROM_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_FROM_ID"];
					c.EdAcadYearToId = Convert.IsDBNull(reader["ED_ACAD_YEAR_TO_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_TO_ID"];
					c.EdCodeSemesterToId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_TO_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_TO_ID"];
					c.ReturnStudBalance = Convert.IsDBNull(reader["RETURN_STUD_BALANCE"]) ? null : (System.Boolean?)reader["RETURN_STUD_BALANCE"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorOffer"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoSponsorOffer"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SpoSponsorOffer entity)
		{
			if (!reader.Read()) return;
			
			entity.SpoSponsorOfferId = (System.Decimal)reader[((int)SpoSponsorOfferColumn.SpoSponsorOfferId - 1)];
			entity.OriginalSpoSponsorOfferId = (System.Decimal)reader["SPO_SPONSOR_OFFER_ID"];
			entity.SpoSponsorId = (System.Decimal)reader[((int)SpoSponsorOfferColumn.SpoSponsorId - 1)];
			entity.OfferNameAr = (reader.IsDBNull(((int)SpoSponsorOfferColumn.OfferNameAr - 1)))?null:(System.String)reader[((int)SpoSponsorOfferColumn.OfferNameAr - 1)];
			entity.OfferNameEn = (reader.IsDBNull(((int)SpoSponsorOfferColumn.OfferNameEn - 1)))?null:(System.String)reader[((int)SpoSponsorOfferColumn.OfferNameEn - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)SpoSponsorOfferColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorOfferColumn.AsFacultyInfoId - 1)];
			entity.AsCodeDegreeClassId = (reader.IsDBNull(((int)SpoSponsorOfferColumn.AsCodeDegreeClassId - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorOfferColumn.AsCodeDegreeClassId - 1)];
			entity.ReqDate = (reader.IsDBNull(((int)SpoSponsorOfferColumn.ReqDate - 1)))?null:(System.DateTime?)reader[((int)SpoSponsorOfferColumn.ReqDate - 1)];
			entity.IsActive = (reader.IsDBNull(((int)SpoSponsorOfferColumn.IsActive - 1)))?null:(System.Boolean?)reader[((int)SpoSponsorOfferColumn.IsActive - 1)];
			entity.MaxStudCount = (reader.IsDBNull(((int)SpoSponsorOfferColumn.MaxStudCount - 1)))?null:(System.Int32?)reader[((int)SpoSponsorOfferColumn.MaxStudCount - 1)];
			entity.SpoPercent = (reader.IsDBNull(((int)SpoSponsorOfferColumn.SpoPercent - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorOfferColumn.SpoPercent - 1)];
			entity.SpoAmount = (reader.IsDBNull(((int)SpoSponsorOfferColumn.SpoAmount - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorOfferColumn.SpoAmount - 1)];
			entity.GsCodeCurrencyId = (reader.IsDBNull(((int)SpoSponsorOfferColumn.GsCodeCurrencyId - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorOfferColumn.GsCodeCurrencyId - 1)];
			entity.RepeatCrsFlg = (reader.IsDBNull(((int)SpoSponsorOfferColumn.RepeatCrsFlg - 1)))?null:(System.Boolean?)reader[((int)SpoSponsorOfferColumn.RepeatCrsFlg - 1)];
			entity.RepeatCrsCount = (reader.IsDBNull(((int)SpoSponsorOfferColumn.RepeatCrsCount - 1)))?null:(System.Int32?)reader[((int)SpoSponsorOfferColumn.RepeatCrsCount - 1)];
			entity.WthdrwCrsFlg = (reader.IsDBNull(((int)SpoSponsorOfferColumn.WthdrwCrsFlg - 1)))?null:(System.Boolean?)reader[((int)SpoSponsorOfferColumn.WthdrwCrsFlg - 1)];
			entity.WthdrwCrsCount = (reader.IsDBNull(((int)SpoSponsorOfferColumn.WthdrwCrsCount - 1)))?null:(System.Int32?)reader[((int)SpoSponsorOfferColumn.WthdrwCrsCount - 1)];
			entity.RepeatAbsCrsFlg = (reader.IsDBNull(((int)SpoSponsorOfferColumn.RepeatAbsCrsFlg - 1)))?null:(System.Boolean?)reader[((int)SpoSponsorOfferColumn.RepeatAbsCrsFlg - 1)];
			entity.RepeatPassedCrsFlg = (reader.IsDBNull(((int)SpoSponsorOfferColumn.RepeatPassedCrsFlg - 1)))?null:(System.Boolean?)reader[((int)SpoSponsorOfferColumn.RepeatPassedCrsFlg - 1)];
			entity.ThesisFlg = (reader.IsDBNull(((int)SpoSponsorOfferColumn.ThesisFlg - 1)))?null:(System.Boolean?)reader[((int)SpoSponsorOfferColumn.ThesisFlg - 1)];
			entity.SemTypeFlg = (reader.IsDBNull(((int)SpoSponsorOfferColumn.SemTypeFlg - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorOfferColumn.SemTypeFlg - 1)];
			entity.FeeTypeFlg = (reader.IsDBNull(((int)SpoSponsorOfferColumn.FeeTypeFlg - 1)))?null:(System.Int32?)reader[((int)SpoSponsorOfferColumn.FeeTypeFlg - 1)];
			entity.FeeCodeTypeId = (reader.IsDBNull(((int)SpoSponsorOfferColumn.FeeCodeTypeId - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorOfferColumn.FeeCodeTypeId - 1)];
			entity.OrientSemCount = (reader.IsDBNull(((int)SpoSponsorOfferColumn.OrientSemCount - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorOfferColumn.OrientSemCount - 1)];
			entity.SemCount = (reader.IsDBNull(((int)SpoSponsorOfferColumn.SemCount - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorOfferColumn.SemCount - 1)];
			entity.EdAcadYearFromId = (reader.IsDBNull(((int)SpoSponsorOfferColumn.EdAcadYearFromId - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorOfferColumn.EdAcadYearFromId - 1)];
			entity.EdCodeSemesterFromId = (reader.IsDBNull(((int)SpoSponsorOfferColumn.EdCodeSemesterFromId - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorOfferColumn.EdCodeSemesterFromId - 1)];
			entity.EdAcadYearToId = (reader.IsDBNull(((int)SpoSponsorOfferColumn.EdAcadYearToId - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorOfferColumn.EdAcadYearToId - 1)];
			entity.EdCodeSemesterToId = (reader.IsDBNull(((int)SpoSponsorOfferColumn.EdCodeSemesterToId - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorOfferColumn.EdCodeSemesterToId - 1)];
			entity.ReturnStudBalance = (reader.IsDBNull(((int)SpoSponsorOfferColumn.ReturnStudBalance - 1)))?null:(System.Boolean?)reader[((int)SpoSponsorOfferColumn.ReturnStudBalance - 1)];
			entity.Notes = (reader.IsDBNull(((int)SpoSponsorOfferColumn.Notes - 1)))?null:(System.String)reader[((int)SpoSponsorOfferColumn.Notes - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)SpoSponsorOfferColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorOfferColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)SpoSponsorOfferColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)SpoSponsorOfferColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorOffer"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoSponsorOffer"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SpoSponsorOffer entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SpoSponsorOfferId = (System.Decimal)dataRow["SPO_SPONSOR_OFFER_ID"];
			entity.OriginalSpoSponsorOfferId = (System.Decimal)dataRow["SPO_SPONSOR_OFFER_ID"];
			entity.SpoSponsorId = (System.Decimal)dataRow["SPO_SPONSOR_ID"];
			entity.OfferNameAr = Convert.IsDBNull(dataRow["OFFER_NAME_AR"]) ? null : (System.String)dataRow["OFFER_NAME_AR"];
			entity.OfferNameEn = Convert.IsDBNull(dataRow["OFFER_NAME_EN"]) ? null : (System.String)dataRow["OFFER_NAME_EN"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.AsCodeDegreeClassId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_CLASS_ID"];
			entity.ReqDate = Convert.IsDBNull(dataRow["REQ_DATE"]) ? null : (System.DateTime?)dataRow["REQ_DATE"];
			entity.IsActive = Convert.IsDBNull(dataRow["IS_ACTIVE"]) ? null : (System.Boolean?)dataRow["IS_ACTIVE"];
			entity.MaxStudCount = Convert.IsDBNull(dataRow["MAX_STUD_COUNT"]) ? null : (System.Int32?)dataRow["MAX_STUD_COUNT"];
			entity.SpoPercent = Convert.IsDBNull(dataRow["SPO_PERCENT"]) ? null : (System.Decimal?)dataRow["SPO_PERCENT"];
			entity.SpoAmount = Convert.IsDBNull(dataRow["SPO_AMOUNT"]) ? null : (System.Decimal?)dataRow["SPO_AMOUNT"];
			entity.GsCodeCurrencyId = Convert.IsDBNull(dataRow["GS_CODE_CURRENCY_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_CURRENCY_ID"];
			entity.RepeatCrsFlg = Convert.IsDBNull(dataRow["REPEAT_CRS_FLG"]) ? null : (System.Boolean?)dataRow["REPEAT_CRS_FLG"];
			entity.RepeatCrsCount = Convert.IsDBNull(dataRow["REPEAT_CRS_COUNT"]) ? null : (System.Int32?)dataRow["REPEAT_CRS_COUNT"];
			entity.WthdrwCrsFlg = Convert.IsDBNull(dataRow["WTHDRW_CRS_FLG"]) ? null : (System.Boolean?)dataRow["WTHDRW_CRS_FLG"];
			entity.WthdrwCrsCount = Convert.IsDBNull(dataRow["WTHDRW_CRS_COUNT"]) ? null : (System.Int32?)dataRow["WTHDRW_CRS_COUNT"];
			entity.RepeatAbsCrsFlg = Convert.IsDBNull(dataRow["REPEAT_ABS_CRS_FLG"]) ? null : (System.Boolean?)dataRow["REPEAT_ABS_CRS_FLG"];
			entity.RepeatPassedCrsFlg = Convert.IsDBNull(dataRow["REPEAT_PASSED_CRS_FLG"]) ? null : (System.Boolean?)dataRow["REPEAT_PASSED_CRS_FLG"];
			entity.ThesisFlg = Convert.IsDBNull(dataRow["THESIS_FLG"]) ? null : (System.Boolean?)dataRow["THESIS_FLG"];
			entity.SemTypeFlg = Convert.IsDBNull(dataRow["SEM_TYPE_FLG"]) ? null : (System.Decimal?)dataRow["SEM_TYPE_FLG"];
			entity.FeeTypeFlg = Convert.IsDBNull(dataRow["FEE_TYPE_FLG"]) ? null : (System.Int32?)dataRow["FEE_TYPE_FLG"];
			entity.FeeCodeTypeId = Convert.IsDBNull(dataRow["FEE_CODE_TYPE_ID"]) ? null : (System.Decimal?)dataRow["FEE_CODE_TYPE_ID"];
			entity.OrientSemCount = Convert.IsDBNull(dataRow["ORIENT_SEM_COUNT"]) ? null : (System.Decimal?)dataRow["ORIENT_SEM_COUNT"];
			entity.SemCount = Convert.IsDBNull(dataRow["SEM_COUNT"]) ? null : (System.Decimal?)dataRow["SEM_COUNT"];
			entity.EdAcadYearFromId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_FROM_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_FROM_ID"];
			entity.EdCodeSemesterFromId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_FROM_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_FROM_ID"];
			entity.EdAcadYearToId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_TO_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_TO_ID"];
			entity.EdCodeSemesterToId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_TO_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_TO_ID"];
			entity.ReturnStudBalance = Convert.IsDBNull(dataRow["RETURN_STUD_BALANCE"]) ? null : (System.Boolean?)dataRow["RETURN_STUD_BALANCE"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoSponsorOffer"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SpoSponsorOffer Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoSponsorOffer entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsCodeDegreeClassIdSource	
			if (CanDeepLoad(entity, "AsCodeDegreeClass|AsCodeDegreeClassIdSource", deepLoadType, innerList) 
				&& entity.AsCodeDegreeClassIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsCodeDegreeClassId ?? 0.0m);
				AsCodeDegreeClass tmpEntity = EntityManager.LocateEntity<AsCodeDegreeClass>(EntityLocator.ConstructKeyFromPkItems(typeof(AsCodeDegreeClass), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsCodeDegreeClassIdSource = tmpEntity;
				else
					entity.AsCodeDegreeClassIdSource = DataRepository.AsCodeDegreeClassProvider.GetByAsCodeDegreeClassId(transactionManager, (entity.AsCodeDegreeClassId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsCodeDegreeClassIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsCodeDegreeClassIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsCodeDegreeClassProvider.DeepLoad(transactionManager, entity.AsCodeDegreeClassIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsCodeDegreeClassIdSource

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

			#region EdAcadYearFromIdSource	
			if (CanDeepLoad(entity, "EdAcadYear|EdAcadYearFromIdSource", deepLoadType, innerList) 
				&& entity.EdAcadYearFromIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdAcadYearFromId ?? 0.0m);
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadYearFromIdSource = tmpEntity;
				else
					entity.EdAcadYearFromIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, (entity.EdAcadYearFromId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadYearFromIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdAcadYearFromIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdAcadYearProvider.DeepLoad(transactionManager, entity.EdAcadYearFromIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdAcadYearFromIdSource

			#region EdAcadYearToIdSource	
			if (CanDeepLoad(entity, "EdAcadYear|EdAcadYearToIdSource", deepLoadType, innerList) 
				&& entity.EdAcadYearToIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdAcadYearToId ?? 0.0m);
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadYearToIdSource = tmpEntity;
				else
					entity.EdAcadYearToIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, (entity.EdAcadYearToId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadYearToIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdAcadYearToIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdAcadYearProvider.DeepLoad(transactionManager, entity.EdAcadYearToIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdAcadYearToIdSource

			#region EdCodeSemesterToIdSource	
			if (CanDeepLoad(entity, "EdCodeSemester|EdCodeSemesterToIdSource", deepLoadType, innerList) 
				&& entity.EdCodeSemesterToIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeSemesterToId ?? 0.0m);
				EdCodeSemester tmpEntity = EntityManager.LocateEntity<EdCodeSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemesterToIdSource = tmpEntity;
				else
					entity.EdCodeSemesterToIdSource = DataRepository.EdCodeSemesterProvider.GetByEdCodeSemesterId(transactionManager, (entity.EdCodeSemesterToId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeSemesterToIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeSemesterToIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeSemesterProvider.DeepLoad(transactionManager, entity.EdCodeSemesterToIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeSemesterToIdSource

			#region EdCodeSemesterFromIdSource	
			if (CanDeepLoad(entity, "EdCodeSemester|EdCodeSemesterFromIdSource", deepLoadType, innerList) 
				&& entity.EdCodeSemesterFromIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeSemesterFromId ?? 0.0m);
				EdCodeSemester tmpEntity = EntityManager.LocateEntity<EdCodeSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemesterFromIdSource = tmpEntity;
				else
					entity.EdCodeSemesterFromIdSource = DataRepository.EdCodeSemesterProvider.GetByEdCodeSemesterId(transactionManager, (entity.EdCodeSemesterFromId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeSemesterFromIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeSemesterFromIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeSemesterProvider.DeepLoad(transactionManager, entity.EdCodeSemesterFromIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeSemesterFromIdSource

			#region FeeCodeTypeIdSource	
			if (CanDeepLoad(entity, "FeeCodeType|FeeCodeTypeIdSource", deepLoadType, innerList) 
				&& entity.FeeCodeTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeCodeTypeId ?? 0.0m);
				FeeCodeType tmpEntity = EntityManager.LocateEntity<FeeCodeType>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCodeType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCodeTypeIdSource = tmpEntity;
				else
					entity.FeeCodeTypeIdSource = DataRepository.FeeCodeTypeProvider.GetByFeeCodeTypeId(transactionManager, (entity.FeeCodeTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCodeTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeCodeTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeCodeTypeProvider.DeepLoad(transactionManager, entity.FeeCodeTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeCodeTypeIdSource

			#region GsCodeCurrencyIdSource	
			if (CanDeepLoad(entity, "GsCodeCurrency|GsCodeCurrencyIdSource", deepLoadType, innerList) 
				&& entity.GsCodeCurrencyIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeCurrencyId ?? 0.0m);
				GsCodeCurrency tmpEntity = EntityManager.LocateEntity<GsCodeCurrency>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeCurrency), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeCurrencyIdSource = tmpEntity;
				else
					entity.GsCodeCurrencyIdSource = DataRepository.GsCodeCurrencyProvider.GetByGsCodeCurrencyId(transactionManager, (entity.GsCodeCurrencyId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeCurrencyIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeCurrencyIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeCurrencyProvider.DeepLoad(transactionManager, entity.GsCodeCurrencyIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeCurrencyIdSource

			#region SpoSponsorIdSource	
			if (CanDeepLoad(entity, "SpoSponsor|SpoSponsorIdSource", deepLoadType, innerList) 
				&& entity.SpoSponsorIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SpoSponsorId;
				SpoSponsor tmpEntity = EntityManager.LocateEntity<SpoSponsor>(EntityLocator.ConstructKeyFromPkItems(typeof(SpoSponsor), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SpoSponsorIdSource = tmpEntity;
				else
					entity.SpoSponsorIdSource = DataRepository.SpoSponsorProvider.GetBySpoSponsorId(transactionManager, entity.SpoSponsorId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SpoSponsorIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SpoSponsorProvider.DeepLoad(transactionManager, entity.SpoSponsorIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SpoSponsorIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySpoSponsorOfferId methods when available
			
			#region SpoSponsorStudSemesterCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoSponsorStudSemester>|SpoSponsorStudSemesterCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorStudSemesterCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoSponsorStudSemesterCollection = DataRepository.SpoSponsorStudSemesterProvider.GetBySpoSponsorOfferId(transactionManager, entity.SpoSponsorOfferId);

				if (deep && entity.SpoSponsorStudSemesterCollection.Count > 0)
				{
					deepHandles.Add("SpoSponsorStudSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoSponsorStudSemester>) DataRepository.SpoSponsorStudSemesterProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoSponsorStudSemesterCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SpoOfferStudExceptionCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoOfferStudException>|SpoOfferStudExceptionCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoOfferStudExceptionCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoOfferStudExceptionCollection = DataRepository.SpoOfferStudExceptionProvider.GetBySpoSponsorOfferId(transactionManager, entity.SpoSponsorOfferId);

				if (deep && entity.SpoOfferStudExceptionCollection.Count > 0)
				{
					deepHandles.Add("SpoOfferStudExceptionCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoOfferStudException>) DataRepository.SpoOfferStudExceptionProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoOfferStudExceptionCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SpoSponsorStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoSponsorStud>|SpoSponsorStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoSponsorStudCollection = DataRepository.SpoSponsorStudProvider.GetBySpoSponsorOfferId(transactionManager, entity.SpoSponsorOfferId);

				if (deep && entity.SpoSponsorStudCollection.Count > 0)
				{
					deepHandles.Add("SpoSponsorStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoSponsorStud>) DataRepository.SpoSponsorStudProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoSponsorStudCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SpoSponsorOfferExtCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoSponsorOfferExt>|SpoSponsorOfferExtCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorOfferExtCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoSponsorOfferExtCollection = DataRepository.SpoSponsorOfferExtProvider.GetBySpoSponsorOfferId(transactionManager, entity.SpoSponsorOfferId);

				if (deep && entity.SpoSponsorOfferExtCollection.Count > 0)
				{
					deepHandles.Add("SpoSponsorOfferExtCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoSponsorOfferExt>) DataRepository.SpoSponsorOfferExtProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoSponsorOfferExtCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SpoSponsorFeeItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoSponsorFeeItem>|SpoSponsorFeeItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorFeeItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoSponsorFeeItemCollection = DataRepository.SpoSponsorFeeItemProvider.GetBySpoSponsorOfferId(transactionManager, entity.SpoSponsorOfferId);

				if (deep && entity.SpoSponsorFeeItemCollection.Count > 0)
				{
					deepHandles.Add("SpoSponsorFeeItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoSponsorFeeItem>) DataRepository.SpoSponsorFeeItemProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoSponsorFeeItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SpoOfferContinueCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoOfferContinue>|SpoOfferContinueCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoOfferContinueCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoOfferContinueCollection = DataRepository.SpoOfferContinueProvider.GetBySpoSponsorOfferId(transactionManager, entity.SpoSponsorOfferId);

				if (deep && entity.SpoOfferContinueCollection.Count > 0)
				{
					deepHandles.Add("SpoOfferContinueCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoOfferContinue>) DataRepository.SpoOfferContinueProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoOfferContinueCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SpoSponsorOffer object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SpoSponsorOffer instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SpoSponsorOffer Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoSponsorOffer entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AsCodeDegreeClassIdSource
			if (CanDeepSave(entity, "AsCodeDegreeClass|AsCodeDegreeClassIdSource", deepSaveType, innerList) 
				&& entity.AsCodeDegreeClassIdSource != null)
			{
				DataRepository.AsCodeDegreeClassProvider.Save(transactionManager, entity.AsCodeDegreeClassIdSource);
				entity.AsCodeDegreeClassId = entity.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
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
			
			#region EdAcadYearFromIdSource
			if (CanDeepSave(entity, "EdAcadYear|EdAcadYearFromIdSource", deepSaveType, innerList) 
				&& entity.EdAcadYearFromIdSource != null)
			{
				DataRepository.EdAcadYearProvider.Save(transactionManager, entity.EdAcadYearFromIdSource);
				entity.EdAcadYearFromId = entity.EdAcadYearFromIdSource.EdAcadYearId;
			}
			#endregion 
			
			#region EdAcadYearToIdSource
			if (CanDeepSave(entity, "EdAcadYear|EdAcadYearToIdSource", deepSaveType, innerList) 
				&& entity.EdAcadYearToIdSource != null)
			{
				DataRepository.EdAcadYearProvider.Save(transactionManager, entity.EdAcadYearToIdSource);
				entity.EdAcadYearToId = entity.EdAcadYearToIdSource.EdAcadYearId;
			}
			#endregion 
			
			#region EdCodeSemesterToIdSource
			if (CanDeepSave(entity, "EdCodeSemester|EdCodeSemesterToIdSource", deepSaveType, innerList) 
				&& entity.EdCodeSemesterToIdSource != null)
			{
				DataRepository.EdCodeSemesterProvider.Save(transactionManager, entity.EdCodeSemesterToIdSource);
				entity.EdCodeSemesterToId = entity.EdCodeSemesterToIdSource.EdCodeSemesterId;
			}
			#endregion 
			
			#region EdCodeSemesterFromIdSource
			if (CanDeepSave(entity, "EdCodeSemester|EdCodeSemesterFromIdSource", deepSaveType, innerList) 
				&& entity.EdCodeSemesterFromIdSource != null)
			{
				DataRepository.EdCodeSemesterProvider.Save(transactionManager, entity.EdCodeSemesterFromIdSource);
				entity.EdCodeSemesterFromId = entity.EdCodeSemesterFromIdSource.EdCodeSemesterId;
			}
			#endregion 
			
			#region FeeCodeTypeIdSource
			if (CanDeepSave(entity, "FeeCodeType|FeeCodeTypeIdSource", deepSaveType, innerList) 
				&& entity.FeeCodeTypeIdSource != null)
			{
				DataRepository.FeeCodeTypeProvider.Save(transactionManager, entity.FeeCodeTypeIdSource);
				entity.FeeCodeTypeId = entity.FeeCodeTypeIdSource.FeeCodeTypeId;
			}
			#endregion 
			
			#region GsCodeCurrencyIdSource
			if (CanDeepSave(entity, "GsCodeCurrency|GsCodeCurrencyIdSource", deepSaveType, innerList) 
				&& entity.GsCodeCurrencyIdSource != null)
			{
				DataRepository.GsCodeCurrencyProvider.Save(transactionManager, entity.GsCodeCurrencyIdSource);
				entity.GsCodeCurrencyId = entity.GsCodeCurrencyIdSource.GsCodeCurrencyId;
			}
			#endregion 
			
			#region SpoSponsorIdSource
			if (CanDeepSave(entity, "SpoSponsor|SpoSponsorIdSource", deepSaveType, innerList) 
				&& entity.SpoSponsorIdSource != null)
			{
				DataRepository.SpoSponsorProvider.Save(transactionManager, entity.SpoSponsorIdSource);
				entity.SpoSponsorId = entity.SpoSponsorIdSource.SpoSponsorId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SpoSponsorStudSemester>
				if (CanDeepSave(entity.SpoSponsorStudSemesterCollection, "List<SpoSponsorStudSemester>|SpoSponsorStudSemesterCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoSponsorStudSemester child in entity.SpoSponsorStudSemesterCollection)
					{
						if(child.SpoSponsorOfferIdSource != null)
						{
							child.SpoSponsorOfferId = child.SpoSponsorOfferIdSource.SpoSponsorOfferId;
						}
						else
						{
							child.SpoSponsorOfferId = entity.SpoSponsorOfferId;
						}

					}

					if (entity.SpoSponsorStudSemesterCollection.Count > 0 || entity.SpoSponsorStudSemesterCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SpoSponsorStudSemesterProvider.Save(transactionManager, entity.SpoSponsorStudSemesterCollection);
						
						deepHandles.Add("SpoSponsorStudSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoSponsorStudSemester >) DataRepository.SpoSponsorStudSemesterProvider.DeepSave,
							new object[] { transactionManager, entity.SpoSponsorStudSemesterCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SpoOfferStudException>
				if (CanDeepSave(entity.SpoOfferStudExceptionCollection, "List<SpoOfferStudException>|SpoOfferStudExceptionCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoOfferStudException child in entity.SpoOfferStudExceptionCollection)
					{
						if(child.SpoSponsorOfferIdSource != null)
						{
							child.SpoSponsorOfferId = child.SpoSponsorOfferIdSource.SpoSponsorOfferId;
						}
						else
						{
							child.SpoSponsorOfferId = entity.SpoSponsorOfferId;
						}

					}

					if (entity.SpoOfferStudExceptionCollection.Count > 0 || entity.SpoOfferStudExceptionCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SpoOfferStudExceptionProvider.Save(transactionManager, entity.SpoOfferStudExceptionCollection);
						
						deepHandles.Add("SpoOfferStudExceptionCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoOfferStudException >) DataRepository.SpoOfferStudExceptionProvider.DeepSave,
							new object[] { transactionManager, entity.SpoOfferStudExceptionCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SpoSponsorStud>
				if (CanDeepSave(entity.SpoSponsorStudCollection, "List<SpoSponsorStud>|SpoSponsorStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoSponsorStud child in entity.SpoSponsorStudCollection)
					{
						if(child.SpoSponsorOfferIdSource != null)
						{
							child.SpoSponsorOfferId = child.SpoSponsorOfferIdSource.SpoSponsorOfferId;
						}
						else
						{
							child.SpoSponsorOfferId = entity.SpoSponsorOfferId;
						}

					}

					if (entity.SpoSponsorStudCollection.Count > 0 || entity.SpoSponsorStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SpoSponsorStudProvider.Save(transactionManager, entity.SpoSponsorStudCollection);
						
						deepHandles.Add("SpoSponsorStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoSponsorStud >) DataRepository.SpoSponsorStudProvider.DeepSave,
							new object[] { transactionManager, entity.SpoSponsorStudCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SpoSponsorOfferExt>
				if (CanDeepSave(entity.SpoSponsorOfferExtCollection, "List<SpoSponsorOfferExt>|SpoSponsorOfferExtCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoSponsorOfferExt child in entity.SpoSponsorOfferExtCollection)
					{
						if(child.SpoSponsorOfferIdSource != null)
						{
							child.SpoSponsorOfferId = child.SpoSponsorOfferIdSource.SpoSponsorOfferId;
						}
						else
						{
							child.SpoSponsorOfferId = entity.SpoSponsorOfferId;
						}

					}

					if (entity.SpoSponsorOfferExtCollection.Count > 0 || entity.SpoSponsorOfferExtCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SpoSponsorOfferExtProvider.Save(transactionManager, entity.SpoSponsorOfferExtCollection);
						
						deepHandles.Add("SpoSponsorOfferExtCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoSponsorOfferExt >) DataRepository.SpoSponsorOfferExtProvider.DeepSave,
							new object[] { transactionManager, entity.SpoSponsorOfferExtCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SpoSponsorFeeItem>
				if (CanDeepSave(entity.SpoSponsorFeeItemCollection, "List<SpoSponsorFeeItem>|SpoSponsorFeeItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoSponsorFeeItem child in entity.SpoSponsorFeeItemCollection)
					{
						if(child.SpoSponsorOfferIdSource != null)
						{
							child.SpoSponsorOfferId = child.SpoSponsorOfferIdSource.SpoSponsorOfferId;
						}
						else
						{
							child.SpoSponsorOfferId = entity.SpoSponsorOfferId;
						}

					}

					if (entity.SpoSponsorFeeItemCollection.Count > 0 || entity.SpoSponsorFeeItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SpoSponsorFeeItemProvider.Save(transactionManager, entity.SpoSponsorFeeItemCollection);
						
						deepHandles.Add("SpoSponsorFeeItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoSponsorFeeItem >) DataRepository.SpoSponsorFeeItemProvider.DeepSave,
							new object[] { transactionManager, entity.SpoSponsorFeeItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SpoOfferContinue>
				if (CanDeepSave(entity.SpoOfferContinueCollection, "List<SpoOfferContinue>|SpoOfferContinueCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoOfferContinue child in entity.SpoOfferContinueCollection)
					{
						if(child.SpoSponsorOfferIdSource != null)
						{
							child.SpoSponsorOfferId = child.SpoSponsorOfferIdSource.SpoSponsorOfferId;
						}
						else
						{
							child.SpoSponsorOfferId = entity.SpoSponsorOfferId;
						}

					}

					if (entity.SpoOfferContinueCollection.Count > 0 || entity.SpoOfferContinueCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SpoOfferContinueProvider.Save(transactionManager, entity.SpoOfferContinueCollection);
						
						deepHandles.Add("SpoOfferContinueCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoOfferContinue >) DataRepository.SpoOfferContinueProvider.DeepSave,
							new object[] { transactionManager, entity.SpoOfferContinueCollection, deepSaveType, childTypes, innerList }
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
	
	#region SpoSponsorOfferChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SpoSponsorOffer</c>
	///</summary>
	public enum SpoSponsorOfferChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsCodeDegreeClass</c> at AsCodeDegreeClassIdSource
		///</summary>
		[ChildEntityType(typeof(AsCodeDegreeClass))]
		AsCodeDegreeClass,
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearFromIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>EdCodeSemester</c> at EdCodeSemesterToIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemester))]
		EdCodeSemester,
		
		///<summary>
		/// Composite Property for <c>FeeCodeType</c> at FeeCodeTypeIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCodeType))]
		FeeCodeType,
		
		///<summary>
		/// Composite Property for <c>GsCodeCurrency</c> at GsCodeCurrencyIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeCurrency))]
		GsCodeCurrency,
		
		///<summary>
		/// Composite Property for <c>SpoSponsor</c> at SpoSponsorIdSource
		///</summary>
		[ChildEntityType(typeof(SpoSponsor))]
		SpoSponsor,
		///<summary>
		/// Collection of <c>SpoSponsorOffer</c> as OneToMany for SpoSponsorStudSemesterCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoSponsorStudSemester>))]
		SpoSponsorStudSemesterCollection,
		///<summary>
		/// Collection of <c>SpoSponsorOffer</c> as OneToMany for SpoOfferStudExceptionCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoOfferStudException>))]
		SpoOfferStudExceptionCollection,
		///<summary>
		/// Collection of <c>SpoSponsorOffer</c> as OneToMany for SpoSponsorStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoSponsorStud>))]
		SpoSponsorStudCollection,
		///<summary>
		/// Collection of <c>SpoSponsorOffer</c> as OneToMany for SpoSponsorOfferExtCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoSponsorOfferExt>))]
		SpoSponsorOfferExtCollection,
		///<summary>
		/// Collection of <c>SpoSponsorOffer</c> as OneToMany for SpoSponsorFeeItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoSponsorFeeItem>))]
		SpoSponsorFeeItemCollection,
		///<summary>
		/// Collection of <c>SpoSponsorOffer</c> as OneToMany for SpoOfferContinueCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoOfferContinue>))]
		SpoOfferContinueCollection,
	}
	
	#endregion SpoSponsorOfferChildEntityTypes
	
	#region SpoSponsorOfferFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SpoSponsorOfferColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoSponsorOffer"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SpoSponsorOfferFilterBuilder : SqlFilterBuilder<SpoSponsorOfferColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoSponsorOfferFilterBuilder class.
		/// </summary>
		public SpoSponsorOfferFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SpoSponsorOfferFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SpoSponsorOfferFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SpoSponsorOfferFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SpoSponsorOfferFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SpoSponsorOfferFilterBuilder
	
	#region SpoSponsorOfferParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SpoSponsorOfferColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoSponsorOffer"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SpoSponsorOfferParameterBuilder : ParameterizedSqlFilterBuilder<SpoSponsorOfferColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoSponsorOfferParameterBuilder class.
		/// </summary>
		public SpoSponsorOfferParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SpoSponsorOfferParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SpoSponsorOfferParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SpoSponsorOfferParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SpoSponsorOfferParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SpoSponsorOfferParameterBuilder
	
	#region SpoSponsorOfferSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SpoSponsorOfferColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoSponsorOffer"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SpoSponsorOfferSortBuilder : SqlSortBuilder<SpoSponsorOfferColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoSponsorOfferSqlSortBuilder class.
		/// </summary>
		public SpoSponsorOfferSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SpoSponsorOfferSortBuilder
	
} // end namespace
