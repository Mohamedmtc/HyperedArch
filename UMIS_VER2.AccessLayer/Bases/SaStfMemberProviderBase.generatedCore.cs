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
	/// This class is the base class for any <see cref="SaStfMemberProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaStfMemberProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaStfMember, UMIS_VER2.BusinessLyer.SaStfMemberKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaStfMemberKey key)
		{
			return Delete(transactionManager, key.SaStfMemberId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saStfMemberId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saStfMemberId)
		{
			return Delete(null, _saStfMemberId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saStfMemberId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0029 key.
		///		FK_AUTO_0029 Description: 
		/// </summary>
		/// <param name="_gsContactMethodHId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByGsContactMethodHId(System.Decimal? _gsContactMethodHId)
		{
			int count = -1;
			return GetByGsContactMethodHId(_gsContactMethodHId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0029 key.
		///		FK_AUTO_0029 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsContactMethodHId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		/// <remarks></remarks>
		public TList<SaStfMember> GetByGsContactMethodHId(TransactionManager transactionManager, System.Decimal? _gsContactMethodHId)
		{
			int count = -1;
			return GetByGsContactMethodHId(transactionManager, _gsContactMethodHId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0029 key.
		///		FK_AUTO_0029 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsContactMethodHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByGsContactMethodHId(TransactionManager transactionManager, System.Decimal? _gsContactMethodHId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsContactMethodHId(transactionManager, _gsContactMethodHId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0029 key.
		///		fkAuto0029 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsContactMethodHId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByGsContactMethodHId(System.Decimal? _gsContactMethodHId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsContactMethodHId(null, _gsContactMethodHId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0029 key.
		///		fkAuto0029 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsContactMethodHId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByGsContactMethodHId(System.Decimal? _gsContactMethodHId, int start, int pageLength,out int count)
		{
			return GetByGsContactMethodHId(null, _gsContactMethodHId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0029 key.
		///		FK_AUTO_0029 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsContactMethodHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public abstract TList<SaStfMember> GetByGsContactMethodHId(TransactionManager transactionManager, System.Decimal? _gsContactMethodHId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_002b key.
		///		FK_AUTO_002b Description: 
		/// </summary>
		/// <param name="_pgThesisGeneralSpecId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByPgThesisGeneralSpecId(System.Decimal? _pgThesisGeneralSpecId)
		{
			int count = -1;
			return GetByPgThesisGeneralSpecId(_pgThesisGeneralSpecId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_002b key.
		///		FK_AUTO_002b Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisGeneralSpecId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		/// <remarks></remarks>
		public TList<SaStfMember> GetByPgThesisGeneralSpecId(TransactionManager transactionManager, System.Decimal? _pgThesisGeneralSpecId)
		{
			int count = -1;
			return GetByPgThesisGeneralSpecId(transactionManager, _pgThesisGeneralSpecId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_002b key.
		///		FK_AUTO_002b Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisGeneralSpecId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByPgThesisGeneralSpecId(TransactionManager transactionManager, System.Decimal? _pgThesisGeneralSpecId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisGeneralSpecId(transactionManager, _pgThesisGeneralSpecId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_002b key.
		///		fkAuto002b Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisGeneralSpecId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByPgThesisGeneralSpecId(System.Decimal? _pgThesisGeneralSpecId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisGeneralSpecId(null, _pgThesisGeneralSpecId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_002b key.
		///		fkAuto002b Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisGeneralSpecId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByPgThesisGeneralSpecId(System.Decimal? _pgThesisGeneralSpecId, int start, int pageLength,out int count)
		{
			return GetByPgThesisGeneralSpecId(null, _pgThesisGeneralSpecId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_002b key.
		///		FK_AUTO_002b Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisGeneralSpecId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public abstract TList<SaStfMember> GetByPgThesisGeneralSpecId(TransactionManager transactionManager, System.Decimal? _pgThesisGeneralSpecId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_AS_FACULTY_INFO key.
		///		FK_SA_STF_MEMBER_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_AS_FACULTY_INFO key.
		///		FK_SA_STF_MEMBER_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		/// <remarks></remarks>
		public TList<SaStfMember> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_AS_FACULTY_INFO key.
		///		FK_SA_STF_MEMBER_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_AS_FACULTY_INFO key.
		///		fkSaStfMemberAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_AS_FACULTY_INFO key.
		///		fkSaStfMemberAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_AS_FACULTY_INFO key.
		///		FK_SA_STF_MEMBER_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public abstract TList<SaStfMember> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_ENTITY_MAIN key.
		///		FK_SA_STF_MEMBER_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_asNodeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByAsNodeId(System.Decimal? _asNodeId)
		{
			int count = -1;
			return GetByAsNodeId(_asNodeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_ENTITY_MAIN key.
		///		FK_SA_STF_MEMBER_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asNodeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		/// <remarks></remarks>
		public TList<SaStfMember> GetByAsNodeId(TransactionManager transactionManager, System.Decimal? _asNodeId)
		{
			int count = -1;
			return GetByAsNodeId(transactionManager, _asNodeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_ENTITY_MAIN key.
		///		FK_SA_STF_MEMBER_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByAsNodeId(TransactionManager transactionManager, System.Decimal? _asNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsNodeId(transactionManager, _asNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_ENTITY_MAIN key.
		///		fkSaStfMemberEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asNodeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByAsNodeId(System.Decimal? _asNodeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsNodeId(null, _asNodeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_ENTITY_MAIN key.
		///		fkSaStfMemberEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asNodeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByAsNodeId(System.Decimal? _asNodeId, int start, int pageLength,out int count)
		{
			return GetByAsNodeId(null, _asNodeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_ENTITY_MAIN key.
		///		FK_SA_STF_MEMBER_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public abstract TList<SaStfMember> GetByAsNodeId(TransactionManager transactionManager, System.Decimal? _asNodeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_GS_CDE_MARITAL_STATUS key.
		///		FK_SA_STF_MEMBER_GS_CDE_MARITAL_STATUS Description: 
		/// </summary>
		/// <param name="_gsCodeMaritalStateId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByGsCodeMaritalStateId(System.Decimal? _gsCodeMaritalStateId)
		{
			int count = -1;
			return GetByGsCodeMaritalStateId(_gsCodeMaritalStateId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_GS_CDE_MARITAL_STATUS key.
		///		FK_SA_STF_MEMBER_GS_CDE_MARITAL_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeMaritalStateId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		/// <remarks></remarks>
		public TList<SaStfMember> GetByGsCodeMaritalStateId(TransactionManager transactionManager, System.Decimal? _gsCodeMaritalStateId)
		{
			int count = -1;
			return GetByGsCodeMaritalStateId(transactionManager, _gsCodeMaritalStateId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_GS_CDE_MARITAL_STATUS key.
		///		FK_SA_STF_MEMBER_GS_CDE_MARITAL_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeMaritalStateId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByGsCodeMaritalStateId(TransactionManager transactionManager, System.Decimal? _gsCodeMaritalStateId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeMaritalStateId(transactionManager, _gsCodeMaritalStateId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_GS_CDE_MARITAL_STATUS key.
		///		fkSaStfMemberGsCdeMaritalStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeMaritalStateId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByGsCodeMaritalStateId(System.Decimal? _gsCodeMaritalStateId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeMaritalStateId(null, _gsCodeMaritalStateId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_GS_CDE_MARITAL_STATUS key.
		///		fkSaStfMemberGsCdeMaritalStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeMaritalStateId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByGsCodeMaritalStateId(System.Decimal? _gsCodeMaritalStateId, int start, int pageLength,out int count)
		{
			return GetByGsCodeMaritalStateId(null, _gsCodeMaritalStateId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_GS_CDE_MARITAL_STATUS key.
		///		FK_SA_STF_MEMBER_GS_CDE_MARITAL_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeMaritalStateId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public abstract TList<SaStfMember> GetByGsCodeMaritalStateId(TransactionManager transactionManager, System.Decimal? _gsCodeMaritalStateId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_GS_CODE_GENDER key.
		///		FK_SA_STF_MEMBER_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="_gsCodeGenderId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId)
		{
			int count = -1;
			return GetByGsCodeGenderId(_gsCodeGenderId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_GS_CODE_GENDER key.
		///		FK_SA_STF_MEMBER_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		/// <remarks></remarks>
		public TList<SaStfMember> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId)
		{
			int count = -1;
			return GetByGsCodeGenderId(transactionManager, _gsCodeGenderId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_GS_CODE_GENDER key.
		///		FK_SA_STF_MEMBER_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeGenderId(transactionManager, _gsCodeGenderId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_GS_CODE_GENDER key.
		///		fkSaStfMemberGsCodeGender Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeGenderId(null, _gsCodeGenderId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_GS_CODE_GENDER key.
		///		fkSaStfMemberGsCodeGender Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId, int start, int pageLength,out int count)
		{
			return GetByGsCodeGenderId(null, _gsCodeGenderId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_GS_CODE_GENDER key.
		///		FK_SA_STF_MEMBER_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public abstract TList<SaStfMember> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_GS_CODE_IDENT_TYPE key.
		///		FK_SA_STF_MEMBER_GS_CODE_IDENT_TYPE Description: 
		/// </summary>
		/// <param name="_gsCodeIdentTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByGsCodeIdentTypeId(System.Decimal? _gsCodeIdentTypeId)
		{
			int count = -1;
			return GetByGsCodeIdentTypeId(_gsCodeIdentTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_GS_CODE_IDENT_TYPE key.
		///		FK_SA_STF_MEMBER_GS_CODE_IDENT_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeIdentTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		/// <remarks></remarks>
		public TList<SaStfMember> GetByGsCodeIdentTypeId(TransactionManager transactionManager, System.Decimal? _gsCodeIdentTypeId)
		{
			int count = -1;
			return GetByGsCodeIdentTypeId(transactionManager, _gsCodeIdentTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_GS_CODE_IDENT_TYPE key.
		///		FK_SA_STF_MEMBER_GS_CODE_IDENT_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeIdentTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByGsCodeIdentTypeId(TransactionManager transactionManager, System.Decimal? _gsCodeIdentTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeIdentTypeId(transactionManager, _gsCodeIdentTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_GS_CODE_IDENT_TYPE key.
		///		fkSaStfMemberGsCodeIdentType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeIdentTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByGsCodeIdentTypeId(System.Decimal? _gsCodeIdentTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeIdentTypeId(null, _gsCodeIdentTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_GS_CODE_IDENT_TYPE key.
		///		fkSaStfMemberGsCodeIdentType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeIdentTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByGsCodeIdentTypeId(System.Decimal? _gsCodeIdentTypeId, int start, int pageLength,out int count)
		{
			return GetByGsCodeIdentTypeId(null, _gsCodeIdentTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_GS_CODE_IDENT_TYPE key.
		///		FK_SA_STF_MEMBER_GS_CODE_IDENT_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeIdentTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public abstract TList<SaStfMember> GetByGsCodeIdentTypeId(TransactionManager transactionManager, System.Decimal? _gsCodeIdentTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_GS_CODE_RELIGION key.
		///		FK_SA_STF_MEMBER_GS_CODE_RELIGION Description: 
		/// </summary>
		/// <param name="_gsCodeReligionId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByGsCodeReligionId(System.Decimal? _gsCodeReligionId)
		{
			int count = -1;
			return GetByGsCodeReligionId(_gsCodeReligionId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_GS_CODE_RELIGION key.
		///		FK_SA_STF_MEMBER_GS_CODE_RELIGION Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReligionId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		/// <remarks></remarks>
		public TList<SaStfMember> GetByGsCodeReligionId(TransactionManager transactionManager, System.Decimal? _gsCodeReligionId)
		{
			int count = -1;
			return GetByGsCodeReligionId(transactionManager, _gsCodeReligionId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_GS_CODE_RELIGION key.
		///		FK_SA_STF_MEMBER_GS_CODE_RELIGION Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReligionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByGsCodeReligionId(TransactionManager transactionManager, System.Decimal? _gsCodeReligionId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeReligionId(transactionManager, _gsCodeReligionId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_GS_CODE_RELIGION key.
		///		fkSaStfMemberGsCodeReligion Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeReligionId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByGsCodeReligionId(System.Decimal? _gsCodeReligionId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeReligionId(null, _gsCodeReligionId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_GS_CODE_RELIGION key.
		///		fkSaStfMemberGsCodeReligion Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeReligionId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByGsCodeReligionId(System.Decimal? _gsCodeReligionId, int start, int pageLength,out int count)
		{
			return GetByGsCodeReligionId(null, _gsCodeReligionId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_GS_CODE_RELIGION key.
		///		FK_SA_STF_MEMBER_GS_CODE_RELIGION Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReligionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public abstract TList<SaStfMember> GetByGsCodeReligionId(TransactionManager transactionManager, System.Decimal? _gsCodeReligionId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_GS_COUNTRY_NODE key.
		///		FK_SA_STF_MEMBER_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="_gsCountryNodeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(_gsCountryNodeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_GS_COUNTRY_NODE key.
		///		FK_SA_STF_MEMBER_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		/// <remarks></remarks>
		public TList<SaStfMember> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_GS_COUNTRY_NODE key.
		///		FK_SA_STF_MEMBER_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_GS_COUNTRY_NODE key.
		///		fkSaStfMemberGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_GS_COUNTRY_NODE key.
		///		fkSaStfMemberGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength,out int count)
		{
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_GS_COUNTRY_NODE key.
		///		FK_SA_STF_MEMBER_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public abstract TList<SaStfMember> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_GS_COUNTRY_NODE1 key.
		///		FK_SA_STF_MEMBER_GS_COUNTRY_NODE1 Description: 
		/// </summary>
		/// <param name="_gsCountryInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByGsCountryInfoId(System.Decimal? _gsCountryInfoId)
		{
			int count = -1;
			return GetByGsCountryInfoId(_gsCountryInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_GS_COUNTRY_NODE1 key.
		///		FK_SA_STF_MEMBER_GS_COUNTRY_NODE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		/// <remarks></remarks>
		public TList<SaStfMember> GetByGsCountryInfoId(TransactionManager transactionManager, System.Decimal? _gsCountryInfoId)
		{
			int count = -1;
			return GetByGsCountryInfoId(transactionManager, _gsCountryInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_GS_COUNTRY_NODE1 key.
		///		FK_SA_STF_MEMBER_GS_COUNTRY_NODE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByGsCountryInfoId(TransactionManager transactionManager, System.Decimal? _gsCountryInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryInfoId(transactionManager, _gsCountryInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_GS_COUNTRY_NODE1 key.
		///		fkSaStfMemberGsCountryNode1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByGsCountryInfoId(System.Decimal? _gsCountryInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCountryInfoId(null, _gsCountryInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_GS_COUNTRY_NODE1 key.
		///		fkSaStfMemberGsCountryNode1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByGsCountryInfoId(System.Decimal? _gsCountryInfoId, int start, int pageLength,out int count)
		{
			return GetByGsCountryInfoId(null, _gsCountryInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_GS_COUNTRY_NODE1 key.
		///		FK_SA_STF_MEMBER_GS_COUNTRY_NODE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public abstract TList<SaStfMember> GetByGsCountryInfoId(TransactionManager transactionManager, System.Decimal? _gsCountryInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_PG_THESIS_DETAILED_SPEC key.
		///		FK_SA_STF_MEMBER_PG_THESIS_DETAILED_SPEC Description: 
		/// </summary>
		/// <param name="_pgThesisDetailedSpecId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByPgThesisDetailedSpecId(System.Decimal? _pgThesisDetailedSpecId)
		{
			int count = -1;
			return GetByPgThesisDetailedSpecId(_pgThesisDetailedSpecId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_PG_THESIS_DETAILED_SPEC key.
		///		FK_SA_STF_MEMBER_PG_THESIS_DETAILED_SPEC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisDetailedSpecId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		/// <remarks></remarks>
		public TList<SaStfMember> GetByPgThesisDetailedSpecId(TransactionManager transactionManager, System.Decimal? _pgThesisDetailedSpecId)
		{
			int count = -1;
			return GetByPgThesisDetailedSpecId(transactionManager, _pgThesisDetailedSpecId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_PG_THESIS_DETAILED_SPEC key.
		///		FK_SA_STF_MEMBER_PG_THESIS_DETAILED_SPEC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisDetailedSpecId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByPgThesisDetailedSpecId(TransactionManager transactionManager, System.Decimal? _pgThesisDetailedSpecId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisDetailedSpecId(transactionManager, _pgThesisDetailedSpecId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_PG_THESIS_DETAILED_SPEC key.
		///		fkSaStfMemberPgThesisDetailedSpec Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisDetailedSpecId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByPgThesisDetailedSpecId(System.Decimal? _pgThesisDetailedSpecId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisDetailedSpecId(null, _pgThesisDetailedSpecId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_PG_THESIS_DETAILED_SPEC key.
		///		fkSaStfMemberPgThesisDetailedSpec Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisDetailedSpecId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetByPgThesisDetailedSpecId(System.Decimal? _pgThesisDetailedSpecId, int start, int pageLength,out int count)
		{
			return GetByPgThesisDetailedSpecId(null, _pgThesisDetailedSpecId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_PG_THESIS_DETAILED_SPEC key.
		///		FK_SA_STF_MEMBER_PG_THESIS_DETAILED_SPEC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisDetailedSpecId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public abstract TList<SaStfMember> GetByPgThesisDetailedSpecId(TransactionManager transactionManager, System.Decimal? _pgThesisDetailedSpecId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_SA_CDE_ADMIN_JOB key.
		///		FK_SA_STF_MEMBER_SA_CDE_ADMIN_JOB Description: 
		/// </summary>
		/// <param name="_saCdeAdminJobId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetBySaCdeAdminJobId(System.Int32? _saCdeAdminJobId)
		{
			int count = -1;
			return GetBySaCdeAdminJobId(_saCdeAdminJobId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_SA_CDE_ADMIN_JOB key.
		///		FK_SA_STF_MEMBER_SA_CDE_ADMIN_JOB Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCdeAdminJobId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		/// <remarks></remarks>
		public TList<SaStfMember> GetBySaCdeAdminJobId(TransactionManager transactionManager, System.Int32? _saCdeAdminJobId)
		{
			int count = -1;
			return GetBySaCdeAdminJobId(transactionManager, _saCdeAdminJobId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_SA_CDE_ADMIN_JOB key.
		///		FK_SA_STF_MEMBER_SA_CDE_ADMIN_JOB Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCdeAdminJobId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetBySaCdeAdminJobId(TransactionManager transactionManager, System.Int32? _saCdeAdminJobId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCdeAdminJobId(transactionManager, _saCdeAdminJobId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_SA_CDE_ADMIN_JOB key.
		///		fkSaStfMemberSaCdeAdminJob Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCdeAdminJobId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetBySaCdeAdminJobId(System.Int32? _saCdeAdminJobId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaCdeAdminJobId(null, _saCdeAdminJobId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_SA_CDE_ADMIN_JOB key.
		///		fkSaStfMemberSaCdeAdminJob Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCdeAdminJobId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetBySaCdeAdminJobId(System.Int32? _saCdeAdminJobId, int start, int pageLength,out int count)
		{
			return GetBySaCdeAdminJobId(null, _saCdeAdminJobId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_SA_CDE_ADMIN_JOB key.
		///		FK_SA_STF_MEMBER_SA_CDE_ADMIN_JOB Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCdeAdminJobId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public abstract TList<SaStfMember> GetBySaCdeAdminJobId(TransactionManager transactionManager, System.Int32? _saCdeAdminJobId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_SA_CODE_JOB_STATUS key.
		///		FK_SA_STF_MEMBER_SA_CODE_JOB_STATUS Description: 
		/// </summary>
		/// <param name="_saCodeJobStatusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetBySaCodeJobStatusId(System.Decimal? _saCodeJobStatusId)
		{
			int count = -1;
			return GetBySaCodeJobStatusId(_saCodeJobStatusId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_SA_CODE_JOB_STATUS key.
		///		FK_SA_STF_MEMBER_SA_CODE_JOB_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeJobStatusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		/// <remarks></remarks>
		public TList<SaStfMember> GetBySaCodeJobStatusId(TransactionManager transactionManager, System.Decimal? _saCodeJobStatusId)
		{
			int count = -1;
			return GetBySaCodeJobStatusId(transactionManager, _saCodeJobStatusId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_SA_CODE_JOB_STATUS key.
		///		FK_SA_STF_MEMBER_SA_CODE_JOB_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeJobStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetBySaCodeJobStatusId(TransactionManager transactionManager, System.Decimal? _saCodeJobStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeJobStatusId(transactionManager, _saCodeJobStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_SA_CODE_JOB_STATUS key.
		///		fkSaStfMemberSaCodeJobStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeJobStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetBySaCodeJobStatusId(System.Decimal? _saCodeJobStatusId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaCodeJobStatusId(null, _saCodeJobStatusId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_SA_CODE_JOB_STATUS key.
		///		fkSaStfMemberSaCodeJobStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeJobStatusId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetBySaCodeJobStatusId(System.Decimal? _saCodeJobStatusId, int start, int pageLength,out int count)
		{
			return GetBySaCodeJobStatusId(null, _saCodeJobStatusId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_SA_CODE_JOB_STATUS key.
		///		FK_SA_STF_MEMBER_SA_CODE_JOB_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeJobStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public abstract TList<SaStfMember> GetBySaCodeJobStatusId(TransactionManager transactionManager, System.Decimal? _saCodeJobStatusId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_SA_CODE_SC_DEG key.
		///		FK_SA_STF_MEMBER_SA_CODE_SC_DEG Description: 
		/// </summary>
		/// <param name="_saCodeScDegId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetBySaCodeScDegId(System.Decimal? _saCodeScDegId)
		{
			int count = -1;
			return GetBySaCodeScDegId(_saCodeScDegId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_SA_CODE_SC_DEG key.
		///		FK_SA_STF_MEMBER_SA_CODE_SC_DEG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		/// <remarks></remarks>
		public TList<SaStfMember> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal? _saCodeScDegId)
		{
			int count = -1;
			return GetBySaCodeScDegId(transactionManager, _saCodeScDegId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_SA_CODE_SC_DEG key.
		///		FK_SA_STF_MEMBER_SA_CODE_SC_DEG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal? _saCodeScDegId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeScDegId(transactionManager, _saCodeScDegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_SA_CODE_SC_DEG key.
		///		fkSaStfMemberSaCodeScDeg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeScDegId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetBySaCodeScDegId(System.Decimal? _saCodeScDegId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaCodeScDegId(null, _saCodeScDegId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_SA_CODE_SC_DEG key.
		///		fkSaStfMemberSaCodeScDeg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public TList<SaStfMember> GetBySaCodeScDegId(System.Decimal? _saCodeScDegId, int start, int pageLength,out int count)
		{
			return GetBySaCodeScDegId(null, _saCodeScDegId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_MEMBER_SA_CODE_SC_DEG key.
		///		FK_SA_STF_MEMBER_SA_CODE_SC_DEG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfMember objects.</returns>
		public abstract TList<SaStfMember> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal? _saCodeScDegId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SaStfMember Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaStfMemberKey key, int start, int pageLength)
		{
			return GetBySaStfMemberId(transactionManager, key.SaStfMemberId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_STF_MEMBER index.
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaStfMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaStfMember GetBySaStfMemberId(System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(null,_saStfMemberId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_STF_MEMBER index.
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaStfMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaStfMember GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_STF_MEMBER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaStfMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaStfMember GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_STF_MEMBER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaStfMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaStfMember GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_STF_MEMBER index.
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaStfMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaStfMember GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength, out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_STF_MEMBER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaStfMember"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaStfMember GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SA_STF_MEMBER index.
		/// </summary>
		/// <param name="_stfCode"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaStfMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaStfMember GetByStfCode(System.String _stfCode)
		{
			int count = -1;
			return GetByStfCode(null,_stfCode, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SA_STF_MEMBER index.
		/// </summary>
		/// <param name="_stfCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaStfMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaStfMember GetByStfCode(System.String _stfCode, int start, int pageLength)
		{
			int count = -1;
			return GetByStfCode(null, _stfCode, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SA_STF_MEMBER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_stfCode"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaStfMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaStfMember GetByStfCode(TransactionManager transactionManager, System.String _stfCode)
		{
			int count = -1;
			return GetByStfCode(transactionManager, _stfCode, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SA_STF_MEMBER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_stfCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaStfMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaStfMember GetByStfCode(TransactionManager transactionManager, System.String _stfCode, int start, int pageLength)
		{
			int count = -1;
			return GetByStfCode(transactionManager, _stfCode, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SA_STF_MEMBER index.
		/// </summary>
		/// <param name="_stfCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaStfMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaStfMember GetByStfCode(System.String _stfCode, int start, int pageLength, out int count)
		{
			return GetByStfCode(null, _stfCode, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SA_STF_MEMBER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_stfCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaStfMember"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaStfMember GetByStfCode(TransactionManager transactionManager, System.String _stfCode, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaStfMember&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaStfMember&gt;"/></returns>
		public static TList<SaStfMember> Fill(IDataReader reader, TList<SaStfMember> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaStfMember c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaStfMember")
					.Append("|").Append((System.Decimal)reader["SA_STF_MEMBER_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaStfMember>(
					key.ToString(), // EntityTrackingKey
					"SaStfMember",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaStfMember();
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
					c.SaStfMemberId = (System.Decimal)reader["SA_STF_MEMBER_ID"];
					c.OriginalSaStfMemberId = c.SaStfMemberId;
					c.StfCode = Convert.IsDBNull(reader["STF_CODE"]) ? null : (System.String)reader["STF_CODE"];
					c.StfFullNameAr = Convert.IsDBNull(reader["STF_FULL_NAME_AR"]) ? null : (System.String)reader["STF_FULL_NAME_AR"];
					c.StfFullNameEn = Convert.IsDBNull(reader["STF_FULL_NAME_EN"]) ? null : (System.String)reader["STF_FULL_NAME_EN"];
					c.AsNodeId = Convert.IsDBNull(reader["AS_NODE_ID"]) ? null : (System.Decimal?)reader["AS_NODE_ID"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.SaCodeJobStatusId = Convert.IsDBNull(reader["SA_CODE_JOB_STATUS_ID"]) ? null : (System.Decimal?)reader["SA_CODE_JOB_STATUS_ID"];
					c.SaCodeScDegId = Convert.IsDBNull(reader["SA_CODE_SC_DEG_ID"]) ? null : (System.Decimal?)reader["SA_CODE_SC_DEG_ID"];
					c.StfNameAr = Convert.IsDBNull(reader["STF_NAME_AR"]) ? null : (System.String)reader["STF_NAME_AR"];
					c.StfClFullNameAr = Convert.IsDBNull(reader["STF_CL_FULL_NAME_AR"]) ? null : (System.String)reader["STF_CL_FULL_NAME_AR"];
					c.StfClNameAr = Convert.IsDBNull(reader["STF_CL_NAME_AR"]) ? null : (System.String)reader["STF_CL_NAME_AR"];
					c.StfLnameAr = Convert.IsDBNull(reader["STF_LNAME_AR"]) ? null : (System.String)reader["STF_LNAME_AR"];
					c.StfClLnameAr = Convert.IsDBNull(reader["STF_CL_LNAME_AR"]) ? null : (System.String)reader["STF_CL_LNAME_AR"];
					c.StfFnameEn = Convert.IsDBNull(reader["STF_FNAME_EN"]) ? null : (System.String)reader["STF_FNAME_EN"];
					c.StfLnameEn = Convert.IsDBNull(reader["STF_LNAME_EN"]) ? null : (System.String)reader["STF_LNAME_EN"];
					c.StfIsAzhary = (System.Decimal)reader["STF_IS_AZHARY"];
					c.FileNum = Convert.IsDBNull(reader["FILE_NUM"]) ? null : (System.String)reader["FILE_NUM"];
					c.StfStatusNum = Convert.IsDBNull(reader["STF_STATUS_NUM"]) ? null : (System.String)reader["STF_STATUS_NUM"];
					c.StfNationalIdNum = Convert.IsDBNull(reader["STF_NATIONAL_ID_NUM"]) ? null : (System.String)reader["STF_NATIONAL_ID_NUM"];
					c.StfDob = Convert.IsDBNull(reader["STF_DOB"]) ? null : (System.DateTime?)reader["STF_DOB"];
					c.StfRegNum = Convert.IsDBNull(reader["STF_REG_NUM"]) ? null : (System.String)reader["STF_REG_NUM"];
					c.StfRegDate = Convert.IsDBNull(reader["STF_REG_DATE"]) ? null : (System.DateTime?)reader["STF_REG_DATE"];
					c.StfMname = Convert.IsDBNull(reader["STF_MNAME"]) ? null : (System.String)reader["STF_MNAME"];
					c.StfPermAdd = Convert.IsDBNull(reader["STF_PERM_ADD"]) ? null : (System.String)reader["STF_PERM_ADD"];
					c.StfCurrAdd = Convert.IsDBNull(reader["STF_CURR_ADD"]) ? null : (System.String)reader["STF_CURR_ADD"];
					c.StfEmpDate = Convert.IsDBNull(reader["STF_EMP_DATE"]) ? null : (System.DateTime?)reader["STF_EMP_DATE"];
					c.GsCodeGenderId = Convert.IsDBNull(reader["GS_CODE_GENDER_ID"]) ? null : (System.Decimal?)reader["GS_CODE_GENDER_ID"];
					c.GsCodeReligionId = Convert.IsDBNull(reader["GS_CODE_RELIGION_ID"]) ? null : (System.Decimal?)reader["GS_CODE_RELIGION_ID"];
					c.GsCodeMaritalStateId = Convert.IsDBNull(reader["GS_CODE_MARITAL_STATE_ID"]) ? null : (System.Decimal?)reader["GS_CODE_MARITAL_STATE_ID"];
					c.GsCountryInfoId = Convert.IsDBNull(reader["GS_COUNTRY_INFO_ID"]) ? null : (System.Decimal?)reader["GS_COUNTRY_INFO_ID"];
					c.GsCountryInfoId2 = Convert.IsDBNull(reader["GS_COUNTRY_INFO_ID2"]) ? null : (System.Decimal?)reader["GS_COUNTRY_INFO_ID2"];
					c.GsCountryNodeId = Convert.IsDBNull(reader["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)reader["GS_COUNTRY_NODE_ID"];
					c.GsCountryNodeId2 = Convert.IsDBNull(reader["GS_COUNTRY_NODE_ID2"]) ? null : (System.Decimal?)reader["GS_COUNTRY_NODE_ID2"];
					c.GsCountryNodeId3 = Convert.IsDBNull(reader["GS_COUNTRY_NODE_ID3"]) ? null : (System.Decimal?)reader["GS_COUNTRY_NODE_ID3"];
					c.GsContactMethodHId = Convert.IsDBNull(reader["GS_CONTACT_METHOD_H_ID"]) ? null : (System.Decimal?)reader["GS_CONTACT_METHOD_H_ID"];
					c.StfPhoto = Convert.IsDBNull(reader["STF_PHOTO"]) ? null : (System.String)reader["STF_PHOTO"];
					c.BasicSalary = Convert.IsDBNull(reader["BASIC_SALARY"]) ? null : (System.Decimal?)reader["BASIC_SALARY"];
					c.PgThesisGeneralSpecId = Convert.IsDBNull(reader["PG_THESIS_GENERAL_SPEC_ID"]) ? null : (System.Decimal?)reader["PG_THESIS_GENERAL_SPEC_ID"];
					c.PgThesisDetailedSpecId = Convert.IsDBNull(reader["PG_THESIS_DETAILED_SPEC_ID"]) ? null : (System.Decimal?)reader["PG_THESIS_DETAILED_SPEC_ID"];
					c.DelFlag = (System.Decimal)reader["DEL_FLAG"];
					c.RetirmentAge = (System.Decimal)reader["RETIRMENT_AGE"];
					c.OldStfMemberId = Convert.IsDBNull(reader["OLD_STF_MEMBER_ID"]) ? null : (System.Decimal?)reader["OLD_STF_MEMBER_ID"];
					c.EmailPassword = Convert.IsDBNull(reader["EMAIL_PASSWORD"]) ? null : (System.String)reader["EMAIL_PASSWORD"];
					c.TelNum = Convert.IsDBNull(reader["TEL_NUM"]) ? null : (System.String)reader["TEL_NUM"];
					c.MobNum = Convert.IsDBNull(reader["MOB_NUM"]) ? null : (System.String)reader["MOB_NUM"];
					c.EMail = Convert.IsDBNull(reader["E_MAIL"]) ? null : (System.String)reader["E_MAIL"];
					c.GsCodeIdentTypeId = Convert.IsDBNull(reader["GS_CODE_IDENT_TYPE_ID"]) ? null : (System.Decimal?)reader["GS_CODE_IDENT_TYPE_ID"];
					c.AdminJobFlg = Convert.IsDBNull(reader["ADMIN_JOB_FLG"]) ? null : (System.Boolean?)reader["ADMIN_JOB_FLG"];
					c.SaCdeAdminJobId = Convert.IsDBNull(reader["SA_CDE_ADMIN_JOB_ID"]) ? null : (System.Int32?)reader["SA_CDE_ADMIN_JOB_ID"];
					c.AdminJobLoad = Convert.IsDBNull(reader["ADMIN_JOB_LOAD"]) ? null : (System.Decimal?)reader["ADMIN_JOB_LOAD"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaStfMember"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaStfMember"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaStfMember entity)
		{
			if (!reader.Read()) return;
			
			entity.SaStfMemberId = (System.Decimal)reader[((int)SaStfMemberColumn.SaStfMemberId - 1)];
			entity.OriginalSaStfMemberId = (System.Decimal)reader["SA_STF_MEMBER_ID"];
			entity.StfCode = (reader.IsDBNull(((int)SaStfMemberColumn.StfCode - 1)))?null:(System.String)reader[((int)SaStfMemberColumn.StfCode - 1)];
			entity.StfFullNameAr = (reader.IsDBNull(((int)SaStfMemberColumn.StfFullNameAr - 1)))?null:(System.String)reader[((int)SaStfMemberColumn.StfFullNameAr - 1)];
			entity.StfFullNameEn = (reader.IsDBNull(((int)SaStfMemberColumn.StfFullNameEn - 1)))?null:(System.String)reader[((int)SaStfMemberColumn.StfFullNameEn - 1)];
			entity.AsNodeId = (reader.IsDBNull(((int)SaStfMemberColumn.AsNodeId - 1)))?null:(System.Decimal?)reader[((int)SaStfMemberColumn.AsNodeId - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)SaStfMemberColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)SaStfMemberColumn.AsFacultyInfoId - 1)];
			entity.SaCodeJobStatusId = (reader.IsDBNull(((int)SaStfMemberColumn.SaCodeJobStatusId - 1)))?null:(System.Decimal?)reader[((int)SaStfMemberColumn.SaCodeJobStatusId - 1)];
			entity.SaCodeScDegId = (reader.IsDBNull(((int)SaStfMemberColumn.SaCodeScDegId - 1)))?null:(System.Decimal?)reader[((int)SaStfMemberColumn.SaCodeScDegId - 1)];
			entity.StfNameAr = (reader.IsDBNull(((int)SaStfMemberColumn.StfNameAr - 1)))?null:(System.String)reader[((int)SaStfMemberColumn.StfNameAr - 1)];
			entity.StfClFullNameAr = (reader.IsDBNull(((int)SaStfMemberColumn.StfClFullNameAr - 1)))?null:(System.String)reader[((int)SaStfMemberColumn.StfClFullNameAr - 1)];
			entity.StfClNameAr = (reader.IsDBNull(((int)SaStfMemberColumn.StfClNameAr - 1)))?null:(System.String)reader[((int)SaStfMemberColumn.StfClNameAr - 1)];
			entity.StfLnameAr = (reader.IsDBNull(((int)SaStfMemberColumn.StfLnameAr - 1)))?null:(System.String)reader[((int)SaStfMemberColumn.StfLnameAr - 1)];
			entity.StfClLnameAr = (reader.IsDBNull(((int)SaStfMemberColumn.StfClLnameAr - 1)))?null:(System.String)reader[((int)SaStfMemberColumn.StfClLnameAr - 1)];
			entity.StfFnameEn = (reader.IsDBNull(((int)SaStfMemberColumn.StfFnameEn - 1)))?null:(System.String)reader[((int)SaStfMemberColumn.StfFnameEn - 1)];
			entity.StfLnameEn = (reader.IsDBNull(((int)SaStfMemberColumn.StfLnameEn - 1)))?null:(System.String)reader[((int)SaStfMemberColumn.StfLnameEn - 1)];
			entity.StfIsAzhary = (System.Decimal)reader[((int)SaStfMemberColumn.StfIsAzhary - 1)];
			entity.FileNum = (reader.IsDBNull(((int)SaStfMemberColumn.FileNum - 1)))?null:(System.String)reader[((int)SaStfMemberColumn.FileNum - 1)];
			entity.StfStatusNum = (reader.IsDBNull(((int)SaStfMemberColumn.StfStatusNum - 1)))?null:(System.String)reader[((int)SaStfMemberColumn.StfStatusNum - 1)];
			entity.StfNationalIdNum = (reader.IsDBNull(((int)SaStfMemberColumn.StfNationalIdNum - 1)))?null:(System.String)reader[((int)SaStfMemberColumn.StfNationalIdNum - 1)];
			entity.StfDob = (reader.IsDBNull(((int)SaStfMemberColumn.StfDob - 1)))?null:(System.DateTime?)reader[((int)SaStfMemberColumn.StfDob - 1)];
			entity.StfRegNum = (reader.IsDBNull(((int)SaStfMemberColumn.StfRegNum - 1)))?null:(System.String)reader[((int)SaStfMemberColumn.StfRegNum - 1)];
			entity.StfRegDate = (reader.IsDBNull(((int)SaStfMemberColumn.StfRegDate - 1)))?null:(System.DateTime?)reader[((int)SaStfMemberColumn.StfRegDate - 1)];
			entity.StfMname = (reader.IsDBNull(((int)SaStfMemberColumn.StfMname - 1)))?null:(System.String)reader[((int)SaStfMemberColumn.StfMname - 1)];
			entity.StfPermAdd = (reader.IsDBNull(((int)SaStfMemberColumn.StfPermAdd - 1)))?null:(System.String)reader[((int)SaStfMemberColumn.StfPermAdd - 1)];
			entity.StfCurrAdd = (reader.IsDBNull(((int)SaStfMemberColumn.StfCurrAdd - 1)))?null:(System.String)reader[((int)SaStfMemberColumn.StfCurrAdd - 1)];
			entity.StfEmpDate = (reader.IsDBNull(((int)SaStfMemberColumn.StfEmpDate - 1)))?null:(System.DateTime?)reader[((int)SaStfMemberColumn.StfEmpDate - 1)];
			entity.GsCodeGenderId = (reader.IsDBNull(((int)SaStfMemberColumn.GsCodeGenderId - 1)))?null:(System.Decimal?)reader[((int)SaStfMemberColumn.GsCodeGenderId - 1)];
			entity.GsCodeReligionId = (reader.IsDBNull(((int)SaStfMemberColumn.GsCodeReligionId - 1)))?null:(System.Decimal?)reader[((int)SaStfMemberColumn.GsCodeReligionId - 1)];
			entity.GsCodeMaritalStateId = (reader.IsDBNull(((int)SaStfMemberColumn.GsCodeMaritalStateId - 1)))?null:(System.Decimal?)reader[((int)SaStfMemberColumn.GsCodeMaritalStateId - 1)];
			entity.GsCountryInfoId = (reader.IsDBNull(((int)SaStfMemberColumn.GsCountryInfoId - 1)))?null:(System.Decimal?)reader[((int)SaStfMemberColumn.GsCountryInfoId - 1)];
			entity.GsCountryInfoId2 = (reader.IsDBNull(((int)SaStfMemberColumn.GsCountryInfoId2 - 1)))?null:(System.Decimal?)reader[((int)SaStfMemberColumn.GsCountryInfoId2 - 1)];
			entity.GsCountryNodeId = (reader.IsDBNull(((int)SaStfMemberColumn.GsCountryNodeId - 1)))?null:(System.Decimal?)reader[((int)SaStfMemberColumn.GsCountryNodeId - 1)];
			entity.GsCountryNodeId2 = (reader.IsDBNull(((int)SaStfMemberColumn.GsCountryNodeId2 - 1)))?null:(System.Decimal?)reader[((int)SaStfMemberColumn.GsCountryNodeId2 - 1)];
			entity.GsCountryNodeId3 = (reader.IsDBNull(((int)SaStfMemberColumn.GsCountryNodeId3 - 1)))?null:(System.Decimal?)reader[((int)SaStfMemberColumn.GsCountryNodeId3 - 1)];
			entity.GsContactMethodHId = (reader.IsDBNull(((int)SaStfMemberColumn.GsContactMethodHId - 1)))?null:(System.Decimal?)reader[((int)SaStfMemberColumn.GsContactMethodHId - 1)];
			entity.StfPhoto = (reader.IsDBNull(((int)SaStfMemberColumn.StfPhoto - 1)))?null:(System.String)reader[((int)SaStfMemberColumn.StfPhoto - 1)];
			entity.BasicSalary = (reader.IsDBNull(((int)SaStfMemberColumn.BasicSalary - 1)))?null:(System.Decimal?)reader[((int)SaStfMemberColumn.BasicSalary - 1)];
			entity.PgThesisGeneralSpecId = (reader.IsDBNull(((int)SaStfMemberColumn.PgThesisGeneralSpecId - 1)))?null:(System.Decimal?)reader[((int)SaStfMemberColumn.PgThesisGeneralSpecId - 1)];
			entity.PgThesisDetailedSpecId = (reader.IsDBNull(((int)SaStfMemberColumn.PgThesisDetailedSpecId - 1)))?null:(System.Decimal?)reader[((int)SaStfMemberColumn.PgThesisDetailedSpecId - 1)];
			entity.DelFlag = (System.Decimal)reader[((int)SaStfMemberColumn.DelFlag - 1)];
			entity.RetirmentAge = (System.Decimal)reader[((int)SaStfMemberColumn.RetirmentAge - 1)];
			entity.OldStfMemberId = (reader.IsDBNull(((int)SaStfMemberColumn.OldStfMemberId - 1)))?null:(System.Decimal?)reader[((int)SaStfMemberColumn.OldStfMemberId - 1)];
			entity.EmailPassword = (reader.IsDBNull(((int)SaStfMemberColumn.EmailPassword - 1)))?null:(System.String)reader[((int)SaStfMemberColumn.EmailPassword - 1)];
			entity.TelNum = (reader.IsDBNull(((int)SaStfMemberColumn.TelNum - 1)))?null:(System.String)reader[((int)SaStfMemberColumn.TelNum - 1)];
			entity.MobNum = (reader.IsDBNull(((int)SaStfMemberColumn.MobNum - 1)))?null:(System.String)reader[((int)SaStfMemberColumn.MobNum - 1)];
			entity.EMail = (reader.IsDBNull(((int)SaStfMemberColumn.EMail - 1)))?null:(System.String)reader[((int)SaStfMemberColumn.EMail - 1)];
			entity.GsCodeIdentTypeId = (reader.IsDBNull(((int)SaStfMemberColumn.GsCodeIdentTypeId - 1)))?null:(System.Decimal?)reader[((int)SaStfMemberColumn.GsCodeIdentTypeId - 1)];
			entity.AdminJobFlg = (reader.IsDBNull(((int)SaStfMemberColumn.AdminJobFlg - 1)))?null:(System.Boolean?)reader[((int)SaStfMemberColumn.AdminJobFlg - 1)];
			entity.SaCdeAdminJobId = (reader.IsDBNull(((int)SaStfMemberColumn.SaCdeAdminJobId - 1)))?null:(System.Int32?)reader[((int)SaStfMemberColumn.SaCdeAdminJobId - 1)];
			entity.AdminJobLoad = (reader.IsDBNull(((int)SaStfMemberColumn.AdminJobLoad - 1)))?null:(System.Decimal?)reader[((int)SaStfMemberColumn.AdminJobLoad - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaStfMember"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaStfMember"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaStfMember entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaStfMemberId = (System.Decimal)dataRow["SA_STF_MEMBER_ID"];
			entity.OriginalSaStfMemberId = (System.Decimal)dataRow["SA_STF_MEMBER_ID"];
			entity.StfCode = Convert.IsDBNull(dataRow["STF_CODE"]) ? null : (System.String)dataRow["STF_CODE"];
			entity.StfFullNameAr = Convert.IsDBNull(dataRow["STF_FULL_NAME_AR"]) ? null : (System.String)dataRow["STF_FULL_NAME_AR"];
			entity.StfFullNameEn = Convert.IsDBNull(dataRow["STF_FULL_NAME_EN"]) ? null : (System.String)dataRow["STF_FULL_NAME_EN"];
			entity.AsNodeId = Convert.IsDBNull(dataRow["AS_NODE_ID"]) ? null : (System.Decimal?)dataRow["AS_NODE_ID"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.SaCodeJobStatusId = Convert.IsDBNull(dataRow["SA_CODE_JOB_STATUS_ID"]) ? null : (System.Decimal?)dataRow["SA_CODE_JOB_STATUS_ID"];
			entity.SaCodeScDegId = Convert.IsDBNull(dataRow["SA_CODE_SC_DEG_ID"]) ? null : (System.Decimal?)dataRow["SA_CODE_SC_DEG_ID"];
			entity.StfNameAr = Convert.IsDBNull(dataRow["STF_NAME_AR"]) ? null : (System.String)dataRow["STF_NAME_AR"];
			entity.StfClFullNameAr = Convert.IsDBNull(dataRow["STF_CL_FULL_NAME_AR"]) ? null : (System.String)dataRow["STF_CL_FULL_NAME_AR"];
			entity.StfClNameAr = Convert.IsDBNull(dataRow["STF_CL_NAME_AR"]) ? null : (System.String)dataRow["STF_CL_NAME_AR"];
			entity.StfLnameAr = Convert.IsDBNull(dataRow["STF_LNAME_AR"]) ? null : (System.String)dataRow["STF_LNAME_AR"];
			entity.StfClLnameAr = Convert.IsDBNull(dataRow["STF_CL_LNAME_AR"]) ? null : (System.String)dataRow["STF_CL_LNAME_AR"];
			entity.StfFnameEn = Convert.IsDBNull(dataRow["STF_FNAME_EN"]) ? null : (System.String)dataRow["STF_FNAME_EN"];
			entity.StfLnameEn = Convert.IsDBNull(dataRow["STF_LNAME_EN"]) ? null : (System.String)dataRow["STF_LNAME_EN"];
			entity.StfIsAzhary = (System.Decimal)dataRow["STF_IS_AZHARY"];
			entity.FileNum = Convert.IsDBNull(dataRow["FILE_NUM"]) ? null : (System.String)dataRow["FILE_NUM"];
			entity.StfStatusNum = Convert.IsDBNull(dataRow["STF_STATUS_NUM"]) ? null : (System.String)dataRow["STF_STATUS_NUM"];
			entity.StfNationalIdNum = Convert.IsDBNull(dataRow["STF_NATIONAL_ID_NUM"]) ? null : (System.String)dataRow["STF_NATIONAL_ID_NUM"];
			entity.StfDob = Convert.IsDBNull(dataRow["STF_DOB"]) ? null : (System.DateTime?)dataRow["STF_DOB"];
			entity.StfRegNum = Convert.IsDBNull(dataRow["STF_REG_NUM"]) ? null : (System.String)dataRow["STF_REG_NUM"];
			entity.StfRegDate = Convert.IsDBNull(dataRow["STF_REG_DATE"]) ? null : (System.DateTime?)dataRow["STF_REG_DATE"];
			entity.StfMname = Convert.IsDBNull(dataRow["STF_MNAME"]) ? null : (System.String)dataRow["STF_MNAME"];
			entity.StfPermAdd = Convert.IsDBNull(dataRow["STF_PERM_ADD"]) ? null : (System.String)dataRow["STF_PERM_ADD"];
			entity.StfCurrAdd = Convert.IsDBNull(dataRow["STF_CURR_ADD"]) ? null : (System.String)dataRow["STF_CURR_ADD"];
			entity.StfEmpDate = Convert.IsDBNull(dataRow["STF_EMP_DATE"]) ? null : (System.DateTime?)dataRow["STF_EMP_DATE"];
			entity.GsCodeGenderId = Convert.IsDBNull(dataRow["GS_CODE_GENDER_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_GENDER_ID"];
			entity.GsCodeReligionId = Convert.IsDBNull(dataRow["GS_CODE_RELIGION_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_RELIGION_ID"];
			entity.GsCodeMaritalStateId = Convert.IsDBNull(dataRow["GS_CODE_MARITAL_STATE_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_MARITAL_STATE_ID"];
			entity.GsCountryInfoId = Convert.IsDBNull(dataRow["GS_COUNTRY_INFO_ID"]) ? null : (System.Decimal?)dataRow["GS_COUNTRY_INFO_ID"];
			entity.GsCountryInfoId2 = Convert.IsDBNull(dataRow["GS_COUNTRY_INFO_ID2"]) ? null : (System.Decimal?)dataRow["GS_COUNTRY_INFO_ID2"];
			entity.GsCountryNodeId = Convert.IsDBNull(dataRow["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)dataRow["GS_COUNTRY_NODE_ID"];
			entity.GsCountryNodeId2 = Convert.IsDBNull(dataRow["GS_COUNTRY_NODE_ID2"]) ? null : (System.Decimal?)dataRow["GS_COUNTRY_NODE_ID2"];
			entity.GsCountryNodeId3 = Convert.IsDBNull(dataRow["GS_COUNTRY_NODE_ID3"]) ? null : (System.Decimal?)dataRow["GS_COUNTRY_NODE_ID3"];
			entity.GsContactMethodHId = Convert.IsDBNull(dataRow["GS_CONTACT_METHOD_H_ID"]) ? null : (System.Decimal?)dataRow["GS_CONTACT_METHOD_H_ID"];
			entity.StfPhoto = Convert.IsDBNull(dataRow["STF_PHOTO"]) ? null : (System.String)dataRow["STF_PHOTO"];
			entity.BasicSalary = Convert.IsDBNull(dataRow["BASIC_SALARY"]) ? null : (System.Decimal?)dataRow["BASIC_SALARY"];
			entity.PgThesisGeneralSpecId = Convert.IsDBNull(dataRow["PG_THESIS_GENERAL_SPEC_ID"]) ? null : (System.Decimal?)dataRow["PG_THESIS_GENERAL_SPEC_ID"];
			entity.PgThesisDetailedSpecId = Convert.IsDBNull(dataRow["PG_THESIS_DETAILED_SPEC_ID"]) ? null : (System.Decimal?)dataRow["PG_THESIS_DETAILED_SPEC_ID"];
			entity.DelFlag = (System.Decimal)dataRow["DEL_FLAG"];
			entity.RetirmentAge = (System.Decimal)dataRow["RETIRMENT_AGE"];
			entity.OldStfMemberId = Convert.IsDBNull(dataRow["OLD_STF_MEMBER_ID"]) ? null : (System.Decimal?)dataRow["OLD_STF_MEMBER_ID"];
			entity.EmailPassword = Convert.IsDBNull(dataRow["EMAIL_PASSWORD"]) ? null : (System.String)dataRow["EMAIL_PASSWORD"];
			entity.TelNum = Convert.IsDBNull(dataRow["TEL_NUM"]) ? null : (System.String)dataRow["TEL_NUM"];
			entity.MobNum = Convert.IsDBNull(dataRow["MOB_NUM"]) ? null : (System.String)dataRow["MOB_NUM"];
			entity.EMail = Convert.IsDBNull(dataRow["E_MAIL"]) ? null : (System.String)dataRow["E_MAIL"];
			entity.GsCodeIdentTypeId = Convert.IsDBNull(dataRow["GS_CODE_IDENT_TYPE_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_IDENT_TYPE_ID"];
			entity.AdminJobFlg = Convert.IsDBNull(dataRow["ADMIN_JOB_FLG"]) ? null : (System.Boolean?)dataRow["ADMIN_JOB_FLG"];
			entity.SaCdeAdminJobId = Convert.IsDBNull(dataRow["SA_CDE_ADMIN_JOB_ID"]) ? null : (System.Int32?)dataRow["SA_CDE_ADMIN_JOB_ID"];
			entity.AdminJobLoad = Convert.IsDBNull(dataRow["ADMIN_JOB_LOAD"]) ? null : (System.Decimal?)dataRow["ADMIN_JOB_LOAD"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaStfMember"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaStfMember Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaStfMember entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region GsContactMethodHIdSource	
			if (CanDeepLoad(entity, "GsContactMethodH|GsContactMethodHIdSource", deepLoadType, innerList) 
				&& entity.GsContactMethodHIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsContactMethodHId ?? 0.0m);
				GsContactMethodH tmpEntity = EntityManager.LocateEntity<GsContactMethodH>(EntityLocator.ConstructKeyFromPkItems(typeof(GsContactMethodH), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsContactMethodHIdSource = tmpEntity;
				else
					entity.GsContactMethodHIdSource = DataRepository.GsContactMethodHProvider.GetByGsContactMethodHId(transactionManager, (entity.GsContactMethodHId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsContactMethodHIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsContactMethodHIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsContactMethodHProvider.DeepLoad(transactionManager, entity.GsContactMethodHIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsContactMethodHIdSource

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

			#region AsNodeIdSource	
			if (CanDeepLoad(entity, "EntityMain|AsNodeIdSource", deepLoadType, innerList) 
				&& entity.AsNodeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsNodeId ?? 0.0m);
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsNodeIdSource = tmpEntity;
				else
					entity.AsNodeIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, (entity.AsNodeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsNodeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsNodeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntityMainProvider.DeepLoad(transactionManager, entity.AsNodeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsNodeIdSource

			#region GsCodeMaritalStateIdSource	
			if (CanDeepLoad(entity, "GsCdeMaritalStatus|GsCodeMaritalStateIdSource", deepLoadType, innerList) 
				&& entity.GsCodeMaritalStateIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeMaritalStateId ?? 0.0m);
				GsCdeMaritalStatus tmpEntity = EntityManager.LocateEntity<GsCdeMaritalStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeMaritalStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeMaritalStateIdSource = tmpEntity;
				else
					entity.GsCodeMaritalStateIdSource = DataRepository.GsCdeMaritalStatusProvider.GetByGsCdeMaritalStatusId(transactionManager, (entity.GsCodeMaritalStateId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeMaritalStateIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeMaritalStateIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeMaritalStatusProvider.DeepLoad(transactionManager, entity.GsCodeMaritalStateIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeMaritalStateIdSource

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

			#region GsCountryNodeIdSource	
			if (CanDeepLoad(entity, "GsCountryNode|GsCountryNodeIdSource", deepLoadType, innerList) 
				&& entity.GsCountryNodeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCountryNodeId ?? 0.0m);
				GsCountryNode tmpEntity = EntityManager.LocateEntity<GsCountryNode>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCountryNode), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCountryNodeIdSource = tmpEntity;
				else
					entity.GsCountryNodeIdSource = DataRepository.GsCountryNodeProvider.GetByGsCountryNodeId(transactionManager, (entity.GsCountryNodeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCountryNodeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCountryNodeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCountryNodeProvider.DeepLoad(transactionManager, entity.GsCountryNodeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCountryNodeIdSource

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

			#region SaCdeAdminJobIdSource	
			if (CanDeepLoad(entity, "SaCdeAdminJob|SaCdeAdminJobIdSource", deepLoadType, innerList) 
				&& entity.SaCdeAdminJobIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaCdeAdminJobId ?? (int)0);
				SaCdeAdminJob tmpEntity = EntityManager.LocateEntity<SaCdeAdminJob>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCdeAdminJob), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCdeAdminJobIdSource = tmpEntity;
				else
					entity.SaCdeAdminJobIdSource = DataRepository.SaCdeAdminJobProvider.GetBySaCdeAdminJobId(transactionManager, (entity.SaCdeAdminJobId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCdeAdminJobIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCdeAdminJobIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCdeAdminJobProvider.DeepLoad(transactionManager, entity.SaCdeAdminJobIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCdeAdminJobIdSource

			#region SaCodeJobStatusIdSource	
			if (CanDeepLoad(entity, "SaCodeJobStatus|SaCodeJobStatusIdSource", deepLoadType, innerList) 
				&& entity.SaCodeJobStatusIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaCodeJobStatusId ?? 0.0m);
				SaCodeJobStatus tmpEntity = EntityManager.LocateEntity<SaCodeJobStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeJobStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeJobStatusIdSource = tmpEntity;
				else
					entity.SaCodeJobStatusIdSource = DataRepository.SaCodeJobStatusProvider.GetBySaCodeJobStatusId(transactionManager, (entity.SaCodeJobStatusId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeJobStatusIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodeJobStatusIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeJobStatusProvider.DeepLoad(transactionManager, entity.SaCodeJobStatusIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodeJobStatusIdSource

			#region SaCodeScDegIdSource	
			if (CanDeepLoad(entity, "SaCodeScDeg|SaCodeScDegIdSource", deepLoadType, innerList) 
				&& entity.SaCodeScDegIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaCodeScDegId ?? 0.0m);
				SaCodeScDeg tmpEntity = EntityManager.LocateEntity<SaCodeScDeg>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeScDeg), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeScDegIdSource = tmpEntity;
				else
					entity.SaCodeScDegIdSource = DataRepository.SaCodeScDegProvider.GetBySaCodeScDegId(transactionManager, (entity.SaCodeScDegId ?? 0.0m));		
				
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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySaStfMemberId methods when available
			
			#region SvStaffPollCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStaffPoll>|SvStaffPollCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStaffPollCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStaffPollCollection = DataRepository.SvStaffPollProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.SvStaffPollCollection.Count > 0)
				{
					deepHandles.Add("SvStaffPollCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStaffPoll>) DataRepository.SvStaffPollProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStaffPollCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaJobStoppageCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaJobStoppage>|SaJobStoppageCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaJobStoppageCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaJobStoppageCollection = DataRepository.SaJobStoppageProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.SaJobStoppageCollection.Count > 0)
				{
					deepHandles.Add("SaJobStoppageCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaJobStoppage>) DataRepository.SaJobStoppageProvider.DeepLoad,
						new object[] { transactionManager, entity.SaJobStoppageCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaFinStatmentCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaFinStatment>|SaFinStatmentCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaFinStatmentCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaFinStatmentCollection = DataRepository.SaFinStatmentProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.SaFinStatmentCollection.Count > 0)
				{
					deepHandles.Add("SaFinStatmentCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaFinStatment>) DataRepository.SaFinStatmentProvider.DeepLoad,
						new object[] { transactionManager, entity.SaFinStatmentCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdOfferingCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdOfferingCourse>|EdOfferingCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdOfferingCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdOfferingCourseCollection = DataRepository.EdOfferingCourseProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.EdOfferingCourseCollection.Count > 0)
				{
					deepHandles.Add("EdOfferingCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdOfferingCourse>) DataRepository.EdOfferingCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.EdOfferingCourseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaStfAttendCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaStfAttend>|SaStfAttendCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaStfAttendCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaStfAttendCollection = DataRepository.SaStfAttendProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.SaStfAttendCollection.Count > 0)
				{
					deepHandles.Add("SaStfAttendCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaStfAttend>) DataRepository.SaStfAttendProvider.DeepLoad,
						new object[] { transactionManager, entity.SaStfAttendCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoExaminerCorectorCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoExaminerCorector>|CoExaminerCorectorCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoExaminerCorectorCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoExaminerCorectorCollection = DataRepository.CoExaminerCorectorProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.CoExaminerCorectorCollection.Count > 0)
				{
					deepHandles.Add("CoExaminerCorectorCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoExaminerCorector>) DataRepository.CoExaminerCorectorProvider.DeepLoad,
						new object[] { transactionManager, entity.CoExaminerCorectorCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaVacationBalanceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaVacationBalance>|SaVacationBalanceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaVacationBalanceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaVacationBalanceCollection = DataRepository.SaVacationBalanceProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.SaVacationBalanceCollection.Count > 0)
				{
					deepHandles.Add("SaVacationBalanceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaVacationBalance>) DataRepository.SaVacationBalanceProvider.DeepLoad,
						new object[] { transactionManager, entity.SaVacationBalanceCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.SaResearchTeamCollection = DataRepository.SaResearchTeamProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.SaResearchTeamCollection.Count > 0)
				{
					deepHandles.Add("SaResearchTeamCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaResearchTeam>) DataRepository.SaResearchTeamProvider.DeepLoad,
						new object[] { transactionManager, entity.SaResearchTeamCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaEmploymentCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaEmployment>|SaEmploymentCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaEmploymentCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaEmploymentCollection = DataRepository.SaEmploymentProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.SaEmploymentCollection.Count > 0)
				{
					deepHandles.Add("SaEmploymentCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaEmployment>) DataRepository.SaEmploymentProvider.DeepLoad,
						new object[] { transactionManager, entity.SaEmploymentCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaScQualCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaScQual>|SaScQualCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaScQualCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaScQualCollection = DataRepository.SaScQualProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.SaScQualCollection.Count > 0)
				{
					deepHandles.Add("SaScQualCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaScQual>) DataRepository.SaScQualProvider.DeepLoad,
						new object[] { transactionManager, entity.SaScQualCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoControlMemberCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoControlMember>|CoControlMemberCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoControlMemberCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoControlMemberCollection = DataRepository.CoControlMemberProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.CoControlMemberCollection.Count > 0)
				{
					deepHandles.Add("CoControlMemberCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoControlMember>) DataRepository.CoControlMemberProvider.DeepLoad,
						new object[] { transactionManager, entity.CoControlMemberCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsCommStaffCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsCommStaff>|GsCommStaffCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCommStaffCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCommStaffCollection = DataRepository.GsCommStaffProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.GsCommStaffCollection.Count > 0)
				{
					deepHandles.Add("GsCommStaffCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsCommStaff>) DataRepository.GsCommStaffProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCommStaffCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaSupervisingJobsCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaSupervisingJobs>|SaSupervisingJobsCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaSupervisingJobsCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaSupervisingJobsCollection = DataRepository.SaSupervisingJobsProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.SaSupervisingJobsCollection.Count > 0)
				{
					deepHandles.Add("SaSupervisingJobsCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaSupervisingJobs>) DataRepository.SaSupervisingJobsProvider.DeepLoad,
						new object[] { transactionManager, entity.SaSupervisingJobsCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppInterviewExamCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppInterviewExam>|AdmAppInterviewExamCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppInterviewExamCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppInterviewExamCollection = DataRepository.AdmAppInterviewExamProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.AdmAppInterviewExamCollection.Count > 0)
				{
					deepHandles.Add("AdmAppInterviewExamCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppInterviewExam>) DataRepository.AdmAppInterviewExamProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppInterviewExamCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdEmployeeQualCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdEmployeeQual>|EdEmployeeQualCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdEmployeeQualCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdEmployeeQualCollection = DataRepository.EdEmployeeQualProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.EdEmployeeQualCollection.Count > 0)
				{
					deepHandles.Add("EdEmployeeQualCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdEmployeeQual>) DataRepository.EdEmployeeQualProvider.DeepLoad,
						new object[] { transactionManager, entity.EdEmployeeQualCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaStfSummeryTransCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaStfSummeryTrans>|SaStfSummeryTransCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaStfSummeryTransCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaStfSummeryTransCollection = DataRepository.SaStfSummeryTransProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.SaStfSummeryTransCollection.Count > 0)
				{
					deepHandles.Add("SaStfSummeryTransCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaStfSummeryTrans>) DataRepository.SaStfSummeryTransProvider.DeepLoad,
						new object[] { transactionManager, entity.SaStfSummeryTransCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScScheduleDtlExtStfCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScScheduleDtlExtStf>|ScScheduleDtlExtStfCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScScheduleDtlExtStfCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScScheduleDtlExtStfCollection = DataRepository.ScScheduleDtlExtStfProvider.GetBySaStfMamberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.ScScheduleDtlExtStfCollection.Count > 0)
				{
					deepHandles.Add("ScScheduleDtlExtStfCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScScheduleDtlExtStf>) DataRepository.ScScheduleDtlExtStfProvider.DeepLoad,
						new object[] { transactionManager, entity.ScScheduleDtlExtStfCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdGuardCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdGuard>|EdGuardCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdGuardCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdGuardCollection = DataRepository.EdGuardProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.EdGuardCollection.Count > 0)
				{
					deepHandles.Add("EdGuardCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdGuard>) DataRepository.EdGuardProvider.DeepLoad,
						new object[] { transactionManager, entity.EdGuardCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdStudAcadmicAdvCollection = DataRepository.EdStudAcadmicAdvProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.EdStudAcadmicAdvCollection.Count > 0)
				{
					deepHandles.Add("EdStudAcadmicAdvCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudAcadmicAdv>) DataRepository.EdStudAcadmicAdvProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudAcadmicAdvCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaRaiseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaRaise>|SaRaiseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaRaiseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaRaiseCollection = DataRepository.SaRaiseProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.SaRaiseCollection.Count > 0)
				{
					deepHandles.Add("SaRaiseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaRaise>) DataRepository.SaRaiseProvider.DeepLoad,
						new object[] { transactionManager, entity.SaRaiseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaPunishmentCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaPunishment>|SaPunishmentCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaPunishmentCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaPunishmentCollection = DataRepository.SaPunishmentProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.SaPunishmentCollection.Count > 0)
				{
					deepHandles.Add("SaPunishmentCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaPunishment>) DataRepository.SaPunishmentProvider.DeepLoad,
						new object[] { transactionManager, entity.SaPunishmentCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudActvtyRegCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudActvtyReg>|EdStudActvtyRegCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudActvtyRegCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudActvtyRegCollection = DataRepository.EdStudActvtyRegProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.EdStudActvtyRegCollection.Count > 0)
				{
					deepHandles.Add("EdStudActvtyRegCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudActvtyReg>) DataRepository.EdStudActvtyRegProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudActvtyRegCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaExperienceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaExperience>|SaExperienceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaExperienceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaExperienceCollection = DataRepository.SaExperienceProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.SaExperienceCollection.Count > 0)
				{
					deepHandles.Add("SaExperienceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaExperience>) DataRepository.SaExperienceProvider.DeepLoad,
						new object[] { transactionManager, entity.SaExperienceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaEmpHierarchyCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaEmpHierarchy>|SaEmpHierarchyCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaEmpHierarchyCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaEmpHierarchyCollection = DataRepository.SaEmpHierarchyProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.SaEmpHierarchyCollection.Count > 0)
				{
					deepHandles.Add("SaEmpHierarchyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaEmpHierarchy>) DataRepository.SaEmpHierarchyProvider.DeepLoad,
						new object[] { transactionManager, entity.SaEmpHierarchyCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.SvStudAskAdvReCollection = DataRepository.SvStudAskAdvReProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.SvStudAskAdvReCollection.Count > 0)
				{
					deepHandles.Add("SvStudAskAdvReCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStudAskAdvRe>) DataRepository.SvStudAskAdvReProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStudAskAdvReCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaPersonIdCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaPersonId>|SaPersonIdCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaPersonIdCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaPersonIdCollection = DataRepository.SaPersonIdProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.SaPersonIdCollection.Count > 0)
				{
					deepHandles.Add("SaPersonIdCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaPersonId>) DataRepository.SaPersonIdProvider.DeepLoad,
						new object[] { transactionManager, entity.SaPersonIdCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudEnrollChangeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudEnrollChange>|EdStudEnrollChangeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudEnrollChangeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudEnrollChangeCollection = DataRepository.EdStudEnrollChangeProvider.GetBySaStfMemApprovedById(transactionManager, entity.SaStfMemberId);

				if (deep && entity.EdStudEnrollChangeCollection.Count > 0)
				{
					deepHandles.Add("EdStudEnrollChangeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudEnrollChange>) DataRepository.EdStudEnrollChangeProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudEnrollChangeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaMilitaryStatusCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaMilitaryStatus>|SaMilitaryStatusCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaMilitaryStatusCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaMilitaryStatusCollection = DataRepository.SaMilitaryStatusProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.SaMilitaryStatusCollection.Count > 0)
				{
					deepHandles.Add("SaMilitaryStatusCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaMilitaryStatus>) DataRepository.SaMilitaryStatusProvider.DeepLoad,
						new object[] { transactionManager, entity.SaMilitaryStatusCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.SvStudStaffEvalExtCollection = DataRepository.SvStudStaffEvalExtProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.SvStudStaffEvalExtCollection.Count > 0)
				{
					deepHandles.Add("SvStudStaffEvalExtCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStudStaffEvalExt>) DataRepository.SvStudStaffEvalExtProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStudStaffEvalExtCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaJobStartStatmentCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaJobStartStatment>|SaJobStartStatmentCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaJobStartStatmentCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaJobStartStatmentCollection = DataRepository.SaJobStartStatmentProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.SaJobStartStatmentCollection.Count > 0)
				{
					deepHandles.Add("SaJobStartStatmentCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaJobStartStatment>) DataRepository.SaJobStartStatmentProvider.DeepLoad,
						new object[] { transactionManager, entity.SaJobStartStatmentCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScGroupStaffCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScGroupStaff>|ScGroupStaffCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScGroupStaffCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScGroupStaffCollection = DataRepository.ScGroupStaffProvider.GetBySaStfMamberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.ScGroupStaffCollection.Count > 0)
				{
					deepHandles.Add("ScGroupStaffCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScGroupStaff>) DataRepository.ScGroupStaffProvider.DeepLoad,
						new object[] { transactionManager, entity.ScGroupStaffCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStud>|EdStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCollection = DataRepository.EdStudProvider.GetBySaStfMemberPrntId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.EdStudCollection.Count > 0)
				{
					deepHandles.Add("EdStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStud>) DataRepository.EdStudProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaTrainingCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaTrainingCourse>|SaTrainingCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaTrainingCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaTrainingCourseCollection = DataRepository.SaTrainingCourseProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.SaTrainingCourseCollection.Count > 0)
				{
					deepHandles.Add("SaTrainingCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaTrainingCourse>) DataRepository.SaTrainingCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.SaTrainingCourseCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.IntegUserAdLogDtlCollection = DataRepository.IntegUserAdLogDtlProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.IntegUserAdLogDtlCollection.Count > 0)
				{
					deepHandles.Add("IntegUserAdLogDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<IntegUserAdLogDtl>) DataRepository.IntegUserAdLogDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.IntegUserAdLogDtlCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdAcdadvRmkCollection = DataRepository.EdAcdadvRmkProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.EdAcdadvRmkCollection.Count > 0)
				{
					deepHandles.Add("EdAcdadvRmkCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdAcdadvRmk>) DataRepository.EdAcdadvRmkProvider.DeepLoad,
						new object[] { transactionManager, entity.EdAcdadvRmkCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaMiltaryCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaMiltary>|SaMiltaryCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaMiltaryCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaMiltaryCollection = DataRepository.SaMiltaryProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.SaMiltaryCollection.Count > 0)
				{
					deepHandles.Add("SaMiltaryCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaMiltary>) DataRepository.SaMiltaryProvider.DeepLoad,
						new object[] { transactionManager, entity.SaMiltaryCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaServTerminCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaServTermin>|SaServTerminCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaServTerminCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaServTerminCollection = DataRepository.SaServTerminProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.SaServTerminCollection.Count > 0)
				{
					deepHandles.Add("SaServTerminCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaServTermin>) DataRepository.SaServTerminProvider.DeepLoad,
						new object[] { transactionManager, entity.SaServTerminCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaPromotionCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaPromotion>|SaPromotionCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaPromotionCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaPromotionCollection = DataRepository.SaPromotionProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.SaPromotionCollection.Count > 0)
				{
					deepHandles.Add("SaPromotionCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaPromotion>) DataRepository.SaPromotionProvider.DeepLoad,
						new object[] { transactionManager, entity.SaPromotionCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvLecNoteCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvLecNote>|SvLecNoteCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvLecNoteCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvLecNoteCollection = DataRepository.SvLecNoteProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.SvLecNoteCollection.Count > 0)
				{
					deepHandles.Add("SvLecNoteCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvLecNote>) DataRepository.SvLecNoteProvider.DeepLoad,
						new object[] { transactionManager, entity.SvLecNoteCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisStaffCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisStaff>|PgThesisStaffCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStaffCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisStaffCollection = DataRepository.PgThesisStaffProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.PgThesisStaffCollection.Count > 0)
				{
					deepHandles.Add("PgThesisStaffCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisStaff>) DataRepository.PgThesisStaffProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisStaffCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseGrdChngCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseGrdChng>|EdStudCourseGrdChngCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseGrdChngCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseGrdChngCollection = DataRepository.EdStudCourseGrdChngProvider.GetBySaStfMemApprovedById(transactionManager, entity.SaStfMemberId);

				if (deep && entity.EdStudCourseGrdChngCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseGrdChngCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseGrdChng>) DataRepository.EdStudCourseGrdChngProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseGrdChngCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStaffCoursePrefCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStaffCoursePref>|EdStaffCoursePrefCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStaffCoursePrefCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStaffCoursePrefCollection = DataRepository.EdStaffCoursePrefProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.EdStaffCoursePrefCollection.Count > 0)
				{
					deepHandles.Add("EdStaffCoursePrefCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStaffCoursePref>) DataRepository.EdStaffCoursePrefProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStaffCoursePrefCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScSchdlSlotStaffCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScSchdlSlotStaff>|ScSchdlSlotStaffCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScSchdlSlotStaffCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScSchdlSlotStaffCollection = DataRepository.ScSchdlSlotStaffProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.ScSchdlSlotStaffCollection.Count > 0)
				{
					deepHandles.Add("ScSchdlSlotStaffCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScSchdlSlotStaff>) DataRepository.ScSchdlSlotStaffProvider.DeepLoad,
						new object[] { transactionManager, entity.ScSchdlSlotStaffCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.PgThesisCommMemberCollection = DataRepository.PgThesisCommMemberProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.PgThesisCommMemberCollection.Count > 0)
				{
					deepHandles.Add("PgThesisCommMemberCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisCommMember>) DataRepository.PgThesisCommMemberProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisCommMemberCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaRelativeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaRelative>|SaRelativeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaRelativeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaRelativeCollection = DataRepository.SaRelativeProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.SaRelativeCollection.Count > 0)
				{
					deepHandles.Add("SaRelativeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaRelative>) DataRepository.SaRelativeProvider.DeepLoad,
						new object[] { transactionManager, entity.SaRelativeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaDocOfFileCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaDocOfFile>|SaDocOfFileCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaDocOfFileCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaDocOfFileCollection = DataRepository.SaDocOfFileProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.SaDocOfFileCollection.Count > 0)
				{
					deepHandles.Add("SaDocOfFileCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaDocOfFile>) DataRepository.SaDocOfFileProvider.DeepLoad,
						new object[] { transactionManager, entity.SaDocOfFileCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaPromotionRequestCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaPromotionRequest>|SaPromotionRequestCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaPromotionRequestCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaPromotionRequestCollection = DataRepository.SaPromotionRequestProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.SaPromotionRequestCollection.Count > 0)
				{
					deepHandles.Add("SaPromotionRequestCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaPromotionRequest>) DataRepository.SaPromotionRequestProvider.DeepLoad,
						new object[] { transactionManager, entity.SaPromotionRequestCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaCommMemberCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaCommMember>|SaCommMemberCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCommMemberCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaCommMemberCollection = DataRepository.SaCommMemberProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.SaCommMemberCollection.Count > 0)
				{
					deepHandles.Add("SaCommMemberCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaCommMember>) DataRepository.SaCommMemberProvider.DeepLoad,
						new object[] { transactionManager, entity.SaCommMemberCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.PgThesisNoteCollection = DataRepository.PgThesisNoteProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.PgThesisNoteCollection.Count > 0)
				{
					deepHandles.Add("PgThesisNoteCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisNote>) DataRepository.PgThesisNoteProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisNoteCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdTrainSupervisorCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdTrainSupervisor>|EdTrainSupervisorCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdTrainSupervisorCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdTrainSupervisorCollection = DataRepository.EdTrainSupervisorProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.EdTrainSupervisorCollection.Count > 0)
				{
					deepHandles.Add("EdTrainSupervisorCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdTrainSupervisor>) DataRepository.EdTrainSupervisorProvider.DeepLoad,
						new object[] { transactionManager, entity.EdTrainSupervisorCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaTransferCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaTransfer>|SaTransferCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaTransferCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaTransferCollection = DataRepository.SaTransferProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.SaTransferCollection.Count > 0)
				{
					deepHandles.Add("SaTransferCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaTransfer>) DataRepository.SaTransferProvider.DeepLoad,
						new object[] { transactionManager, entity.SaTransferCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaExtDelCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaExtDel>|SaExtDelCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaExtDelCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaExtDelCollection = DataRepository.SaExtDelProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.SaExtDelCollection.Count > 0)
				{
					deepHandles.Add("SaExtDelCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaExtDel>) DataRepository.SaExtDelProvider.DeepLoad,
						new object[] { transactionManager, entity.SaExtDelCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCourseOutcomesTopicsCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourseOutcomesTopics>|EdCourseOutcomesTopicsCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseOutcomesTopicsCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseOutcomesTopicsCollection = DataRepository.EdCourseOutcomesTopicsProvider.GetByStfCoordinator(transactionManager, entity.SaStfMemberId);

				if (deep && entity.EdCourseOutcomesTopicsCollection.Count > 0)
				{
					deepHandles.Add("EdCourseOutcomesTopicsCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourseOutcomesTopics>) DataRepository.EdCourseOutcomesTopicsProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseOutcomesTopicsCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoContRoomMemberCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoContRoomMember>|CoContRoomMemberCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoContRoomMemberCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoContRoomMemberCollection = DataRepository.CoContRoomMemberProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.CoContRoomMemberCollection.Count > 0)
				{
					deepHandles.Add("CoContRoomMemberCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoContRoomMember>) DataRepository.CoContRoomMemberProvider.DeepLoad,
						new object[] { transactionManager, entity.CoContRoomMemberCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaJobActivityCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaJobActivity>|SaJobActivityCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaJobActivityCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaJobActivityCollection = DataRepository.SaJobActivityProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.SaJobActivityCollection.Count > 0)
				{
					deepHandles.Add("SaJobActivityCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaJobActivity>) DataRepository.SaJobActivityProvider.DeepLoad,
						new object[] { transactionManager, entity.SaJobActivityCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaOfficeHourCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaOfficeHour>|SaOfficeHourCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaOfficeHourCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaOfficeHourCollection = DataRepository.SaOfficeHourProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.SaOfficeHourCollection.Count > 0)
				{
					deepHandles.Add("SaOfficeHourCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaOfficeHour>) DataRepository.SaOfficeHourProvider.DeepLoad,
						new object[] { transactionManager, entity.SaOfficeHourCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdTrainStudCollection = DataRepository.EdTrainStudProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.EdTrainStudCollection.Count > 0)
				{
					deepHandles.Add("EdTrainStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdTrainStud>) DataRepository.EdTrainStudProvider.DeepLoad,
						new object[] { transactionManager, entity.EdTrainStudCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaCandReleaseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaCandRelease>|SaCandReleaseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCandReleaseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaCandReleaseCollection = DataRepository.SaCandReleaseProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.SaCandReleaseCollection.Count > 0)
				{
					deepHandles.Add("SaCandReleaseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaCandRelease>) DataRepository.SaCandReleaseProvider.DeepLoad,
						new object[] { transactionManager, entity.SaCandReleaseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaStfDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaStfDoc>|SaStfDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaStfDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaStfDocCollection = DataRepository.SaStfDocProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.SaStfDocCollection.Count > 0)
				{
					deepHandles.Add("SaStfDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaStfDoc>) DataRepository.SaStfDocProvider.DeepLoad,
						new object[] { transactionManager, entity.SaStfDocCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.SvStudStaffEvalCollection = DataRepository.SvStudStaffEvalProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.SvStudStaffEvalCollection.Count > 0)
				{
					deepHandles.Add("SvStudStaffEvalCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStudStaffEval>) DataRepository.SvStudStaffEvalProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStudStaffEvalCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdExamSuprvsorCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdExamSuprvsor>|EdExamSuprvsorCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdExamSuprvsorCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdExamSuprvsorCollection = DataRepository.EdExamSuprvsorProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.EdExamSuprvsorCollection.Count > 0)
				{
					deepHandles.Add("EdExamSuprvsorCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdExamSuprvsor>) DataRepository.EdExamSuprvsorProvider.DeepLoad,
						new object[] { transactionManager, entity.EdExamSuprvsorCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdProjSupervisorCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdProjSupervisor>|EdProjSupervisorCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdProjSupervisorCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdProjSupervisorCollection = DataRepository.EdProjSupervisorProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.EdProjSupervisorCollection.Count > 0)
				{
					deepHandles.Add("EdProjSupervisorCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdProjSupervisor>) DataRepository.EdProjSupervisorProvider.DeepLoad,
						new object[] { transactionManager, entity.EdProjSupervisorCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.SvStudCompCollection = DataRepository.SvStudCompProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.SvStudCompCollection.Count > 0)
				{
					deepHandles.Add("SvStudCompCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStudComp>) DataRepository.SvStudCompProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStudCompCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaVacationCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaVacation>|SaVacationCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaVacationCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaVacationCollection = DataRepository.SaVacationProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);

				if (deep && entity.SaVacationCollection.Count > 0)
				{
					deepHandles.Add("SaVacationCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaVacation>) DataRepository.SaVacationProvider.DeepLoad,
						new object[] { transactionManager, entity.SaVacationCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaStfMember object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaStfMember instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaStfMember Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaStfMember entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region GsContactMethodHIdSource
			if (CanDeepSave(entity, "GsContactMethodH|GsContactMethodHIdSource", deepSaveType, innerList) 
				&& entity.GsContactMethodHIdSource != null)
			{
				DataRepository.GsContactMethodHProvider.Save(transactionManager, entity.GsContactMethodHIdSource);
				entity.GsContactMethodHId = entity.GsContactMethodHIdSource.GsContactMethodHId;
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
			
			#region AsFacultyInfoIdSource
			if (CanDeepSave(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepSaveType, innerList) 
				&& entity.AsFacultyInfoIdSource != null)
			{
				DataRepository.AsFacultyInfoProvider.Save(transactionManager, entity.AsFacultyInfoIdSource);
				entity.AsFacultyInfoId = entity.AsFacultyInfoIdSource.AsFacultyInfoId;
			}
			#endregion 
			
			#region AsNodeIdSource
			if (CanDeepSave(entity, "EntityMain|AsNodeIdSource", deepSaveType, innerList) 
				&& entity.AsNodeIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.AsNodeIdSource);
				entity.AsNodeId = entity.AsNodeIdSource.EntMainId;
			}
			#endregion 
			
			#region GsCodeMaritalStateIdSource
			if (CanDeepSave(entity, "GsCdeMaritalStatus|GsCodeMaritalStateIdSource", deepSaveType, innerList) 
				&& entity.GsCodeMaritalStateIdSource != null)
			{
				DataRepository.GsCdeMaritalStatusProvider.Save(transactionManager, entity.GsCodeMaritalStateIdSource);
				entity.GsCodeMaritalStateId = entity.GsCodeMaritalStateIdSource.GsCdeMaritalStatusId;
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
			
			#region GsCodeReligionIdSource
			if (CanDeepSave(entity, "GsCodeReligion|GsCodeReligionIdSource", deepSaveType, innerList) 
				&& entity.GsCodeReligionIdSource != null)
			{
				DataRepository.GsCodeReligionProvider.Save(transactionManager, entity.GsCodeReligionIdSource);
				entity.GsCodeReligionId = entity.GsCodeReligionIdSource.GsCodeReligionId;
			}
			#endregion 
			
			#region GsCountryNodeIdSource
			if (CanDeepSave(entity, "GsCountryNode|GsCountryNodeIdSource", deepSaveType, innerList) 
				&& entity.GsCountryNodeIdSource != null)
			{
				DataRepository.GsCountryNodeProvider.Save(transactionManager, entity.GsCountryNodeIdSource);
				entity.GsCountryNodeId = entity.GsCountryNodeIdSource.GsCountryNodeId;
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
			
			#region PgThesisDetailedSpecIdSource
			if (CanDeepSave(entity, "PgThesisDetailedSpec|PgThesisDetailedSpecIdSource", deepSaveType, innerList) 
				&& entity.PgThesisDetailedSpecIdSource != null)
			{
				DataRepository.PgThesisDetailedSpecProvider.Save(transactionManager, entity.PgThesisDetailedSpecIdSource);
				entity.PgThesisDetailedSpecId = entity.PgThesisDetailedSpecIdSource.PgThesisDetailedSpecId;
			}
			#endregion 
			
			#region SaCdeAdminJobIdSource
			if (CanDeepSave(entity, "SaCdeAdminJob|SaCdeAdminJobIdSource", deepSaveType, innerList) 
				&& entity.SaCdeAdminJobIdSource != null)
			{
				DataRepository.SaCdeAdminJobProvider.Save(transactionManager, entity.SaCdeAdminJobIdSource);
				entity.SaCdeAdminJobId = entity.SaCdeAdminJobIdSource.SaCdeAdminJobId;
			}
			#endregion 
			
			#region SaCodeJobStatusIdSource
			if (CanDeepSave(entity, "SaCodeJobStatus|SaCodeJobStatusIdSource", deepSaveType, innerList) 
				&& entity.SaCodeJobStatusIdSource != null)
			{
				DataRepository.SaCodeJobStatusProvider.Save(transactionManager, entity.SaCodeJobStatusIdSource);
				entity.SaCodeJobStatusId = entity.SaCodeJobStatusIdSource.SaCodeJobStatusId;
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
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SvStaffPoll>
				if (CanDeepSave(entity.SvStaffPollCollection, "List<SvStaffPoll>|SvStaffPollCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStaffPoll child in entity.SvStaffPollCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.SvStaffPollCollection.Count > 0 || entity.SvStaffPollCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStaffPollProvider.Save(transactionManager, entity.SvStaffPollCollection);
						
						deepHandles.Add("SvStaffPollCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStaffPoll >) DataRepository.SvStaffPollProvider.DeepSave,
							new object[] { transactionManager, entity.SvStaffPollCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaJobStoppage>
				if (CanDeepSave(entity.SaJobStoppageCollection, "List<SaJobStoppage>|SaJobStoppageCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaJobStoppage child in entity.SaJobStoppageCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.SaJobStoppageCollection.Count > 0 || entity.SaJobStoppageCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaJobStoppageProvider.Save(transactionManager, entity.SaJobStoppageCollection);
						
						deepHandles.Add("SaJobStoppageCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaJobStoppage >) DataRepository.SaJobStoppageProvider.DeepSave,
							new object[] { transactionManager, entity.SaJobStoppageCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaFinStatment>
				if (CanDeepSave(entity.SaFinStatmentCollection, "List<SaFinStatment>|SaFinStatmentCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaFinStatment child in entity.SaFinStatmentCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.SaFinStatmentCollection.Count > 0 || entity.SaFinStatmentCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaFinStatmentProvider.Save(transactionManager, entity.SaFinStatmentCollection);
						
						deepHandles.Add("SaFinStatmentCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaFinStatment >) DataRepository.SaFinStatmentProvider.DeepSave,
							new object[] { transactionManager, entity.SaFinStatmentCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdOfferingCourse>
				if (CanDeepSave(entity.EdOfferingCourseCollection, "List<EdOfferingCourse>|EdOfferingCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdOfferingCourse child in entity.EdOfferingCourseCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.EdOfferingCourseCollection.Count > 0 || entity.EdOfferingCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdOfferingCourseProvider.Save(transactionManager, entity.EdOfferingCourseCollection);
						
						deepHandles.Add("EdOfferingCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdOfferingCourse >) DataRepository.EdOfferingCourseProvider.DeepSave,
							new object[] { transactionManager, entity.EdOfferingCourseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaStfAttend>
				if (CanDeepSave(entity.SaStfAttendCollection, "List<SaStfAttend>|SaStfAttendCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaStfAttend child in entity.SaStfAttendCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.SaStfAttendCollection.Count > 0 || entity.SaStfAttendCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaStfAttendProvider.Save(transactionManager, entity.SaStfAttendCollection);
						
						deepHandles.Add("SaStfAttendCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaStfAttend >) DataRepository.SaStfAttendProvider.DeepSave,
							new object[] { transactionManager, entity.SaStfAttendCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoExaminerCorector>
				if (CanDeepSave(entity.CoExaminerCorectorCollection, "List<CoExaminerCorector>|CoExaminerCorectorCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoExaminerCorector child in entity.CoExaminerCorectorCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.CoExaminerCorectorCollection.Count > 0 || entity.CoExaminerCorectorCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoExaminerCorectorProvider.Save(transactionManager, entity.CoExaminerCorectorCollection);
						
						deepHandles.Add("CoExaminerCorectorCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoExaminerCorector >) DataRepository.CoExaminerCorectorProvider.DeepSave,
							new object[] { transactionManager, entity.CoExaminerCorectorCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaVacationBalance>
				if (CanDeepSave(entity.SaVacationBalanceCollection, "List<SaVacationBalance>|SaVacationBalanceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaVacationBalance child in entity.SaVacationBalanceCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.SaVacationBalanceCollection.Count > 0 || entity.SaVacationBalanceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaVacationBalanceProvider.Save(transactionManager, entity.SaVacationBalanceCollection);
						
						deepHandles.Add("SaVacationBalanceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaVacationBalance >) DataRepository.SaVacationBalanceProvider.DeepSave,
							new object[] { transactionManager, entity.SaVacationBalanceCollection, deepSaveType, childTypes, innerList }
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
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
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
				
	
			#region List<SaEmployment>
				if (CanDeepSave(entity.SaEmploymentCollection, "List<SaEmployment>|SaEmploymentCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaEmployment child in entity.SaEmploymentCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.SaEmploymentCollection.Count > 0 || entity.SaEmploymentCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaEmploymentProvider.Save(transactionManager, entity.SaEmploymentCollection);
						
						deepHandles.Add("SaEmploymentCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaEmployment >) DataRepository.SaEmploymentProvider.DeepSave,
							new object[] { transactionManager, entity.SaEmploymentCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaScQual>
				if (CanDeepSave(entity.SaScQualCollection, "List<SaScQual>|SaScQualCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaScQual child in entity.SaScQualCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.SaScQualCollection.Count > 0 || entity.SaScQualCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaScQualProvider.Save(transactionManager, entity.SaScQualCollection);
						
						deepHandles.Add("SaScQualCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaScQual >) DataRepository.SaScQualProvider.DeepSave,
							new object[] { transactionManager, entity.SaScQualCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoControlMember>
				if (CanDeepSave(entity.CoControlMemberCollection, "List<CoControlMember>|CoControlMemberCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoControlMember child in entity.CoControlMemberCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.CoControlMemberCollection.Count > 0 || entity.CoControlMemberCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoControlMemberProvider.Save(transactionManager, entity.CoControlMemberCollection);
						
						deepHandles.Add("CoControlMemberCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoControlMember >) DataRepository.CoControlMemberProvider.DeepSave,
							new object[] { transactionManager, entity.CoControlMemberCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GsCommStaff>
				if (CanDeepSave(entity.GsCommStaffCollection, "List<GsCommStaff>|GsCommStaffCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsCommStaff child in entity.GsCommStaffCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.GsCommStaffCollection.Count > 0 || entity.GsCommStaffCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCommStaffProvider.Save(transactionManager, entity.GsCommStaffCollection);
						
						deepHandles.Add("GsCommStaffCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsCommStaff >) DataRepository.GsCommStaffProvider.DeepSave,
							new object[] { transactionManager, entity.GsCommStaffCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaSupervisingJobs>
				if (CanDeepSave(entity.SaSupervisingJobsCollection, "List<SaSupervisingJobs>|SaSupervisingJobsCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaSupervisingJobs child in entity.SaSupervisingJobsCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.SaSupervisingJobsCollection.Count > 0 || entity.SaSupervisingJobsCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaSupervisingJobsProvider.Save(transactionManager, entity.SaSupervisingJobsCollection);
						
						deepHandles.Add("SaSupervisingJobsCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaSupervisingJobs >) DataRepository.SaSupervisingJobsProvider.DeepSave,
							new object[] { transactionManager, entity.SaSupervisingJobsCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppInterviewExam>
				if (CanDeepSave(entity.AdmAppInterviewExamCollection, "List<AdmAppInterviewExam>|AdmAppInterviewExamCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppInterviewExam child in entity.AdmAppInterviewExamCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.AdmAppInterviewExamCollection.Count > 0 || entity.AdmAppInterviewExamCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppInterviewExamProvider.Save(transactionManager, entity.AdmAppInterviewExamCollection);
						
						deepHandles.Add("AdmAppInterviewExamCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppInterviewExam >) DataRepository.AdmAppInterviewExamProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppInterviewExamCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdEmployeeQual>
				if (CanDeepSave(entity.EdEmployeeQualCollection, "List<EdEmployeeQual>|EdEmployeeQualCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdEmployeeQual child in entity.EdEmployeeQualCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.EdEmployeeQualCollection.Count > 0 || entity.EdEmployeeQualCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdEmployeeQualProvider.Save(transactionManager, entity.EdEmployeeQualCollection);
						
						deepHandles.Add("EdEmployeeQualCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdEmployeeQual >) DataRepository.EdEmployeeQualProvider.DeepSave,
							new object[] { transactionManager, entity.EdEmployeeQualCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaStfSummeryTrans>
				if (CanDeepSave(entity.SaStfSummeryTransCollection, "List<SaStfSummeryTrans>|SaStfSummeryTransCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaStfSummeryTrans child in entity.SaStfSummeryTransCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.SaStfSummeryTransCollection.Count > 0 || entity.SaStfSummeryTransCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaStfSummeryTransProvider.Save(transactionManager, entity.SaStfSummeryTransCollection);
						
						deepHandles.Add("SaStfSummeryTransCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaStfSummeryTrans >) DataRepository.SaStfSummeryTransProvider.DeepSave,
							new object[] { transactionManager, entity.SaStfSummeryTransCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScScheduleDtlExtStf>
				if (CanDeepSave(entity.ScScheduleDtlExtStfCollection, "List<ScScheduleDtlExtStf>|ScScheduleDtlExtStfCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScScheduleDtlExtStf child in entity.ScScheduleDtlExtStfCollection)
					{
						if(child.SaStfMamberIdSource != null)
						{
							child.SaStfMamberId = child.SaStfMamberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMamberId = entity.SaStfMemberId;
						}

					}

					if (entity.ScScheduleDtlExtStfCollection.Count > 0 || entity.ScScheduleDtlExtStfCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScScheduleDtlExtStfProvider.Save(transactionManager, entity.ScScheduleDtlExtStfCollection);
						
						deepHandles.Add("ScScheduleDtlExtStfCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScScheduleDtlExtStf >) DataRepository.ScScheduleDtlExtStfProvider.DeepSave,
							new object[] { transactionManager, entity.ScScheduleDtlExtStfCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdGuard>
				if (CanDeepSave(entity.EdGuardCollection, "List<EdGuard>|EdGuardCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdGuard child in entity.EdGuardCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.EdGuardCollection.Count > 0 || entity.EdGuardCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdGuardProvider.Save(transactionManager, entity.EdGuardCollection);
						
						deepHandles.Add("EdGuardCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdGuard >) DataRepository.EdGuardProvider.DeepSave,
							new object[] { transactionManager, entity.EdGuardCollection, deepSaveType, childTypes, innerList }
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
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
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
				
	
			#region List<SaRaise>
				if (CanDeepSave(entity.SaRaiseCollection, "List<SaRaise>|SaRaiseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaRaise child in entity.SaRaiseCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.SaRaiseCollection.Count > 0 || entity.SaRaiseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaRaiseProvider.Save(transactionManager, entity.SaRaiseCollection);
						
						deepHandles.Add("SaRaiseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaRaise >) DataRepository.SaRaiseProvider.DeepSave,
							new object[] { transactionManager, entity.SaRaiseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaPunishment>
				if (CanDeepSave(entity.SaPunishmentCollection, "List<SaPunishment>|SaPunishmentCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaPunishment child in entity.SaPunishmentCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.SaPunishmentCollection.Count > 0 || entity.SaPunishmentCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaPunishmentProvider.Save(transactionManager, entity.SaPunishmentCollection);
						
						deepHandles.Add("SaPunishmentCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaPunishment >) DataRepository.SaPunishmentProvider.DeepSave,
							new object[] { transactionManager, entity.SaPunishmentCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudActvtyReg>
				if (CanDeepSave(entity.EdStudActvtyRegCollection, "List<EdStudActvtyReg>|EdStudActvtyRegCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudActvtyReg child in entity.EdStudActvtyRegCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.EdStudActvtyRegCollection.Count > 0 || entity.EdStudActvtyRegCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudActvtyRegProvider.Save(transactionManager, entity.EdStudActvtyRegCollection);
						
						deepHandles.Add("EdStudActvtyRegCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudActvtyReg >) DataRepository.EdStudActvtyRegProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudActvtyRegCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaExperience>
				if (CanDeepSave(entity.SaExperienceCollection, "List<SaExperience>|SaExperienceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaExperience child in entity.SaExperienceCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.SaExperienceCollection.Count > 0 || entity.SaExperienceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaExperienceProvider.Save(transactionManager, entity.SaExperienceCollection);
						
						deepHandles.Add("SaExperienceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaExperience >) DataRepository.SaExperienceProvider.DeepSave,
							new object[] { transactionManager, entity.SaExperienceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaEmpHierarchy>
				if (CanDeepSave(entity.SaEmpHierarchyCollection, "List<SaEmpHierarchy>|SaEmpHierarchyCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaEmpHierarchy child in entity.SaEmpHierarchyCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.SaEmpHierarchyCollection.Count > 0 || entity.SaEmpHierarchyCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaEmpHierarchyProvider.Save(transactionManager, entity.SaEmpHierarchyCollection);
						
						deepHandles.Add("SaEmpHierarchyCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaEmpHierarchy >) DataRepository.SaEmpHierarchyProvider.DeepSave,
							new object[] { transactionManager, entity.SaEmpHierarchyCollection, deepSaveType, childTypes, innerList }
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
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
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
				
	
			#region List<SaPersonId>
				if (CanDeepSave(entity.SaPersonIdCollection, "List<SaPersonId>|SaPersonIdCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaPersonId child in entity.SaPersonIdCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.SaPersonIdCollection.Count > 0 || entity.SaPersonIdCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaPersonIdProvider.Save(transactionManager, entity.SaPersonIdCollection);
						
						deepHandles.Add("SaPersonIdCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaPersonId >) DataRepository.SaPersonIdProvider.DeepSave,
							new object[] { transactionManager, entity.SaPersonIdCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudEnrollChange>
				if (CanDeepSave(entity.EdStudEnrollChangeCollection, "List<EdStudEnrollChange>|EdStudEnrollChangeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudEnrollChange child in entity.EdStudEnrollChangeCollection)
					{
						if(child.SaStfMemApprovedByIdSource != null)
						{
							child.SaStfMemApprovedById = child.SaStfMemApprovedByIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemApprovedById = entity.SaStfMemberId;
						}

					}

					if (entity.EdStudEnrollChangeCollection.Count > 0 || entity.EdStudEnrollChangeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudEnrollChangeProvider.Save(transactionManager, entity.EdStudEnrollChangeCollection);
						
						deepHandles.Add("EdStudEnrollChangeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudEnrollChange >) DataRepository.EdStudEnrollChangeProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudEnrollChangeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaMilitaryStatus>
				if (CanDeepSave(entity.SaMilitaryStatusCollection, "List<SaMilitaryStatus>|SaMilitaryStatusCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaMilitaryStatus child in entity.SaMilitaryStatusCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.SaMilitaryStatusCollection.Count > 0 || entity.SaMilitaryStatusCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaMilitaryStatusProvider.Save(transactionManager, entity.SaMilitaryStatusCollection);
						
						deepHandles.Add("SaMilitaryStatusCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaMilitaryStatus >) DataRepository.SaMilitaryStatusProvider.DeepSave,
							new object[] { transactionManager, entity.SaMilitaryStatusCollection, deepSaveType, childTypes, innerList }
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
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
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
				
	
			#region List<SaJobStartStatment>
				if (CanDeepSave(entity.SaJobStartStatmentCollection, "List<SaJobStartStatment>|SaJobStartStatmentCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaJobStartStatment child in entity.SaJobStartStatmentCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.SaJobStartStatmentCollection.Count > 0 || entity.SaJobStartStatmentCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaJobStartStatmentProvider.Save(transactionManager, entity.SaJobStartStatmentCollection);
						
						deepHandles.Add("SaJobStartStatmentCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaJobStartStatment >) DataRepository.SaJobStartStatmentProvider.DeepSave,
							new object[] { transactionManager, entity.SaJobStartStatmentCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScGroupStaff>
				if (CanDeepSave(entity.ScGroupStaffCollection, "List<ScGroupStaff>|ScGroupStaffCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScGroupStaff child in entity.ScGroupStaffCollection)
					{
						if(child.SaStfMamberIdSource != null)
						{
							child.SaStfMamberId = child.SaStfMamberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMamberId = entity.SaStfMemberId;
						}

					}

					if (entity.ScGroupStaffCollection.Count > 0 || entity.ScGroupStaffCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScGroupStaffProvider.Save(transactionManager, entity.ScGroupStaffCollection);
						
						deepHandles.Add("ScGroupStaffCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScGroupStaff >) DataRepository.ScGroupStaffProvider.DeepSave,
							new object[] { transactionManager, entity.ScGroupStaffCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStud>
				if (CanDeepSave(entity.EdStudCollection, "List<EdStud>|EdStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStud child in entity.EdStudCollection)
					{
						if(child.SaStfMemberPrntIdSource != null)
						{
							child.SaStfMemberPrntId = child.SaStfMemberPrntIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberPrntId = entity.SaStfMemberId;
						}

					}

					if (entity.EdStudCollection.Count > 0 || entity.EdStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudCollection);
						
						deepHandles.Add("EdStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStud >) DataRepository.EdStudProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaTrainingCourse>
				if (CanDeepSave(entity.SaTrainingCourseCollection, "List<SaTrainingCourse>|SaTrainingCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaTrainingCourse child in entity.SaTrainingCourseCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.SaTrainingCourseCollection.Count > 0 || entity.SaTrainingCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaTrainingCourseProvider.Save(transactionManager, entity.SaTrainingCourseCollection);
						
						deepHandles.Add("SaTrainingCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaTrainingCourse >) DataRepository.SaTrainingCourseProvider.DeepSave,
							new object[] { transactionManager, entity.SaTrainingCourseCollection, deepSaveType, childTypes, innerList }
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
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
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
				
	
			#region List<EdAcdadvRmk>
				if (CanDeepSave(entity.EdAcdadvRmkCollection, "List<EdAcdadvRmk>|EdAcdadvRmkCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdAcdadvRmk child in entity.EdAcdadvRmkCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
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
				
	
			#region List<SaMiltary>
				if (CanDeepSave(entity.SaMiltaryCollection, "List<SaMiltary>|SaMiltaryCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaMiltary child in entity.SaMiltaryCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.SaMiltaryCollection.Count > 0 || entity.SaMiltaryCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaMiltaryProvider.Save(transactionManager, entity.SaMiltaryCollection);
						
						deepHandles.Add("SaMiltaryCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaMiltary >) DataRepository.SaMiltaryProvider.DeepSave,
							new object[] { transactionManager, entity.SaMiltaryCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaServTermin>
				if (CanDeepSave(entity.SaServTerminCollection, "List<SaServTermin>|SaServTerminCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaServTermin child in entity.SaServTerminCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.SaServTerminCollection.Count > 0 || entity.SaServTerminCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaServTerminProvider.Save(transactionManager, entity.SaServTerminCollection);
						
						deepHandles.Add("SaServTerminCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaServTermin >) DataRepository.SaServTerminProvider.DeepSave,
							new object[] { transactionManager, entity.SaServTerminCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaPromotion>
				if (CanDeepSave(entity.SaPromotionCollection, "List<SaPromotion>|SaPromotionCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaPromotion child in entity.SaPromotionCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.SaPromotionCollection.Count > 0 || entity.SaPromotionCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaPromotionProvider.Save(transactionManager, entity.SaPromotionCollection);
						
						deepHandles.Add("SaPromotionCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaPromotion >) DataRepository.SaPromotionProvider.DeepSave,
							new object[] { transactionManager, entity.SaPromotionCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvLecNote>
				if (CanDeepSave(entity.SvLecNoteCollection, "List<SvLecNote>|SvLecNoteCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvLecNote child in entity.SvLecNoteCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.SvLecNoteCollection.Count > 0 || entity.SvLecNoteCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvLecNoteProvider.Save(transactionManager, entity.SvLecNoteCollection);
						
						deepHandles.Add("SvLecNoteCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvLecNote >) DataRepository.SvLecNoteProvider.DeepSave,
							new object[] { transactionManager, entity.SvLecNoteCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisStaff>
				if (CanDeepSave(entity.PgThesisStaffCollection, "List<PgThesisStaff>|PgThesisStaffCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisStaff child in entity.PgThesisStaffCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
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
				
	
			#region List<EdStudCourseGrdChng>
				if (CanDeepSave(entity.EdStudCourseGrdChngCollection, "List<EdStudCourseGrdChng>|EdStudCourseGrdChngCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseGrdChng child in entity.EdStudCourseGrdChngCollection)
					{
						if(child.SaStfMemApprovedByIdSource != null)
						{
							child.SaStfMemApprovedById = child.SaStfMemApprovedByIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemApprovedById = entity.SaStfMemberId;
						}

					}

					if (entity.EdStudCourseGrdChngCollection.Count > 0 || entity.EdStudCourseGrdChngCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseGrdChngProvider.Save(transactionManager, entity.EdStudCourseGrdChngCollection);
						
						deepHandles.Add("EdStudCourseGrdChngCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseGrdChng >) DataRepository.EdStudCourseGrdChngProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseGrdChngCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStaffCoursePref>
				if (CanDeepSave(entity.EdStaffCoursePrefCollection, "List<EdStaffCoursePref>|EdStaffCoursePrefCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStaffCoursePref child in entity.EdStaffCoursePrefCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.EdStaffCoursePrefCollection.Count > 0 || entity.EdStaffCoursePrefCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStaffCoursePrefProvider.Save(transactionManager, entity.EdStaffCoursePrefCollection);
						
						deepHandles.Add("EdStaffCoursePrefCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStaffCoursePref >) DataRepository.EdStaffCoursePrefProvider.DeepSave,
							new object[] { transactionManager, entity.EdStaffCoursePrefCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScSchdlSlotStaff>
				if (CanDeepSave(entity.ScSchdlSlotStaffCollection, "List<ScSchdlSlotStaff>|ScSchdlSlotStaffCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScSchdlSlotStaff child in entity.ScSchdlSlotStaffCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.ScSchdlSlotStaffCollection.Count > 0 || entity.ScSchdlSlotStaffCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScSchdlSlotStaffProvider.Save(transactionManager, entity.ScSchdlSlotStaffCollection);
						
						deepHandles.Add("ScSchdlSlotStaffCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScSchdlSlotStaff >) DataRepository.ScSchdlSlotStaffProvider.DeepSave,
							new object[] { transactionManager, entity.ScSchdlSlotStaffCollection, deepSaveType, childTypes, innerList }
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
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
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
				
	
			#region List<SaRelative>
				if (CanDeepSave(entity.SaRelativeCollection, "List<SaRelative>|SaRelativeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaRelative child in entity.SaRelativeCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.SaRelativeCollection.Count > 0 || entity.SaRelativeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaRelativeProvider.Save(transactionManager, entity.SaRelativeCollection);
						
						deepHandles.Add("SaRelativeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaRelative >) DataRepository.SaRelativeProvider.DeepSave,
							new object[] { transactionManager, entity.SaRelativeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaDocOfFile>
				if (CanDeepSave(entity.SaDocOfFileCollection, "List<SaDocOfFile>|SaDocOfFileCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaDocOfFile child in entity.SaDocOfFileCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.SaDocOfFileCollection.Count > 0 || entity.SaDocOfFileCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaDocOfFileProvider.Save(transactionManager, entity.SaDocOfFileCollection);
						
						deepHandles.Add("SaDocOfFileCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaDocOfFile >) DataRepository.SaDocOfFileProvider.DeepSave,
							new object[] { transactionManager, entity.SaDocOfFileCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaPromotionRequest>
				if (CanDeepSave(entity.SaPromotionRequestCollection, "List<SaPromotionRequest>|SaPromotionRequestCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaPromotionRequest child in entity.SaPromotionRequestCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.SaPromotionRequestCollection.Count > 0 || entity.SaPromotionRequestCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaPromotionRequestProvider.Save(transactionManager, entity.SaPromotionRequestCollection);
						
						deepHandles.Add("SaPromotionRequestCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaPromotionRequest >) DataRepository.SaPromotionRequestProvider.DeepSave,
							new object[] { transactionManager, entity.SaPromotionRequestCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaCommMember>
				if (CanDeepSave(entity.SaCommMemberCollection, "List<SaCommMember>|SaCommMemberCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaCommMember child in entity.SaCommMemberCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.SaCommMemberCollection.Count > 0 || entity.SaCommMemberCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaCommMemberProvider.Save(transactionManager, entity.SaCommMemberCollection);
						
						deepHandles.Add("SaCommMemberCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaCommMember >) DataRepository.SaCommMemberProvider.DeepSave,
							new object[] { transactionManager, entity.SaCommMemberCollection, deepSaveType, childTypes, innerList }
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
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
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
				
	
			#region List<EdTrainSupervisor>
				if (CanDeepSave(entity.EdTrainSupervisorCollection, "List<EdTrainSupervisor>|EdTrainSupervisorCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdTrainSupervisor child in entity.EdTrainSupervisorCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.EdTrainSupervisorCollection.Count > 0 || entity.EdTrainSupervisorCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdTrainSupervisorProvider.Save(transactionManager, entity.EdTrainSupervisorCollection);
						
						deepHandles.Add("EdTrainSupervisorCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdTrainSupervisor >) DataRepository.EdTrainSupervisorProvider.DeepSave,
							new object[] { transactionManager, entity.EdTrainSupervisorCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaTransfer>
				if (CanDeepSave(entity.SaTransferCollection, "List<SaTransfer>|SaTransferCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaTransfer child in entity.SaTransferCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.SaTransferCollection.Count > 0 || entity.SaTransferCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaTransferProvider.Save(transactionManager, entity.SaTransferCollection);
						
						deepHandles.Add("SaTransferCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaTransfer >) DataRepository.SaTransferProvider.DeepSave,
							new object[] { transactionManager, entity.SaTransferCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaExtDel>
				if (CanDeepSave(entity.SaExtDelCollection, "List<SaExtDel>|SaExtDelCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaExtDel child in entity.SaExtDelCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.SaExtDelCollection.Count > 0 || entity.SaExtDelCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaExtDelProvider.Save(transactionManager, entity.SaExtDelCollection);
						
						deepHandles.Add("SaExtDelCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaExtDel >) DataRepository.SaExtDelProvider.DeepSave,
							new object[] { transactionManager, entity.SaExtDelCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCourseOutcomesTopics>
				if (CanDeepSave(entity.EdCourseOutcomesTopicsCollection, "List<EdCourseOutcomesTopics>|EdCourseOutcomesTopicsCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourseOutcomesTopics child in entity.EdCourseOutcomesTopicsCollection)
					{
						if(child.StfCoordinatorSource != null)
						{
							child.StfCoordinator = child.StfCoordinatorSource.SaStfMemberId;
						}
						else
						{
							child.StfCoordinator = entity.SaStfMemberId;
						}

					}

					if (entity.EdCourseOutcomesTopicsCollection.Count > 0 || entity.EdCourseOutcomesTopicsCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseOutcomesTopicsProvider.Save(transactionManager, entity.EdCourseOutcomesTopicsCollection);
						
						deepHandles.Add("EdCourseOutcomesTopicsCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourseOutcomesTopics >) DataRepository.EdCourseOutcomesTopicsProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseOutcomesTopicsCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoContRoomMember>
				if (CanDeepSave(entity.CoContRoomMemberCollection, "List<CoContRoomMember>|CoContRoomMemberCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoContRoomMember child in entity.CoContRoomMemberCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.CoContRoomMemberCollection.Count > 0 || entity.CoContRoomMemberCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoContRoomMemberProvider.Save(transactionManager, entity.CoContRoomMemberCollection);
						
						deepHandles.Add("CoContRoomMemberCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoContRoomMember >) DataRepository.CoContRoomMemberProvider.DeepSave,
							new object[] { transactionManager, entity.CoContRoomMemberCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaJobActivity>
				if (CanDeepSave(entity.SaJobActivityCollection, "List<SaJobActivity>|SaJobActivityCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaJobActivity child in entity.SaJobActivityCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.SaJobActivityCollection.Count > 0 || entity.SaJobActivityCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaJobActivityProvider.Save(transactionManager, entity.SaJobActivityCollection);
						
						deepHandles.Add("SaJobActivityCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaJobActivity >) DataRepository.SaJobActivityProvider.DeepSave,
							new object[] { transactionManager, entity.SaJobActivityCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaOfficeHour>
				if (CanDeepSave(entity.SaOfficeHourCollection, "List<SaOfficeHour>|SaOfficeHourCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaOfficeHour child in entity.SaOfficeHourCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.SaOfficeHourCollection.Count > 0 || entity.SaOfficeHourCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaOfficeHourProvider.Save(transactionManager, entity.SaOfficeHourCollection);
						
						deepHandles.Add("SaOfficeHourCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaOfficeHour >) DataRepository.SaOfficeHourProvider.DeepSave,
							new object[] { transactionManager, entity.SaOfficeHourCollection, deepSaveType, childTypes, innerList }
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
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
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
				
	
			#region List<SaCandRelease>
				if (CanDeepSave(entity.SaCandReleaseCollection, "List<SaCandRelease>|SaCandReleaseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaCandRelease child in entity.SaCandReleaseCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.SaCandReleaseCollection.Count > 0 || entity.SaCandReleaseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaCandReleaseProvider.Save(transactionManager, entity.SaCandReleaseCollection);
						
						deepHandles.Add("SaCandReleaseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaCandRelease >) DataRepository.SaCandReleaseProvider.DeepSave,
							new object[] { transactionManager, entity.SaCandReleaseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaStfDoc>
				if (CanDeepSave(entity.SaStfDocCollection, "List<SaStfDoc>|SaStfDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaStfDoc child in entity.SaStfDocCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.SaStfDocCollection.Count > 0 || entity.SaStfDocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaStfDocProvider.Save(transactionManager, entity.SaStfDocCollection);
						
						deepHandles.Add("SaStfDocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaStfDoc >) DataRepository.SaStfDocProvider.DeepSave,
							new object[] { transactionManager, entity.SaStfDocCollection, deepSaveType, childTypes, innerList }
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
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
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
				
	
			#region List<EdExamSuprvsor>
				if (CanDeepSave(entity.EdExamSuprvsorCollection, "List<EdExamSuprvsor>|EdExamSuprvsorCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdExamSuprvsor child in entity.EdExamSuprvsorCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.EdExamSuprvsorCollection.Count > 0 || entity.EdExamSuprvsorCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdExamSuprvsorProvider.Save(transactionManager, entity.EdExamSuprvsorCollection);
						
						deepHandles.Add("EdExamSuprvsorCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdExamSuprvsor >) DataRepository.EdExamSuprvsorProvider.DeepSave,
							new object[] { transactionManager, entity.EdExamSuprvsorCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdProjSupervisor>
				if (CanDeepSave(entity.EdProjSupervisorCollection, "List<EdProjSupervisor>|EdProjSupervisorCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdProjSupervisor child in entity.EdProjSupervisorCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.EdProjSupervisorCollection.Count > 0 || entity.EdProjSupervisorCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdProjSupervisorProvider.Save(transactionManager, entity.EdProjSupervisorCollection);
						
						deepHandles.Add("EdProjSupervisorCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdProjSupervisor >) DataRepository.EdProjSupervisorProvider.DeepSave,
							new object[] { transactionManager, entity.EdProjSupervisorCollection, deepSaveType, childTypes, innerList }
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
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
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
				
	
			#region List<SaVacation>
				if (CanDeepSave(entity.SaVacationCollection, "List<SaVacation>|SaVacationCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaVacation child in entity.SaVacationCollection)
					{
						if(child.SaStfMemberIdSource != null)
						{
							child.SaStfMemberId = child.SaStfMemberIdSource.SaStfMemberId;
						}
						else
						{
							child.SaStfMemberId = entity.SaStfMemberId;
						}

					}

					if (entity.SaVacationCollection.Count > 0 || entity.SaVacationCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaVacationProvider.Save(transactionManager, entity.SaVacationCollection);
						
						deepHandles.Add("SaVacationCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaVacation >) DataRepository.SaVacationProvider.DeepSave,
							new object[] { transactionManager, entity.SaVacationCollection, deepSaveType, childTypes, innerList }
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
	
	#region SaStfMemberChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaStfMember</c>
	///</summary>
	public enum SaStfMemberChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsContactMethodH</c> at GsContactMethodHIdSource
		///</summary>
		[ChildEntityType(typeof(GsContactMethodH))]
		GsContactMethodH,
		
		///<summary>
		/// Composite Property for <c>PgThesisGeneralSpec</c> at PgThesisGeneralSpecIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisGeneralSpec))]
		PgThesisGeneralSpec,
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at AsNodeIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		
		///<summary>
		/// Composite Property for <c>GsCdeMaritalStatus</c> at GsCodeMaritalStateIdSource
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
		/// Composite Property for <c>GsCodeReligion</c> at GsCodeReligionIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeReligion))]
		GsCodeReligion,
		
		///<summary>
		/// Composite Property for <c>GsCountryNode</c> at GsCountryNodeIdSource
		///</summary>
		[ChildEntityType(typeof(GsCountryNode))]
		GsCountryNode,
		
		///<summary>
		/// Composite Property for <c>PgThesisDetailedSpec</c> at PgThesisDetailedSpecIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisDetailedSpec))]
		PgThesisDetailedSpec,
		
		///<summary>
		/// Composite Property for <c>SaCdeAdminJob</c> at SaCdeAdminJobIdSource
		///</summary>
		[ChildEntityType(typeof(SaCdeAdminJob))]
		SaCdeAdminJob,
		
		///<summary>
		/// Composite Property for <c>SaCodeJobStatus</c> at SaCodeJobStatusIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeJobStatus))]
		SaCodeJobStatus,
		
		///<summary>
		/// Composite Property for <c>SaCodeScDeg</c> at SaCodeScDegIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeScDeg))]
		SaCodeScDeg,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for SvStaffPollCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStaffPoll>))]
		SvStaffPollCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for SaJobStoppageCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaJobStoppage>))]
		SaJobStoppageCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for SaFinStatmentCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaFinStatment>))]
		SaFinStatmentCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for EdOfferingCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdOfferingCourse>))]
		EdOfferingCourseCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for SaStfAttendCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaStfAttend>))]
		SaStfAttendCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for CoExaminerCorectorCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoExaminerCorector>))]
		CoExaminerCorectorCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for SaVacationBalanceCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaVacationBalance>))]
		SaVacationBalanceCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for SaResearchTeamCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaResearchTeam>))]
		SaResearchTeamCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for SaEmploymentCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaEmployment>))]
		SaEmploymentCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for SaScQualCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaScQual>))]
		SaScQualCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for CoControlMemberCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoControlMember>))]
		CoControlMemberCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for GsCommStaffCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsCommStaff>))]
		GsCommStaffCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for SaSupervisingJobsCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaSupervisingJobs>))]
		SaSupervisingJobsCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for AdmAppInterviewExamCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppInterviewExam>))]
		AdmAppInterviewExamCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for EdEmployeeQualCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdEmployeeQual>))]
		EdEmployeeQualCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for SaStfSummeryTransCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaStfSummeryTrans>))]
		SaStfSummeryTransCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for ScScheduleDtlExtStfCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScScheduleDtlExtStf>))]
		ScScheduleDtlExtStfCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for EdGuardCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdGuard>))]
		EdGuardCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for EdStudAcadmicAdvCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudAcadmicAdv>))]
		EdStudAcadmicAdvCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for SaRaiseCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaRaise>))]
		SaRaiseCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for SaPunishmentCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaPunishment>))]
		SaPunishmentCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for EdStudActvtyRegCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudActvtyReg>))]
		EdStudActvtyRegCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for SaExperienceCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaExperience>))]
		SaExperienceCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for SaEmpHierarchyCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaEmpHierarchy>))]
		SaEmpHierarchyCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for SvStudAskAdvReCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStudAskAdvRe>))]
		SvStudAskAdvReCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for SaPersonIdCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaPersonId>))]
		SaPersonIdCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for EdStudEnrollChangeCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudEnrollChange>))]
		EdStudEnrollChangeCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for SaMilitaryStatusCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaMilitaryStatus>))]
		SaMilitaryStatusCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for SvStudStaffEvalExtCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStudStaffEvalExt>))]
		SvStudStaffEvalExtCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for SaJobStartStatmentCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaJobStartStatment>))]
		SaJobStartStatmentCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for ScGroupStaffCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScGroupStaff>))]
		ScGroupStaffCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for EdStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStud>))]
		EdStudCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for SaTrainingCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaTrainingCourse>))]
		SaTrainingCourseCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for IntegUserAdLogDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<IntegUserAdLogDtl>))]
		IntegUserAdLogDtlCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for EdAcdadvRmkCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdAcdadvRmk>))]
		EdAcdadvRmkCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for SaMiltaryCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaMiltary>))]
		SaMiltaryCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for SaServTerminCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaServTermin>))]
		SaServTerminCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for SaPromotionCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaPromotion>))]
		SaPromotionCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for SvLecNoteCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvLecNote>))]
		SvLecNoteCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for PgThesisStaffCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisStaff>))]
		PgThesisStaffCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for EdStudCourseGrdChngCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseGrdChng>))]
		EdStudCourseGrdChngCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for EdStaffCoursePrefCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStaffCoursePref>))]
		EdStaffCoursePrefCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for ScSchdlSlotStaffCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScSchdlSlotStaff>))]
		ScSchdlSlotStaffCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for PgThesisCommMemberCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisCommMember>))]
		PgThesisCommMemberCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for SaRelativeCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaRelative>))]
		SaRelativeCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for SaDocOfFileCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaDocOfFile>))]
		SaDocOfFileCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for SaPromotionRequestCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaPromotionRequest>))]
		SaPromotionRequestCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for SaCommMemberCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaCommMember>))]
		SaCommMemberCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for PgThesisNoteCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisNote>))]
		PgThesisNoteCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for EdTrainSupervisorCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdTrainSupervisor>))]
		EdTrainSupervisorCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for SaTransferCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaTransfer>))]
		SaTransferCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for SaExtDelCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaExtDel>))]
		SaExtDelCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for EdCourseOutcomesTopicsCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourseOutcomesTopics>))]
		EdCourseOutcomesTopicsCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for CoContRoomMemberCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoContRoomMember>))]
		CoContRoomMemberCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for SaJobActivityCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaJobActivity>))]
		SaJobActivityCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for SaOfficeHourCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaOfficeHour>))]
		SaOfficeHourCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for EdTrainStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdTrainStud>))]
		EdTrainStudCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for SaCandReleaseCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaCandRelease>))]
		SaCandReleaseCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for SaStfDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaStfDoc>))]
		SaStfDocCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for SvStudStaffEvalCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStudStaffEval>))]
		SvStudStaffEvalCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for EdExamSuprvsorCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdExamSuprvsor>))]
		EdExamSuprvsorCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for EdProjSupervisorCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdProjSupervisor>))]
		EdProjSupervisorCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for SvStudCompCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStudComp>))]
		SvStudCompCollection,
		///<summary>
		/// Collection of <c>SaStfMember</c> as OneToMany for SaVacationCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaVacation>))]
		SaVacationCollection,
	}
	
	#endregion SaStfMemberChildEntityTypes
	
	#region SaStfMemberFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaStfMemberColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaStfMember"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaStfMemberFilterBuilder : SqlFilterBuilder<SaStfMemberColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaStfMemberFilterBuilder class.
		/// </summary>
		public SaStfMemberFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaStfMemberFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaStfMemberFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaStfMemberFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaStfMemberFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaStfMemberFilterBuilder
	
	#region SaStfMemberParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaStfMemberColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaStfMember"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaStfMemberParameterBuilder : ParameterizedSqlFilterBuilder<SaStfMemberColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaStfMemberParameterBuilder class.
		/// </summary>
		public SaStfMemberParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaStfMemberParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaStfMemberParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaStfMemberParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaStfMemberParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaStfMemberParameterBuilder
	
	#region SaStfMemberSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaStfMemberColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaStfMember"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaStfMemberSortBuilder : SqlSortBuilder<SaStfMemberColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaStfMemberSqlSortBuilder class.
		/// </summary>
		public SaStfMemberSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaStfMemberSortBuilder
	
} // end namespace
