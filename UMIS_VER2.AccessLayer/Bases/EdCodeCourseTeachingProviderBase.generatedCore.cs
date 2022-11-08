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
	/// This class is the base class for any <see cref="EdCodeCourseTeachingProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCodeCourseTeachingProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCodeCourseTeaching, UMIS_VER2.BusinessLyer.EdCodeCourseTeachingKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeCourseTeachingKey key)
		{
			return Delete(transactionManager, key.EdCodeCourseTeachingId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCodeCourseTeachingId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCodeCourseTeachingId)
		{
			return Delete(null, _edCodeCourseTeachingId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTeachingId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCodeCourseTeachingId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_COURSE_TEACHING_ED_CDE_TCHNG_MTHD key.
		///		FK_ED_CODE_COURSE_TEACHING_ED_CDE_TCHNG_MTHD Description: 
		/// </summary>
		/// <param name="_edCdeTchngMthdId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeCourseTeaching objects.</returns>
		public TList<EdCodeCourseTeaching> GetByEdCdeTchngMthdId(System.Decimal? _edCdeTchngMthdId)
		{
			int count = -1;
			return GetByEdCdeTchngMthdId(_edCdeTchngMthdId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_COURSE_TEACHING_ED_CDE_TCHNG_MTHD key.
		///		FK_ED_CODE_COURSE_TEACHING_ED_CDE_TCHNG_MTHD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeTchngMthdId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeCourseTeaching objects.</returns>
		/// <remarks></remarks>
		public TList<EdCodeCourseTeaching> GetByEdCdeTchngMthdId(TransactionManager transactionManager, System.Decimal? _edCdeTchngMthdId)
		{
			int count = -1;
			return GetByEdCdeTchngMthdId(transactionManager, _edCdeTchngMthdId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_COURSE_TEACHING_ED_CDE_TCHNG_MTHD key.
		///		FK_ED_CODE_COURSE_TEACHING_ED_CDE_TCHNG_MTHD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeTchngMthdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeCourseTeaching objects.</returns>
		public TList<EdCodeCourseTeaching> GetByEdCdeTchngMthdId(TransactionManager transactionManager, System.Decimal? _edCdeTchngMthdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeTchngMthdId(transactionManager, _edCdeTchngMthdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_COURSE_TEACHING_ED_CDE_TCHNG_MTHD key.
		///		fkEdCodeCourseTeachingEdCdeTchngMthd Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeTchngMthdId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeCourseTeaching objects.</returns>
		public TList<EdCodeCourseTeaching> GetByEdCdeTchngMthdId(System.Decimal? _edCdeTchngMthdId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeTchngMthdId(null, _edCdeTchngMthdId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_COURSE_TEACHING_ED_CDE_TCHNG_MTHD key.
		///		fkEdCodeCourseTeachingEdCdeTchngMthd Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeTchngMthdId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeCourseTeaching objects.</returns>
		public TList<EdCodeCourseTeaching> GetByEdCdeTchngMthdId(System.Decimal? _edCdeTchngMthdId, int start, int pageLength,out int count)
		{
			return GetByEdCdeTchngMthdId(null, _edCdeTchngMthdId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_COURSE_TEACHING_ED_CDE_TCHNG_MTHD key.
		///		FK_ED_CODE_COURSE_TEACHING_ED_CDE_TCHNG_MTHD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeTchngMthdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeCourseTeaching objects.</returns>
		public abstract TList<EdCodeCourseTeaching> GetByEdCdeTchngMthdId(TransactionManager transactionManager, System.Decimal? _edCdeTchngMthdId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdCodeCourseTeaching Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeCourseTeachingKey key, int start, int pageLength)
		{
			return GetByEdCodeCourseTeachingId(transactionManager, key.EdCodeCourseTeachingId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCodeCourseTeaching&gt;"/> class.</returns>
		public TList<EdCodeCourseTeaching> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCodeCourseTeaching&gt;"/> class.</returns>
		public TList<EdCodeCourseTeaching> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCodeCourseTeaching&gt;"/> class.</returns>
		public TList<EdCodeCourseTeaching> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCodeCourseTeaching&gt;"/> class.</returns>
		public TList<EdCodeCourseTeaching> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCodeCourseTeaching&gt;"/> class.</returns>
		public TList<EdCodeCourseTeaching> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCodeCourseTeaching&gt;"/> class.</returns>
		public abstract TList<EdCodeCourseTeaching> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CODE_SUBJECT_TEACHING index.
		/// </summary>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseTeaching"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseTeaching GetByEdCodeCourseTeachingId(System.Decimal _edCodeCourseTeachingId)
		{
			int count = -1;
			return GetByEdCodeCourseTeachingId(null,_edCodeCourseTeachingId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_SUBJECT_TEACHING index.
		/// </summary>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseTeaching"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseTeaching GetByEdCodeCourseTeachingId(System.Decimal _edCodeCourseTeachingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseTeachingId(null, _edCodeCourseTeachingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_SUBJECT_TEACHING index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseTeaching"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseTeaching GetByEdCodeCourseTeachingId(TransactionManager transactionManager, System.Decimal _edCodeCourseTeachingId)
		{
			int count = -1;
			return GetByEdCodeCourseTeachingId(transactionManager, _edCodeCourseTeachingId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_SUBJECT_TEACHING index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseTeaching"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseTeaching GetByEdCodeCourseTeachingId(TransactionManager transactionManager, System.Decimal _edCodeCourseTeachingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseTeachingId(transactionManager, _edCodeCourseTeachingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_SUBJECT_TEACHING index.
		/// </summary>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseTeaching"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseTeaching GetByEdCodeCourseTeachingId(System.Decimal _edCodeCourseTeachingId, int start, int pageLength, out int count)
		{
			return GetByEdCodeCourseTeachingId(null, _edCodeCourseTeachingId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_SUBJECT_TEACHING index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseTeaching"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCodeCourseTeaching GetByEdCodeCourseTeachingId(TransactionManager transactionManager, System.Decimal _edCodeCourseTeachingId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_CODE_COURSE_TEACHING index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_edCdeTchngMthdId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseTeaching"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseTeaching GetByAsFacultyInfoIdEdCdeTchngMthdId(System.Decimal? _asFacultyInfoId, System.Decimal? _edCdeTchngMthdId)
		{
			int count = -1;
			return GetByAsFacultyInfoIdEdCdeTchngMthdId(null,_asFacultyInfoId, _edCdeTchngMthdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_CODE_COURSE_TEACHING index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_edCdeTchngMthdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseTeaching"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseTeaching GetByAsFacultyInfoIdEdCdeTchngMthdId(System.Decimal? _asFacultyInfoId, System.Decimal? _edCdeTchngMthdId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoIdEdCdeTchngMthdId(null, _asFacultyInfoId, _edCdeTchngMthdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_CODE_COURSE_TEACHING index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_edCdeTchngMthdId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseTeaching"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseTeaching GetByAsFacultyInfoIdEdCdeTchngMthdId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal? _edCdeTchngMthdId)
		{
			int count = -1;
			return GetByAsFacultyInfoIdEdCdeTchngMthdId(transactionManager, _asFacultyInfoId, _edCdeTchngMthdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_CODE_COURSE_TEACHING index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_edCdeTchngMthdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseTeaching"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseTeaching GetByAsFacultyInfoIdEdCdeTchngMthdId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal? _edCdeTchngMthdId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoIdEdCdeTchngMthdId(transactionManager, _asFacultyInfoId, _edCdeTchngMthdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_CODE_COURSE_TEACHING index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_edCdeTchngMthdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseTeaching"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseTeaching GetByAsFacultyInfoIdEdCdeTchngMthdId(System.Decimal? _asFacultyInfoId, System.Decimal? _edCdeTchngMthdId, int start, int pageLength, out int count)
		{
			return GetByAsFacultyInfoIdEdCdeTchngMthdId(null, _asFacultyInfoId, _edCdeTchngMthdId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_CODE_COURSE_TEACHING index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_edCdeTchngMthdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseTeaching"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCodeCourseTeaching GetByAsFacultyInfoIdEdCdeTchngMthdId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal? _edCdeTchngMthdId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCodeCourseTeaching&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCodeCourseTeaching&gt;"/></returns>
		public static TList<EdCodeCourseTeaching> Fill(IDataReader reader, TList<EdCodeCourseTeaching> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCodeCourseTeaching c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCodeCourseTeaching")
					.Append("|").Append((System.Decimal)reader["ED_CODE_COURSE_TEACHING_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCodeCourseTeaching>(
					key.ToString(), // EntityTrackingKey
					"EdCodeCourseTeaching",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCodeCourseTeaching();
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
					c.EdCodeCourseTeachingId = (System.Decimal)reader["ED_CODE_COURSE_TEACHING_ID"];
					c.OriginalEdCodeCourseTeachingId = c.EdCodeCourseTeachingId;
					c.MethodOrder = (System.Decimal)reader["METHOD_ORDER"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.EdCdeTchngMthdId = Convert.IsDBNull(reader["ED_CDE_TCHNG_MTHD_ID"]) ? null : (System.Decimal?)reader["ED_CDE_TCHNG_MTHD_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseTeaching"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseTeaching"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCodeCourseTeaching entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCodeCourseTeachingId = (System.Decimal)reader[((int)EdCodeCourseTeachingColumn.EdCodeCourseTeachingId - 1)];
			entity.OriginalEdCodeCourseTeachingId = (System.Decimal)reader["ED_CODE_COURSE_TEACHING_ID"];
			entity.MethodOrder = (System.Decimal)reader[((int)EdCodeCourseTeachingColumn.MethodOrder - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)EdCodeCourseTeachingColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)EdCodeCourseTeachingColumn.AsFacultyInfoId - 1)];
			entity.EdCdeTchngMthdId = (reader.IsDBNull(((int)EdCodeCourseTeachingColumn.EdCdeTchngMthdId - 1)))?null:(System.Decimal?)reader[((int)EdCodeCourseTeachingColumn.EdCdeTchngMthdId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseTeaching"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseTeaching"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCodeCourseTeaching entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCodeCourseTeachingId = (System.Decimal)dataRow["ED_CODE_COURSE_TEACHING_ID"];
			entity.OriginalEdCodeCourseTeachingId = (System.Decimal)dataRow["ED_CODE_COURSE_TEACHING_ID"];
			entity.MethodOrder = (System.Decimal)dataRow["METHOD_ORDER"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.EdCdeTchngMthdId = Convert.IsDBNull(dataRow["ED_CDE_TCHNG_MTHD_ID"]) ? null : (System.Decimal?)dataRow["ED_CDE_TCHNG_MTHD_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseTeaching"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeCourseTeaching Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeCourseTeaching entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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

			#region EdCdeTchngMthdIdSource	
			if (CanDeepLoad(entity, "EdCdeTchngMthd|EdCdeTchngMthdIdSource", deepLoadType, innerList) 
				&& entity.EdCdeTchngMthdIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCdeTchngMthdId ?? 0.0m);
				EdCdeTchngMthd tmpEntity = EntityManager.LocateEntity<EdCdeTchngMthd>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeTchngMthd), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCdeTchngMthdIdSource = tmpEntity;
				else
					entity.EdCdeTchngMthdIdSource = DataRepository.EdCdeTchngMthdProvider.GetByEdCdeTchngMthdId(transactionManager, (entity.EdCdeTchngMthdId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeTchngMthdIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCdeTchngMthdIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCdeTchngMthdProvider.DeepLoad(transactionManager, entity.EdCdeTchngMthdIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCdeTchngMthdIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCodeCourseTeachingId methods when available
			
			#region ScSchdlSlotCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScSchdlSlot>|ScSchdlSlotCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScSchdlSlotCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScSchdlSlotCollection = DataRepository.ScSchdlSlotProvider.GetByEdCodeCourseTeachingId(transactionManager, entity.EdCodeCourseTeachingId);

				if (deep && entity.ScSchdlSlotCollection.Count > 0)
				{
					deepHandles.Add("ScSchdlSlotCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScSchdlSlot>) DataRepository.ScSchdlSlotProvider.DeepLoad,
						new object[] { transactionManager, entity.ScSchdlSlotCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicyAbsenceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyAbsence>|EntPolicyAbsenceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyAbsenceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyAbsenceCollection = DataRepository.EntPolicyAbsenceProvider.GetByEdCodeCourseTeachingId(transactionManager, entity.EdCodeCourseTeachingId);

				if (deep && entity.EntPolicyAbsenceCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyAbsence>) DataRepository.EntPolicyAbsenceProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyAbsenceCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdStudAbsenceCollection = DataRepository.EdStudAbsenceProvider.GetByEdCodeCourseTeachingId(transactionManager, entity.EdCodeCourseTeachingId);

				if (deep && entity.EdStudAbsenceCollection.Count > 0)
				{
					deepHandles.Add("EdStudAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudAbsence>) DataRepository.EdStudAbsenceProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudAbsenceCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.ScScheduleDtlExtStfCollection = DataRepository.ScScheduleDtlExtStfProvider.GetByEdCodeCourseTeachingId(transactionManager, entity.EdCodeCourseTeachingId);

				if (deep && entity.ScScheduleDtlExtStfCollection.Count > 0)
				{
					deepHandles.Add("ScScheduleDtlExtStfCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScScheduleDtlExtStf>) DataRepository.ScScheduleDtlExtStfProvider.DeepLoad,
						new object[] { transactionManager, entity.ScScheduleDtlExtStfCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScScheduleHdrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScScheduleHdr>|ScScheduleHdrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScScheduleHdrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScScheduleHdrCollection = DataRepository.ScScheduleHdrProvider.GetByEdCodeCourseTeachingId(transactionManager, entity.EdCodeCourseTeachingId);

				if (deep && entity.ScScheduleHdrCollection.Count > 0)
				{
					deepHandles.Add("ScScheduleHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScScheduleHdr>) DataRepository.ScScheduleHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.ScScheduleHdrCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdStudLatenessCollection = DataRepository.EdStudLatenessProvider.GetByEdCodeCourseTeachingId(transactionManager, entity.EdCodeCourseTeachingId);

				if (deep && entity.EdStudLatenessCollection.Count > 0)
				{
					deepHandles.Add("EdStudLatenessCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudLateness>) DataRepository.EdStudLatenessProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudLatenessCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdTopicTchngCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdTopicTchng>|EdTopicTchngCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdTopicTchngCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdTopicTchngCollection = DataRepository.EdTopicTchngProvider.GetByEdCodeCourseTeachingId(transactionManager, entity.EdCodeCourseTeachingId);

				if (deep && entity.EdTopicTchngCollection.Count > 0)
				{
					deepHandles.Add("EdTopicTchngCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdTopicTchng>) DataRepository.EdTopicTchngProvider.DeepLoad,
						new object[] { transactionManager, entity.EdTopicTchngCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScScheduleDtlDayCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScScheduleDtlDay>|ScScheduleDtlDayCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScScheduleDtlDayCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScScheduleDtlDayCollection = DataRepository.ScScheduleDtlDayProvider.GetByEdCodeCourseTeachingId(transactionManager, entity.EdCodeCourseTeachingId);

				if (deep && entity.ScScheduleDtlDayCollection.Count > 0)
				{
					deepHandles.Add("ScScheduleDtlDayCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScScheduleDtlDay>) DataRepository.ScScheduleDtlDayProvider.DeepLoad,
						new object[] { transactionManager, entity.ScScheduleDtlDayCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCourseTchngCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourseTchng>|EdCourseTchngCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseTchngCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseTchngCollection = DataRepository.EdCourseTchngProvider.GetByEdCodeCourseTeachingId(transactionManager, entity.EdCodeCourseTeachingId);

				if (deep && entity.EdCourseTchngCollection.Count > 0)
				{
					deepHandles.Add("EdCourseTchngCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourseTchng>) DataRepository.EdCourseTchngProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseTchngCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCodeCourseTeaching object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCodeCourseTeaching instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeCourseTeaching Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeCourseTeaching entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AsFacultyInfoIdSource
			if (CanDeepSave(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepSaveType, innerList) 
				&& entity.AsFacultyInfoIdSource != null)
			{
				DataRepository.AsFacultyInfoProvider.Save(transactionManager, entity.AsFacultyInfoIdSource);
				entity.AsFacultyInfoId = entity.AsFacultyInfoIdSource.AsFacultyInfoId;
			}
			#endregion 
			
			#region EdCdeTchngMthdIdSource
			if (CanDeepSave(entity, "EdCdeTchngMthd|EdCdeTchngMthdIdSource", deepSaveType, innerList) 
				&& entity.EdCdeTchngMthdIdSource != null)
			{
				DataRepository.EdCdeTchngMthdProvider.Save(transactionManager, entity.EdCdeTchngMthdIdSource);
				entity.EdCdeTchngMthdId = entity.EdCdeTchngMthdIdSource.EdCdeTchngMthdId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<ScSchdlSlot>
				if (CanDeepSave(entity.ScSchdlSlotCollection, "List<ScSchdlSlot>|ScSchdlSlotCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScSchdlSlot child in entity.ScSchdlSlotCollection)
					{
						if(child.EdCodeCourseTeachingIdSource != null)
						{
							child.EdCodeCourseTeachingId = child.EdCodeCourseTeachingIdSource.EdCodeCourseTeachingId;
						}
						else
						{
							child.EdCodeCourseTeachingId = entity.EdCodeCourseTeachingId;
						}

					}

					if (entity.ScSchdlSlotCollection.Count > 0 || entity.ScSchdlSlotCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScSchdlSlotProvider.Save(transactionManager, entity.ScSchdlSlotCollection);
						
						deepHandles.Add("ScSchdlSlotCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScSchdlSlot >) DataRepository.ScSchdlSlotProvider.DeepSave,
							new object[] { transactionManager, entity.ScSchdlSlotCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolicyAbsence>
				if (CanDeepSave(entity.EntPolicyAbsenceCollection, "List<EntPolicyAbsence>|EntPolicyAbsenceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyAbsence child in entity.EntPolicyAbsenceCollection)
					{
						if(child.EdCodeCourseTeachingIdSource != null)
						{
							child.EdCodeCourseTeachingId = child.EdCodeCourseTeachingIdSource.EdCodeCourseTeachingId;
						}
						else
						{
							child.EdCodeCourseTeachingId = entity.EdCodeCourseTeachingId;
						}

					}

					if (entity.EntPolicyAbsenceCollection.Count > 0 || entity.EntPolicyAbsenceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyAbsenceProvider.Save(transactionManager, entity.EntPolicyAbsenceCollection);
						
						deepHandles.Add("EntPolicyAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyAbsence >) DataRepository.EntPolicyAbsenceProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyAbsenceCollection, deepSaveType, childTypes, innerList }
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
						if(child.EdCodeCourseTeachingIdSource != null)
						{
							child.EdCodeCourseTeachingId = child.EdCodeCourseTeachingIdSource.EdCodeCourseTeachingId;
						}
						else
						{
							child.EdCodeCourseTeachingId = entity.EdCodeCourseTeachingId;
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
				
	
			#region List<ScScheduleDtlExtStf>
				if (CanDeepSave(entity.ScScheduleDtlExtStfCollection, "List<ScScheduleDtlExtStf>|ScScheduleDtlExtStfCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScScheduleDtlExtStf child in entity.ScScheduleDtlExtStfCollection)
					{
						if(child.EdCodeCourseTeachingIdSource != null)
						{
							child.EdCodeCourseTeachingId = child.EdCodeCourseTeachingIdSource.EdCodeCourseTeachingId;
						}
						else
						{
							child.EdCodeCourseTeachingId = entity.EdCodeCourseTeachingId;
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
				
	
			#region List<ScScheduleHdr>
				if (CanDeepSave(entity.ScScheduleHdrCollection, "List<ScScheduleHdr>|ScScheduleHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScScheduleHdr child in entity.ScScheduleHdrCollection)
					{
						if(child.EdCodeCourseTeachingIdSource != null)
						{
							child.EdCodeCourseTeachingId = child.EdCodeCourseTeachingIdSource.EdCodeCourseTeachingId;
						}
						else
						{
							child.EdCodeCourseTeachingId = entity.EdCodeCourseTeachingId;
						}

					}

					if (entity.ScScheduleHdrCollection.Count > 0 || entity.ScScheduleHdrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScScheduleHdrProvider.Save(transactionManager, entity.ScScheduleHdrCollection);
						
						deepHandles.Add("ScScheduleHdrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScScheduleHdr >) DataRepository.ScScheduleHdrProvider.DeepSave,
							new object[] { transactionManager, entity.ScScheduleHdrCollection, deepSaveType, childTypes, innerList }
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
						if(child.EdCodeCourseTeachingIdSource != null)
						{
							child.EdCodeCourseTeachingId = child.EdCodeCourseTeachingIdSource.EdCodeCourseTeachingId;
						}
						else
						{
							child.EdCodeCourseTeachingId = entity.EdCodeCourseTeachingId;
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
				
	
			#region List<EdTopicTchng>
				if (CanDeepSave(entity.EdTopicTchngCollection, "List<EdTopicTchng>|EdTopicTchngCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdTopicTchng child in entity.EdTopicTchngCollection)
					{
						if(child.EdCodeCourseTeachingIdSource != null)
						{
							child.EdCodeCourseTeachingId = child.EdCodeCourseTeachingIdSource.EdCodeCourseTeachingId;
						}
						else
						{
							child.EdCodeCourseTeachingId = entity.EdCodeCourseTeachingId;
						}

					}

					if (entity.EdTopicTchngCollection.Count > 0 || entity.EdTopicTchngCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdTopicTchngProvider.Save(transactionManager, entity.EdTopicTchngCollection);
						
						deepHandles.Add("EdTopicTchngCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdTopicTchng >) DataRepository.EdTopicTchngProvider.DeepSave,
							new object[] { transactionManager, entity.EdTopicTchngCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScScheduleDtlDay>
				if (CanDeepSave(entity.ScScheduleDtlDayCollection, "List<ScScheduleDtlDay>|ScScheduleDtlDayCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScScheduleDtlDay child in entity.ScScheduleDtlDayCollection)
					{
						if(child.EdCodeCourseTeachingIdSource != null)
						{
							child.EdCodeCourseTeachingId = child.EdCodeCourseTeachingIdSource.EdCodeCourseTeachingId;
						}
						else
						{
							child.EdCodeCourseTeachingId = entity.EdCodeCourseTeachingId;
						}

					}

					if (entity.ScScheduleDtlDayCollection.Count > 0 || entity.ScScheduleDtlDayCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScScheduleDtlDayProvider.Save(transactionManager, entity.ScScheduleDtlDayCollection);
						
						deepHandles.Add("ScScheduleDtlDayCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScScheduleDtlDay >) DataRepository.ScScheduleDtlDayProvider.DeepSave,
							new object[] { transactionManager, entity.ScScheduleDtlDayCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCourseTchng>
				if (CanDeepSave(entity.EdCourseTchngCollection, "List<EdCourseTchng>|EdCourseTchngCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourseTchng child in entity.EdCourseTchngCollection)
					{
						if(child.EdCodeCourseTeachingIdSource != null)
						{
							child.EdCodeCourseTeachingId = child.EdCodeCourseTeachingIdSource.EdCodeCourseTeachingId;
						}
						else
						{
							child.EdCodeCourseTeachingId = entity.EdCodeCourseTeachingId;
						}

					}

					if (entity.EdCourseTchngCollection.Count > 0 || entity.EdCourseTchngCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseTchngProvider.Save(transactionManager, entity.EdCourseTchngCollection);
						
						deepHandles.Add("EdCourseTchngCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourseTchng >) DataRepository.EdCourseTchngProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseTchngCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCodeCourseTeachingChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCodeCourseTeaching</c>
	///</summary>
	public enum EdCodeCourseTeachingChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>EdCdeTchngMthd</c> at EdCdeTchngMthdIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeTchngMthd))]
		EdCdeTchngMthd,
		///<summary>
		/// Collection of <c>EdCodeCourseTeaching</c> as OneToMany for ScSchdlSlotCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScSchdlSlot>))]
		ScSchdlSlotCollection,
		///<summary>
		/// Collection of <c>EdCodeCourseTeaching</c> as OneToMany for EntPolicyAbsenceCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyAbsence>))]
		EntPolicyAbsenceCollection,
		///<summary>
		/// Collection of <c>EdCodeCourseTeaching</c> as OneToMany for EdStudAbsenceCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudAbsence>))]
		EdStudAbsenceCollection,
		///<summary>
		/// Collection of <c>EdCodeCourseTeaching</c> as OneToMany for ScScheduleDtlExtStfCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScScheduleDtlExtStf>))]
		ScScheduleDtlExtStfCollection,
		///<summary>
		/// Collection of <c>EdCodeCourseTeaching</c> as OneToMany for ScScheduleHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScScheduleHdr>))]
		ScScheduleHdrCollection,
		///<summary>
		/// Collection of <c>EdCodeCourseTeaching</c> as OneToMany for EdStudLatenessCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudLateness>))]
		EdStudLatenessCollection,
		///<summary>
		/// Collection of <c>EdCodeCourseTeaching</c> as OneToMany for EdTopicTchngCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdTopicTchng>))]
		EdTopicTchngCollection,
		///<summary>
		/// Collection of <c>EdCodeCourseTeaching</c> as OneToMany for ScScheduleDtlDayCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScScheduleDtlDay>))]
		ScScheduleDtlDayCollection,
		///<summary>
		/// Collection of <c>EdCodeCourseTeaching</c> as OneToMany for EdCourseTchngCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourseTchng>))]
		EdCourseTchngCollection,
	}
	
	#endregion EdCodeCourseTeachingChildEntityTypes
	
	#region EdCodeCourseTeachingFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCodeCourseTeachingColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeCourseTeaching"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeCourseTeachingFilterBuilder : SqlFilterBuilder<EdCodeCourseTeachingColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseTeachingFilterBuilder class.
		/// </summary>
		public EdCodeCourseTeachingFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseTeachingFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeCourseTeachingFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseTeachingFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeCourseTeachingFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeCourseTeachingFilterBuilder
	
	#region EdCodeCourseTeachingParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCodeCourseTeachingColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeCourseTeaching"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeCourseTeachingParameterBuilder : ParameterizedSqlFilterBuilder<EdCodeCourseTeachingColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseTeachingParameterBuilder class.
		/// </summary>
		public EdCodeCourseTeachingParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseTeachingParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeCourseTeachingParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseTeachingParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeCourseTeachingParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeCourseTeachingParameterBuilder
	
	#region EdCodeCourseTeachingSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCodeCourseTeachingColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeCourseTeaching"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCodeCourseTeachingSortBuilder : SqlSortBuilder<EdCodeCourseTeachingColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseTeachingSqlSortBuilder class.
		/// </summary>
		public EdCodeCourseTeachingSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCodeCourseTeachingSortBuilder
	
} // end namespace
