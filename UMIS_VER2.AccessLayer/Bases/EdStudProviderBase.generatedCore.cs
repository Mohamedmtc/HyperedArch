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
	/// This class is the base class for any <see cref="EdStudProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStud, UMIS_VER2.BusinessLyer.EdStudKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudKey key)
		{
			return Delete(transactionManager, key.EdStudId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudId)
		{
			return Delete(null, _edStudId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GS_CDE_BLOOD key.
		///		FK_ED_STUD_GS_CDE_BLOOD Description: 
		/// </summary>
		/// <param name="_gsCdeBloodId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStud objects.</returns>
		public TList<EdStud> GetByGsCdeBloodId(System.Decimal? _gsCdeBloodId)
		{
			int count = -1;
			return GetByGsCdeBloodId(_gsCdeBloodId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GS_CDE_BLOOD key.
		///		FK_ED_STUD_GS_CDE_BLOOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeBloodId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStud objects.</returns>
		/// <remarks></remarks>
		public TList<EdStud> GetByGsCdeBloodId(TransactionManager transactionManager, System.Decimal? _gsCdeBloodId)
		{
			int count = -1;
			return GetByGsCdeBloodId(transactionManager, _gsCdeBloodId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GS_CDE_BLOOD key.
		///		FK_ED_STUD_GS_CDE_BLOOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeBloodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStud objects.</returns>
		public TList<EdStud> GetByGsCdeBloodId(TransactionManager transactionManager, System.Decimal? _gsCdeBloodId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeBloodId(transactionManager, _gsCdeBloodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GS_CDE_BLOOD key.
		///		fkEdStudGsCdeBlood Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeBloodId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStud objects.</returns>
		public TList<EdStud> GetByGsCdeBloodId(System.Decimal? _gsCdeBloodId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeBloodId(null, _gsCdeBloodId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GS_CDE_BLOOD key.
		///		fkEdStudGsCdeBlood Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeBloodId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStud objects.</returns>
		public TList<EdStud> GetByGsCdeBloodId(System.Decimal? _gsCdeBloodId, int start, int pageLength,out int count)
		{
			return GetByGsCdeBloodId(null, _gsCdeBloodId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GS_CDE_BLOOD key.
		///		FK_ED_STUD_GS_CDE_BLOOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeBloodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStud objects.</returns>
		public abstract TList<EdStud> GetByGsCdeBloodId(TransactionManager transactionManager, System.Decimal? _gsCdeBloodId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GS_CDE_MARITAL_STATUS key.
		///		FK_ED_STUD_GS_CDE_MARITAL_STATUS Description: 
		/// </summary>
		/// <param name="_gsCdeMaritalStatusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStud objects.</returns>
		public TList<EdStud> GetByGsCdeMaritalStatusId(System.Decimal? _gsCdeMaritalStatusId)
		{
			int count = -1;
			return GetByGsCdeMaritalStatusId(_gsCdeMaritalStatusId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GS_CDE_MARITAL_STATUS key.
		///		FK_ED_STUD_GS_CDE_MARITAL_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeMaritalStatusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStud objects.</returns>
		/// <remarks></remarks>
		public TList<EdStud> GetByGsCdeMaritalStatusId(TransactionManager transactionManager, System.Decimal? _gsCdeMaritalStatusId)
		{
			int count = -1;
			return GetByGsCdeMaritalStatusId(transactionManager, _gsCdeMaritalStatusId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GS_CDE_MARITAL_STATUS key.
		///		FK_ED_STUD_GS_CDE_MARITAL_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeMaritalStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStud objects.</returns>
		public TList<EdStud> GetByGsCdeMaritalStatusId(TransactionManager transactionManager, System.Decimal? _gsCdeMaritalStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeMaritalStatusId(transactionManager, _gsCdeMaritalStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GS_CDE_MARITAL_STATUS key.
		///		fkEdStudGsCdeMaritalStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeMaritalStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStud objects.</returns>
		public TList<EdStud> GetByGsCdeMaritalStatusId(System.Decimal? _gsCdeMaritalStatusId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeMaritalStatusId(null, _gsCdeMaritalStatusId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GS_CDE_MARITAL_STATUS key.
		///		fkEdStudGsCdeMaritalStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeMaritalStatusId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStud objects.</returns>
		public TList<EdStud> GetByGsCdeMaritalStatusId(System.Decimal? _gsCdeMaritalStatusId, int start, int pageLength,out int count)
		{
			return GetByGsCdeMaritalStatusId(null, _gsCdeMaritalStatusId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GS_CDE_MARITAL_STATUS key.
		///		FK_ED_STUD_GS_CDE_MARITAL_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeMaritalStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStud objects.</returns>
		public abstract TList<EdStud> GetByGsCdeMaritalStatusId(TransactionManager transactionManager, System.Decimal? _gsCdeMaritalStatusId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GS_CODE_LANGUAGE key.
		///		FK_ED_STUD_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="_gsCodeLanguageId">لغة التخصص</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStud objects.</returns>
		public TList<EdStud> GetByGsCodeLanguageId(System.Decimal? _gsCodeLanguageId)
		{
			int count = -1;
			return GetByGsCodeLanguageId(_gsCodeLanguageId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GS_CODE_LANGUAGE key.
		///		FK_ED_STUD_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId">لغة التخصص</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStud objects.</returns>
		/// <remarks></remarks>
		public TList<EdStud> GetByGsCodeLanguageId(TransactionManager transactionManager, System.Decimal? _gsCodeLanguageId)
		{
			int count = -1;
			return GetByGsCodeLanguageId(transactionManager, _gsCodeLanguageId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GS_CODE_LANGUAGE key.
		///		FK_ED_STUD_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId">لغة التخصص</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStud objects.</returns>
		public TList<EdStud> GetByGsCodeLanguageId(TransactionManager transactionManager, System.Decimal? _gsCodeLanguageId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeLanguageId(transactionManager, _gsCodeLanguageId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GS_CODE_LANGUAGE key.
		///		fkEdStudGsCodeLanguage Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeLanguageId">لغة التخصص</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStud objects.</returns>
		public TList<EdStud> GetByGsCodeLanguageId(System.Decimal? _gsCodeLanguageId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeLanguageId(null, _gsCodeLanguageId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GS_CODE_LANGUAGE key.
		///		fkEdStudGsCodeLanguage Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeLanguageId">لغة التخصص</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStud objects.</returns>
		public TList<EdStud> GetByGsCodeLanguageId(System.Decimal? _gsCodeLanguageId, int start, int pageLength,out int count)
		{
			return GetByGsCodeLanguageId(null, _gsCodeLanguageId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GS_CODE_LANGUAGE key.
		///		FK_ED_STUD_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId">لغة التخصص</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStud objects.</returns>
		public abstract TList<EdStud> GetByGsCodeLanguageId(TransactionManager transactionManager, System.Decimal? _gsCodeLanguageId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SA_STF_MEMBER key.
		///		FK_ED_STUD_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMemberPrntId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStud objects.</returns>
		public TList<EdStud> GetBySaStfMemberPrntId(System.Decimal? _saStfMemberPrntId)
		{
			int count = -1;
			return GetBySaStfMemberPrntId(_saStfMemberPrntId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SA_STF_MEMBER key.
		///		FK_ED_STUD_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberPrntId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStud objects.</returns>
		/// <remarks></remarks>
		public TList<EdStud> GetBySaStfMemberPrntId(TransactionManager transactionManager, System.Decimal? _saStfMemberPrntId)
		{
			int count = -1;
			return GetBySaStfMemberPrntId(transactionManager, _saStfMemberPrntId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SA_STF_MEMBER key.
		///		FK_ED_STUD_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberPrntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStud objects.</returns>
		public TList<EdStud> GetBySaStfMemberPrntId(TransactionManager transactionManager, System.Decimal? _saStfMemberPrntId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberPrntId(transactionManager, _saStfMemberPrntId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SA_STF_MEMBER key.
		///		fkEdStudSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberPrntId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStud objects.</returns>
		public TList<EdStud> GetBySaStfMemberPrntId(System.Decimal? _saStfMemberPrntId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberPrntId(null, _saStfMemberPrntId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SA_STF_MEMBER key.
		///		fkEdStudSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberPrntId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStud objects.</returns>
		public TList<EdStud> GetBySaStfMemberPrntId(System.Decimal? _saStfMemberPrntId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberPrntId(null, _saStfMemberPrntId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SA_STF_MEMBER key.
		///		FK_ED_STUD_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberPrntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStud objects.</returns>
		public abstract TList<EdStud> GetBySaStfMemberPrntId(TransactionManager transactionManager, System.Decimal? _saStfMemberPrntId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStud Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudKey key, int start, int pageLength)
		{
			return GetByEdStudId(transactionManager, key.EdStudId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_BIRTH_COUNTRY_NOD_1 index.
		/// </summary>
		/// <param name="_gsBirthCountryNodeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStud&gt;"/> class.</returns>
		public TList<EdStud> GetByGsBirthCountryNodeId(System.Decimal? _gsBirthCountryNodeId)
		{
			int count = -1;
			return GetByGsBirthCountryNodeId(null,_gsBirthCountryNodeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_BIRTH_COUNTRY_NOD_1 index.
		/// </summary>
		/// <param name="_gsBirthCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStud&gt;"/> class.</returns>
		public TList<EdStud> GetByGsBirthCountryNodeId(System.Decimal? _gsBirthCountryNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsBirthCountryNodeId(null, _gsBirthCountryNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_BIRTH_COUNTRY_NOD_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsBirthCountryNodeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStud&gt;"/> class.</returns>
		public TList<EdStud> GetByGsBirthCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsBirthCountryNodeId)
		{
			int count = -1;
			return GetByGsBirthCountryNodeId(transactionManager, _gsBirthCountryNodeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_BIRTH_COUNTRY_NOD_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsBirthCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStud&gt;"/> class.</returns>
		public TList<EdStud> GetByGsBirthCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsBirthCountryNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsBirthCountryNodeId(transactionManager, _gsBirthCountryNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_BIRTH_COUNTRY_NOD_1 index.
		/// </summary>
		/// <param name="_gsBirthCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStud&gt;"/> class.</returns>
		public TList<EdStud> GetByGsBirthCountryNodeId(System.Decimal? _gsBirthCountryNodeId, int start, int pageLength, out int count)
		{
			return GetByGsBirthCountryNodeId(null, _gsBirthCountryNodeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_BIRTH_COUNTRY_NOD_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsBirthCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStud&gt;"/> class.</returns>
		public abstract TList<EdStud> GetByGsBirthCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsBirthCountryNodeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_CODE_GENDER_ID_1 index.
		/// </summary>
		/// <param name="_gsCodeGenderId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStud&gt;"/> class.</returns>
		public TList<EdStud> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId)
		{
			int count = -1;
			return GetByGsCodeGenderId(null,_gsCodeGenderId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_GENDER_ID_1 index.
		/// </summary>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStud&gt;"/> class.</returns>
		public TList<EdStud> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeGenderId(null, _gsCodeGenderId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_GENDER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStud&gt;"/> class.</returns>
		public TList<EdStud> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId)
		{
			int count = -1;
			return GetByGsCodeGenderId(transactionManager, _gsCodeGenderId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_GENDER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStud&gt;"/> class.</returns>
		public TList<EdStud> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeGenderId(transactionManager, _gsCodeGenderId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_GENDER_ID_1 index.
		/// </summary>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStud&gt;"/> class.</returns>
		public TList<EdStud> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId, int start, int pageLength, out int count)
		{
			return GetByGsCodeGenderId(null, _gsCodeGenderId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_GENDER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStud&gt;"/> class.</returns>
		public abstract TList<EdStud> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_CODE_IDENT_TYPE_I_1 index.
		/// </summary>
		/// <param name="_gsCodeIdentTypeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStud&gt;"/> class.</returns>
		public TList<EdStud> GetByGsCodeIdentTypeId(System.Decimal? _gsCodeIdentTypeId)
		{
			int count = -1;
			return GetByGsCodeIdentTypeId(null,_gsCodeIdentTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_IDENT_TYPE_I_1 index.
		/// </summary>
		/// <param name="_gsCodeIdentTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStud&gt;"/> class.</returns>
		public TList<EdStud> GetByGsCodeIdentTypeId(System.Decimal? _gsCodeIdentTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeIdentTypeId(null, _gsCodeIdentTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_IDENT_TYPE_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeIdentTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStud&gt;"/> class.</returns>
		public TList<EdStud> GetByGsCodeIdentTypeId(TransactionManager transactionManager, System.Decimal? _gsCodeIdentTypeId)
		{
			int count = -1;
			return GetByGsCodeIdentTypeId(transactionManager, _gsCodeIdentTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_IDENT_TYPE_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeIdentTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStud&gt;"/> class.</returns>
		public TList<EdStud> GetByGsCodeIdentTypeId(TransactionManager transactionManager, System.Decimal? _gsCodeIdentTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeIdentTypeId(transactionManager, _gsCodeIdentTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_IDENT_TYPE_I_1 index.
		/// </summary>
		/// <param name="_gsCodeIdentTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStud&gt;"/> class.</returns>
		public TList<EdStud> GetByGsCodeIdentTypeId(System.Decimal? _gsCodeIdentTypeId, int start, int pageLength, out int count)
		{
			return GetByGsCodeIdentTypeId(null, _gsCodeIdentTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_IDENT_TYPE_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeIdentTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStud&gt;"/> class.</returns>
		public abstract TList<EdStud> GetByGsCodeIdentTypeId(TransactionManager transactionManager, System.Decimal? _gsCodeIdentTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_CODE_RELIGION_ID_1 index.
		/// </summary>
		/// <param name="_gsCodeReligionId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStud&gt;"/> class.</returns>
		public TList<EdStud> GetByGsCodeReligionId(System.Decimal? _gsCodeReligionId)
		{
			int count = -1;
			return GetByGsCodeReligionId(null,_gsCodeReligionId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_RELIGION_ID_1 index.
		/// </summary>
		/// <param name="_gsCodeReligionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStud&gt;"/> class.</returns>
		public TList<EdStud> GetByGsCodeReligionId(System.Decimal? _gsCodeReligionId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeReligionId(null, _gsCodeReligionId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_RELIGION_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReligionId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStud&gt;"/> class.</returns>
		public TList<EdStud> GetByGsCodeReligionId(TransactionManager transactionManager, System.Decimal? _gsCodeReligionId)
		{
			int count = -1;
			return GetByGsCodeReligionId(transactionManager, _gsCodeReligionId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_RELIGION_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReligionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStud&gt;"/> class.</returns>
		public TList<EdStud> GetByGsCodeReligionId(TransactionManager transactionManager, System.Decimal? _gsCodeReligionId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeReligionId(transactionManager, _gsCodeReligionId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_RELIGION_ID_1 index.
		/// </summary>
		/// <param name="_gsCodeReligionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStud&gt;"/> class.</returns>
		public TList<EdStud> GetByGsCodeReligionId(System.Decimal? _gsCodeReligionId, int start, int pageLength, out int count)
		{
			return GetByGsCodeReligionId(null, _gsCodeReligionId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_RELIGION_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReligionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStud&gt;"/> class.</returns>
		public abstract TList<EdStud> GetByGsCodeReligionId(TransactionManager transactionManager, System.Decimal? _gsCodeReligionId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_COUNTRY_INFO_ID_1_1 index.
		/// </summary>
		/// <param name="_gsCountryInfoId1"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStud&gt;"/> class.</returns>
		public TList<EdStud> GetByGsCountryInfoId1(System.Decimal? _gsCountryInfoId1)
		{
			int count = -1;
			return GetByGsCountryInfoId1(null,_gsCountryInfoId1, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_COUNTRY_INFO_ID_1_1 index.
		/// </summary>
		/// <param name="_gsCountryInfoId1"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStud&gt;"/> class.</returns>
		public TList<EdStud> GetByGsCountryInfoId1(System.Decimal? _gsCountryInfoId1, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryInfoId1(null, _gsCountryInfoId1, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_COUNTRY_INFO_ID_1_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryInfoId1"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStud&gt;"/> class.</returns>
		public TList<EdStud> GetByGsCountryInfoId1(TransactionManager transactionManager, System.Decimal? _gsCountryInfoId1)
		{
			int count = -1;
			return GetByGsCountryInfoId1(transactionManager, _gsCountryInfoId1, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_COUNTRY_INFO_ID_1_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryInfoId1"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStud&gt;"/> class.</returns>
		public TList<EdStud> GetByGsCountryInfoId1(TransactionManager transactionManager, System.Decimal? _gsCountryInfoId1, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryInfoId1(transactionManager, _gsCountryInfoId1, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_COUNTRY_INFO_ID_1_1 index.
		/// </summary>
		/// <param name="_gsCountryInfoId1"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStud&gt;"/> class.</returns>
		public TList<EdStud> GetByGsCountryInfoId1(System.Decimal? _gsCountryInfoId1, int start, int pageLength, out int count)
		{
			return GetByGsCountryInfoId1(null, _gsCountryInfoId1, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_COUNTRY_INFO_ID_1_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryInfoId1"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStud&gt;"/> class.</returns>
		public abstract TList<EdStud> GetByGsCountryInfoId1(TransactionManager transactionManager, System.Decimal? _gsCountryInfoId1, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_COUNTRY_INFO_ID_2_1 index.
		/// </summary>
		/// <param name="_gsCountryInfoId2"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStud&gt;"/> class.</returns>
		public TList<EdStud> GetByGsCountryInfoId2(System.Decimal? _gsCountryInfoId2)
		{
			int count = -1;
			return GetByGsCountryInfoId2(null,_gsCountryInfoId2, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_COUNTRY_INFO_ID_2_1 index.
		/// </summary>
		/// <param name="_gsCountryInfoId2"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStud&gt;"/> class.</returns>
		public TList<EdStud> GetByGsCountryInfoId2(System.Decimal? _gsCountryInfoId2, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryInfoId2(null, _gsCountryInfoId2, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_COUNTRY_INFO_ID_2_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryInfoId2"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStud&gt;"/> class.</returns>
		public TList<EdStud> GetByGsCountryInfoId2(TransactionManager transactionManager, System.Decimal? _gsCountryInfoId2)
		{
			int count = -1;
			return GetByGsCountryInfoId2(transactionManager, _gsCountryInfoId2, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_COUNTRY_INFO_ID_2_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryInfoId2"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStud&gt;"/> class.</returns>
		public TList<EdStud> GetByGsCountryInfoId2(TransactionManager transactionManager, System.Decimal? _gsCountryInfoId2, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryInfoId2(transactionManager, _gsCountryInfoId2, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_COUNTRY_INFO_ID_2_1 index.
		/// </summary>
		/// <param name="_gsCountryInfoId2"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStud&gt;"/> class.</returns>
		public TList<EdStud> GetByGsCountryInfoId2(System.Decimal? _gsCountryInfoId2, int start, int pageLength, out int count)
		{
			return GetByGsCountryInfoId2(null, _gsCountryInfoId2, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_COUNTRY_INFO_ID_2_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryInfoId2"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStud&gt;"/> class.</returns>
		public abstract TList<EdStud> GetByGsCountryInfoId2(TransactionManager transactionManager, System.Decimal? _gsCountryInfoId2, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStud GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(null,_edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStud GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStud GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStud GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStud GetByEdStudId(System.Decimal _edStudId, int start, int pageLength, out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStud"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStud GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStud&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStud&gt;"/></returns>
		public static TList<EdStud> Fill(IDataReader reader, TList<EdStud> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStud c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStud")
					.Append("|").Append((System.Decimal)reader["ED_STUD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStud>(
					key.ToString(), // EntityTrackingKey
					"EdStud",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStud();
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
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.OriginalEdStudId = c.EdStudId;
					c.NationalNumber = Convert.IsDBNull(reader["NATIONAL_NUMBER"]) ? null : (System.String)reader["NATIONAL_NUMBER"];
					c.FullNameAr = (System.String)reader["FULL_NAME_AR"];
					c.ClFullNameAr = Convert.IsDBNull(reader["CL_FULL_NAME_AR"]) ? null : (System.String)reader["CL_FULL_NAME_AR"];
					c.StudNameAr = Convert.IsDBNull(reader["STUD_NAME_AR"]) ? null : (System.String)reader["STUD_NAME_AR"];
					c.ClStudNameAr = Convert.IsDBNull(reader["CL_STUD_NAME_AR"]) ? null : (System.String)reader["CL_STUD_NAME_AR"];
					c.FatherNameAr = Convert.IsDBNull(reader["FATHER_NAME_AR"]) ? null : (System.String)reader["FATHER_NAME_AR"];
					c.ClFatherNameAr = Convert.IsDBNull(reader["CL_FATHER_NAME_AR"]) ? null : (System.String)reader["CL_FATHER_NAME_AR"];
					c.GrandfatherNameAr = Convert.IsDBNull(reader["GRANDFATHER_NAME_AR"]) ? null : (System.String)reader["GRANDFATHER_NAME_AR"];
					c.ClGrandfatherNameAr = Convert.IsDBNull(reader["CL_GRANDFATHER_NAME_AR"]) ? null : (System.String)reader["CL_GRANDFATHER_NAME_AR"];
					c.FamilyNameAr = Convert.IsDBNull(reader["FAMILY_NAME_AR"]) ? null : (System.String)reader["FAMILY_NAME_AR"];
					c.ClFamilyNameAr = Convert.IsDBNull(reader["CL_FAMILY_NAME_AR"]) ? null : (System.String)reader["CL_FAMILY_NAME_AR"];
					c.FullNameEn = (System.String)reader["FULL_NAME_EN"];
					c.StudNameEn = Convert.IsDBNull(reader["STUD_NAME_EN"]) ? null : (System.String)reader["STUD_NAME_EN"];
					c.FatherNameEn = Convert.IsDBNull(reader["FATHER_NAME_EN"]) ? null : (System.String)reader["FATHER_NAME_EN"];
					c.GrandfatherNameEn = Convert.IsDBNull(reader["GRANDFATHER_NAME_EN"]) ? null : (System.String)reader["GRANDFATHER_NAME_EN"];
					c.FamilyNameEn = Convert.IsDBNull(reader["FAMILY_NAME_EN"]) ? null : (System.String)reader["FAMILY_NAME_EN"];
					c.FatherProfession = Convert.IsDBNull(reader["FATHER_PROFESSION"]) ? null : (System.String)reader["FATHER_PROFESSION"];
					c.FatherNationalNumber = Convert.IsDBNull(reader["FATHER_NATIONAL_NUMBER"]) ? null : (System.String)reader["FATHER_NATIONAL_NUMBER"];
					c.MotherNationalNumber = Convert.IsDBNull(reader["MOTHER_NATIONAL_NUMBER"]) ? null : (System.String)reader["MOTHER_NATIONAL_NUMBER"];
					c.MotherNameAr = Convert.IsDBNull(reader["MOTHER_NAME_AR"]) ? null : (System.String)reader["MOTHER_NAME_AR"];
					c.ClMotherNameAr = Convert.IsDBNull(reader["CL_MOTHER_NAME_AR"]) ? null : (System.String)reader["CL_MOTHER_NAME_AR"];
					c.MotherNameEn = Convert.IsDBNull(reader["MOTHER_NAME_EN"]) ? null : (System.String)reader["MOTHER_NAME_EN"];
					c.GsCodeGenderId = Convert.IsDBNull(reader["GS_CODE_GENDER_ID"]) ? null : (System.Decimal?)reader["GS_CODE_GENDER_ID"];
					c.GsCodeReligionId = Convert.IsDBNull(reader["GS_CODE_RELIGION_ID"]) ? null : (System.Decimal?)reader["GS_CODE_RELIGION_ID"];
					c.BirthRegNumber = Convert.IsDBNull(reader["BIRTH_REG_NUMBER"]) ? null : (System.String)reader["BIRTH_REG_NUMBER"];
					c.BirthDate = Convert.IsDBNull(reader["BIRTH_DATE"]) ? null : (System.DateTime?)reader["BIRTH_DATE"];
					c.GsBirthCountryNodeId = Convert.IsDBNull(reader["GS_BIRTH_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)reader["GS_BIRTH_COUNTRY_NODE_ID"];
					c.GsCountryInfoId1 = Convert.IsDBNull(reader["GS_COUNTRY_INFO_ID_1"]) ? null : (System.Decimal?)reader["GS_COUNTRY_INFO_ID_1"];
					c.GsCountryInfoId2 = Convert.IsDBNull(reader["GS_COUNTRY_INFO_ID_2"]) ? null : (System.Decimal?)reader["GS_COUNTRY_INFO_ID_2"];
					c.StudPhoto = Convert.IsDBNull(reader["STUD_PHOTO"]) ? null : (System.String)reader["STUD_PHOTO"];
					c.GsCodeIdentTypeId = Convert.IsDBNull(reader["GS_CODE_IDENT_TYPE_ID"]) ? null : (System.Decimal?)reader["GS_CODE_IDENT_TYPE_ID"];
					c.IsPrntStaff = Convert.IsDBNull(reader["IS_PRNT_STAFF"]) ? null : (System.Decimal?)reader["IS_PRNT_STAFF"];
					c.SaStfMemberPrntId = Convert.IsDBNull(reader["SA_STF_MEMBER_PRNT_ID"]) ? null : (System.Decimal?)reader["SA_STF_MEMBER_PRNT_ID"];
					c.GsCdeBloodId = Convert.IsDBNull(reader["GS_CDE_BLOOD_ID"]) ? null : (System.Decimal?)reader["GS_CDE_BLOOD_ID"];
					c.StudLnht = Convert.IsDBNull(reader["STUD_LNHT"]) ? null : (System.Decimal?)reader["STUD_LNHT"];
					c.StudWght = Convert.IsDBNull(reader["STUD_WGHT"]) ? null : (System.Decimal?)reader["STUD_WGHT"];
					c.IdentIssuePlc = Convert.IsDBNull(reader["IDENT_ISSUE_PLC"]) ? null : (System.String)reader["IDENT_ISSUE_PLC"];
					c.GsCodeLanguageId = Convert.IsDBNull(reader["GS_CODE_LANGUAGE_ID"]) ? null : (System.Decimal?)reader["GS_CODE_LANGUAGE_ID"];
					c.PassporNo = Convert.IsDBNull(reader["PASSPOR_NO"]) ? null : (System.String)reader["PASSPOR_NO"];
					c.PassporExpireDate = Convert.IsDBNull(reader["PASSPOR_EXPIRE_DATE"]) ? null : (System.DateTime?)reader["PASSPOR_EXPIRE_DATE"];
					c.PassporIssueDate = Convert.IsDBNull(reader["PASSPOR_ISSUE_DATE"]) ? null : (System.DateTime?)reader["PASSPOR_ISSUE_DATE"];
					c.SpecialNeedFlg = Convert.IsDBNull(reader["SPECIAL_NEED_FLG"]) ? null : (System.Boolean?)reader["SPECIAL_NEED_FLG"];
					c.EmployeeFlg = Convert.IsDBNull(reader["EMPLOYEE_FLG"]) ? null : (System.Boolean?)reader["EMPLOYEE_FLG"];
					c.IdentIssueDate = Convert.IsDBNull(reader["IDENT_ISSUE_DATE"]) ? null : (System.DateTime?)reader["IDENT_ISSUE_DATE"];
					c.IdentExpireDate = Convert.IsDBNull(reader["IDENT_EXPIRE_DATE"]) ? null : (System.DateTime?)reader["IDENT_EXPIRE_DATE"];
					c.HecId = Convert.IsDBNull(reader["HEC_ID"]) ? null : (System.String)reader["HEC_ID"];
					c.GsCdeMaritalStatusId = Convert.IsDBNull(reader["GS_CDE_MARITAL_STATUS_ID"]) ? null : (System.Decimal?)reader["GS_CDE_MARITAL_STATUS_ID"];
					c.MarriageDate = Convert.IsDBNull(reader["MARRIAGE_DATE"]) ? null : (System.DateTime?)reader["MARRIAGE_DATE"];
					c.NoChild = Convert.IsDBNull(reader["NO_CHILD"]) ? null : (System.Int32?)reader["NO_CHILD"];
					c.VisaNumber = Convert.IsDBNull(reader["VISA_NUMBER"]) ? null : (System.String)reader["VISA_NUMBER"];
					c.VisaIssueDate = Convert.IsDBNull(reader["VISA_ISSUE_DATE"]) ? null : (System.DateTime?)reader["VISA_ISSUE_DATE"];
					c.VisaExpireDate = Convert.IsDBNull(reader["VISA_EXPIRE_DATE"]) ? null : (System.DateTime?)reader["VISA_EXPIRE_DATE"];
					c.SeFormId = Convert.IsDBNull(reader["SE_FORM_ID"]) ? null : (System.Decimal?)reader["SE_FORM_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.CovidFlg = Convert.IsDBNull(reader["COVID_FLG"]) ? null : (System.Boolean?)reader["COVID_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStud"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStud"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStud entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudId = (System.Decimal)reader[((int)EdStudColumn.EdStudId - 1)];
			entity.OriginalEdStudId = (System.Decimal)reader["ED_STUD_ID"];
			entity.NationalNumber = (reader.IsDBNull(((int)EdStudColumn.NationalNumber - 1)))?null:(System.String)reader[((int)EdStudColumn.NationalNumber - 1)];
			entity.FullNameAr = (System.String)reader[((int)EdStudColumn.FullNameAr - 1)];
			entity.ClFullNameAr = (reader.IsDBNull(((int)EdStudColumn.ClFullNameAr - 1)))?null:(System.String)reader[((int)EdStudColumn.ClFullNameAr - 1)];
			entity.StudNameAr = (reader.IsDBNull(((int)EdStudColumn.StudNameAr - 1)))?null:(System.String)reader[((int)EdStudColumn.StudNameAr - 1)];
			entity.ClStudNameAr = (reader.IsDBNull(((int)EdStudColumn.ClStudNameAr - 1)))?null:(System.String)reader[((int)EdStudColumn.ClStudNameAr - 1)];
			entity.FatherNameAr = (reader.IsDBNull(((int)EdStudColumn.FatherNameAr - 1)))?null:(System.String)reader[((int)EdStudColumn.FatherNameAr - 1)];
			entity.ClFatherNameAr = (reader.IsDBNull(((int)EdStudColumn.ClFatherNameAr - 1)))?null:(System.String)reader[((int)EdStudColumn.ClFatherNameAr - 1)];
			entity.GrandfatherNameAr = (reader.IsDBNull(((int)EdStudColumn.GrandfatherNameAr - 1)))?null:(System.String)reader[((int)EdStudColumn.GrandfatherNameAr - 1)];
			entity.ClGrandfatherNameAr = (reader.IsDBNull(((int)EdStudColumn.ClGrandfatherNameAr - 1)))?null:(System.String)reader[((int)EdStudColumn.ClGrandfatherNameAr - 1)];
			entity.FamilyNameAr = (reader.IsDBNull(((int)EdStudColumn.FamilyNameAr - 1)))?null:(System.String)reader[((int)EdStudColumn.FamilyNameAr - 1)];
			entity.ClFamilyNameAr = (reader.IsDBNull(((int)EdStudColumn.ClFamilyNameAr - 1)))?null:(System.String)reader[((int)EdStudColumn.ClFamilyNameAr - 1)];
			entity.FullNameEn = (System.String)reader[((int)EdStudColumn.FullNameEn - 1)];
			entity.StudNameEn = (reader.IsDBNull(((int)EdStudColumn.StudNameEn - 1)))?null:(System.String)reader[((int)EdStudColumn.StudNameEn - 1)];
			entity.FatherNameEn = (reader.IsDBNull(((int)EdStudColumn.FatherNameEn - 1)))?null:(System.String)reader[((int)EdStudColumn.FatherNameEn - 1)];
			entity.GrandfatherNameEn = (reader.IsDBNull(((int)EdStudColumn.GrandfatherNameEn - 1)))?null:(System.String)reader[((int)EdStudColumn.GrandfatherNameEn - 1)];
			entity.FamilyNameEn = (reader.IsDBNull(((int)EdStudColumn.FamilyNameEn - 1)))?null:(System.String)reader[((int)EdStudColumn.FamilyNameEn - 1)];
			entity.FatherProfession = (reader.IsDBNull(((int)EdStudColumn.FatherProfession - 1)))?null:(System.String)reader[((int)EdStudColumn.FatherProfession - 1)];
			entity.FatherNationalNumber = (reader.IsDBNull(((int)EdStudColumn.FatherNationalNumber - 1)))?null:(System.String)reader[((int)EdStudColumn.FatherNationalNumber - 1)];
			entity.MotherNationalNumber = (reader.IsDBNull(((int)EdStudColumn.MotherNationalNumber - 1)))?null:(System.String)reader[((int)EdStudColumn.MotherNationalNumber - 1)];
			entity.MotherNameAr = (reader.IsDBNull(((int)EdStudColumn.MotherNameAr - 1)))?null:(System.String)reader[((int)EdStudColumn.MotherNameAr - 1)];
			entity.ClMotherNameAr = (reader.IsDBNull(((int)EdStudColumn.ClMotherNameAr - 1)))?null:(System.String)reader[((int)EdStudColumn.ClMotherNameAr - 1)];
			entity.MotherNameEn = (reader.IsDBNull(((int)EdStudColumn.MotherNameEn - 1)))?null:(System.String)reader[((int)EdStudColumn.MotherNameEn - 1)];
			entity.GsCodeGenderId = (reader.IsDBNull(((int)EdStudColumn.GsCodeGenderId - 1)))?null:(System.Decimal?)reader[((int)EdStudColumn.GsCodeGenderId - 1)];
			entity.GsCodeReligionId = (reader.IsDBNull(((int)EdStudColumn.GsCodeReligionId - 1)))?null:(System.Decimal?)reader[((int)EdStudColumn.GsCodeReligionId - 1)];
			entity.BirthRegNumber = (reader.IsDBNull(((int)EdStudColumn.BirthRegNumber - 1)))?null:(System.String)reader[((int)EdStudColumn.BirthRegNumber - 1)];
			entity.BirthDate = (reader.IsDBNull(((int)EdStudColumn.BirthDate - 1)))?null:(System.DateTime?)reader[((int)EdStudColumn.BirthDate - 1)];
			entity.GsBirthCountryNodeId = (reader.IsDBNull(((int)EdStudColumn.GsBirthCountryNodeId - 1)))?null:(System.Decimal?)reader[((int)EdStudColumn.GsBirthCountryNodeId - 1)];
			entity.GsCountryInfoId1 = (reader.IsDBNull(((int)EdStudColumn.GsCountryInfoId1 - 1)))?null:(System.Decimal?)reader[((int)EdStudColumn.GsCountryInfoId1 - 1)];
			entity.GsCountryInfoId2 = (reader.IsDBNull(((int)EdStudColumn.GsCountryInfoId2 - 1)))?null:(System.Decimal?)reader[((int)EdStudColumn.GsCountryInfoId2 - 1)];
			entity.StudPhoto = (reader.IsDBNull(((int)EdStudColumn.StudPhoto - 1)))?null:(System.String)reader[((int)EdStudColumn.StudPhoto - 1)];
			entity.GsCodeIdentTypeId = (reader.IsDBNull(((int)EdStudColumn.GsCodeIdentTypeId - 1)))?null:(System.Decimal?)reader[((int)EdStudColumn.GsCodeIdentTypeId - 1)];
			entity.IsPrntStaff = (reader.IsDBNull(((int)EdStudColumn.IsPrntStaff - 1)))?null:(System.Decimal?)reader[((int)EdStudColumn.IsPrntStaff - 1)];
			entity.SaStfMemberPrntId = (reader.IsDBNull(((int)EdStudColumn.SaStfMemberPrntId - 1)))?null:(System.Decimal?)reader[((int)EdStudColumn.SaStfMemberPrntId - 1)];
			entity.GsCdeBloodId = (reader.IsDBNull(((int)EdStudColumn.GsCdeBloodId - 1)))?null:(System.Decimal?)reader[((int)EdStudColumn.GsCdeBloodId - 1)];
			entity.StudLnht = (reader.IsDBNull(((int)EdStudColumn.StudLnht - 1)))?null:(System.Decimal?)reader[((int)EdStudColumn.StudLnht - 1)];
			entity.StudWght = (reader.IsDBNull(((int)EdStudColumn.StudWght - 1)))?null:(System.Decimal?)reader[((int)EdStudColumn.StudWght - 1)];
			entity.IdentIssuePlc = (reader.IsDBNull(((int)EdStudColumn.IdentIssuePlc - 1)))?null:(System.String)reader[((int)EdStudColumn.IdentIssuePlc - 1)];
			entity.GsCodeLanguageId = (reader.IsDBNull(((int)EdStudColumn.GsCodeLanguageId - 1)))?null:(System.Decimal?)reader[((int)EdStudColumn.GsCodeLanguageId - 1)];
			entity.PassporNo = (reader.IsDBNull(((int)EdStudColumn.PassporNo - 1)))?null:(System.String)reader[((int)EdStudColumn.PassporNo - 1)];
			entity.PassporExpireDate = (reader.IsDBNull(((int)EdStudColumn.PassporExpireDate - 1)))?null:(System.DateTime?)reader[((int)EdStudColumn.PassporExpireDate - 1)];
			entity.PassporIssueDate = (reader.IsDBNull(((int)EdStudColumn.PassporIssueDate - 1)))?null:(System.DateTime?)reader[((int)EdStudColumn.PassporIssueDate - 1)];
			entity.SpecialNeedFlg = (reader.IsDBNull(((int)EdStudColumn.SpecialNeedFlg - 1)))?null:(System.Boolean?)reader[((int)EdStudColumn.SpecialNeedFlg - 1)];
			entity.EmployeeFlg = (reader.IsDBNull(((int)EdStudColumn.EmployeeFlg - 1)))?null:(System.Boolean?)reader[((int)EdStudColumn.EmployeeFlg - 1)];
			entity.IdentIssueDate = (reader.IsDBNull(((int)EdStudColumn.IdentIssueDate - 1)))?null:(System.DateTime?)reader[((int)EdStudColumn.IdentIssueDate - 1)];
			entity.IdentExpireDate = (reader.IsDBNull(((int)EdStudColumn.IdentExpireDate - 1)))?null:(System.DateTime?)reader[((int)EdStudColumn.IdentExpireDate - 1)];
			entity.HecId = (reader.IsDBNull(((int)EdStudColumn.HecId - 1)))?null:(System.String)reader[((int)EdStudColumn.HecId - 1)];
			entity.GsCdeMaritalStatusId = (reader.IsDBNull(((int)EdStudColumn.GsCdeMaritalStatusId - 1)))?null:(System.Decimal?)reader[((int)EdStudColumn.GsCdeMaritalStatusId - 1)];
			entity.MarriageDate = (reader.IsDBNull(((int)EdStudColumn.MarriageDate - 1)))?null:(System.DateTime?)reader[((int)EdStudColumn.MarriageDate - 1)];
			entity.NoChild = (reader.IsDBNull(((int)EdStudColumn.NoChild - 1)))?null:(System.Int32?)reader[((int)EdStudColumn.NoChild - 1)];
			entity.VisaNumber = (reader.IsDBNull(((int)EdStudColumn.VisaNumber - 1)))?null:(System.String)reader[((int)EdStudColumn.VisaNumber - 1)];
			entity.VisaIssueDate = (reader.IsDBNull(((int)EdStudColumn.VisaIssueDate - 1)))?null:(System.DateTime?)reader[((int)EdStudColumn.VisaIssueDate - 1)];
			entity.VisaExpireDate = (reader.IsDBNull(((int)EdStudColumn.VisaExpireDate - 1)))?null:(System.DateTime?)reader[((int)EdStudColumn.VisaExpireDate - 1)];
			entity.SeFormId = (reader.IsDBNull(((int)EdStudColumn.SeFormId - 1)))?null:(System.Decimal?)reader[((int)EdStudColumn.SeFormId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EdStudColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EdStudColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EdStudColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EdStudColumn.SeUserId - 1)];
			entity.CovidFlg = (reader.IsDBNull(((int)EdStudColumn.CovidFlg - 1)))?null:(System.Boolean?)reader[((int)EdStudColumn.CovidFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStud"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStud"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStud entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.OriginalEdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.NationalNumber = Convert.IsDBNull(dataRow["NATIONAL_NUMBER"]) ? null : (System.String)dataRow["NATIONAL_NUMBER"];
			entity.FullNameAr = (System.String)dataRow["FULL_NAME_AR"];
			entity.ClFullNameAr = Convert.IsDBNull(dataRow["CL_FULL_NAME_AR"]) ? null : (System.String)dataRow["CL_FULL_NAME_AR"];
			entity.StudNameAr = Convert.IsDBNull(dataRow["STUD_NAME_AR"]) ? null : (System.String)dataRow["STUD_NAME_AR"];
			entity.ClStudNameAr = Convert.IsDBNull(dataRow["CL_STUD_NAME_AR"]) ? null : (System.String)dataRow["CL_STUD_NAME_AR"];
			entity.FatherNameAr = Convert.IsDBNull(dataRow["FATHER_NAME_AR"]) ? null : (System.String)dataRow["FATHER_NAME_AR"];
			entity.ClFatherNameAr = Convert.IsDBNull(dataRow["CL_FATHER_NAME_AR"]) ? null : (System.String)dataRow["CL_FATHER_NAME_AR"];
			entity.GrandfatherNameAr = Convert.IsDBNull(dataRow["GRANDFATHER_NAME_AR"]) ? null : (System.String)dataRow["GRANDFATHER_NAME_AR"];
			entity.ClGrandfatherNameAr = Convert.IsDBNull(dataRow["CL_GRANDFATHER_NAME_AR"]) ? null : (System.String)dataRow["CL_GRANDFATHER_NAME_AR"];
			entity.FamilyNameAr = Convert.IsDBNull(dataRow["FAMILY_NAME_AR"]) ? null : (System.String)dataRow["FAMILY_NAME_AR"];
			entity.ClFamilyNameAr = Convert.IsDBNull(dataRow["CL_FAMILY_NAME_AR"]) ? null : (System.String)dataRow["CL_FAMILY_NAME_AR"];
			entity.FullNameEn = (System.String)dataRow["FULL_NAME_EN"];
			entity.StudNameEn = Convert.IsDBNull(dataRow["STUD_NAME_EN"]) ? null : (System.String)dataRow["STUD_NAME_EN"];
			entity.FatherNameEn = Convert.IsDBNull(dataRow["FATHER_NAME_EN"]) ? null : (System.String)dataRow["FATHER_NAME_EN"];
			entity.GrandfatherNameEn = Convert.IsDBNull(dataRow["GRANDFATHER_NAME_EN"]) ? null : (System.String)dataRow["GRANDFATHER_NAME_EN"];
			entity.FamilyNameEn = Convert.IsDBNull(dataRow["FAMILY_NAME_EN"]) ? null : (System.String)dataRow["FAMILY_NAME_EN"];
			entity.FatherProfession = Convert.IsDBNull(dataRow["FATHER_PROFESSION"]) ? null : (System.String)dataRow["FATHER_PROFESSION"];
			entity.FatherNationalNumber = Convert.IsDBNull(dataRow["FATHER_NATIONAL_NUMBER"]) ? null : (System.String)dataRow["FATHER_NATIONAL_NUMBER"];
			entity.MotherNationalNumber = Convert.IsDBNull(dataRow["MOTHER_NATIONAL_NUMBER"]) ? null : (System.String)dataRow["MOTHER_NATIONAL_NUMBER"];
			entity.MotherNameAr = Convert.IsDBNull(dataRow["MOTHER_NAME_AR"]) ? null : (System.String)dataRow["MOTHER_NAME_AR"];
			entity.ClMotherNameAr = Convert.IsDBNull(dataRow["CL_MOTHER_NAME_AR"]) ? null : (System.String)dataRow["CL_MOTHER_NAME_AR"];
			entity.MotherNameEn = Convert.IsDBNull(dataRow["MOTHER_NAME_EN"]) ? null : (System.String)dataRow["MOTHER_NAME_EN"];
			entity.GsCodeGenderId = Convert.IsDBNull(dataRow["GS_CODE_GENDER_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_GENDER_ID"];
			entity.GsCodeReligionId = Convert.IsDBNull(dataRow["GS_CODE_RELIGION_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_RELIGION_ID"];
			entity.BirthRegNumber = Convert.IsDBNull(dataRow["BIRTH_REG_NUMBER"]) ? null : (System.String)dataRow["BIRTH_REG_NUMBER"];
			entity.BirthDate = Convert.IsDBNull(dataRow["BIRTH_DATE"]) ? null : (System.DateTime?)dataRow["BIRTH_DATE"];
			entity.GsBirthCountryNodeId = Convert.IsDBNull(dataRow["GS_BIRTH_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)dataRow["GS_BIRTH_COUNTRY_NODE_ID"];
			entity.GsCountryInfoId1 = Convert.IsDBNull(dataRow["GS_COUNTRY_INFO_ID_1"]) ? null : (System.Decimal?)dataRow["GS_COUNTRY_INFO_ID_1"];
			entity.GsCountryInfoId2 = Convert.IsDBNull(dataRow["GS_COUNTRY_INFO_ID_2"]) ? null : (System.Decimal?)dataRow["GS_COUNTRY_INFO_ID_2"];
			entity.StudPhoto = Convert.IsDBNull(dataRow["STUD_PHOTO"]) ? null : (System.String)dataRow["STUD_PHOTO"];
			entity.GsCodeIdentTypeId = Convert.IsDBNull(dataRow["GS_CODE_IDENT_TYPE_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_IDENT_TYPE_ID"];
			entity.IsPrntStaff = Convert.IsDBNull(dataRow["IS_PRNT_STAFF"]) ? null : (System.Decimal?)dataRow["IS_PRNT_STAFF"];
			entity.SaStfMemberPrntId = Convert.IsDBNull(dataRow["SA_STF_MEMBER_PRNT_ID"]) ? null : (System.Decimal?)dataRow["SA_STF_MEMBER_PRNT_ID"];
			entity.GsCdeBloodId = Convert.IsDBNull(dataRow["GS_CDE_BLOOD_ID"]) ? null : (System.Decimal?)dataRow["GS_CDE_BLOOD_ID"];
			entity.StudLnht = Convert.IsDBNull(dataRow["STUD_LNHT"]) ? null : (System.Decimal?)dataRow["STUD_LNHT"];
			entity.StudWght = Convert.IsDBNull(dataRow["STUD_WGHT"]) ? null : (System.Decimal?)dataRow["STUD_WGHT"];
			entity.IdentIssuePlc = Convert.IsDBNull(dataRow["IDENT_ISSUE_PLC"]) ? null : (System.String)dataRow["IDENT_ISSUE_PLC"];
			entity.GsCodeLanguageId = Convert.IsDBNull(dataRow["GS_CODE_LANGUAGE_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_LANGUAGE_ID"];
			entity.PassporNo = Convert.IsDBNull(dataRow["PASSPOR_NO"]) ? null : (System.String)dataRow["PASSPOR_NO"];
			entity.PassporExpireDate = Convert.IsDBNull(dataRow["PASSPOR_EXPIRE_DATE"]) ? null : (System.DateTime?)dataRow["PASSPOR_EXPIRE_DATE"];
			entity.PassporIssueDate = Convert.IsDBNull(dataRow["PASSPOR_ISSUE_DATE"]) ? null : (System.DateTime?)dataRow["PASSPOR_ISSUE_DATE"];
			entity.SpecialNeedFlg = Convert.IsDBNull(dataRow["SPECIAL_NEED_FLG"]) ? null : (System.Boolean?)dataRow["SPECIAL_NEED_FLG"];
			entity.EmployeeFlg = Convert.IsDBNull(dataRow["EMPLOYEE_FLG"]) ? null : (System.Boolean?)dataRow["EMPLOYEE_FLG"];
			entity.IdentIssueDate = Convert.IsDBNull(dataRow["IDENT_ISSUE_DATE"]) ? null : (System.DateTime?)dataRow["IDENT_ISSUE_DATE"];
			entity.IdentExpireDate = Convert.IsDBNull(dataRow["IDENT_EXPIRE_DATE"]) ? null : (System.DateTime?)dataRow["IDENT_EXPIRE_DATE"];
			entity.HecId = Convert.IsDBNull(dataRow["HEC_ID"]) ? null : (System.String)dataRow["HEC_ID"];
			entity.GsCdeMaritalStatusId = Convert.IsDBNull(dataRow["GS_CDE_MARITAL_STATUS_ID"]) ? null : (System.Decimal?)dataRow["GS_CDE_MARITAL_STATUS_ID"];
			entity.MarriageDate = Convert.IsDBNull(dataRow["MARRIAGE_DATE"]) ? null : (System.DateTime?)dataRow["MARRIAGE_DATE"];
			entity.NoChild = Convert.IsDBNull(dataRow["NO_CHILD"]) ? null : (System.Int32?)dataRow["NO_CHILD"];
			entity.VisaNumber = Convert.IsDBNull(dataRow["VISA_NUMBER"]) ? null : (System.String)dataRow["VISA_NUMBER"];
			entity.VisaIssueDate = Convert.IsDBNull(dataRow["VISA_ISSUE_DATE"]) ? null : (System.DateTime?)dataRow["VISA_ISSUE_DATE"];
			entity.VisaExpireDate = Convert.IsDBNull(dataRow["VISA_EXPIRE_DATE"]) ? null : (System.DateTime?)dataRow["VISA_EXPIRE_DATE"];
			entity.SeFormId = Convert.IsDBNull(dataRow["SE_FORM_ID"]) ? null : (System.Decimal?)dataRow["SE_FORM_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.CovidFlg = Convert.IsDBNull(dataRow["COVID_FLG"]) ? null : (System.Boolean?)dataRow["COVID_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStud"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStud Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStud entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region GsCdeBloodIdSource	
			if (CanDeepLoad(entity, "GsCdeBlood|GsCdeBloodIdSource", deepLoadType, innerList) 
				&& entity.GsCdeBloodIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCdeBloodId ?? 0.0m);
				GsCdeBlood tmpEntity = EntityManager.LocateEntity<GsCdeBlood>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeBlood), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeBloodIdSource = tmpEntity;
				else
					entity.GsCdeBloodIdSource = DataRepository.GsCdeBloodProvider.GetByGsCdeBloodId(transactionManager, (entity.GsCdeBloodId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeBloodIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeBloodIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeBloodProvider.DeepLoad(transactionManager, entity.GsCdeBloodIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeBloodIdSource

			#region GsCdeMaritalStatusIdSource	
			if (CanDeepLoad(entity, "GsCdeMaritalStatus|GsCdeMaritalStatusIdSource", deepLoadType, innerList) 
				&& entity.GsCdeMaritalStatusIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCdeMaritalStatusId ?? 0.0m);
				GsCdeMaritalStatus tmpEntity = EntityManager.LocateEntity<GsCdeMaritalStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeMaritalStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeMaritalStatusIdSource = tmpEntity;
				else
					entity.GsCdeMaritalStatusIdSource = DataRepository.GsCdeMaritalStatusProvider.GetByGsCdeMaritalStatusId(transactionManager, (entity.GsCdeMaritalStatusId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeMaritalStatusIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeMaritalStatusIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeMaritalStatusProvider.DeepLoad(transactionManager, entity.GsCdeMaritalStatusIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeMaritalStatusIdSource

			#region GsCodeGenderIdSource	
			if (CanDeepLoad(entity, "GsCodeGender|GsCodeGenderIdSource", deepLoadType, innerList) 
				&& entity.GsCodeGenderIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeGenderId ?? 0.0m);
				GsCodeGender tmpEntity = EntityManager.LocateEntity<GsCodeGender>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeGender), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeGenderIdSource = tmpEntity;
				else
					entity.GsCodeGenderIdSource = DataRepository.GsCodeGenderProvider.GetByGsCodeGenderId(transactionManager, (entity.GsCodeGenderId ?? 0.0m));		
				
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

			#region GsCodeLanguageIdSource	
			if (CanDeepLoad(entity, "GsCodeLanguage|GsCodeLanguageIdSource", deepLoadType, innerList) 
				&& entity.GsCodeLanguageIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeLanguageId ?? 0.0m);
				GsCodeLanguage tmpEntity = EntityManager.LocateEntity<GsCodeLanguage>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeLanguage), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeLanguageIdSource = tmpEntity;
				else
					entity.GsCodeLanguageIdSource = DataRepository.GsCodeLanguageProvider.GetByGsCodeLanguageId(transactionManager, (entity.GsCodeLanguageId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeLanguageIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeLanguageIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeLanguageProvider.DeepLoad(transactionManager, entity.GsCodeLanguageIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeLanguageIdSource

			#region GsCodeReligionIdSource	
			if (CanDeepLoad(entity, "GsCodeReligion|GsCodeReligionIdSource", deepLoadType, innerList) 
				&& entity.GsCodeReligionIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeReligionId ?? 0.0m);
				GsCodeReligion tmpEntity = EntityManager.LocateEntity<GsCodeReligion>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeReligion), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeReligionIdSource = tmpEntity;
				else
					entity.GsCodeReligionIdSource = DataRepository.GsCodeReligionProvider.GetByGsCodeReligionId(transactionManager, (entity.GsCodeReligionId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeReligionIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeReligionIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeReligionProvider.DeepLoad(transactionManager, entity.GsCodeReligionIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeReligionIdSource

			#region GsCountryInfoId1Source	
			if (CanDeepLoad(entity, "GsCountryNode|GsCountryInfoId1Source", deepLoadType, innerList) 
				&& entity.GsCountryInfoId1Source == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCountryInfoId1 ?? 0.0m);
				GsCountryNode tmpEntity = EntityManager.LocateEntity<GsCountryNode>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCountryNode), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCountryInfoId1Source = tmpEntity;
				else
					entity.GsCountryInfoId1Source = DataRepository.GsCountryNodeProvider.GetByGsCountryNodeId(transactionManager, (entity.GsCountryInfoId1 ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCountryInfoId1Source' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCountryInfoId1Source != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCountryNodeProvider.DeepLoad(transactionManager, entity.GsCountryInfoId1Source, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCountryInfoId1Source

			#region GsBirthCountryNodeIdSource	
			if (CanDeepLoad(entity, "GsCountryNode|GsBirthCountryNodeIdSource", deepLoadType, innerList) 
				&& entity.GsBirthCountryNodeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsBirthCountryNodeId ?? 0.0m);
				GsCountryNode tmpEntity = EntityManager.LocateEntity<GsCountryNode>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCountryNode), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsBirthCountryNodeIdSource = tmpEntity;
				else
					entity.GsBirthCountryNodeIdSource = DataRepository.GsCountryNodeProvider.GetByGsCountryNodeId(transactionManager, (entity.GsBirthCountryNodeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsBirthCountryNodeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsBirthCountryNodeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCountryNodeProvider.DeepLoad(transactionManager, entity.GsBirthCountryNodeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsBirthCountryNodeIdSource

			#region SaStfMemberPrntIdSource	
			if (CanDeepLoad(entity, "SaStfMember|SaStfMemberPrntIdSource", deepLoadType, innerList) 
				&& entity.SaStfMemberPrntIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaStfMemberPrntId ?? 0.0m);
				SaStfMember tmpEntity = EntityManager.LocateEntity<SaStfMember>(EntityLocator.ConstructKeyFromPkItems(typeof(SaStfMember), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaStfMemberPrntIdSource = tmpEntity;
				else
					entity.SaStfMemberPrntIdSource = DataRepository.SaStfMemberProvider.GetBySaStfMemberId(transactionManager, (entity.SaStfMemberPrntId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaStfMemberPrntIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaStfMemberPrntIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaStfMemberProvider.DeepLoad(transactionManager, entity.SaStfMemberPrntIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaStfMemberPrntIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdStudId methods when available
			
			#region EdStudFacultyCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudFaculty>|EdStudFacultyCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudFacultyCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudFacultyCollection = DataRepository.EdStudFacultyProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudFacultyCollection.Count > 0)
				{
					deepHandles.Add("EdStudFacultyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudFaculty>) DataRepository.EdStudFacultyProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudFacultyCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudTransCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudTrans>|EdStudTransCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudTransCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudTransCollection = DataRepository.EdStudTransProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudTransCollection.Count > 0)
				{
					deepHandles.Add("EdStudTransCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudTrans>) DataRepository.EdStudTransProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudTransCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvStudAskAdvReCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStudAskAdvRe>|SvStudAskAdvReCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStudAskAdvReCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStudAskAdvReCollection = DataRepository.SvStudAskAdvReProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.SvStudAskAdvReCollection.Count > 0)
				{
					deepHandles.Add("SvStudAskAdvReCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStudAskAdvRe>) DataRepository.SvStudAskAdvReProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStudAskAdvReCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomStudResponsibleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudResponsible>|AccomStudResponsibleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudResponsibleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudResponsibleCollection = DataRepository.AccomStudResponsibleProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.AccomStudResponsibleCollection.Count > 0)
				{
					deepHandles.Add("AccomStudResponsibleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudResponsible>) DataRepository.AccomStudResponsibleProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudResponsibleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudBank
			// RelationshipType.OneToOne
			if (CanDeepLoad(entity, "FeeStudBank|FeeStudBank", deepLoadType, innerList))
			{
				entity.FeeStudBank = DataRepository.FeeStudBankProvider.GetByEdStudId(transactionManager, entity.EdStudId);
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudBank' loaded. key " + entity.EntityTrackingKey);
				#endif 

				if (deep && entity.FeeStudBank != null)
				{
					deepHandles.Add("FeeStudBank",
						new KeyValuePair<Delegate, object>((DeepLoadSingleHandle< FeeStudBank >) DataRepository.FeeStudBankProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudBank, deep, deepLoadType, childTypes, innerList }
					));
				}
			}
			#endregion 
			
			
			
			#region EdStudCourseRegPreCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseRegPre>|EdStudCourseRegPreCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegPreCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegPreCollection = DataRepository.EdStudCourseRegPreProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudCourseRegPreCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegPreCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseRegPre>) DataRepository.EdStudCourseRegPreProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegPreCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvStudStaffEvalExtCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStudStaffEvalExt>|SvStudStaffEvalExtCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStudStaffEvalExtCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStudStaffEvalExtCollection = DataRepository.SvStudStaffEvalExtProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.SvStudStaffEvalExtCollection.Count > 0)
				{
					deepHandles.Add("SvStudStaffEvalExtCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStudStaffEvalExt>) DataRepository.SvStudStaffEvalExtProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStudStaffEvalExtCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudSemesterTempCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudSemesterTemp>|EdStudSemesterTempCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudSemesterTempCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudSemesterTempCollection = DataRepository.EdStudSemesterTempProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudSemesterTempCollection.Count > 0)
				{
					deepHandles.Add("EdStudSemesterTempCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudSemesterTemp>) DataRepository.EdStudSemesterTempProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudSemesterTempCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region MdiStudProblemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MdiStudProblem>|MdiStudProblemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MdiStudProblemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MdiStudProblemCollection = DataRepository.MdiStudProblemProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.MdiStudProblemCollection.Count > 0)
				{
					deepHandles.Add("MdiStudProblemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MdiStudProblem>) DataRepository.MdiStudProblemProvider.DeepLoad,
						new object[] { transactionManager, entity.MdiStudProblemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudInstallmentCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudInstallment>|FeeStudInstallmentCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudInstallmentCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudInstallmentCollection = DataRepository.FeeStudInstallmentProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.FeeStudInstallmentCollection.Count > 0)
				{
					deepHandles.Add("FeeStudInstallmentCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudInstallment>) DataRepository.FeeStudInstallmentProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudInstallmentCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScStudGroupCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScStudGroup>|ScStudGroupCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScStudGroupCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScStudGroupCollection = DataRepository.ScStudGroupProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.ScStudGroupCollection.Count > 0)
				{
					deepHandles.Add("ScStudGroupCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScStudGroup>) DataRepository.ScStudGroupProvider.DeepLoad,
						new object[] { transactionManager, entity.ScStudGroupCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudMltryCrsCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudMltryCrs>|EdStudMltryCrsCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudMltryCrsCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudMltryCrsCollection = DataRepository.EdStudMltryCrsProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudMltryCrsCollection.Count > 0)
				{
					deepHandles.Add("EdStudMltryCrsCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudMltryCrs>) DataRepository.EdStudMltryCrsProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudMltryCrsCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region RsrchStudRegisterCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<RsrchStudRegister>|RsrchStudRegisterCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'RsrchStudRegisterCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.RsrchStudRegisterCollection = DataRepository.RsrchStudRegisterProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.RsrchStudRegisterCollection.Count > 0)
				{
					deepHandles.Add("RsrchStudRegisterCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<RsrchStudRegister>) DataRepository.RsrchStudRegisterProvider.DeepLoad,
						new object[] { transactionManager, entity.RsrchStudRegisterCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdTrainStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdTrainStud>|EdTrainStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdTrainStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdTrainStudCollection = DataRepository.EdTrainStudProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdTrainStudCollection.Count > 0)
				{
					deepHandles.Add("EdTrainStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdTrainStud>) DataRepository.EdTrainStudProvider.DeepLoad,
						new object[] { transactionManager, entity.EdTrainStudCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudMilitaryStateCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudMilitaryState>|EdStudMilitaryStateCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudMilitaryStateCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudMilitaryStateCollection = DataRepository.EdStudMilitaryStateProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudMilitaryStateCollection.Count > 0)
				{
					deepHandles.Add("EdStudMilitaryStateCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudMilitaryState>) DataRepository.EdStudMilitaryStateProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudMilitaryStateCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudGraduationAwardCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudGraduationAward>|EdStudGraduationAwardCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudGraduationAwardCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudGraduationAwardCollection = DataRepository.EdStudGraduationAwardProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudGraduationAwardCollection.Count > 0)
				{
					deepHandles.Add("EdStudGraduationAwardCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudGraduationAward>) DataRepository.EdStudGraduationAwardProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudGraduationAwardCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudGuardCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudGuard>|EdStudGuardCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudGuardCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudGuardCollection = DataRepository.EdStudGuardProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudGuardCollection.Count > 0)
				{
					deepHandles.Add("EdStudGuardCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudGuard>) DataRepository.EdStudGuardProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudGuardCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudTransFromReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudTransFromReq>|EdStudTransFromReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudTransFromReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudTransFromReqCollection = DataRepository.EdStudTransFromReqProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudTransFromReqCollection.Count > 0)
				{
					deepHandles.Add("EdStudTransFromReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudTransFromReq>) DataRepository.EdStudTransFromReqProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudTransFromReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvStudStaffEvalCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStudStaffEval>|SvStudStaffEvalCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStudStaffEvalCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStudStaffEvalCollection = DataRepository.SvStudStaffEvalProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.SvStudStaffEvalCollection.Count > 0)
				{
					deepHandles.Add("SvStudStaffEvalCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStudStaffEval>) DataRepository.SvStudStaffEvalProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStudStaffEvalCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTrnsStateFromCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrnsStateFrom>|EdStudIntTrnsStateFromCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsStateFromCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsStateFromCollection = DataRepository.EdStudIntTrnsStateFromProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudIntTrnsStateFromCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsStateFromCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsStateFrom>) DataRepository.EdStudIntTrnsStateFromProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsStateFromCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudAcadWarnCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudAcadWarn>|EdStudAcadWarnCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudAcadWarnCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudAcadWarnCollection = DataRepository.EdStudAcadWarnProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudAcadWarnCollection.Count > 0)
				{
					deepHandles.Add("EdStudAcadWarnCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudAcadWarn>) DataRepository.EdStudAcadWarnProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudAcadWarnCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region MdiStudHosptlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MdiStudHosptl>|MdiStudHosptlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MdiStudHosptlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MdiStudHosptlCollection = DataRepository.MdiStudHosptlProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.MdiStudHosptlCollection.Count > 0)
				{
					deepHandles.Add("MdiStudHosptlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MdiStudHosptl>) DataRepository.MdiStudHosptlProvider.DeepLoad,
						new object[] { transactionManager, entity.MdiStudHosptlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudLangCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudLang>|EdStudLangCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudLangCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudLangCollection = DataRepository.EdStudLangProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudLangCollection.Count > 0)
				{
					deepHandles.Add("EdStudLangCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudLang>) DataRepository.EdStudLangProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudLangCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region MdiStudRecordCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MdiStudRecord>|MdiStudRecordCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MdiStudRecordCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MdiStudRecordCollection = DataRepository.MdiStudRecordProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.MdiStudRecordCollection.Count > 0)
				{
					deepHandles.Add("MdiStudRecordCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MdiStudRecord>) DataRepository.MdiStudRecordProvider.DeepLoad,
						new object[] { transactionManager, entity.MdiStudRecordCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudLatenessCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudLateness>|EdStudLatenessCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudLatenessCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudLatenessCollection = DataRepository.EdStudLatenessProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudLatenessCollection.Count > 0)
				{
					deepHandles.Add("EdStudLatenessCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudLateness>) DataRepository.EdStudLatenessProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudLatenessCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudItemCnclCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudItemCncl>|FeeStudItemCnclCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudItemCnclCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudItemCnclCollection = DataRepository.FeeStudItemCnclProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.FeeStudItemCnclCollection.Count > 0)
				{
					deepHandles.Add("FeeStudItemCnclCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudItemCncl>) DataRepository.FeeStudItemCnclProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudItemCnclCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudActivityCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudActivity>|EdStudActivityCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudActivityCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudActivityCollection = DataRepository.EdStudActivityProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudActivityCollection.Count > 0)
				{
					deepHandles.Add("EdStudActivityCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudActivity>) DataRepository.EdStudActivityProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudActivityCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudPayPostponeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudPayPostpone>|FeeStudPayPostponeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudPayPostponeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudPayPostponeCollection = DataRepository.FeeStudPayPostponeProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.FeeStudPayPostponeCollection.Count > 0)
				{
					deepHandles.Add("FeeStudPayPostponeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudPayPostpone>) DataRepository.FeeStudPayPostponeProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudPayPostponeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudRsdncyCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudRsdncy>|EdStudRsdncyCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudRsdncyCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudRsdncyCollection = DataRepository.EdStudRsdncyProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudRsdncyCollection.Count > 0)
				{
					deepHandles.Add("EdStudRsdncyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudRsdncy>) DataRepository.EdStudRsdncyProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudRsdncyCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region MltStudInfoCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MltStudInfo>|MltStudInfoCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MltStudInfoCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MltStudInfoCollection = DataRepository.MltStudInfoProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.MltStudInfoCollection.Count > 0)
				{
					deepHandles.Add("MltStudInfoCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MltStudInfo>) DataRepository.MltStudInfoProvider.DeepLoad,
						new object[] { transactionManager, entity.MltStudInfoCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvStudLockerReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStudLockerReq>|SvStudLockerReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStudLockerReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStudLockerReqCollection = DataRepository.SvStudLockerReqProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.SvStudLockerReqCollection.Count > 0)
				{
					deepHandles.Add("SvStudLockerReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStudLockerReq>) DataRepository.SvStudLockerReqProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStudLockerReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudMissionCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudMission>|EdStudMissionCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudMissionCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudMissionCollection = DataRepository.EdStudMissionProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudMissionCollection.Count > 0)
				{
					deepHandles.Add("EdStudMissionCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudMission>) DataRepository.EdStudMissionProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudMissionCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppWorkExperCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppWorkExper>|AdmAppWorkExperCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppWorkExperCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppWorkExperCollection = DataRepository.AdmAppWorkExperProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.AdmAppWorkExperCollection.Count > 0)
				{
					deepHandles.Add("AdmAppWorkExperCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppWorkExper>) DataRepository.AdmAppWorkExperProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppWorkExperCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudNoteCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudNote>|EdStudNoteCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudNoteCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudNoteCollection = DataRepository.EdStudNoteProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudNoteCollection.Count > 0)
				{
					deepHandles.Add("EdStudNoteCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudNote>) DataRepository.EdStudNoteProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudNoteCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudAcadmicAdvCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudAcadmicAdv>|EdStudAcadmicAdvCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudAcadmicAdvCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudAcadmicAdvCollection = DataRepository.EdStudAcadmicAdvProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudAcadmicAdvCollection.Count > 0)
				{
					deepHandles.Add("EdStudAcadmicAdvCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudAcadmicAdv>) DataRepository.EdStudAcadmicAdvProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudAcadmicAdvCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CtrSrvcCrewCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CtrSrvcCrew>|CtrSrvcCrewCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CtrSrvcCrewCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CtrSrvcCrewCollection = DataRepository.CtrSrvcCrewProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.CtrSrvcCrewCollection.Count > 0)
				{
					deepHandles.Add("CtrSrvcCrewCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CtrSrvcCrew>) DataRepository.CtrSrvcCrewProvider.DeepLoad,
						new object[] { transactionManager, entity.CtrSrvcCrewCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeBlockTransCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeBlockTrans>|SeBlockTransCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeBlockTransCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeBlockTransCollection = DataRepository.SeBlockTransProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.SeBlockTransCollection.Count > 0)
				{
					deepHandles.Add("SeBlockTransCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeBlockTrans>) DataRepository.SeBlockTransProvider.DeepLoad,
						new object[] { transactionManager, entity.SeBlockTransCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.SpoSponsorStudCollection = DataRepository.SpoSponsorStudProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.SpoSponsorStudCollection.Count > 0)
				{
					deepHandles.Add("SpoSponsorStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoSponsorStud>) DataRepository.SpoSponsorStudProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoSponsorStudCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AlmJobCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AlmJob>|AlmJobCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AlmJobCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AlmJobCollection = DataRepository.AlmJobProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.AlmJobCollection.Count > 0)
				{
					deepHandles.Add("AlmJobCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AlmJob>) DataRepository.AlmJobProvider.DeepLoad,
						new object[] { transactionManager, entity.AlmJobCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudVoucherCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudVoucher>|FeeStudVoucherCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudVoucherCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudVoucherCollection = DataRepository.FeeStudVoucherProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.FeeStudVoucherCollection.Count > 0)
				{
					deepHandles.Add("FeeStudVoucherCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudVoucher>) DataRepository.FeeStudVoucherProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudVoucherCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SpoSponsorStudSemesterCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoSponsorStudSemester>|SpoSponsorStudSemesterCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorStudSemesterCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoSponsorStudSemesterCollection = DataRepository.SpoSponsorStudSemesterProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.SpoSponsorStudSemesterCollection.Count > 0)
				{
					deepHandles.Add("SpoSponsorStudSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoSponsorStudSemester>) DataRepository.SpoSponsorStudSemesterProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoSponsorStudSemesterCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudFundCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudFund>|FeeStudFundCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudFundCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudFundCollection = DataRepository.FeeStudFundProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.FeeStudFundCollection.Count > 0)
				{
					deepHandles.Add("FeeStudFundCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudFund>) DataRepository.FeeStudFundProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudFundCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgStudTravelCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgStudTravel>|PgStudTravelCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgStudTravelCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgStudTravelCollection = DataRepository.PgStudTravelProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.PgStudTravelCollection.Count > 0)
				{
					deepHandles.Add("PgStudTravelCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgStudTravel>) DataRepository.PgStudTravelProvider.DeepLoad,
						new object[] { transactionManager, entity.PgStudTravelCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CtrStudOutCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CtrStudOut>|CtrStudOutCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CtrStudOutCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CtrStudOutCollection = DataRepository.CtrStudOutProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.CtrStudOutCollection.Count > 0)
				{
					deepHandles.Add("CtrStudOutCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CtrStudOut>) DataRepository.CtrStudOutProvider.DeepLoad,
						new object[] { transactionManager, entity.CtrStudOutCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudDiscCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudDisc>|FeeStudDiscCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudDiscCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudDiscCollection = DataRepository.FeeStudDiscProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.FeeStudDiscCollection.Count > 0)
				{
					deepHandles.Add("FeeStudDiscCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudDisc>) DataRepository.FeeStudDiscProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudDiscCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudSportCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudSport>|EdStudSportCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudSportCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudSportCollection = DataRepository.EdStudSportProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudSportCollection.Count > 0)
				{
					deepHandles.Add("EdStudSportCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudSport>) DataRepository.EdStudSportProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudSportCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region MdiStudVaccCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MdiStudVacc>|MdiStudVaccCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MdiStudVaccCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MdiStudVaccCollection = DataRepository.MdiStudVaccProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.MdiStudVaccCollection.Count > 0)
				{
					deepHandles.Add("MdiStudVaccCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MdiStudVacc>) DataRepository.MdiStudVaccProvider.DeepLoad,
						new object[] { transactionManager, entity.MdiStudVaccCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CtrStudExpCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CtrStudExp>|CtrStudExpCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CtrStudExpCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CtrStudExpCollection = DataRepository.CtrStudExpProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.CtrStudExpCollection.Count > 0)
				{
					deepHandles.Add("CtrStudExpCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CtrStudExp>) DataRepository.CtrStudExpProvider.DeepLoad,
						new object[] { transactionManager, entity.CtrStudExpCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region MdiStudClnqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MdiStudClnq>|MdiStudClnqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MdiStudClnqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MdiStudClnqCollection = DataRepository.MdiStudClnqProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.MdiStudClnqCollection.Count > 0)
				{
					deepHandles.Add("MdiStudClnqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MdiStudClnq>) DataRepository.MdiStudClnqProvider.DeepLoad,
						new object[] { transactionManager, entity.MdiStudClnqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisStud>|PgThesisStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisStudCollection = DataRepository.PgThesisStudProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.PgThesisStudCollection.Count > 0)
				{
					deepHandles.Add("PgThesisStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisStud>) DataRepository.PgThesisStudProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisStudCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudRetrieveRequestCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudRetrieveRequest>|FeeStudRetrieveRequestCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudRetrieveRequestCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudRetrieveRequestCollection = DataRepository.FeeStudRetrieveRequestProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.FeeStudRetrieveRequestCollection.Count > 0)
				{
					deepHandles.Add("FeeStudRetrieveRequestCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudRetrieveRequest>) DataRepository.FeeStudRetrieveRequestProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudRetrieveRequestCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudViolCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudViol>|EdStudViolCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudViolCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudViolCollection = DataRepository.EdStudViolProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudViolCollection.Count > 0)
				{
					deepHandles.Add("EdStudViolCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudViol>) DataRepository.EdStudViolProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudViolCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmApplicantCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmApplicant>|AdmApplicantCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmApplicantCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmApplicantCollection = DataRepository.AdmApplicantProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.AdmApplicantCollection.Count > 0)
				{
					deepHandles.Add("AdmApplicantCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmApplicant>) DataRepository.AdmApplicantProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmApplicantCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdStudIntTrnsCourseFromCollection = DataRepository.EdStudIntTrnsCourseFromProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudIntTrnsCourseFromCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsCourseFromCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsCourseFrom>) DataRepository.EdStudIntTrnsCourseFromProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsCourseFromCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomStudAbsenceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudAbsence>|AccomStudAbsenceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudAbsenceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudAbsenceCollection = DataRepository.AccomStudAbsenceProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.AccomStudAbsenceCollection.Count > 0)
				{
					deepHandles.Add("AccomStudAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudAbsence>) DataRepository.AccomStudAbsenceProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudAbsenceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeItemTrnsBlncCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeItemTrnsBlnc>|FeeItemTrnsBlncCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeItemTrnsBlncCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeItemTrnsBlncCollection = DataRepository.FeeItemTrnsBlncProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.FeeItemTrnsBlncCollection.Count > 0)
				{
					deepHandles.Add("FeeItemTrnsBlncCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeItemTrnsBlnc>) DataRepository.FeeItemTrnsBlncProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeItemTrnsBlncCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmScholorshipCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmScholorship>|AdmScholorshipCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmScholorshipCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmScholorshipCollection = DataRepository.AdmScholorshipProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.AdmScholorshipCollection.Count > 0)
				{
					deepHandles.Add("AdmScholorshipCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmScholorship>) DataRepository.AdmScholorshipProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmScholorshipCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudInstallmentRequestCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudInstallmentRequest>|FeeStudInstallmentRequestCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudInstallmentRequestCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudInstallmentRequestCollection = DataRepository.FeeStudInstallmentRequestProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.FeeStudInstallmentRequestCollection.Count > 0)
				{
					deepHandles.Add("FeeStudInstallmentRequestCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudInstallmentRequest>) DataRepository.FeeStudInstallmentRequestProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudInstallmentRequestCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudGrantTempCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudGrantTemp>|EdStudGrantTempCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudGrantTempCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudGrantTempCollection = DataRepository.EdStudGrantTempProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudGrantTempCollection.Count > 0)
				{
					deepHandles.Add("EdStudGrantTempCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudGrantTemp>) DataRepository.EdStudGrantTempProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudGrantTempCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudAllowanceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudAllowance>|FeeStudAllowanceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudAllowanceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudAllowanceCollection = DataRepository.FeeStudAllowanceProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.FeeStudAllowanceCollection.Count > 0)
				{
					deepHandles.Add("FeeStudAllowanceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudAllowance>) DataRepository.FeeStudAllowanceProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudAllowanceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeInvoiceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeInvoice>|FeeInvoiceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeInvoiceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeInvoiceCollection = DataRepository.FeeInvoiceProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.FeeInvoiceCollection.Count > 0)
				{
					deepHandles.Add("FeeInvoiceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeInvoice>) DataRepository.FeeInvoiceProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeInvoiceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudProblemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudProblem>|EdStudProblemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudProblemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudProblemCollection = DataRepository.EdStudProblemProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudProblemCollection.Count > 0)
				{
					deepHandles.Add("EdStudProblemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudProblem>) DataRepository.EdStudProblemProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudProblemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AlmPrintRequestCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AlmPrintRequest>|AlmPrintRequestCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AlmPrintRequestCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AlmPrintRequestCollection = DataRepository.AlmPrintRequestProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.AlmPrintRequestCollection.Count > 0)
				{
					deepHandles.Add("AlmPrintRequestCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AlmPrintRequest>) DataRepository.AlmPrintRequestProvider.DeepLoad,
						new object[] { transactionManager, entity.AlmPrintRequestCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeInstlmntStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeInstlmntStud>|FeeInstlmntStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeInstlmntStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeInstlmntStudCollection = DataRepository.FeeInstlmntStudProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.FeeInstlmntStudCollection.Count > 0)
				{
					deepHandles.Add("FeeInstlmntStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeInstlmntStud>) DataRepository.FeeInstlmntStudProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeInstlmntStudCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCodeChngCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCodeChng>|EdStudCodeChngCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCodeChngCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCodeChngCollection = DataRepository.EdStudCodeChngProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudCodeChngCollection.Count > 0)
				{
					deepHandles.Add("EdStudCodeChngCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCodeChng>) DataRepository.EdStudCodeChngProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCodeChngCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudGrantDegreeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudGrantDegree>|EdStudGrantDegreeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudGrantDegreeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudGrantDegreeCollection = DataRepository.EdStudGrantDegreeProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudGrantDegreeCollection.Count > 0)
				{
					deepHandles.Add("EdStudGrantDegreeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudGrantDegree>) DataRepository.EdStudGrantDegreeProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudGrantDegreeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdProjStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdProjStud>|EdProjStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdProjStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdProjStudCollection = DataRepository.EdProjStudProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdProjStudCollection.Count > 0)
				{
					deepHandles.Add("EdProjStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdProjStud>) DataRepository.EdProjStudProvider.DeepLoad,
						new object[] { transactionManager, entity.EdProjStudCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudExmptReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudExmptReq>|EdStudExmptReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudExmptReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudExmptReqCollection = DataRepository.EdStudExmptReqProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudExmptReqCollection.Count > 0)
				{
					deepHandles.Add("EdStudExmptReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudExmptReq>) DataRepository.EdStudExmptReqProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudExmptReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppDoc>|AdmAppDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppDocCollection = DataRepository.AdmAppDocProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.AdmAppDocCollection.Count > 0)
				{
					deepHandles.Add("AdmAppDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppDoc>) DataRepository.AdmAppDocProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppDocCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region RsrchStudPostponeReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<RsrchStudPostponeReq>|RsrchStudPostponeReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'RsrchStudPostponeReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.RsrchStudPostponeReqCollection = DataRepository.RsrchStudPostponeReqProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.RsrchStudPostponeReqCollection.Count > 0)
				{
					deepHandles.Add("RsrchStudPostponeReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<RsrchStudPostponeReq>) DataRepository.RsrchStudPostponeReqProvider.DeepLoad,
						new object[] { transactionManager, entity.RsrchStudPostponeReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region TrnsStudCarStkrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<TrnsStudCarStkr>|TrnsStudCarStkrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'TrnsStudCarStkrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.TrnsStudCarStkrCollection = DataRepository.TrnsStudCarStkrProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.TrnsStudCarStkrCollection.Count > 0)
				{
					deepHandles.Add("TrnsStudCarStkrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<TrnsStudCarStkr>) DataRepository.TrnsStudCarStkrProvider.DeepLoad,
						new object[] { transactionManager, entity.TrnsStudCarStkrCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisNoteCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisNote>|PgThesisNoteCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisNoteCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisNoteCollection = DataRepository.PgThesisNoteProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.PgThesisNoteCollection.Count > 0)
				{
					deepHandles.Add("PgThesisNoteCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisNote>) DataRepository.PgThesisNoteProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisNoteCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudNatSimilarityRequestCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudNatSimilarityRequest>|FeeStudNatSimilarityRequestCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudNatSimilarityRequestCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudNatSimilarityRequestCollection = DataRepository.FeeStudNatSimilarityRequestProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.FeeStudNatSimilarityRequestCollection.Count > 0)
				{
					deepHandles.Add("FeeStudNatSimilarityRequestCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudNatSimilarityRequest>) DataRepository.FeeStudNatSimilarityRequestProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudNatSimilarityRequestCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudSemesterCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudSemester>|EdStudSemesterCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudSemesterCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudSemesterCollection = DataRepository.EdStudSemesterProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudSemesterCollection.Count > 0)
				{
					deepHandles.Add("EdStudSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudSemester>) DataRepository.EdStudSemesterProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudSemesterCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvSrvyRespondQstnCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvSrvyRespondQstn>|SvSrvyRespondQstnCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvSrvyRespondQstnCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvSrvyRespondQstnCollection = DataRepository.SvSrvyRespondQstnProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.SvSrvyRespondQstnCollection.Count > 0)
				{
					deepHandles.Add("SvSrvyRespondQstnCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvSrvyRespondQstn>) DataRepository.SvSrvyRespondQstnProvider.DeepLoad,
						new object[] { transactionManager, entity.SvSrvyRespondQstnCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudExecuseReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudExecuseReq>|EdStudExecuseReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudExecuseReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudExecuseReqCollection = DataRepository.EdStudExecuseReqProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudExecuseReqCollection.Count > 0)
				{
					deepHandles.Add("EdStudExecuseReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudExecuseReq>) DataRepository.EdStudExecuseReqProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudExecuseReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeRefndStdReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeRefndStdReq>|FeeRefndStdReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeRefndStdReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeRefndStdReqCollection = DataRepository.FeeRefndStdReqProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.FeeRefndStdReqCollection.Count > 0)
				{
					deepHandles.Add("FeeRefndStdReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeRefndStdReq>) DataRepository.FeeRefndStdReqProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeRefndStdReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvStudPollCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStudPoll>|SvStudPollCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStudPollCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStudPollCollection = DataRepository.SvStudPollProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.SvStudPollCollection.Count > 0)
				{
					deepHandles.Add("SvStudPollCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStudPoll>) DataRepository.SvStudPollProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStudPollCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudAbsenceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudAbsence>|EdStudAbsenceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudAbsenceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudAbsenceCollection = DataRepository.EdStudAbsenceProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudAbsenceCollection.Count > 0)
				{
					deepHandles.Add("EdStudAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudAbsence>) DataRepository.EdStudAbsenceProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudAbsenceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudCoursesItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudCoursesItem>|FeeStudCoursesItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudCoursesItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudCoursesItemCollection = DataRepository.FeeStudCoursesItemProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.FeeStudCoursesItemCollection.Count > 0)
				{
					deepHandles.Add("FeeStudCoursesItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudCoursesItem>) DataRepository.FeeStudCoursesItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudCoursesItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudAbsFwCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudAbsFw>|EdStudAbsFwCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudAbsFwCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudAbsFwCollection = DataRepository.EdStudAbsFwProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudAbsFwCollection.Count > 0)
				{
					deepHandles.Add("EdStudAbsFwCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudAbsFw>) DataRepository.EdStudAbsFwProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudAbsFwCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdAcdadvRmkCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdAcdadvRmk>|EdAcdadvRmkCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcdadvRmkCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdAcdadvRmkCollection = DataRepository.EdAcdadvRmkProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdAcdadvRmkCollection.Count > 0)
				{
					deepHandles.Add("EdAcdadvRmkCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdAcdadvRmk>) DataRepository.EdAcdadvRmkProvider.DeepLoad,
						new object[] { transactionManager, entity.EdAcdadvRmkCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseCompCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseComp>|EdStudCourseCompCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseCompCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseCompCollection = DataRepository.EdStudCourseCompProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudCourseCompCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseCompCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseComp>) DataRepository.EdStudCourseCompProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseCompCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvStudCourseEvalCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStudCourseEval>|SvStudCourseEvalCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStudCourseEvalCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStudCourseEvalCollection = DataRepository.SvStudCourseEvalProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.SvStudCourseEvalCollection.Count > 0)
				{
					deepHandles.Add("SvStudCourseEvalCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStudCourseEval>) DataRepository.SvStudCourseEvalProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStudCourseEvalCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppDisabilityCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppDisability>|AdmAppDisabilityCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppDisabilityCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppDisabilityCollection = DataRepository.AdmAppDisabilityProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.AdmAppDisabilityCollection.Count > 0)
				{
					deepHandles.Add("AdmAppDisabilityCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppDisability>) DataRepository.AdmAppDisabilityProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppDisabilityCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudContactMethodCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudContactMethod>|EdStudContactMethodCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudContactMethodCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudContactMethodCollection = DataRepository.EdStudContactMethodProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudContactMethodCollection.Count > 0)
				{
					deepHandles.Add("EdStudContactMethodCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudContactMethod>) DataRepository.EdStudContactMethodProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudContactMethodCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomStudReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudReq>|AccomStudReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudReqCollection = DataRepository.AccomStudReqProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.AccomStudReqCollection.Count > 0)
				{
					deepHandles.Add("AccomStudReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudReq>) DataRepository.AccomStudReqProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdResidencyStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdResidencyStud>|EdResidencyStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdResidencyStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdResidencyStudCollection = DataRepository.EdResidencyStudProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdResidencyStudCollection.Count > 0)
				{
					deepHandles.Add("EdResidencyStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdResidencyStud>) DataRepository.EdResidencyStudProvider.DeepLoad,
						new object[] { transactionManager, entity.EdResidencyStudCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudStateTempCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudStateTemp>|EdStudStateTempCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudStateTempCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudStateTempCollection = DataRepository.EdStudStateTempProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudStateTempCollection.Count > 0)
				{
					deepHandles.Add("EdStudStateTempCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudStateTemp>) DataRepository.EdStudStateTempProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudStateTempCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgStudPublishCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgStudPublish>|PgStudPublishCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgStudPublishCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgStudPublishCollection = DataRepository.PgStudPublishProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.PgStudPublishCollection.Count > 0)
				{
					deepHandles.Add("PgStudPublishCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgStudPublish>) DataRepository.PgStudPublishProvider.DeepLoad,
						new object[] { transactionManager, entity.PgStudPublishCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdStudIntTrnsCourseToCollection = DataRepository.EdStudIntTrnsCourseToProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudIntTrnsCourseToCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsCourseToCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsCourseTo>) DataRepository.EdStudIntTrnsCourseToProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsCourseToCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTrnsStateToCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrnsStateTo>|EdStudIntTrnsStateToCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsStateToCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsStateToCollection = DataRepository.EdStudIntTrnsStateToProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudIntTrnsStateToCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsStateToCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsStateTo>) DataRepository.EdStudIntTrnsStateToProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsStateToCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudFeeItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudFeeItem>|FeeStudFeeItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudFeeItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudFeeItemCollection = DataRepository.FeeStudFeeItemProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.FeeStudFeeItemCollection.Count > 0)
				{
					deepHandles.Add("FeeStudFeeItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudFeeItem>) DataRepository.FeeStudFeeItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudFeeItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdPrintReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdPrintReq>|EdPrintReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdPrintReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdPrintReqCollection = DataRepository.EdPrintReqProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdPrintReqCollection.Count > 0)
				{
					deepHandles.Add("EdPrintReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdPrintReq>) DataRepository.EdPrintReqProvider.DeepLoad,
						new object[] { transactionManager, entity.EdPrintReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsAddressDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsAddressDtl>|GsAddressDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsAddressDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsAddressDtlCollection = DataRepository.GsAddressDtlProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.GsAddressDtlCollection.Count > 0)
				{
					deepHandles.Add("GsAddressDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsAddressDtl>) DataRepository.GsAddressDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.GsAddressDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region TrnsStudReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<TrnsStudReq>|TrnsStudReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'TrnsStudReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.TrnsStudReqCollection = DataRepository.TrnsStudReqProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.TrnsStudReqCollection.Count > 0)
				{
					deepHandles.Add("TrnsStudReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<TrnsStudReq>) DataRepository.TrnsStudReqProvider.DeepLoad,
						new object[] { transactionManager, entity.TrnsStudReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvStudAskAdvCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStudAskAdv>|SvStudAskAdvCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStudAskAdvCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStudAskAdvCollection = DataRepository.SvStudAskAdvProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.SvStudAskAdvCollection.Count > 0)
				{
					deepHandles.Add("SvStudAskAdvCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStudAskAdv>) DataRepository.SvStudAskAdvProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStudAskAdvCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomStudBookCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudBook>|AccomStudBookCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudBookCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudBookCollection = DataRepository.AccomStudBookProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.AccomStudBookCollection.Count > 0)
				{
					deepHandles.Add("AccomStudBookCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudBook>) DataRepository.AccomStudBookProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudBookCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvStudCourseEvalExtCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStudCourseEvalExt>|SvStudCourseEvalExtCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStudCourseEvalExtCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStudCourseEvalExtCollection = DataRepository.SvStudCourseEvalExtProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.SvStudCourseEvalExtCollection.Count > 0)
				{
					deepHandles.Add("SvStudCourseEvalExtCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStudCourseEvalExt>) DataRepository.SvStudCourseEvalExtProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStudCourseEvalExtCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTrnsCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrns>|EdStudIntTrnsCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsCollection = DataRepository.EdStudIntTrnsProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudIntTrnsCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrns>) DataRepository.EdStudIntTrnsProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvStudCompCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStudComp>|SvStudCompCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStudCompCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStudCompCollection = DataRepository.SvStudCompProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.SvStudCompCollection.Count > 0)
				{
					deepHandles.Add("SvStudCompCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStudComp>) DataRepository.SvStudCompProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStudCompCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudExcuseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudExcuse>|EdStudExcuseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudExcuseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudExcuseCollection = DataRepository.EdStudExcuseProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudExcuseCollection.Count > 0)
				{
					deepHandles.Add("EdStudExcuseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudExcuse>) DataRepository.EdStudExcuseProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudExcuseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudQualCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudQual>|EdStudQualCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudQualCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudQualCollection = DataRepository.EdStudQualProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudQualCollection.Count > 0)
				{
					deepHandles.Add("EdStudQualCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudQual>) DataRepository.EdStudQualProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudQualCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region MltRptDayOutStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MltRptDayOutStud>|MltRptDayOutStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MltRptDayOutStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MltRptDayOutStudCollection = DataRepository.MltRptDayOutStudProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.MltRptDayOutStudCollection.Count > 0)
				{
					deepHandles.Add("MltRptDayOutStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MltRptDayOutStud>) DataRepository.MltRptDayOutStudProvider.DeepLoad,
						new object[] { transactionManager, entity.MltRptDayOutStudCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudRsrvRegTimeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudRsrvRegTime>|EdStudRsrvRegTimeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudRsrvRegTimeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudRsrvRegTimeCollection = DataRepository.EdStudRsrvRegTimeProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudRsrvRegTimeCollection.Count > 0)
				{
					deepHandles.Add("EdStudRsrvRegTimeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudRsrvRegTime>) DataRepository.EdStudRsrvRegTimeProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudRsrvRegTimeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppLanguagesCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppLanguages>|AdmAppLanguagesCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppLanguagesCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppLanguagesCollection = DataRepository.AdmAppLanguagesProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.AdmAppLanguagesCollection.Count > 0)
				{
					deepHandles.Add("AdmAppLanguagesCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppLanguages>) DataRepository.AdmAppLanguagesProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppLanguagesCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgStudConferenceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgStudConference>|PgStudConferenceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgStudConferenceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgStudConferenceCollection = DataRepository.PgStudConferenceProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.PgStudConferenceCollection.Count > 0)
				{
					deepHandles.Add("PgStudConferenceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgStudConference>) DataRepository.PgStudConferenceProvider.DeepLoad,
						new object[] { transactionManager, entity.PgStudConferenceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudMilitaryInfoCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudMilitaryInfo>|EdStudMilitaryInfoCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudMilitaryInfoCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudMilitaryInfoCollection = DataRepository.EdStudMilitaryInfoProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.EdStudMilitaryInfoCollection.Count > 0)
				{
					deepHandles.Add("EdStudMilitaryInfoCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudMilitaryInfo>) DataRepository.EdStudMilitaryInfoProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudMilitaryInfoCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region IntegUserAdLogDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<IntegUserAdLogDtl>|IntegUserAdLogDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'IntegUserAdLogDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.IntegUserAdLogDtlCollection = DataRepository.IntegUserAdLogDtlProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.IntegUserAdLogDtlCollection.Count > 0)
				{
					deepHandles.Add("IntegUserAdLogDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<IntegUserAdLogDtl>) DataRepository.IntegUserAdLogDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.IntegUserAdLogDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomStudAbsenceWarnCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudAbsenceWarn>|AccomStudAbsenceWarnCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudAbsenceWarnCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudAbsenceWarnCollection = DataRepository.AccomStudAbsenceWarnProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.AccomStudAbsenceWarnCollection.Count > 0)
				{
					deepHandles.Add("AccomStudAbsenceWarnCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudAbsenceWarn>) DataRepository.AccomStudAbsenceWarnProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudAbsenceWarnCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmEnglishProficiencyCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmEnglishProficiency>|AdmEnglishProficiencyCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmEnglishProficiencyCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmEnglishProficiencyCollection = DataRepository.AdmEnglishProficiencyProvider.GetByEdStudId(transactionManager, entity.EdStudId);

				if (deep && entity.AdmEnglishProficiencyCollection.Count > 0)
				{
					deepHandles.Add("AdmEnglishProficiencyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmEnglishProficiency>) DataRepository.AdmEnglishProficiencyProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmEnglishProficiencyCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStud object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStud instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStud Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStud entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region GsCdeBloodIdSource
			if (CanDeepSave(entity, "GsCdeBlood|GsCdeBloodIdSource", deepSaveType, innerList) 
				&& entity.GsCdeBloodIdSource != null)
			{
				DataRepository.GsCdeBloodProvider.Save(transactionManager, entity.GsCdeBloodIdSource);
				entity.GsCdeBloodId = entity.GsCdeBloodIdSource.GsCdeBloodId;
			}
			#endregion 
			
			#region GsCdeMaritalStatusIdSource
			if (CanDeepSave(entity, "GsCdeMaritalStatus|GsCdeMaritalStatusIdSource", deepSaveType, innerList) 
				&& entity.GsCdeMaritalStatusIdSource != null)
			{
				DataRepository.GsCdeMaritalStatusProvider.Save(transactionManager, entity.GsCdeMaritalStatusIdSource);
				entity.GsCdeMaritalStatusId = entity.GsCdeMaritalStatusIdSource.GsCdeMaritalStatusId;
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
			
			#region GsCodeLanguageIdSource
			if (CanDeepSave(entity, "GsCodeLanguage|GsCodeLanguageIdSource", deepSaveType, innerList) 
				&& entity.GsCodeLanguageIdSource != null)
			{
				DataRepository.GsCodeLanguageProvider.Save(transactionManager, entity.GsCodeLanguageIdSource);
				entity.GsCodeLanguageId = entity.GsCodeLanguageIdSource.GsCodeLanguageId;
			}
			#endregion 
			
			#region GsCodeReligionIdSource
			if (CanDeepSave(entity, "GsCodeReligion|GsCodeReligionIdSource", deepSaveType, innerList) 
				&& entity.GsCodeReligionIdSource != null)
			{
				DataRepository.GsCodeReligionProvider.Save(transactionManager, entity.GsCodeReligionIdSource);
				entity.GsCodeReligionId = entity.GsCodeReligionIdSource.GsCodeReligionId;
			}
			#endregion 
			
			#region GsCountryInfoId1Source
			if (CanDeepSave(entity, "GsCountryNode|GsCountryInfoId1Source", deepSaveType, innerList) 
				&& entity.GsCountryInfoId1Source != null)
			{
				DataRepository.GsCountryNodeProvider.Save(transactionManager, entity.GsCountryInfoId1Source);
				entity.GsCountryInfoId1 = entity.GsCountryInfoId1Source.GsCountryNodeId;
			}
			#endregion 
			
			#region GsBirthCountryNodeIdSource
			if (CanDeepSave(entity, "GsCountryNode|GsBirthCountryNodeIdSource", deepSaveType, innerList) 
				&& entity.GsBirthCountryNodeIdSource != null)
			{
				DataRepository.GsCountryNodeProvider.Save(transactionManager, entity.GsBirthCountryNodeIdSource);
				entity.GsBirthCountryNodeId = entity.GsBirthCountryNodeIdSource.GsCountryNodeId;
			}
			#endregion 
			
			#region SaStfMemberPrntIdSource
			if (CanDeepSave(entity, "SaStfMember|SaStfMemberPrntIdSource", deepSaveType, innerList) 
				&& entity.SaStfMemberPrntIdSource != null)
			{
				DataRepository.SaStfMemberProvider.Save(transactionManager, entity.SaStfMemberPrntIdSource);
				entity.SaStfMemberPrntId = entity.SaStfMemberPrntIdSource.SaStfMemberId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();

			#region FeeStudBank
			if (CanDeepSave(entity.FeeStudBank, "FeeStudBank|FeeStudBank", deepSaveType, innerList))
			{

				if (entity.FeeStudBank != null)
				{
					// update each child parent id with the real parent id (mostly used on insert)

					entity.FeeStudBank.EdStudId = entity.EdStudId;
					//DataRepository.FeeStudBankProvider.Save(transactionManager, entity.FeeStudBank);
					deepHandles.Add("FeeStudBank",
						new KeyValuePair<Delegate, object>((DeepSaveSingleHandle< FeeStudBank >) DataRepository.FeeStudBankProvider.DeepSave,
						new object[] { transactionManager, entity.FeeStudBank, deepSaveType, childTypes, innerList }
					));
				}
			} 
			#endregion 
	
			#region List<EdStudFaculty>
				if (CanDeepSave(entity.EdStudFacultyCollection, "List<EdStudFaculty>|EdStudFacultyCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudFaculty child in entity.EdStudFacultyCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
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
				
	
			#region List<EdStudTrans>
				if (CanDeepSave(entity.EdStudTransCollection, "List<EdStudTrans>|EdStudTransCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudTrans child in entity.EdStudTransCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdStudTransCollection.Count > 0 || entity.EdStudTransCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudTransProvider.Save(transactionManager, entity.EdStudTransCollection);
						
						deepHandles.Add("EdStudTransCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudTrans >) DataRepository.EdStudTransProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudTransCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvStudAskAdvRe>
				if (CanDeepSave(entity.SvStudAskAdvReCollection, "List<SvStudAskAdvRe>|SvStudAskAdvReCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStudAskAdvRe child in entity.SvStudAskAdvReCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.SvStudAskAdvReCollection.Count > 0 || entity.SvStudAskAdvReCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStudAskAdvReProvider.Save(transactionManager, entity.SvStudAskAdvReCollection);
						
						deepHandles.Add("SvStudAskAdvReCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStudAskAdvRe >) DataRepository.SvStudAskAdvReProvider.DeepSave,
							new object[] { transactionManager, entity.SvStudAskAdvReCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomStudResponsible>
				if (CanDeepSave(entity.AccomStudResponsibleCollection, "List<AccomStudResponsible>|AccomStudResponsibleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudResponsible child in entity.AccomStudResponsibleCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.AccomStudResponsibleCollection.Count > 0 || entity.AccomStudResponsibleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudResponsibleProvider.Save(transactionManager, entity.AccomStudResponsibleCollection);
						
						deepHandles.Add("AccomStudResponsibleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudResponsible >) DataRepository.AccomStudResponsibleProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudResponsibleCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseRegPre>
				if (CanDeepSave(entity.EdStudCourseRegPreCollection, "List<EdStudCourseRegPre>|EdStudCourseRegPreCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseRegPre child in entity.EdStudCourseRegPreCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdStudCourseRegPreCollection.Count > 0 || entity.EdStudCourseRegPreCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegPreProvider.Save(transactionManager, entity.EdStudCourseRegPreCollection);
						
						deepHandles.Add("EdStudCourseRegPreCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseRegPre >) DataRepository.EdStudCourseRegPreProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegPreCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvStudStaffEvalExt>
				if (CanDeepSave(entity.SvStudStaffEvalExtCollection, "List<SvStudStaffEvalExt>|SvStudStaffEvalExtCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStudStaffEvalExt child in entity.SvStudStaffEvalExtCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.SvStudStaffEvalExtCollection.Count > 0 || entity.SvStudStaffEvalExtCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStudStaffEvalExtProvider.Save(transactionManager, entity.SvStudStaffEvalExtCollection);
						
						deepHandles.Add("SvStudStaffEvalExtCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStudStaffEvalExt >) DataRepository.SvStudStaffEvalExtProvider.DeepSave,
							new object[] { transactionManager, entity.SvStudStaffEvalExtCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudSemesterTemp>
				if (CanDeepSave(entity.EdStudSemesterTempCollection, "List<EdStudSemesterTemp>|EdStudSemesterTempCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudSemesterTemp child in entity.EdStudSemesterTempCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdStudSemesterTempCollection.Count > 0 || entity.EdStudSemesterTempCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudSemesterTempProvider.Save(transactionManager, entity.EdStudSemesterTempCollection);
						
						deepHandles.Add("EdStudSemesterTempCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudSemesterTemp >) DataRepository.EdStudSemesterTempProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudSemesterTempCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<MdiStudProblem>
				if (CanDeepSave(entity.MdiStudProblemCollection, "List<MdiStudProblem>|MdiStudProblemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MdiStudProblem child in entity.MdiStudProblemCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.MdiStudProblemCollection.Count > 0 || entity.MdiStudProblemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MdiStudProblemProvider.Save(transactionManager, entity.MdiStudProblemCollection);
						
						deepHandles.Add("MdiStudProblemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MdiStudProblem >) DataRepository.MdiStudProblemProvider.DeepSave,
							new object[] { transactionManager, entity.MdiStudProblemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudInstallment>
				if (CanDeepSave(entity.FeeStudInstallmentCollection, "List<FeeStudInstallment>|FeeStudInstallmentCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudInstallment child in entity.FeeStudInstallmentCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.FeeStudInstallmentCollection.Count > 0 || entity.FeeStudInstallmentCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudInstallmentProvider.Save(transactionManager, entity.FeeStudInstallmentCollection);
						
						deepHandles.Add("FeeStudInstallmentCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudInstallment >) DataRepository.FeeStudInstallmentProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudInstallmentCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScStudGroup>
				if (CanDeepSave(entity.ScStudGroupCollection, "List<ScStudGroup>|ScStudGroupCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScStudGroup child in entity.ScStudGroupCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.ScStudGroupCollection.Count > 0 || entity.ScStudGroupCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScStudGroupProvider.Save(transactionManager, entity.ScStudGroupCollection);
						
						deepHandles.Add("ScStudGroupCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScStudGroup >) DataRepository.ScStudGroupProvider.DeepSave,
							new object[] { transactionManager, entity.ScStudGroupCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudMltryCrs>
				if (CanDeepSave(entity.EdStudMltryCrsCollection, "List<EdStudMltryCrs>|EdStudMltryCrsCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudMltryCrs child in entity.EdStudMltryCrsCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdStudMltryCrsCollection.Count > 0 || entity.EdStudMltryCrsCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudMltryCrsProvider.Save(transactionManager, entity.EdStudMltryCrsCollection);
						
						deepHandles.Add("EdStudMltryCrsCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudMltryCrs >) DataRepository.EdStudMltryCrsProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudMltryCrsCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<RsrchStudRegister>
				if (CanDeepSave(entity.RsrchStudRegisterCollection, "List<RsrchStudRegister>|RsrchStudRegisterCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(RsrchStudRegister child in entity.RsrchStudRegisterCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.RsrchStudRegisterCollection.Count > 0 || entity.RsrchStudRegisterCollection.DeletedItems.Count > 0)
					{
						//DataRepository.RsrchStudRegisterProvider.Save(transactionManager, entity.RsrchStudRegisterCollection);
						
						deepHandles.Add("RsrchStudRegisterCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< RsrchStudRegister >) DataRepository.RsrchStudRegisterProvider.DeepSave,
							new object[] { transactionManager, entity.RsrchStudRegisterCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdTrainStud>
				if (CanDeepSave(entity.EdTrainStudCollection, "List<EdTrainStud>|EdTrainStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdTrainStud child in entity.EdTrainStudCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdTrainStudCollection.Count > 0 || entity.EdTrainStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdTrainStudProvider.Save(transactionManager, entity.EdTrainStudCollection);
						
						deepHandles.Add("EdTrainStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdTrainStud >) DataRepository.EdTrainStudProvider.DeepSave,
							new object[] { transactionManager, entity.EdTrainStudCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudMilitaryState>
				if (CanDeepSave(entity.EdStudMilitaryStateCollection, "List<EdStudMilitaryState>|EdStudMilitaryStateCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudMilitaryState child in entity.EdStudMilitaryStateCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdStudMilitaryStateCollection.Count > 0 || entity.EdStudMilitaryStateCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudMilitaryStateProvider.Save(transactionManager, entity.EdStudMilitaryStateCollection);
						
						deepHandles.Add("EdStudMilitaryStateCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudMilitaryState >) DataRepository.EdStudMilitaryStateProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudMilitaryStateCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudGraduationAward>
				if (CanDeepSave(entity.EdStudGraduationAwardCollection, "List<EdStudGraduationAward>|EdStudGraduationAwardCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudGraduationAward child in entity.EdStudGraduationAwardCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdStudGraduationAwardCollection.Count > 0 || entity.EdStudGraduationAwardCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudGraduationAwardProvider.Save(transactionManager, entity.EdStudGraduationAwardCollection);
						
						deepHandles.Add("EdStudGraduationAwardCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudGraduationAward >) DataRepository.EdStudGraduationAwardProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudGraduationAwardCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudGuard>
				if (CanDeepSave(entity.EdStudGuardCollection, "List<EdStudGuard>|EdStudGuardCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudGuard child in entity.EdStudGuardCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdStudGuardCollection.Count > 0 || entity.EdStudGuardCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudGuardProvider.Save(transactionManager, entity.EdStudGuardCollection);
						
						deepHandles.Add("EdStudGuardCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudGuard >) DataRepository.EdStudGuardProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudGuardCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudTransFromReq>
				if (CanDeepSave(entity.EdStudTransFromReqCollection, "List<EdStudTransFromReq>|EdStudTransFromReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudTransFromReq child in entity.EdStudTransFromReqCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdStudTransFromReqCollection.Count > 0 || entity.EdStudTransFromReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudTransFromReqProvider.Save(transactionManager, entity.EdStudTransFromReqCollection);
						
						deepHandles.Add("EdStudTransFromReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudTransFromReq >) DataRepository.EdStudTransFromReqProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudTransFromReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvStudStaffEval>
				if (CanDeepSave(entity.SvStudStaffEvalCollection, "List<SvStudStaffEval>|SvStudStaffEvalCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStudStaffEval child in entity.SvStudStaffEvalCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.SvStudStaffEvalCollection.Count > 0 || entity.SvStudStaffEvalCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStudStaffEvalProvider.Save(transactionManager, entity.SvStudStaffEvalCollection);
						
						deepHandles.Add("SvStudStaffEvalCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStudStaffEval >) DataRepository.SvStudStaffEvalProvider.DeepSave,
							new object[] { transactionManager, entity.SvStudStaffEvalCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudIntTrnsStateFrom>
				if (CanDeepSave(entity.EdStudIntTrnsStateFromCollection, "List<EdStudIntTrnsStateFrom>|EdStudIntTrnsStateFromCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrnsStateFrom child in entity.EdStudIntTrnsStateFromCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdStudIntTrnsStateFromCollection.Count > 0 || entity.EdStudIntTrnsStateFromCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsStateFromProvider.Save(transactionManager, entity.EdStudIntTrnsStateFromCollection);
						
						deepHandles.Add("EdStudIntTrnsStateFromCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrnsStateFrom >) DataRepository.EdStudIntTrnsStateFromProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsStateFromCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudAcadWarn>
				if (CanDeepSave(entity.EdStudAcadWarnCollection, "List<EdStudAcadWarn>|EdStudAcadWarnCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudAcadWarn child in entity.EdStudAcadWarnCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdStudAcadWarnCollection.Count > 0 || entity.EdStudAcadWarnCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudAcadWarnProvider.Save(transactionManager, entity.EdStudAcadWarnCollection);
						
						deepHandles.Add("EdStudAcadWarnCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudAcadWarn >) DataRepository.EdStudAcadWarnProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudAcadWarnCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<MdiStudHosptl>
				if (CanDeepSave(entity.MdiStudHosptlCollection, "List<MdiStudHosptl>|MdiStudHosptlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MdiStudHosptl child in entity.MdiStudHosptlCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.MdiStudHosptlCollection.Count > 0 || entity.MdiStudHosptlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MdiStudHosptlProvider.Save(transactionManager, entity.MdiStudHosptlCollection);
						
						deepHandles.Add("MdiStudHosptlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MdiStudHosptl >) DataRepository.MdiStudHosptlProvider.DeepSave,
							new object[] { transactionManager, entity.MdiStudHosptlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudLang>
				if (CanDeepSave(entity.EdStudLangCollection, "List<EdStudLang>|EdStudLangCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudLang child in entity.EdStudLangCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdStudLangCollection.Count > 0 || entity.EdStudLangCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudLangProvider.Save(transactionManager, entity.EdStudLangCollection);
						
						deepHandles.Add("EdStudLangCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudLang >) DataRepository.EdStudLangProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudLangCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<MdiStudRecord>
				if (CanDeepSave(entity.MdiStudRecordCollection, "List<MdiStudRecord>|MdiStudRecordCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MdiStudRecord child in entity.MdiStudRecordCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.MdiStudRecordCollection.Count > 0 || entity.MdiStudRecordCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MdiStudRecordProvider.Save(transactionManager, entity.MdiStudRecordCollection);
						
						deepHandles.Add("MdiStudRecordCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MdiStudRecord >) DataRepository.MdiStudRecordProvider.DeepSave,
							new object[] { transactionManager, entity.MdiStudRecordCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudLateness>
				if (CanDeepSave(entity.EdStudLatenessCollection, "List<EdStudLateness>|EdStudLatenessCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudLateness child in entity.EdStudLatenessCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdStudLatenessCollection.Count > 0 || entity.EdStudLatenessCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudLatenessProvider.Save(transactionManager, entity.EdStudLatenessCollection);
						
						deepHandles.Add("EdStudLatenessCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudLateness >) DataRepository.EdStudLatenessProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudLatenessCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudItemCncl>
				if (CanDeepSave(entity.FeeStudItemCnclCollection, "List<FeeStudItemCncl>|FeeStudItemCnclCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudItemCncl child in entity.FeeStudItemCnclCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.FeeStudItemCnclCollection.Count > 0 || entity.FeeStudItemCnclCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudItemCnclProvider.Save(transactionManager, entity.FeeStudItemCnclCollection);
						
						deepHandles.Add("FeeStudItemCnclCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudItemCncl >) DataRepository.FeeStudItemCnclProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudItemCnclCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudActivity>
				if (CanDeepSave(entity.EdStudActivityCollection, "List<EdStudActivity>|EdStudActivityCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudActivity child in entity.EdStudActivityCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdStudActivityCollection.Count > 0 || entity.EdStudActivityCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudActivityProvider.Save(transactionManager, entity.EdStudActivityCollection);
						
						deepHandles.Add("EdStudActivityCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudActivity >) DataRepository.EdStudActivityProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudActivityCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudPayPostpone>
				if (CanDeepSave(entity.FeeStudPayPostponeCollection, "List<FeeStudPayPostpone>|FeeStudPayPostponeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudPayPostpone child in entity.FeeStudPayPostponeCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.FeeStudPayPostponeCollection.Count > 0 || entity.FeeStudPayPostponeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudPayPostponeProvider.Save(transactionManager, entity.FeeStudPayPostponeCollection);
						
						deepHandles.Add("FeeStudPayPostponeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudPayPostpone >) DataRepository.FeeStudPayPostponeProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudPayPostponeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudRsdncy>
				if (CanDeepSave(entity.EdStudRsdncyCollection, "List<EdStudRsdncy>|EdStudRsdncyCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudRsdncy child in entity.EdStudRsdncyCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdStudRsdncyCollection.Count > 0 || entity.EdStudRsdncyCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudRsdncyProvider.Save(transactionManager, entity.EdStudRsdncyCollection);
						
						deepHandles.Add("EdStudRsdncyCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudRsdncy >) DataRepository.EdStudRsdncyProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudRsdncyCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<MltStudInfo>
				if (CanDeepSave(entity.MltStudInfoCollection, "List<MltStudInfo>|MltStudInfoCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MltStudInfo child in entity.MltStudInfoCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.MltStudInfoCollection.Count > 0 || entity.MltStudInfoCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MltStudInfoProvider.Save(transactionManager, entity.MltStudInfoCollection);
						
						deepHandles.Add("MltStudInfoCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MltStudInfo >) DataRepository.MltStudInfoProvider.DeepSave,
							new object[] { transactionManager, entity.MltStudInfoCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvStudLockerReq>
				if (CanDeepSave(entity.SvStudLockerReqCollection, "List<SvStudLockerReq>|SvStudLockerReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStudLockerReq child in entity.SvStudLockerReqCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.SvStudLockerReqCollection.Count > 0 || entity.SvStudLockerReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStudLockerReqProvider.Save(transactionManager, entity.SvStudLockerReqCollection);
						
						deepHandles.Add("SvStudLockerReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStudLockerReq >) DataRepository.SvStudLockerReqProvider.DeepSave,
							new object[] { transactionManager, entity.SvStudLockerReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudMission>
				if (CanDeepSave(entity.EdStudMissionCollection, "List<EdStudMission>|EdStudMissionCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudMission child in entity.EdStudMissionCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdStudMissionCollection.Count > 0 || entity.EdStudMissionCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudMissionProvider.Save(transactionManager, entity.EdStudMissionCollection);
						
						deepHandles.Add("EdStudMissionCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudMission >) DataRepository.EdStudMissionProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudMissionCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppWorkExper>
				if (CanDeepSave(entity.AdmAppWorkExperCollection, "List<AdmAppWorkExper>|AdmAppWorkExperCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppWorkExper child in entity.AdmAppWorkExperCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.AdmAppWorkExperCollection.Count > 0 || entity.AdmAppWorkExperCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppWorkExperProvider.Save(transactionManager, entity.AdmAppWorkExperCollection);
						
						deepHandles.Add("AdmAppWorkExperCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppWorkExper >) DataRepository.AdmAppWorkExperProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppWorkExperCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudNote>
				if (CanDeepSave(entity.EdStudNoteCollection, "List<EdStudNote>|EdStudNoteCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudNote child in entity.EdStudNoteCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdStudNoteCollection.Count > 0 || entity.EdStudNoteCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudNoteProvider.Save(transactionManager, entity.EdStudNoteCollection);
						
						deepHandles.Add("EdStudNoteCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudNote >) DataRepository.EdStudNoteProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudNoteCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudAcadmicAdv>
				if (CanDeepSave(entity.EdStudAcadmicAdvCollection, "List<EdStudAcadmicAdv>|EdStudAcadmicAdvCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudAcadmicAdv child in entity.EdStudAcadmicAdvCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdStudAcadmicAdvCollection.Count > 0 || entity.EdStudAcadmicAdvCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudAcadmicAdvProvider.Save(transactionManager, entity.EdStudAcadmicAdvCollection);
						
						deepHandles.Add("EdStudAcadmicAdvCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudAcadmicAdv >) DataRepository.EdStudAcadmicAdvProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudAcadmicAdvCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CtrSrvcCrew>
				if (CanDeepSave(entity.CtrSrvcCrewCollection, "List<CtrSrvcCrew>|CtrSrvcCrewCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CtrSrvcCrew child in entity.CtrSrvcCrewCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.CtrSrvcCrewCollection.Count > 0 || entity.CtrSrvcCrewCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CtrSrvcCrewProvider.Save(transactionManager, entity.CtrSrvcCrewCollection);
						
						deepHandles.Add("CtrSrvcCrewCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CtrSrvcCrew >) DataRepository.CtrSrvcCrewProvider.DeepSave,
							new object[] { transactionManager, entity.CtrSrvcCrewCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeBlockTrans>
				if (CanDeepSave(entity.SeBlockTransCollection, "List<SeBlockTrans>|SeBlockTransCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeBlockTrans child in entity.SeBlockTransCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.SeBlockTransCollection.Count > 0 || entity.SeBlockTransCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeBlockTransProvider.Save(transactionManager, entity.SeBlockTransCollection);
						
						deepHandles.Add("SeBlockTransCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeBlockTrans >) DataRepository.SeBlockTransProvider.DeepSave,
							new object[] { transactionManager, entity.SeBlockTransCollection, deepSaveType, childTypes, innerList }
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
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
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
				
	
			#region List<AlmJob>
				if (CanDeepSave(entity.AlmJobCollection, "List<AlmJob>|AlmJobCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AlmJob child in entity.AlmJobCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.AlmJobCollection.Count > 0 || entity.AlmJobCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AlmJobProvider.Save(transactionManager, entity.AlmJobCollection);
						
						deepHandles.Add("AlmJobCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AlmJob >) DataRepository.AlmJobProvider.DeepSave,
							new object[] { transactionManager, entity.AlmJobCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudVoucher>
				if (CanDeepSave(entity.FeeStudVoucherCollection, "List<FeeStudVoucher>|FeeStudVoucherCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudVoucher child in entity.FeeStudVoucherCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.FeeStudVoucherCollection.Count > 0 || entity.FeeStudVoucherCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudVoucherProvider.Save(transactionManager, entity.FeeStudVoucherCollection);
						
						deepHandles.Add("FeeStudVoucherCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudVoucher >) DataRepository.FeeStudVoucherProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudVoucherCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SpoSponsorStudSemester>
				if (CanDeepSave(entity.SpoSponsorStudSemesterCollection, "List<SpoSponsorStudSemester>|SpoSponsorStudSemesterCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoSponsorStudSemester child in entity.SpoSponsorStudSemesterCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
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
				
	
			#region List<FeeStudFund>
				if (CanDeepSave(entity.FeeStudFundCollection, "List<FeeStudFund>|FeeStudFundCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudFund child in entity.FeeStudFundCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.FeeStudFundCollection.Count > 0 || entity.FeeStudFundCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudFundProvider.Save(transactionManager, entity.FeeStudFundCollection);
						
						deepHandles.Add("FeeStudFundCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudFund >) DataRepository.FeeStudFundProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudFundCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgStudTravel>
				if (CanDeepSave(entity.PgStudTravelCollection, "List<PgStudTravel>|PgStudTravelCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgStudTravel child in entity.PgStudTravelCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.PgStudTravelCollection.Count > 0 || entity.PgStudTravelCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgStudTravelProvider.Save(transactionManager, entity.PgStudTravelCollection);
						
						deepHandles.Add("PgStudTravelCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgStudTravel >) DataRepository.PgStudTravelProvider.DeepSave,
							new object[] { transactionManager, entity.PgStudTravelCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CtrStudOut>
				if (CanDeepSave(entity.CtrStudOutCollection, "List<CtrStudOut>|CtrStudOutCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CtrStudOut child in entity.CtrStudOutCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.CtrStudOutCollection.Count > 0 || entity.CtrStudOutCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CtrStudOutProvider.Save(transactionManager, entity.CtrStudOutCollection);
						
						deepHandles.Add("CtrStudOutCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CtrStudOut >) DataRepository.CtrStudOutProvider.DeepSave,
							new object[] { transactionManager, entity.CtrStudOutCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudDisc>
				if (CanDeepSave(entity.FeeStudDiscCollection, "List<FeeStudDisc>|FeeStudDiscCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudDisc child in entity.FeeStudDiscCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.FeeStudDiscCollection.Count > 0 || entity.FeeStudDiscCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudDiscProvider.Save(transactionManager, entity.FeeStudDiscCollection);
						
						deepHandles.Add("FeeStudDiscCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudDisc >) DataRepository.FeeStudDiscProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudDiscCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudSport>
				if (CanDeepSave(entity.EdStudSportCollection, "List<EdStudSport>|EdStudSportCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudSport child in entity.EdStudSportCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdStudSportCollection.Count > 0 || entity.EdStudSportCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudSportProvider.Save(transactionManager, entity.EdStudSportCollection);
						
						deepHandles.Add("EdStudSportCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudSport >) DataRepository.EdStudSportProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudSportCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<MdiStudVacc>
				if (CanDeepSave(entity.MdiStudVaccCollection, "List<MdiStudVacc>|MdiStudVaccCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MdiStudVacc child in entity.MdiStudVaccCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.MdiStudVaccCollection.Count > 0 || entity.MdiStudVaccCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MdiStudVaccProvider.Save(transactionManager, entity.MdiStudVaccCollection);
						
						deepHandles.Add("MdiStudVaccCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MdiStudVacc >) DataRepository.MdiStudVaccProvider.DeepSave,
							new object[] { transactionManager, entity.MdiStudVaccCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CtrStudExp>
				if (CanDeepSave(entity.CtrStudExpCollection, "List<CtrStudExp>|CtrStudExpCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CtrStudExp child in entity.CtrStudExpCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.CtrStudExpCollection.Count > 0 || entity.CtrStudExpCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CtrStudExpProvider.Save(transactionManager, entity.CtrStudExpCollection);
						
						deepHandles.Add("CtrStudExpCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CtrStudExp >) DataRepository.CtrStudExpProvider.DeepSave,
							new object[] { transactionManager, entity.CtrStudExpCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<MdiStudClnq>
				if (CanDeepSave(entity.MdiStudClnqCollection, "List<MdiStudClnq>|MdiStudClnqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MdiStudClnq child in entity.MdiStudClnqCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.MdiStudClnqCollection.Count > 0 || entity.MdiStudClnqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MdiStudClnqProvider.Save(transactionManager, entity.MdiStudClnqCollection);
						
						deepHandles.Add("MdiStudClnqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MdiStudClnq >) DataRepository.MdiStudClnqProvider.DeepSave,
							new object[] { transactionManager, entity.MdiStudClnqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisStud>
				if (CanDeepSave(entity.PgThesisStudCollection, "List<PgThesisStud>|PgThesisStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisStud child in entity.PgThesisStudCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.PgThesisStudCollection.Count > 0 || entity.PgThesisStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisStudProvider.Save(transactionManager, entity.PgThesisStudCollection);
						
						deepHandles.Add("PgThesisStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisStud >) DataRepository.PgThesisStudProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisStudCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudRetrieveRequest>
				if (CanDeepSave(entity.FeeStudRetrieveRequestCollection, "List<FeeStudRetrieveRequest>|FeeStudRetrieveRequestCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudRetrieveRequest child in entity.FeeStudRetrieveRequestCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.FeeStudRetrieveRequestCollection.Count > 0 || entity.FeeStudRetrieveRequestCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudRetrieveRequestProvider.Save(transactionManager, entity.FeeStudRetrieveRequestCollection);
						
						deepHandles.Add("FeeStudRetrieveRequestCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudRetrieveRequest >) DataRepository.FeeStudRetrieveRequestProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudRetrieveRequestCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudViol>
				if (CanDeepSave(entity.EdStudViolCollection, "List<EdStudViol>|EdStudViolCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudViol child in entity.EdStudViolCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdStudViolCollection.Count > 0 || entity.EdStudViolCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudViolProvider.Save(transactionManager, entity.EdStudViolCollection);
						
						deepHandles.Add("EdStudViolCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudViol >) DataRepository.EdStudViolProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudViolCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmApplicant>
				if (CanDeepSave(entity.AdmApplicantCollection, "List<AdmApplicant>|AdmApplicantCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmApplicant child in entity.AdmApplicantCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.AdmApplicantCollection.Count > 0 || entity.AdmApplicantCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmApplicantProvider.Save(transactionManager, entity.AdmApplicantCollection);
						
						deepHandles.Add("AdmApplicantCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmApplicant >) DataRepository.AdmApplicantProvider.DeepSave,
							new object[] { transactionManager, entity.AdmApplicantCollection, deepSaveType, childTypes, innerList }
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
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
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
				
	
			#region List<AccomStudAbsence>
				if (CanDeepSave(entity.AccomStudAbsenceCollection, "List<AccomStudAbsence>|AccomStudAbsenceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudAbsence child in entity.AccomStudAbsenceCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.AccomStudAbsenceCollection.Count > 0 || entity.AccomStudAbsenceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudAbsenceProvider.Save(transactionManager, entity.AccomStudAbsenceCollection);
						
						deepHandles.Add("AccomStudAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudAbsence >) DataRepository.AccomStudAbsenceProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudAbsenceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeItemTrnsBlnc>
				if (CanDeepSave(entity.FeeItemTrnsBlncCollection, "List<FeeItemTrnsBlnc>|FeeItemTrnsBlncCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeItemTrnsBlnc child in entity.FeeItemTrnsBlncCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.FeeItemTrnsBlncCollection.Count > 0 || entity.FeeItemTrnsBlncCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeItemTrnsBlncProvider.Save(transactionManager, entity.FeeItemTrnsBlncCollection);
						
						deepHandles.Add("FeeItemTrnsBlncCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeItemTrnsBlnc >) DataRepository.FeeItemTrnsBlncProvider.DeepSave,
							new object[] { transactionManager, entity.FeeItemTrnsBlncCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmScholorship>
				if (CanDeepSave(entity.AdmScholorshipCollection, "List<AdmScholorship>|AdmScholorshipCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmScholorship child in entity.AdmScholorshipCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.AdmScholorshipCollection.Count > 0 || entity.AdmScholorshipCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmScholorshipProvider.Save(transactionManager, entity.AdmScholorshipCollection);
						
						deepHandles.Add("AdmScholorshipCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmScholorship >) DataRepository.AdmScholorshipProvider.DeepSave,
							new object[] { transactionManager, entity.AdmScholorshipCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudInstallmentRequest>
				if (CanDeepSave(entity.FeeStudInstallmentRequestCollection, "List<FeeStudInstallmentRequest>|FeeStudInstallmentRequestCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudInstallmentRequest child in entity.FeeStudInstallmentRequestCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.FeeStudInstallmentRequestCollection.Count > 0 || entity.FeeStudInstallmentRequestCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudInstallmentRequestProvider.Save(transactionManager, entity.FeeStudInstallmentRequestCollection);
						
						deepHandles.Add("FeeStudInstallmentRequestCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudInstallmentRequest >) DataRepository.FeeStudInstallmentRequestProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudInstallmentRequestCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudGrantTemp>
				if (CanDeepSave(entity.EdStudGrantTempCollection, "List<EdStudGrantTemp>|EdStudGrantTempCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudGrantTemp child in entity.EdStudGrantTempCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdStudGrantTempCollection.Count > 0 || entity.EdStudGrantTempCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudGrantTempProvider.Save(transactionManager, entity.EdStudGrantTempCollection);
						
						deepHandles.Add("EdStudGrantTempCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudGrantTemp >) DataRepository.EdStudGrantTempProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudGrantTempCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudAllowance>
				if (CanDeepSave(entity.FeeStudAllowanceCollection, "List<FeeStudAllowance>|FeeStudAllowanceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudAllowance child in entity.FeeStudAllowanceCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.FeeStudAllowanceCollection.Count > 0 || entity.FeeStudAllowanceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudAllowanceProvider.Save(transactionManager, entity.FeeStudAllowanceCollection);
						
						deepHandles.Add("FeeStudAllowanceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudAllowance >) DataRepository.FeeStudAllowanceProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudAllowanceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeInvoice>
				if (CanDeepSave(entity.FeeInvoiceCollection, "List<FeeInvoice>|FeeInvoiceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeInvoice child in entity.FeeInvoiceCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.FeeInvoiceCollection.Count > 0 || entity.FeeInvoiceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeInvoiceProvider.Save(transactionManager, entity.FeeInvoiceCollection);
						
						deepHandles.Add("FeeInvoiceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeInvoice >) DataRepository.FeeInvoiceProvider.DeepSave,
							new object[] { transactionManager, entity.FeeInvoiceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudProblem>
				if (CanDeepSave(entity.EdStudProblemCollection, "List<EdStudProblem>|EdStudProblemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudProblem child in entity.EdStudProblemCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdStudProblemCollection.Count > 0 || entity.EdStudProblemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudProblemProvider.Save(transactionManager, entity.EdStudProblemCollection);
						
						deepHandles.Add("EdStudProblemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudProblem >) DataRepository.EdStudProblemProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudProblemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AlmPrintRequest>
				if (CanDeepSave(entity.AlmPrintRequestCollection, "List<AlmPrintRequest>|AlmPrintRequestCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AlmPrintRequest child in entity.AlmPrintRequestCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.AlmPrintRequestCollection.Count > 0 || entity.AlmPrintRequestCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AlmPrintRequestProvider.Save(transactionManager, entity.AlmPrintRequestCollection);
						
						deepHandles.Add("AlmPrintRequestCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AlmPrintRequest >) DataRepository.AlmPrintRequestProvider.DeepSave,
							new object[] { transactionManager, entity.AlmPrintRequestCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeInstlmntStud>
				if (CanDeepSave(entity.FeeInstlmntStudCollection, "List<FeeInstlmntStud>|FeeInstlmntStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeInstlmntStud child in entity.FeeInstlmntStudCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.FeeInstlmntStudCollection.Count > 0 || entity.FeeInstlmntStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeInstlmntStudProvider.Save(transactionManager, entity.FeeInstlmntStudCollection);
						
						deepHandles.Add("FeeInstlmntStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeInstlmntStud >) DataRepository.FeeInstlmntStudProvider.DeepSave,
							new object[] { transactionManager, entity.FeeInstlmntStudCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCodeChng>
				if (CanDeepSave(entity.EdStudCodeChngCollection, "List<EdStudCodeChng>|EdStudCodeChngCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCodeChng child in entity.EdStudCodeChngCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdStudCodeChngCollection.Count > 0 || entity.EdStudCodeChngCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCodeChngProvider.Save(transactionManager, entity.EdStudCodeChngCollection);
						
						deepHandles.Add("EdStudCodeChngCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCodeChng >) DataRepository.EdStudCodeChngProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCodeChngCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudGrantDegree>
				if (CanDeepSave(entity.EdStudGrantDegreeCollection, "List<EdStudGrantDegree>|EdStudGrantDegreeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudGrantDegree child in entity.EdStudGrantDegreeCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdStudGrantDegreeCollection.Count > 0 || entity.EdStudGrantDegreeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudGrantDegreeProvider.Save(transactionManager, entity.EdStudGrantDegreeCollection);
						
						deepHandles.Add("EdStudGrantDegreeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudGrantDegree >) DataRepository.EdStudGrantDegreeProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudGrantDegreeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdProjStud>
				if (CanDeepSave(entity.EdProjStudCollection, "List<EdProjStud>|EdProjStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdProjStud child in entity.EdProjStudCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdProjStudCollection.Count > 0 || entity.EdProjStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdProjStudProvider.Save(transactionManager, entity.EdProjStudCollection);
						
						deepHandles.Add("EdProjStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdProjStud >) DataRepository.EdProjStudProvider.DeepSave,
							new object[] { transactionManager, entity.EdProjStudCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudExmptReq>
				if (CanDeepSave(entity.EdStudExmptReqCollection, "List<EdStudExmptReq>|EdStudExmptReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudExmptReq child in entity.EdStudExmptReqCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdStudExmptReqCollection.Count > 0 || entity.EdStudExmptReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudExmptReqProvider.Save(transactionManager, entity.EdStudExmptReqCollection);
						
						deepHandles.Add("EdStudExmptReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudExmptReq >) DataRepository.EdStudExmptReqProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudExmptReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppDoc>
				if (CanDeepSave(entity.AdmAppDocCollection, "List<AdmAppDoc>|AdmAppDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppDoc child in entity.AdmAppDocCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.AdmAppDocCollection.Count > 0 || entity.AdmAppDocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppDocProvider.Save(transactionManager, entity.AdmAppDocCollection);
						
						deepHandles.Add("AdmAppDocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppDoc >) DataRepository.AdmAppDocProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppDocCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<RsrchStudPostponeReq>
				if (CanDeepSave(entity.RsrchStudPostponeReqCollection, "List<RsrchStudPostponeReq>|RsrchStudPostponeReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(RsrchStudPostponeReq child in entity.RsrchStudPostponeReqCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.RsrchStudPostponeReqCollection.Count > 0 || entity.RsrchStudPostponeReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.RsrchStudPostponeReqProvider.Save(transactionManager, entity.RsrchStudPostponeReqCollection);
						
						deepHandles.Add("RsrchStudPostponeReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< RsrchStudPostponeReq >) DataRepository.RsrchStudPostponeReqProvider.DeepSave,
							new object[] { transactionManager, entity.RsrchStudPostponeReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<TrnsStudCarStkr>
				if (CanDeepSave(entity.TrnsStudCarStkrCollection, "List<TrnsStudCarStkr>|TrnsStudCarStkrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(TrnsStudCarStkr child in entity.TrnsStudCarStkrCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.TrnsStudCarStkrCollection.Count > 0 || entity.TrnsStudCarStkrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.TrnsStudCarStkrProvider.Save(transactionManager, entity.TrnsStudCarStkrCollection);
						
						deepHandles.Add("TrnsStudCarStkrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< TrnsStudCarStkr >) DataRepository.TrnsStudCarStkrProvider.DeepSave,
							new object[] { transactionManager, entity.TrnsStudCarStkrCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisNote>
				if (CanDeepSave(entity.PgThesisNoteCollection, "List<PgThesisNote>|PgThesisNoteCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisNote child in entity.PgThesisNoteCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.PgThesisNoteCollection.Count > 0 || entity.PgThesisNoteCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisNoteProvider.Save(transactionManager, entity.PgThesisNoteCollection);
						
						deepHandles.Add("PgThesisNoteCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisNote >) DataRepository.PgThesisNoteProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisNoteCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudNatSimilarityRequest>
				if (CanDeepSave(entity.FeeStudNatSimilarityRequestCollection, "List<FeeStudNatSimilarityRequest>|FeeStudNatSimilarityRequestCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudNatSimilarityRequest child in entity.FeeStudNatSimilarityRequestCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.FeeStudNatSimilarityRequestCollection.Count > 0 || entity.FeeStudNatSimilarityRequestCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudNatSimilarityRequestProvider.Save(transactionManager, entity.FeeStudNatSimilarityRequestCollection);
						
						deepHandles.Add("FeeStudNatSimilarityRequestCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudNatSimilarityRequest >) DataRepository.FeeStudNatSimilarityRequestProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudNatSimilarityRequestCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudSemester>
				if (CanDeepSave(entity.EdStudSemesterCollection, "List<EdStudSemester>|EdStudSemesterCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudSemester child in entity.EdStudSemesterCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdStudSemesterCollection.Count > 0 || entity.EdStudSemesterCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudSemesterProvider.Save(transactionManager, entity.EdStudSemesterCollection);
						
						deepHandles.Add("EdStudSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudSemester >) DataRepository.EdStudSemesterProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudSemesterCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvSrvyRespondQstn>
				if (CanDeepSave(entity.SvSrvyRespondQstnCollection, "List<SvSrvyRespondQstn>|SvSrvyRespondQstnCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvSrvyRespondQstn child in entity.SvSrvyRespondQstnCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.SvSrvyRespondQstnCollection.Count > 0 || entity.SvSrvyRespondQstnCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvSrvyRespondQstnProvider.Save(transactionManager, entity.SvSrvyRespondQstnCollection);
						
						deepHandles.Add("SvSrvyRespondQstnCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvSrvyRespondQstn >) DataRepository.SvSrvyRespondQstnProvider.DeepSave,
							new object[] { transactionManager, entity.SvSrvyRespondQstnCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudExecuseReq>
				if (CanDeepSave(entity.EdStudExecuseReqCollection, "List<EdStudExecuseReq>|EdStudExecuseReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudExecuseReq child in entity.EdStudExecuseReqCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdStudExecuseReqCollection.Count > 0 || entity.EdStudExecuseReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudExecuseReqProvider.Save(transactionManager, entity.EdStudExecuseReqCollection);
						
						deepHandles.Add("EdStudExecuseReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudExecuseReq >) DataRepository.EdStudExecuseReqProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudExecuseReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeRefndStdReq>
				if (CanDeepSave(entity.FeeRefndStdReqCollection, "List<FeeRefndStdReq>|FeeRefndStdReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeRefndStdReq child in entity.FeeRefndStdReqCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.FeeRefndStdReqCollection.Count > 0 || entity.FeeRefndStdReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeRefndStdReqProvider.Save(transactionManager, entity.FeeRefndStdReqCollection);
						
						deepHandles.Add("FeeRefndStdReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeRefndStdReq >) DataRepository.FeeRefndStdReqProvider.DeepSave,
							new object[] { transactionManager, entity.FeeRefndStdReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvStudPoll>
				if (CanDeepSave(entity.SvStudPollCollection, "List<SvStudPoll>|SvStudPollCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStudPoll child in entity.SvStudPollCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.SvStudPollCollection.Count > 0 || entity.SvStudPollCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStudPollProvider.Save(transactionManager, entity.SvStudPollCollection);
						
						deepHandles.Add("SvStudPollCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStudPoll >) DataRepository.SvStudPollProvider.DeepSave,
							new object[] { transactionManager, entity.SvStudPollCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudAbsence>
				if (CanDeepSave(entity.EdStudAbsenceCollection, "List<EdStudAbsence>|EdStudAbsenceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudAbsence child in entity.EdStudAbsenceCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdStudAbsenceCollection.Count > 0 || entity.EdStudAbsenceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudAbsenceProvider.Save(transactionManager, entity.EdStudAbsenceCollection);
						
						deepHandles.Add("EdStudAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudAbsence >) DataRepository.EdStudAbsenceProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudAbsenceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudCoursesItem>
				if (CanDeepSave(entity.FeeStudCoursesItemCollection, "List<FeeStudCoursesItem>|FeeStudCoursesItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudCoursesItem child in entity.FeeStudCoursesItemCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.FeeStudCoursesItemCollection.Count > 0 || entity.FeeStudCoursesItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudCoursesItemProvider.Save(transactionManager, entity.FeeStudCoursesItemCollection);
						
						deepHandles.Add("FeeStudCoursesItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudCoursesItem >) DataRepository.FeeStudCoursesItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudCoursesItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudAbsFw>
				if (CanDeepSave(entity.EdStudAbsFwCollection, "List<EdStudAbsFw>|EdStudAbsFwCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudAbsFw child in entity.EdStudAbsFwCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdStudAbsFwCollection.Count > 0 || entity.EdStudAbsFwCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudAbsFwProvider.Save(transactionManager, entity.EdStudAbsFwCollection);
						
						deepHandles.Add("EdStudAbsFwCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudAbsFw >) DataRepository.EdStudAbsFwProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudAbsFwCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdAcdadvRmk>
				if (CanDeepSave(entity.EdAcdadvRmkCollection, "List<EdAcdadvRmk>|EdAcdadvRmkCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdAcdadvRmk child in entity.EdAcdadvRmkCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdAcdadvRmkCollection.Count > 0 || entity.EdAcdadvRmkCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdAcdadvRmkProvider.Save(transactionManager, entity.EdAcdadvRmkCollection);
						
						deepHandles.Add("EdAcdadvRmkCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdAcdadvRmk >) DataRepository.EdAcdadvRmkProvider.DeepSave,
							new object[] { transactionManager, entity.EdAcdadvRmkCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseComp>
				if (CanDeepSave(entity.EdStudCourseCompCollection, "List<EdStudCourseComp>|EdStudCourseCompCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseComp child in entity.EdStudCourseCompCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdStudCourseCompCollection.Count > 0 || entity.EdStudCourseCompCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseCompProvider.Save(transactionManager, entity.EdStudCourseCompCollection);
						
						deepHandles.Add("EdStudCourseCompCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseComp >) DataRepository.EdStudCourseCompProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseCompCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvStudCourseEval>
				if (CanDeepSave(entity.SvStudCourseEvalCollection, "List<SvStudCourseEval>|SvStudCourseEvalCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStudCourseEval child in entity.SvStudCourseEvalCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.SvStudCourseEvalCollection.Count > 0 || entity.SvStudCourseEvalCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStudCourseEvalProvider.Save(transactionManager, entity.SvStudCourseEvalCollection);
						
						deepHandles.Add("SvStudCourseEvalCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStudCourseEval >) DataRepository.SvStudCourseEvalProvider.DeepSave,
							new object[] { transactionManager, entity.SvStudCourseEvalCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppDisability>
				if (CanDeepSave(entity.AdmAppDisabilityCollection, "List<AdmAppDisability>|AdmAppDisabilityCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppDisability child in entity.AdmAppDisabilityCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.AdmAppDisabilityCollection.Count > 0 || entity.AdmAppDisabilityCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppDisabilityProvider.Save(transactionManager, entity.AdmAppDisabilityCollection);
						
						deepHandles.Add("AdmAppDisabilityCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppDisability >) DataRepository.AdmAppDisabilityProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppDisabilityCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudContactMethod>
				if (CanDeepSave(entity.EdStudContactMethodCollection, "List<EdStudContactMethod>|EdStudContactMethodCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudContactMethod child in entity.EdStudContactMethodCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdStudContactMethodCollection.Count > 0 || entity.EdStudContactMethodCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudContactMethodProvider.Save(transactionManager, entity.EdStudContactMethodCollection);
						
						deepHandles.Add("EdStudContactMethodCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudContactMethod >) DataRepository.EdStudContactMethodProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudContactMethodCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomStudReq>
				if (CanDeepSave(entity.AccomStudReqCollection, "List<AccomStudReq>|AccomStudReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudReq child in entity.AccomStudReqCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.AccomStudReqCollection.Count > 0 || entity.AccomStudReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudReqProvider.Save(transactionManager, entity.AccomStudReqCollection);
						
						deepHandles.Add("AccomStudReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudReq >) DataRepository.AccomStudReqProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdResidencyStud>
				if (CanDeepSave(entity.EdResidencyStudCollection, "List<EdResidencyStud>|EdResidencyStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdResidencyStud child in entity.EdResidencyStudCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdResidencyStudCollection.Count > 0 || entity.EdResidencyStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdResidencyStudProvider.Save(transactionManager, entity.EdResidencyStudCollection);
						
						deepHandles.Add("EdResidencyStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdResidencyStud >) DataRepository.EdResidencyStudProvider.DeepSave,
							new object[] { transactionManager, entity.EdResidencyStudCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudStateTemp>
				if (CanDeepSave(entity.EdStudStateTempCollection, "List<EdStudStateTemp>|EdStudStateTempCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudStateTemp child in entity.EdStudStateTempCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdStudStateTempCollection.Count > 0 || entity.EdStudStateTempCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudStateTempProvider.Save(transactionManager, entity.EdStudStateTempCollection);
						
						deepHandles.Add("EdStudStateTempCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudStateTemp >) DataRepository.EdStudStateTempProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudStateTempCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgStudPublish>
				if (CanDeepSave(entity.PgStudPublishCollection, "List<PgStudPublish>|PgStudPublishCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgStudPublish child in entity.PgStudPublishCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.PgStudPublishCollection.Count > 0 || entity.PgStudPublishCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgStudPublishProvider.Save(transactionManager, entity.PgStudPublishCollection);
						
						deepHandles.Add("PgStudPublishCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgStudPublish >) DataRepository.PgStudPublishProvider.DeepSave,
							new object[] { transactionManager, entity.PgStudPublishCollection, deepSaveType, childTypes, innerList }
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
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
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
				
	
			#region List<EdStudIntTrnsStateTo>
				if (CanDeepSave(entity.EdStudIntTrnsStateToCollection, "List<EdStudIntTrnsStateTo>|EdStudIntTrnsStateToCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrnsStateTo child in entity.EdStudIntTrnsStateToCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdStudIntTrnsStateToCollection.Count > 0 || entity.EdStudIntTrnsStateToCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsStateToProvider.Save(transactionManager, entity.EdStudIntTrnsStateToCollection);
						
						deepHandles.Add("EdStudIntTrnsStateToCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrnsStateTo >) DataRepository.EdStudIntTrnsStateToProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsStateToCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudFeeItem>
				if (CanDeepSave(entity.FeeStudFeeItemCollection, "List<FeeStudFeeItem>|FeeStudFeeItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudFeeItem child in entity.FeeStudFeeItemCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.FeeStudFeeItemCollection.Count > 0 || entity.FeeStudFeeItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudFeeItemProvider.Save(transactionManager, entity.FeeStudFeeItemCollection);
						
						deepHandles.Add("FeeStudFeeItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudFeeItem >) DataRepository.FeeStudFeeItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudFeeItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdPrintReq>
				if (CanDeepSave(entity.EdPrintReqCollection, "List<EdPrintReq>|EdPrintReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdPrintReq child in entity.EdPrintReqCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdPrintReqCollection.Count > 0 || entity.EdPrintReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdPrintReqProvider.Save(transactionManager, entity.EdPrintReqCollection);
						
						deepHandles.Add("EdPrintReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdPrintReq >) DataRepository.EdPrintReqProvider.DeepSave,
							new object[] { transactionManager, entity.EdPrintReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GsAddressDtl>
				if (CanDeepSave(entity.GsAddressDtlCollection, "List<GsAddressDtl>|GsAddressDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsAddressDtl child in entity.GsAddressDtlCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.GsAddressDtlCollection.Count > 0 || entity.GsAddressDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsAddressDtlProvider.Save(transactionManager, entity.GsAddressDtlCollection);
						
						deepHandles.Add("GsAddressDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsAddressDtl >) DataRepository.GsAddressDtlProvider.DeepSave,
							new object[] { transactionManager, entity.GsAddressDtlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<TrnsStudReq>
				if (CanDeepSave(entity.TrnsStudReqCollection, "List<TrnsStudReq>|TrnsStudReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(TrnsStudReq child in entity.TrnsStudReqCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.TrnsStudReqCollection.Count > 0 || entity.TrnsStudReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.TrnsStudReqProvider.Save(transactionManager, entity.TrnsStudReqCollection);
						
						deepHandles.Add("TrnsStudReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< TrnsStudReq >) DataRepository.TrnsStudReqProvider.DeepSave,
							new object[] { transactionManager, entity.TrnsStudReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvStudAskAdv>
				if (CanDeepSave(entity.SvStudAskAdvCollection, "List<SvStudAskAdv>|SvStudAskAdvCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStudAskAdv child in entity.SvStudAskAdvCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.SvStudAskAdvCollection.Count > 0 || entity.SvStudAskAdvCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStudAskAdvProvider.Save(transactionManager, entity.SvStudAskAdvCollection);
						
						deepHandles.Add("SvStudAskAdvCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStudAskAdv >) DataRepository.SvStudAskAdvProvider.DeepSave,
							new object[] { transactionManager, entity.SvStudAskAdvCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomStudBook>
				if (CanDeepSave(entity.AccomStudBookCollection, "List<AccomStudBook>|AccomStudBookCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudBook child in entity.AccomStudBookCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.AccomStudBookCollection.Count > 0 || entity.AccomStudBookCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudBookProvider.Save(transactionManager, entity.AccomStudBookCollection);
						
						deepHandles.Add("AccomStudBookCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudBook >) DataRepository.AccomStudBookProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudBookCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvStudCourseEvalExt>
				if (CanDeepSave(entity.SvStudCourseEvalExtCollection, "List<SvStudCourseEvalExt>|SvStudCourseEvalExtCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStudCourseEvalExt child in entity.SvStudCourseEvalExtCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.SvStudCourseEvalExtCollection.Count > 0 || entity.SvStudCourseEvalExtCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStudCourseEvalExtProvider.Save(transactionManager, entity.SvStudCourseEvalExtCollection);
						
						deepHandles.Add("SvStudCourseEvalExtCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStudCourseEvalExt >) DataRepository.SvStudCourseEvalExtProvider.DeepSave,
							new object[] { transactionManager, entity.SvStudCourseEvalExtCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudIntTrns>
				if (CanDeepSave(entity.EdStudIntTrnsCollection, "List<EdStudIntTrns>|EdStudIntTrnsCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrns child in entity.EdStudIntTrnsCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdStudIntTrnsCollection.Count > 0 || entity.EdStudIntTrnsCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsProvider.Save(transactionManager, entity.EdStudIntTrnsCollection);
						
						deepHandles.Add("EdStudIntTrnsCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrns >) DataRepository.EdStudIntTrnsProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvStudComp>
				if (CanDeepSave(entity.SvStudCompCollection, "List<SvStudComp>|SvStudCompCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStudComp child in entity.SvStudCompCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.SvStudCompCollection.Count > 0 || entity.SvStudCompCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStudCompProvider.Save(transactionManager, entity.SvStudCompCollection);
						
						deepHandles.Add("SvStudCompCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStudComp >) DataRepository.SvStudCompProvider.DeepSave,
							new object[] { transactionManager, entity.SvStudCompCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudExcuse>
				if (CanDeepSave(entity.EdStudExcuseCollection, "List<EdStudExcuse>|EdStudExcuseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudExcuse child in entity.EdStudExcuseCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdStudExcuseCollection.Count > 0 || entity.EdStudExcuseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudExcuseProvider.Save(transactionManager, entity.EdStudExcuseCollection);
						
						deepHandles.Add("EdStudExcuseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudExcuse >) DataRepository.EdStudExcuseProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudExcuseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudQual>
				if (CanDeepSave(entity.EdStudQualCollection, "List<EdStudQual>|EdStudQualCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudQual child in entity.EdStudQualCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdStudQualCollection.Count > 0 || entity.EdStudQualCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudQualProvider.Save(transactionManager, entity.EdStudQualCollection);
						
						deepHandles.Add("EdStudQualCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudQual >) DataRepository.EdStudQualProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudQualCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<MltRptDayOutStud>
				if (CanDeepSave(entity.MltRptDayOutStudCollection, "List<MltRptDayOutStud>|MltRptDayOutStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MltRptDayOutStud child in entity.MltRptDayOutStudCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.MltRptDayOutStudCollection.Count > 0 || entity.MltRptDayOutStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MltRptDayOutStudProvider.Save(transactionManager, entity.MltRptDayOutStudCollection);
						
						deepHandles.Add("MltRptDayOutStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MltRptDayOutStud >) DataRepository.MltRptDayOutStudProvider.DeepSave,
							new object[] { transactionManager, entity.MltRptDayOutStudCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudRsrvRegTime>
				if (CanDeepSave(entity.EdStudRsrvRegTimeCollection, "List<EdStudRsrvRegTime>|EdStudRsrvRegTimeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudRsrvRegTime child in entity.EdStudRsrvRegTimeCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdStudRsrvRegTimeCollection.Count > 0 || entity.EdStudRsrvRegTimeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudRsrvRegTimeProvider.Save(transactionManager, entity.EdStudRsrvRegTimeCollection);
						
						deepHandles.Add("EdStudRsrvRegTimeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudRsrvRegTime >) DataRepository.EdStudRsrvRegTimeProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudRsrvRegTimeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppLanguages>
				if (CanDeepSave(entity.AdmAppLanguagesCollection, "List<AdmAppLanguages>|AdmAppLanguagesCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppLanguages child in entity.AdmAppLanguagesCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.AdmAppLanguagesCollection.Count > 0 || entity.AdmAppLanguagesCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppLanguagesProvider.Save(transactionManager, entity.AdmAppLanguagesCollection);
						
						deepHandles.Add("AdmAppLanguagesCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppLanguages >) DataRepository.AdmAppLanguagesProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppLanguagesCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgStudConference>
				if (CanDeepSave(entity.PgStudConferenceCollection, "List<PgStudConference>|PgStudConferenceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgStudConference child in entity.PgStudConferenceCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.PgStudConferenceCollection.Count > 0 || entity.PgStudConferenceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgStudConferenceProvider.Save(transactionManager, entity.PgStudConferenceCollection);
						
						deepHandles.Add("PgStudConferenceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgStudConference >) DataRepository.PgStudConferenceProvider.DeepSave,
							new object[] { transactionManager, entity.PgStudConferenceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudMilitaryInfo>
				if (CanDeepSave(entity.EdStudMilitaryInfoCollection, "List<EdStudMilitaryInfo>|EdStudMilitaryInfoCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudMilitaryInfo child in entity.EdStudMilitaryInfoCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.EdStudMilitaryInfoCollection.Count > 0 || entity.EdStudMilitaryInfoCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudMilitaryInfoProvider.Save(transactionManager, entity.EdStudMilitaryInfoCollection);
						
						deepHandles.Add("EdStudMilitaryInfoCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudMilitaryInfo >) DataRepository.EdStudMilitaryInfoProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudMilitaryInfoCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<IntegUserAdLogDtl>
				if (CanDeepSave(entity.IntegUserAdLogDtlCollection, "List<IntegUserAdLogDtl>|IntegUserAdLogDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(IntegUserAdLogDtl child in entity.IntegUserAdLogDtlCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.IntegUserAdLogDtlCollection.Count > 0 || entity.IntegUserAdLogDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.IntegUserAdLogDtlProvider.Save(transactionManager, entity.IntegUserAdLogDtlCollection);
						
						deepHandles.Add("IntegUserAdLogDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< IntegUserAdLogDtl >) DataRepository.IntegUserAdLogDtlProvider.DeepSave,
							new object[] { transactionManager, entity.IntegUserAdLogDtlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomStudAbsenceWarn>
				if (CanDeepSave(entity.AccomStudAbsenceWarnCollection, "List<AccomStudAbsenceWarn>|AccomStudAbsenceWarnCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudAbsenceWarn child in entity.AccomStudAbsenceWarnCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.AccomStudAbsenceWarnCollection.Count > 0 || entity.AccomStudAbsenceWarnCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudAbsenceWarnProvider.Save(transactionManager, entity.AccomStudAbsenceWarnCollection);
						
						deepHandles.Add("AccomStudAbsenceWarnCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudAbsenceWarn >) DataRepository.AccomStudAbsenceWarnProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudAbsenceWarnCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmEnglishProficiency>
				if (CanDeepSave(entity.AdmEnglishProficiencyCollection, "List<AdmEnglishProficiency>|AdmEnglishProficiencyCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmEnglishProficiency child in entity.AdmEnglishProficiencyCollection)
					{
						if(child.EdStudIdSource != null)
						{
							child.EdStudId = child.EdStudIdSource.EdStudId;
						}
						else
						{
							child.EdStudId = entity.EdStudId;
						}

					}

					if (entity.AdmEnglishProficiencyCollection.Count > 0 || entity.AdmEnglishProficiencyCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmEnglishProficiencyProvider.Save(transactionManager, entity.AdmEnglishProficiencyCollection);
						
						deepHandles.Add("AdmEnglishProficiencyCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmEnglishProficiency >) DataRepository.AdmEnglishProficiencyProvider.DeepSave,
							new object[] { transactionManager, entity.AdmEnglishProficiencyCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdStudChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStud</c>
	///</summary>
	public enum EdStudChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsCdeBlood</c> at GsCdeBloodIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeBlood))]
		GsCdeBlood,
		
		///<summary>
		/// Composite Property for <c>GsCdeMaritalStatus</c> at GsCdeMaritalStatusIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeMaritalStatus))]
		GsCdeMaritalStatus,
		
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
		/// Composite Property for <c>GsCodeLanguage</c> at GsCodeLanguageIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeLanguage))]
		GsCodeLanguage,
		
		///<summary>
		/// Composite Property for <c>GsCodeReligion</c> at GsCodeReligionIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeReligion))]
		GsCodeReligion,
		
		///<summary>
		/// Composite Property for <c>GsCountryNode</c> at GsCountryInfoId1Source
		///</summary>
		[ChildEntityType(typeof(GsCountryNode))]
		GsCountryNode,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberPrntIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudFacultyCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudFaculty>))]
		EdStudFacultyCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudTransCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudTrans>))]
		EdStudTransCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for SvStudAskAdvReCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStudAskAdvRe>))]
		SvStudAskAdvReCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for AccomStudResponsibleCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudResponsible>))]
		AccomStudResponsibleCollection,
		///<summary>
		/// Entity <c>FeeStudBank</c> as OneToOne for FeeStudBank
		///</summary>
		[ChildEntityType(typeof(FeeStudBank))]
		FeeStudBank,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudCourseRegPreCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseRegPre>))]
		EdStudCourseRegPreCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for SvStudStaffEvalExtCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStudStaffEvalExt>))]
		SvStudStaffEvalExtCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudSemesterTempCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudSemesterTemp>))]
		EdStudSemesterTempCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for MdiStudProblemCollection
		///</summary>
		[ChildEntityType(typeof(TList<MdiStudProblem>))]
		MdiStudProblemCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for FeeStudInstallmentCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudInstallment>))]
		FeeStudInstallmentCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for ScStudGroupCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScStudGroup>))]
		ScStudGroupCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudMltryCrsCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudMltryCrs>))]
		EdStudMltryCrsCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for RsrchStudRegisterCollection
		///</summary>
		[ChildEntityType(typeof(TList<RsrchStudRegister>))]
		RsrchStudRegisterCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdTrainStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdTrainStud>))]
		EdTrainStudCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudMilitaryStateCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudMilitaryState>))]
		EdStudMilitaryStateCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudGraduationAwardCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudGraduationAward>))]
		EdStudGraduationAwardCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudGuardCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudGuard>))]
		EdStudGuardCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudTransFromReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudTransFromReq>))]
		EdStudTransFromReqCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for SvStudStaffEvalCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStudStaffEval>))]
		SvStudStaffEvalCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudIntTrnsStateFromCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsStateFrom>))]
		EdStudIntTrnsStateFromCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudAcadWarnCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudAcadWarn>))]
		EdStudAcadWarnCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for MdiStudHosptlCollection
		///</summary>
		[ChildEntityType(typeof(TList<MdiStudHosptl>))]
		MdiStudHosptlCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudLangCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudLang>))]
		EdStudLangCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for MdiStudRecordCollection
		///</summary>
		[ChildEntityType(typeof(TList<MdiStudRecord>))]
		MdiStudRecordCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudLatenessCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudLateness>))]
		EdStudLatenessCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for FeeStudItemCnclCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudItemCncl>))]
		FeeStudItemCnclCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudActivityCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudActivity>))]
		EdStudActivityCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for FeeStudPayPostponeCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudPayPostpone>))]
		FeeStudPayPostponeCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudRsdncyCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudRsdncy>))]
		EdStudRsdncyCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for MltStudInfoCollection
		///</summary>
		[ChildEntityType(typeof(TList<MltStudInfo>))]
		MltStudInfoCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for SvStudLockerReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStudLockerReq>))]
		SvStudLockerReqCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudMissionCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudMission>))]
		EdStudMissionCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for AdmAppWorkExperCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppWorkExper>))]
		AdmAppWorkExperCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudNoteCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudNote>))]
		EdStudNoteCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudAcadmicAdvCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudAcadmicAdv>))]
		EdStudAcadmicAdvCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for CtrSrvcCrewCollection
		///</summary>
		[ChildEntityType(typeof(TList<CtrSrvcCrew>))]
		CtrSrvcCrewCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for SeBlockTransCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeBlockTrans>))]
		SeBlockTransCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for SpoSponsorStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoSponsorStud>))]
		SpoSponsorStudCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for AlmJobCollection
		///</summary>
		[ChildEntityType(typeof(TList<AlmJob>))]
		AlmJobCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for FeeStudVoucherCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudVoucher>))]
		FeeStudVoucherCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for SpoSponsorStudSemesterCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoSponsorStudSemester>))]
		SpoSponsorStudSemesterCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for FeeStudFundCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudFund>))]
		FeeStudFundCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for PgStudTravelCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgStudTravel>))]
		PgStudTravelCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for CtrStudOutCollection
		///</summary>
		[ChildEntityType(typeof(TList<CtrStudOut>))]
		CtrStudOutCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for FeeStudDiscCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudDisc>))]
		FeeStudDiscCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudSportCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudSport>))]
		EdStudSportCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for MdiStudVaccCollection
		///</summary>
		[ChildEntityType(typeof(TList<MdiStudVacc>))]
		MdiStudVaccCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for CtrStudExpCollection
		///</summary>
		[ChildEntityType(typeof(TList<CtrStudExp>))]
		CtrStudExpCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for MdiStudClnqCollection
		///</summary>
		[ChildEntityType(typeof(TList<MdiStudClnq>))]
		MdiStudClnqCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for PgThesisStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisStud>))]
		PgThesisStudCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for FeeStudRetrieveRequestCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudRetrieveRequest>))]
		FeeStudRetrieveRequestCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudViolCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudViol>))]
		EdStudViolCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for AdmApplicantCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmApplicant>))]
		AdmApplicantCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudIntTrnsCourseFromCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsCourseFrom>))]
		EdStudIntTrnsCourseFromCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for AccomStudAbsenceCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudAbsence>))]
		AccomStudAbsenceCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for FeeItemTrnsBlncCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeItemTrnsBlnc>))]
		FeeItemTrnsBlncCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for AdmScholorshipCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmScholorship>))]
		AdmScholorshipCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for FeeStudInstallmentRequestCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudInstallmentRequest>))]
		FeeStudInstallmentRequestCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudGrantTempCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudGrantTemp>))]
		EdStudGrantTempCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for FeeStudAllowanceCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudAllowance>))]
		FeeStudAllowanceCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for FeeInvoiceCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeInvoice>))]
		FeeInvoiceCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudProblemCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudProblem>))]
		EdStudProblemCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for AlmPrintRequestCollection
		///</summary>
		[ChildEntityType(typeof(TList<AlmPrintRequest>))]
		AlmPrintRequestCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for FeeInstlmntStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeInstlmntStud>))]
		FeeInstlmntStudCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudCodeChngCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCodeChng>))]
		EdStudCodeChngCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudGrantDegreeCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudGrantDegree>))]
		EdStudGrantDegreeCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdProjStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdProjStud>))]
		EdProjStudCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudExmptReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudExmptReq>))]
		EdStudExmptReqCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for AdmAppDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppDoc>))]
		AdmAppDocCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for RsrchStudPostponeReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<RsrchStudPostponeReq>))]
		RsrchStudPostponeReqCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for TrnsStudCarStkrCollection
		///</summary>
		[ChildEntityType(typeof(TList<TrnsStudCarStkr>))]
		TrnsStudCarStkrCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for PgThesisNoteCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisNote>))]
		PgThesisNoteCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for FeeStudNatSimilarityRequestCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudNatSimilarityRequest>))]
		FeeStudNatSimilarityRequestCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudSemesterCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudSemester>))]
		EdStudSemesterCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for SvSrvyRespondQstnCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvSrvyRespondQstn>))]
		SvSrvyRespondQstnCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudExecuseReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudExecuseReq>))]
		EdStudExecuseReqCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for FeeRefndStdReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeRefndStdReq>))]
		FeeRefndStdReqCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for SvStudPollCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStudPoll>))]
		SvStudPollCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudAbsenceCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudAbsence>))]
		EdStudAbsenceCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for FeeStudCoursesItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudCoursesItem>))]
		FeeStudCoursesItemCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudAbsFwCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudAbsFw>))]
		EdStudAbsFwCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdAcdadvRmkCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdAcdadvRmk>))]
		EdAcdadvRmkCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudCourseCompCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseComp>))]
		EdStudCourseCompCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for SvStudCourseEvalCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStudCourseEval>))]
		SvStudCourseEvalCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for AdmAppDisabilityCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppDisability>))]
		AdmAppDisabilityCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudContactMethodCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudContactMethod>))]
		EdStudContactMethodCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for AccomStudReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudReq>))]
		AccomStudReqCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdResidencyStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdResidencyStud>))]
		EdResidencyStudCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudStateTempCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudStateTemp>))]
		EdStudStateTempCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for PgStudPublishCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgStudPublish>))]
		PgStudPublishCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudIntTrnsCourseToCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsCourseTo>))]
		EdStudIntTrnsCourseToCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudIntTrnsStateToCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsStateTo>))]
		EdStudIntTrnsStateToCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for FeeStudFeeItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudFeeItem>))]
		FeeStudFeeItemCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdPrintReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdPrintReq>))]
		EdPrintReqCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for GsAddressDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsAddressDtl>))]
		GsAddressDtlCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for TrnsStudReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<TrnsStudReq>))]
		TrnsStudReqCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for SvStudAskAdvCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStudAskAdv>))]
		SvStudAskAdvCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for AccomStudBookCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudBook>))]
		AccomStudBookCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for SvStudCourseEvalExtCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStudCourseEvalExt>))]
		SvStudCourseEvalExtCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudIntTrnsCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrns>))]
		EdStudIntTrnsCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for SvStudCompCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStudComp>))]
		SvStudCompCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudExcuseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudExcuse>))]
		EdStudExcuseCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudQualCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudQual>))]
		EdStudQualCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for MltRptDayOutStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<MltRptDayOutStud>))]
		MltRptDayOutStudCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudRsrvRegTimeCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudRsrvRegTime>))]
		EdStudRsrvRegTimeCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for AdmAppLanguagesCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppLanguages>))]
		AdmAppLanguagesCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for PgStudConferenceCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgStudConference>))]
		PgStudConferenceCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for EdStudMilitaryInfoCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudMilitaryInfo>))]
		EdStudMilitaryInfoCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for IntegUserAdLogDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<IntegUserAdLogDtl>))]
		IntegUserAdLogDtlCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for AccomStudAbsenceWarnCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudAbsenceWarn>))]
		AccomStudAbsenceWarnCollection,
		///<summary>
		/// Collection of <c>EdStud</c> as OneToMany for AdmEnglishProficiencyCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmEnglishProficiency>))]
		AdmEnglishProficiencyCollection,
	}
	
	#endregion EdStudChildEntityTypes
	
	#region EdStudFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStud"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudFilterBuilder : SqlFilterBuilder<EdStudColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudFilterBuilder class.
		/// </summary>
		public EdStudFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudFilterBuilder
	
	#region EdStudParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStud"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudParameterBuilder : ParameterizedSqlFilterBuilder<EdStudColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudParameterBuilder class.
		/// </summary>
		public EdStudParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudParameterBuilder
	
	#region EdStudSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStud"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudSortBuilder : SqlSortBuilder<EdStudColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudSqlSortBuilder class.
		/// </summary>
		public EdStudSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudSortBuilder
	
} // end namespace
