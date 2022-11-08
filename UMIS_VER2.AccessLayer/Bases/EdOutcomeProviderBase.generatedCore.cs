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
	/// This class is the base class for any <see cref="EdOutcomeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdOutcomeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdOutcome, UMIS_VER2.BusinessLyer.EdOutcomeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdOutcomeKey key)
		{
			return Delete(transactionManager, key.EdOutcomeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edOutcomeId">مخرجات التعلم. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edOutcomeId)
		{
			return Delete(null, _edOutcomeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edOutcomeId">مخرجات التعلم. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edOutcomeId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OUTCOME_ED_CDE_OUTCOME_CAT key.
		///		FK_ED_OUTCOME_ED_CDE_OUTCOME_CAT Description: 
		/// </summary>
		/// <param name="_edCdeOutcomeCatId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOutcome objects.</returns>
		public TList<EdOutcome> GetByEdCdeOutcomeCatId(System.Int32 _edCdeOutcomeCatId)
		{
			int count = -1;
			return GetByEdCdeOutcomeCatId(_edCdeOutcomeCatId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OUTCOME_ED_CDE_OUTCOME_CAT key.
		///		FK_ED_OUTCOME_ED_CDE_OUTCOME_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeOutcomeCatId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOutcome objects.</returns>
		/// <remarks></remarks>
		public TList<EdOutcome> GetByEdCdeOutcomeCatId(TransactionManager transactionManager, System.Int32 _edCdeOutcomeCatId)
		{
			int count = -1;
			return GetByEdCdeOutcomeCatId(transactionManager, _edCdeOutcomeCatId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OUTCOME_ED_CDE_OUTCOME_CAT key.
		///		FK_ED_OUTCOME_ED_CDE_OUTCOME_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeOutcomeCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOutcome objects.</returns>
		public TList<EdOutcome> GetByEdCdeOutcomeCatId(TransactionManager transactionManager, System.Int32 _edCdeOutcomeCatId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeOutcomeCatId(transactionManager, _edCdeOutcomeCatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OUTCOME_ED_CDE_OUTCOME_CAT key.
		///		fkEdOutcomeEdCdeOutcomeCat Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeOutcomeCatId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOutcome objects.</returns>
		public TList<EdOutcome> GetByEdCdeOutcomeCatId(System.Int32 _edCdeOutcomeCatId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeOutcomeCatId(null, _edCdeOutcomeCatId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OUTCOME_ED_CDE_OUTCOME_CAT key.
		///		fkEdOutcomeEdCdeOutcomeCat Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeOutcomeCatId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOutcome objects.</returns>
		public TList<EdOutcome> GetByEdCdeOutcomeCatId(System.Int32 _edCdeOutcomeCatId, int start, int pageLength,out int count)
		{
			return GetByEdCdeOutcomeCatId(null, _edCdeOutcomeCatId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OUTCOME_ED_CDE_OUTCOME_CAT key.
		///		FK_ED_OUTCOME_ED_CDE_OUTCOME_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeOutcomeCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOutcome objects.</returns>
		public abstract TList<EdOutcome> GetByEdCdeOutcomeCatId(TransactionManager transactionManager, System.Int32 _edCdeOutcomeCatId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OUTCOME_ED_COURSE key.
		///		FK_ED_OUTCOME_ED_COURSE Description: 
		/// </summary>
		/// <param name="_edCourseId">مقرر</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOutcome objects.</returns>
		public TList<EdOutcome> GetByEdCourseId(System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(_edCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OUTCOME_ED_COURSE key.
		///		FK_ED_OUTCOME_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId">مقرر</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOutcome objects.</returns>
		/// <remarks></remarks>
		public TList<EdOutcome> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OUTCOME_ED_COURSE key.
		///		FK_ED_OUTCOME_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId">مقرر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOutcome objects.</returns>
		public TList<EdOutcome> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OUTCOME_ED_COURSE key.
		///		fkEdOutcomeEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId">مقرر</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOutcome objects.</returns>
		public TList<EdOutcome> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OUTCOME_ED_COURSE key.
		///		fkEdOutcomeEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId">مقرر</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOutcome objects.</returns>
		public TList<EdOutcome> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength,out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OUTCOME_ED_COURSE key.
		///		FK_ED_OUTCOME_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId">مقرر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOutcome objects.</returns>
		public abstract TList<EdOutcome> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OUTCOME_ENTITY_MAIN key.
		///		FK_ED_OUTCOME_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_entMainId">البرنامج</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOutcome objects.</returns>
		public TList<EdOutcome> GetByEntMainId(System.Decimal? _entMainId)
		{
			int count = -1;
			return GetByEntMainId(_entMainId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OUTCOME_ENTITY_MAIN key.
		///		FK_ED_OUTCOME_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">البرنامج</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOutcome objects.</returns>
		/// <remarks></remarks>
		public TList<EdOutcome> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OUTCOME_ENTITY_MAIN key.
		///		FK_ED_OUTCOME_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">البرنامج</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOutcome objects.</returns>
		public TList<EdOutcome> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OUTCOME_ENTITY_MAIN key.
		///		fkEdOutcomeEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId">البرنامج</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOutcome objects.</returns>
		public TList<EdOutcome> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainId(null, _entMainId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OUTCOME_ENTITY_MAIN key.
		///		fkEdOutcomeEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId">البرنامج</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOutcome objects.</returns>
		public TList<EdOutcome> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength,out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OUTCOME_ENTITY_MAIN key.
		///		FK_ED_OUTCOME_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">البرنامج</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOutcome objects.</returns>
		public abstract TList<EdOutcome> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OUTCOME_SE_USER key.
		///		FK_ED_OUTCOME_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOutcome objects.</returns>
		public TList<EdOutcome> GetBySeUserId(System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(_seUserId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OUTCOME_SE_USER key.
		///		FK_ED_OUTCOME_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOutcome objects.</returns>
		/// <remarks></remarks>
		public TList<EdOutcome> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OUTCOME_SE_USER key.
		///		FK_ED_OUTCOME_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOutcome objects.</returns>
		public TList<EdOutcome> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OUTCOME_SE_USER key.
		///		fkEdOutcomeSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOutcome objects.</returns>
		public TList<EdOutcome> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserId(null, _seUserId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OUTCOME_SE_USER key.
		///		fkEdOutcomeSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOutcome objects.</returns>
		public TList<EdOutcome> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength,out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OUTCOME_SE_USER key.
		///		FK_ED_OUTCOME_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOutcome objects.</returns>
		public abstract TList<EdOutcome> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdOutcome Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdOutcomeKey key, int start, int pageLength)
		{
			return GetByEdOutcomeId(transactionManager, key.EdOutcomeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_OUTCOME index.
		/// </summary>
		/// <param name="_edOutcomeId">مخرجات التعلم</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdOutcome"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdOutcome GetByEdOutcomeId(System.Decimal _edOutcomeId)
		{
			int count = -1;
			return GetByEdOutcomeId(null,_edOutcomeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_OUTCOME index.
		/// </summary>
		/// <param name="_edOutcomeId">مخرجات التعلم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdOutcome"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdOutcome GetByEdOutcomeId(System.Decimal _edOutcomeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdOutcomeId(null, _edOutcomeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_OUTCOME index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edOutcomeId">مخرجات التعلم</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdOutcome"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdOutcome GetByEdOutcomeId(TransactionManager transactionManager, System.Decimal _edOutcomeId)
		{
			int count = -1;
			return GetByEdOutcomeId(transactionManager, _edOutcomeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_OUTCOME index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edOutcomeId">مخرجات التعلم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdOutcome"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdOutcome GetByEdOutcomeId(TransactionManager transactionManager, System.Decimal _edOutcomeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdOutcomeId(transactionManager, _edOutcomeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_OUTCOME index.
		/// </summary>
		/// <param name="_edOutcomeId">مخرجات التعلم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdOutcome"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdOutcome GetByEdOutcomeId(System.Decimal _edOutcomeId, int start, int pageLength, out int count)
		{
			return GetByEdOutcomeId(null, _edOutcomeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_OUTCOME index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edOutcomeId">مخرجات التعلم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdOutcome"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdOutcome GetByEdOutcomeId(TransactionManager transactionManager, System.Decimal _edOutcomeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdOutcome&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdOutcome&gt;"/></returns>
		public static TList<EdOutcome> Fill(IDataReader reader, TList<EdOutcome> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdOutcome c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdOutcome")
					.Append("|").Append((System.Decimal)reader["ED_OUTCOME_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdOutcome>(
					key.ToString(), // EntityTrackingKey
					"EdOutcome",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdOutcome();
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
					c.EdOutcomeId = (System.Decimal)reader["ED_OUTCOME_ID"];
					c.OriginalEdOutcomeId = c.EdOutcomeId;
					c.EdCdeOutcomeCatId = (System.Int32)reader["ED_CDE_OUTCOME_CAT_ID"];
					c.EdCourseId = Convert.IsDBNull(reader["ED_COURSE_ID"]) ? null : (System.Decimal?)reader["ED_COURSE_ID"];
					c.EntMainId = Convert.IsDBNull(reader["ENT_MAIN_ID"]) ? null : (System.Decimal?)reader["ENT_MAIN_ID"];
					c.OutcomeAr = Convert.IsDBNull(reader["OUTCOME_AR"]) ? null : (System.String)reader["OUTCOME_AR"];
					c.OutcomeEn = Convert.IsDBNull(reader["OUTCOME_EN"]) ? null : (System.String)reader["OUTCOME_EN"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdOutcome"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdOutcome"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdOutcome entity)
		{
			if (!reader.Read()) return;
			
			entity.EdOutcomeId = (System.Decimal)reader[((int)EdOutcomeColumn.EdOutcomeId - 1)];
			entity.OriginalEdOutcomeId = (System.Decimal)reader["ED_OUTCOME_ID"];
			entity.EdCdeOutcomeCatId = (System.Int32)reader[((int)EdOutcomeColumn.EdCdeOutcomeCatId - 1)];
			entity.EdCourseId = (reader.IsDBNull(((int)EdOutcomeColumn.EdCourseId - 1)))?null:(System.Decimal?)reader[((int)EdOutcomeColumn.EdCourseId - 1)];
			entity.EntMainId = (reader.IsDBNull(((int)EdOutcomeColumn.EntMainId - 1)))?null:(System.Decimal?)reader[((int)EdOutcomeColumn.EntMainId - 1)];
			entity.OutcomeAr = (reader.IsDBNull(((int)EdOutcomeColumn.OutcomeAr - 1)))?null:(System.String)reader[((int)EdOutcomeColumn.OutcomeAr - 1)];
			entity.OutcomeEn = (reader.IsDBNull(((int)EdOutcomeColumn.OutcomeEn - 1)))?null:(System.String)reader[((int)EdOutcomeColumn.OutcomeEn - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EdOutcomeColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EdOutcomeColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EdOutcomeColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EdOutcomeColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdOutcome"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdOutcome"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdOutcome entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdOutcomeId = (System.Decimal)dataRow["ED_OUTCOME_ID"];
			entity.OriginalEdOutcomeId = (System.Decimal)dataRow["ED_OUTCOME_ID"];
			entity.EdCdeOutcomeCatId = (System.Int32)dataRow["ED_CDE_OUTCOME_CAT_ID"];
			entity.EdCourseId = Convert.IsDBNull(dataRow["ED_COURSE_ID"]) ? null : (System.Decimal?)dataRow["ED_COURSE_ID"];
			entity.EntMainId = Convert.IsDBNull(dataRow["ENT_MAIN_ID"]) ? null : (System.Decimal?)dataRow["ENT_MAIN_ID"];
			entity.OutcomeAr = Convert.IsDBNull(dataRow["OUTCOME_AR"]) ? null : (System.String)dataRow["OUTCOME_AR"];
			entity.OutcomeEn = Convert.IsDBNull(dataRow["OUTCOME_EN"]) ? null : (System.String)dataRow["OUTCOME_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdOutcome"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdOutcome Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdOutcome entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCdeOutcomeCatIdSource	
			if (CanDeepLoad(entity, "EdCdeOutcomeCat|EdCdeOutcomeCatIdSource", deepLoadType, innerList) 
				&& entity.EdCdeOutcomeCatIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCdeOutcomeCatId;
				EdCdeOutcomeCat tmpEntity = EntityManager.LocateEntity<EdCdeOutcomeCat>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeOutcomeCat), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCdeOutcomeCatIdSource = tmpEntity;
				else
					entity.EdCdeOutcomeCatIdSource = DataRepository.EdCdeOutcomeCatProvider.GetByEdCdeOutcomeCatId(transactionManager, entity.EdCdeOutcomeCatId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeOutcomeCatIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCdeOutcomeCatIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCdeOutcomeCatProvider.DeepLoad(transactionManager, entity.EdCdeOutcomeCatIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCdeOutcomeCatIdSource

			#region EdCourseIdSource	
			if (CanDeepLoad(entity, "EdCourse|EdCourseIdSource", deepLoadType, innerList) 
				&& entity.EdCourseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCourseId ?? 0.0m);
				EdCourse tmpEntity = EntityManager.LocateEntity<EdCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseIdSource = tmpEntity;
				else
					entity.EdCourseIdSource = DataRepository.EdCourseProvider.GetByEdCourseId(transactionManager, (entity.EdCourseId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCourseIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCourseProvider.DeepLoad(transactionManager, entity.EdCourseIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCourseIdSource

			#region EntMainIdSource	
			if (CanDeepLoad(entity, "EntityMain|EntMainIdSource", deepLoadType, innerList) 
				&& entity.EntMainIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntMainId ?? 0.0m);
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntMainIdSource = tmpEntity;
				else
					entity.EntMainIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, (entity.EntMainId ?? 0.0m));		
				
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

			#region SeUserIdSource	
			if (CanDeepLoad(entity, "SeUser|SeUserIdSource", deepLoadType, innerList) 
				&& entity.SeUserIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeUserId ?? 0.0m);
				SeUser tmpEntity = EntityManager.LocateEntity<SeUser>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUser), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeUserIdSource = tmpEntity;
				else
					entity.SeUserIdSource = DataRepository.SeUserProvider.GetBySeUserId(transactionManager, (entity.SeUserId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeUserIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeUserProvider.DeepLoad(transactionManager, entity.SeUserIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeUserIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdOutcome object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdOutcome instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdOutcome Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdOutcome entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCdeOutcomeCatIdSource
			if (CanDeepSave(entity, "EdCdeOutcomeCat|EdCdeOutcomeCatIdSource", deepSaveType, innerList) 
				&& entity.EdCdeOutcomeCatIdSource != null)
			{
				DataRepository.EdCdeOutcomeCatProvider.Save(transactionManager, entity.EdCdeOutcomeCatIdSource);
				entity.EdCdeOutcomeCatId = entity.EdCdeOutcomeCatIdSource.EdCdeOutcomeCatId;
			}
			#endregion 
			
			#region EdCourseIdSource
			if (CanDeepSave(entity, "EdCourse|EdCourseIdSource", deepSaveType, innerList) 
				&& entity.EdCourseIdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseIdSource);
				entity.EdCourseId = entity.EdCourseIdSource.EdCourseId;
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
			
			#region SeUserIdSource
			if (CanDeepSave(entity, "SeUser|SeUserIdSource", deepSaveType, innerList) 
				&& entity.SeUserIdSource != null)
			{
				DataRepository.SeUserProvider.Save(transactionManager, entity.SeUserIdSource);
				entity.SeUserId = entity.SeUserIdSource.SeUserId;
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
	
	#region EdOutcomeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdOutcome</c>
	///</summary>
	public enum EdOutcomeChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCdeOutcomeCat</c> at EdCdeOutcomeCatIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeOutcomeCat))]
		EdCdeOutcomeCat,
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at SeUserIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
	}
	
	#endregion EdOutcomeChildEntityTypes
	
	#region EdOutcomeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdOutcomeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdOutcome"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdOutcomeFilterBuilder : SqlFilterBuilder<EdOutcomeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdOutcomeFilterBuilder class.
		/// </summary>
		public EdOutcomeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdOutcomeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdOutcomeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdOutcomeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdOutcomeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdOutcomeFilterBuilder
	
	#region EdOutcomeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdOutcomeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdOutcome"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdOutcomeParameterBuilder : ParameterizedSqlFilterBuilder<EdOutcomeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdOutcomeParameterBuilder class.
		/// </summary>
		public EdOutcomeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdOutcomeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdOutcomeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdOutcomeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdOutcomeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdOutcomeParameterBuilder
	
	#region EdOutcomeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdOutcomeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdOutcome"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdOutcomeSortBuilder : SqlSortBuilder<EdOutcomeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdOutcomeSqlSortBuilder class.
		/// </summary>
		public EdOutcomeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdOutcomeSortBuilder
	
} // end namespace
