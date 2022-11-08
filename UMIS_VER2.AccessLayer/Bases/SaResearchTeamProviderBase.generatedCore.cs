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
	/// This class is the base class for any <see cref="SaResearchTeamProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaResearchTeamProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaResearchTeam, UMIS_VER2.BusinessLyer.SaResearchTeamKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaResearchTeamKey key)
		{
			return Delete(transactionManager, key.SaResearchTeamId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saResearchTeamId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saResearchTeamId)
		{
			return Delete(null, _saResearchTeamId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saResearchTeamId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saResearchTeamId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_034f key.
		///		FK_AUTO_034f Description: 
		/// </summary>
		/// <param name="_saCodeScDegId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaResearchTeam objects.</returns>
		public TList<SaResearchTeam> GetBySaCodeScDegId(System.Decimal? _saCodeScDegId)
		{
			int count = -1;
			return GetBySaCodeScDegId(_saCodeScDegId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_034f key.
		///		FK_AUTO_034f Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaResearchTeam objects.</returns>
		/// <remarks></remarks>
		public TList<SaResearchTeam> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal? _saCodeScDegId)
		{
			int count = -1;
			return GetBySaCodeScDegId(transactionManager, _saCodeScDegId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_034f key.
		///		FK_AUTO_034f Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaResearchTeam objects.</returns>
		public TList<SaResearchTeam> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal? _saCodeScDegId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeScDegId(transactionManager, _saCodeScDegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_034f key.
		///		fkAuto034f Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeScDegId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaResearchTeam objects.</returns>
		public TList<SaResearchTeam> GetBySaCodeScDegId(System.Decimal? _saCodeScDegId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaCodeScDegId(null, _saCodeScDegId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_034f key.
		///		fkAuto034f Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaResearchTeam objects.</returns>
		public TList<SaResearchTeam> GetBySaCodeScDegId(System.Decimal? _saCodeScDegId, int start, int pageLength,out int count)
		{
			return GetBySaCodeScDegId(null, _saCodeScDegId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_034f key.
		///		FK_AUTO_034f Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaResearchTeam objects.</returns>
		public abstract TList<SaResearchTeam> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal? _saCodeScDegId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_04a1 key.
		///		FK_AUTO_04a1 Description: 
		/// </summary>
		/// <param name="_saScResearchId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaResearchTeam objects.</returns>
		public TList<SaResearchTeam> GetBySaScResearchId(System.Decimal _saScResearchId)
		{
			int count = -1;
			return GetBySaScResearchId(_saScResearchId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_04a1 key.
		///		FK_AUTO_04a1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saScResearchId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaResearchTeam objects.</returns>
		/// <remarks></remarks>
		public TList<SaResearchTeam> GetBySaScResearchId(TransactionManager transactionManager, System.Decimal _saScResearchId)
		{
			int count = -1;
			return GetBySaScResearchId(transactionManager, _saScResearchId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_04a1 key.
		///		FK_AUTO_04a1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saScResearchId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaResearchTeam objects.</returns>
		public TList<SaResearchTeam> GetBySaScResearchId(TransactionManager transactionManager, System.Decimal _saScResearchId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaScResearchId(transactionManager, _saScResearchId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_04a1 key.
		///		fkAuto04a1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saScResearchId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaResearchTeam objects.</returns>
		public TList<SaResearchTeam> GetBySaScResearchId(System.Decimal _saScResearchId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaScResearchId(null, _saScResearchId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_04a1 key.
		///		fkAuto04a1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saScResearchId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaResearchTeam objects.</returns>
		public TList<SaResearchTeam> GetBySaScResearchId(System.Decimal _saScResearchId, int start, int pageLength,out int count)
		{
			return GetBySaScResearchId(null, _saScResearchId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_04a1 key.
		///		FK_AUTO_04a1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saScResearchId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaResearchTeam objects.</returns>
		public abstract TList<SaResearchTeam> GetBySaScResearchId(TransactionManager transactionManager, System.Decimal _saScResearchId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_RESEARCH_TEAM_AS_FACULTY_INFO key.
		///		FK_SA_RESEARCH_TEAM_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaResearchTeam objects.</returns>
		public TList<SaResearchTeam> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_RESEARCH_TEAM_AS_FACULTY_INFO key.
		///		FK_SA_RESEARCH_TEAM_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaResearchTeam objects.</returns>
		/// <remarks></remarks>
		public TList<SaResearchTeam> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_RESEARCH_TEAM_AS_FACULTY_INFO key.
		///		FK_SA_RESEARCH_TEAM_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaResearchTeam objects.</returns>
		public TList<SaResearchTeam> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_RESEARCH_TEAM_AS_FACULTY_INFO key.
		///		fkSaResearchTeamAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaResearchTeam objects.</returns>
		public TList<SaResearchTeam> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_RESEARCH_TEAM_AS_FACULTY_INFO key.
		///		fkSaResearchTeamAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaResearchTeam objects.</returns>
		public TList<SaResearchTeam> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_RESEARCH_TEAM_AS_FACULTY_INFO key.
		///		FK_SA_RESEARCH_TEAM_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaResearchTeam objects.</returns>
		public abstract TList<SaResearchTeam> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_RESEARCH_TEAM_SA_CODE_RESEARCH_COOP key.
		///		FK_SA_RESEARCH_TEAM_SA_CODE_RESEARCH_COOP Description: 
		/// </summary>
		/// <param name="_saCodeResearchCoopId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaResearchTeam objects.</returns>
		public TList<SaResearchTeam> GetBySaCodeResearchCoopId(System.Decimal? _saCodeResearchCoopId)
		{
			int count = -1;
			return GetBySaCodeResearchCoopId(_saCodeResearchCoopId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_RESEARCH_TEAM_SA_CODE_RESEARCH_COOP key.
		///		FK_SA_RESEARCH_TEAM_SA_CODE_RESEARCH_COOP Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeResearchCoopId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaResearchTeam objects.</returns>
		/// <remarks></remarks>
		public TList<SaResearchTeam> GetBySaCodeResearchCoopId(TransactionManager transactionManager, System.Decimal? _saCodeResearchCoopId)
		{
			int count = -1;
			return GetBySaCodeResearchCoopId(transactionManager, _saCodeResearchCoopId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_RESEARCH_TEAM_SA_CODE_RESEARCH_COOP key.
		///		FK_SA_RESEARCH_TEAM_SA_CODE_RESEARCH_COOP Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeResearchCoopId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaResearchTeam objects.</returns>
		public TList<SaResearchTeam> GetBySaCodeResearchCoopId(TransactionManager transactionManager, System.Decimal? _saCodeResearchCoopId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeResearchCoopId(transactionManager, _saCodeResearchCoopId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_RESEARCH_TEAM_SA_CODE_RESEARCH_COOP key.
		///		fkSaResearchTeamSaCodeResearchCoop Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeResearchCoopId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaResearchTeam objects.</returns>
		public TList<SaResearchTeam> GetBySaCodeResearchCoopId(System.Decimal? _saCodeResearchCoopId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaCodeResearchCoopId(null, _saCodeResearchCoopId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_RESEARCH_TEAM_SA_CODE_RESEARCH_COOP key.
		///		fkSaResearchTeamSaCodeResearchCoop Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeResearchCoopId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaResearchTeam objects.</returns>
		public TList<SaResearchTeam> GetBySaCodeResearchCoopId(System.Decimal? _saCodeResearchCoopId, int start, int pageLength,out int count)
		{
			return GetBySaCodeResearchCoopId(null, _saCodeResearchCoopId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_RESEARCH_TEAM_SA_CODE_RESEARCH_COOP key.
		///		FK_SA_RESEARCH_TEAM_SA_CODE_RESEARCH_COOP Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeResearchCoopId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaResearchTeam objects.</returns>
		public abstract TList<SaResearchTeam> GetBySaCodeResearchCoopId(TransactionManager transactionManager, System.Decimal? _saCodeResearchCoopId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_RESEARCH_TEAM_SA_STF_MEMBER key.
		///		FK_SA_RESEARCH_TEAM_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaResearchTeam objects.</returns>
		public TList<SaResearchTeam> GetBySaStfMemberId(System.Decimal? _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_RESEARCH_TEAM_SA_STF_MEMBER key.
		///		FK_SA_RESEARCH_TEAM_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaResearchTeam objects.</returns>
		/// <remarks></remarks>
		public TList<SaResearchTeam> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_RESEARCH_TEAM_SA_STF_MEMBER key.
		///		FK_SA_RESEARCH_TEAM_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaResearchTeam objects.</returns>
		public TList<SaResearchTeam> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_RESEARCH_TEAM_SA_STF_MEMBER key.
		///		fkSaResearchTeamSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaResearchTeam objects.</returns>
		public TList<SaResearchTeam> GetBySaStfMemberId(System.Decimal? _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_RESEARCH_TEAM_SA_STF_MEMBER key.
		///		fkSaResearchTeamSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaResearchTeam objects.</returns>
		public TList<SaResearchTeam> GetBySaStfMemberId(System.Decimal? _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_RESEARCH_TEAM_SA_STF_MEMBER key.
		///		FK_SA_RESEARCH_TEAM_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaResearchTeam objects.</returns>
		public abstract TList<SaResearchTeam> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SaResearchTeam Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaResearchTeamKey key, int start, int pageLength)
		{
			return GetBySaResearchTeamId(transactionManager, key.SaResearchTeamId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_RESEARCH_TEAM index.
		/// </summary>
		/// <param name="_saResearchTeamId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaResearchTeam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaResearchTeam GetBySaResearchTeamId(System.Decimal _saResearchTeamId)
		{
			int count = -1;
			return GetBySaResearchTeamId(null,_saResearchTeamId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_RESEARCH_TEAM index.
		/// </summary>
		/// <param name="_saResearchTeamId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaResearchTeam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaResearchTeam GetBySaResearchTeamId(System.Decimal _saResearchTeamId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaResearchTeamId(null, _saResearchTeamId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_RESEARCH_TEAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saResearchTeamId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaResearchTeam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaResearchTeam GetBySaResearchTeamId(TransactionManager transactionManager, System.Decimal _saResearchTeamId)
		{
			int count = -1;
			return GetBySaResearchTeamId(transactionManager, _saResearchTeamId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_RESEARCH_TEAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saResearchTeamId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaResearchTeam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaResearchTeam GetBySaResearchTeamId(TransactionManager transactionManager, System.Decimal _saResearchTeamId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaResearchTeamId(transactionManager, _saResearchTeamId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_RESEARCH_TEAM index.
		/// </summary>
		/// <param name="_saResearchTeamId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaResearchTeam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaResearchTeam GetBySaResearchTeamId(System.Decimal _saResearchTeamId, int start, int pageLength, out int count)
		{
			return GetBySaResearchTeamId(null, _saResearchTeamId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_RESEARCH_TEAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saResearchTeamId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaResearchTeam"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaResearchTeam GetBySaResearchTeamId(TransactionManager transactionManager, System.Decimal _saResearchTeamId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaResearchTeam&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaResearchTeam&gt;"/></returns>
		public static TList<SaResearchTeam> Fill(IDataReader reader, TList<SaResearchTeam> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaResearchTeam c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaResearchTeam")
					.Append("|").Append((System.Decimal)reader["SA_RESEARCH_TEAM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaResearchTeam>(
					key.ToString(), // EntityTrackingKey
					"SaResearchTeam",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaResearchTeam();
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
					c.SaResearchTeamId = (System.Decimal)reader["SA_RESEARCH_TEAM_ID"];
					c.OriginalSaResearchTeamId = c.SaResearchTeamId;
					c.ResearcherType = (System.Decimal)reader["RESEARCHER_TYPE"];
					c.SaStfMemberId = Convert.IsDBNull(reader["SA_STF_MEMBER_ID"]) ? null : (System.Decimal?)reader["SA_STF_MEMBER_ID"];
					c.SaScResearchId = (System.Decimal)reader["SA_SC_RESEARCH_ID"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.ResearcherExName = Convert.IsDBNull(reader["RESEARCHER_EX_NAME"]) ? null : (System.String)reader["RESEARCHER_EX_NAME"];
					c.ResearcherPostStudId = Convert.IsDBNull(reader["RESEARCHER_POST_STUD_ID"]) ? null : (System.Decimal?)reader["RESEARCHER_POST_STUD_ID"];
					c.SaCodeResearchCoopId = Convert.IsDBNull(reader["SA_CODE_RESEARCH_COOP_ID"]) ? null : (System.Decimal?)reader["SA_CODE_RESEARCH_COOP_ID"];
					c.SaCodeScDegId = Convert.IsDBNull(reader["SA_CODE_SC_DEG_ID"]) ? null : (System.Decimal?)reader["SA_CODE_SC_DEG_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaResearchTeam"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaResearchTeam"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaResearchTeam entity)
		{
			if (!reader.Read()) return;
			
			entity.SaResearchTeamId = (System.Decimal)reader[((int)SaResearchTeamColumn.SaResearchTeamId - 1)];
			entity.OriginalSaResearchTeamId = (System.Decimal)reader["SA_RESEARCH_TEAM_ID"];
			entity.ResearcherType = (System.Decimal)reader[((int)SaResearchTeamColumn.ResearcherType - 1)];
			entity.SaStfMemberId = (reader.IsDBNull(((int)SaResearchTeamColumn.SaStfMemberId - 1)))?null:(System.Decimal?)reader[((int)SaResearchTeamColumn.SaStfMemberId - 1)];
			entity.SaScResearchId = (System.Decimal)reader[((int)SaResearchTeamColumn.SaScResearchId - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)SaResearchTeamColumn.AsFacultyInfoId - 1)];
			entity.ResearcherExName = (reader.IsDBNull(((int)SaResearchTeamColumn.ResearcherExName - 1)))?null:(System.String)reader[((int)SaResearchTeamColumn.ResearcherExName - 1)];
			entity.ResearcherPostStudId = (reader.IsDBNull(((int)SaResearchTeamColumn.ResearcherPostStudId - 1)))?null:(System.Decimal?)reader[((int)SaResearchTeamColumn.ResearcherPostStudId - 1)];
			entity.SaCodeResearchCoopId = (reader.IsDBNull(((int)SaResearchTeamColumn.SaCodeResearchCoopId - 1)))?null:(System.Decimal?)reader[((int)SaResearchTeamColumn.SaCodeResearchCoopId - 1)];
			entity.SaCodeScDegId = (reader.IsDBNull(((int)SaResearchTeamColumn.SaCodeScDegId - 1)))?null:(System.Decimal?)reader[((int)SaResearchTeamColumn.SaCodeScDegId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaResearchTeam"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaResearchTeam"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaResearchTeam entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaResearchTeamId = (System.Decimal)dataRow["SA_RESEARCH_TEAM_ID"];
			entity.OriginalSaResearchTeamId = (System.Decimal)dataRow["SA_RESEARCH_TEAM_ID"];
			entity.ResearcherType = (System.Decimal)dataRow["RESEARCHER_TYPE"];
			entity.SaStfMemberId = Convert.IsDBNull(dataRow["SA_STF_MEMBER_ID"]) ? null : (System.Decimal?)dataRow["SA_STF_MEMBER_ID"];
			entity.SaScResearchId = (System.Decimal)dataRow["SA_SC_RESEARCH_ID"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
			entity.ResearcherExName = Convert.IsDBNull(dataRow["RESEARCHER_EX_NAME"]) ? null : (System.String)dataRow["RESEARCHER_EX_NAME"];
			entity.ResearcherPostStudId = Convert.IsDBNull(dataRow["RESEARCHER_POST_STUD_ID"]) ? null : (System.Decimal?)dataRow["RESEARCHER_POST_STUD_ID"];
			entity.SaCodeResearchCoopId = Convert.IsDBNull(dataRow["SA_CODE_RESEARCH_COOP_ID"]) ? null : (System.Decimal?)dataRow["SA_CODE_RESEARCH_COOP_ID"];
			entity.SaCodeScDegId = Convert.IsDBNull(dataRow["SA_CODE_SC_DEG_ID"]) ? null : (System.Decimal?)dataRow["SA_CODE_SC_DEG_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaResearchTeam"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaResearchTeam Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaResearchTeam entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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

			#region SaScResearchIdSource	
			if (CanDeepLoad(entity, "SaScResearch|SaScResearchIdSource", deepLoadType, innerList) 
				&& entity.SaScResearchIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaScResearchId;
				SaScResearch tmpEntity = EntityManager.LocateEntity<SaScResearch>(EntityLocator.ConstructKeyFromPkItems(typeof(SaScResearch), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaScResearchIdSource = tmpEntity;
				else
					entity.SaScResearchIdSource = DataRepository.SaScResearchProvider.GetBySaScResearchId(transactionManager, entity.SaScResearchId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaScResearchIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaScResearchIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaScResearchProvider.DeepLoad(transactionManager, entity.SaScResearchIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaScResearchIdSource

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

			#region SaCodeResearchCoopIdSource	
			if (CanDeepLoad(entity, "SaCodeResearchCoop|SaCodeResearchCoopIdSource", deepLoadType, innerList) 
				&& entity.SaCodeResearchCoopIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaCodeResearchCoopId ?? 0.0m);
				SaCodeResearchCoop tmpEntity = EntityManager.LocateEntity<SaCodeResearchCoop>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeResearchCoop), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeResearchCoopIdSource = tmpEntity;
				else
					entity.SaCodeResearchCoopIdSource = DataRepository.SaCodeResearchCoopProvider.GetBySaCodeResearchCooperId(transactionManager, (entity.SaCodeResearchCoopId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeResearchCoopIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodeResearchCoopIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeResearchCoopProvider.DeepLoad(transactionManager, entity.SaCodeResearchCoopIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodeResearchCoopIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaResearchTeam object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaResearchTeam instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaResearchTeam Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaResearchTeam entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region SaScResearchIdSource
			if (CanDeepSave(entity, "SaScResearch|SaScResearchIdSource", deepSaveType, innerList) 
				&& entity.SaScResearchIdSource != null)
			{
				DataRepository.SaScResearchProvider.Save(transactionManager, entity.SaScResearchIdSource);
				entity.SaScResearchId = entity.SaScResearchIdSource.SaScResearchId;
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
			
			#region SaCodeResearchCoopIdSource
			if (CanDeepSave(entity, "SaCodeResearchCoop|SaCodeResearchCoopIdSource", deepSaveType, innerList) 
				&& entity.SaCodeResearchCoopIdSource != null)
			{
				DataRepository.SaCodeResearchCoopProvider.Save(transactionManager, entity.SaCodeResearchCoopIdSource);
				entity.SaCodeResearchCoopId = entity.SaCodeResearchCoopIdSource.SaCodeResearchCooperId;
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
	
	#region SaResearchTeamChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaResearchTeam</c>
	///</summary>
	public enum SaResearchTeamChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SaCodeScDeg</c> at SaCodeScDegIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeScDeg))]
		SaCodeScDeg,
		
		///<summary>
		/// Composite Property for <c>SaScResearch</c> at SaScResearchIdSource
		///</summary>
		[ChildEntityType(typeof(SaScResearch))]
		SaScResearch,
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>SaCodeResearchCoop</c> at SaCodeResearchCoopIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeResearchCoop))]
		SaCodeResearchCoop,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
	}
	
	#endregion SaResearchTeamChildEntityTypes
	
	#region SaResearchTeamFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaResearchTeamColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaResearchTeam"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaResearchTeamFilterBuilder : SqlFilterBuilder<SaResearchTeamColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaResearchTeamFilterBuilder class.
		/// </summary>
		public SaResearchTeamFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaResearchTeamFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaResearchTeamFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaResearchTeamFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaResearchTeamFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaResearchTeamFilterBuilder
	
	#region SaResearchTeamParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaResearchTeamColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaResearchTeam"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaResearchTeamParameterBuilder : ParameterizedSqlFilterBuilder<SaResearchTeamColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaResearchTeamParameterBuilder class.
		/// </summary>
		public SaResearchTeamParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaResearchTeamParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaResearchTeamParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaResearchTeamParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaResearchTeamParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaResearchTeamParameterBuilder
	
	#region SaResearchTeamSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaResearchTeamColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaResearchTeam"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaResearchTeamSortBuilder : SqlSortBuilder<SaResearchTeamColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaResearchTeamSqlSortBuilder class.
		/// </summary>
		public SaResearchTeamSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaResearchTeamSortBuilder
	
} // end namespace
