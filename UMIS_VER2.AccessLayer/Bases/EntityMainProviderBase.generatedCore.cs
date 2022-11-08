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
	/// This class is the base class for any <see cref="EntityMainProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntityMainProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntityMain, UMIS_VER2.BusinessLyer.EntityMainKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntityMainKey key)
		{
			return Delete(transactionManager, key.EntMainId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entMainId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entMainId)
		{
			return Delete(null, _entMainId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entMainId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENTITY_MAIN_AS_CODE_DEGREE key.
		///		FK_ENTITY_MAIN_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="_asCodeDegreeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntityMain objects.</returns>
		public TList<EntityMain> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(_asCodeDegreeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENTITY_MAIN_AS_CODE_DEGREE key.
		///		FK_ENTITY_MAIN_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntityMain objects.</returns>
		/// <remarks></remarks>
		public TList<EntityMain> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENTITY_MAIN_AS_CODE_DEGREE key.
		///		FK_ENTITY_MAIN_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntityMain objects.</returns>
		public TList<EntityMain> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENTITY_MAIN_AS_CODE_DEGREE key.
		///		fkEntityMainAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntityMain objects.</returns>
		public TList<EntityMain> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENTITY_MAIN_AS_CODE_DEGREE key.
		///		fkEntityMainAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntityMain objects.</returns>
		public TList<EntityMain> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENTITY_MAIN_AS_CODE_DEGREE key.
		///		FK_ENTITY_MAIN_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntityMain objects.</returns>
		public abstract TList<EntityMain> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENTITY_MAIN_ED_CODE_STUDY_METHOD key.
		///		FK_ENTITY_MAIN_ED_CODE_STUDY_METHOD Description: 
		/// </summary>
		/// <param name="_edStudyMethodId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntityMain objects.</returns>
		public TList<EntityMain> GetByEdStudyMethodId(System.Decimal? _edStudyMethodId)
		{
			int count = -1;
			return GetByEdStudyMethodId(_edStudyMethodId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENTITY_MAIN_ED_CODE_STUDY_METHOD key.
		///		FK_ENTITY_MAIN_ED_CODE_STUDY_METHOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudyMethodId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntityMain objects.</returns>
		/// <remarks></remarks>
		public TList<EntityMain> GetByEdStudyMethodId(TransactionManager transactionManager, System.Decimal? _edStudyMethodId)
		{
			int count = -1;
			return GetByEdStudyMethodId(transactionManager, _edStudyMethodId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENTITY_MAIN_ED_CODE_STUDY_METHOD key.
		///		FK_ENTITY_MAIN_ED_CODE_STUDY_METHOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudyMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntityMain objects.</returns>
		public TList<EntityMain> GetByEdStudyMethodId(TransactionManager transactionManager, System.Decimal? _edStudyMethodId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudyMethodId(transactionManager, _edStudyMethodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENTITY_MAIN_ED_CODE_STUDY_METHOD key.
		///		fkEntityMainEdCodeStudyMethod Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudyMethodId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntityMain objects.</returns>
		public TList<EntityMain> GetByEdStudyMethodId(System.Decimal? _edStudyMethodId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudyMethodId(null, _edStudyMethodId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENTITY_MAIN_ED_CODE_STUDY_METHOD key.
		///		fkEntityMainEdCodeStudyMethod Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudyMethodId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntityMain objects.</returns>
		public TList<EntityMain> GetByEdStudyMethodId(System.Decimal? _edStudyMethodId, int start, int pageLength,out int count)
		{
			return GetByEdStudyMethodId(null, _edStudyMethodId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENTITY_MAIN_ED_CODE_STUDY_METHOD key.
		///		FK_ENTITY_MAIN_ED_CODE_STUDY_METHOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudyMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntityMain objects.</returns>
		public abstract TList<EntityMain> GetByEdStudyMethodId(TransactionManager transactionManager, System.Decimal? _edStudyMethodId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENTITY_MAIN_GS_CDE_SPEC_AREA key.
		///		FK_ENTITY_MAIN_GS_CDE_SPEC_AREA Description: 
		/// </summary>
		/// <param name="_gsCdeSpecAreaId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntityMain objects.</returns>
		public TList<EntityMain> GetByGsCdeSpecAreaId(System.Decimal? _gsCdeSpecAreaId)
		{
			int count = -1;
			return GetByGsCdeSpecAreaId(_gsCdeSpecAreaId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENTITY_MAIN_GS_CDE_SPEC_AREA key.
		///		FK_ENTITY_MAIN_GS_CDE_SPEC_AREA Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeSpecAreaId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntityMain objects.</returns>
		/// <remarks></remarks>
		public TList<EntityMain> GetByGsCdeSpecAreaId(TransactionManager transactionManager, System.Decimal? _gsCdeSpecAreaId)
		{
			int count = -1;
			return GetByGsCdeSpecAreaId(transactionManager, _gsCdeSpecAreaId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENTITY_MAIN_GS_CDE_SPEC_AREA key.
		///		FK_ENTITY_MAIN_GS_CDE_SPEC_AREA Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeSpecAreaId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntityMain objects.</returns>
		public TList<EntityMain> GetByGsCdeSpecAreaId(TransactionManager transactionManager, System.Decimal? _gsCdeSpecAreaId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeSpecAreaId(transactionManager, _gsCdeSpecAreaId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENTITY_MAIN_GS_CDE_SPEC_AREA key.
		///		fkEntityMainGsCdeSpecArea Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeSpecAreaId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntityMain objects.</returns>
		public TList<EntityMain> GetByGsCdeSpecAreaId(System.Decimal? _gsCdeSpecAreaId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeSpecAreaId(null, _gsCdeSpecAreaId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENTITY_MAIN_GS_CDE_SPEC_AREA key.
		///		fkEntityMainGsCdeSpecArea Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeSpecAreaId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntityMain objects.</returns>
		public TList<EntityMain> GetByGsCdeSpecAreaId(System.Decimal? _gsCdeSpecAreaId, int start, int pageLength,out int count)
		{
			return GetByGsCdeSpecAreaId(null, _gsCdeSpecAreaId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENTITY_MAIN_GS_CDE_SPEC_AREA key.
		///		FK_ENTITY_MAIN_GS_CDE_SPEC_AREA Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeSpecAreaId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntityMain objects.</returns>
		public abstract TList<EntityMain> GetByGsCdeSpecAreaId(TransactionManager transactionManager, System.Decimal? _gsCdeSpecAreaId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENTITY_MAIN_GS_CODE_GENDER key.
		///		FK_ENTITY_MAIN_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="_gsCodeGenderId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntityMain objects.</returns>
		public TList<EntityMain> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId)
		{
			int count = -1;
			return GetByGsCodeGenderId(_gsCodeGenderId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENTITY_MAIN_GS_CODE_GENDER key.
		///		FK_ENTITY_MAIN_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntityMain objects.</returns>
		/// <remarks></remarks>
		public TList<EntityMain> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId)
		{
			int count = -1;
			return GetByGsCodeGenderId(transactionManager, _gsCodeGenderId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENTITY_MAIN_GS_CODE_GENDER key.
		///		FK_ENTITY_MAIN_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntityMain objects.</returns>
		public TList<EntityMain> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeGenderId(transactionManager, _gsCodeGenderId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENTITY_MAIN_GS_CODE_GENDER key.
		///		fkEntityMainGsCodeGender Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntityMain objects.</returns>
		public TList<EntityMain> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeGenderId(null, _gsCodeGenderId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENTITY_MAIN_GS_CODE_GENDER key.
		///		fkEntityMainGsCodeGender Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntityMain objects.</returns>
		public TList<EntityMain> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId, int start, int pageLength,out int count)
		{
			return GetByGsCodeGenderId(null, _gsCodeGenderId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENTITY_MAIN_GS_CODE_GENDER key.
		///		FK_ENTITY_MAIN_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntityMain objects.</returns>
		public abstract TList<EntityMain> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENTITY_MAIN_GS_CODE_LANGUAGE key.
		///		FK_ENTITY_MAIN_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="_gsCodeLanguageId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntityMain objects.</returns>
		public TList<EntityMain> GetByGsCodeLanguageId(System.Decimal? _gsCodeLanguageId)
		{
			int count = -1;
			return GetByGsCodeLanguageId(_gsCodeLanguageId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENTITY_MAIN_GS_CODE_LANGUAGE key.
		///		FK_ENTITY_MAIN_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntityMain objects.</returns>
		/// <remarks></remarks>
		public TList<EntityMain> GetByGsCodeLanguageId(TransactionManager transactionManager, System.Decimal? _gsCodeLanguageId)
		{
			int count = -1;
			return GetByGsCodeLanguageId(transactionManager, _gsCodeLanguageId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENTITY_MAIN_GS_CODE_LANGUAGE key.
		///		FK_ENTITY_MAIN_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntityMain objects.</returns>
		public TList<EntityMain> GetByGsCodeLanguageId(TransactionManager transactionManager, System.Decimal? _gsCodeLanguageId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeLanguageId(transactionManager, _gsCodeLanguageId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENTITY_MAIN_GS_CODE_LANGUAGE key.
		///		fkEntityMainGsCodeLanguage Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntityMain objects.</returns>
		public TList<EntityMain> GetByGsCodeLanguageId(System.Decimal? _gsCodeLanguageId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeLanguageId(null, _gsCodeLanguageId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENTITY_MAIN_GS_CODE_LANGUAGE key.
		///		fkEntityMainGsCodeLanguage Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntityMain objects.</returns>
		public TList<EntityMain> GetByGsCodeLanguageId(System.Decimal? _gsCodeLanguageId, int start, int pageLength,out int count)
		{
			return GetByGsCodeLanguageId(null, _gsCodeLanguageId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENTITY_MAIN_GS_CODE_LANGUAGE key.
		///		FK_ENTITY_MAIN_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntityMain objects.</returns>
		public abstract TList<EntityMain> GetByGsCodeLanguageId(TransactionManager transactionManager, System.Decimal? _gsCodeLanguageId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EntityMain Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntityMainKey key, int start, int pageLength)
		{
			return GetByEntMainId(transactionManager, key.EntMainId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntityMain&gt;"/> class.</returns>
		public TList<EntityMain> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null,_asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntityMain&gt;"/> class.</returns>
		public TList<EntityMain> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntityMain&gt;"/> class.</returns>
		public TList<EntityMain> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntityMain&gt;"/> class.</returns>
		public TList<EntityMain> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntityMain&gt;"/> class.</returns>
		public TList<EntityMain> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntityMain&gt;"/> class.</returns>
		public abstract TList<EntityMain> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_LEVEL_ID_1 index.
		/// </summary>
		/// <param name="_edCodeLevelId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntityMain&gt;"/> class.</returns>
		public TList<EntityMain> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(null,_edCodeLevelId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_LEVEL_ID_1 index.
		/// </summary>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntityMain&gt;"/> class.</returns>
		public TList<EntityMain> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_LEVEL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntityMain&gt;"/> class.</returns>
		public TList<EntityMain> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_LEVEL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntityMain&gt;"/> class.</returns>
		public TList<EntityMain> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_LEVEL_ID_1 index.
		/// </summary>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntityMain&gt;"/> class.</returns>
		public TList<EntityMain> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId, int start, int pageLength, out int count)
		{
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_LEVEL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntityMain&gt;"/> class.</returns>
		public abstract TList<EntityMain> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_CODE_ENTITY_TYPE_1 index.
		/// </summary>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntityMain&gt;"/> class.</returns>
		public TList<EntityMain> GetByEntCodeEntityTypeId(System.Decimal _entCodeEntityTypeId)
		{
			int count = -1;
			return GetByEntCodeEntityTypeId(null,_entCodeEntityTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_ENTITY_TYPE_1 index.
		/// </summary>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntityMain&gt;"/> class.</returns>
		public TList<EntityMain> GetByEntCodeEntityTypeId(System.Decimal _entCodeEntityTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodeEntityTypeId(null, _entCodeEntityTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_ENTITY_TYPE_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntityMain&gt;"/> class.</returns>
		public TList<EntityMain> GetByEntCodeEntityTypeId(TransactionManager transactionManager, System.Decimal _entCodeEntityTypeId)
		{
			int count = -1;
			return GetByEntCodeEntityTypeId(transactionManager, _entCodeEntityTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_ENTITY_TYPE_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntityMain&gt;"/> class.</returns>
		public TList<EntityMain> GetByEntCodeEntityTypeId(TransactionManager transactionManager, System.Decimal _entCodeEntityTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodeEntityTypeId(transactionManager, _entCodeEntityTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_ENTITY_TYPE_1 index.
		/// </summary>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntityMain&gt;"/> class.</returns>
		public TList<EntityMain> GetByEntCodeEntityTypeId(System.Decimal _entCodeEntityTypeId, int start, int pageLength, out int count)
		{
			return GetByEntCodeEntityTypeId(null, _entCodeEntityTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_ENTITY_TYPE_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntityMain&gt;"/> class.</returns>
		public abstract TList<EntityMain> GetByEntCodeEntityTypeId(TransactionManager transactionManager, System.Decimal _entCodeEntityTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_PARENT_ID_1 index.
		/// </summary>
		/// <param name="_entParentId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntityMain&gt;"/> class.</returns>
		public TList<EntityMain> GetByEntParentId(System.Decimal? _entParentId)
		{
			int count = -1;
			return GetByEntParentId(null,_entParentId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_PARENT_ID_1 index.
		/// </summary>
		/// <param name="_entParentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntityMain&gt;"/> class.</returns>
		public TList<EntityMain> GetByEntParentId(System.Decimal? _entParentId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntParentId(null, _entParentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_PARENT_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entParentId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntityMain&gt;"/> class.</returns>
		public TList<EntityMain> GetByEntParentId(TransactionManager transactionManager, System.Decimal? _entParentId)
		{
			int count = -1;
			return GetByEntParentId(transactionManager, _entParentId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_PARENT_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entParentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntityMain&gt;"/> class.</returns>
		public TList<EntityMain> GetByEntParentId(TransactionManager transactionManager, System.Decimal? _entParentId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntParentId(transactionManager, _entParentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_PARENT_ID_1 index.
		/// </summary>
		/// <param name="_entParentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntityMain&gt;"/> class.</returns>
		public TList<EntityMain> GetByEntParentId(System.Decimal? _entParentId, int start, int pageLength, out int count)
		{
			return GetByEntParentId(null, _entParentId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_PARENT_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entParentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntityMain&gt;"/> class.</returns>
		public abstract TList<EntityMain> GetByEntParentId(TransactionManager transactionManager, System.Decimal? _entParentId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ENTITY_MAIN index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntityMain"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntityMain GetByEntMainId(System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(null,_entMainId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENTITY_MAIN index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntityMain"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntityMain GetByEntMainId(System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENTITY_MAIN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntityMain"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntityMain GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENTITY_MAIN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntityMain"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntityMain GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENTITY_MAIN index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntityMain"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntityMain GetByEntMainId(System.Decimal _entMainId, int start, int pageLength, out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENTITY_MAIN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntityMain"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntityMain GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ENTITY_MAIN index.
		/// </summary>
		/// <param name="_nodePath"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntityMain"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntityMain GetByNodePath(System.String _nodePath)
		{
			int count = -1;
			return GetByNodePath(null,_nodePath, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENTITY_MAIN index.
		/// </summary>
		/// <param name="_nodePath"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntityMain"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntityMain GetByNodePath(System.String _nodePath, int start, int pageLength)
		{
			int count = -1;
			return GetByNodePath(null, _nodePath, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENTITY_MAIN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_nodePath"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntityMain"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntityMain GetByNodePath(TransactionManager transactionManager, System.String _nodePath)
		{
			int count = -1;
			return GetByNodePath(transactionManager, _nodePath, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENTITY_MAIN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_nodePath"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntityMain"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntityMain GetByNodePath(TransactionManager transactionManager, System.String _nodePath, int start, int pageLength)
		{
			int count = -1;
			return GetByNodePath(transactionManager, _nodePath, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENTITY_MAIN index.
		/// </summary>
		/// <param name="_nodePath"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntityMain"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntityMain GetByNodePath(System.String _nodePath, int start, int pageLength, out int count)
		{
			return GetByNodePath(null, _nodePath, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENTITY_MAIN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_nodePath"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntityMain"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntityMain GetByNodePath(TransactionManager transactionManager, System.String _nodePath, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ENTITY_MAIN_DESCR_AR index.
		/// </summary>
		/// <param name="_entDescrAr"></param>
		/// <param name="_entParentId"></param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntityMain"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntityMain GetByEntDescrArEntParentIdEntCodeEntityTypeIdAsCodeDegreeId(System.String _entDescrAr, System.Decimal? _entParentId, System.Decimal _entCodeEntityTypeId, System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByEntDescrArEntParentIdEntCodeEntityTypeIdAsCodeDegreeId(null,_entDescrAr, _entParentId, _entCodeEntityTypeId, _asCodeDegreeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENTITY_MAIN_DESCR_AR index.
		/// </summary>
		/// <param name="_entDescrAr"></param>
		/// <param name="_entParentId"></param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntityMain"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntityMain GetByEntDescrArEntParentIdEntCodeEntityTypeIdAsCodeDegreeId(System.String _entDescrAr, System.Decimal? _entParentId, System.Decimal _entCodeEntityTypeId, System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntDescrArEntParentIdEntCodeEntityTypeIdAsCodeDegreeId(null, _entDescrAr, _entParentId, _entCodeEntityTypeId, _asCodeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENTITY_MAIN_DESCR_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entDescrAr"></param>
		/// <param name="_entParentId"></param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntityMain"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntityMain GetByEntDescrArEntParentIdEntCodeEntityTypeIdAsCodeDegreeId(TransactionManager transactionManager, System.String _entDescrAr, System.Decimal? _entParentId, System.Decimal _entCodeEntityTypeId, System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByEntDescrArEntParentIdEntCodeEntityTypeIdAsCodeDegreeId(transactionManager, _entDescrAr, _entParentId, _entCodeEntityTypeId, _asCodeDegreeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENTITY_MAIN_DESCR_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entDescrAr"></param>
		/// <param name="_entParentId"></param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntityMain"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntityMain GetByEntDescrArEntParentIdEntCodeEntityTypeIdAsCodeDegreeId(TransactionManager transactionManager, System.String _entDescrAr, System.Decimal? _entParentId, System.Decimal _entCodeEntityTypeId, System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntDescrArEntParentIdEntCodeEntityTypeIdAsCodeDegreeId(transactionManager, _entDescrAr, _entParentId, _entCodeEntityTypeId, _asCodeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENTITY_MAIN_DESCR_AR index.
		/// </summary>
		/// <param name="_entDescrAr"></param>
		/// <param name="_entParentId"></param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntityMain"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntityMain GetByEntDescrArEntParentIdEntCodeEntityTypeIdAsCodeDegreeId(System.String _entDescrAr, System.Decimal? _entParentId, System.Decimal _entCodeEntityTypeId, System.Decimal? _asCodeDegreeId, int start, int pageLength, out int count)
		{
			return GetByEntDescrArEntParentIdEntCodeEntityTypeIdAsCodeDegreeId(null, _entDescrAr, _entParentId, _entCodeEntityTypeId, _asCodeDegreeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENTITY_MAIN_DESCR_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entDescrAr"></param>
		/// <param name="_entParentId"></param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntityMain"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntityMain GetByEntDescrArEntParentIdEntCodeEntityTypeIdAsCodeDegreeId(TransactionManager transactionManager, System.String _entDescrAr, System.Decimal? _entParentId, System.Decimal _entCodeEntityTypeId, System.Decimal? _asCodeDegreeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ENTITY_MAIN_DESCR_EN index.
		/// </summary>
		/// <param name="_entDescrEn"></param>
		/// <param name="_entParentId"></param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntityMain"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntityMain GetByEntDescrEnEntParentIdEntCodeEntityTypeIdAsCodeDegreeId(System.String _entDescrEn, System.Decimal? _entParentId, System.Decimal _entCodeEntityTypeId, System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByEntDescrEnEntParentIdEntCodeEntityTypeIdAsCodeDegreeId(null,_entDescrEn, _entParentId, _entCodeEntityTypeId, _asCodeDegreeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENTITY_MAIN_DESCR_EN index.
		/// </summary>
		/// <param name="_entDescrEn"></param>
		/// <param name="_entParentId"></param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntityMain"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntityMain GetByEntDescrEnEntParentIdEntCodeEntityTypeIdAsCodeDegreeId(System.String _entDescrEn, System.Decimal? _entParentId, System.Decimal _entCodeEntityTypeId, System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntDescrEnEntParentIdEntCodeEntityTypeIdAsCodeDegreeId(null, _entDescrEn, _entParentId, _entCodeEntityTypeId, _asCodeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENTITY_MAIN_DESCR_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entDescrEn"></param>
		/// <param name="_entParentId"></param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntityMain"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntityMain GetByEntDescrEnEntParentIdEntCodeEntityTypeIdAsCodeDegreeId(TransactionManager transactionManager, System.String _entDescrEn, System.Decimal? _entParentId, System.Decimal _entCodeEntityTypeId, System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByEntDescrEnEntParentIdEntCodeEntityTypeIdAsCodeDegreeId(transactionManager, _entDescrEn, _entParentId, _entCodeEntityTypeId, _asCodeDegreeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENTITY_MAIN_DESCR_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entDescrEn"></param>
		/// <param name="_entParentId"></param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntityMain"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntityMain GetByEntDescrEnEntParentIdEntCodeEntityTypeIdAsCodeDegreeId(TransactionManager transactionManager, System.String _entDescrEn, System.Decimal? _entParentId, System.Decimal _entCodeEntityTypeId, System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntDescrEnEntParentIdEntCodeEntityTypeIdAsCodeDegreeId(transactionManager, _entDescrEn, _entParentId, _entCodeEntityTypeId, _asCodeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENTITY_MAIN_DESCR_EN index.
		/// </summary>
		/// <param name="_entDescrEn"></param>
		/// <param name="_entParentId"></param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntityMain"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntityMain GetByEntDescrEnEntParentIdEntCodeEntityTypeIdAsCodeDegreeId(System.String _entDescrEn, System.Decimal? _entParentId, System.Decimal _entCodeEntityTypeId, System.Decimal? _asCodeDegreeId, int start, int pageLength, out int count)
		{
			return GetByEntDescrEnEntParentIdEntCodeEntityTypeIdAsCodeDegreeId(null, _entDescrEn, _entParentId, _entCodeEntityTypeId, _asCodeDegreeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENTITY_MAIN_DESCR_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entDescrEn"></param>
		/// <param name="_entParentId"></param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntityMain"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntityMain GetByEntDescrEnEntParentIdEntCodeEntityTypeIdAsCodeDegreeId(TransactionManager transactionManager, System.String _entDescrEn, System.Decimal? _entParentId, System.Decimal _entCodeEntityTypeId, System.Decimal? _asCodeDegreeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntityMain&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntityMain&gt;"/></returns>
		public static TList<EntityMain> Fill(IDataReader reader, TList<EntityMain> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntityMain c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntityMain")
					.Append("|").Append((System.Decimal)reader["ENT_MAIN_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntityMain>(
					key.ToString(), // EntityTrackingKey
					"EntityMain",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntityMain();
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
					c.EntMainId = (System.Decimal)reader["ENT_MAIN_ID"];
					c.OriginalEntMainId = c.EntMainId;
					c.EntDescrAr = Convert.IsDBNull(reader["ENT_DESCR_AR"]) ? null : (System.String)reader["ENT_DESCR_AR"];
					c.EntCodeEntityTypeId = (System.Decimal)reader["ENT_CODE_ENTITY_TYPE_ID"];
					c.StateNotation = Convert.IsDBNull(reader["STATE_NOTATION"]) ? null : (System.String)reader["STATE_NOTATION"];
					c.EntParentId = Convert.IsDBNull(reader["ENT_PARENT_ID"]) ? null : (System.Decimal?)reader["ENT_PARENT_ID"];
					c.EntDescrEn = Convert.IsDBNull(reader["ENT_DESCR_EN"]) ? null : (System.String)reader["ENT_DESCR_EN"];
					c.IsStateFlg = Convert.IsDBNull(reader["IS_STATE_FLG"]) ? null : (System.Decimal?)reader["IS_STATE_FLG"];
					c.NodeChildCount = Convert.IsDBNull(reader["NODE_CHILD_COUNT"]) ? null : (System.Decimal?)reader["NODE_CHILD_COUNT"];
					c.NodePath = Convert.IsDBNull(reader["NODE_PATH"]) ? null : (System.String)reader["NODE_PATH"];
					c.NodeOrder = Convert.IsDBNull(reader["NODE_ORDER"]) ? null : (System.Decimal?)reader["NODE_ORDER"];
					c.NodeLevel = Convert.IsDBNull(reader["NODE_LEVEL"]) ? null : (System.Decimal?)reader["NODE_LEVEL"];
					c.EdStudyMethodId = Convert.IsDBNull(reader["ED_STUDY_METHOD_ID"]) ? null : (System.Decimal?)reader["ED_STUDY_METHOD_ID"];
					c.IsInfoFlg = Convert.IsDBNull(reader["IS_INFO_FLG"]) ? null : (System.Decimal?)reader["IS_INFO_FLG"];
					c.IsHomeFlg = Convert.IsDBNull(reader["IS_HOME_FLG"]) ? null : (System.Decimal?)reader["IS_HOME_FLG"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.StateDescrAr = Convert.IsDBNull(reader["STATE_DESCR_AR"]) ? null : (System.String)reader["STATE_DESCR_AR"];
					c.StateDescrEn = Convert.IsDBNull(reader["STATE_DESCR_EN"]) ? null : (System.String)reader["STATE_DESCR_EN"];
					c.EdCodeLevelId = Convert.IsDBNull(reader["ED_CODE_LEVEL_ID"]) ? null : (System.Decimal?)reader["ED_CODE_LEVEL_ID"];
					c.IsVisible = (System.Decimal)reader["IS_VISIBLE"];
					c.IsActive = (System.Decimal)reader["IS_ACTIVE"];
					c.AsCodeDegreeId = Convert.IsDBNull(reader["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_ID"];
					c.ApproveFlg = Convert.IsDBNull(reader["APPROVE_FLG"]) ? null : (System.Decimal?)reader["APPROVE_FLG"];
					c.LoadWithTrain = Convert.IsDBNull(reader["LOAD_WITH_TRAIN"]) ? null : (System.Decimal?)reader["LOAD_WITH_TRAIN"];
					c.GsCdeSpecAreaId = Convert.IsDBNull(reader["GS_CDE_SPEC_AREA_ID"]) ? null : (System.Decimal?)reader["GS_CDE_SPEC_AREA_ID"];
					c.MaxTrnsCh = Convert.IsDBNull(reader["MAX_TRNS_CH"]) ? null : (System.Int32?)reader["MAX_TRNS_CH"];
					c.GsCodeGenderId = Convert.IsDBNull(reader["GS_CODE_GENDER_ID"]) ? null : (System.Decimal?)reader["GS_CODE_GENDER_ID"];
					c.AdmShowFlg = Convert.IsDBNull(reader["ADM_SHOW_FLG"]) ? null : (System.Boolean?)reader["ADM_SHOW_FLG"];
					c.DegEquvText = Convert.IsDBNull(reader["DEG_EQUV_TEXT"]) ? null : (System.String)reader["DEG_EQUV_TEXT"];
					c.DegEquvTextEng = Convert.IsDBNull(reader["DEG_EQUV_TEXT_ENG"]) ? null : (System.String)reader["DEG_EQUV_TEXT_ENG"];
					c.GsCodeLanguageId = Convert.IsDBNull(reader["GS_CODE_LANGUAGE_ID"]) ? null : (System.Decimal?)reader["GS_CODE_LANGUAGE_ID"];
					c.ScheduleTypeFlg = Convert.IsDBNull(reader["SCHEDULE_TYPE_FLG"]) ? null : (System.Decimal?)reader["SCHEDULE_TYPE_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntityMain"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntityMain"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntityMain entity)
		{
			if (!reader.Read()) return;
			
			entity.EntMainId = (System.Decimal)reader[((int)EntityMainColumn.EntMainId - 1)];
			entity.OriginalEntMainId = (System.Decimal)reader["ENT_MAIN_ID"];
			entity.EntDescrAr = (reader.IsDBNull(((int)EntityMainColumn.EntDescrAr - 1)))?null:(System.String)reader[((int)EntityMainColumn.EntDescrAr - 1)];
			entity.EntCodeEntityTypeId = (System.Decimal)reader[((int)EntityMainColumn.EntCodeEntityTypeId - 1)];
			entity.StateNotation = (reader.IsDBNull(((int)EntityMainColumn.StateNotation - 1)))?null:(System.String)reader[((int)EntityMainColumn.StateNotation - 1)];
			entity.EntParentId = (reader.IsDBNull(((int)EntityMainColumn.EntParentId - 1)))?null:(System.Decimal?)reader[((int)EntityMainColumn.EntParentId - 1)];
			entity.EntDescrEn = (reader.IsDBNull(((int)EntityMainColumn.EntDescrEn - 1)))?null:(System.String)reader[((int)EntityMainColumn.EntDescrEn - 1)];
			entity.IsStateFlg = (reader.IsDBNull(((int)EntityMainColumn.IsStateFlg - 1)))?null:(System.Decimal?)reader[((int)EntityMainColumn.IsStateFlg - 1)];
			entity.NodeChildCount = (reader.IsDBNull(((int)EntityMainColumn.NodeChildCount - 1)))?null:(System.Decimal?)reader[((int)EntityMainColumn.NodeChildCount - 1)];
			entity.NodePath = (reader.IsDBNull(((int)EntityMainColumn.NodePath - 1)))?null:(System.String)reader[((int)EntityMainColumn.NodePath - 1)];
			entity.NodeOrder = (reader.IsDBNull(((int)EntityMainColumn.NodeOrder - 1)))?null:(System.Decimal?)reader[((int)EntityMainColumn.NodeOrder - 1)];
			entity.NodeLevel = (reader.IsDBNull(((int)EntityMainColumn.NodeLevel - 1)))?null:(System.Decimal?)reader[((int)EntityMainColumn.NodeLevel - 1)];
			entity.EdStudyMethodId = (reader.IsDBNull(((int)EntityMainColumn.EdStudyMethodId - 1)))?null:(System.Decimal?)reader[((int)EntityMainColumn.EdStudyMethodId - 1)];
			entity.IsInfoFlg = (reader.IsDBNull(((int)EntityMainColumn.IsInfoFlg - 1)))?null:(System.Decimal?)reader[((int)EntityMainColumn.IsInfoFlg - 1)];
			entity.IsHomeFlg = (reader.IsDBNull(((int)EntityMainColumn.IsHomeFlg - 1)))?null:(System.Decimal?)reader[((int)EntityMainColumn.IsHomeFlg - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)EntityMainColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)EntityMainColumn.AsFacultyInfoId - 1)];
			entity.StateDescrAr = (reader.IsDBNull(((int)EntityMainColumn.StateDescrAr - 1)))?null:(System.String)reader[((int)EntityMainColumn.StateDescrAr - 1)];
			entity.StateDescrEn = (reader.IsDBNull(((int)EntityMainColumn.StateDescrEn - 1)))?null:(System.String)reader[((int)EntityMainColumn.StateDescrEn - 1)];
			entity.EdCodeLevelId = (reader.IsDBNull(((int)EntityMainColumn.EdCodeLevelId - 1)))?null:(System.Decimal?)reader[((int)EntityMainColumn.EdCodeLevelId - 1)];
			entity.IsVisible = (System.Decimal)reader[((int)EntityMainColumn.IsVisible - 1)];
			entity.IsActive = (System.Decimal)reader[((int)EntityMainColumn.IsActive - 1)];
			entity.AsCodeDegreeId = (reader.IsDBNull(((int)EntityMainColumn.AsCodeDegreeId - 1)))?null:(System.Decimal?)reader[((int)EntityMainColumn.AsCodeDegreeId - 1)];
			entity.ApproveFlg = (reader.IsDBNull(((int)EntityMainColumn.ApproveFlg - 1)))?null:(System.Decimal?)reader[((int)EntityMainColumn.ApproveFlg - 1)];
			entity.LoadWithTrain = (reader.IsDBNull(((int)EntityMainColumn.LoadWithTrain - 1)))?null:(System.Decimal?)reader[((int)EntityMainColumn.LoadWithTrain - 1)];
			entity.GsCdeSpecAreaId = (reader.IsDBNull(((int)EntityMainColumn.GsCdeSpecAreaId - 1)))?null:(System.Decimal?)reader[((int)EntityMainColumn.GsCdeSpecAreaId - 1)];
			entity.MaxTrnsCh = (reader.IsDBNull(((int)EntityMainColumn.MaxTrnsCh - 1)))?null:(System.Int32?)reader[((int)EntityMainColumn.MaxTrnsCh - 1)];
			entity.GsCodeGenderId = (reader.IsDBNull(((int)EntityMainColumn.GsCodeGenderId - 1)))?null:(System.Decimal?)reader[((int)EntityMainColumn.GsCodeGenderId - 1)];
			entity.AdmShowFlg = (reader.IsDBNull(((int)EntityMainColumn.AdmShowFlg - 1)))?null:(System.Boolean?)reader[((int)EntityMainColumn.AdmShowFlg - 1)];
			entity.DegEquvText = (reader.IsDBNull(((int)EntityMainColumn.DegEquvText - 1)))?null:(System.String)reader[((int)EntityMainColumn.DegEquvText - 1)];
			entity.DegEquvTextEng = (reader.IsDBNull(((int)EntityMainColumn.DegEquvTextEng - 1)))?null:(System.String)reader[((int)EntityMainColumn.DegEquvTextEng - 1)];
			entity.GsCodeLanguageId = (reader.IsDBNull(((int)EntityMainColumn.GsCodeLanguageId - 1)))?null:(System.Decimal?)reader[((int)EntityMainColumn.GsCodeLanguageId - 1)];
			entity.ScheduleTypeFlg = (reader.IsDBNull(((int)EntityMainColumn.ScheduleTypeFlg - 1)))?null:(System.Decimal?)reader[((int)EntityMainColumn.ScheduleTypeFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntityMain"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntityMain"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntityMain entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntMainId = (System.Decimal)dataRow["ENT_MAIN_ID"];
			entity.OriginalEntMainId = (System.Decimal)dataRow["ENT_MAIN_ID"];
			entity.EntDescrAr = Convert.IsDBNull(dataRow["ENT_DESCR_AR"]) ? null : (System.String)dataRow["ENT_DESCR_AR"];
			entity.EntCodeEntityTypeId = (System.Decimal)dataRow["ENT_CODE_ENTITY_TYPE_ID"];
			entity.StateNotation = Convert.IsDBNull(dataRow["STATE_NOTATION"]) ? null : (System.String)dataRow["STATE_NOTATION"];
			entity.EntParentId = Convert.IsDBNull(dataRow["ENT_PARENT_ID"]) ? null : (System.Decimal?)dataRow["ENT_PARENT_ID"];
			entity.EntDescrEn = Convert.IsDBNull(dataRow["ENT_DESCR_EN"]) ? null : (System.String)dataRow["ENT_DESCR_EN"];
			entity.IsStateFlg = Convert.IsDBNull(dataRow["IS_STATE_FLG"]) ? null : (System.Decimal?)dataRow["IS_STATE_FLG"];
			entity.NodeChildCount = Convert.IsDBNull(dataRow["NODE_CHILD_COUNT"]) ? null : (System.Decimal?)dataRow["NODE_CHILD_COUNT"];
			entity.NodePath = Convert.IsDBNull(dataRow["NODE_PATH"]) ? null : (System.String)dataRow["NODE_PATH"];
			entity.NodeOrder = Convert.IsDBNull(dataRow["NODE_ORDER"]) ? null : (System.Decimal?)dataRow["NODE_ORDER"];
			entity.NodeLevel = Convert.IsDBNull(dataRow["NODE_LEVEL"]) ? null : (System.Decimal?)dataRow["NODE_LEVEL"];
			entity.EdStudyMethodId = Convert.IsDBNull(dataRow["ED_STUDY_METHOD_ID"]) ? null : (System.Decimal?)dataRow["ED_STUDY_METHOD_ID"];
			entity.IsInfoFlg = Convert.IsDBNull(dataRow["IS_INFO_FLG"]) ? null : (System.Decimal?)dataRow["IS_INFO_FLG"];
			entity.IsHomeFlg = Convert.IsDBNull(dataRow["IS_HOME_FLG"]) ? null : (System.Decimal?)dataRow["IS_HOME_FLG"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.StateDescrAr = Convert.IsDBNull(dataRow["STATE_DESCR_AR"]) ? null : (System.String)dataRow["STATE_DESCR_AR"];
			entity.StateDescrEn = Convert.IsDBNull(dataRow["STATE_DESCR_EN"]) ? null : (System.String)dataRow["STATE_DESCR_EN"];
			entity.EdCodeLevelId = Convert.IsDBNull(dataRow["ED_CODE_LEVEL_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_LEVEL_ID"];
			entity.IsVisible = (System.Decimal)dataRow["IS_VISIBLE"];
			entity.IsActive = (System.Decimal)dataRow["IS_ACTIVE"];
			entity.AsCodeDegreeId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_ID"];
			entity.ApproveFlg = Convert.IsDBNull(dataRow["APPROVE_FLG"]) ? null : (System.Decimal?)dataRow["APPROVE_FLG"];
			entity.LoadWithTrain = Convert.IsDBNull(dataRow["LOAD_WITH_TRAIN"]) ? null : (System.Decimal?)dataRow["LOAD_WITH_TRAIN"];
			entity.GsCdeSpecAreaId = Convert.IsDBNull(dataRow["GS_CDE_SPEC_AREA_ID"]) ? null : (System.Decimal?)dataRow["GS_CDE_SPEC_AREA_ID"];
			entity.MaxTrnsCh = Convert.IsDBNull(dataRow["MAX_TRNS_CH"]) ? null : (System.Int32?)dataRow["MAX_TRNS_CH"];
			entity.GsCodeGenderId = Convert.IsDBNull(dataRow["GS_CODE_GENDER_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_GENDER_ID"];
			entity.AdmShowFlg = Convert.IsDBNull(dataRow["ADM_SHOW_FLG"]) ? null : (System.Boolean?)dataRow["ADM_SHOW_FLG"];
			entity.DegEquvText = Convert.IsDBNull(dataRow["DEG_EQUV_TEXT"]) ? null : (System.String)dataRow["DEG_EQUV_TEXT"];
			entity.DegEquvTextEng = Convert.IsDBNull(dataRow["DEG_EQUV_TEXT_ENG"]) ? null : (System.String)dataRow["DEG_EQUV_TEXT_ENG"];
			entity.GsCodeLanguageId = Convert.IsDBNull(dataRow["GS_CODE_LANGUAGE_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_LANGUAGE_ID"];
			entity.ScheduleTypeFlg = Convert.IsDBNull(dataRow["SCHEDULE_TYPE_FLG"]) ? null : (System.Decimal?)dataRow["SCHEDULE_TYPE_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntityMain"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntityMain Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntityMain entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsCodeDegreeIdSource	
			if (CanDeepLoad(entity, "AsCodeDegree|AsCodeDegreeIdSource", deepLoadType, innerList) 
				&& entity.AsCodeDegreeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsCodeDegreeId ?? 0.0m);
				AsCodeDegree tmpEntity = EntityManager.LocateEntity<AsCodeDegree>(EntityLocator.ConstructKeyFromPkItems(typeof(AsCodeDegree), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsCodeDegreeIdSource = tmpEntity;
				else
					entity.AsCodeDegreeIdSource = DataRepository.AsCodeDegreeProvider.GetByAsCodeDegreeId(transactionManager, (entity.AsCodeDegreeId ?? 0.0m));		
				
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

			#region EdCodeLevelIdSource	
			if (CanDeepLoad(entity, "EdCodeLevel|EdCodeLevelIdSource", deepLoadType, innerList) 
				&& entity.EdCodeLevelIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeLevelId ?? 0.0m);
				EdCodeLevel tmpEntity = EntityManager.LocateEntity<EdCodeLevel>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeLevel), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeLevelIdSource = tmpEntity;
				else
					entity.EdCodeLevelIdSource = DataRepository.EdCodeLevelProvider.GetByEdCodeLevelId(transactionManager, (entity.EdCodeLevelId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeLevelIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeLevelIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeLevelProvider.DeepLoad(transactionManager, entity.EdCodeLevelIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeLevelIdSource

			#region EdStudyMethodIdSource	
			if (CanDeepLoad(entity, "EdCodeStudyMethod|EdStudyMethodIdSource", deepLoadType, innerList) 
				&& entity.EdStudyMethodIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdStudyMethodId ?? 0.0m);
				EdCodeStudyMethod tmpEntity = EntityManager.LocateEntity<EdCodeStudyMethod>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeStudyMethod), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudyMethodIdSource = tmpEntity;
				else
					entity.EdStudyMethodIdSource = DataRepository.EdCodeStudyMethodProvider.GetByEdCodeStudyMethodId(transactionManager, (entity.EdStudyMethodId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudyMethodIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudyMethodIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeStudyMethodProvider.DeepLoad(transactionManager, entity.EdStudyMethodIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudyMethodIdSource

			#region EntCodeEntityTypeIdSource	
			if (CanDeepLoad(entity, "EntCodeEntityType|EntCodeEntityTypeIdSource", deepLoadType, innerList) 
				&& entity.EntCodeEntityTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EntCodeEntityTypeId;
				EntCodeEntityType tmpEntity = EntityManager.LocateEntity<EntCodeEntityType>(EntityLocator.ConstructKeyFromPkItems(typeof(EntCodeEntityType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntCodeEntityTypeIdSource = tmpEntity;
				else
					entity.EntCodeEntityTypeIdSource = DataRepository.EntCodeEntityTypeProvider.GetByEntCodeEntityTypeId(transactionManager, entity.EntCodeEntityTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCodeEntityTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntCodeEntityTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntCodeEntityTypeProvider.DeepLoad(transactionManager, entity.EntCodeEntityTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntCodeEntityTypeIdSource

			#region EntParentIdSource	
			if (CanDeepLoad(entity, "EntityMain|EntParentIdSource", deepLoadType, innerList) 
				&& entity.EntParentIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntParentId ?? 0.0m);
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntParentIdSource = tmpEntity;
				else
					entity.EntParentIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, (entity.EntParentId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntParentIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntParentIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntityMainProvider.DeepLoad(transactionManager, entity.EntParentIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntParentIdSource

			#region GsCdeSpecAreaIdSource	
			if (CanDeepLoad(entity, "GsCdeSpecArea|GsCdeSpecAreaIdSource", deepLoadType, innerList) 
				&& entity.GsCdeSpecAreaIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCdeSpecAreaId ?? 0.0m);
				GsCdeSpecArea tmpEntity = EntityManager.LocateEntity<GsCdeSpecArea>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeSpecArea), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeSpecAreaIdSource = tmpEntity;
				else
					entity.GsCdeSpecAreaIdSource = DataRepository.GsCdeSpecAreaProvider.GetByGsCdeSpecAreaId(transactionManager, (entity.GsCdeSpecAreaId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeSpecAreaIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeSpecAreaIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeSpecAreaProvider.DeepLoad(transactionManager, entity.GsCdeSpecAreaIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeSpecAreaIdSource

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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEntMainId methods when available
			
			#region EdStudFacultyCollectionGetByEntMainGrad1
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudFaculty>|EdStudFacultyCollectionGetByEntMainGrad1", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudFacultyCollectionGetByEntMainGrad1' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudFacultyCollectionGetByEntMainGrad1 = DataRepository.EdStudFacultyProvider.GetByEntMainGrad1(transactionManager, entity.EntMainId);

				if (deep && entity.EdStudFacultyCollectionGetByEntMainGrad1.Count > 0)
				{
					deepHandles.Add("EdStudFacultyCollectionGetByEntMainGrad1",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudFaculty>) DataRepository.EdStudFacultyProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudFacultyCollectionGetByEntMainGrad1, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvStaffEvlCollectionGetByEntMainMajorId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStaffEvl>|SvStaffEvlCollectionGetByEntMainMajorId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStaffEvlCollectionGetByEntMainMajorId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStaffEvlCollectionGetByEntMainMajorId = DataRepository.SvStaffEvlProvider.GetByEntMainMajorId(transactionManager, entity.EntMainId);

				if (deep && entity.SvStaffEvlCollectionGetByEntMainMajorId.Count > 0)
				{
					deepHandles.Add("SvStaffEvlCollectionGetByEntMainMajorId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStaffEvl>) DataRepository.SvStaffEvlProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStaffEvlCollectionGetByEntMainMajorId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvStaffEvlCollectionGetByEntMainId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStaffEvl>|SvStaffEvlCollectionGetByEntMainId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStaffEvlCollectionGetByEntMainId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStaffEvlCollectionGetByEntMainId = DataRepository.SvStaffEvlProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.SvStaffEvlCollectionGetByEntMainId.Count > 0)
				{
					deepHandles.Add("SvStaffEvlCollectionGetByEntMainId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStaffEvl>) DataRepository.SvStaffEvlProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStaffEvlCollectionGetByEntMainId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicyMdDataCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyMdData>|EntPolicyMdDataCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyMdDataCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyMdDataCollection = DataRepository.EntPolicyMdDataProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.EntPolicyMdDataCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyMdData>) DataRepository.EntPolicyMdDataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyMdDataCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntFullfillMdDataCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntFullfillMdData>|EntFullfillMdDataCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntFullfillMdDataCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntFullfillMdDataCollection = DataRepository.EntFullfillMdDataProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.EntFullfillMdDataCollection.Count > 0)
				{
					deepHandles.Add("EntFullfillMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntFullfillMdData>) DataRepository.EntFullfillMdDataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntFullfillMdDataCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicyGradingLevelCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyGradingLevel>|EntPolicyGradingLevelCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyGradingLevelCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyGradingLevelCollection = DataRepository.EntPolicyGradingLevelProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.EntPolicyGradingLevelCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyGradingLevelCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyGradingLevel>) DataRepository.EntPolicyGradingLevelProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyGradingLevelCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdStudIntTrnsStateToCollection = DataRepository.EdStudIntTrnsStateToProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.EdStudIntTrnsStateToCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsStateToCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsStateTo>) DataRepository.EdStudIntTrnsStateToProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsStateToCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeFacultyInstallmentCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeFacultyInstallment>|FeeFacultyInstallmentCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeFacultyInstallmentCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeFacultyInstallmentCollection = DataRepository.FeeFacultyInstallmentProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.FeeFacultyInstallmentCollection.Count > 0)
				{
					deepHandles.Add("FeeFacultyInstallmentCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeFacultyInstallment>) DataRepository.FeeFacultyInstallmentProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeFacultyInstallmentCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmReqDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmReqDoc>|AdmReqDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmReqDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmReqDocCollection = DataRepository.AdmReqDocProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.AdmReqDocCollection.Count > 0)
				{
					deepHandles.Add("AdmReqDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmReqDoc>) DataRepository.AdmReqDocProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmReqDocCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCourseOrientCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourseOrient>|EdCourseOrientCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseOrientCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseOrientCollection = DataRepository.EdCourseOrientProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.EdCourseOrientCollection.Count > 0)
				{
					deepHandles.Add("EdCourseOrientCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourseOrient>) DataRepository.EdCourseOrientProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseOrientCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdProjectCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdProject>|EdProjectCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdProjectCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdProjectCollection = DataRepository.EdProjectProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.EdProjectCollection.Count > 0)
				{
					deepHandles.Add("EdProjectCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdProject>) DataRepository.EdProjectProvider.DeepLoad,
						new object[] { transactionManager, entity.EdProjectCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmCdePlacementExamCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmCdePlacementExam>|AdmCdePlacementExamCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdePlacementExamCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmCdePlacementExamCollection = DataRepository.AdmCdePlacementExamProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.AdmCdePlacementExamCollection.Count > 0)
				{
					deepHandles.Add("AdmCdePlacementExamCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmCdePlacementExam>) DataRepository.AdmCdePlacementExamProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmCdePlacementExamCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntCoursePkgHdrCollectionGetByEntMainRltdId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntCoursePkgHdr>|EntCoursePkgHdrCollectionGetByEntMainRltdId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCoursePkgHdrCollectionGetByEntMainRltdId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntCoursePkgHdrCollectionGetByEntMainRltdId = DataRepository.EntCoursePkgHdrProvider.GetByEntMainRltdId(transactionManager, entity.EntMainId);

				if (deep && entity.EntCoursePkgHdrCollectionGetByEntMainRltdId.Count > 0)
				{
					deepHandles.Add("EntCoursePkgHdrCollectionGetByEntMainRltdId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntCoursePkgHdr>) DataRepository.EntCoursePkgHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.EntCoursePkgHdrCollectionGetByEntMainRltdId, deep, deepLoadType, childTypes, innerList }
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

				entity.SpoSponsorOfferExtCollection = DataRepository.SpoSponsorOfferExtProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.SpoSponsorOfferExtCollection.Count > 0)
				{
					deepHandles.Add("SpoSponsorOfferExtCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoSponsorOfferExt>) DataRepository.SpoSponsorOfferExtProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoSponsorOfferExtCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScHallRsrvCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScHallRsrv>|ScHallRsrvCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScHallRsrvCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScHallRsrvCollection = DataRepository.ScHallRsrvProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.ScHallRsrvCollection.Count > 0)
				{
					deepHandles.Add("ScHallRsrvCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScHallRsrv>) DataRepository.ScHallRsrvProvider.DeepLoad,
						new object[] { transactionManager, entity.ScHallRsrvCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScSectionGroupHdrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScSectionGroupHdr>|ScSectionGroupHdrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScSectionGroupHdrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScSectionGroupHdrCollection = DataRepository.ScSectionGroupHdrProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.ScSectionGroupHdrCollection.Count > 0)
				{
					deepHandles.Add("ScSectionGroupHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScSectionGroupHdr>) DataRepository.ScSectionGroupHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.ScSectionGroupHdrCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntMajorPhaseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntMajorPhase>|EntMajorPhaseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMajorPhaseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntMajorPhaseCollection = DataRepository.EntMajorPhaseProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.EntMajorPhaseCollection.Count > 0)
				{
					deepHandles.Add("EntMajorPhaseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntMajorPhase>) DataRepository.EntMajorPhaseProvider.DeepLoad,
						new object[] { transactionManager, entity.EntMajorPhaseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicyObserved
			// RelationshipType.OneToOne
			if (CanDeepLoad(entity, "EntPolicyObserved|EntPolicyObserved", deepLoadType, innerList))
			{
				entity.EntPolicyObserved = DataRepository.EntPolicyObservedProvider.GetByEntMainId(transactionManager, entity.EntMainId);
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyObserved' loaded. key " + entity.EntityTrackingKey);
				#endif 

				if (deep && entity.EntPolicyObserved != null)
				{
					deepHandles.Add("EntPolicyObserved",
						new KeyValuePair<Delegate, object>((DeepLoadSingleHandle< EntPolicyObserved >) DataRepository.EntPolicyObservedProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyObserved, deep, deepLoadType, childTypes, innerList }
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

				entity.AdmAppInterviewExamCollection = DataRepository.AdmAppInterviewExamProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.AdmAppInterviewExamCollection.Count > 0)
				{
					deepHandles.Add("AdmAppInterviewExamCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppInterviewExam>) DataRepository.AdmAppInterviewExamProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppInterviewExamCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCourseTopicCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourseTopic>|EdCourseTopicCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseTopicCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseTopicCollection = DataRepository.EdCourseTopicProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.EdCourseTopicCollection.Count > 0)
				{
					deepHandles.Add("EdCourseTopicCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourseTopic>) DataRepository.EdCourseTopicProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseTopicCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoControlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoControl>|CoControlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoControlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoControlCollection = DataRepository.CoControlProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.CoControlCollection.Count > 0)
				{
					deepHandles.Add("CoControlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoControl>) DataRepository.CoControlProvider.DeepLoad,
						new object[] { transactionManager, entity.CoControlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdAcadPlanCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdAcadPlan>|EdAcadPlanCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadPlanCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdAcadPlanCollection = DataRepository.EdAcadPlanProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.EdAcadPlanCollection.Count > 0)
				{
					deepHandles.Add("EdAcadPlanCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdAcadPlan>) DataRepository.EdAcadPlanProvider.DeepLoad,
						new object[] { transactionManager, entity.EdAcadPlanCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTransPrefCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTransPref>|EdStudIntTransPrefCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTransPrefCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTransPrefCollection = DataRepository.EdStudIntTransPrefProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.EdStudIntTransPrefCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTransPrefCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTransPref>) DataRepository.EdStudIntTransPrefProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTransPrefCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmPrecondQualCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmPrecondQual>|AdmPrecondQualCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmPrecondQualCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmPrecondQualCollection = DataRepository.AdmPrecondQualProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.AdmPrecondQualCollection.Count > 0)
				{
					deepHandles.Add("AdmPrecondQualCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmPrecondQual>) DataRepository.AdmPrecondQualProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmPrecondQualCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdStudIntTrnsStateFromCollection = DataRepository.EdStudIntTrnsStateFromProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.EdStudIntTrnsStateFromCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsStateFromCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsStateFrom>) DataRepository.EdStudIntTrnsStateFromProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsStateFromCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoControlRoomCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoControlRoom>|CoControlRoomCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoControlRoomCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoControlRoomCollection = DataRepository.CoControlRoomProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.CoControlRoomCollection.Count > 0)
				{
					deepHandles.Add("CoControlRoomCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoControlRoom>) DataRepository.CoControlRoomProvider.DeepLoad,
						new object[] { transactionManager, entity.CoControlRoomCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.SaScQualCollection = DataRepository.SaScQualProvider.GetByAsNodeId(transactionManager, entity.EntMainId);

				if (deep && entity.SaScQualCollection.Count > 0)
				{
					deepHandles.Add("SaScQualCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaScQual>) DataRepository.SaScQualProvider.DeepLoad,
						new object[] { transactionManager, entity.SaScQualCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntIntroducMdDataCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntIntroducMdData>|EntIntroducMdDataCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntIntroducMdDataCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntIntroducMdDataCollection = DataRepository.EntIntroducMdDataProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.EntIntroducMdDataCollection.Count > 0)
				{
					deepHandles.Add("EntIntroducMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntIntroducMdData>) DataRepository.EntIntroducMdDataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntIntroducMdDataCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntCoursePkgMdDataCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntCoursePkgMdData>|EntCoursePkgMdDataCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCoursePkgMdDataCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntCoursePkgMdDataCollection = DataRepository.EntCoursePkgMdDataProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.EntCoursePkgMdDataCollection.Count > 0)
				{
					deepHandles.Add("EntCoursePkgMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntCoursePkgMdData>) DataRepository.EntCoursePkgMdDataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntCoursePkgMdDataCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmTansikMajorsCodesCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmTansikMajorsCodes>|AdmTansikMajorsCodesCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmTansikMajorsCodesCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmTansikMajorsCodesCollection = DataRepository.AdmTansikMajorsCodesProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.AdmTansikMajorsCodesCollection.Count > 0)
				{
					deepHandles.Add("AdmTansikMajorsCodesCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmTansikMajorsCodes>) DataRepository.AdmTansikMajorsCodesProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmTansikMajorsCodesCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPrecondMdDataCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPrecondMdData>|EntPrecondMdDataCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPrecondMdDataCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPrecondMdDataCollection = DataRepository.EntPrecondMdDataProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.EntPrecondMdDataCollection.Count > 0)
				{
					deepHandles.Add("EntPrecondMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPrecondMdData>) DataRepository.EntPrecondMdDataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPrecondMdDataCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmCdeFeeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmCdeFee>|AdmCdeFeeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeFeeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmCdeFeeCollection = DataRepository.AdmCdeFeeProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.AdmCdeFeeCollection.Count > 0)
				{
					deepHandles.Add("AdmCdeFeeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmCdeFee>) DataRepository.AdmCdeFeeProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmCdeFeeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudStateCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudState>|EdStudStateCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudStateCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudStateCollection = DataRepository.EdStudStateProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.EdStudStateCollection.Count > 0)
				{
					deepHandles.Add("EdStudStateCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudState>) DataRepository.EdStudStateProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudStateCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsCommCollectionGetByEntMainMinorId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsComm>|GsCommCollectionGetByEntMainMinorId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCommCollectionGetByEntMainMinorId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCommCollectionGetByEntMainMinorId = DataRepository.GsCommProvider.GetByEntMainMinorId(transactionManager, entity.EntMainId);

				if (deep && entity.GsCommCollectionGetByEntMainMinorId.Count > 0)
				{
					deepHandles.Add("GsCommCollectionGetByEntMainMinorId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsComm>) DataRepository.GsCommProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCommCollectionGetByEntMainMinorId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppPrefCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppPref>|AdmAppPrefCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppPrefCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppPrefCollection = DataRepository.AdmAppPrefProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.AdmAppPrefCollection.Count > 0)
				{
					deepHandles.Add("AdmAppPrefCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppPref>) DataRepository.AdmAppPrefProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppPrefCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdSemesterOpenCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdSemesterOpen>|EdSemesterOpenCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdSemesterOpenCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdSemesterOpenCollection = DataRepository.EdSemesterOpenProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.EdSemesterOpenCollection.Count > 0)
				{
					deepHandles.Add("EdSemesterOpenCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdSemesterOpen>) DataRepository.EdSemesterOpenProvider.DeepLoad,
						new object[] { transactionManager, entity.EdSemesterOpenCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvPollHdrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvPollHdr>|SvPollHdrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvPollHdrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvPollHdrCollection = DataRepository.SvPollHdrProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.SvPollHdrCollection.Count > 0)
				{
					deepHandles.Add("SvPollHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvPollHdr>) DataRepository.SvPollHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.SvPollHdrCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.SaTrainingCourseCollection = DataRepository.SaTrainingCourseProvider.GetByAsNodeId(transactionManager, entity.EntMainId);

				if (deep && entity.SaTrainingCourseCollection.Count > 0)
				{
					deepHandles.Add("SaTrainingCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaTrainingCourse>) DataRepository.SaTrainingCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.SaTrainingCourseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppTransReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppTransReq>|AdmAppTransReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppTransReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppTransReqCollection = DataRepository.AdmAppTransReqProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.AdmAppTransReqCollection.Count > 0)
				{
					deepHandles.Add("AdmAppTransReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppTransReq>) DataRepository.AdmAppTransReqProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppTransReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntCoursePkgHdrCollectionGetByEntMainSpcRltdId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntCoursePkgHdr>|EntCoursePkgHdrCollectionGetByEntMainSpcRltdId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCoursePkgHdrCollectionGetByEntMainSpcRltdId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntCoursePkgHdrCollectionGetByEntMainSpcRltdId = DataRepository.EntCoursePkgHdrProvider.GetByEntMainSpcRltdId(transactionManager, entity.EntMainId);

				if (deep && entity.EntCoursePkgHdrCollectionGetByEntMainSpcRltdId.Count > 0)
				{
					deepHandles.Add("EntCoursePkgHdrCollectionGetByEntMainSpcRltdId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntCoursePkgHdr>) DataRepository.EntCoursePkgHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.EntCoursePkgHdrCollectionGetByEntMainSpcRltdId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudFacultyCollectionGetByEntMainGrad3
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudFaculty>|EdStudFacultyCollectionGetByEntMainGrad3", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudFacultyCollectionGetByEntMainGrad3' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudFacultyCollectionGetByEntMainGrad3 = DataRepository.EdStudFacultyProvider.GetByEntMainGrad3(transactionManager, entity.EntMainId);

				if (deep && entity.EdStudFacultyCollectionGetByEntMainGrad3.Count > 0)
				{
					deepHandles.Add("EdStudFacultyCollectionGetByEntMainGrad3",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudFaculty>) DataRepository.EdStudFacultyProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudFacultyCollectionGetByEntMainGrad3, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgOfferingCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgOffering>|PgOfferingCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgOfferingCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgOfferingCollection = DataRepository.PgOfferingProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.PgOfferingCollection.Count > 0)
				{
					deepHandles.Add("PgOfferingCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgOffering>) DataRepository.PgOfferingProvider.DeepLoad,
						new object[] { transactionManager, entity.PgOfferingCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntCoursePkgHdrCollectionGetByEntMainId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntCoursePkgHdr>|EntCoursePkgHdrCollectionGetByEntMainId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCoursePkgHdrCollectionGetByEntMainId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntCoursePkgHdrCollectionGetByEntMainId = DataRepository.EntCoursePkgHdrProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.EntCoursePkgHdrCollectionGetByEntMainId.Count > 0)
				{
					deepHandles.Add("EntCoursePkgHdrCollectionGetByEntMainId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntCoursePkgHdr>) DataRepository.EntCoursePkgHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.EntCoursePkgHdrCollectionGetByEntMainId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdOutcomeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdOutcome>|EdOutcomeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdOutcomeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdOutcomeCollection = DataRepository.EdOutcomeProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.EdOutcomeCollection.Count > 0)
				{
					deepHandles.Add("EdOutcomeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdOutcome>) DataRepository.EdOutcomeProvider.DeepLoad,
						new object[] { transactionManager, entity.EdOutcomeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmCdeAppStatusCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmCdeAppStatus>|AdmCdeAppStatusCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeAppStatusCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmCdeAppStatusCollection = DataRepository.AdmCdeAppStatusProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.AdmCdeAppStatusCollection.Count > 0)
				{
					deepHandles.Add("AdmCdeAppStatusCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmCdeAppStatus>) DataRepository.AdmCdeAppStatusProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmCdeAppStatusCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdStudGrantTempCollection = DataRepository.EdStudGrantTempProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.EdStudGrantTempCollection.Count > 0)
				{
					deepHandles.Add("EdStudGrantTempCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudGrantTemp>) DataRepository.EdStudGrantTempProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudGrantTempCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdBranchRuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdBranchRule>|EdBranchRuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdBranchRuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdBranchRuleCollection = DataRepository.EdBranchRuleProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.EdBranchRuleCollection.Count > 0)
				{
					deepHandles.Add("EdBranchRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdBranchRule>) DataRepository.EdBranchRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.EdBranchRuleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeFacultyRuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeFacultyRule>|FeeFacultyRuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeFacultyRuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeFacultyRuleCollection = DataRepository.FeeFacultyRuleProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.FeeFacultyRuleCollection.Count > 0)
				{
					deepHandles.Add("FeeFacultyRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeFacultyRule>) DataRepository.FeeFacultyRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeFacultyRuleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntMainMatrixCollectionGetByEntMainId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntMainMatrix>|EntMainMatrixCollectionGetByEntMainId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMainMatrixCollectionGetByEntMainId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntMainMatrixCollectionGetByEntMainId = DataRepository.EntMainMatrixProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.EntMainMatrixCollectionGetByEntMainId.Count > 0)
				{
					deepHandles.Add("EntMainMatrixCollectionGetByEntMainId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntMainMatrix>) DataRepository.EntMainMatrixProvider.DeepLoad,
						new object[] { transactionManager, entity.EntMainMatrixCollectionGetByEntMainId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvStaffEvlCollectionGetByEntMainMinorId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStaffEvl>|SvStaffEvlCollectionGetByEntMainMinorId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStaffEvlCollectionGetByEntMainMinorId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStaffEvlCollectionGetByEntMainMinorId = DataRepository.SvStaffEvlProvider.GetByEntMainMinorId(transactionManager, entity.EntMainId);

				if (deep && entity.SvStaffEvlCollectionGetByEntMainMinorId.Count > 0)
				{
					deepHandles.Add("SvStaffEvlCollectionGetByEntMainMinorId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStaffEvl>) DataRepository.SvStaffEvlProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStaffEvlCollectionGetByEntMainMinorId, deep, deepLoadType, childTypes, innerList }
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

				entity.SaExperienceCollection = DataRepository.SaExperienceProvider.GetByAsNodeId(transactionManager, entity.EntMainId);

				if (deep && entity.SaExperienceCollection.Count > 0)
				{
					deepHandles.Add("SaExperienceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaExperience>) DataRepository.SaExperienceProvider.DeepLoad,
						new object[] { transactionManager, entity.SaExperienceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntGraduationReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntGraduationReq>|EntGraduationReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntGraduationReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntGraduationReqCollection = DataRepository.EntGraduationReqProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.EntGraduationReqCollection.Count > 0)
				{
					deepHandles.Add("EntGraduationReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntGraduationReq>) DataRepository.EntGraduationReqProvider.DeepLoad,
						new object[] { transactionManager, entity.EntGraduationReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntMainMatrixCollectionGetByEntMainSpecId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntMainMatrix>|EntMainMatrixCollectionGetByEntMainSpecId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMainMatrixCollectionGetByEntMainSpecId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntMainMatrixCollectionGetByEntMainSpecId = DataRepository.EntMainMatrixProvider.GetByEntMainSpecId(transactionManager, entity.EntMainId);

				if (deep && entity.EntMainMatrixCollectionGetByEntMainSpecId.Count > 0)
				{
					deepHandles.Add("EntMainMatrixCollectionGetByEntMainSpecId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntMainMatrix>) DataRepository.EntMainMatrixProvider.DeepLoad,
						new object[] { transactionManager, entity.EntMainMatrixCollectionGetByEntMainSpecId, deep, deepLoadType, childTypes, innerList }
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

				entity.EdStudGrantDegreeCollection = DataRepository.EdStudGrantDegreeProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.EdStudGrantDegreeCollection.Count > 0)
				{
					deepHandles.Add("EdStudGrantDegreeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudGrantDegree>) DataRepository.EdStudGrantDegreeProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudGrantDegreeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvCourseEvalCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvCourseEval>|SvCourseEvalCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCourseEvalCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvCourseEvalCollection = DataRepository.SvCourseEvalProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.SvCourseEvalCollection.Count > 0)
				{
					deepHandles.Add("SvCourseEvalCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvCourseEval>) DataRepository.SvCourseEvalProvider.DeepLoad,
						new object[] { transactionManager, entity.SvCourseEvalCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdAcadPlanHdrCollectionGetByEntMainSpcRltdId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdAcadPlanHdr>|EdAcadPlanHdrCollectionGetByEntMainSpcRltdId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadPlanHdrCollectionGetByEntMainSpcRltdId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdAcadPlanHdrCollectionGetByEntMainSpcRltdId = DataRepository.EdAcadPlanHdrProvider.GetByEntMainSpcRltdId(transactionManager, entity.EntMainId);

				if (deep && entity.EdAcadPlanHdrCollectionGetByEntMainSpcRltdId.Count > 0)
				{
					deepHandles.Add("EdAcadPlanHdrCollectionGetByEntMainSpcRltdId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdAcadPlanHdr>) DataRepository.EdAcadPlanHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.EdAcadPlanHdrCollectionGetByEntMainSpcRltdId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaStfMemberCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaStfMember>|SaStfMemberCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaStfMemberCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaStfMemberCollection = DataRepository.SaStfMemberProvider.GetByAsNodeId(transactionManager, entity.EntMainId);

				if (deep && entity.SaStfMemberCollection.Count > 0)
				{
					deepHandles.Add("SaStfMemberCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaStfMember>) DataRepository.SaStfMemberProvider.DeepLoad,
						new object[] { transactionManager, entity.SaStfMemberCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntGradingMdDataCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntGradingMdData>|EntGradingMdDataCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntGradingMdDataCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntGradingMdDataCollection = DataRepository.EntGradingMdDataProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.EntGradingMdDataCollection.Count > 0)
				{
					deepHandles.Add("EntGradingMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntGradingMdData>) DataRepository.EntGradingMdDataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntGradingMdDataCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntMainMatrixCollectionGetByEntMainMinorId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntMainMatrix>|EntMainMatrixCollectionGetByEntMainMinorId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMainMatrixCollectionGetByEntMainMinorId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntMainMatrixCollectionGetByEntMainMinorId = DataRepository.EntMainMatrixProvider.GetByEntMainMinorId(transactionManager, entity.EntMainId);

				if (deep && entity.EntMainMatrixCollectionGetByEntMainMinorId.Count > 0)
				{
					deepHandles.Add("EntMainMatrixCollectionGetByEntMainMinorId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntMainMatrix>) DataRepository.EntMainMatrixProvider.DeepLoad,
						new object[] { transactionManager, entity.EntMainMatrixCollectionGetByEntMainMinorId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdOfferingCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdOffering>|EdOfferingCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdOfferingCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdOfferingCollection = DataRepository.EdOfferingProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.EdOfferingCollection.Count > 0)
				{
					deepHandles.Add("EdOfferingCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdOffering>) DataRepository.EdOfferingProvider.DeepLoad,
						new object[] { transactionManager, entity.EdOfferingCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdBylawCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdBylaw>|EdBylawCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdBylawCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdBylawCollection = DataRepository.EdBylawProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.EdBylawCollection.Count > 0)
				{
					deepHandles.Add("EdBylawCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdBylaw>) DataRepository.EdBylawProvider.DeepLoad,
						new object[] { transactionManager, entity.EdBylawCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudFacultyCollectionGetByEntMainGrad2
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudFaculty>|EdStudFacultyCollectionGetByEntMainGrad2", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudFacultyCollectionGetByEntMainGrad2' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudFacultyCollectionGetByEntMainGrad2 = DataRepository.EdStudFacultyProvider.GetByEntMainGrad2(transactionManager, entity.EntMainId);

				if (deep && entity.EdStudFacultyCollectionGetByEntMainGrad2.Count > 0)
				{
					deepHandles.Add("EdStudFacultyCollectionGetByEntMainGrad2",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudFaculty>) DataRepository.EdStudFacultyProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudFacultyCollectionGetByEntMainGrad2, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntMainMatrixCollectionGetByEntMainMajorId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntMainMatrix>|EntMainMatrixCollectionGetByEntMainMajorId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMainMatrixCollectionGetByEntMainMajorId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntMainMatrixCollectionGetByEntMainMajorId = DataRepository.EntMainMatrixProvider.GetByEntMainMajorId(transactionManager, entity.EntMainId);

				if (deep && entity.EntMainMatrixCollectionGetByEntMainMajorId.Count > 0)
				{
					deepHandles.Add("EntMainMatrixCollectionGetByEntMainMajorId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntMainMatrix>) DataRepository.EntMainMatrixProvider.DeepLoad,
						new object[] { transactionManager, entity.EntMainMatrixCollectionGetByEntMainMajorId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeUserCrsAssessCollectionGetByEntMainDeptId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeUserCrsAssess>|SeUserCrsAssessCollectionGetByEntMainDeptId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserCrsAssessCollectionGetByEntMainDeptId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeUserCrsAssessCollectionGetByEntMainDeptId = DataRepository.SeUserCrsAssessProvider.GetByEntMainDeptId(transactionManager, entity.EntMainId);

				if (deep && entity.SeUserCrsAssessCollectionGetByEntMainDeptId.Count > 0)
				{
					deepHandles.Add("SeUserCrsAssessCollectionGetByEntMainDeptId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeUserCrsAssess>) DataRepository.SeUserCrsAssessProvider.DeepLoad,
						new object[] { transactionManager, entity.SeUserCrsAssessCollectionGetByEntMainDeptId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeSemesterAgendaCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeSemesterAgenda>|FeeSemesterAgendaCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeSemesterAgendaCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeSemesterAgendaCollection = DataRepository.FeeSemesterAgendaProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.FeeSemesterAgendaCollection.Count > 0)
				{
					deepHandles.Add("FeeSemesterAgendaCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeSemesterAgenda>) DataRepository.FeeSemesterAgendaProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeSemesterAgendaCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppCountCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppCount>|AdmAppCountCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppCountCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppCountCollection = DataRepository.AdmAppCountProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.AdmAppCountCollection.Count > 0)
				{
					deepHandles.Add("AdmAppCountCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppCount>) DataRepository.AdmAppCountProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppCountCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.SaSupervisingJobsCollection = DataRepository.SaSupervisingJobsProvider.GetByAsNodeId(transactionManager, entity.EntMainId);

				if (deep && entity.SaSupervisingJobsCollection.Count > 0)
				{
					deepHandles.Add("SaSupervisingJobsCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaSupervisingJobs>) DataRepository.SaSupervisingJobsProvider.DeepLoad,
						new object[] { transactionManager, entity.SaSupervisingJobsCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeUserCrsAssessCollectionGetByEntMainMajorId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeUserCrsAssess>|SeUserCrsAssessCollectionGetByEntMainMajorId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserCrsAssessCollectionGetByEntMainMajorId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeUserCrsAssessCollectionGetByEntMainMajorId = DataRepository.SeUserCrsAssessProvider.GetByEntMainMajorId(transactionManager, entity.EntMainId);

				if (deep && entity.SeUserCrsAssessCollectionGetByEntMainMajorId.Count > 0)
				{
					deepHandles.Add("SeUserCrsAssessCollectionGetByEntMainMajorId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeUserCrsAssess>) DataRepository.SeUserCrsAssessProvider.DeepLoad,
						new object[] { transactionManager, entity.SeUserCrsAssessCollectionGetByEntMainMajorId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdResultApproveCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdResultApprove>|EdResultApproveCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdResultApproveCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdResultApproveCollection = DataRepository.EdResultApproveProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.EdResultApproveCollection.Count > 0)
				{
					deepHandles.Add("EdResultApproveCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdResultApprove>) DataRepository.EdResultApproveProvider.DeepLoad,
						new object[] { transactionManager, entity.EdResultApproveCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCoursePrfxCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCoursePrfx>|EdCoursePrfxCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCoursePrfxCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCoursePrfxCollection = DataRepository.EdCoursePrfxProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.EdCoursePrfxCollection.Count > 0)
				{
					deepHandles.Add("EdCoursePrfxCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCoursePrfx>) DataRepository.EdCoursePrfxProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCoursePrfxCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisGeneralSpecCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisGeneralSpec>|PgThesisGeneralSpecCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisGeneralSpecCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisGeneralSpecCollection = DataRepository.PgThesisGeneralSpecProvider.GetByAsNodeId(transactionManager, entity.EntMainId);

				if (deep && entity.PgThesisGeneralSpecCollection.Count > 0)
				{
					deepHandles.Add("PgThesisGeneralSpecCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisGeneralSpec>) DataRepository.PgThesisGeneralSpecProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisGeneralSpecCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdAcadPlanHdrCollectionGetByEntMainRltdId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdAcadPlanHdr>|EdAcadPlanHdrCollectionGetByEntMainRltdId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadPlanHdrCollectionGetByEntMainRltdId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdAcadPlanHdrCollectionGetByEntMainRltdId = DataRepository.EdAcadPlanHdrProvider.GetByEntMainRltdId(transactionManager, entity.EntMainId);

				if (deep && entity.EdAcadPlanHdrCollectionGetByEntMainRltdId.Count > 0)
				{
					deepHandles.Add("EdAcadPlanHdrCollectionGetByEntMainRltdId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdAcadPlanHdr>) DataRepository.EdAcadPlanHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.EdAcadPlanHdrCollectionGetByEntMainRltdId, deep, deepLoadType, childTypes, innerList }
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

				entity.EdStudStateTempCollection = DataRepository.EdStudStateTempProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.EdStudStateTempCollection.Count > 0)
				{
					deepHandles.Add("EdStudStateTempCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudStateTemp>) DataRepository.EdStudStateTempProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudStateTempCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmRatingParametersMajorsCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmRatingParametersMajors>|AdmRatingParametersMajorsCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmRatingParametersMajorsCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmRatingParametersMajorsCollection = DataRepository.AdmRatingParametersMajorsProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.AdmRatingParametersMajorsCollection.Count > 0)
				{
					deepHandles.Add("AdmRatingParametersMajorsCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmRatingParametersMajors>) DataRepository.AdmRatingParametersMajorsProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmRatingParametersMajorsCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmPlaceExamDatetimeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmPlaceExamDatetime>|AdmPlaceExamDatetimeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmPlaceExamDatetimeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmPlaceExamDatetimeCollection = DataRepository.AdmPlaceExamDatetimeProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.AdmPlaceExamDatetimeCollection.Count > 0)
				{
					deepHandles.Add("AdmPlaceExamDatetimeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmPlaceExamDatetime>) DataRepository.AdmPlaceExamDatetimeProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmPlaceExamDatetimeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourse>|EdCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseCollection = DataRepository.EdCourseProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.EdCourseCollection.Count > 0)
				{
					deepHandles.Add("EdCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourse>) DataRepository.EdCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeUserAccntCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeUserAccnt>|SeUserAccntCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserAccntCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeUserAccntCollection = DataRepository.SeUserAccntProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.SeUserAccntCollection.Count > 0)
				{
					deepHandles.Add("SeUserAccntCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeUserAccnt>) DataRepository.SeUserAccntProvider.DeepLoad,
						new object[] { transactionManager, entity.SeUserAccntCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.SaEmpHierarchyCollection = DataRepository.SaEmpHierarchyProvider.GetByAsNodeId(transactionManager, entity.EntMainId);

				if (deep && entity.SaEmpHierarchyCollection.Count > 0)
				{
					deepHandles.Add("SaEmpHierarchyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaEmpHierarchy>) DataRepository.SaEmpHierarchyProvider.DeepLoad,
						new object[] { transactionManager, entity.SaEmpHierarchyCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudBranchPrefCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudBranchPref>|EdStudBranchPrefCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudBranchPrefCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudBranchPrefCollection = DataRepository.EdStudBranchPrefProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.EdStudBranchPrefCollection.Count > 0)
				{
					deepHandles.Add("EdStudBranchPrefCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudBranchPref>) DataRepository.EdStudBranchPrefProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudBranchPrefCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntityMainCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntityMain>|EntityMainCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntityMainCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntityMainCollection = DataRepository.EntityMainProvider.GetByEntParentId(transactionManager, entity.EntMainId);

				if (deep && entity.EntityMainCollection.Count > 0)
				{
					deepHandles.Add("EntityMainCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntityMain>) DataRepository.EntityMainProvider.DeepLoad,
						new object[] { transactionManager, entity.EntityMainCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.SaExtDelCollection = DataRepository.SaExtDelProvider.GetByAsNodeId(transactionManager, entity.EntMainId);

				if (deep && entity.SaExtDelCollection.Count > 0)
				{
					deepHandles.Add("SaExtDelCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaExtDel>) DataRepository.SaExtDelProvider.DeepLoad,
						new object[] { transactionManager, entity.SaExtDelCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScScheduleRsrvCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScScheduleRsrv>|ScScheduleRsrvCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScScheduleRsrvCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScScheduleRsrvCollection = DataRepository.ScScheduleRsrvProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.ScScheduleRsrvCollection.Count > 0)
				{
					deepHandles.Add("ScScheduleRsrvCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScScheduleRsrv>) DataRepository.ScScheduleRsrvProvider.DeepLoad,
						new object[] { transactionManager, entity.ScScheduleRsrvCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScSchdlPeriodCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScSchdlPeriod>|ScSchdlPeriodCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScSchdlPeriodCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScSchdlPeriodCollection = DataRepository.ScSchdlPeriodProvider.GetByEntMainMjrId(transactionManager, entity.EntMainId);

				if (deep && entity.ScSchdlPeriodCollection.Count > 0)
				{
					deepHandles.Add("ScSchdlPeriodCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScSchdlPeriod>) DataRepository.ScSchdlPeriodProvider.DeepLoad,
						new object[] { transactionManager, entity.ScSchdlPeriodCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.SeBlockTransCollection = DataRepository.SeBlockTransProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.SeBlockTransCollection.Count > 0)
				{
					deepHandles.Add("SeBlockTransCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeBlockTrans>) DataRepository.SeBlockTransProvider.DeepLoad,
						new object[] { transactionManager, entity.SeBlockTransCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScGroupInfoCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScGroupInfo>|ScGroupInfoCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScGroupInfoCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScGroupInfoCollection = DataRepository.ScGroupInfoProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.ScGroupInfoCollection.Count > 0)
				{
					deepHandles.Add("ScGroupInfoCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScGroupInfo>) DataRepository.ScGroupInfoProvider.DeepLoad,
						new object[] { transactionManager, entity.ScGroupInfoCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolcyGrdngHdrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolcyGrdngHdr>|EntPolcyGrdngHdrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolcyGrdngHdrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolcyGrdngHdrCollection = DataRepository.EntPolcyGrdngHdrProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.EntPolcyGrdngHdrCollection.Count > 0)
				{
					deepHandles.Add("EntPolcyGrdngHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolcyGrdngHdr>) DataRepository.EntPolcyGrdngHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolcyGrdngHdrCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdInttransRuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdInttransRule>|EdInttransRuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdInttransRuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdInttransRuleCollection = DataRepository.EdInttransRuleProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.EdInttransRuleCollection.Count > 0)
				{
					deepHandles.Add("EdInttransRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdInttransRule>) DataRepository.EdInttransRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.EdInttransRuleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntCourseMdDataCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntCourseMdData>|EntCourseMdDataCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCourseMdDataCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntCourseMdDataCollection = DataRepository.EntCourseMdDataProvider.GetByEntMainId(transactionManager, entity.EntMainId);

				if (deep && entity.EntCourseMdDataCollection.Count > 0)
				{
					deepHandles.Add("EntCourseMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntCourseMdData>) DataRepository.EntCourseMdDataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntCourseMdDataCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsCommCollectionGetByEntMainMajorId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsComm>|GsCommCollectionGetByEntMainMajorId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCommCollectionGetByEntMainMajorId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCommCollectionGetByEntMainMajorId = DataRepository.GsCommProvider.GetByEntMainMajorId(transactionManager, entity.EntMainId);

				if (deep && entity.GsCommCollectionGetByEntMainMajorId.Count > 0)
				{
					deepHandles.Add("GsCommCollectionGetByEntMainMajorId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsComm>) DataRepository.GsCommProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCommCollectionGetByEntMainMajorId, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntityMain object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntityMain instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntityMain Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntityMain entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
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
			
			#region EdCodeLevelIdSource
			if (CanDeepSave(entity, "EdCodeLevel|EdCodeLevelIdSource", deepSaveType, innerList) 
				&& entity.EdCodeLevelIdSource != null)
			{
				DataRepository.EdCodeLevelProvider.Save(transactionManager, entity.EdCodeLevelIdSource);
				entity.EdCodeLevelId = entity.EdCodeLevelIdSource.EdCodeLevelId;
			}
			#endregion 
			
			#region EdStudyMethodIdSource
			if (CanDeepSave(entity, "EdCodeStudyMethod|EdStudyMethodIdSource", deepSaveType, innerList) 
				&& entity.EdStudyMethodIdSource != null)
			{
				DataRepository.EdCodeStudyMethodProvider.Save(transactionManager, entity.EdStudyMethodIdSource);
				entity.EdStudyMethodId = entity.EdStudyMethodIdSource.EdCodeStudyMethodId;
			}
			#endregion 
			
			#region EntCodeEntityTypeIdSource
			if (CanDeepSave(entity, "EntCodeEntityType|EntCodeEntityTypeIdSource", deepSaveType, innerList) 
				&& entity.EntCodeEntityTypeIdSource != null)
			{
				DataRepository.EntCodeEntityTypeProvider.Save(transactionManager, entity.EntCodeEntityTypeIdSource);
				entity.EntCodeEntityTypeId = entity.EntCodeEntityTypeIdSource.EntCodeEntityTypeId;
			}
			#endregion 
			
			#region EntParentIdSource
			if (CanDeepSave(entity, "EntityMain|EntParentIdSource", deepSaveType, innerList) 
				&& entity.EntParentIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.EntParentIdSource);
				entity.EntParentId = entity.EntParentIdSource.EntMainId;
			}
			#endregion 
			
			#region GsCdeSpecAreaIdSource
			if (CanDeepSave(entity, "GsCdeSpecArea|GsCdeSpecAreaIdSource", deepSaveType, innerList) 
				&& entity.GsCdeSpecAreaIdSource != null)
			{
				DataRepository.GsCdeSpecAreaProvider.Save(transactionManager, entity.GsCdeSpecAreaIdSource);
				entity.GsCdeSpecAreaId = entity.GsCdeSpecAreaIdSource.GsCdeSpecAreaId;
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
			
			#region GsCodeLanguageIdSource
			if (CanDeepSave(entity, "GsCodeLanguage|GsCodeLanguageIdSource", deepSaveType, innerList) 
				&& entity.GsCodeLanguageIdSource != null)
			{
				DataRepository.GsCodeLanguageProvider.Save(transactionManager, entity.GsCodeLanguageIdSource);
				entity.GsCodeLanguageId = entity.GsCodeLanguageIdSource.GsCodeLanguageId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();

			#region EntPolicyObserved
			if (CanDeepSave(entity.EntPolicyObserved, "EntPolicyObserved|EntPolicyObserved", deepSaveType, innerList))
			{

				if (entity.EntPolicyObserved != null)
				{
					// update each child parent id with the real parent id (mostly used on insert)

					entity.EntPolicyObserved.EntMainId = entity.EntMainId;
					//DataRepository.EntPolicyObservedProvider.Save(transactionManager, entity.EntPolicyObserved);
					deepHandles.Add("EntPolicyObserved",
						new KeyValuePair<Delegate, object>((DeepSaveSingleHandle< EntPolicyObserved >) DataRepository.EntPolicyObservedProvider.DeepSave,
						new object[] { transactionManager, entity.EntPolicyObserved, deepSaveType, childTypes, innerList }
					));
				}
			} 
			#endregion 
	
			#region List<EdStudFaculty>
				if (CanDeepSave(entity.EdStudFacultyCollectionGetByEntMainGrad1, "List<EdStudFaculty>|EdStudFacultyCollectionGetByEntMainGrad1", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudFaculty child in entity.EdStudFacultyCollectionGetByEntMainGrad1)
					{
						if(child.EntMainGrad1Source != null)
						{
							child.EntMainGrad1 = child.EntMainGrad1Source.EntMainId;
						}
						else
						{
							child.EntMainGrad1 = entity.EntMainId;
						}

					}

					if (entity.EdStudFacultyCollectionGetByEntMainGrad1.Count > 0 || entity.EdStudFacultyCollectionGetByEntMainGrad1.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudFacultyProvider.Save(transactionManager, entity.EdStudFacultyCollectionGetByEntMainGrad1);
						
						deepHandles.Add("EdStudFacultyCollectionGetByEntMainGrad1",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudFaculty >) DataRepository.EdStudFacultyProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudFacultyCollectionGetByEntMainGrad1, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvStaffEvl>
				if (CanDeepSave(entity.SvStaffEvlCollectionGetByEntMainMajorId, "List<SvStaffEvl>|SvStaffEvlCollectionGetByEntMainMajorId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStaffEvl child in entity.SvStaffEvlCollectionGetByEntMainMajorId)
					{
						if(child.EntMainMajorIdSource != null)
						{
							child.EntMainMajorId = child.EntMainMajorIdSource.EntMainId;
						}
						else
						{
							child.EntMainMajorId = entity.EntMainId;
						}

					}

					if (entity.SvStaffEvlCollectionGetByEntMainMajorId.Count > 0 || entity.SvStaffEvlCollectionGetByEntMainMajorId.DeletedItems.Count > 0)
					{
						//DataRepository.SvStaffEvlProvider.Save(transactionManager, entity.SvStaffEvlCollectionGetByEntMainMajorId);
						
						deepHandles.Add("SvStaffEvlCollectionGetByEntMainMajorId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStaffEvl >) DataRepository.SvStaffEvlProvider.DeepSave,
							new object[] { transactionManager, entity.SvStaffEvlCollectionGetByEntMainMajorId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvStaffEvl>
				if (CanDeepSave(entity.SvStaffEvlCollectionGetByEntMainId, "List<SvStaffEvl>|SvStaffEvlCollectionGetByEntMainId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStaffEvl child in entity.SvStaffEvlCollectionGetByEntMainId)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.SvStaffEvlCollectionGetByEntMainId.Count > 0 || entity.SvStaffEvlCollectionGetByEntMainId.DeletedItems.Count > 0)
					{
						//DataRepository.SvStaffEvlProvider.Save(transactionManager, entity.SvStaffEvlCollectionGetByEntMainId);
						
						deepHandles.Add("SvStaffEvlCollectionGetByEntMainId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStaffEvl >) DataRepository.SvStaffEvlProvider.DeepSave,
							new object[] { transactionManager, entity.SvStaffEvlCollectionGetByEntMainId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolicyMdData>
				if (CanDeepSave(entity.EntPolicyMdDataCollection, "List<EntPolicyMdData>|EntPolicyMdDataCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyMdData child in entity.EntPolicyMdDataCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.EntPolicyMdDataCollection.Count > 0 || entity.EntPolicyMdDataCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyMdDataProvider.Save(transactionManager, entity.EntPolicyMdDataCollection);
						
						deepHandles.Add("EntPolicyMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyMdData >) DataRepository.EntPolicyMdDataProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyMdDataCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntFullfillMdData>
				if (CanDeepSave(entity.EntFullfillMdDataCollection, "List<EntFullfillMdData>|EntFullfillMdDataCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntFullfillMdData child in entity.EntFullfillMdDataCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.EntFullfillMdDataCollection.Count > 0 || entity.EntFullfillMdDataCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntFullfillMdDataProvider.Save(transactionManager, entity.EntFullfillMdDataCollection);
						
						deepHandles.Add("EntFullfillMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntFullfillMdData >) DataRepository.EntFullfillMdDataProvider.DeepSave,
							new object[] { transactionManager, entity.EntFullfillMdDataCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolicyGradingLevel>
				if (CanDeepSave(entity.EntPolicyGradingLevelCollection, "List<EntPolicyGradingLevel>|EntPolicyGradingLevelCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyGradingLevel child in entity.EntPolicyGradingLevelCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.EntPolicyGradingLevelCollection.Count > 0 || entity.EntPolicyGradingLevelCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyGradingLevelProvider.Save(transactionManager, entity.EntPolicyGradingLevelCollection);
						
						deepHandles.Add("EntPolicyGradingLevelCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyGradingLevel >) DataRepository.EntPolicyGradingLevelProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyGradingLevelCollection, deepSaveType, childTypes, innerList }
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
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
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
				
	
			#region List<FeeFacultyInstallment>
				if (CanDeepSave(entity.FeeFacultyInstallmentCollection, "List<FeeFacultyInstallment>|FeeFacultyInstallmentCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeFacultyInstallment child in entity.FeeFacultyInstallmentCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.FeeFacultyInstallmentCollection.Count > 0 || entity.FeeFacultyInstallmentCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeFacultyInstallmentProvider.Save(transactionManager, entity.FeeFacultyInstallmentCollection);
						
						deepHandles.Add("FeeFacultyInstallmentCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeFacultyInstallment >) DataRepository.FeeFacultyInstallmentProvider.DeepSave,
							new object[] { transactionManager, entity.FeeFacultyInstallmentCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmReqDoc>
				if (CanDeepSave(entity.AdmReqDocCollection, "List<AdmReqDoc>|AdmReqDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmReqDoc child in entity.AdmReqDocCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.AdmReqDocCollection.Count > 0 || entity.AdmReqDocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmReqDocProvider.Save(transactionManager, entity.AdmReqDocCollection);
						
						deepHandles.Add("AdmReqDocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmReqDoc >) DataRepository.AdmReqDocProvider.DeepSave,
							new object[] { transactionManager, entity.AdmReqDocCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCourseOrient>
				if (CanDeepSave(entity.EdCourseOrientCollection, "List<EdCourseOrient>|EdCourseOrientCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourseOrient child in entity.EdCourseOrientCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.EdCourseOrientCollection.Count > 0 || entity.EdCourseOrientCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseOrientProvider.Save(transactionManager, entity.EdCourseOrientCollection);
						
						deepHandles.Add("EdCourseOrientCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourseOrient >) DataRepository.EdCourseOrientProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseOrientCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdProject>
				if (CanDeepSave(entity.EdProjectCollection, "List<EdProject>|EdProjectCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdProject child in entity.EdProjectCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.EdProjectCollection.Count > 0 || entity.EdProjectCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdProjectProvider.Save(transactionManager, entity.EdProjectCollection);
						
						deepHandles.Add("EdProjectCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdProject >) DataRepository.EdProjectProvider.DeepSave,
							new object[] { transactionManager, entity.EdProjectCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmCdePlacementExam>
				if (CanDeepSave(entity.AdmCdePlacementExamCollection, "List<AdmCdePlacementExam>|AdmCdePlacementExamCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmCdePlacementExam child in entity.AdmCdePlacementExamCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.AdmCdePlacementExamCollection.Count > 0 || entity.AdmCdePlacementExamCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmCdePlacementExamProvider.Save(transactionManager, entity.AdmCdePlacementExamCollection);
						
						deepHandles.Add("AdmCdePlacementExamCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmCdePlacementExam >) DataRepository.AdmCdePlacementExamProvider.DeepSave,
							new object[] { transactionManager, entity.AdmCdePlacementExamCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntCoursePkgHdr>
				if (CanDeepSave(entity.EntCoursePkgHdrCollectionGetByEntMainRltdId, "List<EntCoursePkgHdr>|EntCoursePkgHdrCollectionGetByEntMainRltdId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntCoursePkgHdr child in entity.EntCoursePkgHdrCollectionGetByEntMainRltdId)
					{
						if(child.EntMainRltdIdSource != null)
						{
							child.EntMainRltdId = child.EntMainRltdIdSource.EntMainId;
						}
						else
						{
							child.EntMainRltdId = entity.EntMainId;
						}

					}

					if (entity.EntCoursePkgHdrCollectionGetByEntMainRltdId.Count > 0 || entity.EntCoursePkgHdrCollectionGetByEntMainRltdId.DeletedItems.Count > 0)
					{
						//DataRepository.EntCoursePkgHdrProvider.Save(transactionManager, entity.EntCoursePkgHdrCollectionGetByEntMainRltdId);
						
						deepHandles.Add("EntCoursePkgHdrCollectionGetByEntMainRltdId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntCoursePkgHdr >) DataRepository.EntCoursePkgHdrProvider.DeepSave,
							new object[] { transactionManager, entity.EntCoursePkgHdrCollectionGetByEntMainRltdId, deepSaveType, childTypes, innerList }
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
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
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
				
	
			#region List<ScHallRsrv>
				if (CanDeepSave(entity.ScHallRsrvCollection, "List<ScHallRsrv>|ScHallRsrvCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScHallRsrv child in entity.ScHallRsrvCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.ScHallRsrvCollection.Count > 0 || entity.ScHallRsrvCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScHallRsrvProvider.Save(transactionManager, entity.ScHallRsrvCollection);
						
						deepHandles.Add("ScHallRsrvCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScHallRsrv >) DataRepository.ScHallRsrvProvider.DeepSave,
							new object[] { transactionManager, entity.ScHallRsrvCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScSectionGroupHdr>
				if (CanDeepSave(entity.ScSectionGroupHdrCollection, "List<ScSectionGroupHdr>|ScSectionGroupHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScSectionGroupHdr child in entity.ScSectionGroupHdrCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.ScSectionGroupHdrCollection.Count > 0 || entity.ScSectionGroupHdrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScSectionGroupHdrProvider.Save(transactionManager, entity.ScSectionGroupHdrCollection);
						
						deepHandles.Add("ScSectionGroupHdrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScSectionGroupHdr >) DataRepository.ScSectionGroupHdrProvider.DeepSave,
							new object[] { transactionManager, entity.ScSectionGroupHdrCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntMajorPhase>
				if (CanDeepSave(entity.EntMajorPhaseCollection, "List<EntMajorPhase>|EntMajorPhaseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntMajorPhase child in entity.EntMajorPhaseCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.EntMajorPhaseCollection.Count > 0 || entity.EntMajorPhaseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntMajorPhaseProvider.Save(transactionManager, entity.EntMajorPhaseCollection);
						
						deepHandles.Add("EntMajorPhaseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntMajorPhase >) DataRepository.EntMajorPhaseProvider.DeepSave,
							new object[] { transactionManager, entity.EntMajorPhaseCollection, deepSaveType, childTypes, innerList }
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
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
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
				
	
			#region List<EdCourseTopic>
				if (CanDeepSave(entity.EdCourseTopicCollection, "List<EdCourseTopic>|EdCourseTopicCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourseTopic child in entity.EdCourseTopicCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.EdCourseTopicCollection.Count > 0 || entity.EdCourseTopicCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseTopicProvider.Save(transactionManager, entity.EdCourseTopicCollection);
						
						deepHandles.Add("EdCourseTopicCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourseTopic >) DataRepository.EdCourseTopicProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseTopicCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoControl>
				if (CanDeepSave(entity.CoControlCollection, "List<CoControl>|CoControlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoControl child in entity.CoControlCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.CoControlCollection.Count > 0 || entity.CoControlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoControlProvider.Save(transactionManager, entity.CoControlCollection);
						
						deepHandles.Add("CoControlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoControl >) DataRepository.CoControlProvider.DeepSave,
							new object[] { transactionManager, entity.CoControlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdAcadPlan>
				if (CanDeepSave(entity.EdAcadPlanCollection, "List<EdAcadPlan>|EdAcadPlanCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdAcadPlan child in entity.EdAcadPlanCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.EdAcadPlanCollection.Count > 0 || entity.EdAcadPlanCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdAcadPlanProvider.Save(transactionManager, entity.EdAcadPlanCollection);
						
						deepHandles.Add("EdAcadPlanCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdAcadPlan >) DataRepository.EdAcadPlanProvider.DeepSave,
							new object[] { transactionManager, entity.EdAcadPlanCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudIntTransPref>
				if (CanDeepSave(entity.EdStudIntTransPrefCollection, "List<EdStudIntTransPref>|EdStudIntTransPrefCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTransPref child in entity.EdStudIntTransPrefCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.EdStudIntTransPrefCollection.Count > 0 || entity.EdStudIntTransPrefCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTransPrefProvider.Save(transactionManager, entity.EdStudIntTransPrefCollection);
						
						deepHandles.Add("EdStudIntTransPrefCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTransPref >) DataRepository.EdStudIntTransPrefProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTransPrefCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmPrecondQual>
				if (CanDeepSave(entity.AdmPrecondQualCollection, "List<AdmPrecondQual>|AdmPrecondQualCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmPrecondQual child in entity.AdmPrecondQualCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.AdmPrecondQualCollection.Count > 0 || entity.AdmPrecondQualCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmPrecondQualProvider.Save(transactionManager, entity.AdmPrecondQualCollection);
						
						deepHandles.Add("AdmPrecondQualCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmPrecondQual >) DataRepository.AdmPrecondQualProvider.DeepSave,
							new object[] { transactionManager, entity.AdmPrecondQualCollection, deepSaveType, childTypes, innerList }
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
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
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
				
	
			#region List<CoControlRoom>
				if (CanDeepSave(entity.CoControlRoomCollection, "List<CoControlRoom>|CoControlRoomCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoControlRoom child in entity.CoControlRoomCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.CoControlRoomCollection.Count > 0 || entity.CoControlRoomCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoControlRoomProvider.Save(transactionManager, entity.CoControlRoomCollection);
						
						deepHandles.Add("CoControlRoomCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoControlRoom >) DataRepository.CoControlRoomProvider.DeepSave,
							new object[] { transactionManager, entity.CoControlRoomCollection, deepSaveType, childTypes, innerList }
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
						if(child.AsNodeIdSource != null)
						{
							child.AsNodeId = child.AsNodeIdSource.EntMainId;
						}
						else
						{
							child.AsNodeId = entity.EntMainId;
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
				
	
			#region List<EntIntroducMdData>
				if (CanDeepSave(entity.EntIntroducMdDataCollection, "List<EntIntroducMdData>|EntIntroducMdDataCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntIntroducMdData child in entity.EntIntroducMdDataCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.EntIntroducMdDataCollection.Count > 0 || entity.EntIntroducMdDataCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntIntroducMdDataProvider.Save(transactionManager, entity.EntIntroducMdDataCollection);
						
						deepHandles.Add("EntIntroducMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntIntroducMdData >) DataRepository.EntIntroducMdDataProvider.DeepSave,
							new object[] { transactionManager, entity.EntIntroducMdDataCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntCoursePkgMdData>
				if (CanDeepSave(entity.EntCoursePkgMdDataCollection, "List<EntCoursePkgMdData>|EntCoursePkgMdDataCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntCoursePkgMdData child in entity.EntCoursePkgMdDataCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.EntCoursePkgMdDataCollection.Count > 0 || entity.EntCoursePkgMdDataCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntCoursePkgMdDataProvider.Save(transactionManager, entity.EntCoursePkgMdDataCollection);
						
						deepHandles.Add("EntCoursePkgMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntCoursePkgMdData >) DataRepository.EntCoursePkgMdDataProvider.DeepSave,
							new object[] { transactionManager, entity.EntCoursePkgMdDataCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmTansikMajorsCodes>
				if (CanDeepSave(entity.AdmTansikMajorsCodesCollection, "List<AdmTansikMajorsCodes>|AdmTansikMajorsCodesCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmTansikMajorsCodes child in entity.AdmTansikMajorsCodesCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.AdmTansikMajorsCodesCollection.Count > 0 || entity.AdmTansikMajorsCodesCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmTansikMajorsCodesProvider.Save(transactionManager, entity.AdmTansikMajorsCodesCollection);
						
						deepHandles.Add("AdmTansikMajorsCodesCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmTansikMajorsCodes >) DataRepository.AdmTansikMajorsCodesProvider.DeepSave,
							new object[] { transactionManager, entity.AdmTansikMajorsCodesCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPrecondMdData>
				if (CanDeepSave(entity.EntPrecondMdDataCollection, "List<EntPrecondMdData>|EntPrecondMdDataCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPrecondMdData child in entity.EntPrecondMdDataCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.EntPrecondMdDataCollection.Count > 0 || entity.EntPrecondMdDataCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPrecondMdDataProvider.Save(transactionManager, entity.EntPrecondMdDataCollection);
						
						deepHandles.Add("EntPrecondMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPrecondMdData >) DataRepository.EntPrecondMdDataProvider.DeepSave,
							new object[] { transactionManager, entity.EntPrecondMdDataCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmCdeFee>
				if (CanDeepSave(entity.AdmCdeFeeCollection, "List<AdmCdeFee>|AdmCdeFeeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmCdeFee child in entity.AdmCdeFeeCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.AdmCdeFeeCollection.Count > 0 || entity.AdmCdeFeeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmCdeFeeProvider.Save(transactionManager, entity.AdmCdeFeeCollection);
						
						deepHandles.Add("AdmCdeFeeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmCdeFee >) DataRepository.AdmCdeFeeProvider.DeepSave,
							new object[] { transactionManager, entity.AdmCdeFeeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudState>
				if (CanDeepSave(entity.EdStudStateCollection, "List<EdStudState>|EdStudStateCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudState child in entity.EdStudStateCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.EdStudStateCollection.Count > 0 || entity.EdStudStateCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudStateProvider.Save(transactionManager, entity.EdStudStateCollection);
						
						deepHandles.Add("EdStudStateCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudState >) DataRepository.EdStudStateProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudStateCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GsComm>
				if (CanDeepSave(entity.GsCommCollectionGetByEntMainMinorId, "List<GsComm>|GsCommCollectionGetByEntMainMinorId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsComm child in entity.GsCommCollectionGetByEntMainMinorId)
					{
						if(child.EntMainMinorIdSource != null)
						{
							child.EntMainMinorId = child.EntMainMinorIdSource.EntMainId;
						}
						else
						{
							child.EntMainMinorId = entity.EntMainId;
						}

					}

					if (entity.GsCommCollectionGetByEntMainMinorId.Count > 0 || entity.GsCommCollectionGetByEntMainMinorId.DeletedItems.Count > 0)
					{
						//DataRepository.GsCommProvider.Save(transactionManager, entity.GsCommCollectionGetByEntMainMinorId);
						
						deepHandles.Add("GsCommCollectionGetByEntMainMinorId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsComm >) DataRepository.GsCommProvider.DeepSave,
							new object[] { transactionManager, entity.GsCommCollectionGetByEntMainMinorId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppPref>
				if (CanDeepSave(entity.AdmAppPrefCollection, "List<AdmAppPref>|AdmAppPrefCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppPref child in entity.AdmAppPrefCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.AdmAppPrefCollection.Count > 0 || entity.AdmAppPrefCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppPrefProvider.Save(transactionManager, entity.AdmAppPrefCollection);
						
						deepHandles.Add("AdmAppPrefCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppPref >) DataRepository.AdmAppPrefProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppPrefCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdSemesterOpen>
				if (CanDeepSave(entity.EdSemesterOpenCollection, "List<EdSemesterOpen>|EdSemesterOpenCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdSemesterOpen child in entity.EdSemesterOpenCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.EdSemesterOpenCollection.Count > 0 || entity.EdSemesterOpenCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdSemesterOpenProvider.Save(transactionManager, entity.EdSemesterOpenCollection);
						
						deepHandles.Add("EdSemesterOpenCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdSemesterOpen >) DataRepository.EdSemesterOpenProvider.DeepSave,
							new object[] { transactionManager, entity.EdSemesterOpenCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvPollHdr>
				if (CanDeepSave(entity.SvPollHdrCollection, "List<SvPollHdr>|SvPollHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvPollHdr child in entity.SvPollHdrCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.SvPollHdrCollection.Count > 0 || entity.SvPollHdrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvPollHdrProvider.Save(transactionManager, entity.SvPollHdrCollection);
						
						deepHandles.Add("SvPollHdrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvPollHdr >) DataRepository.SvPollHdrProvider.DeepSave,
							new object[] { transactionManager, entity.SvPollHdrCollection, deepSaveType, childTypes, innerList }
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
						if(child.AsNodeIdSource != null)
						{
							child.AsNodeId = child.AsNodeIdSource.EntMainId;
						}
						else
						{
							child.AsNodeId = entity.EntMainId;
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
				
	
			#region List<AdmAppTransReq>
				if (CanDeepSave(entity.AdmAppTransReqCollection, "List<AdmAppTransReq>|AdmAppTransReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppTransReq child in entity.AdmAppTransReqCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.AdmAppTransReqCollection.Count > 0 || entity.AdmAppTransReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppTransReqProvider.Save(transactionManager, entity.AdmAppTransReqCollection);
						
						deepHandles.Add("AdmAppTransReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppTransReq >) DataRepository.AdmAppTransReqProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppTransReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntCoursePkgHdr>
				if (CanDeepSave(entity.EntCoursePkgHdrCollectionGetByEntMainSpcRltdId, "List<EntCoursePkgHdr>|EntCoursePkgHdrCollectionGetByEntMainSpcRltdId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntCoursePkgHdr child in entity.EntCoursePkgHdrCollectionGetByEntMainSpcRltdId)
					{
						if(child.EntMainSpcRltdIdSource != null)
						{
							child.EntMainSpcRltdId = child.EntMainSpcRltdIdSource.EntMainId;
						}
						else
						{
							child.EntMainSpcRltdId = entity.EntMainId;
						}

					}

					if (entity.EntCoursePkgHdrCollectionGetByEntMainSpcRltdId.Count > 0 || entity.EntCoursePkgHdrCollectionGetByEntMainSpcRltdId.DeletedItems.Count > 0)
					{
						//DataRepository.EntCoursePkgHdrProvider.Save(transactionManager, entity.EntCoursePkgHdrCollectionGetByEntMainSpcRltdId);
						
						deepHandles.Add("EntCoursePkgHdrCollectionGetByEntMainSpcRltdId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntCoursePkgHdr >) DataRepository.EntCoursePkgHdrProvider.DeepSave,
							new object[] { transactionManager, entity.EntCoursePkgHdrCollectionGetByEntMainSpcRltdId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudFaculty>
				if (CanDeepSave(entity.EdStudFacultyCollectionGetByEntMainGrad3, "List<EdStudFaculty>|EdStudFacultyCollectionGetByEntMainGrad3", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudFaculty child in entity.EdStudFacultyCollectionGetByEntMainGrad3)
					{
						if(child.EntMainGrad3Source != null)
						{
							child.EntMainGrad3 = child.EntMainGrad3Source.EntMainId;
						}
						else
						{
							child.EntMainGrad3 = entity.EntMainId;
						}

					}

					if (entity.EdStudFacultyCollectionGetByEntMainGrad3.Count > 0 || entity.EdStudFacultyCollectionGetByEntMainGrad3.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudFacultyProvider.Save(transactionManager, entity.EdStudFacultyCollectionGetByEntMainGrad3);
						
						deepHandles.Add("EdStudFacultyCollectionGetByEntMainGrad3",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudFaculty >) DataRepository.EdStudFacultyProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudFacultyCollectionGetByEntMainGrad3, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgOffering>
				if (CanDeepSave(entity.PgOfferingCollection, "List<PgOffering>|PgOfferingCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgOffering child in entity.PgOfferingCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.PgOfferingCollection.Count > 0 || entity.PgOfferingCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgOfferingProvider.Save(transactionManager, entity.PgOfferingCollection);
						
						deepHandles.Add("PgOfferingCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgOffering >) DataRepository.PgOfferingProvider.DeepSave,
							new object[] { transactionManager, entity.PgOfferingCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntCoursePkgHdr>
				if (CanDeepSave(entity.EntCoursePkgHdrCollectionGetByEntMainId, "List<EntCoursePkgHdr>|EntCoursePkgHdrCollectionGetByEntMainId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntCoursePkgHdr child in entity.EntCoursePkgHdrCollectionGetByEntMainId)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.EntCoursePkgHdrCollectionGetByEntMainId.Count > 0 || entity.EntCoursePkgHdrCollectionGetByEntMainId.DeletedItems.Count > 0)
					{
						//DataRepository.EntCoursePkgHdrProvider.Save(transactionManager, entity.EntCoursePkgHdrCollectionGetByEntMainId);
						
						deepHandles.Add("EntCoursePkgHdrCollectionGetByEntMainId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntCoursePkgHdr >) DataRepository.EntCoursePkgHdrProvider.DeepSave,
							new object[] { transactionManager, entity.EntCoursePkgHdrCollectionGetByEntMainId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdOutcome>
				if (CanDeepSave(entity.EdOutcomeCollection, "List<EdOutcome>|EdOutcomeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdOutcome child in entity.EdOutcomeCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.EdOutcomeCollection.Count > 0 || entity.EdOutcomeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdOutcomeProvider.Save(transactionManager, entity.EdOutcomeCollection);
						
						deepHandles.Add("EdOutcomeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdOutcome >) DataRepository.EdOutcomeProvider.DeepSave,
							new object[] { transactionManager, entity.EdOutcomeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmCdeAppStatus>
				if (CanDeepSave(entity.AdmCdeAppStatusCollection, "List<AdmCdeAppStatus>|AdmCdeAppStatusCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmCdeAppStatus child in entity.AdmCdeAppStatusCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.AdmCdeAppStatusCollection.Count > 0 || entity.AdmCdeAppStatusCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmCdeAppStatusProvider.Save(transactionManager, entity.AdmCdeAppStatusCollection);
						
						deepHandles.Add("AdmCdeAppStatusCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmCdeAppStatus >) DataRepository.AdmCdeAppStatusProvider.DeepSave,
							new object[] { transactionManager, entity.AdmCdeAppStatusCollection, deepSaveType, childTypes, innerList }
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
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
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
				
	
			#region List<EdBranchRule>
				if (CanDeepSave(entity.EdBranchRuleCollection, "List<EdBranchRule>|EdBranchRuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdBranchRule child in entity.EdBranchRuleCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.EdBranchRuleCollection.Count > 0 || entity.EdBranchRuleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdBranchRuleProvider.Save(transactionManager, entity.EdBranchRuleCollection);
						
						deepHandles.Add("EdBranchRuleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdBranchRule >) DataRepository.EdBranchRuleProvider.DeepSave,
							new object[] { transactionManager, entity.EdBranchRuleCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeFacultyRule>
				if (CanDeepSave(entity.FeeFacultyRuleCollection, "List<FeeFacultyRule>|FeeFacultyRuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeFacultyRule child in entity.FeeFacultyRuleCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.FeeFacultyRuleCollection.Count > 0 || entity.FeeFacultyRuleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeFacultyRuleProvider.Save(transactionManager, entity.FeeFacultyRuleCollection);
						
						deepHandles.Add("FeeFacultyRuleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeFacultyRule >) DataRepository.FeeFacultyRuleProvider.DeepSave,
							new object[] { transactionManager, entity.FeeFacultyRuleCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntMainMatrix>
				if (CanDeepSave(entity.EntMainMatrixCollectionGetByEntMainId, "List<EntMainMatrix>|EntMainMatrixCollectionGetByEntMainId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntMainMatrix child in entity.EntMainMatrixCollectionGetByEntMainId)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.EntMainMatrixCollectionGetByEntMainId.Count > 0 || entity.EntMainMatrixCollectionGetByEntMainId.DeletedItems.Count > 0)
					{
						//DataRepository.EntMainMatrixProvider.Save(transactionManager, entity.EntMainMatrixCollectionGetByEntMainId);
						
						deepHandles.Add("EntMainMatrixCollectionGetByEntMainId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntMainMatrix >) DataRepository.EntMainMatrixProvider.DeepSave,
							new object[] { transactionManager, entity.EntMainMatrixCollectionGetByEntMainId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvStaffEvl>
				if (CanDeepSave(entity.SvStaffEvlCollectionGetByEntMainMinorId, "List<SvStaffEvl>|SvStaffEvlCollectionGetByEntMainMinorId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStaffEvl child in entity.SvStaffEvlCollectionGetByEntMainMinorId)
					{
						if(child.EntMainMinorIdSource != null)
						{
							child.EntMainMinorId = child.EntMainMinorIdSource.EntMainId;
						}
						else
						{
							child.EntMainMinorId = entity.EntMainId;
						}

					}

					if (entity.SvStaffEvlCollectionGetByEntMainMinorId.Count > 0 || entity.SvStaffEvlCollectionGetByEntMainMinorId.DeletedItems.Count > 0)
					{
						//DataRepository.SvStaffEvlProvider.Save(transactionManager, entity.SvStaffEvlCollectionGetByEntMainMinorId);
						
						deepHandles.Add("SvStaffEvlCollectionGetByEntMainMinorId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStaffEvl >) DataRepository.SvStaffEvlProvider.DeepSave,
							new object[] { transactionManager, entity.SvStaffEvlCollectionGetByEntMainMinorId, deepSaveType, childTypes, innerList }
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
						if(child.AsNodeIdSource != null)
						{
							child.AsNodeId = child.AsNodeIdSource.EntMainId;
						}
						else
						{
							child.AsNodeId = entity.EntMainId;
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
				
	
			#region List<EntGraduationReq>
				if (CanDeepSave(entity.EntGraduationReqCollection, "List<EntGraduationReq>|EntGraduationReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntGraduationReq child in entity.EntGraduationReqCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.EntGraduationReqCollection.Count > 0 || entity.EntGraduationReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntGraduationReqProvider.Save(transactionManager, entity.EntGraduationReqCollection);
						
						deepHandles.Add("EntGraduationReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntGraduationReq >) DataRepository.EntGraduationReqProvider.DeepSave,
							new object[] { transactionManager, entity.EntGraduationReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntMainMatrix>
				if (CanDeepSave(entity.EntMainMatrixCollectionGetByEntMainSpecId, "List<EntMainMatrix>|EntMainMatrixCollectionGetByEntMainSpecId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntMainMatrix child in entity.EntMainMatrixCollectionGetByEntMainSpecId)
					{
						if(child.EntMainSpecIdSource != null)
						{
							child.EntMainSpecId = child.EntMainSpecIdSource.EntMainId;
						}
						else
						{
							child.EntMainSpecId = entity.EntMainId;
						}

					}

					if (entity.EntMainMatrixCollectionGetByEntMainSpecId.Count > 0 || entity.EntMainMatrixCollectionGetByEntMainSpecId.DeletedItems.Count > 0)
					{
						//DataRepository.EntMainMatrixProvider.Save(transactionManager, entity.EntMainMatrixCollectionGetByEntMainSpecId);
						
						deepHandles.Add("EntMainMatrixCollectionGetByEntMainSpecId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntMainMatrix >) DataRepository.EntMainMatrixProvider.DeepSave,
							new object[] { transactionManager, entity.EntMainMatrixCollectionGetByEntMainSpecId, deepSaveType, childTypes, innerList }
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
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
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
				
	
			#region List<SvCourseEval>
				if (CanDeepSave(entity.SvCourseEvalCollection, "List<SvCourseEval>|SvCourseEvalCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvCourseEval child in entity.SvCourseEvalCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.SvCourseEvalCollection.Count > 0 || entity.SvCourseEvalCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvCourseEvalProvider.Save(transactionManager, entity.SvCourseEvalCollection);
						
						deepHandles.Add("SvCourseEvalCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvCourseEval >) DataRepository.SvCourseEvalProvider.DeepSave,
							new object[] { transactionManager, entity.SvCourseEvalCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdAcadPlanHdr>
				if (CanDeepSave(entity.EdAcadPlanHdrCollectionGetByEntMainSpcRltdId, "List<EdAcadPlanHdr>|EdAcadPlanHdrCollectionGetByEntMainSpcRltdId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdAcadPlanHdr child in entity.EdAcadPlanHdrCollectionGetByEntMainSpcRltdId)
					{
						if(child.EntMainSpcRltdIdSource != null)
						{
							child.EntMainSpcRltdId = child.EntMainSpcRltdIdSource.EntMainId;
						}
						else
						{
							child.EntMainSpcRltdId = entity.EntMainId;
						}

					}

					if (entity.EdAcadPlanHdrCollectionGetByEntMainSpcRltdId.Count > 0 || entity.EdAcadPlanHdrCollectionGetByEntMainSpcRltdId.DeletedItems.Count > 0)
					{
						//DataRepository.EdAcadPlanHdrProvider.Save(transactionManager, entity.EdAcadPlanHdrCollectionGetByEntMainSpcRltdId);
						
						deepHandles.Add("EdAcadPlanHdrCollectionGetByEntMainSpcRltdId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdAcadPlanHdr >) DataRepository.EdAcadPlanHdrProvider.DeepSave,
							new object[] { transactionManager, entity.EdAcadPlanHdrCollectionGetByEntMainSpcRltdId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaStfMember>
				if (CanDeepSave(entity.SaStfMemberCollection, "List<SaStfMember>|SaStfMemberCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaStfMember child in entity.SaStfMemberCollection)
					{
						if(child.AsNodeIdSource != null)
						{
							child.AsNodeId = child.AsNodeIdSource.EntMainId;
						}
						else
						{
							child.AsNodeId = entity.EntMainId;
						}

					}

					if (entity.SaStfMemberCollection.Count > 0 || entity.SaStfMemberCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaStfMemberProvider.Save(transactionManager, entity.SaStfMemberCollection);
						
						deepHandles.Add("SaStfMemberCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaStfMember >) DataRepository.SaStfMemberProvider.DeepSave,
							new object[] { transactionManager, entity.SaStfMemberCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntGradingMdData>
				if (CanDeepSave(entity.EntGradingMdDataCollection, "List<EntGradingMdData>|EntGradingMdDataCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntGradingMdData child in entity.EntGradingMdDataCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.EntGradingMdDataCollection.Count > 0 || entity.EntGradingMdDataCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntGradingMdDataProvider.Save(transactionManager, entity.EntGradingMdDataCollection);
						
						deepHandles.Add("EntGradingMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntGradingMdData >) DataRepository.EntGradingMdDataProvider.DeepSave,
							new object[] { transactionManager, entity.EntGradingMdDataCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntMainMatrix>
				if (CanDeepSave(entity.EntMainMatrixCollectionGetByEntMainMinorId, "List<EntMainMatrix>|EntMainMatrixCollectionGetByEntMainMinorId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntMainMatrix child in entity.EntMainMatrixCollectionGetByEntMainMinorId)
					{
						if(child.EntMainMinorIdSource != null)
						{
							child.EntMainMinorId = child.EntMainMinorIdSource.EntMainId;
						}
						else
						{
							child.EntMainMinorId = entity.EntMainId;
						}

					}

					if (entity.EntMainMatrixCollectionGetByEntMainMinorId.Count > 0 || entity.EntMainMatrixCollectionGetByEntMainMinorId.DeletedItems.Count > 0)
					{
						//DataRepository.EntMainMatrixProvider.Save(transactionManager, entity.EntMainMatrixCollectionGetByEntMainMinorId);
						
						deepHandles.Add("EntMainMatrixCollectionGetByEntMainMinorId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntMainMatrix >) DataRepository.EntMainMatrixProvider.DeepSave,
							new object[] { transactionManager, entity.EntMainMatrixCollectionGetByEntMainMinorId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdOffering>
				if (CanDeepSave(entity.EdOfferingCollection, "List<EdOffering>|EdOfferingCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdOffering child in entity.EdOfferingCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.EdOfferingCollection.Count > 0 || entity.EdOfferingCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdOfferingProvider.Save(transactionManager, entity.EdOfferingCollection);
						
						deepHandles.Add("EdOfferingCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdOffering >) DataRepository.EdOfferingProvider.DeepSave,
							new object[] { transactionManager, entity.EdOfferingCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdBylaw>
				if (CanDeepSave(entity.EdBylawCollection, "List<EdBylaw>|EdBylawCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdBylaw child in entity.EdBylawCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.EdBylawCollection.Count > 0 || entity.EdBylawCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdBylawProvider.Save(transactionManager, entity.EdBylawCollection);
						
						deepHandles.Add("EdBylawCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdBylaw >) DataRepository.EdBylawProvider.DeepSave,
							new object[] { transactionManager, entity.EdBylawCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudFaculty>
				if (CanDeepSave(entity.EdStudFacultyCollectionGetByEntMainGrad2, "List<EdStudFaculty>|EdStudFacultyCollectionGetByEntMainGrad2", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudFaculty child in entity.EdStudFacultyCollectionGetByEntMainGrad2)
					{
						if(child.EntMainGrad2Source != null)
						{
							child.EntMainGrad2 = child.EntMainGrad2Source.EntMainId;
						}
						else
						{
							child.EntMainGrad2 = entity.EntMainId;
						}

					}

					if (entity.EdStudFacultyCollectionGetByEntMainGrad2.Count > 0 || entity.EdStudFacultyCollectionGetByEntMainGrad2.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudFacultyProvider.Save(transactionManager, entity.EdStudFacultyCollectionGetByEntMainGrad2);
						
						deepHandles.Add("EdStudFacultyCollectionGetByEntMainGrad2",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudFaculty >) DataRepository.EdStudFacultyProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudFacultyCollectionGetByEntMainGrad2, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntMainMatrix>
				if (CanDeepSave(entity.EntMainMatrixCollectionGetByEntMainMajorId, "List<EntMainMatrix>|EntMainMatrixCollectionGetByEntMainMajorId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntMainMatrix child in entity.EntMainMatrixCollectionGetByEntMainMajorId)
					{
						if(child.EntMainMajorIdSource != null)
						{
							child.EntMainMajorId = child.EntMainMajorIdSource.EntMainId;
						}
						else
						{
							child.EntMainMajorId = entity.EntMainId;
						}

					}

					if (entity.EntMainMatrixCollectionGetByEntMainMajorId.Count > 0 || entity.EntMainMatrixCollectionGetByEntMainMajorId.DeletedItems.Count > 0)
					{
						//DataRepository.EntMainMatrixProvider.Save(transactionManager, entity.EntMainMatrixCollectionGetByEntMainMajorId);
						
						deepHandles.Add("EntMainMatrixCollectionGetByEntMainMajorId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntMainMatrix >) DataRepository.EntMainMatrixProvider.DeepSave,
							new object[] { transactionManager, entity.EntMainMatrixCollectionGetByEntMainMajorId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeUserCrsAssess>
				if (CanDeepSave(entity.SeUserCrsAssessCollectionGetByEntMainDeptId, "List<SeUserCrsAssess>|SeUserCrsAssessCollectionGetByEntMainDeptId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeUserCrsAssess child in entity.SeUserCrsAssessCollectionGetByEntMainDeptId)
					{
						if(child.EntMainDeptIdSource != null)
						{
							child.EntMainDeptId = child.EntMainDeptIdSource.EntMainId;
						}
						else
						{
							child.EntMainDeptId = entity.EntMainId;
						}

					}

					if (entity.SeUserCrsAssessCollectionGetByEntMainDeptId.Count > 0 || entity.SeUserCrsAssessCollectionGetByEntMainDeptId.DeletedItems.Count > 0)
					{
						//DataRepository.SeUserCrsAssessProvider.Save(transactionManager, entity.SeUserCrsAssessCollectionGetByEntMainDeptId);
						
						deepHandles.Add("SeUserCrsAssessCollectionGetByEntMainDeptId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeUserCrsAssess >) DataRepository.SeUserCrsAssessProvider.DeepSave,
							new object[] { transactionManager, entity.SeUserCrsAssessCollectionGetByEntMainDeptId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeSemesterAgenda>
				if (CanDeepSave(entity.FeeSemesterAgendaCollection, "List<FeeSemesterAgenda>|FeeSemesterAgendaCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeSemesterAgenda child in entity.FeeSemesterAgendaCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.FeeSemesterAgendaCollection.Count > 0 || entity.FeeSemesterAgendaCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeSemesterAgendaProvider.Save(transactionManager, entity.FeeSemesterAgendaCollection);
						
						deepHandles.Add("FeeSemesterAgendaCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeSemesterAgenda >) DataRepository.FeeSemesterAgendaProvider.DeepSave,
							new object[] { transactionManager, entity.FeeSemesterAgendaCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppCount>
				if (CanDeepSave(entity.AdmAppCountCollection, "List<AdmAppCount>|AdmAppCountCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppCount child in entity.AdmAppCountCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.AdmAppCountCollection.Count > 0 || entity.AdmAppCountCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppCountProvider.Save(transactionManager, entity.AdmAppCountCollection);
						
						deepHandles.Add("AdmAppCountCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppCount >) DataRepository.AdmAppCountProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppCountCollection, deepSaveType, childTypes, innerList }
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
						if(child.AsNodeIdSource != null)
						{
							child.AsNodeId = child.AsNodeIdSource.EntMainId;
						}
						else
						{
							child.AsNodeId = entity.EntMainId;
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
				
	
			#region List<SeUserCrsAssess>
				if (CanDeepSave(entity.SeUserCrsAssessCollectionGetByEntMainMajorId, "List<SeUserCrsAssess>|SeUserCrsAssessCollectionGetByEntMainMajorId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeUserCrsAssess child in entity.SeUserCrsAssessCollectionGetByEntMainMajorId)
					{
						if(child.EntMainMajorIdSource != null)
						{
							child.EntMainMajorId = child.EntMainMajorIdSource.EntMainId;
						}
						else
						{
							child.EntMainMajorId = entity.EntMainId;
						}

					}

					if (entity.SeUserCrsAssessCollectionGetByEntMainMajorId.Count > 0 || entity.SeUserCrsAssessCollectionGetByEntMainMajorId.DeletedItems.Count > 0)
					{
						//DataRepository.SeUserCrsAssessProvider.Save(transactionManager, entity.SeUserCrsAssessCollectionGetByEntMainMajorId);
						
						deepHandles.Add("SeUserCrsAssessCollectionGetByEntMainMajorId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeUserCrsAssess >) DataRepository.SeUserCrsAssessProvider.DeepSave,
							new object[] { transactionManager, entity.SeUserCrsAssessCollectionGetByEntMainMajorId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdResultApprove>
				if (CanDeepSave(entity.EdResultApproveCollection, "List<EdResultApprove>|EdResultApproveCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdResultApprove child in entity.EdResultApproveCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.EdResultApproveCollection.Count > 0 || entity.EdResultApproveCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdResultApproveProvider.Save(transactionManager, entity.EdResultApproveCollection);
						
						deepHandles.Add("EdResultApproveCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdResultApprove >) DataRepository.EdResultApproveProvider.DeepSave,
							new object[] { transactionManager, entity.EdResultApproveCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCoursePrfx>
				if (CanDeepSave(entity.EdCoursePrfxCollection, "List<EdCoursePrfx>|EdCoursePrfxCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCoursePrfx child in entity.EdCoursePrfxCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.EdCoursePrfxCollection.Count > 0 || entity.EdCoursePrfxCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCoursePrfxProvider.Save(transactionManager, entity.EdCoursePrfxCollection);
						
						deepHandles.Add("EdCoursePrfxCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCoursePrfx >) DataRepository.EdCoursePrfxProvider.DeepSave,
							new object[] { transactionManager, entity.EdCoursePrfxCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisGeneralSpec>
				if (CanDeepSave(entity.PgThesisGeneralSpecCollection, "List<PgThesisGeneralSpec>|PgThesisGeneralSpecCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisGeneralSpec child in entity.PgThesisGeneralSpecCollection)
					{
						if(child.AsNodeIdSource != null)
						{
							child.AsNodeId = child.AsNodeIdSource.EntMainId;
						}
						else
						{
							child.AsNodeId = entity.EntMainId;
						}

					}

					if (entity.PgThesisGeneralSpecCollection.Count > 0 || entity.PgThesisGeneralSpecCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisGeneralSpecProvider.Save(transactionManager, entity.PgThesisGeneralSpecCollection);
						
						deepHandles.Add("PgThesisGeneralSpecCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisGeneralSpec >) DataRepository.PgThesisGeneralSpecProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisGeneralSpecCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdAcadPlanHdr>
				if (CanDeepSave(entity.EdAcadPlanHdrCollectionGetByEntMainRltdId, "List<EdAcadPlanHdr>|EdAcadPlanHdrCollectionGetByEntMainRltdId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdAcadPlanHdr child in entity.EdAcadPlanHdrCollectionGetByEntMainRltdId)
					{
						if(child.EntMainRltdIdSource != null)
						{
							child.EntMainRltdId = child.EntMainRltdIdSource.EntMainId;
						}
						else
						{
							child.EntMainRltdId = entity.EntMainId;
						}

					}

					if (entity.EdAcadPlanHdrCollectionGetByEntMainRltdId.Count > 0 || entity.EdAcadPlanHdrCollectionGetByEntMainRltdId.DeletedItems.Count > 0)
					{
						//DataRepository.EdAcadPlanHdrProvider.Save(transactionManager, entity.EdAcadPlanHdrCollectionGetByEntMainRltdId);
						
						deepHandles.Add("EdAcadPlanHdrCollectionGetByEntMainRltdId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdAcadPlanHdr >) DataRepository.EdAcadPlanHdrProvider.DeepSave,
							new object[] { transactionManager, entity.EdAcadPlanHdrCollectionGetByEntMainRltdId, deepSaveType, childTypes, innerList }
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
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
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
				
	
			#region List<AdmRatingParametersMajors>
				if (CanDeepSave(entity.AdmRatingParametersMajorsCollection, "List<AdmRatingParametersMajors>|AdmRatingParametersMajorsCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmRatingParametersMajors child in entity.AdmRatingParametersMajorsCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.AdmRatingParametersMajorsCollection.Count > 0 || entity.AdmRatingParametersMajorsCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmRatingParametersMajorsProvider.Save(transactionManager, entity.AdmRatingParametersMajorsCollection);
						
						deepHandles.Add("AdmRatingParametersMajorsCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmRatingParametersMajors >) DataRepository.AdmRatingParametersMajorsProvider.DeepSave,
							new object[] { transactionManager, entity.AdmRatingParametersMajorsCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmPlaceExamDatetime>
				if (CanDeepSave(entity.AdmPlaceExamDatetimeCollection, "List<AdmPlaceExamDatetime>|AdmPlaceExamDatetimeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmPlaceExamDatetime child in entity.AdmPlaceExamDatetimeCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.AdmPlaceExamDatetimeCollection.Count > 0 || entity.AdmPlaceExamDatetimeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmPlaceExamDatetimeProvider.Save(transactionManager, entity.AdmPlaceExamDatetimeCollection);
						
						deepHandles.Add("AdmPlaceExamDatetimeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmPlaceExamDatetime >) DataRepository.AdmPlaceExamDatetimeProvider.DeepSave,
							new object[] { transactionManager, entity.AdmPlaceExamDatetimeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCourse>
				if (CanDeepSave(entity.EdCourseCollection, "List<EdCourse>|EdCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourse child in entity.EdCourseCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.EdCourseCollection.Count > 0 || entity.EdCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseCollection);
						
						deepHandles.Add("EdCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourse >) DataRepository.EdCourseProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeUserAccnt>
				if (CanDeepSave(entity.SeUserAccntCollection, "List<SeUserAccnt>|SeUserAccntCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeUserAccnt child in entity.SeUserAccntCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.SeUserAccntCollection.Count > 0 || entity.SeUserAccntCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeUserAccntProvider.Save(transactionManager, entity.SeUserAccntCollection);
						
						deepHandles.Add("SeUserAccntCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeUserAccnt >) DataRepository.SeUserAccntProvider.DeepSave,
							new object[] { transactionManager, entity.SeUserAccntCollection, deepSaveType, childTypes, innerList }
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
						if(child.AsNodeIdSource != null)
						{
							child.AsNodeId = child.AsNodeIdSource.EntMainId;
						}
						else
						{
							child.AsNodeId = entity.EntMainId;
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
				
	
			#region List<EdStudBranchPref>
				if (CanDeepSave(entity.EdStudBranchPrefCollection, "List<EdStudBranchPref>|EdStudBranchPrefCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudBranchPref child in entity.EdStudBranchPrefCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.EdStudBranchPrefCollection.Count > 0 || entity.EdStudBranchPrefCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudBranchPrefProvider.Save(transactionManager, entity.EdStudBranchPrefCollection);
						
						deepHandles.Add("EdStudBranchPrefCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudBranchPref >) DataRepository.EdStudBranchPrefProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudBranchPrefCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntityMain>
				if (CanDeepSave(entity.EntityMainCollection, "List<EntityMain>|EntityMainCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntityMain child in entity.EntityMainCollection)
					{
						if(child.EntParentIdSource != null)
						{
							child.EntParentId = child.EntParentIdSource.EntMainId;
						}
						else
						{
							child.EntParentId = entity.EntMainId;
						}

					}

					if (entity.EntityMainCollection.Count > 0 || entity.EntityMainCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntityMainProvider.Save(transactionManager, entity.EntityMainCollection);
						
						deepHandles.Add("EntityMainCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntityMain >) DataRepository.EntityMainProvider.DeepSave,
							new object[] { transactionManager, entity.EntityMainCollection, deepSaveType, childTypes, innerList }
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
						if(child.AsNodeIdSource != null)
						{
							child.AsNodeId = child.AsNodeIdSource.EntMainId;
						}
						else
						{
							child.AsNodeId = entity.EntMainId;
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
				
	
			#region List<ScScheduleRsrv>
				if (CanDeepSave(entity.ScScheduleRsrvCollection, "List<ScScheduleRsrv>|ScScheduleRsrvCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScScheduleRsrv child in entity.ScScheduleRsrvCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.ScScheduleRsrvCollection.Count > 0 || entity.ScScheduleRsrvCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScScheduleRsrvProvider.Save(transactionManager, entity.ScScheduleRsrvCollection);
						
						deepHandles.Add("ScScheduleRsrvCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScScheduleRsrv >) DataRepository.ScScheduleRsrvProvider.DeepSave,
							new object[] { transactionManager, entity.ScScheduleRsrvCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScSchdlPeriod>
				if (CanDeepSave(entity.ScSchdlPeriodCollection, "List<ScSchdlPeriod>|ScSchdlPeriodCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScSchdlPeriod child in entity.ScSchdlPeriodCollection)
					{
						if(child.EntMainMjrIdSource != null)
						{
							child.EntMainMjrId = child.EntMainMjrIdSource.EntMainId;
						}
						else
						{
							child.EntMainMjrId = entity.EntMainId;
						}

					}

					if (entity.ScSchdlPeriodCollection.Count > 0 || entity.ScSchdlPeriodCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScSchdlPeriodProvider.Save(transactionManager, entity.ScSchdlPeriodCollection);
						
						deepHandles.Add("ScSchdlPeriodCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScSchdlPeriod >) DataRepository.ScSchdlPeriodProvider.DeepSave,
							new object[] { transactionManager, entity.ScSchdlPeriodCollection, deepSaveType, childTypes, innerList }
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
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
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
				
	
			#region List<ScGroupInfo>
				if (CanDeepSave(entity.ScGroupInfoCollection, "List<ScGroupInfo>|ScGroupInfoCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScGroupInfo child in entity.ScGroupInfoCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.ScGroupInfoCollection.Count > 0 || entity.ScGroupInfoCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScGroupInfoProvider.Save(transactionManager, entity.ScGroupInfoCollection);
						
						deepHandles.Add("ScGroupInfoCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScGroupInfo >) DataRepository.ScGroupInfoProvider.DeepSave,
							new object[] { transactionManager, entity.ScGroupInfoCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolcyGrdngHdr>
				if (CanDeepSave(entity.EntPolcyGrdngHdrCollection, "List<EntPolcyGrdngHdr>|EntPolcyGrdngHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolcyGrdngHdr child in entity.EntPolcyGrdngHdrCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.EntPolcyGrdngHdrCollection.Count > 0 || entity.EntPolcyGrdngHdrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolcyGrdngHdrProvider.Save(transactionManager, entity.EntPolcyGrdngHdrCollection);
						
						deepHandles.Add("EntPolcyGrdngHdrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolcyGrdngHdr >) DataRepository.EntPolcyGrdngHdrProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolcyGrdngHdrCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdInttransRule>
				if (CanDeepSave(entity.EdInttransRuleCollection, "List<EdInttransRule>|EdInttransRuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdInttransRule child in entity.EdInttransRuleCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.EdInttransRuleCollection.Count > 0 || entity.EdInttransRuleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdInttransRuleProvider.Save(transactionManager, entity.EdInttransRuleCollection);
						
						deepHandles.Add("EdInttransRuleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdInttransRule >) DataRepository.EdInttransRuleProvider.DeepSave,
							new object[] { transactionManager, entity.EdInttransRuleCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntCourseMdData>
				if (CanDeepSave(entity.EntCourseMdDataCollection, "List<EntCourseMdData>|EntCourseMdDataCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntCourseMdData child in entity.EntCourseMdDataCollection)
					{
						if(child.EntMainIdSource != null)
						{
							child.EntMainId = child.EntMainIdSource.EntMainId;
						}
						else
						{
							child.EntMainId = entity.EntMainId;
						}

					}

					if (entity.EntCourseMdDataCollection.Count > 0 || entity.EntCourseMdDataCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntCourseMdDataProvider.Save(transactionManager, entity.EntCourseMdDataCollection);
						
						deepHandles.Add("EntCourseMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntCourseMdData >) DataRepository.EntCourseMdDataProvider.DeepSave,
							new object[] { transactionManager, entity.EntCourseMdDataCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GsComm>
				if (CanDeepSave(entity.GsCommCollectionGetByEntMainMajorId, "List<GsComm>|GsCommCollectionGetByEntMainMajorId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsComm child in entity.GsCommCollectionGetByEntMainMajorId)
					{
						if(child.EntMainMajorIdSource != null)
						{
							child.EntMainMajorId = child.EntMainMajorIdSource.EntMainId;
						}
						else
						{
							child.EntMainMajorId = entity.EntMainId;
						}

					}

					if (entity.GsCommCollectionGetByEntMainMajorId.Count > 0 || entity.GsCommCollectionGetByEntMainMajorId.DeletedItems.Count > 0)
					{
						//DataRepository.GsCommProvider.Save(transactionManager, entity.GsCommCollectionGetByEntMainMajorId);
						
						deepHandles.Add("GsCommCollectionGetByEntMainMajorId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsComm >) DataRepository.GsCommProvider.DeepSave,
							new object[] { transactionManager, entity.GsCommCollectionGetByEntMainMajorId, deepSaveType, childTypes, innerList }
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
	
	#region EntityMainChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntityMain</c>
	///</summary>
	public enum EntityMainChildEntityTypes
	{
		
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
		/// Composite Property for <c>EdCodeLevel</c> at EdCodeLevelIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeLevel))]
		EdCodeLevel,
		
		///<summary>
		/// Composite Property for <c>EdCodeStudyMethod</c> at EdStudyMethodIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeStudyMethod))]
		EdCodeStudyMethod,
		
		///<summary>
		/// Composite Property for <c>EntCodeEntityType</c> at EntCodeEntityTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EntCodeEntityType))]
		EntCodeEntityType,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntParentIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		
		///<summary>
		/// Composite Property for <c>GsCdeSpecArea</c> at GsCdeSpecAreaIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeSpecArea))]
		GsCdeSpecArea,
		
		///<summary>
		/// Composite Property for <c>GsCodeGender</c> at GsCodeGenderIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeGender))]
		GsCodeGender,
		
		///<summary>
		/// Composite Property for <c>GsCodeLanguage</c> at GsCodeLanguageIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeLanguage))]
		GsCodeLanguage,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EdStudFacultyCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudFaculty>))]
		EdStudFacultyCollectionGetByEntMainGrad1,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for SvStaffEvlCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStaffEvl>))]
		SvStaffEvlCollectionGetByEntMainMajorId,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for SvStaffEvlCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStaffEvl>))]
		SvStaffEvlCollectionGetByEntMainId,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EntPolicyMdDataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyMdData>))]
		EntPolicyMdDataCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EntFullfillMdDataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntFullfillMdData>))]
		EntFullfillMdDataCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EntPolicyGradingLevelCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyGradingLevel>))]
		EntPolicyGradingLevelCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EdStudIntTrnsStateToCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsStateTo>))]
		EdStudIntTrnsStateToCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for FeeFacultyInstallmentCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeFacultyInstallment>))]
		FeeFacultyInstallmentCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for AdmReqDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmReqDoc>))]
		AdmReqDocCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EdCourseOrientCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourseOrient>))]
		EdCourseOrientCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EdProjectCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdProject>))]
		EdProjectCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for AdmCdePlacementExamCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmCdePlacementExam>))]
		AdmCdePlacementExamCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EntCoursePkgHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntCoursePkgHdr>))]
		EntCoursePkgHdrCollectionGetByEntMainRltdId,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for SpoSponsorOfferExtCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoSponsorOfferExt>))]
		SpoSponsorOfferExtCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for ScHallRsrvCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScHallRsrv>))]
		ScHallRsrvCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for ScSectionGroupHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScSectionGroupHdr>))]
		ScSectionGroupHdrCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EntMajorPhaseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntMajorPhase>))]
		EntMajorPhaseCollection,
		///<summary>
		/// Entity <c>EntPolicyObserved</c> as OneToOne for EntPolicyObserved
		///</summary>
		[ChildEntityType(typeof(EntPolicyObserved))]
		EntPolicyObserved,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for AdmAppInterviewExamCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppInterviewExam>))]
		AdmAppInterviewExamCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EdCourseTopicCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourseTopic>))]
		EdCourseTopicCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for CoControlCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoControl>))]
		CoControlCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EdAcadPlanCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdAcadPlan>))]
		EdAcadPlanCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EdStudIntTransPrefCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTransPref>))]
		EdStudIntTransPrefCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for AdmPrecondQualCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmPrecondQual>))]
		AdmPrecondQualCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EdStudIntTrnsStateFromCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsStateFrom>))]
		EdStudIntTrnsStateFromCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for CoControlRoomCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoControlRoom>))]
		CoControlRoomCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for SaScQualCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaScQual>))]
		SaScQualCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EntIntroducMdDataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntIntroducMdData>))]
		EntIntroducMdDataCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EntCoursePkgMdDataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntCoursePkgMdData>))]
		EntCoursePkgMdDataCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for AdmTansikMajorsCodesCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmTansikMajorsCodes>))]
		AdmTansikMajorsCodesCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EntPrecondMdDataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPrecondMdData>))]
		EntPrecondMdDataCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for AdmCdeFeeCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmCdeFee>))]
		AdmCdeFeeCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EdStudStateCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudState>))]
		EdStudStateCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for GsCommCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsComm>))]
		GsCommCollectionGetByEntMainMinorId,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for AdmAppPrefCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppPref>))]
		AdmAppPrefCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EdSemesterOpenCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdSemesterOpen>))]
		EdSemesterOpenCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for SvPollHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvPollHdr>))]
		SvPollHdrCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for SaTrainingCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaTrainingCourse>))]
		SaTrainingCourseCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for AdmAppTransReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppTransReq>))]
		AdmAppTransReqCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EntCoursePkgHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntCoursePkgHdr>))]
		EntCoursePkgHdrCollectionGetByEntMainSpcRltdId,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EdStudFacultyCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudFaculty>))]
		EdStudFacultyCollectionGetByEntMainGrad3,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for PgOfferingCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgOffering>))]
		PgOfferingCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EntCoursePkgHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntCoursePkgHdr>))]
		EntCoursePkgHdrCollectionGetByEntMainId,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EdOutcomeCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdOutcome>))]
		EdOutcomeCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for AdmCdeAppStatusCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmCdeAppStatus>))]
		AdmCdeAppStatusCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EdStudGrantTempCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudGrantTemp>))]
		EdStudGrantTempCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EdBranchRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdBranchRule>))]
		EdBranchRuleCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for FeeFacultyRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeFacultyRule>))]
		FeeFacultyRuleCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EntMainMatrixCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntMainMatrix>))]
		EntMainMatrixCollectionGetByEntMainId,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for SvStaffEvlCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStaffEvl>))]
		SvStaffEvlCollectionGetByEntMainMinorId,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for SaExperienceCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaExperience>))]
		SaExperienceCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EntGraduationReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntGraduationReq>))]
		EntGraduationReqCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EntMainMatrixCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntMainMatrix>))]
		EntMainMatrixCollectionGetByEntMainSpecId,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EdStudGrantDegreeCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudGrantDegree>))]
		EdStudGrantDegreeCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for SvCourseEvalCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvCourseEval>))]
		SvCourseEvalCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EdAcadPlanHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdAcadPlanHdr>))]
		EdAcadPlanHdrCollectionGetByEntMainSpcRltdId,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for SaStfMemberCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaStfMember>))]
		SaStfMemberCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EntGradingMdDataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntGradingMdData>))]
		EntGradingMdDataCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EntMainMatrixCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntMainMatrix>))]
		EntMainMatrixCollectionGetByEntMainMinorId,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EdOfferingCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdOffering>))]
		EdOfferingCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EdBylawCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdBylaw>))]
		EdBylawCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EdStudFacultyCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudFaculty>))]
		EdStudFacultyCollectionGetByEntMainGrad2,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EntMainMatrixCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntMainMatrix>))]
		EntMainMatrixCollectionGetByEntMainMajorId,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for SeUserCrsAssessCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeUserCrsAssess>))]
		SeUserCrsAssessCollectionGetByEntMainDeptId,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for FeeSemesterAgendaCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeSemesterAgenda>))]
		FeeSemesterAgendaCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for AdmAppCountCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppCount>))]
		AdmAppCountCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for SaSupervisingJobsCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaSupervisingJobs>))]
		SaSupervisingJobsCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for SeUserCrsAssessCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeUserCrsAssess>))]
		SeUserCrsAssessCollectionGetByEntMainMajorId,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EdResultApproveCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdResultApprove>))]
		EdResultApproveCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EdCoursePrfxCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCoursePrfx>))]
		EdCoursePrfxCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for PgThesisGeneralSpecCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisGeneralSpec>))]
		PgThesisGeneralSpecCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EdAcadPlanHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdAcadPlanHdr>))]
		EdAcadPlanHdrCollectionGetByEntMainRltdId,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EdStudStateTempCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudStateTemp>))]
		EdStudStateTempCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for AdmRatingParametersMajorsCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmRatingParametersMajors>))]
		AdmRatingParametersMajorsCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for AdmPlaceExamDatetimeCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmPlaceExamDatetime>))]
		AdmPlaceExamDatetimeCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EdCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourse>))]
		EdCourseCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for SeUserAccntCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeUserAccnt>))]
		SeUserAccntCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for SaEmpHierarchyCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaEmpHierarchy>))]
		SaEmpHierarchyCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EdStudBranchPrefCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudBranchPref>))]
		EdStudBranchPrefCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EntityMainCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntityMain>))]
		EntityMainCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for SaExtDelCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaExtDel>))]
		SaExtDelCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for ScScheduleRsrvCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScScheduleRsrv>))]
		ScScheduleRsrvCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for ScSchdlPeriodCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScSchdlPeriod>))]
		ScSchdlPeriodCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for SeBlockTransCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeBlockTrans>))]
		SeBlockTransCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for ScGroupInfoCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScGroupInfo>))]
		ScGroupInfoCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EntPolcyGrdngHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolcyGrdngHdr>))]
		EntPolcyGrdngHdrCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EdInttransRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdInttransRule>))]
		EdInttransRuleCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for EntCourseMdDataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntCourseMdData>))]
		EntCourseMdDataCollection,
		///<summary>
		/// Collection of <c>EntityMain</c> as OneToMany for GsCommCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsComm>))]
		GsCommCollectionGetByEntMainMajorId,
	}
	
	#endregion EntityMainChildEntityTypes
	
	#region EntityMainFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityMainColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntityMain"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntityMainFilterBuilder : SqlFilterBuilder<EntityMainColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntityMainFilterBuilder class.
		/// </summary>
		public EntityMainFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntityMainFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntityMainFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntityMainFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntityMainFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntityMainFilterBuilder
	
	#region EntityMainParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityMainColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntityMain"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntityMainParameterBuilder : ParameterizedSqlFilterBuilder<EntityMainColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntityMainParameterBuilder class.
		/// </summary>
		public EntityMainParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntityMainParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntityMainParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntityMainParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntityMainParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntityMainParameterBuilder
	
	#region EntityMainSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityMainColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntityMain"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntityMainSortBuilder : SqlSortBuilder<EntityMainColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntityMainSqlSortBuilder class.
		/// </summary>
		public EntityMainSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntityMainSortBuilder
	
} // end namespace
