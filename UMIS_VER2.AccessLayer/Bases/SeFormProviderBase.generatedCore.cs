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
	/// This class is the base class for any <see cref="SeFormProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SeFormProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SeForm, UMIS_VER2.BusinessLyer.SeFormKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeFormKey key)
		{
			return Delete(transactionManager, key.SeFormId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_seFormId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _seFormId)
		{
			return Delete(null, _seFormId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _seFormId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_FORM_AS_CODE_DEGREE_CLASS key.
		///		FK_SE_FORM_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeForm objects.</returns>
		public TList<SeForm> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(_asCodeDegreeClassId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_FORM_AS_CODE_DEGREE_CLASS key.
		///		FK_SE_FORM_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeForm objects.</returns>
		/// <remarks></remarks>
		public TList<SeForm> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_FORM_AS_CODE_DEGREE_CLASS key.
		///		FK_SE_FORM_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeForm objects.</returns>
		public TList<SeForm> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_FORM_AS_CODE_DEGREE_CLASS key.
		///		fkSeFormAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeForm objects.</returns>
		public TList<SeForm> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_FORM_AS_CODE_DEGREE_CLASS key.
		///		fkSeFormAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeForm objects.</returns>
		public TList<SeForm> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_FORM_AS_CODE_DEGREE_CLASS key.
		///		FK_SE_FORM_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeForm objects.</returns>
		public abstract TList<SeForm> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_FORM_AS_FACULTY_INFO key.
		///		FK_SE_FORM_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeForm objects.</returns>
		public TList<SeForm> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_FORM_AS_FACULTY_INFO key.
		///		FK_SE_FORM_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeForm objects.</returns>
		/// <remarks></remarks>
		public TList<SeForm> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_FORM_AS_FACULTY_INFO key.
		///		FK_SE_FORM_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeForm objects.</returns>
		public TList<SeForm> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_FORM_AS_FACULTY_INFO key.
		///		fkSeFormAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeForm objects.</returns>
		public TList<SeForm> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_FORM_AS_FACULTY_INFO key.
		///		fkSeFormAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeForm objects.</returns>
		public TList<SeForm> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_FORM_AS_FACULTY_INFO key.
		///		FK_SE_FORM_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeForm objects.</returns>
		public abstract TList<SeForm> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_FORM_ED_CODE_STUDY_METHOD key.
		///		FK_SE_FORM_ED_CODE_STUDY_METHOD Description: 
		/// </summary>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeForm objects.</returns>
		public TList<SeForm> GetByEdCodeStudyMethodId(System.Decimal? _edCodeStudyMethodId)
		{
			int count = -1;
			return GetByEdCodeStudyMethodId(_edCodeStudyMethodId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_FORM_ED_CODE_STUDY_METHOD key.
		///		FK_SE_FORM_ED_CODE_STUDY_METHOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeForm objects.</returns>
		/// <remarks></remarks>
		public TList<SeForm> GetByEdCodeStudyMethodId(TransactionManager transactionManager, System.Decimal? _edCodeStudyMethodId)
		{
			int count = -1;
			return GetByEdCodeStudyMethodId(transactionManager, _edCodeStudyMethodId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_FORM_ED_CODE_STUDY_METHOD key.
		///		FK_SE_FORM_ED_CODE_STUDY_METHOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeForm objects.</returns>
		public TList<SeForm> GetByEdCodeStudyMethodId(TransactionManager transactionManager, System.Decimal? _edCodeStudyMethodId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeStudyMethodId(transactionManager, _edCodeStudyMethodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_FORM_ED_CODE_STUDY_METHOD key.
		///		fkSeFormEdCodeStudyMethod Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeForm objects.</returns>
		public TList<SeForm> GetByEdCodeStudyMethodId(System.Decimal? _edCodeStudyMethodId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeStudyMethodId(null, _edCodeStudyMethodId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_FORM_ED_CODE_STUDY_METHOD key.
		///		fkSeFormEdCodeStudyMethod Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeForm objects.</returns>
		public TList<SeForm> GetByEdCodeStudyMethodId(System.Decimal? _edCodeStudyMethodId, int start, int pageLength,out int count)
		{
			return GetByEdCodeStudyMethodId(null, _edCodeStudyMethodId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_FORM_ED_CODE_STUDY_METHOD key.
		///		FK_SE_FORM_ED_CODE_STUDY_METHOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeForm objects.</returns>
		public abstract TList<SeForm> GetByEdCodeStudyMethodId(TransactionManager transactionManager, System.Decimal? _edCodeStudyMethodId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SeForm Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeFormKey key, int start, int pageLength)
		{
			return GetBySeFormId(transactionManager, key.SeFormId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SE_MODULE_ID_1 index.
		/// </summary>
		/// <param name="_seModuleId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeForm&gt;"/> class.</returns>
		public TList<SeForm> GetBySeModuleId(System.Decimal _seModuleId)
		{
			int count = -1;
			return GetBySeModuleId(null,_seModuleId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_MODULE_ID_1 index.
		/// </summary>
		/// <param name="_seModuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeForm&gt;"/> class.</returns>
		public TList<SeForm> GetBySeModuleId(System.Decimal _seModuleId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeModuleId(null, _seModuleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_MODULE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seModuleId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeForm&gt;"/> class.</returns>
		public TList<SeForm> GetBySeModuleId(TransactionManager transactionManager, System.Decimal _seModuleId)
		{
			int count = -1;
			return GetBySeModuleId(transactionManager, _seModuleId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_MODULE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seModuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeForm&gt;"/> class.</returns>
		public TList<SeForm> GetBySeModuleId(TransactionManager transactionManager, System.Decimal _seModuleId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeModuleId(transactionManager, _seModuleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_MODULE_ID_1 index.
		/// </summary>
		/// <param name="_seModuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeForm&gt;"/> class.</returns>
		public TList<SeForm> GetBySeModuleId(System.Decimal _seModuleId, int start, int pageLength, out int count)
		{
			return GetBySeModuleId(null, _seModuleId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_MODULE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seModuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeForm&gt;"/> class.</returns>
		public abstract TList<SeForm> GetBySeModuleId(TransactionManager transactionManager, System.Decimal _seModuleId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SE_FORM index.
		/// </summary>
		/// <param name="_seFormId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeForm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeForm GetBySeFormId(System.Decimal _seFormId)
		{
			int count = -1;
			return GetBySeFormId(null,_seFormId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_FORM index.
		/// </summary>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeForm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeForm GetBySeFormId(System.Decimal _seFormId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeFormId(null, _seFormId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_FORM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeForm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeForm GetBySeFormId(TransactionManager transactionManager, System.Decimal _seFormId)
		{
			int count = -1;
			return GetBySeFormId(transactionManager, _seFormId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_FORM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeForm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeForm GetBySeFormId(TransactionManager transactionManager, System.Decimal _seFormId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeFormId(transactionManager, _seFormId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_FORM index.
		/// </summary>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeForm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeForm GetBySeFormId(System.Decimal _seFormId, int start, int pageLength, out int count)
		{
			return GetBySeFormId(null, _seFormId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_FORM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeForm"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SeForm GetBySeFormId(TransactionManager transactionManager, System.Decimal _seFormId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SeForm&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SeForm&gt;"/></returns>
		public static TList<SeForm> Fill(IDataReader reader, TList<SeForm> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SeForm c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SeForm")
					.Append("|").Append((System.Decimal)reader["SE_FORM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SeForm>(
					key.ToString(), // EntityTrackingKey
					"SeForm",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SeForm();
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
					c.SeFormId = (System.Decimal)reader["SE_FORM_ID"];
					c.OriginalSeFormId = c.SeFormId;
					c.SeModuleId = (System.Decimal)reader["SE_MODULE_ID"];
					c.FormCodeName = (System.String)reader["FORM_CODE_NAME"];
					c.DescAr = (System.String)reader["DESC_AR"];
					c.MenuPage = (System.Decimal)reader["Menu_Page"];
					c.FacultyFlag = (System.Decimal)reader["Faculty_Flag"];
					c.TrandFlag = (System.Decimal)reader["Trand_Flag"];
					c.DescEn = Convert.IsDBNull(reader["DESC_EN"]) ? null : (System.String)reader["DESC_EN"];
					c.OrderFlg = Convert.IsDBNull(reader["ORDER_FLG"]) ? null : (System.Decimal?)reader["ORDER_FLG"];
					c.EdCodeStudyMethodId = Convert.IsDBNull(reader["ED_CODE_STUDY_METHOD_ID"]) ? null : (System.Decimal?)reader["ED_CODE_STUDY_METHOD_ID"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.AsCodeDegreeClassId = Convert.IsDBNull(reader["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_CLASS_ID"];
					c.SignatureFlg = Convert.IsDBNull(reader["SIGNATURE_FLG"]) ? null : (System.Boolean?)reader["SIGNATURE_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeForm"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeForm"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SeForm entity)
		{
			if (!reader.Read()) return;
			
			entity.SeFormId = (System.Decimal)reader[((int)SeFormColumn.SeFormId - 1)];
			entity.OriginalSeFormId = (System.Decimal)reader["SE_FORM_ID"];
			entity.SeModuleId = (System.Decimal)reader[((int)SeFormColumn.SeModuleId - 1)];
			entity.FormCodeName = (System.String)reader[((int)SeFormColumn.FormCodeName - 1)];
			entity.DescAr = (System.String)reader[((int)SeFormColumn.DescAr - 1)];
			entity.MenuPage = (System.Decimal)reader[((int)SeFormColumn.MenuPage - 1)];
			entity.FacultyFlag = (System.Decimal)reader[((int)SeFormColumn.FacultyFlag - 1)];
			entity.TrandFlag = (System.Decimal)reader[((int)SeFormColumn.TrandFlag - 1)];
			entity.DescEn = (reader.IsDBNull(((int)SeFormColumn.DescEn - 1)))?null:(System.String)reader[((int)SeFormColumn.DescEn - 1)];
			entity.OrderFlg = (reader.IsDBNull(((int)SeFormColumn.OrderFlg - 1)))?null:(System.Decimal?)reader[((int)SeFormColumn.OrderFlg - 1)];
			entity.EdCodeStudyMethodId = (reader.IsDBNull(((int)SeFormColumn.EdCodeStudyMethodId - 1)))?null:(System.Decimal?)reader[((int)SeFormColumn.EdCodeStudyMethodId - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)SeFormColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)SeFormColumn.AsFacultyInfoId - 1)];
			entity.AsCodeDegreeClassId = (reader.IsDBNull(((int)SeFormColumn.AsCodeDegreeClassId - 1)))?null:(System.Decimal?)reader[((int)SeFormColumn.AsCodeDegreeClassId - 1)];
			entity.SignatureFlg = (reader.IsDBNull(((int)SeFormColumn.SignatureFlg - 1)))?null:(System.Boolean?)reader[((int)SeFormColumn.SignatureFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeForm"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeForm"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SeForm entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SeFormId = (System.Decimal)dataRow["SE_FORM_ID"];
			entity.OriginalSeFormId = (System.Decimal)dataRow["SE_FORM_ID"];
			entity.SeModuleId = (System.Decimal)dataRow["SE_MODULE_ID"];
			entity.FormCodeName = (System.String)dataRow["FORM_CODE_NAME"];
			entity.DescAr = (System.String)dataRow["DESC_AR"];
			entity.MenuPage = (System.Decimal)dataRow["Menu_Page"];
			entity.FacultyFlag = (System.Decimal)dataRow["Faculty_Flag"];
			entity.TrandFlag = (System.Decimal)dataRow["Trand_Flag"];
			entity.DescEn = Convert.IsDBNull(dataRow["DESC_EN"]) ? null : (System.String)dataRow["DESC_EN"];
			entity.OrderFlg = Convert.IsDBNull(dataRow["ORDER_FLG"]) ? null : (System.Decimal?)dataRow["ORDER_FLG"];
			entity.EdCodeStudyMethodId = Convert.IsDBNull(dataRow["ED_CODE_STUDY_METHOD_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_STUDY_METHOD_ID"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.AsCodeDegreeClassId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_CLASS_ID"];
			entity.SignatureFlg = Convert.IsDBNull(dataRow["SIGNATURE_FLG"]) ? null : (System.Boolean?)dataRow["SIGNATURE_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeForm"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeForm Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeForm entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region EdCodeStudyMethodIdSource	
			if (CanDeepLoad(entity, "EdCodeStudyMethod|EdCodeStudyMethodIdSource", deepLoadType, innerList) 
				&& entity.EdCodeStudyMethodIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeStudyMethodId ?? 0.0m);
				EdCodeStudyMethod tmpEntity = EntityManager.LocateEntity<EdCodeStudyMethod>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeStudyMethod), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeStudyMethodIdSource = tmpEntity;
				else
					entity.EdCodeStudyMethodIdSource = DataRepository.EdCodeStudyMethodProvider.GetByEdCodeStudyMethodId(transactionManager, (entity.EdCodeStudyMethodId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeStudyMethodIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeStudyMethodIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeStudyMethodProvider.DeepLoad(transactionManager, entity.EdCodeStudyMethodIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeStudyMethodIdSource

			#region SeModuleIdSource	
			if (CanDeepLoad(entity, "SeModule|SeModuleIdSource", deepLoadType, innerList) 
				&& entity.SeModuleIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SeModuleId;
				SeModule tmpEntity = EntityManager.LocateEntity<SeModule>(EntityLocator.ConstructKeyFromPkItems(typeof(SeModule), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeModuleIdSource = tmpEntity;
				else
					entity.SeModuleIdSource = DataRepository.SeModuleProvider.GetBySeModuleId(transactionManager, entity.SeModuleId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeModuleIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeModuleIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeModuleProvider.DeepLoad(transactionManager, entity.SeModuleIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeModuleIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySeFormId methods when available
			
			#region EdStudAcadWarnCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudAcadWarn>|EdStudAcadWarnCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudAcadWarnCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudAcadWarnCollection = DataRepository.EdStudAcadWarnProvider.GetBySeFormId(transactionManager, entity.SeFormId);

				if (deep && entity.EdStudAcadWarnCollection.Count > 0)
				{
					deepHandles.Add("EdStudAcadWarnCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudAcadWarn>) DataRepository.EdStudAcadWarnProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudAcadWarnCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.CtrStudExpCollection = DataRepository.CtrStudExpProvider.GetBySeFormId(transactionManager, entity.SeFormId);

				if (deep && entity.CtrStudExpCollection.Count > 0)
				{
					deepHandles.Add("CtrStudExpCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CtrStudExp>) DataRepository.CtrStudExpProvider.DeepLoad,
						new object[] { transactionManager, entity.CtrStudExpCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdStudAbsFwCollection = DataRepository.EdStudAbsFwProvider.GetBySeFormId(transactionManager, entity.SeFormId);

				if (deep && entity.EdStudAbsFwCollection.Count > 0)
				{
					deepHandles.Add("EdStudAbsFwCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudAbsFw>) DataRepository.EdStudAbsFwProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudAbsFwCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdStudExcuseCollection = DataRepository.EdStudExcuseProvider.GetBySeFormId(transactionManager, entity.SeFormId);

				if (deep && entity.EdStudExcuseCollection.Count > 0)
				{
					deepHandles.Add("EdStudExcuseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudExcuse>) DataRepository.EdStudExcuseProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudExcuseCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdStudEnrollChangeCollection = DataRepository.EdStudEnrollChangeProvider.GetBySeFormId(transactionManager, entity.SeFormId);

				if (deep && entity.EdStudEnrollChangeCollection.Count > 0)
				{
					deepHandles.Add("EdStudEnrollChangeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudEnrollChange>) DataRepository.EdStudEnrollChangeProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudEnrollChangeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeAccntFormDiffCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeAccntFormDiff>|SeAccntFormDiffCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeAccntFormDiffCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeAccntFormDiffCollection = DataRepository.SeAccntFormDiffProvider.GetBySeFormId(transactionManager, entity.SeFormId);

				if (deep && entity.SeAccntFormDiffCollection.Count > 0)
				{
					deepHandles.Add("SeAccntFormDiffCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeAccntFormDiff>) DataRepository.SeAccntFormDiffProvider.DeepLoad,
						new object[] { transactionManager, entity.SeAccntFormDiffCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegAssessCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseRegAssess>|EdStudCourseRegAssessCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegAssessCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegAssessCollection = DataRepository.EdStudCourseRegAssessProvider.GetBySeFormId(transactionManager, entity.SeFormId);

				if (deep && entity.EdStudCourseRegAssessCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegAssessCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseRegAssess>) DataRepository.EdStudCourseRegAssessProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegAssessCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeUserAccntFormDiffCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeUserAccntFormDiff>|SeUserAccntFormDiffCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserAccntFormDiffCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeUserAccntFormDiffCollection = DataRepository.SeUserAccntFormDiffProvider.GetBySeFormId(transactionManager, entity.SeFormId);

				if (deep && entity.SeUserAccntFormDiffCollection.Count > 0)
				{
					deepHandles.Add("SeUserAccntFormDiffCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeUserAccntFormDiff>) DataRepository.SeUserAccntFormDiffProvider.DeepLoad,
						new object[] { transactionManager, entity.SeUserAccntFormDiffCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeFormControlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeFormControl>|SeFormControlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeFormControlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeFormControlCollection = DataRepository.SeFormControlProvider.GetBySeFormId(transactionManager, entity.SeFormId);

				if (deep && entity.SeFormControlCollection.Count > 0)
				{
					deepHandles.Add("SeFormControlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeFormControl>) DataRepository.SeFormControlProvider.DeepLoad,
						new object[] { transactionManager, entity.SeFormControlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseReg>|EdStudCourseRegCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegCollection = DataRepository.EdStudCourseRegProvider.GetBySeFormId(transactionManager, entity.SeFormId);

				if (deep && entity.EdStudCourseRegCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseReg>) DataRepository.EdStudCourseRegProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdSemAgendaFormCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdSemAgendaForm>|EdSemAgendaFormCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdSemAgendaFormCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdSemAgendaFormCollection = DataRepository.EdSemAgendaFormProvider.GetBySeFormId(transactionManager, entity.SeFormId);

				if (deep && entity.EdSemAgendaFormCollection.Count > 0)
				{
					deepHandles.Add("EdSemAgendaFormCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdSemAgendaForm>) DataRepository.EdSemAgendaFormProvider.DeepLoad,
						new object[] { transactionManager, entity.EdSemAgendaFormCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdOfferingCourseCollection = DataRepository.EdOfferingCourseProvider.GetBySeFormId(transactionManager, entity.SeFormId);

				if (deep && entity.EdOfferingCourseCollection.Count > 0)
				{
					deepHandles.Add("EdOfferingCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdOfferingCourse>) DataRepository.EdOfferingCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.EdOfferingCourseCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.FeeStudFeeItemCollection = DataRepository.FeeStudFeeItemProvider.GetBySeFormId(transactionManager, entity.SeFormId);

				if (deep && entity.FeeStudFeeItemCollection.Count > 0)
				{
					deepHandles.Add("FeeStudFeeItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudFeeItem>) DataRepository.FeeStudFeeItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudFeeItemCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdStudCourseGrdChngCollection = DataRepository.EdStudCourseGrdChngProvider.GetBySeFormId(transactionManager, entity.SeFormId);

				if (deep && entity.EdStudCourseGrdChngCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseGrdChngCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseGrdChng>) DataRepository.EdStudCourseGrdChngProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseGrdChngCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.CtrStudOutCollection = DataRepository.CtrStudOutProvider.GetBySeFormId(transactionManager, entity.SeFormId);

				if (deep && entity.CtrStudOutCollection.Count > 0)
				{
					deepHandles.Add("CtrStudOutCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CtrStudOut>) DataRepository.CtrStudOutProvider.DeepLoad,
						new object[] { transactionManager, entity.CtrStudOutCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region UsrTopLinkCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<UsrTopLink>|UsrTopLinkCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'UsrTopLinkCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.UsrTopLinkCollection = DataRepository.UsrTopLinkProvider.GetBySeFormId(transactionManager, entity.SeFormId);

				if (deep && entity.UsrTopLinkCollection.Count > 0)
				{
					deepHandles.Add("UsrTopLinkCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<UsrTopLink>) DataRepository.UsrTopLinkProvider.DeepLoad,
						new object[] { transactionManager, entity.UsrTopLinkCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeApplicationLogCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeApplicationLog>|SeApplicationLogCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeApplicationLogCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeApplicationLogCollection = DataRepository.SeApplicationLogProvider.GetBySeFormId(transactionManager, entity.SeFormId);

				if (deep && entity.SeApplicationLogCollection.Count > 0)
				{
					deepHandles.Add("SeApplicationLogCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeApplicationLog>) DataRepository.SeApplicationLogProvider.DeepLoad,
						new object[] { transactionManager, entity.SeApplicationLogCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseChngCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseChng>|EdStudCourseChngCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseChngCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseChngCollection = DataRepository.EdStudCourseChngProvider.GetBySeFormId(transactionManager, entity.SeFormId);

				if (deep && entity.EdStudCourseChngCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseChngCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseChng>) DataRepository.EdStudCourseChngProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseChngCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SeForm object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SeForm instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeForm Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeForm entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdCodeStudyMethodIdSource
			if (CanDeepSave(entity, "EdCodeStudyMethod|EdCodeStudyMethodIdSource", deepSaveType, innerList) 
				&& entity.EdCodeStudyMethodIdSource != null)
			{
				DataRepository.EdCodeStudyMethodProvider.Save(transactionManager, entity.EdCodeStudyMethodIdSource);
				entity.EdCodeStudyMethodId = entity.EdCodeStudyMethodIdSource.EdCodeStudyMethodId;
			}
			#endregion 
			
			#region SeModuleIdSource
			if (CanDeepSave(entity, "SeModule|SeModuleIdSource", deepSaveType, innerList) 
				&& entity.SeModuleIdSource != null)
			{
				DataRepository.SeModuleProvider.Save(transactionManager, entity.SeModuleIdSource);
				entity.SeModuleId = entity.SeModuleIdSource.SeModuleId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EdStudAcadWarn>
				if (CanDeepSave(entity.EdStudAcadWarnCollection, "List<EdStudAcadWarn>|EdStudAcadWarnCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudAcadWarn child in entity.EdStudAcadWarnCollection)
					{
						if(child.SeFormIdSource != null)
						{
							child.SeFormId = child.SeFormIdSource.SeFormId;
						}
						else
						{
							child.SeFormId = entity.SeFormId;
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
				
	
			#region List<CtrStudExp>
				if (CanDeepSave(entity.CtrStudExpCollection, "List<CtrStudExp>|CtrStudExpCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CtrStudExp child in entity.CtrStudExpCollection)
					{
						if(child.SeFormIdSource != null)
						{
							child.SeFormId = child.SeFormIdSource.SeFormId;
						}
						else
						{
							child.SeFormId = entity.SeFormId;
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
				
	
			#region List<EdStudAbsFw>
				if (CanDeepSave(entity.EdStudAbsFwCollection, "List<EdStudAbsFw>|EdStudAbsFwCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudAbsFw child in entity.EdStudAbsFwCollection)
					{
						if(child.SeFormIdSource != null)
						{
							child.SeFormId = child.SeFormIdSource.SeFormId;
						}
						else
						{
							child.SeFormId = entity.SeFormId;
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
				
	
			#region List<EdStudExcuse>
				if (CanDeepSave(entity.EdStudExcuseCollection, "List<EdStudExcuse>|EdStudExcuseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudExcuse child in entity.EdStudExcuseCollection)
					{
						if(child.SeFormIdSource != null)
						{
							child.SeFormId = child.SeFormIdSource.SeFormId;
						}
						else
						{
							child.SeFormId = entity.SeFormId;
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
				
	
			#region List<EdStudEnrollChange>
				if (CanDeepSave(entity.EdStudEnrollChangeCollection, "List<EdStudEnrollChange>|EdStudEnrollChangeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudEnrollChange child in entity.EdStudEnrollChangeCollection)
					{
						if(child.SeFormIdSource != null)
						{
							child.SeFormId = child.SeFormIdSource.SeFormId;
						}
						else
						{
							child.SeFormId = entity.SeFormId;
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
				
	
			#region List<SeAccntFormDiff>
				if (CanDeepSave(entity.SeAccntFormDiffCollection, "List<SeAccntFormDiff>|SeAccntFormDiffCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeAccntFormDiff child in entity.SeAccntFormDiffCollection)
					{
						if(child.SeFormIdSource != null)
						{
							child.SeFormId = child.SeFormIdSource.SeFormId;
						}
						else
						{
							child.SeFormId = entity.SeFormId;
						}

					}

					if (entity.SeAccntFormDiffCollection.Count > 0 || entity.SeAccntFormDiffCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeAccntFormDiffProvider.Save(transactionManager, entity.SeAccntFormDiffCollection);
						
						deepHandles.Add("SeAccntFormDiffCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeAccntFormDiff >) DataRepository.SeAccntFormDiffProvider.DeepSave,
							new object[] { transactionManager, entity.SeAccntFormDiffCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseRegAssess>
				if (CanDeepSave(entity.EdStudCourseRegAssessCollection, "List<EdStudCourseRegAssess>|EdStudCourseRegAssessCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseRegAssess child in entity.EdStudCourseRegAssessCollection)
					{
						if(child.SeFormIdSource != null)
						{
							child.SeFormId = child.SeFormIdSource.SeFormId;
						}
						else
						{
							child.SeFormId = entity.SeFormId;
						}

					}

					if (entity.EdStudCourseRegAssessCollection.Count > 0 || entity.EdStudCourseRegAssessCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegAssessProvider.Save(transactionManager, entity.EdStudCourseRegAssessCollection);
						
						deepHandles.Add("EdStudCourseRegAssessCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseRegAssess >) DataRepository.EdStudCourseRegAssessProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegAssessCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeUserAccntFormDiff>
				if (CanDeepSave(entity.SeUserAccntFormDiffCollection, "List<SeUserAccntFormDiff>|SeUserAccntFormDiffCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeUserAccntFormDiff child in entity.SeUserAccntFormDiffCollection)
					{
						if(child.SeFormIdSource != null)
						{
							child.SeFormId = child.SeFormIdSource.SeFormId;
						}
						else
						{
							child.SeFormId = entity.SeFormId;
						}

					}

					if (entity.SeUserAccntFormDiffCollection.Count > 0 || entity.SeUserAccntFormDiffCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeUserAccntFormDiffProvider.Save(transactionManager, entity.SeUserAccntFormDiffCollection);
						
						deepHandles.Add("SeUserAccntFormDiffCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeUserAccntFormDiff >) DataRepository.SeUserAccntFormDiffProvider.DeepSave,
							new object[] { transactionManager, entity.SeUserAccntFormDiffCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeFormControl>
				if (CanDeepSave(entity.SeFormControlCollection, "List<SeFormControl>|SeFormControlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeFormControl child in entity.SeFormControlCollection)
					{
						if(child.SeFormIdSource != null)
						{
							child.SeFormId = child.SeFormIdSource.SeFormId;
						}
						else
						{
							child.SeFormId = entity.SeFormId;
						}

					}

					if (entity.SeFormControlCollection.Count > 0 || entity.SeFormControlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeFormControlProvider.Save(transactionManager, entity.SeFormControlCollection);
						
						deepHandles.Add("SeFormControlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeFormControl >) DataRepository.SeFormControlProvider.DeepSave,
							new object[] { transactionManager, entity.SeFormControlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseReg>
				if (CanDeepSave(entity.EdStudCourseRegCollection, "List<EdStudCourseReg>|EdStudCourseRegCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseReg child in entity.EdStudCourseRegCollection)
					{
						if(child.SeFormIdSource != null)
						{
							child.SeFormId = child.SeFormIdSource.SeFormId;
						}
						else
						{
							child.SeFormId = entity.SeFormId;
						}

					}

					if (entity.EdStudCourseRegCollection.Count > 0 || entity.EdStudCourseRegCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegProvider.Save(transactionManager, entity.EdStudCourseRegCollection);
						
						deepHandles.Add("EdStudCourseRegCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseReg >) DataRepository.EdStudCourseRegProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdSemAgendaForm>
				if (CanDeepSave(entity.EdSemAgendaFormCollection, "List<EdSemAgendaForm>|EdSemAgendaFormCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdSemAgendaForm child in entity.EdSemAgendaFormCollection)
					{
						if(child.SeFormIdSource != null)
						{
							child.SeFormId = child.SeFormIdSource.SeFormId;
						}
						else
						{
							child.SeFormId = entity.SeFormId;
						}

					}

					if (entity.EdSemAgendaFormCollection.Count > 0 || entity.EdSemAgendaFormCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdSemAgendaFormProvider.Save(transactionManager, entity.EdSemAgendaFormCollection);
						
						deepHandles.Add("EdSemAgendaFormCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdSemAgendaForm >) DataRepository.EdSemAgendaFormProvider.DeepSave,
							new object[] { transactionManager, entity.EdSemAgendaFormCollection, deepSaveType, childTypes, innerList }
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
						if(child.SeFormIdSource != null)
						{
							child.SeFormId = child.SeFormIdSource.SeFormId;
						}
						else
						{
							child.SeFormId = entity.SeFormId;
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
				
	
			#region List<FeeStudFeeItem>
				if (CanDeepSave(entity.FeeStudFeeItemCollection, "List<FeeStudFeeItem>|FeeStudFeeItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudFeeItem child in entity.FeeStudFeeItemCollection)
					{
						if(child.SeFormIdSource != null)
						{
							child.SeFormId = child.SeFormIdSource.SeFormId;
						}
						else
						{
							child.SeFormId = entity.SeFormId;
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
				
	
			#region List<EdStudCourseGrdChng>
				if (CanDeepSave(entity.EdStudCourseGrdChngCollection, "List<EdStudCourseGrdChng>|EdStudCourseGrdChngCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseGrdChng child in entity.EdStudCourseGrdChngCollection)
					{
						if(child.SeFormIdSource != null)
						{
							child.SeFormId = child.SeFormIdSource.SeFormId;
						}
						else
						{
							child.SeFormId = entity.SeFormId;
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
				
	
			#region List<CtrStudOut>
				if (CanDeepSave(entity.CtrStudOutCollection, "List<CtrStudOut>|CtrStudOutCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CtrStudOut child in entity.CtrStudOutCollection)
					{
						if(child.SeFormIdSource != null)
						{
							child.SeFormId = child.SeFormIdSource.SeFormId;
						}
						else
						{
							child.SeFormId = entity.SeFormId;
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
				
	
			#region List<UsrTopLink>
				if (CanDeepSave(entity.UsrTopLinkCollection, "List<UsrTopLink>|UsrTopLinkCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(UsrTopLink child in entity.UsrTopLinkCollection)
					{
						if(child.SeFormIdSource != null)
						{
							child.SeFormId = child.SeFormIdSource.SeFormId;
						}
						else
						{
							child.SeFormId = entity.SeFormId;
						}

					}

					if (entity.UsrTopLinkCollection.Count > 0 || entity.UsrTopLinkCollection.DeletedItems.Count > 0)
					{
						//DataRepository.UsrTopLinkProvider.Save(transactionManager, entity.UsrTopLinkCollection);
						
						deepHandles.Add("UsrTopLinkCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< UsrTopLink >) DataRepository.UsrTopLinkProvider.DeepSave,
							new object[] { transactionManager, entity.UsrTopLinkCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeApplicationLog>
				if (CanDeepSave(entity.SeApplicationLogCollection, "List<SeApplicationLog>|SeApplicationLogCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeApplicationLog child in entity.SeApplicationLogCollection)
					{
						if(child.SeFormIdSource != null)
						{
							child.SeFormId = child.SeFormIdSource.SeFormId;
						}
						else
						{
							child.SeFormId = entity.SeFormId;
						}

					}

					if (entity.SeApplicationLogCollection.Count > 0 || entity.SeApplicationLogCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeApplicationLogProvider.Save(transactionManager, entity.SeApplicationLogCollection);
						
						deepHandles.Add("SeApplicationLogCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeApplicationLog >) DataRepository.SeApplicationLogProvider.DeepSave,
							new object[] { transactionManager, entity.SeApplicationLogCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseChng>
				if (CanDeepSave(entity.EdStudCourseChngCollection, "List<EdStudCourseChng>|EdStudCourseChngCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseChng child in entity.EdStudCourseChngCollection)
					{
						if(child.SeFormIdSource != null)
						{
							child.SeFormId = child.SeFormIdSource.SeFormId;
						}
						else
						{
							child.SeFormId = entity.SeFormId;
						}

					}

					if (entity.EdStudCourseChngCollection.Count > 0 || entity.EdStudCourseChngCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseChngProvider.Save(transactionManager, entity.EdStudCourseChngCollection);
						
						deepHandles.Add("EdStudCourseChngCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseChng >) DataRepository.EdStudCourseChngProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseChngCollection, deepSaveType, childTypes, innerList }
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
	
	#region SeFormChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SeForm</c>
	///</summary>
	public enum SeFormChildEntityTypes
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
		/// Composite Property for <c>EdCodeStudyMethod</c> at EdCodeStudyMethodIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeStudyMethod))]
		EdCodeStudyMethod,
		
		///<summary>
		/// Composite Property for <c>SeModule</c> at SeModuleIdSource
		///</summary>
		[ChildEntityType(typeof(SeModule))]
		SeModule,
		///<summary>
		/// Collection of <c>SeForm</c> as OneToMany for EdStudAcadWarnCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudAcadWarn>))]
		EdStudAcadWarnCollection,
		///<summary>
		/// Collection of <c>SeForm</c> as OneToMany for CtrStudExpCollection
		///</summary>
		[ChildEntityType(typeof(TList<CtrStudExp>))]
		CtrStudExpCollection,
		///<summary>
		/// Collection of <c>SeForm</c> as OneToMany for EdStudAbsFwCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudAbsFw>))]
		EdStudAbsFwCollection,
		///<summary>
		/// Collection of <c>SeForm</c> as OneToMany for EdStudExcuseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudExcuse>))]
		EdStudExcuseCollection,
		///<summary>
		/// Collection of <c>SeForm</c> as OneToMany for EdStudEnrollChangeCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudEnrollChange>))]
		EdStudEnrollChangeCollection,
		///<summary>
		/// Collection of <c>SeForm</c> as OneToMany for SeAccntFormDiffCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeAccntFormDiff>))]
		SeAccntFormDiffCollection,
		///<summary>
		/// Collection of <c>SeForm</c> as OneToMany for EdStudCourseRegAssessCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseRegAssess>))]
		EdStudCourseRegAssessCollection,
		///<summary>
		/// Collection of <c>SeForm</c> as OneToMany for SeUserAccntFormDiffCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeUserAccntFormDiff>))]
		SeUserAccntFormDiffCollection,
		///<summary>
		/// Collection of <c>SeForm</c> as OneToMany for SeFormControlCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeFormControl>))]
		SeFormControlCollection,
		///<summary>
		/// Collection of <c>SeForm</c> as OneToMany for EdStudCourseRegCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseReg>))]
		EdStudCourseRegCollection,
		///<summary>
		/// Collection of <c>SeForm</c> as OneToMany for EdSemAgendaFormCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdSemAgendaForm>))]
		EdSemAgendaFormCollection,
		///<summary>
		/// Collection of <c>SeForm</c> as OneToMany for EdOfferingCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdOfferingCourse>))]
		EdOfferingCourseCollection,
		///<summary>
		/// Collection of <c>SeForm</c> as OneToMany for FeeStudFeeItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudFeeItem>))]
		FeeStudFeeItemCollection,
		///<summary>
		/// Collection of <c>SeForm</c> as OneToMany for EdStudCourseGrdChngCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseGrdChng>))]
		EdStudCourseGrdChngCollection,
		///<summary>
		/// Collection of <c>SeForm</c> as OneToMany for CtrStudOutCollection
		///</summary>
		[ChildEntityType(typeof(TList<CtrStudOut>))]
		CtrStudOutCollection,
		///<summary>
		/// Collection of <c>SeForm</c> as OneToMany for UsrTopLinkCollection
		///</summary>
		[ChildEntityType(typeof(TList<UsrTopLink>))]
		UsrTopLinkCollection,
		///<summary>
		/// Collection of <c>SeForm</c> as OneToMany for SeApplicationLogCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeApplicationLog>))]
		SeApplicationLogCollection,
		///<summary>
		/// Collection of <c>SeForm</c> as OneToMany for EdStudCourseChngCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseChng>))]
		EdStudCourseChngCollection,
	}
	
	#endregion SeFormChildEntityTypes
	
	#region SeFormFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SeFormColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeForm"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeFormFilterBuilder : SqlFilterBuilder<SeFormColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeFormFilterBuilder class.
		/// </summary>
		public SeFormFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeFormFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeFormFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeFormFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeFormFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeFormFilterBuilder
	
	#region SeFormParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SeFormColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeForm"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeFormParameterBuilder : ParameterizedSqlFilterBuilder<SeFormColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeFormParameterBuilder class.
		/// </summary>
		public SeFormParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeFormParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeFormParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeFormParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeFormParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeFormParameterBuilder
	
	#region SeFormSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SeFormColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeForm"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SeFormSortBuilder : SqlSortBuilder<SeFormColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeFormSqlSortBuilder class.
		/// </summary>
		public SeFormSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SeFormSortBuilder
	
} // end namespace
