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
	/// This class is the base class for any <see cref="SaScQualProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaScQualProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaScQual, UMIS_VER2.BusinessLyer.SaScQualKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaScQualKey key)
		{
			return Delete(transactionManager, key.SaScQualId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saScQualId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saScQualId)
		{
			return Delete(null, _saScQualId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saScQualId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saScQualId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_04cf key.
		///		FK_AUTO_04cf Description: 
		/// </summary>
		/// <param name="_saCodeRatingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public TList<SaScQual> GetBySaCodeRatingId(System.Decimal? _saCodeRatingId)
		{
			int count = -1;
			return GetBySaCodeRatingId(_saCodeRatingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_04cf key.
		///		FK_AUTO_04cf Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeRatingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		/// <remarks></remarks>
		public TList<SaScQual> GetBySaCodeRatingId(TransactionManager transactionManager, System.Decimal? _saCodeRatingId)
		{
			int count = -1;
			return GetBySaCodeRatingId(transactionManager, _saCodeRatingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_04cf key.
		///		FK_AUTO_04cf Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeRatingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public TList<SaScQual> GetBySaCodeRatingId(TransactionManager transactionManager, System.Decimal? _saCodeRatingId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeRatingId(transactionManager, _saCodeRatingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_04cf key.
		///		fkAuto04cf Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeRatingId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public TList<SaScQual> GetBySaCodeRatingId(System.Decimal? _saCodeRatingId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaCodeRatingId(null, _saCodeRatingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_04cf key.
		///		fkAuto04cf Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeRatingId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public TList<SaScQual> GetBySaCodeRatingId(System.Decimal? _saCodeRatingId, int start, int pageLength,out int count)
		{
			return GetBySaCodeRatingId(null, _saCodeRatingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_04cf key.
		///		FK_AUTO_04cf Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeRatingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public abstract TList<SaScQual> GetBySaCodeRatingId(TransactionManager transactionManager, System.Decimal? _saCodeRatingId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_04d0 key.
		///		FK_AUTO_04d0 Description: 
		/// </summary>
		/// <param name="_saCodeRatingId2"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public TList<SaScQual> GetBySaCodeRatingId2(System.Decimal? _saCodeRatingId2)
		{
			int count = -1;
			return GetBySaCodeRatingId2(_saCodeRatingId2, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_04d0 key.
		///		FK_AUTO_04d0 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeRatingId2"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		/// <remarks></remarks>
		public TList<SaScQual> GetBySaCodeRatingId2(TransactionManager transactionManager, System.Decimal? _saCodeRatingId2)
		{
			int count = -1;
			return GetBySaCodeRatingId2(transactionManager, _saCodeRatingId2, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_04d0 key.
		///		FK_AUTO_04d0 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeRatingId2"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public TList<SaScQual> GetBySaCodeRatingId2(TransactionManager transactionManager, System.Decimal? _saCodeRatingId2, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeRatingId2(transactionManager, _saCodeRatingId2, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_04d0 key.
		///		fkAuto04d0 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeRatingId2"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public TList<SaScQual> GetBySaCodeRatingId2(System.Decimal? _saCodeRatingId2, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaCodeRatingId2(null, _saCodeRatingId2, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_04d0 key.
		///		fkAuto04d0 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeRatingId2"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public TList<SaScQual> GetBySaCodeRatingId2(System.Decimal? _saCodeRatingId2, int start, int pageLength,out int count)
		{
			return GetBySaCodeRatingId2(null, _saCodeRatingId2, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_04d0 key.
		///		FK_AUTO_04d0 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeRatingId2"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public abstract TList<SaScQual> GetBySaCodeRatingId2(TransactionManager transactionManager, System.Decimal? _saCodeRatingId2, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_QUAL_AS_CODE_DEGREE key.
		///		FK_SA_SC_QUAL_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="_asCodeDegreeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public TList<SaScQual> GetByAsCodeDegreeId(System.Decimal _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(_asCodeDegreeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_QUAL_AS_CODE_DEGREE key.
		///		FK_SA_SC_QUAL_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		/// <remarks></remarks>
		public TList<SaScQual> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_QUAL_AS_CODE_DEGREE key.
		///		FK_SA_SC_QUAL_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public TList<SaScQual> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal _asCodeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_QUAL_AS_CODE_DEGREE key.
		///		fkSaScQualAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public TList<SaScQual> GetByAsCodeDegreeId(System.Decimal _asCodeDegreeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_QUAL_AS_CODE_DEGREE key.
		///		fkSaScQualAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public TList<SaScQual> GetByAsCodeDegreeId(System.Decimal _asCodeDegreeId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_QUAL_AS_CODE_DEGREE key.
		///		FK_SA_SC_QUAL_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public abstract TList<SaScQual> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal _asCodeDegreeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_QUAL_AS_FACULTY_INFO key.
		///		FK_SA_SC_QUAL_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public TList<SaScQual> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_QUAL_AS_FACULTY_INFO key.
		///		FK_SA_SC_QUAL_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		/// <remarks></remarks>
		public TList<SaScQual> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_QUAL_AS_FACULTY_INFO key.
		///		FK_SA_SC_QUAL_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public TList<SaScQual> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_QUAL_AS_FACULTY_INFO key.
		///		fkSaScQualAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public TList<SaScQual> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_QUAL_AS_FACULTY_INFO key.
		///		fkSaScQualAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public TList<SaScQual> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_QUAL_AS_FACULTY_INFO key.
		///		FK_SA_SC_QUAL_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public abstract TList<SaScQual> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_QUAL_ENTITY_MAIN key.
		///		FK_SA_SC_QUAL_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_asNodeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public TList<SaScQual> GetByAsNodeId(System.Decimal _asNodeId)
		{
			int count = -1;
			return GetByAsNodeId(_asNodeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_QUAL_ENTITY_MAIN key.
		///		FK_SA_SC_QUAL_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asNodeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		/// <remarks></remarks>
		public TList<SaScQual> GetByAsNodeId(TransactionManager transactionManager, System.Decimal _asNodeId)
		{
			int count = -1;
			return GetByAsNodeId(transactionManager, _asNodeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_QUAL_ENTITY_MAIN key.
		///		FK_SA_SC_QUAL_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public TList<SaScQual> GetByAsNodeId(TransactionManager transactionManager, System.Decimal _asNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsNodeId(transactionManager, _asNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_QUAL_ENTITY_MAIN key.
		///		fkSaScQualEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asNodeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public TList<SaScQual> GetByAsNodeId(System.Decimal _asNodeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsNodeId(null, _asNodeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_QUAL_ENTITY_MAIN key.
		///		fkSaScQualEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asNodeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public TList<SaScQual> GetByAsNodeId(System.Decimal _asNodeId, int start, int pageLength,out int count)
		{
			return GetByAsNodeId(null, _asNodeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_QUAL_ENTITY_MAIN key.
		///		FK_SA_SC_QUAL_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public abstract TList<SaScQual> GetByAsNodeId(TransactionManager transactionManager, System.Decimal _asNodeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_QUAL_PG_THESIS_DETAILED_SPEC key.
		///		FK_SA_SC_QUAL_PG_THESIS_DETAILED_SPEC Description: 
		/// </summary>
		/// <param name="_pgThesisDetailedSpecId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public TList<SaScQual> GetByPgThesisDetailedSpecId(System.Decimal? _pgThesisDetailedSpecId)
		{
			int count = -1;
			return GetByPgThesisDetailedSpecId(_pgThesisDetailedSpecId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_QUAL_PG_THESIS_DETAILED_SPEC key.
		///		FK_SA_SC_QUAL_PG_THESIS_DETAILED_SPEC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisDetailedSpecId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		/// <remarks></remarks>
		public TList<SaScQual> GetByPgThesisDetailedSpecId(TransactionManager transactionManager, System.Decimal? _pgThesisDetailedSpecId)
		{
			int count = -1;
			return GetByPgThesisDetailedSpecId(transactionManager, _pgThesisDetailedSpecId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_QUAL_PG_THESIS_DETAILED_SPEC key.
		///		FK_SA_SC_QUAL_PG_THESIS_DETAILED_SPEC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisDetailedSpecId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public TList<SaScQual> GetByPgThesisDetailedSpecId(TransactionManager transactionManager, System.Decimal? _pgThesisDetailedSpecId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisDetailedSpecId(transactionManager, _pgThesisDetailedSpecId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_QUAL_PG_THESIS_DETAILED_SPEC key.
		///		fkSaScQualPgThesisDetailedSpec Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisDetailedSpecId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public TList<SaScQual> GetByPgThesisDetailedSpecId(System.Decimal? _pgThesisDetailedSpecId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisDetailedSpecId(null, _pgThesisDetailedSpecId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_QUAL_PG_THESIS_DETAILED_SPEC key.
		///		fkSaScQualPgThesisDetailedSpec Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisDetailedSpecId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public TList<SaScQual> GetByPgThesisDetailedSpecId(System.Decimal? _pgThesisDetailedSpecId, int start, int pageLength,out int count)
		{
			return GetByPgThesisDetailedSpecId(null, _pgThesisDetailedSpecId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_QUAL_PG_THESIS_DETAILED_SPEC key.
		///		FK_SA_SC_QUAL_PG_THESIS_DETAILED_SPEC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisDetailedSpecId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public abstract TList<SaScQual> GetByPgThesisDetailedSpecId(TransactionManager transactionManager, System.Decimal? _pgThesisDetailedSpecId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_QUAL_PG_THESIS_GENERAL_SPEC key.
		///		FK_SA_SC_QUAL_PG_THESIS_GENERAL_SPEC Description: 
		/// </summary>
		/// <param name="_pgThesisGeneralSpecId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public TList<SaScQual> GetByPgThesisGeneralSpecId(System.Decimal? _pgThesisGeneralSpecId)
		{
			int count = -1;
			return GetByPgThesisGeneralSpecId(_pgThesisGeneralSpecId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_QUAL_PG_THESIS_GENERAL_SPEC key.
		///		FK_SA_SC_QUAL_PG_THESIS_GENERAL_SPEC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisGeneralSpecId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		/// <remarks></remarks>
		public TList<SaScQual> GetByPgThesisGeneralSpecId(TransactionManager transactionManager, System.Decimal? _pgThesisGeneralSpecId)
		{
			int count = -1;
			return GetByPgThesisGeneralSpecId(transactionManager, _pgThesisGeneralSpecId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_QUAL_PG_THESIS_GENERAL_SPEC key.
		///		FK_SA_SC_QUAL_PG_THESIS_GENERAL_SPEC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisGeneralSpecId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public TList<SaScQual> GetByPgThesisGeneralSpecId(TransactionManager transactionManager, System.Decimal? _pgThesisGeneralSpecId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisGeneralSpecId(transactionManager, _pgThesisGeneralSpecId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_QUAL_PG_THESIS_GENERAL_SPEC key.
		///		fkSaScQualPgThesisGeneralSpec Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisGeneralSpecId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public TList<SaScQual> GetByPgThesisGeneralSpecId(System.Decimal? _pgThesisGeneralSpecId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisGeneralSpecId(null, _pgThesisGeneralSpecId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_QUAL_PG_THESIS_GENERAL_SPEC key.
		///		fkSaScQualPgThesisGeneralSpec Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisGeneralSpecId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public TList<SaScQual> GetByPgThesisGeneralSpecId(System.Decimal? _pgThesisGeneralSpecId, int start, int pageLength,out int count)
		{
			return GetByPgThesisGeneralSpecId(null, _pgThesisGeneralSpecId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_QUAL_PG_THESIS_GENERAL_SPEC key.
		///		FK_SA_SC_QUAL_PG_THESIS_GENERAL_SPEC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisGeneralSpecId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public abstract TList<SaScQual> GetByPgThesisGeneralSpecId(TransactionManager transactionManager, System.Decimal? _pgThesisGeneralSpecId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_QUAL_SA_STF_MEMBER key.
		///		FK_SA_SC_QUAL_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public TList<SaScQual> GetBySaStfMemberId(System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_QUAL_SA_STF_MEMBER key.
		///		FK_SA_SC_QUAL_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		/// <remarks></remarks>
		public TList<SaScQual> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_QUAL_SA_STF_MEMBER key.
		///		FK_SA_SC_QUAL_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public TList<SaScQual> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_QUAL_SA_STF_MEMBER key.
		///		fkSaScQualSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public TList<SaScQual> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_QUAL_SA_STF_MEMBER key.
		///		fkSaScQualSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public TList<SaScQual> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_QUAL_SA_STF_MEMBER key.
		///		FK_SA_SC_QUAL_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScQual objects.</returns>
		public abstract TList<SaScQual> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SaScQual Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaScQualKey key, int start, int pageLength)
		{
			return GetBySaScQualId(transactionManager, key.SaScQualId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_SC_QUAL index.
		/// </summary>
		/// <param name="_saScQualId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaScQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaScQual GetBySaScQualId(System.Decimal _saScQualId)
		{
			int count = -1;
			return GetBySaScQualId(null,_saScQualId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_SC_QUAL index.
		/// </summary>
		/// <param name="_saScQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaScQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaScQual GetBySaScQualId(System.Decimal _saScQualId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaScQualId(null, _saScQualId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_SC_QUAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saScQualId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaScQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaScQual GetBySaScQualId(TransactionManager transactionManager, System.Decimal _saScQualId)
		{
			int count = -1;
			return GetBySaScQualId(transactionManager, _saScQualId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_SC_QUAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saScQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaScQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaScQual GetBySaScQualId(TransactionManager transactionManager, System.Decimal _saScQualId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaScQualId(transactionManager, _saScQualId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_SC_QUAL index.
		/// </summary>
		/// <param name="_saScQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaScQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaScQual GetBySaScQualId(System.Decimal _saScQualId, int start, int pageLength, out int count)
		{
			return GetBySaScQualId(null, _saScQualId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_SC_QUAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saScQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaScQual"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaScQual GetBySaScQualId(TransactionManager transactionManager, System.Decimal _saScQualId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaScQual&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaScQual&gt;"/></returns>
		public static TList<SaScQual> Fill(IDataReader reader, TList<SaScQual> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaScQual c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaScQual")
					.Append("|").Append((System.Decimal)reader["SA_SC_QUAL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaScQual>(
					key.ToString(), // EntityTrackingKey
					"SaScQual",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaScQual();
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
					c.SaScQualId = (System.Decimal)reader["SA_SC_QUAL_ID"];
					c.OriginalSaScQualId = c.SaScQualId;
					c.ScDegDate = (System.DateTime)reader["SC_DEG_DATE"];
					c.ScDegValidTil = Convert.IsDBNull(reader["SC_DEG_VALID_TIL"]) ? null : (System.DateTime?)reader["SC_DEG_VALID_TIL"];
					c.Round = Convert.IsDBNull(reader["ROUND"]) ? null : (System.String)reader["ROUND"];
					c.ThesisTitleAr = Convert.IsDBNull(reader["THESIS_TITLE_AR"]) ? null : (System.String)reader["THESIS_TITLE_AR"];
					c.ThesisTitleEn = Convert.IsDBNull(reader["THESIS_TITLE_EN"]) ? null : (System.String)reader["THESIS_TITLE_EN"];
					c.ThesisTopicAr = Convert.IsDBNull(reader["THESIS_TOPIC_AR"]) ? null : (System.String)reader["THESIS_TOPIC_AR"];
					c.ThesisTopicEn = Convert.IsDBNull(reader["THESIS_TOPIC_EN"]) ? null : (System.String)reader["THESIS_TOPIC_EN"];
					c.SpecSub = Convert.IsDBNull(reader["SPEC_SUB"]) ? null : (System.String)reader["SPEC_SUB"];
					c.IsComplementry = Convert.IsDBNull(reader["IS_COMPLEMENTRY"]) ? null : (System.Decimal?)reader["IS_COMPLEMENTRY"];
					c.Comments = Convert.IsDBNull(reader["COMMENTS"]) ? null : (System.String)reader["COMMENTS"];
					c.SaStfMemberId = (System.Decimal)reader["SA_STF_MEMBER_ID"];
					c.SaCodeRatingId = Convert.IsDBNull(reader["SA_CODE_RATING_ID"]) ? null : (System.Decimal?)reader["SA_CODE_RATING_ID"];
					c.SaCodeRatingId2 = Convert.IsDBNull(reader["SA_CODE_RATING_ID2"]) ? null : (System.Decimal?)reader["SA_CODE_RATING_ID2"];
					c.GsCountryNodeId = Convert.IsDBNull(reader["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)reader["GS_COUNTRY_NODE_ID"];
					c.AsCodeDegreeId = (System.Decimal)reader["AS_CODE_DEGREE_ID"];
					c.AsNodeId = (System.Decimal)reader["AS_NODE_ID"];
					c.PgThesisDetailedSpecId = Convert.IsDBNull(reader["PG_THESIS_DETAILED_SPEC_ID"]) ? null : (System.Decimal?)reader["PG_THESIS_DETAILED_SPEC_ID"];
					c.PgThesisGeneralSpecId = Convert.IsDBNull(reader["PG_THESIS_GENERAL_SPEC_ID"]) ? null : (System.Decimal?)reader["PG_THESIS_GENERAL_SPEC_ID"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaScQual"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaScQual"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaScQual entity)
		{
			if (!reader.Read()) return;
			
			entity.SaScQualId = (System.Decimal)reader[((int)SaScQualColumn.SaScQualId - 1)];
			entity.OriginalSaScQualId = (System.Decimal)reader["SA_SC_QUAL_ID"];
			entity.ScDegDate = (System.DateTime)reader[((int)SaScQualColumn.ScDegDate - 1)];
			entity.ScDegValidTil = (reader.IsDBNull(((int)SaScQualColumn.ScDegValidTil - 1)))?null:(System.DateTime?)reader[((int)SaScQualColumn.ScDegValidTil - 1)];
			entity.Round = (reader.IsDBNull(((int)SaScQualColumn.Round - 1)))?null:(System.String)reader[((int)SaScQualColumn.Round - 1)];
			entity.ThesisTitleAr = (reader.IsDBNull(((int)SaScQualColumn.ThesisTitleAr - 1)))?null:(System.String)reader[((int)SaScQualColumn.ThesisTitleAr - 1)];
			entity.ThesisTitleEn = (reader.IsDBNull(((int)SaScQualColumn.ThesisTitleEn - 1)))?null:(System.String)reader[((int)SaScQualColumn.ThesisTitleEn - 1)];
			entity.ThesisTopicAr = (reader.IsDBNull(((int)SaScQualColumn.ThesisTopicAr - 1)))?null:(System.String)reader[((int)SaScQualColumn.ThesisTopicAr - 1)];
			entity.ThesisTopicEn = (reader.IsDBNull(((int)SaScQualColumn.ThesisTopicEn - 1)))?null:(System.String)reader[((int)SaScQualColumn.ThesisTopicEn - 1)];
			entity.SpecSub = (reader.IsDBNull(((int)SaScQualColumn.SpecSub - 1)))?null:(System.String)reader[((int)SaScQualColumn.SpecSub - 1)];
			entity.IsComplementry = (reader.IsDBNull(((int)SaScQualColumn.IsComplementry - 1)))?null:(System.Decimal?)reader[((int)SaScQualColumn.IsComplementry - 1)];
			entity.Comments = (reader.IsDBNull(((int)SaScQualColumn.Comments - 1)))?null:(System.String)reader[((int)SaScQualColumn.Comments - 1)];
			entity.SaStfMemberId = (System.Decimal)reader[((int)SaScQualColumn.SaStfMemberId - 1)];
			entity.SaCodeRatingId = (reader.IsDBNull(((int)SaScQualColumn.SaCodeRatingId - 1)))?null:(System.Decimal?)reader[((int)SaScQualColumn.SaCodeRatingId - 1)];
			entity.SaCodeRatingId2 = (reader.IsDBNull(((int)SaScQualColumn.SaCodeRatingId2 - 1)))?null:(System.Decimal?)reader[((int)SaScQualColumn.SaCodeRatingId2 - 1)];
			entity.GsCountryNodeId = (reader.IsDBNull(((int)SaScQualColumn.GsCountryNodeId - 1)))?null:(System.Decimal?)reader[((int)SaScQualColumn.GsCountryNodeId - 1)];
			entity.AsCodeDegreeId = (System.Decimal)reader[((int)SaScQualColumn.AsCodeDegreeId - 1)];
			entity.AsNodeId = (System.Decimal)reader[((int)SaScQualColumn.AsNodeId - 1)];
			entity.PgThesisDetailedSpecId = (reader.IsDBNull(((int)SaScQualColumn.PgThesisDetailedSpecId - 1)))?null:(System.Decimal?)reader[((int)SaScQualColumn.PgThesisDetailedSpecId - 1)];
			entity.PgThesisGeneralSpecId = (reader.IsDBNull(((int)SaScQualColumn.PgThesisGeneralSpecId - 1)))?null:(System.Decimal?)reader[((int)SaScQualColumn.PgThesisGeneralSpecId - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)SaScQualColumn.AsFacultyInfoId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaScQual"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaScQual"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaScQual entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaScQualId = (System.Decimal)dataRow["SA_SC_QUAL_ID"];
			entity.OriginalSaScQualId = (System.Decimal)dataRow["SA_SC_QUAL_ID"];
			entity.ScDegDate = (System.DateTime)dataRow["SC_DEG_DATE"];
			entity.ScDegValidTil = Convert.IsDBNull(dataRow["SC_DEG_VALID_TIL"]) ? null : (System.DateTime?)dataRow["SC_DEG_VALID_TIL"];
			entity.Round = Convert.IsDBNull(dataRow["ROUND"]) ? null : (System.String)dataRow["ROUND"];
			entity.ThesisTitleAr = Convert.IsDBNull(dataRow["THESIS_TITLE_AR"]) ? null : (System.String)dataRow["THESIS_TITLE_AR"];
			entity.ThesisTitleEn = Convert.IsDBNull(dataRow["THESIS_TITLE_EN"]) ? null : (System.String)dataRow["THESIS_TITLE_EN"];
			entity.ThesisTopicAr = Convert.IsDBNull(dataRow["THESIS_TOPIC_AR"]) ? null : (System.String)dataRow["THESIS_TOPIC_AR"];
			entity.ThesisTopicEn = Convert.IsDBNull(dataRow["THESIS_TOPIC_EN"]) ? null : (System.String)dataRow["THESIS_TOPIC_EN"];
			entity.SpecSub = Convert.IsDBNull(dataRow["SPEC_SUB"]) ? null : (System.String)dataRow["SPEC_SUB"];
			entity.IsComplementry = Convert.IsDBNull(dataRow["IS_COMPLEMENTRY"]) ? null : (System.Decimal?)dataRow["IS_COMPLEMENTRY"];
			entity.Comments = Convert.IsDBNull(dataRow["COMMENTS"]) ? null : (System.String)dataRow["COMMENTS"];
			entity.SaStfMemberId = (System.Decimal)dataRow["SA_STF_MEMBER_ID"];
			entity.SaCodeRatingId = Convert.IsDBNull(dataRow["SA_CODE_RATING_ID"]) ? null : (System.Decimal?)dataRow["SA_CODE_RATING_ID"];
			entity.SaCodeRatingId2 = Convert.IsDBNull(dataRow["SA_CODE_RATING_ID2"]) ? null : (System.Decimal?)dataRow["SA_CODE_RATING_ID2"];
			entity.GsCountryNodeId = Convert.IsDBNull(dataRow["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)dataRow["GS_COUNTRY_NODE_ID"];
			entity.AsCodeDegreeId = (System.Decimal)dataRow["AS_CODE_DEGREE_ID"];
			entity.AsNodeId = (System.Decimal)dataRow["AS_NODE_ID"];
			entity.PgThesisDetailedSpecId = Convert.IsDBNull(dataRow["PG_THESIS_DETAILED_SPEC_ID"]) ? null : (System.Decimal?)dataRow["PG_THESIS_DETAILED_SPEC_ID"];
			entity.PgThesisGeneralSpecId = Convert.IsDBNull(dataRow["PG_THESIS_GENERAL_SPEC_ID"]) ? null : (System.Decimal?)dataRow["PG_THESIS_GENERAL_SPEC_ID"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaScQual"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaScQual Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaScQual entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SaCodeRatingIdSource	
			if (CanDeepLoad(entity, "SaCodeRating|SaCodeRatingIdSource", deepLoadType, innerList) 
				&& entity.SaCodeRatingIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaCodeRatingId ?? 0.0m);
				SaCodeRating tmpEntity = EntityManager.LocateEntity<SaCodeRating>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeRating), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeRatingIdSource = tmpEntity;
				else
					entity.SaCodeRatingIdSource = DataRepository.SaCodeRatingProvider.GetBySaCodeRatingId(transactionManager, (entity.SaCodeRatingId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeRatingIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodeRatingIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeRatingProvider.DeepLoad(transactionManager, entity.SaCodeRatingIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodeRatingIdSource

			#region SaCodeRatingId2Source	
			if (CanDeepLoad(entity, "SaCodeRating|SaCodeRatingId2Source", deepLoadType, innerList) 
				&& entity.SaCodeRatingId2Source == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaCodeRatingId2 ?? 0.0m);
				SaCodeRating tmpEntity = EntityManager.LocateEntity<SaCodeRating>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeRating), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeRatingId2Source = tmpEntity;
				else
					entity.SaCodeRatingId2Source = DataRepository.SaCodeRatingProvider.GetBySaCodeRatingId(transactionManager, (entity.SaCodeRatingId2 ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeRatingId2Source' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodeRatingId2Source != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeRatingProvider.DeepLoad(transactionManager, entity.SaCodeRatingId2Source, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodeRatingId2Source

			#region AsCodeDegreeIdSource	
			if (CanDeepLoad(entity, "AsCodeDegree|AsCodeDegreeIdSource", deepLoadType, innerList) 
				&& entity.AsCodeDegreeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AsCodeDegreeId;
				AsCodeDegree tmpEntity = EntityManager.LocateEntity<AsCodeDegree>(EntityLocator.ConstructKeyFromPkItems(typeof(AsCodeDegree), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsCodeDegreeIdSource = tmpEntity;
				else
					entity.AsCodeDegreeIdSource = DataRepository.AsCodeDegreeProvider.GetByAsCodeDegreeId(transactionManager, entity.AsCodeDegreeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsCodeDegreeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsCodeDegreeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsCodeDegreeProvider.DeepLoad(transactionManager, entity.AsCodeDegreeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsCodeDegreeIdSource

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

			#region AsNodeIdSource	
			if (CanDeepLoad(entity, "EntityMain|AsNodeIdSource", deepLoadType, innerList) 
				&& entity.AsNodeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AsNodeId;
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsNodeIdSource = tmpEntity;
				else
					entity.AsNodeIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, entity.AsNodeId);		
				
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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySaScQualId methods when available
			
			#region SaEmploymentCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaEmployment>|SaEmploymentCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaEmploymentCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaEmploymentCollection = DataRepository.SaEmploymentProvider.GetBySaScQualId(transactionManager, entity.SaScQualId);

				if (deep && entity.SaEmploymentCollection.Count > 0)
				{
					deepHandles.Add("SaEmploymentCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaEmployment>) DataRepository.SaEmploymentProvider.DeepLoad,
						new object[] { transactionManager, entity.SaEmploymentCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaScQual object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaScQual instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaScQual Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaScQual entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SaCodeRatingIdSource
			if (CanDeepSave(entity, "SaCodeRating|SaCodeRatingIdSource", deepSaveType, innerList) 
				&& entity.SaCodeRatingIdSource != null)
			{
				DataRepository.SaCodeRatingProvider.Save(transactionManager, entity.SaCodeRatingIdSource);
				entity.SaCodeRatingId = entity.SaCodeRatingIdSource.SaCodeRatingId;
			}
			#endregion 
			
			#region SaCodeRatingId2Source
			if (CanDeepSave(entity, "SaCodeRating|SaCodeRatingId2Source", deepSaveType, innerList) 
				&& entity.SaCodeRatingId2Source != null)
			{
				DataRepository.SaCodeRatingProvider.Save(transactionManager, entity.SaCodeRatingId2Source);
				entity.SaCodeRatingId2 = entity.SaCodeRatingId2Source.SaCodeRatingId;
			}
			#endregion 
			
			#region AsCodeDegreeIdSource
			if (CanDeepSave(entity, "AsCodeDegree|AsCodeDegreeIdSource", deepSaveType, innerList) 
				&& entity.AsCodeDegreeIdSource != null)
			{
				DataRepository.AsCodeDegreeProvider.Save(transactionManager, entity.AsCodeDegreeIdSource);
				entity.AsCodeDegreeId = entity.AsCodeDegreeIdSource.AsCodeDegreeId;
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
			
			#region PgThesisDetailedSpecIdSource
			if (CanDeepSave(entity, "PgThesisDetailedSpec|PgThesisDetailedSpecIdSource", deepSaveType, innerList) 
				&& entity.PgThesisDetailedSpecIdSource != null)
			{
				DataRepository.PgThesisDetailedSpecProvider.Save(transactionManager, entity.PgThesisDetailedSpecIdSource);
				entity.PgThesisDetailedSpecId = entity.PgThesisDetailedSpecIdSource.PgThesisDetailedSpecId;
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
	
			#region List<SaEmployment>
				if (CanDeepSave(entity.SaEmploymentCollection, "List<SaEmployment>|SaEmploymentCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaEmployment child in entity.SaEmploymentCollection)
					{
						if(child.SaScQualIdSource != null)
						{
							child.SaScQualId = child.SaScQualIdSource.SaScQualId;
						}
						else
						{
							child.SaScQualId = entity.SaScQualId;
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
	
	#region SaScQualChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaScQual</c>
	///</summary>
	public enum SaScQualChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SaCodeRating</c> at SaCodeRatingIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeRating))]
		SaCodeRating,
		
		///<summary>
		/// Composite Property for <c>AsCodeDegree</c> at AsCodeDegreeIdSource
		///</summary>
		[ChildEntityType(typeof(AsCodeDegree))]
		AsCodeDegree,
		
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
		/// Composite Property for <c>PgThesisDetailedSpec</c> at PgThesisDetailedSpecIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisDetailedSpec))]
		PgThesisDetailedSpec,
		
		///<summary>
		/// Composite Property for <c>PgThesisGeneralSpec</c> at PgThesisGeneralSpecIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisGeneralSpec))]
		PgThesisGeneralSpec,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
		///<summary>
		/// Collection of <c>SaScQual</c> as OneToMany for SaEmploymentCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaEmployment>))]
		SaEmploymentCollection,
	}
	
	#endregion SaScQualChildEntityTypes
	
	#region SaScQualFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaScQualColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaScQual"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaScQualFilterBuilder : SqlFilterBuilder<SaScQualColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaScQualFilterBuilder class.
		/// </summary>
		public SaScQualFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaScQualFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaScQualFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaScQualFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaScQualFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaScQualFilterBuilder
	
	#region SaScQualParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaScQualColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaScQual"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaScQualParameterBuilder : ParameterizedSqlFilterBuilder<SaScQualColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaScQualParameterBuilder class.
		/// </summary>
		public SaScQualParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaScQualParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaScQualParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaScQualParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaScQualParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaScQualParameterBuilder
	
	#region SaScQualSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaScQualColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaScQual"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaScQualSortBuilder : SqlSortBuilder<SaScQualColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaScQualSqlSortBuilder class.
		/// </summary>
		public SaScQualSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaScQualSortBuilder
	
} // end namespace
