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
	/// This class is the base class for any <see cref="PgExtMemberProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PgExtMemberProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.PgExtMember, UMIS_VER2.BusinessLyer.PgExtMemberKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgExtMemberKey key)
		{
			return Delete(transactionManager, key.PgExtMemberId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_pgExtMemberId">مسلسل مشرف/محكم خارجى. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _pgExtMemberId)
		{
			return Delete(null, _pgExtMemberId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgExtMemberId">مسلسل مشرف/محكم خارجى. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _pgExtMemberId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_039b key.
		///		FK_AUTO_039b Description: 
		/// </summary>
		/// <param name="_saCodeScDegId">الدرجة العلمية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgExtMember objects.</returns>
		public TList<PgExtMember> GetBySaCodeScDegId(System.Decimal _saCodeScDegId)
		{
			int count = -1;
			return GetBySaCodeScDegId(_saCodeScDegId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_039b key.
		///		FK_AUTO_039b Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId">الدرجة العلمية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgExtMember objects.</returns>
		/// <remarks></remarks>
		public TList<PgExtMember> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal _saCodeScDegId)
		{
			int count = -1;
			return GetBySaCodeScDegId(transactionManager, _saCodeScDegId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_039b key.
		///		FK_AUTO_039b Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId">الدرجة العلمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgExtMember objects.</returns>
		public TList<PgExtMember> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal _saCodeScDegId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeScDegId(transactionManager, _saCodeScDegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_039b key.
		///		fkAuto039b Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeScDegId">الدرجة العلمية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgExtMember objects.</returns>
		public TList<PgExtMember> GetBySaCodeScDegId(System.Decimal _saCodeScDegId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaCodeScDegId(null, _saCodeScDegId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_039b key.
		///		fkAuto039b Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeScDegId">الدرجة العلمية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgExtMember objects.</returns>
		public TList<PgExtMember> GetBySaCodeScDegId(System.Decimal _saCodeScDegId, int start, int pageLength,out int count)
		{
			return GetBySaCodeScDegId(null, _saCodeScDegId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_039b key.
		///		FK_AUTO_039b Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId">الدرجة العلمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgExtMember objects.</returns>
		public abstract TList<PgExtMember> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal _saCodeScDegId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_EXT_MEMBER_GS_CDE_UNIVERSITIES key.
		///		FK_PG_EXT_MEMBER_GS_CDE_UNIVERSITIES Description: 
		/// </summary>
		/// <param name="_gsCdeUniversitiesId">اسم الجامعه</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgExtMember objects.</returns>
		public TList<PgExtMember> GetByGsCdeUniversitiesId(System.Decimal? _gsCdeUniversitiesId)
		{
			int count = -1;
			return GetByGsCdeUniversitiesId(_gsCdeUniversitiesId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_EXT_MEMBER_GS_CDE_UNIVERSITIES key.
		///		FK_PG_EXT_MEMBER_GS_CDE_UNIVERSITIES Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeUniversitiesId">اسم الجامعه</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgExtMember objects.</returns>
		/// <remarks></remarks>
		public TList<PgExtMember> GetByGsCdeUniversitiesId(TransactionManager transactionManager, System.Decimal? _gsCdeUniversitiesId)
		{
			int count = -1;
			return GetByGsCdeUniversitiesId(transactionManager, _gsCdeUniversitiesId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_EXT_MEMBER_GS_CDE_UNIVERSITIES key.
		///		FK_PG_EXT_MEMBER_GS_CDE_UNIVERSITIES Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeUniversitiesId">اسم الجامعه</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgExtMember objects.</returns>
		public TList<PgExtMember> GetByGsCdeUniversitiesId(TransactionManager transactionManager, System.Decimal? _gsCdeUniversitiesId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeUniversitiesId(transactionManager, _gsCdeUniversitiesId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_EXT_MEMBER_GS_CDE_UNIVERSITIES key.
		///		fkPgExtMemberGsCdeUniversities Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeUniversitiesId">اسم الجامعه</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgExtMember objects.</returns>
		public TList<PgExtMember> GetByGsCdeUniversitiesId(System.Decimal? _gsCdeUniversitiesId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeUniversitiesId(null, _gsCdeUniversitiesId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_EXT_MEMBER_GS_CDE_UNIVERSITIES key.
		///		fkPgExtMemberGsCdeUniversities Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeUniversitiesId">اسم الجامعه</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgExtMember objects.</returns>
		public TList<PgExtMember> GetByGsCdeUniversitiesId(System.Decimal? _gsCdeUniversitiesId, int start, int pageLength,out int count)
		{
			return GetByGsCdeUniversitiesId(null, _gsCdeUniversitiesId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_EXT_MEMBER_GS_CDE_UNIVERSITIES key.
		///		FK_PG_EXT_MEMBER_GS_CDE_UNIVERSITIES Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeUniversitiesId">اسم الجامعه</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgExtMember objects.</returns>
		public abstract TList<PgExtMember> GetByGsCdeUniversitiesId(TransactionManager transactionManager, System.Decimal? _gsCdeUniversitiesId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_EXT_MEMBER_GS_CODE_GENDER key.
		///		FK_PG_EXT_MEMBER_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="_gsCodeGenderId">النوع (ذكر أو انثى)</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgExtMember objects.</returns>
		public TList<PgExtMember> GetByGsCodeGenderId(System.Decimal _gsCodeGenderId)
		{
			int count = -1;
			return GetByGsCodeGenderId(_gsCodeGenderId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_EXT_MEMBER_GS_CODE_GENDER key.
		///		FK_PG_EXT_MEMBER_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId">النوع (ذكر أو انثى)</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgExtMember objects.</returns>
		/// <remarks></remarks>
		public TList<PgExtMember> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal _gsCodeGenderId)
		{
			int count = -1;
			return GetByGsCodeGenderId(transactionManager, _gsCodeGenderId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_EXT_MEMBER_GS_CODE_GENDER key.
		///		FK_PG_EXT_MEMBER_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId">النوع (ذكر أو انثى)</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgExtMember objects.</returns>
		public TList<PgExtMember> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal _gsCodeGenderId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeGenderId(transactionManager, _gsCodeGenderId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_EXT_MEMBER_GS_CODE_GENDER key.
		///		fkPgExtMemberGsCodeGender Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeGenderId">النوع (ذكر أو انثى)</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgExtMember objects.</returns>
		public TList<PgExtMember> GetByGsCodeGenderId(System.Decimal _gsCodeGenderId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeGenderId(null, _gsCodeGenderId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_EXT_MEMBER_GS_CODE_GENDER key.
		///		fkPgExtMemberGsCodeGender Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeGenderId">النوع (ذكر أو انثى)</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgExtMember objects.</returns>
		public TList<PgExtMember> GetByGsCodeGenderId(System.Decimal _gsCodeGenderId, int start, int pageLength,out int count)
		{
			return GetByGsCodeGenderId(null, _gsCodeGenderId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_EXT_MEMBER_GS_CODE_GENDER key.
		///		FK_PG_EXT_MEMBER_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId">النوع (ذكر أو انثى)</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgExtMember objects.</returns>
		public abstract TList<PgExtMember> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal _gsCodeGenderId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_EXT_MEMBER_GS_CODE_IDENT_TYPE key.
		///		FK_PG_EXT_MEMBER_GS_CODE_IDENT_TYPE Description: 
		/// </summary>
		/// <param name="_gsCodeIdentTypeId">نوع تحقيق الشخصية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgExtMember objects.</returns>
		public TList<PgExtMember> GetByGsCodeIdentTypeId(System.Decimal? _gsCodeIdentTypeId)
		{
			int count = -1;
			return GetByGsCodeIdentTypeId(_gsCodeIdentTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_EXT_MEMBER_GS_CODE_IDENT_TYPE key.
		///		FK_PG_EXT_MEMBER_GS_CODE_IDENT_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeIdentTypeId">نوع تحقيق الشخصية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgExtMember objects.</returns>
		/// <remarks></remarks>
		public TList<PgExtMember> GetByGsCodeIdentTypeId(TransactionManager transactionManager, System.Decimal? _gsCodeIdentTypeId)
		{
			int count = -1;
			return GetByGsCodeIdentTypeId(transactionManager, _gsCodeIdentTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_EXT_MEMBER_GS_CODE_IDENT_TYPE key.
		///		FK_PG_EXT_MEMBER_GS_CODE_IDENT_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeIdentTypeId">نوع تحقيق الشخصية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgExtMember objects.</returns>
		public TList<PgExtMember> GetByGsCodeIdentTypeId(TransactionManager transactionManager, System.Decimal? _gsCodeIdentTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeIdentTypeId(transactionManager, _gsCodeIdentTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_EXT_MEMBER_GS_CODE_IDENT_TYPE key.
		///		fkPgExtMemberGsCodeIdentType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeIdentTypeId">نوع تحقيق الشخصية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgExtMember objects.</returns>
		public TList<PgExtMember> GetByGsCodeIdentTypeId(System.Decimal? _gsCodeIdentTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeIdentTypeId(null, _gsCodeIdentTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_EXT_MEMBER_GS_CODE_IDENT_TYPE key.
		///		fkPgExtMemberGsCodeIdentType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeIdentTypeId">نوع تحقيق الشخصية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgExtMember objects.</returns>
		public TList<PgExtMember> GetByGsCodeIdentTypeId(System.Decimal? _gsCodeIdentTypeId, int start, int pageLength,out int count)
		{
			return GetByGsCodeIdentTypeId(null, _gsCodeIdentTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_EXT_MEMBER_GS_CODE_IDENT_TYPE key.
		///		FK_PG_EXT_MEMBER_GS_CODE_IDENT_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeIdentTypeId">نوع تحقيق الشخصية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgExtMember objects.</returns>
		public abstract TList<PgExtMember> GetByGsCodeIdentTypeId(TransactionManager transactionManager, System.Decimal? _gsCodeIdentTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_EXT_MEMBER_GS_COUNTRY_NODE key.
		///		FK_PG_EXT_MEMBER_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="_gsCountryInfoId">الجنسية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgExtMember objects.</returns>
		public TList<PgExtMember> GetByGsCountryInfoId(System.Decimal? _gsCountryInfoId)
		{
			int count = -1;
			return GetByGsCountryInfoId(_gsCountryInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_EXT_MEMBER_GS_COUNTRY_NODE key.
		///		FK_PG_EXT_MEMBER_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryInfoId">الجنسية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgExtMember objects.</returns>
		/// <remarks></remarks>
		public TList<PgExtMember> GetByGsCountryInfoId(TransactionManager transactionManager, System.Decimal? _gsCountryInfoId)
		{
			int count = -1;
			return GetByGsCountryInfoId(transactionManager, _gsCountryInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_EXT_MEMBER_GS_COUNTRY_NODE key.
		///		FK_PG_EXT_MEMBER_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryInfoId">الجنسية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgExtMember objects.</returns>
		public TList<PgExtMember> GetByGsCountryInfoId(TransactionManager transactionManager, System.Decimal? _gsCountryInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryInfoId(transactionManager, _gsCountryInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_EXT_MEMBER_GS_COUNTRY_NODE key.
		///		fkPgExtMemberGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryInfoId">الجنسية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgExtMember objects.</returns>
		public TList<PgExtMember> GetByGsCountryInfoId(System.Decimal? _gsCountryInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCountryInfoId(null, _gsCountryInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_EXT_MEMBER_GS_COUNTRY_NODE key.
		///		fkPgExtMemberGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryInfoId">الجنسية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgExtMember objects.</returns>
		public TList<PgExtMember> GetByGsCountryInfoId(System.Decimal? _gsCountryInfoId, int start, int pageLength,out int count)
		{
			return GetByGsCountryInfoId(null, _gsCountryInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_EXT_MEMBER_GS_COUNTRY_NODE key.
		///		FK_PG_EXT_MEMBER_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryInfoId">الجنسية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgExtMember objects.</returns>
		public abstract TList<PgExtMember> GetByGsCountryInfoId(TransactionManager transactionManager, System.Decimal? _gsCountryInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_EXT_MEMBER_SA_CODE_ORG key.
		///		FK_PG_EXT_MEMBER_SA_CODE_ORG Description: 
		/// </summary>
		/// <param name="_saCodeOrgId">XXX'جهة العمل'XX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgExtMember objects.</returns>
		public TList<PgExtMember> GetBySaCodeOrgId(System.Decimal? _saCodeOrgId)
		{
			int count = -1;
			return GetBySaCodeOrgId(_saCodeOrgId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_EXT_MEMBER_SA_CODE_ORG key.
		///		FK_PG_EXT_MEMBER_SA_CODE_ORG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeOrgId">XXX'جهة العمل'XX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgExtMember objects.</returns>
		/// <remarks></remarks>
		public TList<PgExtMember> GetBySaCodeOrgId(TransactionManager transactionManager, System.Decimal? _saCodeOrgId)
		{
			int count = -1;
			return GetBySaCodeOrgId(transactionManager, _saCodeOrgId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_EXT_MEMBER_SA_CODE_ORG key.
		///		FK_PG_EXT_MEMBER_SA_CODE_ORG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeOrgId">XXX'جهة العمل'XX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgExtMember objects.</returns>
		public TList<PgExtMember> GetBySaCodeOrgId(TransactionManager transactionManager, System.Decimal? _saCodeOrgId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeOrgId(transactionManager, _saCodeOrgId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_EXT_MEMBER_SA_CODE_ORG key.
		///		fkPgExtMemberSaCodeOrg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeOrgId">XXX'جهة العمل'XX</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgExtMember objects.</returns>
		public TList<PgExtMember> GetBySaCodeOrgId(System.Decimal? _saCodeOrgId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaCodeOrgId(null, _saCodeOrgId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_EXT_MEMBER_SA_CODE_ORG key.
		///		fkPgExtMemberSaCodeOrg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeOrgId">XXX'جهة العمل'XX</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgExtMember objects.</returns>
		public TList<PgExtMember> GetBySaCodeOrgId(System.Decimal? _saCodeOrgId, int start, int pageLength,out int count)
		{
			return GetBySaCodeOrgId(null, _saCodeOrgId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_EXT_MEMBER_SA_CODE_ORG key.
		///		FK_PG_EXT_MEMBER_SA_CODE_ORG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeOrgId">XXX'جهة العمل'XX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgExtMember objects.</returns>
		public abstract TList<PgExtMember> GetBySaCodeOrgId(TransactionManager transactionManager, System.Decimal? _saCodeOrgId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.PgExtMember Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgExtMemberKey key, int start, int pageLength)
		{
			return GetByPgExtMemberId(transactionManager, key.PgExtMemberId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PG_EXT_SUPERVISOR index.
		/// </summary>
		/// <param name="_pgExtMemberId">مسلسل مشرف/محكم خارجى</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgExtMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgExtMember GetByPgExtMemberId(System.Decimal _pgExtMemberId)
		{
			int count = -1;
			return GetByPgExtMemberId(null,_pgExtMemberId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_EXT_SUPERVISOR index.
		/// </summary>
		/// <param name="_pgExtMemberId">مسلسل مشرف/محكم خارجى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgExtMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgExtMember GetByPgExtMemberId(System.Decimal _pgExtMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgExtMemberId(null, _pgExtMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_EXT_SUPERVISOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgExtMemberId">مسلسل مشرف/محكم خارجى</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgExtMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgExtMember GetByPgExtMemberId(TransactionManager transactionManager, System.Decimal _pgExtMemberId)
		{
			int count = -1;
			return GetByPgExtMemberId(transactionManager, _pgExtMemberId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_EXT_SUPERVISOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgExtMemberId">مسلسل مشرف/محكم خارجى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgExtMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgExtMember GetByPgExtMemberId(TransactionManager transactionManager, System.Decimal _pgExtMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgExtMemberId(transactionManager, _pgExtMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_EXT_SUPERVISOR index.
		/// </summary>
		/// <param name="_pgExtMemberId">مسلسل مشرف/محكم خارجى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgExtMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgExtMember GetByPgExtMemberId(System.Decimal _pgExtMemberId, int start, int pageLength, out int count)
		{
			return GetByPgExtMemberId(null, _pgExtMemberId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_EXT_SUPERVISOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgExtMemberId">مسلسل مشرف/محكم خارجى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgExtMember"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgExtMember GetByPgExtMemberId(TransactionManager transactionManager, System.Decimal _pgExtMemberId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PgExtMember&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PgExtMember&gt;"/></returns>
		public static TList<PgExtMember> Fill(IDataReader reader, TList<PgExtMember> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.PgExtMember c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PgExtMember")
					.Append("|").Append((System.Decimal)reader["PG_EXT_MEMBER_ID"]).ToString();
					c = EntityManager.LocateOrCreate<PgExtMember>(
					key.ToString(), // EntityTrackingKey
					"PgExtMember",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.PgExtMember();
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
					c.PgExtMemberId = (System.Decimal)reader["PG_EXT_MEMBER_ID"];
					c.OriginalPgExtMemberId = c.PgExtMemberId;
					c.MemberCode = Convert.IsDBNull(reader["MEMBER_CODE"]) ? null : (System.String)reader["MEMBER_CODE"];
					c.MemberNameAr = (System.String)reader["MEMBER_NAME_AR"];
					c.MemberNameEn = Convert.IsDBNull(reader["MEMBER_NAME_EN"]) ? null : (System.String)reader["MEMBER_NAME_EN"];
					c.GsCodeGenderId = (System.Decimal)reader["GS_CODE_GENDER_ID"];
					c.MemberJob = (System.String)reader["MEMBER_JOB"];
					c.MemberHireDate = Convert.IsDBNull(reader["MEMBER_HIRE_DATE"]) ? null : (System.DateTime?)reader["MEMBER_HIRE_DATE"];
					c.WorkPlaceType = (System.Decimal)reader["WORK_PLACE_TYPE"];
					c.SaCodeScDegId = (System.Decimal)reader["SA_CODE_SC_DEG_ID"];
					c.SaCodeOrgId = Convert.IsDBNull(reader["SA_CODE_ORG_ID"]) ? null : (System.Decimal?)reader["SA_CODE_ORG_ID"];
					c.GsCdeUniversitiesId = Convert.IsDBNull(reader["GS_CDE_UNIVERSITIES_ID"]) ? null : (System.Decimal?)reader["GS_CDE_UNIVERSITIES_ID"];
					c.GsCountryInfoId = Convert.IsDBNull(reader["GS_COUNTRY_INFO_ID"]) ? null : (System.Decimal?)reader["GS_COUNTRY_INFO_ID"];
					c.Address = Convert.IsDBNull(reader["ADDRESS"]) ? null : (System.String)reader["ADDRESS"];
					c.EMail = Convert.IsDBNull(reader["E_MAIL"]) ? null : (System.String)reader["E_MAIL"];
					c.MobNum = Convert.IsDBNull(reader["MOB_NUM"]) ? null : (System.String)reader["MOB_NUM"];
					c.GsCodeIdentTypeId = Convert.IsDBNull(reader["GS_CODE_IDENT_TYPE_ID"]) ? null : (System.Decimal?)reader["GS_CODE_IDENT_TYPE_ID"];
					c.IdentNumber = Convert.IsDBNull(reader["IDENT_NUMBER"]) ? null : (System.String)reader["IDENT_NUMBER"];
					c.MemberQualMajorAr = Convert.IsDBNull(reader["MEMBER_QUAL_MAJOR_AR"]) ? null : (System.String)reader["MEMBER_QUAL_MAJOR_AR"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.IsActive = Convert.IsDBNull(reader["IS_ACTIVE"]) ? null : (System.Boolean?)reader["IS_ACTIVE"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgExtMember"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgExtMember"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.PgExtMember entity)
		{
			if (!reader.Read()) return;
			
			entity.PgExtMemberId = (System.Decimal)reader[((int)PgExtMemberColumn.PgExtMemberId - 1)];
			entity.OriginalPgExtMemberId = (System.Decimal)reader["PG_EXT_MEMBER_ID"];
			entity.MemberCode = (reader.IsDBNull(((int)PgExtMemberColumn.MemberCode - 1)))?null:(System.String)reader[((int)PgExtMemberColumn.MemberCode - 1)];
			entity.MemberNameAr = (System.String)reader[((int)PgExtMemberColumn.MemberNameAr - 1)];
			entity.MemberNameEn = (reader.IsDBNull(((int)PgExtMemberColumn.MemberNameEn - 1)))?null:(System.String)reader[((int)PgExtMemberColumn.MemberNameEn - 1)];
			entity.GsCodeGenderId = (System.Decimal)reader[((int)PgExtMemberColumn.GsCodeGenderId - 1)];
			entity.MemberJob = (System.String)reader[((int)PgExtMemberColumn.MemberJob - 1)];
			entity.MemberHireDate = (reader.IsDBNull(((int)PgExtMemberColumn.MemberHireDate - 1)))?null:(System.DateTime?)reader[((int)PgExtMemberColumn.MemberHireDate - 1)];
			entity.WorkPlaceType = (System.Decimal)reader[((int)PgExtMemberColumn.WorkPlaceType - 1)];
			entity.SaCodeScDegId = (System.Decimal)reader[((int)PgExtMemberColumn.SaCodeScDegId - 1)];
			entity.SaCodeOrgId = (reader.IsDBNull(((int)PgExtMemberColumn.SaCodeOrgId - 1)))?null:(System.Decimal?)reader[((int)PgExtMemberColumn.SaCodeOrgId - 1)];
			entity.GsCdeUniversitiesId = (reader.IsDBNull(((int)PgExtMemberColumn.GsCdeUniversitiesId - 1)))?null:(System.Decimal?)reader[((int)PgExtMemberColumn.GsCdeUniversitiesId - 1)];
			entity.GsCountryInfoId = (reader.IsDBNull(((int)PgExtMemberColumn.GsCountryInfoId - 1)))?null:(System.Decimal?)reader[((int)PgExtMemberColumn.GsCountryInfoId - 1)];
			entity.Address = (reader.IsDBNull(((int)PgExtMemberColumn.Address - 1)))?null:(System.String)reader[((int)PgExtMemberColumn.Address - 1)];
			entity.EMail = (reader.IsDBNull(((int)PgExtMemberColumn.EMail - 1)))?null:(System.String)reader[((int)PgExtMemberColumn.EMail - 1)];
			entity.MobNum = (reader.IsDBNull(((int)PgExtMemberColumn.MobNum - 1)))?null:(System.String)reader[((int)PgExtMemberColumn.MobNum - 1)];
			entity.GsCodeIdentTypeId = (reader.IsDBNull(((int)PgExtMemberColumn.GsCodeIdentTypeId - 1)))?null:(System.Decimal?)reader[((int)PgExtMemberColumn.GsCodeIdentTypeId - 1)];
			entity.IdentNumber = (reader.IsDBNull(((int)PgExtMemberColumn.IdentNumber - 1)))?null:(System.String)reader[((int)PgExtMemberColumn.IdentNumber - 1)];
			entity.MemberQualMajorAr = (reader.IsDBNull(((int)PgExtMemberColumn.MemberQualMajorAr - 1)))?null:(System.String)reader[((int)PgExtMemberColumn.MemberQualMajorAr - 1)];
			entity.Notes = (reader.IsDBNull(((int)PgExtMemberColumn.Notes - 1)))?null:(System.String)reader[((int)PgExtMemberColumn.Notes - 1)];
			entity.IsActive = (reader.IsDBNull(((int)PgExtMemberColumn.IsActive - 1)))?null:(System.Boolean?)reader[((int)PgExtMemberColumn.IsActive - 1)];
			entity.LastDate = (reader.IsDBNull(((int)PgExtMemberColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)PgExtMemberColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)PgExtMemberColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)PgExtMemberColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgExtMember"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgExtMember"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.PgExtMember entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PgExtMemberId = (System.Decimal)dataRow["PG_EXT_MEMBER_ID"];
			entity.OriginalPgExtMemberId = (System.Decimal)dataRow["PG_EXT_MEMBER_ID"];
			entity.MemberCode = Convert.IsDBNull(dataRow["MEMBER_CODE"]) ? null : (System.String)dataRow["MEMBER_CODE"];
			entity.MemberNameAr = (System.String)dataRow["MEMBER_NAME_AR"];
			entity.MemberNameEn = Convert.IsDBNull(dataRow["MEMBER_NAME_EN"]) ? null : (System.String)dataRow["MEMBER_NAME_EN"];
			entity.GsCodeGenderId = (System.Decimal)dataRow["GS_CODE_GENDER_ID"];
			entity.MemberJob = (System.String)dataRow["MEMBER_JOB"];
			entity.MemberHireDate = Convert.IsDBNull(dataRow["MEMBER_HIRE_DATE"]) ? null : (System.DateTime?)dataRow["MEMBER_HIRE_DATE"];
			entity.WorkPlaceType = (System.Decimal)dataRow["WORK_PLACE_TYPE"];
			entity.SaCodeScDegId = (System.Decimal)dataRow["SA_CODE_SC_DEG_ID"];
			entity.SaCodeOrgId = Convert.IsDBNull(dataRow["SA_CODE_ORG_ID"]) ? null : (System.Decimal?)dataRow["SA_CODE_ORG_ID"];
			entity.GsCdeUniversitiesId = Convert.IsDBNull(dataRow["GS_CDE_UNIVERSITIES_ID"]) ? null : (System.Decimal?)dataRow["GS_CDE_UNIVERSITIES_ID"];
			entity.GsCountryInfoId = Convert.IsDBNull(dataRow["GS_COUNTRY_INFO_ID"]) ? null : (System.Decimal?)dataRow["GS_COUNTRY_INFO_ID"];
			entity.Address = Convert.IsDBNull(dataRow["ADDRESS"]) ? null : (System.String)dataRow["ADDRESS"];
			entity.EMail = Convert.IsDBNull(dataRow["E_MAIL"]) ? null : (System.String)dataRow["E_MAIL"];
			entity.MobNum = Convert.IsDBNull(dataRow["MOB_NUM"]) ? null : (System.String)dataRow["MOB_NUM"];
			entity.GsCodeIdentTypeId = Convert.IsDBNull(dataRow["GS_CODE_IDENT_TYPE_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_IDENT_TYPE_ID"];
			entity.IdentNumber = Convert.IsDBNull(dataRow["IDENT_NUMBER"]) ? null : (System.String)dataRow["IDENT_NUMBER"];
			entity.MemberQualMajorAr = Convert.IsDBNull(dataRow["MEMBER_QUAL_MAJOR_AR"]) ? null : (System.String)dataRow["MEMBER_QUAL_MAJOR_AR"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.IsActive = Convert.IsDBNull(dataRow["IS_ACTIVE"]) ? null : (System.Boolean?)dataRow["IS_ACTIVE"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgExtMember"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgExtMember Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgExtMember entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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

			#region GsCdeUniversitiesIdSource	
			if (CanDeepLoad(entity, "GsCdeUniversities|GsCdeUniversitiesIdSource", deepLoadType, innerList) 
				&& entity.GsCdeUniversitiesIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCdeUniversitiesId ?? 0.0m);
				GsCdeUniversities tmpEntity = EntityManager.LocateEntity<GsCdeUniversities>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeUniversities), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeUniversitiesIdSource = tmpEntity;
				else
					entity.GsCdeUniversitiesIdSource = DataRepository.GsCdeUniversitiesProvider.GetByGsCdeUniversitiesId(transactionManager, (entity.GsCdeUniversitiesId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeUniversitiesIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeUniversitiesIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeUniversitiesProvider.DeepLoad(transactionManager, entity.GsCdeUniversitiesIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeUniversitiesIdSource

			#region GsCodeGenderIdSource	
			if (CanDeepLoad(entity, "GsCodeGender|GsCodeGenderIdSource", deepLoadType, innerList) 
				&& entity.GsCodeGenderIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodeGenderId;
				GsCodeGender tmpEntity = EntityManager.LocateEntity<GsCodeGender>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeGender), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeGenderIdSource = tmpEntity;
				else
					entity.GsCodeGenderIdSource = DataRepository.GsCodeGenderProvider.GetByGsCodeGenderId(transactionManager, entity.GsCodeGenderId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeGenderIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeGenderIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeGenderProvider.DeepLoad(transactionManager, entity.GsCodeGenderIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeGenderIdSource

			#region GsCodeIdentTypeIdSource	
			if (CanDeepLoad(entity, "GsCodeIdentType|GsCodeIdentTypeIdSource", deepLoadType, innerList) 
				&& entity.GsCodeIdentTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeIdentTypeId ?? 0.0m);
				GsCodeIdentType tmpEntity = EntityManager.LocateEntity<GsCodeIdentType>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeIdentType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeIdentTypeIdSource = tmpEntity;
				else
					entity.GsCodeIdentTypeIdSource = DataRepository.GsCodeIdentTypeProvider.GetByGsCodeIdentTypeId(transactionManager, (entity.GsCodeIdentTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeIdentTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeIdentTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeIdentTypeProvider.DeepLoad(transactionManager, entity.GsCodeIdentTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeIdentTypeIdSource

			#region GsCountryInfoIdSource	
			if (CanDeepLoad(entity, "GsCountryNode|GsCountryInfoIdSource", deepLoadType, innerList) 
				&& entity.GsCountryInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCountryInfoId ?? 0.0m);
				GsCountryNode tmpEntity = EntityManager.LocateEntity<GsCountryNode>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCountryNode), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCountryInfoIdSource = tmpEntity;
				else
					entity.GsCountryInfoIdSource = DataRepository.GsCountryNodeProvider.GetByGsCountryNodeId(transactionManager, (entity.GsCountryInfoId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCountryInfoIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCountryInfoIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCountryNodeProvider.DeepLoad(transactionManager, entity.GsCountryInfoIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCountryInfoIdSource

			#region SaCodeOrgIdSource	
			if (CanDeepLoad(entity, "SaCodeOrg|SaCodeOrgIdSource", deepLoadType, innerList) 
				&& entity.SaCodeOrgIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaCodeOrgId ?? 0.0m);
				SaCodeOrg tmpEntity = EntityManager.LocateEntity<SaCodeOrg>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeOrg), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeOrgIdSource = tmpEntity;
				else
					entity.SaCodeOrgIdSource = DataRepository.SaCodeOrgProvider.GetBySaCodeOrgId(transactionManager, (entity.SaCodeOrgId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeOrgIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodeOrgIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeOrgProvider.DeepLoad(transactionManager, entity.SaCodeOrgIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodeOrgIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByPgExtMemberId methods when available
			
			#region PgThesisStaffCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisStaff>|PgThesisStaffCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStaffCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisStaffCollection = DataRepository.PgThesisStaffProvider.GetByPgExtMemberId(transactionManager, entity.PgExtMemberId);

				if (deep && entity.PgThesisStaffCollection.Count > 0)
				{
					deepHandles.Add("PgThesisStaffCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisStaff>) DataRepository.PgThesisStaffProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisStaffCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisCommMemberCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisCommMember>|PgThesisCommMemberCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisCommMemberCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisCommMemberCollection = DataRepository.PgThesisCommMemberProvider.GetByPgExtMemberId(transactionManager, entity.PgExtMemberId);

				if (deep && entity.PgThesisCommMemberCollection.Count > 0)
				{
					deepHandles.Add("PgThesisCommMemberCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisCommMember>) DataRepository.PgThesisCommMemberProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisCommMemberCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.PgExtMember object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.PgExtMember instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgExtMember Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgExtMember entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SaCodeScDegIdSource
			if (CanDeepSave(entity, "SaCodeScDeg|SaCodeScDegIdSource", deepSaveType, innerList) 
				&& entity.SaCodeScDegIdSource != null)
			{
				DataRepository.SaCodeScDegProvider.Save(transactionManager, entity.SaCodeScDegIdSource);
				entity.SaCodeScDegId = entity.SaCodeScDegIdSource.SaCodeScDegId;
			}
			#endregion 
			
			#region GsCdeUniversitiesIdSource
			if (CanDeepSave(entity, "GsCdeUniversities|GsCdeUniversitiesIdSource", deepSaveType, innerList) 
				&& entity.GsCdeUniversitiesIdSource != null)
			{
				DataRepository.GsCdeUniversitiesProvider.Save(transactionManager, entity.GsCdeUniversitiesIdSource);
				entity.GsCdeUniversitiesId = entity.GsCdeUniversitiesIdSource.GsCdeUniversitiesId;
			}
			#endregion 
			
			#region GsCodeGenderIdSource
			if (CanDeepSave(entity, "GsCodeGender|GsCodeGenderIdSource", deepSaveType, innerList) 
				&& entity.GsCodeGenderIdSource != null)
			{
				DataRepository.GsCodeGenderProvider.Save(transactionManager, entity.GsCodeGenderIdSource);
				entity.GsCodeGenderId = entity.GsCodeGenderIdSource.GsCodeGenderId;
			}
			#endregion 
			
			#region GsCodeIdentTypeIdSource
			if (CanDeepSave(entity, "GsCodeIdentType|GsCodeIdentTypeIdSource", deepSaveType, innerList) 
				&& entity.GsCodeIdentTypeIdSource != null)
			{
				DataRepository.GsCodeIdentTypeProvider.Save(transactionManager, entity.GsCodeIdentTypeIdSource);
				entity.GsCodeIdentTypeId = entity.GsCodeIdentTypeIdSource.GsCodeIdentTypeId;
			}
			#endregion 
			
			#region GsCountryInfoIdSource
			if (CanDeepSave(entity, "GsCountryNode|GsCountryInfoIdSource", deepSaveType, innerList) 
				&& entity.GsCountryInfoIdSource != null)
			{
				DataRepository.GsCountryNodeProvider.Save(transactionManager, entity.GsCountryInfoIdSource);
				entity.GsCountryInfoId = entity.GsCountryInfoIdSource.GsCountryNodeId;
			}
			#endregion 
			
			#region SaCodeOrgIdSource
			if (CanDeepSave(entity, "SaCodeOrg|SaCodeOrgIdSource", deepSaveType, innerList) 
				&& entity.SaCodeOrgIdSource != null)
			{
				DataRepository.SaCodeOrgProvider.Save(transactionManager, entity.SaCodeOrgIdSource);
				entity.SaCodeOrgId = entity.SaCodeOrgIdSource.SaCodeOrgId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<PgThesisStaff>
				if (CanDeepSave(entity.PgThesisStaffCollection, "List<PgThesisStaff>|PgThesisStaffCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisStaff child in entity.PgThesisStaffCollection)
					{
						if(child.PgExtMemberIdSource != null)
						{
							child.PgExtMemberId = child.PgExtMemberIdSource.PgExtMemberId;
						}
						else
						{
							child.PgExtMemberId = entity.PgExtMemberId;
						}

					}

					if (entity.PgThesisStaffCollection.Count > 0 || entity.PgThesisStaffCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisStaffProvider.Save(transactionManager, entity.PgThesisStaffCollection);
						
						deepHandles.Add("PgThesisStaffCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisStaff >) DataRepository.PgThesisStaffProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisStaffCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisCommMember>
				if (CanDeepSave(entity.PgThesisCommMemberCollection, "List<PgThesisCommMember>|PgThesisCommMemberCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisCommMember child in entity.PgThesisCommMemberCollection)
					{
						if(child.PgExtMemberIdSource != null)
						{
							child.PgExtMemberId = child.PgExtMemberIdSource.PgExtMemberId;
						}
						else
						{
							child.PgExtMemberId = entity.PgExtMemberId;
						}

					}

					if (entity.PgThesisCommMemberCollection.Count > 0 || entity.PgThesisCommMemberCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisCommMemberProvider.Save(transactionManager, entity.PgThesisCommMemberCollection);
						
						deepHandles.Add("PgThesisCommMemberCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisCommMember >) DataRepository.PgThesisCommMemberProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisCommMemberCollection, deepSaveType, childTypes, innerList }
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
	
	#region PgExtMemberChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.PgExtMember</c>
	///</summary>
	public enum PgExtMemberChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SaCodeScDeg</c> at SaCodeScDegIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeScDeg))]
		SaCodeScDeg,
		
		///<summary>
		/// Composite Property for <c>GsCdeUniversities</c> at GsCdeUniversitiesIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeUniversities))]
		GsCdeUniversities,
		
		///<summary>
		/// Composite Property for <c>GsCodeGender</c> at GsCodeGenderIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeGender))]
		GsCodeGender,
		
		///<summary>
		/// Composite Property for <c>GsCodeIdentType</c> at GsCodeIdentTypeIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeIdentType))]
		GsCodeIdentType,
		
		///<summary>
		/// Composite Property for <c>GsCountryNode</c> at GsCountryInfoIdSource
		///</summary>
		[ChildEntityType(typeof(GsCountryNode))]
		GsCountryNode,
		
		///<summary>
		/// Composite Property for <c>SaCodeOrg</c> at SaCodeOrgIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeOrg))]
		SaCodeOrg,
		///<summary>
		/// Collection of <c>PgExtMember</c> as OneToMany for PgThesisStaffCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisStaff>))]
		PgThesisStaffCollection,
		///<summary>
		/// Collection of <c>PgExtMember</c> as OneToMany for PgThesisCommMemberCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisCommMember>))]
		PgThesisCommMemberCollection,
	}
	
	#endregion PgExtMemberChildEntityTypes
	
	#region PgExtMemberFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PgExtMemberColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgExtMember"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgExtMemberFilterBuilder : SqlFilterBuilder<PgExtMemberColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgExtMemberFilterBuilder class.
		/// </summary>
		public PgExtMemberFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgExtMemberFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgExtMemberFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgExtMemberFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgExtMemberFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgExtMemberFilterBuilder
	
	#region PgExtMemberParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PgExtMemberColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgExtMember"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgExtMemberParameterBuilder : ParameterizedSqlFilterBuilder<PgExtMemberColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgExtMemberParameterBuilder class.
		/// </summary>
		public PgExtMemberParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgExtMemberParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgExtMemberParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgExtMemberParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgExtMemberParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgExtMemberParameterBuilder
	
	#region PgExtMemberSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PgExtMemberColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgExtMember"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PgExtMemberSortBuilder : SqlSortBuilder<PgExtMemberColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgExtMemberSqlSortBuilder class.
		/// </summary>
		public PgExtMemberSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PgExtMemberSortBuilder
	
} // end namespace
